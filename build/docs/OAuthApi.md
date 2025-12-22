# OAuthApi

## PureCloudPlatform.Client.V2.Api.OAuthApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteOauthClient**](#DeleteOauthClient) | **Delete** /api/v2/oauth/clients/{clientId} | Delete OAuth Client |
| [**GetOauthAuthorization**](#GetOauthAuthorization) | **Get** /api/v2/oauth/authorizations/{clientId} | Get a client that is authorized by the resource owner |
| [**GetOauthAuthorizations**](#GetOauthAuthorizations) | **Get** /api/v2/oauth/authorizations | List clients that have been authorized, requested, or revoked by the resource owner |
| [**GetOauthClient**](#GetOauthClient) | **Get** /api/v2/oauth/clients/{clientId} | Get OAuth Client |
| [**GetOauthClientUsageQueryResult**](#GetOauthClientUsageQueryResult) | **Get** /api/v2/oauth/clients/{clientId}/usage/query/results/{executionId} | Get the results of a usage query |
| [**GetOauthClientUsageSummary**](#GetOauthClientUsageSummary) | **Get** /api/v2/oauth/clients/{clientId}/usage/summary | Get a summary of OAuth client API usage |
| [**GetOauthClients**](#GetOauthClients) | **Get** /api/v2/oauth/clients | The list of OAuth clients |
| [**GetOauthScope**](#GetOauthScope) | **Get** /api/v2/oauth/scopes/{scopeId} | An OAuth scope |
| [**GetOauthScopes**](#GetOauthScopes) | **Get** /api/v2/oauth/scopes | The list of OAuth scopes |
| [**PostOauthClientSecret**](#PostOauthClientSecret) | **Post** /api/v2/oauth/clients/{clientId}/secret | Regenerate Client Secret |
| [**PostOauthClientUsageQuery**](#PostOauthClientUsageQuery) | **Post** /api/v2/oauth/clients/{clientId}/usage/query | Query for OAuth client API usage |
| [**PostOauthClients**](#PostOauthClients) | **Post** /api/v2/oauth/clients | Create OAuth client |
| [**PutOauthClient**](#PutOauthClient) | **Put** /api/v2/oauth/clients/{clientId} | Update OAuth Client |



## DeleteOauthClient

> void DeleteOauthClient (string clientId)


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

### Return type

void (empty response body)


## GetOauthAuthorization

> [**OAuthAuthorization**](OAuthAuthorization) GetOauthAuthorization (string clientId, string acceptLanguage = null)


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
            var acceptLanguage = acceptLanguage_example;  // string | The language in which to display the client descriptions. (optional)  (default to "en-us")

            try
            { 
                // Get a client that is authorized by the resource owner
                OAuthAuthorization result = apiInstance.GetOauthAuthorization(clientId, acceptLanguage);
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
| **acceptLanguage** | **string**| The language in which to display the client descriptions. | [optional] [default to "en-us"] |

### Return type

[**OAuthAuthorization**](OAuthAuthorization)


## GetOauthAuthorizations

> [**OAuthAuthorizationListing**](OAuthAuthorizationListing) GetOauthAuthorizations (string acceptLanguage = null)


List clients that have been authorized, requested, or revoked by the resource owner

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
            var acceptLanguage = acceptLanguage_example;  // string | The language in which to display the client descriptions. (optional)  (default to "en-us")

            try
            { 
                // List clients that have been authorized, requested, or revoked by the resource owner
                OAuthAuthorizationListing result = apiInstance.GetOauthAuthorizations(acceptLanguage);
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


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **acceptLanguage** | **string**| The language in which to display the client descriptions. | [optional] [default to "en-us"] |

### Return type

[**OAuthAuthorizationListing**](OAuthAuthorizationListing)


## GetOauthClient

> [**OAuthClient**](OAuthClient) GetOauthClient (string clientId)


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

### Return type

[**OAuthClient**](OAuthClient)


## GetOauthClientUsageQueryResult

> [**ApiUsageQueryResult**](ApiUsageQueryResult) GetOauthClientUsageQueryResult (string executionId, string clientId)


Get the results of a usage query

Requires ANY permissions: 

* oauth:client:view
* usage:client:view

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

### Return type

[**ApiUsageQueryResult**](ApiUsageQueryResult)


## GetOauthClientUsageSummary

> [**UsageExecutionResult**](UsageExecutionResult) GetOauthClientUsageSummary (string clientId, string days = null)


Get a summary of OAuth client API usage

After calling this method, you will then need to poll for the query results based on the returned execution Id

Requires ANY permissions: 

* oauth:client:view
* usage:client:view

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
            var days = days_example;  // string | Previous number of days to query (optional)  (default to "7")

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
| **days** | **string**| Previous number of days to query | [optional] [default to "7"] |

### Return type

[**UsageExecutionResult**](UsageExecutionResult)


## GetOauthClients

> [**OAuthClientEntityListing**](OAuthClientEntityListing) GetOauthClients ()


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

[**OAuthClientEntityListing**](OAuthClientEntityListing)


## GetOauthScope

> [**OAuthScope**](OAuthScope) GetOauthScope (string scopeId, string acceptLanguage = null)


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
            var acceptLanguage = acceptLanguage_example;  // string | The language with which to display the scope description. (optional)  (default to "en-us")

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
| **acceptLanguage** | **string**| The language with which to display the scope description. | [optional] [default to "en-us"] |

### Return type

[**OAuthScope**](OAuthScope)


## GetOauthScopes

> [**OAuthScopeListing**](OAuthScopeListing) GetOauthScopes (string acceptLanguage = null)


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
            var acceptLanguage = acceptLanguage_example;  // string | The language with which to display the scope descriptions. (optional)  (default to "en-us")

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
| **acceptLanguage** | **string**| The language with which to display the scope descriptions. | [optional] [default to "en-us"] |

### Return type

[**OAuthScopeListing**](OAuthScopeListing)


## PostOauthClientSecret

> [**OAuthClient**](OAuthClient) PostOauthClientSecret (string clientId)


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

### Return type

[**OAuthClient**](OAuthClient)


## PostOauthClientUsageQuery

> [**UsageExecutionResult**](UsageExecutionResult) PostOauthClientUsageQuery (string clientId, ApiUsageClientQuery body)


Query for OAuth client API usage

After calling this method, you will then need to poll for the query results based on the returned execution Id

Requires ANY permissions: 

* oauth:client:view
* usage:client:view

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
            var body = new ApiUsageClientQuery(); // ApiUsageClientQuery | Query

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
| **body** | [**ApiUsageClientQuery**](ApiUsageClientQuery)| Query |  |

### Return type

[**UsageExecutionResult**](UsageExecutionResult)


## PostOauthClients

> [**OAuthClient**](OAuthClient) PostOauthClients (OAuthClientRequest body)


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
| **body** | [**OAuthClientRequest**](OAuthClientRequest)| Client |  |

### Return type

[**OAuthClient**](OAuthClient)


## PutOauthClient

> [**OAuthClient**](OAuthClient) PutOauthClient (string clientId, OAuthClientRequest body)


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
| **body** | [**OAuthClientRequest**](OAuthClientRequest)| Client |  |

### Return type

[**OAuthClient**](OAuthClient)


_PureCloudPlatform.Client.V2 252.1.0_
