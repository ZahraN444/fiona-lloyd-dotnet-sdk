// <copyright file="RegionMetadataNaicsCode.cs" company="APIMatic">
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
    /// RegionMetadataNaicsCode.
    /// </summary>
    public class RegionMetadataNaicsCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionMetadataNaicsCode"/> class.
        /// </summary>
        public RegionMetadataNaicsCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionMetadataNaicsCode"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="name">name.</param>
        public RegionMetadataNaicsCode(
            string code = null,
            string name = null)
        {
            this.Code = code;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegionMetadataNaicsCode : ({string.Join(", ", toStringOutput)})";
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
            return obj is RegionMetadataNaicsCode other &&                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
        }
    }
}