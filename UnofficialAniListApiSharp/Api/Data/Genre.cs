using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UnofficialAniListApiSharp.Api.Data
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Genre
    {
        Action,
        Adventure,
        Cars,
        Comedy,
        Dementia,
        Demons,
        Drama,
        Ecchi,
        Fantasy,
        Game,
        Harem,
        Hentai,
        Historical,
        Horror,
        Josei,
        Kids,
        Magic,
        Mecha,
        Military,
        Music,
        Mystery,
        Parody,
        Police,
        Psychological,
        Romance,
        Samurai,
        School,
        Seinen,
        Shoujo,
        Shounen,
        Space,
        Sports,
        Supernatural,
        Thriller,
        Vampire,
        Yaoi,
        Yuri,

        [EnumMember(Value = "Martial Arts")]
        MartialArts,

        [EnumMember(Value = "Sci-Fi")]
        SciFi,

        [EnumMember(Value = "Shoujo Ai")]
        ShoujoAi,

        [EnumMember(Value = "Shounen Ai")]
        ShounenAi,

        [EnumMember(Value = "Slice of Life")]
        SliceofLife,

        [EnumMember(Value = "Super Power")]
        SuperPower
    }
}
