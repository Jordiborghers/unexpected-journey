Set WebAppName=%1

call az group create --name RG-%WebAppName% --location northeurope

call az appservice plan create --resource-group RG-%WebAppName% --name Plan-%WebAppName%

call az webapp create --resource-group RG-%WebAppName% --name App-%WebAppName% --plan Plan-%WebAppName%

