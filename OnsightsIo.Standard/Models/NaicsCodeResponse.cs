// <copyright file="NaicsCodeResponse.cs" company="APIMatic">
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
    /// NaicsCodeResponse.
    /// </summary>
    public class NaicsCodeResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NaicsCodeResponse"/> class.
        /// </summary>
        public NaicsCodeResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NaicsCodeResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="title">title.</param>
        /// <param name="parentId">parentId.</param>
        public NaicsCodeResponse(
            Guid? id = null,
            string code = null,
            string title = null,
            Guid? parentId = null)
        {
            this.Id = id;
            this.Code = code;
            this.Title = title;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets ParentId.
        /// </summary>
        [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ParentId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NaicsCodeResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is NaicsCodeResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.ParentId == null && other.ParentId == null) || (this.ParentId?.Equals(other.ParentId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.ParentId = {(this.ParentId == null ? "null" : this.ParentId.ToString())}");
        }
    }
}