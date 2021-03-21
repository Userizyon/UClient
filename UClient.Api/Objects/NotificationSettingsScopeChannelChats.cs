using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class NotificationSettingsScope : Object
        {
            /// <summary>
            /// Notification settings applied to all channels when the corresponding chat setting has a default value
            /// </summary>
            public class NotificationSettingsScopeChannelChats : NotificationSettingsScope
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "notificationSettingsScopeChannelChats";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}
