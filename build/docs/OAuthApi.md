---
title: OAuthApi
---
## PureCloudPlatform.Client.V2.Api.OAuthApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteOauthClient**](OAuthApi.html#deleteoauthclient) | **DELETE** /api/v2/oauth/clients/{clientId} | Delete OAuth Client |
| [**GetOauthClient**](OAuthApi.html#getoauthclient) | **GET** /api/v2/oauth/clients/{clientId} | Get OAuth Client |
| [**GetOauthClients**](OAuthApi.html#getoauthclients) | **GET** /api/v2/oauth/clients | The list of OAuth clients |
| [**PostOauthClientSecret**](OAuthApi.html#postoauthclientsecret) | **POST** /api/v2/oauth/clients/{clientId}/secret | Regenerate Client Secret |
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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
{: class="table table-striped"}

### Return type

[**OAuthClientEntityListing**](OAuthClientEntityListing.html)

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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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

<a name="postoauthclients"></a>

## [**OAuthClient**](OAuthClient.html) PostOauthClients (OAuthClient body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthApi();
            var body = new OAuthClient(); // OAuthClient | Client

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
| **body** | [**OAuthClient**](OAuthClient.html)| Client |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.html)

<a name="putoauthclient"></a>

## [**OAuthClient**](OAuthClient.html) PutOauthClient (string clientId, OAuthClient body)



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
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID
            var body = new OAuthClient(); // OAuthClient | Client

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
| **body** | [**OAuthClient**](OAuthClient.html)| Client |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.html)

