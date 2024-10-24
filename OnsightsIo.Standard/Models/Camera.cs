// <copyright file="Camera.cs" company="APIMatic">
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
    /// Camera.
    /// </summary>
    public class Camera
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Camera"/> class.
        /// </summary>
        public Camera()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Camera"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="floorId">floorId.</param>
        /// <param name="buildingId">buildingId.</param>
        /// <param name="azimuthRad">azimuthRad.</param>
        /// <param name="fieldOfViewRad">fieldOfViewRad.</param>
        /// <param name="rangeMeters">rangeMeters.</param>
        /// <param name="coordinatesWKT">coordinatesWKT.</param>
        public Camera(
            Guid id,
            string name,
            Guid? floorId = null,
            Guid? buildingId = null,
            double? azimuthRad = null,
            double? fieldOfViewRad = null,
            double? rangeMeters = null,
            string coordinatesWKT = null)
        {
            this.Id = id;
            this.Name = name;
            this.FloorId = floorId;
            this.BuildingId = buildingId;
            this.AzimuthRad = azimuthRad;
            this.FieldOfViewRad = fieldOfViewRad;
            this.RangeMeters = rangeMeters;
            this.CoordinatesWKT = coordinatesWKT;
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
        /// Gets or sets FloorId.
        /// </summary>
        [JsonProperty("floorId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FloorId { get; set; }

        /// <summary>
        /// Gets or sets BuildingId.
        /// </summary>
        [JsonProperty("buildingId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? BuildingId { get; set; }

        /// <summary>
        /// Gets or sets AzimuthRad.
        /// </summary>
        [JsonProperty("azimuthRad", NullValueHandling = NullValueHandling.Ignore)]
        public double? AzimuthRad { get; set; }

        /// <summary>
        /// Gets or sets FieldOfViewRad.
        /// </summary>
        [JsonProperty("fieldOfViewRad", NullValueHandling = NullValueHandling.Ignore)]
        public double? FieldOfViewRad { get; set; }

        /// <summary>
        /// Gets or sets RangeMeters.
        /// </summary>
        [JsonProperty("rangeMeters", NullValueHandling = NullValueHandling.Ignore)]
        public double? RangeMeters { get; set; }

        /// <summary>
        /// Gets or sets CoordinatesWKT.
        /// </summary>
        [JsonProperty("coordinatesWKT", NullValueHandling = NullValueHandling.Ignore)]
        public string CoordinatesWKT { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Camera : ({string.Join(", ", toStringOutput)})";
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
            return obj is Camera other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.FloorId == null && other.FloorId == null) || (this.FloorId?.Equals(other.FloorId) == true)) &&
                ((this.BuildingId == null && other.BuildingId == null) || (this.BuildingId?.Equals(other.BuildingId) == true)) &&
                ((this.AzimuthRad == null && other.AzimuthRad == null) || (this.AzimuthRad?.Equals(other.AzimuthRad) == true)) &&
                ((this.FieldOfViewRad == null && other.FieldOfViewRad == null) || (this.FieldOfViewRad?.Equals(other.FieldOfViewRad) == true)) &&
                ((this.RangeMeters == null && other.RangeMeters == null) || (this.RangeMeters?.Equals(other.RangeMeters) == true)) &&
                ((this.CoordinatesWKT == null && other.CoordinatesWKT == null) || (this.CoordinatesWKT?.Equals(other.CoordinatesWKT) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.FloorId = {(this.FloorId == null ? "null" : this.FloorId.ToString())}");
            toStringOutput.Add($"this.BuildingId = {(this.BuildingId == null ? "null" : this.BuildingId.ToString())}");
            toStringOutput.Add($"this.AzimuthRad = {(this.AzimuthRad == null ? "null" : this.AzimuthRad.ToString())}");
            toStringOutput.Add($"this.FieldOfViewRad = {(this.FieldOfViewRad == null ? "null" : this.FieldOfViewRad.ToString())}");
            toStringOutput.Add($"this.RangeMeters = {(this.RangeMeters == null ? "null" : this.RangeMeters.ToString())}");
            toStringOutput.Add($"this.CoordinatesWKT = {(this.CoordinatesWKT == null ? "null" : this.CoordinatesWKT)}");
        }
    }
}