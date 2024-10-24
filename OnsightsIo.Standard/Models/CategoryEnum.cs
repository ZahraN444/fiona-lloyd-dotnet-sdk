// <copyright file="CategoryEnum.cs" company="APIMatic">
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
    /// CategoryEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryEnum
    {
        /// <summary>
        /// STORE.
        /// </summary>
        [EnumMember(Value = "STORE")]
        STORE,

        /// <summary>
        /// ENTRANCE.
        /// </summary>
        [EnumMember(Value = "ENTRANCE")]
        ENTRANCE,

        /// <summary>
        /// WHOLEFACILITY.
        /// </summary>
        [EnumMember(Value = "WHOLE_FACILITY")]
        WHOLEFACILITY,

        /// <summary>
        /// ADSIGNAGE.
        /// </summary>
        [EnumMember(Value = "AD_SIGNAGE")]
        ADSIGNAGE,

        /// <summary>
        /// STOREMULTIFLOOR.
        /// </summary>
        [EnumMember(Value = "STORE_MULTIFLOOR")]
        STOREMULTIFLOOR
    }
}