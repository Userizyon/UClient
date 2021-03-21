using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class PageBlock : Object
        {
            /// <summary>
            /// A map
            /// </summary>
            public class PageBlockMap : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockMap";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Location of the map center
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("location")]
public Location Location { get; set; }

/// <summary>
/// Map zoom level
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("zoom")]
public int Zoom { get; set; }

/// <summary>
/// Map width
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("width")]
public int Width { get; set; }

/// <summary>
/// Map height
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("height")]
public int Height { get; set; }

/// <summary>
/// Block caption
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("caption")]
public PageBlockCaption Caption { get; set; }


            }
        }
    }
}
