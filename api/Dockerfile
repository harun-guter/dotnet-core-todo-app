FROM --platform=arm64 mcr.microsoft.com/dotnet/sdk:8.0-alpine
WORKDIR /app
COPY . /app
RUN dotnet build
RUN cd WebApi/bin/Debug/net8.0
EXPOSE 8080
ENTRYPOINT [ "dotnet", "./WebApi/bin/Debug/net8.0/WebApi.dll" ]