
# Geometry Validate Request

## Structure

`GeometryValidateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Boundary` | [`GeometryValidateRequestBoundary`](../../doc/models/containers/geometry-validate-request-boundary.md) | Required | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "boundary": {
    "value": [
      {
        "x": 29.38,
        "y": 160.66
      }
    ],
    "type": "LineRepresentation"
  }
}
```

