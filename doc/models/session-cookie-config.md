
# Session Cookie Config

## Structure

`SessionCookieConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Path` | `string` | Optional | - |
| `Attributes` | `Dictionary<string, string>` | Optional | - |
| `Comment` | `string` | Optional | - |
| `Secure` | `bool?` | Optional | - |
| `Domain` | `string` | Optional | - |
| `MaxAge` | `int?` | Optional | - |
| `HttpOnly` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name2",
  "path": "path6",
  "attributes": {
    "key0": "attributes3",
    "key1": "attributes4"
  },
  "comment": "comment6",
  "secure": false
}
```

