# Advertisement-Controller

```csharp
AdvertisementController advertisementController = client.AdvertisementController;
```

## Class Name

`AdvertisementController`

## Methods

* [Advertisement Get](../../doc/controllers/advertisement-controller.md#advertisement-get)
* [Advertisement Update](../../doc/controllers/advertisement-controller.md#advertisement-update)
* [Advertisement Delete](../../doc/controllers/advertisement-controller.md#advertisement-delete)
* [Advertisement Get All](../../doc/controllers/advertisement-controller.md#advertisement-get-all)
* [Advertisement Create](../../doc/controllers/advertisement-controller.md#advertisement-create)
* [Advertisement Get All Campaign Advertisements](../../doc/controllers/advertisement-controller.md#advertisement-get-all-campaign-advertisements)


# Advertisement Get

```csharp
AdvertisementGetAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.AdvertisementResponse>`](../../doc/models/advertisement-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    AdvertisementResponse result = await advertisementController.AdvertisementGetAsync(id);
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


# Advertisement Update

```csharp
AdvertisementUpdateAsync(
    Guid id,
    Models.AdvertisementRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `body` | [`AdvertisementRequest`](../../doc/models/advertisement-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
AdvertisementRequest body = new AdvertisementRequest
{
    Name = "name6",
    FacilityId = new Guid("000002ee-0000-0000-0000-000000000000"),
};

try
{
    Guid? result = await advertisementController.AdvertisementUpdateAsync(
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


# Advertisement Delete

```csharp
AdvertisementDeleteAsync(
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
    await advertisementController.AdvertisementDeleteAsync(id);
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


# Advertisement Get All

```csharp
AdvertisementGetAllAsync(
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

[`Task<Models.PageAdvertisementResponse>`](../../doc/models/page-advertisement-response.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageAdvertisementResponse result = await advertisementController.AdvertisementGetAllAsync(
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


# Advertisement Create

```csharp
AdvertisementCreateAsync(
    Models.AdvertisementRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AdvertisementRequest`](../../doc/models/advertisement-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
AdvertisementRequest body = new AdvertisementRequest
{
    Name = "name6",
    FacilityId = new Guid("000002ee-0000-0000-0000-000000000000"),
};

try
{
    Guid? result = await advertisementController.AdvertisementCreateAsync(body);
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


# Advertisement Get All Campaign Advertisements

```csharp
AdvertisementGetAllCampaignAdvertisementsAsync(
    Guid campaignId,
    DateTime startDay,
    DateTime endDay)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `campaignId` | `Guid` | Template, Required | - |
| `startDay` | `DateTime` | Query, Required | - |
| `endDay` | `DateTime` | Query, Required | - |

## Response Type

[`Task<List<Models.AdvertisementResponse>>`](../../doc/models/advertisement-response.md)

## Example Usage

```csharp
Guid campaignId = new Guid("000026a2-0000-0000-0000-000000000000");
DateTime startDay = DateTime.Parse("2016-03-13");
DateTime endDay = DateTime.Parse("2016-03-13");
try
{
    List<AdvertisementResponse> result = await advertisementController.AdvertisementGetAllCampaignAdvertisementsAsync(
        campaignId,
        startDay,
        endDay
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

