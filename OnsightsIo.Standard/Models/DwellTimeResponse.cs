// <copyright file="DwellTimeResponse.cs" company="APIMatic">
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
    /// DwellTimeResponse.
    /// </summary>
    public class DwellTimeResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DwellTimeResponse"/> class.
        /// </summary>
        public DwellTimeResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DwellTimeResponse"/> class.
        /// </summary>
        /// <param name="entries">entries.</param>
        public DwellTimeResponse(
            List<Models.DwellTimeResponseEntry> entries)
        {
            this.Entries = entries;
        }

        /// <summary>
        /// Gets or sets Entries.
        /// </summary>
        [JsonProperty("entries")]
        public List<Models.DwellTimeResponseEntry> Entries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DwellTimeResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is DwellTimeResponse other &&                ((this.Entries == null && other.Entries == null) || (this.Entries?.Equals(other.Entries) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Entries = {(this.Entries == null ? "null" : $"[{string.Join(", ", this.Entries)} ]")}");
        }
    }
}