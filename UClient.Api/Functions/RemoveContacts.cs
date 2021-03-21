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
        /// Removes users from the contact list
        /// </summary>
        public class RemoveContacts : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "removeContacts";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Identifiers of users to be deleted
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user_ids")]
public int[] UserIds { get; set; }


        }

        /// <summary>
        /// Removes users from the contact list
        /// </summary>
        public static Task<Ok> RemoveContactsAsync(
            this Client client, int[] userIds = default)
        {
            return client.ExecuteAsync(new RemoveContacts
            {
                UserIds = userIds
            });
        }
    }
}
