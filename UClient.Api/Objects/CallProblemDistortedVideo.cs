using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class CallProblem : Object
        {
            /// <summary>
            /// The video was distorted
            /// </summary>
            public class CallProblemDistortedVideo : CallProblem
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "callProblemDistortedVideo";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}
