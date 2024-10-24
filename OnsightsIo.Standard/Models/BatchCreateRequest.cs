// <copyright file="BatchCreateRequest.cs" company="APIMatic">
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
    /// BatchCreateRequest.
    /// </summary>
    public class BatchCreateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCreateRequest"/> class.
        /// </summary>
        public BatchCreateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCreateRequest"/> class.
        /// </summary>
        /// <param name="videos">videos.</param>
        /// <param name="retainIntermediaryData">retainIntermediaryData.</param>
        public BatchCreateRequest(
            List<string> videos,
            bool retainIntermediaryData)
        {
            this.Videos = videos;
            this.RetainIntermediaryData = retainIntermediaryData;
        }

        /// <summary>
        /// Gets or sets Videos.
        /// </summary>
        [JsonProperty("videos")]
        public List<string> Videos { get; set; }

        /// <summary>
        /// Gets or sets RetainIntermediaryData.
        /// </summary>
        [JsonProperty("retainIntermediaryData")]
        public bool RetainIntermediaryData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BatchCreateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is BatchCreateRequest other &&                ((this.Videos == null && other.Videos == null) || (this.Videos?.Equals(other.Videos) == true)) &&
                this.RetainIntermediaryData.Equals(other.RetainIntermediaryData);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Videos = {(this.Videos == null ? "null" : $"[{string.Join(", ", this.Videos)} ]")}");
            toStringOutput.Add($"this.RetainIntermediaryData = {this.RetainIntermediaryData}");
        }
    }
}