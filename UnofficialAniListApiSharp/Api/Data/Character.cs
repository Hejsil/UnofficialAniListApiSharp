using Newtonsoft.Json;

namespace UnofficialAniListApiSharp.Api.Data
{
    public class Character : AnilistObject
    {
        [JsonProperty("name_first")]
        public string NameFirst { get; set; }

        [JsonProperty("name_last")]
        public string NameLast { get; set; }

        [JsonProperty("image_url_lge")]
        public string ImageUrlLge { get; set; }

        [JsonProperty("image_url_med")]
        public string ImageUrlMed { get; set; }

        [JsonProperty("id_actor")]
        public object IdActor { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
