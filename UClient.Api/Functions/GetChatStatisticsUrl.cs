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
        /// Returns an HTTP URL with the chat statistics. Currently this method of getting the statistics are disabled and can be deleted in the future
        /// </summary>
        public class GetChatStatisticsUrl : Function<HttpUrl>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatStatisticsUrl";

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
/// Parameters from "tg://statsrefresh?params=******" link
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("parameters")]
public string Parameters { get; set; }

/// <summary>
/// Pass true if a URL with the dark theme must be returned
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_dark")]
public bool IsDark { get; set; }


        }

        /// <summary>
        /// Returns an HTTP URL with the chat statistics. Currently this method of getting the statistics are disabled and can be deleted in the future
        /// </summary>
        public static Task<HttpUrl> GetChatStatisticsUrlAsync(
            this Client client, long chatId = default, string parameters = default, bool isDark = default)
        {
            return client.ExecuteAsync(new GetChatStatisticsUrl
            {
                ChatId = chatId, Parameters = parameters, IsDark = isDark
            });
        }
    }
}
