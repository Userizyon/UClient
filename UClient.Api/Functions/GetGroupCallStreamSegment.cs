using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Returns a file with a segment of a group call stream in a modified OGG format
        /// </summary>
        public class GetGroupCallStreamSegment : Function<FilePart>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getGroupCallStreamSegment";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Group call identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("group_call_id")]
public int GroupCallId { get; set; }

/// <summary>
/// Point in time when the stream segment begins; Unix timestamp in milliseconds
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("time_offset")]
public long TimeOffset { get; set; }

/// <summary>
/// Segment duration scale; 0-1. Segment's duration is 1000/(2**scale) milliseconds
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("scale")]
public int Scale { get; set; }


        }

        /// <summary>
        /// Returns a file with a segment of a group call stream in a modified OGG format
        /// </summary>
        public static Task<FilePart> GetGroupCallStreamSegmentAsync(
            this Client client, int groupCallId = default, long timeOffset = default, int scale = default)
        {
            return client.ExecuteAsync(new GetGroupCallStreamSegment
            {
                GroupCallId = groupCallId, TimeOffset = timeOffset, Scale = scale
            });
        }
    }
}