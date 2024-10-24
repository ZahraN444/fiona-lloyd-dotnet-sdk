// <copyright file="Region.cs" company="APIMatic">
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
    /// Region.
    /// </summary>
    public class Region
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Region"/> class.
        /// </summary>
        public Region()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Region"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="category">category.</param>
        /// <param name="geometryWKT">geometryWKT.</param>
        /// <param name="features">features.</param>
        /// <param name="parentId">parentId.</param>
        public Region(
            Guid id,
            string name,
            Models.Category2Enum category,
            string geometryWKT = null,
            List<Models.RegionFeature> features = null,
            Guid? parentId = null)
        {
            this.Id = id;
            this.Name = name;
            this.GeometryWKT = geometryWKT;
            this.Category = category;
            this.Features = features;
            this.ParentId = parentId;
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
        /// Gets or sets GeometryWKT.
        /// </summary>
        [JsonProperty("geometryWKT", NullValueHandling = NullValueHandling.Ignore)]
        public string GeometryWKT { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        [JsonProperty("category")]
        public Models.Category2Enum Category { get; set; }

        /// <summary>
        /// Gets or sets Features.
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RegionFeature> Features { get; set; }

        /// <summary>
        /// Gets or sets ParentId.
        /// </summary>
        [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ParentId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Region : ({string.Join(", ", toStringOutput)})";
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
            return obj is Region other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.GeometryWKT == null && other.GeometryWKT == null) || (this.GeometryWKT?.Equals(other.GeometryWKT) == true)) &&
                this.Category.Equals(other.Category) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
                ((this.ParentId == null && other.ParentId == null) || (this.ParentId?.Equals(other.ParentId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.GeometryWKT = {(this.GeometryWKT == null ? "null" : this.GeometryWKT)}");
            toStringOutput.Add($"this.Category = {this.Category}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : $"[{string.Join(", ", this.Features)} ]")}");
            toStringOutput.Add($"this.ParentId = {(this.ParentId == null ? "null" : this.ParentId.ToString())}");
        }
    }
}