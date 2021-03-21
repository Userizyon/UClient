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
        /// Uploads a PNG image with a sticker; for bots only; returns the uploaded file
        /// </summary>
        public class UploadStickerFile : Function<File>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "uploadStickerFile";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Sticker file owner
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user_id")]
public int UserId { get; set; }

/// <summary>
/// PNG image with the sticker; must be up to 512 KB in size and fit in 512x512 square
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("png_sticker")]
public InputFile PngSticker { get; set; }


        }

        /// <summary>
        /// Uploads a PNG image with a sticker; for bots only; returns the uploaded file
        /// </summary>
        public static Task<File> UploadStickerFileAsync(
            this Client client, int userId = default, InputFile pngSticker = default)
        {
            return client.ExecuteAsync(new UploadStickerFile
            {
                UserId = userId, PngSticker = pngSticker
            });
        }
    }
}
