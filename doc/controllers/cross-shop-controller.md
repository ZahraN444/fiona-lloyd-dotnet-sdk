# Cross-Shop-Controller

```csharp
CrossShopController crossShopController = client.CrossShopController;
```

## Class Name

`CrossShopController`

## Methods

* [Cross Shop Cross Product Breakdown All](../../doc/controllers/cross-shop-controller.md#cross-shop-cross-product-breakdown-all)
* [Cross Shop Avg Cross Shop After](../../doc/controllers/cross-shop-controller.md#cross-shop-avg-cross-shop-after)


# Cross Shop Cross Product Breakdown All

```csharp
CrossShopCrossProductBreakdownAllAsync(
    DateTime startDate,
    DateTime endDate,
    Guid facilityId,
    Guid? regionId = null,
    int? maxPairs = null,
    bool? includeAbsoluteValues = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startDate` | `DateTime` | Query, Required | - |
| `endDate` | `DateTime` | Query, Required | - |
| `facilityId` | `Guid` | Template, Required | - |
| `regionId` | `Guid?` | Query, Optional | - |
| `maxPairs` | `int?` | Query, Optional | **Constraints**: `>= 1` |
| `includeAbsoluteValues` | `bool?` | Query, Optional | - |

## Response Type

[`Task<Models.CrossShopBreakdownResponse>`](../../doc/models/cross-shop-breakdown-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    CrossShopBreakdownResponse result = await crossShopController.CrossShopCrossProductBreakdownAllAsync(
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


# Cross Shop Avg Cross Shop After

```csharp
CrossShopAvgCrossShopAfterAsync(
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

[`Task<Models.AvgCrossShopAfterResponse>`](../../doc/models/avg-cross-shop-after-response.md)

## Example Usage

```csharp
DateTime startDate = DateTime.Parse("2016-03-13");
DateTime endDate = DateTime.Parse("2016-03-13");
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
try
{
    AvgCrossShopAfterResponse result = await crossShopController.CrossShopAvgCrossShopAfterAsync(
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

