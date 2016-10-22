using Newtonsoft.Json;

namespace UnofficialAniListApiSharp.Api.Other
{
    public class ListStats
    {
        [JsonProperty("completed")]
        public int Completed { get; set; }

        [JsonProperty("on_hold")]
        public int OnHold { get; set; }
        [JsonProperty("dropped")]
        public int Dropped { get; set; }
    }
}
