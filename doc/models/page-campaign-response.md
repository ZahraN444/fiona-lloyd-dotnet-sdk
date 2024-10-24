
# Page Campaign Response

## Structure

`PageCampaignResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<CampaignResponse>`](../../doc/models/campaign-response.md) | Optional | - |
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
  "totalPages": 76,
  "totalElements": 80,
  "size": 252,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "startDate": "2016-03-13T12:52:32.123Z",
      "endDate": "2016-03-13T12:52:32.123Z",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "facilityId": "000003d6-0000-0000-0000-000000000000"
    },
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "startDate": "2016-03-13T12:52:32.123Z",
      "endDate": "2016-03-13T12:52:32.123Z",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "facilityId": "000003d6-0000-0000-0000-000000000000"
    },
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "startDate": "2016-03-13T12:52:32.123Z",
      "endDate": "2016-03-13T12:52:32.123Z",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "facilityId": "000003d6-0000-0000-0000-000000000000"
    }
  ],
  "number": 136
}
```

