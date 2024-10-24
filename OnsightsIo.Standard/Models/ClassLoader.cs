// <copyright file="ClassLoader.cs" company="APIMatic">
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
    /// ClassLoader.
    /// </summary>
    public class ClassLoader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassLoader"/> class.
        /// </summary>
        public ClassLoader()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassLoader"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="registeredAsParallelCapable">registeredAsParallelCapable.</param>
        /// <param name="parent">parent.</param>
        /// <param name="unnamedModule">unnamedModule.</param>
        /// <param name="definedPackages">definedPackages.</param>
        /// <param name="defaultAssertionStatus">defaultAssertionStatus.</param>
        public ClassLoader(
            string name = null,
            bool? registeredAsParallelCapable = null,
            Models.Parent parent = null,
            Models.UnnamedModule unnamedModule = null,
            List<Models.DefinedPackage> definedPackages = null,
            bool? defaultAssertionStatus = null)
        {
            this.Name = name;
            this.RegisteredAsParallelCapable = registeredAsParallelCapable;
            this.Parent = parent;
            this.UnnamedModule = unnamedModule;
            this.DefinedPackages = definedPackages;
            this.DefaultAssertionStatus = defaultAssertionStatus;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets RegisteredAsParallelCapable.
        /// </summary>
        [JsonProperty("registeredAsParallelCapable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RegisteredAsParallelCapable { get; set; }

        /// <summary>
        /// Gets or sets Parent.
        /// </summary>
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Parent Parent { get; set; }

        /// <summary>
        /// Gets or sets UnnamedModule.
        /// </summary>
        [JsonProperty("unnamedModule", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UnnamedModule UnnamedModule { get; set; }

        /// <summary>
        /// Gets or sets DefinedPackages.
        /// </summary>
        [JsonProperty("definedPackages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DefinedPackage> DefinedPackages { get; set; }

        /// <summary>
        /// Gets or sets DefaultAssertionStatus.
        /// </summary>
        [JsonProperty("defaultAssertionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultAssertionStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClassLoader : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClassLoader other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.RegisteredAsParallelCapable == null && other.RegisteredAsParallelCapable == null) || (this.RegisteredAsParallelCapable?.Equals(other.RegisteredAsParallelCapable) == true)) &&
                ((this.Parent == null && other.Parent == null) || (this.Parent?.Equals(other.Parent) == true)) &&
                ((this.UnnamedModule == null && other.UnnamedModule == null) || (this.UnnamedModule?.Equals(other.UnnamedModule) == true)) &&
                ((this.DefinedPackages == null && other.DefinedPackages == null) || (this.DefinedPackages?.Equals(other.DefinedPackages) == true)) &&
                ((this.DefaultAssertionStatus == null && other.DefaultAssertionStatus == null) || (this.DefaultAssertionStatus?.Equals(other.DefaultAssertionStatus) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.RegisteredAsParallelCapable = {(this.RegisteredAsParallelCapable == null ? "null" : this.RegisteredAsParallelCapable.ToString())}");
            toStringOutput.Add($"this.Parent = {(this.Parent == null ? "null" : this.Parent.ToString())}");
            toStringOutput.Add($"this.UnnamedModule = {(this.UnnamedModule == null ? "null" : this.UnnamedModule.ToString())}");
            toStringOutput.Add($"this.DefinedPackages = {(this.DefinedPackages == null ? "null" : $"[{string.Join(", ", this.DefinedPackages)} ]")}");
            toStringOutput.Add($"this.DefaultAssertionStatus = {(this.DefaultAssertionStatus == null ? "null" : this.DefaultAssertionStatus.ToString())}");
        }
    }
}