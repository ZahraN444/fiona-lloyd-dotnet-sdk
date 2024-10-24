// <copyright file="VisitorDestinationStoreResponseEntry.cs" company="APIMatic">
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
    /// VisitorDestinationStoreResponseEntry.
    /// </summary>
    public class VisitorDestinationStoreResponseEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorDestinationStoreResponseEntry"/> class.
        /// </summary>
        public VisitorDestinationStoreResponseEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorDestinationStoreResponseEntry"/> class.
        /// </summary>
        /// <param name="regionId">regionId.</param>
        /// <param name="fractionRegionIsFirstDestination">fractionRegionIsFirstDestination.</param>
        public VisitorDestinationStoreResponseEntry(
            Guid regionId,
            double fractionRegionIsFirstDestination)
        {
            this.RegionId = regionId;
            this.FractionRegionIsFirstDestination = fractionRegionIsFirstDestination;
        }

        /// <summary>
        /// Gets or sets RegionId.
        /// </summary>
        [JsonProperty("regionId")]
        public Guid RegionId { get; set; }

        /// <summary>
        /// Gets or sets FractionRegionIsFirstDestination.
        /// </summary>
        [JsonProperty("fractionRegionIsFirstDestination")]
        public double FractionRegionIsFirstDestination { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VisitorDestinationStoreResponseEntry : ({string.Join(", ", toStringOutput)})";
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
            return obj is VisitorDestinationStoreResponseEntry other &&                this.RegionId.Equals(other.RegionId) &&
                this.FractionRegionIsFirstDestination.Equals(other.FractionRegionIsFirstDestination);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegionId = {this.RegionId}");
            toStringOutput.Add($"this.FractionRegionIsFirstDestination = {this.FractionRegionIsFirstDestination}");
        }
    }
}