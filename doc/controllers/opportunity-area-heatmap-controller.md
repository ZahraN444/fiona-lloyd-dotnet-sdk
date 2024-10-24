# Opportunity-Area-Heatmap-Controller

```csharp
OpportunityAreaHeatmapController opportunityAreaHeatmapController = client.OpportunityAreaHeatmapController;
```

## Class Name

`OpportunityAreaHeatmapController`


# Opportunity Area Heatmap Get Opportunity Area Heatmap All

```csharp
OpportunityAreaHeatmapGetOpportunityAreaHeatmapAllAsync(
    Guid facilityId,
    DateTime startDate,
    DateTime endDate,
    bool? includeAbsoluteValues = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `facilityId` | `Guid` | Template, Required | - |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.GetOpportunityAreaHeatmapResponse>`](../../doc/models/get-opportunity-area-heatmap-response.md)

## Example Usage

```csharp
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
try
{
    GetOpportunityAreaHeatmapResponse result = await opportunityAreaHeatmapController.OpportunityAreaHeatmapGetOpportunityAreaHeatmapAllAsync(
        facilityId,
        startDate,
        endDate
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

