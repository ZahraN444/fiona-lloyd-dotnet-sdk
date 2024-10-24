
# Batch Status Info Dto

## Structure

`BatchStatusInfoDto`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `UpdateTimestamp` | `DateTime?` | Optional | - |
| `Stage` | [`StageEnum`](../../doc/models/stage-enum.md) | Required | - |
| `Status` | [`Status3Enum`](../../doc/models/status-3-enum.md) | Required | - |
| `Metadata` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": "00001e46-0000-0000-0000-000000000000",
  "updateTimestamp": "2016-03-13T12:52:32.123Z",
  "stage": "pra",
  "status": "failed",
  "metadata": "metadata6"
}
```

