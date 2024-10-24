// <copyright file="RedirectView.cs" company="APIMatic">
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
    /// RedirectView.
    /// </summary>
    public class RedirectView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectView"/> class.
        /// </summary>
        public RedirectView()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectView"/> class.
        /// </summary>
        /// <param name="applicationContext">applicationContext.</param>
        /// <param name="servletContext">servletContext.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="requestContextAttribute">requestContextAttribute.</param>
        /// <param name="staticAttributes">staticAttributes.</param>
        /// <param name="exposePathVariables">exposePathVariables.</param>
        /// <param name="exposeContextBeansAsAttributes">exposeContextBeansAsAttributes.</param>
        /// <param name="exposedContextBeanNames">exposedContextBeanNames.</param>
        /// <param name="beanName">beanName.</param>
        /// <param name="url">url.</param>
        /// <param name="contextRelative">contextRelative.</param>
        /// <param name="http10Compatible">http10Compatible.</param>
        /// <param name="exposeModelAttributes">exposeModelAttributes.</param>
        /// <param name="encodingScheme">encodingScheme.</param>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="expandUriTemplateVariables">expandUriTemplateVariables.</param>
        /// <param name="propagateQueryParams">propagateQueryParams.</param>
        /// <param name="hosts">hosts.</param>
        /// <param name="redirectViewProp">redirectView.</param>
        /// <param name="propagateQueryProperties">propagateQueryProperties.</param>
        /// <param name="attributesMap">attributesMap.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="attributesCSV">attributesCSV.</param>
        public RedirectView(
            Models.ApplicationContext applicationContext = null,
            Models.ServletContext servletContext = null,
            string contentType = null,
            string requestContextAttribute = null,
            object staticAttributes = null,
            bool? exposePathVariables = null,
            bool? exposeContextBeansAsAttributes = null,
            List<string> exposedContextBeanNames = null,
            string beanName = null,
            string url = null,
            bool? contextRelative = null,
            bool? http10Compatible = null,
            bool? exposeModelAttributes = null,
            string encodingScheme = null,
            Models.HttpStatusCode statusCode = null,
            bool? expandUriTemplateVariables = null,
            bool? propagateQueryParams = null,
            List<string> hosts = null,
            bool? redirectViewProp = null,
            bool? propagateQueryProperties = null,
            object attributesMap = null,
            Dictionary<string, string> attributes = null,
            string attributesCSV = null)
        {
            this.ApplicationContext = applicationContext;
            this.ServletContext = servletContext;
            this.ContentType = contentType;
            this.RequestContextAttribute = requestContextAttribute;
            this.StaticAttributes = staticAttributes;
            this.ExposePathVariables = exposePathVariables;
            this.ExposeContextBeansAsAttributes = exposeContextBeansAsAttributes;
            this.ExposedContextBeanNames = exposedContextBeanNames;
            this.BeanName = beanName;
            this.Url = url;
            this.ContextRelative = contextRelative;
            this.Http10Compatible = http10Compatible;
            this.ExposeModelAttributes = exposeModelAttributes;
            this.EncodingScheme = encodingScheme;
            this.StatusCode = statusCode;
            this.ExpandUriTemplateVariables = expandUriTemplateVariables;
            this.PropagateQueryParams = propagateQueryParams;
            this.Hosts = hosts;
            this.RedirectViewProp = redirectViewProp;
            this.PropagateQueryProperties = propagateQueryProperties;
            this.AttributesMap = attributesMap;
            this.Attributes = attributes;
            this.AttributesCSV = attributesCSV;
        }

        /// <summary>
        /// Gets or sets ApplicationContext.
        /// </summary>
        [JsonProperty("applicationContext", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplicationContext ApplicationContext { get; set; }

        /// <summary>
        /// Gets or sets ServletContext.
        /// </summary>
        [JsonProperty("servletContext", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServletContext ServletContext { get; set; }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("contentType", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets RequestContextAttribute.
        /// </summary>
        [JsonProperty("requestContextAttribute", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestContextAttribute { get; set; }

        /// <summary>
        /// Gets or sets StaticAttributes.
        /// </summary>
        [JsonProperty("staticAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public object StaticAttributes { get; set; }

        /// <summary>
        /// Gets or sets ExposePathVariables.
        /// </summary>
        [JsonProperty("exposePathVariables", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExposePathVariables { get; set; }

        /// <summary>
        /// Gets or sets ExposeContextBeansAsAttributes.
        /// </summary>
        [JsonProperty("exposeContextBeansAsAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExposeContextBeansAsAttributes { get; set; }

        /// <summary>
        /// Gets or sets ExposedContextBeanNames.
        /// </summary>
        [JsonProperty("exposedContextBeanNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExposedContextBeanNames { get; set; }

        /// <summary>
        /// Gets or sets BeanName.
        /// </summary>
        [JsonProperty("beanName", NullValueHandling = NullValueHandling.Ignore)]
        public string BeanName { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets ContextRelative.
        /// </summary>
        [JsonProperty("contextRelative", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContextRelative { get; set; }

        /// <summary>
        /// Gets or sets Http10Compatible.
        /// </summary>
        [JsonProperty("http10Compatible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Http10Compatible { get; set; }

        /// <summary>
        /// Gets or sets ExposeModelAttributes.
        /// </summary>
        [JsonProperty("exposeModelAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExposeModelAttributes { get; set; }

        /// <summary>
        /// Gets or sets EncodingScheme.
        /// </summary>
        [JsonProperty("encodingScheme", NullValueHandling = NullValueHandling.Ignore)]
        public string EncodingScheme { get; set; }

        /// <summary>
        /// Gets or sets StatusCode.
        /// </summary>
        [JsonProperty("statusCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or sets ExpandUriTemplateVariables.
        /// </summary>
        [JsonProperty("expandUriTemplateVariables", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExpandUriTemplateVariables { get; set; }

        /// <summary>
        /// Gets or sets PropagateQueryParams.
        /// </summary>
        [JsonProperty("propagateQueryParams", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PropagateQueryParams { get; set; }

        /// <summary>
        /// Gets or sets Hosts.
        /// </summary>
        [JsonProperty("hosts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// Gets or sets RedirectViewProp.
        /// </summary>
        [JsonProperty("redirectView", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirectViewProp { get; set; }

        /// <summary>
        /// Gets or sets PropagateQueryProperties.
        /// </summary>
        [JsonProperty("propagateQueryProperties", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PropagateQueryProperties { get; set; }

        /// <summary>
        /// Gets or sets AttributesMap.
        /// </summary>
        [JsonProperty("attributesMap", NullValueHandling = NullValueHandling.Ignore)]
        public object AttributesMap { get; set; }

        /// <summary>
        /// Gets or sets Attributes.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or sets AttributesCSV.
        /// </summary>
        [JsonProperty("attributesCSV", NullValueHandling = NullValueHandling.Ignore)]
        public string AttributesCSV { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RedirectView : ({string.Join(", ", toStringOutput)})";
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
            return obj is RedirectView other &&                ((this.ApplicationContext == null && other.ApplicationContext == null) || (this.ApplicationContext?.Equals(other.ApplicationContext) == true)) &&
                ((this.ServletContext == null && other.ServletContext == null) || (this.ServletContext?.Equals(other.ServletContext) == true)) &&
                ((this.ContentType == null && other.ContentType == null) || (this.ContentType?.Equals(other.ContentType) == true)) &&
                ((this.RequestContextAttribute == null && other.RequestContextAttribute == null) || (this.RequestContextAttribute?.Equals(other.RequestContextAttribute) == true)) &&
                ((this.StaticAttributes == null && other.StaticAttributes == null) || (this.StaticAttributes?.Equals(other.StaticAttributes) == true)) &&
                ((this.ExposePathVariables == null && other.ExposePathVariables == null) || (this.ExposePathVariables?.Equals(other.ExposePathVariables) == true)) &&
                ((this.ExposeContextBeansAsAttributes == null && other.ExposeContextBeansAsAttributes == null) || (this.ExposeContextBeansAsAttributes?.Equals(other.ExposeContextBeansAsAttributes) == true)) &&
                ((this.ExposedContextBeanNames == null && other.ExposedContextBeanNames == null) || (this.ExposedContextBeanNames?.Equals(other.ExposedContextBeanNames) == true)) &&
                ((this.BeanName == null && other.BeanName == null) || (this.BeanName?.Equals(other.BeanName) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.ContextRelative == null && other.ContextRelative == null) || (this.ContextRelative?.Equals(other.ContextRelative) == true)) &&
                ((this.Http10Compatible == null && other.Http10Compatible == null) || (this.Http10Compatible?.Equals(other.Http10Compatible) == true)) &&
                ((this.ExposeModelAttributes == null && other.ExposeModelAttributes == null) || (this.ExposeModelAttributes?.Equals(other.ExposeModelAttributes) == true)) &&
                ((this.EncodingScheme == null && other.EncodingScheme == null) || (this.EncodingScheme?.Equals(other.EncodingScheme) == true)) &&
                ((this.StatusCode == null && other.StatusCode == null) || (this.StatusCode?.Equals(other.StatusCode) == true)) &&
                ((this.ExpandUriTemplateVariables == null && other.ExpandUriTemplateVariables == null) || (this.ExpandUriTemplateVariables?.Equals(other.ExpandUriTemplateVariables) == true)) &&
                ((this.PropagateQueryParams == null && other.PropagateQueryParams == null) || (this.PropagateQueryParams?.Equals(other.PropagateQueryParams) == true)) &&
                ((this.Hosts == null && other.Hosts == null) || (this.Hosts?.Equals(other.Hosts) == true)) &&
                ((this.RedirectViewProp == null && other.RedirectViewProp == null) || (this.RedirectViewProp?.Equals(other.RedirectViewProp) == true)) &&
                ((this.PropagateQueryProperties == null && other.PropagateQueryProperties == null) || (this.PropagateQueryProperties?.Equals(other.PropagateQueryProperties) == true)) &&
                ((this.AttributesMap == null && other.AttributesMap == null) || (this.AttributesMap?.Equals(other.AttributesMap) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                ((this.AttributesCSV == null && other.AttributesCSV == null) || (this.AttributesCSV?.Equals(other.AttributesCSV) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ApplicationContext = {(this.ApplicationContext == null ? "null" : this.ApplicationContext.ToString())}");
            toStringOutput.Add($"this.ServletContext = {(this.ServletContext == null ? "null" : this.ServletContext.ToString())}");
            toStringOutput.Add($"this.ContentType = {(this.ContentType == null ? "null" : this.ContentType)}");
            toStringOutput.Add($"this.RequestContextAttribute = {(this.RequestContextAttribute == null ? "null" : this.RequestContextAttribute)}");
            toStringOutput.Add($"StaticAttributes = {(this.StaticAttributes == null ? "null" : this.StaticAttributes.ToString())}");
            toStringOutput.Add($"this.ExposePathVariables = {(this.ExposePathVariables == null ? "null" : this.ExposePathVariables.ToString())}");
            toStringOutput.Add($"this.ExposeContextBeansAsAttributes = {(this.ExposeContextBeansAsAttributes == null ? "null" : this.ExposeContextBeansAsAttributes.ToString())}");
            toStringOutput.Add($"this.ExposedContextBeanNames = {(this.ExposedContextBeanNames == null ? "null" : $"[{string.Join(", ", this.ExposedContextBeanNames)} ]")}");
            toStringOutput.Add($"this.BeanName = {(this.BeanName == null ? "null" : this.BeanName)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.ContextRelative = {(this.ContextRelative == null ? "null" : this.ContextRelative.ToString())}");
            toStringOutput.Add($"this.Http10Compatible = {(this.Http10Compatible == null ? "null" : this.Http10Compatible.ToString())}");
            toStringOutput.Add($"this.ExposeModelAttributes = {(this.ExposeModelAttributes == null ? "null" : this.ExposeModelAttributes.ToString())}");
            toStringOutput.Add($"this.EncodingScheme = {(this.EncodingScheme == null ? "null" : this.EncodingScheme)}");
            toStringOutput.Add($"this.StatusCode = {(this.StatusCode == null ? "null" : this.StatusCode.ToString())}");
            toStringOutput.Add($"this.ExpandUriTemplateVariables = {(this.ExpandUriTemplateVariables == null ? "null" : this.ExpandUriTemplateVariables.ToString())}");
            toStringOutput.Add($"this.PropagateQueryParams = {(this.PropagateQueryParams == null ? "null" : this.PropagateQueryParams.ToString())}");
            toStringOutput.Add($"this.Hosts = {(this.Hosts == null ? "null" : $"[{string.Join(", ", this.Hosts)} ]")}");
            toStringOutput.Add($"this.RedirectViewProp = {(this.RedirectViewProp == null ? "null" : this.RedirectViewProp.ToString())}");
            toStringOutput.Add($"this.PropagateQueryProperties = {(this.PropagateQueryProperties == null ? "null" : this.PropagateQueryProperties.ToString())}");
            toStringOutput.Add($"AttributesMap = {(this.AttributesMap == null ? "null" : this.AttributesMap.ToString())}");
            toStringOutput.Add($"Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.AttributesCSV = {(this.AttributesCSV == null ? "null" : this.AttributesCSV)}");
        }
    }
}