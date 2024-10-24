// <copyright file="ApplicationContext.cs" company="APIMatic">
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
    /// ApplicationContext.
    /// </summary>
    public class ApplicationContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationContext"/> class.
        /// </summary>
        public ApplicationContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationContext"/> class.
        /// </summary>
        /// <param name="parent">parent.</param>
        /// <param name="id">id.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="applicationName">applicationName.</param>
        /// <param name="startupDate">startupDate.</param>
        /// <param name="autowireCapableBeanFactory">autowireCapableBeanFactory.</param>
        /// <param name="environment">environment.</param>
        /// <param name="beanDefinitionNames">beanDefinitionNames.</param>
        /// <param name="beanDefinitionCount">beanDefinitionCount.</param>
        /// <param name="parentBeanFactory">parentBeanFactory.</param>
        /// <param name="classLoader">classLoader.</param>
        public ApplicationContext(
            Models.ApplicationContext parent = null,
            string id = null,
            string displayName = null,
            string applicationName = null,
            long? startupDate = null,
            object autowireCapableBeanFactory = null,
            Models.Environment environment = null,
            List<string> beanDefinitionNames = null,
            int? beanDefinitionCount = null,
            object parentBeanFactory = null,
            Models.ClassLoader classLoader = null)
        {
            this.Parent = parent;
            this.Id = id;
            this.DisplayName = displayName;
            this.ApplicationName = applicationName;
            this.StartupDate = startupDate;
            this.AutowireCapableBeanFactory = autowireCapableBeanFactory;
            this.Environment = environment;
            this.BeanDefinitionNames = beanDefinitionNames;
            this.BeanDefinitionCount = beanDefinitionCount;
            this.ParentBeanFactory = parentBeanFactory;
            this.ClassLoader = classLoader;
        }

        /// <summary>
        /// Gets or sets Parent.
        /// </summary>
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplicationContext Parent { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets ApplicationName.
        /// </summary>
        [JsonProperty("applicationName", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets StartupDate.
        /// </summary>
        [JsonProperty("startupDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartupDate { get; set; }

        /// <summary>
        /// Gets or sets AutowireCapableBeanFactory.
        /// </summary>
        [JsonProperty("autowireCapableBeanFactory", NullValueHandling = NullValueHandling.Ignore)]
        public object AutowireCapableBeanFactory { get; set; }

        /// <summary>
        /// Gets or sets Environment.
        /// </summary>
        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Environment Environment { get; set; }

        /// <summary>
        /// Gets or sets BeanDefinitionNames.
        /// </summary>
        [JsonProperty("beanDefinitionNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BeanDefinitionNames { get; set; }

        /// <summary>
        /// Gets or sets BeanDefinitionCount.
        /// </summary>
        [JsonProperty("beanDefinitionCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? BeanDefinitionCount { get; set; }

        /// <summary>
        /// Gets or sets ParentBeanFactory.
        /// </summary>
        [JsonProperty("parentBeanFactory", NullValueHandling = NullValueHandling.Ignore)]
        public object ParentBeanFactory { get; set; }

        /// <summary>
        /// Gets or sets ClassLoader.
        /// </summary>
        [JsonProperty("classLoader", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClassLoader ClassLoader { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplicationContext : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApplicationContext other &&                ((this.Parent == null && other.Parent == null) || (this.Parent?.Equals(other.Parent) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.ApplicationName == null && other.ApplicationName == null) || (this.ApplicationName?.Equals(other.ApplicationName) == true)) &&
                ((this.StartupDate == null && other.StartupDate == null) || (this.StartupDate?.Equals(other.StartupDate) == true)) &&
                ((this.AutowireCapableBeanFactory == null && other.AutowireCapableBeanFactory == null) || (this.AutowireCapableBeanFactory?.Equals(other.AutowireCapableBeanFactory) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.BeanDefinitionNames == null && other.BeanDefinitionNames == null) || (this.BeanDefinitionNames?.Equals(other.BeanDefinitionNames) == true)) &&
                ((this.BeanDefinitionCount == null && other.BeanDefinitionCount == null) || (this.BeanDefinitionCount?.Equals(other.BeanDefinitionCount) == true)) &&
                ((this.ParentBeanFactory == null && other.ParentBeanFactory == null) || (this.ParentBeanFactory?.Equals(other.ParentBeanFactory) == true)) &&
                ((this.ClassLoader == null && other.ClassLoader == null) || (this.ClassLoader?.Equals(other.ClassLoader) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Parent = {(this.Parent == null ? "null" : this.Parent.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName)}");
            toStringOutput.Add($"this.ApplicationName = {(this.ApplicationName == null ? "null" : this.ApplicationName)}");
            toStringOutput.Add($"this.StartupDate = {(this.StartupDate == null ? "null" : this.StartupDate.ToString())}");
            toStringOutput.Add($"AutowireCapableBeanFactory = {(this.AutowireCapableBeanFactory == null ? "null" : this.AutowireCapableBeanFactory.ToString())}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment.ToString())}");
            toStringOutput.Add($"this.BeanDefinitionNames = {(this.BeanDefinitionNames == null ? "null" : $"[{string.Join(", ", this.BeanDefinitionNames)} ]")}");
            toStringOutput.Add($"this.BeanDefinitionCount = {(this.BeanDefinitionCount == null ? "null" : this.BeanDefinitionCount.ToString())}");
            toStringOutput.Add($"ParentBeanFactory = {(this.ParentBeanFactory == null ? "null" : this.ParentBeanFactory.ToString())}");
            toStringOutput.Add($"this.ClassLoader = {(this.ClassLoader == null ? "null" : this.ClassLoader.ToString())}");
        }
    }
}