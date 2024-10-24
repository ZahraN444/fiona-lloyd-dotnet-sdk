// <copyright file="SessionCookieConfig.cs" company="APIMatic">
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
    /// SessionCookieConfig.
    /// </summary>
    public class SessionCookieConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCookieConfig"/> class.
        /// </summary>
        public SessionCookieConfig()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCookieConfig"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="path">path.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="comment">comment.</param>
        /// <param name="secure">secure.</param>
        /// <param name="domain">domain.</param>
        /// <param name="maxAge">maxAge.</param>
        /// <param name="httpOnly">httpOnly.</param>
        public SessionCookieConfig(
            string name = null,
            string path = null,
            Dictionary<string, string> attributes = null,
            string comment = null,
            bool? secure = null,
            string domain = null,
            int? maxAge = null,
            bool? httpOnly = null)
        {
            this.Name = name;
            this.Path = path;
            this.Attributes = attributes;
            this.Comment = comment;
            this.Secure = secure;
            this.Domain = domain;
            this.MaxAge = maxAge;
            this.HttpOnly = httpOnly;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Path.
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets Attributes.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or sets Comment.
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets Secure.
        /// </summary>
        [JsonProperty("secure", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Secure { get; set; }

        /// <summary>
        /// Gets or sets Domain.
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets MaxAge.
        /// </summary>
        [JsonProperty("maxAge", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAge { get; set; }

        /// <summary>
        /// Gets or sets HttpOnly.
        /// </summary>
        [JsonProperty("httpOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HttpOnly { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SessionCookieConfig : ({string.Join(", ", toStringOutput)})";
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
            return obj is SessionCookieConfig other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                ((this.Comment == null && other.Comment == null) || (this.Comment?.Equals(other.Comment) == true)) &&
                ((this.Secure == null && other.Secure == null) || (this.Secure?.Equals(other.Secure) == true)) &&
                ((this.Domain == null && other.Domain == null) || (this.Domain?.Equals(other.Domain) == true)) &&
                ((this.MaxAge == null && other.MaxAge == null) || (this.MaxAge?.Equals(other.MaxAge) == true)) &&
                ((this.HttpOnly == null && other.HttpOnly == null) || (this.HttpOnly?.Equals(other.HttpOnly) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path)}");
            toStringOutput.Add($"Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.Comment = {(this.Comment == null ? "null" : this.Comment)}");
            toStringOutput.Add($"this.Secure = {(this.Secure == null ? "null" : this.Secure.ToString())}");
            toStringOutput.Add($"this.Domain = {(this.Domain == null ? "null" : this.Domain)}");
            toStringOutput.Add($"this.MaxAge = {(this.MaxAge == null ? "null" : this.MaxAge.ToString())}");
            toStringOutput.Add($"this.HttpOnly = {(this.HttpOnly == null ? "null" : this.HttpOnly.ToString())}");
        }
    }
}