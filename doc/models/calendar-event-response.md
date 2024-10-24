
# Calendar Event Response

## Structure

`CalendarEventResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `FacilityId` | `Guid?` | Optional | - |
| `FloorId` | `Guid?` | Optional | - |
| `RegionId` | `Guid?` | Optional | - |
| `Name` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `Notes` | `string` | Optional | - |
| `IsRecurring` | `bool` | Required | - |
| `Recurrence` | `List<string>` | Optional | - |
| `FirstOccurrence` | `DateTime` | Required | - |
| `LastOccurrence` | `DateTime?` | Optional | - |
| `DurationSeconds` | `int` | Required | - |
| `IsHiddenFromAnalytics` | `bool` | Required | - |
| `IsFromExternalSource` | `bool` | Required | - |
| `Location` | [`CalendarEventResponseLocation`](../../doc/models/containers/calendar-event-response-location.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "id": "00000488-0000-0000-0000-000000000000",
  "createdAt": "2016-03-13T12:52:32.123Z",
  "facilityId": "0000091e-0000-0000-0000-000000000000",
  "floorId": "000010c8-0000-0000-0000-000000000000",
  "regionId": "00001e6c-0000-0000-0000-000000000000",
  "name": "name0",
  "description": "description0",
  "notes": "notes0",
  "isRecurring": false,
  "firstOccurrence": "2016-03-13T12:52:32.123Z",
  "durationSeconds": 158,
  "isHiddenFromAnalytics": false,
  "isFromExternalSource": false
}
```

