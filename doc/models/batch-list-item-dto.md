
# Batch List Item Dto

## Structure

`BatchListItemDto`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `FacilityId` | `Guid` | Required | - |
| `DataStartDatetime` | `DateTime?` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `CreatedBy` | `string` | Optional | - |
| `VideoCount` | `int` | Required | - |
| `PreprocessedVideoCount` | `int` | Required | - |
| `ErrorVideoCount` | `int` | Required | - |
| `StatusUpdates` | [`List<BatchStatusInfoDto>`](../../doc/models/batch-status-info-dto.md) | Required | - |
| `RunIds` | `List<Guid>` | Required | - |
| `RetainIntermediaryData` | `bool` | Required | - |

## Example (as JSON)

```json
{
  "id": "0000229c-0000-0000-0000-000000000000",
  "facilityId": "00000022-0000-0000-0000-000000000000",
  "videoCount": 128,
  "preprocessedVideoCount": 174,
  "errorVideoCount": 10,
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
    "000019d6-0000-0000-0000-000000000000",
    "000019d7-0000-0000-0000-000000000000"
  ],
  "retainIntermediaryData": false,
  "dataStartDatetime": "2016-03-13T12:52:32.123Z",
  "createdAt": "2016-03-13T12:52:32.123Z",
  "createdBy": "createdBy2"
}
```

