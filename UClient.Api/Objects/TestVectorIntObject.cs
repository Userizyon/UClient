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
        /// A simple object containing a vector of objects that hold a number; for testing only
        /// </summary>
        public partial class TestVectorIntObject : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "testVectorIntObject";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Vector of objects
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("value")]
public TestInt[] Value { get; set; }


        }
    }
}
