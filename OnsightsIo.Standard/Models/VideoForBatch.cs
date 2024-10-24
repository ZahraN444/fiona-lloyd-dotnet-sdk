// <copyright file="VideoForBatch.cs" company="APIMatic">
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
    /// VideoForBatch.
    /// </summary>
    public class VideoForBatch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoForBatch"/> class.
        /// </summary>
        public VideoForBatch()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoForBatch"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="originalFileName">originalFileName.</param>
        /// <param name="videoLength">videoLength.</param>
        /// <param name="videoStartTimestamp">videoStartTimestamp.</param>
        /// <param name="status">status.</param>
        /// <param name="frameRate">frameRate.</param>
        /// <param name="resolution">resolution.</param>
        public VideoForBatch(
            string id,
            string originalFileName,
            int videoLength,
            DateTime videoStartTimestamp,
            Models.StatusEnum? status = null,
            int? frameRate = null,
            Models.PixelDimensions resolution = null)
        {
            this.Id = id;
            this.OriginalFileName = originalFileName;
            this.Status = status;
            this.FrameRate = frameRate;
            this.VideoLength = videoLength;
            this.VideoStartTimestamp = videoStartTimestamp;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets OriginalFileName.
        /// </summary>
        [JsonProperty("originalFileName")]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or sets FrameRate.
        /// </summary>
        [JsonProperty("frameRate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }

        /// <summary>
        /// Gets or sets VideoLength.
        /// </summary>
        [JsonProperty("videoLength")]
        public int VideoLength { get; set; }

        /// <summary>
        /// Gets or sets VideoStartTimestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("videoStartTimestamp")]
        public DateTime VideoStartTimestamp { get; set; }

        /// <summary>
        /// Gets or sets Resolution.
        /// </summary>
        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PixelDimensions Resolution { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VideoForBatch : ({string.Join(", ", toStringOutput)})";
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
            return obj is VideoForBatch other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.OriginalFileName == null && other.OriginalFileName == null) || (this.OriginalFileName?.Equals(other.OriginalFileName) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.FrameRate == null && other.FrameRate == null) || (this.FrameRate?.Equals(other.FrameRate) == true)) &&
                this.VideoLength.Equals(other.VideoLength) &&
                this.VideoStartTimestamp.Equals(other.VideoStartTimestamp) &&
                ((this.Resolution == null && other.Resolution == null) || (this.Resolution?.Equals(other.Resolution) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.OriginalFileName = {(this.OriginalFileName == null ? "null" : this.OriginalFileName)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.FrameRate = {(this.FrameRate == null ? "null" : this.FrameRate.ToString())}");
            toStringOutput.Add($"this.VideoLength = {this.VideoLength}");
            toStringOutput.Add($"this.VideoStartTimestamp = {this.VideoStartTimestamp}");
            toStringOutput.Add($"this.Resolution = {(this.Resolution == null ? "null" : this.Resolution.ToString())}");
        }
    }
}