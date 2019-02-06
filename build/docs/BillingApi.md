---
title: BillingApi
---
## PureCloudPlatform.Client.V2.Api.BillingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetBillingReportsBillableusage**](BillingApi.html#getbillingreportsbillableusage) | **GET** /api/v2/billing/reports/billableusage | Get a report of the billable usages (e.g. licenses and devices utilized) for a given period. |
| [**GetBillingTrusteebillingoverviewTrustorOrgId**](BillingApi.html#getbillingtrusteebillingoverviewtrustororgid) | **GET** /api/v2/billing/trusteebillingoverview/{trustorOrgId} | Get the billing overview for an organization that is managed by a partner. |
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
```{"language":"csharp"}
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
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **startDate** | **DateTime?**| The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ |  |
| **endDate** | **DateTime?**| The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ |  |
{: class="table table-striped"}

### Return type

[**BillingUsageReport**](BillingUsageReport.html)

<a name="getbillingtrusteebillingoverviewtrustororgid"></a>

## [**TrusteeBillingOverview**](TrusteeBillingOverview.html) GetBillingTrusteebillingoverviewTrustorOrgId (string trustorOrgId, int? billingPeriodIndex = null)



Get the billing overview for an organization that is managed by a partner.

Tax Disclaimer: Prices returned by this API do not include applicable taxes. It is the responsibility of the customer to pay all taxes that are appropriate in their jurisdiction. See the PureCloud API Documentation in the Developer Center for more information about this API: https://developer.mypurecloud.com/api/rest/v2/

Requires ANY permissions: 

* affiliateOrganization:clientBilling:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetBillingTrusteebillingoverviewTrustorOrgIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BillingApi();
            var trustorOrgId = trustorOrgId_example;  // string | The organization ID of the trustor (customer) organization.
            var billingPeriodIndex = 56;  // int? | Billing Period Index (optional)  (default to 0)

            try
            { 
                // Get the billing overview for an organization that is managed by a partner.
                TrusteeBillingOverview result = apiInstance.GetBillingTrusteebillingoverviewTrustorOrgId(trustorOrgId, billingPeriodIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetBillingTrusteebillingoverviewTrustorOrgId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trustorOrgId** | **string**| The organization ID of the trustor (customer) organization. |  |
| **billingPeriodIndex** | **int?**| Billing Period Index | [optional] [default to 0] |
{: class="table table-striped"}

### Return type

[**TrusteeBillingOverview**](TrusteeBillingOverview.html)

