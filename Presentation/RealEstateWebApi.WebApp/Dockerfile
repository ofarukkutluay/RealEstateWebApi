#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5132
EXPOSE 7132

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Presentation/RealEstateWebApi.WebApp/RealEstateWebApi.WebApp.csproj", "Presentation/RealEstateWebApi.WebApp/"]
RUN dotnet restore "Presentation/RealEstateWebApi.WebApp/RealEstateWebApi.WebApp.csproj"
COPY . .
WORKDIR "/src/Presentation/RealEstateWebApi.WebApp"
RUN dotnet build "RealEstateWebApi.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RealEstateWebApi.WebApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RealEstateWebApi.WebApp.dll"]