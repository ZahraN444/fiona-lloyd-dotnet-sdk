
# Dwell Time Response

## Structure

`DwellTimeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Entries` | [`List<DwellTimeResponseEntry>`](../../doc/models/dwell-time-response-entry.md) | Required | - |

## Example (as JSON)

```json
{
  "entries": [
    {
      "regionId": "00001d72-0000-0000-0000-000000000000",
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
      "visitorsWhoEntered": 26,
      "visitorsWhoEnteredFactor": 49.34,
      "totalVisitorsWhoWalkedPast": 104,
      "totalVisitorsWhoWalkedPastFactor": 188.44,
      "visitorsWhoDidNotEnter": 212,
      "visitorsWhoDidNotEnterFactor": 64.22,
      "conversionRate": 88.06,
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
  ]
}
```

