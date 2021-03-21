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
        /// Searches for the specified query in the first names, last names and usernames of the known user contacts
        /// </summary>
        public class SearchContacts : Function<Users>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchContacts";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Query to search for; may be empty to return all contacts
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("query")]
public string Query { get; set; }

/// <summary>
/// The maximum number of users to be returned
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("limit")]
public int Limit { get; set; }


        }

        /// <summary>
        /// Searches for the specified query in the first names, last names and usernames of the known user contacts
        /// </summary>
        public static Task<Users> SearchContactsAsync(
            this Client client, string query = default, int limit = default)
        {
            return client.ExecuteAsync(new SearchContacts
            {
                Query = query, Limit = limit
            });
        }
    }
}
