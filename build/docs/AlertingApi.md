---
title: AlertingApi
---
## PureCloudPlatform.Client.V2.Api.AlertingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAlertingAlert**](AlertingApi.html#deletealertingalert) | **Delete** /api/v2/alerting/alerts/{alertId} | Delete an alert |
| [**DeleteAlertingInteractionstatsAlert**](AlertingApi.html#deletealertinginteractionstatsalert) | **Delete** /api/v2/alerting/interactionstats/alerts/{alertId} | Delete an interaction stats alert |
| [**DeleteAlertingInteractionstatsRule**](AlertingApi.html#deletealertinginteractionstatsrule) | **Delete** /api/v2/alerting/interactionstats/rules/{ruleId} | Delete an interaction stats rule. |
| [**DeleteAlertingRule**](AlertingApi.html#deletealertingrule) | **Delete** /api/v2/alerting/rules/{ruleId} | Delete a rule. |
| [**GetAlertingAlert**](AlertingApi.html#getalertingalert) | **Get** /api/v2/alerting/alerts/{alertId} | Get an alert |
| [**GetAlertingAlertsActive**](AlertingApi.html#getalertingalertsactive) | **Get** /api/v2/alerting/alerts/active | Gets active alert count for a user. |
| [**GetAlertingInteractionstatsAlert**](AlertingApi.html#getalertinginteractionstatsalert) | **Get** /api/v2/alerting/interactionstats/alerts/{alertId} | Get an interaction stats alert |
| [**GetAlertingInteractionstatsAlerts**](AlertingApi.html#getalertinginteractionstatsalerts) | **Get** /api/v2/alerting/interactionstats/alerts | Get interaction stats alert list. |
| [**GetAlertingInteractionstatsAlertsUnread**](AlertingApi.html#getalertinginteractionstatsalertsunread) | **Get** /api/v2/alerting/interactionstats/alerts/unread | Gets user unread count of interaction stats alerts. |
| [**GetAlertingInteractionstatsRule**](AlertingApi.html#getalertinginteractionstatsrule) | **Get** /api/v2/alerting/interactionstats/rules/{ruleId} | Get an interaction stats rule. |
| [**GetAlertingInteractionstatsRules**](AlertingApi.html#getalertinginteractionstatsrules) | **Get** /api/v2/alerting/interactionstats/rules | Get an interaction stats rule list. |
| [**GetAlertingRule**](AlertingApi.html#getalertingrule) | **Get** /api/v2/alerting/rules/{ruleId} | Get a rule. |
| [**PatchAlertingAlert**](AlertingApi.html#patchalertingalert) | **Patch** /api/v2/alerting/alerts/{alertId} | Allows an entity to mute/snooze an alert or update the unread status of the alert. |
| [**PatchAlertingAlertsBulk**](AlertingApi.html#patchalertingalertsbulk) | **Patch** /api/v2/alerting/alerts/bulk | Bulk alert updates |
| [**PatchAlertingRulesBulk**](AlertingApi.html#patchalertingrulesbulk) | **Patch** /api/v2/alerting/rules/bulk | Bulk update of notification lists |
| [**PostAlertingAlertsQuery**](AlertingApi.html#postalertingalertsquery) | **Post** /api/v2/alerting/alerts/query | Gets a paged list of alerts. The max page size is 50 |
| [**PostAlertingInteractionstatsRules**](AlertingApi.html#postalertinginteractionstatsrules) | **Post** /api/v2/alerting/interactionstats/rules | Create an interaction stats rule. |
| [**PostAlertingRules**](AlertingApi.html#postalertingrules) | **Post** /api/v2/alerting/rules | Create a Rule. |
| [**PostAlertingRulesBulkRemove**](AlertingApi.html#postalertingrulesbulkremove) | **Post** /api/v2/alerting/rules/bulk/remove | Bulk remove rules |
| [**PostAlertingRulesQuery**](AlertingApi.html#postalertingrulesquery) | **Post** /api/v2/alerting/rules/query | Get a paged list of rules.  The max size of the page is 50 items. |
| [**PutAlertingAlert**](AlertingApi.html#putalertingalert) | **Put** /api/v2/alerting/alerts/{alertId} | Update an alert read status |
| [**PutAlertingInteractionstatsAlert**](AlertingApi.html#putalertinginteractionstatsalert) | **Put** /api/v2/alerting/interactionstats/alerts/{alertId} | Update an interaction stats alert read status |
| [**PutAlertingInteractionstatsRule**](AlertingApi.html#putalertinginteractionstatsrule) | **Put** /api/v2/alerting/interactionstats/rules/{ruleId} | Update an interaction stats rule |
| [**PutAlertingRule**](AlertingApi.html#putalertingrule) | **Put** /api/v2/alerting/rules/{ruleId} | Update a rule |
{: class="table table-striped"}

<a name="deletealertingalert"></a>

## void DeleteAlertingAlert (string alertId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletealertinginteractionstatsalert"></a>

## void DeleteAlertingInteractionstatsAlert (string alertId)



Delete an interaction stats alert

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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletealertinginteractionstatsrule"></a>

## void DeleteAlertingInteractionstatsRule (string ruleId)



Delete an interaction stats rule.

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
                // Delete an interaction stats rule.
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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletealertingrule"></a>

## void DeleteAlertingRule (string ruleId)



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
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getalertingalert"></a>

## [**CommonAlert**](CommonAlert.html) GetAlertingAlert (string alertId)



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
{: class="table table-striped"}

### Return type

[**CommonAlert**](CommonAlert.html)

<a name="getalertingalertsactive"></a>

## [**ActiveAlertCount**](ActiveAlertCount.html) GetAlertingAlertsActive ()



Gets active alert count for a user.

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
                // Gets active alert count for a user.
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

[**ActiveAlertCount**](ActiveAlertCount.html)

<a name="getalertinginteractionstatsalert"></a>

## [**InteractionStatsAlert**](InteractionStatsAlert.html) GetAlertingInteractionstatsAlert (string alertId, List<string> expand = null)



Get an interaction stats alert

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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**InteractionStatsAlert**](InteractionStatsAlert.html)

<a name="getalertinginteractionstatsalerts"></a>

## [**InteractionStatsAlertContainer**](InteractionStatsAlertContainer.html) GetAlertingInteractionstatsAlerts (List<string> expand = null)



Get interaction stats alert list.

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
                // Get interaction stats alert list.
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**InteractionStatsAlertContainer**](InteractionStatsAlertContainer.html)

<a name="getalertinginteractionstatsalertsunread"></a>

## [**UnreadMetric**](UnreadMetric.html) GetAlertingInteractionstatsAlertsUnread ()



Gets user unread count of interaction stats alerts.

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
                // Gets user unread count of interaction stats alerts.
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

[**UnreadMetric**](UnreadMetric.html)

<a name="getalertinginteractionstatsrule"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) GetAlertingInteractionstatsRule (string ruleId, List<string> expand = null)



Get an interaction stats rule.

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
                // Get an interaction stats rule.
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.html)

<a name="getalertinginteractionstatsrules"></a>

## [**InteractionStatsRuleContainer**](InteractionStatsRuleContainer.html) GetAlertingInteractionstatsRules (List<string> expand = null)



Get an interaction stats rule list.

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
                // Get an interaction stats rule list.
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**InteractionStatsRuleContainer**](InteractionStatsRuleContainer.html)

<a name="getalertingrule"></a>

## [**CommonRule**](CommonRule.html) GetAlertingRule (string ruleId)



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
{: class="table table-striped"}

### Return type

[**CommonRule**](CommonRule.html)

<a name="patchalertingalert"></a>

## [**CommonAlert**](CommonAlert.html) PatchAlertingAlert (string alertId, AlertRequest body = null)



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
| **body** | [**AlertRequest**](AlertRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**CommonAlert**](CommonAlert.html)

<a name="patchalertingalertsbulk"></a>

## [**BulkResponse**](BulkResponse.html) PatchAlertingAlertsBulk (CommonAlertBulkUpdateRequest body)



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
| **body** | [**CommonAlertBulkUpdateRequest**](CommonAlertBulkUpdateRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**BulkResponse**](BulkResponse.html)

<a name="patchalertingrulesbulk"></a>

## [**BulkResponse**](BulkResponse.html) PatchAlertingRulesBulk (CommonRuleBulkUpdateNotificationsRequest body)



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
| **body** | [**CommonRuleBulkUpdateNotificationsRequest**](CommonRuleBulkUpdateNotificationsRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**BulkResponse**](BulkResponse.html)

<a name="postalertingalertsquery"></a>

## [**AlertListing**](AlertListing.html) PostAlertingAlertsQuery (GetAlertQuery body = null)



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
| **body** | [**GetAlertQuery**](GetAlertQuery.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**AlertListing**](AlertListing.html)

<a name="postalertinginteractionstatsrules"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) PostAlertingInteractionstatsRules (InteractionStatsRule body, List<string> expand = null)



Create an interaction stats rule.

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
                // Create an interaction stats rule.
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
| **body** | [**InteractionStatsRule**](InteractionStatsRule.html)| AlertingRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.html)

<a name="postalertingrules"></a>

## [**CommonRule**](CommonRule.html) PostAlertingRules (CommonRule body)



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
| **body** | [**CommonRule**](CommonRule.html)| rule to be created |  |
{: class="table table-striped"}

### Return type

[**CommonRule**](CommonRule.html)

<a name="postalertingrulesbulkremove"></a>

## [**BulkResponse**](BulkResponse.html) PostAlertingRulesBulkRemove (CommonRuleBulkDeleteRequest body)



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
| **body** | [**CommonRuleBulkDeleteRequest**](CommonRuleBulkDeleteRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**BulkResponse**](BulkResponse.html)

<a name="postalertingrulesquery"></a>

## [**CommonRuleContainer**](CommonRuleContainer.html) PostAlertingRulesQuery (GetRulesQuery body = null)



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
| **body** | [**GetRulesQuery**](GetRulesQuery.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**CommonRuleContainer**](CommonRuleContainer.html)

<a name="putalertingalert"></a>

## [**UnreadStatus**](UnreadStatus.html) PutAlertingAlert (string alertId, AlertingUnreadStatus body = null)



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
| **body** | [**AlertingUnreadStatus**](AlertingUnreadStatus.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**UnreadStatus**](UnreadStatus.html)

<a name="putalertinginteractionstatsalert"></a>

## [**UnreadStatus**](UnreadStatus.html) PutAlertingInteractionstatsAlert (string alertId, UnreadStatus body, List<string> expand = null)



Update an interaction stats alert read status

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
| **body** | [**UnreadStatus**](UnreadStatus.html)| InteractionStatsAlert |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**UnreadStatus**](UnreadStatus.html)

<a name="putalertinginteractionstatsrule"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) PutAlertingInteractionstatsRule (string ruleId, InteractionStatsRule body, List<string> expand = null)



Update an interaction stats rule

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
| **body** | [**InteractionStatsRule**](InteractionStatsRule.html)| AlertingRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.html)

<a name="putalertingrule"></a>

## [**CommonRule**](CommonRule.html) PutAlertingRule (string ruleId, ModifiableRuleProperties body)



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
| **body** | [**ModifiableRuleProperties**](ModifiableRuleProperties.html)| rule to be updated |  |
{: class="table table-striped"}

### Return type

[**CommonRule**](CommonRule.html)

