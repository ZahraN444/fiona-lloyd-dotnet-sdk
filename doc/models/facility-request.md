
# Facility Request

## Structure

`FacilityRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Address` | `string` | Required | - |
| `Notes` | `string` | Optional | - |
| `ImageId` | `Guid?` | Optional | - |
| `Timezone` | `string` | Required | - |
| `OperationHours` | [`OperationHours`](../../doc/models/operation-hours.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "address": "address6",
  "notes": "notes0",
  "imageId": "00000f36-0000-0000-0000-000000000000",
  "timezone": "timezone0",
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
  }
}
```

