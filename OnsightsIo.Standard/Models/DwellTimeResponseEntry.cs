// <copyright file="DwellTimeResponseEntry.cs" company="APIMatic">
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
using OnsightsIo.Standard.Models.Containers;
using OnsightsIo.Standard.Utilities;

namespace OnsightsIo.Standard.Models
{
    /// <summary>
    /// DwellTimeResponseEntry.
    /// </summary>
    public class DwellTimeResponseEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DwellTimeResponseEntry"/> class.
        /// </summary>
        public DwellTimeResponseEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DwellTimeResponseEntry"/> class.
        /// </summary>
        /// <param name="regionId">regionId.</param>
        /// <param name="minDwellDuration">minDwellDuration.</param>
        /// <param name="maxDwellDuration">maxDwellDuration.</param>
        /// <param name="visitorsWhoEnteredFactor">visitorsWhoEnteredFactor.</param>
        /// <param name="totalVisitorsWhoWalkedPastFactor">totalVisitorsWhoWalkedPastFactor.</param>
        /// <param name="visitorsWhoDidNotEnterFactor">visitorsWhoDidNotEnterFactor.</param>
        /// <param name="conversionRate">conversionRate.</param>
        /// <param name="totalDwellDuration">totalDwellDuration.</param>
        /// <param name="meanDwellDuration">meanDwellDuration.</param>
        /// <param name="visitorsWhoEntered">visitorsWhoEntered.</param>
        /// <param name="totalVisitorsWhoWalkedPast">totalVisitorsWhoWalkedPast.</param>
        /// <param name="visitorsWhoDidNotEnter">visitorsWhoDidNotEnter.</param>
        public DwellTimeResponseEntry(
            Guid regionId,
            ConditionalDataString2 minDwellDuration,
            ConditionalDataString2 maxDwellDuration,
            double visitorsWhoEnteredFactor,
            double totalVisitorsWhoWalkedPastFactor,
            double visitorsWhoDidNotEnterFactor,
            double conversionRate,
            ConditionalDataString2 totalDwellDuration,
            ConditionalDataString2 meanDwellDuration,
            long? visitorsWhoEntered = null,
            long? totalVisitorsWhoWalkedPast = null,
            long? visitorsWhoDidNotEnter = null)
        {
            this.RegionId = regionId;
            this.MinDwellDuration = minDwellDuration;
            this.MaxDwellDuration = maxDwellDuration;
            this.VisitorsWhoEntered = visitorsWhoEntered;
            this.VisitorsWhoEnteredFactor = visitorsWhoEnteredFactor;
            this.TotalVisitorsWhoWalkedPast = totalVisitorsWhoWalkedPast;
            this.TotalVisitorsWhoWalkedPastFactor = totalVisitorsWhoWalkedPastFactor;
            this.VisitorsWhoDidNotEnter = visitorsWhoDidNotEnter;
            this.VisitorsWhoDidNotEnterFactor = visitorsWhoDidNotEnterFactor;
            this.ConversionRate = conversionRate;
            this.TotalDwellDuration = totalDwellDuration;
            this.MeanDwellDuration = meanDwellDuration;
        }

        /// <summary>
        /// Gets or sets RegionId.
        /// </summary>
        [JsonProperty("regionId")]
        public Guid RegionId { get; set; }

        /// <summary>
        /// Gets or sets MinDwellDuration.
        /// </summary>
        [JsonProperty("minDwellDuration")]
        public ConditionalDataString2 MinDwellDuration { get; set; }

        /// <summary>
        /// Gets or sets MaxDwellDuration.
        /// </summary>
        [JsonProperty("maxDwellDuration")]
        public ConditionalDataString2 MaxDwellDuration { get; set; }

        /// <summary>
        /// Gets or sets VisitorsWhoEntered.
        /// </summary>
        [JsonProperty("visitorsWhoEntered", NullValueHandling = NullValueHandling.Ignore)]
        public long? VisitorsWhoEntered { get; set; }

        /// <summary>
        /// Gets or sets VisitorsWhoEnteredFactor.
        /// </summary>
        [JsonProperty("visitorsWhoEnteredFactor")]
        public double VisitorsWhoEnteredFactor { get; set; }

        /// <summary>
        /// Gets or sets TotalVisitorsWhoWalkedPast.
        /// </summary>
        [JsonProperty("totalVisitorsWhoWalkedPast", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalVisitorsWhoWalkedPast { get; set; }

        /// <summary>
        /// Gets or sets TotalVisitorsWhoWalkedPastFactor.
        /// </summary>
        [JsonProperty("totalVisitorsWhoWalkedPastFactor")]
        public double TotalVisitorsWhoWalkedPastFactor { get; set; }

        /// <summary>
        /// Gets or sets VisitorsWhoDidNotEnter.
        /// </summary>
        [JsonProperty("visitorsWhoDidNotEnter", NullValueHandling = NullValueHandling.Ignore)]
        public long? VisitorsWhoDidNotEnter { get; set; }

        /// <summary>
        /// Gets or sets VisitorsWhoDidNotEnterFactor.
        /// </summary>
        [JsonProperty("visitorsWhoDidNotEnterFactor")]
        public double VisitorsWhoDidNotEnterFactor { get; set; }

        /// <summary>
        /// Gets or sets ConversionRate.
        /// </summary>
        [JsonProperty("conversionRate")]
        public double ConversionRate { get; set; }

        /// <summary>
        /// Gets or sets TotalDwellDuration.
        /// </summary>
        [JsonProperty("totalDwellDuration")]
        public ConditionalDataString2 TotalDwellDuration { get; set; }

        /// <summary>
        /// Gets or sets MeanDwellDuration.
        /// </summary>
        [JsonProperty("meanDwellDuration")]
        public ConditionalDataString2 MeanDwellDuration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DwellTimeResponseEntry : ({string.Join(", ", toStringOutput)})";
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
            return obj is DwellTimeResponseEntry other &&                this.RegionId.Equals(other.RegionId) &&
                ((this.MinDwellDuration == null && other.MinDwellDuration == null) || (this.MinDwellDuration?.Equals(other.MinDwellDuration) == true)) &&
                ((this.MaxDwellDuration == null && other.MaxDwellDuration == null) || (this.MaxDwellDuration?.Equals(other.MaxDwellDuration) == true)) &&
                ((this.VisitorsWhoEntered == null && other.VisitorsWhoEntered == null) || (this.VisitorsWhoEntered?.Equals(other.VisitorsWhoEntered) == true)) &&
                this.VisitorsWhoEnteredFactor.Equals(other.VisitorsWhoEnteredFactor) &&
                ((this.TotalVisitorsWhoWalkedPast == null && other.TotalVisitorsWhoWalkedPast == null) || (this.TotalVisitorsWhoWalkedPast?.Equals(other.TotalVisitorsWhoWalkedPast) == true)) &&
                this.TotalVisitorsWhoWalkedPastFactor.Equals(other.TotalVisitorsWhoWalkedPastFactor) &&
                ((this.VisitorsWhoDidNotEnter == null && other.VisitorsWhoDidNotEnter == null) || (this.VisitorsWhoDidNotEnter?.Equals(other.VisitorsWhoDidNotEnter) == true)) &&
                this.VisitorsWhoDidNotEnterFactor.Equals(other.VisitorsWhoDidNotEnterFactor) &&
                this.ConversionRate.Equals(other.ConversionRate) &&
                ((this.TotalDwellDuration == null && other.TotalDwellDuration == null) || (this.TotalDwellDuration?.Equals(other.TotalDwellDuration) == true)) &&
                ((this.MeanDwellDuration == null && other.MeanDwellDuration == null) || (this.MeanDwellDuration?.Equals(other.MeanDwellDuration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegionId = {this.RegionId}");
            toStringOutput.Add($"MinDwellDuration = {(this.MinDwellDuration == null ? "null" : this.MinDwellDuration.ToString())}");
            toStringOutput.Add($"MaxDwellDuration = {(this.MaxDwellDuration == null ? "null" : this.MaxDwellDuration.ToString())}");
            toStringOutput.Add($"this.VisitorsWhoEntered = {(this.VisitorsWhoEntered == null ? "null" : this.VisitorsWhoEntered.ToString())}");
            toStringOutput.Add($"this.VisitorsWhoEnteredFactor = {this.VisitorsWhoEnteredFactor}");
            toStringOutput.Add($"this.TotalVisitorsWhoWalkedPast = {(this.TotalVisitorsWhoWalkedPast == null ? "null" : this.TotalVisitorsWhoWalkedPast.ToString())}");
            toStringOutput.Add($"this.TotalVisitorsWhoWalkedPastFactor = {this.TotalVisitorsWhoWalkedPastFactor}");
            toStringOutput.Add($"this.VisitorsWhoDidNotEnter = {(this.VisitorsWhoDidNotEnter == null ? "null" : this.VisitorsWhoDidNotEnter.ToString())}");
            toStringOutput.Add($"this.VisitorsWhoDidNotEnterFactor = {this.VisitorsWhoDidNotEnterFactor}");
            toStringOutput.Add($"this.ConversionRate = {this.ConversionRate}");
            toStringOutput.Add($"TotalDwellDuration = {(this.TotalDwellDuration == null ? "null" : this.TotalDwellDuration.ToString())}");
            toStringOutput.Add($"MeanDwellDuration = {(this.MeanDwellDuration == null ? "null" : this.MeanDwellDuration.ToString())}");
        }
    }
}