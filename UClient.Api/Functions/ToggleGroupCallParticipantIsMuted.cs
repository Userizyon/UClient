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
        /// Toggles whether a group call participant is muted, unmuted, or allowed to unmute themself
        /// </summary>
        public class ToggleGroupCallParticipantIsMuted : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "toggleGroupCallParticipantIsMuted";

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
/// Participant identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("participant")]
public MessageSender Participant { get; set; }

/// <summary>
/// Pass true if the user must be muted and false otherwise
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_muted")]
public bool IsMuted { get; set; }


        }

        /// <summary>
        /// Toggles whether a group call participant is muted, unmuted, or allowed to unmute themself
        /// </summary>
        public static Task<Ok> ToggleGroupCallParticipantIsMutedAsync(
            this Client client, int groupCallId = default, MessageSender participant = default, bool isMuted = default)
        {
            return client.ExecuteAsync(new ToggleGroupCallParticipantIsMuted
            {
                GroupCallId = groupCallId, Participant = participant, IsMuted = isMuted
            });
        }
    }
}
