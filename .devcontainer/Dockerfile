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

# Additional packages for day-to-day development in the container.
