using Newtonsoft.Json;

namespace UnofficialAniListApiSharp.Api.Other
{
    public class MangaStats : ListStats
    {
        [JsonProperty("reading")]
        public int Reading { get; set; }

        [JsonProperty("plan_to_read")]
        public int PlanToRead { get; set; }
    }
}
