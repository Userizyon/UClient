using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class ResendPhoneNumberVerificationCode : Function<AuthenticationCodeInfo>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "resendPhoneNumberVerificationCode";

            [JsonProperty("@extra")] public override string Extra { get; set; }
        }
    }
}