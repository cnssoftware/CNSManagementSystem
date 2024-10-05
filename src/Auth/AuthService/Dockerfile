# .NET SDK imajını kullanarak projeyi build ediyoruz
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /Presentation

# Sadece AuthService.API projesini kopyalıyoruz
COPY . .

# Bağımlılıkları yüklüyoruz ve projeyi publish ediyoruz
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# Runtime imajına geçiyoruz
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/publish .

# Uygulamayı başlatıyoruz
ENTRYPOINT ["dotnet", "AuthService.API.dll"]