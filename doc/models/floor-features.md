
# Floor Features

## Structure

`FloorFeatures`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FloorId` | `Guid?` | Optional | - |
| `WorldFile` | [`WorldFile`](../../doc/models/world-file.md) | Optional | - |
| `WorldImage` | `string` | Optional | - |
| `FloorBackground` | `string` | Optional | - |
| `WorldImageHeight` | `int?` | Optional | - |
| `WorldImageWidth` | `int?` | Optional | - |
| `CustomerId` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "floorId": "00001182-0000-0000-0000-000000000000",
  "worldFile": {
    "xscale": 171.22,
    "yskew": 95.68,
    "xskew": 98.38,
    "yscale": 190.16,
    "xposition": 141.62
  },
  "worldImage": "worldImage4",
  "floorBackground": "floorBackground0",
  "worldImageHeight": 148
}
```

