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
        /// Sends a callback query to a bot and returns an answer. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
        /// </summary>
        public class GetCallbackQueryAnswer : Function<CallbackQueryAnswer>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getCallbackQueryAnswer";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Identifier of the chat with the message
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_id")]
public long ChatId { get; set; }

/// <summary>
/// Identifier of the message from which the query originated
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("message_id")]
public long MessageId { get; set; }

/// <summary>
/// Query payload
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("payload")]
public CallbackQueryPayload Payload { get; set; }


        }

        /// <summary>
        /// Sends a callback query to a bot and returns an answer. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
        /// </summary>
        public static Task<CallbackQueryAnswer> GetCallbackQueryAnswerAsync(
            this Client client, long chatId = default, long messageId = default, CallbackQueryPayload payload = default)
        {
            return client.ExecuteAsync(new GetCallbackQueryAnswer
            {
                ChatId = chatId, MessageId = messageId, Payload = payload
            });
        }
    }
}
