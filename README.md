# Entity Framework Introduction

Basic Program to -
 * Connect to Postgres DB
 * Code-First approach in creating Table
 * Read/Write operation to DB

### Steps -

1. Run postgres DB n check via pgAdmin UI
```bash
        docker run --name postgres -e POSTGRES_PASSWORD=password -p 5432:5432 -d postgres:latest
        docker run -p 80:80 -e 'PGADMIN_DEFAULT_EMAIL=user@domain.com' -e 'PGADMIN_DEFAULT_PASSWORD=SuperSecret' -d dpage/pgadmin4
```
   
**Note:** Command to get Database ***Hostname*** used in pgAdmin

```bash
 docker inspect <postgres-dockerContainerId> | grep IPAddress
```

2. Install EF Framework (if not already installed)
```bash
        dotnet tool install --global dotnet-ef
```
3. Create Migration script using - 
```bash
        dotnet ef migrations add InitialState

        dotnet ef database update
```
4. Run the program.

## Output -


![img.jpg](https://github.com/ayanNullPointerEx/EfExample/blob/master/img.jpg)
