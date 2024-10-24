
# Visitor Daily Conversions Response Entry

## Structure

`VisitorDailyConversionsResponseEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegionId` | `Guid` | Required | - |
| `LocalDate` | `DateTime` | Required | - |
| `VisitorsWhoEntered` | `long?` | Optional | - |
| `VisitorsWhoEnteredFactor` | `double` | Required | - |
| `TotalVisitorsWhoWalkedPast` | `long?` | Optional | - |
| `TotalVisitorsWhoWalkedPastFactor` | `double` | Required | - |
| `VisitorsWhoDidNotEnter` | `long?` | Optional | - |
| `VisitorsWhoDidNotEnterFactor` | `double` | Required | - |
| `ConversionRate` | `double` | Required | - |
| `TotalDayVisitors` | `long?` | Optional | - |
| `TotalDayVisitorsFactor` | `double` | Required | - |

## Example (as JSON)

```json
{
  "regionId": "00000786-0000-0000-0000-000000000000",
  "localDate": "2016-03-13",
  "visitorsWhoEntered": 254,
  "visitorsWhoEnteredFactor": 87.98,
  "totalVisitorsWhoWalkedPast": 128,
  "totalVisitorsWhoWalkedPastFactor": 227.08,
  "visitorsWhoDidNotEnter": 68,
  "visitorsWhoDidNotEnterFactor": 102.86,
  "conversionRate": 49.42,
  "totalDayVisitors": 30,
  "totalDayVisitorsFactor": 7.92
}
```

