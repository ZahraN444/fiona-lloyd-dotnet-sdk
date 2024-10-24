# Floor-Feature-Controller

```csharp
FloorFeatureController floorFeatureController = client.FloorFeatureController;
```

## Class Name

`FloorFeatureController`

## Methods

* [Floor Feature Upload Lidar Asset](../../doc/controllers/floor-feature-controller.md#floor-feature-upload-lidar-asset)
* [Floor Feature Get Floor Plan Background](../../doc/controllers/floor-feature-controller.md#floor-feature-get-floor-plan-background)
* [Floor Feature Upload Background](../../doc/controllers/floor-feature-controller.md#floor-feature-upload-background)
* [Floor Feature Get by Id](../../doc/controllers/floor-feature-controller.md#floor-feature-get-by-id)
* [Floor Feature World File Data](../../doc/controllers/floor-feature-controller.md#floor-feature-world-file-data)
* [Floor Feature Get Lidar 2 D Scan](../../doc/controllers/floor-feature-controller.md#floor-feature-get-lidar-2-d-scan)


# Floor Feature Upload Lidar Asset

```csharp
FloorFeatureUploadLidarAssetAsync(
    Guid id,
    string worldFileContent,
    FileStreamInfo image)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `worldFileContent` | `string` | Form, Required | - |
| `image` | `FileStreamInfo` | Form, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
string worldFileContent = "worldFileContent6";
FileStreamInfo image = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    await floorFeatureController.FloorFeatureUploadLidarAssetAsync(
        id,
        worldFileContent,
        image
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


# Floor Feature Get Floor Plan Background

```csharp
FloorFeatureGetFloorPlanBackgroundAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    dynamic result = await floorFeatureController.FloorFeatureGetFloorPlanBackgroundAsync(id);
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


# Floor Feature Upload Background

```csharp
FloorFeatureUploadBackgroundAsync(
    Guid id,
    FileStreamInfo image)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `image` | `FileStreamInfo` | Form, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
FileStreamInfo image = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    await floorFeatureController.FloorFeatureUploadBackgroundAsync(
        id,
        image
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


# Floor Feature Get by Id

```csharp
FloorFeatureGetByIdAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.FloorFeatures>`](../../doc/models/floor-features.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    FloorFeatures result = await floorFeatureController.FloorFeatureGetByIdAsync(id);
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


# Floor Feature World File Data

```csharp
FloorFeatureWorldFileDataAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.WorldFile>`](../../doc/models/world-file.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    WorldFile result = await floorFeatureController.FloorFeatureWorldFileDataAsync(id);
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


# Floor Feature Get Lidar 2 D Scan

```csharp
FloorFeatureGetLidar2dScanAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    dynamic result = await floorFeatureController.FloorFeatureGetLidar2dScanAsync(id);
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

