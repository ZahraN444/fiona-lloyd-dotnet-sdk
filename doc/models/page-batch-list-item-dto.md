
# Page Batch List Item Dto

## Structure

`PageBatchListItemDto`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<BatchListItemDto>`](../../doc/models/batch-list-item-dto.md) | Optional | - |
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
  "totalPages": 10,
  "totalElements": 146,
  "size": 186,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "facilityId": "000003d6-0000-0000-0000-000000000000",
      "dataStartDatetime": "2016-03-13T12:52:32.123Z",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "createdBy": "createdBy8",
      "videoCount": 152,
      "preprocessedVideoCount": 150,
      "errorVideoCount": 34,
      "statusUpdates": [
        {
          "id": "000026c8-0000-0000-0000-000000000000",
          "updateTimestamp": "2016-03-13T12:52:32.123Z",
          "stage": "cross-camera",
          "status": "finished",
          "metadata": "metadata8"
        }
      ],
      "runIds": [
        "00001dce-0000-0000-0000-000000000000",
        "00001dcf-0000-0000-0000-000000000000",
        "00001dd0-0000-0000-0000-000000000000"
      ],
      "retainIntermediaryData": false
    },
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "facilityId": "000003d6-0000-0000-0000-000000000000",
      "dataStartDatetime": "2016-03-13T12:52:32.123Z",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "createdBy": "createdBy8",
      "videoCount": 152,
      "preprocessedVideoCount": 150,
      "errorVideoCount": 34,
      "statusUpdates": [
        {
          "id": "000026c8-0000-0000-0000-000000000000",
          "updateTimestamp": "2016-03-13T12:52:32.123Z",
          "stage": "cross-camera",
          "status": "finished",
          "metadata": "metadata8"
        }
      ],
      "runIds": [
        "00001dce-0000-0000-0000-000000000000",
        "00001dcf-0000-0000-0000-000000000000",
        "00001dd0-0000-0000-0000-000000000000"
      ],
      "retainIntermediaryData": false
    }
  ],
  "number": 70
}
```

