# Campaign-Controller

```csharp
CampaignController campaignController = client.CampaignController;
```

## Class Name

`CampaignController`

## Methods

* [Campaign Get](../../doc/controllers/campaign-controller.md#campaign-get)
* [Campaign Update](../../doc/controllers/campaign-controller.md#campaign-update)
* [Campaign Delete](../../doc/controllers/campaign-controller.md#campaign-delete)
* [Campaign Get All](../../doc/controllers/campaign-controller.md#campaign-get-all)
* [Campaign Create](../../doc/controllers/campaign-controller.md#campaign-create)


# Campaign Get

```csharp
CampaignGetAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.CampaignResponse>`](../../doc/models/campaign-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    CampaignResponse result = await campaignController.CampaignGetAsync(id);
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


# Campaign Update

```csharp
CampaignUpdateAsync(
    Guid id,
    Models.CampaignRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `body` | [`CampaignRequest`](../../doc/models/campaign-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
CampaignRequest body = new CampaignRequest
{
    Name = "name6",
    StartDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    FacilityId = new Guid("000002ee-0000-0000-0000-000000000000"),
};

try
{
    Guid? result = await campaignController.CampaignUpdateAsync(
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


# Campaign Delete

```csharp
CampaignDeleteAsync(
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
    await campaignController.CampaignDeleteAsync(id);
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


# Campaign Get All

```csharp
CampaignGetAllAsync(
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

[`Task<Models.PageCampaignResponse>`](../../doc/models/page-campaign-response.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageCampaignResponse result = await campaignController.CampaignGetAllAsync(
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


# Campaign Create

```csharp
CampaignCreateAsync(
    Models.CampaignRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CampaignRequest`](../../doc/models/campaign-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
CampaignRequest body = new CampaignRequest
{
    Name = "name6",
    StartDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    FacilityId = new Guid("000002ee-0000-0000-0000-000000000000"),
};

try
{
    Guid? result = await campaignController.CampaignCreateAsync(body);
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

