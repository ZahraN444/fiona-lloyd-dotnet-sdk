
# Floor

## Structure

`Floor`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Level` | `int?` | Optional | - |
| `CommonAreaWKT` | `string` | Optional | - |
| `WholeFloorWKT` | `string` | Optional | - |
| `BottomLimit` | `double` | Required | - |
| `Regions` | [`List<Region>`](../../doc/models/region.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "0000027a-0000-0000-0000-000000000000",
  "level": 84,
  "commonAreaWKT": "commonAreaWKT4",
  "wholeFloorWKT": "wholeFloorWKT8",
  "bottomLimit": 187.4,
  "regions": [
    {
      "id": "00000866-0000-0000-0000-000000000000",
      "name": "name0",
      "geometryWKT": "geometryWKT0",
      "category": "whole_facility",
      "features": [
        {
          "id": "00001eae-0000-0000-0000-000000000000",
          "name": "name4",
          "geometryWKT": "geometryWKT6",
          "category": "opportunity_area"
        }
      ],
      "parentId": "00000a3c-0000-0000-0000-000000000000"
    },
    {
      "id": "00000866-0000-0000-0000-000000000000",
      "name": "name0",
      "geometryWKT": "geometryWKT0",
      "category": "whole_facility",
      "features": [
        {
          "id": "00001eae-0000-0000-0000-000000000000",
          "name": "name4",
          "geometryWKT": "geometryWKT6",
          "category": "opportunity_area"
        }
      ],
      "parentId": "00000a3c-0000-0000-0000-000000000000"
    },
    {
      "id": "00000866-0000-0000-0000-000000000000",
      "name": "name0",
      "geometryWKT": "geometryWKT0",
      "category": "whole_facility",
      "features": [
        {
          "id": "00001eae-0000-0000-0000-000000000000",
          "name": "name4",
          "geometryWKT": "geometryWKT6",
          "category": "opportunity_area"
        }
      ],
      "parentId": "00000a3c-0000-0000-0000-000000000000"
    }
  ]
}
```

