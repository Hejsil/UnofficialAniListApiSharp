using Newtonsoft.Json;

namespace UnofficialAniListApiSharp.Api.Data
{
    public class StaffBig : Staff
    {
        [JsonProperty("dob")]
        public int Dob { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("name_first_japanese")]
        public string NameFirstJapanese { get; set; }

        [JsonProperty("name_last_japanese")]
        public string NameLastJapanese { get; set; }
    }
}
