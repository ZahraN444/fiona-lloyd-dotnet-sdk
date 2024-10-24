// <copyright file="Environment.cs" company="APIMatic">
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
    /// Environment.
    /// </summary>
    public class Environment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Environment"/> class.
        /// </summary>
        public Environment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment"/> class.
        /// </summary>
        /// <param name="activeProfiles">activeProfiles.</param>
        /// <param name="defaultProfiles">defaultProfiles.</param>
        public Environment(
            List<string> activeProfiles = null,
            List<string> defaultProfiles = null)
        {
            this.ActiveProfiles = activeProfiles;
            this.DefaultProfiles = defaultProfiles;
        }

        /// <summary>
        /// Gets or sets ActiveProfiles.
        /// </summary>
        [JsonProperty("activeProfiles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ActiveProfiles { get; set; }

        /// <summary>
        /// Gets or sets DefaultProfiles.
        /// </summary>
        [JsonProperty("defaultProfiles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DefaultProfiles { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Environment : ({string.Join(", ", toStringOutput)})";
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
            return obj is Environment other &&                ((this.ActiveProfiles == null && other.ActiveProfiles == null) || (this.ActiveProfiles?.Equals(other.ActiveProfiles) == true)) &&
                ((this.DefaultProfiles == null && other.DefaultProfiles == null) || (this.DefaultProfiles?.Equals(other.DefaultProfiles) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ActiveProfiles = {(this.ActiveProfiles == null ? "null" : $"[{string.Join(", ", this.ActiveProfiles)} ]")}");
            toStringOutput.Add($"this.DefaultProfiles = {(this.DefaultProfiles == null ? "null" : $"[{string.Join(", ", this.DefaultProfiles)} ]")}");
        }
    }
}