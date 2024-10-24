// <copyright file="WorldFile.cs" company="APIMatic">
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
    /// WorldFile.
    /// </summary>
    public class WorldFile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorldFile"/> class.
        /// </summary>
        public WorldFile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldFile"/> class.
        /// </summary>
        /// <param name="xscale">xscale.</param>
        /// <param name="yskew">yskew.</param>
        /// <param name="xskew">xskew.</param>
        /// <param name="yscale">yscale.</param>
        /// <param name="xposition">xposition.</param>
        /// <param name="yposition">yposition.</param>
        public WorldFile(
            double? xscale = null,
            double? yskew = null,
            double? xskew = null,
            double? yscale = null,
            double? xposition = null,
            double? yposition = null)
        {
            this.Xscale = xscale;
            this.Yskew = yskew;
            this.Xskew = xskew;
            this.Yscale = yscale;
            this.Xposition = xposition;
            this.Yposition = yposition;
        }

        /// <summary>
        /// Gets or sets Xscale.
        /// </summary>
        [JsonProperty("xscale", NullValueHandling = NullValueHandling.Ignore)]
        public double? Xscale { get; set; }

        /// <summary>
        /// Gets or sets Yskew.
        /// </summary>
        [JsonProperty("yskew", NullValueHandling = NullValueHandling.Ignore)]
        public double? Yskew { get; set; }

        /// <summary>
        /// Gets or sets Xskew.
        /// </summary>
        [JsonProperty("xskew", NullValueHandling = NullValueHandling.Ignore)]
        public double? Xskew { get; set; }

        /// <summary>
        /// Gets or sets Yscale.
        /// </summary>
        [JsonProperty("yscale", NullValueHandling = NullValueHandling.Ignore)]
        public double? Yscale { get; set; }

        /// <summary>
        /// Gets or sets Xposition.
        /// </summary>
        [JsonProperty("xposition", NullValueHandling = NullValueHandling.Ignore)]
        public double? Xposition { get; set; }

        /// <summary>
        /// Gets or sets Yposition.
        /// </summary>
        [JsonProperty("yposition", NullValueHandling = NullValueHandling.Ignore)]
        public double? Yposition { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorldFile : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorldFile other &&                ((this.Xscale == null && other.Xscale == null) || (this.Xscale?.Equals(other.Xscale) == true)) &&
                ((this.Yskew == null && other.Yskew == null) || (this.Yskew?.Equals(other.Yskew) == true)) &&
                ((this.Xskew == null && other.Xskew == null) || (this.Xskew?.Equals(other.Xskew) == true)) &&
                ((this.Yscale == null && other.Yscale == null) || (this.Yscale?.Equals(other.Yscale) == true)) &&
                ((this.Xposition == null && other.Xposition == null) || (this.Xposition?.Equals(other.Xposition) == true)) &&
                ((this.Yposition == null && other.Yposition == null) || (this.Yposition?.Equals(other.Yposition) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Xscale = {(this.Xscale == null ? "null" : this.Xscale.ToString())}");
            toStringOutput.Add($"this.Yskew = {(this.Yskew == null ? "null" : this.Yskew.ToString())}");
            toStringOutput.Add($"this.Xskew = {(this.Xskew == null ? "null" : this.Xskew.ToString())}");
            toStringOutput.Add($"this.Yscale = {(this.Yscale == null ? "null" : this.Yscale.ToString())}");
            toStringOutput.Add($"this.Xposition = {(this.Xposition == null ? "null" : this.Xposition.ToString())}");
            toStringOutput.Add($"this.Yposition = {(this.Yposition == null ? "null" : this.Yposition.ToString())}");
        }
    }
}