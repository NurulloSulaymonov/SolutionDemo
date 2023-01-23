FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Query/Query.csproj", "Query/"]
RUN dotnet restore "Query/Query.csproj"
COPY . .
WORKDIR "/src/Query"
RUN dotnet build "Query.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Query.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Query.dll"]
