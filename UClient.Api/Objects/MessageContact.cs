using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class MessageContent : Object
        {
            /// <summary>
            /// A message with a user contact
            /// </summary>
            public class MessageContact : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageContact";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// The contact description
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("contact")]
public Contact Contact { get; set; }


            }
        }
    }
}
