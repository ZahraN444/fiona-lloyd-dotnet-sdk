// <copyright file="JourneySankeyPathDefinition.cs" company="APIMatic">
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
using OnsightsIo.Standard.Models.Containers;
using OnsightsIo.Standard.Utilities;

namespace OnsightsIo.Standard.Models
{
    /// <summary>
    /// JourneySankeyPathDefinition.
    /// </summary>
    public class JourneySankeyPathDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySankeyPathDefinition"/> class.
        /// </summary>
        public JourneySankeyPathDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySankeyPathDefinition"/> class.
        /// </summary>
        /// <param name="pathRegionIds">pathRegionIds.</param>
        /// <param name="numberOfVisitorsFactor">numberOfVisitorsFactor.</param>
        /// <param name="numberOfVisitors">numberOfVisitors.</param>
        public JourneySankeyPathDefinition(
            List<JourneySankeyPathDefinitionPathRegionIds> pathRegionIds,
            double numberOfVisitorsFactor,
            int? numberOfVisitors = null)
        {
            this.NumberOfVisitors = numberOfVisitors;
            this.PathRegionIds = pathRegionIds;
            this.NumberOfVisitorsFactor = numberOfVisitorsFactor;
        }

        /// <summary>
        /// Gets or sets NumberOfVisitors.
        /// </summary>
        [JsonProperty("numberOfVisitors", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfVisitors { get; set; }

        /// <summary>
        /// Gets or sets PathRegionIds.
        /// </summary>
        [JsonProperty("pathRegionIds")]
        public List<JourneySankeyPathDefinitionPathRegionIds> PathRegionIds { get; set; }

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

            return $"JourneySankeyPathDefinition : ({string.Join(", ", toStringOutput)})";
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
            return obj is JourneySankeyPathDefinition other &&                ((this.NumberOfVisitors == null && other.NumberOfVisitors == null) || (this.NumberOfVisitors?.Equals(other.NumberOfVisitors) == true)) &&
                ((this.PathRegionIds == null && other.PathRegionIds == null) || (this.PathRegionIds?.Equals(other.PathRegionIds) == true)) &&
                this.NumberOfVisitorsFactor.Equals(other.NumberOfVisitorsFactor);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NumberOfVisitors = {(this.NumberOfVisitors == null ? "null" : this.NumberOfVisitors.ToString())}");
            toStringOutput.Add($"PathRegionIds = {(this.PathRegionIds == null ? "null" : this.PathRegionIds.ToString())}");
            toStringOutput.Add($"this.NumberOfVisitorsFactor = {this.NumberOfVisitorsFactor}");
        }
    }
}