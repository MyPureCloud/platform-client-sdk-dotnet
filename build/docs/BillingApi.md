# BillingApi

## PureCloudPlatform.Client.V2.Api.BillingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetBillingReportsBillableusage**](#GetBillingReportsBillableusage) | **Get** /api/v2/billing/reports/billableusage | Get a report of the billable license usages |
| [**GetBillingTrusteebillingoverviewTrustorOrgId**](#GetBillingTrusteebillingoverviewTrustorOrgId) | **Get** /api/v2/billing/trusteebillingoverview/{trustorOrgId} | Get the billing overview for an organization that is managed by a partner. |



## GetBillingReportsBillableusage

> [**BillingUsageReport**](BillingUsageReport) GetBillingReportsBillableusage (DateTime? startDate, DateTime? endDate)


Get a report of the billable license usages

Report is of the billable usages (e.g. licenses and devices utilized) for a given period. If response's status is InProgress, wait a few seconds, then try the same request again.

Requires ANY permissions: 

* billing:subscription:read
* billing:subscription:view

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BillingApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z

            try
            { 
                // Get a report of the billable license usages
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
| **startDate** | **DateTime?**| The period start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z |  |
| **endDate** | **DateTime?**| The period end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z |  |

### Return type

[**BillingUsageReport**](BillingUsageReport)


## GetBillingTrusteebillingoverviewTrustorOrgId

> [**TrusteeBillingOverview**](TrusteeBillingOverview) GetBillingTrusteebillingoverviewTrustorOrgId (string trustorOrgId, int? billingPeriodIndex = null)


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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new BillingApi();
            var trustorOrgId = trustorOrgId_example;  // string | The organization ID of the trustor (customer) organization.
            var billingPeriodIndex = 56;  // int? | 0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. (optional)  (default to 0)

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
| **billingPeriodIndex** | **int?**| 0 for active period (overview data may change until period closes). 1 for prior completed billing period. 2 for two billing cycles prior, and so on. | [optional] [default to 0] |

### Return type

[**TrusteeBillingOverview**](TrusteeBillingOverview)


_PureCloudPlatform.Client.V2 230.0.0_
