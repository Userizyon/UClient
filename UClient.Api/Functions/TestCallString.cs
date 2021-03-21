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
        /// Returns the received string; for testing only. This is an offline method. Can be called before authorization
        /// </summary>
        public class TestCallString : Function<TestString>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "testCallString";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// String to return
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("x")]
public string X { get; set; }


        }

        /// <summary>
        /// Returns the received string; for testing only. This is an offline method. Can be called before authorization
        /// </summary>
        public static Task<TestString> TestCallStringAsync(
            this Client client, string x = default)
        {
            return client.ExecuteAsync(new TestCallString
            {
                X = x
            });
        }
    }
}
