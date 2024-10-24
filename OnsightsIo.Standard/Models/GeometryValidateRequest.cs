// <copyright file="GeometryValidateRequest.cs" company="APIMatic">
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
using OnsightsIo.Standard.Models.Containers;
using OnsightsIo.Standard.Utilities;

namespace OnsightsIo.Standard.Models
{
    /// <summary>
    /// GeometryValidateRequest.
    /// </summary>
    public class GeometryValidateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryValidateRequest"/> class.
        /// </summary>
        public GeometryValidateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryValidateRequest"/> class.
        /// </summary>
        /// <param name="boundary">boundary.</param>
        public GeometryValidateRequest(
            GeometryValidateRequestBoundary boundary)
        {
            this.Boundary = boundary;
        }

        /// <summary>
        /// Gets or sets Boundary.
        /// </summary>
        [JsonProperty("boundary")]
        public GeometryValidateRequestBoundary Boundary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GeometryValidateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is GeometryValidateRequest other &&                ((this.Boundary == null && other.Boundary == null) || (this.Boundary?.Equals(other.Boundary) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Boundary = {(this.Boundary == null ? "null" : this.Boundary.ToString())}");
        }
    }
}