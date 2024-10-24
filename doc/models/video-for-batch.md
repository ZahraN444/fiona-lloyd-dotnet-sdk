
# Video for Batch

## Structure

`VideoForBatch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `OriginalFileName` | `string` | Required | - |
| `Status` | [`StatusEnum?`](../../doc/models/status-enum.md) | Optional | - |
| `FrameRate` | `int?` | Optional | - |
| `VideoLength` | `int` | Required | - |
| `VideoStartTimestamp` | `DateTime` | Required | - |
| `Resolution` | [`PixelDimensions`](../../doc/models/pixel-dimensions.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "id4",
  "originalFileName": "originalFileName2",
  "status": "upload-started",
  "frameRate": 164,
  "videoLength": 174,
  "videoStartTimestamp": "2016-03-13T12:52:32.123Z",
  "resolution": {
    "width": 154,
    "height": 250
  }
}
```

