// <copyright file="TaglibDescriptor.cs" company="APIMatic">
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
    /// TaglibDescriptor.
    /// </summary>
    public class TaglibDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaglibDescriptor"/> class.
        /// </summary>
        public TaglibDescriptor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaglibDescriptor"/> class.
        /// </summary>
        /// <param name="taglibURI">taglibURI.</param>
        /// <param name="taglibLocation">taglibLocation.</param>
        public TaglibDescriptor(
            string taglibURI = null,
            string taglibLocation = null)
        {
            this.TaglibURI = taglibURI;
            this.TaglibLocation = taglibLocation;
        }

        /// <summary>
        /// Gets or sets TaglibURI.
        /// </summary>
        [JsonProperty("taglibURI", NullValueHandling = NullValueHandling.Ignore)]
        public string TaglibURI { get; set; }

        /// <summary>
        /// Gets or sets TaglibLocation.
        /// </summary>
        [JsonProperty("taglibLocation", NullValueHandling = NullValueHandling.Ignore)]
        public string TaglibLocation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TaglibDescriptor : ({string.Join(", ", toStringOutput)})";
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
            return obj is TaglibDescriptor other &&                ((this.TaglibURI == null && other.TaglibURI == null) || (this.TaglibURI?.Equals(other.TaglibURI) == true)) &&
                ((this.TaglibLocation == null && other.TaglibLocation == null) || (this.TaglibLocation?.Equals(other.TaglibLocation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TaglibURI = {(this.TaglibURI == null ? "null" : this.TaglibURI)}");
            toStringOutput.Add($"this.TaglibLocation = {(this.TaglibLocation == null ? "null" : this.TaglibLocation)}");
        }
    }
}