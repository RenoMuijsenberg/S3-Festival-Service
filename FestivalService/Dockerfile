FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY FestivalService.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish "FestivalService.csproj" -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app .

EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "./FestivalService.dll"]