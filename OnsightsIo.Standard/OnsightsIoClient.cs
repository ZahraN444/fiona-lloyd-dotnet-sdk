// <copyright file="OnsightsIoClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using OnsightsIo.Standard.Authentication;
using OnsightsIo.Standard.Controllers;
using OnsightsIo.Standard.Http.Client;
using OnsightsIo.Standard.Utilities;

namespace OnsightsIo.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class OnsightsIoClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://app.dev.onsights.io/api" },
                    { Server.AuthServer, "https://onsights-dev.us.auth0.com/.well-known" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<RegionFeatureController> regionFeatureController;
        private readonly Lazy<RegionController> regionController;
        private readonly Lazy<FloorController> floorController;
        private readonly Lazy<DashboardSettingsController> dashboardSettingsController;
        private readonly Lazy<FacilityController> facilityController;
        private readonly Lazy<CalendarEventsController> calendarEventsController;
        private readonly Lazy<CampaignController> campaignController;
        private readonly Lazy<CampaignDetailsController> campaignDetailsController;
        private readonly Lazy<CameraController> cameraController;
        private readonly Lazy<BuildingController> buildingController;
        private readonly Lazy<AdvertisementController> advertisementController;
        private readonly Lazy<ImageController> imageController;
        private readonly Lazy<GeometryController> geometryController;
        private readonly Lazy<FloorFeatureController> floorFeatureController;
        private readonly Lazy<UserController> userController;
        private readonly Lazy<NaicsCodeController> naicsCodeController;
        private readonly Lazy<BatchController> batchController;
        private readonly Lazy<VideoController> videoController;
        private readonly Lazy<JourneysController> journeysController;
        private readonly Lazy<VisitorsController> visitorsController;
        private readonly Lazy<OpportunityAreaHeatmapController> opportunityAreaHeatmapController;
        private readonly Lazy<CrossShopController> crossShopController;

        private OnsightsIoClient(
            Environment environment,
            BearerAuthModel bearerAuthModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            BearerAuthModel = bearerAuthModel;
            var bearerAuthManager = new BearerAuthManager(bearerAuthModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"openId", bearerAuthManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();

            BearerAuthCredentials = bearerAuthManager;

            this.regionFeatureController = new Lazy<RegionFeatureController>(
                () => new RegionFeatureController(globalConfiguration));
            this.regionController = new Lazy<RegionController>(
                () => new RegionController(globalConfiguration));
            this.floorController = new Lazy<FloorController>(
                () => new FloorController(globalConfiguration));
            this.dashboardSettingsController = new Lazy<DashboardSettingsController>(
                () => new DashboardSettingsController(globalConfiguration));
            this.facilityController = new Lazy<FacilityController>(
                () => new FacilityController(globalConfiguration));
            this.calendarEventsController = new Lazy<CalendarEventsController>(
                () => new CalendarEventsController(globalConfiguration));
            this.campaignController = new Lazy<CampaignController>(
                () => new CampaignController(globalConfiguration));
            this.campaignDetailsController = new Lazy<CampaignDetailsController>(
                () => new CampaignDetailsController(globalConfiguration));
            this.cameraController = new Lazy<CameraController>(
                () => new CameraController(globalConfiguration));
            this.buildingController = new Lazy<BuildingController>(
                () => new BuildingController(globalConfiguration));
            this.advertisementController = new Lazy<AdvertisementController>(
                () => new AdvertisementController(globalConfiguration));
            this.imageController = new Lazy<ImageController>(
                () => new ImageController(globalConfiguration));
            this.geometryController = new Lazy<GeometryController>(
                () => new GeometryController(globalConfiguration));
            this.floorFeatureController = new Lazy<FloorFeatureController>(
                () => new FloorFeatureController(globalConfiguration));
            this.userController = new Lazy<UserController>(
                () => new UserController(globalConfiguration));
            this.naicsCodeController = new Lazy<NaicsCodeController>(
                () => new NaicsCodeController(globalConfiguration));
            this.batchController = new Lazy<BatchController>(
                () => new BatchController(globalConfiguration));
            this.videoController = new Lazy<VideoController>(
                () => new VideoController(globalConfiguration));
            this.journeysController = new Lazy<JourneysController>(
                () => new JourneysController(globalConfiguration));
            this.visitorsController = new Lazy<VisitorsController>(
                () => new VisitorsController(globalConfiguration));
            this.opportunityAreaHeatmapController = new Lazy<OpportunityAreaHeatmapController>(
                () => new OpportunityAreaHeatmapController(globalConfiguration));
            this.crossShopController = new Lazy<CrossShopController>(
                () => new CrossShopController(globalConfiguration));
        }

        /// <summary>
        /// Gets RegionFeatureController controller.
        /// </summary>
        public RegionFeatureController RegionFeatureController => this.regionFeatureController.Value;

        /// <summary>
        /// Gets RegionController controller.
        /// </summary>
        public RegionController RegionController => this.regionController.Value;

        /// <summary>
        /// Gets FloorController controller.
        /// </summary>
        public FloorController FloorController => this.floorController.Value;

        /// <summary>
        /// Gets DashboardSettingsController controller.
        /// </summary>
        public DashboardSettingsController DashboardSettingsController => this.dashboardSettingsController.Value;

        /// <summary>
        /// Gets FacilityController controller.
        /// </summary>
        public FacilityController FacilityController => this.facilityController.Value;

        /// <summary>
        /// Gets CalendarEventsController controller.
        /// </summary>
        public CalendarEventsController CalendarEventsController => this.calendarEventsController.Value;

        /// <summary>
        /// Gets CampaignController controller.
        /// </summary>
        public CampaignController CampaignController => this.campaignController.Value;

        /// <summary>
        /// Gets CampaignDetailsController controller.
        /// </summary>
        public CampaignDetailsController CampaignDetailsController => this.campaignDetailsController.Value;

        /// <summary>
        /// Gets CameraController controller.
        /// </summary>
        public CameraController CameraController => this.cameraController.Value;

        /// <summary>
        /// Gets BuildingController controller.
        /// </summary>
        public BuildingController BuildingController => this.buildingController.Value;

        /// <summary>
        /// Gets AdvertisementController controller.
        /// </summary>
        public AdvertisementController AdvertisementController => this.advertisementController.Value;

        /// <summary>
        /// Gets ImageController controller.
        /// </summary>
        public ImageController ImageController => this.imageController.Value;

        /// <summary>
        /// Gets GeometryController controller.
        /// </summary>
        public GeometryController GeometryController => this.geometryController.Value;

        /// <summary>
        /// Gets FloorFeatureController controller.
        /// </summary>
        public FloorFeatureController FloorFeatureController => this.floorFeatureController.Value;

        /// <summary>
        /// Gets UserController controller.
        /// </summary>
        public UserController UserController => this.userController.Value;

        /// <summary>
        /// Gets NaicsCodeController controller.
        /// </summary>
        public NaicsCodeController NaicsCodeController => this.naicsCodeController.Value;

        /// <summary>
        /// Gets BatchController controller.
        /// </summary>
        public BatchController BatchController => this.batchController.Value;

        /// <summary>
        /// Gets VideoController controller.
        /// </summary>
        public VideoController VideoController => this.videoController.Value;

        /// <summary>
        /// Gets JourneysController controller.
        /// </summary>
        public JourneysController JourneysController => this.journeysController.Value;

        /// <summary>
        /// Gets VisitorsController controller.
        /// </summary>
        public VisitorsController VisitorsController => this.visitorsController.Value;

        /// <summary>
        /// Gets OpportunityAreaHeatmapController controller.
        /// </summary>
        public OpportunityAreaHeatmapController OpportunityAreaHeatmapController => this.opportunityAreaHeatmapController.Value;

        /// <summary>
        /// Gets CrossShopController controller.
        /// </summary>
        public CrossShopController CrossShopController => this.crossShopController.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with BearerAuth.
        /// </summary>
        public IBearerAuthCredentials BearerAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BearerAuth.
        /// </summary>
        public BearerAuthModel BearerAuthModel { get; private set; }

        /// <summary>
        /// Gets the access token to use with OAuth 2 authentication.
        /// </summary>
        public string AccessToken => this.BearerAuthCredentials.AccessToken;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the OnsightsIoClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallback(httpCallback)
                .HttpClientConfig(config => config.Build());

            if (BearerAuthModel != null)
            {
                builder.BearerAuthCredentials(BearerAuthModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> OnsightsIoClient.</returns>
        internal static OnsightsIoClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("ONSIGHTS_IO_STANDARD_ENVIRONMENT");
            string accessToken = System.Environment.GetEnvironmentVariable("ONSIGHTS_IO_STANDARD_ACCESS_TOKEN");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (accessToken != null)
            {
                builder.BearerAuthCredentials(new BearerAuthModel
                .Builder(accessToken)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = OnsightsIo.Standard.Environment.Production;
            private BearerAuthModel bearerAuthModel = new BearerAuthModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="accessToken">AccessToken.</param>
            /// <returns>Builder.</returns>
            [Obsolete("This method is deprecated. Use BearerAuthCredentials(bearerAuthModel) instead.")]
            public Builder AccessToken(string accessToken)
            {
                bearerAuthModel = bearerAuthModel.ToBuilder()
                    .AccessToken(accessToken)
                    .Build();
                return this;
            }

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="bearerAuthModel">BearerAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder BearerAuthCredentials(BearerAuthModel bearerAuthModel)
            {
                if (bearerAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(bearerAuthModel));
                }

                this.bearerAuthModel = bearerAuthModel;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }



            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the OnsightsIoClient using the values provided for the builder.
            /// </summary>
            /// <returns>OnsightsIoClient.</returns>
            public OnsightsIoClient Build()
            {
                if (bearerAuthModel.AccessToken == null)
                {
                    bearerAuthModel = null;
                }
                return new OnsightsIoClient(
                    environment,
                    bearerAuthModel,
                    httpCallback,
                    httpClientConfig.Build());
            }
        }
    }
}
