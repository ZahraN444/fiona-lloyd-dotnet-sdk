# Region-Feature-Controller

```csharp
RegionFeatureController regionFeatureController = client.RegionFeatureController;
```

## Class Name

`RegionFeatureController`

## Methods

* [Region Feature Update](../../doc/controllers/region-feature-controller.md#region-feature-update)
* [Region Feature Get All](../../doc/controllers/region-feature-controller.md#region-feature-get-all)
* [Region Feature Create](../../doc/controllers/region-feature-controller.md#region-feature-create)
* [Region Feature Get](../../doc/controllers/region-feature-controller.md#region-feature-get)
* [Region Feature Delete](../../doc/controllers/region-feature-controller.md#region-feature-delete)


# Region Feature Update

```csharp
RegionFeatureUpdateAsync(
    Guid regionId,
    Guid id,
    Models.RegionFeatureRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `regionId` | `Guid` | Template, Required | - |
| `id` | `Guid` | Template, Required | - |
| `body` | [`RegionFeatureRequest`](../../doc/models/region-feature-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid regionId = new Guid("00000b84-0000-0000-0000-000000000000");
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
RegionFeatureRequest body = new RegionFeatureRequest
{
    RegionId = new Guid("0000249c-0000-0000-0000-000000000000"),
    Name = "name6",
    Boundary = RegionFeatureRequestBoundary.FromLineRepresentation(
        new LineRepresentation
        {
            MValue = new List<Point2D>
            {
                new Point2D
                {
                    X = 29.38,
                    Y = 160.66,
                },
            },
            Type = "LineRepresentation",
        }
    ),
    FeatureCategory = FeatureCategoryEnum.STOREENTRANCE,
};

try
{
    Guid? result = await regionFeatureController.RegionFeatureUpdateAsync(
        regionId,
        id,
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
| 404 | Not Found | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Region Feature Get All

```csharp
RegionFeatureGetAllAsync(
    Guid regionId,
    List<string> sort = null,
    Models.Category5Enum? category = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `regionId` | `Guid` | Template, Required | - |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |
| `category` | [`Category5Enum?`](../../doc/models/category-5-enum.md) | Query, Optional | - |

## Response Type

[`Task<List<Models.RegionFeatureResponse>>`](../../doc/models/region-feature-response.md)

## Example Usage

```csharp
Guid regionId = new Guid("00000b84-0000-0000-0000-000000000000");
try
{
    List<RegionFeatureResponse> result = await regionFeatureController.RegionFeatureGetAllAsync(regionId);
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
| 404 | Not Found | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Region Feature Create

```csharp
RegionFeatureCreateAsync(
    Guid regionId,
    Models.RegionFeatureRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `regionId` | `Guid` | Template, Required | - |
| `body` | [`RegionFeatureRequest`](../../doc/models/region-feature-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid regionId = new Guid("00000b84-0000-0000-0000-000000000000");
RegionFeatureRequest body = new RegionFeatureRequest
{
    RegionId = new Guid("0000249c-0000-0000-0000-000000000000"),
    Name = "name6",
    Boundary = RegionFeatureRequestBoundary.FromLineRepresentation(
        new LineRepresentation
        {
            MValue = new List<Point2D>
            {
                new Point2D
                {
                    X = 29.38,
                    Y = 160.66,
                },
            },
            Type = "LineRepresentation",
        }
    ),
    FeatureCategory = FeatureCategoryEnum.STOREENTRANCE,
};

try
{
    Guid? result = await regionFeatureController.RegionFeatureCreateAsync(
        regionId,
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
| 404 | Not Found | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Region Feature Get

```csharp
RegionFeatureGetAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.RegionFeatureResponse>`](../../doc/models/region-feature-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    RegionFeatureResponse result = await regionFeatureController.RegionFeatureGetAsync(id);
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
| 404 | Not Found | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |


# Region Feature Delete

```csharp
RegionFeatureDeleteAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.RegionFeature>`](../../doc/models/region-feature.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    RegionFeature result = await regionFeatureController.RegionFeatureDeleteAsync(id);
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
| 404 | Not Found | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |

