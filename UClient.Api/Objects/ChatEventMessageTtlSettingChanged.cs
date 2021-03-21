using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// The message TTL setting was changed
            /// </summary>
            public class ChatEventMessageTtlSettingChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventMessageTtlSettingChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Previous value of message_ttl_setting
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("old_message_ttl_setting")]
public int OldMessageTtlSetting { get; set; }

/// <summary>
/// New value of message_ttl_setting
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("new_message_ttl_setting")]
public int NewMessageTtlSetting { get; set; }


            }
        }
    }
}
