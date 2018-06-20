---
title: OrganizationApi
---
## PureCloudPlatform.Client.V2.Api.OrganizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetFieldconfig**](OrganizationApi.html#getfieldconfig) | **GET** /api/v2/fieldconfig | Fetch field config for an entity type |
| [**GetOrganizationsMe**](OrganizationApi.html#getorganizationsme) | **GET** /api/v2/organizations/me | Get organization. |
| [**PatchOrganizationsFeature**](OrganizationApi.html#patchorganizationsfeature) | **PATCH** /api/v2/organizations/features/{featureName} | Update organization |
| [**PutOrganizationsMe**](OrganizationApi.html#putorganizationsme) | **PUT** /api/v2/organizations/me | Update organization. |
{: class="table table-striped"}

<a name="getfieldconfig"></a>

## [**FieldConfig**](FieldConfig.html) GetFieldconfig (string type)



Fetch field config for an entity type



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
    public class GetFieldconfigExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationApi();
            
            
            var type = type_example;  // string | Field type
            
            
            

            try
            {
                
                // Fetch field config for an entity type
                
                FieldConfig result = apiInstance.GetFieldconfig(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetFieldconfig: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**| Field type | <br />**Values**: person, group, org, externalContact |
{: class="table table-striped"}

### Return type

[**FieldConfig**](FieldConfig.html)

<a name="getorganizationsme"></a>

## [**Organization**](Organization.html) GetOrganizationsMe ()



Get organization.



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
    public class GetOrganizationsMeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationApi();
            

            try
            {
                
                // Get organization.
                
                Organization result = apiInstance.GetOrganizationsMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationsMe: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Organization**](Organization.html)

<a name="patchorganizationsfeature"></a>

## [**OrganizationFeatures**](OrganizationFeatures.html) PatchOrganizationsFeature (string featureName, FeatureState enabled)



Update organization



Requires ANY permissions: 

* admin

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOrganizationsFeatureExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationApi();
            
            
            var featureName = featureName_example;  // string | Organization feature
            
            
            
            
            
            var enabled = new FeatureState(); // FeatureState | New state of feature
            
            

            try
            {
                
                // Update organization
                
                OrganizationFeatures result = apiInstance.PatchOrganizationsFeature(featureName, enabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PatchOrganizationsFeature: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **featureName** | **string**| Organization feature | <br />**Values**: realtimeCIC, purecloud, hipaa, ucEnabled, pci, purecloudVoice, xmppFederation, chat, informalPhotos, directory, contactCenter, unifiedCommunications, custserv |
| **enabled** | [**FeatureState**](FeatureState.html)| New state of feature |  |
{: class="table table-striped"}

### Return type

[**OrganizationFeatures**](OrganizationFeatures.html)

<a name="putorganizationsme"></a>

## [**Organization**](Organization.html) PutOrganizationsMe (Organization body = null)



Update organization.



Requires ANY permissions: 

* admin

### Example
~~~csharp
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOrganizationsMeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            

            var apiInstance = new OrganizationApi();
            
            
            
            var body = new Organization(); // Organization | Organization (optional) 
            
            

            try
            {
                
                // Update organization.
                
                Organization result = apiInstance.PutOrganizationsMe(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PutOrganizationsMe: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Organization**](Organization.html)| Organization | [optional]  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.html)

