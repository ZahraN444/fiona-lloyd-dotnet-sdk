// <copyright file="ConditionalDataString.cs" company="APIMatic">
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
    /// ConditionalDataString.
    /// </summary>
    public class ConditionalDataString
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalDataString"/> class.
        /// </summary>
        public ConditionalDataString()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalDataString"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="reason">reason.</param>
        public ConditionalDataString(
            string data = null,
            string reason = null)
        {
            this.Data = data;
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConditionalDataString : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConditionalDataString other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data)}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
        }
    }
}