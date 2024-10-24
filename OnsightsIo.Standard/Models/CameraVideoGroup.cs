// <copyright file="CameraVideoGroup.cs" company="APIMatic">
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
    /// CameraVideoGroup.
    /// </summary>
    public class CameraVideoGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraVideoGroup"/> class.
        /// </summary>
        public CameraVideoGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraVideoGroup"/> class.
        /// </summary>
        /// <param name="cameraId">cameraId.</param>
        /// <param name="frameRate">frameRate.</param>
        /// <param name="status">status.</param>
        /// <param name="videos">videos.</param>
        /// <param name="resolution">resolution.</param>
        public CameraVideoGroup(
            string cameraId,
            int frameRate,
            Models.StatusEnum status,
            List<Models.VideoForBatch> videos,
            Models.PixelDimensions resolution)
        {
            this.CameraId = cameraId;
            this.FrameRate = frameRate;
            this.Status = status;
            this.Videos = videos;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Gets or sets CameraId.
        /// </summary>
        [JsonProperty("cameraId")]
        public string CameraId { get; set; }

        /// <summary>
        /// Gets or sets FrameRate.
        /// </summary>
        [JsonProperty("frameRate")]
        public int FrameRate { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.StatusEnum Status { get; set; }

        /// <summary>
        /// Gets or sets Videos.
        /// </summary>
        [JsonProperty("videos")]
        public List<Models.VideoForBatch> Videos { get; set; }

        /// <summary>
        /// Gets or sets Resolution.
        /// </summary>
        [JsonProperty("resolution")]
        public Models.PixelDimensions Resolution { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CameraVideoGroup : ({string.Join(", ", toStringOutput)})";
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
            return obj is CameraVideoGroup other &&                ((this.CameraId == null && other.CameraId == null) || (this.CameraId?.Equals(other.CameraId) == true)) &&
                this.FrameRate.Equals(other.FrameRate) &&
                this.Status.Equals(other.Status) &&
                ((this.Videos == null && other.Videos == null) || (this.Videos?.Equals(other.Videos) == true)) &&
                ((this.Resolution == null && other.Resolution == null) || (this.Resolution?.Equals(other.Resolution) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CameraId = {(this.CameraId == null ? "null" : this.CameraId)}");
            toStringOutput.Add($"this.FrameRate = {this.FrameRate}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.Videos = {(this.Videos == null ? "null" : $"[{string.Join(", ", this.Videos)} ]")}");
            toStringOutput.Add($"this.Resolution = {(this.Resolution == null ? "null" : this.Resolution.ToString())}");
        }
    }
}