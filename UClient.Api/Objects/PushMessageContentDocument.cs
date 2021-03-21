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
            /// A document message (a general file)
            /// </summary>
            public class PushMessageContentDocument : PushMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pushMessageContentDocument";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Message content; may be null
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("document")]
public Document Document { get; set; }

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
