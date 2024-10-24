// <copyright file="CampaignRequest.cs" company="APIMatic">
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
    /// CampaignRequest.
    /// </summary>
    public class CampaignRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRequest"/> class.
        /// </summary>
        public CampaignRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="facilityId">facilityId.</param>
        /// <param name="description">description.</param>
        public CampaignRequest(
            string name,
            DateTime startDate,
            DateTime endDate,
            Guid facilityId,
            string description = null)
        {
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.FacilityId = facilityId;
        }

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
        /// Gets or sets FacilityId.
        /// </summary>
        [JsonProperty("facilityId")]
        public Guid FacilityId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CampaignRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CampaignRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.StartDate.Equals(other.StartDate) &&
                this.EndDate.Equals(other.EndDate) &&
                this.FacilityId.Equals(other.FacilityId);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.StartDate = {this.StartDate}");
            toStringOutput.Add($"this.EndDate = {this.EndDate}");
            toStringOutput.Add($"this.FacilityId = {this.FacilityId}");
        }
    }
}