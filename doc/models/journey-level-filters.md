
# Journey Level Filters

## Structure

`JourneyLevelFilters`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Level` | `int` | Required | **Constraints**: `>= 1`, `<= 10` |
| `IdIn` | `List<Guid>` | Optional | - |
| `ForceMoveIdsToOthers` | `List<Guid>` | Optional | - |

## Example (as JSON)

```json
{
  "level": 196,
  "idIn": [
    "000025f7-0000-0000-0000-000000000000",
    "000025f8-0000-0000-0000-000000000000",
    "000025f9-0000-0000-0000-000000000000"
  ],
  "forceMoveIdsToOthers": [
    "000023a0-0000-0000-0000-000000000000",
    "000023a1-0000-0000-0000-000000000000"
  ]
}
```

