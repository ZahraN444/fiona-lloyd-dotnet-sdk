
# Page Calendar Event Occurrence Response

## Structure

`PageCalendarEventOccurrenceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<CalendarEventOccurrenceResponse>`](../../doc/models/calendar-event-occurrence-response.md) | Optional | - |
| `Number` | `int?` | Optional | - |
| `Sort` | [`SortObject`](../../doc/models/sort-object.md) | Optional | - |
| `NumberOfElements` | `int?` | Optional | - |
| `Pageable` | [`PageableObject`](../../doc/models/pageable-object.md) | Optional | - |
| `First` | `bool?` | Optional | - |
| `Last` | `bool?` | Optional | - |
| `Empty` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "totalPages": 68,
  "totalElements": 88,
  "size": 12,
  "content": [
    {
      "eventId": "00001206-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "isRecurring": false,
      "timeStart": "2016-03-13T12:52:32.123Z",
      "timeEnd": "2016-03-13T12:52:32.123Z"
    },
    {
      "eventId": "00001206-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "isRecurring": false,
      "timeStart": "2016-03-13T12:52:32.123Z",
      "timeEnd": "2016-03-13T12:52:32.123Z"
    }
  ],
  "number": 128
}
```

