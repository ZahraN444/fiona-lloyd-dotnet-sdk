// <copyright file="PixelDimensions.cs" company="APIMatic">
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
    /// PixelDimensions.
    /// </summary>
    public class PixelDimensions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PixelDimensions"/> class.
        /// </summary>
        public PixelDimensions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PixelDimensions"/> class.
        /// </summary>
        /// <param name="width">width.</param>
        /// <param name="height">height.</param>
        public PixelDimensions(
            int? width = null,
            int? height = null)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets Width.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets Height.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PixelDimensions : ({string.Join(", ", toStringOutput)})";
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
            return obj is PixelDimensions other &&                ((this.Width == null && other.Width == null) || (this.Width?.Equals(other.Width) == true)) &&
                ((this.Height == null && other.Height == null) || (this.Height?.Equals(other.Height) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Width = {(this.Width == null ? "null" : this.Width.ToString())}");
            toStringOutput.Add($"this.Height = {(this.Height == null ? "null" : this.Height.ToString())}");
        }
    }
}