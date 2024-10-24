// <copyright file="JourneysSankeyCriteria.cs" company="APIMatic">
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
    /// JourneysSankeyCriteria.
    /// </summary>
    public class JourneysSankeyCriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneysSankeyCriteria"/> class.
        /// </summary>
        public JourneysSankeyCriteria()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneysSankeyCriteria"/> class.
        /// </summary>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="maxWidth">maxWidth.</param>
        /// <param name="focus">focus.</param>
        /// <param name="maxDepth">maxDepth.</param>
        /// <param name="levelFiltersCollection">levelFiltersCollection.</param>
        /// <param name="excludeFullyVirtualResults">excludeFullyVirtualResults.</param>
        public JourneysSankeyCriteria(
            DateTime startDate,
            DateTime endDate,
            int maxWidth,
            Models.FocusEnum focus,
            int? maxDepth = null,
            List<Models.JourneyLevelFilters> levelFiltersCollection = null,
            bool? excludeFullyVirtualResults = null)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.MaxDepth = maxDepth;
            this.MaxWidth = maxWidth;
            this.Focus = focus;
            this.LevelFiltersCollection = levelFiltersCollection;
            this.ExcludeFullyVirtualResults = excludeFullyVirtualResults;
        }

        /// <summary>
        /// Gets or sets StartDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets EndDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets MaxDepth.
        /// </summary>
        [JsonProperty("maxDepth", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Gets or sets MaxWidth.
        /// </summary>
        [JsonProperty("maxWidth")]
        public int MaxWidth { get; set; }

        /// <summary>
        /// Gets or sets Focus.
        /// </summary>
        [JsonProperty("focus")]
        public Models.FocusEnum Focus { get; set; }

        /// <summary>
        /// Gets or sets LevelFiltersCollection.
        /// </summary>
        [JsonProperty("levelFiltersCollection", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.JourneyLevelFilters> LevelFiltersCollection { get; set; }

        /// <summary>
        /// Gets or sets ExcludeFullyVirtualResults.
        /// </summary>
        [JsonProperty("excludeFullyVirtualResults", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeFullyVirtualResults { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JourneysSankeyCriteria : ({string.Join(", ", toStringOutput)})";
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
            return obj is JourneysSankeyCriteria other &&                this.StartDate.Equals(other.StartDate) &&
                this.EndDate.Equals(other.EndDate) &&
                ((this.MaxDepth == null && other.MaxDepth == null) || (this.MaxDepth?.Equals(other.MaxDepth) == true)) &&
                this.MaxWidth.Equals(other.MaxWidth) &&
                this.Focus.Equals(other.Focus) &&
                ((this.LevelFiltersCollection == null && other.LevelFiltersCollection == null) || (this.LevelFiltersCollection?.Equals(other.LevelFiltersCollection) == true)) &&
                ((this.ExcludeFullyVirtualResults == null && other.ExcludeFullyVirtualResults == null) || (this.ExcludeFullyVirtualResults?.Equals(other.ExcludeFullyVirtualResults) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartDate = {this.StartDate}");
            toStringOutput.Add($"this.EndDate = {this.EndDate}");
            toStringOutput.Add($"this.MaxDepth = {(this.MaxDepth == null ? "null" : this.MaxDepth.ToString())}");
            toStringOutput.Add($"this.MaxWidth = {this.MaxWidth}");
            toStringOutput.Add($"this.Focus = {this.Focus}");
            toStringOutput.Add($"this.LevelFiltersCollection = {(this.LevelFiltersCollection == null ? "null" : $"[{string.Join(", ", this.LevelFiltersCollection)} ]")}");
            toStringOutput.Add($"this.ExcludeFullyVirtualResults = {(this.ExcludeFullyVirtualResults == null ? "null" : this.ExcludeFullyVirtualResults.ToString())}");
        }
    }
}