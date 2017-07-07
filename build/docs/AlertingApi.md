---
title: AlertingApi
---
## PureCloudPlatform.Client.V2.Api.AlertingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAlertingInteractionstatsAlert**](AlertingApi.html#deletealertinginteractionstatsalert) | **DELETE** /api/v2/alerting/interactionstats/alerts/{alertId} | Delete an interaction stats alert |
| [**DeleteAlertingInteractionstatsRule**](AlertingApi.html#deletealertinginteractionstatsrule) | **DELETE** /api/v2/alerting/interactionstats/rules/{ruleId} | Delete an interaction stats rule. |
| [**GetAlertingInteractionstatsAlert**](AlertingApi.html#getalertinginteractionstatsalert) | **GET** /api/v2/alerting/interactionstats/alerts/{alertId} | Get an interaction stats alert |
| [**GetAlertingInteractionstatsAlerts**](AlertingApi.html#getalertinginteractionstatsalerts) | **GET** /api/v2/alerting/interactionstats/alerts | Get interaction stats alert list. |
| [**GetAlertingInteractionstatsAlertsUnread**](AlertingApi.html#getalertinginteractionstatsalertsunread) | **GET** /api/v2/alerting/interactionstats/alerts/unread | Gets user unread count of interaction stats alerts. |
| [**GetAlertingInteractionstatsRule**](AlertingApi.html#getalertinginteractionstatsrule) | **GET** /api/v2/alerting/interactionstats/rules/{ruleId} | Get an interaction stats rule. |
| [**GetAlertingInteractionstatsRules**](AlertingApi.html#getalertinginteractionstatsrules) | **GET** /api/v2/alerting/interactionstats/rules | Get an interaction stats rule list. |
| [**PostAlertingInteractionstatsRules**](AlertingApi.html#postalertinginteractionstatsrules) | **POST** /api/v2/alerting/interactionstats/rules | Create an interaction stats rule. |
| [**PutAlertingInteractionstatsAlert**](AlertingApi.html#putalertinginteractionstatsalert) | **PUT** /api/v2/alerting/interactionstats/alerts/{alertId} | Update an interaction stats alert read status |
| [**PutAlertingInteractionstatsRule**](AlertingApi.html#putalertinginteractionstatsrule) | **PUT** /api/v2/alerting/interactionstats/rules/{ruleId} | Update an interaction stats rule |
{: class="table table-striped"}

<a name="deletealertinginteractionstatsalert"></a>

## void DeleteAlertingInteractionstatsAlert (string alertId)

Delete an interaction stats alert



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

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



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getalertinginteractionstatsalert"></a>

## [**InteractionStatsAlert**](InteractionStatsAlert.html) GetAlertingInteractionstatsAlert (string alertId, List<string> expand = null)

Get an interaction stats alert



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

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



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

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



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**UnreadMetric**](UnreadMetric.html)

<a name="getalertinginteractionstatsrule"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) GetAlertingInteractionstatsRule (string ruleId, List<string> expand = null)

Get an interaction stats rule.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

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



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**InteractionStatsRuleContainer**](InteractionStatsRuleContainer.html)

<a name="postalertinginteractionstatsrules"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) PostAlertingInteractionstatsRules (InteractionStatsRule body, List<string> expand = null)

Create an interaction stats rule.



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**InteractionStatsRule**](InteractionStatsRule.html)| AlertingRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.html)

<a name="putalertinginteractionstatsalert"></a>

## [**UnreadStatus**](UnreadStatus.html) PutAlertingInteractionstatsAlert (string alertId, UnreadStatus body, List<string> expand = null)

Update an interaction stats alert read status



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

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



### Example
~~~csharp
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
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

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
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **body** | [**InteractionStatsRule**](InteractionStatsRule.html)| AlertingRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.html)

