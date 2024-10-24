
# Page Region Response

## Structure

`PageRegionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<RegionResponse>`](../../doc/models/region-response.md) | Optional | - |
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
  "totalPages": 240,
  "totalElements": 172,
  "size": 96,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
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
      "temporary": false,
      "floorId": "000003d4-0000-0000-0000-000000000000",
      "facilityId": "000003d6-0000-0000-0000-000000000000",
      "parentId": "00001b0e-0000-0000-0000-000000000000",
      "logoId": "00000a9a-0000-0000-0000-000000000000",
      "metadata": {
        "naicsCode": {
          "code": "code0",
          "name": "name2"
        },
        "signType": "DIGITAL_DYNAMIC",
        "size": "size6"
      },
      "category": "AD_SIGNAGE",
      "disabled": false
    },
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
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
      "temporary": false,
      "floorId": "000003d4-0000-0000-0000-000000000000",
      "facilityId": "000003d6-0000-0000-0000-000000000000",
      "parentId": "00001b0e-0000-0000-0000-000000000000",
      "logoId": "00000a9a-0000-0000-0000-000000000000",
      "metadata": {
        "naicsCode": {
          "code": "code0",
          "name": "name2"
        },
        "signType": "DIGITAL_DYNAMIC",
        "size": "size6"
      },
      "category": "AD_SIGNAGE",
      "disabled": false
    }
  ],
  "number": 212
}
```

