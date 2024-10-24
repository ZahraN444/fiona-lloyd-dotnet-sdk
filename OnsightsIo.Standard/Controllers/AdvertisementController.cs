// <copyright file="AdvertisementController.cs" company="APIMatic">
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
    /// AdvertisementController.
    /// </summary>
    public class AdvertisementController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertisementController"/> class.
        /// </summary>
        internal AdvertisementController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Advertisement_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AdvertisementResponse response from the API call.</returns>
        public Models.AdvertisementResponse AdvertisementGet(
                Guid id)
            => CoreHelper.RunTask(AdvertisementGetAsync(id));

        /// <summary>
        /// Advertisement_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AdvertisementResponse response from the API call.</returns>
        public async Task<Models.AdvertisementResponse> AdvertisementGetAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AdvertisementResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/advertisements/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Advertisement_update EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid AdvertisementUpdate(
                Guid id,
                Models.AdvertisementRequest body)
            => CoreHelper.RunTask(AdvertisementUpdateAsync(id, body));

        /// <summary>
        /// Advertisement_update EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> AdvertisementUpdateAsync(
                Guid id,
                Models.AdvertisementRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/managementapi/advertisements/{id}")
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
        /// Advertisement_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        public void AdvertisementDelete(
                Guid id)
            => CoreHelper.RunVoidTask(AdvertisementDeleteAsync(id));

        /// <summary>
        /// Advertisement_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task AdvertisementDeleteAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/managementapi/advertisements/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Advertisement_getAll EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PageAdvertisementResponse response from the API call.</returns>
        public Models.PageAdvertisementResponse AdvertisementGetAll(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                Guid? facilityId = null)
            => CoreHelper.RunTask(AdvertisementGetAllAsync(page, size, sort, facilityId));

        /// <summary>
        /// Advertisement_getAll EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PageAdvertisementResponse response from the API call.</returns>
        public async Task<Models.PageAdvertisementResponse> AdvertisementGetAllAsync(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                Guid? facilityId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PageAdvertisementResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/advertisements")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 0))
                      .Query(_query => _query.Setup("size", size ?? 20))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("facilityId", facilityId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Advertisement_create EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid AdvertisementCreate(
                Models.AdvertisementRequest body)
            => CoreHelper.RunTask(AdvertisementCreateAsync(body));

        /// <summary>
        /// Advertisement_create EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> AdvertisementCreateAsync(
                Models.AdvertisementRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managementapi/advertisements")
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
        /// Advertisement_getAllCampaignAdvertisements EndPoint.
        /// </summary>
        /// <param name="campaignId">Required parameter: Example: .</param>
        /// <param name="startDay">Required parameter: Example: .</param>
        /// <param name="endDay">Required parameter: Example: .</param>
        /// <returns>Returns the List of Models.AdvertisementResponse response from the API call.</returns>
        public List<Models.AdvertisementResponse> AdvertisementGetAllCampaignAdvertisements(
                Guid campaignId,
                DateTime startDay,
                DateTime endDay)
            => CoreHelper.RunTask(AdvertisementGetAllCampaignAdvertisementsAsync(campaignId, startDay, endDay));

        /// <summary>
        /// Advertisement_getAllCampaignAdvertisements EndPoint.
        /// </summary>
        /// <param name="campaignId">Required parameter: Example: .</param>
        /// <param name="startDay">Required parameter: Example: .</param>
        /// <param name="endDay">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.AdvertisementResponse response from the API call.</returns>
        public async Task<List<Models.AdvertisementResponse>> AdvertisementGetAllCampaignAdvertisementsAsync(
                Guid campaignId,
                DateTime startDay,
                DateTime endDay,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.AdvertisementResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/advertisements/campaigns/{campaignId}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("campaignId", campaignId))
                      .Query(_query => _query.Setup("startDay", startDay.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDay", endDay.ToString("yyyy'-'MM'-'dd")))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}