// <copyright file="FacilityRequest.cs" company="APIMatic">
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
    /// FacilityRequest.
    /// </summary>
    public class FacilityRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacilityRequest"/> class.
        /// </summary>
        public FacilityRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacilityRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="address">address.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="operationHours">operationHours.</param>
        /// <param name="notes">notes.</param>
        /// <param name="imageId">imageId.</param>
        public FacilityRequest(
            string name,
            string address,
            string timezone,
            Models.OperationHours operationHours,
            string notes = null,
            Guid? imageId = null)
        {
            this.Name = name;
            this.Address = address;
            this.Notes = notes;
            this.ImageId = imageId;
            this.Timezone = timezone;
            this.OperationHours = operationHours;
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
        /// Gets or sets ImageId.
        /// </summary>
        [JsonProperty("imageId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ImageId { get; set; }

        /// <summary>
        /// Gets or sets Timezone.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets OperationHours.
        /// </summary>
        [JsonProperty("operationHours")]
        public Models.OperationHours OperationHours { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FacilityRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is FacilityRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Notes == null && other.Notes == null) || (this.Notes?.Equals(other.Notes) == true)) &&
                ((this.ImageId == null && other.ImageId == null) || (this.ImageId?.Equals(other.ImageId) == true)) &&
                ((this.Timezone == null && other.Timezone == null) || (this.Timezone?.Equals(other.Timezone) == true)) &&
                ((this.OperationHours == null && other.OperationHours == null) || (this.OperationHours?.Equals(other.OperationHours) == true));
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
            toStringOutput.Add($"this.ImageId = {(this.ImageId == null ? "null" : this.ImageId.ToString())}");
            toStringOutput.Add($"this.Timezone = {(this.Timezone == null ? "null" : this.Timezone)}");
            toStringOutput.Add($"this.OperationHours = {(this.OperationHours == null ? "null" : this.OperationHours.ToString())}");
        }
    }
}