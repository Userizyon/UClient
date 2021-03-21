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
            /// A video message
            /// </summary>
            public class PushMessageContentVideo : PushMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pushMessageContentVideo";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Message content; may be null
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("video")]
public Video Video { get; set; }

/// <summary>
/// Video caption
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("caption")]
public string Caption { get; set; }

/// <summary>
/// True, if the video is secret
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_secret")]
public bool IsSecret { get; set; }

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