// <copyright file="RegionControllerTest.cs" company="APIMatic">
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
    /// RegionControllerTest.
    /// </summary>
    [TestFixture]
    public class RegionControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private RegionController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.RegionController;
        }

        /// <summary>
        /// Testcase for testing endpoint Region_getAll.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRegionGetAll()
        {
            // Parameters for the API call
            int? page = 0;
            int? size = 20;
            List<string> sort = null;
            Guid? floorId = null;
            Guid? facilityId = null;
            List<Standard.Models.CategoryEnum> category = null;

            // Perform API call
            Standard.Models.PageRegionResponse result = null;
            try
            {
                result = await this.controller.RegionGetAllAsync(page, size, sort, floorId, facilityId, category);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint Region_export.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRegionExport()
        {
            // Perform API call
            List<Standard.Models.RegionExportItem> result = null;
            try
            {
                result = await this.controller.RegionExportAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}