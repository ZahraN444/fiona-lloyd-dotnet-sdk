// <copyright file="Status3Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using OnsightsIo.Standard;
using OnsightsIo.Standard.Utilities;

namespace OnsightsIo.Standard.Models
{
    /// <summary>
    /// Status3Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status3Enum
    {
        /// <summary>
        /// Started.
        /// </summary>
        [EnumMember(Value = "started")]
        Started,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,

        /// <summary>
        /// Finished.
        /// </summary>
        [EnumMember(Value = "finished")]
        Finished
    }
}