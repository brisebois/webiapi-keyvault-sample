# Where to get the report APIs
Start-Process "https://docs.microsoft.com/en-us/rest/api/apimanagement/reports"

# Login to armclient a convenient way to programmatically call into 
armclient login

# Fetch an example report
$baseUrl='/subscriptions/64668628-d5e6-4c5b-9be4-9e577d5b8fd0/resourceGroups/apim-demo/providers/Microsoft.ApiManagement/service/albrisebapidemo/reports/'
$filter='timestamp ge datetime''2018-01-01T00:00:00'' and timestamp le datetime''2018-06-02T00:00:00'''
$filterEncoded='$filter=' + [System.Web.HttpUtility]::UrlEncode($filter) 
$apiVersion='api-version=2018-01-01'

$reportApi='byApi'
$url="$($baseUrl)$($reportApi)?$filterEncoded&$apiVersion"
$report = armclient get $url | Out-String
(ConvertFrom-Json -InputObject $report).value | Format-Table

$reportApi='byUser'
$url="$($baseUrl)$($reportApi)?$filterEncoded&$apiVersion"
$report = armclient get $url | Out-String
(ConvertFrom-Json -InputObject $report).value | Format-Table

$reportApi='bySubscription'
$url="$($baseUrl)$($reportApi)?$filterEncoded&$apiVersion"
$report = armclient get $url | Out-String
(ConvertFrom-Json -InputObject $report).value | Format-Table

# Query Application Insights
Start-Process https://analytics.applicationinsights.io/subscriptions/64668628-d5e6-4c5b-9be4-9e577d5b8fd0/resourcegroups/apim-demo/components/albrisebapidemo-apim