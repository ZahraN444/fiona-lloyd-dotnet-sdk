
# Unnamed Module

## Structure

`UnnamedModule`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `ClassLoader` | [`ClassLoader1`](../../doc/models/class-loader-1.md) | Optional | - |
| `Descriptor` | [`Descriptor`](../../doc/models/descriptor.md) | Optional | - |
| `Named` | `bool?` | Optional | - |
| `Annotations` | `object` | Optional | - |
| `DeclaredAnnotations` | `object` | Optional | - |
| `Packages` | `List<string>` | Optional | **Constraints**: *Unique Items Required* |
| `Layer` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name6",
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
  "descriptor": {
    "open": false,
    "automatic": false
  },
  "named": false,
  "annotations": [
    {
      "key1": "val1",
      "key2": "val2"
    }
  ]
}
```

