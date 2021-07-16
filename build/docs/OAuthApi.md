---
title: OAuthApi
---
## PureCloudPlatform.Client.V2.Api.OAuthApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteOauthClient**](OAuthApi.html#deleteoauthclient) | **DELETE** /api/v2/oauth/clients/{clientId} | Delete OAuth Client |
| [**GetOauthAuthorization**](OAuthApi.html#getoauthauthorization) | **GET** /api/v2/oauth/authorizations/{clientId} | Get a client that is authorized by the resource owner |
| [**GetOauthAuthorizations**](OAuthApi.html#getoauthauthorizations) | **GET** /api/v2/oauth/authorizations | List clients that are authorized by the resource owner |
| [**GetOauthClient**](OAuthApi.html#getoauthclient) | **GET** /api/v2/oauth/clients/{clientId} | Get OAuth Client |
| [**GetOauthClientUsageQueryResult**](OAuthApi.html#getoauthclientusagequeryresult) | **GET** /api/v2/oauth/clients/{clientId}/usage/query/results/{executionId} | Get the results of a usage query |
| [**GetOauthClientUsageSummary**](OAuthApi.html#getoauthclientusagesummary) | **GET** /api/v2/oauth/clients/{clientId}/usage/summary | Get a summary of OAuth client API usage |
| [**GetOauthClients**](OAuthApi.html#getoauthclients) | **GET** /api/v2/oauth/clients | The list of OAuth clients |
| [**GetOauthScope**](OAuthApi.html#getoauthscope) | **GET** /api/v2/oauth/scopes/{scopeId} | An OAuth scope |
| [**GetOauthScopes**](OAuthApi.html#getoauthscopes) | **GET** /api/v2/oauth/scopes | The list of OAuth scopes |
| [**PostOauthClientSecret**](OAuthApi.html#postoauthclientsecret) | **POST** /api/v2/oauth/clients/{clientId}/secret | Regenerate Client Secret |
| [**PostOauthClientUsageQuery**](OAuthApi.html#postoauthclientusagequery) | **POST** /api/v2/oauth/clients/{clientId}/usage/query | Query for OAuth client API usage |
| [**PostOauthClients**](OAuthApi.html#postoauthclients) | **POST** /api/v2/oauth/clients | Create OAuth client |
| [**PutOauthClient**](OAuthApi.html#putoauthclient) | **PUT** /api/v2/oauth/clients/{clientId} | Update OAuth Client |
{: class="table table-striped"}

<a name="deleteoauthclient"></a>

## void DeleteOauthClient (string clientId)



Delete OAuth Client



Requires ANY permissions: 

* oauth:client:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOauthClientExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID

            try
            { 
                // Delete OAuth Client
                apiInstance.DeleteOauthClient(clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.DeleteOauthClient: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getoauthauthorization"></a>

## [**OAuthAuthorization**](OAuthAuthorization.html) GetOauthAuthorization (string clientId)



Get a client that is authorized by the resource owner



Requires ANY permissions: 

* oauth:client:authorize

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOauthAuthorizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | The ID of client

            try
            { 
                // Get a client that is authorized by the resource owner
                OAuthAuthorization result = apiInstance.GetOauthAuthorization(clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetOauthAuthorization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| The ID of client |  |
{: class="table table-striped"}

### Return type

[**OAuthAuthorization**](OAuthAuthorization.html)

<a name="getoauthauthorizations"></a>

## [**OAuthAuthorizationListing**](OAuthAuthorizationListing.html) GetOauthAuthorizations ()



List clients that are authorized by the resource owner



Requires ANY permissions: 

* oauth:client:authorize

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOauthAuthorizationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();

            try
            { 
                // List clients that are authorized by the resource owner
                OAuthAuthorizationListing result = apiInstance.GetOauthAuthorizations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetOauthAuthorizations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**OAuthAuthorizationListing**](OAuthAuthorizationListing.html)

<a name="getoauthclient"></a>

## [**OAuthClient**](OAuthClient.html) GetOauthClient (string clientId)



Get OAuth Client



Requires ANY permissions: 

* oauth:client:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOauthClientExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID

            try
            { 
                // Get OAuth Client
                OAuthClient result = apiInstance.GetOauthClient(clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetOauthClient: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.html)

<a name="getoauthclientusagequeryresult"></a>

## [**ApiUsageQueryResult**](ApiUsageQueryResult.html) GetOauthClientUsageQueryResult (string executionId, string clientId)



Get the results of a usage query



Requires ANY permissions: 

* oauth:client:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOauthClientUsageQueryResultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var executionId = executionId_example;  // string | ID of the query execution
            var clientId = clientId_example;  // string | Client ID

            try
            { 
                // Get the results of a usage query
                ApiUsageQueryResult result = apiInstance.GetOauthClientUsageQueryResult(executionId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetOauthClientUsageQueryResult: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **executionId** | **string**| ID of the query execution |  |
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

[**ApiUsageQueryResult**](ApiUsageQueryResult.html)

<a name="getoauthclientusagesummary"></a>

## [**UsageExecutionResult**](UsageExecutionResult.html) GetOauthClientUsageSummary (string clientId, string days = null)



Get a summary of OAuth client API usage

After calling this method, you will then need to poll for the query results based on the returned execution Id

Requires ANY permissions: 

* oauth:client:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOauthClientUsageSummaryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID
            var days = days_example;  // string | Previous number of days to query (optional)  (default to 7)

            try
            { 
                // Get a summary of OAuth client API usage
                UsageExecutionResult result = apiInstance.GetOauthClientUsageSummary(clientId, days);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetOauthClientUsageSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
| **days** | **string**| Previous number of days to query | [optional] [default to 7] |
{: class="table table-striped"}

### Return type

[**UsageExecutionResult**](UsageExecutionResult.html)

<a name="getoauthclients"></a>

## [**OAuthClientEntityListing**](OAuthClientEntityListing.html) GetOauthClients ()



The list of OAuth clients



Requires ANY permissions: 

* oauth:client:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOauthClientsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();

            try
            { 
                // The list of OAuth clients
                OAuthClientEntityListing result = apiInstance.GetOauthClients();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetOauthClients: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**OAuthClientEntityListing**](OAuthClientEntityListing.html)

<a name="getoauthscope"></a>

## [**OAuthScope**](OAuthScope.html) GetOauthScope (string scopeId, string acceptLanguage = null)



An OAuth scope



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
    public class GetOauthScopeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var scopeId = scopeId_example;  // string | Scope ID
            var acceptLanguage = acceptLanguage_example;  // string | The language with which to display the scope description. (optional)  (default to en-us)

            try
            { 
                // An OAuth scope
                OAuthScope result = apiInstance.GetOauthScope(scopeId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetOauthScope: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scopeId** | **string**| Scope ID |  |
| **acceptLanguage** | **string**| The language with which to display the scope description. | [optional] [default to en-us] |
{: class="table table-striped"}

### Return type

[**OAuthScope**](OAuthScope.html)

<a name="getoauthscopes"></a>

## [**OAuthScopeListing**](OAuthScopeListing.html) GetOauthScopes (string acceptLanguage = null)



The list of OAuth scopes



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
    public class GetOauthScopesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var acceptLanguage = acceptLanguage_example;  // string | The language with which to display the scope descriptions. (optional)  (default to en-us)

            try
            { 
                // The list of OAuth scopes
                OAuthScopeListing result = apiInstance.GetOauthScopes(acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetOauthScopes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **acceptLanguage** | **string**| The language with which to display the scope descriptions. | [optional] [default to en-us] |
{: class="table table-striped"}

### Return type

[**OAuthScopeListing**](OAuthScopeListing.html)

<a name="postoauthclientsecret"></a>

## [**OAuthClient**](OAuthClient.html) PostOauthClientSecret (string clientId)



Regenerate Client Secret

This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.

Requires ANY permissions: 

* oauth:client:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOauthClientSecretExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID

            try
            { 
                // Regenerate Client Secret
                OAuthClient result = apiInstance.PostOauthClientSecret(clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PostOauthClientSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.html)

<a name="postoauthclientusagequery"></a>

## [**UsageExecutionResult**](UsageExecutionResult.html) PostOauthClientUsageQuery (string clientId, ApiUsageQuery body)



Query for OAuth client API usage

After calling this method, you will then need to poll for the query results based on the returned execution Id

Requires ANY permissions: 

* oauth:client:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOauthClientUsageQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID
            var body = new ApiUsageQuery(); // ApiUsageQuery | Query

            try
            { 
                // Query for OAuth client API usage
                UsageExecutionResult result = apiInstance.PostOauthClientUsageQuery(clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PostOauthClientUsageQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
| **body** | [**ApiUsageQuery**](ApiUsageQuery.html)| Query |  |
{: class="table table-striped"}

### Return type

[**UsageExecutionResult**](UsageExecutionResult.html)

<a name="postoauthclients"></a>

## [**OAuthClient**](OAuthClient.html) PostOauthClients (OAuthClientRequest body)



Create OAuth client

The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud.  The preferred authorizedGrantTypes is 'CODE' which requires applications to send a client ID and client secret. This is typically a web server.  If the client is unable to secure the client secret then the 'TOKEN' grant type aka IMPLICIT should be used. This is would be for browser or mobile apps.  If a client is to be used outside of the context of a user then the 'CLIENT-CREDENTIALS' grant may be used. In this case the client must be granted roles  via the 'roleIds' field.

Requires ANY permissions: 

* oauth:client:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOauthClientsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var body = new OAuthClientRequest(); // OAuthClientRequest | Client

            try
            { 
                // Create OAuth client
                OAuthClient result = apiInstance.PostOauthClients(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PostOauthClients: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OAuthClientRequest**](OAuthClientRequest.html)| Client |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.html)

<a name="putoauthclient"></a>

## [**OAuthClient**](OAuthClient.html) PutOauthClient (string clientId, OAuthClientRequest body)



Update OAuth Client



Requires ANY permissions: 

* oauth:client:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOauthClientExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID
            var body = new OAuthClientRequest(); // OAuthClientRequest | Client

            try
            { 
                // Update OAuth Client
                OAuthClient result = apiInstance.PutOauthClient(clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PutOauthClient: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
| **body** | [**OAuthClientRequest**](OAuthClientRequest.html)| Client |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.html)

