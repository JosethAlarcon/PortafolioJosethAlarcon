# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY Portafolio/*.csproj ./Portafolio/
WORKDIR /src/Portafolio
RUN dotnet restore

COPY Portafolio/. ./
RUN dotnet publish -c Release -o /app/publish --no-restore

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:$PORT

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "Portafolio.dll"]
