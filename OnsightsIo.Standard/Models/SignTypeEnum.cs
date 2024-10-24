// <copyright file="SignTypeEnum.cs" company="APIMatic">
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
    /// SignTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SignTypeEnum
    {
        /// <summary>
        /// STATICPOSTER.
        /// </summary>
        [EnumMember(Value = "STATIC_POSTER")]
        STATICPOSTER,

        /// <summary>
        /// DIGITALSTATIC.
        /// </summary>
        [EnumMember(Value = "DIGITAL_STATIC")]
        DIGITALSTATIC,

        /// <summary>
        /// DIGITALDYNAMIC.
        /// </summary>
        [EnumMember(Value = "DIGITAL_DYNAMIC")]
        DIGITALDYNAMIC,

        /// <summary>
        /// DIGITALINTERACTIVE.
        /// </summary>
        [EnumMember(Value = "DIGITAL_INTERACTIVE")]
        DIGITALINTERACTIVE,

        /// <summary>
        /// OTHER.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER
    }
}