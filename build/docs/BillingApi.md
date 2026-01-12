# BillingApi

## PureCloudPlatform.Client.V2.Api.BillingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetBillingContract**](#GetBillingContract) | **Get** /api/v2/billing/contracts/{contractId} | Get billing contract |
| [**GetBillingContractBillingperiod**](#GetBillingContractBillingperiod) | **Get** /api/v2/billing/contracts/{contractId}/billingperiods/{billingPeriodId} | Get contract billing period |
| [**GetBillingContracts**](#GetBillingContracts) | **Get** /api/v2/billing/contracts | Get billing contracts |
| [**GetBillingContractsInvoiceDocument**](#GetBillingContractsInvoiceDocument) | **Get** /api/v2/billing/contracts/invoices/{invoiceId}/document | Get invoice document |
| [**GetBillingContractsInvoiceLines**](#GetBillingContractsInvoiceLines) | **Get** /api/v2/billing/contracts/invoices/{invoiceId}/lines | Get invoice lines |
| [**GetBillingContractsInvoices**](#GetBillingContractsInvoices) | **Get** /api/v2/billing/contracts/invoices | Get invoices |
| [**GetBillingReportsBillableusage**](#GetBillingReportsBillableusage) | **Get** /api/v2/billing/reports/billableusage | Get a report of the billable license usages |
| [**GetBillingTrusteebillingoverviewTrustorOrgId**](#GetBillingTrusteebillingoverviewTrustorOrgId) | **Get** /api/v2/billing/trusteebillingoverview/{trustorOrgId} | Get the billing overview for an organization that is managed by a partner. |



## GetBillingContract

> [**BillingContract**](BillingContract) GetBillingContract (string contractId)


Get billing contract

Retrieve a single contract from the system.

GetBillingContract is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

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
    public class GetBillingContractExample
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
            var contractId = contractId_example;  // string | The contract number.

            try
            { 
                // Get billing contract
                BillingContract result = apiInstance.GetBillingContract(contractId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetBillingContract: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contractId** | **string**| The contract number. |  |

### Return type

[**BillingContract**](BillingContract)


## GetBillingContractBillingperiod

> [**BillingContractPeriodDetail**](BillingContractPeriodDetail) GetBillingContractBillingperiod (string contractId, string billingPeriodId)


Get contract billing period

Fetch the billing information for a given Organization by billing period.

GetBillingContractBillingperiod is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

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
    public class GetBillingContractBillingperiodExample
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
            var contractId = contractId_example;  // string | The contract number.
            var billingPeriodId = billingPeriodId_example;  // string | The Billing Period Id for the Org.

            try
            { 
                // Get contract billing period
                BillingContractPeriodDetail result = apiInstance.GetBillingContractBillingperiod(contractId, billingPeriodId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetBillingContractBillingperiod: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contractId** | **string**| The contract number. |  |
| **billingPeriodId** | **string**| The Billing Period Id for the Org. |  |

### Return type

[**BillingContractPeriodDetail**](BillingContractPeriodDetail)


## GetBillingContracts

> [**BillingContractListing**](BillingContractListing) GetBillingContracts (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string status = null, string externalNumber = null)


Get billing contracts

Retrieve a list of contracts stored in the system.

GetBillingContracts is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

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
    public class GetBillingContractsExample
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
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var dateStart = 2013-10-20;  // String | Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var dateEnd = 2013-10-20;  // String | End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var status = status_example;  // string | Filter by the status of contracts (optional) 
            var externalNumber = externalNumber_example;  // string | Filter by the unique external number. (optional) 

            try
            { 
                // Get billing contracts
                BillingContractListing result = apiInstance.GetBillingContracts(before, after, pageSize, dateStart, dateEnd, status, externalNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetBillingContracts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **dateStart** | **String**| Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **dateEnd** | **String**| End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **status** | **string**| Filter by the status of contracts | [optional] <br />**Values**: Active, Inactive |
| **externalNumber** | **string**| Filter by the unique external number. | [optional]  |

### Return type

[**BillingContractListing**](BillingContractListing)


## GetBillingContractsInvoiceDocument

> [**UrlResponse**](UrlResponse) GetBillingContractsInvoiceDocument (string invoiceId)


Get invoice document

Fetch the document for a specific invoice.

GetBillingContractsInvoiceDocument is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

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
    public class GetBillingContractsInvoiceDocumentExample
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
            var invoiceId = invoiceId_example;  // string | invoiceId

            try
            { 
                // Get invoice document
                UrlResponse result = apiInstance.GetBillingContractsInvoiceDocument(invoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetBillingContractsInvoiceDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **invoiceId** | **string**| invoiceId |  |

### Return type

[**UrlResponse**](UrlResponse)


## GetBillingContractsInvoiceLines

> [**BillingInvoiceItemListing**](BillingInvoiceItemListing) GetBillingContractsInvoiceLines (string invoiceId, string before = null, string after = null, string pageSize = null)


Get invoice lines

Fetch a list of all bills for the specified account.

GetBillingContractsInvoiceLines is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

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
    public class GetBillingContractsInvoiceLinesExample
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
            var invoiceId = invoiceId_example;  // string | invoiceId
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 

            try
            { 
                // Get invoice lines
                BillingInvoiceItemListing result = apiInstance.GetBillingContractsInvoiceLines(invoiceId, before, after, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetBillingContractsInvoiceLines: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **invoiceId** | **string**| invoiceId |  |
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |

### Return type

[**BillingInvoiceItemListing**](BillingInvoiceItemListing)


## GetBillingContractsInvoices

> [**BillingInvoiceListing**](BillingInvoiceListing) GetBillingContractsInvoices (string before = null, string after = null, string pageSize = null, String dateStart = null, String dateEnd = null, string paymentStatus = null)


Get invoices

Retrieve a list of invoices stored in the system.

GetBillingContractsInvoices is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

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
    public class GetBillingContractsInvoicesExample
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
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var dateStart = 2013-10-20;  // String | Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var dateEnd = 2013-10-20;  // String | End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional) 
            var paymentStatus = paymentStatus_example;  // string | Payment Status (optional) 

            try
            { 
                // Get invoices
                BillingInvoiceListing result = apiInstance.GetBillingContractsInvoices(before, after, pageSize, dateStart, dateEnd, paymentStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetBillingContractsInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **dateStart** | **String**| Start date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **dateEnd** | **String**| End date for the query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional]  |
| **paymentStatus** | **string**| Payment Status | [optional] <br />**Values**: Paid, UnPaid |

### Return type

[**BillingInvoiceListing**](BillingInvoiceListing)


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


_PureCloudPlatform.Client.V2 253.0.0_
