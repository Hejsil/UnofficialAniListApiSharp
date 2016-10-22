using System.Collections.Generic;
using Newtonsoft.Json;

namespace UnofficialAniListApiSharp.Api.Data
{
    public class Manga : AnilistObject
    {
        [JsonProperty("title_romaji")]
        public string TitleRomaji { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title_japanese")]
        public string TitleJapanese { get; set; }

        [JsonProperty("title_english")]
        public string TitleEnglish { get; set; }

        [JsonProperty("synonyms")]
        public List<object> Synonyms { get; set; }

        [JsonProperty("image_url_lge")]
        public string ImageUrlLge { get; set; }

        [JsonProperty("image_url_med")]
        public string ImageUrlMed { get; set; }

        [JsonProperty("publishing_status")]
        public string PublishingStatus { get; set; }

        [JsonProperty("average_score")]
        public string AverageScore { get; set; }

        [JsonProperty("total_chapters")]
        public int TotalChapters { get; set; }

        [JsonProperty("total_volumes")]
        public int TotalVolumes { get; set; }

        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("relation_type")]
        public object RelationType { get; set; }

        [JsonProperty("role")]
        public object Role { get; set; }
    }
}
