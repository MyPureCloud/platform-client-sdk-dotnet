---
title: AttributesApi
---
## PureCloudPlatform.Client.V2.Api.AttributesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAttribute**](AttributesApi.html#deleteattribute) | **DELETE** /api/v2/attributes/{attributeId} | Delete an existing Attribute. |
| [**GetAttribute**](AttributesApi.html#getattribute) | **GET** /api/v2/attributes/{attributeId} | Get details about an existing attribute. |
| [**GetAttributes**](AttributesApi.html#getattributes) | **GET** /api/v2/attributes | Gets a list of existing attributes. |
| [**PostAttributes**](AttributesApi.html#postattributes) | **POST** /api/v2/attributes | Create an attribute. |
| [**PostAttributesQuery**](AttributesApi.html#postattributesquery) | **POST** /api/v2/attributes/query | Query attributes |
| [**PutAttribute**](AttributesApi.html#putattribute) | **PUT** /api/v2/attributes/{attributeId} | Update an existing attribute. |
{: class="table table-striped"}

<a name="deleteattribute"></a>

## void DeleteAttribute (string attributeId)



Delete an existing Attribute.

This will remove attribute.

Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteAttributeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AttributesApi();
            
            
            var attributeId = attributeId_example;  // string | Attribute ID
            
            
            

            try
            {
                
                // Delete an existing Attribute.
                
                apiInstance.DeleteAttribute(attributeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.DeleteAttribute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attributeId** | **string**| Attribute ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getattribute"></a>

## [**PureCloudPlatform.Client.V2.Model.Attribute**](Attribute.html) GetAttribute (string attributeId)



Get details about an existing attribute.



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAttributeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AttributesApi();
            
            
            var attributeId = attributeId_example;  // string | Attribute ID
            
            
            

            try
            {
                
                // Get details about an existing attribute.
                
                PureCloudPlatform.Client.V2.Model.Attribute result = apiInstance.GetAttribute(attributeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.GetAttribute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attributeId** | **string**| Attribute ID |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Attribute**](Attribute.html)

<a name="getattributes"></a>

## [**AttributeEntityListing**](AttributeEntityListing.html) GetAttributes (int? pageNumber = null, int? pageSize = null)



Gets a list of existing attributes.



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AttributesApi();
            
            
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            
            
            
            
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            
            
            

            try
            {
                
                // Gets a list of existing attributes.
                
                AttributeEntityListing result = apiInstance.GetAttributes(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.GetAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**AttributeEntityListing**](AttributeEntityListing.html)

<a name="postattributes"></a>

## [**PureCloudPlatform.Client.V2.Model.Attribute**](Attribute.html) PostAttributes (PureCloudPlatform.Client.V2.Model.Attribute body)



Create an attribute.



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AttributesApi();
            
            
            
            var body = new PureCloudPlatform.Client.V2.Model.Attribute(); // PureCloudPlatform.Client.V2.Model.Attribute | Attribute
            
            

            try
            {
                
                // Create an attribute.
                
                PureCloudPlatform.Client.V2.Model.Attribute result = apiInstance.PostAttributes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.PostAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PureCloudPlatform.Client.V2.Model.Attribute**](PureCloudPlatform.Client.V2.Model.Attribute.html)| Attribute |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Attribute**](Attribute.html)

<a name="postattributesquery"></a>

## [**AttributeEntityListing**](AttributeEntityListing.html) PostAttributesQuery (AttributeQueryRequest body)



Query attributes



Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAttributesQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AttributesApi();
            
            
            
            var body = new AttributeQueryRequest(); // AttributeQueryRequest | query
            
            

            try
            {
                
                // Query attributes
                
                AttributeEntityListing result = apiInstance.PostAttributesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.PostAttributesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AttributeQueryRequest**](AttributeQueryRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**AttributeEntityListing**](AttributeEntityListing.html)

<a name="putattribute"></a>

## [**PureCloudPlatform.Client.V2.Model.Attribute**](Attribute.html) PutAttribute (string attributeId, PureCloudPlatform.Client.V2.Model.Attribute body)



Update an existing attribute.

Fields that can be updated: name, description. The most recent version is required for updates.

Requires NO permissions: 


### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutAttributeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new AttributesApi();
            
            
            var attributeId = attributeId_example;  // string | Attribute ID
            
            
            
            
            
            var body = new PureCloudPlatform.Client.V2.Model.Attribute(); // PureCloudPlatform.Client.V2.Model.Attribute | Attribute
            
            

            try
            {
                
                // Update an existing attribute.
                
                PureCloudPlatform.Client.V2.Model.Attribute result = apiInstance.PutAttribute(attributeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.PutAttribute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attributeId** | **string**| Attribute ID |  |
| **body** | [**PureCloudPlatform.Client.V2.Model.Attribute**](PureCloudPlatform.Client.V2.Model.Attribute.html)| Attribute |  |
{: class="table table-striped"}

### Return type

[**PureCloudPlatform.Client.V2.Model.Attribute**](Attribute.html)

