// <copyright file="PageableObject.cs" company="APIMatic">
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
    /// PageableObject.
    /// </summary>
    public class PageableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageableObject"/> class.
        /// </summary>
        public PageableObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageableObject"/> class.
        /// </summary>
        /// <param name="offset">offset.</param>
        /// <param name="sort">sort.</param>
        /// <param name="unpaged">unpaged.</param>
        /// <param name="paged">paged.</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="pageSize">pageSize.</param>
        public PageableObject(
            long? offset = null,
            Models.SortObject sort = null,
            bool? unpaged = null,
            bool? paged = null,
            int? pageNumber = null,
            int? pageSize = null)
        {
            this.Offset = offset;
            this.Sort = sort;
            this.Unpaged = unpaged;
            this.Paged = paged;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Gets or sets Offset.
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; }

        /// <summary>
        /// Gets or sets Sort.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SortObject Sort { get; set; }

        /// <summary>
        /// Gets or sets Unpaged.
        /// </summary>
        [JsonProperty("unpaged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unpaged { get; set; }

        /// <summary>
        /// Gets or sets Paged.
        /// </summary>
        [JsonProperty("paged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Paged { get; set; }

        /// <summary>
        /// Gets or sets PageNumber.
        /// </summary>
        [JsonProperty("pageNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Gets or sets PageSize.
        /// </summary>
        [JsonProperty("pageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PageableObject : ({string.Join(", ", toStringOutput)})";
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
            return obj is PageableObject other &&                ((this.Offset == null && other.Offset == null) || (this.Offset?.Equals(other.Offset) == true)) &&
                ((this.Sort == null && other.Sort == null) || (this.Sort?.Equals(other.Sort) == true)) &&
                ((this.Unpaged == null && other.Unpaged == null) || (this.Unpaged?.Equals(other.Unpaged) == true)) &&
                ((this.Paged == null && other.Paged == null) || (this.Paged?.Equals(other.Paged) == true)) &&
                ((this.PageNumber == null && other.PageNumber == null) || (this.PageNumber?.Equals(other.PageNumber) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Offset = {(this.Offset == null ? "null" : this.Offset.ToString())}");
            toStringOutput.Add($"this.Sort = {(this.Sort == null ? "null" : this.Sort.ToString())}");
            toStringOutput.Add($"this.Unpaged = {(this.Unpaged == null ? "null" : this.Unpaged.ToString())}");
            toStringOutput.Add($"this.Paged = {(this.Paged == null ? "null" : this.Paged.ToString())}");
            toStringOutput.Add($"this.PageNumber = {(this.PageNumber == null ? "null" : this.PageNumber.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
        }
    }
}