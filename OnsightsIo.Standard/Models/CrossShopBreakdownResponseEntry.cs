// <copyright file="CrossShopBreakdownResponseEntry.cs" company="APIMatic">
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
    /// CrossShopBreakdownResponseEntry.
    /// </summary>
    public class CrossShopBreakdownResponseEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossShopBreakdownResponseEntry"/> class.
        /// </summary>
        public CrossShopBreakdownResponseEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossShopBreakdownResponseEntry"/> class.
        /// </summary>
        /// <param name="firstRegionId">firstRegionId.</param>
        /// <param name="secondRegionId">secondRegionId.</param>
        /// <param name="crossShopVisitorsFactor">crossShopVisitorsFactor.</param>
        /// <param name="crossShopVisitorsOppositeDirectionFactor">crossShopVisitorsOppositeDirectionFactor.</param>
        /// <param name="crossShopVisitorsBothDirectionsFactor">crossShopVisitorsBothDirectionsFactor.</param>
        /// <param name="crossShopVisitors">crossShopVisitors.</param>
        /// <param name="crossShopVisitorsOppositeDirection">crossShopVisitorsOppositeDirection.</param>
        /// <param name="crossShopVisitorsBothDirections">crossShopVisitorsBothDirections.</param>
        public CrossShopBreakdownResponseEntry(
            Guid firstRegionId,
            Guid secondRegionId,
            double crossShopVisitorsFactor,
            double crossShopVisitorsOppositeDirectionFactor,
            double crossShopVisitorsBothDirectionsFactor,
            long? crossShopVisitors = null,
            long? crossShopVisitorsOppositeDirection = null,
            long? crossShopVisitorsBothDirections = null)
        {
            this.FirstRegionId = firstRegionId;
            this.SecondRegionId = secondRegionId;
            this.CrossShopVisitors = crossShopVisitors;
            this.CrossShopVisitorsOppositeDirection = crossShopVisitorsOppositeDirection;
            this.CrossShopVisitorsBothDirections = crossShopVisitorsBothDirections;
            this.CrossShopVisitorsFactor = crossShopVisitorsFactor;
            this.CrossShopVisitorsOppositeDirectionFactor = crossShopVisitorsOppositeDirectionFactor;
            this.CrossShopVisitorsBothDirectionsFactor = crossShopVisitorsBothDirectionsFactor;
        }

        /// <summary>
        /// Gets or sets FirstRegionId.
        /// </summary>
        [JsonProperty("firstRegionId")]
        public Guid FirstRegionId { get; set; }

        /// <summary>
        /// Gets or sets SecondRegionId.
        /// </summary>
        [JsonProperty("secondRegionId")]
        public Guid SecondRegionId { get; set; }

        /// <summary>
        /// Gets or sets CrossShopVisitors.
        /// </summary>
        [JsonProperty("crossShopVisitors", NullValueHandling = NullValueHandling.Ignore)]
        public long? CrossShopVisitors { get; set; }

        /// <summary>
        /// Gets or sets CrossShopVisitorsOppositeDirection.
        /// </summary>
        [JsonProperty("crossShopVisitorsOppositeDirection", NullValueHandling = NullValueHandling.Ignore)]
        public long? CrossShopVisitorsOppositeDirection { get; set; }

        /// <summary>
        /// Gets or sets CrossShopVisitorsBothDirections.
        /// </summary>
        [JsonProperty("crossShopVisitorsBothDirections", NullValueHandling = NullValueHandling.Ignore)]
        public long? CrossShopVisitorsBothDirections { get; set; }

        /// <summary>
        /// Gets or sets CrossShopVisitorsFactor.
        /// </summary>
        [JsonProperty("crossShopVisitorsFactor")]
        public double CrossShopVisitorsFactor { get; set; }

        /// <summary>
        /// Gets or sets CrossShopVisitorsOppositeDirectionFactor.
        /// </summary>
        [JsonProperty("crossShopVisitorsOppositeDirectionFactor")]
        public double CrossShopVisitorsOppositeDirectionFactor { get; set; }

        /// <summary>
        /// Gets or sets CrossShopVisitorsBothDirectionsFactor.
        /// </summary>
        [JsonProperty("crossShopVisitorsBothDirectionsFactor")]
        public double CrossShopVisitorsBothDirectionsFactor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CrossShopBreakdownResponseEntry : ({string.Join(", ", toStringOutput)})";
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
            return obj is CrossShopBreakdownResponseEntry other &&                this.FirstRegionId.Equals(other.FirstRegionId) &&
                this.SecondRegionId.Equals(other.SecondRegionId) &&
                ((this.CrossShopVisitors == null && other.CrossShopVisitors == null) || (this.CrossShopVisitors?.Equals(other.CrossShopVisitors) == true)) &&
                ((this.CrossShopVisitorsOppositeDirection == null && other.CrossShopVisitorsOppositeDirection == null) || (this.CrossShopVisitorsOppositeDirection?.Equals(other.CrossShopVisitorsOppositeDirection) == true)) &&
                ((this.CrossShopVisitorsBothDirections == null && other.CrossShopVisitorsBothDirections == null) || (this.CrossShopVisitorsBothDirections?.Equals(other.CrossShopVisitorsBothDirections) == true)) &&
                this.CrossShopVisitorsFactor.Equals(other.CrossShopVisitorsFactor) &&
                this.CrossShopVisitorsOppositeDirectionFactor.Equals(other.CrossShopVisitorsOppositeDirectionFactor) &&
                this.CrossShopVisitorsBothDirectionsFactor.Equals(other.CrossShopVisitorsBothDirectionsFactor);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirstRegionId = {this.FirstRegionId}");
            toStringOutput.Add($"this.SecondRegionId = {this.SecondRegionId}");
            toStringOutput.Add($"this.CrossShopVisitors = {(this.CrossShopVisitors == null ? "null" : this.CrossShopVisitors.ToString())}");
            toStringOutput.Add($"this.CrossShopVisitorsOppositeDirection = {(this.CrossShopVisitorsOppositeDirection == null ? "null" : this.CrossShopVisitorsOppositeDirection.ToString())}");
            toStringOutput.Add($"this.CrossShopVisitorsBothDirections = {(this.CrossShopVisitorsBothDirections == null ? "null" : this.CrossShopVisitorsBothDirections.ToString())}");
            toStringOutput.Add($"this.CrossShopVisitorsFactor = {this.CrossShopVisitorsFactor}");
            toStringOutput.Add($"this.CrossShopVisitorsOppositeDirectionFactor = {this.CrossShopVisitorsOppositeDirectionFactor}");
            toStringOutput.Add($"this.CrossShopVisitorsBothDirectionsFactor = {this.CrossShopVisitorsBothDirectionsFactor}");
        }
    }
}