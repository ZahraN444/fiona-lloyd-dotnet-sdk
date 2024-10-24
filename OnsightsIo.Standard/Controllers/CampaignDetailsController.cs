// <copyright file="CampaignDetailsController.cs" company="APIMatic">
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
    /// CampaignDetailsController.
    /// </summary>
    public class CampaignDetailsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDetailsController"/> class.
        /// </summary>
        internal CampaignDetailsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// CampaignDetails_update EndPoint.
        /// </summary>
        /// <param name="campaignId">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid CampaignDetailsUpdate(
                Guid campaignId,
                Guid id,
                Models.CampaignDetailsRequest body)
            => CoreHelper.RunTask(CampaignDetailsUpdateAsync(campaignId, id, body));

        /// <summary>
        /// CampaignDetails_update EndPoint.
        /// </summary>
        /// <param name="campaignId">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> CampaignDetailsUpdateAsync(
                Guid campaignId,
                Guid id,
                Models.CampaignDetailsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/managementapi/campaigns/{campaignId}/campaign-details/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("campaignId", campaignId))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .Deserializer(_response => Guid.Parse(_response)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CampaignDetails_getAll EndPoint.
        /// </summary>
        /// <param name="campaignId">Required parameter: Example: .</param>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <returns>Returns the Models.PageCampaignDetailsResponse response from the API call.</returns>
        public Models.PageCampaignDetailsResponse CampaignDetailsGetAll(
                Guid campaignId,
                int? page = 0,
                int? size = 20,
                List<string> sort = null)
            => CoreHelper.RunTask(CampaignDetailsGetAllAsync(campaignId, page, size, sort));

        /// <summary>
        /// CampaignDetails_getAll EndPoint.
        /// </summary>
        /// <param name="campaignId">Required parameter: Example: .</param>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PageCampaignDetailsResponse response from the API call.</returns>
        public async Task<Models.PageCampaignDetailsResponse> CampaignDetailsGetAllAsync(
                Guid campaignId,
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PageCampaignDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/campaigns/{campaignId}/campaign-details")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("campaignId", campaignId))
                      .Query(_query => _query.Setup("page", page ?? 0))
                      .Query(_query => _query.Setup("size", size ?? 20))
                      .Query(_query => _query.Setup("sort", sort))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CampaignDetails_create EndPoint.
        /// </summary>
        /// <param name="campaignId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid CampaignDetailsCreate(
                Guid campaignId,
                Models.CampaignDetailsRequest body)
            => CoreHelper.RunTask(CampaignDetailsCreateAsync(campaignId, body));

        /// <summary>
        /// CampaignDetails_create EndPoint.
        /// </summary>
        /// <param name="campaignId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> CampaignDetailsCreateAsync(
                Guid campaignId,
                Models.CampaignDetailsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managementapi/campaigns/{campaignId}/campaign-details")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("campaignId", campaignId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .Deserializer(_response => Guid.Parse(_response)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CampaignDetails_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CampaignDetailsResponse response from the API call.</returns>
        public Models.CampaignDetailsResponse CampaignDetailsGet(
                Guid id)
            => CoreHelper.RunTask(CampaignDetailsGetAsync(id));

        /// <summary>
        /// CampaignDetails_get EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CampaignDetailsResponse response from the API call.</returns>
        public async Task<Models.CampaignDetailsResponse> CampaignDetailsGetAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CampaignDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/campaign-details/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CampaignDetails_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        public void CampaignDetailsDelete(
                Guid id)
            => CoreHelper.RunVoidTask(CampaignDetailsDeleteAsync(id));

        /// <summary>
        /// CampaignDetails_delete EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CampaignDetailsDeleteAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/managementapi/campaign-details/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}