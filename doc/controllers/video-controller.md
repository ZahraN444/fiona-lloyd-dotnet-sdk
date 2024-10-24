# Video-Controller

```csharp
VideoController videoController = client.VideoController;
```

## Class Name

`VideoController`

## Methods

* [Video Search Videos](../../doc/controllers/video-controller.md#video-search-videos)
* [Video Get Video](../../doc/controllers/video-controller.md#video-get-video)
* [Video Get Video Stream Url](../../doc/controllers/video-controller.md#video-get-video-stream-url)
* [Video Get Videos for Batch by Camera](../../doc/controllers/video-controller.md#video-get-videos-for-batch-by-camera)


# Video Search Videos

```csharp
VideoSearchVideosAsync(
    int? page = 0,
    int? size = 20,
    List<string> sort = null,
    Guid? facilityId = null,
    string cameraId = null,
    Guid? batchId = null,
    DateTime? videoStartFrom = null,
    DateTime? videoStartTo = null,
    DateTime? videoEndFrom = null,
    DateTime? videoEndTo = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |
| `facilityId` | `Guid?` | Query, Optional | - |
| `cameraId` | `string` | Query, Optional | - |
| `batchId` | `Guid?` | Query, Optional | - |
| `videoStartFrom` | `DateTime?` | Query, Optional | - |
| `videoStartTo` | `DateTime?` | Query, Optional | - |
| `videoEndFrom` | `DateTime?` | Query, Optional | - |
| `videoEndTo` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.PageVideoMetadata>`](../../doc/models/page-video-metadata.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageVideoMetadata result = await videoController.VideoSearchVideosAsync(
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


# Video Get Video

```csharp
VideoGetVideoAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |

## Response Type

[`Task<Models.VideoMetadata>`](../../doc/models/video-metadata.md)

## Example Usage

```csharp
string id = "id0";
try
{
    VideoMetadata result = await videoController.VideoGetVideoAsync(id);
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


# Video Get Video Stream Url

```csharp
VideoGetVideoStreamUrlAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |

## Response Type

[`Task<Models.StorageAccessUrl>`](../../doc/models/storage-access-url.md)

## Example Usage

```csharp
string id = "id0";
try
{
    StorageAccessUrl result = await videoController.VideoGetVideoStreamUrlAsync(id);
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


# Video Get Videos for Batch by Camera

```csharp
VideoGetVideosForBatchByCameraAsync(
    Guid facilityId,
    DateTime videoStartFrom,
    DateTime videoStartTo)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `facilityId` | `Guid` | Query, Required | - |
| `videoStartFrom` | `DateTime` | Query, Required | - |
| `videoStartTo` | `DateTime` | Query, Required | - |

## Response Type

[`Task<List<Models.CameraVideoGroup>>`](../../doc/models/camera-video-group.md)

## Example Usage

```csharp
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
DateTime videoStartFrom = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
DateTime videoStartTo = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
try
{
    List<CameraVideoGroup> result = await videoController.VideoGetVideosForBatchByCameraAsync(
        facilityId,
        videoStartFrom,
        videoStartTo
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

