# User-Controller

```csharp
UserController userController = client.UserController;
```

## Class Name

`UserController`

## Methods

* [User Get My Organizations](../../doc/controllers/user-controller.md#user-get-my-organizations)
* [User Find by Id](../../doc/controllers/user-controller.md#user-find-by-id)


# User Get My Organizations

```csharp
UserGetMyOrganizationsAsync()
```

## Response Type

[`Task<List<Models.OrganizationItem>>`](../../doc/models/organization-item.md)

## Example Usage

```csharp
try
{
    List<OrganizationItem> result = await userController.UserGetMyOrganizationsAsync();
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


# User Find by Id

```csharp
UserFindByIdAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Query, Required | - |

## Response Type

[`Task<Models.UserResponse>`](../../doc/models/user-response.md)

## Example Usage

```csharp
string id = "id0";
try
{
    UserResponse result = await userController.UserFindByIdAsync(id);
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

