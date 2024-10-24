
# Get Opportunity Area Heatmap Response Entry

## Structure

`GetOpportunityAreaHeatmapResponseEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegionUuid` | `Guid` | Required | - |
| `FootTrafficSum` | `int?` | Optional | - |
| `FootTrafficMax` | `int?` | Optional | - |
| `FootTrafficMin` | `int?` | Optional | - |
| `FootTrafficMean` | `double?` | Optional | - |
| `FootTrafficFactor` | `double` | Required | - |

## Example (as JSON)

```json
{
  "regionUuid": "000006b0-0000-0000-0000-000000000000",
  "footTrafficSum": 226,
  "footTrafficMax": 170,
  "footTrafficMin": 94,
  "footTrafficMean": 157.98,
  "footTrafficFactor": 225.58
}
```

