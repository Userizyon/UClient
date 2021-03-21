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
        /// Changes a profile photo for the current user
        /// </summary>
        public class SetProfilePhoto : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setProfilePhoto";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Profile photo to set
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("photo")]
public InputChatPhoto Photo { get; set; }


        }

        /// <summary>
        /// Changes a profile photo for the current user
        /// </summary>
        public static Task<Ok> SetProfilePhotoAsync(
            this Client client, InputChatPhoto photo = default)
        {
            return client.ExecuteAsync(new SetProfilePhoto
            {
                Photo = photo
            });
        }
    }
}
