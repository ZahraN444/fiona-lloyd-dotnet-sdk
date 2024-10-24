
# Page Calendar Event Response

## Structure

`PageCalendarEventResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<CalendarEventResponse>`](../../doc/models/calendar-event-response.md) | Optional | - |
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
  "totalPages": 234,
  "totalElements": 178,
  "size": 154,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "facilityId": "000003d6-0000-0000-0000-000000000000",
      "floorId": "000003d4-0000-0000-0000-000000000000",
      "regionId": "00000450-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "notes": "notes4",
      "isRecurring": false,
      "firstOccurrence": "2016-03-13T12:52:32.123Z",
      "durationSeconds": 138,
      "isHiddenFromAnalytics": false,
      "isFromExternalSource": false
    },
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "facilityId": "000003d6-0000-0000-0000-000000000000",
      "floorId": "000003d4-0000-0000-0000-000000000000",
      "regionId": "00000450-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "notes": "notes4",
      "isRecurring": false,
      "firstOccurrence": "2016-03-13T12:52:32.123Z",
      "durationSeconds": 138,
      "isHiddenFromAnalytics": false,
      "isFromExternalSource": false
    }
  ],
  "number": 38
}
```

