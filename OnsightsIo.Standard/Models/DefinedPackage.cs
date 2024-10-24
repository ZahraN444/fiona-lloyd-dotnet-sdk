// <copyright file="DefinedPackage.cs" company="APIMatic">
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
    /// DefinedPackage.
    /// </summary>
    public class DefinedPackage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefinedPackage"/> class.
        /// </summary>
        public DefinedPackage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinedPackage"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="declaredAnnotations">declaredAnnotations.</param>
        /// <param name="mSealed">sealed.</param>
        /// <param name="specificationTitle">specificationTitle.</param>
        /// <param name="specificationVersion">specificationVersion.</param>
        /// <param name="specificationVendor">specificationVendor.</param>
        /// <param name="implementationTitle">implementationTitle.</param>
        /// <param name="implementationVersion">implementationVersion.</param>
        /// <param name="implementationVendor">implementationVendor.</param>
        public DefinedPackage(
            string name = null,
            object annotations = null,
            object declaredAnnotations = null,
            bool? mSealed = null,
            string specificationTitle = null,
            string specificationVersion = null,
            string specificationVendor = null,
            string implementationTitle = null,
            string implementationVersion = null,
            string implementationVendor = null)
        {
            this.Name = name;
            this.Annotations = annotations;
            this.DeclaredAnnotations = declaredAnnotations;
            this.MSealed = mSealed;
            this.SpecificationTitle = specificationTitle;
            this.SpecificationVersion = specificationVersion;
            this.SpecificationVendor = specificationVendor;
            this.ImplementationTitle = implementationTitle;
            this.ImplementationVersion = implementationVersion;
            this.ImplementationVendor = implementationVendor;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        /// Gets or sets MSealed.
        /// </summary>
        [JsonProperty("sealed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MSealed { get; set; }

        /// <summary>
        /// Gets or sets SpecificationTitle.
        /// </summary>
        [JsonProperty("specificationTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecificationTitle { get; set; }

        /// <summary>
        /// Gets or sets SpecificationVersion.
        /// </summary>
        [JsonProperty("specificationVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecificationVersion { get; set; }

        /// <summary>
        /// Gets or sets SpecificationVendor.
        /// </summary>
        [JsonProperty("specificationVendor", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecificationVendor { get; set; }

        /// <summary>
        /// Gets or sets ImplementationTitle.
        /// </summary>
        [JsonProperty("implementationTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string ImplementationTitle { get; set; }

        /// <summary>
        /// Gets or sets ImplementationVersion.
        /// </summary>
        [JsonProperty("implementationVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ImplementationVersion { get; set; }

        /// <summary>
        /// Gets or sets ImplementationVendor.
        /// </summary>
        [JsonProperty("implementationVendor", NullValueHandling = NullValueHandling.Ignore)]
        public string ImplementationVendor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DefinedPackage : ({string.Join(", ", toStringOutput)})";
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
            return obj is DefinedPackage other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Annotations == null && other.Annotations == null) || (this.Annotations?.Equals(other.Annotations) == true)) &&
                ((this.DeclaredAnnotations == null && other.DeclaredAnnotations == null) || (this.DeclaredAnnotations?.Equals(other.DeclaredAnnotations) == true)) &&
                ((this.MSealed == null && other.MSealed == null) || (this.MSealed?.Equals(other.MSealed) == true)) &&
                ((this.SpecificationTitle == null && other.SpecificationTitle == null) || (this.SpecificationTitle?.Equals(other.SpecificationTitle) == true)) &&
                ((this.SpecificationVersion == null && other.SpecificationVersion == null) || (this.SpecificationVersion?.Equals(other.SpecificationVersion) == true)) &&
                ((this.SpecificationVendor == null && other.SpecificationVendor == null) || (this.SpecificationVendor?.Equals(other.SpecificationVendor) == true)) &&
                ((this.ImplementationTitle == null && other.ImplementationTitle == null) || (this.ImplementationTitle?.Equals(other.ImplementationTitle) == true)) &&
                ((this.ImplementationVersion == null && other.ImplementationVersion == null) || (this.ImplementationVersion?.Equals(other.ImplementationVersion) == true)) &&
                ((this.ImplementationVendor == null && other.ImplementationVendor == null) || (this.ImplementationVendor?.Equals(other.ImplementationVendor) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"Annotations = {(this.Annotations == null ? "null" : this.Annotations.ToString())}");
            toStringOutput.Add($"DeclaredAnnotations = {(this.DeclaredAnnotations == null ? "null" : this.DeclaredAnnotations.ToString())}");
            toStringOutput.Add($"this.MSealed = {(this.MSealed == null ? "null" : this.MSealed.ToString())}");
            toStringOutput.Add($"this.SpecificationTitle = {(this.SpecificationTitle == null ? "null" : this.SpecificationTitle)}");
            toStringOutput.Add($"this.SpecificationVersion = {(this.SpecificationVersion == null ? "null" : this.SpecificationVersion)}");
            toStringOutput.Add($"this.SpecificationVendor = {(this.SpecificationVendor == null ? "null" : this.SpecificationVendor)}");
            toStringOutput.Add($"this.ImplementationTitle = {(this.ImplementationTitle == null ? "null" : this.ImplementationTitle)}");
            toStringOutput.Add($"this.ImplementationVersion = {(this.ImplementationVersion == null ? "null" : this.ImplementationVersion)}");
            toStringOutput.Add($"this.ImplementationVendor = {(this.ImplementationVendor == null ? "null" : this.ImplementationVendor)}");
        }
    }
}