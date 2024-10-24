
# Http Status Code

## Structure

`HttpStatusCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | `bool?` | Optional | - |
| `Is4xxClientError` | `bool?` | Optional | - |
| `Is5xxServerError` | `bool?` | Optional | - |
| `Is1xxInformational` | `bool?` | Optional | - |
| `Is2xxSuccessful` | `bool?` | Optional | - |
| `Is3xxRedirection` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "error": false,
  "is4xxClientError": false,
  "is5xxServerError": false,
  "is1xxInformational": false,
  "is2xxSuccessful": false
}
```

