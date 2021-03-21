using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// Service notification from the server. Upon receiving this the application must show a popup with the content of the notification
            /// </summary>
            public class UpdateServiceNotification : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateServiceNotification";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Notification type. If type begins with "AUTH_KEY_DROP_", then two buttons "Cancel" and "Log out" should be shown under notification; if user presses the second, all local data should be destroyed using Destroy method
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("type")]
public string Type { get; set; }

/// <summary>
/// Notification content
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("content")]
public MessageContent Content { get; set; }


            }
        }
    }
}
