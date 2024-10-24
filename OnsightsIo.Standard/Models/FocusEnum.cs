// <copyright file="FocusEnum.cs" company="APIMatic">
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
    /// FocusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FocusEnum
    {
        /// <summary>
        /// STORE.
        /// </summary>
        [EnumMember(Value = "STORE")]
        STORE,

        /// <summary>
        /// PATH.
        /// </summary>
        [EnumMember(Value = "PATH")]
        PATH
    }
}