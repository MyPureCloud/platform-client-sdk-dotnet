---
title: ObjectsApi
---
## PureCloudPlatform.Client.V2.Api.ObjectsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetAuthorizationDivisionsLimit**](ObjectsApi.html#getauthorizationdivisionslimit) | **GET** /api/v2/authorization/divisions/limit | Returns the maximum allowed number of divisions. |
{: class="table table-striped"}

<a name="getauthorizationdivisionslimit"></a>

## **int?** GetAuthorizationDivisionsLimit ()

Returns the maximum allowed number of divisions.



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAuthorizationDivisionsLimitExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ObjectsApi();
            

            try
            {
                
                // Returns the maximum allowed number of divisions.
                
                int? result = apiInstance.GetAuthorizationDivisionsLimit();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.GetAuthorizationDivisionsLimit: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**int?**

