# EF Core 7 and Postgres Database
### Install EF TOOL
dotnet tool install --global dotnet-ef
Or
dotnet tool update --global dotnet-ef

Move to MM.DataAccess
### Add new migration
dotnet ef --startup-project ../MM.Api/ migrations add IntialMigration
### Update Database
dotnet ef --startup-project ../MM.Api/ database update