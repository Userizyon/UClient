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
            /// Some data of a user has changed. This update is guaranteed to come before the user identifier is returned to the application
            /// </summary>
            public class UpdateUser : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateUser";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// New data about the user
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user")]
public User User { get; set; }


            }
        }
    }
}
