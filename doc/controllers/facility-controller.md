# Facility-Controller

```csharp
FacilityController facilityController = client.FacilityController;
```

## Class Name

`FacilityController`

## Methods

* [Facility Get](../../doc/controllers/facility-controller.md#facility-get)
* [Facility Update](../../doc/controllers/facility-controller.md#facility-update)
* [Facility Delete](../../doc/controllers/facility-controller.md#facility-delete)
* [Facility Get All](../../doc/controllers/facility-controller.md#facility-get-all)
* [Facility Create](../../doc/controllers/facility-controller.md#facility-create)
* [Facility Snapshot](../../doc/controllers/facility-controller.md#facility-snapshot)


# Facility Get

```csharp
FacilityGetAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.FacilityResponse>`](../../doc/models/facility-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    FacilityResponse result = await facilityController.FacilityGetAsync(id);
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


# Facility Update

```csharp
FacilityUpdateAsync(
    Guid id,
    Models.FacilityRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `body` | [`FacilityRequest`](../../doc/models/facility-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
FacilityRequest body = new FacilityRequest
{
    Name = "name6",
    Address = "address2",
    Timezone = "timezone4",
    OperationHours = new OperationHours
    {
        Monday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Tuesday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Wednesday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Thursday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Friday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Saturday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Sunday = new DailyOperationHours
        {
            IsOpen = false,
        },
    },
};

try
{
    Guid? result = await facilityController.FacilityUpdateAsync(
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


# Facility Delete

```csharp
FacilityDeleteAsync(
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
    await facilityController.FacilityDeleteAsync(id);
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


# Facility Get All

```csharp
FacilityGetAllAsync(
    int? page = 0,
    int? size = 20,
    List<string> sort = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |

## Response Type

[`Task<Models.PageFacilityResponse>`](../../doc/models/page-facility-response.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageFacilityResponse result = await facilityController.FacilityGetAllAsync(
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


# Facility Create

```csharp
FacilityCreateAsync(
    Models.FacilityRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`FacilityRequest`](../../doc/models/facility-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
FacilityRequest body = new FacilityRequest
{
    Name = "name6",
    Address = "address2",
    Timezone = "timezone4",
    OperationHours = new OperationHours
    {
        Monday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Tuesday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Wednesday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Thursday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Friday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Saturday = new DailyOperationHours
        {
            IsOpen = false,
        },
        Sunday = new DailyOperationHours
        {
            IsOpen = false,
        },
    },
};

try
{
    Guid? result = await facilityController.FacilityCreateAsync(body);
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


# Facility Snapshot

```csharp
FacilitySnapshotAsync(
    Guid id,
    DateTime snapshotDate)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `snapshotDate` | `DateTime` | Query, Required | - |

## Response Type

[`Task<Models.Facility>`](../../doc/models/facility.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
DateTime snapshotDate = DateTime.Parse("2016-03-13");
try
{
    Facility result = await facilityController.FacilitySnapshotAsync(
        id,
        snapshotDate
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

