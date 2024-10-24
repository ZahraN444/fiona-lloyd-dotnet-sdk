
# Building Request

## Structure

`BuildingRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Address` | `string` | Required | - |
| `Notes` | `string` | Optional | - |
| `FacilityId` | `Guid` | Required | - |
| `Boundary` | [`BuildingRequestBoundary`](../../doc/models/containers/building-request-boundary.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "name": "name2",
  "address": "address8",
  "notes": "notes2",
  "facilityId": "00001f14-0000-0000-0000-000000000000",
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
  }
}
```

