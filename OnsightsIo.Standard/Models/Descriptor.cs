// <copyright file="Descriptor.cs" company="APIMatic">
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
    /// Descriptor.
    /// </summary>
    public class Descriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Descriptor"/> class.
        /// </summary>
        public Descriptor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Descriptor"/> class.
        /// </summary>
        /// <param name="open">open.</param>
        /// <param name="automatic">automatic.</param>
        public Descriptor(
            bool? open = null,
            bool? automatic = null)
        {
            this.Open = open;
            this.Automatic = automatic;
        }

        /// <summary>
        /// Gets or sets Open.
        /// </summary>
        [JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Open { get; set; }

        /// <summary>
        /// Gets or sets Automatic.
        /// </summary>
        [JsonProperty("automatic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automatic { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Descriptor : ({string.Join(", ", toStringOutput)})";
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
            return obj is Descriptor other &&                ((this.Open == null && other.Open == null) || (this.Open?.Equals(other.Open) == true)) &&
                ((this.Automatic == null && other.Automatic == null) || (this.Automatic?.Equals(other.Automatic) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Open = {(this.Open == null ? "null" : this.Open.ToString())}");
            toStringOutput.Add($"this.Automatic = {(this.Automatic == null ? "null" : this.Automatic.ToString())}");
        }
    }
}