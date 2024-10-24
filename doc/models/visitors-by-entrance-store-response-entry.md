
# Visitors by Entrance Store Response Entry

## Structure

`VisitorsByEntranceStoreResponseEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegionId` | `Guid` | Required | - |
| `TotalVisitorsByEntrance` | `long?` | Optional | - |
| `VisitorsFactor` | `double` | Required | - |
| `TopPeakDay` | `DateTime` | Required | - |
| `TopPeakHour` | `int` | Required | - |
| `TopPeakVisitors` | `long?` | Optional | - |
| `TopPeakVisitorsFactor` | `double` | Required | - |

## Example (as JSON)

```json
{
  "regionId": "00002006-0000-0000-0000-000000000000",
  "totalVisitorsByEntrance": 22,
  "visitorsFactor": 58.16,
  "topPeakDay": "2016-03-13",
  "topPeakHour": 186,
  "topPeakVisitors": 144,
  "topPeakVisitorsFactor": 70.98
}
```

