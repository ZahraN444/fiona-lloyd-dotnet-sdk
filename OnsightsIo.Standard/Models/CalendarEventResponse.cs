// <copyright file="CalendarEventResponse.cs" company="APIMatic">
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
    /// CalendarEventResponse.
    /// </summary>
    public class CalendarEventResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarEventResponse"/> class.
        /// </summary>
        public CalendarEventResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarEventResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="name">name.</param>
        /// <param name="isRecurring">isRecurring.</param>
        /// <param name="firstOccurrence">firstOccurrence.</param>
        /// <param name="durationSeconds">durationSeconds.</param>
        /// <param name="isHiddenFromAnalytics">isHiddenFromAnalytics.</param>
        /// <param name="isFromExternalSource">isFromExternalSource.</param>
        /// <param name="facilityId">facilityId.</param>
        /// <param name="floorId">floorId.</param>
        /// <param name="regionId">regionId.</param>
        /// <param name="description">description.</param>
        /// <param name="notes">notes.</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="lastOccurrence">lastOccurrence.</param>
        /// <param name="location">location.</param>
        public CalendarEventResponse(
            Guid id,
            DateTime createdAt,
            string name,
            bool isRecurring,
            DateTime firstOccurrence,
            int durationSeconds,
            bool isHiddenFromAnalytics,
            bool isFromExternalSource,
            Guid? facilityId = null,
            Guid? floorId = null,
            Guid? regionId = null,
            string description = null,
            string notes = null,
            List<string> recurrence = null,
            DateTime? lastOccurrence = null,
            CalendarEventResponseLocation location = null)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.FacilityId = facilityId;
            this.FloorId = floorId;
            this.RegionId = regionId;
            this.Name = name;
            this.Description = description;
            this.Notes = notes;
            this.IsRecurring = isRecurring;
            this.Recurrence = recurrence;
            this.FirstOccurrence = firstOccurrence;
            this.LastOccurrence = lastOccurrence;
            this.DurationSeconds = durationSeconds;
            this.IsHiddenFromAnalytics = isHiddenFromAnalytics;
            this.IsFromExternalSource = isFromExternalSource;
            this.Location = location;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets FacilityId.
        /// </summary>
        [JsonProperty("facilityId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FacilityId { get; set; }

        /// <summary>
        /// Gets or sets FloorId.
        /// </summary>
        [JsonProperty("floorId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FloorId { get; set; }

        /// <summary>
        /// Gets or sets RegionId.
        /// </summary>
        [JsonProperty("regionId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? RegionId { get; set; }

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
        /// Gets or sets Notes.
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets IsRecurring.
        /// </summary>
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        /// <summary>
        /// Gets or sets Recurrence.
        /// </summary>
        [JsonProperty("recurrence", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Recurrence { get; set; }

        /// <summary>
        /// Gets or sets FirstOccurrence.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("firstOccurrence")]
        public DateTime FirstOccurrence { get; set; }

        /// <summary>
        /// Gets or sets LastOccurrence.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastOccurrence", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastOccurrence { get; set; }

        /// <summary>
        /// Gets or sets DurationSeconds.
        /// </summary>
        [JsonProperty("durationSeconds")]
        public int DurationSeconds { get; set; }

        /// <summary>
        /// Gets or sets IsHiddenFromAnalytics.
        /// </summary>
        [JsonProperty("isHiddenFromAnalytics")]
        public bool IsHiddenFromAnalytics { get; set; }

        /// <summary>
        /// Gets or sets IsFromExternalSource.
        /// </summary>
        [JsonProperty("isFromExternalSource")]
        public bool IsFromExternalSource { get; set; }

        /// <summary>
        /// Gets or sets Location.
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public CalendarEventResponseLocation Location { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CalendarEventResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CalendarEventResponse other &&                this.Id.Equals(other.Id) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                ((this.FacilityId == null && other.FacilityId == null) || (this.FacilityId?.Equals(other.FacilityId) == true)) &&
                ((this.FloorId == null && other.FloorId == null) || (this.FloorId?.Equals(other.FloorId) == true)) &&
                ((this.RegionId == null && other.RegionId == null) || (this.RegionId?.Equals(other.RegionId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Notes == null && other.Notes == null) || (this.Notes?.Equals(other.Notes) == true)) &&
                this.IsRecurring.Equals(other.IsRecurring) &&
                ((this.Recurrence == null && other.Recurrence == null) || (this.Recurrence?.Equals(other.Recurrence) == true)) &&
                this.FirstOccurrence.Equals(other.FirstOccurrence) &&
                ((this.LastOccurrence == null && other.LastOccurrence == null) || (this.LastOccurrence?.Equals(other.LastOccurrence) == true)) &&
                this.DurationSeconds.Equals(other.DurationSeconds) &&
                this.IsHiddenFromAnalytics.Equals(other.IsHiddenFromAnalytics) &&
                this.IsFromExternalSource.Equals(other.IsFromExternalSource) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.FacilityId = {(this.FacilityId == null ? "null" : this.FacilityId.ToString())}");
            toStringOutput.Add($"this.FloorId = {(this.FloorId == null ? "null" : this.FloorId.ToString())}");
            toStringOutput.Add($"this.RegionId = {(this.RegionId == null ? "null" : this.RegionId.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Notes = {(this.Notes == null ? "null" : this.Notes)}");
            toStringOutput.Add($"this.IsRecurring = {this.IsRecurring}");
            toStringOutput.Add($"this.Recurrence = {(this.Recurrence == null ? "null" : $"[{string.Join(", ", this.Recurrence)} ]")}");
            toStringOutput.Add($"this.FirstOccurrence = {this.FirstOccurrence}");
            toStringOutput.Add($"this.LastOccurrence = {(this.LastOccurrence == null ? "null" : this.LastOccurrence.ToString())}");
            toStringOutput.Add($"this.DurationSeconds = {this.DurationSeconds}");
            toStringOutput.Add($"this.IsHiddenFromAnalytics = {this.IsHiddenFromAnalytics}");
            toStringOutput.Add($"this.IsFromExternalSource = {this.IsFromExternalSource}");
            toStringOutput.Add($"Location = {(this.Location == null ? "null" : this.Location.ToString())}");
        }
    }
}