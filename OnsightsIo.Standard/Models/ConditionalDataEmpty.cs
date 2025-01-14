// <copyright file="ConditionalDataEmpty.cs" company="APIMatic">
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
    /// ConditionalDataEmpty.
    /// </summary>
    public class ConditionalDataEmpty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalDataEmpty"/> class.
        /// </summary>
        public ConditionalDataEmpty()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalDataEmpty"/> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        public ConditionalDataEmpty(
            string reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("reason")]
        [JsonRequired]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConditionalDataEmpty : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConditionalDataEmpty other &&                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
        }
    }
}