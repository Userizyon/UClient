using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class PassportElement : Object
        {
            /// <summary>
            /// A Telegram Passport element containing the user's rental agreement
            /// </summary>
            public class PassportElementRentalAgreement : PassportElement
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementRentalAgreement";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Rental agreement
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("rental_agreement")]
public PersonalDocument RentalAgreement { get; set; }


            }
        }
    }
}
