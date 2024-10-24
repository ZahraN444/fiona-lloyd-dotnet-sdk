
# Page Campaign Details Response

## Structure

`PageCampaignDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<CampaignDetailsResponse>`](../../doc/models/campaign-details-response.md) | Optional | - |
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
  "totalPages": 20,
  "totalElements": 120,
  "size": 196,
  "content": [
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "advertisementId": "000023ae-0000-0000-0000-000000000000",
      "adSignage": "000007b8-0000-0000-0000-000000000000",
      "campaignId": "00001f6e-0000-0000-0000-000000000000",
      "startDate": "2016-03-13T12:52:32.123Z",
      "endDate": "2016-03-13T12:52:32.123Z",
      "shareOfVoice": 56.5,
      "secondsOfRotation": 36,
      "secondsOfShare": 158,
      "createdAt": "2016-03-13T12:52:32.123Z"
    },
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "advertisementId": "000023ae-0000-0000-0000-000000000000",
      "adSignage": "000007b8-0000-0000-0000-000000000000",
      "campaignId": "00001f6e-0000-0000-0000-000000000000",
      "startDate": "2016-03-13T12:52:32.123Z",
      "endDate": "2016-03-13T12:52:32.123Z",
      "shareOfVoice": 56.5,
      "secondsOfRotation": 36,
      "secondsOfShare": 158,
      "createdAt": "2016-03-13T12:52:32.123Z"
    },
    {
      "id": "00001ea4-0000-0000-0000-000000000000",
      "name": "name4",
      "description": "description6",
      "advertisementId": "000023ae-0000-0000-0000-000000000000",
      "adSignage": "000007b8-0000-0000-0000-000000000000",
      "campaignId": "00001f6e-0000-0000-0000-000000000000",
      "startDate": "2016-03-13T12:52:32.123Z",
      "endDate": "2016-03-13T12:52:32.123Z",
      "shareOfVoice": 56.5,
      "secondsOfRotation": 36,
      "secondsOfShare": 158,
      "createdAt": "2016-03-13T12:52:32.123Z"
    }
  ],
  "number": 80
}
```

