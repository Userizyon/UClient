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
        /// Returns all entities (mentions, hashtags, cashtags, bot commands, bank card numbers, URLs, and email addresses) contained in the text. Can be called synchronously
        /// </summary>
        public class GetTextEntities : Function<TextEntities>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getTextEntities";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// The text in which to look for entites
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("text")]
public string Text { get; set; }


        }

        /// <summary>
        /// Returns all entities (mentions, hashtags, cashtags, bot commands, bank card numbers, URLs, and email addresses) contained in the text. Can be called synchronously
        /// </summary>
        public static Task<TextEntities> GetTextEntitiesAsync(
            this Client client, string text = default)
        {
            return client.ExecuteAsync(new GetTextEntities
            {
                Text = text
            });
        }
    }
}
