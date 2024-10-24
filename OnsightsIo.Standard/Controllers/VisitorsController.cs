// <copyright file="VisitorsController.cs" company="APIMatic">
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
    /// VisitorsController.
    /// </summary>
    public class VisitorsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorsController"/> class.
        /// </summary>
        internal VisitorsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Visitors_visitorsByEntrance EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.VisitorsByEntranceStoreResponse response from the API call.</returns>
        public Models.VisitorsByEntranceStoreResponse VisitorsVisitorsByEntrance(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(VisitorsVisitorsByEntranceAsync(startDate, endDate, facilityId, includeAbsoluteValues));

        /// <summary>
        /// Visitors_visitorsByEntrance EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VisitorsByEntranceStoreResponse response from the API call.</returns>
        public async Task<Models.VisitorsByEntranceStoreResponse> VisitorsVisitorsByEntranceAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VisitorsByEntranceStoreResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/visitors/visitors-by-entrance")
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
        /// Visitors_totalSummedAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.VisitorTotalSumResponse response from the API call.</returns>
        public Models.VisitorTotalSumResponse VisitorsTotalSummedAll(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(VisitorsTotalSummedAllAsync(startDate, endDate, facilityId, includeAbsoluteValues));

        /// <summary>
        /// Visitors_totalSummedAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VisitorTotalSumResponse response from the API call.</returns>
        public async Task<Models.VisitorTotalSumResponse> VisitorsTotalSummedAllAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VisitorTotalSumResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/visitors/total/sum")
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
        /// Visitors_totalHourlyAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.VisitorHourlyTotalResponse response from the API call.</returns>
        public Models.VisitorHourlyTotalResponse VisitorsTotalHourlyAll(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                Guid? regionId = null,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(VisitorsTotalHourlyAllAsync(startDate, endDate, facilityId, regionId, includeAbsoluteValues));

        /// <summary>
        /// Visitors_totalHourlyAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VisitorHourlyTotalResponse response from the API call.</returns>
        public async Task<Models.VisitorHourlyTotalResponse> VisitorsTotalHourlyAllAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                Guid? regionId = null,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VisitorHourlyTotalResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/visitors/total/hourly")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("regionId", regionId))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// analyticsapiVisitors_totalHourlyAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.VisitorHourlyTotalResponse response from the API call.</returns>
        public Models.VisitorHourlyTotalResponse AnalyticsapiVisitorsTotalHourlyAll(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                Guid? regionId = null,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(AnalyticsapiVisitorsTotalHourlyAllAsync(startDate, endDate, facilityId, regionId, includeAbsoluteValues));

        /// <summary>
        /// analyticsapiVisitors_totalHourlyAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VisitorHourlyTotalResponse response from the API call.</returns>
        public async Task<Models.VisitorHourlyTotalResponse> AnalyticsapiVisitorsTotalHourlyAllAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                Guid? regionId = null,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VisitorHourlyTotalResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/visitors/total")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("regionId", regionId))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Visitors_totalDailyAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.VisitorDailyTotalResponse response from the API call.</returns>
        public Models.VisitorDailyTotalResponse VisitorsTotalDailyAll(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                Guid? regionId = null,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(VisitorsTotalDailyAllAsync(startDate, endDate, facilityId, regionId, includeAbsoluteValues));

        /// <summary>
        /// Visitors_totalDailyAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VisitorDailyTotalResponse response from the API call.</returns>
        public async Task<Models.VisitorDailyTotalResponse> VisitorsTotalDailyAllAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                Guid? regionId = null,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VisitorDailyTotalResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/visitors/total/daily")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("regionId", regionId))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Visitors_destinationStores EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.VisitorDestinationStoreResponse response from the API call.</returns>
        public Models.VisitorDestinationStoreResponse VisitorsDestinationStores(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId)
            => CoreHelper.RunTask(VisitorsDestinationStoresAsync(startDate, endDate, facilityId));

        /// <summary>
        /// Visitors_destinationStores EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VisitorDestinationStoreResponse response from the API call.</returns>
        public async Task<Models.VisitorDestinationStoreResponse> VisitorsDestinationStoresAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VisitorDestinationStoreResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/visitors/destination")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Visitors_crossShop EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RedirectView response from the API call.</returns>
        public Models.RedirectView VisitorsCrossShop(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId)
            => CoreHelper.RunTask(VisitorsCrossShopAsync(startDate, endDate, facilityId));

        /// <summary>
        /// Visitors_crossShop EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RedirectView response from the API call.</returns>
        public async Task<Models.RedirectView> VisitorsCrossShopAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RedirectView>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/visitors/cross-shop")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Visitors_conversionsDailyAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.VisitorDailyConversionsResponse response from the API call.</returns>
        public Models.VisitorDailyConversionsResponse VisitorsConversionsDailyAll(
                DateTime startDate,
                DateTime endDate,
                Guid regionId,
                Guid facilityId,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(VisitorsConversionsDailyAllAsync(startDate, endDate, regionId, facilityId, includeAbsoluteValues));

        /// <summary>
        /// Visitors_conversionsDailyAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VisitorDailyConversionsResponse response from the API call.</returns>
        public async Task<Models.VisitorDailyConversionsResponse> VisitorsConversionsDailyAllAsync(
                DateTime startDate,
                DateTime endDate,
                Guid regionId,
                Guid facilityId,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VisitorDailyConversionsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/visitors/conversions")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("regionId", regionId))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}