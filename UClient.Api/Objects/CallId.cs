using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Contains the call identifier
        /// </summary>
        public partial class CallId : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "callId";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Call identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("id")]
public int Id { get; set; }


        }
    }
}
