using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Checks the 2-step verification recovery email address verification code
        /// </summary>
        public class CheckRecoveryEmailAddressCode : Function<PasswordState>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "checkRecoveryEmailAddressCode";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Verification code
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("code")]
public string Code { get; set; }


        }

        /// <summary>
        /// Checks the 2-step verification recovery email address verification code
        /// </summary>
        public static Task<PasswordState> CheckRecoveryEmailAddressCodeAsync(
            this Client client, string code = default)
        {
            return client.ExecuteAsync(new CheckRecoveryEmailAddressCode
            {
                Code = code
            });
        }
    }
}
