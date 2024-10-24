
# Cross Shop Breakdown Response

## Structure

`CrossShopBreakdownResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VisitorEntries` | [`List<CrossShopBreakdownResponseEntry>`](../../doc/models/cross-shop-breakdown-response-entry.md) | Required | - |

## Example (as JSON)

```json
{
  "visitorEntries": [
    {
      "firstRegionId": "00001150-0000-0000-0000-000000000000",
      "secondRegionId": "000007c6-0000-0000-0000-000000000000",
      "crossShopVisitors": 194,
      "crossShopVisitorsOppositeDirection": 108,
      "crossShopVisitorsBothDirections": 174,
      "crossShopVisitorsFactor": 158.44,
      "crossShopVisitorsOppositeDirectionFactor": 22.8,
      "crossShopVisitorsBothDirectionsFactor": 60.8
    }
  ]
}
```

