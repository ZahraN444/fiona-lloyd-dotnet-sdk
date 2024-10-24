// <copyright file="JourneySankeyResponse.cs" company="APIMatic">
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
    /// JourneySankeyResponse.
    /// </summary>
    public class JourneySankeyResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySankeyResponse"/> class.
        /// </summary>
        public JourneySankeyResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySankeyResponse"/> class.
        /// </summary>
        /// <param name="items">items.</param>
        public JourneySankeyResponse(
            List<Models.JourneySankeyPathDefinition> items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.JourneySankeyPathDefinition> Items { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JourneySankeyResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is JourneySankeyResponse other &&                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
        }
    }
}