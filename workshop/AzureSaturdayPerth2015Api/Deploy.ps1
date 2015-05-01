Param(
    [string] [Parameter(Mandatory = $true)] $SubscriptionId,
    $Location = "Southeast Asia",
    $ResourceGroupName = "AzureSaturdayPerth2015"
)

Add-Type -Assembly System.Web 
function Get-GeneratedPassword() {
    return [Web.Security.Membership]::GeneratePassword(26, 10)
}

$ErrorActionPreference = "Stop"

Import-Module "C:\Program Files (x86)\Microsoft SDKs\Azure\PowerShell\ServiceManagement\Azure\Azure.psd1"
Switch-AzureMode AzureResourceManager
try {
    Select-AzureSubscription -SubscriptionId $SubscriptionId
    New-AzureResourceGroup -Location $Location -Name $ResourceGroupName -Force | Out-Null
}
catch {
    Add-AzureAccount
    Select-AzureSubscription -SubscriptionId $SubscriptionId
    New-AzureResourceGroup -Location $Location -Name $ResourceGroupName -Force | Out-Null
}

$Parameters = @{
    siteName = "azsatperarmdemoapi";
    hostingPlanName = "AzureSaturdayPerth2015";
    sku = "Free";
    workerSize = "0";
    sqlServerName ="azsatperarmdemoapi";
    sqlServerAdminLogin = "sqladmin";
    sqlDbName = "azsatperarmdemoapi";
    sqlServerAdminPassword = Get-GeneratedPassword;
}

New-AzureResourceGroupDeployment -ResourceGroupName $ResourceGroupName `
    -TemplateFile (Join-Path $PSScriptRoot "azuredeploy.json") `
    -TemplateParameterObject $Parameters `
    -Name ("AzureSaturdayPerth2015Api" + (Get-Date -Format "yyyy-MM-dd-HH-mm-ss")) `
    -ErrorAction Continue
