// <copyright file="StatusEnum.cs" company="APIMatic">
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
    /// StatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Uploadstarted.
        /// </summary>
        [EnumMember(Value = "upload-started")]
        Uploadstarted,

        /// <summary>
        /// Uploadfinished.
        /// </summary>
        [EnumMember(Value = "upload-finished")]
        Uploadfinished,

        /// <summary>
        /// Metadataextracted.
        /// </summary>
        [EnumMember(Value = "metadata-extracted")]
        Metadataextracted,

        /// <summary>
        /// Preprocessed.
        /// </summary>
        [EnumMember(Value = "preprocessed")]
        Preprocessed,

        /// <summary>
        /// Uploadterminated.
        /// </summary>
        [EnumMember(Value = "upload-terminated")]
        Uploadterminated,

        /// <summary>
        /// Error.
        /// </summary>
        [EnumMember(Value = "error")]
        Error
    }
}