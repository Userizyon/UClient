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
        /// Contains a list of chat invite link counts
        /// </summary>
        public partial class ChatInviteLinkCounts : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatInviteLinkCounts";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// List of invite linkcounts
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("invite_link_counts")]
public ChatInviteLinkCount[] InviteLinkCounts { get; set; }


        }
    }
}
