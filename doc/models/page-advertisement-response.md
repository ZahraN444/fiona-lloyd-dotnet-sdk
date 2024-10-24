
# Page Advertisement Response

## Structure

`PageAdvertisementResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<AdvertisementResponse>`](../../doc/models/advertisement-response.md) | Optional | - |
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
  "totalPages": 170,
  "totalElements": 242,
  "size": 90,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "type": "DIGITAL_STATIC",
      "imageId": "00000a62-0000-0000-0000-000000000000",
      "storeId": "00001dd0-0000-0000-0000-000000000000",
      "facilityId": "000003d6-0000-0000-0000-000000000000",
      "version": "version0",
      "externalStoreName": "externalStoreName8"
    }
  ],
  "number": 230
}
```

