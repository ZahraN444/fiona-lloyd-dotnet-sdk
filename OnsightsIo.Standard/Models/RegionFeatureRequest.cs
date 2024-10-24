// <copyright file="RegionFeatureRequest.cs" company="APIMatic">
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
    /// RegionFeatureRequest.
    /// </summary>
    public class RegionFeatureRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionFeatureRequest"/> class.
        /// </summary>
        public RegionFeatureRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionFeatureRequest"/> class.
        /// </summary>
        /// <param name="regionId">regionId.</param>
        /// <param name="name">name.</param>
        /// <param name="boundary">boundary.</param>
        /// <param name="featureCategory">featureCategory.</param>
        public RegionFeatureRequest(
            Guid regionId,
            string name,
            RegionFeatureRequestBoundary boundary,
            Models.FeatureCategoryEnum featureCategory)
        {
            this.RegionId = regionId;
            this.Name = name;
            this.Boundary = boundary;
            this.FeatureCategory = featureCategory;
        }

        /// <summary>
        /// Gets or sets RegionId.
        /// </summary>
        [JsonProperty("regionId")]
        public Guid RegionId { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Boundary.
        /// </summary>
        [JsonProperty("boundary")]
        public RegionFeatureRequestBoundary Boundary { get; set; }

        /// <summary>
        /// Gets or sets FeatureCategory.
        /// </summary>
        [JsonProperty("featureCategory")]
        public Models.FeatureCategoryEnum FeatureCategory { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegionFeatureRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is RegionFeatureRequest other &&                this.RegionId.Equals(other.RegionId) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Boundary == null && other.Boundary == null) || (this.Boundary?.Equals(other.Boundary) == true)) &&
                this.FeatureCategory.Equals(other.FeatureCategory);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegionId = {this.RegionId}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"Boundary = {(this.Boundary == null ? "null" : this.Boundary.ToString())}");
            toStringOutput.Add($"this.FeatureCategory = {this.FeatureCategory}");
        }
    }
}