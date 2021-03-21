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
        /// Uses the current IP address to find the current country. Returns two-letter ISO 3166-1 alpha-2 country code. Can be called before authorization
        /// </summary>
        public class GetCountryCode : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getCountryCode";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            

        }

        /// <summary>
        /// Uses the current IP address to find the current country. Returns two-letter ISO 3166-1 alpha-2 country code. Can be called before authorization
        /// </summary>
        public static Task<Text> GetCountryCodeAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetCountryCode
            {
                
            });
        }
    }
}