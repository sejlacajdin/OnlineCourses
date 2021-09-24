FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 5010
ENV ASPNETCORE_URLS=http://+:5010


FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY . .

FROM build AS publish
RUN dotnet publish "OnlineCourseApp.WebAPI" -c Release -o /app
FROM base AS final
WORKDIR /app
ADD ./OnlineCourseApp.WebAPI/Images ./Images
ADD ./OnlineCourseApp.WebAPI/Resources ./Resources
COPY --from=publish /app .

EXPOSE 5010
ENTRYPOINT ["dotnet", "OnlineCourseApp.WebAPI.dll"]