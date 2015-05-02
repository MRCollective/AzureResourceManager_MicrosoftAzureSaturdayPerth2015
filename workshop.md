# Azure Resource Manager Workshop

## Exercise 1 - deploy a Web App using Azure Resource Manager 

1. Use the Deploy To Azure button on the [Demo site we've created](workshop/DemoSiteToDeploy) to deploy an Azure Web App including the deployment of [our HTML](workshop/DemoSiteToDeploy/DemoSiteToDeploy/index.html)
2. Once it succeeds, find your Web App in the Portal and open it
3. Click on the Register button and look at the presentation screen to see your site pop up!
4. If you click on the Register button subsequent times then it will tell you that you have already registered

Congratulations! You've now used Azure Resource Manager.

The JSON definition for the site you just created can be [found on GitHub](workshop/DemoSiteToDeploy/azuredeploy.json), as can the [JSON definition](workshop/AzureSaturdayPerth2015Api/azuredeploy.json) and [code](workshop/AzureSaturdayPerth2015Api) of the site that hosted the API (that one includes a SQL database and auto-deploy from GitHub!).

## Exercise 2 - deploy a web app with SQL or a VM using Azure Resource Manager from Visual Studio

1. Install Azure SDK 2.6 (2.5 is OK too, but you can only do Web site + sql with that and the intellisense for the JSON template isn't there)
2. Create a new Cloud Deployment project and select either Website + SQL or Virtual Machine
3. Feel free to click on the different files to see how it all pieces together
4. Right click the deployment project and click Deploy and then deploy to Azure

## Exercise 3 - deploy an Azure Key Vault

Azure Key Vault is an exciting service in Azure that allows you to securely store passwords and other secrets and assign fine-grained access permissions based on Azure AD principals. It can only be provisioned using Azure Resource Msnsger. [Follow the tutorial to learn sbout it](http://azure.microsoft.com/en-us/documentation/articles/key-vault-get-started/).
