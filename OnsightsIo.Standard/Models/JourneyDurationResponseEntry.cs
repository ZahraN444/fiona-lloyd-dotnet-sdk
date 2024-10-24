// <copyright file="JourneyDurationResponseEntry.cs" company="APIMatic">
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
    /// JourneyDurationResponseEntry.
    /// </summary>
    public class JourneyDurationResponseEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyDurationResponseEntry"/> class.
        /// </summary>
        public JourneyDurationResponseEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyDurationResponseEntry"/> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="minMinutes">minMinutes.</param>
        /// <param name="maxMinutes">maxMinutes.</param>
        /// <param name="lowerQuartileMinutes">lowerQuartileMinutes.</param>
        /// <param name="upperQuartileMinutes">upperQuartileMinutes.</param>
        /// <param name="medianMinutes">medianMinutes.</param>
        /// <param name="meanMinutes">meanMinutes.</param>
        /// <param name="observations">observations.</param>
        public JourneyDurationResponseEntry(
            DateTime date,
            double minMinutes,
            double maxMinutes,
            double lowerQuartileMinutes,
            double upperQuartileMinutes,
            double medianMinutes,
            double meanMinutes,
            long? observations = null)
        {
            this.Date = date;
            this.Observations = observations;
            this.MinMinutes = minMinutes;
            this.MaxMinutes = maxMinutes;
            this.LowerQuartileMinutes = lowerQuartileMinutes;
            this.UpperQuartileMinutes = upperQuartileMinutes;
            this.MedianMinutes = medianMinutes;
            this.MeanMinutes = meanMinutes;
        }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets Observations.
        /// </summary>
        [JsonProperty("observations", NullValueHandling = NullValueHandling.Ignore)]
        public long? Observations { get; set; }

        /// <summary>
        /// Gets or sets MinMinutes.
        /// </summary>
        [JsonProperty("minMinutes")]
        public double MinMinutes { get; set; }

        /// <summary>
        /// Gets or sets MaxMinutes.
        /// </summary>
        [JsonProperty("maxMinutes")]
        public double MaxMinutes { get; set; }

        /// <summary>
        /// Gets or sets LowerQuartileMinutes.
        /// </summary>
        [JsonProperty("lowerQuartileMinutes")]
        public double LowerQuartileMinutes { get; set; }

        /// <summary>
        /// Gets or sets UpperQuartileMinutes.
        /// </summary>
        [JsonProperty("upperQuartileMinutes")]
        public double UpperQuartileMinutes { get; set; }

        /// <summary>
        /// Gets or sets MedianMinutes.
        /// </summary>
        [JsonProperty("medianMinutes")]
        public double MedianMinutes { get; set; }

        /// <summary>
        /// Gets or sets MeanMinutes.
        /// </summary>
        [JsonProperty("meanMinutes")]
        public double MeanMinutes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JourneyDurationResponseEntry : ({string.Join(", ", toStringOutput)})";
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
            return obj is JourneyDurationResponseEntry other &&                this.Date.Equals(other.Date) &&
                ((this.Observations == null && other.Observations == null) || (this.Observations?.Equals(other.Observations) == true)) &&
                this.MinMinutes.Equals(other.MinMinutes) &&
                this.MaxMinutes.Equals(other.MaxMinutes) &&
                this.LowerQuartileMinutes.Equals(other.LowerQuartileMinutes) &&
                this.UpperQuartileMinutes.Equals(other.UpperQuartileMinutes) &&
                this.MedianMinutes.Equals(other.MedianMinutes) &&
                this.MeanMinutes.Equals(other.MeanMinutes);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Date = {this.Date}");
            toStringOutput.Add($"this.Observations = {(this.Observations == null ? "null" : this.Observations.ToString())}");
            toStringOutput.Add($"this.MinMinutes = {this.MinMinutes}");
            toStringOutput.Add($"this.MaxMinutes = {this.MaxMinutes}");
            toStringOutput.Add($"this.LowerQuartileMinutes = {this.LowerQuartileMinutes}");
            toStringOutput.Add($"this.UpperQuartileMinutes = {this.UpperQuartileMinutes}");
            toStringOutput.Add($"this.MedianMinutes = {this.MedianMinutes}");
            toStringOutput.Add($"this.MeanMinutes = {this.MeanMinutes}");
        }
    }
}