using Newtonsoft.Json;

namespace UnofficialAniListApiSharp.Api.Other
{
    public class Airing
    {
        [JsonProperty("time")]
        public string Time { get; set; }
        [JsonProperty("countdown")]
        public int Countdown { get; set; }
        [JsonProperty("next_episode")]
        public int NextEpisode { get; set; }
    }
}
