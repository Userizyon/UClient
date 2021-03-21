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
        /// Returns information about a sticker set by its identifier
        /// </summary>
        public class GetStickerSet : Function<StickerSet>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getStickerSet";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Identifier of the sticker set
/// </summary>
[JsonConverter(typeof(Converter.Int64))]
[JsonProperty("set_id")]
public long SetId { get; set; }


        }

        /// <summary>
        /// Returns information about a sticker set by its identifier
        /// </summary>
        public static Task<StickerSet> GetStickerSetAsync(
            this Client client, long setId = default)
        {
            return client.ExecuteAsync(new GetStickerSet
            {
                SetId = setId
            });
        }
    }
}
