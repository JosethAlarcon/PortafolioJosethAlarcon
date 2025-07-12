# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o /app/publish --no-restore

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

# Usar el puerto dinámico asignado por Render
ENV ASPNETCORE_URLS=http://+:$PORT

COPY --from=build /app/publish .

# Exponer puerto dinámico
EXPOSE 8080

ENTRYPOINT ["dotnet", "Portafolio.dll"]
