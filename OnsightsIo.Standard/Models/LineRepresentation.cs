// <copyright file="LineRepresentation.cs" company="APIMatic">
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
    /// LineRepresentation.
    /// </summary>
    public class LineRepresentation : GeometryRepresentation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineRepresentation"/> class.
        /// </summary>
        public LineRepresentation()
        {
            this.Type = "LineRepresentation";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LineRepresentation"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="type">type.</param>
        public LineRepresentation(
            List<Models.Point2D> mValue,
            string type = "LineRepresentation")
            : base(
                type)
        {
            this.MValue = mValue;
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        [JsonRequired]
        public List<Models.Point2D> MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LineRepresentation : ({string.Join(", ", toStringOutput)})";
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
            return obj is LineRepresentation other &&                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : $"[{string.Join(", ", this.MValue)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}