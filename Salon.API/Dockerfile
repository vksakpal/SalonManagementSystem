#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Salon.API/Salon.API.csproj", "Salon.API/"]
COPY ["Salon.DataLayer/Salon.DataLayer.csproj", "Salon.DataLayer/"]
COPY ["Salon.Domain/Salon.Domain.csproj", "Salon.Domain/"]
COPY ["Salon.AppLayer/Salon.AppLayer.csproj", "Salon.AppLayer/"]
RUN dotnet restore "Salon.API/Salon.API.csproj"
COPY . .
WORKDIR "/src/Salon.API"
RUN dotnet build "Salon.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Salon.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Salon.API.dll"]