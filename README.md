## Microservice Project with Docker and SQL Database

#### docker-compose.yml
```
version: '3.5'
services:
  ProductService:
   image: ${DOCKER_REGISTRY-}producstmicroservice:v1
   build:
    context: .
    dockerfile: ProductMicroservice/Dockerfile
   environment:
    - CONNECTIONSTRINGS__DEFAULTCONNECTION=Data Source=192.168.0.104,1433;Initial Catalog=ProductServiceDB;User Id=sa;Password=data!2019;Encrypt=True;TrustServerCertificate=True;
   ports:
    - "4201:8080"
  UserService:
   image: ${DOCKER_REGISTRY-}usersmicroservice:v1
   build:
    context: .
    dockerfile: UserMicroservice/Dockerfile
   environment:
    - CONNECTIONSTRINGS__DEFAULTCONNECTION=Data Source=192.168.0.104,1433;Initial Catalog=UserServiceDB;User Id=sa;Password=data!2019;Encrypt=True;TrustServerCertificate=True;
   ports:
    - "4202:8080"
```

#### CMD command

```
docker-compose build
docker-compose up
```

###### Ref https://www.c-sharpcorner.com/article/implementation-and-containerization-of-microservices-using-net-core-6-and-docke/


