// <copyright file="Point2D.cs" company="APIMatic">
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
    /// Point2D.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point2D"/> class.
        /// </summary>
        public Point2D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point2D"/> class.
        /// </summary>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        public Point2D(
            double x,
            double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or sets X.
        /// </summary>
        [JsonProperty("x")]
        public double X { get; set; }

        /// <summary>
        /// Gets or sets Y.
        /// </summary>
        [JsonProperty("y")]
        public double Y { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Point2D : ({string.Join(", ", toStringOutput)})";
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
            return obj is Point2D other &&                this.X.Equals(other.X) &&
                this.Y.Equals(other.Y);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.X = {this.X}");
            toStringOutput.Add($"this.Y = {this.Y}");
        }
    }
}