using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class InputPassportElement : Object
        {
            /// <summary>
            /// A Telegram Passport element to be saved containing the user's driver license
            /// </summary>
            public class InputPassportElementDriverLicense : InputPassportElement
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementDriverLicense";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// The driver license to be saved
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("driver_license")]
public InputIdentityDocument DriverLicense { get; set; }


            }
        }
    }
}
