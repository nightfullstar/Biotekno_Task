#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Biotekno_Task.Api/Biotekno_Task.Api.csproj", "Biotekno_Task.Api/"]
RUN dotnet restore "Biotekno_Task.Api/Biotekno_Task.Api.csproj"
COPY . .
WORKDIR "/src/Biotekno_Task.Api"
RUN dotnet build "Biotekno_Task.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Biotekno_Task.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Biotekno_Task.Api.dll"]