// <copyright file="RegionFeatureController.cs" company="APIMatic">
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
    /// RegionFeatureController.
    /// </summary>
    public class RegionFeatureController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionFeatureController"/> class.
        /// </summary>
        internal RegionFeatureController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// RegionFeature_update EndPoint.
        /// </summary>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid RegionFeatureUpdate(
                Guid regionId,
                Guid id,
                Models.RegionFeatureRequest body)
            => CoreHelper.RunTask(RegionFeatureUpdateAsync(regionId, id, body));

        /// <summary>
        /// RegionFeature_update EndPoint.
        /// </summary>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> RegionFeatureUpdateAsync(
                Guid regionId,
                Guid id,
                Models.RegionFeatureRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/managementapi/regions/{regionId}/region-feature/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("regionId", regionId))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .Deserializer(_response => Guid.Parse(_response)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// RegionFeature_getAll EndPoint.
        /// </summary>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="category">Optional parameter: Example: .</param>
        /// <returns>Returns the List of Models.RegionFeatureResponse response from the API call.</returns>
        public List<Models.RegionFeatureResponse> RegionFeatureGetAll(
                Guid regionId,
                List<string> sort = null,
                Models.Category5Enum? category = null)
            => CoreHelper.RunTask(RegionFeatureGetAllAsync(regionId, sort, category));

        /// <summary>
        /// RegionFeature_getAll EndPoint.
        /// </summary>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="category">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.RegionFeatureResponse response from the API call.</returns>
        public async Task<List<Models.RegionFeatureResponse>> RegionFeatureGetAllAsync(
                Guid regionId,
                List<string> sort = null,
                Models.Category5Enum? category = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.RegionFeatureResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/regions/{regionId}/region-feature")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("regionId", regionId))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("category", (category.HasValue) ? ApiHelper.JsonSerialize(category.Value).Trim('\"') : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// RegionFeature_create EndPoint.
        /// </summary>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid RegionFeatureCreate(
                Guid regionId,
                Models.RegionFeatureRequest body)
            => CoreHelper.RunTask(RegionFeatureCreateAsync(regionId, body));

        /// <summary>
        /// RegionFeature_create EndPoint.
        /// </summary>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> RegionFeatureCreateAsync(
                Guid regionId,
                Models.RegionFeatureRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managementapi/regions/{regionId}/region-feature")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("regionId", regionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .Deserializer(_response => Guid.Parse(_response)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// RegionFeature_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RegionFeatureResponse response from the API call.</returns>
        public Models.RegionFeatureResponse RegionFeatureGet(
                Guid id)
            => CoreHelper.RunTask(RegionFeatureGetAsync(id));

        /// <summary>
        /// RegionFeature_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RegionFeatureResponse response from the API call.</returns>
        public async Task<Models.RegionFeatureResponse> RegionFeatureGetAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RegionFeatureResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/region-feature/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// RegionFeature_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RegionFeature response from the API call.</returns>
        public Models.RegionFeature RegionFeatureDelete(
                Guid id)
            => CoreHelper.RunTask(RegionFeatureDeleteAsync(id));

        /// <summary>
        /// RegionFeature_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RegionFeature response from the API call.</returns>
        public async Task<Models.RegionFeature> RegionFeatureDeleteAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RegionFeature>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/managementapi/region-feature/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}