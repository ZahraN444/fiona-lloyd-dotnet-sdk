// <copyright file="FloorResponse.cs" company="APIMatic">
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
    /// FloorResponse.
    /// </summary>
    public class FloorResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloorResponse"/> class.
        /// </summary>
        public FloorResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloorResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="level">level.</param>
        /// <param name="buildingId">buildingId.</param>
        /// <param name="bottomLimit">bottomLimit.</param>
        /// <param name="notes">notes.</param>
        /// <param name="boundary">boundary.</param>
        /// <param name="commonArea">commonArea.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="createdAt">createdAt.</param>
        public FloorResponse(
            Guid id,
            int level,
            Guid buildingId,
            double bottomLimit,
            string notes = null,
            FloorResponseBoundary boundary = null,
            FloorResponseCommonArea commonArea = null,
            Models.FloorResponseMetadata metadata = null,
            DateTime? createdAt = null)
        {
            this.Id = id;
            this.Level = level;
            this.Notes = notes;
            this.BuildingId = buildingId;
            this.Boundary = boundary;
            this.CommonArea = commonArea;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.BottomLimit = bottomLimit;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets Level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets Notes.
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets BuildingId.
        /// </summary>
        [JsonProperty("buildingId")]
        public Guid BuildingId { get; set; }

        /// <summary>
        /// Gets or sets Boundary.
        /// </summary>
        [JsonProperty("boundary", NullValueHandling = NullValueHandling.Ignore)]
        public FloorResponseBoundary Boundary { get; set; }

        /// <summary>
        /// Gets or sets CommonArea.
        /// </summary>
        [JsonProperty("commonArea", NullValueHandling = NullValueHandling.Ignore)]
        public FloorResponseCommonArea CommonArea { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FloorResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets BottomLimit.
        /// </summary>
        [JsonProperty("bottomLimit")]
        public double BottomLimit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FloorResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is FloorResponse other &&                this.Id.Equals(other.Id) &&
                this.Level.Equals(other.Level) &&
                ((this.Notes == null && other.Notes == null) || (this.Notes?.Equals(other.Notes) == true)) &&
                this.BuildingId.Equals(other.BuildingId) &&
                ((this.Boundary == null && other.Boundary == null) || (this.Boundary?.Equals(other.Boundary) == true)) &&
                ((this.CommonArea == null && other.CommonArea == null) || (this.CommonArea?.Equals(other.CommonArea) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                this.BottomLimit.Equals(other.BottomLimit);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Level = {this.Level}");
            toStringOutput.Add($"this.Notes = {(this.Notes == null ? "null" : this.Notes)}");
            toStringOutput.Add($"this.BuildingId = {this.BuildingId}");
            toStringOutput.Add($"Boundary = {(this.Boundary == null ? "null" : this.Boundary.ToString())}");
            toStringOutput.Add($"CommonArea = {(this.CommonArea == null ? "null" : this.CommonArea.ToString())}");
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.BottomLimit = {this.BottomLimit}");
        }
    }
}