// <copyright file="FloorControllerTest.cs" company="APIMatic">
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
    /// FloorControllerTest.
    /// </summary>
    [TestFixture]
    public class FloorControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private FloorController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.FloorController;
        }

        /// <summary>
        /// Testcase for testing endpoint Floor_getAll.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestFloorGetAll()
        {
            // Parameters for the API call
            int? page = 0;
            int? size = 20;
            List<string> sort = null;
            Guid? facilityId = null;
            Guid? buildingId = null;

            // Perform API call
            Standard.Models.PageFloorResponse result = null;
            try
            {
                result = await this.controller.FloorGetAllAsync(page, size, sort, facilityId, buildingId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}