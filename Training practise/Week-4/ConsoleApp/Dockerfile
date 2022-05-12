FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
    


FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY --from=build-env /app/publish .
CMD dotnet /app/ConsoleApp.dll