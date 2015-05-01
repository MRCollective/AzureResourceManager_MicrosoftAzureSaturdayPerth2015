Param(
    [string] [Parameter(Mandatory = $true)] $SubscriptionId,
    $Location = "Southeast Asia",
    $ResourceGroupName = "AzureSaturdayPerth2015"
)

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

New-AzureResourceGroupDeployment -ResourceGroupName $ResourceGroupName `
    -TemplateFile (Join-Path $PSScriptRoot "azuredeploy.json") `
    -TemplateParameterFile (Join-Path $PSScriptRoot "azuredeploy.parameters.json") `
    -Name ("AzureSaturdayPerth2015Api" + (Get-Date -Format "yyyy-MM-dd-HH-mm-ss")) `
    -ErrorAction Continue
