// <copyright file="BatchStatusInfoDto.cs" company="APIMatic">
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
    /// BatchStatusInfoDto.
    /// </summary>
    public class BatchStatusInfoDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStatusInfoDto"/> class.
        /// </summary>
        public BatchStatusInfoDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStatusInfoDto"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="stage">stage.</param>
        /// <param name="status">status.</param>
        /// <param name="updateTimestamp">updateTimestamp.</param>
        /// <param name="metadata">metadata.</param>
        public BatchStatusInfoDto(
            Guid id,
            Models.StageEnum stage,
            Models.Status3Enum status,
            DateTime? updateTimestamp = null,
            string metadata = null)
        {
            this.Id = id;
            this.UpdateTimestamp = updateTimestamp;
            this.Stage = stage;
            this.Status = status;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets UpdateTimestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTimestamp { get; set; }

        /// <summary>
        /// Gets or sets Stage.
        /// </summary>
        [JsonProperty("stage")]
        public Models.StageEnum Stage { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.Status3Enum Status { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public string Metadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BatchStatusInfoDto : ({string.Join(", ", toStringOutput)})";
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
            return obj is BatchStatusInfoDto other &&                this.Id.Equals(other.Id) &&
                ((this.UpdateTimestamp == null && other.UpdateTimestamp == null) || (this.UpdateTimestamp?.Equals(other.UpdateTimestamp) == true)) &&
                this.Stage.Equals(other.Stage) &&
                this.Status.Equals(other.Status) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.UpdateTimestamp = {(this.UpdateTimestamp == null ? "null" : this.UpdateTimestamp.ToString())}");
            toStringOutput.Add($"this.Stage = {this.Stage}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : this.Metadata)}");
        }
    }
}