# Campaign-Details-Controller

```csharp
CampaignDetailsController campaignDetailsController = client.CampaignDetailsController;
```

## Class Name

`CampaignDetailsController`

## Methods

* [Campaign Details Update](../../doc/controllers/campaign-details-controller.md#campaign-details-update)
* [Campaign Details Get All](../../doc/controllers/campaign-details-controller.md#campaign-details-get-all)
* [Campaign Details Create](../../doc/controllers/campaign-details-controller.md#campaign-details-create)
* [Campaign Details Get](../../doc/controllers/campaign-details-controller.md#campaign-details-get)
* [Campaign Details Delete](../../doc/controllers/campaign-details-controller.md#campaign-details-delete)


# Campaign Details Update

```csharp
CampaignDetailsUpdateAsync(
    Guid campaignId,
    Guid id,
    Models.CampaignDetailsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `campaignId` | `Guid` | Template, Required | - |
| `id` | `Guid` | Template, Required | - |
| `body` | [`CampaignDetailsRequest`](../../doc/models/campaign-details-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid campaignId = new Guid("000026a2-0000-0000-0000-000000000000");
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
CampaignDetailsRequest body = new CampaignDetailsRequest
{
    Name = "name6",
    AdvertisementId = new Guid("00000362-0000-0000-0000-000000000000"),
    AdSignage = new Guid("0000261c-0000-0000-0000-000000000000"),
    CampaignId = new Guid("000018aa-0000-0000-0000-000000000000"),
    StartDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ShareOfVoice = 60.82,
    SecondsOfRotation = 80,
    SecondsOfShare = 202,
};

try
{
    Guid? result = await campaignDetailsController.CampaignDetailsUpdateAsync(
        campaignId,
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


# Campaign Details Get All

```csharp
CampaignDetailsGetAllAsync(
    Guid campaignId,
    int? page = 0,
    int? size = 20,
    List<string> sort = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `campaignId` | `Guid` | Template, Required | - |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |

## Response Type

[`Task<Models.PageCampaignDetailsResponse>`](../../doc/models/page-campaign-details-response.md)

## Example Usage

```csharp
Guid campaignId = new Guid("000026a2-0000-0000-0000-000000000000");
int? page = 0;
int? size = 20;
try
{
    PageCampaignDetailsResponse result = await campaignDetailsController.CampaignDetailsGetAllAsync(
        campaignId,
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


# Campaign Details Create

```csharp
CampaignDetailsCreateAsync(
    Guid campaignId,
    Models.CampaignDetailsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `campaignId` | `Guid` | Template, Required | - |
| `body` | [`CampaignDetailsRequest`](../../doc/models/campaign-details-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid campaignId = new Guid("000026a2-0000-0000-0000-000000000000");
CampaignDetailsRequest body = new CampaignDetailsRequest
{
    Name = "name6",
    AdvertisementId = new Guid("00000362-0000-0000-0000-000000000000"),
    AdSignage = new Guid("0000261c-0000-0000-0000-000000000000"),
    CampaignId = new Guid("000018aa-0000-0000-0000-000000000000"),
    StartDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ShareOfVoice = 60.82,
    SecondsOfRotation = 80,
    SecondsOfShare = 202,
};

try
{
    Guid? result = await campaignDetailsController.CampaignDetailsCreateAsync(
        campaignId,
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


# Campaign Details Get

```csharp
CampaignDetailsGetAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.CampaignDetailsResponse>`](../../doc/models/campaign-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    CampaignDetailsResponse result = await campaignDetailsController.CampaignDetailsGetAsync(id);
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


# Campaign Details Delete

```csharp
CampaignDetailsDeleteAsync(
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
    await campaignDetailsController.CampaignDetailsDeleteAsync(id);
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

