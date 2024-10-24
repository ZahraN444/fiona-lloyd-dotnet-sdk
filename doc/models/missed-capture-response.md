
# Missed Capture Response

## Structure

`MissedCaptureResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Entries` | [`List<MissedCaptureResponseItem>`](../../doc/models/missed-capture-response-item.md) | Required | - |

## Example (as JSON)

```json
{
  "entries": [
    {
      "numberOfEntitiesMissed": 24,
      "numberOfEntitiesMissedFactor": 82.92,
      "numberOfEntitiesVisitedBothRegions": 218,
      "numberOfEntitiesVisitedBothRegionsFactor": 105.16,
      "totalInSignatureRegion": 174,
      "totalInSignatureRegionFactor": 47.48,
      "signatureRegionId": "00001b86-0000-0000-0000-000000000000"
    }
  ]
}
```

