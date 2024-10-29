# AlertingApi

## PureCloudPlatform.Client.V2.Api.AlertingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAlertingAlert**](#DeleteAlertingAlert) | **Delete** /api/v2/alerting/alerts/{alertId} | Delete an alert |
| [**DeleteAlertingInteractionstatsAlert**](#DeleteAlertingInteractionstatsAlert) | **Delete** /api/v2/alerting/interactionstats/alerts/{alertId} | Delete an interaction stats alert |
| [**DeleteAlertingInteractionstatsRule**](#DeleteAlertingInteractionstatsRule) | **Delete** /api/v2/alerting/interactionstats/rules/{ruleId} | Delete an interaction stats rule |
| [**DeleteAlertingRule**](#DeleteAlertingRule) | **Delete** /api/v2/alerting/rules/{ruleId} | Delete a rule. |
| [**GetAlertingAlert**](#GetAlertingAlert) | **Get** /api/v2/alerting/alerts/{alertId} | Get an alert |
| [**GetAlertingAlertsActive**](#GetAlertingAlertsActive) | **Get** /api/v2/alerting/alerts/active | Gets active alert count for a user |
| [**GetAlertingInteractionstatsAlert**](#GetAlertingInteractionstatsAlert) | **Get** /api/v2/alerting/interactionstats/alerts/{alertId} | Get an interaction stats alert |
| [**GetAlertingInteractionstatsAlerts**](#GetAlertingInteractionstatsAlerts) | **Get** /api/v2/alerting/interactionstats/alerts | Get interaction stats alert list |
| [**GetAlertingInteractionstatsAlertsUnread**](#GetAlertingInteractionstatsAlertsUnread) | **Get** /api/v2/alerting/interactionstats/alerts/unread | Gets user unread count of interaction stats alerts |
| [**GetAlertingInteractionstatsRule**](#GetAlertingInteractionstatsRule) | **Get** /api/v2/alerting/interactionstats/rules/{ruleId} | Get an interaction stats rule |
| [**GetAlertingInteractionstatsRules**](#GetAlertingInteractionstatsRules) | **Get** /api/v2/alerting/interactionstats/rules | Get an interaction stats rule list |
| [**GetAlertingRule**](#GetAlertingRule) | **Get** /api/v2/alerting/rules/{ruleId} | Get a rule. |
| [**PatchAlertingAlert**](#PatchAlertingAlert) | **Patch** /api/v2/alerting/alerts/{alertId} | Allows an entity to mute/snooze an alert or update the unread status of the alert. |
| [**PatchAlertingAlertsBulk**](#PatchAlertingAlertsBulk) | **Patch** /api/v2/alerting/alerts/bulk | Bulk alert updates |
| [**PatchAlertingRulesBulk**](#PatchAlertingRulesBulk) | **Patch** /api/v2/alerting/rules/bulk | Bulk update of notification lists |
| [**PostAlertingAlertsQuery**](#PostAlertingAlertsQuery) | **Post** /api/v2/alerting/alerts/query | Gets a paged list of alerts. The max page size is 50 |
| [**PostAlertingInteractionstatsRules**](#PostAlertingInteractionstatsRules) | **Post** /api/v2/alerting/interactionstats/rules | Create an interaction stats rule |
| [**PostAlertingRules**](#PostAlertingRules) | **Post** /api/v2/alerting/rules | Create a Rule. |
| [**PostAlertingRulesBulkRemove**](#PostAlertingRulesBulkRemove) | **Post** /api/v2/alerting/rules/bulk/remove | Bulk remove rules |
| [**PostAlertingRulesQuery**](#PostAlertingRulesQuery) | **Post** /api/v2/alerting/rules/query | Get a paged list of rules.  The max size of the page is 50 items. |
| [**PutAlertingAlert**](#PutAlertingAlert) | **Put** /api/v2/alerting/alerts/{alertId} | Update an alert read status |
| [**PutAlertingInteractionstatsAlert**](#PutAlertingInteractionstatsAlert) | **Put** /api/v2/alerting/interactionstats/alerts/{alertId} | Update an interaction stats alert read status |
| [**PutAlertingInteractionstatsRule**](#PutAlertingInteractionstatsRule) | **Put** /api/v2/alerting/interactionstats/rules/{ruleId} | Update an interaction stats rule |
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


## DeleteAlertingInteractionstatsAlert

> void DeleteAlertingInteractionstatsAlert (string alertId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Delete an interaction stats alert

Apps should migrate to use DELETE /api/v2/alerting/alerts/{alertId}.

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
    public class DeleteAlertingInteractionstatsAlertExample
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
                // Delete an interaction stats alert
                apiInstance.DeleteAlertingInteractionstatsAlert(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingInteractionstatsAlert: " + e.Message );
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


## DeleteAlertingInteractionstatsRule

> void DeleteAlertingInteractionstatsRule (string ruleId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Delete an interaction stats rule

Apps should migrate to use DELETE /api/v2/alerting/rules/{ruleId}.

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
    public class DeleteAlertingInteractionstatsRuleExample
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
            var ruleId = ruleId_example;  // string | Rule ID

            try
            { 
                // Delete an interaction stats rule
                apiInstance.DeleteAlertingInteractionstatsRule(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingInteractionstatsRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |

### Return type

void (empty response body)


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


## GetAlertingAlertsActive

> [**ActiveAlertCount**](ActiveAlertCount) GetAlertingAlertsActive ()

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Gets active alert count for a user

Apps should migrate to use POST /api/v2/alerting/alerts/query with the queryType set to 'Count' and alertStatus to 'Active' in the request body.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingAlertsActiveExample
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
                // Gets active alert count for a user
                ActiveAlertCount result = apiInstance.GetAlertingAlertsActive();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingAlertsActive: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ActiveAlertCount**](ActiveAlertCount)


## GetAlertingInteractionstatsAlert

> [**InteractionStatsAlert**](InteractionStatsAlert) GetAlertingInteractionstatsAlert (string alertId, List<string> expand = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get an interaction stats alert

Apps should migrate to use GET /api/v2/alerting/alerts/{alertId}.

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
    public class GetAlertingInteractionstatsAlertExample
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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get an interaction stats alert
                InteractionStatsAlert result = apiInstance.GetAlertingInteractionstatsAlert(alertId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingInteractionstatsAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |

### Return type

[**InteractionStatsAlert**](InteractionStatsAlert)


## GetAlertingInteractionstatsAlerts

> [**InteractionStatsAlertContainer**](InteractionStatsAlertContainer) GetAlertingInteractionstatsAlerts (List<string> expand = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get interaction stats alert list

Apps should migrate to use POST /api/v2/alerting/alerts/query.

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
    public class GetAlertingInteractionstatsAlertsExample
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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get interaction stats alert list
                InteractionStatsAlertContainer result = apiInstance.GetAlertingInteractionstatsAlerts(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingInteractionstatsAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |

### Return type

[**InteractionStatsAlertContainer**](InteractionStatsAlertContainer)


## GetAlertingInteractionstatsAlertsUnread

> [**UnreadMetric**](UnreadMetric) GetAlertingInteractionstatsAlertsUnread ()

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Gets user unread count of interaction stats alerts

Apps should migrate to use POST /api/v2/alerting/alerts/query with the queryType set to 'Count' and viewStatus to 'Unread' in the request body.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingInteractionstatsAlertsUnreadExample
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
                // Gets user unread count of interaction stats alerts
                UnreadMetric result = apiInstance.GetAlertingInteractionstatsAlertsUnread();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingInteractionstatsAlertsUnread: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**UnreadMetric**](UnreadMetric)


## GetAlertingInteractionstatsRule

> [**InteractionStatsRule**](InteractionStatsRule) GetAlertingInteractionstatsRule (string ruleId, List<string> expand = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get an interaction stats rule

Apps should migrate to use GET /api/v2/alerting/rules/{ruleId}.

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
    public class GetAlertingInteractionstatsRuleExample
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
            var ruleId = ruleId_example;  // string | Rule ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get an interaction stats rule
                InteractionStatsRule result = apiInstance.GetAlertingInteractionstatsRule(ruleId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingInteractionstatsRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |

### Return type

[**InteractionStatsRule**](InteractionStatsRule)


## GetAlertingInteractionstatsRules

> [**InteractionStatsRuleContainer**](InteractionStatsRuleContainer) GetAlertingInteractionstatsRules (List<string> expand = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Get an interaction stats rule list

Apps should migrate to use POST /api/v2/alerting/rules/query.

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
    public class GetAlertingInteractionstatsRulesExample
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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get an interaction stats rule list
                InteractionStatsRuleContainer result = apiInstance.GetAlertingInteractionstatsRules(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingInteractionstatsRules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |

### Return type

[**InteractionStatsRuleContainer**](InteractionStatsRuleContainer)


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


## PostAlertingInteractionstatsRules

> [**InteractionStatsRule**](InteractionStatsRule) PostAlertingInteractionstatsRules (InteractionStatsRule body, List<string> expand = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Create an interaction stats rule

Apps should migrate to use POST /api/v2/alerting/rules.

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
    public class PostAlertingInteractionstatsRulesExample
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
            var body = new InteractionStatsRule(); // InteractionStatsRule | AlertingRule
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Create an interaction stats rule
                InteractionStatsRule result = apiInstance.PostAlertingInteractionstatsRules(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostAlertingInteractionstatsRules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**InteractionStatsRule**](InteractionStatsRule)| AlertingRule |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |

### Return type

[**InteractionStatsRule**](InteractionStatsRule)


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

> [**UnreadStatus**](UnreadStatus) PutAlertingAlert (string alertId, AlertingUnreadStatus body = null)


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
                UnreadStatus result = apiInstance.PutAlertingAlert(alertId, body);
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

[**UnreadStatus**](UnreadStatus)


## PutAlertingInteractionstatsAlert

> [**UnreadStatus**](UnreadStatus) PutAlertingInteractionstatsAlert (string alertId, UnreadStatus body, List<string> expand = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update an interaction stats alert read status

Apps should migrate to use PUT /api/v2/alerting/alerts/{alertId}.

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
    public class PutAlertingInteractionstatsAlertExample
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
            var body = new UnreadStatus(); // UnreadStatus | InteractionStatsAlert
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Update an interaction stats alert read status
                UnreadStatus result = apiInstance.PutAlertingInteractionstatsAlert(alertId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutAlertingInteractionstatsAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
| **body** | [**UnreadStatus**](UnreadStatus)| InteractionStatsAlert |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |

### Return type

[**UnreadStatus**](UnreadStatus)


## PutAlertingInteractionstatsRule

> [**InteractionStatsRule**](InteractionStatsRule) PutAlertingInteractionstatsRule (string ruleId, InteractionStatsRule body, List<string> expand = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Update an interaction stats rule

Apps should migrate to use PUT /api/v2/alerting/rules/{ruleId}.

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
    public class PutAlertingInteractionstatsRuleExample
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
            var ruleId = ruleId_example;  // string | Rule ID
            var body = new InteractionStatsRule(); // InteractionStatsRule | AlertingRule
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Update an interaction stats rule
                InteractionStatsRule result = apiInstance.PutAlertingInteractionstatsRule(ruleId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutAlertingInteractionstatsRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **body** | [**InteractionStatsRule**](InteractionStatsRule)| AlertingRule |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |

### Return type

[**InteractionStatsRule**](InteractionStatsRule)


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


_PureCloudPlatform.Client.V2 220.0.0_
