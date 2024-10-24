# Batch-Controller

```csharp
BatchController batchController = client.BatchController;
```

## Class Name

`BatchController`

## Methods

* [Batch Search Batches](../../doc/controllers/batch-controller.md#batch-search-batches)
* [Batch Create Batch](../../doc/controllers/batch-controller.md#batch-create-batch)
* [Batch Get Batch](../../doc/controllers/batch-controller.md#batch-get-batch)


# Batch Search Batches

```csharp
BatchSearchBatchesAsync(
    int? page = 0,
    int? size = 20,
    List<string> sort = null,
    Guid? facilityId = null,
    DateTime? videoStartFrom = null,
    DateTime? videoStartTo = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |
| `facilityId` | `Guid?` | Query, Optional | - |
| `videoStartFrom` | `DateTime?` | Query, Optional | - |
| `videoStartTo` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.PageBatchListItemDto>`](../../doc/models/page-batch-list-item-dto.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageBatchListItemDto result = await batchController.BatchSearchBatchesAsync(
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


# Batch Create Batch

```csharp
BatchCreateBatchAsync(
    Models.BatchCreateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`BatchCreateRequest`](../../doc/models/batch-create-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
BatchCreateRequest body = new BatchCreateRequest
{
    Videos = new List<string>
    {
        "videos6",
    },
    RetainIntermediaryData = false,
};

try
{
    Guid? result = await batchController.BatchCreateBatchAsync(body);
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


# Batch Get Batch

```csharp
BatchGetBatchAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.BatchDto>`](../../doc/models/batch-dto.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    BatchDto result = await batchController.BatchGetBatchAsync(id);
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

