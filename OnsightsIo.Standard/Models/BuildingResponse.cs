// <copyright file="BuildingResponse.cs" company="APIMatic">
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
    /// BuildingResponse.
    /// </summary>
    public class BuildingResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingResponse"/> class.
        /// </summary>
        public BuildingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="facilityId">facilityId.</param>
        /// <param name="address">address.</param>
        /// <param name="notes">notes.</param>
        /// <param name="boundary">boundary.</param>
        /// <param name="createdAt">createdAt.</param>
        public BuildingResponse(
            Guid id,
            string name,
            Guid facilityId,
            string address = null,
            string notes = null,
            BuildingResponseBoundary boundary = null,
            DateTime? createdAt = null)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Notes = notes;
            this.FacilityId = facilityId;
            this.Boundary = boundary;
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
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets Notes.
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets FacilityId.
        /// </summary>
        [JsonProperty("facilityId")]
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Gets or sets Boundary.
        /// </summary>
        [JsonProperty("boundary", NullValueHandling = NullValueHandling.Ignore)]
        public BuildingResponseBoundary Boundary { get; set; }

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

            return $"BuildingResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is BuildingResponse other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Notes == null && other.Notes == null) || (this.Notes?.Equals(other.Notes) == true)) &&
                this.FacilityId.Equals(other.FacilityId) &&
                ((this.Boundary == null && other.Boundary == null) || (this.Boundary?.Equals(other.Boundary) == true)) &&
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
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
            toStringOutput.Add($"this.Notes = {(this.Notes == null ? "null" : this.Notes)}");
            toStringOutput.Add($"this.FacilityId = {this.FacilityId}");
            toStringOutput.Add($"Boundary = {(this.Boundary == null ? "null" : this.Boundary.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
        }
    }
}