
# Class Loader

## Structure

`ClassLoader`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `RegisteredAsParallelCapable` | `bool?` | Optional | - |
| `Parent` | [`Parent`](../../doc/models/parent.md) | Optional | - |
| `UnnamedModule` | [`UnnamedModule`](../../doc/models/unnamed-module.md) | Optional | - |
| `DefinedPackages` | [`List<DefinedPackage>`](../../doc/models/defined-package.md) | Optional | - |
| `DefaultAssertionStatus` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name2",
  "registeredAsParallelCapable": false,
  "parent": {
    "name": "name0",
    "registeredAsParallelCapable": false,
    "unnamedModule": {
      "name": "name0",
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
    },
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
      }
    ],
    "defaultAssertionStatus": false
  },
  "unnamedModule": {
    "name": "name0",
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
  },
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
    }
  ]
}
```

