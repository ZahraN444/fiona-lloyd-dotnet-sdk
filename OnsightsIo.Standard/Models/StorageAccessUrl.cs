// <copyright file="StorageAccessUrl.cs" company="APIMatic">
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
    /// StorageAccessUrl.
    /// </summary>
    public class StorageAccessUrl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageAccessUrl"/> class.
        /// </summary>
        public StorageAccessUrl()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageAccessUrl"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="validForMinutes">validForMinutes.</param>
        public StorageAccessUrl(
            string url,
            int validForMinutes)
        {
            this.Url = url;
            this.ValidForMinutes = validForMinutes;
        }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets ValidForMinutes.
        /// </summary>
        [JsonProperty("validForMinutes")]
        public int ValidForMinutes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StorageAccessUrl : ({string.Join(", ", toStringOutput)})";
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
            return obj is StorageAccessUrl other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                this.ValidForMinutes.Equals(other.ValidForMinutes);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.ValidForMinutes = {this.ValidForMinutes}");
        }
    }
}