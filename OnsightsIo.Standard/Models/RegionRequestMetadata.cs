// <copyright file="RegionRequestMetadata.cs" company="APIMatic">
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
    /// RegionRequestMetadata.
    /// </summary>
    public class RegionRequestMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionRequestMetadata"/> class.
        /// </summary>
        public RegionRequestMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionRequestMetadata"/> class.
        /// </summary>
        /// <param name="naicsCode">naicsCode.</param>
        /// <param name="signType">signType.</param>
        /// <param name="size">size.</param>
        public RegionRequestMetadata(
            string naicsCode = null,
            Models.SignTypeEnum? signType = null,
            string size = null)
        {
            this.NaicsCode = naicsCode;
            this.SignType = signType;
            this.Size = size;
        }

        /// <summary>
        /// Gets or sets NaicsCode.
        /// </summary>
        [JsonProperty("naicsCode", NullValueHandling = NullValueHandling.Ignore)]
        public string NaicsCode { get; set; }

        /// <summary>
        /// Gets or sets SignType.
        /// </summary>
        [JsonProperty("signType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SignTypeEnum? SignType { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegionRequestMetadata : ({string.Join(", ", toStringOutput)})";
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
            return obj is RegionRequestMetadata other &&                ((this.NaicsCode == null && other.NaicsCode == null) || (this.NaicsCode?.Equals(other.NaicsCode) == true)) &&
                ((this.SignType == null && other.SignType == null) || (this.SignType?.Equals(other.SignType) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NaicsCode = {(this.NaicsCode == null ? "null" : this.NaicsCode)}");
            toStringOutput.Add($"this.SignType = {(this.SignType == null ? "null" : this.SignType.ToString())}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size)}");
        }
    }
}