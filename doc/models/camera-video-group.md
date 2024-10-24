
# Camera Video Group

## Structure

`CameraVideoGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CameraId` | `string` | Required | - |
| `FrameRate` | `int` | Required | - |
| `Status` | [`StatusEnum`](../../doc/models/status-enum.md) | Required | - |
| `Videos` | [`List<VideoForBatch>`](../../doc/models/video-for-batch.md) | Required | - |
| `Resolution` | [`PixelDimensions`](../../doc/models/pixel-dimensions.md) | Required | - |

## Example (as JSON)

```json
{
  "cameraId": "cameraId8",
  "frameRate": 6,
  "status": "upload-terminated",
  "videos": [
    {
      "id": "id0",
      "originalFileName": "originalFileName8",
      "status": "upload-terminated",
      "frameRate": 12,
      "videoLength": 94,
      "videoStartTimestamp": "2016-03-13T12:52:32.123Z",
      "resolution": {
        "width": 154,
        "height": 250
      }
    }
  ],
  "resolution": {
    "width": 154,
    "height": 250
  }
}
```

