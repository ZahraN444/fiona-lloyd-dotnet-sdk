
# Top Destinations Response Node

## Structure

`TopDestinationsResponseNode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `long?` | Optional | - |
| `Id` | `string` | Required | - |
| `Children` | [`List<TopDestinationsResponseNode>`](../../doc/models/top-destinations-response-node.md) | Optional | - |
| `FractionOfParent` | `double?` | Optional | - |
| `FractionOfTotalOfSelection` | `double?` | Optional | - |
| `FractionOfAll` | `double?` | Optional | - |

## Example (as JSON)

```json
{
  "value": 50,
  "id": "id4",
  "children": [
    {
      "value": 244,
      "id": "id8",
      "children": [
        {}
      ],
      "fractionOfParent": 50.64,
      "fractionOfTotalOfSelection": 79.06,
      "fractionOfAll": 227.14
    },
    {
      "value": 244,
      "id": "id8",
      "children": [
        {}
      ],
      "fractionOfParent": 50.64,
      "fractionOfTotalOfSelection": 79.06,
      "fractionOfAll": 227.14
    },
    {
      "value": 244,
      "id": "id8",
      "children": [
        {}
      ],
      "fractionOfParent": 50.64,
      "fractionOfTotalOfSelection": 79.06,
      "fractionOfAll": 227.14
    }
  ],
  "fractionOfParent": 48.7,
  "fractionOfTotalOfSelection": 77.12,
  "fractionOfAll": 225.2
}
```

