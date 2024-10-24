// <copyright file="VideoControllerTest.cs" company="APIMatic">
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
    /// VideoControllerTest.
    /// </summary>
    [TestFixture]
    public class VideoControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private VideoController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.VideoController;
        }

        /// <summary>
        /// Testcase for testing endpoint Video_searchVideos.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestVideoSearchVideos()
        {
            // Parameters for the API call
            int? page = 0;
            int? size = 20;
            List<string> sort = null;
            Guid? facilityId = null;
            string cameraId = null;
            Guid? batchId = null;
            DateTime? videoStartFrom = null;
            DateTime? videoStartTo = null;
            DateTime? videoEndFrom = null;
            DateTime? videoEndTo = null;

            // Perform API call
            Standard.Models.PageVideoMetadata result = null;
            try
            {
                result = await this.controller.VideoSearchVideosAsync(page, size, sort, facilityId, cameraId, batchId, videoStartFrom, videoStartTo, videoEndFrom, videoEndTo);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}