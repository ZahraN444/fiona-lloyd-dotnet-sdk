// <copyright file="PathRegionIdEnum.cs" company="APIMatic">
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
    /// PathRegionIdEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PathRegionIdEnum
    {
        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "Other")]
        Other,

        /// <summary>
        /// LeftFacility.
        /// </summary>
        [EnumMember(Value = "LeftFacility")]
        LeftFacility
    }
}