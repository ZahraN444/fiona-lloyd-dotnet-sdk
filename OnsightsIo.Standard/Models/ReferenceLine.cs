// <copyright file="ReferenceLine.cs" company="APIMatic">
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
    /// ReferenceLine.
    /// </summary>
    public class ReferenceLine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceLine"/> class.
        /// </summary>
        public ReferenceLine()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceLine"/> class.
        /// </summary>
        /// <param name="point">point.</param>
        /// <param name="angleRad">angleRad.</param>
        public ReferenceLine(
            Models.Point2D point,
            double angleRad)
        {
            this.Point = point;
            this.AngleRad = angleRad;
        }

        /// <summary>
        /// Gets or sets Point.
        /// </summary>
        [JsonProperty("point")]
        public Models.Point2D Point { get; set; }

        /// <summary>
        /// Gets or sets AngleRad.
        /// </summary>
        [JsonProperty("angleRad")]
        public double AngleRad { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReferenceLine : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReferenceLine other &&                ((this.Point == null && other.Point == null) || (this.Point?.Equals(other.Point) == true)) &&
                this.AngleRad.Equals(other.AngleRad);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Point = {(this.Point == null ? "null" : this.Point.ToString())}");
            toStringOutput.Add($"this.AngleRad = {this.AngleRad}");
        }
    }
}