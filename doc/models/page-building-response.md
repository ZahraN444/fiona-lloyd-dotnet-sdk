
# Page Building Response

## Structure

`PageBuildingResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<BuildingResponse>`](../../doc/models/building-response.md) | Optional | - |
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
  "totalPages": 252,
  "totalElements": 96,
  "size": 172,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "address": "address0",
      "notes": "notes4",
      "facilityId": "000003d6-0000-0000-0000-000000000000",
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
      "createdAt": "2016-03-13T12:52:32.123Z"
    }
  ],
  "number": 56
}
```

