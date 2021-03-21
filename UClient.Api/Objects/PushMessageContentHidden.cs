using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class PushMessageContent : Object
        {
            /// <summary>
            /// Contains content of a push message notification
            /// </summary>
            public class PushMessageContentHidden : PushMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pushMessageContentHidden";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// True, if the message is a pinned message with the specified content
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_pinned")]
public bool IsPinned { get; set; }


            }
        }
    }
}
