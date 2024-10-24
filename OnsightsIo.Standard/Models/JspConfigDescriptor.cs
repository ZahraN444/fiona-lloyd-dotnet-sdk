// <copyright file="JspConfigDescriptor.cs" company="APIMatic">
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
    /// JspConfigDescriptor.
    /// </summary>
    public class JspConfigDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JspConfigDescriptor"/> class.
        /// </summary>
        public JspConfigDescriptor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JspConfigDescriptor"/> class.
        /// </summary>
        /// <param name="taglibs">taglibs.</param>
        /// <param name="jspPropertyGroups">jspPropertyGroups.</param>
        public JspConfigDescriptor(
            List<Models.TaglibDescriptor> taglibs = null,
            List<Models.JspPropertyGroupDescriptor> jspPropertyGroups = null)
        {
            this.Taglibs = taglibs;
            this.JspPropertyGroups = jspPropertyGroups;
        }

        /// <summary>
        /// Gets or sets Taglibs.
        /// </summary>
        [JsonProperty("taglibs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TaglibDescriptor> Taglibs { get; set; }

        /// <summary>
        /// Gets or sets JspPropertyGroups.
        /// </summary>
        [JsonProperty("jspPropertyGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.JspPropertyGroupDescriptor> JspPropertyGroups { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JspConfigDescriptor : ({string.Join(", ", toStringOutput)})";
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
            return obj is JspConfigDescriptor other &&                ((this.Taglibs == null && other.Taglibs == null) || (this.Taglibs?.Equals(other.Taglibs) == true)) &&
                ((this.JspPropertyGroups == null && other.JspPropertyGroups == null) || (this.JspPropertyGroups?.Equals(other.JspPropertyGroups) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Taglibs = {(this.Taglibs == null ? "null" : $"[{string.Join(", ", this.Taglibs)} ]")}");
            toStringOutput.Add($"this.JspPropertyGroups = {(this.JspPropertyGroups == null ? "null" : $"[{string.Join(", ", this.JspPropertyGroups)} ]")}");
        }
    }
}