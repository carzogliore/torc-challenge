FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release

COPY ["Torc.Common/Torc.Common.csproj", "Torc.Common/"]
COPY ["Torc.Business/Torc.Business.csproj", "Torc.Business/"]
COPY ["Torc.Data/Torc.Data.csproj", "Torc.Data/"]
COPY ["Torc.Api/Torc.Api.csproj", "Torc.Api/"]

RUN dotnet restore "Torc.Api/Torc.Api.csproj"
COPY . .
WORKDIR "/src/Torc.Api"
RUN dotnet build "Torc.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Torc.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Torc.Api.dll"]
