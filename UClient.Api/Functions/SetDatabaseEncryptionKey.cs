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
        /// Changes the database encryption key. Usually the encryption key is never changed and is stored in some OS keychain
        /// </summary>
        public class SetDatabaseEncryptionKey : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setDatabaseEncryptionKey";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// New encryption key
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("new_encryption_key")]
public byte[] NewEncryptionKey { get; set; }


        }

        /// <summary>
        /// Changes the database encryption key. Usually the encryption key is never changed and is stored in some OS keychain
        /// </summary>
        public static Task<Ok> SetDatabaseEncryptionKeyAsync(
            this Client client, byte[] newEncryptionKey = default)
        {
            return client.ExecuteAsync(new SetDatabaseEncryptionKey
            {
                NewEncryptionKey = newEncryptionKey
            });
        }
    }
}