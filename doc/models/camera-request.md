
# Camera Request

## Structure

`CameraRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Make` | `string` | Optional | - |
| `Model` | `string` | Optional | - |
| `Notes` | `string` | Optional | - |
| `AzimuthRad` | `double?` | Optional | - |
| `FieldOfViewRad` | `double?` | Optional | - |
| `RangeMeters` | `double?` | Optional | - |
| `FloorId` | `Guid?` | Optional | - |
| `BuildingId` | `Guid?` | Optional | - |
| `LocalId` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `VolumePath` | `string` | Optional | - |
| `RtspAddress` | `string` | Optional | - |
| `Coordinates` | [`CameraRequestCoordinates`](../../doc/models/containers/camera-request-coordinates.md) | Required | This is a container for one-of cases. |
| `FacilityId` | `Guid` | Required | - |

## Example (as JSON)

```json
{
  "name": "name4",
  "coordinates": {
    "value": [
      {
        "x": 29.38,
        "y": 160.66
      }
    ],
    "type": "LineRepresentation"
  },
  "facilityId": "000018a4-0000-0000-0000-000000000000",
  "make": "make4",
  "model": "model2",
  "notes": "notes4",
  "azimuthRad": 136.5,
  "fieldOfViewRad": 245.54
}
```

