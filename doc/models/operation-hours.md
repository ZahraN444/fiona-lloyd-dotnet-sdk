
# Operation Hours

## Structure

`OperationHours`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Monday` | [`DailyOperationHours`](../../doc/models/daily-operation-hours.md) | Required | - |
| `Tuesday` | [`DailyOperationHours`](../../doc/models/daily-operation-hours.md) | Required | - |
| `Wednesday` | [`DailyOperationHours`](../../doc/models/daily-operation-hours.md) | Required | - |
| `Thursday` | [`DailyOperationHours`](../../doc/models/daily-operation-hours.md) | Required | - |
| `Friday` | [`DailyOperationHours`](../../doc/models/daily-operation-hours.md) | Required | - |
| `Saturday` | [`DailyOperationHours`](../../doc/models/daily-operation-hours.md) | Required | - |
| `Sunday` | [`DailyOperationHours`](../../doc/models/daily-operation-hours.md) | Required | - |

## Example (as JSON)

```json
{
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
```

