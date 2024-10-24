
# Region Feature Request

## Structure

`RegionFeatureRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegionId` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Boundary` | [`RegionFeatureRequestBoundary`](../../doc/models/containers/region-feature-request-boundary.md) | Required | This is a container for one-of cases. |
| `FeatureCategory` | [`FeatureCategoryEnum`](../../doc/models/feature-category-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "regionId": "0000171a-0000-0000-0000-000000000000",
  "name": "name4",
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

