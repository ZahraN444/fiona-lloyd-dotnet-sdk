// <copyright file="MissedCaptureResponse.cs" company="APIMatic">
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
    /// MissedCaptureResponse.
    /// </summary>
    public class MissedCaptureResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissedCaptureResponse"/> class.
        /// </summary>
        public MissedCaptureResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissedCaptureResponse"/> class.
        /// </summary>
        /// <param name="entries">entries.</param>
        public MissedCaptureResponse(
            List<Models.MissedCaptureResponseItem> entries)
        {
            this.Entries = entries;
        }

        /// <summary>
        /// Gets or sets Entries.
        /// </summary>
        [JsonProperty("entries")]
        public List<Models.MissedCaptureResponseItem> Entries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MissedCaptureResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is MissedCaptureResponse other &&                ((this.Entries == null && other.Entries == null) || (this.Entries?.Equals(other.Entries) == true));
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