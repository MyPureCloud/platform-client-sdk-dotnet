# AlertingApi

## PureCloudPlatform.Client.V2.Api.AlertingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAlertingAlert**](#DeleteAlertingAlert) | **Delete** /api/v2/alerting/alerts/{alertId} | Delete an alert |
| [**DeleteAlertingAlertsAll**](#DeleteAlertingAlertsAll) | **Delete** /api/v2/alerting/alerts/all | Delete all alerts for the user |
| [**DeleteAlertingRule**](#DeleteAlertingRule) | **Delete** /api/v2/alerting/rules/{ruleId} | Delete a rule. |
| [**GetAlertingAlert**](#GetAlertingAlert) | **Get** /api/v2/alerting/alerts/{alertId} | Get an alert |
| [**GetAlertingRule**](#GetAlertingRule) | **Get** /api/v2/alerting/rules/{ruleId} | Get a rule. |
| [**PatchAlertingAlert**](#PatchAlertingAlert) | **Patch** /api/v2/alerting/alerts/{alertId} | Allows an entity to mute/snooze an alert or update the unread status of the alert. |
| [**PatchAlertingAlertsAll**](#PatchAlertingAlertsAll) | **Patch** /api/v2/alerting/alerts/all | Updates all alerts |
| [**PatchAlertingAlertsBulk**](#PatchAlertingAlertsBulk) | **Patch** /api/v2/alerting/alerts/bulk | Bulk alert updates |
| [**PatchAlertingRulesBulk**](#PatchAlertingRulesBulk) | **Patch** /api/v2/alerting/rules/bulk | Bulk update of notification lists |
| [**PostAlertingAlertsQuery**](#PostAlertingAlertsQuery) | **Post** /api/v2/alerting/alerts/query | Gets a paged list of alerts. The max page size is 50 |
| [**PostAlertingRules**](#PostAlertingRules) | **Post** /api/v2/alerting/rules | Create a Rule. |
| [**PostAlertingRulesBulkRemove**](#PostAlertingRulesBulkRemove) | **Post** /api/v2/alerting/rules/bulk/remove | Bulk remove rules |
| [**PostAlertingRulesQuery**](#PostAlertingRulesQuery) | **Post** /api/v2/alerting/rules/query | Get a paged list of rules.  The max size of the page is 50 items. |
| [**PutAlertingAlert**](#PutAlertingAlert) | **Put** /api/v2/alerting/alerts/{alertId} | Update an alert read status |
| [**PutAlertingRule**](#PutAlertingRule) | **Put** /api/v2/alerting/rules/{ruleId} | Update a rule |



## DeleteAlertingAlert

> void DeleteAlertingAlert (string alertId)


Delete an alert

Requires ALL permissions: 

* alerting:alert:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAlertingAlertExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID

            try
            { 
                // Delete an alert
                apiInstance.DeleteAlertingAlert(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |

### Return type

void (empty response body)


## DeleteAlertingAlertsAll

> **Object** DeleteAlertingAlertsAll ()


Delete all alerts for the user

Requires ALL permissions: 

* alerting:alert:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAlertingAlertsAllExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();

            try
            { 
                // Delete all alerts for the user
                Object result = apiInstance.DeleteAlertingAlertsAll();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingAlertsAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

**Object**


## DeleteAlertingRule

> void DeleteAlertingRule (string ruleId)


Delete a rule.

Requires ALL permissions: 

* alerting:rule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAlertingRuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule Id

            try
            { 
                // Delete a rule.
                apiInstance.DeleteAlertingRule(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule Id |  |

### Return type

void (empty response body)


## GetAlertingAlert

> [**CommonAlert**](CommonAlert) GetAlertingAlert (string alertId)


Get an alert

Requires ALL permissions: 

* alerting:alert:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingAlertExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID

            try
            { 
                // Get an alert
                CommonAlert result = apiInstance.GetAlertingAlert(alertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |

### Return type

[**CommonAlert**](CommonAlert)


## GetAlertingRule

> [**CommonRule**](CommonRule) GetAlertingRule (string ruleId)


Get a rule.

Requires ALL permissions: 

* alerting:rule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingRuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule Id

            try
            { 
                // Get a rule.
                CommonRule result = apiInstance.GetAlertingRule(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule Id |  |

### Return type

[**CommonRule**](CommonRule)


## PatchAlertingAlert

> [**CommonAlert**](CommonAlert) PatchAlertingAlert (string alertId, AlertRequest body = null)


Allows an entity to mute/snooze an alert or update the unread status of the alert.

Snoozing an alert temporarily stop it from resending notifications to individualsas well as other services within Genesys Cloud for a given period.  Muting an alert will only block the notifications to individuals.

Requires ALL permissions: 

* alerting:alert:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchAlertingAlertExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID
            var body = new AlertRequest(); // AlertRequest |  (optional) 

            try
            { 
                // Allows an entity to mute/snooze an alert or update the unread status of the alert.
                CommonAlert result = apiInstance.PatchAlertingAlert(alertId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PatchAlertingAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
| **body** | [**AlertRequest**](AlertRequest)|  | [optional]  |

### Return type

[**CommonAlert**](CommonAlert)


## PatchAlertingAlertsAll

> **Object** PatchAlertingAlertsAll (CommonAllAlertUpdateRequest body = null)


Updates all alerts

Requires ALL permissions: 

* alerting:alert:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchAlertingAlertsAllExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var body = new CommonAllAlertUpdateRequest(); // CommonAllAlertUpdateRequest |  (optional) 

            try
            { 
                // Updates all alerts
                Object result = apiInstance.PatchAlertingAlertsAll(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PatchAlertingAlertsAll: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CommonAllAlertUpdateRequest**](CommonAllAlertUpdateRequest)|  | [optional]  |

### Return type

**Object**


## PatchAlertingAlertsBulk

> [**BulkResponse**](BulkResponse) PatchAlertingAlertsBulk (CommonAlertBulkUpdateRequest body)


Bulk alert updates

Requires ALL permissions: 

* alerting:alert:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchAlertingAlertsBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var body = new CommonAlertBulkUpdateRequest(); // CommonAlertBulkUpdateRequest | 

            try
            { 
                // Bulk alert updates
                BulkResponse result = apiInstance.PatchAlertingAlertsBulk(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PatchAlertingAlertsBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CommonAlertBulkUpdateRequest**](CommonAlertBulkUpdateRequest)|  |  |

### Return type

[**BulkResponse**](BulkResponse)


## PatchAlertingRulesBulk

> [**BulkResponse**](BulkResponse) PatchAlertingRulesBulk (CommonRuleBulkUpdateNotificationsRequest body)


Bulk update of notification lists

Requires ALL permissions: 

* alerting:rule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchAlertingRulesBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var body = new CommonRuleBulkUpdateNotificationsRequest(); // CommonRuleBulkUpdateNotificationsRequest | 

            try
            { 
                // Bulk update of notification lists
                BulkResponse result = apiInstance.PatchAlertingRulesBulk(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PatchAlertingRulesBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CommonRuleBulkUpdateNotificationsRequest**](CommonRuleBulkUpdateNotificationsRequest)|  |  |

### Return type

[**BulkResponse**](BulkResponse)


## PostAlertingAlertsQuery

> [**AlertListing**](AlertListing) PostAlertingAlertsQuery (GetAlertQuery body = null)


Gets a paged list of alerts. The max page size is 50

Requires ALL permissions: 

* alerting:alert:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAlertingAlertsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var body = new GetAlertQuery(); // GetAlertQuery |  (optional) 

            try
            { 
                // Gets a paged list of alerts. The max page size is 50
                AlertListing result = apiInstance.PostAlertingAlertsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostAlertingAlertsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GetAlertQuery**](GetAlertQuery)|  | [optional]  |

### Return type

[**AlertListing**](AlertListing)


## PostAlertingRules

> [**CommonRule**](CommonRule) PostAlertingRules (CommonRule body)


Create a Rule.

Requires ALL permissions: 

* alerting:rule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAlertingRulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var body = new CommonRule(); // CommonRule | rule to be created

            try
            { 
                // Create a Rule.
                CommonRule result = apiInstance.PostAlertingRules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostAlertingRules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CommonRule**](CommonRule)| rule to be created |  |

### Return type

[**CommonRule**](CommonRule)


## PostAlertingRulesBulkRemove

> [**BulkResponse**](BulkResponse) PostAlertingRulesBulkRemove (CommonRuleBulkDeleteRequest body)


Bulk remove rules

Requires ALL permissions: 

* alerting:rule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAlertingRulesBulkRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var body = new CommonRuleBulkDeleteRequest(); // CommonRuleBulkDeleteRequest | 

            try
            { 
                // Bulk remove rules
                BulkResponse result = apiInstance.PostAlertingRulesBulkRemove(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostAlertingRulesBulkRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CommonRuleBulkDeleteRequest**](CommonRuleBulkDeleteRequest)|  |  |

### Return type

[**BulkResponse**](BulkResponse)


## PostAlertingRulesQuery

> [**CommonRuleContainer**](CommonRuleContainer) PostAlertingRulesQuery (GetRulesQuery body = null)


Get a paged list of rules.  The max size of the page is 50 items.

Requires ALL permissions: 

* alerting:rule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAlertingRulesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var body = new GetRulesQuery(); // GetRulesQuery |  (optional) 

            try
            { 
                // Get a paged list of rules.  The max size of the page is 50 items.
                CommonRuleContainer result = apiInstance.PostAlertingRulesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostAlertingRulesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GetRulesQuery**](GetRulesQuery)|  | [optional]  |

### Return type

[**CommonRuleContainer**](CommonRuleContainer)


## PutAlertingAlert

> [**AlertingUnreadStatus**](AlertingUnreadStatus) PutAlertingAlert (string alertId, AlertingUnreadStatus body = null)


Update an alert read status

Requires ALL permissions: 

* alerting:alert:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAlertingAlertExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID
            var body = new AlertingUnreadStatus(); // AlertingUnreadStatus |  (optional) 

            try
            { 
                // Update an alert read status
                AlertingUnreadStatus result = apiInstance.PutAlertingAlert(alertId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutAlertingAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
| **body** | [**AlertingUnreadStatus**](AlertingUnreadStatus)|  | [optional]  |

### Return type

[**AlertingUnreadStatus**](AlertingUnreadStatus)


## PutAlertingRule

> [**CommonRule**](CommonRule) PutAlertingRule (string ruleId, ModifiableRuleProperties body)


Update a rule

Requires ALL permissions: 

* alerting:rule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAlertingRuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule Id
            var body = new ModifiableRuleProperties(); // ModifiableRuleProperties | rule to be updated

            try
            { 
                // Update a rule
                CommonRule result = apiInstance.PutAlertingRule(ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutAlertingRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule Id |  |
| **body** | [**ModifiableRuleProperties**](ModifiableRuleProperties)| rule to be updated |  |

### Return type

[**CommonRule**](CommonRule)


_PureCloudPlatform.Client.V2 229.0.0_
