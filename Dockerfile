# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copiar archivos de proyecto y restaurar dependencias
COPY *.csproj .
RUN dotnet restore

# Copiar todo el código y compilar
COPY . .
RUN dotnet publish -c Release -o out

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/out .

# Exponer puerto 80
EXPOSE 80

# Comando para ejecutar la app
ENTRYPOINT ["dotnet", "Portafolio.dll"]
