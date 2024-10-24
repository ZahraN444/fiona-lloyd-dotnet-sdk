// <copyright file="SessionTrackingModeEnum.cs" company="APIMatic">
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
    /// SessionTrackingModeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SessionTrackingModeEnum
    {
        /// <summary>
        /// COOKIE.
        /// </summary>
        [EnumMember(Value = "COOKIE")]
        COOKIE,

        /// <summary>
        /// URL.
        /// </summary>
        [EnumMember(Value = "URL")]
        URL,

        /// <summary>
        /// SSL.
        /// </summary>
        [EnumMember(Value = "SSL")]
        SSL
    }
}