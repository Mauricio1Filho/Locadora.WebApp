# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /build

# Copia o restante dos arquivos do projeto
COPY . /build

# Restaura as dependências usando o dotnet restore
RUN dotnet restore

# Publica o projeto
RUN dotnet publish src/Locadora.WebApp/Locadora.WebApp.csproj -c RELEASE --self-contained -r linux-x64 -o src/out

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:6.0

RUN sed -i 's/CipherString = DEFAULT@SECLEVEL=2/CipherString = DEFAULT@SECLEVEL=1/' /etc/ssl/openssl.cnf

WORKDIR /app

# Copia os artefatos publicados do estágio de build
COPY --from=build /build/src/out ./

# Adiciona o script de inicialização
COPY entrypoint.sh /app/entrypoint.sh
RUN chmod +x /app/entrypoint.sh

ARG ASPNETCORE_ENVIRONMENT
ENV ASPNETCORE_ENVIRONMENT=$ASPNETCORE_ENVIRONMENT
EXPOSE 80

# Define o comando de inicialização
ENTRYPOINT ["/app/entrypoint.sh"]

CMD ["dotnet", "Locadora.WebApp.dll"]
