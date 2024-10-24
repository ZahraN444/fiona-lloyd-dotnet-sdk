
# Campaign Details Response

## Structure

`CampaignDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `AdvertisementId` | `Guid` | Required | - |
| `AdSignage` | `Guid` | Required | - |
| `CampaignId` | `Guid` | Required | - |
| `StartDate` | `DateTime` | Required | - |
| `EndDate` | `DateTime` | Required | - |
| `ShareOfVoice` | `double` | Required | - |
| `SecondsOfRotation` | `int` | Required | - |
| `SecondsOfShare` | `int` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |

## Example (as JSON)

```json
{
  "id": "00001cfa-0000-0000-0000-000000000000",
  "name": "name8",
  "description": "description8",
  "advertisementId": "00002204-0000-0000-0000-000000000000",
  "adSignage": "00001dae-0000-0000-0000-000000000000",
  "campaignId": "00002118-0000-0000-0000-000000000000",
  "startDate": "2016-03-13T12:52:32.123Z",
  "endDate": "2016-03-13T12:52:32.123Z",
  "shareOfVoice": 239.24,
  "secondsOfRotation": 158,
  "secondsOfShare": 24,
  "createdAt": "2016-03-13T12:52:32.123Z"
}
```

