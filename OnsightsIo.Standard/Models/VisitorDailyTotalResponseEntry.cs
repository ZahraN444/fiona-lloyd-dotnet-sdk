// <copyright file="VisitorDailyTotalResponseEntry.cs" company="APIMatic">
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
    /// VisitorDailyTotalResponseEntry.
    /// </summary>
    public class VisitorDailyTotalResponseEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorDailyTotalResponseEntry"/> class.
        /// </summary>
        public VisitorDailyTotalResponseEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorDailyTotalResponseEntry"/> class.
        /// </summary>
        /// <param name="localDate">localDate.</param>
        /// <param name="numberOfVisitorsFactor">numberOfVisitorsFactor.</param>
        /// <param name="numberOfVisitors">numberOfVisitors.</param>
        public VisitorDailyTotalResponseEntry(
            DateTime localDate,
            double numberOfVisitorsFactor,
            long? numberOfVisitors = null)
        {
            this.LocalDate = localDate;
            this.NumberOfVisitors = numberOfVisitors;
            this.NumberOfVisitorsFactor = numberOfVisitorsFactor;
        }

        /// <summary>
        /// Gets or sets LocalDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("localDate")]
        public DateTime LocalDate { get; set; }

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

            return $"VisitorDailyTotalResponseEntry : ({string.Join(", ", toStringOutput)})";
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
            return obj is VisitorDailyTotalResponseEntry other &&                this.LocalDate.Equals(other.LocalDate) &&
                ((this.NumberOfVisitors == null && other.NumberOfVisitors == null) || (this.NumberOfVisitors?.Equals(other.NumberOfVisitors) == true)) &&
                this.NumberOfVisitorsFactor.Equals(other.NumberOfVisitorsFactor);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocalDate = {this.LocalDate}");
            toStringOutput.Add($"this.NumberOfVisitors = {(this.NumberOfVisitors == null ? "null" : this.NumberOfVisitors.ToString())}");
            toStringOutput.Add($"this.NumberOfVisitorsFactor = {this.NumberOfVisitorsFactor}");
        }
    }
}