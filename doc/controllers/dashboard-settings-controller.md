# Dashboard-Settings-Controller

```csharp
DashboardSettingsController dashboardSettingsController = client.DashboardSettingsController;
```

## Class Name

`DashboardSettingsController`

## Methods

* [Dashboard Settings Get](../../doc/controllers/dashboard-settings-controller.md#dashboard-settings-get)
* [Dashboard Settings Set](../../doc/controllers/dashboard-settings-controller.md#dashboard-settings-set)
* [Dashboard Settings Delete](../../doc/controllers/dashboard-settings-controller.md#dashboard-settings-delete)


# Dashboard Settings Get

```csharp
DashboardSettingsGetAsync(
    Guid facilityId,
    string dashboardId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `facilityId` | `Guid` | Template, Required | - |
| `dashboardId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.DashboardSettingsResponse>`](../../doc/models/dashboard-settings-response.md)

## Example Usage

```csharp
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
string dashboardId = "dashboardId2";
try
{
    DashboardSettingsResponse result = await dashboardSettingsController.DashboardSettingsGetAsync(
        facilityId,
        dashboardId
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


# Dashboard Settings Set

```csharp
DashboardSettingsSetAsync(
    Guid facilityId,
    string dashboardId,
    Models.DashboardSettingsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `facilityId` | `Guid` | Template, Required | - |
| `dashboardId` | `string` | Template, Required | - |
| `body` | [`DashboardSettingsRequest`](../../doc/models/dashboard-settings-request.md) | Body, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
string dashboardId = "dashboardId2";
DashboardSettingsRequest body = new DashboardSettingsRequest
{
    MValue = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};

try
{
    await dashboardSettingsController.DashboardSettingsSetAsync(
        facilityId,
        dashboardId,
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


# Dashboard Settings Delete

```csharp
DashboardSettingsDeleteAsync(
    Guid facilityId,
    string dashboardId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `facilityId` | `Guid` | Template, Required | - |
| `dashboardId` | `string` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid facilityId = new Guid("00000b0a-0000-0000-0000-000000000000");
string dashboardId = "dashboardId2";
try
{
    await dashboardSettingsController.DashboardSettingsDeleteAsync(
        facilityId,
        dashboardId
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

