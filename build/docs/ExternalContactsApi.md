---
title: ExternalContactsApi
---
## PureCloudPlatform.Client.V2.Api.ExternalContactsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteExternalcontactsContact**](ExternalContactsApi.html#deleteexternalcontactscontact) | **DELETE** /api/v2/externalcontacts/contacts/{contactId} | Delete an external contact |
| [**DeleteExternalcontactsContactNote**](ExternalContactsApi.html#deleteexternalcontactscontactnote) | **DELETE** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Delete a note for an external contact |
| [**DeleteExternalcontactsOrganization**](ExternalContactsApi.html#deleteexternalcontactsorganization) | **DELETE** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Delete an external organization |
| [**DeleteExternalcontactsOrganizationNote**](ExternalContactsApi.html#deleteexternalcontactsorganizationnote) | **DELETE** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Delete a note for an external organization |
| [**DeleteExternalcontactsOrganizationTrustor**](ExternalContactsApi.html#deleteexternalcontactsorganizationtrustor) | **DELETE** /api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor | Unlink the Trustor for this External Organization |
| [**DeleteExternalcontactsRelationship**](ExternalContactsApi.html#deleteexternalcontactsrelationship) | **DELETE** /api/v2/externalcontacts/relationships/{relationshipId} | Delete a relationship |
| [**GetExternalcontactsContact**](ExternalContactsApi.html#getexternalcontactscontact) | **GET** /api/v2/externalcontacts/contacts/{contactId} | Fetch an external contact |
| [**GetExternalcontactsContactNote**](ExternalContactsApi.html#getexternalcontactscontactnote) | **GET** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Fetch a note for an external contact |
| [**GetExternalcontactsContactNotes**](ExternalContactsApi.html#getexternalcontactscontactnotes) | **GET** /api/v2/externalcontacts/contacts/{contactId}/notes | List notes for an external contact |
| [**GetExternalcontactsContacts**](ExternalContactsApi.html#getexternalcontactscontacts) | **GET** /api/v2/externalcontacts/contacts | Search for external contacts |
| [**GetExternalcontactsOrganization**](ExternalContactsApi.html#getexternalcontactsorganization) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Fetch an external organization |
| [**GetExternalcontactsOrganizationContacts**](ExternalContactsApi.html#getexternalcontactsorganizationcontacts) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/contacts | Search for external contacts in an external organization |
| [**GetExternalcontactsOrganizationNote**](ExternalContactsApi.html#getexternalcontactsorganizationnote) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Fetch a note for an external organization |
| [**GetExternalcontactsOrganizationNotes**](ExternalContactsApi.html#getexternalcontactsorganizationnotes) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes | List notes for an external organization |
| [**GetExternalcontactsOrganizationRelationships**](ExternalContactsApi.html#getexternalcontactsorganizationrelationships) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/relationships | Fetch a relationship for an external organization |
| [**GetExternalcontactsOrganizations**](ExternalContactsApi.html#getexternalcontactsorganizations) | **GET** /api/v2/externalcontacts/organizations | Search for external organizations |
| [**GetExternalcontactsRelationship**](ExternalContactsApi.html#getexternalcontactsrelationship) | **GET** /api/v2/externalcontacts/relationships/{relationshipId} | Fetch a relationship |
| [**GetExternalcontactsReversewhitepageslookup**](ExternalContactsApi.html#getexternalcontactsreversewhitepageslookup) | **GET** /api/v2/externalcontacts/reversewhitepageslookup | Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned. |
| [**PostExternalcontactsContactNotes**](ExternalContactsApi.html#postexternalcontactscontactnotes) | **POST** /api/v2/externalcontacts/contacts/{contactId}/notes | Create a note for an external contact |
| [**PostExternalcontactsContacts**](ExternalContactsApi.html#postexternalcontactscontacts) | **POST** /api/v2/externalcontacts/contacts | Create an external contact |
| [**PostExternalcontactsOrganizationNotes**](ExternalContactsApi.html#postexternalcontactsorganizationnotes) | **POST** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes | Create a note for an external organization |
| [**PostExternalcontactsOrganizations**](ExternalContactsApi.html#postexternalcontactsorganizations) | **POST** /api/v2/externalcontacts/organizations | Create an external organization |
| [**PostExternalcontactsRelationships**](ExternalContactsApi.html#postexternalcontactsrelationships) | **POST** /api/v2/externalcontacts/relationships | Create a relationship |
| [**PutExternalcontactsContact**](ExternalContactsApi.html#putexternalcontactscontact) | **PUT** /api/v2/externalcontacts/contacts/{contactId} | Update an external contact |
| [**PutExternalcontactsContactNote**](ExternalContactsApi.html#putexternalcontactscontactnote) | **PUT** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Update a note for an external contact |
| [**PutExternalcontactsConversation**](ExternalContactsApi.html#putexternalcontactsconversation) | **PUT** /api/v2/externalcontacts/conversations/{conversationId} | Associate an external contact with a conversation |
| [**PutExternalcontactsOrganization**](ExternalContactsApi.html#putexternalcontactsorganization) | **PUT** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Update an external organization |
| [**PutExternalcontactsOrganizationNote**](ExternalContactsApi.html#putexternalcontactsorganizationnote) | **PUT** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Update a note for an external organization |
| [**PutExternalcontactsOrganizationTrustorTrustorId**](ExternalContactsApi.html#putexternalcontactsorganizationtrustortrustorid) | **PUT** /api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor/{trustorId} | Links a Trustor with an External Organization |
| [**PutExternalcontactsRelationship**](ExternalContactsApi.html#putexternalcontactsrelationship) | **PUT** /api/v2/externalcontacts/relationships/{relationshipId} | Update a relationship |
{: class="table table-striped"}

<a name="deleteexternalcontactscontact"></a>

## void DeleteExternalcontactsContact (string contactId)



Delete an external contact



Requires ANY permissions: 

* externalContacts:contact:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsContactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact ID

            try
            { 
                // Delete an external contact
                apiInstance.DeleteExternalcontactsContact(contactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteExternalcontactsContact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteexternalcontactscontactnote"></a>

## void DeleteExternalcontactsContactNote (string contactId, string noteId)



Delete a note for an external contact



Requires ANY permissions: 

* externalContacts:contact:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsContactNoteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var noteId = noteId_example;  // string | Note Id

            try
            { 
                // Delete a note for an external contact
                apiInstance.DeleteExternalcontactsContactNote(contactId, noteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteExternalcontactsContactNote: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact Id |  |
| **noteId** | **string**| Note Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteexternalcontactsorganization"></a>

## void DeleteExternalcontactsOrganization (string externalOrganizationId)



Delete an external organization



Requires ANY permissions: 

* externalContacts:externalOrganization:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsOrganizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID

            try
            { 
                // Delete an external organization
                apiInstance.DeleteExternalcontactsOrganization(externalOrganizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteExternalcontactsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteexternalcontactsorganizationnote"></a>

## void DeleteExternalcontactsOrganizationNote (string externalOrganizationId, string noteId)



Delete a note for an external organization



Requires ANY permissions: 

* externalContacts:externalOrganization:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsOrganizationNoteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var noteId = noteId_example;  // string | Note Id

            try
            { 
                // Delete a note for an external organization
                apiInstance.DeleteExternalcontactsOrganizationNote(externalOrganizationId, noteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteExternalcontactsOrganizationNote: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization Id |  |
| **noteId** | **string**| Note Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteexternalcontactsorganizationtrustor"></a>

## void DeleteExternalcontactsOrganizationTrustor (string externalOrganizationId)



Unlink the Trustor for this External Organization



Requires ANY permissions: 

* externalContacts:externalOrganization:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsOrganizationTrustorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID

            try
            { 
                // Unlink the Trustor for this External Organization
                apiInstance.DeleteExternalcontactsOrganizationTrustor(externalOrganizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteExternalcontactsOrganizationTrustor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteexternalcontactsrelationship"></a>

## void DeleteExternalcontactsRelationship (string relationshipId)



Delete a relationship



Requires ANY permissions: 

* externalContacts:externalOrganization:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsRelationshipExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var relationshipId = relationshipId_example;  // string | Relationship Id

            try
            { 
                // Delete a relationship
                apiInstance.DeleteExternalcontactsRelationship(relationshipId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteExternalcontactsRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **relationshipId** | **string**| Relationship Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getexternalcontactscontact"></a>

## [**ExternalContact**](ExternalContact.html) GetExternalcontactsContact (string contactId, List<string> expand = null)



Fetch an external contact



Requires ANY permissions: 

* externalContacts:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsContactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact ID
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (externalOrganization,externalDataSources) (optional) 

            try
            { 
                // Fetch an external contact
                ExternalContact result = apiInstance.GetExternalcontactsContact(contactId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |
| **expand** | [**List<string>**](string.html)| which fields, if any, to expand (externalOrganization,externalDataSources) | [optional] <br />**Values**: externalOrganization, externalDataSources |
{: class="table table-striped"}

### Return type

[**ExternalContact**](ExternalContact.html)

<a name="getexternalcontactscontactnote"></a>

## [**Note**](Note.html) GetExternalcontactsContactNote (string contactId, string noteId, List<string> expand = null)



Fetch a note for an external contact



Requires ANY permissions: 

* externalContacts:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsContactNoteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var noteId = noteId_example;  // string | Note Id
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

            try
            { 
                // Fetch a note for an external contact
                Note result = apiInstance.GetExternalcontactsContactNote(contactId, noteId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContactNote: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact Id |  |
| **noteId** | **string**| Note Id |  |
| **expand** | [**List<string>**](string.html)| which fields, if any, to expand | [optional] <br />**Values**: author, externalDataSources |
{: class="table table-striped"}

### Return type

[**Note**](Note.html)

<a name="getexternalcontactscontactnotes"></a>

## [**NoteListing**](NoteListing.html) GetExternalcontactsContactNotes (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)



List notes for an external contact



Requires ANY permissions: 

* externalContacts:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsContactNotesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var pageSize = 56;  // int? | Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

            try
            { 
                // List notes for an external contact
                NoteListing result = apiInstance.GetExternalcontactsContactNotes(contactId, pageSize, pageNumber, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContactNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact Id |  |
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional]  |
| **expand** | [**List<string>**](string.html)| which fields, if any, to expand | [optional] <br />**Values**: author, externalDataSources |
{: class="table table-striped"}

### Return type

[**NoteListing**](NoteListing.html)

<a name="getexternalcontactscontacts"></a>

## [**ContactListing**](ContactListing.html) GetExternalcontactsContacts (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)



Search for external contacts



Requires ANY permissions: 

* externalContacts:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsContactsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var pageSize = 56;  // int? | Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 1)
            var q = q_example;  // string | User supplied search keywords (no special syntax is currently supported) (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

            try
            { 
                // Search for external contacts
                ContactListing result = apiInstance.GetExternalcontactsContacts(pageSize, pageNumber, q, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 1] |
| **q** | **string**| User supplied search keywords (no special syntax is currently supported) | [optional]  |
| **sortOrder** | **string**| Sort order | [optional]  |
| **expand** | [**List<string>**](string.html)| which fields, if any, to expand | [optional] <br />**Values**: externalOrganization, externalDataSources |
{: class="table table-striped"}

### Return type

[**ContactListing**](ContactListing.html)

<a name="getexternalcontactsorganization"></a>

## [**ExternalOrganization**](ExternalOrganization.html) GetExternalcontactsOrganization (string externalOrganizationId, string expand = null, bool? includeTrustors = null)



Fetch an external organization



Requires ANY permissions: 

* externalContacts:externalOrganization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsOrganizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID
            var expand = expand_example;  // string | which fields, if any, to expand (externalDataSources) (optional) 
            var includeTrustors = true;  // bool? | (true or false) whether or not to include trustor information embedded in the externalOrganization (optional) 

            try
            { 
                // Fetch an external organization
                ExternalOrganization result = apiInstance.GetExternalcontactsOrganization(externalOrganizationId, expand, includeTrustors);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
| **expand** | **string**| which fields, if any, to expand (externalDataSources) | [optional] <br />**Values**: externalDataSources |
| **includeTrustors** | **bool?**| (true or false) whether or not to include trustor information embedded in the externalOrganization | [optional]  |
{: class="table table-striped"}

### Return type

[**ExternalOrganization**](ExternalOrganization.html)

<a name="getexternalcontactsorganizationcontacts"></a>

## [**ContactListing**](ContactListing.html) GetExternalcontactsOrganizationContacts (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)



Search for external contacts in an external organization



Requires ANY permissions: 

* externalContacts:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsOrganizationContactsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID
            var pageSize = 56;  // int? | Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 1)
            var q = q_example;  // string | User supplied search keywords (no special syntax is currently supported) (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

            try
            { 
                // Search for external contacts in an external organization
                ContactListing result = apiInstance.GetExternalcontactsOrganizationContacts(externalOrganizationId, pageSize, pageNumber, q, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsOrganizationContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 1] |
| **q** | **string**| User supplied search keywords (no special syntax is currently supported) | [optional]  |
| **sortOrder** | **string**| Sort order | [optional]  |
| **expand** | [**List<string>**](string.html)| which fields, if any, to expand | [optional] <br />**Values**: externalOrganization, externalDataSources |
{: class="table table-striped"}

### Return type

[**ContactListing**](ContactListing.html)

<a name="getexternalcontactsorganizationnote"></a>

## [**Note**](Note.html) GetExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, List<string> expand = null)



Fetch a note for an external organization



Requires ANY permissions: 

* externalContacts:externalOrganization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsOrganizationNoteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var noteId = noteId_example;  // string | Note Id
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

            try
            { 
                // Fetch a note for an external organization
                Note result = apiInstance.GetExternalcontactsOrganizationNote(externalOrganizationId, noteId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsOrganizationNote: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization Id |  |
| **noteId** | **string**| Note Id |  |
| **expand** | [**List<string>**](string.html)| which fields, if any, to expand | [optional] <br />**Values**: author, externalDataSources |
{: class="table table-striped"}

### Return type

[**Note**](Note.html)

<a name="getexternalcontactsorganizationnotes"></a>

## [**NoteListing**](NoteListing.html) GetExternalcontactsOrganizationNotes (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)



List notes for an external organization



Requires ANY permissions: 

* externalContacts:externalOrganization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsOrganizationNotesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var pageSize = 56;  // int? | Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

            try
            { 
                // List notes for an external organization
                NoteListing result = apiInstance.GetExternalcontactsOrganizationNotes(externalOrganizationId, pageSize, pageNumber, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsOrganizationNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization Id |  |
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional]  |
| **expand** | [**List<string>**](string.html)| which fields, if any, to expand | [optional] <br />**Values**: author, externalDataSources |
{: class="table table-striped"}

### Return type

[**NoteListing**](NoteListing.html)

<a name="getexternalcontactsorganizationrelationships"></a>

## [**RelationshipListing**](RelationshipListing.html) GetExternalcontactsOrganizationRelationships (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string expand = null, string sortOrder = null)



Fetch a relationship for an external organization



Requires ANY permissions: 

* externalContacts:externalOrganization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsOrganizationRelationshipsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID
            var pageSize = 56;  // int? | Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 1)
            var expand = expand_example;  // string | which fields, if any, to expand (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 

            try
            { 
                // Fetch a relationship for an external organization
                RelationshipListing result = apiInstance.GetExternalcontactsOrganizationRelationships(externalOrganizationId, pageSize, pageNumber, expand, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsOrganizationRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 1] |
| **expand** | **string**| which fields, if any, to expand | [optional] <br />**Values**: externalDataSources |
| **sortOrder** | **string**| Sort order | [optional]  |
{: class="table table-striped"}

### Return type

[**RelationshipListing**](RelationshipListing.html)

<a name="getexternalcontactsorganizations"></a>

## [**ExternalOrganizationListing**](ExternalOrganizationListing.html) GetExternalcontactsOrganizations (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null)



Search for external organizations



Requires ANY permissions: 

* externalContacts:externalOrganization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsOrganizationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var pageSize = 56;  // int? | Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be <= 1,000) (optional)  (default to 1)
            var q = q_example;  // string | Search query (optional) 
            var trustorId = new List<string>(); // List<string> | Search for external organizations by trustorIds (limit 25). If supplied, the 'q' parameters is ignored. Items are returned in the order requested (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 
            var includeTrustors = true;  // bool? | (true or false) whether or not to include trustor information embedded in the externalOrganization (optional) 

            try
            { 
                // Search for external organizations
                ExternalOrganizationListing result = apiInstance.GetExternalcontactsOrganizations(pageSize, pageNumber, q, trustorId, sortOrder, expand, includeTrustors);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsOrganizations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;= 1,000) | [optional] [default to 1] |
| **q** | **string**| Search query | [optional]  |
| **trustorId** | [**List<string>**](string.html)| Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested | [optional]  |
| **sortOrder** | **string**| Sort order | [optional]  |
| **expand** | [**List<string>**](string.html)| which fields, if any, to expand | [optional] <br />**Values**: externalDataSources |
| **includeTrustors** | **bool?**| (true or false) whether or not to include trustor information embedded in the externalOrganization | [optional]  |
{: class="table table-striped"}

### Return type

[**ExternalOrganizationListing**](ExternalOrganizationListing.html)

<a name="getexternalcontactsrelationship"></a>

## [**Relationship**](Relationship.html) GetExternalcontactsRelationship (string relationshipId, string expand = null)



Fetch a relationship



Requires ANY permissions: 

* externalContacts:externalOrganization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsRelationshipExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var relationshipId = relationshipId_example;  // string | Relationship Id
            var expand = expand_example;  // string | which fields, if any, to expand (optional) 

            try
            { 
                // Fetch a relationship
                Relationship result = apiInstance.GetExternalcontactsRelationship(relationshipId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **relationshipId** | **string**| Relationship Id |  |
| **expand** | **string**| which fields, if any, to expand | [optional] <br />**Values**: externalDataSources |
{: class="table table-striped"}

### Return type

[**Relationship**](Relationship.html)

<a name="getexternalcontactsreversewhitepageslookup"></a>

## [**ReverseWhitepagesLookupResult**](ReverseWhitepagesLookupResult.html) GetExternalcontactsReversewhitepageslookup (string lookupVal, List<string> expand = null)



Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned.



Requires ANY permissions: 

* externalContacts:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsReversewhitepageslookupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var lookupVal = lookupVal_example;  // string | User supplied value to lookup contacts/externalOrganizations (supports email addresses, e164 phone numbers, Twitter screen names)
            var expand = new List<string>(); // List<string> | which field, if any, to expand (optional) 

            try
            { 
                // Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned.
                ReverseWhitepagesLookupResult result = apiInstance.GetExternalcontactsReversewhitepageslookup(lookupVal, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsReversewhitepageslookup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lookupVal** | **string**| User supplied value to lookup contacts/externalOrganizations (supports email addresses, e164 phone numbers, Twitter screen names) |  |
| **expand** | [**List<string>**](string.html)| which field, if any, to expand | [optional] <br />**Values**: contacts.externalOrganization, externalDataSources |
{: class="table table-striped"}

### Return type

[**ReverseWhitepagesLookupResult**](ReverseWhitepagesLookupResult.html)

<a name="postexternalcontactscontactnotes"></a>

## [**Note**](Note.html) PostExternalcontactsContactNotes (string contactId, Note body)



Create a note for an external contact



Requires ANY permissions: 

* externalContacts:contact:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsContactNotesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var body = new Note(); // Note | ExternalContact

            try
            { 
                // Create a note for an external contact
                Note result = apiInstance.PostExternalcontactsContactNotes(contactId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsContactNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact Id |  |
| **body** | [**Note**](Note.html)| ExternalContact |  |
{: class="table table-striped"}

### Return type

[**Note**](Note.html)

<a name="postexternalcontactscontacts"></a>

## [**ExternalContact**](ExternalContact.html) PostExternalcontactsContacts (ExternalContact body)



Create an external contact



Requires ANY permissions: 

* externalContacts:contact:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsContactsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var body = new ExternalContact(); // ExternalContact | ExternalContact

            try
            { 
                // Create an external contact
                ExternalContact result = apiInstance.PostExternalcontactsContacts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExternalContact**](ExternalContact.html)| ExternalContact |  |
{: class="table table-striped"}

### Return type

[**ExternalContact**](ExternalContact.html)

<a name="postexternalcontactsorganizationnotes"></a>

## [**Note**](Note.html) PostExternalcontactsOrganizationNotes (string externalOrganizationId, Note body)



Create a note for an external organization



Requires ANY permissions: 

* externalContacts:externalOrganization:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsOrganizationNotesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var body = new Note(); // Note | ExternalContact

            try
            { 
                // Create a note for an external organization
                Note result = apiInstance.PostExternalcontactsOrganizationNotes(externalOrganizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsOrganizationNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization Id |  |
| **body** | [**Note**](Note.html)| ExternalContact |  |
{: class="table table-striped"}

### Return type

[**Note**](Note.html)

<a name="postexternalcontactsorganizations"></a>

## [**ExternalOrganization**](ExternalOrganization.html) PostExternalcontactsOrganizations (ExternalOrganization body)



Create an external organization



Requires ANY permissions: 

* externalContacts:externalOrganization:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsOrganizationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var body = new ExternalOrganization(); // ExternalOrganization | ExternalOrganization

            try
            { 
                // Create an external organization
                ExternalOrganization result = apiInstance.PostExternalcontactsOrganizations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsOrganizations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExternalOrganization**](ExternalOrganization.html)| ExternalOrganization |  |
{: class="table table-striped"}

### Return type

[**ExternalOrganization**](ExternalOrganization.html)

<a name="postexternalcontactsrelationships"></a>

## [**Relationship**](Relationship.html) PostExternalcontactsRelationships (Relationship body)



Create a relationship



Requires ANY permissions: 

* externalContacts:externalOrganization:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsRelationshipsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var body = new Relationship(); // Relationship | Relationship

            try
            { 
                // Create a relationship
                Relationship result = apiInstance.PostExternalcontactsRelationships(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Relationship**](Relationship.html)| Relationship |  |
{: class="table table-striped"}

### Return type

[**Relationship**](Relationship.html)

<a name="putexternalcontactscontact"></a>

## [**ExternalContact**](ExternalContact.html) PutExternalcontactsContact (string contactId, ExternalContact body)



Update an external contact



Requires ANY permissions: 

* externalContacts:contact:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsContactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact ID
            var body = new ExternalContact(); // ExternalContact | ExternalContact

            try
            { 
                // Update an external contact
                ExternalContact result = apiInstance.PutExternalcontactsContact(contactId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsContact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |
| **body** | [**ExternalContact**](ExternalContact.html)| ExternalContact |  |
{: class="table table-striped"}

### Return type

[**ExternalContact**](ExternalContact.html)

<a name="putexternalcontactscontactnote"></a>

## [**Note**](Note.html) PutExternalcontactsContactNote (string contactId, string noteId, Note body)



Update a note for an external contact



Requires ANY permissions: 

* externalContacts:contact:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsContactNoteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var noteId = noteId_example;  // string | Note Id
            var body = new Note(); // Note | Note

            try
            { 
                // Update a note for an external contact
                Note result = apiInstance.PutExternalcontactsContactNote(contactId, noteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsContactNote: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact Id |  |
| **noteId** | **string**| Note Id |  |
| **body** | [**Note**](Note.html)| Note |  |
{: class="table table-striped"}

### Return type

[**Note**](Note.html)

<a name="putexternalcontactsconversation"></a>

## void PutExternalcontactsConversation (string conversationId, ConversationAssociation body)



Associate an external contact with a conversation



Requires ANY permissions: 

* externalContacts:conversation:associate

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var body = new ConversationAssociation(); // ConversationAssociation | ConversationAssociation

            try
            { 
                // Associate an external contact with a conversation
                apiInstance.PutExternalcontactsConversation(conversationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **body** | [**ConversationAssociation**](ConversationAssociation.html)| ConversationAssociation |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putexternalcontactsorganization"></a>

## [**ExternalOrganization**](ExternalOrganization.html) PutExternalcontactsOrganization (string externalOrganizationId, ExternalOrganization body)



Update an external organization



Requires ANY permissions: 

* externalContacts:externalOrganization:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsOrganizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID
            var body = new ExternalOrganization(); // ExternalOrganization | ExternalOrganization

            try
            { 
                // Update an external organization
                ExternalOrganization result = apiInstance.PutExternalcontactsOrganization(externalOrganizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
| **body** | [**ExternalOrganization**](ExternalOrganization.html)| ExternalOrganization |  |
{: class="table table-striped"}

### Return type

[**ExternalOrganization**](ExternalOrganization.html)

<a name="putexternalcontactsorganizationnote"></a>

## [**Note**](Note.html) PutExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, Note body)



Update a note for an external organization



Requires ANY permissions: 

* externalContacts:externalOrganization:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsOrganizationNoteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var noteId = noteId_example;  // string | Note Id
            var body = new Note(); // Note | Note

            try
            { 
                // Update a note for an external organization
                Note result = apiInstance.PutExternalcontactsOrganizationNote(externalOrganizationId, noteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsOrganizationNote: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization Id |  |
| **noteId** | **string**| Note Id |  |
| **body** | [**Note**](Note.html)| Note |  |
{: class="table table-striped"}

### Return type

[**Note**](Note.html)

<a name="putexternalcontactsorganizationtrustortrustorid"></a>

## [**ExternalOrganization**](ExternalOrganization.html) PutExternalcontactsOrganizationTrustorTrustorId (string externalOrganizationId, string trustorId)



Links a Trustor with an External Organization



Requires ANY permissions: 

* externalContacts:externalOrganization:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsOrganizationTrustorTrustorIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID
            var trustorId = trustorId_example;  // string | Trustor ID

            try
            { 
                // Links a Trustor with an External Organization
                ExternalOrganization result = apiInstance.PutExternalcontactsOrganizationTrustorTrustorId(externalOrganizationId, trustorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsOrganizationTrustorTrustorId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
| **trustorId** | **string**| Trustor ID |  |
{: class="table table-striped"}

### Return type

[**ExternalOrganization**](ExternalOrganization.html)

<a name="putexternalcontactsrelationship"></a>

## [**Relationship**](Relationship.html) PutExternalcontactsRelationship (string relationshipId, Relationship body)



Update a relationship



Requires ANY permissions: 

* externalContacts:externalOrganization:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsRelationshipExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi();
            var relationshipId = relationshipId_example;  // string | Relationship Id
            var body = new Relationship(); // Relationship | Relationship

            try
            { 
                // Update a relationship
                Relationship result = apiInstance.PutExternalcontactsRelationship(relationshipId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **relationshipId** | **string**| Relationship Id |  |
| **body** | [**Relationship**](Relationship.html)| Relationship |  |
{: class="table table-striped"}

### Return type

[**Relationship**](Relationship.html)

