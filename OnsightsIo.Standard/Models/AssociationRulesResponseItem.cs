// <copyright file="AssociationRulesResponseItem.cs" company="APIMatic">
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
    /// AssociationRulesResponseItem.
    /// </summary>
    public class AssociationRulesResponseItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationRulesResponseItem"/> class.
        /// </summary>
        public AssociationRulesResponseItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationRulesResponseItem"/> class.
        /// </summary>
        /// <param name="associatedRegionIds">associatedRegionIds.</param>
        /// <param name="confidence">confidence.</param>
        public AssociationRulesResponseItem(
            List<Guid> associatedRegionIds,
            double confidence)
        {
            this.AssociatedRegionIds = associatedRegionIds;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Gets or sets AssociatedRegionIds.
        /// </summary>
        [JsonProperty("associatedRegionIds")]
        public List<Guid> AssociatedRegionIds { get; set; }

        /// <summary>
        /// Gets or sets Confidence.
        /// </summary>
        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AssociationRulesResponseItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is AssociationRulesResponseItem other &&                ((this.AssociatedRegionIds == null && other.AssociatedRegionIds == null) || (this.AssociatedRegionIds?.Equals(other.AssociatedRegionIds) == true)) &&
                this.Confidence.Equals(other.Confidence);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AssociatedRegionIds = {(this.AssociatedRegionIds == null ? "null" : $"[{string.Join(", ", this.AssociatedRegionIds)} ]")}");
            toStringOutput.Add($"this.Confidence = {this.Confidence}");
        }
    }
}