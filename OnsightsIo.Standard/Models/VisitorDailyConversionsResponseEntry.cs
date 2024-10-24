// <copyright file="VisitorDailyConversionsResponseEntry.cs" company="APIMatic">
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
    /// VisitorDailyConversionsResponseEntry.
    /// </summary>
    public class VisitorDailyConversionsResponseEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorDailyConversionsResponseEntry"/> class.
        /// </summary>
        public VisitorDailyConversionsResponseEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorDailyConversionsResponseEntry"/> class.
        /// </summary>
        /// <param name="regionId">regionId.</param>
        /// <param name="localDate">localDate.</param>
        /// <param name="visitorsWhoEnteredFactor">visitorsWhoEnteredFactor.</param>
        /// <param name="totalVisitorsWhoWalkedPastFactor">totalVisitorsWhoWalkedPastFactor.</param>
        /// <param name="visitorsWhoDidNotEnterFactor">visitorsWhoDidNotEnterFactor.</param>
        /// <param name="conversionRate">conversionRate.</param>
        /// <param name="totalDayVisitorsFactor">totalDayVisitorsFactor.</param>
        /// <param name="visitorsWhoEntered">visitorsWhoEntered.</param>
        /// <param name="totalVisitorsWhoWalkedPast">totalVisitorsWhoWalkedPast.</param>
        /// <param name="visitorsWhoDidNotEnter">visitorsWhoDidNotEnter.</param>
        /// <param name="totalDayVisitors">totalDayVisitors.</param>
        public VisitorDailyConversionsResponseEntry(
            Guid regionId,
            DateTime localDate,
            double visitorsWhoEnteredFactor,
            double totalVisitorsWhoWalkedPastFactor,
            double visitorsWhoDidNotEnterFactor,
            double conversionRate,
            double totalDayVisitorsFactor,
            long? visitorsWhoEntered = null,
            long? totalVisitorsWhoWalkedPast = null,
            long? visitorsWhoDidNotEnter = null,
            long? totalDayVisitors = null)
        {
            this.RegionId = regionId;
            this.LocalDate = localDate;
            this.VisitorsWhoEntered = visitorsWhoEntered;
            this.VisitorsWhoEnteredFactor = visitorsWhoEnteredFactor;
            this.TotalVisitorsWhoWalkedPast = totalVisitorsWhoWalkedPast;
            this.TotalVisitorsWhoWalkedPastFactor = totalVisitorsWhoWalkedPastFactor;
            this.VisitorsWhoDidNotEnter = visitorsWhoDidNotEnter;
            this.VisitorsWhoDidNotEnterFactor = visitorsWhoDidNotEnterFactor;
            this.ConversionRate = conversionRate;
            this.TotalDayVisitors = totalDayVisitors;
            this.TotalDayVisitorsFactor = totalDayVisitorsFactor;
        }

        /// <summary>
        /// Gets or sets RegionId.
        /// </summary>
        [JsonProperty("regionId")]
        public Guid RegionId { get; set; }

        /// <summary>
        /// Gets or sets LocalDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("localDate")]
        public DateTime LocalDate { get; set; }

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
        /// Gets or sets TotalDayVisitors.
        /// </summary>
        [JsonProperty("totalDayVisitors", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDayVisitors { get; set; }

        /// <summary>
        /// Gets or sets TotalDayVisitorsFactor.
        /// </summary>
        [JsonProperty("totalDayVisitorsFactor")]
        public double TotalDayVisitorsFactor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VisitorDailyConversionsResponseEntry : ({string.Join(", ", toStringOutput)})";
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
            return obj is VisitorDailyConversionsResponseEntry other &&                this.RegionId.Equals(other.RegionId) &&
                this.LocalDate.Equals(other.LocalDate) &&
                ((this.VisitorsWhoEntered == null && other.VisitorsWhoEntered == null) || (this.VisitorsWhoEntered?.Equals(other.VisitorsWhoEntered) == true)) &&
                this.VisitorsWhoEnteredFactor.Equals(other.VisitorsWhoEnteredFactor) &&
                ((this.TotalVisitorsWhoWalkedPast == null && other.TotalVisitorsWhoWalkedPast == null) || (this.TotalVisitorsWhoWalkedPast?.Equals(other.TotalVisitorsWhoWalkedPast) == true)) &&
                this.TotalVisitorsWhoWalkedPastFactor.Equals(other.TotalVisitorsWhoWalkedPastFactor) &&
                ((this.VisitorsWhoDidNotEnter == null && other.VisitorsWhoDidNotEnter == null) || (this.VisitorsWhoDidNotEnter?.Equals(other.VisitorsWhoDidNotEnter) == true)) &&
                this.VisitorsWhoDidNotEnterFactor.Equals(other.VisitorsWhoDidNotEnterFactor) &&
                this.ConversionRate.Equals(other.ConversionRate) &&
                ((this.TotalDayVisitors == null && other.TotalDayVisitors == null) || (this.TotalDayVisitors?.Equals(other.TotalDayVisitors) == true)) &&
                this.TotalDayVisitorsFactor.Equals(other.TotalDayVisitorsFactor);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegionId = {this.RegionId}");
            toStringOutput.Add($"this.LocalDate = {this.LocalDate}");
            toStringOutput.Add($"this.VisitorsWhoEntered = {(this.VisitorsWhoEntered == null ? "null" : this.VisitorsWhoEntered.ToString())}");
            toStringOutput.Add($"this.VisitorsWhoEnteredFactor = {this.VisitorsWhoEnteredFactor}");
            toStringOutput.Add($"this.TotalVisitorsWhoWalkedPast = {(this.TotalVisitorsWhoWalkedPast == null ? "null" : this.TotalVisitorsWhoWalkedPast.ToString())}");
            toStringOutput.Add($"this.TotalVisitorsWhoWalkedPastFactor = {this.TotalVisitorsWhoWalkedPastFactor}");
            toStringOutput.Add($"this.VisitorsWhoDidNotEnter = {(this.VisitorsWhoDidNotEnter == null ? "null" : this.VisitorsWhoDidNotEnter.ToString())}");
            toStringOutput.Add($"this.VisitorsWhoDidNotEnterFactor = {this.VisitorsWhoDidNotEnterFactor}");
            toStringOutput.Add($"this.ConversionRate = {this.ConversionRate}");
            toStringOutput.Add($"this.TotalDayVisitors = {(this.TotalDayVisitors == null ? "null" : this.TotalDayVisitors.ToString())}");
            toStringOutput.Add($"this.TotalDayVisitorsFactor = {this.TotalDayVisitorsFactor}");
        }
    }
}