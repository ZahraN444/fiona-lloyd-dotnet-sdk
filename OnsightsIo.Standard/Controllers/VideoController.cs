// <copyright file="VideoController.cs" company="APIMatic">
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
    /// VideoController.
    /// </summary>
    public class VideoController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoController"/> class.
        /// </summary>
        internal VideoController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Video_searchVideos EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="cameraId">Optional parameter: Example: .</param>
        /// <param name="batchId">Optional parameter: Example: .</param>
        /// <param name="videoStartFrom">Optional parameter: Example: .</param>
        /// <param name="videoStartTo">Optional parameter: Example: .</param>
        /// <param name="videoEndFrom">Optional parameter: Example: .</param>
        /// <param name="videoEndTo">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PageVideoMetadata response from the API call.</returns>
        public Models.PageVideoMetadata VideoSearchVideos(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                Guid? facilityId = null,
                string cameraId = null,
                Guid? batchId = null,
                DateTime? videoStartFrom = null,
                DateTime? videoStartTo = null,
                DateTime? videoEndFrom = null,
                DateTime? videoEndTo = null)
            => CoreHelper.RunTask(VideoSearchVideosAsync(page, size, sort, facilityId, cameraId, batchId, videoStartFrom, videoStartTo, videoEndFrom, videoEndTo));

        /// <summary>
        /// Video_searchVideos EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Zero-based page index (0..N).</param>
        /// <param name="size">Optional parameter: The size of the page to be returned.</param>
        /// <param name="sort">Optional parameter: Sorting criteria in the format: property,(asc|desc). Default sort order is ascending. Multiple sort criteria are supported..</param>
        /// <param name="facilityId">Optional parameter: Example: .</param>
        /// <param name="cameraId">Optional parameter: Example: .</param>
        /// <param name="batchId">Optional parameter: Example: .</param>
        /// <param name="videoStartFrom">Optional parameter: Example: .</param>
        /// <param name="videoStartTo">Optional parameter: Example: .</param>
        /// <param name="videoEndFrom">Optional parameter: Example: .</param>
        /// <param name="videoEndTo">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PageVideoMetadata response from the API call.</returns>
        public async Task<Models.PageVideoMetadata> VideoSearchVideosAsync(
                int? page = 0,
                int? size = 20,
                List<string> sort = null,
                Guid? facilityId = null,
                string cameraId = null,
                Guid? batchId = null,
                DateTime? videoStartFrom = null,
                DateTime? videoStartTo = null,
                DateTime? videoEndFrom = null,
                DateTime? videoEndTo = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PageVideoMetadata>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/videometadata/videos")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 0))
                      .Query(_query => _query.Setup("size", size ?? 20))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("cameraId", cameraId))
                      .Query(_query => _query.Setup("batchId", batchId))
                      .Query(_query => _query.Setup("videoStartFrom", videoStartFrom.HasValue ? videoStartFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("videoStartTo", videoStartTo.HasValue ? videoStartTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("videoEndFrom", videoEndFrom.HasValue ? videoEndFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("videoEndTo", videoEndTo.HasValue ? videoEndTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Video_getVideo EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.VideoMetadata response from the API call.</returns>
        public Models.VideoMetadata VideoGetVideo(
                string id)
            => CoreHelper.RunTask(VideoGetVideoAsync(id));

        /// <summary>
        /// Video_getVideo EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VideoMetadata response from the API call.</returns>
        public async Task<Models.VideoMetadata> VideoGetVideoAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VideoMetadata>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/videometadata/videos/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Video_getVideoStreamUrl EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.StorageAccessUrl response from the API call.</returns>
        public Models.StorageAccessUrl VideoGetVideoStreamUrl(
                string id)
            => CoreHelper.RunTask(VideoGetVideoStreamUrlAsync(id));

        /// <summary>
        /// Video_getVideoStreamUrl EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StorageAccessUrl response from the API call.</returns>
        public async Task<Models.StorageAccessUrl> VideoGetVideoStreamUrlAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.StorageAccessUrl>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/videometadata/videos/{id}/stream")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Video_getVideosForBatchByCamera EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="videoStartFrom">Required parameter: Example: .</param>
        /// <param name="videoStartTo">Required parameter: Example: .</param>
        /// <returns>Returns the List of Models.CameraVideoGroup response from the API call.</returns>
        public List<Models.CameraVideoGroup> VideoGetVideosForBatchByCamera(
                Guid facilityId,
                DateTime videoStartFrom,
                DateTime videoStartTo)
            => CoreHelper.RunTask(VideoGetVideosForBatchByCameraAsync(facilityId, videoStartFrom, videoStartTo));

        /// <summary>
        /// Video_getVideosForBatchByCamera EndPoint.
        /// </summary>
        /// <param name="facilityId">Required parameter: Example: .</param>
        /// <param name="videoStartFrom">Required parameter: Example: .</param>
        /// <param name="videoStartTo">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.CameraVideoGroup response from the API call.</returns>
        public async Task<List<Models.CameraVideoGroup>> VideoGetVideosForBatchByCameraAsync(
                Guid facilityId,
                DateTime videoStartFrom,
                DateTime videoStartTo,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CameraVideoGroup>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/videometadata/videos/for-batch-by-camera")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("facilityId", facilityId))
                      .Query(_query => _query.Setup("videoStartFrom", videoStartFrom.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK")))
                      .Query(_query => _query.Setup("videoStartTo", videoStartTo.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK")))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}