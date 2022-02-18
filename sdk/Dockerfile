FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Scheduler.Sdk.sln /usr/src/
COPY Finbourne.Scheduler.Sdk/Finbourne.Scheduler.Sdk.csproj /usr/src/Finbourne.Scheduler.Sdk/
RUN dotnet restore Finbourne.Scheduler.Sdk

ENV FBN_SCHEDULER_API_URL ${FBN_SCHEDULER_API_URL}

# ENTRYPOINT [ "/bin/bash" ]
ENTRYPOINT dotnet build --configuration Release --verbosity normal Finbourne.Scheduler.Sdk