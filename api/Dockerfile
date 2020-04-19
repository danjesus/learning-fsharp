# This is your Editor pane. Write the Dockerfile here and
# use the command line to execute commands
FROM ocelotuproar/docker-alpine-fsharp:4.0

RUN         mkdir -p /src
WORKDIR     /src

COPY . /src

# COPY        paket.dependencies /src
# RUN         mono ./.paket/paket.exe install

RUN ./build.sh

EXPOSE      8083
CMD         ["fsharpi", "build.fsx"]
