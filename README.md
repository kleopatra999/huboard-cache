#How to build

You need mono `brew install mono`

I'm using VSCode + Ionide

```
npm install -g foreman
```

You will need a postgres database. By default the app looks for its connection string
in the environment variable `DATABASE_URL`.

#API

`~/cache/<owner>/<repo>/issues/<issueid>` - gets and caches (forever) a github issue

### Scripts

#### Set Up Database

In `~/migrations/up` are a set of SQL files you can run to construct the database

You will need to run them as admin. they create the user and database.

#### Compile Code

`./build.sh`

#### Run Tests
`./build.sh test`

#### Run App
`./run.sh`

or

`foreman start` - if ruby based

or

`nf start` - if node based

or

`docker run -t -p 5000:5000 cache` (cache is what i named my docker image)

Syntax note: in the `-p <host machine port>:<container port>`

or

`./run.sh docker`

### Build Docker Image

#### Setup Docker

##### with Docker Beta

Install the [Docker Beta](https://beta.docker.com/)

##### with boot2docker (OSX)

`brew install boot2docker` (It's vagrant for Docker containers, uses the hosts docker binary in a tiny VM)

`boot2docker init`

`boot2docker up` (Follow the trailing instructions for ENV vars OR cert install)

#### Build the docker image
`./build.sh docker`

### Docker Compose

There is also a Docker compose file (`docker-compose.yml`) that can be used to spin up
the postgres database for getting the full hosted experience.

`docker-compose build`

`docker-compose up`

#### Ports

`http://localhost:5000` for the website

`postgresql://localhost:5433/hucache` for the postgres instance (Connect with username `huboard` and password `huboard`)
