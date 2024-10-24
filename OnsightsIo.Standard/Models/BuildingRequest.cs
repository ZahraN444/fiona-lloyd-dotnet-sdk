// <copyright file="BuildingRequest.cs" company="APIMatic">
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
    /// BuildingRequest.
    /// </summary>
    public class BuildingRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingRequest"/> class.
        /// </summary>
        public BuildingRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="address">address.</param>
        /// <param name="facilityId">facilityId.</param>
        /// <param name="notes">notes.</param>
        /// <param name="boundary">boundary.</param>
        public BuildingRequest(
            string name,
            string address,
            Guid facilityId,
            string notes = null,
            BuildingRequestBoundary boundary = null)
        {
            this.Name = name;
            this.Address = address;
            this.Notes = notes;
            this.FacilityId = facilityId;
            this.Boundary = boundary;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
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
        public BuildingRequestBoundary Boundary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BuildingRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is BuildingRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Notes == null && other.Notes == null) || (this.Notes?.Equals(other.Notes) == true)) &&
                this.FacilityId.Equals(other.FacilityId) &&
                ((this.Boundary == null && other.Boundary == null) || (this.Boundary?.Equals(other.Boundary) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
            toStringOutput.Add($"this.Notes = {(this.Notes == null ? "null" : this.Notes)}");
            toStringOutput.Add($"this.FacilityId = {this.FacilityId}");
            toStringOutput.Add($"Boundary = {(this.Boundary == null ? "null" : this.Boundary.ToString())}");
        }
    }
}