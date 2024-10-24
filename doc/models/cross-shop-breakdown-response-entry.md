
# Cross Shop Breakdown Response Entry

## Structure

`CrossShopBreakdownResponseEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstRegionId` | `Guid` | Required | - |
| `SecondRegionId` | `Guid` | Required | - |
| `CrossShopVisitors` | `long?` | Optional | - |
| `CrossShopVisitorsOppositeDirection` | `long?` | Optional | - |
| `CrossShopVisitorsBothDirections` | `long?` | Optional | - |
| `CrossShopVisitorsFactor` | `double` | Required | - |
| `CrossShopVisitorsOppositeDirectionFactor` | `double` | Required | - |
| `CrossShopVisitorsBothDirectionsFactor` | `double` | Required | - |

## Example (as JSON)

```json
{
  "firstRegionId": "00000980-0000-0000-0000-000000000000",
  "secondRegionId": "00001406-0000-0000-0000-000000000000",
  "crossShopVisitors": 210,
  "crossShopVisitorsOppositeDirection": 124,
  "crossShopVisitorsBothDirections": 190,
  "crossShopVisitorsFactor": 145.8,
  "crossShopVisitorsOppositeDirectionFactor": 10.16,
  "crossShopVisitorsBothDirectionsFactor": 73.44
}
```

