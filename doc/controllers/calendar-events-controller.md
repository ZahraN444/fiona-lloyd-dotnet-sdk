# Calendar-Events-Controller

```csharp
CalendarEventsController calendarEventsController = client.CalendarEventsController;
```

## Class Name

`CalendarEventsController`

## Methods

* [Calendar Events Get Single Event](../../doc/controllers/calendar-events-controller.md#calendar-events-get-single-event)
* [Calendar Events Update Event](../../doc/controllers/calendar-events-controller.md#calendar-events-update-event)
* [Calendar Events Get Events](../../doc/controllers/calendar-events-controller.md#calendar-events-get-events)
* [Calendar Events Create Event](../../doc/controllers/calendar-events-controller.md#calendar-events-create-event)
* [Calendar Events Get Occurrences](../../doc/controllers/calendar-events-controller.md#calendar-events-get-occurrences)


# Calendar Events Get Single Event

```csharp
CalendarEventsGetSingleEventAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.CalendarEventResponse>`](../../doc/models/calendar-event-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    CalendarEventResponse result = await calendarEventsController.CalendarEventsGetSingleEventAsync(id);
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


# Calendar Events Update Event

```csharp
CalendarEventsUpdateEventAsync(
    Guid id,
    Models.CalendarEventUpdateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |
| `body` | [`CalendarEventUpdateRequest`](../../doc/models/calendar-event-update-request.md) | Body, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
CalendarEventUpdateRequest body = new CalendarEventUpdateRequest
{
};

try
{
    Guid? result = await calendarEventsController.CalendarEventsUpdateEventAsync(
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


# Calendar Events Get Events

```csharp
CalendarEventsGetEventsAsync(
    Guid? regionId = null,
    Guid? floorId = null,
    Guid? facilityId = null,
    DateTime? startDate = null,
    DateTime? endDate = null,
    bool? showHiddenEvents = null,
    int? page = 0,
    int? size = 20,
    List<string> sort = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `regionId` | `Guid?` | Query, Optional | - |
| `floorId` | `Guid?` | Query, Optional | - |
| `facilityId` | `Guid?` | Query, Optional | - |
| `startDate` | `DateTime?` | Query, Optional | - |
| `endDate` | `DateTime?` | Query, Optional | - |
| `showHiddenEvents` | `bool?` | Query, Optional | - |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |

## Response Type

[`Task<Models.PageCalendarEventResponse>`](../../doc/models/page-calendar-event-response.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageCalendarEventResponse result = await calendarEventsController.CalendarEventsGetEventsAsync(
        null,
        null,
        null,
        null,
        null,
        null,
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


# Calendar Events Create Event

```csharp
CalendarEventsCreateEventAsync(
    Models.CalendarEventCreateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CalendarEventCreateRequest`](../../doc/models/calendar-event-create-request.md) | Body, Required | - |

## Response Type

[`Task<Models.CalendarEventResponse>`](../../doc/models/calendar-event-response.md)

## Example Usage

```csharp
CalendarEventCreateRequest body = new CalendarEventCreateRequest
{
    Name = "name6",
    FirstOccurrence = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    DurationSeconds = 94,
    IsHiddenFromAnalytics = false,
};

try
{
    CalendarEventResponse result = await calendarEventsController.CalendarEventsCreateEventAsync(body);
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


# Calendar Events Get Occurrences

```csharp
CalendarEventsGetOccurrencesAsync(
    Guid? regionId = null,
    Guid? floorId = null,
    Guid? facilityId = null,
    DateTime? startDate = null,
    DateTime? endDate = null,
    bool? showHiddenEvents = null,
    int? page = 0,
    int? size = 20,
    List<string> sort = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `regionId` | `Guid?` | Query, Optional | - |
| `floorId` | `Guid?` | Query, Optional | - |
| `facilityId` | `Guid?` | Query, Optional | - |
| `startDate` | `DateTime?` | Query, Optional | - |
| `endDate` | `DateTime?` | Query, Optional | - |
| `showHiddenEvents` | `bool?` | Query, Optional | - |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |

## Response Type

[`Task<Models.PageCalendarEventOccurrenceResponse>`](../../doc/models/page-calendar-event-occurrence-response.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageCalendarEventOccurrenceResponse result = await calendarEventsController.CalendarEventsGetOccurrencesAsync(
        null,
        null,
        null,
        null,
        null,
        null,
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

