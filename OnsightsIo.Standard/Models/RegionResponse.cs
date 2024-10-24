// <copyright file="RegionResponse.cs" company="APIMatic">
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
    /// RegionResponse.
    /// </summary>
    public class RegionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionResponse"/> class.
        /// </summary>
        public RegionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="boundary">boundary.</param>
        /// <param name="floorId">floorId.</param>
        /// <param name="facilityId">facilityId.</param>
        /// <param name="category">category.</param>
        /// <param name="disabled">disabled.</param>
        /// <param name="description">description.</param>
        /// <param name="temporary">temporary.</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="logoId">logoId.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="setupDate">setupDate.</param>
        /// <param name="teardownDate">teardownDate.</param>
        /// <param name="features">features.</param>
        public RegionResponse(
            Guid id,
            string name,
            RegionResponseBoundary boundary,
            Guid floorId,
            Guid facilityId,
            Models.CategoryEnum category,
            bool disabled,
            string description = null,
            bool? temporary = null,
            Guid? parentId = null,
            Guid? logoId = null,
            Models.RegionResponseMetadata metadata = null,
            DateTime? createdAt = null,
            DateTime? setupDate = null,
            DateTime? teardownDate = null,
            List<Models.RegionFeatureResponse> features = null)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Boundary = boundary;
            this.Temporary = temporary;
            this.FloorId = floorId;
            this.FacilityId = facilityId;
            this.ParentId = parentId;
            this.LogoId = logoId;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.SetupDate = setupDate;
            this.TeardownDate = teardownDate;
            this.Category = category;
            this.Disabled = disabled;
            this.Features = features;
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
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Boundary.
        /// </summary>
        [JsonProperty("boundary")]
        public RegionResponseBoundary Boundary { get; set; }

        /// <summary>
        /// Gets or sets Temporary.
        /// </summary>
        [JsonProperty("temporary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Temporary { get; set; }

        /// <summary>
        /// Gets or sets FloorId.
        /// </summary>
        [JsonProperty("floorId")]
        public Guid FloorId { get; set; }

        /// <summary>
        /// Gets or sets FacilityId.
        /// </summary>
        [JsonProperty("facilityId")]
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Gets or sets ParentId.
        /// </summary>
        [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or sets LogoId.
        /// </summary>
        [JsonProperty("logoId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LogoId { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RegionResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets SetupDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("setupDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SetupDate { get; set; }

        /// <summary>
        /// Gets or sets TeardownDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("teardownDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TeardownDate { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        [JsonProperty("category")]
        public Models.CategoryEnum Category { get; set; }

        /// <summary>
        /// Gets or sets Disabled.
        /// </summary>
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        /// <summary>
        /// Gets or sets Features.
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RegionFeatureResponse> Features { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegionResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is RegionResponse other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Boundary == null && other.Boundary == null) || (this.Boundary?.Equals(other.Boundary) == true)) &&
                ((this.Temporary == null && other.Temporary == null) || (this.Temporary?.Equals(other.Temporary) == true)) &&
                this.FloorId.Equals(other.FloorId) &&
                this.FacilityId.Equals(other.FacilityId) &&
                ((this.ParentId == null && other.ParentId == null) || (this.ParentId?.Equals(other.ParentId) == true)) &&
                ((this.LogoId == null && other.LogoId == null) || (this.LogoId?.Equals(other.LogoId) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.SetupDate == null && other.SetupDate == null) || (this.SetupDate?.Equals(other.SetupDate) == true)) &&
                ((this.TeardownDate == null && other.TeardownDate == null) || (this.TeardownDate?.Equals(other.TeardownDate) == true)) &&
                this.Category.Equals(other.Category) &&
                this.Disabled.Equals(other.Disabled) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"Boundary = {(this.Boundary == null ? "null" : this.Boundary.ToString())}");
            toStringOutput.Add($"this.Temporary = {(this.Temporary == null ? "null" : this.Temporary.ToString())}");
            toStringOutput.Add($"this.FloorId = {this.FloorId}");
            toStringOutput.Add($"this.FacilityId = {this.FacilityId}");
            toStringOutput.Add($"this.ParentId = {(this.ParentId == null ? "null" : this.ParentId.ToString())}");
            toStringOutput.Add($"this.LogoId = {(this.LogoId == null ? "null" : this.LogoId.ToString())}");
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.SetupDate = {(this.SetupDate == null ? "null" : this.SetupDate.ToString())}");
            toStringOutput.Add($"this.TeardownDate = {(this.TeardownDate == null ? "null" : this.TeardownDate.ToString())}");
            toStringOutput.Add($"this.Category = {this.Category}");
            toStringOutput.Add($"this.Disabled = {this.Disabled}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : $"[{string.Join(", ", this.Features)} ]")}");
        }
    }
}