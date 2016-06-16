http://benjii.me/2016/05/dotnet-ef-migrations-for-asp-net-core/

POWERSHELL >> add-migration -context SkyContext "FirstMigration"
COMMANDLINE >> dotnet ef migrations add --context SkyContext FirstMigration

POWERSHELL >> update-database -context SkyContext
COMMANDLINE >> dotnet ef database update --context SkyContext
