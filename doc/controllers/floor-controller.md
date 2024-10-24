# Floor-Controller

```csharp
FloorController floorController = client.FloorController;
```

## Class Name

`FloorController`

## Methods

* [Floor Get](../../doc/controllers/floor-controller.md#floor-get)
* [Floor Update](../../doc/controllers/floor-controller.md#floor-update)
* [Floor Delete](../../doc/controllers/floor-controller.md#floor-delete)
* [Floor Get All](../../doc/controllers/floor-controller.md#floor-get-all)
* [Floor Create](../../doc/controllers/floor-controller.md#floor-create)


# Floor Get

```csharp
FloorGetAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.FloorResponse>`](../../doc/models/floor-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    FloorResponse result = await floorController.FloorGetAsync(id);
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


# Floor Update

```csharp
FloorUpdateAsync(
    Guid id,
    Models.FloorRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `body` | [`FloorRequest`](../../doc/models/floor-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
FloorRequest body = new FloorRequest
{
    Level = 154,
    BuildingId = new Guid("00002626-0000-0000-0000-000000000000"),
    BottomLimit = 97.98,
};

try
{
    Guid? result = await floorController.FloorUpdateAsync(
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


# Floor Delete

```csharp
FloorDeleteAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    await floorController.FloorDeleteAsync(id);
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


# Floor Get All

```csharp
FloorGetAllAsync(
    int? page = 0,
    int? size = 20,
    List<string> sort = null,
    Guid? facilityId = null,
    Guid? buildingId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |
| `facilityId` | `Guid?` | Query, Optional | - |
| `buildingId` | `Guid?` | Query, Optional | - |

## Response Type

[`Task<Models.PageFloorResponse>`](../../doc/models/page-floor-response.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageFloorResponse result = await floorController.FloorGetAllAsync(
        page,
        size
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


# Floor Create

```csharp
FloorCreateAsync(
    Models.FloorRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`FloorRequest`](../../doc/models/floor-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
FloorRequest body = new FloorRequest
{
    Level = 154,
    BuildingId = new Guid("00002626-0000-0000-0000-000000000000"),
    BottomLimit = 97.98,
};

try
{
    Guid? result = await floorController.FloorCreateAsync(body);
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

