// <copyright file="UserController.cs" company="APIMatic">
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
    /// UserController.
    /// </summary>
    public class UserController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        internal UserController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// User_getMyOrganizations EndPoint.
        /// </summary>
        /// <returns>Returns the List of Models.OrganizationItem response from the API call.</returns>
        public List<Models.OrganizationItem> UserGetMyOrganizations()
            => CoreHelper.RunTask(UserGetMyOrganizationsAsync());

        /// <summary>
        /// User_getMyOrganizations EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.OrganizationItem response from the API call.</returns>
        public async Task<List<Models.OrganizationItem>> UserGetMyOrganizationsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.OrganizationItem>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/users/my-organizations")
                  .WithAuth("openId"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// User_findById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UserResponse response from the API call.</returns>
        public Models.UserResponse UserFindById(
                string id)
            => CoreHelper.RunTask(UserFindByIdAsync(id));

        /// <summary>
        /// User_findById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserResponse response from the API call.</returns>
        public async Task<Models.UserResponse> UserFindByIdAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managementapi/users/info")
                  .WithAuth("openId")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorMessageException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorMessageException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}