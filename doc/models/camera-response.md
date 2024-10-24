
# Camera Response

## Structure

`CameraResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Make` | `string` | Optional | - |
| `Model` | `string` | Optional | - |
| `Notes` | `string` | Optional | - |
| `LocalId` | `string` | Optional | - |
| `RtspAddress` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `VolumePath` | `string` | Optional | - |
| `AzimuthRad` | `double?` | Optional | - |
| `FieldOfViewRad` | `double?` | Optional | - |
| `RangeMeters` | `double?` | Optional | - |
| `Coordinates` | [`CameraResponseCoordinates`](../../doc/models/containers/camera-response-coordinates.md) | Required | This is a container for one-of cases. |
| `FloorId` | `Guid?` | Optional | - |
| `BuildingId` | `Guid?` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `FacilityId` | `Guid` | Required | - |

## Example (as JSON)

```json
{
  "id": "000014dc-0000-0000-0000-000000000000",
  "name": "name0",
  "coordinates": {
    "value": [
      {
        "x": 29.38,
        "y": 160.66
      }
    ],
    "type": "LineRepresentation"
  },
  "facilityId": "00000d9e-0000-0000-0000-000000000000",
  "make": "make0",
  "model": "model8",
  "notes": "notes0",
  "localId": "localId6",
  "rtspAddress": "rtspAddress2"
}
```

