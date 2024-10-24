
# Campaign Details Request

## Structure

`CampaignDetailsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `AdvertisementId` | `Guid` | Required | - |
| `AdSignage` | `Guid` | Required | - |
| `CampaignId` | `Guid` | Required | - |
| `StartDate` | `DateTime` | Required | - |
| `EndDate` | `DateTime` | Required | - |
| `ShareOfVoice` | `double` | Required | **Constraints**: `>= 1` |
| `SecondsOfRotation` | `int` | Required | **Constraints**: `>= 1` |
| `SecondsOfShare` | `int` | Required | **Constraints**: `>= 1` |

## Example (as JSON)

```json
{
  "name": "name8",
  "description": "description8",
  "advertisementId": "00000ac6-0000-0000-0000-000000000000",
  "adSignage": "00000670-0000-0000-0000-000000000000",
  "campaignId": "000015ca-0000-0000-0000-000000000000",
  "startDate": "2016-03-13T12:52:32.123Z",
  "endDate": "2016-03-13T12:52:32.123Z",
  "shareOfVoice": 223.74,
  "secondsOfRotation": 84,
  "secondsOfShare": 38
}
```

