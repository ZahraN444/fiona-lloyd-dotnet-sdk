// <copyright file="CampaignDetailsRequest.cs" company="APIMatic">
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
    /// CampaignDetailsRequest.
    /// </summary>
    public class CampaignDetailsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDetailsRequest"/> class.
        /// </summary>
        public CampaignDetailsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDetailsRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="advertisementId">advertisementId.</param>
        /// <param name="adSignage">adSignage.</param>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="shareOfVoice">shareOfVoice.</param>
        /// <param name="secondsOfRotation">secondsOfRotation.</param>
        /// <param name="secondsOfShare">secondsOfShare.</param>
        /// <param name="description">description.</param>
        public CampaignDetailsRequest(
            string name,
            Guid advertisementId,
            Guid adSignage,
            Guid campaignId,
            DateTime startDate,
            DateTime endDate,
            double shareOfVoice,
            int secondsOfRotation,
            int secondsOfShare,
            string description = null)
        {
            this.Name = name;
            this.Description = description;
            this.AdvertisementId = advertisementId;
            this.AdSignage = adSignage;
            this.CampaignId = campaignId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ShareOfVoice = shareOfVoice;
            this.SecondsOfRotation = secondsOfRotation;
            this.SecondsOfShare = secondsOfShare;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets AdvertisementId.
        /// </summary>
        [JsonProperty("advertisementId")]
        public Guid AdvertisementId { get; set; }

        /// <summary>
        /// Gets or sets AdSignage.
        /// </summary>
        [JsonProperty("adSignage")]
        public Guid AdSignage { get; set; }

        /// <summary>
        /// Gets or sets CampaignId.
        /// </summary>
        [JsonProperty("campaignId")]
        public Guid CampaignId { get; set; }

        /// <summary>
        /// Gets or sets StartDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets EndDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets ShareOfVoice.
        /// </summary>
        [JsonProperty("shareOfVoice")]
        public double ShareOfVoice { get; set; }

        /// <summary>
        /// Gets or sets SecondsOfRotation.
        /// </summary>
        [JsonProperty("secondsOfRotation")]
        public int SecondsOfRotation { get; set; }

        /// <summary>
        /// Gets or sets SecondsOfShare.
        /// </summary>
        [JsonProperty("secondsOfShare")]
        public int SecondsOfShare { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CampaignDetailsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CampaignDetailsRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.AdvertisementId.Equals(other.AdvertisementId) &&
                this.AdSignage.Equals(other.AdSignage) &&
                this.CampaignId.Equals(other.CampaignId) &&
                this.StartDate.Equals(other.StartDate) &&
                this.EndDate.Equals(other.EndDate) &&
                this.ShareOfVoice.Equals(other.ShareOfVoice) &&
                this.SecondsOfRotation.Equals(other.SecondsOfRotation) &&
                this.SecondsOfShare.Equals(other.SecondsOfShare);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.AdvertisementId = {this.AdvertisementId}");
            toStringOutput.Add($"this.AdSignage = {this.AdSignage}");
            toStringOutput.Add($"this.CampaignId = {this.CampaignId}");
            toStringOutput.Add($"this.StartDate = {this.StartDate}");
            toStringOutput.Add($"this.EndDate = {this.EndDate}");
            toStringOutput.Add($"this.ShareOfVoice = {this.ShareOfVoice}");
            toStringOutput.Add($"this.SecondsOfRotation = {this.SecondsOfRotation}");
            toStringOutput.Add($"this.SecondsOfShare = {this.SecondsOfShare}");
        }
    }
}