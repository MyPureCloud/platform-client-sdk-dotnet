---
title: AlertingApi
---
## PureCloudPlatform.Client.V2.Api.AlertingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAlertingHeartbeatAlert**](AlertingApi.html#deletealertingheartbeatalert) | **DELETE** /api/v2/alerting/heartbeat/alerts/{alertId} | Delete a heart beat alert |
| [**DeleteAlertingHeartbeatRule**](AlertingApi.html#deletealertingheartbeatrule) | **DELETE** /api/v2/alerting/heartbeat/rules/{ruleId} | Delete a heart beat rule. |
| [**DeleteAlertingInteractionstatsAlert**](AlertingApi.html#deletealertinginteractionstatsalert) | **DELETE** /api/v2/alerting/interactionstats/alerts/{alertId} | Delete an interaction stats alert |
| [**DeleteAlertingInteractionstatsRule**](AlertingApi.html#deletealertinginteractionstatsrule) | **DELETE** /api/v2/alerting/interactionstats/rules/{ruleId} | Delete an interaction stats rule. |
| [**DeleteAlertingRoutingstatusAlert**](AlertingApi.html#deletealertingroutingstatusalert) | **DELETE** /api/v2/alerting/routingstatus/alerts/{alertId} | Delete a routing status alert |
| [**DeleteAlertingRoutingstatusRule**](AlertingApi.html#deletealertingroutingstatusrule) | **DELETE** /api/v2/alerting/routingstatus/rules/{ruleId} | Delete a routing status rule. |
| [**DeleteAlertingUserpresenceAlert**](AlertingApi.html#deletealertinguserpresencealert) | **DELETE** /api/v2/alerting/userpresence/alerts/{alertId} | Delete a user presence alert |
| [**DeleteAlertingUserpresenceRule**](AlertingApi.html#deletealertinguserpresencerule) | **DELETE** /api/v2/alerting/userpresence/rules/{ruleId} | Delete a user presence rule. |
| [**GetAlertingHeartbeatAlert**](AlertingApi.html#getalertingheartbeatalert) | **GET** /api/v2/alerting/heartbeat/alerts/{alertId} | Get a heart beat alert |
| [**GetAlertingHeartbeatAlerts**](AlertingApi.html#getalertingheartbeatalerts) | **GET** /api/v2/alerting/heartbeat/alerts | Get heart beat alert list. |
| [**GetAlertingHeartbeatRule**](AlertingApi.html#getalertingheartbeatrule) | **GET** /api/v2/alerting/heartbeat/rules/{ruleId} | Get a heart beat rule. |
| [**GetAlertingHeartbeatRules**](AlertingApi.html#getalertingheartbeatrules) | **GET** /api/v2/alerting/heartbeat/rules | Get a heart beat rule list. |
| [**GetAlertingInteractionstatsAlert**](AlertingApi.html#getalertinginteractionstatsalert) | **GET** /api/v2/alerting/interactionstats/alerts/{alertId} | Get an interaction stats alert |
| [**GetAlertingInteractionstatsAlerts**](AlertingApi.html#getalertinginteractionstatsalerts) | **GET** /api/v2/alerting/interactionstats/alerts | Get interaction stats alert list. |
| [**GetAlertingInteractionstatsAlertsUnread**](AlertingApi.html#getalertinginteractionstatsalertsunread) | **GET** /api/v2/alerting/interactionstats/alerts/unread | Gets user unread count of interaction stats alerts. |
| [**GetAlertingInteractionstatsRule**](AlertingApi.html#getalertinginteractionstatsrule) | **GET** /api/v2/alerting/interactionstats/rules/{ruleId} | Get an interaction stats rule. |
| [**GetAlertingInteractionstatsRules**](AlertingApi.html#getalertinginteractionstatsrules) | **GET** /api/v2/alerting/interactionstats/rules | Get an interaction stats rule list. |
| [**GetAlertingRoutingstatusAlert**](AlertingApi.html#getalertingroutingstatusalert) | **GET** /api/v2/alerting/routingstatus/alerts/{alertId} | Get a routing status alert |
| [**GetAlertingRoutingstatusAlerts**](AlertingApi.html#getalertingroutingstatusalerts) | **GET** /api/v2/alerting/routingstatus/alerts | Get routing status alert list. |
| [**GetAlertingRoutingstatusRule**](AlertingApi.html#getalertingroutingstatusrule) | **GET** /api/v2/alerting/routingstatus/rules/{ruleId} | Get a routing status rule. |
| [**GetAlertingRoutingstatusRules**](AlertingApi.html#getalertingroutingstatusrules) | **GET** /api/v2/alerting/routingstatus/rules | Get a routing status rule list. |
| [**GetAlertingUserpresenceAlert**](AlertingApi.html#getalertinguserpresencealert) | **GET** /api/v2/alerting/userpresence/alerts/{alertId} | Get a user presence alert |
| [**GetAlertingUserpresenceAlerts**](AlertingApi.html#getalertinguserpresencealerts) | **GET** /api/v2/alerting/userpresence/alerts | Get user presence alert list. |
| [**GetAlertingUserpresenceRule**](AlertingApi.html#getalertinguserpresencerule) | **GET** /api/v2/alerting/userpresence/rules/{ruleId} | Get a user presence rule. |
| [**GetAlertingUserpresenceRules**](AlertingApi.html#getalertinguserpresencerules) | **GET** /api/v2/alerting/userpresence/rules | Get a user presence rule list. |
| [**PostAlertingHeartbeatRules**](AlertingApi.html#postalertingheartbeatrules) | **POST** /api/v2/alerting/heartbeat/rules | Create a heart beat rule. |
| [**PostAlertingInteractionstatsRules**](AlertingApi.html#postalertinginteractionstatsrules) | **POST** /api/v2/alerting/interactionstats/rules | Create an interaction stats rule. |
| [**PostAlertingRoutingstatusRules**](AlertingApi.html#postalertingroutingstatusrules) | **POST** /api/v2/alerting/routingstatus/rules | Create a routing status rule. |
| [**PostAlertingUserpresenceRules**](AlertingApi.html#postalertinguserpresencerules) | **POST** /api/v2/alerting/userpresence/rules | Create a user presence rule. |
| [**PutAlertingHeartbeatRule**](AlertingApi.html#putalertingheartbeatrule) | **PUT** /api/v2/alerting/heartbeat/rules/{ruleId} | Update a heart beat rule |
| [**PutAlertingInteractionstatsAlert**](AlertingApi.html#putalertinginteractionstatsalert) | **PUT** /api/v2/alerting/interactionstats/alerts/{alertId} | Update an interaction stats alert read status |
| [**PutAlertingInteractionstatsRule**](AlertingApi.html#putalertinginteractionstatsrule) | **PUT** /api/v2/alerting/interactionstats/rules/{ruleId} | Update an interaction stats rule |
| [**PutAlertingRoutingstatusRule**](AlertingApi.html#putalertingroutingstatusrule) | **PUT** /api/v2/alerting/routingstatus/rules/{ruleId} | Update a routing status rule |
| [**PutAlertingUserpresenceRule**](AlertingApi.html#putalertinguserpresencerule) | **PUT** /api/v2/alerting/userpresence/rules/{ruleId} | Update a user presence rule |
{: class="table table-striped"}

<a name="deletealertingheartbeatalert"></a>

## void DeleteAlertingHeartbeatAlert (string alertId)

Delete a heart beat alert



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAlertingHeartbeatAlertExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            var alertId = alertId_example;  // string | Alert ID
            
            
            

            try
            {
                
                // Delete a heart beat alert
                
                apiInstance.DeleteAlertingHeartbeatAlert(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingHeartbeatAlert: " + e.Message );
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

<a name="deletealertingheartbeatrule"></a>

## void DeleteAlertingHeartbeatRule (string ruleId)

Delete a heart beat rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAlertingHeartbeatRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            var ruleId = ruleId_example;  // string | Rule ID
            
            
            

            try
            {
                
                // Delete a heart beat rule.
                
                apiInstance.DeleteAlertingHeartbeatRule(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingHeartbeatRule: " + e.Message );
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

<a name="deletealertingroutingstatusalert"></a>

## void DeleteAlertingRoutingstatusAlert (string alertId)

Delete a routing status alert



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAlertingRoutingstatusAlertExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            var alertId = alertId_example;  // string | Alert ID
            
            
            

            try
            {
                
                // Delete a routing status alert
                
                apiInstance.DeleteAlertingRoutingstatusAlert(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingRoutingstatusAlert: " + e.Message );
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

<a name="deletealertingroutingstatusrule"></a>

## void DeleteAlertingRoutingstatusRule (string ruleId)

Delete a routing status rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAlertingRoutingstatusRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            var ruleId = ruleId_example;  // string | Rule ID
            
            
            

            try
            {
                
                // Delete a routing status rule.
                
                apiInstance.DeleteAlertingRoutingstatusRule(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingRoutingstatusRule: " + e.Message );
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

<a name="deletealertinguserpresencealert"></a>

## void DeleteAlertingUserpresenceAlert (string alertId)

Delete a user presence alert



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAlertingUserpresenceAlertExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            var alertId = alertId_example;  // string | Alert ID
            
            
            

            try
            {
                
                // Delete a user presence alert
                
                apiInstance.DeleteAlertingUserpresenceAlert(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingUserpresenceAlert: " + e.Message );
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

<a name="deletealertinguserpresencerule"></a>

## void DeleteAlertingUserpresenceRule (string ruleId)

Delete a user presence rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAlertingUserpresenceRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            var ruleId = ruleId_example;  // string | Rule ID
            
            
            

            try
            {
                
                // Delete a user presence rule.
                
                apiInstance.DeleteAlertingUserpresenceRule(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteAlertingUserpresenceRule: " + e.Message );
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

<a name="getalertingheartbeatalert"></a>

## [**HeartBeatAlert**](HeartBeatAlert.html) GetAlertingHeartbeatAlert (string alertId, List<string> expand = null)

Get a heart beat alert



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingHeartbeatAlertExample
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
                
                // Get a heart beat alert
                
                HeartBeatAlert result = apiInstance.GetAlertingHeartbeatAlert(alertId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingHeartbeatAlert: " + e.Message );
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

[**HeartBeatAlert**](HeartBeatAlert.html)

<a name="getalertingheartbeatalerts"></a>

## [**HeartBeatAlertContainer**](HeartBeatAlertContainer.html) GetAlertingHeartbeatAlerts (List<string> expand = null)

Get heart beat alert list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingHeartbeatAlertsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Get heart beat alert list.
                
                HeartBeatAlertContainer result = apiInstance.GetAlertingHeartbeatAlerts(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingHeartbeatAlerts: " + e.Message );
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

[**HeartBeatAlertContainer**](HeartBeatAlertContainer.html)

<a name="getalertingheartbeatrule"></a>

## [**HeartBeatRule**](HeartBeatRule.html) GetAlertingHeartbeatRule (string ruleId, List<string> expand = null)

Get a heart beat rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingHeartbeatRuleExample
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
                
                // Get a heart beat rule.
                
                HeartBeatRule result = apiInstance.GetAlertingHeartbeatRule(ruleId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingHeartbeatRule: " + e.Message );
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

[**HeartBeatRule**](HeartBeatRule.html)

<a name="getalertingheartbeatrules"></a>

## [**HeartBeatRuleContainer**](HeartBeatRuleContainer.html) GetAlertingHeartbeatRules (List<string> expand = null)

Get a heart beat rule list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingHeartbeatRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Get a heart beat rule list.
                
                HeartBeatRuleContainer result = apiInstance.GetAlertingHeartbeatRules(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingHeartbeatRules: " + e.Message );
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

[**HeartBeatRuleContainer**](HeartBeatRuleContainer.html)

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

<a name="getalertingroutingstatusalert"></a>

## [**RoutingStatusAlert**](RoutingStatusAlert.html) GetAlertingRoutingstatusAlert (string alertId, List<string> expand = null)

Get a routing status alert



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingRoutingstatusAlertExample
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
                
                // Get a routing status alert
                
                RoutingStatusAlert result = apiInstance.GetAlertingRoutingstatusAlert(alertId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingRoutingstatusAlert: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, agent |
{: class="table table-striped"}

### Return type

[**RoutingStatusAlert**](RoutingStatusAlert.html)

<a name="getalertingroutingstatusalerts"></a>

## [**RoutingStatusAlertContainer**](RoutingStatusAlertContainer.html) GetAlertingRoutingstatusAlerts (List<string> expand = null)

Get routing status alert list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingRoutingstatusAlertsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Get routing status alert list.
                
                RoutingStatusAlertContainer result = apiInstance.GetAlertingRoutingstatusAlerts(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingRoutingstatusAlerts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, agent |
{: class="table table-striped"}

### Return type

[**RoutingStatusAlertContainer**](RoutingStatusAlertContainer.html)

<a name="getalertingroutingstatusrule"></a>

## [**RoutingStatusRule**](RoutingStatusRule.html) GetAlertingRoutingstatusRule (string ruleId, List<string> expand = null)

Get a routing status rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingRoutingstatusRuleExample
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
                
                // Get a routing status rule.
                
                RoutingStatusRule result = apiInstance.GetAlertingRoutingstatusRule(ruleId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingRoutingstatusRule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, agent |
{: class="table table-striped"}

### Return type

[**RoutingStatusRule**](RoutingStatusRule.html)

<a name="getalertingroutingstatusrules"></a>

## [**RoutingStatusRuleContainer**](RoutingStatusRuleContainer.html) GetAlertingRoutingstatusRules (List<string> expand = null)

Get a routing status rule list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingRoutingstatusRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Get a routing status rule list.
                
                RoutingStatusRuleContainer result = apiInstance.GetAlertingRoutingstatusRules(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingRoutingstatusRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, agent |
{: class="table table-striped"}

### Return type

[**RoutingStatusRuleContainer**](RoutingStatusRuleContainer.html)

<a name="getalertinguserpresencealert"></a>

## [**UserPresenceAlert**](UserPresenceAlert.html) GetAlertingUserpresenceAlert (string alertId, List<string> expand = null)

Get a user presence alert



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingUserpresenceAlertExample
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
                
                // Get a user presence alert
                
                UserPresenceAlert result = apiInstance.GetAlertingUserpresenceAlert(alertId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingUserpresenceAlert: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, presenceUser |
{: class="table table-striped"}

### Return type

[**UserPresenceAlert**](UserPresenceAlert.html)

<a name="getalertinguserpresencealerts"></a>

## [**UserPresenceAlertContainer**](UserPresenceAlertContainer.html) GetAlertingUserpresenceAlerts (List<string> expand = null)

Get user presence alert list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingUserpresenceAlertsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Get user presence alert list.
                
                UserPresenceAlertContainer result = apiInstance.GetAlertingUserpresenceAlerts(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingUserpresenceAlerts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, presenceUser |
{: class="table table-striped"}

### Return type

[**UserPresenceAlertContainer**](UserPresenceAlertContainer.html)

<a name="getalertinguserpresencerule"></a>

## [**UserPresenceRule**](UserPresenceRule.html) GetAlertingUserpresenceRule (string ruleId, List<string> expand = null)

Get a user presence rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingUserpresenceRuleExample
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
                
                // Get a user presence rule.
                
                UserPresenceRule result = apiInstance.GetAlertingUserpresenceRule(ruleId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingUserpresenceRule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, presenceUser |
{: class="table table-striped"}

### Return type

[**UserPresenceRule**](UserPresenceRule.html)

<a name="getalertinguserpresencerules"></a>

## [**UserPresenceRuleContainer**](UserPresenceRuleContainer.html) GetAlertingUserpresenceRules (List<string> expand = null)

Get a user presence rule list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAlertingUserpresenceRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Get a user presence rule list.
                
                UserPresenceRuleContainer result = apiInstance.GetAlertingUserpresenceRules(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetAlertingUserpresenceRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, presenceUser |
{: class="table table-striped"}

### Return type

[**UserPresenceRuleContainer**](UserPresenceRuleContainer.html)

<a name="postalertingheartbeatrules"></a>

## [**HeartBeatRule**](HeartBeatRule.html) PostAlertingHeartbeatRules (HeartBeatRule body, List<string> expand = null)

Create a heart beat rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAlertingHeartbeatRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            
            var body = new HeartBeatRule(); // HeartBeatRule | HeartBeatRule
            
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Create a heart beat rule.
                
                HeartBeatRule result = apiInstance.PostAlertingHeartbeatRules(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostAlertingHeartbeatRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**HeartBeatRule**](HeartBeatRule.html)| HeartBeatRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**HeartBeatRule**](HeartBeatRule.html)

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

<a name="postalertingroutingstatusrules"></a>

## [**RoutingStatusRule**](RoutingStatusRule.html) PostAlertingRoutingstatusRules (RoutingStatusRule body, List<string> expand = null)

Create a routing status rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAlertingRoutingstatusRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            
            var body = new RoutingStatusRule(); // RoutingStatusRule | RoutingStatusRule
            
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Create a routing status rule.
                
                RoutingStatusRule result = apiInstance.PostAlertingRoutingstatusRules(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostAlertingRoutingstatusRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RoutingStatusRule**](RoutingStatusRule.html)| RoutingStatusRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, agent |
{: class="table table-striped"}

### Return type

[**RoutingStatusRule**](RoutingStatusRule.html)

<a name="postalertinguserpresencerules"></a>

## [**UserPresenceRule**](UserPresenceRule.html) PostAlertingUserpresenceRules (UserPresenceRule body, List<string> expand = null)

Create a user presence rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAlertingUserpresenceRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            
            var body = new UserPresenceRule(); // UserPresenceRule | UserPresenceRule
            
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Create a user presence rule.
                
                UserPresenceRule result = apiInstance.PostAlertingUserpresenceRules(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostAlertingUserpresenceRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserPresenceRule**](UserPresenceRule.html)| UserPresenceRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, presenceUser |
{: class="table table-striped"}

### Return type

[**UserPresenceRule**](UserPresenceRule.html)

<a name="putalertingheartbeatrule"></a>

## [**HeartBeatRule**](HeartBeatRule.html) PutAlertingHeartbeatRule (string ruleId, HeartBeatRule body, List<string> expand = null)

Update a heart beat rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAlertingHeartbeatRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            var ruleId = ruleId_example;  // string | Rule ID
            
            
            
            
            
            var body = new HeartBeatRule(); // HeartBeatRule | HeartBeatRule
            
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Update a heart beat rule
                
                HeartBeatRule result = apiInstance.PutAlertingHeartbeatRule(ruleId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutAlertingHeartbeatRule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **body** | [**HeartBeatRule**](HeartBeatRule.html)| HeartBeatRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers |
{: class="table table-striped"}

### Return type

[**HeartBeatRule**](HeartBeatRule.html)

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

<a name="putalertingroutingstatusrule"></a>

## [**RoutingStatusRule**](RoutingStatusRule.html) PutAlertingRoutingstatusRule (string ruleId, RoutingStatusRule body, List<string> expand = null)

Update a routing status rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAlertingRoutingstatusRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            var ruleId = ruleId_example;  // string | Rule ID
            
            
            
            
            
            var body = new RoutingStatusRule(); // RoutingStatusRule | RoutingStatusRule
            
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Update a routing status rule
                
                RoutingStatusRule result = apiInstance.PutAlertingRoutingstatusRule(ruleId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutAlertingRoutingstatusRule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **body** | [**RoutingStatusRule**](RoutingStatusRule.html)| RoutingStatusRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, agent |
{: class="table table-striped"}

### Return type

[**RoutingStatusRule**](RoutingStatusRule.html)

<a name="putalertinguserpresencerule"></a>

## [**UserPresenceRule**](UserPresenceRule.html) PutAlertingUserpresenceRule (string ruleId, UserPresenceRule body, List<string> expand = null)

Update a user presence rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAlertingUserpresenceRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AlertingApi();
            
            
            var ruleId = ruleId_example;  // string | Rule ID
            
            
            
            
            
            var body = new UserPresenceRule(); // UserPresenceRule | UserPresenceRule
            
            
            
            
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            
            

            try
            {
                
                // Update a user presence rule
                
                UserPresenceRule result = apiInstance.PutAlertingUserpresenceRule(ruleId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutAlertingUserpresenceRule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **body** | [**UserPresenceRule**](UserPresenceRule.html)| UserPresenceRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional] <br />**Values**: notificationUsers, presenceUser |
{: class="table table-striped"}

### Return type

[**UserPresenceRule**](UserPresenceRule.html)

