FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["SmartHome.API/SmartHome.API.csproj", "SmartHome.API/"]
COPY ["SmartHome.Application/SmartHome.Application.csproj", "SmartHome.Application/"]
COPY ["SmartHome.Infrastructure/SmartHome.Infrastructure.csproj", "SmartHome.Infrastructure/"]
COPY ["SmartHome.Core/SmartHome.Core.csproj", "SmartHome.Core/"]
RUN dotnet restore "SmartHome.API/SmartHome.API.csproj"

COPY . .
WORKDIR "/src/SmartHome.API"
RUN dotnet publish "SmartHome.API.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "SmartHome.API.dll"]