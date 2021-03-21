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
        /// Returns approximate number of messages of the specified type in the chat
        /// </summary>
        public class GetChatMessageCount : Function<Count>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatMessageCount";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Identifier of the chat in which to count messages
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_id")]
public long ChatId { get; set; }

/// <summary>
/// Filter for message content; searchMessagesFilterEmpty is unsupported in this function
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("filter")]
public SearchMessagesFilter Filter { get; set; }

/// <summary>
/// If true, returns count that is available locally without sending network requests, returning -1 if the number of messages is unknown
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("return_local")]
public bool ReturnLocal { get; set; }


        }

        /// <summary>
        /// Returns approximate number of messages of the specified type in the chat
        /// </summary>
        public static Task<Count> GetChatMessageCountAsync(
            this Client client, long chatId = default, SearchMessagesFilter filter = default, bool returnLocal = default)
        {
            return client.ExecuteAsync(new GetChatMessageCount
            {
                ChatId = chatId, Filter = filter, ReturnLocal = returnLocal
            });
        }
    }
}
