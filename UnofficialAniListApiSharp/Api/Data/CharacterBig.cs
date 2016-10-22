using Newtonsoft.Json;

namespace UnofficialAniListApiSharp.Api.Data
{
    public class CharacterBig : Character
    {
        [JsonProperty("name_alt")]
        public string NameAlt { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("name_japanese")]
        public string NameJapanese { get; set; }
    }
}
