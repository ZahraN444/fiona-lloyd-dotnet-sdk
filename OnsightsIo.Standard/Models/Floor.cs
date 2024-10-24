// <copyright file="Floor.cs" company="APIMatic">
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
    /// Floor.
    /// </summary>
    public class Floor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Floor"/> class.
        /// </summary>
        public Floor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Floor"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="bottomLimit">bottomLimit.</param>
        /// <param name="level">level.</param>
        /// <param name="commonAreaWKT">commonAreaWKT.</param>
        /// <param name="wholeFloorWKT">wholeFloorWKT.</param>
        /// <param name="regions">regions.</param>
        public Floor(
            Guid id,
            double bottomLimit,
            int? level = null,
            string commonAreaWKT = null,
            string wholeFloorWKT = null,
            List<Models.Region> regions = null)
        {
            this.Id = id;
            this.Level = level;
            this.CommonAreaWKT = commonAreaWKT;
            this.WholeFloorWKT = wholeFloorWKT;
            this.BottomLimit = bottomLimit;
            this.Regions = regions;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets Level.
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// Gets or sets CommonAreaWKT.
        /// </summary>
        [JsonProperty("commonAreaWKT", NullValueHandling = NullValueHandling.Ignore)]
        public string CommonAreaWKT { get; set; }

        /// <summary>
        /// Gets or sets WholeFloorWKT.
        /// </summary>
        [JsonProperty("wholeFloorWKT", NullValueHandling = NullValueHandling.Ignore)]
        public string WholeFloorWKT { get; set; }

        /// <summary>
        /// Gets or sets BottomLimit.
        /// </summary>
        [JsonProperty("bottomLimit")]
        public double BottomLimit { get; set; }

        /// <summary>
        /// Gets or sets Regions.
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Region> Regions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Floor : ({string.Join(", ", toStringOutput)})";
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
            return obj is Floor other &&                this.Id.Equals(other.Id) &&
                ((this.Level == null && other.Level == null) || (this.Level?.Equals(other.Level) == true)) &&
                ((this.CommonAreaWKT == null && other.CommonAreaWKT == null) || (this.CommonAreaWKT?.Equals(other.CommonAreaWKT) == true)) &&
                ((this.WholeFloorWKT == null && other.WholeFloorWKT == null) || (this.WholeFloorWKT?.Equals(other.WholeFloorWKT) == true)) &&
                this.BottomLimit.Equals(other.BottomLimit) &&
                ((this.Regions == null && other.Regions == null) || (this.Regions?.Equals(other.Regions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Level = {(this.Level == null ? "null" : this.Level.ToString())}");
            toStringOutput.Add($"this.CommonAreaWKT = {(this.CommonAreaWKT == null ? "null" : this.CommonAreaWKT)}");
            toStringOutput.Add($"this.WholeFloorWKT = {(this.WholeFloorWKT == null ? "null" : this.WholeFloorWKT)}");
            toStringOutput.Add($"this.BottomLimit = {this.BottomLimit}");
            toStringOutput.Add($"this.Regions = {(this.Regions == null ? "null" : $"[{string.Join(", ", this.Regions)} ]")}");
        }
    }
}