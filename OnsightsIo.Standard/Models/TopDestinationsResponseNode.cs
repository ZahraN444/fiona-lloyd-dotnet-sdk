// <copyright file="TopDestinationsResponseNode.cs" company="APIMatic">
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
    /// TopDestinationsResponseNode.
    /// </summary>
    public class TopDestinationsResponseNode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopDestinationsResponseNode"/> class.
        /// </summary>
        public TopDestinationsResponseNode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopDestinationsResponseNode"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="mValue">value.</param>
        /// <param name="children">children.</param>
        /// <param name="fractionOfParent">fractionOfParent.</param>
        /// <param name="fractionOfTotalOfSelection">fractionOfTotalOfSelection.</param>
        /// <param name="fractionOfAll">fractionOfAll.</param>
        public TopDestinationsResponseNode(
            string id,
            long? mValue = null,
            List<Models.TopDestinationsResponseNode> children = null,
            double? fractionOfParent = null,
            double? fractionOfTotalOfSelection = null,
            double? fractionOfAll = null)
        {
            this.MValue = mValue;
            this.Id = id;
            this.Children = children;
            this.FractionOfParent = fractionOfParent;
            this.FractionOfTotalOfSelection = fractionOfTotalOfSelection;
            this.FractionOfAll = fractionOfAll;
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? MValue { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Children.
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TopDestinationsResponseNode> Children { get; set; }

        /// <summary>
        /// Gets or sets FractionOfParent.
        /// </summary>
        [JsonProperty("fractionOfParent", NullValueHandling = NullValueHandling.Ignore)]
        public double? FractionOfParent { get; set; }

        /// <summary>
        /// Gets or sets FractionOfTotalOfSelection.
        /// </summary>
        [JsonProperty("fractionOfTotalOfSelection", NullValueHandling = NullValueHandling.Ignore)]
        public double? FractionOfTotalOfSelection { get; set; }

        /// <summary>
        /// Gets or sets FractionOfAll.
        /// </summary>
        [JsonProperty("fractionOfAll", NullValueHandling = NullValueHandling.Ignore)]
        public double? FractionOfAll { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TopDestinationsResponseNode : ({string.Join(", ", toStringOutput)})";
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
            return obj is TopDestinationsResponseNode other &&                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Children == null && other.Children == null) || (this.Children?.Equals(other.Children) == true)) &&
                ((this.FractionOfParent == null && other.FractionOfParent == null) || (this.FractionOfParent?.Equals(other.FractionOfParent) == true)) &&
                ((this.FractionOfTotalOfSelection == null && other.FractionOfTotalOfSelection == null) || (this.FractionOfTotalOfSelection?.Equals(other.FractionOfTotalOfSelection) == true)) &&
                ((this.FractionOfAll == null && other.FractionOfAll == null) || (this.FractionOfAll?.Equals(other.FractionOfAll) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Children = {(this.Children == null ? "null" : $"[{string.Join(", ", this.Children)} ]")}");
            toStringOutput.Add($"this.FractionOfParent = {(this.FractionOfParent == null ? "null" : this.FractionOfParent.ToString())}");
            toStringOutput.Add($"this.FractionOfTotalOfSelection = {(this.FractionOfTotalOfSelection == null ? "null" : this.FractionOfTotalOfSelection.ToString())}");
            toStringOutput.Add($"this.FractionOfAll = {(this.FractionOfAll == null ? "null" : this.FractionOfAll.ToString())}");
        }
    }
}