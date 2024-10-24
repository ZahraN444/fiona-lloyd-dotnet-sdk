// <copyright file="ConditionalDataOk.cs" company="APIMatic">
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
    /// ConditionalDataOk.
    /// </summary>
    public class ConditionalDataOk
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalDataOk"/> class.
        /// </summary>
        public ConditionalDataOk()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalDataOk"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public ConditionalDataOk(
            object data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        [JsonRequired]
        public object Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConditionalDataOk : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConditionalDataOk other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}