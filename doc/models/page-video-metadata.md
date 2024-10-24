
# Page Video Metadata

## Structure

`PageVideoMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalPages` | `int?` | Optional | - |
| `TotalElements` | `long?` | Optional | - |
| `Size` | `int?` | Optional | - |
| `Content` | [`List<VideoMetadata>`](../../doc/models/video-metadata.md) | Optional | - |
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
  "totalPages": 106,
  "totalElements": 50,
  "size": 230,
  "content": [
    {
      "id": "id4",
      "cameraId": "cameraId0",
      "customerId": "customerId8",
      "originalFileName": "originalFileName2",
      "status": "upload-started",
      "codec": "codec2",
      "resolution": {
        "width": 154,
        "height": 250
      },
      "isVariableFrameRate": false,
      "frameRate": 64,
      "parentBatches": [
        "parentBatches6",
        "parentBatches7"
      ]
    },
    {
      "id": "id4",
      "cameraId": "cameraId0",
      "customerId": "customerId8",
      "originalFileName": "originalFileName2",
      "status": "upload-started",
      "codec": "codec2",
      "resolution": {
        "width": 154,
        "height": 250
      },
      "isVariableFrameRate": false,
      "frameRate": 64,
      "parentBatches": [
        "parentBatches6",
        "parentBatches7"
      ]
    },
    {
      "id": "id4",
      "cameraId": "cameraId0",
      "customerId": "customerId8",
      "originalFileName": "originalFileName2",
      "status": "upload-started",
      "codec": "codec2",
      "resolution": {
        "width": 154,
        "height": 250
      },
      "isVariableFrameRate": false,
      "frameRate": 64,
      "parentBatches": [
        "parentBatches6",
        "parentBatches7"
      ]
    }
  ],
  "number": 90
}
```

