
# Redirect View

## Structure

`RedirectView`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApplicationContext` | [`ApplicationContext`](../../doc/models/application-context.md) | Optional | - |
| `ServletContext` | [`ServletContext`](../../doc/models/servlet-context.md) | Optional | - |
| `ContentType` | `string` | Optional | - |
| `RequestContextAttribute` | `string` | Optional | - |
| `StaticAttributes` | `object` | Optional | - |
| `ExposePathVariables` | `bool?` | Optional | - |
| `ExposeContextBeansAsAttributes` | `bool?` | Optional | - |
| `ExposedContextBeanNames` | `List<string>` | Optional | - |
| `BeanName` | `string` | Optional | - |
| `Url` | `string` | Optional | - |
| `ContextRelative` | `bool?` | Optional | - |
| `Http10Compatible` | `bool?` | Optional | - |
| `ExposeModelAttributes` | `bool?` | Optional | - |
| `EncodingScheme` | `string` | Optional | - |
| `StatusCode` | [`HttpStatusCode`](../../doc/models/http-status-code.md) | Optional | - |
| `ExpandUriTemplateVariables` | `bool?` | Optional | - |
| `PropagateQueryParams` | `bool?` | Optional | - |
| `Hosts` | `List<string>` | Optional | - |
| `RedirectView` | `bool?` | Optional | - |
| `PropagateQueryProperties` | `bool?` | Optional | - |
| `AttributesMap` | `object` | Optional | - |
| `Attributes` | `Dictionary<string, string>` | Optional | - |
| `AttributesCSV` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "applicationContext": {
    "parent": {
      "parent": {},
      "id": "id0",
      "displayName": "displayName2",
      "applicationName": "applicationName8",
      "startupDate": 240
    },
    "id": "id2",
    "displayName": "displayName0",
    "applicationName": "applicationName6",
    "startupDate": 34
  },
  "servletContext": {
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
    "majorVersion": 246,
    "minorVersion": 222,
    "attributeNames": {
      "key1": "val1",
      "key2": "val2"
    },
    "contextPath": "contextPath6"
  },
  "contentType": "contentType8",
  "requestContextAttribute": "requestContextAttribute4",
  "staticAttributes": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    },
    "key1": {
      "key1": "val1",
      "key2": "val2"
    },
    "key2": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

