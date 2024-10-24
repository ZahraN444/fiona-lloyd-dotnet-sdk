// <copyright file="CameraRequest.cs" company="APIMatic">
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
    /// CameraRequest.
    /// </summary>
    public class CameraRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraRequest"/> class.
        /// </summary>
        public CameraRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="coordinates">coordinates.</param>
        /// <param name="facilityId">facilityId.</param>
        /// <param name="make">make.</param>
        /// <param name="model">model.</param>
        /// <param name="notes">notes.</param>
        /// <param name="azimuthRad">azimuthRad.</param>
        /// <param name="fieldOfViewRad">fieldOfViewRad.</param>
        /// <param name="rangeMeters">rangeMeters.</param>
        /// <param name="floorId">floorId.</param>
        /// <param name="buildingId">buildingId.</param>
        /// <param name="localId">localId.</param>
        /// <param name="status">status.</param>
        /// <param name="volumePath">volumePath.</param>
        /// <param name="rtspAddress">rtspAddress.</param>
        public CameraRequest(
            string name,
            CameraRequestCoordinates coordinates,
            Guid facilityId,
            string make = null,
            string model = null,
            string notes = null,
            double? azimuthRad = null,
            double? fieldOfViewRad = null,
            double? rangeMeters = null,
            Guid? floorId = null,
            Guid? buildingId = null,
            string localId = null,
            string status = null,
            string volumePath = null,
            string rtspAddress = null)
        {
            this.Name = name;
            this.Make = make;
            this.Model = model;
            this.Notes = notes;
            this.AzimuthRad = azimuthRad;
            this.FieldOfViewRad = fieldOfViewRad;
            this.RangeMeters = rangeMeters;
            this.FloorId = floorId;
            this.BuildingId = buildingId;
            this.LocalId = localId;
            this.Status = status;
            this.VolumePath = volumePath;
            this.RtspAddress = rtspAddress;
            this.Coordinates = coordinates;
            this.FacilityId = facilityId;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Make.
        /// </summary>
        [JsonProperty("make", NullValueHandling = NullValueHandling.Ignore)]
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets Model.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets Notes.
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

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
        /// Gets or sets LocalId.
        /// </summary>
        [JsonProperty("localId", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalId { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets VolumePath.
        /// </summary>
        [JsonProperty("volumePath", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumePath { get; set; }

        /// <summary>
        /// Gets or sets RtspAddress.
        /// </summary>
        [JsonProperty("rtspAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string RtspAddress { get; set; }

        /// <summary>
        /// Gets or sets Coordinates.
        /// </summary>
        [JsonProperty("coordinates")]
        public CameraRequestCoordinates Coordinates { get; set; }

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

            return $"CameraRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CameraRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Notes == null && other.Notes == null) || (this.Notes?.Equals(other.Notes) == true)) &&
                ((this.AzimuthRad == null && other.AzimuthRad == null) || (this.AzimuthRad?.Equals(other.AzimuthRad) == true)) &&
                ((this.FieldOfViewRad == null && other.FieldOfViewRad == null) || (this.FieldOfViewRad?.Equals(other.FieldOfViewRad) == true)) &&
                ((this.RangeMeters == null && other.RangeMeters == null) || (this.RangeMeters?.Equals(other.RangeMeters) == true)) &&
                ((this.FloorId == null && other.FloorId == null) || (this.FloorId?.Equals(other.FloorId) == true)) &&
                ((this.BuildingId == null && other.BuildingId == null) || (this.BuildingId?.Equals(other.BuildingId) == true)) &&
                ((this.LocalId == null && other.LocalId == null) || (this.LocalId?.Equals(other.LocalId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.VolumePath == null && other.VolumePath == null) || (this.VolumePath?.Equals(other.VolumePath) == true)) &&
                ((this.RtspAddress == null && other.RtspAddress == null) || (this.RtspAddress?.Equals(other.RtspAddress) == true)) &&
                ((this.Coordinates == null && other.Coordinates == null) || (this.Coordinates?.Equals(other.Coordinates) == true)) &&
                this.FacilityId.Equals(other.FacilityId);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Make = {(this.Make == null ? "null" : this.Make)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.Notes = {(this.Notes == null ? "null" : this.Notes)}");
            toStringOutput.Add($"this.AzimuthRad = {(this.AzimuthRad == null ? "null" : this.AzimuthRad.ToString())}");
            toStringOutput.Add($"this.FieldOfViewRad = {(this.FieldOfViewRad == null ? "null" : this.FieldOfViewRad.ToString())}");
            toStringOutput.Add($"this.RangeMeters = {(this.RangeMeters == null ? "null" : this.RangeMeters.ToString())}");
            toStringOutput.Add($"this.FloorId = {(this.FloorId == null ? "null" : this.FloorId.ToString())}");
            toStringOutput.Add($"this.BuildingId = {(this.BuildingId == null ? "null" : this.BuildingId.ToString())}");
            toStringOutput.Add($"this.LocalId = {(this.LocalId == null ? "null" : this.LocalId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.VolumePath = {(this.VolumePath == null ? "null" : this.VolumePath)}");
            toStringOutput.Add($"this.RtspAddress = {(this.RtspAddress == null ? "null" : this.RtspAddress)}");
            toStringOutput.Add($"Coordinates = {(this.Coordinates == null ? "null" : this.Coordinates.ToString())}");
            toStringOutput.Add($"this.FacilityId = {this.FacilityId}");
        }
    }
}