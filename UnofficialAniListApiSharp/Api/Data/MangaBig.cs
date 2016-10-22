using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnofficialAniListApiSharp.Api.Other;

namespace UnofficialAniListApiSharp.Api.Data
{
    public class MangaBig : Manga
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("image_url_banner")]
        public object ImageUrlBanner { get; set; }

        [JsonProperty("list_stats")]
        public MangaStats ListStats { get; set; }
    }
}