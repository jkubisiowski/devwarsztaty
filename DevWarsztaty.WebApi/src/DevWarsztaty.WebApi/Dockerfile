﻿FROM microsoft/dotnet:1.0-sdk-projectjson
COPY . /app
WORKDIR /app

RUN ["dotnet", "restore", "--source", "https://api.nuget.org/v3/index.json", "--source", "https://www.myget.org/F/devwarsztaty-jkubisiowski/api/v3/index.json", "--no-cache"]
RUN ["dotnet", "build"]

EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000
ENV ASPNETCORE_ENVIRONMENT Docker

ENTRYPOINT ["dotnet", "run"]