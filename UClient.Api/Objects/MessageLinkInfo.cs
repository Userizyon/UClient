using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Contains information about a link to a message in a chat
        /// </summary>
        public partial class MessageLinkInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "messageLinkInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// True, if the link is a public link for a message in a chat
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_public")]
public bool IsPublic { get; set; }

/// <summary>
/// If found, identifier of the chat to which the message belongs, 0 otherwise
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_id")]
public long ChatId { get; set; }

/// <summary>
/// If found, the linked message; may be null
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("message")]
public Message Message { get; set; }

/// <summary>
/// True, if the whole media album to which the message belongs is linked
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("for_album")]
public bool ForAlbum { get; set; }

/// <summary>
/// True, if the message is linked as a channel post comment or from a message thread
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("for_comment")]
public bool ForComment { get; set; }


        }
    }
}
