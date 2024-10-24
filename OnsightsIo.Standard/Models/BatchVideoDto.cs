// <copyright file="BatchVideoDto.cs" company="APIMatic">
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
    /// BatchVideoDto.
    /// </summary>
    public class BatchVideoDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchVideoDto"/> class.
        /// </summary>
        public BatchVideoDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchVideoDto"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="cameraId">cameraId.</param>
        /// <param name="customerId">customerId.</param>
        /// <param name="status">status.</param>
        /// <param name="originalFileName">originalFileName.</param>
        /// <param name="codec">codec.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="frameRate">frameRate.</param>
        /// <param name="videoLength">videoLength.</param>
        /// <param name="totalFrames">totalFrames.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="videoStartTimestamp">videoStartTimestamp.</param>
        /// <param name="uploadedBy">uploadedBy.</param>
        /// <param name="lastUpdateAt">lastUpdateAt.</param>
        /// <param name="errorDescription">errorDescription.</param>
        /// <param name="facilityId">facilityId.</param>
        public BatchVideoDto(
            string id,
            string cameraId,
            string customerId,
            Models.StatusEnum status,
            string originalFileName = null,
            string codec = null,
            Models.PixelDimensions resolution = null,
            int? frameRate = null,
            int? videoLength = null,
            int? totalFrames = null,
            long? fileSize = null,
            DateTime? videoStartTimestamp = null,
            string uploadedBy = null,
            DateTime? lastUpdateAt = null,
            string errorDescription = null,
            Guid? facilityId = null)
        {
            this.Id = id;
            this.CameraId = cameraId;
            this.CustomerId = customerId;
            this.OriginalFileName = originalFileName;
            this.Status = status;
            this.Codec = codec;
            this.Resolution = resolution;
            this.FrameRate = frameRate;
            this.VideoLength = videoLength;
            this.TotalFrames = totalFrames;
            this.FileSize = fileSize;
            this.VideoStartTimestamp = videoStartTimestamp;
            this.UploadedBy = uploadedBy;
            this.LastUpdateAt = lastUpdateAt;
            this.ErrorDescription = errorDescription;
            this.FacilityId = facilityId;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets CameraId.
        /// </summary>
        [JsonProperty("cameraId")]
        public string CameraId { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets OriginalFileName.
        /// </summary>
        [JsonProperty("originalFileName", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.StatusEnum Status { get; set; }

        /// <summary>
        /// Gets or sets Codec.
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public string Codec { get; set; }

        /// <summary>
        /// Gets or sets Resolution.
        /// </summary>
        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PixelDimensions Resolution { get; set; }

        /// <summary>
        /// Gets or sets FrameRate.
        /// </summary>
        [JsonProperty("frameRate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }

        /// <summary>
        /// Gets or sets VideoLength.
        /// </summary>
        [JsonProperty("videoLength", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoLength { get; set; }

        /// <summary>
        /// Gets or sets TotalFrames.
        /// </summary>
        [JsonProperty("totalFrames", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalFrames { get; set; }

        /// <summary>
        /// Gets or sets FileSize.
        /// </summary>
        [JsonProperty("fileSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        /// <summary>
        /// Gets or sets VideoStartTimestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("videoStartTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? VideoStartTimestamp { get; set; }

        /// <summary>
        /// Gets or sets UploadedBy.
        /// </summary>
        [JsonProperty("uploadedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadedBy { get; set; }

        /// <summary>
        /// Gets or sets LastUpdateAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastUpdateAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastUpdateAt { get; set; }

        /// <summary>
        /// Gets or sets ErrorDescription.
        /// </summary>
        [JsonProperty("errorDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or sets FacilityId.
        /// </summary>
        [JsonProperty("facilityId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FacilityId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BatchVideoDto : ({string.Join(", ", toStringOutput)})";
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
            return obj is BatchVideoDto other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CameraId == null && other.CameraId == null) || (this.CameraId?.Equals(other.CameraId) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.OriginalFileName == null && other.OriginalFileName == null) || (this.OriginalFileName?.Equals(other.OriginalFileName) == true)) &&
                this.Status.Equals(other.Status) &&
                ((this.Codec == null && other.Codec == null) || (this.Codec?.Equals(other.Codec) == true)) &&
                ((this.Resolution == null && other.Resolution == null) || (this.Resolution?.Equals(other.Resolution) == true)) &&
                ((this.FrameRate == null && other.FrameRate == null) || (this.FrameRate?.Equals(other.FrameRate) == true)) &&
                ((this.VideoLength == null && other.VideoLength == null) || (this.VideoLength?.Equals(other.VideoLength) == true)) &&
                ((this.TotalFrames == null && other.TotalFrames == null) || (this.TotalFrames?.Equals(other.TotalFrames) == true)) &&
                ((this.FileSize == null && other.FileSize == null) || (this.FileSize?.Equals(other.FileSize) == true)) &&
                ((this.VideoStartTimestamp == null && other.VideoStartTimestamp == null) || (this.VideoStartTimestamp?.Equals(other.VideoStartTimestamp) == true)) &&
                ((this.UploadedBy == null && other.UploadedBy == null) || (this.UploadedBy?.Equals(other.UploadedBy) == true)) &&
                ((this.LastUpdateAt == null && other.LastUpdateAt == null) || (this.LastUpdateAt?.Equals(other.LastUpdateAt) == true)) &&
                ((this.ErrorDescription == null && other.ErrorDescription == null) || (this.ErrorDescription?.Equals(other.ErrorDescription) == true)) &&
                ((this.FacilityId == null && other.FacilityId == null) || (this.FacilityId?.Equals(other.FacilityId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.CameraId = {(this.CameraId == null ? "null" : this.CameraId)}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId)}");
            toStringOutput.Add($"this.OriginalFileName = {(this.OriginalFileName == null ? "null" : this.OriginalFileName)}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.Codec = {(this.Codec == null ? "null" : this.Codec)}");
            toStringOutput.Add($"this.Resolution = {(this.Resolution == null ? "null" : this.Resolution.ToString())}");
            toStringOutput.Add($"this.FrameRate = {(this.FrameRate == null ? "null" : this.FrameRate.ToString())}");
            toStringOutput.Add($"this.VideoLength = {(this.VideoLength == null ? "null" : this.VideoLength.ToString())}");
            toStringOutput.Add($"this.TotalFrames = {(this.TotalFrames == null ? "null" : this.TotalFrames.ToString())}");
            toStringOutput.Add($"this.FileSize = {(this.FileSize == null ? "null" : this.FileSize.ToString())}");
            toStringOutput.Add($"this.VideoStartTimestamp = {(this.VideoStartTimestamp == null ? "null" : this.VideoStartTimestamp.ToString())}");
            toStringOutput.Add($"this.UploadedBy = {(this.UploadedBy == null ? "null" : this.UploadedBy)}");
            toStringOutput.Add($"this.LastUpdateAt = {(this.LastUpdateAt == null ? "null" : this.LastUpdateAt.ToString())}");
            toStringOutput.Add($"this.ErrorDescription = {(this.ErrorDescription == null ? "null" : this.ErrorDescription)}");
            toStringOutput.Add($"this.FacilityId = {(this.FacilityId == null ? "null" : this.FacilityId.ToString())}");
        }
    }
}