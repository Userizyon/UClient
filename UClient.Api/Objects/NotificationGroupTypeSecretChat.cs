using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class NotificationGroupType : Object
        {
            /// <summary>
            /// A group containing a notification of type notificationTypeNewSecretChat
            /// </summary>
            public class NotificationGroupTypeSecretChat : NotificationGroupType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "notificationGroupTypeSecretChat";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}
