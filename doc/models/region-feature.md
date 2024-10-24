
# Region Feature

## Structure

`RegionFeature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `GeometryWKT` | `string` | Optional | - |
| `Category` | [`Category3Enum`](../../doc/models/category-3-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "00001ba6-0000-0000-0000-000000000000",
  "name": "name8",
  "geometryWKT": "geometryWKT8",
  "category": "opportunity_area"
}
```

