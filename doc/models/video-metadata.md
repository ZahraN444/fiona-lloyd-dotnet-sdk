
# Video Metadata

## Structure

`VideoMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `CameraId` | `string` | Required | - |
| `CustomerId` | `string` | Required | - |
| `OriginalFileName` | `string` | Optional | - |
| `Status` | [`StatusEnum`](../../doc/models/status-enum.md) | Required | - |
| `Codec` | `string` | Optional | - |
| `Resolution` | [`PixelDimensions`](../../doc/models/pixel-dimensions.md) | Optional | - |
| `IsVariableFrameRate` | `bool?` | Optional | - |
| `FrameRate` | `int?` | Optional | - |
| `VideoLength` | `int?` | Optional | - |
| `TotalFrames` | `int?` | Optional | - |
| `FileSize` | `long?` | Optional | - |
| `StorageBucket` | `string` | Optional | - |
| `StorageKey` | `string` | Optional | - |
| `VideoStartTimestamp` | `DateTime?` | Optional | - |
| `UploadStartedAt` | `DateTime?` | Optional | - |
| `UploadFinishedAt` | `DateTime?` | Optional | - |
| `UploadedBy` | `string` | Optional | - |
| `LastUpdateAt` | `DateTime?` | Optional | - |
| `BytesReceived` | `long?` | Optional | - |
| `ErrorDescription` | `string` | Optional | - |
| `FacilityId` | `Guid?` | Optional | - |
| `ParentBatches` | `List<string>` | Required | - |
| `SampledTotalFrames` | `int?` | Optional | - |

## Example (as JSON)

```json
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
  "isVariableFrameRate": false,
  "frameRate": 114,
  "parentBatches": [
    "parentBatches2",
    "parentBatches3",
    "parentBatches4"
  ]
}
```

