
# Servlet Context

## Structure

`ServletContext`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClassLoader` | [`ClassLoader1`](../../doc/models/class-loader-1.md) | Optional | - |
| `MajorVersion` | `int?` | Optional | - |
| `MinorVersion` | `int?` | Optional | - |
| `AttributeNames` | `object` | Optional | - |
| `ContextPath` | `string` | Optional | - |
| `InitParameterNames` | `object` | Optional | - |
| `SessionTrackingModes` | [`List<SessionTrackingModeEnum>`](../../doc/models/session-tracking-mode-enum.md) | Optional | **Constraints**: *Unique Items Required* |
| `SessionTimeout` | `int?` | Optional | - |
| `ServletRegistrations` | [`Dictionary<string, ServletRegistration>`](../../doc/models/servlet-registration.md) | Optional | - |
| `FilterRegistrations` | [`Dictionary<string, FilterRegistration>`](../../doc/models/filter-registration.md) | Optional | - |
| `SessionCookieConfig` | [`SessionCookieConfig`](../../doc/models/session-cookie-config.md) | Optional | - |
| `DefaultSessionTrackingModes` | [`List<DefaultSessionTrackingModeEnum>`](../../doc/models/default-session-tracking-mode-enum.md) | Optional | **Constraints**: *Unique Items Required* |
| `EffectiveSessionTrackingModes` | [`List<EffectiveSessionTrackingModeEnum>`](../../doc/models/effective-session-tracking-mode-enum.md) | Optional | **Constraints**: *Unique Items Required* |
| `JspConfigDescriptor` | [`JspConfigDescriptor`](../../doc/models/jsp-config-descriptor.md) | Optional | - |
| `VirtualServerName` | `string` | Optional | - |
| `RequestCharacterEncoding` | `string` | Optional | - |
| `ResponseCharacterEncoding` | `string` | Optional | - |
| `EffectiveMajorVersion` | `int?` | Optional | - |
| `EffectiveMinorVersion` | `int?` | Optional | - |
| `ServerInfo` | `string` | Optional | - |
| `ServletContextName` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "classLoader": {
    "name": "name0",
    "registeredAsParallelCapable": false,
    "definedPackages": [
      {
        "name": "name4",
        "annotations": [
          {
            "key1": "val1",
            "key2": "val2"
          }
        ],
        "declaredAnnotations": [
          {
            "key1": "val1",
            "key2": "val2"
          },
          {
            "key1": "val1",
            "key2": "val2"
          },
          {
            "key1": "val1",
            "key2": "val2"
          }
        ],
        "sealed": false,
        "specificationTitle": "specificationTitle6"
      },
      {
        "name": "name4",
        "annotations": [
          {
            "key1": "val1",
            "key2": "val2"
          }
        ],
        "declaredAnnotations": [
          {
            "key1": "val1",
            "key2": "val2"
          },
          {
            "key1": "val1",
            "key2": "val2"
          },
          {
            "key1": "val1",
            "key2": "val2"
          }
        ],
        "sealed": false,
        "specificationTitle": "specificationTitle6"
      },
      {
        "name": "name4",
        "annotations": [
          {
            "key1": "val1",
            "key2": "val2"
          }
        ],
        "declaredAnnotations": [
          {
            "key1": "val1",
            "key2": "val2"
          },
          {
            "key1": "val1",
            "key2": "val2"
          },
          {
            "key1": "val1",
            "key2": "val2"
          }
        ],
        "sealed": false,
        "specificationTitle": "specificationTitle6"
      }
    ],
    "defaultAssertionStatus": false
  },
  "majorVersion": 16,
  "minorVersion": 248,
  "attributeNames": {
    "key1": "val1",
    "key2": "val2"
  },
  "contextPath": "contextPath8"
}
```

