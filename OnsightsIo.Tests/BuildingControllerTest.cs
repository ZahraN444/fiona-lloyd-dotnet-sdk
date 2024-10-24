// <copyright file="BuildingControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using Newtonsoft.Json.Converters;
using NUnit.Framework;
using OnsightsIo.Standard;
using OnsightsIo.Standard.Controllers;
using OnsightsIo.Standard.Exceptions;
using OnsightsIo.Standard.Http.Client;
using OnsightsIo.Standard.Http.Response;
using OnsightsIo.Standard.Models.Containers;
using OnsightsIo.Standard.Utilities;

namespace OnsightsIo.Tests
{
    /// <summary>
    /// BuildingControllerTest.
    /// </summary>
    [TestFixture]
    public class BuildingControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private BuildingController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.BuildingController;
        }

        /// <summary>
        /// Testcase for testing endpoint Building_getAll.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestBuildingGetAll()
        {
            // Parameters for the API call
            int? page = 0;
            int? size = 20;
            List<string> sort = null;
            Guid? facilityId = null;

            // Perform API call
            Standard.Models.PageBuildingResponse result = null;
            try
            {
                result = await this.controller.BuildingGetAllAsync(page, size, sort, facilityId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}