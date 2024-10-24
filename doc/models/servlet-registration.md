
# Servlet Registration

## Structure

`ServletRegistration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mappings` | `List<string>` | Optional | - |
| `RunAsRole` | `string` | Optional | - |
| `Name` | `string` | Optional | - |
| `ClassName` | `string` | Optional | - |
| `InitParameters` | `Dictionary<string, string>` | Optional | - |

## Example (as JSON)

```json
{
  "mappings": [
    "mappings2"
  ],
  "runAsRole": "runAsRole4",
  "name": "name4",
  "className": "className0",
  "initParameters": {
    "key0": "initParameters4",
    "key1": "initParameters3"
  }
}
```

