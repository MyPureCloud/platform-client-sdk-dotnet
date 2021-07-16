---
title: ExternalContactsApi
---
## PureCloudPlatform.Client.V2.Api.ExternalContactsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteExternalcontactsContact**](ExternalContactsApi.html#deleteexternalcontactscontact) | **DELETE** /api/v2/externalcontacts/contacts/{contactId} | Delete an external contact |
| [**DeleteExternalcontactsContactNote**](ExternalContactsApi.html#deleteexternalcontactscontactnote) | **DELETE** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Delete a note for an external contact |
| [**DeleteExternalcontactsContactsSchema**](ExternalContactsApi.html#deleteexternalcontactscontactsschema) | **DELETE** /api/v2/externalcontacts/contacts/schemas/{schemaId} | Delete a schema |
| [**DeleteExternalcontactsOrganization**](ExternalContactsApi.html#deleteexternalcontactsorganization) | **DELETE** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Delete an external organization |
| [**DeleteExternalcontactsOrganizationNote**](ExternalContactsApi.html#deleteexternalcontactsorganizationnote) | **DELETE** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Delete a note for an external organization |
| [**DeleteExternalcontactsOrganizationTrustor**](ExternalContactsApi.html#deleteexternalcontactsorganizationtrustor) | **DELETE** /api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor | Unlink the Trustor for this External Organization |
| [**DeleteExternalcontactsRelationship**](ExternalContactsApi.html#deleteexternalcontactsrelationship) | **DELETE** /api/v2/externalcontacts/relationships/{relationshipId} | Delete a relationship |
| [**GetExternalcontactsContact**](ExternalContactsApi.html#getexternalcontactscontact) | **GET** /api/v2/externalcontacts/contacts/{contactId} | Fetch an external contact |
| [**GetExternalcontactsContactNote**](ExternalContactsApi.html#getexternalcontactscontactnote) | **GET** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Fetch a note for an external contact |
| [**GetExternalcontactsContactNotes**](ExternalContactsApi.html#getexternalcontactscontactnotes) | **GET** /api/v2/externalcontacts/contacts/{contactId}/notes | List notes for an external contact |
| [**GetExternalcontactsContacts**](ExternalContactsApi.html#getexternalcontactscontacts) | **GET** /api/v2/externalcontacts/contacts | Search for external contacts |
| [**GetExternalcontactsContactsSchema**](ExternalContactsApi.html#getexternalcontactscontactsschema) | **GET** /api/v2/externalcontacts/contacts/schemas/{schemaId} | Get a schema |
| [**GetExternalcontactsContactsSchemaVersion**](ExternalContactsApi.html#getexternalcontactscontactsschemaversion) | **GET** /api/v2/externalcontacts/contacts/schemas/{schemaId}/versions/{versionId} | Get a specific version of a schema |
| [**GetExternalcontactsContactsSchemaVersions**](ExternalContactsApi.html#getexternalcontactscontactsschemaversions) | **GET** /api/v2/externalcontacts/contacts/schemas/{schemaId}/versions | Get all versions of an external contact&#39;s schema |
| [**GetExternalcontactsContactsSchemas**](ExternalContactsApi.html#getexternalcontactscontactsschemas) | **GET** /api/v2/externalcontacts/contacts/schemas | Get a list of schemas. |
| [**GetExternalcontactsOrganization**](ExternalContactsApi.html#getexternalcontactsorganization) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Fetch an external organization |
| [**GetExternalcontactsOrganizationContacts**](ExternalContactsApi.html#getexternalcontactsorganizationcontacts) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/contacts | Search for external contacts in an external organization |
| [**GetExternalcontactsOrganizationNote**](ExternalContactsApi.html#getexternalcontactsorganizationnote) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Fetch a note for an external organization |
| [**GetExternalcontactsOrganizationNotes**](ExternalContactsApi.html#getexternalcontactsorganizationnotes) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes | List notes for an external organization |
| [**GetExternalcontactsOrganizationRelationships**](ExternalContactsApi.html#getexternalcontactsorganizationrelationships) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/relationships | Fetch a relationship for an external organization |
| [**GetExternalcontactsOrganizations**](ExternalContactsApi.html#getexternalcontactsorganizations) | **GET** /api/v2/externalcontacts/organizations | Search for external organizations |
| [**GetExternalcontactsOrganizationsSchema**](ExternalContactsApi.html#getexternalcontactsorganizationsschema) | **GET** /api/v2/externalcontacts/organizations/schemas/{schemaId} | Get a schema |
| [**GetExternalcontactsOrganizationsSchemaVersion**](ExternalContactsApi.html#getexternalcontactsorganizationsschemaversion) | **GET** /api/v2/externalcontacts/organizations/schemas/{schemaId}/versions/{versionId} | Get a specific version of a schema |
| [**GetExternalcontactsOrganizationsSchemaVersions**](ExternalContactsApi.html#getexternalcontactsorganizationsschemaversions) | **GET** /api/v2/externalcontacts/organizations/schemas/{schemaId}/versions | Get all versions of an external organization&#39;s schema |
| [**GetExternalcontactsOrganizationsSchemas**](ExternalContactsApi.html#getexternalcontactsorganizationsschemas) | **GET** /api/v2/externalcontacts/organizations/schemas | Get a list of schemas. |
| [**GetExternalcontactsRelationship**](ExternalContactsApi.html#getexternalcontactsrelationship) | **GET** /api/v2/externalcontacts/relationships/{relationshipId} | Fetch a relationship |
| [**GetExternalcontactsReversewhitepageslookup**](ExternalContactsApi.html#getexternalcontactsreversewhitepageslookup) | **GET** /api/v2/externalcontacts/reversewhitepageslookup | Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned. |
| [**GetExternalcontactsScanContacts**](ExternalContactsApi.html#getexternalcontactsscancontacts) | **GET** /api/v2/externalcontacts/scan/contacts | Scan for external contacts using paging |
| [**GetExternalcontactsScanNotes**](ExternalContactsApi.html#getexternalcontactsscannotes) | **GET** /api/v2/externalcontacts/scan/notes | Scan for notes using paging |
| [**GetExternalcontactsScanOrganizations**](ExternalContactsApi.html#getexternalcontactsscanorganizations) | **GET** /api/v2/externalcontacts/scan/organizations | Scan for external organizations using paging |
| [**GetExternalcontactsScanRelationships**](ExternalContactsApi.html#getexternalcontactsscanrelationships) | **GET** /api/v2/externalcontacts/scan/relationships | Scan for relationships |
| [**PostExternalcontactsBulkContacts**](ExternalContactsApi.html#postexternalcontactsbulkcontacts) | **POST** /api/v2/externalcontacts/bulk/contacts | Bulk fetch contacts |
| [**PostExternalcontactsBulkContactsAdd**](ExternalContactsApi.html#postexternalcontactsbulkcontactsadd) | **POST** /api/v2/externalcontacts/bulk/contacts/add | Bulk add contacts |
| [**PostExternalcontactsBulkContactsRemove**](ExternalContactsApi.html#postexternalcontactsbulkcontactsremove) | **POST** /api/v2/externalcontacts/bulk/contacts/remove | Bulk remove contacts |
| [**PostExternalcontactsBulkContactsUpdate**](ExternalContactsApi.html#postexternalcontactsbulkcontactsupdate) | **POST** /api/v2/externalcontacts/bulk/contacts/update | Bulk update contacts |
| [**PostExternalcontactsBulkNotes**](ExternalContactsApi.html#postexternalcontactsbulknotes) | **POST** /api/v2/externalcontacts/bulk/notes | Bulk fetch notes |
| [**PostExternalcontactsBulkNotesAdd**](ExternalContactsApi.html#postexternalcontactsbulknotesadd) | **POST** /api/v2/externalcontacts/bulk/notes/add | Bulk add notes |
| [**PostExternalcontactsBulkNotesRemove**](ExternalContactsApi.html#postexternalcontactsbulknotesremove) | **POST** /api/v2/externalcontacts/bulk/notes/remove | Bulk remove notes |
| [**PostExternalcontactsBulkNotesUpdate**](ExternalContactsApi.html#postexternalcontactsbulknotesupdate) | **POST** /api/v2/externalcontacts/bulk/notes/update | Bulk update notes |
| [**PostExternalcontactsBulkOrganizations**](ExternalContactsApi.html#postexternalcontactsbulkorganizations) | **POST** /api/v2/externalcontacts/bulk/organizations | Bulk fetch organizations |
| [**PostExternalcontactsBulkOrganizationsAdd**](ExternalContactsApi.html#postexternalcontactsbulkorganizationsadd) | **POST** /api/v2/externalcontacts/bulk/organizations/add | Bulk add organizations |
| [**PostExternalcontactsBulkOrganizationsRemove**](ExternalContactsApi.html#postexternalcontactsbulkorganizationsremove) | **POST** /api/v2/externalcontacts/bulk/organizations/remove | Bulk remove organizations |
| [**PostExternalcontactsBulkOrganizationsUpdate**](ExternalContactsApi.html#postexternalcontactsbulkorganizationsupdate) | **POST** /api/v2/externalcontacts/bulk/organizations/update | Bulk update organizations |
| [**PostExternalcontactsBulkRelationships**](ExternalContactsApi.html#postexternalcontactsbulkrelationships) | **POST** /api/v2/externalcontacts/bulk/relationships | Bulk fetch relationships |
| [**PostExternalcontactsBulkRelationshipsAdd**](ExternalContactsApi.html#postexternalcontactsbulkrelationshipsadd) | **POST** /api/v2/externalcontacts/bulk/relationships/add | Bulk add relationships |
| [**PostExternalcontactsBulkRelationshipsRemove**](ExternalContactsApi.html#postexternalcontactsbulkrelationshipsremove) | **POST** /api/v2/externalcontacts/bulk/relationships/remove | Bulk remove relationships |
| [**PostExternalcontactsBulkRelationshipsUpdate**](ExternalContactsApi.html#postexternalcontactsbulkrelationshipsupdate) | **POST** /api/v2/externalcontacts/bulk/relationships/update | Bulk update relationships |
| [**PostExternalcontactsContactNotes**](ExternalContactsApi.html#postexternalcontactscontactnotes) | **POST** /api/v2/externalcontacts/contacts/{contactId}/notes | Create a note for an external contact |
| [**PostExternalcontactsContacts**](ExternalContactsApi.html#postexternalcontactscontacts) | **POST** /api/v2/externalcontacts/contacts | Create an external contact |
| [**PostExternalcontactsContactsSchemas**](ExternalContactsApi.html#postexternalcontactscontactsschemas) | **POST** /api/v2/externalcontacts/contacts/schemas | Create a schema |
| [**PostExternalcontactsOrganizationNotes**](ExternalContactsApi.html#postexternalcontactsorganizationnotes) | **POST** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes | Create a note for an external organization |
| [**PostExternalcontactsOrganizations**](ExternalContactsApi.html#postexternalcontactsorganizations) | **POST** /api/v2/externalcontacts/organizations | Create an external organization |
| [**PostExternalcontactsOrganizationsSchemas**](ExternalContactsApi.html#postexternalcontactsorganizationsschemas) | **POST** /api/v2/externalcontacts/organizations/schemas | Create a schema |
| [**PostExternalcontactsRelationships**](ExternalContactsApi.html#postexternalcontactsrelationships) | **POST** /api/v2/externalcontacts/relationships | Create a relationship |
| [**PutExternalcontactsContact**](ExternalContactsApi.html#putexternalcontactscontact) | **PUT** /api/v2/externalcontacts/contacts/{contactId} | Update an external contact |
| [**PutExternalcontactsContactNote**](ExternalContactsApi.html#putexternalcontactscontactnote) | **PUT** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Update a note for an external contact |
| [**PutExternalcontactsContactsSchema**](ExternalContactsApi.html#putexternalcontactscontactsschema) | **PUT** /api/v2/externalcontacts/contacts/schemas/{schemaId} | Update a schema |
| [**PutExternalcontactsConversation**](ExternalContactsApi.html#putexternalcontactsconversation) | **PUT** /api/v2/externalcontacts/conversations/{conversationId} | Associate/disassociate an external contact with a conversation |
| [**PutExternalcontactsOrganization**](ExternalContactsApi.html#putexternalcontactsorganization) | **PUT** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Update an external organization |
| [**PutExternalcontactsOrganizationNote**](ExternalContactsApi.html#putexternalcontactsorganizationnote) | **PUT** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Update a note for an external organization |
| [**PutExternalcontactsOrganizationTrustorTrustorId**](ExternalContactsApi.html#putexternalcontactsorganizationtrustortrustorid) | **PUT** /api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor/{trustorId} | Links a Trustor with an External Organization |
| [**PutExternalcontactsOrganizationsSchema**](ExternalContactsApi.html#putexternalcontactsorganizationsschema) | **PUT** /api/v2/externalcontacts/organizations/schemas/{schemaId} | Update a schema |
| [**PutExternalcontactsRelationship**](ExternalContactsApi.html#putexternalcontactsrelationship) | **PUT** /api/v2/externalcontacts/relationships/{relationshipId} | Update a relationship |
{: class="table table-striped"}

<a name="deleteexternalcontactscontact"></a>

## [**Empty**](Empty.html) DeleteExternalcontactsContact (string contactId)



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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact ID

            try
            { 
                // Delete an external contact
                Empty result = apiInstance.DeleteExternalcontactsContact(contactId);
                Debug.WriteLine(result);
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

[**Empty**](Empty.html)

<a name="deleteexternalcontactscontactnote"></a>

## [**Empty**](Empty.html) DeleteExternalcontactsContactNote (string contactId, string noteId)



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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var noteId = noteId_example;  // string | Note Id

            try
            { 
                // Delete a note for an external contact
                Empty result = apiInstance.DeleteExternalcontactsContactNote(contactId, noteId);
                Debug.WriteLine(result);
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

[**Empty**](Empty.html)

<a name="deleteexternalcontactscontactsschema"></a>

## void DeleteExternalcontactsContactsSchema (string schemaId)



Delete a schema



Requires ANY permissions: 

* externalContacts:customFields:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsContactsSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var schemaId = schemaId_example;  // string | Schema ID

            try
            { 
                // Delete a schema
                apiInstance.DeleteExternalcontactsContactsSchema(schemaId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteExternalcontactsContactsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteexternalcontactsorganization"></a>

## [**Empty**](Empty.html) DeleteExternalcontactsOrganization (string externalOrganizationId)



Delete an external organization



Requires ANY permissions: 

* relate:externalOrganization:delete
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID

            try
            { 
                // Delete an external organization
                Empty result = apiInstance.DeleteExternalcontactsOrganization(externalOrganizationId);
                Debug.WriteLine(result);
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

[**Empty**](Empty.html)

<a name="deleteexternalcontactsorganizationnote"></a>

## [**Empty**](Empty.html) DeleteExternalcontactsOrganizationNote (string externalOrganizationId, string noteId)



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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var noteId = noteId_example;  // string | Note Id

            try
            { 
                // Delete a note for an external organization
                Empty result = apiInstance.DeleteExternalcontactsOrganizationNote(externalOrganizationId, noteId);
                Debug.WriteLine(result);
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

[**Empty**](Empty.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

## [**Empty**](Empty.html) DeleteExternalcontactsRelationship (string relationshipId)



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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var relationshipId = relationshipId_example;  // string | Relationship Id

            try
            { 
                // Delete a relationship
                Empty result = apiInstance.DeleteExternalcontactsRelationship(relationshipId);
                Debug.WriteLine(result);
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

[**Empty**](Empty.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="getexternalcontactscontactsschema"></a>

## [**DataSchema**](DataSchema.html) GetExternalcontactsContactsSchema (string schemaId)



Get a schema



Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsContactsSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var schemaId = schemaId_example;  // string | Schema ID

            try
            { 
                // Get a schema
                DataSchema result = apiInstance.GetExternalcontactsContactsSchema(schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContactsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="getexternalcontactscontactsschemaversion"></a>

## [**DataSchema**](DataSchema.html) GetExternalcontactsContactsSchemaVersion (string schemaId, string versionId)



Get a specific version of a schema



Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsContactsSchemaVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var schemaId = schemaId_example;  // string | Schema ID
            var versionId = versionId_example;  // string | Schema version

            try
            { 
                // Get a specific version of a schema
                DataSchema result = apiInstance.GetExternalcontactsContactsSchemaVersion(schemaId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContactsSchemaVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
| **versionId** | **string**| Schema version |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="getexternalcontactscontactsschemaversions"></a>

## [**DataSchema**](DataSchema.html) GetExternalcontactsContactsSchemaVersions (string schemaId)



Get all versions of an external contact's schema



Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsContactsSchemaVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var schemaId = schemaId_example;  // string | Schema ID

            try
            { 
                // Get all versions of an external contact's schema
                DataSchema result = apiInstance.GetExternalcontactsContactsSchemaVersions(schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContactsSchemaVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="getexternalcontactscontactsschemas"></a>

## [**DataSchemaListing**](DataSchemaListing.html) GetExternalcontactsContactsSchemas ()



Get a list of schemas.



Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsContactsSchemasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();

            try
            { 
                // Get a list of schemas.
                DataSchemaListing result = apiInstance.GetExternalcontactsContactsSchemas();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContactsSchemas: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**DataSchemaListing**](DataSchemaListing.html)

<a name="getexternalcontactsorganization"></a>

## [**ExternalOrganization**](ExternalOrganization.html) GetExternalcontactsOrganization (string externalOrganizationId, string expand = null, bool? includeTrustors = null)



Fetch an external organization



Requires ANY permissions: 

* relate:externalOrganization:view
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

* relate:externalOrganization:view
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

* relate:externalOrganization:view
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

* relate:externalOrganization:view
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="getexternalcontactsorganizationsschema"></a>

## [**DataSchema**](DataSchema.html) GetExternalcontactsOrganizationsSchema (string schemaId)



Get a schema



Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsOrganizationsSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var schemaId = schemaId_example;  // string | Schema ID

            try
            { 
                // Get a schema
                DataSchema result = apiInstance.GetExternalcontactsOrganizationsSchema(schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsOrganizationsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="getexternalcontactsorganizationsschemaversion"></a>

## [**DataSchema**](DataSchema.html) GetExternalcontactsOrganizationsSchemaVersion (string schemaId, string versionId)



Get a specific version of a schema



Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsOrganizationsSchemaVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var schemaId = schemaId_example;  // string | Schema ID
            var versionId = versionId_example;  // string | Schema version

            try
            { 
                // Get a specific version of a schema
                DataSchema result = apiInstance.GetExternalcontactsOrganizationsSchemaVersion(schemaId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsOrganizationsSchemaVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
| **versionId** | **string**| Schema version |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="getexternalcontactsorganizationsschemaversions"></a>

## [**DataSchema**](DataSchema.html) GetExternalcontactsOrganizationsSchemaVersions (string schemaId)



Get all versions of an external organization's schema



Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsOrganizationsSchemaVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var schemaId = schemaId_example;  // string | Schema ID

            try
            { 
                // Get all versions of an external organization's schema
                DataSchema result = apiInstance.GetExternalcontactsOrganizationsSchemaVersions(schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsOrganizationsSchemaVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="getexternalcontactsorganizationsschemas"></a>

## [**DataSchemaListing**](DataSchemaListing.html) GetExternalcontactsOrganizationsSchemas ()



Get a list of schemas.



Requires ANY permissions: 

* externalContacts:customFields:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsOrganizationsSchemasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();

            try
            { 
                // Get a list of schemas.
                DataSchemaListing result = apiInstance.GetExternalcontactsOrganizationsSchemas();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsOrganizationsSchemas: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**DataSchemaListing**](DataSchemaListing.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="getexternalcontactsscancontacts"></a>

## [**CursorContactListing**](CursorContactListing.html) GetExternalcontactsScanContacts (int? limit = null, string cursor = null)



Scan for external contacts using paging



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
    public class GetExternalcontactsScanContactsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var limit = 56;  // int? | The number of contacts per page; must be between 10 and 200, default is 100) (optional) 
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional) 

            try
            { 
                // Scan for external contacts using paging
                CursorContactListing result = apiInstance.GetExternalcontactsScanContacts(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsScanContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **limit** | **int?**| The number of contacts per page; must be between 10 and 200, default is 100) | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL | [optional]  |
{: class="table table-striped"}

### Return type

[**CursorContactListing**](CursorContactListing.html)

<a name="getexternalcontactsscannotes"></a>

## [**CursorNoteListing**](CursorNoteListing.html) GetExternalcontactsScanNotes (int? limit = null, string cursor = null)



Scan for notes using paging



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
    public class GetExternalcontactsScanNotesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var limit = 56;  // int? | The number of notes per page; must be between 10 and 200, default is 100) (optional) 
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional) 

            try
            { 
                // Scan for notes using paging
                CursorNoteListing result = apiInstance.GetExternalcontactsScanNotes(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsScanNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **limit** | **int?**| The number of notes per page; must be between 10 and 200, default is 100) | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL | [optional]  |
{: class="table table-striped"}

### Return type

[**CursorNoteListing**](CursorNoteListing.html)

<a name="getexternalcontactsscanorganizations"></a>

## [**CursorOrganizationListing**](CursorOrganizationListing.html) GetExternalcontactsScanOrganizations (int? limit = null, string cursor = null)



Scan for external organizations using paging



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
    public class GetExternalcontactsScanOrganizationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var limit = 56;  // int? | The number of organizations per page; must be between 10 and 200, default is 100) (optional) 
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional) 

            try
            { 
                // Scan for external organizations using paging
                CursorOrganizationListing result = apiInstance.GetExternalcontactsScanOrganizations(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsScanOrganizations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **limit** | **int?**| The number of organizations per page; must be between 10 and 200, default is 100) | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL | [optional]  |
{: class="table table-striped"}

### Return type

[**CursorOrganizationListing**](CursorOrganizationListing.html)

<a name="getexternalcontactsscanrelationships"></a>

## [**CursorRelationshipListing**](CursorRelationshipListing.html) GetExternalcontactsScanRelationships (int? limit = null, string cursor = null)



Scan for relationships



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
    public class GetExternalcontactsScanRelationshipsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var limit = 56;  // int? | The number of relationships per page; must be between 10 and 200, default is 100) (optional) 
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional) 

            try
            { 
                // Scan for relationships
                CursorRelationshipListing result = apiInstance.GetExternalcontactsScanRelationships(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsScanRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **limit** | **int?**| The number of relationships per page; must be between 10 and 200, default is 100) | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL | [optional]  |
{: class="table table-striped"}

### Return type

[**CursorRelationshipListing**](CursorRelationshipListing.html)

<a name="postexternalcontactsbulkcontacts"></a>

## [**BulkFetchContactsResponse**](BulkFetchContactsResponse.html) PostExternalcontactsBulkContacts (BulkIdsRequest body)



Bulk fetch contacts



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
    public class PostExternalcontactsBulkContactsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkIdsRequest(); // BulkIdsRequest | Contact ids

            try
            { 
                // Bulk fetch contacts
                BulkFetchContactsResponse result = apiInstance.PostExternalcontactsBulkContacts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkIdsRequest**](BulkIdsRequest.html)| Contact ids |  |
{: class="table table-striped"}

### Return type

[**BulkFetchContactsResponse**](BulkFetchContactsResponse.html)

<a name="postexternalcontactsbulkcontactsadd"></a>

## [**BulkContactsResponse**](BulkContactsResponse.html) PostExternalcontactsBulkContactsAdd (BulkContactsRequest body)



Bulk add contacts



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
    public class PostExternalcontactsBulkContactsAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkContactsRequest(); // BulkContactsRequest | Contacts

            try
            { 
                // Bulk add contacts
                BulkContactsResponse result = apiInstance.PostExternalcontactsBulkContactsAdd(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkContactsAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkContactsRequest**](BulkContactsRequest.html)| Contacts |  |
{: class="table table-striped"}

### Return type

[**BulkContactsResponse**](BulkContactsResponse.html)

<a name="postexternalcontactsbulkcontactsremove"></a>

## [**BulkDeleteResponse**](BulkDeleteResponse.html) PostExternalcontactsBulkContactsRemove (BulkIdsRequest body)



Bulk remove contacts



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
    public class PostExternalcontactsBulkContactsRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkIdsRequest(); // BulkIdsRequest | Contact ids

            try
            { 
                // Bulk remove contacts
                BulkDeleteResponse result = apiInstance.PostExternalcontactsBulkContactsRemove(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkContactsRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkIdsRequest**](BulkIdsRequest.html)| Contact ids |  |
{: class="table table-striped"}

### Return type

[**BulkDeleteResponse**](BulkDeleteResponse.html)

<a name="postexternalcontactsbulkcontactsupdate"></a>

## [**BulkContactsResponse**](BulkContactsResponse.html) PostExternalcontactsBulkContactsUpdate (BulkContactsRequest body)



Bulk update contacts



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
    public class PostExternalcontactsBulkContactsUpdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkContactsRequest(); // BulkContactsRequest | Contacts

            try
            { 
                // Bulk update contacts
                BulkContactsResponse result = apiInstance.PostExternalcontactsBulkContactsUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkContactsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkContactsRequest**](BulkContactsRequest.html)| Contacts |  |
{: class="table table-striped"}

### Return type

[**BulkContactsResponse**](BulkContactsResponse.html)

<a name="postexternalcontactsbulknotes"></a>

## [**BulkFetchNotesResponse**](BulkFetchNotesResponse.html) PostExternalcontactsBulkNotes (BulkIdsRequest body)



Bulk fetch notes



Requires ALL permissions: 

* externalContacts:contact:view
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
    public class PostExternalcontactsBulkNotesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkIdsRequest(); // BulkIdsRequest | Note ids

            try
            { 
                // Bulk fetch notes
                BulkFetchNotesResponse result = apiInstance.PostExternalcontactsBulkNotes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkIdsRequest**](BulkIdsRequest.html)| Note ids |  |
{: class="table table-striped"}

### Return type

[**BulkFetchNotesResponse**](BulkFetchNotesResponse.html)

<a name="postexternalcontactsbulknotesadd"></a>

## [**BulkNotesResponse**](BulkNotesResponse.html) PostExternalcontactsBulkNotesAdd (BulkNotesRequest body)



Bulk add notes



Requires ALL permissions: 

* externalContacts:contact:add
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
    public class PostExternalcontactsBulkNotesAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkNotesRequest(); // BulkNotesRequest | Notes

            try
            { 
                // Bulk add notes
                BulkNotesResponse result = apiInstance.PostExternalcontactsBulkNotesAdd(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkNotesAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkNotesRequest**](BulkNotesRequest.html)| Notes |  |
{: class="table table-striped"}

### Return type

[**BulkNotesResponse**](BulkNotesResponse.html)

<a name="postexternalcontactsbulknotesremove"></a>

## [**BulkDeleteResponse**](BulkDeleteResponse.html) PostExternalcontactsBulkNotesRemove (BulkIdsRequest body)



Bulk remove notes



Requires ALL permissions: 

* externalContacts:contact:delete
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
    public class PostExternalcontactsBulkNotesRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkIdsRequest(); // BulkIdsRequest | Note ids

            try
            { 
                // Bulk remove notes
                BulkDeleteResponse result = apiInstance.PostExternalcontactsBulkNotesRemove(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkNotesRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkIdsRequest**](BulkIdsRequest.html)| Note ids |  |
{: class="table table-striped"}

### Return type

[**BulkDeleteResponse**](BulkDeleteResponse.html)

<a name="postexternalcontactsbulknotesupdate"></a>

## [**BulkNotesResponse**](BulkNotesResponse.html) PostExternalcontactsBulkNotesUpdate (BulkNotesRequest body)



Bulk update notes



Requires ALL permissions: 

* externalContacts:contact:edit
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
    public class PostExternalcontactsBulkNotesUpdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkNotesRequest(); // BulkNotesRequest | Notes

            try
            { 
                // Bulk update notes
                BulkNotesResponse result = apiInstance.PostExternalcontactsBulkNotesUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkNotesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkNotesRequest**](BulkNotesRequest.html)| Notes |  |
{: class="table table-striped"}

### Return type

[**BulkNotesResponse**](BulkNotesResponse.html)

<a name="postexternalcontactsbulkorganizations"></a>

## [**BulkFetchOrganizationsResponse**](BulkFetchOrganizationsResponse.html) PostExternalcontactsBulkOrganizations (BulkIdsRequest body)



Bulk fetch organizations



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
    public class PostExternalcontactsBulkOrganizationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkIdsRequest(); // BulkIdsRequest | Organizations ids

            try
            { 
                // Bulk fetch organizations
                BulkFetchOrganizationsResponse result = apiInstance.PostExternalcontactsBulkOrganizations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkOrganizations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkIdsRequest**](BulkIdsRequest.html)| Organizations ids |  |
{: class="table table-striped"}

### Return type

[**BulkFetchOrganizationsResponse**](BulkFetchOrganizationsResponse.html)

<a name="postexternalcontactsbulkorganizationsadd"></a>

## [**BulkOrganizationsResponse**](BulkOrganizationsResponse.html) PostExternalcontactsBulkOrganizationsAdd (BulkOrganizationsRequest body)



Bulk add organizations



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
    public class PostExternalcontactsBulkOrganizationsAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkOrganizationsRequest(); // BulkOrganizationsRequest | Organizations

            try
            { 
                // Bulk add organizations
                BulkOrganizationsResponse result = apiInstance.PostExternalcontactsBulkOrganizationsAdd(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkOrganizationsAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkOrganizationsRequest**](BulkOrganizationsRequest.html)| Organizations |  |
{: class="table table-striped"}

### Return type

[**BulkOrganizationsResponse**](BulkOrganizationsResponse.html)

<a name="postexternalcontactsbulkorganizationsremove"></a>

## [**BulkDeleteResponse**](BulkDeleteResponse.html) PostExternalcontactsBulkOrganizationsRemove (BulkIdsRequest body)



Bulk remove organizations



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
    public class PostExternalcontactsBulkOrganizationsRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkIdsRequest(); // BulkIdsRequest | Organization ids

            try
            { 
                // Bulk remove organizations
                BulkDeleteResponse result = apiInstance.PostExternalcontactsBulkOrganizationsRemove(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkOrganizationsRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkIdsRequest**](BulkIdsRequest.html)| Organization ids |  |
{: class="table table-striped"}

### Return type

[**BulkDeleteResponse**](BulkDeleteResponse.html)

<a name="postexternalcontactsbulkorganizationsupdate"></a>

## [**BulkOrganizationsResponse**](BulkOrganizationsResponse.html) PostExternalcontactsBulkOrganizationsUpdate (BulkOrganizationsRequest body)



Bulk update organizations



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
    public class PostExternalcontactsBulkOrganizationsUpdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkOrganizationsRequest(); // BulkOrganizationsRequest | Organizations

            try
            { 
                // Bulk update organizations
                BulkOrganizationsResponse result = apiInstance.PostExternalcontactsBulkOrganizationsUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkOrganizationsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkOrganizationsRequest**](BulkOrganizationsRequest.html)| Organizations |  |
{: class="table table-striped"}

### Return type

[**BulkOrganizationsResponse**](BulkOrganizationsResponse.html)

<a name="postexternalcontactsbulkrelationships"></a>

## [**BulkFetchRelationshipsResponse**](BulkFetchRelationshipsResponse.html) PostExternalcontactsBulkRelationships (BulkIdsRequest body)



Bulk fetch relationships



Requires ALL permissions: 

* externalContacts:contact:view
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
    public class PostExternalcontactsBulkRelationshipsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkIdsRequest(); // BulkIdsRequest | Relationships ids

            try
            { 
                // Bulk fetch relationships
                BulkFetchRelationshipsResponse result = apiInstance.PostExternalcontactsBulkRelationships(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkIdsRequest**](BulkIdsRequest.html)| Relationships ids |  |
{: class="table table-striped"}

### Return type

[**BulkFetchRelationshipsResponse**](BulkFetchRelationshipsResponse.html)

<a name="postexternalcontactsbulkrelationshipsadd"></a>

## [**BulkRelationshipsResponse**](BulkRelationshipsResponse.html) PostExternalcontactsBulkRelationshipsAdd (BulkRelationshipsRequest body)



Bulk add relationships



Requires ALL permissions: 

* externalContacts:contact:add
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
    public class PostExternalcontactsBulkRelationshipsAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkRelationshipsRequest(); // BulkRelationshipsRequest | Relationships

            try
            { 
                // Bulk add relationships
                BulkRelationshipsResponse result = apiInstance.PostExternalcontactsBulkRelationshipsAdd(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkRelationshipsAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkRelationshipsRequest**](BulkRelationshipsRequest.html)| Relationships |  |
{: class="table table-striped"}

### Return type

[**BulkRelationshipsResponse**](BulkRelationshipsResponse.html)

<a name="postexternalcontactsbulkrelationshipsremove"></a>

## [**BulkDeleteResponse**](BulkDeleteResponse.html) PostExternalcontactsBulkRelationshipsRemove (BulkIdsRequest body)



Bulk remove relationships



Requires ALL permissions: 

* externalContacts:contact:delete
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
    public class PostExternalcontactsBulkRelationshipsRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkIdsRequest(); // BulkIdsRequest | Relationships ids

            try
            { 
                // Bulk remove relationships
                BulkDeleteResponse result = apiInstance.PostExternalcontactsBulkRelationshipsRemove(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkRelationshipsRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkIdsRequest**](BulkIdsRequest.html)| Relationships ids |  |
{: class="table table-striped"}

### Return type

[**BulkDeleteResponse**](BulkDeleteResponse.html)

<a name="postexternalcontactsbulkrelationshipsupdate"></a>

## [**BulkRelationshipsResponse**](BulkRelationshipsResponse.html) PostExternalcontactsBulkRelationshipsUpdate (BulkRelationshipsRequest body)



Bulk update relationships



Requires ALL permissions: 

* externalContacts:contact:edit
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
    public class PostExternalcontactsBulkRelationshipsUpdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new BulkRelationshipsRequest(); // BulkRelationshipsRequest | Relationships

            try
            { 
                // Bulk update relationships
                BulkRelationshipsResponse result = apiInstance.PostExternalcontactsBulkRelationshipsUpdate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkRelationshipsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkRelationshipsRequest**](BulkRelationshipsRequest.html)| Relationships |  |
{: class="table table-striped"}

### Return type

[**BulkRelationshipsResponse**](BulkRelationshipsResponse.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="postexternalcontactscontactsschemas"></a>

## [**DataSchema**](DataSchema.html) PostExternalcontactsContactsSchemas (DataSchema body)



Create a schema



Requires ANY permissions: 

* externalContacts:customFields:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsContactsSchemasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new DataSchema(); // DataSchema | Schema

            try
            { 
                // Create a schema
                DataSchema result = apiInstance.PostExternalcontactsContactsSchemas(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsContactsSchemas: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DataSchema**](DataSchema.html)| Schema |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="postexternalcontactsorganizationnotes"></a>

## [**Note**](Note.html) PostExternalcontactsOrganizationNotes (string externalOrganizationId, Note body)



Create a note for an external organization



Requires ANY permissions: 

* relate:externalOrganization:edit
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

* relate:externalOrganization:add
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="postexternalcontactsorganizationsschemas"></a>

## [**DataSchema**](DataSchema.html) PostExternalcontactsOrganizationsSchemas (DataSchema body)



Create a schema



Requires ANY permissions: 

* externalContacts:customFields:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsOrganizationsSchemasExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new DataSchema(); // DataSchema | Schema

            try
            { 
                // Create a schema
                DataSchema result = apiInstance.PostExternalcontactsOrganizationsSchemas(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsOrganizationsSchemas: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DataSchema**](DataSchema.html)| Schema |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

<a name="putexternalcontactscontactsschema"></a>

## [**DataSchema**](DataSchema.html) PutExternalcontactsContactsSchema (string schemaId, DataSchema body)



Update a schema



Requires ANY permissions: 

* externalContacts:customFields:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsContactsSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var schemaId = schemaId_example;  // string | Schema ID
            var body = new DataSchema(); // DataSchema | Data Schema

            try
            { 
                // Update a schema
                DataSchema result = apiInstance.PutExternalcontactsContactsSchema(schemaId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsContactsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
| **body** | [**DataSchema**](DataSchema.html)| Data Schema |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

<a name="putexternalcontactsconversation"></a>

## void PutExternalcontactsConversation (ConversationAssociation body, string conversationId)



Associate/disassociate an external contact with a conversation

To associate, supply a value for the externalContactId.  To disassociate, do not include the property at all.

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var body = new ConversationAssociation(); // ConversationAssociation | ConversationAssociation
            var conversationId = conversationId_example;  // string | Conversation ID

            try
            { 
                // Associate/disassociate an external contact with a conversation
                apiInstance.PutExternalcontactsConversation(body, conversationId);
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
| **body** | [**ConversationAssociation**](ConversationAssociation.html)| ConversationAssociation |  |
| **conversationId** | **string**| Conversation ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putexternalcontactsorganization"></a>

## [**ExternalOrganization**](ExternalOrganization.html) PutExternalcontactsOrganization (string externalOrganizationId, ExternalOrganization body)



Update an external organization



Requires ANY permissions: 

* relate:externalOrganization:edit
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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

## [**ExternalOrganizationTrustorLink**](ExternalOrganizationTrustorLink.html) PutExternalcontactsOrganizationTrustorTrustorId (string externalOrganizationId, string trustorId)



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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID
            var trustorId = trustorId_example;  // string | Trustor ID

            try
            { 
                // Links a Trustor with an External Organization
                ExternalOrganizationTrustorLink result = apiInstance.PutExternalcontactsOrganizationTrustorTrustorId(externalOrganizationId, trustorId);
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

[**ExternalOrganizationTrustorLink**](ExternalOrganizationTrustorLink.html)

<a name="putexternalcontactsorganizationsschema"></a>

## [**DataSchema**](DataSchema.html) PutExternalcontactsOrganizationsSchema (string schemaId, DataSchema body)



Update a schema



Requires ANY permissions: 

* externalContacts:customFields:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsOrganizationsSchemaExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ExternalContactsApi();
            var schemaId = schemaId_example;  // string | Schema ID
            var body = new DataSchema(); // DataSchema | Data Schema

            try
            { 
                // Update a schema
                DataSchema result = apiInstance.PutExternalcontactsOrganizationsSchema(schemaId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsOrganizationsSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaId** | **string**| Schema ID |  |
| **body** | [**DataSchema**](DataSchema.html)| Data Schema |  |
{: class="table table-striped"}

### Return type

[**DataSchema**](DataSchema.html)

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
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

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

