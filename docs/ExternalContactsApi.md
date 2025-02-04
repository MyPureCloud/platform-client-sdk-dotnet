# ExternalContactsApi

## PureCloudPlatform.Client.V2.Api.ExternalContactsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteExternalcontactsContact**](#DeleteExternalcontactsContact) | **Delete** /api/v2/externalcontacts/contacts/{contactId} | Delete an external contact |
| [**DeleteExternalcontactsContactNote**](#DeleteExternalcontactsContactNote) | **Delete** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Delete a note for an external contact |
| [**DeleteExternalcontactsContactsSchema**](#DeleteExternalcontactsContactsSchema) | **Delete** /api/v2/externalcontacts/contacts/schemas/{schemaId} | Delete a schema |
| [**DeleteExternalcontactsExternalsource**](#DeleteExternalcontactsExternalsource) | **Delete** /api/v2/externalcontacts/externalsources/{externalSourceId} | Delete an External Source. WARNING: Any records that reference this External Source will not be automatically cleaned up. Those records will still be editable, but their External IDs may not be fully viewable. |
| [**DeleteExternalcontactsImportCsvSetting**](#DeleteExternalcontactsImportCsvSetting) | **Delete** /api/v2/externalcontacts/import/csv/settings/{settingsId} | Delete settings for CSV import |
| [**DeleteExternalcontactsImportSetting**](#DeleteExternalcontactsImportSetting) | **Delete** /api/v2/externalcontacts/import/settings/{settingsId} | Delete Settings |
| [**DeleteExternalcontactsOrganization**](#DeleteExternalcontactsOrganization) | **Delete** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Delete an external organization |
| [**DeleteExternalcontactsOrganizationNote**](#DeleteExternalcontactsOrganizationNote) | **Delete** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Delete a note for an external organization |
| [**DeleteExternalcontactsOrganizationTrustor**](#DeleteExternalcontactsOrganizationTrustor) | **Delete** /api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor | Unlink the Trustor for this External Organization |
| [**DeleteExternalcontactsRelationship**](#DeleteExternalcontactsRelationship) | **Delete** /api/v2/externalcontacts/relationships/{relationshipId} | Delete a relationship |
| [**GetExternalcontactsContact**](#GetExternalcontactsContact) | **Get** /api/v2/externalcontacts/contacts/{contactId} | Fetch an external contact |
| [**GetExternalcontactsContactIdentifiers**](#GetExternalcontactsContactIdentifiers) | **Get** /api/v2/externalcontacts/contacts/{contactId}/identifiers | List the identifiers for a contact |
| [**GetExternalcontactsContactJourneySessions**](#GetExternalcontactsContactJourneySessions) | **Get** /api/v2/externalcontacts/contacts/{contactId}/journey/sessions | Retrieve all sessions for a given external contact. |
| [**GetExternalcontactsContactNote**](#GetExternalcontactsContactNote) | **Get** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Fetch a note for an external contact |
| [**GetExternalcontactsContactNotes**](#GetExternalcontactsContactNotes) | **Get** /api/v2/externalcontacts/contacts/{contactId}/notes | List notes for an external contact |
| [**GetExternalcontactsContactUnresolved**](#GetExternalcontactsContactUnresolved) | **Get** /api/v2/externalcontacts/contacts/{contactId}/unresolved | Fetch an unresolved external contact |
| [**GetExternalcontactsContacts**](#GetExternalcontactsContacts) | **Get** /api/v2/externalcontacts/contacts | Search for external contacts |
| [**GetExternalcontactsContactsSchema**](#GetExternalcontactsContactsSchema) | **Get** /api/v2/externalcontacts/contacts/schemas/{schemaId} | Get a schema |
| [**GetExternalcontactsContactsSchemaVersion**](#GetExternalcontactsContactsSchemaVersion) | **Get** /api/v2/externalcontacts/contacts/schemas/{schemaId}/versions/{versionId} | Get a specific version of a schema |
| [**GetExternalcontactsContactsSchemaVersions**](#GetExternalcontactsContactsSchemaVersions) | **Get** /api/v2/externalcontacts/contacts/schemas/{schemaId}/versions | Get all versions of an external contact&#39;s schema |
| [**GetExternalcontactsContactsSchemas**](#GetExternalcontactsContactsSchemas) | **Get** /api/v2/externalcontacts/contacts/schemas | Get a list of schemas. |
| [**GetExternalcontactsExternalsource**](#GetExternalcontactsExternalsource) | **Get** /api/v2/externalcontacts/externalsources/{externalSourceId} | Fetch an External Source |
| [**GetExternalcontactsExternalsources**](#GetExternalcontactsExternalsources) | **Get** /api/v2/externalcontacts/externalsources | Fetch a list of External Sources |
| [**GetExternalcontactsImportCsvSetting**](#GetExternalcontactsImportCsvSetting) | **Get** /api/v2/externalcontacts/import/csv/settings/{settingsId} | Get settings for CSV import |
| [**GetExternalcontactsImportCsvSettings**](#GetExternalcontactsImportCsvSettings) | **Get** /api/v2/externalcontacts/import/csv/settings | Retrieve all settings for organization filtered by externalSettingsId if provided |
| [**GetExternalcontactsImportCsvUploadDetails**](#GetExternalcontactsImportCsvUploadDetails) | **Get** /api/v2/externalcontacts/import/csv/uploads/{uploadId}/details | Get details for CSV upload |
| [**GetExternalcontactsImportCsvUploadPreview**](#GetExternalcontactsImportCsvUploadPreview) | **Get** /api/v2/externalcontacts/import/csv/uploads/{uploadId}/preview | Get preview for CSV upload |
| [**GetExternalcontactsImportJob**](#GetExternalcontactsImportJob) | **Get** /api/v2/externalcontacts/import/jobs/{jobId} | Get job based on id |
| [**GetExternalcontactsImportJobs**](#GetExternalcontactsImportJobs) | **Get** /api/v2/externalcontacts/import/jobs | List jobs for organization |
| [**GetExternalcontactsImportSetting**](#GetExternalcontactsImportSetting) | **Get** /api/v2/externalcontacts/import/settings/{settingsId} | Get setting based on id |
| [**GetExternalcontactsImportSettings**](#GetExternalcontactsImportSettings) | **Get** /api/v2/externalcontacts/import/settings | List settings for organization |
| [**GetExternalcontactsOrganization**](#GetExternalcontactsOrganization) | **Get** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Fetch an external organization |
| [**GetExternalcontactsOrganizationContacts**](#GetExternalcontactsOrganizationContacts) | **Get** /api/v2/externalcontacts/organizations/{externalOrganizationId}/contacts | Search for external contacts in an external organization |
| [**GetExternalcontactsOrganizationNote**](#GetExternalcontactsOrganizationNote) | **Get** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Fetch a note for an external organization |
| [**GetExternalcontactsOrganizationNotes**](#GetExternalcontactsOrganizationNotes) | **Get** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes | List notes for an external organization |
| [**GetExternalcontactsOrganizationRelationships**](#GetExternalcontactsOrganizationRelationships) | **Get** /api/v2/externalcontacts/organizations/{externalOrganizationId}/relationships | Fetch a relationship for an external organization |
| [**GetExternalcontactsOrganizations**](#GetExternalcontactsOrganizations) | **Get** /api/v2/externalcontacts/organizations | Search for external organizations |
| [**GetExternalcontactsOrganizationsSchema**](#GetExternalcontactsOrganizationsSchema) | **Get** /api/v2/externalcontacts/organizations/schemas/{schemaId} | Get a schema |
| [**GetExternalcontactsOrganizationsSchemaVersion**](#GetExternalcontactsOrganizationsSchemaVersion) | **Get** /api/v2/externalcontacts/organizations/schemas/{schemaId}/versions/{versionId} | Get a specific version of a schema |
| [**GetExternalcontactsOrganizationsSchemaVersions**](#GetExternalcontactsOrganizationsSchemaVersions) | **Get** /api/v2/externalcontacts/organizations/schemas/{schemaId}/versions | Get all versions of an external organization&#39;s schema |
| [**GetExternalcontactsOrganizationsSchemas**](#GetExternalcontactsOrganizationsSchemas) | **Get** /api/v2/externalcontacts/organizations/schemas | Get a list of schemas. |
| [**GetExternalcontactsRelationship**](#GetExternalcontactsRelationship) | **Get** /api/v2/externalcontacts/relationships/{relationshipId} | Fetch a relationship |
| [**GetExternalcontactsReversewhitepageslookup**](#GetExternalcontactsReversewhitepageslookup) | **Get** /api/v2/externalcontacts/reversewhitepageslookup | Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned. |
| [**GetExternalcontactsScanContacts**](#GetExternalcontactsScanContacts) | **Get** /api/v2/externalcontacts/scan/contacts | Scan for external contacts using paging |
| [**GetExternalcontactsScanNotes**](#GetExternalcontactsScanNotes) | **Get** /api/v2/externalcontacts/scan/notes | Scan for notes using paging |
| [**GetExternalcontactsScanOrganizations**](#GetExternalcontactsScanOrganizations) | **Get** /api/v2/externalcontacts/scan/organizations | Scan for external organizations using paging |
| [**GetExternalcontactsScanRelationships**](#GetExternalcontactsScanRelationships) | **Get** /api/v2/externalcontacts/scan/relationships | Scan for relationships |
| [**PatchExternalcontactsContactIdentifiers**](#PatchExternalcontactsContactIdentifiers) | **Patch** /api/v2/externalcontacts/contacts/{contactId}/identifiers | Claim or release identifiers for a contact |
| [**PostExternalcontactsBulkContacts**](#PostExternalcontactsBulkContacts) | **Post** /api/v2/externalcontacts/bulk/contacts | Bulk fetch contacts |
| [**PostExternalcontactsBulkContactsAdd**](#PostExternalcontactsBulkContactsAdd) | **Post** /api/v2/externalcontacts/bulk/contacts/add | Bulk add contacts |
| [**PostExternalcontactsBulkContactsRemove**](#PostExternalcontactsBulkContactsRemove) | **Post** /api/v2/externalcontacts/bulk/contacts/remove | Bulk remove contacts |
| [**PostExternalcontactsBulkContactsUnresolved**](#PostExternalcontactsBulkContactsUnresolved) | **Post** /api/v2/externalcontacts/bulk/contacts/unresolved | Bulk fetch unresolved ancestor contacts |
| [**PostExternalcontactsBulkContactsUpdate**](#PostExternalcontactsBulkContactsUpdate) | **Post** /api/v2/externalcontacts/bulk/contacts/update | Bulk update contacts |
| [**PostExternalcontactsBulkNotes**](#PostExternalcontactsBulkNotes) | **Post** /api/v2/externalcontacts/bulk/notes | Bulk fetch notes |
| [**PostExternalcontactsBulkNotesAdd**](#PostExternalcontactsBulkNotesAdd) | **Post** /api/v2/externalcontacts/bulk/notes/add | Bulk add notes |
| [**PostExternalcontactsBulkNotesRemove**](#PostExternalcontactsBulkNotesRemove) | **Post** /api/v2/externalcontacts/bulk/notes/remove | Bulk remove notes |
| [**PostExternalcontactsBulkNotesUpdate**](#PostExternalcontactsBulkNotesUpdate) | **Post** /api/v2/externalcontacts/bulk/notes/update | Bulk update notes |
| [**PostExternalcontactsBulkOrganizations**](#PostExternalcontactsBulkOrganizations) | **Post** /api/v2/externalcontacts/bulk/organizations | Bulk fetch organizations |
| [**PostExternalcontactsBulkOrganizationsAdd**](#PostExternalcontactsBulkOrganizationsAdd) | **Post** /api/v2/externalcontacts/bulk/organizations/add | Bulk add organizations |
| [**PostExternalcontactsBulkOrganizationsRemove**](#PostExternalcontactsBulkOrganizationsRemove) | **Post** /api/v2/externalcontacts/bulk/organizations/remove | Bulk remove organizations |
| [**PostExternalcontactsBulkOrganizationsUpdate**](#PostExternalcontactsBulkOrganizationsUpdate) | **Post** /api/v2/externalcontacts/bulk/organizations/update | Bulk update organizations |
| [**PostExternalcontactsBulkRelationships**](#PostExternalcontactsBulkRelationships) | **Post** /api/v2/externalcontacts/bulk/relationships | Bulk fetch relationships |
| [**PostExternalcontactsBulkRelationshipsAdd**](#PostExternalcontactsBulkRelationshipsAdd) | **Post** /api/v2/externalcontacts/bulk/relationships/add | Bulk add relationships |
| [**PostExternalcontactsBulkRelationshipsRemove**](#PostExternalcontactsBulkRelationshipsRemove) | **Post** /api/v2/externalcontacts/bulk/relationships/remove | Bulk remove relationships |
| [**PostExternalcontactsBulkRelationshipsUpdate**](#PostExternalcontactsBulkRelationshipsUpdate) | **Post** /api/v2/externalcontacts/bulk/relationships/update | Bulk update relationships |
| [**PostExternalcontactsContactNotes**](#PostExternalcontactsContactNotes) | **Post** /api/v2/externalcontacts/contacts/{contactId}/notes | Create a note for an external contact |
| [**PostExternalcontactsContactPromotion**](#PostExternalcontactsContactPromotion) | **Post** /api/v2/externalcontacts/contacts/{contactId}/promotion | Promote an observed contact (ephemeral or identified) to a curated contact |
| [**PostExternalcontactsContacts**](#PostExternalcontactsContacts) | **Post** /api/v2/externalcontacts/contacts | Create an external contact |
| [**PostExternalcontactsContactsSchemas**](#PostExternalcontactsContactsSchemas) | **Post** /api/v2/externalcontacts/contacts/schemas | Create a schema |
| [**PostExternalcontactsExternalsources**](#PostExternalcontactsExternalsources) | **Post** /api/v2/externalcontacts/externalsources | Create an External Source |
| [**PostExternalcontactsIdentifierlookup**](#PostExternalcontactsIdentifierlookup) | **Post** /api/v2/externalcontacts/identifierlookup | Fetch a contact using an identifier type and value. |
| [**PostExternalcontactsImportCsvJobs**](#PostExternalcontactsImportCsvJobs) | **Post** /api/v2/externalcontacts/import/csv/jobs | Create CSV import job |
| [**PostExternalcontactsImportCsvSettings**](#PostExternalcontactsImportCsvSettings) | **Post** /api/v2/externalcontacts/import/csv/settings | Create settings for CSV import |
| [**PostExternalcontactsImportCsvUploads**](#PostExternalcontactsImportCsvUploads) | **Post** /api/v2/externalcontacts/import/csv/uploads | Get url for CSV upload |
| [**PostExternalcontactsImportJobs**](#PostExternalcontactsImportJobs) | **Post** /api/v2/externalcontacts/import/jobs | Create a new job |
| [**PostExternalcontactsImportSettings**](#PostExternalcontactsImportSettings) | **Post** /api/v2/externalcontacts/import/settings | Create a new settings |
| [**PostExternalcontactsMergeContacts**](#PostExternalcontactsMergeContacts) | **Post** /api/v2/externalcontacts/merge/contacts | Merge two contacts into a new contact record |
| [**PostExternalcontactsOrganizationNotes**](#PostExternalcontactsOrganizationNotes) | **Post** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes | Create a note for an external organization |
| [**PostExternalcontactsOrganizations**](#PostExternalcontactsOrganizations) | **Post** /api/v2/externalcontacts/organizations | Create an external organization |
| [**PostExternalcontactsOrganizationsSchemas**](#PostExternalcontactsOrganizationsSchemas) | **Post** /api/v2/externalcontacts/organizations/schemas | Create a schema |
| [**PostExternalcontactsRelationships**](#PostExternalcontactsRelationships) | **Post** /api/v2/externalcontacts/relationships | Create a relationship |
| [**PutExternalcontactsContact**](#PutExternalcontactsContact) | **Put** /api/v2/externalcontacts/contacts/{contactId} | Update an external contact |
| [**PutExternalcontactsContactNote**](#PutExternalcontactsContactNote) | **Put** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Update a note for an external contact |
| [**PutExternalcontactsContactsSchema**](#PutExternalcontactsContactsSchema) | **Put** /api/v2/externalcontacts/contacts/schemas/{schemaId} | Update a schema |
| [**PutExternalcontactsConversation**](#PutExternalcontactsConversation) | **Put** /api/v2/externalcontacts/conversations/{conversationId} | Associate/disassociate an external contact with a conversation |
| [**PutExternalcontactsExternalsource**](#PutExternalcontactsExternalsource) | **Put** /api/v2/externalcontacts/externalsources/{externalSourceId} | Update an External Source |
| [**PutExternalcontactsImportCsvSetting**](#PutExternalcontactsImportCsvSetting) | **Put** /api/v2/externalcontacts/import/csv/settings/{settingsId} | Update settings for CSV import |
| [**PutExternalcontactsImportJob**](#PutExternalcontactsImportJob) | **Put** /api/v2/externalcontacts/import/jobs/{jobId} | Update Job&#39;s workflow status |
| [**PutExternalcontactsImportSetting**](#PutExternalcontactsImportSetting) | **Put** /api/v2/externalcontacts/import/settings/{settingsId} | Update settings |
| [**PutExternalcontactsOrganization**](#PutExternalcontactsOrganization) | **Put** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Update an external organization |
| [**PutExternalcontactsOrganizationNote**](#PutExternalcontactsOrganizationNote) | **Put** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Update a note for an external organization |
| [**PutExternalcontactsOrganizationTrustorTrustorId**](#PutExternalcontactsOrganizationTrustorTrustorId) | **Put** /api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor/{trustorId} | Links a Trustor with an External Organization |
| [**PutExternalcontactsOrganizationsSchema**](#PutExternalcontactsOrganizationsSchema) | **Put** /api/v2/externalcontacts/organizations/schemas/{schemaId} | Update a schema |
| [**PutExternalcontactsRelationship**](#PutExternalcontactsRelationship) | **Put** /api/v2/externalcontacts/relationships/{relationshipId} | Update a relationship |



## DeleteExternalcontactsContact

> **Object** DeleteExternalcontactsContact (string contactId)


Delete an external contact

Requires ANY permissions: 

* relate:contact:delete
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
                Object result = apiInstance.DeleteExternalcontactsContact(contactId);
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

### Return type

**Object**


## DeleteExternalcontactsContactNote

> **Object** DeleteExternalcontactsContactNote (string contactId, string noteId)


Delete a note for an external contact

Requires ANY permissions: 

* relate:contact:edit
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
                Object result = apiInstance.DeleteExternalcontactsContactNote(contactId, noteId);
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

### Return type

**Object**


## DeleteExternalcontactsContactsSchema

> void DeleteExternalcontactsContactsSchema (string schemaId)


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

### Return type

void (empty response body)


## DeleteExternalcontactsExternalsource

> **Object** DeleteExternalcontactsExternalsource (string externalSourceId)


Delete an External Source. WARNING: Any records that reference this External Source will not be automatically cleaned up. Those records will still be editable, but their External IDs may not be fully viewable.

Requires ANY permissions: 

* externalContacts:externalSource:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsExternalsourceExample
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
            var externalSourceId = externalSourceId_example;  // string | External Source ID

            try
            { 
                // Delete an External Source. WARNING: Any records that reference this External Source will not be automatically cleaned up. Those records will still be editable, but their External IDs may not be fully viewable.
                Object result = apiInstance.DeleteExternalcontactsExternalsource(externalSourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteExternalcontactsExternalsource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalSourceId** | **string**| External Source ID |  |

### Return type

**Object**


## DeleteExternalcontactsImportCsvSetting

> void DeleteExternalcontactsImportCsvSetting (string settingsId)


Delete settings for CSV import

Requires ANY permissions: 

* externalContacts:importCsvSettings:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsImportCsvSettingExample
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
            var settingsId = settingsId_example;  // string | Settings id

            try
            { 
                // Delete settings for CSV import
                apiInstance.DeleteExternalcontactsImportCsvSetting(settingsId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteExternalcontactsImportCsvSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **settingsId** | **string**| Settings id |  |

### Return type

void (empty response body)


## DeleteExternalcontactsImportSetting

> void DeleteExternalcontactsImportSetting (string settingsId)


Delete Settings

Requires ANY permissions: 

* externalContacts:importSettings:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteExternalcontactsImportSettingExample
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
            var settingsId = settingsId_example;  // string | Settings id

            try
            { 
                // Delete Settings
                apiInstance.DeleteExternalcontactsImportSetting(settingsId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteExternalcontactsImportSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **settingsId** | **string**| Settings id |  |

### Return type

void (empty response body)


## DeleteExternalcontactsOrganization

> **Object** DeleteExternalcontactsOrganization (string externalOrganizationId)


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
                Object result = apiInstance.DeleteExternalcontactsOrganization(externalOrganizationId);
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

### Return type

**Object**


## DeleteExternalcontactsOrganizationNote

> **Object** DeleteExternalcontactsOrganizationNote (string externalOrganizationId, string noteId)


Delete a note for an external organization

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
                Object result = apiInstance.DeleteExternalcontactsOrganizationNote(externalOrganizationId, noteId);
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

### Return type

**Object**


## DeleteExternalcontactsOrganizationTrustor

> void DeleteExternalcontactsOrganizationTrustor (string externalOrganizationId)


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

### Return type

void (empty response body)


## DeleteExternalcontactsRelationship

> **Object** DeleteExternalcontactsRelationship (string relationshipId)


Delete a relationship

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
                Object result = apiInstance.DeleteExternalcontactsRelationship(relationshipId);
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

### Return type

**Object**


## GetExternalcontactsContact

> [**ExternalContact**](ExternalContact) GetExternalcontactsContact (string contactId, List<string> expand = null)


Fetch an external contact

Requires ANY permissions: 

* relate:contact:view
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
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

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
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: externalOrganization, externalDataSources, identifiers, externalSources, division |

### Return type

[**ExternalContact**](ExternalContact)


## GetExternalcontactsContactIdentifiers

> [**ContactIdentifierListing**](ContactIdentifierListing) GetExternalcontactsContactIdentifiers (string contactId)


List the identifiers for a contact

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
    public class GetExternalcontactsContactIdentifiersExample
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
                // List the identifiers for a contact
                ContactIdentifierListing result = apiInstance.GetExternalcontactsContactIdentifiers(contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContactIdentifiers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |

### Return type

[**ContactIdentifierListing**](ContactIdentifierListing)


## GetExternalcontactsContactJourneySessions

> [**SessionListing**](SessionListing) GetExternalcontactsContactJourneySessions (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)


Retrieve all sessions for a given external contact.

Requires ANY permissions: 

* externalContacts:session:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsContactJourneySessionsExample
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
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var includeMerged = true;  // bool? | Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional) 

            try
            { 
                // Retrieve all sessions for a given external contact.
                SessionListing result = apiInstance.GetExternalcontactsContactJourneySessions(contactId, pageSize, after, includeMerged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContactJourneySessions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **includeMerged** | **bool?**| Indicates whether to return sessions from all external contacts in the merge-set of the given one. | [optional]  |

### Return type

[**SessionListing**](SessionListing)


## GetExternalcontactsContactNote

> [**Note**](Note) GetExternalcontactsContactNote (string contactId, string noteId, List<string> expand = null)


Fetch a note for an external contact

Requires ANY permissions: 

* relate:contact:view
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
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: author, externalDataSources, division |

### Return type

[**Note**](Note)


## GetExternalcontactsContactNotes

> [**NoteListing**](NoteListing) GetExternalcontactsContactNotes (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)


List notes for an external contact

Requires ANY permissions: 

* relate:contact:view
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
            var sortOrder = sortOrder_example;  // string | The Note field to sort by. Any of: [createDate]. Direction: [asc, desc].  e.g. \"createDate:asc\", \"createDate:desc\" (optional) 
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
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 1] |
| **sortOrder** | **string**| The Note field to sort by. Any of: [createDate]. Direction: [asc, desc].  e.g. \&quot;createDate:asc\&quot;, \&quot;createDate:desc\&quot; | [optional]  |
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: author, externalDataSources, division |

### Return type

[**NoteListing**](NoteListing)


## GetExternalcontactsContactUnresolved

> [**ExternalContact**](ExternalContact) GetExternalcontactsContactUnresolved (string contactId, List<string> expand = null)


Fetch an unresolved external contact

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
    public class GetExternalcontactsContactUnresolvedExample
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
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

            try
            { 
                // Fetch an unresolved external contact
                ExternalContact result = apiInstance.GetExternalcontactsContactUnresolved(contactId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsContactUnresolved: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: externalOrganization, externalDataSources, identifiers, division |

### Return type

[**ExternalContact**](ExternalContact)


## GetExternalcontactsContacts

> [**ContactListing**](ContactListing) GetExternalcontactsContacts (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)


Search for external contacts

Requires ANY permissions: 

* relate:contact:view
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
            var sortOrder = sortOrder_example;  // string | The External Contact field to sort by. Any of: [firstName, lastName, middleName, title]. Direction: [asc, desc]. e.g. \"firstName:asc\", \"title:desc\" (optional) 
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
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 1] |
| **q** | **string**| User supplied search keywords (no special syntax is currently supported) | [optional]  |
| **sortOrder** | **string**| The External Contact field to sort by. Any of: [firstName, lastName, middleName, title]. Direction: [asc, desc]. e.g. \&quot;firstName:asc\&quot;, \&quot;title:desc\&quot; | [optional]  |
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: externalOrganization, externalDataSources, identifiers, externalSources, division |

### Return type

[**ContactListing**](ContactListing)


## GetExternalcontactsContactsSchema

> [**DataSchema**](DataSchema) GetExternalcontactsContactsSchema (string schemaId)


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

### Return type

[**DataSchema**](DataSchema)


## GetExternalcontactsContactsSchemaVersion

> [**DataSchema**](DataSchema) GetExternalcontactsContactsSchemaVersion (string schemaId, string versionId)


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

### Return type

[**DataSchema**](DataSchema)


## GetExternalcontactsContactsSchemaVersions

> [**DataSchema**](DataSchema) GetExternalcontactsContactsSchemaVersions (string schemaId)


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

### Return type

[**DataSchema**](DataSchema)


## GetExternalcontactsContactsSchemas

> [**DataSchemaListing**](DataSchemaListing) GetExternalcontactsContactsSchemas ()


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

[**DataSchemaListing**](DataSchemaListing)


## GetExternalcontactsExternalsource

> [**ExternalSource**](ExternalSource) GetExternalcontactsExternalsource (string externalSourceId)


Fetch an External Source

Requires ANY permissions: 

* externalContacts:externalSource:view
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
    public class GetExternalcontactsExternalsourceExample
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
            var externalSourceId = externalSourceId_example;  // string | External Source ID

            try
            { 
                // Fetch an External Source
                ExternalSource result = apiInstance.GetExternalcontactsExternalsource(externalSourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsExternalsource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalSourceId** | **string**| External Source ID |  |

### Return type

[**ExternalSource**](ExternalSource)


## GetExternalcontactsExternalsources

> [**CursorExternalSourceListing**](CursorExternalSourceListing) GetExternalcontactsExternalsources (string cursor = null, int? limit = null, string name = null, bool? active = null)


Fetch a list of External Sources

Requires ANY permissions: 

* externalContacts:externalSource:view
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
    public class GetExternalcontactsExternalsourcesExample
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
            var cursor = cursor_example;  // string | Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional) 
            var limit = 56;  // int? | The number of ExternalSources per page; must be between 10 and 200, default is 100 (optional) 
            var name = name_example;  // string | Filter by external source name. Filtering is prefix filtering and not an exact match (optional) 
            var active = true;  // bool? | Filter by active status of external source (optional) 

            try
            { 
                // Fetch a list of External Sources
                CursorExternalSourceListing result = apiInstance.GetExternalcontactsExternalsources(cursor, limit, name, active);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsExternalsources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **cursor** | **string**| Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL | [optional]  |
| **limit** | **int?**| The number of ExternalSources per page; must be between 10 and 200, default is 100 | [optional]  |
| **name** | **string**| Filter by external source name. Filtering is prefix filtering and not an exact match | [optional]  |
| **active** | **bool?**| Filter by active status of external source | [optional]  |

### Return type

[**CursorExternalSourceListing**](CursorExternalSourceListing)


## GetExternalcontactsImportCsvSetting

> [**CsvSettings**](CsvSettings) GetExternalcontactsImportCsvSetting (string settingsId)


Get settings for CSV import

Requires ANY permissions: 

* externalContacts:importCsvSettings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsImportCsvSettingExample
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
            var settingsId = settingsId_example;  // string | Settings id

            try
            { 
                // Get settings for CSV import
                CsvSettings result = apiInstance.GetExternalcontactsImportCsvSetting(settingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsImportCsvSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **settingsId** | **string**| Settings id |  |

### Return type

[**CsvSettings**](CsvSettings)


## GetExternalcontactsImportCsvSettings

> [**Listing**](Listing) GetExternalcontactsImportCsvSettings (string after = null, string pageSize = null, string externalSettingsId = null)


Retrieve all settings for organization filtered by externalSettingsId if provided

Requires ANY permissions: 

* externalContacts:importCsvSettings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsImportCsvSettingsExample
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
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var externalSettingsId = externalSettingsId_example;  // string | External Settings Id to filter the list. (optional) 

            try
            { 
                // Retrieve all settings for organization filtered by externalSettingsId if provided
                Listing result = apiInstance.GetExternalcontactsImportCsvSettings(after, pageSize, externalSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsImportCsvSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **externalSettingsId** | **string**| External Settings Id to filter the list. | [optional]  |

### Return type

[**Listing**](Listing)


## GetExternalcontactsImportCsvUploadDetails

> [**CsvUploadDetailsResponse**](CsvUploadDetailsResponse) GetExternalcontactsImportCsvUploadDetails (string uploadId)


Get details for CSV upload

Requires ANY permissions: 

* externalContacts:importCsvUpload:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsImportCsvUploadDetailsExample
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
            var uploadId = uploadId_example;  // string | Upload id

            try
            { 
                // Get details for CSV upload
                CsvUploadDetailsResponse result = apiInstance.GetExternalcontactsImportCsvUploadDetails(uploadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsImportCsvUploadDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **uploadId** | **string**| Upload id |  |

### Return type

[**CsvUploadDetailsResponse**](CsvUploadDetailsResponse)


## GetExternalcontactsImportCsvUploadPreview

> [**CsvUploadPreviewResponse**](CsvUploadPreviewResponse) GetExternalcontactsImportCsvUploadPreview (string uploadId)


Get preview for CSV upload

Requires ANY permissions: 

* externalContacts:importCsvUpload:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsImportCsvUploadPreviewExample
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
            var uploadId = uploadId_example;  // string | Upload id

            try
            { 
                // Get preview for CSV upload
                CsvUploadPreviewResponse result = apiInstance.GetExternalcontactsImportCsvUploadPreview(uploadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsImportCsvUploadPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **uploadId** | **string**| Upload id |  |

### Return type

[**CsvUploadPreviewResponse**](CsvUploadPreviewResponse)


## GetExternalcontactsImportJob

> [**ContactImportJobResponse**](ContactImportJobResponse) GetExternalcontactsImportJob (string jobId)


Get job based on id

Requires ANY permissions: 

* externalContacts:importJob:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsImportJobExample
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
            var jobId = jobId_example;  // string | Job id

            try
            { 
                // Get job based on id
                ContactImportJobResponse result = apiInstance.GetExternalcontactsImportJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| Job id |  |

### Return type

[**ContactImportJobResponse**](ContactImportJobResponse)


## GetExternalcontactsImportJobs

> [**ContactImportJobEntityListing**](ContactImportJobEntityListing) GetExternalcontactsImportJobs (string after = null, string pageSize = null, string sortOrder = null, string jobStatus = null)


List jobs for organization

Requires ANY permissions: 

* externalContacts:importJob:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsImportJobsExample
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
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 100. (optional)  (default to "25")
            var sortOrder = sortOrder_example;  // string | Direction of sorting. (optional)  (default to Ascending)
            var jobStatus = jobStatus_example;  // string | Search term to filter by jobStatus (optional) 

            try
            { 
                // List jobs for organization
                ContactImportJobEntityListing result = apiInstance.GetExternalcontactsImportJobs(after, pageSize, sortOrder, jobStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsImportJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 100. | [optional] [default to "25"] |
| **sortOrder** | **string**| Direction of sorting. | [optional] [default to Ascending]<br />**Values**: Ascending, Descending |
| **jobStatus** | **string**| Search term to filter by jobStatus | [optional] <br />**Values**: Created, Running, Completed, Failed, Cancelled |

### Return type

[**ContactImportJobEntityListing**](ContactImportJobEntityListing)


## GetExternalcontactsImportSetting

> [**ContactImportSettings**](ContactImportSettings) GetExternalcontactsImportSetting (string settingsId)


Get setting based on id

Requires ANY permissions: 

* externalContacts:importSettings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsImportSettingExample
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
            var settingsId = settingsId_example;  // string | Settings id

            try
            { 
                // Get setting based on id
                ContactImportSettings result = apiInstance.GetExternalcontactsImportSetting(settingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsImportSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **settingsId** | **string**| Settings id |  |

### Return type

[**ContactImportSettings**](ContactImportSettings)


## GetExternalcontactsImportSettings

> [**ContactImportSettingsEntityListing**](ContactImportSettingsEntityListing) GetExternalcontactsImportSettings (string after = null, string pageSize = null, string sortOrder = null, string name = null)


List settings for organization

Requires ANY permissions: 

* externalContacts:importSettings:viewAll

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetExternalcontactsImportSettingsExample
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
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 100. (optional)  (default to "25")
            var sortOrder = sortOrder_example;  // string | Direction of sorting. (optional)  (default to Ascending)
            var name = name_example;  // string | Search term to filter by settings name (optional) 

            try
            { 
                // List settings for organization
                ContactImportSettingsEntityListing result = apiInstance.GetExternalcontactsImportSettings(after, pageSize, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetExternalcontactsImportSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 100. | [optional] [default to "25"] |
| **sortOrder** | **string**| Direction of sorting. | [optional] [default to Ascending]<br />**Values**: Ascending, Descending |
| **name** | **string**| Search term to filter by settings name | [optional]  |

### Return type

[**ContactImportSettingsEntityListing**](ContactImportSettingsEntityListing)


## GetExternalcontactsOrganization

> [**ExternalOrganization**](ExternalOrganization) GetExternalcontactsOrganization (string externalOrganizationId, List<string> expand = null, bool? includeTrustors = null)


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
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 
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
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: externalDataSources, division, identifiers, externalSources |
| **includeTrustors** | **bool?**| (true or false) whether or not to include trustor information embedded in the externalOrganization | [optional]  |

### Return type

[**ExternalOrganization**](ExternalOrganization)


## GetExternalcontactsOrganizationContacts

> [**ContactListing**](ContactListing) GetExternalcontactsOrganizationContacts (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)


Search for external contacts in an external organization

Requires ANY permissions: 

* relate:contact:view
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
            var sortOrder = sortOrder_example;  // string | The External Contact field to sort by. Any of: [firstName, lastName, middleName, title]. Direction: [asc, desc]. e.g. \"firstName:asc\", \"title:desc\" (optional) 
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
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 1] |
| **q** | **string**| User supplied search keywords (no special syntax is currently supported) | [optional]  |
| **sortOrder** | **string**| The External Contact field to sort by. Any of: [firstName, lastName, middleName, title]. Direction: [asc, desc]. e.g. \&quot;firstName:asc\&quot;, \&quot;title:desc\&quot; | [optional]  |
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: externalOrganization, externalDataSources, identifiers, externalSources, division |

### Return type

[**ContactListing**](ContactListing)


## GetExternalcontactsOrganizationNote

> [**Note**](Note) GetExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, List<string> expand = null)


Fetch a note for an external organization

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
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: author, externalDataSources, division |

### Return type

[**Note**](Note)


## GetExternalcontactsOrganizationNotes

> [**NoteListing**](NoteListing) GetExternalcontactsOrganizationNotes (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)


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
            var sortOrder = sortOrder_example;  // string | The Note field to sort by. Any of: [createDate]. Direction: [asc, desc]. e.g. \"createDate:asc\", \"createDate:desc\" (optional) 
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
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 1] |
| **sortOrder** | **string**| The Note field to sort by. Any of: [createDate]. Direction: [asc, desc]. e.g. \&quot;createDate:asc\&quot;, \&quot;createDate:desc\&quot; | [optional]  |
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: author, externalDataSources, division |

### Return type

[**NoteListing**](NoteListing)


## GetExternalcontactsOrganizationRelationships

> [**RelationshipListing**](RelationshipListing) GetExternalcontactsOrganizationRelationships (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, List<string> expand = null, string sortOrder = null)


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
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 
            var sortOrder = sortOrder_example;  // string | The Relationship field to sort by. Any of: [createDate, relationship]. Direction: [asc, desc]. e.g. \"createDate:asc\", \"relationship:desc\" (optional) 

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
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 1] |
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: externalDataSources, division |
| **sortOrder** | **string**| The Relationship field to sort by. Any of: [createDate, relationship]. Direction: [asc, desc]. e.g. \&quot;createDate:asc\&quot;, \&quot;relationship:desc\&quot; | [optional]  |

### Return type

[**RelationshipListing**](RelationshipListing)


## GetExternalcontactsOrganizations

> [**ExternalOrganizationListing**](ExternalOrganizationListing) GetExternalcontactsOrganizations (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null)


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
            var sortOrder = sortOrder_example;  // string | The Organization field to sort by. Any of: [companyType, industry, name]. Direction: [asc, desc]. e.g. \"companyType:asc\", \"industry:desc\" (optional) 
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
| **pageSize** | **int?**| Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) | [optional] [default to 1] |
| **q** | **string**| Search query | [optional]  |
| **trustorId** | [**List<string>**](string)| Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested | [optional]  |
| **sortOrder** | **string**| The Organization field to sort by. Any of: [companyType, industry, name]. Direction: [asc, desc]. e.g. \&quot;companyType:asc\&quot;, \&quot;industry:desc\&quot; | [optional]  |
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: externalDataSources, division, identifiers, externalSources |
| **includeTrustors** | **bool?**| (true or false) whether or not to include trustor information embedded in the externalOrganization | [optional]  |

### Return type

[**ExternalOrganizationListing**](ExternalOrganizationListing)


## GetExternalcontactsOrganizationsSchema

> [**DataSchema**](DataSchema) GetExternalcontactsOrganizationsSchema (string schemaId)


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

### Return type

[**DataSchema**](DataSchema)


## GetExternalcontactsOrganizationsSchemaVersion

> [**DataSchema**](DataSchema) GetExternalcontactsOrganizationsSchemaVersion (string schemaId, string versionId)


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

### Return type

[**DataSchema**](DataSchema)


## GetExternalcontactsOrganizationsSchemaVersions

> [**DataSchema**](DataSchema) GetExternalcontactsOrganizationsSchemaVersions (string schemaId)


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

### Return type

[**DataSchema**](DataSchema)


## GetExternalcontactsOrganizationsSchemas

> [**DataSchemaListing**](DataSchemaListing) GetExternalcontactsOrganizationsSchemas ()


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

[**DataSchemaListing**](DataSchemaListing)


## GetExternalcontactsRelationship

> [**Relationship**](Relationship) GetExternalcontactsRelationship (string relationshipId, List<string> expand = null)


Fetch a relationship

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
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

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
| **expand** | [**List<string>**](string)| which fields, if any, to expand | [optional] <br />**Values**: externalDataSources, division |

### Return type

[**Relationship**](Relationship)


## GetExternalcontactsReversewhitepageslookup

> [**ReverseWhitepagesLookupResult**](ReverseWhitepagesLookupResult) GetExternalcontactsReversewhitepageslookup (string lookupVal, List<string> expand = null)


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
| **expand** | [**List<string>**](string)| which field, if any, to expand | [optional] <br />**Values**: contacts.externalOrganization, externalDataSources, division |

### Return type

[**ReverseWhitepagesLookupResult**](ReverseWhitepagesLookupResult)


## GetExternalcontactsScanContacts

> [**CursorContactListing**](CursorContactListing) GetExternalcontactsScanContacts (int? limit = null, string cursor = null)


Scan for external contacts using paging

Requires ANY permissions: 

* relate:contact:view
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
            var limit = 56;  // int? | The number of contacts per page; must be between 10 and 200, default is 100 (optional) 
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
| **limit** | **int?**| The number of contacts per page; must be between 10 and 200, default is 100 | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL | [optional]  |

### Return type

[**CursorContactListing**](CursorContactListing)


## GetExternalcontactsScanNotes

> [**CursorNoteListing**](CursorNoteListing) GetExternalcontactsScanNotes (int? limit = null, string cursor = null)


Scan for notes using paging

Requires ANY permissions: 

* relate:contact:view
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
            var limit = 56;  // int? | The number of notes per page; must be between 10 and 200, default is 100 (optional) 
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
| **limit** | **int?**| The number of notes per page; must be between 10 and 200, default is 100 | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL | [optional]  |

### Return type

[**CursorNoteListing**](CursorNoteListing)


## GetExternalcontactsScanOrganizations

> [**CursorOrganizationListing**](CursorOrganizationListing) GetExternalcontactsScanOrganizations (int? limit = null, string cursor = null)


Scan for external organizations using paging

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
            var limit = 56;  // int? | The number of organizations per page; must be between 10 and 200, default is 100 (optional) 
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
| **limit** | **int?**| The number of organizations per page; must be between 10 and 200, default is 100 | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL | [optional]  |

### Return type

[**CursorOrganizationListing**](CursorOrganizationListing)


## GetExternalcontactsScanRelationships

> [**CursorRelationshipListing**](CursorRelationshipListing) GetExternalcontactsScanRelationships (int? limit = null, string cursor = null)


Scan for relationships

Requires ANY permissions: 

* relate:contact:view
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
            var limit = 56;  // int? | The number of relationships per page; must be between 10 and 200, default is 100 (optional) 
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
| **limit** | **int?**| The number of relationships per page; must be between 10 and 200, default is 100 | [optional]  |
| **cursor** | **string**| Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL | [optional]  |

### Return type

[**CursorRelationshipListing**](CursorRelationshipListing)


## PatchExternalcontactsContactIdentifiers

> [**ContactIdentifier**](ContactIdentifier) PatchExternalcontactsContactIdentifiers (string contactId, IdentifierClaimRequest body)


Claim or release identifiers for a contact

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
    public class PatchExternalcontactsContactIdentifiersExample
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
            var body = new IdentifierClaimRequest(); // IdentifierClaimRequest | ClaimRequest

            try
            { 
                // Claim or release identifiers for a contact
                ContactIdentifier result = apiInstance.PatchExternalcontactsContactIdentifiers(contactId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PatchExternalcontactsContactIdentifiers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |
| **body** | [**IdentifierClaimRequest**](IdentifierClaimRequest)| ClaimRequest |  |

### Return type

[**ContactIdentifier**](ContactIdentifier)


## PostExternalcontactsBulkContacts

> [**BulkFetchContactsResponse**](BulkFetchContactsResponse) PostExternalcontactsBulkContacts (BulkIdsRequest body)


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
| **body** | [**BulkIdsRequest**](BulkIdsRequest)| Contact ids |  |

### Return type

[**BulkFetchContactsResponse**](BulkFetchContactsResponse)


## PostExternalcontactsBulkContactsAdd

> [**BulkContactsResponse**](BulkContactsResponse) PostExternalcontactsBulkContactsAdd (BulkContactsRequest body)


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
| **body** | [**BulkContactsRequest**](BulkContactsRequest)| Contacts |  |

### Return type

[**BulkContactsResponse**](BulkContactsResponse)


## PostExternalcontactsBulkContactsRemove

> [**BulkDeleteResponse**](BulkDeleteResponse) PostExternalcontactsBulkContactsRemove (BulkIdsRequest body)


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
| **body** | [**BulkIdsRequest**](BulkIdsRequest)| Contact ids |  |

### Return type

[**BulkDeleteResponse**](BulkDeleteResponse)


## PostExternalcontactsBulkContactsUnresolved

> [**BulkFetchContactsResponse**](BulkFetchContactsResponse) PostExternalcontactsBulkContactsUnresolved (BulkIdsRequest body)


Bulk fetch unresolved ancestor contacts

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
    public class PostExternalcontactsBulkContactsUnresolvedExample
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
                // Bulk fetch unresolved ancestor contacts
                BulkFetchContactsResponse result = apiInstance.PostExternalcontactsBulkContactsUnresolved(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsBulkContactsUnresolved: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**BulkIdsRequest**](BulkIdsRequest)| Contact ids |  |

### Return type

[**BulkFetchContactsResponse**](BulkFetchContactsResponse)


## PostExternalcontactsBulkContactsUpdate

> [**BulkContactsResponse**](BulkContactsResponse) PostExternalcontactsBulkContactsUpdate (BulkContactsRequest body)


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
| **body** | [**BulkContactsRequest**](BulkContactsRequest)| Contacts |  |

### Return type

[**BulkContactsResponse**](BulkContactsResponse)


## PostExternalcontactsBulkNotes

> [**BulkFetchNotesResponse**](BulkFetchNotesResponse) PostExternalcontactsBulkNotes (BulkIdsRequest body)


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
| **body** | [**BulkIdsRequest**](BulkIdsRequest)| Note ids |  |

### Return type

[**BulkFetchNotesResponse**](BulkFetchNotesResponse)


## PostExternalcontactsBulkNotesAdd

> [**BulkNotesResponse**](BulkNotesResponse) PostExternalcontactsBulkNotesAdd (BulkNotesRequest body)


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
| **body** | [**BulkNotesRequest**](BulkNotesRequest)| Notes |  |

### Return type

[**BulkNotesResponse**](BulkNotesResponse)


## PostExternalcontactsBulkNotesRemove

> [**BulkDeleteResponse**](BulkDeleteResponse) PostExternalcontactsBulkNotesRemove (BulkIdsRequest body)


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
| **body** | [**BulkIdsRequest**](BulkIdsRequest)| Note ids |  |

### Return type

[**BulkDeleteResponse**](BulkDeleteResponse)


## PostExternalcontactsBulkNotesUpdate

> [**BulkNotesResponse**](BulkNotesResponse) PostExternalcontactsBulkNotesUpdate (BulkNotesRequest body)


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
| **body** | [**BulkNotesRequest**](BulkNotesRequest)| Notes |  |

### Return type

[**BulkNotesResponse**](BulkNotesResponse)


## PostExternalcontactsBulkOrganizations

> [**BulkFetchOrganizationsResponse**](BulkFetchOrganizationsResponse) PostExternalcontactsBulkOrganizations (BulkIdsRequest body)


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
| **body** | [**BulkIdsRequest**](BulkIdsRequest)| Organizations ids |  |

### Return type

[**BulkFetchOrganizationsResponse**](BulkFetchOrganizationsResponse)


## PostExternalcontactsBulkOrganizationsAdd

> [**BulkOrganizationsResponse**](BulkOrganizationsResponse) PostExternalcontactsBulkOrganizationsAdd (BulkOrganizationsRequest body)


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
| **body** | [**BulkOrganizationsRequest**](BulkOrganizationsRequest)| Organizations |  |

### Return type

[**BulkOrganizationsResponse**](BulkOrganizationsResponse)


## PostExternalcontactsBulkOrganizationsRemove

> [**BulkDeleteResponse**](BulkDeleteResponse) PostExternalcontactsBulkOrganizationsRemove (BulkIdsRequest body)


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
| **body** | [**BulkIdsRequest**](BulkIdsRequest)| Organization ids |  |

### Return type

[**BulkDeleteResponse**](BulkDeleteResponse)


## PostExternalcontactsBulkOrganizationsUpdate

> [**BulkOrganizationsResponse**](BulkOrganizationsResponse) PostExternalcontactsBulkOrganizationsUpdate (BulkOrganizationsRequest body)


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
| **body** | [**BulkOrganizationsRequest**](BulkOrganizationsRequest)| Organizations |  |

### Return type

[**BulkOrganizationsResponse**](BulkOrganizationsResponse)


## PostExternalcontactsBulkRelationships

> [**BulkFetchRelationshipsResponse**](BulkFetchRelationshipsResponse) PostExternalcontactsBulkRelationships (BulkIdsRequest body)


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
| **body** | [**BulkIdsRequest**](BulkIdsRequest)| Relationships ids |  |

### Return type

[**BulkFetchRelationshipsResponse**](BulkFetchRelationshipsResponse)


## PostExternalcontactsBulkRelationshipsAdd

> [**BulkRelationshipsResponse**](BulkRelationshipsResponse) PostExternalcontactsBulkRelationshipsAdd (BulkRelationshipsRequest body)


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
| **body** | [**BulkRelationshipsRequest**](BulkRelationshipsRequest)| Relationships |  |

### Return type

[**BulkRelationshipsResponse**](BulkRelationshipsResponse)


## PostExternalcontactsBulkRelationshipsRemove

> [**BulkDeleteResponse**](BulkDeleteResponse) PostExternalcontactsBulkRelationshipsRemove (BulkIdsRequest body)


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
| **body** | [**BulkIdsRequest**](BulkIdsRequest)| Relationships ids |  |

### Return type

[**BulkDeleteResponse**](BulkDeleteResponse)


## PostExternalcontactsBulkRelationshipsUpdate

> [**BulkRelationshipsResponse**](BulkRelationshipsResponse) PostExternalcontactsBulkRelationshipsUpdate (BulkRelationshipsRequest body)


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
| **body** | [**BulkRelationshipsRequest**](BulkRelationshipsRequest)| Relationships |  |

### Return type

[**BulkRelationshipsResponse**](BulkRelationshipsResponse)


## PostExternalcontactsContactNotes

> [**Note**](Note) PostExternalcontactsContactNotes (string contactId, Note body)


Create a note for an external contact

Requires ANY permissions: 

* relate:contact:edit
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
| **body** | [**Note**](Note)| ExternalContact |  |

### Return type

[**Note**](Note)


## PostExternalcontactsContactPromotion

> [**ExternalContact**](ExternalContact) PostExternalcontactsContactPromotion (string contactId)


Promote an observed contact (ephemeral or identified) to a curated contact

Requires ANY permissions: 

* externalContacts:identity:promote

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsContactPromotionExample
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
                // Promote an observed contact (ephemeral or identified) to a curated contact
                ExternalContact result = apiInstance.PostExternalcontactsContactPromotion(contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsContactPromotion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |

### Return type

[**ExternalContact**](ExternalContact)


## PostExternalcontactsContacts

> [**ExternalContact**](ExternalContact) PostExternalcontactsContacts (ExternalContact body)


Create an external contact

Requires ANY permissions: 

* relate:contact:add
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
| **body** | [**ExternalContact**](ExternalContact)| ExternalContact |  |

### Return type

[**ExternalContact**](ExternalContact)


## PostExternalcontactsContactsSchemas

> [**DataSchema**](DataSchema) PostExternalcontactsContactsSchemas (DataSchema body)


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
| **body** | [**DataSchema**](DataSchema)| Schema |  |

### Return type

[**DataSchema**](DataSchema)


## PostExternalcontactsExternalsources

> [**ExternalSource**](ExternalSource) PostExternalcontactsExternalsources (ExternalSource body)


Create an External Source

Requires ANY permissions: 

* externalContacts:externalSource:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsExternalsourcesExample
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
            var body = new ExternalSource(); // ExternalSource | External Source

            try
            { 
                // Create an External Source
                ExternalSource result = apiInstance.PostExternalcontactsExternalsources(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsExternalsources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExternalSource**](ExternalSource)| External Source |  |

### Return type

[**ExternalSource**](ExternalSource)


## PostExternalcontactsIdentifierlookup

> [**ExternalContact**](ExternalContact) PostExternalcontactsIdentifierlookup (ContactIdentifier identifier, List<string> expand = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Fetch a contact using an identifier type and value.

NOTE: Deprecated. Please use /api/v2/externalcontacts/identifierlookup/contacts as an alternative endpoint instead. Phone number identifier values must be provided with the country code and a leading '+' symbol. Example: \"+1 704 298 4733\"

Requires ANY permissions: 

* externalContacts:contact:view
* relate:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsIdentifierlookupExample
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
            var identifier = new ContactIdentifier(); // ContactIdentifier | 
            var expand = new List<string>(); // List<string> | which field, if any, to expand (optional) 

            try
            { 
                // Fetch a contact using an identifier type and value.
                ExternalContact result = apiInstance.PostExternalcontactsIdentifierlookup(identifier, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsIdentifierlookup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **identifier** | [**ContactIdentifier**](ContactIdentifier)|  |  |
| **expand** | [**List<string>**](string)| which field, if any, to expand | [optional] <br />**Values**: externalOrganization, identifiers, externalSources, division |

### Return type

[**ExternalContact**](ExternalContact)


## PostExternalcontactsImportCsvJobs

> [**CsvJobResponse**](CsvJobResponse) PostExternalcontactsImportCsvJobs (CsvJobRequest body)


Create CSV import job

Requires ANY permissions: 

* externalContacts:importCsvJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsImportCsvJobsExample
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
            var body = new CsvJobRequest(); // CsvJobRequest | ImportRequest

            try
            { 
                // Create CSV import job
                CsvJobResponse result = apiInstance.PostExternalcontactsImportCsvJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsImportCsvJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CsvJobRequest**](CsvJobRequest)| ImportRequest |  |

### Return type

[**CsvJobResponse**](CsvJobResponse)


## PostExternalcontactsImportCsvSettings

> [**CsvSettings**](CsvSettings) PostExternalcontactsImportCsvSettings (CsvSettings body)


Create settings for CSV import

Requires ANY permissions: 

* externalContacts:importCsvSettings:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsImportCsvSettingsExample
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
            var body = new CsvSettings(); // CsvSettings | Settings

            try
            { 
                // Create settings for CSV import
                CsvSettings result = apiInstance.PostExternalcontactsImportCsvSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsImportCsvSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CsvSettings**](CsvSettings)| Settings |  |

### Return type

[**CsvSettings**](CsvSettings)


## PostExternalcontactsImportCsvUploads

> [**CsvUploadResponse**](CsvUploadResponse) PostExternalcontactsImportCsvUploads (CsvUploadRequest body)


Get url for CSV upload

Requires ANY permissions: 

* externalContacts:importCsvUpload:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsImportCsvUploadsExample
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
            var body = new CsvUploadRequest(); // CsvUploadRequest | UploadRequest

            try
            { 
                // Get url for CSV upload
                CsvUploadResponse result = apiInstance.PostExternalcontactsImportCsvUploads(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsImportCsvUploads: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CsvUploadRequest**](CsvUploadRequest)| UploadRequest |  |

### Return type

[**CsvUploadResponse**](CsvUploadResponse)


## PostExternalcontactsImportJobs

> [**ContactImportJobResponse**](ContactImportJobResponse) PostExternalcontactsImportJobs (ContactImportJobRequest body)


Create a new job

Requires ANY permissions: 

* externalContacts:importJob:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsImportJobsExample
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
            var body = new ContactImportJobRequest(); // ContactImportJobRequest | Job

            try
            { 
                // Create a new job
                ContactImportJobResponse result = apiInstance.PostExternalcontactsImportJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsImportJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactImportJobRequest**](ContactImportJobRequest)| Job |  |

### Return type

[**ContactImportJobResponse**](ContactImportJobResponse)


## PostExternalcontactsImportSettings

> [**ContactImportSettings**](ContactImportSettings) PostExternalcontactsImportSettings (ContactImportSettings body)


Create a new settings

Requires ANY permissions: 

* externalContacts:importSettings:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsImportSettingsExample
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
            var body = new ContactImportSettings(); // ContactImportSettings | Setting

            try
            { 
                // Create a new settings
                ContactImportSettings result = apiInstance.PostExternalcontactsImportSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsImportSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactImportSettings**](ContactImportSettings)| Setting |  |

### Return type

[**ContactImportSettings**](ContactImportSettings)


## PostExternalcontactsMergeContacts

> [**ExternalContact**](ExternalContact) PostExternalcontactsMergeContacts (MergeRequest body)


Merge two contacts into a new contact record

Two curated contacts cannot be merged. Refer to the Contact Merging article on the Developer Center for details

Requires ANY permissions: 

* externalContacts:identity:merge

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostExternalcontactsMergeContactsExample
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
            var body = new MergeRequest(); // MergeRequest | MergeRequest

            try
            { 
                // Merge two contacts into a new contact record
                ExternalContact result = apiInstance.PostExternalcontactsMergeContacts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostExternalcontactsMergeContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**MergeRequest**](MergeRequest)| MergeRequest |  |

### Return type

[**ExternalContact**](ExternalContact)


## PostExternalcontactsOrganizationNotes

> [**Note**](Note) PostExternalcontactsOrganizationNotes (string externalOrganizationId, Note body)


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
| **body** | [**Note**](Note)| ExternalContact |  |

### Return type

[**Note**](Note)


## PostExternalcontactsOrganizations

> [**ExternalOrganization**](ExternalOrganization) PostExternalcontactsOrganizations (ExternalOrganization body)


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
| **body** | [**ExternalOrganization**](ExternalOrganization)| ExternalOrganization |  |

### Return type

[**ExternalOrganization**](ExternalOrganization)


## PostExternalcontactsOrganizationsSchemas

> [**DataSchema**](DataSchema) PostExternalcontactsOrganizationsSchemas (DataSchema body)


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
| **body** | [**DataSchema**](DataSchema)| Schema |  |

### Return type

[**DataSchema**](DataSchema)


## PostExternalcontactsRelationships

> [**Relationship**](Relationship) PostExternalcontactsRelationships (Relationship body)


Create a relationship

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
| **body** | [**Relationship**](Relationship)| Relationship |  |

### Return type

[**Relationship**](Relationship)


## PutExternalcontactsContact

> [**ExternalContact**](ExternalContact) PutExternalcontactsContact (string contactId, ExternalContact body)


Update an external contact

Requires ANY permissions: 

* relate:contact:edit
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
| **body** | [**ExternalContact**](ExternalContact)| ExternalContact |  |

### Return type

[**ExternalContact**](ExternalContact)


## PutExternalcontactsContactNote

> [**Note**](Note) PutExternalcontactsContactNote (string contactId, string noteId, Note body)


Update a note for an external contact

Requires ANY permissions: 

* relate:contact:edit
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
| **body** | [**Note**](Note)| Note |  |

### Return type

[**Note**](Note)


## PutExternalcontactsContactsSchema

> [**DataSchema**](DataSchema) PutExternalcontactsContactsSchema (string schemaId, DataSchema body)


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
| **body** | [**DataSchema**](DataSchema)| Data Schema |  |

### Return type

[**DataSchema**](DataSchema)


## PutExternalcontactsConversation

> void PutExternalcontactsConversation (string conversationId, ConversationAssociation body)


Associate/disassociate an external contact with a conversation

To associate, supply a value for the externalContactId.  To disassociate, do not include the property at all.

Requires ANY permissions: 

* relate:conversation:associate
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
            var conversationId = conversationId_example;  // string | Conversation ID
            var body = new ConversationAssociation(); // ConversationAssociation | ConversationAssociation

            try
            { 
                // Associate/disassociate an external contact with a conversation
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
| **body** | [**ConversationAssociation**](ConversationAssociation)| ConversationAssociation |  |

### Return type

void (empty response body)


## PutExternalcontactsExternalsource

> [**ExternalSource**](ExternalSource) PutExternalcontactsExternalsource (string externalSourceId, ExternalSource body)


Update an External Source

Requires ANY permissions: 

* externalContacts:externalSource:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsExternalsourceExample
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
            var externalSourceId = externalSourceId_example;  // string | External Source ID
            var body = new ExternalSource(); // ExternalSource | External Source

            try
            { 
                // Update an External Source
                ExternalSource result = apiInstance.PutExternalcontactsExternalsource(externalSourceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsExternalsource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalSourceId** | **string**| External Source ID |  |
| **body** | [**ExternalSource**](ExternalSource)| External Source |  |

### Return type

[**ExternalSource**](ExternalSource)


## PutExternalcontactsImportCsvSetting

> [**CsvSettings**](CsvSettings) PutExternalcontactsImportCsvSetting (string settingsId, CsvSettings body)


Update settings for CSV import

Requires ANY permissions: 

* externalContacts:importCsvSettings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsImportCsvSettingExample
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
            var settingsId = settingsId_example;  // string | Settings id
            var body = new CsvSettings(); // CsvSettings | Settings

            try
            { 
                // Update settings for CSV import
                CsvSettings result = apiInstance.PutExternalcontactsImportCsvSetting(settingsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsImportCsvSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **settingsId** | **string**| Settings id |  |
| **body** | [**CsvSettings**](CsvSettings)| Settings |  |

### Return type

[**CsvSettings**](CsvSettings)


## PutExternalcontactsImportJob

> [**ContactImportJobStatusUpdateResponse**](ContactImportJobStatusUpdateResponse) PutExternalcontactsImportJob (string jobId, ContactImportJobStatusUpdateRequest body)


Update Job's workflow status

Requires ANY permissions: 

* externalContacts:importJob:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsImportJobExample
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
            var jobId = jobId_example;  // string | Job id
            var body = new ContactImportJobStatusUpdateRequest(); // ContactImportJobStatusUpdateRequest | Status of the Job's workflow

            try
            { 
                // Update Job's workflow status
                ContactImportJobStatusUpdateResponse result = apiInstance.PutExternalcontactsImportJob(jobId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| Job id |  |
| **body** | [**ContactImportJobStatusUpdateRequest**](ContactImportJobStatusUpdateRequest)| Status of the Job&#39;s workflow |  |

### Return type

[**ContactImportJobStatusUpdateResponse**](ContactImportJobStatusUpdateResponse)


## PutExternalcontactsImportSetting

> [**ContactImportSettings**](ContactImportSettings) PutExternalcontactsImportSetting (string settingsId, ContactImportSettings body)


Update settings

Requires ANY permissions: 

* externalContacts:importSettings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutExternalcontactsImportSettingExample
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
            var settingsId = settingsId_example;  // string | Settings id
            var body = new ContactImportSettings(); // ContactImportSettings | Setting

            try
            { 
                // Update settings
                ContactImportSettings result = apiInstance.PutExternalcontactsImportSetting(settingsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutExternalcontactsImportSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **settingsId** | **string**| Settings id |  |
| **body** | [**ContactImportSettings**](ContactImportSettings)| Setting |  |

### Return type

[**ContactImportSettings**](ContactImportSettings)


## PutExternalcontactsOrganization

> [**ExternalOrganization**](ExternalOrganization) PutExternalcontactsOrganization (string externalOrganizationId, ExternalOrganization body)


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
| **body** | [**ExternalOrganization**](ExternalOrganization)| ExternalOrganization |  |

### Return type

[**ExternalOrganization**](ExternalOrganization)


## PutExternalcontactsOrganizationNote

> [**Note**](Note) PutExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, Note body)


Update a note for an external organization

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
| **body** | [**Note**](Note)| Note |  |

### Return type

[**Note**](Note)


## PutExternalcontactsOrganizationTrustorTrustorId

> [**ExternalOrganizationTrustorLink**](ExternalOrganizationTrustorLink) PutExternalcontactsOrganizationTrustorTrustorId (string externalOrganizationId, string trustorId)


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

### Return type

[**ExternalOrganizationTrustorLink**](ExternalOrganizationTrustorLink)


## PutExternalcontactsOrganizationsSchema

> [**DataSchema**](DataSchema) PutExternalcontactsOrganizationsSchema (string schemaId, DataSchema body)


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
| **body** | [**DataSchema**](DataSchema)| Data Schema |  |

### Return type

[**DataSchema**](DataSchema)


## PutExternalcontactsRelationship

> [**Relationship**](Relationship) PutExternalcontactsRelationship (string relationshipId, Relationship body)


Update a relationship

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
| **body** | [**Relationship**](Relationship)| Relationship |  |

### Return type

[**Relationship**](Relationship)


_PureCloudPlatform.Client.V2 226.0.0_
