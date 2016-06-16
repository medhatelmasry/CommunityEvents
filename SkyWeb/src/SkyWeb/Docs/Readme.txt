http://benjii.me/2016/05/dotnet-ef-migrations-for-asp-net-core/

****************************** SkyConcext ********************************

POWERSHELL >> add-migration -context SkyContext "ModelSnapshot"
COMMANDLINE >> dotnet ef migrations add --context SkyContext FirstMigration

POWERSHELL >> update-database -context SkyContext
COMMANDLINE >> dotnet ef database update --context SkyContext

****************************** ApplicationDbConcext ********************************

POWERSHELL >> add-migration -context ApplicationDbContext "FirstMigration"
COMMANDLINE >> dotnet ef migrations add --context ApplicationDbContext FirstMigration

POWERSHELL >> update-database -context ApplicationDbContext
COMMANDLINE >> dotnet ef database update --context ApplicationDbContext

