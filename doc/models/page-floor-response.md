
# Page Floor Response

## Structure

`PageFloorResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<FloorResponse>`](../../doc/models/floor-response.md) | Optional | - |
| `Number` | `int?` | Optional | - |
| `Sort` | [`SortObject`](../../doc/models/sort-object.md) | Optional | - |
| `NumberOfElements` | `int?` | Optional | - |
| `Pageable` | [`PageableObject`](../../doc/models/pageable-object.md) | Optional | - |
| `First` | `bool?` | Optional | - |
| `Last` | `bool?` | Optional | - |
| `Empty` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "totalPages": 84,
  "totalElements": 72,
  "size": 252,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "level": 58,
      "notes": "notes4",
      "buildingId": "000005da-0000-0000-0000-000000000000",
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
      "bottomLimit": 215.3
    },
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "level": 58,
      "notes": "notes4",
      "buildingId": "000005da-0000-0000-0000-000000000000",
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
      "bottomLimit": 215.3
    }
  ],
  "number": 112
}
```

