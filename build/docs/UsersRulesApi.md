# UsersRulesApi

## PureCloudPlatform.Client.V2.Api.UsersRulesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteUsersRule**](#DeleteUsersRule) | **Delete** /api/v2/users/rules/{ruleId} | Delete an existing users rule |
| [**GetUsersRule**](#GetUsersRule) | **Get** /api/v2/users/rules/{ruleId} | Get a users rule |
| [**GetUsersRuleDependentTypeId**](#GetUsersRuleDependentTypeId) | **Get** /api/v2/users/rules/{ruleId}/dependents/{ruleType}/{typeId} | Get dependent of a users rule |
| [**GetUsersRuleDependents**](#GetUsersRuleDependents) | **Get** /api/v2/users/rules/{ruleId}/dependents | Get dependents for a users rule |
| [**GetUsersRules**](#GetUsersRules) | **Get** /api/v2/users/rules | Get the list of users rules |
| [**GetUsersRulesSetting**](#GetUsersRulesSetting) | **Get** /api/v2/users/rules/settings/{ruleType} | Get the settings for a specific users rule type |
| [**PatchUsersRule**](#PatchUsersRule) | **Patch** /api/v2/users/rules/{ruleId} | Update an existing users rule |
| [**PostUsersRules**](#PostUsersRules) | **Post** /api/v2/users/rules | Create a new rule |
| [**PostUsersRulesQuery**](#PostUsersRulesQuery) | **Post** /api/v2/users/rules/query | Query the result of a users rule |



## DeleteUsersRule

> void DeleteUsersRule (string ruleId)


Delete an existing users rule

DeleteUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* users:rules:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUsersRuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersRulesApi();
            var ruleId = ruleId_example;  // string | The id of the rule

            try
            { 
                // Delete an existing users rule
                apiInstance.DeleteUsersRule(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRulesApi.DeleteUsersRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| The id of the rule |  |

### Return type

void (empty response body)


## GetUsersRule

> [**UsersRulesRule**](UsersRulesRule) GetUsersRule (string ruleId)


Get a users rule

GetUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* users:rules:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersRuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersRulesApi();
            var ruleId = ruleId_example;  // string | The ID of the rule to retrieve

            try
            { 
                // Get a users rule
                UsersRulesRule result = apiInstance.GetUsersRule(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRulesApi.GetUsersRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| The ID of the rule to retrieve |  |

### Return type

[**UsersRulesRule**](UsersRulesRule)


## GetUsersRuleDependentTypeId

> [**UsersRulesDependent**](UsersRulesDependent) GetUsersRuleDependentTypeId (string ruleId, string ruleType, string typeId)


Get dependent of a users rule

GetUsersRuleDependentTypeId is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* users:ruleDependents:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersRuleDependentTypeIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersRulesApi();
            var ruleId = ruleId_example;  // string | The ID of the rule for which to retrieve dependents
            var ruleType = ruleType_example;  // string | The type of the dependent
            var typeId = typeId_example;  // string | The type ID of the dependent

            try
            { 
                // Get dependent of a users rule
                UsersRulesDependent result = apiInstance.GetUsersRuleDependentTypeId(ruleId, ruleType, typeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRulesApi.GetUsersRuleDependentTypeId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| The ID of the rule for which to retrieve dependents |  |
| **ruleType** | **string**| The type of the dependent | <br />**Values**: learning |
| **typeId** | **string**| The type ID of the dependent |  |

### Return type

[**UsersRulesDependent**](UsersRulesDependent)


## GetUsersRuleDependents

> [**UsersRulesDependentList**](UsersRulesDependentList) GetUsersRuleDependents (string ruleId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)


Get dependents for a users rule

GetUsersRuleDependents is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* users:ruleDependents:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersRuleDependentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersRulesApi();
            var ruleId = ruleId_example;  // string | The ID of the rule for which to retrieve dependents
            var pageSize = 56;  // int? | Number of results per page (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order for dependents (by last run date, then created date) (optional)  (default to descending)

            try
            { 
                // Get dependents for a users rule
                UsersRulesDependentList result = apiInstance.GetUsersRuleDependents(ruleId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRulesApi.GetUsersRuleDependents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| The ID of the rule for which to retrieve dependents |  |
| **pageSize** | **int?**| Number of results per page | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order for dependents (by last run date, then created date) | [optional] [default to descending]<br />**Values**: ascending, descending |

### Return type

[**UsersRulesDependentList**](UsersRulesDependentList)


## GetUsersRules

> [**UsersRulesRuleList**](UsersRulesRuleList) GetUsersRules (List<string> types, int? pageNumber = null, int? pageSize = null, List<string> expand = null, string searchTerm = null, string sortOrder = null)


Get the list of users rules

GetUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* users:rules:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersRulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersRulesApi();
            var types = new List<string>(); // List<string> | The types of the rule
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Number of results per page (optional)  (default to 25)
            var expand = new List<string>(); // List<string> | Fields to expand in response (optional) 
            var searchTerm = searchTerm_example;  // string | a search term for finding a rule by name (optional) 
            var sortOrder = sortOrder_example;  // string | sort rules by name, ascending, descending (optional)  (default to ascending)

            try
            { 
                // Get the list of users rules
                UsersRulesRuleList result = apiInstance.GetUsersRules(types, pageNumber, pageSize, expand, searchTerm, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRulesApi.GetUsersRules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **types** | [**List<string>**](string)| The types of the rule | <br />**Values**: Learning |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Number of results per page | [optional] [default to 25] |
| **expand** | [**List<string>**](string)| Fields to expand in response | [optional] <br />**Values**: criteria |
| **searchTerm** | **string**| a search term for finding a rule by name | [optional]  |
| **sortOrder** | **string**| sort rules by name, ascending, descending | [optional] [default to ascending]<br />**Values**: ascending, descending |

### Return type

[**UsersRulesRuleList**](UsersRulesRuleList)


## GetUsersRulesSetting

> [**UsersRulesRuleSettings**](UsersRulesRuleSettings) GetUsersRulesSetting (string ruleType)


Get the settings for a specific users rule type

GetUsersRulesSetting is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* users:rules:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUsersRulesSettingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersRulesApi();
            var ruleType = ruleType_example;  // string | The type of the rule

            try
            { 
                // Get the settings for a specific users rule type
                UsersRulesRuleSettings result = apiInstance.GetUsersRulesSetting(ruleType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRulesApi.GetUsersRulesSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleType** | **string**| The type of the rule | <br />**Values**: Learning |

### Return type

[**UsersRulesRuleSettings**](UsersRulesRuleSettings)


## PatchUsersRule

> [**UsersRulesRule**](UsersRulesRule) PatchUsersRule (string ruleId, UsersRulesUpdateRuleRequest body)


Update an existing users rule

This will update an existing users rule with the specified fields.

PatchUsersRule is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* users:rules:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUsersRuleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersRulesApi();
            var ruleId = ruleId_example;  // string | The ID of the rule to update
            var body = new UsersRulesUpdateRuleRequest(); // UsersRulesUpdateRuleRequest | updateRuleRequest

            try
            { 
                // Update an existing users rule
                UsersRulesRule result = apiInstance.PatchUsersRule(ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRulesApi.PatchUsersRule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| The ID of the rule to update |  |
| **body** | [**UsersRulesUpdateRuleRequest**](UsersRulesUpdateRuleRequest)| updateRuleRequest |  |

### Return type

[**UsersRulesRule**](UsersRulesRule)


## PostUsersRules

> [**UsersRulesRule**](UsersRulesRule) PostUsersRules (UsersRulesCreateRuleRequest body)


Create a new rule

This will create a new rule with the specified fields.

PostUsersRules is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* users:rules:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersRulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersRulesApi();
            var body = new UsersRulesCreateRuleRequest(); // UsersRulesCreateRuleRequest | usersRulesCreateRuleRequest

            try
            { 
                // Create a new rule
                UsersRulesRule result = apiInstance.PostUsersRules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRulesApi.PostUsersRules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UsersRulesCreateRuleRequest**](UsersRulesCreateRuleRequest)| usersRulesCreateRuleRequest |  |

### Return type

[**UsersRulesRule**](UsersRulesRule)


## PostUsersRulesQuery

> [**UsersRulesQueryResponse**](UsersRulesQueryResponse) PostUsersRulesQuery (UsersRulesQueryRuleRequest body, int? pageNumber = null, int? pageSize = null)


Query the result of a users rule

This will query the result of a rule.

PostUsersRulesQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ANY permissions: 

* users:ruleUsers:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUsersRulesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UsersRulesApi();
            var body = new UsersRulesQueryRuleRequest(); // UsersRulesQueryRuleRequest | usersRulesQueryRuleRequest
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Number of results per page (optional)  (default to 25)

            try
            { 
                // Query the result of a users rule
                UsersRulesQueryResponse result = apiInstance.PostUsersRulesQuery(body, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRulesApi.PostUsersRulesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UsersRulesQueryRuleRequest**](UsersRulesQueryRuleRequest)| usersRulesQueryRuleRequest |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Number of results per page | [optional] [default to 25] |

### Return type

[**UsersRulesQueryResponse**](UsersRulesQueryResponse)


_PureCloudPlatform.Client.V2 250.0.0_
