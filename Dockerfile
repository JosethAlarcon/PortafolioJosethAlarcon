# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o /out --no-restore

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

# Render asigna un puerto dinámico con la variable $PORT
ENV ASPNETCORE_URLS=http://+:$PORT

COPY --from=build /out ./

# Exponer puerto para Render
EXPOSE 8080

ENTRYPOINT ["dotnet", "Portafolio.dll"]
