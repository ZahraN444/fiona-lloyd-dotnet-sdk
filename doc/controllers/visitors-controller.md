# Visitors-Controller

```csharp
VisitorsController visitorsController = client.VisitorsController;
```

## Class Name

`VisitorsController`

## Methods

* [Visitors Visitors by Entrance](../../doc/controllers/visitors-controller.md#visitors-visitors-by-entrance)
* [Visitors Total Summed All](../../doc/controllers/visitors-controller.md#visitors-total-summed-all)
* [Visitors Total Hourly All](../../doc/controllers/visitors-controller.md#visitors-total-hourly-all)
* [Analyticsapi Visitors Total Hourly All](../../doc/controllers/visitors-controller.md#analyticsapi-visitors-total-hourly-all)
* [Visitors Total Daily All](../../doc/controllers/visitors-controller.md#visitors-total-daily-all)
* [Visitors Destination Stores](../../doc/controllers/visitors-controller.md#visitors-destination-stores)
* [Visitors Cross Shop](../../doc/controllers/visitors-controller.md#visitors-cross-shop)
* [Visitors Conversions Daily All](../../doc/controllers/visitors-controller.md#visitors-conversions-daily-all)


# Visitors Visitors by Entrance

```csharp
VisitorsVisitorsByEntranceAsync(
    DateTime startDate,
    DateTime endDate,
    Guid facilityId,
    bool? includeAbsoluteValues = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.VisitorsByEntranceStoreResponse>`](../../doc/models/visitors-by-entrance-store-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    VisitorsByEntranceStoreResponse result = await visitorsController.VisitorsVisitorsByEntranceAsync(
        startDate,
        endDate,
        facilityId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Visitors Total Summed All

```csharp
VisitorsTotalSummedAllAsync(
    DateTime startDate,
    DateTime endDate,
    Guid facilityId,
    bool? includeAbsoluteValues = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.VisitorTotalSumResponse>`](../../doc/models/visitor-total-sum-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    VisitorTotalSumResponse result = await visitorsController.VisitorsTotalSummedAllAsync(
        startDate,
        endDate,
        facilityId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Visitors Total Hourly All

```csharp
VisitorsTotalHourlyAllAsync(
    DateTime startDate,
    DateTime endDate,
    Guid facilityId,
    Guid? regionId = null,
    bool? includeAbsoluteValues = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |
| `regionId` | `Guid?` | Query, Optional | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.VisitorHourlyTotalResponse>`](../../doc/models/visitor-hourly-total-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    VisitorHourlyTotalResponse result = await visitorsController.VisitorsTotalHourlyAllAsync(
        startDate,
        endDate,
        facilityId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Analyticsapi Visitors Total Hourly All

```csharp
AnalyticsapiVisitorsTotalHourlyAllAsync(
    DateTime startDate,
    DateTime endDate,
    Guid facilityId,
    Guid? regionId = null,
    bool? includeAbsoluteValues = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |
| `regionId` | `Guid?` | Query, Optional | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.VisitorHourlyTotalResponse>`](../../doc/models/visitor-hourly-total-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    VisitorHourlyTotalResponse result = await visitorsController.AnalyticsapiVisitorsTotalHourlyAllAsync(
        startDate,
        endDate,
        facilityId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Visitors Total Daily All

```csharp
VisitorsTotalDailyAllAsync(
    DateTime startDate,
    DateTime endDate,
    Guid facilityId,
    Guid? regionId = null,
    bool? includeAbsoluteValues = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |
| `regionId` | `Guid?` | Query, Optional | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.VisitorDailyTotalResponse>`](../../doc/models/visitor-daily-total-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    VisitorDailyTotalResponse result = await visitorsController.VisitorsTotalDailyAllAsync(
        startDate,
        endDate,
        facilityId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Visitors Destination Stores

```csharp
VisitorsDestinationStoresAsync(
    DateTime startDate,
    DateTime endDate,
    Guid facilityId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.VisitorDestinationStoreResponse>`](../../doc/models/visitor-destination-store-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    VisitorDestinationStoreResponse result = await visitorsController.VisitorsDestinationStoresAsync(
        startDate,
        endDate,
        facilityId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Visitors Cross Shop

```csharp
VisitorsCrossShopAsync(
    DateTime startDate,
    DateTime endDate,
    Guid facilityId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.RedirectView>`](../../doc/models/redirect-view.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    RedirectView result = await visitorsController.VisitorsCrossShopAsync(
        startDate,
        endDate,
        facilityId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Visitors Conversions Daily All

```csharp
VisitorsConversionsDailyAllAsync(
    DateTime startDate,
    DateTime endDate,
    Guid regionId,
    Guid facilityId,
    bool? includeAbsoluteValues = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `regionId` | `Guid` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.VisitorDailyConversionsResponse>`](../../doc/models/visitor-daily-conversions-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid regionId = new Guid("00000b84-0000-0000-0000-000000000000");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    VisitorDailyConversionsResponse result = await visitorsController.VisitorsConversionsDailyAllAsync(
        startDate,
        endDate,
        regionId,
        facilityId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 500 | Internal Server Error | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |

