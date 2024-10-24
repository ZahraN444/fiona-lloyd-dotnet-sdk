
# Page Facility Response

## Structure

`PageFacilityResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<FacilityResponse>`](../../doc/models/facility-response.md) | Optional | - |
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
  "totalPages": 72,
  "totalElements": 84,
  "size": 8,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "address": "address0",
      "notes": "notes4",
      "imageId": "00000a62-0000-0000-0000-000000000000",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "timezone": "timezone6",
      "operationHours": {
        "monday": {
          "isOpen": false,
          "startLocalHour": "2016-03-13T12:52:32.123Z",
          "endLocalHour": "2016-03-13T12:52:32.123Z"
        },
        "tuesday": {
          "isOpen": false,
          "startLocalHour": "2016-03-13T12:52:32.123Z",
          "endLocalHour": "2016-03-13T12:52:32.123Z"
        },
        "wednesday": {
          "isOpen": false,
          "startLocalHour": "2016-03-13T12:52:32.123Z",
          "endLocalHour": "2016-03-13T12:52:32.123Z"
        },
        "thursday": {
          "isOpen": false,
          "startLocalHour": "2016-03-13T12:52:32.123Z",
          "endLocalHour": "2016-03-13T12:52:32.123Z"
        },
        "friday": {
          "isOpen": false,
          "startLocalHour": "2016-03-13T12:52:32.123Z",
          "endLocalHour": "2016-03-13T12:52:32.123Z"
        },
        "saturday": {
          "isOpen": false,
          "startLocalHour": "2016-03-13T12:52:32.123Z",
          "endLocalHour": "2016-03-13T12:52:32.123Z"
        },
        "sunday": {
          "isOpen": false,
          "startLocalHour": "2016-03-13T12:52:32.123Z",
          "endLocalHour": "2016-03-13T12:52:32.123Z"
        }
      },
      "calendarEmailAddress": "calendarEmailAddress4"
    }
  ],
  "number": 124
}
```

