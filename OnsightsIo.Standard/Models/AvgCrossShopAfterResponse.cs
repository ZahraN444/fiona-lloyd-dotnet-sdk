// <copyright file="AvgCrossShopAfterResponse.cs" company="APIMatic">
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
    /// AvgCrossShopAfterResponse.
    /// </summary>
    public class AvgCrossShopAfterResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvgCrossShopAfterResponse"/> class.
        /// </summary>
        public AvgCrossShopAfterResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvgCrossShopAfterResponse"/> class.
        /// </summary>
        /// <param name="crossShopEntries">crossShopEntries.</param>
        public AvgCrossShopAfterResponse(
            List<Models.AvgCrossShopAfterResponseEntry> crossShopEntries)
        {
            this.CrossShopEntries = crossShopEntries;
        }

        /// <summary>
        /// Gets or sets CrossShopEntries.
        /// </summary>
        [JsonProperty("crossShopEntries")]
        public List<Models.AvgCrossShopAfterResponseEntry> CrossShopEntries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AvgCrossShopAfterResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is AvgCrossShopAfterResponse other &&                ((this.CrossShopEntries == null && other.CrossShopEntries == null) || (this.CrossShopEntries?.Equals(other.CrossShopEntries) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CrossShopEntries = {(this.CrossShopEntries == null ? "null" : $"[{string.Join(", ", this.CrossShopEntries)} ]")}");
        }
    }
}