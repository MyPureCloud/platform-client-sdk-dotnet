---
title: BillingApi
---
## PureCloudPlatform.Client.V2.Api.BillingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetBillingReportsBillableusage**](BillingApi.html#getbillingreportsbillableusage) | **GET** /api/v2/billing/reports/billableusage | Get a report of the billable usages (e.g. licenses and devices utilized) for a given period. |
{: class="table table-striped"}

<a name="getbillingreportsbillableusage"></a>

## [**BillingUsageReport**](BillingUsageReport.html) GetBillingReportsBillableusage (DateTime? startDate, DateTime? endDate)



Get a report of the billable usages (e.g. licenses and devices utilized) for a given period.



Requires ANY permissions: 

* billing:subscription:read
* billing:subscription:view
* billing:subscription:create
* billing:subscription:add

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBillingReportsBillableusageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new BillingApi();
            
            
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
            
            
            
            
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
            
            
            

            try
            {
                
                // Get a report of the billable usages (e.g. licenses and devices utilized) for a given period.
                
                BillingUsageReport result = apiInstance.GetBillingReportsBillableusage(startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetBillingReportsBillableusage: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **startDate** | **DateTime?**| The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ |  |
| **endDate** | **DateTime?**| The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ |  |
{: class="table table-striped"}

### Return type

[**BillingUsageReport**](BillingUsageReport.html)

