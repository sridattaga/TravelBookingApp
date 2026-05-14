FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:5000

COPY publish/ .
ENTRYPOINT ["dotnet", "TravelBooking.Web.dll"]
