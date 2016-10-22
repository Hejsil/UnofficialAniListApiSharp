using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnofficialAniListApiSharp.Api;
using UnofficialAniListApiSharp.Api.Data;

namespace UnofficialAniListApiSharp.Client
{
    public class AnilistClient
    {
        Authentication _auth;
        DateTime _nextUpdate;
        readonly string _clientId;
        readonly string _clientSecret;

        public AnilistClient(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        public T Get<T>(Category category, int id) where T : AnilistObject
        {
            UpdateAuth();
            return Anilist.GetAndDeserialize<T>(_auth, category, id);
        }

        public T[] Search<T>(Category category, string query) where T : AnilistObject
        {
            UpdateAuth();
            return Anilist.SearchAndDeserialize<T>(_auth, category, query);
        }

        public T[] Browse<T>(Category category, params string[] options) where T : AnilistObject
        {
            UpdateAuth();
            return Anilist.BrowseAndDeserialize<T>(_auth, category, options);
        }

        void UpdateAuth()
        {
            if (_auth != null && _nextUpdate >= DateTime.Now)
                return;

            _nextUpdate = DateTime.Now + new TimeSpan(1, 0, 0);
            _auth = Anilist.GrantClientCredentials(_clientId, _clientSecret);
        }
    }
}
