﻿using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class $BASE_TYPE_NAME : Object
        {
            /// <summary>
            /// $TYPE_DESCRIPTION
            /// </summary>
            public class $TYPE_NAME : $BASE_TYPE_NAME
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "$TL_TYPE_NAME";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

$TYPE_FIELDS
            }
        }
    }
}