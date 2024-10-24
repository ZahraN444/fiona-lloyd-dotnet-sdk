// <copyright file="OperationHours.cs" company="APIMatic">
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
    /// OperationHours.
    /// </summary>
    public class OperationHours
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationHours"/> class.
        /// </summary>
        public OperationHours()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationHours"/> class.
        /// </summary>
        /// <param name="monday">monday.</param>
        /// <param name="tuesday">tuesday.</param>
        /// <param name="wednesday">wednesday.</param>
        /// <param name="thursday">thursday.</param>
        /// <param name="friday">friday.</param>
        /// <param name="saturday">saturday.</param>
        /// <param name="sunday">sunday.</param>
        public OperationHours(
            Models.DailyOperationHours monday,
            Models.DailyOperationHours tuesday,
            Models.DailyOperationHours wednesday,
            Models.DailyOperationHours thursday,
            Models.DailyOperationHours friday,
            Models.DailyOperationHours saturday,
            Models.DailyOperationHours sunday)
        {
            this.Monday = monday;
            this.Tuesday = tuesday;
            this.Wednesday = wednesday;
            this.Thursday = thursday;
            this.Friday = friday;
            this.Saturday = saturday;
            this.Sunday = sunday;
        }

        /// <summary>
        /// Gets or sets Monday.
        /// </summary>
        [JsonProperty("monday")]
        public Models.DailyOperationHours Monday { get; set; }

        /// <summary>
        /// Gets or sets Tuesday.
        /// </summary>
        [JsonProperty("tuesday")]
        public Models.DailyOperationHours Tuesday { get; set; }

        /// <summary>
        /// Gets or sets Wednesday.
        /// </summary>
        [JsonProperty("wednesday")]
        public Models.DailyOperationHours Wednesday { get; set; }

        /// <summary>
        /// Gets or sets Thursday.
        /// </summary>
        [JsonProperty("thursday")]
        public Models.DailyOperationHours Thursday { get; set; }

        /// <summary>
        /// Gets or sets Friday.
        /// </summary>
        [JsonProperty("friday")]
        public Models.DailyOperationHours Friday { get; set; }

        /// <summary>
        /// Gets or sets Saturday.
        /// </summary>
        [JsonProperty("saturday")]
        public Models.DailyOperationHours Saturday { get; set; }

        /// <summary>
        /// Gets or sets Sunday.
        /// </summary>
        [JsonProperty("sunday")]
        public Models.DailyOperationHours Sunday { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OperationHours : ({string.Join(", ", toStringOutput)})";
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
            return obj is OperationHours other &&                ((this.Monday == null && other.Monday == null) || (this.Monday?.Equals(other.Monday) == true)) &&
                ((this.Tuesday == null && other.Tuesday == null) || (this.Tuesday?.Equals(other.Tuesday) == true)) &&
                ((this.Wednesday == null && other.Wednesday == null) || (this.Wednesday?.Equals(other.Wednesday) == true)) &&
                ((this.Thursday == null && other.Thursday == null) || (this.Thursday?.Equals(other.Thursday) == true)) &&
                ((this.Friday == null && other.Friday == null) || (this.Friday?.Equals(other.Friday) == true)) &&
                ((this.Saturday == null && other.Saturday == null) || (this.Saturday?.Equals(other.Saturday) == true)) &&
                ((this.Sunday == null && other.Sunday == null) || (this.Sunday?.Equals(other.Sunday) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Monday = {(this.Monday == null ? "null" : this.Monday.ToString())}");
            toStringOutput.Add($"this.Tuesday = {(this.Tuesday == null ? "null" : this.Tuesday.ToString())}");
            toStringOutput.Add($"this.Wednesday = {(this.Wednesday == null ? "null" : this.Wednesday.ToString())}");
            toStringOutput.Add($"this.Thursday = {(this.Thursday == null ? "null" : this.Thursday.ToString())}");
            toStringOutput.Add($"this.Friday = {(this.Friday == null ? "null" : this.Friday.ToString())}");
            toStringOutput.Add($"this.Saturday = {(this.Saturday == null ? "null" : this.Saturday.ToString())}");
            toStringOutput.Add($"this.Sunday = {(this.Sunday == null ? "null" : this.Sunday.ToString())}");
        }
    }
}