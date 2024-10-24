
# Page Camera Response

## Structure

`PageCameraResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<CameraResponse>`](../../doc/models/camera-response.md) | Optional | - |
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
  "totalPages": 74,
  "totalElements": 82,
  "size": 6,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "make": "make6",
      "model": "model8",
      "notes": "notes4",
      "localId": "localId2",
      "rtspAddress": "rtspAddress8",
      "coordinates": {
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
      "facilityId": "000003d6-0000-0000-0000-000000000000"
    },
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "make": "make6",
      "model": "model8",
      "notes": "notes4",
      "localId": "localId2",
      "rtspAddress": "rtspAddress8",
      "coordinates": {
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
      "facilityId": "000003d6-0000-0000-0000-000000000000"
    },
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "make": "make6",
      "model": "model8",
      "notes": "notes4",
      "localId": "localId2",
      "rtspAddress": "rtspAddress8",
      "coordinates": {
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
      "facilityId": "000003d6-0000-0000-0000-000000000000"
    }
  ],
  "number": 122
}
```

