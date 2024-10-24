// <copyright file="FloorRequest.cs" company="APIMatic">
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
    /// FloorRequest.
    /// </summary>
    public class FloorRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloorRequest"/> class.
        /// </summary>
        public FloorRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloorRequest"/> class.
        /// </summary>
        /// <param name="level">level.</param>
        /// <param name="buildingId">buildingId.</param>
        /// <param name="bottomLimit">bottomLimit.</param>
        /// <param name="notes">notes.</param>
        /// <param name="boundary">boundary.</param>
        /// <param name="commonArea">commonArea.</param>
        /// <param name="metadata">metadata.</param>
        public FloorRequest(
            int level,
            Guid buildingId,
            double bottomLimit,
            string notes = null,
            FloorRequestBoundary boundary = null,
            FloorRequestCommonArea commonArea = null,
            Models.FloorRequestMetadata metadata = null)
        {
            this.Level = level;
            this.Notes = notes;
            this.BuildingId = buildingId;
            this.Boundary = boundary;
            this.CommonArea = commonArea;
            this.Metadata = metadata;
            this.BottomLimit = bottomLimit;
        }

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
        public FloorRequestBoundary Boundary { get; set; }

        /// <summary>
        /// Gets or sets CommonArea.
        /// </summary>
        [JsonProperty("commonArea", NullValueHandling = NullValueHandling.Ignore)]
        public FloorRequestCommonArea CommonArea { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FloorRequestMetadata Metadata { get; set; }

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

            return $"FloorRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is FloorRequest other &&                this.Level.Equals(other.Level) &&
                ((this.Notes == null && other.Notes == null) || (this.Notes?.Equals(other.Notes) == true)) &&
                this.BuildingId.Equals(other.BuildingId) &&
                ((this.Boundary == null && other.Boundary == null) || (this.Boundary?.Equals(other.Boundary) == true)) &&
                ((this.CommonArea == null && other.CommonArea == null) || (this.CommonArea?.Equals(other.CommonArea) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                this.BottomLimit.Equals(other.BottomLimit);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Level = {this.Level}");
            toStringOutput.Add($"this.Notes = {(this.Notes == null ? "null" : this.Notes)}");
            toStringOutput.Add($"this.BuildingId = {this.BuildingId}");
            toStringOutput.Add($"Boundary = {(this.Boundary == null ? "null" : this.Boundary.ToString())}");
            toStringOutput.Add($"CommonArea = {(this.CommonArea == null ? "null" : this.CommonArea.ToString())}");
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.BottomLimit = {this.BottomLimit}");
        }
    }
}