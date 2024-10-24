
# Building

## Structure

`Building`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Floors` | [`List<Floor>`](../../doc/models/floor.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "00001c9a-0000-0000-0000-000000000000",
  "name": "name2",
  "floors": [
    {
      "id": "00001ee2-0000-0000-0000-000000000000",
      "level": 52,
      "commonAreaWKT": "commonAreaWKT8",
      "wholeFloorWKT": "wholeFloorWKT6",
      "bottomLimit": 85.32,
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
        }
      ]
    }
  ]
}
```

