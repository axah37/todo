Tools
1. dotnet cli
2. dotnet tool install --global dotnet-ef (EF Core CLI extension)

Project Commands

1. dotnet new webapp --auth Windows --no-https
2. dotnet add package Microsoft.EntityFrameworkCore.SqlServer (For database connection)
3. dotnet add package Microsoft.EntityFrameworkCore.Design (For migrations)
4. dotnet ef migrations add Initial (create migration)
5. dotnet ef database update (create db and tables)

Run Commands
1. dotnet watch run