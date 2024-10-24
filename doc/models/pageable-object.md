
# Pageable Object

## Structure

`PageableObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Offset` | `long?` | Optional | - |
| `Sort` | [`SortObject`](../../doc/models/sort-object.md) | Optional | - |
| `Unpaged` | `bool?` | Optional | - |
| `Paged` | `bool?` | Optional | - |
| `PageNumber` | `int?` | Optional | - |
| `PageSize` | `int?` | Optional | - |

## Example (as JSON)

```json
{
  "offset": 200,
  "sort": {
    "empty": false,
    "unsorted": false,
    "sorted": false
  },
  "unpaged": false,
  "paged": false,
  "pageNumber": 178
}
```

