// <copyright file="ErrorMessageException.cs" company="APIMatic">
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
using OnsightsIo.Standard.Http.Client;
using OnsightsIo.Standard.Models;
using OnsightsIo.Standard.Utilities;

namespace OnsightsIo.Standard.Exceptions
{
    /// <summary>
    /// ErrorMessageException.
    /// </summary>
    public class ErrorMessageException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorMessageException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ErrorMessageException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public new string Message { get; set; }
    }
}