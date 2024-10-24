// <copyright file="FloorRequestMetadata.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OnsightsIo.Standard;
using OnsightsIo.Standard.Utilities;

namespace OnsightsIo.Standard.Models
{
    /// <summary>
    /// FloorRequestMetadata.
    /// </summary>
    public class FloorRequestMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloorRequestMetadata"/> class.
        /// </summary>
        public FloorRequestMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloorRequestMetadata"/> class.
        /// </summary>
        /// <param name="defaultGridDensityFactor">defaultGridDensityFactor.</param>
        /// <param name="referenceLines">referenceLines.</param>
        public FloorRequestMetadata(
            double? defaultGridDensityFactor = null,
            List<Models.ReferenceLine> referenceLines = null)
        {
            this.DefaultGridDensityFactor = defaultGridDensityFactor;
            this.ReferenceLines = referenceLines;
        }

        /// <summary>
        /// Gets or sets DefaultGridDensityFactor.
        /// </summary>
        [JsonProperty("defaultGridDensityFactor", NullValueHandling = NullValueHandling.Ignore)]
        public double? DefaultGridDensityFactor { get; set; }

        /// <summary>
        /// Gets or sets ReferenceLines.
        /// </summary>
        [JsonProperty("referenceLines", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ReferenceLine> ReferenceLines { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FloorRequestMetadata : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is FloorRequestMetadata other &&                ((this.DefaultGridDensityFactor == null && other.DefaultGridDensityFactor == null) || (this.DefaultGridDensityFactor?.Equals(other.DefaultGridDensityFactor) == true)) &&
                ((this.ReferenceLines == null && other.ReferenceLines == null) || (this.ReferenceLines?.Equals(other.ReferenceLines) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DefaultGridDensityFactor = {(this.DefaultGridDensityFactor == null ? "null" : this.DefaultGridDensityFactor.ToString())}");
            toStringOutput.Add($"this.ReferenceLines = {(this.ReferenceLines == null ? "null" : $"[{string.Join(", ", this.ReferenceLines)} ]")}");
        }
    }
}