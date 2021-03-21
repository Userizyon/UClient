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
        /// Contains information about countries
        /// </summary>
        public partial class Countries : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "countries";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// The list of countries
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("countries")]
public CountryInfo[] Countries_ { get; set; }


        }
    }
}