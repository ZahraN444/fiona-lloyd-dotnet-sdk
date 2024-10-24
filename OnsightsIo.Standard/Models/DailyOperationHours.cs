// <copyright file="DailyOperationHours.cs" company="APIMatic">
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
    /// DailyOperationHours.
    /// </summary>
    public class DailyOperationHours
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyOperationHours"/> class.
        /// </summary>
        public DailyOperationHours()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyOperationHours"/> class.
        /// </summary>
        /// <param name="isOpen">isOpen.</param>
        /// <param name="startLocalHour">startLocalHour.</param>
        /// <param name="endLocalHour">endLocalHour.</param>
        public DailyOperationHours(
            bool isOpen,
            DateTime? startLocalHour = null,
            DateTime? endLocalHour = null)
        {
            this.IsOpen = isOpen;
            this.StartLocalHour = startLocalHour;
            this.EndLocalHour = endLocalHour;
        }

        /// <summary>
        /// Gets or sets IsOpen.
        /// </summary>
        [JsonProperty("isOpen")]
        public bool IsOpen { get; set; }

        /// <summary>
        /// Gets or sets StartLocalHour.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startLocalHour", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartLocalHour { get; set; }

        /// <summary>
        /// Gets or sets EndLocalHour.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endLocalHour", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndLocalHour { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DailyOperationHours : ({string.Join(", ", toStringOutput)})";
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
            return obj is DailyOperationHours other &&                this.IsOpen.Equals(other.IsOpen) &&
                ((this.StartLocalHour == null && other.StartLocalHour == null) || (this.StartLocalHour?.Equals(other.StartLocalHour) == true)) &&
                ((this.EndLocalHour == null && other.EndLocalHour == null) || (this.EndLocalHour?.Equals(other.EndLocalHour) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IsOpen = {this.IsOpen}");
            toStringOutput.Add($"this.StartLocalHour = {(this.StartLocalHour == null ? "null" : this.StartLocalHour.ToString())}");
            toStringOutput.Add($"this.EndLocalHour = {(this.EndLocalHour == null ? "null" : this.EndLocalHour.ToString())}");
        }
    }
}