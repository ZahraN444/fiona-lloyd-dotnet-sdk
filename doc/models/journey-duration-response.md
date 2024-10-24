
# Journey Duration Response

## Structure

`JourneyDurationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `JourneyDurations` | [`List<JourneyDurationResponseEntry>`](../../doc/models/journey-duration-response-entry.md) | Required | - |

## Example (as JSON)

```json
{
  "journeyDurations": [
    {
      "date": "2016-03-13",
      "observations": 132,
      "minMinutes": 43.34,
      "maxMinutes": 245.0,
      "lowerQuartileMinutes": 197.68,
      "upperQuartileMinutes": 61.02,
      "medianMinutes": 83.72,
      "meanMinutes": 161.98
    }
  ]
}
```

