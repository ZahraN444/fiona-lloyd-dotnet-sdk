// <copyright file="ImageController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using OnsightsIo.Standard;
using OnsightsIo.Standard.Exceptions;
using OnsightsIo.Standard.Http.Client;
using OnsightsIo.Standard.Utilities;
using System.Net.Http;

namespace OnsightsIo.Standard.Controllers
{
    /// <summary>
    /// ImageController.
    /// </summary>
    public class ImageController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageController"/> class.
        /// </summary>
        internal ImageController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Image_create EndPoint.
        /// </summary>
        /// <param name="title">Required parameter: Example: .</param>
        /// <param name="altText">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid ImageCreate(
                string title,
                string altText,
                FileStreamInfo image)
            => CoreHelper.RunTask(ImageCreateAsync(title, altText, image));

        /// <summary>
        /// Image_create EndPoint.
        /// </summary>
        /// <param name="title">Required parameter: Example: .</param>
        /// <param name="altText">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> ImageCreateAsync(
                string title,
                string altText,
                FileStreamInfo image,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managementapi/images")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("title", title))
                      .Form(_form => _form.Setup("altText", altText))
                      .Form(_form => _form.Setup("image", image))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .Deserializer(_response => Guid.Parse(_response)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Image_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic ImageGet(
                Guid id)
            => CoreHelper.RunTask(ImageGetAsync(id));

        /// <summary>
        /// Image_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> ImageGetAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<dynamic>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/images/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Image_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        public void ImageDelete(
                Guid id)
            => CoreHelper.RunVoidTask(ImageDeleteAsync(id));

        /// <summary>
        /// Image_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ImageDeleteAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/managementapi/images/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}