# Generate OpenApi spec

The goal is to generate openapi spec of the `controller` based on the project's `assembly`.
This is using `nswag` packages  based on the configuration file `nswag_v1.json` to generate the open api.

## Add new Project and NSwag dependencies

```sh
dotnet new webapi -n WebApp
dotnet new gitignore
dotnet add package NSwag.MSBuild --version 13.14.4
dotnet add package NSwag.AspNetCore
dotnet add package Swashbuckle.AspNetCore.Annotations --version 6.2.3
```

## Build project

```sh
dotnet build
```

It would create a file `openapi_v1.json` with the basic information about the `controller`

## References

<https://kaylumah.nl/2021/05/23/generate-csharp-client-for-openapi.html>
<https://blog.rsuter.com/versioned-aspnetcore-apis-with-openapi-generation-and-azure-api-management/>
