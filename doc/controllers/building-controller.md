# Building-Controller

```csharp
BuildingController buildingController = client.BuildingController;
```

## Class Name

`BuildingController`

## Methods

* [Building Get](../../doc/controllers/building-controller.md#building-get)
* [Building Update](../../doc/controllers/building-controller.md#building-update)
* [Building Delete](../../doc/controllers/building-controller.md#building-delete)
* [Building Get All](../../doc/controllers/building-controller.md#building-get-all)
* [Building Create](../../doc/controllers/building-controller.md#building-create)


# Building Get

```csharp
BuildingGetAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.BuildingResponse>`](../../doc/models/building-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    BuildingResponse result = await buildingController.BuildingGetAsync(id);
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


# Building Update

```csharp
BuildingUpdateAsync(
    Guid id,
    Models.BuildingRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `body` | [`BuildingRequest`](../../doc/models/building-request.md) | Body, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
BuildingRequest body = new BuildingRequest
{
    Name = "name6",
    Address = "address2",
    FacilityId = new Guid("000002ee-0000-0000-0000-000000000000"),
};

try
{
    await buildingController.BuildingUpdateAsync(
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


# Building Delete

```csharp
BuildingDeleteAsync(
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
    await buildingController.BuildingDeleteAsync(id);
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


# Building Get All

```csharp
BuildingGetAllAsync(
    int? page = 0,
    int? size = 20,
    List<string> sort = null,
    Guid? facilityId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |
| `facilityId` | `Guid?` | Query, Optional | - |

## Response Type

[`Task<Models.PageBuildingResponse>`](../../doc/models/page-building-response.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageBuildingResponse result = await buildingController.BuildingGetAllAsync(
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


# Building Create

```csharp
BuildingCreateAsync(
    Models.BuildingRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`BuildingRequest`](../../doc/models/building-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
BuildingRequest body = new BuildingRequest
{
    Name = "name6",
    Address = "address2",
    FacilityId = new Guid("000002ee-0000-0000-0000-000000000000"),
};

try
{
    Guid? result = await buildingController.BuildingCreateAsync(body);
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

