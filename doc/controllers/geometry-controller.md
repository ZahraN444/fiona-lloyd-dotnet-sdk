# Geometry-Controller

```csharp
GeometryController geometryController = client.GeometryController;
```

## Class Name

`GeometryController`


# Geometry Validate

```csharp
GeometryValidateAsync(
    Models.GeometryValidateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GeometryValidateRequest`](../../doc/models/geometry-validate-request.md) | Body, Required | - |

## Response Type

[`Task<Models.GeometryValidationResponse>`](../../doc/models/geometry-validation-response.md)

## Example Usage

```csharp
GeometryValidateRequest body = new GeometryValidateRequest
{
    Boundary = GeometryValidateRequestBoundary.FromLineRepresentation(
        new LineRepresentation
        {
            MValue = new List<Point2D>
            {
                new Point2D
                {
                    X = 29.38,
                    Y = 160.66,
                },
            },
            Type = "LineRepresentation",
        }
    ),
};

try
{
    GeometryValidationResponse result = await geometryController.GeometryValidateAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |
| 404 | Not Found | [`ErrorMessageException`](../../doc/models/error-message-exception.md) |

