// <copyright file="MissedCaptureResponseItem.cs" company="APIMatic">
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
    /// MissedCaptureResponseItem.
    /// </summary>
    public class MissedCaptureResponseItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissedCaptureResponseItem"/> class.
        /// </summary>
        public MissedCaptureResponseItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissedCaptureResponseItem"/> class.
        /// </summary>
        /// <param name="numberOfEntitiesMissedFactor">numberOfEntitiesMissedFactor.</param>
        /// <param name="numberOfEntitiesVisitedBothRegionsFactor">numberOfEntitiesVisitedBothRegionsFactor.</param>
        /// <param name="totalInSignatureRegionFactor">totalInSignatureRegionFactor.</param>
        /// <param name="signatureRegionId">signatureRegionId.</param>
        /// <param name="numberOfEntitiesMissed">numberOfEntitiesMissed.</param>
        /// <param name="numberOfEntitiesVisitedBothRegions">numberOfEntitiesVisitedBothRegions.</param>
        /// <param name="totalInSignatureRegion">totalInSignatureRegion.</param>
        public MissedCaptureResponseItem(
            double numberOfEntitiesMissedFactor,
            double numberOfEntitiesVisitedBothRegionsFactor,
            double totalInSignatureRegionFactor,
            Guid signatureRegionId,
            int? numberOfEntitiesMissed = null,
            int? numberOfEntitiesVisitedBothRegions = null,
            int? totalInSignatureRegion = null)
        {
            this.NumberOfEntitiesMissed = numberOfEntitiesMissed;
            this.NumberOfEntitiesMissedFactor = numberOfEntitiesMissedFactor;
            this.NumberOfEntitiesVisitedBothRegions = numberOfEntitiesVisitedBothRegions;
            this.NumberOfEntitiesVisitedBothRegionsFactor = numberOfEntitiesVisitedBothRegionsFactor;
            this.TotalInSignatureRegion = totalInSignatureRegion;
            this.TotalInSignatureRegionFactor = totalInSignatureRegionFactor;
            this.SignatureRegionId = signatureRegionId;
        }

        /// <summary>
        /// Gets or sets NumberOfEntitiesMissed.
        /// </summary>
        [JsonProperty("numberOfEntitiesMissed", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfEntitiesMissed { get; set; }

        /// <summary>
        /// Gets or sets NumberOfEntitiesMissedFactor.
        /// </summary>
        [JsonProperty("numberOfEntitiesMissedFactor")]
        public double NumberOfEntitiesMissedFactor { get; set; }

        /// <summary>
        /// Gets or sets NumberOfEntitiesVisitedBothRegions.
        /// </summary>
        [JsonProperty("numberOfEntitiesVisitedBothRegions", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfEntitiesVisitedBothRegions { get; set; }

        /// <summary>
        /// Gets or sets NumberOfEntitiesVisitedBothRegionsFactor.
        /// </summary>
        [JsonProperty("numberOfEntitiesVisitedBothRegionsFactor")]
        public double NumberOfEntitiesVisitedBothRegionsFactor { get; set; }

        /// <summary>
        /// Gets or sets TotalInSignatureRegion.
        /// </summary>
        [JsonProperty("totalInSignatureRegion", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalInSignatureRegion { get; set; }

        /// <summary>
        /// Gets or sets TotalInSignatureRegionFactor.
        /// </summary>
        [JsonProperty("totalInSignatureRegionFactor")]
        public double TotalInSignatureRegionFactor { get; set; }

        /// <summary>
        /// Gets or sets SignatureRegionId.
        /// </summary>
        [JsonProperty("signatureRegionId")]
        public Guid SignatureRegionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MissedCaptureResponseItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is MissedCaptureResponseItem other &&                ((this.NumberOfEntitiesMissed == null && other.NumberOfEntitiesMissed == null) || (this.NumberOfEntitiesMissed?.Equals(other.NumberOfEntitiesMissed) == true)) &&
                this.NumberOfEntitiesMissedFactor.Equals(other.NumberOfEntitiesMissedFactor) &&
                ((this.NumberOfEntitiesVisitedBothRegions == null && other.NumberOfEntitiesVisitedBothRegions == null) || (this.NumberOfEntitiesVisitedBothRegions?.Equals(other.NumberOfEntitiesVisitedBothRegions) == true)) &&
                this.NumberOfEntitiesVisitedBothRegionsFactor.Equals(other.NumberOfEntitiesVisitedBothRegionsFactor) &&
                ((this.TotalInSignatureRegion == null && other.TotalInSignatureRegion == null) || (this.TotalInSignatureRegion?.Equals(other.TotalInSignatureRegion) == true)) &&
                this.TotalInSignatureRegionFactor.Equals(other.TotalInSignatureRegionFactor) &&
                this.SignatureRegionId.Equals(other.SignatureRegionId);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NumberOfEntitiesMissed = {(this.NumberOfEntitiesMissed == null ? "null" : this.NumberOfEntitiesMissed.ToString())}");
            toStringOutput.Add($"this.NumberOfEntitiesMissedFactor = {this.NumberOfEntitiesMissedFactor}");
            toStringOutput.Add($"this.NumberOfEntitiesVisitedBothRegions = {(this.NumberOfEntitiesVisitedBothRegions == null ? "null" : this.NumberOfEntitiesVisitedBothRegions.ToString())}");
            toStringOutput.Add($"this.NumberOfEntitiesVisitedBothRegionsFactor = {this.NumberOfEntitiesVisitedBothRegionsFactor}");
            toStringOutput.Add($"this.TotalInSignatureRegion = {(this.TotalInSignatureRegion == null ? "null" : this.TotalInSignatureRegion.ToString())}");
            toStringOutput.Add($"this.TotalInSignatureRegionFactor = {this.TotalInSignatureRegionFactor}");
            toStringOutput.Add($"this.SignatureRegionId = {this.SignatureRegionId}");
        }
    }
}