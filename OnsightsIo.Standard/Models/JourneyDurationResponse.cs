// <copyright file="JourneyDurationResponse.cs" company="APIMatic">
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
    /// JourneyDurationResponse.
    /// </summary>
    public class JourneyDurationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyDurationResponse"/> class.
        /// </summary>
        public JourneyDurationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyDurationResponse"/> class.
        /// </summary>
        /// <param name="journeyDurations">journeyDurations.</param>
        public JourneyDurationResponse(
            List<Models.JourneyDurationResponseEntry> journeyDurations)
        {
            this.JourneyDurations = journeyDurations;
        }

        /// <summary>
        /// Gets or sets JourneyDurations.
        /// </summary>
        [JsonProperty("journeyDurations")]
        public List<Models.JourneyDurationResponseEntry> JourneyDurations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JourneyDurationResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is JourneyDurationResponse other &&                ((this.JourneyDurations == null && other.JourneyDurations == null) || (this.JourneyDurations?.Equals(other.JourneyDurations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.JourneyDurations = {(this.JourneyDurations == null ? "null" : $"[{string.Join(", ", this.JourneyDurations)} ]")}");
        }
    }
}