// <copyright file="GeometryRepresentation.cs" company="APIMatic">
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
    /// GeometryRepresentation.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(LineRepresentation), "LineRepresentation")]
    [JsonSubtypes.KnownSubType(typeof(PointRepresentation), "PointRepresentation")]
    [JsonSubtypes.KnownSubType(typeof(PolygonRepresentation), "PolygonRepresentation")]
    [JsonSubtypes.KnownSubType(typeof(PolylineRepresentation), "PolylineRepresentation")]
    public class GeometryRepresentation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryRepresentation"/> class.
        /// </summary>
        public GeometryRepresentation()
        {
            this.Type = "GeometryRepresentation";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryRepresentation"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public GeometryRepresentation(
            string type = "GeometryRepresentation")
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GeometryRepresentation : ({string.Join(", ", toStringOutput)})";
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
            return obj is GeometryRepresentation other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}