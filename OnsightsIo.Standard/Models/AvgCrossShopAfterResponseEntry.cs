// <copyright file="AvgCrossShopAfterResponseEntry.cs" company="APIMatic">
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
    /// AvgCrossShopAfterResponseEntry.
    /// </summary>
    public class AvgCrossShopAfterResponseEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvgCrossShopAfterResponseEntry"/> class.
        /// </summary>
        public AvgCrossShopAfterResponseEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvgCrossShopAfterResponseEntry"/> class.
        /// </summary>
        /// <param name="regionId">regionId.</param>
        /// <param name="avgNumberRegionsVisitedAfter">avgNumberRegionsVisitedAfter.</param>
        public AvgCrossShopAfterResponseEntry(
            Guid regionId,
            double avgNumberRegionsVisitedAfter)
        {
            this.RegionId = regionId;
            this.AvgNumberRegionsVisitedAfter = avgNumberRegionsVisitedAfter;
        }

        /// <summary>
        /// Gets or sets RegionId.
        /// </summary>
        [JsonProperty("regionId")]
        public Guid RegionId { get; set; }

        /// <summary>
        /// Gets or sets AvgNumberRegionsVisitedAfter.
        /// </summary>
        [JsonProperty("avgNumberRegionsVisitedAfter")]
        public double AvgNumberRegionsVisitedAfter { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AvgCrossShopAfterResponseEntry : ({string.Join(", ", toStringOutput)})";
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
            return obj is AvgCrossShopAfterResponseEntry other &&                this.RegionId.Equals(other.RegionId) &&
                this.AvgNumberRegionsVisitedAfter.Equals(other.AvgNumberRegionsVisitedAfter);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegionId = {this.RegionId}");
            toStringOutput.Add($"this.AvgNumberRegionsVisitedAfter = {this.AvgNumberRegionsVisitedAfter}");
        }
    }
}