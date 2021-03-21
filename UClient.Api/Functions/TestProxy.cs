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
        /// Sends a simple network request to the Telegram servers via proxy; for testing only. Can be called before authorization
        /// </summary>
        public class TestProxy : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "testProxy";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Proxy server IP address
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("server")]
public string Server { get; set; }

/// <summary>
/// Proxy server port
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("port")]
public int Port { get; set; }

/// <summary>
/// Proxy type
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("type")]
public ProxyType Type { get; set; }

/// <summary>
/// Identifier of a datacenter, with which to test connection
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("dc_id")]
public int DcId { get; set; }

/// <summary>
/// The maximum overall timeout for the request
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("timeout")]
public double? Timeout { get; set; }


        }

        /// <summary>
        /// Sends a simple network request to the Telegram servers via proxy; for testing only. Can be called before authorization
        /// </summary>
        public static Task<Ok> TestProxyAsync(
            this Client client, string server = default, int port = default, ProxyType type = default, int dcId = default, double? timeout = default)
        {
            return client.ExecuteAsync(new TestProxy
            {
                Server = server, Port = port, Type = type, DcId = dcId, Timeout = timeout
            });
        }
    }
}
