Entity Framework Introduction
------------------------------------
Basic Program to -
    1. Connect to Postgres DB
    2. Code-First approach in creating Table
    3. Read/Write operation to DB

Steps - 
-------------------------------------
1. Run postgres DB n check via pgAdmin UI
        docker run --name postgres -e POSTGRES_PASSWORD=password -p 5432:5432 -d postgres:latest
        docker run -p 80:80 -e 'PGADMIN_DEFAULT_EMAIL=user@domain.com' -e 'PGADMIN_DEFAULT_PASSWORD=SuperSecret' -d dpage/pgadmin4
        Note: Hostname = docker inspect <postgres-dockerContainerId> | grep IPAddress

2. Install EF Framework (if not already installed)
        dotnet tool install --global dotnet-ef

3. Create Migration script using - 
        dotnet ef migrations add InitialState
        dotnet ef database update

4. Run the program.