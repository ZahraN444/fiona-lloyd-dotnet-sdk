
# Class Loader 1

## Structure

`ClassLoader1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `RegisteredAsParallelCapable` | `bool?` | Optional | - |
| `DefinedPackages` | [`List<DefinedPackage>`](../../doc/models/defined-package.md) | Optional | - |
| `DefaultAssertionStatus` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name6",
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
}
```

