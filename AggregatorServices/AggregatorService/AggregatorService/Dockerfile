FROM microsoft/dotnet:3.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:3.1-sdk AS build
WORKDIR /src
COPY ["AggregatorService/AggregatorService.csproj", "AggregatorService/"]
RUN dotnet restore "AggregatorService/AggregatorService.csproj"
COPY . .
WORKDIR "/src/AggregatorService"
RUN dotnet build "AggregatorService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AggregatorService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AggregatorService.dll"]