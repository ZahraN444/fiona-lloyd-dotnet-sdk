// <copyright file="CalendarEventOccurrenceResponse.cs" company="APIMatic">
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
    /// CalendarEventOccurrenceResponse.
    /// </summary>
    public class CalendarEventOccurrenceResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarEventOccurrenceResponse"/> class.
        /// </summary>
        public CalendarEventOccurrenceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarEventOccurrenceResponse"/> class.
        /// </summary>
        /// <param name="eventId">eventId.</param>
        /// <param name="name">name.</param>
        /// <param name="isRecurring">isRecurring.</param>
        /// <param name="timeStart">timeStart.</param>
        /// <param name="timeEnd">timeEnd.</param>
        /// <param name="description">description.</param>
        public CalendarEventOccurrenceResponse(
            Guid eventId,
            string name,
            bool isRecurring,
            DateTime timeStart,
            DateTime timeEnd,
            string description = null)
        {
            this.EventId = eventId;
            this.Name = name;
            this.Description = description;
            this.IsRecurring = isRecurring;
            this.TimeStart = timeStart;
            this.TimeEnd = timeEnd;
        }

        /// <summary>
        /// Gets or sets EventId.
        /// </summary>
        [JsonProperty("eventId")]
        public Guid EventId { get; set; }

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
        /// Gets or sets IsRecurring.
        /// </summary>
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        /// <summary>
        /// Gets or sets TimeStart.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timeStart")]
        public DateTime TimeStart { get; set; }

        /// <summary>
        /// Gets or sets TimeEnd.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timeEnd")]
        public DateTime TimeEnd { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CalendarEventOccurrenceResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CalendarEventOccurrenceResponse other &&                this.EventId.Equals(other.EventId) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.IsRecurring.Equals(other.IsRecurring) &&
                this.TimeStart.Equals(other.TimeStart) &&
                this.TimeEnd.Equals(other.TimeEnd);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EventId = {this.EventId}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.IsRecurring = {this.IsRecurring}");
            toStringOutput.Add($"this.TimeStart = {this.TimeStart}");
            toStringOutput.Add($"this.TimeEnd = {this.TimeEnd}");
        }
    }
}