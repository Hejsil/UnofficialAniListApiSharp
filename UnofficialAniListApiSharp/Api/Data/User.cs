using System.Collections.Generic;
using Newtonsoft.Json;

namespace UnofficialAniListApiSharp.Api.Data
{
    public class User : AnilistObject
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("anime_time")]
        public int AnimeTime { get; set; }

        [JsonProperty("manga_chap")]
        public int MangaChap { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("list_order")]
        public int ListOrder { get; set; }

        [JsonProperty("adult_content")]
        public bool AdultContent { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("image_url_lge")]
        public string ImageUrlLge { get; set; }

        [JsonProperty("image_url_med")]
        public string ImageUrlMed { get; set; }

        [JsonProperty("image_url_banner")]
        public string ImageUrlBanner { get; set; }

        [JsonProperty("title_language")]
        public string TitleLanguage { get; set; }

        [JsonProperty("score_type")]
        public int ScoreType { get; set; }

        [JsonProperty("custom_list_anime")]
        public List<string> CustomListAnime { get; set; }

        [JsonProperty("custom_list_manga")]
        public List<string> CustomListManga { get; set; }

        [JsonProperty("advanced_rating")]
        public bool AdvancedRating { get; set; }

        [JsonProperty("advanced_rating_names")]
        public List<string> AdvancedRatingNames { get; set; }

        [JsonProperty("notifications")]
        public int Notifications { get; set; }
    }
}
