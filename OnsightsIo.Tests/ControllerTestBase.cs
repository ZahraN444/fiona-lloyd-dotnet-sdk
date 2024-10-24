// <copyright file="ControllerTestBase.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OnsightsIo.Standard;
using OnsightsIo.Standard.Authentication;
using OnsightsIo.Standard.Http.Client;
using OnsightsIo.Standard.Models;
using OnsightsIo.Standard.Models.Containers;

namespace OnsightsIo.Tests
{
    /// <summary>
    /// ControllerTestBase Class.
    /// </summary>
    [TestFixture]
    public class ControllerTestBase
    {
        /// <summary>
        /// Assert precision.
        /// </summary>
        protected const double AssertPrecision = 0.1;

        /// <summary>
        /// Gets HttpCallBackHandler.
        /// </summary>
        internal HttpCallback HttpCallBack { get; private set; } = new HttpCallback();

        /// <summary>
        /// Gets OnsightsIoClient Client.
        /// </summary>
        protected OnsightsIoClient Client { get; private set; }

        /// <summary>
        /// Set up the client.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            OnsightsIoClient config = OnsightsIoClient.CreateFromEnvironment();
            this.Client = config.ToBuilder()
                .HttpCallback(HttpCallBack)
                .Build();
        }
    }
}