# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copiar archivos de proyecto y restaurar dependencias
COPY *.csproj ./
RUN dotnet restore

# Copiar todo el código y compilar para producción
COPY . ./
RUN dotnet publish -c Release -o /out --no-restore

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

# Configurar el puerto dinámico que Render asigna
ENV ASPNETCORE_URLS=http://+:$PORT

# Copiar archivos publicados desde la etapa de build
COPY --from=build /out ./

# Exponer puerto (opcional para Render)
EXPOSE 80

# Comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "Portafolio.dll"]
