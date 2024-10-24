// <copyright file="UnnamedModule.cs" company="APIMatic">
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
    /// UnnamedModule.
    /// </summary>
    public class UnnamedModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnnamedModule"/> class.
        /// </summary>
        public UnnamedModule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnnamedModule"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="classLoader">classLoader.</param>
        /// <param name="descriptor">descriptor.</param>
        /// <param name="named">named.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="declaredAnnotations">declaredAnnotations.</param>
        /// <param name="packages">packages.</param>
        /// <param name="layer">layer.</param>
        public UnnamedModule(
            string name = null,
            Models.ClassLoader1 classLoader = null,
            Models.Descriptor descriptor = null,
            bool? named = null,
            object annotations = null,
            object declaredAnnotations = null,
            List<string> packages = null,
            object layer = null)
        {
            this.Name = name;
            this.ClassLoader = classLoader;
            this.Descriptor = descriptor;
            this.Named = named;
            this.Annotations = annotations;
            this.DeclaredAnnotations = declaredAnnotations;
            this.Packages = packages;
            this.Layer = layer;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ClassLoader.
        /// </summary>
        [JsonProperty("classLoader", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClassLoader1 ClassLoader { get; set; }

        /// <summary>
        /// Gets or sets Descriptor.
        /// </summary>
        [JsonProperty("descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Descriptor Descriptor { get; set; }

        /// <summary>
        /// Gets or sets Named.
        /// </summary>
        [JsonProperty("named", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Named { get; set; }

        /// <summary>
        /// Gets or sets Annotations.
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public object Annotations { get; set; }

        /// <summary>
        /// Gets or sets DeclaredAnnotations.
        /// </summary>
        [JsonProperty("declaredAnnotations", NullValueHandling = NullValueHandling.Ignore)]
        public object DeclaredAnnotations { get; set; }

        /// <summary>
        /// Gets or sets Packages.
        /// </summary>
        [JsonProperty("packages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Packages { get; set; }

        /// <summary>
        /// Gets or sets Layer.
        /// </summary>
        [JsonProperty("layer", NullValueHandling = NullValueHandling.Ignore)]
        public object Layer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UnnamedModule : ({string.Join(", ", toStringOutput)})";
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
            return obj is UnnamedModule other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ClassLoader == null && other.ClassLoader == null) || (this.ClassLoader?.Equals(other.ClassLoader) == true)) &&
                ((this.Descriptor == null && other.Descriptor == null) || (this.Descriptor?.Equals(other.Descriptor) == true)) &&
                ((this.Named == null && other.Named == null) || (this.Named?.Equals(other.Named) == true)) &&
                ((this.Annotations == null && other.Annotations == null) || (this.Annotations?.Equals(other.Annotations) == true)) &&
                ((this.DeclaredAnnotations == null && other.DeclaredAnnotations == null) || (this.DeclaredAnnotations?.Equals(other.DeclaredAnnotations) == true)) &&
                ((this.Packages == null && other.Packages == null) || (this.Packages?.Equals(other.Packages) == true)) &&
                ((this.Layer == null && other.Layer == null) || (this.Layer?.Equals(other.Layer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.ClassLoader = {(this.ClassLoader == null ? "null" : this.ClassLoader.ToString())}");
            toStringOutput.Add($"this.Descriptor = {(this.Descriptor == null ? "null" : this.Descriptor.ToString())}");
            toStringOutput.Add($"this.Named = {(this.Named == null ? "null" : this.Named.ToString())}");
            toStringOutput.Add($"Annotations = {(this.Annotations == null ? "null" : this.Annotations.ToString())}");
            toStringOutput.Add($"DeclaredAnnotations = {(this.DeclaredAnnotations == null ? "null" : this.DeclaredAnnotations.ToString())}");
            toStringOutput.Add($"this.Packages = {(this.Packages == null ? "null" : $"[{string.Join(", ", this.Packages)} ]")}");
            toStringOutput.Add($"Layer = {(this.Layer == null ? "null" : this.Layer.ToString())}");
        }
    }
}