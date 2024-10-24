
# Facility Response

## Structure

`FacilityResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Address` | `string` | Required | - |
| `Notes` | `string` | Optional | - |
| `ImageId` | `Guid?` | Optional | - |
| `CreatedAt` | `DateTime` | Required | - |
| `Timezone` | `string` | Required | - |
| `OperationHours` | [`OperationHours`](../../doc/models/operation-hours.md) | Required | - |
| `CalendarEmailAddress` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": "00000162-0000-0000-0000-000000000000",
  "name": "name4",
  "address": "address0",
  "notes": "notes4",
  "imageId": "00001430-0000-0000-0000-000000000000",
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
```

