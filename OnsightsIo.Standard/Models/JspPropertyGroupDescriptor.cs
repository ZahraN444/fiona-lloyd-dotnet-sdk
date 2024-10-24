// <copyright file="JspPropertyGroupDescriptor.cs" company="APIMatic">
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
    /// JspPropertyGroupDescriptor.
    /// </summary>
    public class JspPropertyGroupDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JspPropertyGroupDescriptor"/> class.
        /// </summary>
        public JspPropertyGroupDescriptor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JspPropertyGroupDescriptor"/> class.
        /// </summary>
        /// <param name="buffer">buffer.</param>
        /// <param name="errorOnUndeclaredNamespace">errorOnUndeclaredNamespace.</param>
        /// <param name="trimDirectiveWhitespaces">trimDirectiveWhitespaces.</param>
        /// <param name="deferredSyntaxAllowedAsLiteral">deferredSyntaxAllowedAsLiteral.</param>
        /// <param name="scriptingInvalid">scriptingInvalid.</param>
        /// <param name="errorOnELNotFound">errorOnELNotFound.</param>
        /// <param name="elIgnored">elIgnored.</param>
        /// <param name="pageEncoding">pageEncoding.</param>
        /// <param name="isXml">isXml.</param>
        /// <param name="includePreludes">includePreludes.</param>
        /// <param name="includeCodas">includeCodas.</param>
        /// <param name="urlPatterns">urlPatterns.</param>
        /// <param name="defaultContentType">defaultContentType.</param>
        public JspPropertyGroupDescriptor(
            string buffer = null,
            string errorOnUndeclaredNamespace = null,
            string trimDirectiveWhitespaces = null,
            string deferredSyntaxAllowedAsLiteral = null,
            string scriptingInvalid = null,
            string errorOnELNotFound = null,
            string elIgnored = null,
            string pageEncoding = null,
            string isXml = null,
            List<string> includePreludes = null,
            List<string> includeCodas = null,
            List<string> urlPatterns = null,
            string defaultContentType = null)
        {
            this.Buffer = buffer;
            this.ErrorOnUndeclaredNamespace = errorOnUndeclaredNamespace;
            this.TrimDirectiveWhitespaces = trimDirectiveWhitespaces;
            this.DeferredSyntaxAllowedAsLiteral = deferredSyntaxAllowedAsLiteral;
            this.ScriptingInvalid = scriptingInvalid;
            this.ErrorOnELNotFound = errorOnELNotFound;
            this.ElIgnored = elIgnored;
            this.PageEncoding = pageEncoding;
            this.IsXml = isXml;
            this.IncludePreludes = includePreludes;
            this.IncludeCodas = includeCodas;
            this.UrlPatterns = urlPatterns;
            this.DefaultContentType = defaultContentType;
        }

        /// <summary>
        /// Gets or sets Buffer.
        /// </summary>
        [JsonProperty("buffer", NullValueHandling = NullValueHandling.Ignore)]
        public string Buffer { get; set; }

        /// <summary>
        /// Gets or sets ErrorOnUndeclaredNamespace.
        /// </summary>
        [JsonProperty("errorOnUndeclaredNamespace", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorOnUndeclaredNamespace { get; set; }

        /// <summary>
        /// Gets or sets TrimDirectiveWhitespaces.
        /// </summary>
        [JsonProperty("trimDirectiveWhitespaces", NullValueHandling = NullValueHandling.Ignore)]
        public string TrimDirectiveWhitespaces { get; set; }

        /// <summary>
        /// Gets or sets DeferredSyntaxAllowedAsLiteral.
        /// </summary>
        [JsonProperty("deferredSyntaxAllowedAsLiteral", NullValueHandling = NullValueHandling.Ignore)]
        public string DeferredSyntaxAllowedAsLiteral { get; set; }

        /// <summary>
        /// Gets or sets ScriptingInvalid.
        /// </summary>
        [JsonProperty("scriptingInvalid", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptingInvalid { get; set; }

        /// <summary>
        /// Gets or sets ErrorOnELNotFound.
        /// </summary>
        [JsonProperty("errorOnELNotFound", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorOnELNotFound { get; set; }

        /// <summary>
        /// Gets or sets ElIgnored.
        /// </summary>
        [JsonProperty("elIgnored", NullValueHandling = NullValueHandling.Ignore)]
        public string ElIgnored { get; set; }

        /// <summary>
        /// Gets or sets PageEncoding.
        /// </summary>
        [JsonProperty("pageEncoding", NullValueHandling = NullValueHandling.Ignore)]
        public string PageEncoding { get; set; }

        /// <summary>
        /// Gets or sets IsXml.
        /// </summary>
        [JsonProperty("isXml", NullValueHandling = NullValueHandling.Ignore)]
        public string IsXml { get; set; }

        /// <summary>
        /// Gets or sets IncludePreludes.
        /// </summary>
        [JsonProperty("includePreludes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IncludePreludes { get; set; }

        /// <summary>
        /// Gets or sets IncludeCodas.
        /// </summary>
        [JsonProperty("includeCodas", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IncludeCodas { get; set; }

        /// <summary>
        /// Gets or sets UrlPatterns.
        /// </summary>
        [JsonProperty("urlPatterns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UrlPatterns { get; set; }

        /// <summary>
        /// Gets or sets DefaultContentType.
        /// </summary>
        [JsonProperty("defaultContentType", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultContentType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JspPropertyGroupDescriptor : ({string.Join(", ", toStringOutput)})";
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
            return obj is JspPropertyGroupDescriptor other &&                ((this.Buffer == null && other.Buffer == null) || (this.Buffer?.Equals(other.Buffer) == true)) &&
                ((this.ErrorOnUndeclaredNamespace == null && other.ErrorOnUndeclaredNamespace == null) || (this.ErrorOnUndeclaredNamespace?.Equals(other.ErrorOnUndeclaredNamespace) == true)) &&
                ((this.TrimDirectiveWhitespaces == null && other.TrimDirectiveWhitespaces == null) || (this.TrimDirectiveWhitespaces?.Equals(other.TrimDirectiveWhitespaces) == true)) &&
                ((this.DeferredSyntaxAllowedAsLiteral == null && other.DeferredSyntaxAllowedAsLiteral == null) || (this.DeferredSyntaxAllowedAsLiteral?.Equals(other.DeferredSyntaxAllowedAsLiteral) == true)) &&
                ((this.ScriptingInvalid == null && other.ScriptingInvalid == null) || (this.ScriptingInvalid?.Equals(other.ScriptingInvalid) == true)) &&
                ((this.ErrorOnELNotFound == null && other.ErrorOnELNotFound == null) || (this.ErrorOnELNotFound?.Equals(other.ErrorOnELNotFound) == true)) &&
                ((this.ElIgnored == null && other.ElIgnored == null) || (this.ElIgnored?.Equals(other.ElIgnored) == true)) &&
                ((this.PageEncoding == null && other.PageEncoding == null) || (this.PageEncoding?.Equals(other.PageEncoding) == true)) &&
                ((this.IsXml == null && other.IsXml == null) || (this.IsXml?.Equals(other.IsXml) == true)) &&
                ((this.IncludePreludes == null && other.IncludePreludes == null) || (this.IncludePreludes?.Equals(other.IncludePreludes) == true)) &&
                ((this.IncludeCodas == null && other.IncludeCodas == null) || (this.IncludeCodas?.Equals(other.IncludeCodas) == true)) &&
                ((this.UrlPatterns == null && other.UrlPatterns == null) || (this.UrlPatterns?.Equals(other.UrlPatterns) == true)) &&
                ((this.DefaultContentType == null && other.DefaultContentType == null) || (this.DefaultContentType?.Equals(other.DefaultContentType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Buffer = {(this.Buffer == null ? "null" : this.Buffer)}");
            toStringOutput.Add($"this.ErrorOnUndeclaredNamespace = {(this.ErrorOnUndeclaredNamespace == null ? "null" : this.ErrorOnUndeclaredNamespace)}");
            toStringOutput.Add($"this.TrimDirectiveWhitespaces = {(this.TrimDirectiveWhitespaces == null ? "null" : this.TrimDirectiveWhitespaces)}");
            toStringOutput.Add($"this.DeferredSyntaxAllowedAsLiteral = {(this.DeferredSyntaxAllowedAsLiteral == null ? "null" : this.DeferredSyntaxAllowedAsLiteral)}");
            toStringOutput.Add($"this.ScriptingInvalid = {(this.ScriptingInvalid == null ? "null" : this.ScriptingInvalid)}");
            toStringOutput.Add($"this.ErrorOnELNotFound = {(this.ErrorOnELNotFound == null ? "null" : this.ErrorOnELNotFound)}");
            toStringOutput.Add($"this.ElIgnored = {(this.ElIgnored == null ? "null" : this.ElIgnored)}");
            toStringOutput.Add($"this.PageEncoding = {(this.PageEncoding == null ? "null" : this.PageEncoding)}");
            toStringOutput.Add($"this.IsXml = {(this.IsXml == null ? "null" : this.IsXml)}");
            toStringOutput.Add($"this.IncludePreludes = {(this.IncludePreludes == null ? "null" : $"[{string.Join(", ", this.IncludePreludes)} ]")}");
            toStringOutput.Add($"this.IncludeCodas = {(this.IncludeCodas == null ? "null" : $"[{string.Join(", ", this.IncludeCodas)} ]")}");
            toStringOutput.Add($"this.UrlPatterns = {(this.UrlPatterns == null ? "null" : $"[{string.Join(", ", this.UrlPatterns)} ]")}");
            toStringOutput.Add($"this.DefaultContentType = {(this.DefaultContentType == null ? "null" : this.DefaultContentType)}");
        }
    }
}