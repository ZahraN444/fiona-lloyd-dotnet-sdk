// <copyright file="CalendarEventsController.cs" company="APIMatic">
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
    /// CalendarEventsController.
    /// </summary>
    public class CalendarEventsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarEventsController"/> class.
        /// </summary>
        internal CalendarEventsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// CalendarEvents_getSingleEvent EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CalendarEventResponse response from the API call.</returns>
        public Models.CalendarEventResponse CalendarEventsGetSingleEvent(
                Guid id)
            => CoreHelper.RunTask(CalendarEventsGetSingleEventAsync(id));

        /// <summary>
        /// CalendarEvents_getSingleEvent EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CalendarEventResponse response from the API call.</returns>
        public async Task<Models.CalendarEventResponse> CalendarEventsGetSingleEventAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CalendarEventResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/events/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CalendarEvents_updateEvent EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public Guid CalendarEventsUpdateEvent(
                Guid id,
                Models.CalendarEventUpdateRequest body)
            => CoreHelper.RunTask(CalendarEventsUpdateEventAsync(id, body));

        /// <summary>
        /// CalendarEvents_updateEvent EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Guid response from the API call.</returns>
        public async Task<Guid> CalendarEventsUpdateEventAsync(
                Guid id,
                Models.CalendarEventUpdateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Guid>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/managementapi/events/{id}")
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
        /// CalendarEvents_getEvents EndPoint.
        /// </summary>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="floorId">Optional parameter: Example: .</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="startDate">Optional parameter: Example: .</param>
        /// <param name="endDate">Optional parameter: Example: .</param>
        /// <param name="showHiddenEvents">Optional parameter: Example: .</param>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <returns>Returns the Models.PageCalendarEventResponse response from the API call.</returns>
        public Models.PageCalendarEventResponse CalendarEventsGetEvents(
                Guid? regionId = null,
                Guid? floorId = null,
                Guid? facilityId = null,
                DateTime? startDate = null,
                DateTime? endDate = null,
                bool? showHiddenEvents = null,
                int? page = 0,
                int? size = 20,
                List<string> sort = null)
            => CoreHelper.RunTask(CalendarEventsGetEventsAsync(regionId, floorId, facilityId, startDate, endDate, showHiddenEvents, page, size, sort));

        /// <summary>
        /// CalendarEvents_getEvents EndPoint.
        /// </summary>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="floorId">Optional parameter: Example: .</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="startDate">Optional parameter: Example: .</param>
        /// <param name="endDate">Optional parameter: Example: .</param>
        /// <param name="showHiddenEvents">Optional parameter: Example: .</param>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PageCalendarEventResponse response from the API call.</returns>
        public async Task<Models.PageCalendarEventResponse> CalendarEventsGetEventsAsync(
                Guid? regionId = null,
                Guid? floorId = null,
                Guid? facilityId = null,
                DateTime? startDate = null,
                DateTime? endDate = null,
                bool? showHiddenEvents = null,
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PageCalendarEventResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/events")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("regionId", regionId))
                      .Query(_query => _query.Setup("floorId", floorId))
                      .Query(_query => _query.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("startDate", startDate.HasValue ? startDate.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("endDate", endDate.HasValue ? endDate.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("showHiddenEvents", showHiddenEvents))
                      .Query(_query => _query.Setup("page", page ?? 0))
                      .Query(_query => _query.Setup("size", size ?? 20))
                      .Query(_query => _query.Setup("sort", sort))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CalendarEvents_createEvent EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CalendarEventResponse response from the API call.</returns>
        public Models.CalendarEventResponse CalendarEventsCreateEvent(
                Models.CalendarEventCreateRequest body)
            => CoreHelper.RunTask(CalendarEventsCreateEventAsync(body));

        /// <summary>
        /// CalendarEvents_createEvent EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CalendarEventResponse response from the API call.</returns>
        public async Task<Models.CalendarEventResponse> CalendarEventsCreateEventAsync(
                Models.CalendarEventCreateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CalendarEventResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managementapi/events")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CalendarEvents_getOccurrences EndPoint.
        /// </summary>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="floorId">Optional parameter: Example: .</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="startDate">Optional parameter: Example: .</param>
        /// <param name="endDate">Optional parameter: Example: .</param>
        /// <param name="showHiddenEvents">Optional parameter: Example: .</param>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <returns>Returns the Models.PageCalendarEventOccurrenceResponse response from the API call.</returns>
        public Models.PageCalendarEventOccurrenceResponse CalendarEventsGetOccurrences(
                Guid? regionId = null,
                Guid? floorId = null,
                Guid? facilityId = null,
                DateTime? startDate = null,
                DateTime? endDate = null,
                bool? showHiddenEvents = null,
                int? page = 0,
                int? size = 20,
                List<string> sort = null)
            => CoreHelper.RunTask(CalendarEventsGetOccurrencesAsync(regionId, floorId, facilityId, startDate, endDate, showHiddenEvents, page, size, sort));

        /// <summary>
        /// CalendarEvents_getOccurrences EndPoint.
        /// </summary>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="floorId">Optional parameter: Example: .</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="startDate">Optional parameter: Example: .</param>
        /// <param name="endDate">Optional parameter: Example: .</param>
        /// <param name="showHiddenEvents">Optional parameter: Example: .</param>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PageCalendarEventOccurrenceResponse response from the API call.</returns>
        public async Task<Models.PageCalendarEventOccurrenceResponse> CalendarEventsGetOccurrencesAsync(
                Guid? regionId = null,
                Guid? floorId = null,
                Guid? facilityId = null,
                DateTime? startDate = null,
                DateTime? endDate = null,
                bool? showHiddenEvents = null,
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PageCalendarEventOccurrenceResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/events/occurrences")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("regionId", regionId))
                      .Query(_query => _query.Setup("floorId", floorId))
                      .Query(_query => _query.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("startDate", startDate.HasValue ? startDate.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("endDate", endDate.HasValue ? endDate.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("showHiddenEvents", showHiddenEvents))
                      .Query(_query => _query.Setup("page", page ?? 0))
                      .Query(_query => _query.Setup("size", size ?? 20))
                      .Query(_query => _query.Setup("sort", sort))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}