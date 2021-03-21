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
        /// Returns information about currently used log stream for internal logging of TDLib. Can be called synchronously
        /// </summary>
        public class GetLogStream : Function<LogStream>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getLogStream";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            

        }

        /// <summary>
        /// Returns information about currently used log stream for internal logging of TDLib. Can be called synchronously
        /// </summary>
        public static Task<LogStream> GetLogStreamAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetLogStream
            {
                
            });
        }
    }
}
