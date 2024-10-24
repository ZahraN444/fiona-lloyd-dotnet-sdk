// <copyright file="CrossShopBreakdownResponse.cs" company="APIMatic">
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
    /// CrossShopBreakdownResponse.
    /// </summary>
    public class CrossShopBreakdownResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossShopBreakdownResponse"/> class.
        /// </summary>
        public CrossShopBreakdownResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossShopBreakdownResponse"/> class.
        /// </summary>
        /// <param name="visitorEntries">visitorEntries.</param>
        public CrossShopBreakdownResponse(
            List<Models.CrossShopBreakdownResponseEntry> visitorEntries)
        {
            this.VisitorEntries = visitorEntries;
        }

        /// <summary>
        /// Gets or sets VisitorEntries.
        /// </summary>
        [JsonProperty("visitorEntries")]
        public List<Models.CrossShopBreakdownResponseEntry> VisitorEntries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CrossShopBreakdownResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CrossShopBreakdownResponse other &&                ((this.VisitorEntries == null && other.VisitorEntries == null) || (this.VisitorEntries?.Equals(other.VisitorEntries) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VisitorEntries = {(this.VisitorEntries == null ? "null" : $"[{string.Join(", ", this.VisitorEntries)} ]")}");
        }
    }
}