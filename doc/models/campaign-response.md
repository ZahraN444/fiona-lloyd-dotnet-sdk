
# Campaign Response

## Structure

`CampaignResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `StartDate` | `DateTime` | Required | - |
| `EndDate` | `DateTime` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `FacilityId` | `Guid` | Required | - |

## Example (as JSON)

```json
{
  "id": "0000174c-0000-0000-0000-000000000000",
  "name": "name4",
  "description": "description4",
  "startDate": "2016-03-13T12:52:32.123Z",
  "endDate": "2016-03-13T12:52:32.123Z",
  "createdAt": "2016-03-13T12:52:32.123Z",
  "facilityId": "00001be2-0000-0000-0000-000000000000"
}
```

