// <copyright file="Geometry.cs" company="APIMatic">
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
    /// Geometry.
    /// </summary>
    public class Geometry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry"/> class.
        /// </summary>
        public Geometry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry"/> class.
        /// </summary>
        /// <param name="dimension">dimension.</param>
        /// <param name="haveMeasure">haveMeasure.</param>
        /// <param name="type">type.</param>
        /// <param name="srid">srid.</param>
        /// <param name="mValue">value.</param>
        /// <param name="typeString">typeString.</param>
        /// <param name="firstPoint">firstPoint.</param>
        /// <param name="lastPoint">lastPoint.</param>
        /// <param name="measured">measured.</param>
        public Geometry(
            int? dimension = null,
            bool? haveMeasure = null,
            int? type = null,
            int? srid = null,
            string mValue = null,
            string typeString = null,
            Models.Point firstPoint = null,
            Models.Point lastPoint = null,
            bool? measured = null)
        {
            this.Dimension = dimension;
            this.HaveMeasure = haveMeasure;
            this.Type = type;
            this.Srid = srid;
            this.MValue = mValue;
            this.TypeString = typeString;
            this.FirstPoint = firstPoint;
            this.LastPoint = lastPoint;
            this.Measured = measured;
        }

        /// <summary>
        /// Gets or sets Dimension.
        /// </summary>
        [JsonProperty("dimension", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dimension { get; set; }

        /// <summary>
        /// Gets or sets HaveMeasure.
        /// </summary>
        [JsonProperty("haveMeasure", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaveMeasure { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or sets Srid.
        /// </summary>
        [JsonProperty("srid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Srid { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Gets or sets TypeString.
        /// </summary>
        [JsonProperty("typeString", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeString { get; set; }

        /// <summary>
        /// Gets or sets FirstPoint.
        /// </summary>
        [JsonProperty("firstPoint", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Point FirstPoint { get; set; }

        /// <summary>
        /// Gets or sets LastPoint.
        /// </summary>
        [JsonProperty("lastPoint", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Point LastPoint { get; set; }

        /// <summary>
        /// Gets or sets Measured.
        /// </summary>
        [JsonProperty("measured", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Measured { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Geometry : ({string.Join(", ", toStringOutput)})";
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
            return obj is Geometry other &&                ((this.Dimension == null && other.Dimension == null) || (this.Dimension?.Equals(other.Dimension) == true)) &&
                ((this.HaveMeasure == null && other.HaveMeasure == null) || (this.HaveMeasure?.Equals(other.HaveMeasure) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Srid == null && other.Srid == null) || (this.Srid?.Equals(other.Srid) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.TypeString == null && other.TypeString == null) || (this.TypeString?.Equals(other.TypeString) == true)) &&
                ((this.FirstPoint == null && other.FirstPoint == null) || (this.FirstPoint?.Equals(other.FirstPoint) == true)) &&
                ((this.LastPoint == null && other.LastPoint == null) || (this.LastPoint?.Equals(other.LastPoint) == true)) &&
                ((this.Measured == null && other.Measured == null) || (this.Measured?.Equals(other.Measured) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Dimension = {(this.Dimension == null ? "null" : this.Dimension.ToString())}");
            toStringOutput.Add($"this.HaveMeasure = {(this.HaveMeasure == null ? "null" : this.HaveMeasure.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Srid = {(this.Srid == null ? "null" : this.Srid.ToString())}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
            toStringOutput.Add($"this.TypeString = {(this.TypeString == null ? "null" : this.TypeString)}");
            toStringOutput.Add($"this.FirstPoint = {(this.FirstPoint == null ? "null" : this.FirstPoint.ToString())}");
            toStringOutput.Add($"this.LastPoint = {(this.LastPoint == null ? "null" : this.LastPoint.ToString())}");
            toStringOutput.Add($"this.Measured = {(this.Measured == null ? "null" : this.Measured.ToString())}");
        }
    }
}