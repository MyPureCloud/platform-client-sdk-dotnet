---
title: SignedDataApi
---
## PureCloudPlatform.Client.V2.Api.SignedDataApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**PostSigneddata**](SignedDataApi.html#postsigneddata) | **POST** /api/v2/signeddata | Sign identifying information |
{: class="table table-striped"}

<a name="postsigneddata"></a>

## [**SignedData**](SignedData.html) PostSigneddata (Object body = null)

Sign identifying information



### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostSigneddataExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new SignedDataApi();
            
            
            var body = ;  // Object |  (optional) 
            
            
            

            try
            {
                
                // Sign identifying information
                
                SignedData result = apiInstance.PostSigneddata(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignedDataApi.PostSigneddata: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | **Object**|  | [optional]  |
{: class="table table-striped"}

### Return type

[**SignedData**](SignedData.html)

