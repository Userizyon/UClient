﻿using System;
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
        /// $FUNC_DESCRIPTION
        /// </summary>
        public class $FUNC_NAME : Function<$RETURN_TYPE_NAME>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "$TL_FUNC_NAME";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
$FUNC_FIELDS
        }

        /// <summary>
        /// $FUNC_DESCRIPTION
        /// </summary>
        public static Task<$RETURN_TYPE_NAME> $FUNC_NAMEAsync(
            this Client client$FUNC_PARAMS)
        {
            return client.ExecuteAsync(new $FUNC_NAME
            {
                $FUNC_ARGS
            });
        }
    }
}
