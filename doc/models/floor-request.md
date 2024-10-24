
# Floor Request

## Structure

`FloorRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Level` | `int` | Required | - |
| `Notes` | `string` | Optional | - |
| `BuildingId` | `Guid` | Required | - |
| `Boundary` | [`FloorRequestBoundary`](../../doc/models/containers/floor-request-boundary.md) | Optional | This is a container for one-of cases. |
| `CommonArea` | [`FloorRequestCommonArea`](../../doc/models/containers/floor-request-common-area.md) | Optional | This is a container for one-of cases. |
| `Metadata` | [`FloorRequestMetadata`](../../doc/models/floor-request-metadata.md) | Optional | - |
| `BottomLimit` | `double` | Required | - |

## Example (as JSON)

```json
{
  "level": 82,
  "notes": "notes2",
  "buildingId": "00000262-0000-0000-0000-000000000000",
  "boundary": {
    "type": "LineRepresentation",
    "value": [
      {
        "x": 29.38,
        "y": 160.66
      },
      {
        "x": 29.38,
        "y": 160.66
      },
      {
        "x": 29.38,
        "y": 160.66
      }
    ]
  },
  "commonArea": {
    "type": "LineRepresentation",
    "value": [
      {
        "x": 29.38,
        "y": 160.66
      },
      {
        "x": 29.38,
        "y": 160.66
      },
      {
        "x": 29.38,
        "y": 160.66
      }
    ]
  },
  "metadata": {
    "defaultGridDensityFactor": 197.7,
    "referenceLines": [
      {
        "point": {
          "x": 132.38,
          "y": 254.9
        },
        "angleRad": 208.94
      }
    ]
  },
  "bottomLimit": 49.78
}
```

