#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5045
EXPOSE 7045

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Presentation/RealEstateWebApi.WebApi/RealEstateWebApi.WebApi.csproj", "Presentation/RealEstateWebApi.WebApi/"]
COPY ["Infrastructure/RealEstateWebApi.Infrastructure/RealEstateWebApi.Infrastructure.csproj", "Infrastructure/RealEstateWebApi.Infrastructure/"]
COPY ["Core/RealEstateWebApi.Application/RealEstateWebApi.Application.csproj", "Core/RealEstateWebApi.Application/"]
COPY ["Core/RealEstateWebApi.Domain/RealEstateWebApi.Domain.csproj", "Core/RealEstateWebApi.Domain/"]
COPY ["Infrastructure/RealEstateWebApi.Persistence/RealEstateWebApi.Persistence.csproj", "Infrastructure/RealEstateWebApi.Persistence/"]
RUN dotnet restore "Presentation/RealEstateWebApi.WebApi/RealEstateWebApi.WebApi.csproj"
COPY . .
WORKDIR "/src/Presentation/RealEstateWebApi.WebApi"
RUN dotnet build "RealEstateWebApi.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RealEstateWebApi.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RealEstateWebApi.WebApi.dll"]