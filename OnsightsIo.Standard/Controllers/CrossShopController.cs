// <copyright file="CrossShopController.cs" company="APIMatic">
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
    /// CrossShopController.
    /// </summary>
    public class CrossShopController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossShopController"/> class.
        /// </summary>
        internal CrossShopController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// CrossShop_crossProductBreakdownAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="maxPairs">Optional parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CrossShopBreakdownResponse response from the API call.</returns>
        public Models.CrossShopBreakdownResponse CrossShopCrossProductBreakdownAll(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                Guid? regionId = null,
                int? maxPairs = null,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(CrossShopCrossProductBreakdownAllAsync(startDate, endDate, facilityId, regionId, maxPairs, includeAbsoluteValues));

        /// <summary>
        /// CrossShop_crossProductBreakdownAll EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="regionId">Optional parameter: Example: .</param>
        /// <param name="maxPairs">Optional parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CrossShopBreakdownResponse response from the API call.</returns>
        public async Task<Models.CrossShopBreakdownResponse> CrossShopCrossProductBreakdownAllAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                Guid? regionId = null,
                int? maxPairs = null,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CrossShopBreakdownResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/cross-shop/breakdown")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("regionId", regionId))
                      .Query(_query => _query.Setup("maxPairs", maxPairs))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CrossShop_avgCrossShopAfter EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AvgCrossShopAfterResponse response from the API call.</returns>
        public Models.AvgCrossShopAfterResponse CrossShopAvgCrossShopAfter(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId)
            => CoreHelper.RunTask(CrossShopAvgCrossShopAfterAsync(startDate, endDate, facilityId));

        /// <summary>
        /// CrossShop_avgCrossShopAfter EndPoint.
        /// </summary>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AvgCrossShopAfterResponse response from the API call.</returns>
        public async Task<Models.AvgCrossShopAfterResponse> CrossShopAvgCrossShopAfterAsync(
                DateTime startDate,
                DateTime endDate,
                Guid facilityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AvgCrossShopAfterResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/cross-shop/avg-after")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Template(_template => _template.Setup("facilityId", facilityId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}