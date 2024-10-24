// <copyright file="RegionFeatureResponse.cs" company="APIMatic">
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
    /// RegionFeatureResponse.
    /// </summary>
    public class RegionFeatureResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionFeatureResponse"/> class.
        /// </summary>
        public RegionFeatureResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionFeatureResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="regionId">regionId.</param>
        /// <param name="boundary">boundary.</param>
        /// <param name="featureCategory">featureCategory.</param>
        public RegionFeatureResponse(
            Guid id,
            string name,
            Guid regionId,
            RegionFeatureResponseBoundary boundary,
            Models.FeatureCategoryEnum featureCategory)
        {
            this.Id = id;
            this.Name = name;
            this.RegionId = regionId;
            this.Boundary = boundary;
            this.FeatureCategory = featureCategory;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets RegionId.
        /// </summary>
        [JsonProperty("regionId")]
        public Guid RegionId { get; set; }

        /// <summary>
        /// Gets or sets Boundary.
        /// </summary>
        [JsonProperty("boundary")]
        public RegionFeatureResponseBoundary Boundary { get; set; }

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

            return $"RegionFeatureResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is RegionFeatureResponse other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.RegionId.Equals(other.RegionId) &&
                ((this.Boundary == null && other.Boundary == null) || (this.Boundary?.Equals(other.Boundary) == true)) &&
                this.FeatureCategory.Equals(other.FeatureCategory);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.RegionId = {this.RegionId}");
            toStringOutput.Add($"Boundary = {(this.Boundary == null ? "null" : this.Boundary.ToString())}");
            toStringOutput.Add($"this.FeatureCategory = {this.FeatureCategory}");
        }
    }
}