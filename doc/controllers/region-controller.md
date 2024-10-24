# Region-Controller

```csharp
RegionController regionController = client.RegionController;
```

## Class Name

`RegionController`

## Methods

* [Region Get](../../doc/controllers/region-controller.md#region-get)
* [Region Update](../../doc/controllers/region-controller.md#region-update)
* [Region Delete](../../doc/controllers/region-controller.md#region-delete)
* [Region Get All](../../doc/controllers/region-controller.md#region-get-all)
* [Region Create](../../doc/controllers/region-controller.md#region-create)
* [Region Search by Naics](../../doc/controllers/region-controller.md#region-search-by-naics)
* [Region Export](../../doc/controllers/region-controller.md#region-export)


# Region Get

```csharp
RegionGetAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.RegionResponse>`](../../doc/models/region-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    RegionResponse result = await regionController.RegionGetAsync(id);
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


# Region Update

```csharp
RegionUpdateAsync(
    Guid id,
    Models.RegionRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `body` | [`RegionRequest`](../../doc/models/region-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
RegionRequest body = new RegionRequest
{
    Name = "name6",
    FacilityId = new Guid("000002ee-0000-0000-0000-000000000000"),
    Category = CategoryEnum.STOREMULTIFLOOR,
    Disabled = false,
};

try
{
    Guid? result = await regionController.RegionUpdateAsync(
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


# Region Delete

```csharp
RegionDeleteAsync(
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
    await regionController.RegionDeleteAsync(id);
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


# Region Get All

```csharp
RegionGetAllAsync(
    int? page = 0,
    int? size = 20,
    List<string> sort = null,
    Guid? floorId = null,
    Guid? facilityId = null,
    List<Models.CategoryEnum> category = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |
| `floorId` | `Guid?` | Query, Optional | - |
| `facilityId` | `Guid?` | Query, Optional | - |
| `category` | [`List<CategoryEnum>`](../../doc/models/category-enum.md) | Query, Optional | - |

## Response Type

[`Task<Models.PageRegionResponse>`](../../doc/models/page-region-response.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageRegionResponse result = await regionController.RegionGetAllAsync(
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


# Region Create

```csharp
RegionCreateAsync(
    Models.RegionRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`RegionRequest`](../../doc/models/region-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
RegionRequest body = new RegionRequest
{
    Name = "name6",
    FacilityId = new Guid("000002ee-0000-0000-0000-000000000000"),
    Category = CategoryEnum.STOREMULTIFLOOR,
    Disabled = false,
};

try
{
    Guid? result = await regionController.RegionCreateAsync(body);
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


# Region Search by Naics

```csharp
RegionSearchByNaicsAsync(
    Guid facilityId,
    string naicsPrefix)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `facilityId` | `Guid` | Template, Required | - |
| `naicsPrefix` | `string` | Query, Required | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `6`, *Pattern*: `^[1-9]+0*$` |

## Response Type

`Task<List<Guid>>`

## Example Usage

```csharp
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
string naicsPrefix = "naicsPrefix6";
try
{
    List<Guid> result = await regionController.RegionSearchByNaicsAsync(
        facilityId,
        naicsPrefix
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


# Region Export

```csharp
RegionExportAsync()
```

## Response Type

[`Task<List<Models.RegionExportItem>>`](../../doc/models/region-export-item.md)

## Example Usage

```csharp
try
{
    List<RegionExportItem> result = await regionController.RegionExportAsync();
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

