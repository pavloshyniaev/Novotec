FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Novotec.API/Novotec.API.csproj", "Novotec.API/"]
COPY ["Novotec.DB/Novotec.DB.csproj", "Novotec.DB/"]

RUN dotnet restore "Novotec.API/Novotec.API.csproj"
COPY . .
WORKDIR "/src/Novotec.API"
RUN dotnet build "Novotec.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Novotec.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Novotec.API.dll"]
