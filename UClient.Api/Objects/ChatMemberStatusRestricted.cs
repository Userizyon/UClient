using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class ChatMemberStatus : Object
        {
            /// <summary>
            /// The user is under certain restrictions in the chat. Not supported in basic groups and channels
            /// </summary>
            public class ChatMemberStatusRestricted : ChatMemberStatus
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatMemberStatusRestricted";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// True, if the user is a member of the chat
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_member")]
public bool IsMember { get; set; }

/// <summary>
/// Point in time (Unix timestamp) when restrictions will be lifted from the user; 0 if never. If the user is restricted for more than 366 days or for less than 30 seconds from the current time, the user is considered to be restricted forever
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("restricted_until_date")]
public int RestrictedUntilDate { get; set; }

/// <summary>
/// User permissions in the chat
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("permissions")]
public ChatPermissions Permissions { get; set; }


            }
        }
    }
}
