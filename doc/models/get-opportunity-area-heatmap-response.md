
# Get Opportunity Area Heatmap Response

## Structure

`GetOpportunityAreaHeatmapResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OpportunityAreaHeatmapsEntries` | [`List<GetOpportunityAreaHeatmapResponseEntry>`](../../doc/models/get-opportunity-area-heatmap-response-entry.md) | Required | - |

## Example (as JSON)

```json
{
  "opportunityAreaHeatmapsEntries": [
    {
      "regionUuid": "00000426-0000-0000-0000-000000000000",
      "footTrafficSum": 56,
      "footTrafficMax": 0,
      "footTrafficMin": 180,
      "footTrafficMean": 207.48,
      "footTrafficFactor": 19.08
    }
  ]
}
```

