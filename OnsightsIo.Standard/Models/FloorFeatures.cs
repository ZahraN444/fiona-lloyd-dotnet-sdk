// <copyright file="FloorFeatures.cs" company="APIMatic">
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
    /// FloorFeatures.
    /// </summary>
    public class FloorFeatures
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloorFeatures"/> class.
        /// </summary>
        public FloorFeatures()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloorFeatures"/> class.
        /// </summary>
        /// <param name="floorId">floorId.</param>
        /// <param name="worldFile">worldFile.</param>
        /// <param name="worldImage">worldImage.</param>
        /// <param name="floorBackground">floorBackground.</param>
        /// <param name="worldImageHeight">worldImageHeight.</param>
        /// <param name="worldImageWidth">worldImageWidth.</param>
        /// <param name="customerId">customerId.</param>
        public FloorFeatures(
            Guid? floorId = null,
            Models.WorldFile worldFile = null,
            string worldImage = null,
            string floorBackground = null,
            int? worldImageHeight = null,
            int? worldImageWidth = null,
            string customerId = null)
        {
            this.FloorId = floorId;
            this.WorldFile = worldFile;
            this.WorldImage = worldImage;
            this.FloorBackground = floorBackground;
            this.WorldImageHeight = worldImageHeight;
            this.WorldImageWidth = worldImageWidth;
            this.CustomerId = customerId;
        }

        /// <summary>
        /// Gets or sets FloorId.
        /// </summary>
        [JsonProperty("floorId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FloorId { get; set; }

        /// <summary>
        /// Gets or sets WorldFile.
        /// </summary>
        [JsonProperty("worldFile", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WorldFile WorldFile { get; set; }

        /// <summary>
        /// Gets or sets WorldImage.
        /// </summary>
        [JsonProperty("worldImage", NullValueHandling = NullValueHandling.Ignore)]
        public string WorldImage { get; set; }

        /// <summary>
        /// Gets or sets FloorBackground.
        /// </summary>
        [JsonProperty("floorBackground", NullValueHandling = NullValueHandling.Ignore)]
        public string FloorBackground { get; set; }

        /// <summary>
        /// Gets or sets WorldImageHeight.
        /// </summary>
        [JsonProperty("worldImageHeight", NullValueHandling = NullValueHandling.Ignore)]
        public int? WorldImageHeight { get; set; }

        /// <summary>
        /// Gets or sets WorldImageWidth.
        /// </summary>
        [JsonProperty("worldImageWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? WorldImageWidth { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customerId", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FloorFeatures : ({string.Join(", ", toStringOutput)})";
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
            return obj is FloorFeatures other &&                ((this.FloorId == null && other.FloorId == null) || (this.FloorId?.Equals(other.FloorId) == true)) &&
                ((this.WorldFile == null && other.WorldFile == null) || (this.WorldFile?.Equals(other.WorldFile) == true)) &&
                ((this.WorldImage == null && other.WorldImage == null) || (this.WorldImage?.Equals(other.WorldImage) == true)) &&
                ((this.FloorBackground == null && other.FloorBackground == null) || (this.FloorBackground?.Equals(other.FloorBackground) == true)) &&
                ((this.WorldImageHeight == null && other.WorldImageHeight == null) || (this.WorldImageHeight?.Equals(other.WorldImageHeight) == true)) &&
                ((this.WorldImageWidth == null && other.WorldImageWidth == null) || (this.WorldImageWidth?.Equals(other.WorldImageWidth) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FloorId = {(this.FloorId == null ? "null" : this.FloorId.ToString())}");
            toStringOutput.Add($"this.WorldFile = {(this.WorldFile == null ? "null" : this.WorldFile.ToString())}");
            toStringOutput.Add($"this.WorldImage = {(this.WorldImage == null ? "null" : this.WorldImage)}");
            toStringOutput.Add($"this.FloorBackground = {(this.FloorBackground == null ? "null" : this.FloorBackground)}");
            toStringOutput.Add($"this.WorldImageHeight = {(this.WorldImageHeight == null ? "null" : this.WorldImageHeight.ToString())}");
            toStringOutput.Add($"this.WorldImageWidth = {(this.WorldImageWidth == null ? "null" : this.WorldImageWidth.ToString())}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId)}");
        }
    }
}