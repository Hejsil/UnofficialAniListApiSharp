using Newtonsoft.Json;

namespace UnofficialAniListApiSharp.Api.Other
{
    public class AnimeStats : ListStats
    {
        [JsonProperty("plan_to_watch")]
        public int PlanToWatch { get; set; }

        [JsonProperty("watching")]
        public int Watching { get; set; }
    }
}
