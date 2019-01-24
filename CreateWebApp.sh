WebAppName=%1

az group create --name RG-$WebAppName --location northeurope

az appservice plan create --resource-group RG-$WebAppName --name Plan-$WebAppName

az webapp create --resource-group RG-$WebAppName --name App-$WebAppName --plan Plan-$WebAppName

