#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["check_odd_even/check_odd_even.csproj", "check_odd_even/"]
RUN dotnet restore "check_odd_even/check_odd_even.csproj"
COPY . .
WORKDIR "/src/check_odd_even"
RUN dotnet build "check_odd_even.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "check_odd_even.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "check_odd_even.dll"]