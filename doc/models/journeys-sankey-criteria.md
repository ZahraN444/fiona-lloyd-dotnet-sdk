
# Journeys Sankey Criteria

## Structure

`JourneysSankeyCriteria`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartDate` | `DateTime` | Required | - |
| `EndDate` | `DateTime` | Required | - |
| `MaxDepth` | `int?` | Optional | **Constraints**: `>= 1`, `<= 10` |
| `MaxWidth` | `int` | Required | **Constraints**: `>= 1` |
| `Focus` | [`FocusEnum`](../../doc/models/focus-enum.md) | Required | - |
| `LevelFiltersCollection` | [`List<JourneyLevelFilters>`](../../doc/models/journey-level-filters.md) | Optional | - |
| `ExcludeFullyVirtualResults` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "startDate": "2016-03-13",
  "endDate": "2016-03-13",
  "maxDepth": 166,
  "maxWidth": 114,
  "focus": "STORE",
  "levelFiltersCollection": [
    {
      "level": 84,
      "idIn": [
        "00000abf-0000-0000-0000-000000000000",
        "00000ac0-0000-0000-0000-000000000000",
        "00000ac1-0000-0000-0000-000000000000"
      ],
      "forceMoveIdsToOthers": [
        "00000f2c-0000-0000-0000-000000000000",
        "00000f2b-0000-0000-0000-000000000000",
        "00000f2a-0000-0000-0000-000000000000"
      ]
    }
  ],
  "excludeFullyVirtualResults": false
}
```

