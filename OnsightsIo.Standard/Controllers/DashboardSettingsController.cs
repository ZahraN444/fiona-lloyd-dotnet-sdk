// <copyright file="DashboardSettingsController.cs" company="APIMatic">
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
    /// DashboardSettingsController.
    /// </summary>
    public class DashboardSettingsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardSettingsController"/> class.
        /// </summary>
        internal DashboardSettingsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// DashboardSettings_get EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="dashboardId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.DashboardSettingsResponse response from the API call.</returns>
        public Models.DashboardSettingsResponse DashboardSettingsGet(
                Guid facilityId,
                string dashboardId)
            => CoreHelper.RunTask(DashboardSettingsGetAsync(facilityId, dashboardId));

        /// <summary>
        /// DashboardSettings_get EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="dashboardId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DashboardSettingsResponse response from the API call.</returns>
        public async Task<Models.DashboardSettingsResponse> DashboardSettingsGetAsync(
                Guid facilityId,
                string dashboardId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DashboardSettingsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/facility/{facilityId}/dashboard-settings/{dashboardId}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Template(_template => _template.Setup("dashboardId", dashboardId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// DashboardSettings_set EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="dashboardId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        public void DashboardSettingsSet(
                Guid facilityId,
                string dashboardId,
                Models.DashboardSettingsRequest body)
            => CoreHelper.RunVoidTask(DashboardSettingsSetAsync(facilityId, dashboardId, body));

        /// <summary>
        /// DashboardSettings_set EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="dashboardId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DashboardSettingsSetAsync(
                Guid facilityId,
                string dashboardId,
                Models.DashboardSettingsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/managementapi/facility/{facilityId}/dashboard-settings/{dashboardId}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Template(_template => _template.Setup("dashboardId", dashboardId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// DashboardSettings_delete EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="dashboardId">Required parameter: Example: .</param>
        public void DashboardSettingsDelete(
                Guid facilityId,
                string dashboardId)
            => CoreHelper.RunVoidTask(DashboardSettingsDeleteAsync(facilityId, dashboardId));

        /// <summary>
        /// DashboardSettings_delete EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="dashboardId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DashboardSettingsDeleteAsync(
                Guid facilityId,
                string dashboardId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/managementapi/facility/{facilityId}/dashboard-settings/{dashboardId}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Template(_template => _template.Setup("dashboardId", dashboardId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}