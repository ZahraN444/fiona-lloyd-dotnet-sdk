
# Page Naics Code Response

## Structure

`PageNaicsCodeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<NaicsCodeResponse>`](../../doc/models/naics-code-response.md) | Optional | - |
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
  "totalPages": 46,
  "totalElements": 146,
  "size": 222,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "code": "code2",
      "title": "title0",
      "parentId": "00001b0e-0000-0000-0000-000000000000"
    }
  ],
  "number": 106
}
```

