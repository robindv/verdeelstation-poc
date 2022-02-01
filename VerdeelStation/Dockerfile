FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["VerdeelStation/VerdeelStation.csproj", "VerdeelStation/"]
RUN dotnet restore "VerdeelStation/VerdeelStation.csproj"
COPY . .
WORKDIR "/src/VerdeelStation"
RUN dotnet build "VerdeelStation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VerdeelStation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VerdeelStation.dll"]
