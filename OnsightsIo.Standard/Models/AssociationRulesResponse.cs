// <copyright file="AssociationRulesResponse.cs" company="APIMatic">
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
    /// AssociationRulesResponse.
    /// </summary>
    public class AssociationRulesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationRulesResponse"/> class.
        /// </summary>
        public AssociationRulesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationRulesResponse"/> class.
        /// </summary>
        /// <param name="entries">entries.</param>
        public AssociationRulesResponse(
            List<Models.AssociationRulesResponseItem> entries)
        {
            this.Entries = entries;
        }

        /// <summary>
        /// Gets or sets Entries.
        /// </summary>
        [JsonProperty("entries")]
        public List<Models.AssociationRulesResponseItem> Entries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AssociationRulesResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is AssociationRulesResponse other &&                ((this.Entries == null && other.Entries == null) || (this.Entries?.Equals(other.Entries) == true));
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