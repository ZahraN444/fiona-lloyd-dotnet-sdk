// <copyright file="StageEnum.cs" company="APIMatic">
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
    /// StageEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum StageEnum
    {
        /// <summary>
        /// Withincamera.
        /// </summary>
        [EnumMember(Value = "within-camera")]
        Withincamera,

        /// <summary>
        /// Crosscamera.
        /// </summary>
        [EnumMember(Value = "cross-camera")]
        Crosscamera,

        /// <summary>
        /// Pra.
        /// </summary>
        [EnumMember(Value = "pra")]
        Pra
    }
}