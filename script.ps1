# Mangement APIs
# https://docs.microsoft.com/en-us/rest/api/apimanagement/

Connect-AzureRmAccount

# Get Admin URL
Get-AzureRmApiManagementSsoToken -ResourceGroupName 'apim-demo' -Name 'albrisebapidemo'