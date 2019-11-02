FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src

COPY scripts scripts/

COPY HereIAmLordAPI/HereIAmLordAPIAccount.csproj HereIAmLordAPI/
COPY WebHostCustomization/WebHost.Customization/WebHost.Customization.csproj WebHostCustomization/WebHost.Customization/
COPY */*.csproj /csproj-files/



COPY . .
WORKDIR "./HereIAmLordAPI"
RUN dotnet publish -c Release -o /app

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HereIAmLordAPIAccount.dll"]
