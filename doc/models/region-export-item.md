
# Region Export Item

## Structure

`RegionExportItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegionId` | `Guid` | Required | - |
| `RegionName` | `string` | Required | - |
| `Geometry` | [`Geometry`](../../doc/models/geometry.md) | Required | - |
| `RegionType` | `string` | Required | - |

## Example (as JSON)

```json
{
  "region_id": "00001456-0000-0000-0000-000000000000",
  "region_name": "region_name8",
  "geometry": {
    "dimension": 98,
    "haveMeasure": false,
    "type": 140,
    "srid": 48,
    "value": "value6"
  },
  "region_type": "region_type6"
}
```

