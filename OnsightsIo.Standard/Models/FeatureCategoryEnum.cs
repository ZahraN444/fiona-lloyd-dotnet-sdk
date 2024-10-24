// <copyright file="FeatureCategoryEnum.cs" company="APIMatic">
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
    /// FeatureCategoryEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeatureCategoryEnum
    {
        /// <summary>
        /// STOREENTRANCE.
        /// </summary>
        [EnumMember(Value = "STORE_ENTRANCE")]
        STOREENTRANCE,

        /// <summary>
        /// OPPORTUNITYAREA.
        /// </summary>
        [EnumMember(Value = "OPPORTUNITY_AREA")]
        OPPORTUNITYAREA,

        /// <summary>
        /// VIEWABLEAREA.
        /// </summary>
        [EnumMember(Value = "VIEWABLE_AREA")]
        VIEWABLEAREA
    }
}