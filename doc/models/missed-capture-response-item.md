
# Missed Capture Response Item

## Structure

`MissedCaptureResponseItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NumberOfEntitiesMissed` | `int?` | Optional | - |
| `NumberOfEntitiesMissedFactor` | `double` | Required | - |
| `NumberOfEntitiesVisitedBothRegions` | `int?` | Optional | - |
| `NumberOfEntitiesVisitedBothRegionsFactor` | `double` | Required | - |
| `TotalInSignatureRegion` | `int?` | Optional | - |
| `TotalInSignatureRegionFactor` | `double` | Required | - |
| `SignatureRegionId` | `Guid` | Required | - |

## Example (as JSON)

```json
{
  "numberOfEntitiesMissed": 60,
  "numberOfEntitiesMissedFactor": 119.12,
  "numberOfEntitiesVisitedBothRegions": 2,
  "numberOfEntitiesVisitedBothRegionsFactor": 141.36,
  "totalInSignatureRegion": 46,
  "totalInSignatureRegionFactor": 83.68,
  "signatureRegionId": "00001346-0000-0000-0000-000000000000"
}
```

