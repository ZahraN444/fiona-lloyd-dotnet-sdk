// <copyright file="NaicsCodeController.cs" company="APIMatic">
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
    /// NaicsCodeController.
    /// </summary>
    public class NaicsCodeController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NaicsCodeController"/> class.
        /// </summary>
        internal NaicsCodeController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// NaicsCode_search EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <returns>Returns the Models.PageNaicsCodeResponse response from the API call.</returns>
        public Models.PageNaicsCodeResponse NaicsCodeSearch(
                int? page = 0,
                int? size = 20,
                List<string> sort = null)
            => CoreHelper.RunTask(NaicsCodeSearchAsync(page, size, sort));

        /// <summary>
        /// NaicsCode_search EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PageNaicsCodeResponse response from the API call.</returns>
        public async Task<Models.PageNaicsCodeResponse> NaicsCodeSearchAsync(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PageNaicsCodeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/naics-codes")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 0))
                      .Query(_query => _query.Setup("size", size ?? 20))
                      .Query(_query => _query.Setup("sort", sort))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// NaicsCode_getByCode EndPoint.
        /// </summary>
        /// <param name="code">Required parameter: Example: .</param>
        /// <returns>Returns the Models.NaicsCode response from the API call.</returns>
        public Models.NaicsCode NaicsCodeGetByCode(
                string code)
            => CoreHelper.RunTask(NaicsCodeGetByCodeAsync(code));

        /// <summary>
        /// NaicsCode_getByCode EndPoint.
        /// </summary>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.NaicsCode response from the API call.</returns>
        public async Task<Models.NaicsCode> NaicsCodeGetByCodeAsync(
                string code,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NaicsCode>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/naics-codes/{code}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("code", code))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}