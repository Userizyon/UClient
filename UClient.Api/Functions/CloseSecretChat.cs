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
        /// Closes a secret chat, effectively transferring its state to secretChatStateClosed
        /// </summary>
        public class CloseSecretChat : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "closeSecretChat";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Secret chat identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("secret_chat_id")]
public int SecretChatId { get; set; }


        }

        /// <summary>
        /// Closes a secret chat, effectively transferring its state to secretChatStateClosed
        /// </summary>
        public static Task<Ok> CloseSecretChatAsync(
            this Client client, int secretChatId = default)
        {
            return client.ExecuteAsync(new CloseSecretChat
            {
                SecretChatId = secretChatId
            });
        }
    }
}
