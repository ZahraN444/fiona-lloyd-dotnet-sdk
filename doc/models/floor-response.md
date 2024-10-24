
# Floor Response

## Structure

`FloorResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Level` | `int` | Required | - |
| `Notes` | `string` | Optional | - |
| `BuildingId` | `Guid` | Required | - |
| `Boundary` | [`FloorResponseBoundary`](../../doc/models/containers/floor-response-boundary.md) | Optional | This is a container for one-of cases. |
| `CommonArea` | [`FloorResponseCommonArea`](../../doc/models/containers/floor-response-common-area.md) | Optional | This is a container for one-of cases. |
| `Metadata` | [`FloorResponseMetadata`](../../doc/models/floor-response-metadata.md) | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `BottomLimit` | `double` | Required | - |

## Example (as JSON)

```json
{
  "id": "00001672-0000-0000-0000-000000000000",
  "level": 212,
  "notes": "notes6",
  "buildingId": "00001904-0000-0000-0000-000000000000",
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
  "createdAt": "2016-03-13T12:52:32.123Z",
  "bottomLimit": 163.72
}
```

