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
        /// Answers a custom query; for bots only
        /// </summary>
        public class AnswerCustomQuery : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "answerCustomQuery";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Identifier of a custom query
/// </summary>
[JsonConverter(typeof(Converter.Int64))]
[JsonProperty("custom_query_id")]
public long CustomQueryId { get; set; }

/// <summary>
/// JSON-serialized answer to the query
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("data")]
public string Data { get; set; }


        }

        /// <summary>
        /// Answers a custom query; for bots only
        /// </summary>
        public static Task<Ok> AnswerCustomQueryAsync(
            this Client client, long customQueryId = default, string data = default)
        {
            return client.ExecuteAsync(new AnswerCustomQuery
            {
                CustomQueryId = customQueryId, Data = data
            });
        }
    }
}
