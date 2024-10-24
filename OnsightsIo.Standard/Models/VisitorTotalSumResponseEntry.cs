// <copyright file="VisitorTotalSumResponseEntry.cs" company="APIMatic">
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
    /// VisitorTotalSumResponseEntry.
    /// </summary>
    public class VisitorTotalSumResponseEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorTotalSumResponseEntry"/> class.
        /// </summary>
        public VisitorTotalSumResponseEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorTotalSumResponseEntry"/> class.
        /// </summary>
        /// <param name="regionId">regionId.</param>
        /// <param name="numberOfVisitorsFactor">numberOfVisitorsFactor.</param>
        /// <param name="numberOfVisitors">numberOfVisitors.</param>
        public VisitorTotalSumResponseEntry(
            Guid regionId,
            double numberOfVisitorsFactor,
            long? numberOfVisitors = null)
        {
            this.RegionId = regionId;
            this.NumberOfVisitors = numberOfVisitors;
            this.NumberOfVisitorsFactor = numberOfVisitorsFactor;
        }

        /// <summary>
        /// Gets or sets RegionId.
        /// </summary>
        [JsonProperty("regionId")]
        public Guid RegionId { get; set; }

        /// <summary>
        /// Gets or sets NumberOfVisitors.
        /// </summary>
        [JsonProperty("numberOfVisitors", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumberOfVisitors { get; set; }

        /// <summary>
        /// Gets or sets NumberOfVisitorsFactor.
        /// </summary>
        [JsonProperty("numberOfVisitorsFactor")]
        public double NumberOfVisitorsFactor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VisitorTotalSumResponseEntry : ({string.Join(", ", toStringOutput)})";
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
            return obj is VisitorTotalSumResponseEntry other &&                this.RegionId.Equals(other.RegionId) &&
                ((this.NumberOfVisitors == null && other.NumberOfVisitors == null) || (this.NumberOfVisitors?.Equals(other.NumberOfVisitors) == true)) &&
                this.NumberOfVisitorsFactor.Equals(other.NumberOfVisitorsFactor);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegionId = {this.RegionId}");
            toStringOutput.Add($"this.NumberOfVisitors = {(this.NumberOfVisitors == null ? "null" : this.NumberOfVisitors.ToString())}");
            toStringOutput.Add($"this.NumberOfVisitorsFactor = {this.NumberOfVisitorsFactor}");
        }
    }
}