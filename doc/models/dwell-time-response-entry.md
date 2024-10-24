
# Dwell Time Response Entry

## Structure

`DwellTimeResponseEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegionId` | `Guid` | Required | - |
| `MinDwellDuration` | [`ConditionalDataString2`](../../doc/models/containers/conditional-data-string-2.md) | Required | - |
| `MaxDwellDuration` | [`ConditionalDataString2`](../../doc/models/containers/conditional-data-string-2.md) | Required | - |
| `VisitorsWhoEntered` | `long?` | Optional | - |
| `VisitorsWhoEnteredFactor` | `double` | Required | - |
| `TotalVisitorsWhoWalkedPast` | `long?` | Optional | - |
| `TotalVisitorsWhoWalkedPastFactor` | `double` | Required | - |
| `VisitorsWhoDidNotEnter` | `long?` | Optional | - |
| `VisitorsWhoDidNotEnterFactor` | `double` | Required | - |
| `ConversionRate` | `double` | Required | - |
| `TotalDwellDuration` | [`ConditionalDataString2`](../../doc/models/containers/conditional-data-string-2.md) | Required | - |
| `MeanDwellDuration` | [`ConditionalDataString2`](../../doc/models/containers/conditional-data-string-2.md) | Required | - |

## Example (as JSON)

```json
{
  "regionId": "000012a6-0000-0000-0000-000000000000",
  "minDwellDuration": {
    "data": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "maxDwellDuration": {
    "data": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "visitorsWhoEntered": 94,
  "visitorsWhoEnteredFactor": 232.98,
  "totalVisitorsWhoWalkedPast": 36,
  "totalVisitorsWhoWalkedPastFactor": 116.08,
  "visitorsWhoDidNotEnter": 24,
  "visitorsWhoDidNotEnterFactor": 247.86,
  "conversionRate": 160.42,
  "totalDwellDuration": {
    "data": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "meanDwellDuration": {
    "data": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

