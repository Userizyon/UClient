using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class ChatSource : Object
        {
            /// <summary>
            /// The chat contains a public service announcement
            /// </summary>
            public class ChatSourcePublicServiceAnnouncement : ChatSource
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatSourcePublicServiceAnnouncement";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// The type of the announcement
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("type")]
public string Type { get; set; }

/// <summary>
/// The text of the announcement
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("text")]
public string Text { get; set; }


            }
        }
    }
}
