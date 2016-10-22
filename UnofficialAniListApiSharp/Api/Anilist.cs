using System;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using UnofficialAniListApiSharp.Api.Data;

namespace UnofficialAniListApiSharp.Api
{
    public enum Category
    {
        Anime,
        Manga,
        Character,
        Staff,
        Studio,
        User
    }

    public static class Anilist
    {
        static readonly RestClient _restClient = new RestClient("https://anilist.co/api/");
        
        public static Authentication GrantClientCredentials(string clientId, string clientSecret)
        {
            return RequestAndDeserialize<Authentication>(null, "auth/access_token", Method.POST,
                new
                {
                    grant_type = "client_credentials",
                    client_id = clientId,
                    client_secret = clientSecret
                });
        }

        public static IRestResponse Request(Authentication auth, string url, Method method, params object[] bodies)
        {
            var requent = new RestRequest(url, method) { RequestFormat = DataFormat.Json };

            if (auth != null)
                requent.AddHeader("Authorization", "Bearer " + auth.AccessToken);

            foreach (var body in bodies)
                requent.AddBody(body);

            return _restClient.Execute(requent);
        }

        public static T RequestAndDeserialize<T>(Authentication auth, string url, Method method, params object[] bodies) where T : class
        {
            var response = Request(auth, url, method, bodies);

            if (!Succeeded(response))
                return null;

            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public static IRestResponse Search(Authentication auth, Category category, string query)
        {
            string url;
            if (category != Category.User)
                url = GetCategoryString(category);
            else
                throw new NotImplementedException();

            return Request(auth, url + "/search/" + query, Method.GET);
        }

        public static T[] SearchAndDeserialize<T>(Authentication auth, Category category, string query) where T : AnilistObject
        {
            var response = Search(auth, category, query);

            if (!Succeeded(response))
                return null;

            return JsonConvert.DeserializeObject<T[]>(response.Content);
        }

        public static IRestResponse Get(Authentication auth, Category category, int id)
        {
            return Request(auth, GetCategoryString(category) + "/" + id, Method.GET);
        }

        public static T GetAndDeserialize<T>(Authentication auth, Category category, int id) where T : AnilistObject
        {
            var response = Get(auth, category, id);

            if (!Succeeded(response))
                return null;

            return JsonConvert.DeserializeObject<T>(response.Content);
        }
        
        public static IRestResponse Browse(Authentication auth, Category category, params string[] options)
        {
            string url;
            if (category == Category.Anime || category == Category.Manga)
                url = GetCategoryString(category);
            else
                throw new NotImplementedException();

            if (options.Length > 0)
            {
                url += "?" + string.Join("&", options);
            }

            return Request(auth, "browse/" + url, Method.GET);
        }

        public static T[] BrowseAndDeserialize<T>(Authentication auth, Category category, params string[] options) where T : AnilistObject
        {
            var response = Browse(auth, category, options);

            if (!Succeeded(response))
                return null;

            return JsonConvert.DeserializeObject<T[]>(response.Content);
        }

        static bool Succeeded(IRestResponse response)
        {
            return response.StatusCode == HttpStatusCode.OK &&
                   !string.IsNullOrEmpty(response.Content);
        }

        static string GetCategoryString(Category category)
        {
            switch (category)
            {
                case Category.Anime:
                    return "anime";
                case Category.Manga:
                    return "manga";
                case Category.Character:
                    return "character";
                case Category.Staff:
                    return "staff";
                case Category.Studio:
                    return "studio";
                case Category.User:
                    return "user";
                default:
                    return "";
            }
        }
    }
}
