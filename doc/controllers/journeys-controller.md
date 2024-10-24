# Journeys-Controller

```csharp
JourneysController journeysController = client.JourneysController;
```

## Class Name

`JourneysController`

## Methods

* [Journeys Get Sankey Journeys All](../../doc/controllers/journeys-controller.md#journeys-get-sankey-journeys-all)
* [Journeys Get Top Destinations All](../../doc/controllers/journeys-controller.md#journeys-get-top-destinations-all)
* [Journeys Get Missed Capture All](../../doc/controllers/journeys-controller.md#journeys-get-missed-capture-all)
* [Journeys Get Dwell Time All](../../doc/controllers/journeys-controller.md#journeys-get-dwell-time-all)
* [Journeys Get Journey Duration All](../../doc/controllers/journeys-controller.md#journeys-get-journey-duration-all)
* [Journeys Get Association Rules](../../doc/controllers/journeys-controller.md#journeys-get-association-rules)


# Journeys Get Sankey Journeys All

```csharp
JourneysGetSankeyJourneysAllAsync(
    Guid facilityId,
    Models.JourneysSankeyCriteria body,
    bool? includeAbsoluteValues = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `facilityId` | `Guid` | Template, Required | - |
| `body` | [`JourneysSankeyCriteria`](../../doc/models/journeys-sankey-criteria.md) | Body, Required | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.JourneySankeyResponse>`](../../doc/models/journey-sankey-response.md)

## Example Usage

```csharp
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
JourneysSankeyCriteria body = new JourneysSankeyCriteria
{
    StartDate = DateTime.Parse("2016-03-13"),
    EndDate = DateTime.Parse("2016-03-13"),
    MaxWidth = 208,
    Focus = FocusEnum.STORE,
};

try
{
    JourneySankeyResponse result = await journeysController.JourneysGetSankeyJourneysAllAsync(
        facilityId,
        body
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


# Journeys Get Top Destinations All

```csharp
JourneysGetTopDestinationsAllAsync(
    DateTime startDate,
    DateTime endDate,
    Guid facilityId,
    int? depth = null,
    int? count = null,
    Guid? regionId = null,
    bool? includeAbsoluteValues = null,
    bool? filterRegionsWithParents = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |
| `depth` | `int?` | Query, Optional | **Constraints**: `>= 1`, `<= 10` |
| `count` | `int?` | Query, Optional | **Constraints**: `>= 1` |
| `regionId` | `Guid?` | Query, Optional | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |
| `filterRegionsWithParents` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.TopDestinationsResponse>`](../../doc/models/top-destinations-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    TopDestinationsResponse result = await journeysController.JourneysGetTopDestinationsAllAsync(
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


# Journeys Get Missed Capture All

```csharp
JourneysGetMissedCaptureAllAsync(
    Guid regionId,
    DateTime startDate,
    DateTime endDate,
    Guid facilityId,
    bool? includeAbsoluteValues = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `regionId` | `Guid` | Query, Required | - |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.MissedCaptureResponse>`](../../doc/models/missed-capture-response.md)

## Example Usage

```csharp
Guid regionId = new Guid("00000b84-0000-0000-0000-000000000000");
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    MissedCaptureResponse result = await journeysController.JourneysGetMissedCaptureAllAsync(
        regionId,
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


# Journeys Get Dwell Time All

```csharp
JourneysGetDwellTimeAllAsync(
    DateTime startDate,
    DateTime endDate,
    Guid facilityId,
    bool? includeAbsoluteValues = null,
    bool? filterRegionsWithParents = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |
| `filterRegionsWithParents` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.DwellTimeResponse>`](../../doc/models/dwell-time-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    DwellTimeResponse result = await journeysController.JourneysGetDwellTimeAllAsync(
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


# Journeys Get Journey Duration All

```csharp
JourneysGetJourneyDurationAllAsync(
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

[`Task<Models.JourneyDurationResponse>`](../../doc/models/journey-duration-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    JourneyDurationResponse result = await journeysController.JourneysGetJourneyDurationAllAsync(
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


# Journeys Get Association Rules

```csharp
JourneysGetAssociationRulesAsync(
    Guid regionId,
    DateTime startDate,
    DateTime endDate,
    Guid facilityId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `regionId` | `Guid` | Query, Required | - |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.AssociationRulesResponse>`](../../doc/models/association-rules-response.md)

## Example Usage

```csharp
Guid regionId = new Guid("00000b84-0000-0000-0000-000000000000");
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    AssociationRulesResponse result = await journeysController.JourneysGetAssociationRulesAsync(
        regionId,
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

