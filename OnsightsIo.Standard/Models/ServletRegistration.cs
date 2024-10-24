// <copyright file="ServletRegistration.cs" company="APIMatic">
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
    /// ServletRegistration.
    /// </summary>
    public class ServletRegistration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServletRegistration"/> class.
        /// </summary>
        public ServletRegistration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServletRegistration"/> class.
        /// </summary>
        /// <param name="mappings">mappings.</param>
        /// <param name="runAsRole">runAsRole.</param>
        /// <param name="name">name.</param>
        /// <param name="className">className.</param>
        /// <param name="initParameters">initParameters.</param>
        public ServletRegistration(
            List<string> mappings = null,
            string runAsRole = null,
            string name = null,
            string className = null,
            Dictionary<string, string> initParameters = null)
        {
            this.Mappings = mappings;
            this.RunAsRole = runAsRole;
            this.Name = name;
            this.ClassName = className;
            this.InitParameters = initParameters;
        }

        /// <summary>
        /// Gets or sets Mappings.
        /// </summary>
        [JsonProperty("mappings", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Mappings { get; set; }

        /// <summary>
        /// Gets or sets RunAsRole.
        /// </summary>
        [JsonProperty("runAsRole", NullValueHandling = NullValueHandling.Ignore)]
        public string RunAsRole { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ClassName.
        /// </summary>
        [JsonProperty("className", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets InitParameters.
        /// </summary>
        [JsonProperty("initParameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> InitParameters { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServletRegistration : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServletRegistration other &&                ((this.Mappings == null && other.Mappings == null) || (this.Mappings?.Equals(other.Mappings) == true)) &&
                ((this.RunAsRole == null && other.RunAsRole == null) || (this.RunAsRole?.Equals(other.RunAsRole) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ClassName == null && other.ClassName == null) || (this.ClassName?.Equals(other.ClassName) == true)) &&
                ((this.InitParameters == null && other.InitParameters == null) || (this.InitParameters?.Equals(other.InitParameters) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mappings = {(this.Mappings == null ? "null" : $"[{string.Join(", ", this.Mappings)} ]")}");
            toStringOutput.Add($"this.RunAsRole = {(this.RunAsRole == null ? "null" : this.RunAsRole)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.ClassName = {(this.ClassName == null ? "null" : this.ClassName)}");
            toStringOutput.Add($"InitParameters = {(this.InitParameters == null ? "null" : this.InitParameters.ToString())}");
        }
    }
}