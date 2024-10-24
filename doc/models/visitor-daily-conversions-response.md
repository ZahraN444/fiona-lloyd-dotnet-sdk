
# Visitor Daily Conversions Response

## Structure

`VisitorDailyConversionsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VisitorEntries` | [`List<VisitorDailyConversionsResponseEntry>`](../../doc/models/visitor-daily-conversions-response-entry.md) | Required | - |

## Example (as JSON)

```json
{
  "visitorEntries": [
    {
      "regionId": "000018b8-0000-0000-0000-000000000000",
      "localDate": "2016-03-13",
      "visitorsWhoEntered": 16,
      "visitorsWhoEnteredFactor": 188.0,
      "totalVisitorsWhoWalkedPast": 146,
      "totalVisitorsWhoWalkedPastFactor": 71.1,
      "visitorsWhoDidNotEnter": 170,
      "visitorsWhoDidNotEnterFactor": 202.88,
      "conversionRate": 205.4,
      "totalDayVisitors": 48,
      "totalDayVisitorsFactor": 107.94
    }
  ]
}
```

