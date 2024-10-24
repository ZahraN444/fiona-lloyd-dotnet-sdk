// <copyright file="JourneysController.cs" company="APIMatic">
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
    /// JourneysController.
    /// </summary>
    public class JourneysController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneysController"/> class.
        /// </summary>
        internal JourneysController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Journeys_getSankeyJourneysAll EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.JourneySankeyResponse response from the API call.</returns>
        public Models.JourneySankeyResponse JourneysGetSankeyJourneysAll(
                Guid facilityId,
                Models.JourneysSankeyCriteria body,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(JourneysGetSankeyJourneysAllAsync(facilityId, body, includeAbsoluteValues));

        /// <summary>
        /// Journeys_getSankeyJourneysAll EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JourneySankeyResponse response from the API call.</returns>
        public async Task<Models.JourneySankeyResponse> JourneysGetSankeyJourneysAllAsync(
                Guid facilityId,
                Models.JourneysSankeyCriteria body,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JourneySankeyResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/analyticsapi/facility/{facilityId}/journeys/sankey")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Journeys_getTopDestinationsAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="depth">Optional parameter: Example: .</param>
        /// <param name="count">Optional parameter: Example: .</param>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="filterRegionsWithParents">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.TopDestinationsResponse response from the API call.</returns>
        public Models.TopDestinationsResponse JourneysGetTopDestinationsAll(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                int? depth = null,
                int? count = null,
                Guid? regionId = null,
                bool? includeAbsoluteValues = null,
                bool? filterRegionsWithParents = null)
            => CoreHelper.RunTask(JourneysGetTopDestinationsAllAsync(startDate, endDate, facilityId, depth, count, regionId, includeAbsoluteValues, filterRegionsWithParents));

        /// <summary>
        /// Journeys_getTopDestinationsAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="depth">Optional parameter: Example: .</param>
        /// <param name="count">Optional parameter: Example: .</param>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="filterRegionsWithParents">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TopDestinationsResponse response from the API call.</returns>
        public async Task<Models.TopDestinationsResponse> JourneysGetTopDestinationsAllAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                int? depth = null,
                int? count = null,
                Guid? regionId = null,
                bool? includeAbsoluteValues = null,
                bool? filterRegionsWithParents = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TopDestinationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/journeys/top-destinations")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("depth", depth))
                      .Query(_query => _query.Setup("count", count))
                      .Query(_query => _query.Setup("regionId", regionId))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))
                      .Query(_query => _query.Setup("filterRegionsWithParents", filterRegionsWithParents))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Journeys_getMissedCaptureAll EndPoint.
        /// </summary>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.MissedCaptureResponse response from the API call.</returns>
        public Models.MissedCaptureResponse JourneysGetMissedCaptureAll(
                Guid regionId,
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(JourneysGetMissedCaptureAllAsync(regionId, startDate, endDate, facilityId, includeAbsoluteValues));

        /// <summary>
        /// Journeys_getMissedCaptureAll EndPoint.
        /// </summary>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MissedCaptureResponse response from the API call.</returns>
        public async Task<Models.MissedCaptureResponse> JourneysGetMissedCaptureAllAsync(
                Guid regionId,
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MissedCaptureResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/journeys/missed-capture")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("regionId", regionId))
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Journeys_getDwellTimeAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="filterRegionsWithParents">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.DwellTimeResponse response from the API call.</returns>
        public Models.DwellTimeResponse JourneysGetDwellTimeAll(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                bool? includeAbsoluteValues = null,
                bool? filterRegionsWithParents = null)
            => CoreHelper.RunTask(JourneysGetDwellTimeAllAsync(startDate, endDate, facilityId, includeAbsoluteValues, filterRegionsWithParents));

        /// <summary>
        /// Journeys_getDwellTimeAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="filterRegionsWithParents">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DwellTimeResponse response from the API call.</returns>
        public async Task<Models.DwellTimeResponse> JourneysGetDwellTimeAllAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                bool? includeAbsoluteValues = null,
                bool? filterRegionsWithParents = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DwellTimeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/journeys/dwell-time")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))
                      .Query(_query => _query.Setup("filterRegionsWithParents", filterRegionsWithParents))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Journeys_getJourneyDurationAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.JourneyDurationResponse response from the API call.</returns>
        public Models.JourneyDurationResponse JourneysGetJourneyDurationAll(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(JourneysGetJourneyDurationAllAsync(startDate, endDate, facilityId, includeAbsoluteValues));

        /// <summary>
        /// Journeys_getJourneyDurationAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JourneyDurationResponse response from the API call.</returns>
        public async Task<Models.JourneyDurationResponse> JourneysGetJourneyDurationAllAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JourneyDurationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/journeys/duration")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Journeys_getAssociationRules EndPoint.
        /// </summary>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AssociationRulesResponse response from the API call.</returns>
        public Models.AssociationRulesResponse JourneysGetAssociationRules(
                Guid regionId,
                DateTime startDate,
                DateTime endDate,
                Guid facilityId)
            => CoreHelper.RunTask(JourneysGetAssociationRulesAsync(regionId, startDate, endDate, facilityId));

        /// <summary>
        /// Journeys_getAssociationRules EndPoint.
        /// </summary>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AssociationRulesResponse response from the API call.</returns>
        public async Task<Models.AssociationRulesResponse> JourneysGetAssociationRulesAsync(
                Guid regionId,
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AssociationRulesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/journeys/association-rules")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("regionId", regionId))
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}