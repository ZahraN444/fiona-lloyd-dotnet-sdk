// <copyright file="CalendarEventsControllerTest.cs" company="APIMatic">
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
    /// CalendarEventsControllerTest.
    /// </summary>
    [TestFixture]
    public class CalendarEventsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private CalendarEventsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.CalendarEventsController;
        }

        /// <summary>
        /// Testcase for testing endpoint CalendarEvents_getEvents.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCalendarEventsGetEvents()
        {
            // Parameters for the API call
            Guid? regionId = null;
            Guid? floorId = null;
            Guid? facilityId = null;
            DateTime? startDate = null;
            DateTime? endDate = null;
            bool? showHiddenEvents = null;
            int? page = 0;
            int? size = 20;
            List<string> sort = null;

            // Perform API call
            Standard.Models.PageCalendarEventResponse result = null;
            try
            {
                result = await this.controller.CalendarEventsGetEventsAsync(regionId, floorId, facilityId, startDate, endDate, showHiddenEvents, page, size, sort);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Testcase for testing endpoint CalendarEvents_getOccurrences.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCalendarEventsGetOccurrences()
        {
            // Parameters for the API call
            Guid? regionId = null;
            Guid? floorId = null;
            Guid? facilityId = null;
            DateTime? startDate = null;
            DateTime? endDate = null;
            bool? showHiddenEvents = null;
            int? page = 0;
            int? size = 20;
            List<string> sort = null;

            // Perform API call
            Standard.Models.PageCalendarEventOccurrenceResponse result = null;
            try
            {
                result = await this.controller.CalendarEventsGetOccurrencesAsync(regionId, floorId, facilityId, startDate, endDate, showHiddenEvents, page, size, sort);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}