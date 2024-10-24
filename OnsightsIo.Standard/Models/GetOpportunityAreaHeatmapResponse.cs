// <copyright file="GetOpportunityAreaHeatmapResponse.cs" company="APIMatic">
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
    /// GetOpportunityAreaHeatmapResponse.
    /// </summary>
    public class GetOpportunityAreaHeatmapResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOpportunityAreaHeatmapResponse"/> class.
        /// </summary>
        public GetOpportunityAreaHeatmapResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOpportunityAreaHeatmapResponse"/> class.
        /// </summary>
        /// <param name="opportunityAreaHeatmapsEntries">opportunityAreaHeatmapsEntries.</param>
        public GetOpportunityAreaHeatmapResponse(
            List<Models.GetOpportunityAreaHeatmapResponseEntry> opportunityAreaHeatmapsEntries)
        {
            this.OpportunityAreaHeatmapsEntries = opportunityAreaHeatmapsEntries;
        }

        /// <summary>
        /// Gets or sets OpportunityAreaHeatmapsEntries.
        /// </summary>
        [JsonProperty("opportunityAreaHeatmapsEntries")]
        public List<Models.GetOpportunityAreaHeatmapResponseEntry> OpportunityAreaHeatmapsEntries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetOpportunityAreaHeatmapResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetOpportunityAreaHeatmapResponse other &&                ((this.OpportunityAreaHeatmapsEntries == null && other.OpportunityAreaHeatmapsEntries == null) || (this.OpportunityAreaHeatmapsEntries?.Equals(other.OpportunityAreaHeatmapsEntries) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OpportunityAreaHeatmapsEntries = {(this.OpportunityAreaHeatmapsEntries == null ? "null" : $"[{string.Join(", ", this.OpportunityAreaHeatmapsEntries)} ]")}");
        }
    }
}