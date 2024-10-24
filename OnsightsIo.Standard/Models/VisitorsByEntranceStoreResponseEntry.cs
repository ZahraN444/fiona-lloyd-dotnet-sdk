// <copyright file="VisitorsByEntranceStoreResponseEntry.cs" company="APIMatic">
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
    /// VisitorsByEntranceStoreResponseEntry.
    /// </summary>
    public class VisitorsByEntranceStoreResponseEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorsByEntranceStoreResponseEntry"/> class.
        /// </summary>
        public VisitorsByEntranceStoreResponseEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorsByEntranceStoreResponseEntry"/> class.
        /// </summary>
        /// <param name="regionId">regionId.</param>
        /// <param name="visitorsFactor">visitorsFactor.</param>
        /// <param name="topPeakDay">topPeakDay.</param>
        /// <param name="topPeakHour">topPeakHour.</param>
        /// <param name="topPeakVisitorsFactor">topPeakVisitorsFactor.</param>
        /// <param name="totalVisitorsByEntrance">totalVisitorsByEntrance.</param>
        /// <param name="topPeakVisitors">topPeakVisitors.</param>
        public VisitorsByEntranceStoreResponseEntry(
            Guid regionId,
            double visitorsFactor,
            DateTime topPeakDay,
            int topPeakHour,
            double topPeakVisitorsFactor,
            long? totalVisitorsByEntrance = null,
            long? topPeakVisitors = null)
        {
            this.RegionId = regionId;
            this.TotalVisitorsByEntrance = totalVisitorsByEntrance;
            this.VisitorsFactor = visitorsFactor;
            this.TopPeakDay = topPeakDay;
            this.TopPeakHour = topPeakHour;
            this.TopPeakVisitors = topPeakVisitors;
            this.TopPeakVisitorsFactor = topPeakVisitorsFactor;
        }

        /// <summary>
        /// Gets or sets RegionId.
        /// </summary>
        [JsonProperty("regionId")]
        public Guid RegionId { get; set; }

        /// <summary>
        /// Gets or sets TotalVisitorsByEntrance.
        /// </summary>
        [JsonProperty("totalVisitorsByEntrance", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalVisitorsByEntrance { get; set; }

        /// <summary>
        /// Gets or sets VisitorsFactor.
        /// </summary>
        [JsonProperty("visitorsFactor")]
        public double VisitorsFactor { get; set; }

        /// <summary>
        /// Gets or sets TopPeakDay.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("topPeakDay")]
        public DateTime TopPeakDay { get; set; }

        /// <summary>
        /// Gets or sets TopPeakHour.
        /// </summary>
        [JsonProperty("topPeakHour")]
        public int TopPeakHour { get; set; }

        /// <summary>
        /// Gets or sets TopPeakVisitors.
        /// </summary>
        [JsonProperty("topPeakVisitors", NullValueHandling = NullValueHandling.Ignore)]
        public long? TopPeakVisitors { get; set; }

        /// <summary>
        /// Gets or sets TopPeakVisitorsFactor.
        /// </summary>
        [JsonProperty("topPeakVisitorsFactor")]
        public double TopPeakVisitorsFactor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VisitorsByEntranceStoreResponseEntry : ({string.Join(", ", toStringOutput)})";
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
            return obj is VisitorsByEntranceStoreResponseEntry other &&                this.RegionId.Equals(other.RegionId) &&
                ((this.TotalVisitorsByEntrance == null && other.TotalVisitorsByEntrance == null) || (this.TotalVisitorsByEntrance?.Equals(other.TotalVisitorsByEntrance) == true)) &&
                this.VisitorsFactor.Equals(other.VisitorsFactor) &&
                this.TopPeakDay.Equals(other.TopPeakDay) &&
                this.TopPeakHour.Equals(other.TopPeakHour) &&
                ((this.TopPeakVisitors == null && other.TopPeakVisitors == null) || (this.TopPeakVisitors?.Equals(other.TopPeakVisitors) == true)) &&
                this.TopPeakVisitorsFactor.Equals(other.TopPeakVisitorsFactor);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegionId = {this.RegionId}");
            toStringOutput.Add($"this.TotalVisitorsByEntrance = {(this.TotalVisitorsByEntrance == null ? "null" : this.TotalVisitorsByEntrance.ToString())}");
            toStringOutput.Add($"this.VisitorsFactor = {this.VisitorsFactor}");
            toStringOutput.Add($"this.TopPeakDay = {this.TopPeakDay}");
            toStringOutput.Add($"this.TopPeakHour = {this.TopPeakHour}");
            toStringOutput.Add($"this.TopPeakVisitors = {(this.TopPeakVisitors == null ? "null" : this.TopPeakVisitors.ToString())}");
            toStringOutput.Add($"this.TopPeakVisitorsFactor = {this.TopPeakVisitorsFactor}");
        }
    }
}