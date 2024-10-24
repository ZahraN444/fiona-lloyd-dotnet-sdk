// <copyright file="OpportunityAreaHeatmapController.cs" company="APIMatic">
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
    /// OpportunityAreaHeatmapController.
    /// </summary>
    public class OpportunityAreaHeatmapController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunityAreaHeatmapController"/> class.
        /// </summary>
        internal OpportunityAreaHeatmapController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// OpportunityAreaHeatmap_getOpportunityAreaHeatmapAll EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOpportunityAreaHeatmapResponse response from the API call.</returns>
        public Models.GetOpportunityAreaHeatmapResponse OpportunityAreaHeatmapGetOpportunityAreaHeatmapAll(
                Guid facilityId,
                DateTime startDate,
                DateTime endDate,
                bool? includeAbsoluteValues = null)
            => CoreHelper.RunTask(OpportunityAreaHeatmapGetOpportunityAreaHeatmapAllAsync(facilityId, startDate, endDate, includeAbsoluteValues));

        /// <summary>
        /// OpportunityAreaHeatmap_getOpportunityAreaHeatmapAll EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="includeAbsoluteValues">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOpportunityAreaHeatmapResponse response from the API call.</returns>
        public async Task<Models.GetOpportunityAreaHeatmapResponse> OpportunityAreaHeatmapGetOpportunityAreaHeatmapAllAsync(
                Guid facilityId,
                DateTime startDate,
                DateTime endDate,
                bool? includeAbsoluteValues = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOpportunityAreaHeatmapResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/analyticsapi/facility/{facilityId}/opportunity-area-heatmap/")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("startDate", startDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("endDate", endDate.ToString("yyyy'-'MM'-'dd")))
                      .Query(_query => _query.Setup("includeAbsoluteValues", includeAbsoluteValues))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}