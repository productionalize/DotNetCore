# Sample DotNetCore WebApi

## Description

This project showcases CI/CD for a standard DotNetCore API. It uses MongoDB for data storage.

## Development

### Setup

Run the following command to set up the database using Docker.

```bash
docker run -d --name mongo -p 27017:27017 mongo

# Load Data
docker build -t seed data/.
docker run --net=host -e host=$MongoInternalDockerIP seed

dotnet run --environment "Development"
```


## Testing
