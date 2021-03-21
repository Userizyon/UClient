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
        /// Describes a venue
        /// </summary>
        public partial class Venue : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "venue";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Venue location; as defined by the sender
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("location")]
public Location Location { get; set; }

/// <summary>
/// Venue name; as defined by the sender
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("title")]
public string Title { get; set; }

/// <summary>
/// Venue address; as defined by the sender
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("address")]
public string Address { get; set; }

/// <summary>
/// Provider of the venue database; as defined by the sender. Currently only "foursquare" and "gplaces" (Google Places) need to be supported
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("provider")]
public string Provider { get; set; }

/// <summary>
/// Identifier of the venue in the provider database; as defined by the sender
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("id")]
public string Id { get; set; }

/// <summary>
/// Type of the venue in the provider database; as defined by the sender
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("type")]
public string Type { get; set; }


        }
    }
}
