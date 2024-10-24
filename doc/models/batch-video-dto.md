
# Batch Video Dto

## Structure

`BatchVideoDto`

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
| `FrameRate` | `int?` | Optional | - |
| `VideoLength` | `int?` | Optional | - |
| `TotalFrames` | `int?` | Optional | - |
| `FileSize` | `long?` | Optional | - |
| `VideoStartTimestamp` | `DateTime?` | Optional | - |
| `UploadedBy` | `string` | Optional | - |
| `LastUpdateAt` | `DateTime?` | Optional | - |
| `ErrorDescription` | `string` | Optional | - |
| `FacilityId` | `Guid?` | Optional | - |

## Example (as JSON)

```json
{
  "id": "id4",
  "cameraId": "cameraId0",
  "customerId": "customerId8",
  "originalFileName": "originalFileName2",
  "status": "metadata-extracted",
  "codec": "codec2",
  "resolution": {
    "width": 154,
    "height": 250
  },
  "frameRate": 82,
  "videoLength": 0
}
```

