// <copyright file="SortObject.cs" company="APIMatic">
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
    /// SortObject.
    /// </summary>
    public class SortObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortObject"/> class.
        /// </summary>
        public SortObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortObject"/> class.
        /// </summary>
        /// <param name="empty">empty.</param>
        /// <param name="unsorted">unsorted.</param>
        /// <param name="sorted">sorted.</param>
        public SortObject(
            bool? empty = null,
            bool? unsorted = null,
            bool? sorted = null)
        {
            this.Empty = empty;
            this.Unsorted = unsorted;
            this.Sorted = sorted;
        }

        /// <summary>
        /// Gets or sets Empty.
        /// </summary>
        [JsonProperty("empty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Empty { get; set; }

        /// <summary>
        /// Gets or sets Unsorted.
        /// </summary>
        [JsonProperty("unsorted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unsorted { get; set; }

        /// <summary>
        /// Gets or sets Sorted.
        /// </summary>
        [JsonProperty("sorted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sorted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SortObject : ({string.Join(", ", toStringOutput)})";
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
            return obj is SortObject other &&                ((this.Empty == null && other.Empty == null) || (this.Empty?.Equals(other.Empty) == true)) &&
                ((this.Unsorted == null && other.Unsorted == null) || (this.Unsorted?.Equals(other.Unsorted) == true)) &&
                ((this.Sorted == null && other.Sorted == null) || (this.Sorted?.Equals(other.Sorted) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Empty = {(this.Empty == null ? "null" : this.Empty.ToString())}");
            toStringOutput.Add($"this.Unsorted = {(this.Unsorted == null ? "null" : this.Unsorted.ToString())}");
            toStringOutput.Add($"this.Sorted = {(this.Sorted == null ? "null" : this.Sorted.ToString())}");
        }
    }
}