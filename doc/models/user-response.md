
# User Response

## Structure

`UserResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `CreatedTimestamp` | `DateTime?` | Optional | - |
| `Name` | `string` | Required | - |
| `IsBlocked` | `bool` | Required | - |
| `GivenName` | `string` | Optional | - |
| `FamilyName` | `string` | Optional | - |
| `Email` | `string` | Optional | - |
| `Picture` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `IsAPerson` | `bool` | Required | - |

## Example (as JSON)

```json
{
  "id": "id8",
  "createdTimestamp": "2016-03-13T12:52:32.123Z",
  "name": "name8",
  "isBlocked": false,
  "givenName": "givenName2",
  "familyName": "familyName6",
  "email": "email8",
  "picture": "picture8",
  "isAPerson": false
}
```

