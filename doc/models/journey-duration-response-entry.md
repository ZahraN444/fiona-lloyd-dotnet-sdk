
# Journey Duration Response Entry

## Structure

`JourneyDurationResponseEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Date` | `DateTime` | Required | - |
| `Observations` | `long?` | Optional | - |
| `MinMinutes` | `double` | Required | - |
| `MaxMinutes` | `double` | Required | - |
| `LowerQuartileMinutes` | `double` | Required | - |
| `UpperQuartileMinutes` | `double` | Required | - |
| `MedianMinutes` | `double` | Required | - |
| `MeanMinutes` | `double` | Required | - |

## Example (as JSON)

```json
{
  "date": "2016-03-13",
  "observations": 236,
  "minMinutes": 11.1,
  "maxMinutes": 212.76,
  "lowerQuartileMinutes": 165.44,
  "upperQuartileMinutes": 28.78,
  "medianMinutes": 51.48,
  "meanMinutes": 129.74
}
```

