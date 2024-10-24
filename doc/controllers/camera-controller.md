# Camera-Controller

```csharp
CameraController cameraController = client.CameraController;
```

## Class Name

`CameraController`

## Methods

* [Camera Get](../../doc/controllers/camera-controller.md#camera-get)
* [Camera Update](../../doc/controllers/camera-controller.md#camera-update)
* [Camera Delete](../../doc/controllers/camera-controller.md#camera-delete)
* [Camera Get All](../../doc/controllers/camera-controller.md#camera-get-all)
* [Camera Create](../../doc/controllers/camera-controller.md#camera-create)


# Camera Get

```csharp
CameraGetAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.CameraResponse>`](../../doc/models/camera-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    CameraResponse result = await cameraController.CameraGetAsync(id);
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


# Camera Update

```csharp
CameraUpdateAsync(
    Guid id,
    Models.CameraRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `body` | [`CameraRequest`](../../doc/models/camera-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
CameraRequest body = new CameraRequest
{
    Name = "name6",
    Coordinates = CameraRequestCoordinates.FromLineRepresentation(
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
    FacilityId = new Guid("000002ee-0000-0000-0000-000000000000"),
};

try
{
    Guid? result = await cameraController.CameraUpdateAsync(
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


# Camera Delete

```csharp
CameraDeleteAsync(
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
    await cameraController.CameraDeleteAsync(id);
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


# Camera Get All

```csharp
CameraGetAllAsync(
    int? page = 0,
    int? size = 20,
    List<string> sort = null,
    Guid? facilityId = null,
    Guid? floorId = null,
    Guid? buildingId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |
| `facilityId` | `Guid?` | Query, Optional | - |
| `floorId` | `Guid?` | Query, Optional | - |
| `buildingId` | `Guid?` | Query, Optional | - |

## Response Type

[`Task<Models.PageCameraResponse>`](../../doc/models/page-camera-response.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageCameraResponse result = await cameraController.CameraGetAllAsync(
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


# Camera Create

```csharp
CameraCreateAsync(
    Models.CameraRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CameraRequest`](../../doc/models/camera-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
CameraRequest body = new CameraRequest
{
    Name = "name6",
    Coordinates = CameraRequestCoordinates.FromLineRepresentation(
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
    FacilityId = new Guid("000002ee-0000-0000-0000-000000000000"),
};

try
{
    Guid? result = await cameraController.CameraCreateAsync(body);
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

