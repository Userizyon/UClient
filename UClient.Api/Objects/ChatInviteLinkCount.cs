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
        /// Describes a chat administrator with a number of active and revoked chat invite links
        /// </summary>
        public partial class ChatInviteLinkCount : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatInviteLinkCount";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Administrator's user identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user_id")]
public int UserId { get; set; }

/// <summary>
/// Number of active invite links
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("invite_link_count")]
public int InviteLinkCount { get; set; }

/// <summary>
/// Number of revoked invite links
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("revoked_invite_link_count")]
public int RevokedInviteLinkCount { get; set; }


        }
    }
}
