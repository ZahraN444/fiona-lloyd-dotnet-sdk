# Naics-Code-Controller

```csharp
NaicsCodeController naicsCodeController = client.NaicsCodeController;
```

## Class Name

`NaicsCodeController`

## Methods

* [Naics Code Search](../../doc/controllers/naics-code-controller.md#naics-code-search)
* [Naics Code Get by Code](../../doc/controllers/naics-code-controller.md#naics-code-get-by-code)


# Naics Code Search

```csharp
NaicsCodeSearchAsync(
    int? page = 0,
    int? size = 20,
    List<string> sort = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Zero-based page index (0..N)<br>**Default**: `0`<br>**Constraints**: `>= 0` |
| `size` | `int?` | Query, Optional | The size of the page to be returned<br>**Default**: `20`<br>**Constraints**: `>= 1` |
| `sort` | `List<string>` | Query, Optional | Sorting criteria in the format: property,(asc\|desc). Default sort order is ascending. Multiple sort criteria are supported. |

## Response Type

[`Task<Models.PageNaicsCodeResponse>`](../../doc/models/page-naics-code-response.md)

## Example Usage

```csharp
int? page = 0;
int? size = 20;
try
{
    PageNaicsCodeResponse result = await naicsCodeController.NaicsCodeSearchAsync(
        page,
        size
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


# Naics Code Get by Code

```csharp
NaicsCodeGetByCodeAsync(
    string code)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `code` | `string` | Template, Required | - |

## Response Type

[`Task<Models.NaicsCode>`](../../doc/models/naics-code.md)

## Example Usage

```csharp
string code = "code8";
try
{
    NaicsCode result = await naicsCodeController.NaicsCodeGetByCodeAsync(code);
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

