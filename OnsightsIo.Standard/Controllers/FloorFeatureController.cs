// <copyright file="FloorFeatureController.cs" company="APIMatic">
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
    /// FloorFeatureController.
    /// </summary>
    public class FloorFeatureController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloorFeatureController"/> class.
        /// </summary>
        internal FloorFeatureController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// FloorFeature_uploadLidarAsset EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="worldFileContent">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        public void FloorFeatureUploadLidarAsset(
                Guid id,
                string worldFileContent,
                FileStreamInfo image)
            => CoreHelper.RunVoidTask(FloorFeatureUploadLidarAssetAsync(id, worldFileContent, image));

        /// <summary>
        /// FloorFeature_uploadLidarAsset EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="worldFileContent">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task FloorFeatureUploadLidarAssetAsync(
                Guid id,
                string worldFileContent,
                FileStreamInfo image,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managementapi/floor-features/{id}/lidar-asset")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Form(_form => _form.Setup("worldFileContent", worldFileContent))
                      .Form(_form => _form.Setup("image", image))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// FloorFeature_getFloorPlanBackground EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic FloorFeatureGetFloorPlanBackground(
                Guid id)
            => CoreHelper.RunTask(FloorFeatureGetFloorPlanBackgroundAsync(id));

        /// <summary>
        /// FloorFeature_getFloorPlanBackground EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> FloorFeatureGetFloorPlanBackgroundAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<dynamic>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/floor-features/{id}/background")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// FloorFeature_uploadBackground EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        public void FloorFeatureUploadBackground(
                Guid id,
                FileStreamInfo image)
            => CoreHelper.RunVoidTask(FloorFeatureUploadBackgroundAsync(id, image));

        /// <summary>
        /// FloorFeature_uploadBackground EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task FloorFeatureUploadBackgroundAsync(
                Guid id,
                FileStreamInfo image,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managementapi/floor-features/{id}/background")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Form(_form => _form.Setup("image", image))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// FloorFeature_getById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.FloorFeatures response from the API call.</returns>
        public Models.FloorFeatures FloorFeatureGetById(
                Guid id)
            => CoreHelper.RunTask(FloorFeatureGetByIdAsync(id));

        /// <summary>
        /// FloorFeature_getById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FloorFeatures response from the API call.</returns>
        public async Task<Models.FloorFeatures> FloorFeatureGetByIdAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FloorFeatures>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/floor-features/{id}")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// FloorFeature_worldFileData EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorldFile response from the API call.</returns>
        public Models.WorldFile FloorFeatureWorldFileData(
                Guid id)
            => CoreHelper.RunTask(FloorFeatureWorldFileDataAsync(id));

        /// <summary>
        /// FloorFeature_worldFileData EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorldFile response from the API call.</returns>
        public async Task<Models.WorldFile> FloorFeatureWorldFileDataAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorldFile>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/floor-features/{id}/world-file-data")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// FloorFeature_getLidar2dScan EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic FloorFeatureGetLidar2dScan(
                Guid id)
            => CoreHelper.RunTask(FloorFeatureGetLidar2dScanAsync(id));

        /// <summary>
        /// FloorFeature_getLidar2dScan EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> FloorFeatureGetLidar2dScanAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<dynamic>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/floor-features/{id}/lidar")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}