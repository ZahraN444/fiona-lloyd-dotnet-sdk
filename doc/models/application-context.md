
# Application Context

## Structure

`ApplicationContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Parent` | [`ApplicationContext`](../../doc/models/application-context.md) | Optional | - |
| `Id` | `string` | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `ApplicationName` | `string` | Optional | - |
| `StartupDate` | `long?` | Optional | - |
| `AutowireCapableBeanFactory` | `object` | Optional | - |
| `Environment` | [`Environment`](../../doc/models/environment.md) | Optional | - |
| `BeanDefinitionNames` | `List<string>` | Optional | - |
| `BeanDefinitionCount` | `int?` | Optional | - |
| `ParentBeanFactory` | `object` | Optional | - |
| `ClassLoader` | [`ClassLoader`](../../doc/models/class-loader.md) | Optional | - |

## Example (as JSON)

```json
{
  "parent": {
    "parent": {},
    "id": "id0",
    "displayName": "displayName2",
    "applicationName": "applicationName8",
    "startupDate": 240
  },
  "id": "id0",
  "displayName": "displayName2",
  "applicationName": "applicationName8",
  "startupDate": 202
}
```

