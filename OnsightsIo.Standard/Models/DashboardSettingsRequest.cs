// <copyright file="DashboardSettingsRequest.cs" company="APIMatic">
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
    /// DashboardSettingsRequest.
    /// </summary>
    public class DashboardSettingsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardSettingsRequest"/> class.
        /// </summary>
        public DashboardSettingsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardSettingsRequest"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        public DashboardSettingsRequest(
            object mValue)
        {
            this.MValue = mValue;
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        public object MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DashboardSettingsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DashboardSettingsRequest other &&                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
        }
    }
}