// <copyright file="Facility.cs" company="APIMatic">
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
    /// Facility.
    /// </summary>
    public class Facility
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Facility"/> class.
        /// </summary>
        public Facility()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Facility"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="buildings">buildings.</param>
        /// <param name="wholeFacilityWKT">wholeFacilityWKT.</param>
        /// <param name="cameras">cameras.</param>
        /// <param name="facilityScopedRegions">facilityScopedRegions.</param>
        public Facility(
            Guid id,
            string name,
            List<Models.Building> buildings = null,
            string wholeFacilityWKT = null,
            List<Models.Camera> cameras = null,
            List<Models.Region> facilityScopedRegions = null)
        {
            this.Id = id;
            this.Name = name;
            this.Buildings = buildings;
            this.WholeFacilityWKT = wholeFacilityWKT;
            this.Cameras = cameras;
            this.FacilityScopedRegions = facilityScopedRegions;
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
        /// Gets or sets Buildings.
        /// </summary>
        [JsonProperty("buildings", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Building> Buildings { get; set; }

        /// <summary>
        /// Gets or sets WholeFacilityWKT.
        /// </summary>
        [JsonProperty("wholeFacilityWKT", NullValueHandling = NullValueHandling.Ignore)]
        public string WholeFacilityWKT { get; set; }

        /// <summary>
        /// Gets or sets Cameras.
        /// </summary>
        [JsonProperty("cameras", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Camera> Cameras { get; set; }

        /// <summary>
        /// Gets or sets FacilityScopedRegions.
        /// </summary>
        [JsonProperty("facilityScopedRegions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Region> FacilityScopedRegions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Facility : ({string.Join(", ", toStringOutput)})";
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
            return obj is Facility other &&                this.Id.Equals(other.Id) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Buildings == null && other.Buildings == null) || (this.Buildings?.Equals(other.Buildings) == true)) &&
                ((this.WholeFacilityWKT == null && other.WholeFacilityWKT == null) || (this.WholeFacilityWKT?.Equals(other.WholeFacilityWKT) == true)) &&
                ((this.Cameras == null && other.Cameras == null) || (this.Cameras?.Equals(other.Cameras) == true)) &&
                ((this.FacilityScopedRegions == null && other.FacilityScopedRegions == null) || (this.FacilityScopedRegions?.Equals(other.FacilityScopedRegions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Buildings = {(this.Buildings == null ? "null" : $"[{string.Join(", ", this.Buildings)} ]")}");
            toStringOutput.Add($"this.WholeFacilityWKT = {(this.WholeFacilityWKT == null ? "null" : this.WholeFacilityWKT)}");
            toStringOutput.Add($"this.Cameras = {(this.Cameras == null ? "null" : $"[{string.Join(", ", this.Cameras)} ]")}");
            toStringOutput.Add($"this.FacilityScopedRegions = {(this.FacilityScopedRegions == null ? "null" : $"[{string.Join(", ", this.FacilityScopedRegions)} ]")}");
        }
    }
}