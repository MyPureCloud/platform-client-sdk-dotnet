---
title: ObjectsApi
---
## PureCloudPlatform.Client.V2.Api.ObjectsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetAuthorizationDivisionsLimit**](ObjectsApi.html#getauthorizationdivisionslimit) | **GET** /api/v2/authorization/divisions/limit | Returns the maximum allowed number of divisions. |
| [**PostAuthorizationDivisionObject**](ObjectsApi.html#postauthorizationdivisionobject) | **POST** /api/v2/authorization/divisions/{divisionId}/objects/{objectType} | Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER |
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

<a name="postauthorizationdivisionobject"></a>

## [**List&lt;AuthzTypedObject&gt;**](AuthzTypedObject.html) PostAuthorizationDivisionObject (string divisionId, string objectType, List<string> body)

Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAuthorizationDivisionObjectExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new ObjectsApi();
            
            
            var divisionId = divisionId_example;  // string | Division ID
            
            
            
            
            var objectType = objectType_example;  // string | The type of the objects. Must be one of the valid object types
            
            
            
            
            var body = ;  // List<string> | Object Id List
            
            
            

            try
            {
                
                // Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER
                
                List&lt;AuthzTypedObject&gt; result = apiInstance.PostAuthorizationDivisionObject(divisionId, objectType, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.PostAuthorizationDivisionObject: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | **string**| Division ID |  |
| **objectType** | **string**| The type of the objects. Must be one of the valid object types | <br />**Values**: QUEUE, CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, USER |
| **body** | **List<string>**| Object Id List |  |
{: class="table table-striped"}

### Return type

[**List<AuthzTypedObject>**](AuthzTypedObject.html)

