FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

WORKDIR /app



# ENV ASPNETCORE_URLS=http://+:5001



# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# WORKDIR /src

COPY *.csproj ./

RUN dotnet restore

# COPY . .

# WORKDIR "/src/."

# RUN dotnet build "Puretv.csproj" -c Release -o /app/build

COPY . ./

RUN dotnet publish -c Release -o out




# FROM build AS publish

# RUN dotnet publish "Puretv.csproj" -c Release -o /app/publish /p:UseAppHost=false



# FROM base AS final

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

WORKDIR /app

EXPOSE 80

COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "Puretv.dll"]