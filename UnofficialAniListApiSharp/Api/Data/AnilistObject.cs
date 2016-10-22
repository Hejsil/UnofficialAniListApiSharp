using Newtonsoft.Json;

namespace UnofficialAniListApiSharp.Api.Data
{
    public class AnilistObject
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
