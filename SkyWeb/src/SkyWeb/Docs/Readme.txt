http://benjii.me/2016/05/dotnet-ef-migrations-for-asp-net-core/

https://azure.microsoft.com/en-us/documentation/articles/vs-azure-tools-docker-hosting-web-apps-in-docker

https://blogs.msdn.microsoft.com/appserviceteam/2016/05/24/azure-app-service-and-asp-net-core-rc2/

https://azure.microsoft.com/en-us/documentation/articles/app-service-deploy-local-git/

mzem		>>		C0ptic!!

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

