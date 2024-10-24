// <copyright file="VisitorDestinationStoreResponse.cs" company="APIMatic">
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
    /// VisitorDestinationStoreResponse.
    /// </summary>
    public class VisitorDestinationStoreResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorDestinationStoreResponse"/> class.
        /// </summary>
        public VisitorDestinationStoreResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorDestinationStoreResponse"/> class.
        /// </summary>
        /// <param name="destinationEntries">destinationEntries.</param>
        public VisitorDestinationStoreResponse(
            List<Models.VisitorDestinationStoreResponseEntry> destinationEntries)
        {
            this.DestinationEntries = destinationEntries;
        }

        /// <summary>
        /// Gets or sets DestinationEntries.
        /// </summary>
        [JsonProperty("destinationEntries")]
        public List<Models.VisitorDestinationStoreResponseEntry> DestinationEntries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VisitorDestinationStoreResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is VisitorDestinationStoreResponse other &&                ((this.DestinationEntries == null && other.DestinationEntries == null) || (this.DestinationEntries?.Equals(other.DestinationEntries) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DestinationEntries = {(this.DestinationEntries == null ? "null" : $"[{string.Join(", ", this.DestinationEntries)} ]")}");
        }
    }
}