using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class InlineKeyboardButtonType : Object
        {
            /// <summary>
            /// A button that opens a specified URL and automatically authorize the current user if allowed to do so
            /// </summary>
            public class InlineKeyboardButtonTypeLoginUrl : InlineKeyboardButtonType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inlineKeyboardButtonTypeLoginUrl";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// An HTTP URL to open
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("url")]
public string Url { get; set; }

/// <summary>
/// Unique button identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("id")]
public int Id { get; set; }

/// <summary>
/// If non-empty, new text of the button in forwarded messages
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("forward_text")]
public string ForwardText { get; set; }


            }
        }
    }
}