
# Batch Dto

## Structure

`BatchDto`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `FacilityId` | `Guid` | Required | - |
| `CustomerId` | `string` | Required | - |
| `DataStartDatetime` | `DateTime?` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `CreatedBy` | `string` | Optional | - |
| `Videos` | [`List<BatchVideoDto>`](../../doc/models/batch-video-dto.md) | Required | - |
| `StatusUpdates` | [`List<BatchStatusInfoDto>`](../../doc/models/batch-status-info-dto.md) | Required | - |
| `RunIds` | `List<Guid>` | Required | - |
| `RetainIntermediaryData` | `bool` | Required | - |

## Example (as JSON)

```json
{
  "id": "00000cd6-0000-0000-0000-000000000000",
  "facilityId": "0000116c-0000-0000-0000-000000000000",
  "customerId": "customerId0",
  "videos": [
    {
      "id": "id0",
      "cameraId": "cameraId6",
      "customerId": "customerId4",
      "originalFileName": "originalFileName8",
      "status": "upload-terminated",
      "codec": "codec8",
      "resolution": {
        "width": 154,
        "height": 250
      },
      "frameRate": 12,
      "videoLength": 94
    }
  ],
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
    "0000088c-0000-0000-0000-000000000000"
  ],
  "retainIntermediaryData": false,
  "dataStartDatetime": "2016-03-13T12:52:32.123Z",
  "createdAt": "2016-03-13T12:52:32.123Z",
  "createdBy": "createdBy6"
}
```

