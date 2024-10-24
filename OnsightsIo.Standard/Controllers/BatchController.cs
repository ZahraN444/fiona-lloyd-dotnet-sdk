// <copyright file="BatchController.cs" company="APIMatic">
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
    /// BatchController.
    /// </summary>
    public class BatchController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchController"/> class.
        /// </summary>
        internal BatchController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Batch_searchBatches EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="videoStartFrom">Optional parameter: Example: .</param>
        /// <param name="videoStartTo">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PageBatchListItemDto response from the API call.</returns>
        public Models.PageBatchListItemDto BatchSearchBatches(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                Guid? facilityId = null,
                DateTime? videoStartFrom = null,
                DateTime? videoStartTo = null)
            => CoreHelper.RunTask(BatchSearchBatchesAsync(page, size, sort, facilityId, videoStartFrom, videoStartTo));

        /// <summary>
        /// Batch_searchBatches EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="videoStartFrom">Optional parameter: Example: .</param>
        /// <param name="videoStartTo">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PageBatchListItemDto response from the API call.</returns>
        public async Task<Models.PageBatchListItemDto> BatchSearchBatchesAsync(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                Guid? facilityId = null,
                DateTime? videoStartFrom = null,
                DateTime? videoStartTo = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PageBatchListItemDto>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/videometadata/batches")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 0))
                      .Query(_query => _query.Setup("size", size ?? 20))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("videoStartFrom", videoStartFrom.HasValue ? videoStartFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("videoStartTo", videoStartTo.HasValue ? videoStartTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Batch_createBatch EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid BatchCreateBatch(
                Models.BatchCreateRequest body)
            => CoreHelper.RunTask(BatchCreateBatchAsync(body));

        /// <summary>
        /// Batch_createBatch EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> BatchCreateBatchAsync(
                Models.BatchCreateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/videometadata/batches")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .Deserializer(_response => Guid.Parse(_response)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Batch_getBatch EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.BatchDto response from the API call.</returns>
        public Models.BatchDto BatchGetBatch(
                Guid id)
            => CoreHelper.RunTask(BatchGetBatchAsync(id));

        /// <summary>
        /// Batch_getBatch EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BatchDto response from the API call.</returns>
        public async Task<Models.BatchDto> BatchGetBatchAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BatchDto>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/videometadata/batches/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}