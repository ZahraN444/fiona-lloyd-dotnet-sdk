// <copyright file="AdvertisementResponse.cs" company="APIMatic">
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
    /// AdvertisementResponse.
    /// </summary>
    public class AdvertisementResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertisementResponse"/> class.
        /// </summary>
        public AdvertisementResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertisementResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="facilityId">facilityId.</param>
        /// <param name="description">description.</param>
        /// <param name="imageId">imageId.</param>
        /// <param name="storeId">storeId.</param>
        /// <param name="version">version.</param>
        /// <param name="externalStoreName">externalStoreName.</param>
        /// <param name="createdAt">createdAt.</param>
        public AdvertisementResponse(
            Guid id,
            string name,
            Models.TypeEnum type,
            Guid facilityId,
            string description = null,
            Guid? imageId = null,
            Guid? storeId = null,
            string version = null,
            string externalStoreName = null,
            DateTime? createdAt = null)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.ImageId = imageId;
            this.StoreId = storeId;
            this.FacilityId = facilityId;
            this.Version = version;
            this.ExternalStoreName = externalStoreName;
            this.CreatedAt = createdAt;
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
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public Models.TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or sets ImageId.
        /// </summary>
        [JsonProperty("imageId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ImageId { get; set; }

        /// <summary>
        /// Gets or sets StoreId.
        /// </summary>
        [JsonProperty("storeId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StoreId { get; set; }

        /// <summary>
        /// Gets or sets FacilityId.
        /// </summary>
        [JsonProperty("facilityId")]
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets ExternalStoreName.
        /// </summary>
        [JsonProperty("externalStoreName", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalStoreName { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdvertisementResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdvertisementResponse other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Type.Equals(other.Type) &&
                ((this.ImageId == null && other.ImageId == null) || (this.ImageId?.Equals(other.ImageId) == true)) &&
                ((this.StoreId == null && other.StoreId == null) || (this.StoreId?.Equals(other.StoreId) == true)) &&
                this.FacilityId.Equals(other.FacilityId) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.ExternalStoreName == null && other.ExternalStoreName == null) || (this.ExternalStoreName?.Equals(other.ExternalStoreName) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true));
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
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.ImageId = {(this.ImageId == null ? "null" : this.ImageId.ToString())}");
            toStringOutput.Add($"this.StoreId = {(this.StoreId == null ? "null" : this.StoreId.ToString())}");
            toStringOutput.Add($"this.FacilityId = {this.FacilityId}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
            toStringOutput.Add($"this.ExternalStoreName = {(this.ExternalStoreName == null ? "null" : this.ExternalStoreName)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
        }
    }
}