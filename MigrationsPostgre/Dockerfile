#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MigrationsPostgre/MigrationsPostgre.csproj", "MigrationsPostgre/"]
RUN dotnet restore "MigrationsPostgre/MigrationsPostgre.csproj"
COPY . .
WORKDIR "/src/MigrationsPostgre"
RUN dotnet build "MigrationsPostgre.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MigrationsPostgre.csproj" -c Release -o /app/publish

#RUN dotnet tool install --global dotnet-ef --version 3.1.2
#ENV PATH="${PATH}:/root/.dotnet/tools"

#CMD ["dotnet", "ef", "--project", "MigrationsPostgre", "database", "update"]

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MigrationsPostgre.dll"]