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
        /// Removes a sticker from the set to which it belongs; for bots only. The sticker set must have been created by the bot
        /// </summary>
        public class RemoveStickerFromSet : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "removeStickerFromSet";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Sticker
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("sticker")]
public InputFile Sticker { get; set; }


        }

        /// <summary>
        /// Removes a sticker from the set to which it belongs; for bots only. The sticker set must have been created by the bot
        /// </summary>
        public static Task<Ok> RemoveStickerFromSetAsync(
            this Client client, InputFile sticker = default)
        {
            return client.ExecuteAsync(new RemoveStickerFromSet
            {
                Sticker = sticker
            });
        }
    }
}
