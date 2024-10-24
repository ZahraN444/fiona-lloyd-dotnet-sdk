// <copyright file="CampaignController.cs" company="APIMatic">
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
    /// CampaignController.
    /// </summary>
    public class CampaignController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignController"/> class.
        /// </summary>
        internal CampaignController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Campaign_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CampaignResponse response from the API call.</returns>
        public Models.CampaignResponse CampaignGet(
                Guid id)
            => CoreHelper.RunTask(CampaignGetAsync(id));

        /// <summary>
        /// Campaign_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CampaignResponse response from the API call.</returns>
        public async Task<Models.CampaignResponse> CampaignGetAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CampaignResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/campaigns/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Campaign_update EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid CampaignUpdate(
                Guid id,
                Models.CampaignRequest body)
            => CoreHelper.RunTask(CampaignUpdateAsync(id, body));

        /// <summary>
        /// Campaign_update EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> CampaignUpdateAsync(
                Guid id,
                Models.CampaignRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/managementapi/campaigns/{id}")
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
        /// Campaign_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        public void CampaignDelete(
                Guid id)
            => CoreHelper.RunVoidTask(CampaignDeleteAsync(id));

        /// <summary>
        /// Campaign_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CampaignDeleteAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/managementapi/campaigns/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Campaign_getAll EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PageCampaignResponse response from the API call.</returns>
        public Models.PageCampaignResponse CampaignGetAll(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                Guid? facilityId = null)
            => CoreHelper.RunTask(CampaignGetAllAsync(page, size, sort, facilityId));

        /// <summary>
        /// Campaign_getAll EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PageCampaignResponse response from the API call.</returns>
        public async Task<Models.PageCampaignResponse> CampaignGetAllAsync(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                Guid? facilityId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PageCampaignResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/campaigns")
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
        /// Campaign_create EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid CampaignCreate(
                Models.CampaignRequest body)
            => CoreHelper.RunTask(CampaignCreateAsync(body));

        /// <summary>
        /// Campaign_create EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> CampaignCreateAsync(
                Models.CampaignRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managementapi/campaigns")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .Deserializer(_response => Guid.Parse(_response)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}