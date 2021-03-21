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
        /// Returns detailed statistics about a message. Can be used only if Message.can_get_statistics == true
        /// </summary>
        public class GetMessageStatistics : Function<MessageStatistics>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getMessageStatistics";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Chat identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_id")]
public long ChatId { get; set; }

/// <summary>
/// Message identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("message_id")]
public long MessageId { get; set; }

/// <summary>
/// Pass true if a dark theme is used by the application
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_dark")]
public bool IsDark { get; set; }


        }

        /// <summary>
        /// Returns detailed statistics about a message. Can be used only if Message.can_get_statistics == true
        /// </summary>
        public static Task<MessageStatistics> GetMessageStatisticsAsync(
            this Client client, long chatId = default, long messageId = default, bool isDark = default)
        {
            return client.ExecuteAsync(new GetMessageStatistics
            {
                ChatId = chatId, MessageId = messageId, IsDark = isDark
            });
        }
    }
}
