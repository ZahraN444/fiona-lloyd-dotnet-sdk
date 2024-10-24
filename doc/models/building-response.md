
# Building Response

## Structure

`BuildingResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Address` | `string` | Optional | - |
| `Notes` | `string` | Optional | - |
| `FacilityId` | `Guid` | Required | - |
| `Boundary` | [`BuildingResponseBoundary`](../../doc/models/containers/building-response-boundary.md) | Optional | This is a container for one-of cases. |
| `CreatedAt` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "id": "00001a4c-0000-0000-0000-000000000000",
  "name": "name2",
  "address": "address8",
  "notes": "notes2",
  "facilityId": "00001ee2-0000-0000-0000-000000000000",
  "boundary": {
    "type": "LineRepresentation",
    "value": [
      {
        "x": 29.38,
        "y": 160.66
      },
      {
        "x": 29.38,
        "y": 160.66
      },
      {
        "x": 29.38,
        "y": 160.66
      }
    ]
  },
  "createdAt": "2016-03-13T12:52:32.123Z"
}
```

