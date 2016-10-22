using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnofficialAniListApiSharp.Api.Other;

namespace UnofficialAniListApiSharp.Api.Data
{
    public class AnimeBig : Anime
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("hashtag")]
        public object Hashtag { get; set; }

        [JsonProperty("source")]
        public object Source { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("image_url_banner")]
        public string ImageUrlBanner { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("youtube_id")]
        public object YoutubeId { get; set; }

        [JsonProperty("list_stats")]
        public AnimeStats ListStats { get; set; }

        [JsonProperty("airing")]
        public Airing Airing { get; set; }
    }
}
