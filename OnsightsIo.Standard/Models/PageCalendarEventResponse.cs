// <copyright file="PageCalendarEventResponse.cs" company="APIMatic">
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
    /// PageCalendarEventResponse.
    /// </summary>
    public class PageCalendarEventResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageCalendarEventResponse"/> class.
        /// </summary>
        public PageCalendarEventResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageCalendarEventResponse"/> class.
        /// </summary>
        /// <param name="totalPages">totalPages.</param>
        /// <param name="totalElements">totalElements.</param>
        /// <param name="size">size.</param>
        /// <param name="content">content.</param>
        /// <param name="number">number.</param>
        /// <param name="sort">sort.</param>
        /// <param name="numberOfElements">numberOfElements.</param>
        /// <param name="pageable">pageable.</param>
        /// <param name="first">first.</param>
        /// <param name="last">last.</param>
        /// <param name="empty">empty.</param>
        public PageCalendarEventResponse(
            int? totalPages = null,
            long? totalElements = null,
            int? size = null,
            List<Models.CalendarEventResponse> content = null,
            int? number = null,
            Models.SortObject sort = null,
            int? numberOfElements = null,
            Models.PageableObject pageable = null,
            bool? first = null,
            bool? last = null,
            bool? empty = null)
        {
            this.TotalPages = totalPages;
            this.TotalElements = totalElements;
            this.Size = size;
            this.Content = content;
            this.Number = number;
            this.Sort = sort;
            this.NumberOfElements = numberOfElements;
            this.Pageable = pageable;
            this.First = first;
            this.Last = last;
            this.Empty = empty;
        }

        /// <summary>
        /// Gets or sets TotalPages.
        /// </summary>
        [JsonProperty("totalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or sets TotalElements.
        /// </summary>
        [JsonProperty("totalElements", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalElements { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or sets Content.
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CalendarEventResponse> Content { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public int? Number { get; set; }

        /// <summary>
        /// Gets or sets Sort.
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SortObject Sort { get; set; }

        /// <summary>
        /// Gets or sets NumberOfElements.
        /// </summary>
        [JsonProperty("numberOfElements", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfElements { get; set; }

        /// <summary>
        /// Gets or sets Pageable.
        /// </summary>
        [JsonProperty("pageable", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PageableObject Pageable { get; set; }

        /// <summary>
        /// Gets or sets First.
        /// </summary>
        [JsonProperty("first", NullValueHandling = NullValueHandling.Ignore)]
        public bool? First { get; set; }

        /// <summary>
        /// Gets or sets Last.
        /// </summary>
        [JsonProperty("last", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Last { get; set; }

        /// <summary>
        /// Gets or sets Empty.
        /// </summary>
        [JsonProperty("empty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Empty { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PageCalendarEventResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PageCalendarEventResponse other &&                ((this.TotalPages == null && other.TotalPages == null) || (this.TotalPages?.Equals(other.TotalPages) == true)) &&
                ((this.TotalElements == null && other.TotalElements == null) || (this.TotalElements?.Equals(other.TotalElements) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true)) &&
                ((this.Content == null && other.Content == null) || (this.Content?.Equals(other.Content) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Sort == null && other.Sort == null) || (this.Sort?.Equals(other.Sort) == true)) &&
                ((this.NumberOfElements == null && other.NumberOfElements == null) || (this.NumberOfElements?.Equals(other.NumberOfElements) == true)) &&
                ((this.Pageable == null && other.Pageable == null) || (this.Pageable?.Equals(other.Pageable) == true)) &&
                ((this.First == null && other.First == null) || (this.First?.Equals(other.First) == true)) &&
                ((this.Last == null && other.Last == null) || (this.Last?.Equals(other.Last) == true)) &&
                ((this.Empty == null && other.Empty == null) || (this.Empty?.Equals(other.Empty) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"this.TotalElements = {(this.TotalElements == null ? "null" : this.TotalElements.ToString())}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size.ToString())}");
            toStringOutput.Add($"this.Content = {(this.Content == null ? "null" : $"[{string.Join(", ", this.Content)} ]")}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number.ToString())}");
            toStringOutput.Add($"this.Sort = {(this.Sort == null ? "null" : this.Sort.ToString())}");
            toStringOutput.Add($"this.NumberOfElements = {(this.NumberOfElements == null ? "null" : this.NumberOfElements.ToString())}");
            toStringOutput.Add($"this.Pageable = {(this.Pageable == null ? "null" : this.Pageable.ToString())}");
            toStringOutput.Add($"this.First = {(this.First == null ? "null" : this.First.ToString())}");
            toStringOutput.Add($"this.Last = {(this.Last == null ? "null" : this.Last.ToString())}");
            toStringOutput.Add($"this.Empty = {(this.Empty == null ? "null" : this.Empty.ToString())}");
        }
    }
}