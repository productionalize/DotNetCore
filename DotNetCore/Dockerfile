FROM microsoft/dotnet:2.1-runtime-deps-alpine

COPY release/ .
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000/tcp
CMD ["./DotNetCore"]