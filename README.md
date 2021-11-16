# Generate OpenApi spec

[![.NET](https://github.com/juzuluag/testmicsvc/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/juzuluag/testmicsvc/actions/workflows/dotnet.yml)

The goal is to generate openapi spec of the `controller`  as part of the build process based on the project's `assembly`. The spec can be done manually, but it opens the windows for high maintenance and also for error prune, since the manual file might not reflect what the service does.
This is using `nswag` packages  based on the configuration file `nswag_v1.json` to generate the open api.

## Add new Project and NSwag dependencies

```sh
dotnet new webapi -n WebApp
dotnet new gitignore
cd WebApp
dotnet add package NSwag.MSBuild --version 13.14.4
dotnet add package NSwag.AspNetCore
dotnet add package Swashbuckle.AspNetCore.Annotations --version 6.2.3
```

## Build project

```sh
dotnet build
```

It would create `openapi_v1.json` openapi spec with what the `controller` is about. This file can be publish as an artifact of the CI pipeline in order to be consumed by a client. An easy way to look at the api is to use for instance [Swagger Editor](https://editor.swagger.io) and check the endpoints.

![image info](./images/gen_openapi.png)

## References

<https://kaylumah.nl/2021/05/23/generate-csharp-client-for-openapi.html>

<https://blog.rsuter.com/versioned-aspnetcore-apis-with-openapi-generation-and-azure-api-management/>

<https://github.com/RicoSuter/NSwag>

<https://editor.swagger.io>