// <copyright file="HttpStatusCode.cs" company="APIMatic">
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
    /// HttpStatusCode.
    /// </summary>
    public class HttpStatusCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpStatusCode"/> class.
        /// </summary>
        public HttpStatusCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpStatusCode"/> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="is4xxClientError">is4xxClientError.</param>
        /// <param name="is5xxServerError">is5xxServerError.</param>
        /// <param name="is1xxInformational">is1xxInformational.</param>
        /// <param name="is2xxSuccessful">is2xxSuccessful.</param>
        /// <param name="is3xxRedirection">is3xxRedirection.</param>
        public HttpStatusCode(
            bool? error = null,
            bool? is4xxClientError = null,
            bool? is5xxServerError = null,
            bool? is1xxInformational = null,
            bool? is2xxSuccessful = null,
            bool? is3xxRedirection = null)
        {
            this.Error = error;
            this.Is4xxClientError = is4xxClientError;
            this.Is5xxServerError = is5xxServerError;
            this.Is1xxInformational = is1xxInformational;
            this.Is2xxSuccessful = is2xxSuccessful;
            this.Is3xxRedirection = is3xxRedirection;
        }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Error { get; set; }

        /// <summary>
        /// Gets or sets Is4xxClientError.
        /// </summary>
        [JsonProperty("is4xxClientError", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is4xxClientError { get; set; }

        /// <summary>
        /// Gets or sets Is5xxServerError.
        /// </summary>
        [JsonProperty("is5xxServerError", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is5xxServerError { get; set; }

        /// <summary>
        /// Gets or sets Is1xxInformational.
        /// </summary>
        [JsonProperty("is1xxInformational", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is1xxInformational { get; set; }

        /// <summary>
        /// Gets or sets Is2xxSuccessful.
        /// </summary>
        [JsonProperty("is2xxSuccessful", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is2xxSuccessful { get; set; }

        /// <summary>
        /// Gets or sets Is3xxRedirection.
        /// </summary>
        [JsonProperty("is3xxRedirection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is3xxRedirection { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HttpStatusCode : ({string.Join(", ", toStringOutput)})";
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
            return obj is HttpStatusCode other &&                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.Is4xxClientError == null && other.Is4xxClientError == null) || (this.Is4xxClientError?.Equals(other.Is4xxClientError) == true)) &&
                ((this.Is5xxServerError == null && other.Is5xxServerError == null) || (this.Is5xxServerError?.Equals(other.Is5xxServerError) == true)) &&
                ((this.Is1xxInformational == null && other.Is1xxInformational == null) || (this.Is1xxInformational?.Equals(other.Is1xxInformational) == true)) &&
                ((this.Is2xxSuccessful == null && other.Is2xxSuccessful == null) || (this.Is2xxSuccessful?.Equals(other.Is2xxSuccessful) == true)) &&
                ((this.Is3xxRedirection == null && other.Is3xxRedirection == null) || (this.Is3xxRedirection?.Equals(other.Is3xxRedirection) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.Is4xxClientError = {(this.Is4xxClientError == null ? "null" : this.Is4xxClientError.ToString())}");
            toStringOutput.Add($"this.Is5xxServerError = {(this.Is5xxServerError == null ? "null" : this.Is5xxServerError.ToString())}");
            toStringOutput.Add($"this.Is1xxInformational = {(this.Is1xxInformational == null ? "null" : this.Is1xxInformational.ToString())}");
            toStringOutput.Add($"this.Is2xxSuccessful = {(this.Is2xxSuccessful == null ? "null" : this.Is2xxSuccessful.ToString())}");
            toStringOutput.Add($"this.Is3xxRedirection = {(this.Is3xxRedirection == null ? "null" : this.Is3xxRedirection.ToString())}");
        }
    }
}