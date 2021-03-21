using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class InputInlineQueryResult : Object
        {
            /// <summary>
            /// Represents a user contact
            /// </summary>
            public class InputInlineQueryResultContact : InputInlineQueryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputInlineQueryResultContact";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Unique identifier of the query result
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("id")]
public string Id { get; set; }

/// <summary>
/// User contact
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("contact")]
public Contact Contact { get; set; }

/// <summary>
/// URL of the result thumbnail, if it exists
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("thumbnail_url")]
public string ThumbnailUrl { get; set; }

/// <summary>
/// Thumbnail width, if known
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("thumbnail_width")]
public int ThumbnailWidth { get; set; }

/// <summary>
/// Thumbnail height, if known
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("thumbnail_height")]
public int ThumbnailHeight { get; set; }

/// <summary>
/// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("reply_markup")]
public ReplyMarkup ReplyMarkup { get; set; }

/// <summary>
/// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageLocation, InputMessageVenue or InputMessageContact
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("input_message_content")]
public InputMessageContent InputMessageContent { get; set; }


            }
        }
    }
}
