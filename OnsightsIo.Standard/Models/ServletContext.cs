// <copyright file="ServletContext.cs" company="APIMatic">
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
    /// ServletContext.
    /// </summary>
    public class ServletContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServletContext"/> class.
        /// </summary>
        public ServletContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServletContext"/> class.
        /// </summary>
        /// <param name="classLoader">classLoader.</param>
        /// <param name="majorVersion">majorVersion.</param>
        /// <param name="minorVersion">minorVersion.</param>
        /// <param name="attributeNames">attributeNames.</param>
        /// <param name="contextPath">contextPath.</param>
        /// <param name="initParameterNames">initParameterNames.</param>
        /// <param name="sessionTrackingModes">sessionTrackingModes.</param>
        /// <param name="sessionTimeout">sessionTimeout.</param>
        /// <param name="servletRegistrations">servletRegistrations.</param>
        /// <param name="filterRegistrations">filterRegistrations.</param>
        /// <param name="sessionCookieConfig">sessionCookieConfig.</param>
        /// <param name="defaultSessionTrackingModes">defaultSessionTrackingModes.</param>
        /// <param name="effectiveSessionTrackingModes">effectiveSessionTrackingModes.</param>
        /// <param name="jspConfigDescriptor">jspConfigDescriptor.</param>
        /// <param name="virtualServerName">virtualServerName.</param>
        /// <param name="requestCharacterEncoding">requestCharacterEncoding.</param>
        /// <param name="responseCharacterEncoding">responseCharacterEncoding.</param>
        /// <param name="effectiveMajorVersion">effectiveMajorVersion.</param>
        /// <param name="effectiveMinorVersion">effectiveMinorVersion.</param>
        /// <param name="serverInfo">serverInfo.</param>
        /// <param name="servletContextName">servletContextName.</param>
        public ServletContext(
            Models.ClassLoader1 classLoader = null,
            int? majorVersion = null,
            int? minorVersion = null,
            object attributeNames = null,
            string contextPath = null,
            object initParameterNames = null,
            List<Models.SessionTrackingModeEnum> sessionTrackingModes = null,
            int? sessionTimeout = null,
            Dictionary<string, Models.ServletRegistration> servletRegistrations = null,
            Dictionary<string, Models.FilterRegistration> filterRegistrations = null,
            Models.SessionCookieConfig sessionCookieConfig = null,
            List<Models.DefaultSessionTrackingModeEnum> defaultSessionTrackingModes = null,
            List<Models.EffectiveSessionTrackingModeEnum> effectiveSessionTrackingModes = null,
            Models.JspConfigDescriptor jspConfigDescriptor = null,
            string virtualServerName = null,
            string requestCharacterEncoding = null,
            string responseCharacterEncoding = null,
            int? effectiveMajorVersion = null,
            int? effectiveMinorVersion = null,
            string serverInfo = null,
            string servletContextName = null)
        {
            this.ClassLoader = classLoader;
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
            this.AttributeNames = attributeNames;
            this.ContextPath = contextPath;
            this.InitParameterNames = initParameterNames;
            this.SessionTrackingModes = sessionTrackingModes;
            this.SessionTimeout = sessionTimeout;
            this.ServletRegistrations = servletRegistrations;
            this.FilterRegistrations = filterRegistrations;
            this.SessionCookieConfig = sessionCookieConfig;
            this.DefaultSessionTrackingModes = defaultSessionTrackingModes;
            this.EffectiveSessionTrackingModes = effectiveSessionTrackingModes;
            this.JspConfigDescriptor = jspConfigDescriptor;
            this.VirtualServerName = virtualServerName;
            this.RequestCharacterEncoding = requestCharacterEncoding;
            this.ResponseCharacterEncoding = responseCharacterEncoding;
            this.EffectiveMajorVersion = effectiveMajorVersion;
            this.EffectiveMinorVersion = effectiveMinorVersion;
            this.ServerInfo = serverInfo;
            this.ServletContextName = servletContextName;
        }

        /// <summary>
        /// Gets or sets ClassLoader.
        /// </summary>
        [JsonProperty("classLoader", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClassLoader1 ClassLoader { get; set; }

        /// <summary>
        /// Gets or sets MajorVersion.
        /// </summary>
        [JsonProperty("majorVersion", NullValueHandling = NullValueHandling.Ignore)]
        public int? MajorVersion { get; set; }

        /// <summary>
        /// Gets or sets MinorVersion.
        /// </summary>
        [JsonProperty("minorVersion", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinorVersion { get; set; }

        /// <summary>
        /// Gets or sets AttributeNames.
        /// </summary>
        [JsonProperty("attributeNames", NullValueHandling = NullValueHandling.Ignore)]
        public object AttributeNames { get; set; }

        /// <summary>
        /// Gets or sets ContextPath.
        /// </summary>
        [JsonProperty("contextPath", NullValueHandling = NullValueHandling.Ignore)]
        public string ContextPath { get; set; }

        /// <summary>
        /// Gets or sets InitParameterNames.
        /// </summary>
        [JsonProperty("initParameterNames", NullValueHandling = NullValueHandling.Ignore)]
        public object InitParameterNames { get; set; }

        /// <summary>
        /// Gets or sets SessionTrackingModes.
        /// </summary>
        [JsonProperty("sessionTrackingModes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SessionTrackingModeEnum> SessionTrackingModes { get; set; }

        /// <summary>
        /// Gets or sets SessionTimeout.
        /// </summary>
        [JsonProperty("sessionTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// Gets or sets ServletRegistrations.
        /// </summary>
        [JsonProperty("servletRegistrations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.ServletRegistration> ServletRegistrations { get; set; }

        /// <summary>
        /// Gets or sets FilterRegistrations.
        /// </summary>
        [JsonProperty("filterRegistrations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.FilterRegistration> FilterRegistrations { get; set; }

        /// <summary>
        /// Gets or sets SessionCookieConfig.
        /// </summary>
        [JsonProperty("sessionCookieConfig", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SessionCookieConfig SessionCookieConfig { get; set; }

        /// <summary>
        /// Gets or sets DefaultSessionTrackingModes.
        /// </summary>
        [JsonProperty("defaultSessionTrackingModes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DefaultSessionTrackingModeEnum> DefaultSessionTrackingModes { get; set; }

        /// <summary>
        /// Gets or sets EffectiveSessionTrackingModes.
        /// </summary>
        [JsonProperty("effectiveSessionTrackingModes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EffectiveSessionTrackingModeEnum> EffectiveSessionTrackingModes { get; set; }

        /// <summary>
        /// Gets or sets JspConfigDescriptor.
        /// </summary>
        [JsonProperty("jspConfigDescriptor", NullValueHandling = NullValueHandling.Ignore)]
        public Models.JspConfigDescriptor JspConfigDescriptor { get; set; }

        /// <summary>
        /// Gets or sets VirtualServerName.
        /// </summary>
        [JsonProperty("virtualServerName", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualServerName { get; set; }

        /// <summary>
        /// Gets or sets RequestCharacterEncoding.
        /// </summary>
        [JsonProperty("requestCharacterEncoding", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestCharacterEncoding { get; set; }

        /// <summary>
        /// Gets or sets ResponseCharacterEncoding.
        /// </summary>
        [JsonProperty("responseCharacterEncoding", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponseCharacterEncoding { get; set; }

        /// <summary>
        /// Gets or sets EffectiveMajorVersion.
        /// </summary>
        [JsonProperty("effectiveMajorVersion", NullValueHandling = NullValueHandling.Ignore)]
        public int? EffectiveMajorVersion { get; set; }

        /// <summary>
        /// Gets or sets EffectiveMinorVersion.
        /// </summary>
        [JsonProperty("effectiveMinorVersion", NullValueHandling = NullValueHandling.Ignore)]
        public int? EffectiveMinorVersion { get; set; }

        /// <summary>
        /// Gets or sets ServerInfo.
        /// </summary>
        [JsonProperty("serverInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerInfo { get; set; }

        /// <summary>
        /// Gets or sets ServletContextName.
        /// </summary>
        [JsonProperty("servletContextName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServletContextName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServletContext : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServletContext other &&                ((this.ClassLoader == null && other.ClassLoader == null) || (this.ClassLoader?.Equals(other.ClassLoader) == true)) &&
                ((this.MajorVersion == null && other.MajorVersion == null) || (this.MajorVersion?.Equals(other.MajorVersion) == true)) &&
                ((this.MinorVersion == null && other.MinorVersion == null) || (this.MinorVersion?.Equals(other.MinorVersion) == true)) &&
                ((this.AttributeNames == null && other.AttributeNames == null) || (this.AttributeNames?.Equals(other.AttributeNames) == true)) &&
                ((this.ContextPath == null && other.ContextPath == null) || (this.ContextPath?.Equals(other.ContextPath) == true)) &&
                ((this.InitParameterNames == null && other.InitParameterNames == null) || (this.InitParameterNames?.Equals(other.InitParameterNames) == true)) &&
                ((this.SessionTrackingModes == null && other.SessionTrackingModes == null) || (this.SessionTrackingModes?.Equals(other.SessionTrackingModes) == true)) &&
                ((this.SessionTimeout == null && other.SessionTimeout == null) || (this.SessionTimeout?.Equals(other.SessionTimeout) == true)) &&
                ((this.ServletRegistrations == null && other.ServletRegistrations == null) || (this.ServletRegistrations?.Equals(other.ServletRegistrations) == true)) &&
                ((this.FilterRegistrations == null && other.FilterRegistrations == null) || (this.FilterRegistrations?.Equals(other.FilterRegistrations) == true)) &&
                ((this.SessionCookieConfig == null && other.SessionCookieConfig == null) || (this.SessionCookieConfig?.Equals(other.SessionCookieConfig) == true)) &&
                ((this.DefaultSessionTrackingModes == null && other.DefaultSessionTrackingModes == null) || (this.DefaultSessionTrackingModes?.Equals(other.DefaultSessionTrackingModes) == true)) &&
                ((this.EffectiveSessionTrackingModes == null && other.EffectiveSessionTrackingModes == null) || (this.EffectiveSessionTrackingModes?.Equals(other.EffectiveSessionTrackingModes) == true)) &&
                ((this.JspConfigDescriptor == null && other.JspConfigDescriptor == null) || (this.JspConfigDescriptor?.Equals(other.JspConfigDescriptor) == true)) &&
                ((this.VirtualServerName == null && other.VirtualServerName == null) || (this.VirtualServerName?.Equals(other.VirtualServerName) == true)) &&
                ((this.RequestCharacterEncoding == null && other.RequestCharacterEncoding == null) || (this.RequestCharacterEncoding?.Equals(other.RequestCharacterEncoding) == true)) &&
                ((this.ResponseCharacterEncoding == null && other.ResponseCharacterEncoding == null) || (this.ResponseCharacterEncoding?.Equals(other.ResponseCharacterEncoding) == true)) &&
                ((this.EffectiveMajorVersion == null && other.EffectiveMajorVersion == null) || (this.EffectiveMajorVersion?.Equals(other.EffectiveMajorVersion) == true)) &&
                ((this.EffectiveMinorVersion == null && other.EffectiveMinorVersion == null) || (this.EffectiveMinorVersion?.Equals(other.EffectiveMinorVersion) == true)) &&
                ((this.ServerInfo == null && other.ServerInfo == null) || (this.ServerInfo?.Equals(other.ServerInfo) == true)) &&
                ((this.ServletContextName == null && other.ServletContextName == null) || (this.ServletContextName?.Equals(other.ServletContextName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClassLoader = {(this.ClassLoader == null ? "null" : this.ClassLoader.ToString())}");
            toStringOutput.Add($"this.MajorVersion = {(this.MajorVersion == null ? "null" : this.MajorVersion.ToString())}");
            toStringOutput.Add($"this.MinorVersion = {(this.MinorVersion == null ? "null" : this.MinorVersion.ToString())}");
            toStringOutput.Add($"AttributeNames = {(this.AttributeNames == null ? "null" : this.AttributeNames.ToString())}");
            toStringOutput.Add($"this.ContextPath = {(this.ContextPath == null ? "null" : this.ContextPath)}");
            toStringOutput.Add($"InitParameterNames = {(this.InitParameterNames == null ? "null" : this.InitParameterNames.ToString())}");
            toStringOutput.Add($"this.SessionTrackingModes = {(this.SessionTrackingModes == null ? "null" : $"[{string.Join(", ", this.SessionTrackingModes)} ]")}");
            toStringOutput.Add($"this.SessionTimeout = {(this.SessionTimeout == null ? "null" : this.SessionTimeout.ToString())}");
            toStringOutput.Add($"ServletRegistrations = {(this.ServletRegistrations == null ? "null" : this.ServletRegistrations.ToString())}");
            toStringOutput.Add($"FilterRegistrations = {(this.FilterRegistrations == null ? "null" : this.FilterRegistrations.ToString())}");
            toStringOutput.Add($"this.SessionCookieConfig = {(this.SessionCookieConfig == null ? "null" : this.SessionCookieConfig.ToString())}");
            toStringOutput.Add($"this.DefaultSessionTrackingModes = {(this.DefaultSessionTrackingModes == null ? "null" : $"[{string.Join(", ", this.DefaultSessionTrackingModes)} ]")}");
            toStringOutput.Add($"this.EffectiveSessionTrackingModes = {(this.EffectiveSessionTrackingModes == null ? "null" : $"[{string.Join(", ", this.EffectiveSessionTrackingModes)} ]")}");
            toStringOutput.Add($"this.JspConfigDescriptor = {(this.JspConfigDescriptor == null ? "null" : this.JspConfigDescriptor.ToString())}");
            toStringOutput.Add($"this.VirtualServerName = {(this.VirtualServerName == null ? "null" : this.VirtualServerName)}");
            toStringOutput.Add($"this.RequestCharacterEncoding = {(this.RequestCharacterEncoding == null ? "null" : this.RequestCharacterEncoding)}");
            toStringOutput.Add($"this.ResponseCharacterEncoding = {(this.ResponseCharacterEncoding == null ? "null" : this.ResponseCharacterEncoding)}");
            toStringOutput.Add($"this.EffectiveMajorVersion = {(this.EffectiveMajorVersion == null ? "null" : this.EffectiveMajorVersion.ToString())}");
            toStringOutput.Add($"this.EffectiveMinorVersion = {(this.EffectiveMinorVersion == null ? "null" : this.EffectiveMinorVersion.ToString())}");
            toStringOutput.Add($"this.ServerInfo = {(this.ServerInfo == null ? "null" : this.ServerInfo)}");
            toStringOutput.Add($"this.ServletContextName = {(this.ServletContextName == null ? "null" : this.ServletContextName)}");
        }
    }
}