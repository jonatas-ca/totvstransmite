FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

RUN mkdir /app

WORKDIR /app

COPY api.portal.csproj .

RUN dotnet restore

COPY . .

RUN dotnet publish -c Release -o dist

EXPOSE 80/tcp

CMD ["dotnet", "dist/api.portal.dll"]

