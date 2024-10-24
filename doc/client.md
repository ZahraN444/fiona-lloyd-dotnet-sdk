
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BearerAuthCredentials` | [`BearerAuthCredentials`](auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |

The API client can be initialized as follows:

```csharp
OnsightsIoClient client = new OnsightsIoClient.Builder()
    .BearerAuthCredentials(
        new BearerAuthModel.Builder(
            "AccessToken"
        )
        .Build())
    .Environment(OnsightsIo.Standard.Environment.Production)
    .Build();
```

## Onsights.ioClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| RegionFeatureController | Gets RegionFeatureController controller. |
| RegionController | Gets RegionController controller. |
| FloorController | Gets FloorController controller. |
| DashboardSettingsController | Gets DashboardSettingsController controller. |
| FacilityController | Gets FacilityController controller. |
| CalendarEventsController | Gets CalendarEventsController controller. |
| CampaignController | Gets CampaignController controller. |
| CampaignDetailsController | Gets CampaignDetailsController controller. |
| CameraController | Gets CameraController controller. |
| BuildingController | Gets BuildingController controller. |
| AdvertisementController | Gets AdvertisementController controller. |
| ImageController | Gets ImageController controller. |
| GeometryController | Gets GeometryController controller. |
| FloorFeatureController | Gets FloorFeatureController controller. |
| UserController | Gets UserController controller. |
| NaicsCodeController | Gets NaicsCodeController controller. |
| BatchController | Gets BatchController controller. |
| VideoController | Gets VideoController controller. |
| JourneysController | Gets JourneysController controller. |
| VisitorsController | Gets VisitorsController controller. |
| OpportunityAreaHeatmapController | Gets OpportunityAreaHeatmapController controller. |
| CrossShopController | Gets CrossShopController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| BearerAuthCredentials | Gets the credentials to use with BearerAuth. | [`IBearerAuthCredentials`](auth/oauth-2-bearer-token.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Onsights.ioClient using the values provided for the builder. | `Builder` |

## Onsights.ioClient Builder Class

Class to build instances of Onsights.ioClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `BearerAuthCredentials(Action<BearerAuthModel.Builder> action)` | Sets credentials for BearerAuth. | `Builder` |

