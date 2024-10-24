// <copyright file="GeometryValidationResponse.cs" company="APIMatic">
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
    /// GeometryValidationResponse.
    /// </summary>
    public class GeometryValidationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryValidationResponse"/> class.
        /// </summary>
        public GeometryValidationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryValidationResponse"/> class.
        /// </summary>
        /// <param name="isValid">isValid.</param>
        /// <param name="error">error.</param>
        public GeometryValidationResponse(
            bool isValid,
            string error = null)
        {
            this.IsValid = isValid;
            this.Error = error;
        }

        /// <summary>
        /// Gets or sets IsValid.
        /// </summary>
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GeometryValidationResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is GeometryValidationResponse other &&                this.IsValid.Equals(other.IsValid) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IsValid = {this.IsValid}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error)}");
        }
    }
}