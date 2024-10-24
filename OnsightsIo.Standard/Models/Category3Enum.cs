// <copyright file="Category3Enum.cs" company="APIMatic">
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
    /// Category3Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Category3Enum
    {
        /// <summary>
        /// StoreEntrance.
        /// </summary>
        [EnumMember(Value = "store_entrance")]
        StoreEntrance,

        /// <summary>
        /// ViewableArea.
        /// </summary>
        [EnumMember(Value = "viewable_area")]
        ViewableArea,

        /// <summary>
        /// OpportunityArea.
        /// </summary>
        [EnumMember(Value = "opportunity_area")]
        OpportunityArea
    }
}