
# Calendar Event Occurrence Response

## Structure

`CalendarEventOccurrenceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EventId` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `IsRecurring` | `bool` | Required | - |
| `TimeStart` | `DateTime` | Required | - |
| `TimeEnd` | `DateTime` | Required | - |

## Example (as JSON)

```json
{
  "eventId": "000006b6-0000-0000-0000-000000000000",
  "name": "name0",
  "description": "description0",
  "isRecurring": false,
  "timeStart": "2016-03-13T12:52:32.123Z",
  "timeEnd": "2016-03-13T12:52:32.123Z"
}
```

