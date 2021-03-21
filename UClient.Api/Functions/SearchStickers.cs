using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Searches for stickers from public sticker sets that correspond to a given emoji
        /// </summary>
        public class SearchStickers : Function<Stickers>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchStickers";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// String representation of emoji; must be non-empty
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("emoji")]
public string Emoji { get; set; }

/// <summary>
/// The maximum number of stickers to be returned
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("limit")]
public int Limit { get; set; }


        }

        /// <summary>
        /// Searches for stickers from public sticker sets that correspond to a given emoji
        /// </summary>
        public static Task<Stickers> SearchStickersAsync(
            this Client client, string emoji = default, int limit = default)
        {
            return client.ExecuteAsync(new SearchStickers
            {
                Emoji = emoji, Limit = limit
            });
        }
    }
}
