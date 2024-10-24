
# Camera

## Structure

`Camera`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `FloorId` | `Guid?` | Optional | - |
| `BuildingId` | `Guid?` | Optional | - |
| `AzimuthRad` | `double?` | Optional | - |
| `FieldOfViewRad` | `double?` | Optional | - |
| `RangeMeters` | `double?` | Optional | - |
| `CoordinatesWKT` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": "0000012c-0000-0000-0000-000000000000",
  "name": "name0",
  "floorId": "00000d6c-0000-0000-0000-000000000000",
  "buildingId": "000003be-0000-0000-0000-000000000000",
  "azimuthRad": 188.16,
  "fieldOfViewRad": 41.2,
  "rangeMeters": 181.72
}
```

