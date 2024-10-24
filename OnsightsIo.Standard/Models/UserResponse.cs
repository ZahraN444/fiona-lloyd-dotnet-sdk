// <copyright file="UserResponse.cs" company="APIMatic">
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
    /// UserResponse.
    /// </summary>
    public class UserResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse"/> class.
        /// </summary>
        public UserResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="isBlocked">isBlocked.</param>
        /// <param name="isAPerson">isAPerson.</param>
        /// <param name="createdTimestamp">createdTimestamp.</param>
        /// <param name="givenName">givenName.</param>
        /// <param name="familyName">familyName.</param>
        /// <param name="email">email.</param>
        /// <param name="picture">picture.</param>
        /// <param name="description">description.</param>
        public UserResponse(
            string id,
            string name,
            bool isBlocked,
            bool isAPerson,
            DateTime? createdTimestamp = null,
            string givenName = null,
            string familyName = null,
            string email = null,
            string picture = null,
            string description = null)
        {
            this.Id = id;
            this.CreatedTimestamp = createdTimestamp;
            this.Name = name;
            this.IsBlocked = isBlocked;
            this.GivenName = givenName;
            this.FamilyName = familyName;
            this.Email = email;
            this.Picture = picture;
            this.Description = description;
            this.IsAPerson = isAPerson;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets CreatedTimestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets IsBlocked.
        /// </summary>
        [JsonProperty("isBlocked")]
        public bool IsBlocked { get; set; }

        /// <summary>
        /// Gets or sets GivenName.
        /// </summary>
        [JsonProperty("givenName", NullValueHandling = NullValueHandling.Ignore)]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets FamilyName.
        /// </summary>
        [JsonProperty("familyName", NullValueHandling = NullValueHandling.Ignore)]
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Picture.
        /// </summary>
        [JsonProperty("picture", NullValueHandling = NullValueHandling.Ignore)]
        public string Picture { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets IsAPerson.
        /// </summary>
        [JsonProperty("isAPerson")]
        public bool IsAPerson { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UserResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is UserResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CreatedTimestamp == null && other.CreatedTimestamp == null) || (this.CreatedTimestamp?.Equals(other.CreatedTimestamp) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.IsBlocked.Equals(other.IsBlocked) &&
                ((this.GivenName == null && other.GivenName == null) || (this.GivenName?.Equals(other.GivenName) == true)) &&
                ((this.FamilyName == null && other.FamilyName == null) || (this.FamilyName?.Equals(other.FamilyName) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Picture == null && other.Picture == null) || (this.Picture?.Equals(other.Picture) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.IsAPerson.Equals(other.IsAPerson);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.CreatedTimestamp = {(this.CreatedTimestamp == null ? "null" : this.CreatedTimestamp.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.IsBlocked = {this.IsBlocked}");
            toStringOutput.Add($"this.GivenName = {(this.GivenName == null ? "null" : this.GivenName)}");
            toStringOutput.Add($"this.FamilyName = {(this.FamilyName == null ? "null" : this.FamilyName)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Picture = {(this.Picture == null ? "null" : this.Picture)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.IsAPerson = {this.IsAPerson}");
        }
    }
}