FROM microsoft/dotnet:2.1-sdk AS build

WORKDIR /src
COPY *.csproj .
RUN dotnet restore
COPY . .

RUN dotnet publish -c Release -o /app/alpine -r alpine.3.6-x64

FROM microsoft/dotnet:2.1-runtime-deps-alpine AS base
WORKDIR /app

# Needs libuv for asp.net
RUN apk add --update libuv && \
    cp /usr/lib/libuv.so.1 libuv.so

COPY --from=build /app/alpine .
ENTRYPOINT [ "/app/DotNetCore" ]