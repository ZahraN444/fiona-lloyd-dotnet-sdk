// <copyright file="RegionController.cs" company="APIMatic">
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
    /// RegionController.
    /// </summary>
    public class RegionController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionController"/> class.
        /// </summary>
        internal RegionController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Region_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RegionResponse response from the API call.</returns>
        public Models.RegionResponse RegionGet(
                Guid id)
            => CoreHelper.RunTask(RegionGetAsync(id));

        /// <summary>
        /// Region_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RegionResponse response from the API call.</returns>
        public async Task<Models.RegionResponse> RegionGetAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RegionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/regions/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Region_update EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid RegionUpdate(
                Guid id,
                Models.RegionRequest body)
            => CoreHelper.RunTask(RegionUpdateAsync(id, body));

        /// <summary>
        /// Region_update EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> RegionUpdateAsync(
                Guid id,
                Models.RegionRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/managementapi/regions/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .Deserializer(_response => Guid.Parse(_response)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Region_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        public void RegionDelete(
                Guid id)
            => CoreHelper.RunVoidTask(RegionDeleteAsync(id));

        /// <summary>
        /// Region_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task RegionDeleteAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/managementapi/regions/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Region_getAll EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="floorId">Optional parameter: Example: .</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="category">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PageRegionResponse response from the API call.</returns>
        public Models.PageRegionResponse RegionGetAll(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                Guid? floorId = null,
                Guid? facilityId = null,
                List<Models.CategoryEnum> category = null)
            => CoreHelper.RunTask(RegionGetAllAsync(page, size, sort, floorId, facilityId, category));

        /// <summary>
        /// Region_getAll EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="floorId">Optional parameter: Example: .</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="category">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PageRegionResponse response from the API call.</returns>
        public async Task<Models.PageRegionResponse> RegionGetAllAsync(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                Guid? floorId = null,
                Guid? facilityId = null,
                List<Models.CategoryEnum> category = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PageRegionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/regions")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 0))
                      .Query(_query => _query.Setup("size", size ?? 20))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("floorId", floorId))
                      .Query(_query => _query.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("category", category?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Region_create EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid RegionCreate(
                Models.RegionRequest body)
            => CoreHelper.RunTask(RegionCreateAsync(body));

        /// <summary>
        /// Region_create EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> RegionCreateAsync(
                Models.RegionRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managementapi/regions")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .Deserializer(_response => Guid.Parse(_response)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Region_searchByNaics EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="naicsPrefix">Required parameter: Example: .</param>
        /// <returns>Returns the List of Guid response from the API call.</returns>
        public List<Guid> RegionSearchByNaics(
                Guid facilityId,
                string naicsPrefix)
            => CoreHelper.RunTask(RegionSearchByNaicsAsync(facilityId, naicsPrefix));

        /// <summary>
        /// Region_searchByNaics EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="naicsPrefix">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Guid response from the API call.</returns>
        public async Task<List<Guid>> RegionSearchByNaicsAsync(
                Guid facilityId,
                string naicsPrefix,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Guid>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/regions/{facilityId}/by-naics")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("naicsPrefix", naicsPrefix))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Region_export EndPoint.
        /// </summary>
        /// <returns>Returns the List of Models.RegionExportItem response from the API call.</returns>
        public List<Models.RegionExportItem> RegionExport()
            => CoreHelper.RunTask(RegionExportAsync());

        /// <summary>
        /// Region_export EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.RegionExportItem response from the API call.</returns>
        public async Task<List<Models.RegionExportItem>> RegionExportAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.RegionExportItem>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/regions/export")
                  .WithAuth("openId"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}