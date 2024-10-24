// <copyright file="VisitorsByEntranceStoreResponse.cs" company="APIMatic">
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
    /// VisitorsByEntranceStoreResponse.
    /// </summary>
    public class VisitorsByEntranceStoreResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorsByEntranceStoreResponse"/> class.
        /// </summary>
        public VisitorsByEntranceStoreResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorsByEntranceStoreResponse"/> class.
        /// </summary>
        /// <param name="visitorEntries">visitorEntries.</param>
        public VisitorsByEntranceStoreResponse(
            List<Models.VisitorsByEntranceStoreResponseEntry> visitorEntries)
        {
            this.VisitorEntries = visitorEntries;
        }

        /// <summary>
        /// Gets or sets VisitorEntries.
        /// </summary>
        [JsonProperty("visitorEntries")]
        public List<Models.VisitorsByEntranceStoreResponseEntry> VisitorEntries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VisitorsByEntranceStoreResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is VisitorsByEntranceStoreResponse other &&                ((this.VisitorEntries == null && other.VisitorEntries == null) || (this.VisitorEntries?.Equals(other.VisitorEntries) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VisitorEntries = {(this.VisitorEntries == null ? "null" : $"[{string.Join(", ", this.VisitorEntries)} ]")}");
        }
    }
}