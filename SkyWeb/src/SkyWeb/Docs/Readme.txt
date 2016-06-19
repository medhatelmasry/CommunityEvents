http://benjii.me/2016/05/dotnet-ef-migrations-for-asp-net-core/

https://azure.microsoft.com/en-us/documentation/articles/vs-azure-tools-docker-hosting-web-apps-in-docker

https://blogs.msdn.microsoft.com/appserviceteam/2016/05/24/azure-app-service-and-asp-net-core-rc2/

https://azure.microsoft.com/en-us/documentation/articles/app-service-deploy-local-git/

Deploy an ASP.NET Core web app to Azure using Visual Studio
	https://docs.asp.net/en/latest/tutorials/publish-to-azure-webapp-using-vs.html

Publishing to an Azure Web App with Continuous Deployment
	https://docs.asp.net/en/latest/publishing/azure-continuous-deployment.html

Publishing to IIS
	https://docs.asp.net/en/latest/publishing/iis.html

Publishing to IIS with Web Deploy using Visual Studio
	https://docs.asp.net/en/latest/publishing/iis-with-msdeploy.html

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

============================ NOTE ON MIGRATIONS ON AZURE ======================================
After deploying app to azure, make sure you run the migrations after pointing to the azure database in the connection string.

============================ URLs ===================================
http://skywardweb.azurewebsites.net/api/activity

