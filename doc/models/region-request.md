
# Region Request

## Structure

`RegionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `Boundary` | [`RegionRequestBoundary`](../../doc/models/containers/region-request-boundary.md) | Optional | This is a container for one-of cases. |
| `Temporary` | `bool?` | Optional | - |
| `SetupDate` | `DateTime?` | Optional | - |
| `TeardownDate` | `DateTime?` | Optional | - |
| `LogoId` | `Guid?` | Optional | - |
| `FacilityId` | `Guid` | Required | - |
| `Category` | [`CategoryEnum`](../../doc/models/category-enum.md) | Required | - |
| `FloorId` | `Guid?` | Optional | - |
| `Metadata` | [`RegionRequestMetadata`](../../doc/models/region-request-metadata.md) | Optional | - |
| `ParentId` | `Guid?` | Optional | - |
| `Disabled` | `bool` | Required | - |

## Example (as JSON)

```json
{
  "name": "name8",
  "description": "description2",
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
  "temporary": false,
  "setupDate": "2016-03-13T12:52:32.123Z",
  "teardownDate": "2016-03-13T12:52:32.123Z",
  "facilityId": "00000eb2-0000-0000-0000-000000000000",
  "category": "ENTRANCE",
  "disabled": false
}
```

