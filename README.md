
# Getting Started with Onsights.io

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package FionaLloydSDK --version 1.2.3
```

You can also view the package at:
https://www.nuget.org/packages/FionaLloydSDK/1.2.3

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BearerAuthCredentials` | [`BearerAuthCredentials`](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |

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

## Authorization

This API uses the following authentication schemes.

* [`openId (OAuth 2 Bearer token)`](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/auth/oauth-2-bearer-token.md)

## List of APIs

* [Region-Feature-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/region-feature-controller.md)
* [Region-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/region-controller.md)
* [Floor-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/floor-controller.md)
* [Dashboard-Settings-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/dashboard-settings-controller.md)
* [Facility-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/facility-controller.md)
* [Calendar-Events-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/calendar-events-controller.md)
* [Campaign-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/campaign-controller.md)
* [Campaign-Details-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/campaign-details-controller.md)
* [Camera-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/camera-controller.md)
* [Building-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/building-controller.md)
* [Advertisement-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/advertisement-controller.md)
* [Image-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/image-controller.md)
* [Geometry-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/geometry-controller.md)
* [Floor-Feature-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/floor-feature-controller.md)
* [User-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/user-controller.md)
* [Naics-Code-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/naics-code-controller.md)
* [Batch-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/batch-controller.md)
* [Video-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/video-controller.md)
* [Journeys-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/journeys-controller.md)
* [Visitors-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/visitors-controller.md)
* [Opportunity-Area-Heatmap-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/opportunity-area-heatmap-controller.md)
* [Cross-Shop-Controller](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/controllers/cross-shop-controller.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/http-request.md)
* [HttpResponse](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/http-string-response.md)
* [HttpContext](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/ZahraN444/fiona-lloyd-dotnet-sdk/tree/1.2.3/doc/api-exception.md)

