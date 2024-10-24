
# Advertisement Request

## Structure

`AdvertisementRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `ImageId` | `Guid?` | Optional | - |
| `StoreId` | `Guid?` | Optional | - |
| `FacilityId` | `Guid` | Required | - |
| `ExternalStoreName` | `string` | Optional | - |
| `Type` | [`TypeEnum?`](../../doc/models/type-enum.md) | Optional | - |
| `Version` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name4",
  "description": "description4",
  "imageId": "000004f4-0000-0000-0000-000000000000",
  "storeId": "000003d2-0000-0000-0000-000000000000",
  "facilityId": "00001dcc-0000-0000-0000-000000000000",
  "externalStoreName": "externalStoreName2",
  "type": "DIGITAL_STATIC"
}
```

