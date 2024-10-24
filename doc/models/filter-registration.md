
# Filter Registration

## Structure

`FilterRegistration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServletNameMappings` | `List<string>` | Optional | - |
| `UrlPatternMappings` | `List<string>` | Optional | - |
| `Name` | `string` | Optional | - |
| `ClassName` | `string` | Optional | - |
| `InitParameters` | `Dictionary<string, string>` | Optional | - |

## Example (as JSON)

```json
{
  "servletNameMappings": [
    "servletNameMappings4",
    "servletNameMappings3",
    "servletNameMappings2"
  ],
  "urlPatternMappings": [
    "urlPatternMappings9",
    "urlPatternMappings0"
  ],
  "name": "name0",
  "className": "className6",
  "initParameters": {
    "key0": "initParameters4",
    "key1": "initParameters3",
    "key2": "initParameters2"
  }
}
```

