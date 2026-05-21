FROM mcr.microsoft.com/devcontainers/dotnet:1-10.0

ARG DEBIAN_FRONTEND=noninteractive

RUN rm -f /etc/apt/sources.list.d/yarn.list /etc/apt/sources.list.d/yarn.list.save \
    && apt-get update \
    && apt-get install -y --no-install-recommends \
        bash-completion \
        ca-certificates \
        curl \
        git \
        procps \
        wget \
    && rm -rf /var/lib/apt/lists/*

# Generate and trust ASP.NET Core HTTPS dev certificate
USER vscode
RUN dotnet dev-certs https \
    && dotnet dev-certs https --export-path /tmp/aspnet-dev-cert.crt --format PEM --no-password

USER root
RUN cp /tmp/aspnet-dev-cert.crt /usr/local/share/ca-certificates/ \
    && update-ca-certificates \
    && rm /tmp/aspnet-dev-cert.crt

# Additional packages for day-to-day development in the container.
