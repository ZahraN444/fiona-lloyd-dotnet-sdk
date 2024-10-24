// <copyright file="RegionExportItem.cs" company="APIMatic">
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
    /// RegionExportItem.
    /// </summary>
    public class RegionExportItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionExportItem"/> class.
        /// </summary>
        public RegionExportItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionExportItem"/> class.
        /// </summary>
        /// <param name="regionId">region_id.</param>
        /// <param name="regionName">region_name.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="regionType">region_type.</param>
        public RegionExportItem(
            Guid regionId,
            string regionName,
            Models.Geometry geometry,
            string regionType)
        {
            this.RegionId = regionId;
            this.RegionName = regionName;
            this.Geometry = geometry;
            this.RegionType = regionType;
        }

        /// <summary>
        /// Gets or sets RegionId.
        /// </summary>
        [JsonProperty("region_id")]
        public Guid RegionId { get; set; }

        /// <summary>
        /// Gets or sets RegionName.
        /// </summary>
        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        /// <summary>
        /// Gets or sets Geometry.
        /// </summary>
        [JsonProperty("geometry")]
        public Models.Geometry Geometry { get; set; }

        /// <summary>
        /// Gets or sets RegionType.
        /// </summary>
        [JsonProperty("region_type")]
        public string RegionType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegionExportItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is RegionExportItem other &&                this.RegionId.Equals(other.RegionId) &&
                ((this.RegionName == null && other.RegionName == null) || (this.RegionName?.Equals(other.RegionName) == true)) &&
                ((this.Geometry == null && other.Geometry == null) || (this.Geometry?.Equals(other.Geometry) == true)) &&
                ((this.RegionType == null && other.RegionType == null) || (this.RegionType?.Equals(other.RegionType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegionId = {this.RegionId}");
            toStringOutput.Add($"this.RegionName = {(this.RegionName == null ? "null" : this.RegionName)}");
            toStringOutput.Add($"this.Geometry = {(this.Geometry == null ? "null" : this.Geometry.ToString())}");
            toStringOutput.Add($"this.RegionType = {(this.RegionType == null ? "null" : this.RegionType)}");
        }
    }
}