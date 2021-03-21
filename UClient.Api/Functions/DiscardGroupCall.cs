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
        /// Discards a group call. Requires groupCall.can_be_managed
        /// </summary>
        public class DiscardGroupCall : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "discardGroupCall";

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


        }

        /// <summary>
        /// Discards a group call. Requires groupCall.can_be_managed
        /// </summary>
        public static Task<Ok> DiscardGroupCallAsync(
            this Client client, int groupCallId = default)
        {
            return client.ExecuteAsync(new DiscardGroupCall
            {
                GroupCallId = groupCallId
            });
        }
    }
}
