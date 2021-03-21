using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class MessageFileType : Object
        {
            /// <summary>
            /// The messages was exported from a group chat
            /// </summary>
            public class MessageFileTypeGroup : MessageFileType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageFileTypeGroup";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Title of the group chat; may be empty if unrecognized
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("title")]
public string Title { get; set; }


            }
        }
    }
}