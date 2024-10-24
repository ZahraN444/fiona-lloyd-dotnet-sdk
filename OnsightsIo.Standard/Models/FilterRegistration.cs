// <copyright file="FilterRegistration.cs" company="APIMatic">
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
    /// FilterRegistration.
    /// </summary>
    public class FilterRegistration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterRegistration"/> class.
        /// </summary>
        public FilterRegistration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterRegistration"/> class.
        /// </summary>
        /// <param name="servletNameMappings">servletNameMappings.</param>
        /// <param name="urlPatternMappings">urlPatternMappings.</param>
        /// <param name="name">name.</param>
        /// <param name="className">className.</param>
        /// <param name="initParameters">initParameters.</param>
        public FilterRegistration(
            List<string> servletNameMappings = null,
            List<string> urlPatternMappings = null,
            string name = null,
            string className = null,
            Dictionary<string, string> initParameters = null)
        {
            this.ServletNameMappings = servletNameMappings;
            this.UrlPatternMappings = urlPatternMappings;
            this.Name = name;
            this.ClassName = className;
            this.InitParameters = initParameters;
        }

        /// <summary>
        /// Gets or sets ServletNameMappings.
        /// </summary>
        [JsonProperty("servletNameMappings", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServletNameMappings { get; set; }

        /// <summary>
        /// Gets or sets UrlPatternMappings.
        /// </summary>
        [JsonProperty("urlPatternMappings", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UrlPatternMappings { get; set; }

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

            return $"FilterRegistration : ({string.Join(", ", toStringOutput)})";
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
            return obj is FilterRegistration other &&                ((this.ServletNameMappings == null && other.ServletNameMappings == null) || (this.ServletNameMappings?.Equals(other.ServletNameMappings) == true)) &&
                ((this.UrlPatternMappings == null && other.UrlPatternMappings == null) || (this.UrlPatternMappings?.Equals(other.UrlPatternMappings) == true)) &&
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
            toStringOutput.Add($"this.ServletNameMappings = {(this.ServletNameMappings == null ? "null" : $"[{string.Join(", ", this.ServletNameMappings)} ]")}");
            toStringOutput.Add($"this.UrlPatternMappings = {(this.UrlPatternMappings == null ? "null" : $"[{string.Join(", ", this.UrlPatternMappings)} ]")}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.ClassName = {(this.ClassName == null ? "null" : this.ClassName)}");
            toStringOutput.Add($"InitParameters = {(this.InitParameters == null ? "null" : this.InitParameters.ToString())}");
        }
    }
}