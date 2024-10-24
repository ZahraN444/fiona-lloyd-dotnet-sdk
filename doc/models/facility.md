
# Facility

## Structure

`Facility`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `Name` | `string` | Required | - |
| `Buildings` | [`List<Building>`](../../doc/models/building.md) | Optional | - |
| `WholeFacilityWKT` | `string` | Optional | - |
| `Cameras` | [`List<Camera>`](../../doc/models/camera.md) | Optional | - |
| `FacilityScopedRegions` | [`List<Region>`](../../doc/models/region.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "00000a3c-0000-0000-0000-000000000000",
  "name": "name0",
  "buildings": [
    {
      "id": "000019ee-0000-0000-0000-000000000000",
      "name": "name8",
      "floors": [
        {
          "id": "00001ee2-0000-0000-0000-000000000000",
          "level": 52,
          "commonAreaWKT": "commonAreaWKT8",
          "wholeFloorWKT": "wholeFloorWKT6",
          "bottomLimit": 85.32,
          "regions": [
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            },
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            }
          ]
        },
        {
          "id": "00001ee2-0000-0000-0000-000000000000",
          "level": 52,
          "commonAreaWKT": "commonAreaWKT8",
          "wholeFloorWKT": "wholeFloorWKT6",
          "bottomLimit": 85.32,
          "regions": [
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            },
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            }
          ]
        },
        {
          "id": "00001ee2-0000-0000-0000-000000000000",
          "level": 52,
          "commonAreaWKT": "commonAreaWKT8",
          "wholeFloorWKT": "wholeFloorWKT6",
          "bottomLimit": 85.32,
          "regions": [
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            },
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            }
          ]
        }
      ]
    },
    {
      "id": "000019ee-0000-0000-0000-000000000000",
      "name": "name8",
      "floors": [
        {
          "id": "00001ee2-0000-0000-0000-000000000000",
          "level": 52,
          "commonAreaWKT": "commonAreaWKT8",
          "wholeFloorWKT": "wholeFloorWKT6",
          "bottomLimit": 85.32,
          "regions": [
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            },
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            }
          ]
        },
        {
          "id": "00001ee2-0000-0000-0000-000000000000",
          "level": 52,
          "commonAreaWKT": "commonAreaWKT8",
          "wholeFloorWKT": "wholeFloorWKT6",
          "bottomLimit": 85.32,
          "regions": [
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            },
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            }
          ]
        },
        {
          "id": "00001ee2-0000-0000-0000-000000000000",
          "level": 52,
          "commonAreaWKT": "commonAreaWKT8",
          "wholeFloorWKT": "wholeFloorWKT6",
          "bottomLimit": 85.32,
          "regions": [
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            },
            {
              "id": "00000866-0000-0000-0000-000000000000",
              "name": "name0",
              "geometryWKT": "geometryWKT0",
              "category": "whole_facility",
              "features": [
                {
                  "id": "00001eae-0000-0000-0000-000000000000",
                  "name": "name4",
                  "geometryWKT": "geometryWKT6",
                  "category": "opportunity_area"
                }
              ],
              "parentId": "00000a3c-0000-0000-0000-000000000000"
            }
          ]
        }
      ]
    }
  ],
  "wholeFacilityWKT": "wholeFacilityWKT8",
  "cameras": [
    {
      "id": "00002026-0000-0000-0000-000000000000",
      "name": "name0",
      "floorId": "00000556-0000-0000-0000-000000000000",
      "buildingId": "000022b8-0000-0000-0000-000000000000",
      "azimuthRad": 67.46,
      "fieldOfViewRad": 176.5,
      "rangeMeters": 61.02
    },
    {
      "id": "00002026-0000-0000-0000-000000000000",
      "name": "name0",
      "floorId": "00000556-0000-0000-0000-000000000000",
      "buildingId": "000022b8-0000-0000-0000-000000000000",
      "azimuthRad": 67.46,
      "fieldOfViewRad": 176.5,
      "rangeMeters": 61.02
    },
    {
      "id": "00002026-0000-0000-0000-000000000000",
      "name": "name0",
      "floorId": "00000556-0000-0000-0000-000000000000",
      "buildingId": "000022b8-0000-0000-0000-000000000000",
      "azimuthRad": 67.46,
      "fieldOfViewRad": 176.5,
      "rangeMeters": 61.02
    }
  ],
  "facilityScopedRegions": [
    {
      "id": "000011b0-0000-0000-0000-000000000000",
      "name": "name8",
      "geometryWKT": "geometryWKT2",
      "category": "ad_signage",
      "features": [
        {
          "id": "00001eae-0000-0000-0000-000000000000",
          "name": "name4",
          "geometryWKT": "geometryWKT6",
          "category": "opportunity_area"
        },
        {
          "id": "00001eae-0000-0000-0000-000000000000",
          "name": "name4",
          "geometryWKT": "geometryWKT6",
          "category": "opportunity_area"
        }
      ],
      "parentId": "000000f2-0000-0000-0000-000000000000"
    }
  ]
}
```

