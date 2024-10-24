// <copyright file="GetOpportunityAreaHeatmapResponseEntry.cs" company="APIMatic">
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
    /// GetOpportunityAreaHeatmapResponseEntry.
    /// </summary>
    public class GetOpportunityAreaHeatmapResponseEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOpportunityAreaHeatmapResponseEntry"/> class.
        /// </summary>
        public GetOpportunityAreaHeatmapResponseEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOpportunityAreaHeatmapResponseEntry"/> class.
        /// </summary>
        /// <param name="regionUuid">regionUuid.</param>
        /// <param name="footTrafficFactor">footTrafficFactor.</param>
        /// <param name="footTrafficSum">footTrafficSum.</param>
        /// <param name="footTrafficMax">footTrafficMax.</param>
        /// <param name="footTrafficMin">footTrafficMin.</param>
        /// <param name="footTrafficMean">footTrafficMean.</param>
        public GetOpportunityAreaHeatmapResponseEntry(
            Guid regionUuid,
            double footTrafficFactor,
            int? footTrafficSum = null,
            int? footTrafficMax = null,
            int? footTrafficMin = null,
            double? footTrafficMean = null)
        {
            this.RegionUuid = regionUuid;
            this.FootTrafficSum = footTrafficSum;
            this.FootTrafficMax = footTrafficMax;
            this.FootTrafficMin = footTrafficMin;
            this.FootTrafficMean = footTrafficMean;
            this.FootTrafficFactor = footTrafficFactor;
        }

        /// <summary>
        /// Gets or sets RegionUuid.
        /// </summary>
        [JsonProperty("regionUuid")]
        public Guid RegionUuid { get; set; }

        /// <summary>
        /// Gets or sets FootTrafficSum.
        /// </summary>
        [JsonProperty("footTrafficSum", NullValueHandling = NullValueHandling.Ignore)]
        public int? FootTrafficSum { get; set; }

        /// <summary>
        /// Gets or sets FootTrafficMax.
        /// </summary>
        [JsonProperty("footTrafficMax", NullValueHandling = NullValueHandling.Ignore)]
        public int? FootTrafficMax { get; set; }

        /// <summary>
        /// Gets or sets FootTrafficMin.
        /// </summary>
        [JsonProperty("footTrafficMin", NullValueHandling = NullValueHandling.Ignore)]
        public int? FootTrafficMin { get; set; }

        /// <summary>
        /// Gets or sets FootTrafficMean.
        /// </summary>
        [JsonProperty("footTrafficMean", NullValueHandling = NullValueHandling.Ignore)]
        public double? FootTrafficMean { get; set; }

        /// <summary>
        /// Gets or sets FootTrafficFactor.
        /// </summary>
        [JsonProperty("footTrafficFactor")]
        public double FootTrafficFactor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetOpportunityAreaHeatmapResponseEntry : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetOpportunityAreaHeatmapResponseEntry other &&                this.RegionUuid.Equals(other.RegionUuid) &&
                ((this.FootTrafficSum == null && other.FootTrafficSum == null) || (this.FootTrafficSum?.Equals(other.FootTrafficSum) == true)) &&
                ((this.FootTrafficMax == null && other.FootTrafficMax == null) || (this.FootTrafficMax?.Equals(other.FootTrafficMax) == true)) &&
                ((this.FootTrafficMin == null && other.FootTrafficMin == null) || (this.FootTrafficMin?.Equals(other.FootTrafficMin) == true)) &&
                ((this.FootTrafficMean == null && other.FootTrafficMean == null) || (this.FootTrafficMean?.Equals(other.FootTrafficMean) == true)) &&
                this.FootTrafficFactor.Equals(other.FootTrafficFactor);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegionUuid = {this.RegionUuid}");
            toStringOutput.Add($"this.FootTrafficSum = {(this.FootTrafficSum == null ? "null" : this.FootTrafficSum.ToString())}");
            toStringOutput.Add($"this.FootTrafficMax = {(this.FootTrafficMax == null ? "null" : this.FootTrafficMax.ToString())}");
            toStringOutput.Add($"this.FootTrafficMin = {(this.FootTrafficMin == null ? "null" : this.FootTrafficMin.ToString())}");
            toStringOutput.Add($"this.FootTrafficMean = {(this.FootTrafficMean == null ? "null" : this.FootTrafficMean.ToString())}");
            toStringOutput.Add($"this.FootTrafficFactor = {this.FootTrafficFactor}");
        }
    }
}