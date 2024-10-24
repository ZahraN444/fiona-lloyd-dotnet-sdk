
# Region Response

## Structure

`RegionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `Boundary` | [`RegionResponseBoundary`](../../doc/models/containers/region-response-boundary.md) | Required | This is a container for one-of cases. |
| `Temporary` | `bool?` | Optional | - |
| `FloorId` | `Guid` | Required | - |
| `FacilityId` | `Guid` | Required | - |
| `ParentId` | `Guid?` | Optional | - |
| `LogoId` | `Guid?` | Optional | - |
| `Metadata` | [`RegionResponseMetadata`](../../doc/models/region-response-metadata.md) | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `SetupDate` | `DateTime?` | Optional | - |
| `TeardownDate` | `DateTime?` | Optional | - |
| `Category` | [`CategoryEnum`](../../doc/models/category-enum.md) | Required | - |
| `Disabled` | `bool` | Required | - |
| `Features` | [`List<RegionFeatureResponse>`](../../doc/models/region-feature-response.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "00000468-0000-0000-0000-000000000000",
  "name": "name8",
  "boundary": {
    "value": [
      {
        "x": 29.38,
        "y": 160.66
      }
    ],
    "type": "LineRepresentation"
  },
  "floorId": "000010a8-0000-0000-0000-000000000000",
  "facilityId": "000008fe-0000-0000-0000-000000000000",
  "category": "ENTRANCE",
  "disabled": false,
  "description": "description8",
  "temporary": false,
  "parentId": "00000e3a-0000-0000-0000-000000000000",
  "logoId": "000024d6-0000-0000-0000-000000000000",
  "metadata": {
    "naicsCode": {
      "code": "code0",
      "name": "name2"
    },
    "signType": "DIGITAL_DYNAMIC",
    "size": "size6"
  }
}
```

