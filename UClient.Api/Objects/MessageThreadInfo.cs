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
        /// Contains information about a message thread
        /// </summary>
        public partial class MessageThreadInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "messageThreadInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Identifier of the chat to which the message thread belongs
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_id")]
public long ChatId { get; set; }

/// <summary>
/// Message thread identifier, unique within the chat
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("message_thread_id")]
public long MessageThreadId { get; set; }

/// <summary>
/// Contains information about the message thread
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("reply_info")]
public MessageReplyInfo ReplyInfo { get; set; }

/// <summary>
/// The messages from which the thread starts. The messages are returned in a reverse chronological order (i.e., in order of decreasing message_id)
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("messages")]
public Message[] Messages { get; set; }

/// <summary>
/// A draft of a message in the message thread; may be null
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("draft_message")]
public DraftMessage DraftMessage { get; set; }


        }
    }
}
