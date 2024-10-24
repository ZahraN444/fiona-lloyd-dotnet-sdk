// <copyright file="Category2Enum.cs" company="APIMatic">
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
    /// Category2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Category2Enum
    {
        /// <summary>
        /// Store.
        /// </summary>
        [EnumMember(Value = "store")]
        Store,

        /// <summary>
        /// AdSignage.
        /// </summary>
        [EnumMember(Value = "ad_signage")]
        AdSignage,

        /// <summary>
        /// WholeFacility.
        /// </summary>
        [EnumMember(Value = "whole_facility")]
        WholeFacility,

        /// <summary>
        /// Entrance.
        /// </summary>
        [EnumMember(Value = "entrance")]
        Entrance,

        /// <summary>
        /// StoreMultifloor.
        /// </summary>
        [EnumMember(Value = "store_multifloor")]
        StoreMultifloor
    }
}