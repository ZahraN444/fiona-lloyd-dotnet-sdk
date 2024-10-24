
# Calendar Event Create Request

## Structure

`CalendarEventCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FacilityId` | `Guid?` | Optional | - |
| `FloorId` | `Guid?` | Optional | - |
| `RegionId` | `Guid?` | Optional | - |
| `Name` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `Notes` | `string` | Optional | - |
| `Recurrence` | `List<string>` | Optional | - |
| `FirstOccurrence` | `DateTime` | Required | - |
| `LastOccurrence` | `DateTime?` | Optional | - |
| `DurationSeconds` | `int` | Required | - |
| `IsHiddenFromAnalytics` | `bool` | Required | - |
| `Location` | [`CalendarEventCreateRequestLocation`](../../doc/models/containers/calendar-event-create-request-location.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "facilityId": "00000fd4-0000-0000-0000-000000000000",
  "floorId": "0000177e-0000-0000-0000-000000000000",
  "regionId": "00000f5a-0000-0000-0000-000000000000",
  "name": "name8",
  "description": "description8",
  "notes": "notes8",
  "firstOccurrence": "2016-03-13T12:52:32.123Z",
  "durationSeconds": 132,
  "isHiddenFromAnalytics": false
}
```

