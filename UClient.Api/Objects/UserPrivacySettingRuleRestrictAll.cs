using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class UserPrivacySettingRule : Object
        {
            /// <summary>
            /// A rule to restrict all users from doing something
            /// </summary>
            public class UserPrivacySettingRuleRestrictAll : UserPrivacySettingRule
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingRuleRestrictAll";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}