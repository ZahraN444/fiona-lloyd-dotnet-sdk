
# Journey Sankey Path Definition

## Structure

`JourneySankeyPathDefinition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NumberOfVisitors` | `int?` | Optional | - |
| `PathRegionIds` | [`List<JourneySankeyPathDefinitionPathRegionIds>`](../../doc/models/containers/journey-sankey-path-definition-path-region-ids.md) | Required | This is List of a container for one-of cases. |
| `NumberOfVisitorsFactor` | `double` | Required | - |

## Example (as JSON)

```json
{
  "numberOfVisitors": 154,
  "pathRegionIds": [
    "00001429-0000-0000-0000-000000000000",
    "0000142a-0000-0000-0000-000000000000"
  ],
  "numberOfVisitorsFactor": 169.84
}
```

