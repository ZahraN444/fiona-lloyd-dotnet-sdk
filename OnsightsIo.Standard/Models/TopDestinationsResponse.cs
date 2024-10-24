// <copyright file="TopDestinationsResponse.cs" company="APIMatic">
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
    /// TopDestinationsResponse.
    /// </summary>
    public class TopDestinationsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopDestinationsResponse"/> class.
        /// </summary>
        public TopDestinationsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopDestinationsResponse"/> class.
        /// </summary>
        /// <param name="topDestinations">topDestinations.</param>
        public TopDestinationsResponse(
            Models.TopDestinationsResponseNode topDestinations)
        {
            this.TopDestinations = topDestinations;
        }

        /// <summary>
        /// Gets or sets TopDestinations.
        /// </summary>
        [JsonProperty("topDestinations")]
        public Models.TopDestinationsResponseNode TopDestinations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TopDestinationsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is TopDestinationsResponse other &&                ((this.TopDestinations == null && other.TopDestinations == null) || (this.TopDestinations?.Equals(other.TopDestinations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TopDestinations = {(this.TopDestinations == null ? "null" : this.TopDestinations.ToString())}");
        }
    }
}