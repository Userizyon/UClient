using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class VectorPathCommand : Object
        {
            /// <summary>
            /// Represents a vector path command
            /// </summary>
            public class VectorPathCommandLine : VectorPathCommand
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "vectorPathCommandLine";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// The end point of the straight line
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("end_point")]
public Point EndPoint { get; set; }


            }
        }
    }
}
