using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class ThumbnailFormat : Object
        {
            /// <summary>
            /// The thumbnail is in TGS format. It will be used only for animated sticker sets
            /// </summary>
            public class ThumbnailFormatTgs : ThumbnailFormat
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "thumbnailFormatTgs";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}
