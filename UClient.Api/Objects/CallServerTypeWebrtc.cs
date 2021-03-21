using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class CallServerType : Object
        {
            /// <summary>
            /// A WebRTC server
            /// </summary>
            public class CallServerTypeWebrtc : CallServerType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "callServerTypeWebrtc";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Username to be used for authentication
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("username")]
public string Username { get; set; }

/// <summary>
/// Authentication password
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("password")]
public string Password { get; set; }

/// <summary>
/// True, if the server supports TURN
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("supports_turn")]
public bool SupportsTurn { get; set; }

/// <summary>
/// True, if the server supports STUN
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("supports_stun")]
public bool SupportsStun { get; set; }


            }
        }
    }
}
