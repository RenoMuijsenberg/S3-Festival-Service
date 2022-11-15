# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY FestivalService.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish "FestivalService.csproj" -c Release -o out
    
    
# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /src/out .
ENTRYPOINT [ "dotnet", "./FestivalService.dll" ]