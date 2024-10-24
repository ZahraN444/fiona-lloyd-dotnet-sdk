
# Journey Sankey Response

## Structure

`JourneySankeyResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<JourneySankeyPathDefinition>`](../../doc/models/journey-sankey-path-definition.md) | Required | - |

## Example (as JSON)

```json
{
  "items": [
    {
      "numberOfVisitors": 4,
      "pathRegionIds": [
        "000012bf-0000-0000-0000-000000000000",
        "000012c0-0000-0000-0000-000000000000",
        "000012c1-0000-0000-0000-000000000000"
      ],
      "numberOfVisitorsFactor": 166.22
    }
  ]
}
```

