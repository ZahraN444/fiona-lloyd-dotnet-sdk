
# Advertisement Response

## Structure

`AdvertisementResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `Type` | [`TypeEnum`](../../doc/models/type-enum.md) | Required | - |
| `ImageId` | `Guid?` | Optional | - |
| `StoreId` | `Guid?` | Optional | - |
| `FacilityId` | `Guid` | Required | - |
| `Version` | `string` | Optional | - |
| `ExternalStoreName` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "id": "00001d56-0000-0000-0000-000000000000",
  "name": "name0",
  "description": "description0",
  "type": "STATIC_POSTER",
  "imageId": "00000914-0000-0000-0000-000000000000",
  "storeId": "000007f2-0000-0000-0000-000000000000",
  "facilityId": "000021ec-0000-0000-0000-000000000000",
  "version": "version6",
  "externalStoreName": "externalStoreName8"
}
```

