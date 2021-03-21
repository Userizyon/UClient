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
        /// Returns the default text for invitation messages to be used as a placeholder when the current user invites friends to Telegram
        /// </summary>
        public class GetInviteText : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getInviteText";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            

        }

        /// <summary>
        /// Returns the default text for invitation messages to be used as a placeholder when the current user invites friends to Telegram
        /// </summary>
        public static Task<Text> GetInviteTextAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetInviteText
            {
                
            });
        }
    }
}
