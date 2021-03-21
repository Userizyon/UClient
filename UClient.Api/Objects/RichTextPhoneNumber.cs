using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class RichText : Object
        {
            /// <summary>
            /// A rich text phone number
            /// </summary>
            public class RichTextPhoneNumber : RichText
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "richTextPhoneNumber";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Text
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("text")]
public RichText Text { get; set; }

/// <summary>
/// Phone number
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("phone_number")]
public string PhoneNumber { get; set; }


            }
        }
    }
}
