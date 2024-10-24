// <copyright file="CampaignResponse.cs" company="APIMatic">
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
    /// CampaignResponse.
    /// </summary>
    public class CampaignResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignResponse"/> class.
        /// </summary>
        public CampaignResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="facilityId">facilityId.</param>
        /// <param name="description">description.</param>
        public CampaignResponse(
            Guid id,
            string name,
            DateTime startDate,
            DateTime endDate,
            DateTime createdAt,
            Guid facilityId,
            string description = null)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CreatedAt = createdAt;
            this.FacilityId = facilityId;
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
        /// Gets or sets StartDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets EndDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets FacilityId.
        /// </summary>
        [JsonProperty("facilityId")]
        public Guid FacilityId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CampaignResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CampaignResponse other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.StartDate.Equals(other.StartDate) &&
                this.EndDate.Equals(other.EndDate) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.FacilityId.Equals(other.FacilityId);
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
            toStringOutput.Add($"this.StartDate = {this.StartDate}");
            toStringOutput.Add($"this.EndDate = {this.EndDate}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.FacilityId = {this.FacilityId}");
        }
    }
}