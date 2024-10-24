
# Region Feature Response

## Structure

`RegionFeatureResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `RegionId` | `Guid` | Required | - |
| `Boundary` | [`RegionFeatureResponseBoundary`](../../doc/models/containers/region-feature-response-boundary.md) | Required | This is a container for one-of cases. |
| `FeatureCategory` | [`FeatureCategoryEnum`](../../doc/models/feature-category-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "00000f88-0000-0000-0000-000000000000",
  "name": "name6",
  "regionId": "0000136c-0000-0000-0000-000000000000",
  "boundary": {
    "value": [
      {
        "x": 29.38,
        "y": 160.66
      }
    ],
    "type": "LineRepresentation"
  },
  "featureCategory": "VIEWABLE_AREA"
}
```

