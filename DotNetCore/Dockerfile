FROM microsoft/dotnet:2.1-runtime-alpine

COPY DotNetCore/published .
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000/tcp
CMD ["dotnet", "./DotNetCore.dll"]