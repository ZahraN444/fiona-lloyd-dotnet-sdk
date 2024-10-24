// <copyright file="JourneyLevelFilters.cs" company="APIMatic">
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
    /// JourneyLevelFilters.
    /// </summary>
    public class JourneyLevelFilters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyLevelFilters"/> class.
        /// </summary>
        public JourneyLevelFilters()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyLevelFilters"/> class.
        /// </summary>
        /// <param name="level">level.</param>
        /// <param name="idIn">idIn.</param>
        /// <param name="forceMoveIdsToOthers">forceMoveIdsToOthers.</param>
        public JourneyLevelFilters(
            int level,
            List<Guid> idIn = null,
            List<Guid> forceMoveIdsToOthers = null)
        {
            this.Level = level;
            this.IdIn = idIn;
            this.ForceMoveIdsToOthers = forceMoveIdsToOthers;
        }

        /// <summary>
        /// Gets or sets Level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets IdIn.
        /// </summary>
        [JsonProperty("idIn", NullValueHandling = NullValueHandling.Ignore)]
        public List<Guid> IdIn { get; set; }

        /// <summary>
        /// Gets or sets ForceMoveIdsToOthers.
        /// </summary>
        [JsonProperty("forceMoveIdsToOthers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Guid> ForceMoveIdsToOthers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JourneyLevelFilters : ({string.Join(", ", toStringOutput)})";
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
            return obj is JourneyLevelFilters other &&                this.Level.Equals(other.Level) &&
                ((this.IdIn == null && other.IdIn == null) || (this.IdIn?.Equals(other.IdIn) == true)) &&
                ((this.ForceMoveIdsToOthers == null && other.ForceMoveIdsToOthers == null) || (this.ForceMoveIdsToOthers?.Equals(other.ForceMoveIdsToOthers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Level = {this.Level}");
            toStringOutput.Add($"this.IdIn = {(this.IdIn == null ? "null" : $"[{string.Join(", ", this.IdIn)} ]")}");
            toStringOutput.Add($"this.ForceMoveIdsToOthers = {(this.ForceMoveIdsToOthers == null ? "null" : $"[{string.Join(", ", this.ForceMoveIdsToOthers)} ]")}");
        }
    }
}