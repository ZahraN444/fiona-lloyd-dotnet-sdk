// <copyright file="BatchDto.cs" company="APIMatic">
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
    /// BatchDto.
    /// </summary>
    public class BatchDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDto"/> class.
        /// </summary>
        public BatchDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDto"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="facilityId">facilityId.</param>
        /// <param name="customerId">customerId.</param>
        /// <param name="videos">videos.</param>
        /// <param name="statusUpdates">statusUpdates.</param>
        /// <param name="runIds">runIds.</param>
        /// <param name="retainIntermediaryData">retainIntermediaryData.</param>
        /// <param name="dataStartDatetime">dataStartDatetime.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="createdBy">createdBy.</param>
        public BatchDto(
            Guid id,
            Guid facilityId,
            string customerId,
            List<Models.BatchVideoDto> videos,
            List<Models.BatchStatusInfoDto> statusUpdates,
            List<Guid> runIds,
            bool retainIntermediaryData,
            DateTime? dataStartDatetime = null,
            DateTime? createdAt = null,
            string createdBy = null)
        {
            this.Id = id;
            this.FacilityId = facilityId;
            this.CustomerId = customerId;
            this.DataStartDatetime = dataStartDatetime;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Videos = videos;
            this.StatusUpdates = statusUpdates;
            this.RunIds = runIds;
            this.RetainIntermediaryData = retainIntermediaryData;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets FacilityId.
        /// </summary>
        [JsonProperty("facilityId")]
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets DataStartDatetime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dataStartDatetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataStartDatetime { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets CreatedBy.
        /// </summary>
        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets Videos.
        /// </summary>
        [JsonProperty("videos")]
        public List<Models.BatchVideoDto> Videos { get; set; }

        /// <summary>
        /// Gets or sets StatusUpdates.
        /// </summary>
        [JsonProperty("statusUpdates")]
        public List<Models.BatchStatusInfoDto> StatusUpdates { get; set; }

        /// <summary>
        /// Gets or sets RunIds.
        /// </summary>
        [JsonProperty("runIds")]
        public List<Guid> RunIds { get; set; }

        /// <summary>
        /// Gets or sets RetainIntermediaryData.
        /// </summary>
        [JsonProperty("retainIntermediaryData")]
        public bool RetainIntermediaryData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BatchDto : ({string.Join(", ", toStringOutput)})";
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
            return obj is BatchDto other &&                this.Id.Equals(other.Id) &&
                this.FacilityId.Equals(other.FacilityId) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.DataStartDatetime == null && other.DataStartDatetime == null) || (this.DataStartDatetime?.Equals(other.DataStartDatetime) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.CreatedBy == null && other.CreatedBy == null) || (this.CreatedBy?.Equals(other.CreatedBy) == true)) &&
                ((this.Videos == null && other.Videos == null) || (this.Videos?.Equals(other.Videos) == true)) &&
                ((this.StatusUpdates == null && other.StatusUpdates == null) || (this.StatusUpdates?.Equals(other.StatusUpdates) == true)) &&
                ((this.RunIds == null && other.RunIds == null) || (this.RunIds?.Equals(other.RunIds) == true)) &&
                this.RetainIntermediaryData.Equals(other.RetainIntermediaryData);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.FacilityId = {this.FacilityId}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId)}");
            toStringOutput.Add($"this.DataStartDatetime = {(this.DataStartDatetime == null ? "null" : this.DataStartDatetime.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.CreatedBy = {(this.CreatedBy == null ? "null" : this.CreatedBy)}");
            toStringOutput.Add($"this.Videos = {(this.Videos == null ? "null" : $"[{string.Join(", ", this.Videos)} ]")}");
            toStringOutput.Add($"this.StatusUpdates = {(this.StatusUpdates == null ? "null" : $"[{string.Join(", ", this.StatusUpdates)} ]")}");
            toStringOutput.Add($"this.RunIds = {(this.RunIds == null ? "null" : $"[{string.Join(", ", this.RunIds)} ]")}");
            toStringOutput.Add($"this.RetainIntermediaryData = {this.RetainIntermediaryData}");
        }
    }
}