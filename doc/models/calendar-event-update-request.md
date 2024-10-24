
# Calendar Event Update Request

## Structure

`CalendarEventUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FacilityId` | `Guid?` | Optional | - |
| `FloorId` | `Guid?` | Optional | - |
| `RegionId` | `Guid?` | Optional | - |
| `IsHiddenFromAnalytics` | `bool?` | Optional | - |
| `Notes` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Name` | `string` | Optional | - |
| `Recurrence` | `List<string>` | Optional | - |
| `FirstOccurrence` | `DateTime?` | Optional | - |
| `LastOccurrence` | `DateTime?` | Optional | - |
| `DurationSeconds` | `int?` | Optional | - |
| `Location` | [`CalendarEventUpdateRequestLocation`](../../doc/models/containers/calendar-event-update-request-location.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "facilityId": "00001834-0000-0000-0000-000000000000",
  "floorId": "00001fde-0000-0000-0000-000000000000",
  "regionId": "00000f56-0000-0000-0000-000000000000",
  "isHiddenFromAnalytics": false,
  "notes": "notes2"
}
```

