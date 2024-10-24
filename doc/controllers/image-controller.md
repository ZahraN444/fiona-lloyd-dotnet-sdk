# Image-Controller

```csharp
ImageController imageController = client.ImageController;
```

## Class Name

`ImageController`

## Methods

* [Image Create](../../doc/controllers/image-controller.md#image-create)
* [Image Get](../../doc/controllers/image-controller.md#image-get)
* [Image Delete](../../doc/controllers/image-controller.md#image-delete)


# Image Create

```csharp
ImageCreateAsync(
    string title,
    string altText,
    FileStreamInfo image)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `title` | `string` | Form, Required | - |
| `altText` | `string` | Form, Required | - |
| `image` | `FileStreamInfo` | Form, Required | - |

## Response Type

`Task<Guid>`

## Example Usage

```csharp
string title = "title4";
string altText = "altText4";
FileStreamInfo image = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    Guid? result = await imageController.ImageCreateAsync(
        title,
        altText,
        image
    );
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


# Image Get

```csharp
ImageGetAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    dynamic result = await imageController.ImageGetAsync(id);
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


# Image Delete

```csharp
ImageDeleteAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    await imageController.ImageDeleteAsync(id);
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

