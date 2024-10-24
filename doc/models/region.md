
# Region

## Structure

`Region`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `GeometryWKT` | `string` | Optional | - |
| `Category` | [`Category2Enum`](../../doc/models/category-2-enum.md) | Required | - |
| `Features` | [`List<RegionFeature>`](../../doc/models/region-feature.md) | Optional | - |
| `ParentId` | `Guid?` | Optional | - |

## Example (as JSON)

```json
{
  "id": "00000b18-0000-0000-0000-000000000000",
  "name": "name0",
  "geometryWKT": "geometryWKT0",
  "category": "entrance",
  "features": [
    {
      "id": "00001eae-0000-0000-0000-000000000000",
      "name": "name4",
      "geometryWKT": "geometryWKT6",
      "category": "opportunity_area"
    }
  ],
  "parentId": "0000078a-0000-0000-0000-000000000000"
}
```

