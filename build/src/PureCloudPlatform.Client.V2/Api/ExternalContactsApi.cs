using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExternalContactsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Object</returns>
        
        Object DeleteExternalcontactsContact (string contactId);

        /// <summary>
        /// Delete an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of Object</returns>
        
        ApiResponse<Object> DeleteExternalcontactsContactWithHttpInfo (string contactId);

        /// <summary>
        /// Delete a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Object</returns>
        
        Object DeleteExternalcontactsContactNote (string contactId, string noteId);

        /// <summary>
        /// Delete a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object</returns>
        
        ApiResponse<Object> DeleteExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId);

        /// <summary>
        /// Delete a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns></returns>
        
        void DeleteExternalcontactsContactsSchema (string schemaId);

        /// <summary>
        /// Delete a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteExternalcontactsContactsSchemaWithHttpInfo (string schemaId);

        /// <summary>
        /// Delete an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Object</returns>
        
        Object DeleteExternalcontactsOrganization (string externalOrganizationId);

        /// <summary>
        /// Delete an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ApiResponse of Object</returns>
        
        ApiResponse<Object> DeleteExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId);

        /// <summary>
        /// Delete a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Object</returns>
        
        Object DeleteExternalcontactsOrganizationNote (string externalOrganizationId, string noteId);

        /// <summary>
        /// Delete a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object</returns>
        
        ApiResponse<Object> DeleteExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId);

        /// <summary>
        /// Unlink the Trustor for this External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns></returns>
        
        void DeleteExternalcontactsOrganizationTrustor (string externalOrganizationId);

        /// <summary>
        /// Unlink the Trustor for this External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteExternalcontactsOrganizationTrustorWithHttpInfo (string externalOrganizationId);

        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Object</returns>
        
        Object DeleteExternalcontactsRelationship (string relationshipId);

        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>ApiResponse of Object</returns>
        
        ApiResponse<Object> DeleteExternalcontactsRelationshipWithHttpInfo (string relationshipId);

        /// <summary>
        /// Fetch an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>ExternalContact</returns>
        
        ExternalContact GetExternalcontactsContact (string contactId, List<string> expand = null);

        /// <summary>
        /// Fetch an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        ApiResponse<ExternalContact> GetExternalcontactsContactWithHttpInfo (string contactId, List<string> expand = null);

        /// <summary>
        /// List the identifiers for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>EntityListing</returns>
        
        EntityListing GetExternalcontactsContactIdentifiers (string contactId);

        /// <summary>
        /// List the identifiers for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of EntityListing</returns>
        
        ApiResponse<EntityListing> GetExternalcontactsContactIdentifiersWithHttpInfo (string contactId);

        /// <summary>
        /// Retrieve all sessions for a given external contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>SessionListing</returns>
        
        SessionListing GetExternalcontactsContactJourneySessions (string contactId, string pageSize = null, string after = null, bool? includeMerged = null);

        /// <summary>
        /// Retrieve all sessions for a given external contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>ApiResponse of SessionListing</returns>
        
        ApiResponse<SessionListing> GetExternalcontactsContactJourneySessionsWithHttpInfo (string contactId, string pageSize = null, string after = null, bool? includeMerged = null);

        /// <summary>
        /// Fetch a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Note</returns>
        
        Note GetExternalcontactsContactNote (string contactId, string noteId, List<string> expand = null);

        /// <summary>
        /// Fetch a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        
        ApiResponse<Note> GetExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId, List<string> expand = null);

        /// <summary>
        /// List notes for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>NoteListing</returns>
        
        NoteListing GetExternalcontactsContactNotes (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// List notes for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of NoteListing</returns>
        
        ApiResponse<NoteListing> GetExternalcontactsContactNotesWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Fetch an unresolved external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>ExternalContact</returns>
        
        ExternalContact GetExternalcontactsContactUnresolved (string contactId, List<string> expand = null);

        /// <summary>
        /// Fetch an unresolved external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        ApiResponse<ExternalContact> GetExternalcontactsContactUnresolvedWithHttpInfo (string contactId, List<string> expand = null);

        /// <summary>
        /// Search for external contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ContactListing</returns>
        
        ContactListing GetExternalcontactsContacts (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Search for external contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of ContactListing</returns>
        
        ApiResponse<ContactListing> GetExternalcontactsContactsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        DataSchema GetExternalcontactsContactsSchema (string schemaId);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> GetExternalcontactsContactsSchemaWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>DataSchema</returns>
        
        DataSchema GetExternalcontactsContactsSchemaVersion (string schemaId, string versionId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> GetExternalcontactsContactsSchemaVersionWithHttpInfo (string schemaId, string versionId);

        /// <summary>
        /// Get all versions of an external contact's schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        DataSchema GetExternalcontactsContactsSchemaVersions (string schemaId);

        /// <summary>
        /// Get all versions of an external contact's schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> GetExternalcontactsContactsSchemaVersionsWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DataSchemaListing</returns>
        
        DataSchemaListing GetExternalcontactsContactsSchemas ();

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DataSchemaListing</returns>
        
        ApiResponse<DataSchemaListing> GetExternalcontactsContactsSchemasWithHttpInfo ();

        /// <summary>
        /// Fetch an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="expand">which fields, if any, to expand (externalDataSources) (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>ExternalOrganization</returns>
        
        ExternalOrganization GetExternalcontactsOrganization (string externalOrganizationId, string expand = null, bool? includeTrustors = null);

        /// <summary>
        /// Fetch an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="expand">which fields, if any, to expand (externalDataSources) (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        
        ApiResponse<ExternalOrganization> GetExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId, string expand = null, bool? includeTrustors = null);

        /// <summary>
        /// Search for external contacts in an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ContactListing</returns>
        
        ContactListing GetExternalcontactsOrganizationContacts (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Search for external contacts in an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of ContactListing</returns>
        
        ApiResponse<ContactListing> GetExternalcontactsOrganizationContactsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Fetch a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Note</returns>
        
        Note GetExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, List<string> expand = null);

        /// <summary>
        /// Fetch a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        
        ApiResponse<Note> GetExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId, List<string> expand = null);

        /// <summary>
        /// List notes for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>NoteListing</returns>
        
        NoteListing GetExternalcontactsOrganizationNotes (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// List notes for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of NoteListing</returns>
        
        ApiResponse<NoteListing> GetExternalcontactsOrganizationNotesWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Fetch a relationship for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>RelationshipListing</returns>
        
        RelationshipListing GetExternalcontactsOrganizationRelationships (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string expand = null, string sortOrder = null);

        /// <summary>
        /// Fetch a relationship for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>ApiResponse of RelationshipListing</returns>
        
        ApiResponse<RelationshipListing> GetExternalcontactsOrganizationRelationshipsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string expand = null, string sortOrder = null);

        /// <summary>
        /// Search for external organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">Search query (optional)</param>
        /// <param name="trustorId">Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>ExternalOrganizationListing</returns>
        
        ExternalOrganizationListing GetExternalcontactsOrganizations (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null);

        /// <summary>
        /// Search for external organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">Search query (optional)</param>
        /// <param name="trustorId">Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>ApiResponse of ExternalOrganizationListing</returns>
        
        ApiResponse<ExternalOrganizationListing> GetExternalcontactsOrganizationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        DataSchema GetExternalcontactsOrganizationsSchema (string schemaId);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> GetExternalcontactsOrganizationsSchemaWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>DataSchema</returns>
        
        DataSchema GetExternalcontactsOrganizationsSchemaVersion (string schemaId, string versionId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> GetExternalcontactsOrganizationsSchemaVersionWithHttpInfo (string schemaId, string versionId);

        /// <summary>
        /// Get all versions of an external organization's schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        DataSchema GetExternalcontactsOrganizationsSchemaVersions (string schemaId);

        /// <summary>
        /// Get all versions of an external organization's schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> GetExternalcontactsOrganizationsSchemaVersionsWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DataSchemaListing</returns>
        
        DataSchemaListing GetExternalcontactsOrganizationsSchemas ();

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DataSchemaListing</returns>
        
        ApiResponse<DataSchemaListing> GetExternalcontactsOrganizationsSchemasWithHttpInfo ();

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Relationship</returns>
        
        Relationship GetExternalcontactsRelationship (string relationshipId, string expand = null);

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of Relationship</returns>
        
        ApiResponse<Relationship> GetExternalcontactsRelationshipWithHttpInfo (string relationshipId, string expand = null);

        /// <summary>
        /// Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lookupVal">User supplied value to lookup contacts/externalOrganizations (supports email addresses, e164 phone numbers, Twitter screen names)</param>
        /// <param name="expand">which field, if any, to expand (optional)</param>
        /// <returns>ReverseWhitepagesLookupResult</returns>
        
        ReverseWhitepagesLookupResult GetExternalcontactsReversewhitepageslookup (string lookupVal, List<string> expand = null);

        /// <summary>
        /// Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lookupVal">User supplied value to lookup contacts/externalOrganizations (supports email addresses, e164 phone numbers, Twitter screen names)</param>
        /// <param name="expand">which field, if any, to expand (optional)</param>
        /// <returns>ApiResponse of ReverseWhitepagesLookupResult</returns>
        
        ApiResponse<ReverseWhitepagesLookupResult> GetExternalcontactsReversewhitepageslookupWithHttpInfo (string lookupVal, List<string> expand = null);

        /// <summary>
        /// Scan for external contacts using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of contacts per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>CursorContactListing</returns>
        
        CursorContactListing GetExternalcontactsScanContacts (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for external contacts using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of contacts per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>ApiResponse of CursorContactListing</returns>
        
        ApiResponse<CursorContactListing> GetExternalcontactsScanContactsWithHttpInfo (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for notes using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of notes per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>CursorNoteListing</returns>
        
        CursorNoteListing GetExternalcontactsScanNotes (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for notes using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of notes per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>ApiResponse of CursorNoteListing</returns>
        
        ApiResponse<CursorNoteListing> GetExternalcontactsScanNotesWithHttpInfo (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for external organizations using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of organizations per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>CursorOrganizationListing</returns>
        
        CursorOrganizationListing GetExternalcontactsScanOrganizations (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for external organizations using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of organizations per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>ApiResponse of CursorOrganizationListing</returns>
        
        ApiResponse<CursorOrganizationListing> GetExternalcontactsScanOrganizationsWithHttpInfo (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of relationships per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>CursorRelationshipListing</returns>
        
        CursorRelationshipListing GetExternalcontactsScanRelationships (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of relationships per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>ApiResponse of CursorRelationshipListing</returns>
        
        ApiResponse<CursorRelationshipListing> GetExternalcontactsScanRelationshipsWithHttpInfo (int? limit = null, string cursor = null);

        /// <summary>
        /// Claim or release identifiers for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ClaimRequest</param>
        /// <returns>ContactIdentifier</returns>
        
        ContactIdentifier PatchExternalcontactsContactIdentifiers (string contactId, IdentifierClaimRequest body);

        /// <summary>
        /// Claim or release identifiers for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ClaimRequest</param>
        /// <returns>ApiResponse of ContactIdentifier</returns>
        
        ApiResponse<ContactIdentifier> PatchExternalcontactsContactIdentifiersWithHttpInfo (string contactId, IdentifierClaimRequest body);

        /// <summary>
        /// Bulk fetch contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>BulkFetchContactsResponse</returns>
        
        BulkFetchContactsResponse PostExternalcontactsBulkContacts (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>ApiResponse of BulkFetchContactsResponse</returns>
        
        ApiResponse<BulkFetchContactsResponse> PostExternalcontactsBulkContactsWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk add contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>BulkContactsResponse</returns>
        
        BulkContactsResponse PostExternalcontactsBulkContactsAdd (BulkContactsRequest body);

        /// <summary>
        /// Bulk add contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>ApiResponse of BulkContactsResponse</returns>
        
        ApiResponse<BulkContactsResponse> PostExternalcontactsBulkContactsAddWithHttpInfo (BulkContactsRequest body);

        /// <summary>
        /// Bulk remove contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>BulkDeleteResponse</returns>
        
        BulkDeleteResponse PostExternalcontactsBulkContactsRemove (BulkIdsRequest body);

        /// <summary>
        /// Bulk remove contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>ApiResponse of BulkDeleteResponse</returns>
        
        ApiResponse<BulkDeleteResponse> PostExternalcontactsBulkContactsRemoveWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch unresolved ancestor contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>BulkFetchContactsResponse</returns>
        
        BulkFetchContactsResponse PostExternalcontactsBulkContactsUnresolved (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch unresolved ancestor contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>ApiResponse of BulkFetchContactsResponse</returns>
        
        ApiResponse<BulkFetchContactsResponse> PostExternalcontactsBulkContactsUnresolvedWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk update contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>BulkContactsResponse</returns>
        
        BulkContactsResponse PostExternalcontactsBulkContactsUpdate (BulkContactsRequest body);

        /// <summary>
        /// Bulk update contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>ApiResponse of BulkContactsResponse</returns>
        
        ApiResponse<BulkContactsResponse> PostExternalcontactsBulkContactsUpdateWithHttpInfo (BulkContactsRequest body);

        /// <summary>
        /// Bulk fetch notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>BulkFetchNotesResponse</returns>
        
        BulkFetchNotesResponse PostExternalcontactsBulkNotes (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>ApiResponse of BulkFetchNotesResponse</returns>
        
        ApiResponse<BulkFetchNotesResponse> PostExternalcontactsBulkNotesWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk add notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>BulkNotesResponse</returns>
        
        BulkNotesResponse PostExternalcontactsBulkNotesAdd (BulkNotesRequest body);

        /// <summary>
        /// Bulk add notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>ApiResponse of BulkNotesResponse</returns>
        
        ApiResponse<BulkNotesResponse> PostExternalcontactsBulkNotesAddWithHttpInfo (BulkNotesRequest body);

        /// <summary>
        /// Bulk remove notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>BulkDeleteResponse</returns>
        
        BulkDeleteResponse PostExternalcontactsBulkNotesRemove (BulkIdsRequest body);

        /// <summary>
        /// Bulk remove notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>ApiResponse of BulkDeleteResponse</returns>
        
        ApiResponse<BulkDeleteResponse> PostExternalcontactsBulkNotesRemoveWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk update notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>BulkNotesResponse</returns>
        
        BulkNotesResponse PostExternalcontactsBulkNotesUpdate (BulkNotesRequest body);

        /// <summary>
        /// Bulk update notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>ApiResponse of BulkNotesResponse</returns>
        
        ApiResponse<BulkNotesResponse> PostExternalcontactsBulkNotesUpdateWithHttpInfo (BulkNotesRequest body);

        /// <summary>
        /// Bulk fetch organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations ids</param>
        /// <returns>BulkFetchOrganizationsResponse</returns>
        
        BulkFetchOrganizationsResponse PostExternalcontactsBulkOrganizations (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations ids</param>
        /// <returns>ApiResponse of BulkFetchOrganizationsResponse</returns>
        
        ApiResponse<BulkFetchOrganizationsResponse> PostExternalcontactsBulkOrganizationsWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk add organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>BulkOrganizationsResponse</returns>
        
        BulkOrganizationsResponse PostExternalcontactsBulkOrganizationsAdd (BulkOrganizationsRequest body);

        /// <summary>
        /// Bulk add organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>ApiResponse of BulkOrganizationsResponse</returns>
        
        ApiResponse<BulkOrganizationsResponse> PostExternalcontactsBulkOrganizationsAddWithHttpInfo (BulkOrganizationsRequest body);

        /// <summary>
        /// Bulk remove organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization ids</param>
        /// <returns>BulkDeleteResponse</returns>
        
        BulkDeleteResponse PostExternalcontactsBulkOrganizationsRemove (BulkIdsRequest body);

        /// <summary>
        /// Bulk remove organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization ids</param>
        /// <returns>ApiResponse of BulkDeleteResponse</returns>
        
        ApiResponse<BulkDeleteResponse> PostExternalcontactsBulkOrganizationsRemoveWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk update organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>BulkOrganizationsResponse</returns>
        
        BulkOrganizationsResponse PostExternalcontactsBulkOrganizationsUpdate (BulkOrganizationsRequest body);

        /// <summary>
        /// Bulk update organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>ApiResponse of BulkOrganizationsResponse</returns>
        
        ApiResponse<BulkOrganizationsResponse> PostExternalcontactsBulkOrganizationsUpdateWithHttpInfo (BulkOrganizationsRequest body);

        /// <summary>
        /// Bulk fetch relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>BulkFetchRelationshipsResponse</returns>
        
        BulkFetchRelationshipsResponse PostExternalcontactsBulkRelationships (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>ApiResponse of BulkFetchRelationshipsResponse</returns>
        
        ApiResponse<BulkFetchRelationshipsResponse> PostExternalcontactsBulkRelationshipsWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk add relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>BulkRelationshipsResponse</returns>
        
        BulkRelationshipsResponse PostExternalcontactsBulkRelationshipsAdd (BulkRelationshipsRequest body);

        /// <summary>
        /// Bulk add relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>ApiResponse of BulkRelationshipsResponse</returns>
        
        ApiResponse<BulkRelationshipsResponse> PostExternalcontactsBulkRelationshipsAddWithHttpInfo (BulkRelationshipsRequest body);

        /// <summary>
        /// Bulk remove relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>BulkDeleteResponse</returns>
        
        BulkDeleteResponse PostExternalcontactsBulkRelationshipsRemove (BulkIdsRequest body);

        /// <summary>
        /// Bulk remove relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>ApiResponse of BulkDeleteResponse</returns>
        
        ApiResponse<BulkDeleteResponse> PostExternalcontactsBulkRelationshipsRemoveWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk update relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>BulkRelationshipsResponse</returns>
        
        BulkRelationshipsResponse PostExternalcontactsBulkRelationshipsUpdate (BulkRelationshipsRequest body);

        /// <summary>
        /// Bulk update relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>ApiResponse of BulkRelationshipsResponse</returns>
        
        ApiResponse<BulkRelationshipsResponse> PostExternalcontactsBulkRelationshipsUpdateWithHttpInfo (BulkRelationshipsRequest body);

        /// <summary>
        /// Create a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Note</returns>
        
        Note PostExternalcontactsContactNotes (string contactId, Note body);

        /// <summary>
        /// Create a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of Note</returns>
        
        ApiResponse<Note> PostExternalcontactsContactNotesWithHttpInfo (string contactId, Note body);

        /// <summary>
        /// Promote an observed contact (ephemeral or identified) to a curated contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ExternalContact</returns>
        
        ExternalContact PostExternalcontactsContactPromotion (string contactId);

        /// <summary>
        /// Promote an observed contact (ephemeral or identified) to a curated contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        ApiResponse<ExternalContact> PostExternalcontactsContactPromotionWithHttpInfo (string contactId);

        /// <summary>
        /// Create an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact</param>
        /// <returns>ExternalContact</returns>
        
        ExternalContact PostExternalcontactsContacts (ExternalContact body);

        /// <summary>
        /// Create an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        ApiResponse<ExternalContact> PostExternalcontactsContactsWithHttpInfo (ExternalContact body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>DataSchema</returns>
        
        DataSchema PostExternalcontactsContactsSchemas (DataSchema body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> PostExternalcontactsContactsSchemasWithHttpInfo (DataSchema body);

        /// <summary>
        /// Fetch a contact using an identifier type and value.
        /// </summary>
        /// <remarks>
        /// Phone number identifier values must be provided with the country code and a leading '+' symbol. Example: \"+1 704 298 4733\"
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier"></param>
        /// <returns>ExternalContact</returns>
        
        ExternalContact PostExternalcontactsIdentifierlookup (ContactIdentifier identifier);

        /// <summary>
        /// Fetch a contact using an identifier type and value.
        /// </summary>
        /// <remarks>
        /// Phone number identifier values must be provided with the country code and a leading '+' symbol. Example: \"+1 704 298 4733\"
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier"></param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        ApiResponse<ExternalContact> PostExternalcontactsIdentifierlookupWithHttpInfo (ContactIdentifier identifier);

        /// <summary>
        /// Merge two contacts into a new contact record
        /// </summary>
        /// <remarks>
        /// Two curated contacts cannot be merged. Refer to the Contact Merging article on the Developer Center for details
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MergeRequest</param>
        /// <returns>ExternalContact</returns>
        
        ExternalContact PostExternalcontactsMergeContacts (MergeRequest body);

        /// <summary>
        /// Merge two contacts into a new contact record
        /// </summary>
        /// <remarks>
        /// Two curated contacts cannot be merged. Refer to the Contact Merging article on the Developer Center for details
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MergeRequest</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        ApiResponse<ExternalContact> PostExternalcontactsMergeContactsWithHttpInfo (MergeRequest body);

        /// <summary>
        /// Create a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Note</returns>
        
        Note PostExternalcontactsOrganizationNotes (string externalOrganizationId, Note body);

        /// <summary>
        /// Create a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of Note</returns>
        
        ApiResponse<Note> PostExternalcontactsOrganizationNotesWithHttpInfo (string externalOrganizationId, Note body);

        /// <summary>
        /// Create an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ExternalOrganization</returns>
        
        ExternalOrganization PostExternalcontactsOrganizations (ExternalOrganization body);

        /// <summary>
        /// Create an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        
        ApiResponse<ExternalOrganization> PostExternalcontactsOrganizationsWithHttpInfo (ExternalOrganization body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>DataSchema</returns>
        
        DataSchema PostExternalcontactsOrganizationsSchemas (DataSchema body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> PostExternalcontactsOrganizationsSchemasWithHttpInfo (DataSchema body);

        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship</param>
        /// <returns>Relationship</returns>
        
        Relationship PostExternalcontactsRelationships (Relationship body);

        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship</param>
        /// <returns>ApiResponse of Relationship</returns>
        
        ApiResponse<Relationship> PostExternalcontactsRelationshipsWithHttpInfo (Relationship body);

        /// <summary>
        /// Update an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ExternalContact</returns>
        
        ExternalContact PutExternalcontactsContact (string contactId, ExternalContact body);

        /// <summary>
        /// Update an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        ApiResponse<ExternalContact> PutExternalcontactsContactWithHttpInfo (string contactId, ExternalContact body);

        /// <summary>
        /// Update a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Note</returns>
        
        Note PutExternalcontactsContactNote (string contactId, string noteId, Note body);

        /// <summary>
        /// Update a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>ApiResponse of Note</returns>
        
        ApiResponse<Note> PutExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId, Note body);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>DataSchema</returns>
        
        DataSchema PutExternalcontactsContactsSchema (string schemaId, DataSchema body);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> PutExternalcontactsContactsSchemaWithHttpInfo (string schemaId, DataSchema body);

        /// <summary>
        /// Associate/disassociate an external contact with a conversation
        /// </summary>
        /// <remarks>
        /// To associate, supply a value for the externalContactId.  To disassociate, do not include the property at all.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation</param>
        /// <returns></returns>
        
        void PutExternalcontactsConversation (string conversationId, ConversationAssociation body);

        /// <summary>
        /// Associate/disassociate an external contact with a conversation
        /// </summary>
        /// <remarks>
        /// To associate, supply a value for the externalContactId.  To disassociate, do not include the property at all.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PutExternalcontactsConversationWithHttpInfo (string conversationId, ConversationAssociation body);

        /// <summary>
        /// Update an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ExternalOrganization</returns>
        
        ExternalOrganization PutExternalcontactsOrganization (string externalOrganizationId, ExternalOrganization body);

        /// <summary>
        /// Update an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        
        ApiResponse<ExternalOrganization> PutExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId, ExternalOrganization body);

        /// <summary>
        /// Update a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Note</returns>
        
        Note PutExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, Note body);

        /// <summary>
        /// Update a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>ApiResponse of Note</returns>
        
        ApiResponse<Note> PutExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId, Note body);

        /// <summary>
        /// Links a Trustor with an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>ExternalOrganizationTrustorLink</returns>
        
        ExternalOrganizationTrustorLink PutExternalcontactsOrganizationTrustorTrustorId (string externalOrganizationId, string trustorId);

        /// <summary>
        /// Links a Trustor with an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>ApiResponse of ExternalOrganizationTrustorLink</returns>
        
        ApiResponse<ExternalOrganizationTrustorLink> PutExternalcontactsOrganizationTrustorTrustorIdWithHttpInfo (string externalOrganizationId, string trustorId);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>DataSchema</returns>
        
        DataSchema PutExternalcontactsOrganizationsSchema (string schemaId, DataSchema body);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        ApiResponse<DataSchema> PutExternalcontactsOrganizationsSchemaWithHttpInfo (string schemaId, DataSchema body);

        /// <summary>
        /// Update a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Relationship</returns>
        
        Relationship PutExternalcontactsRelationship (string relationshipId, Relationship body);

        /// <summary>
        /// Update a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>ApiResponse of Relationship</returns>
        
        ApiResponse<Relationship> PutExternalcontactsRelationshipWithHttpInfo (string relationshipId, Relationship body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of Object</returns>
        
        System.Threading.Tasks.Task<Object> DeleteExternalcontactsContactAsync (string contactId);

        /// <summary>
        /// Delete an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactAsyncWithHttpInfo (string contactId);

        /// <summary>
        /// Delete a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of Object</returns>
        
        System.Threading.Tasks.Task<Object> DeleteExternalcontactsContactNoteAsync (string contactId, string noteId);

        /// <summary>
        /// Delete a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId);

        /// <summary>
        /// Delete a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteExternalcontactsContactsSchemaAsync (string schemaId);

        /// <summary>
        /// Delete a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactsSchemaAsyncWithHttpInfo (string schemaId);

        /// <summary>
        /// Delete an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of Object</returns>
        
        System.Threading.Tasks.Task<Object> DeleteExternalcontactsOrganizationAsync (string externalOrganizationId);

        /// <summary>
        /// Delete an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId);

        /// <summary>
        /// Delete a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of Object</returns>
        
        System.Threading.Tasks.Task<Object> DeleteExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId);

        /// <summary>
        /// Delete a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId);

        /// <summary>
        /// Unlink the Trustor for this External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteExternalcontactsOrganizationTrustorAsync (string externalOrganizationId);

        /// <summary>
        /// Unlink the Trustor for this External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsOrganizationTrustorAsyncWithHttpInfo (string externalOrganizationId);

        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of Object</returns>
        
        System.Threading.Tasks.Task<Object> DeleteExternalcontactsRelationshipAsync (string relationshipId);

        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId);

        /// <summary>
        /// Fetch an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>Task of ExternalContact</returns>
        
        System.Threading.Tasks.Task<ExternalContact> GetExternalcontactsContactAsync (string contactId, List<string> expand = null);

        /// <summary>
        /// Fetch an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> GetExternalcontactsContactAsyncWithHttpInfo (string contactId, List<string> expand = null);

        /// <summary>
        /// List the identifiers for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of EntityListing</returns>
        
        System.Threading.Tasks.Task<EntityListing> GetExternalcontactsContactIdentifiersAsync (string contactId);

        /// <summary>
        /// List the identifiers for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse (EntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EntityListing>> GetExternalcontactsContactIdentifiersAsyncWithHttpInfo (string contactId);

        /// <summary>
        /// Retrieve all sessions for a given external contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>Task of SessionListing</returns>
        
        System.Threading.Tasks.Task<SessionListing> GetExternalcontactsContactJourneySessionsAsync (string contactId, string pageSize = null, string after = null, bool? includeMerged = null);

        /// <summary>
        /// Retrieve all sessions for a given external contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>Task of ApiResponse (SessionListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SessionListing>> GetExternalcontactsContactJourneySessionsAsyncWithHttpInfo (string contactId, string pageSize = null, string after = null, bool? includeMerged = null);

        /// <summary>
        /// Fetch a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of Note</returns>
        
        System.Threading.Tasks.Task<Note> GetExternalcontactsContactNoteAsync (string contactId, string noteId, List<string> expand = null);

        /// <summary>
        /// Fetch a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Note>> GetExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId, List<string> expand = null);

        /// <summary>
        /// List notes for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of NoteListing</returns>
        
        System.Threading.Tasks.Task<NoteListing> GetExternalcontactsContactNotesAsync (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// List notes for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (NoteListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Fetch an unresolved external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>Task of ExternalContact</returns>
        
        System.Threading.Tasks.Task<ExternalContact> GetExternalcontactsContactUnresolvedAsync (string contactId, List<string> expand = null);

        /// <summary>
        /// Fetch an unresolved external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> GetExternalcontactsContactUnresolvedAsyncWithHttpInfo (string contactId, List<string> expand = null);

        /// <summary>
        /// Search for external contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ContactListing</returns>
        
        System.Threading.Tasks.Task<ContactListing> GetExternalcontactsContactsAsync (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Search for external contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (ContactListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetExternalcontactsContactsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> GetExternalcontactsContactsSchemaAsync (string schemaId);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsContactsSchemaAsyncWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> GetExternalcontactsContactsSchemaVersionAsync (string schemaId, string versionId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsContactsSchemaVersionAsyncWithHttpInfo (string schemaId, string versionId);

        /// <summary>
        /// Get all versions of an external contact's schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> GetExternalcontactsContactsSchemaVersionsAsync (string schemaId);

        /// <summary>
        /// Get all versions of an external contact's schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsContactsSchemaVersionsAsyncWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DataSchemaListing</returns>
        
        System.Threading.Tasks.Task<DataSchemaListing> GetExternalcontactsContactsSchemasAsync ();

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DataSchemaListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchemaListing>> GetExternalcontactsContactsSchemasAsyncWithHttpInfo ();

        /// <summary>
        /// Fetch an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="expand">which fields, if any, to expand (externalDataSources) (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>Task of ExternalOrganization</returns>
        
        System.Threading.Tasks.Task<ExternalOrganization> GetExternalcontactsOrganizationAsync (string externalOrganizationId, string expand = null, bool? includeTrustors = null);

        /// <summary>
        /// Fetch an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="expand">which fields, if any, to expand (externalDataSources) (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> GetExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId, string expand = null, bool? includeTrustors = null);

        /// <summary>
        /// Search for external contacts in an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ContactListing</returns>
        
        System.Threading.Tasks.Task<ContactListing> GetExternalcontactsOrganizationContactsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Search for external contacts in an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (ContactListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetExternalcontactsOrganizationContactsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Fetch a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of Note</returns>
        
        System.Threading.Tasks.Task<Note> GetExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId, List<string> expand = null);

        /// <summary>
        /// Fetch a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Note>> GetExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId, List<string> expand = null);

        /// <summary>
        /// List notes for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of NoteListing</returns>
        
        System.Threading.Tasks.Task<NoteListing> GetExternalcontactsOrganizationNotesAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// List notes for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (NoteListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetExternalcontactsOrganizationNotesAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);

        /// <summary>
        /// Fetch a relationship for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of RelationshipListing</returns>
        
        System.Threading.Tasks.Task<RelationshipListing> GetExternalcontactsOrganizationRelationshipsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string expand = null, string sortOrder = null);

        /// <summary>
        /// Fetch a relationship for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of ApiResponse (RelationshipListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<RelationshipListing>> GetExternalcontactsOrganizationRelationshipsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string expand = null, string sortOrder = null);

        /// <summary>
        /// Search for external organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">Search query (optional)</param>
        /// <param name="trustorId">Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>Task of ExternalOrganizationListing</returns>
        
        System.Threading.Tasks.Task<ExternalOrganizationListing> GetExternalcontactsOrganizationsAsync (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null);

        /// <summary>
        /// Search for external organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">Search query (optional)</param>
        /// <param name="trustorId">Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>Task of ApiResponse (ExternalOrganizationListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganizationListing>> GetExternalcontactsOrganizationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> GetExternalcontactsOrganizationsSchemaAsync (string schemaId);

        /// <summary>
        /// Get a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsOrganizationsSchemaAsyncWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> GetExternalcontactsOrganizationsSchemaVersionAsync (string schemaId, string versionId);

        /// <summary>
        /// Get a specific version of a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsOrganizationsSchemaVersionAsyncWithHttpInfo (string schemaId, string versionId);

        /// <summary>
        /// Get all versions of an external organization's schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> GetExternalcontactsOrganizationsSchemaVersionsAsync (string schemaId);

        /// <summary>
        /// Get all versions of an external organization's schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsOrganizationsSchemaVersionsAsyncWithHttpInfo (string schemaId);

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DataSchemaListing</returns>
        
        System.Threading.Tasks.Task<DataSchemaListing> GetExternalcontactsOrganizationsSchemasAsync ();

        /// <summary>
        /// Get a list of schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DataSchemaListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchemaListing>> GetExternalcontactsOrganizationsSchemasAsyncWithHttpInfo ();

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of Relationship</returns>
        
        System.Threading.Tasks.Task<Relationship> GetExternalcontactsRelationshipAsync (string relationshipId, string expand = null);

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Relationship>> GetExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId, string expand = null);

        /// <summary>
        /// Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lookupVal">User supplied value to lookup contacts/externalOrganizations (supports email addresses, e164 phone numbers, Twitter screen names)</param>
        /// <param name="expand">which field, if any, to expand (optional)</param>
        /// <returns>Task of ReverseWhitepagesLookupResult</returns>
        
        System.Threading.Tasks.Task<ReverseWhitepagesLookupResult> GetExternalcontactsReversewhitepageslookupAsync (string lookupVal, List<string> expand = null);

        /// <summary>
        /// Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lookupVal">User supplied value to lookup contacts/externalOrganizations (supports email addresses, e164 phone numbers, Twitter screen names)</param>
        /// <param name="expand">which field, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (ReverseWhitepagesLookupResult)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ReverseWhitepagesLookupResult>> GetExternalcontactsReversewhitepageslookupAsyncWithHttpInfo (string lookupVal, List<string> expand = null);

        /// <summary>
        /// Scan for external contacts using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of contacts per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of CursorContactListing</returns>
        
        System.Threading.Tasks.Task<CursorContactListing> GetExternalcontactsScanContactsAsync (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for external contacts using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of contacts per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of ApiResponse (CursorContactListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CursorContactListing>> GetExternalcontactsScanContactsAsyncWithHttpInfo (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for notes using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of notes per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of CursorNoteListing</returns>
        
        System.Threading.Tasks.Task<CursorNoteListing> GetExternalcontactsScanNotesAsync (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for notes using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of notes per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of ApiResponse (CursorNoteListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CursorNoteListing>> GetExternalcontactsScanNotesAsyncWithHttpInfo (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for external organizations using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of organizations per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of CursorOrganizationListing</returns>
        
        System.Threading.Tasks.Task<CursorOrganizationListing> GetExternalcontactsScanOrganizationsAsync (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for external organizations using paging
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of organizations per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of ApiResponse (CursorOrganizationListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CursorOrganizationListing>> GetExternalcontactsScanOrganizationsAsyncWithHttpInfo (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of relationships per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of CursorRelationshipListing</returns>
        
        System.Threading.Tasks.Task<CursorRelationshipListing> GetExternalcontactsScanRelationshipsAsync (int? limit = null, string cursor = null);

        /// <summary>
        /// Scan for relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of relationships per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of ApiResponse (CursorRelationshipListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CursorRelationshipListing>> GetExternalcontactsScanRelationshipsAsyncWithHttpInfo (int? limit = null, string cursor = null);

        /// <summary>
        /// Claim or release identifiers for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ClaimRequest</param>
        /// <returns>Task of ContactIdentifier</returns>
        
        System.Threading.Tasks.Task<ContactIdentifier> PatchExternalcontactsContactIdentifiersAsync (string contactId, IdentifierClaimRequest body);

        /// <summary>
        /// Claim or release identifiers for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ClaimRequest</param>
        /// <returns>Task of ApiResponse (ContactIdentifier)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ContactIdentifier>> PatchExternalcontactsContactIdentifiersAsyncWithHttpInfo (string contactId, IdentifierClaimRequest body);

        /// <summary>
        /// Bulk fetch contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of BulkFetchContactsResponse</returns>
        
        System.Threading.Tasks.Task<BulkFetchContactsResponse> PostExternalcontactsBulkContactsAsync (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of ApiResponse (BulkFetchContactsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkFetchContactsResponse>> PostExternalcontactsBulkContactsAsyncWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk add contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>Task of BulkContactsResponse</returns>
        
        System.Threading.Tasks.Task<BulkContactsResponse> PostExternalcontactsBulkContactsAddAsync (BulkContactsRequest body);

        /// <summary>
        /// Bulk add contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>Task of ApiResponse (BulkContactsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkContactsResponse>> PostExternalcontactsBulkContactsAddAsyncWithHttpInfo (BulkContactsRequest body);

        /// <summary>
        /// Bulk remove contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of BulkDeleteResponse</returns>
        
        System.Threading.Tasks.Task<BulkDeleteResponse> PostExternalcontactsBulkContactsRemoveAsync (BulkIdsRequest body);

        /// <summary>
        /// Bulk remove contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of ApiResponse (BulkDeleteResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkDeleteResponse>> PostExternalcontactsBulkContactsRemoveAsyncWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch unresolved ancestor contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of BulkFetchContactsResponse</returns>
        
        System.Threading.Tasks.Task<BulkFetchContactsResponse> PostExternalcontactsBulkContactsUnresolvedAsync (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch unresolved ancestor contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of ApiResponse (BulkFetchContactsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkFetchContactsResponse>> PostExternalcontactsBulkContactsUnresolvedAsyncWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk update contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>Task of BulkContactsResponse</returns>
        
        System.Threading.Tasks.Task<BulkContactsResponse> PostExternalcontactsBulkContactsUpdateAsync (BulkContactsRequest body);

        /// <summary>
        /// Bulk update contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>Task of ApiResponse (BulkContactsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkContactsResponse>> PostExternalcontactsBulkContactsUpdateAsyncWithHttpInfo (BulkContactsRequest body);

        /// <summary>
        /// Bulk fetch notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>Task of BulkFetchNotesResponse</returns>
        
        System.Threading.Tasks.Task<BulkFetchNotesResponse> PostExternalcontactsBulkNotesAsync (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>Task of ApiResponse (BulkFetchNotesResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkFetchNotesResponse>> PostExternalcontactsBulkNotesAsyncWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk add notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>Task of BulkNotesResponse</returns>
        
        System.Threading.Tasks.Task<BulkNotesResponse> PostExternalcontactsBulkNotesAddAsync (BulkNotesRequest body);

        /// <summary>
        /// Bulk add notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>Task of ApiResponse (BulkNotesResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkNotesResponse>> PostExternalcontactsBulkNotesAddAsyncWithHttpInfo (BulkNotesRequest body);

        /// <summary>
        /// Bulk remove notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>Task of BulkDeleteResponse</returns>
        
        System.Threading.Tasks.Task<BulkDeleteResponse> PostExternalcontactsBulkNotesRemoveAsync (BulkIdsRequest body);

        /// <summary>
        /// Bulk remove notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>Task of ApiResponse (BulkDeleteResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkDeleteResponse>> PostExternalcontactsBulkNotesRemoveAsyncWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk update notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>Task of BulkNotesResponse</returns>
        
        System.Threading.Tasks.Task<BulkNotesResponse> PostExternalcontactsBulkNotesUpdateAsync (BulkNotesRequest body);

        /// <summary>
        /// Bulk update notes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>Task of ApiResponse (BulkNotesResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkNotesResponse>> PostExternalcontactsBulkNotesUpdateAsyncWithHttpInfo (BulkNotesRequest body);

        /// <summary>
        /// Bulk fetch organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations ids</param>
        /// <returns>Task of BulkFetchOrganizationsResponse</returns>
        
        System.Threading.Tasks.Task<BulkFetchOrganizationsResponse> PostExternalcontactsBulkOrganizationsAsync (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations ids</param>
        /// <returns>Task of ApiResponse (BulkFetchOrganizationsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkFetchOrganizationsResponse>> PostExternalcontactsBulkOrganizationsAsyncWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk add organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>Task of BulkOrganizationsResponse</returns>
        
        System.Threading.Tasks.Task<BulkOrganizationsResponse> PostExternalcontactsBulkOrganizationsAddAsync (BulkOrganizationsRequest body);

        /// <summary>
        /// Bulk add organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>Task of ApiResponse (BulkOrganizationsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkOrganizationsResponse>> PostExternalcontactsBulkOrganizationsAddAsyncWithHttpInfo (BulkOrganizationsRequest body);

        /// <summary>
        /// Bulk remove organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization ids</param>
        /// <returns>Task of BulkDeleteResponse</returns>
        
        System.Threading.Tasks.Task<BulkDeleteResponse> PostExternalcontactsBulkOrganizationsRemoveAsync (BulkIdsRequest body);

        /// <summary>
        /// Bulk remove organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization ids</param>
        /// <returns>Task of ApiResponse (BulkDeleteResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkDeleteResponse>> PostExternalcontactsBulkOrganizationsRemoveAsyncWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk update organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>Task of BulkOrganizationsResponse</returns>
        
        System.Threading.Tasks.Task<BulkOrganizationsResponse> PostExternalcontactsBulkOrganizationsUpdateAsync (BulkOrganizationsRequest body);

        /// <summary>
        /// Bulk update organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>Task of ApiResponse (BulkOrganizationsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkOrganizationsResponse>> PostExternalcontactsBulkOrganizationsUpdateAsyncWithHttpInfo (BulkOrganizationsRequest body);

        /// <summary>
        /// Bulk fetch relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>Task of BulkFetchRelationshipsResponse</returns>
        
        System.Threading.Tasks.Task<BulkFetchRelationshipsResponse> PostExternalcontactsBulkRelationshipsAsync (BulkIdsRequest body);

        /// <summary>
        /// Bulk fetch relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>Task of ApiResponse (BulkFetchRelationshipsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkFetchRelationshipsResponse>> PostExternalcontactsBulkRelationshipsAsyncWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk add relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>Task of BulkRelationshipsResponse</returns>
        
        System.Threading.Tasks.Task<BulkRelationshipsResponse> PostExternalcontactsBulkRelationshipsAddAsync (BulkRelationshipsRequest body);

        /// <summary>
        /// Bulk add relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>Task of ApiResponse (BulkRelationshipsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkRelationshipsResponse>> PostExternalcontactsBulkRelationshipsAddAsyncWithHttpInfo (BulkRelationshipsRequest body);

        /// <summary>
        /// Bulk remove relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>Task of BulkDeleteResponse</returns>
        
        System.Threading.Tasks.Task<BulkDeleteResponse> PostExternalcontactsBulkRelationshipsRemoveAsync (BulkIdsRequest body);

        /// <summary>
        /// Bulk remove relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>Task of ApiResponse (BulkDeleteResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkDeleteResponse>> PostExternalcontactsBulkRelationshipsRemoveAsyncWithHttpInfo (BulkIdsRequest body);

        /// <summary>
        /// Bulk update relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>Task of BulkRelationshipsResponse</returns>
        
        System.Threading.Tasks.Task<BulkRelationshipsResponse> PostExternalcontactsBulkRelationshipsUpdateAsync (BulkRelationshipsRequest body);

        /// <summary>
        /// Bulk update relationships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>Task of ApiResponse (BulkRelationshipsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkRelationshipsResponse>> PostExternalcontactsBulkRelationshipsUpdateAsyncWithHttpInfo (BulkRelationshipsRequest body);

        /// <summary>
        /// Create a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of Note</returns>
        
        System.Threading.Tasks.Task<Note> PostExternalcontactsContactNotesAsync (string contactId, Note body);

        /// <summary>
        /// Create a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, Note body);

        /// <summary>
        /// Promote an observed contact (ephemeral or identified) to a curated contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ExternalContact</returns>
        
        System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsContactPromotionAsync (string contactId);

        /// <summary>
        /// Promote an observed contact (ephemeral or identified) to a curated contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsContactPromotionAsyncWithHttpInfo (string contactId);

        /// <summary>
        /// Create an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        
        System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsContactsAsync (ExternalContact body);

        /// <summary>
        /// Create an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsContactsAsyncWithHttpInfo (ExternalContact body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> PostExternalcontactsContactsSchemasAsync (DataSchema body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> PostExternalcontactsContactsSchemasAsyncWithHttpInfo (DataSchema body);

        /// <summary>
        /// Fetch a contact using an identifier type and value.
        /// </summary>
        /// <remarks>
        /// Phone number identifier values must be provided with the country code and a leading '+' symbol. Example: \"+1 704 298 4733\"
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier"></param>
        /// <returns>Task of ExternalContact</returns>
        
        System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsIdentifierlookupAsync (ContactIdentifier identifier);

        /// <summary>
        /// Fetch a contact using an identifier type and value.
        /// </summary>
        /// <remarks>
        /// Phone number identifier values must be provided with the country code and a leading '+' symbol. Example: \"+1 704 298 4733\"
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier"></param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsIdentifierlookupAsyncWithHttpInfo (ContactIdentifier identifier);

        /// <summary>
        /// Merge two contacts into a new contact record
        /// </summary>
        /// <remarks>
        /// Two curated contacts cannot be merged. Refer to the Contact Merging article on the Developer Center for details
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MergeRequest</param>
        /// <returns>Task of ExternalContact</returns>
        
        System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsMergeContactsAsync (MergeRequest body);

        /// <summary>
        /// Merge two contacts into a new contact record
        /// </summary>
        /// <remarks>
        /// Two curated contacts cannot be merged. Refer to the Contact Merging article on the Developer Center for details
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MergeRequest</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsMergeContactsAsyncWithHttpInfo (MergeRequest body);

        /// <summary>
        /// Create a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of Note</returns>
        
        System.Threading.Tasks.Task<Note> PostExternalcontactsOrganizationNotesAsync (string externalOrganizationId, Note body);

        /// <summary>
        /// Create a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsOrganizationNotesAsyncWithHttpInfo (string externalOrganizationId, Note body);

        /// <summary>
        /// Create an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        
        System.Threading.Tasks.Task<ExternalOrganization> PostExternalcontactsOrganizationsAsync (ExternalOrganization body);

        /// <summary>
        /// Create an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PostExternalcontactsOrganizationsAsyncWithHttpInfo (ExternalOrganization body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> PostExternalcontactsOrganizationsSchemasAsync (DataSchema body);

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> PostExternalcontactsOrganizationsSchemasAsyncWithHttpInfo (DataSchema body);

        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        
        System.Threading.Tasks.Task<Relationship> PostExternalcontactsRelationshipsAsync (Relationship body);

        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Relationship>> PostExternalcontactsRelationshipsAsyncWithHttpInfo (Relationship body);

        /// <summary>
        /// Update an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        
        System.Threading.Tasks.Task<ExternalContact> PutExternalcontactsContactAsync (string contactId, ExternalContact body);

        /// <summary>
        /// Update an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PutExternalcontactsContactAsyncWithHttpInfo (string contactId, ExternalContact body);

        /// <summary>
        /// Update a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of Note</returns>
        
        System.Threading.Tasks.Task<Note> PutExternalcontactsContactNoteAsync (string contactId, string noteId, Note body);

        /// <summary>
        /// Update a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId, Note body);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> PutExternalcontactsContactsSchemaAsync (string schemaId, DataSchema body);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> PutExternalcontactsContactsSchemaAsyncWithHttpInfo (string schemaId, DataSchema body);

        /// <summary>
        /// Associate/disassociate an external contact with a conversation
        /// </summary>
        /// <remarks>
        /// To associate, supply a value for the externalContactId.  To disassociate, do not include the property at all.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PutExternalcontactsConversationAsync (string conversationId, ConversationAssociation body);

        /// <summary>
        /// Associate/disassociate an external contact with a conversation
        /// </summary>
        /// <remarks>
        /// To associate, supply a value for the externalContactId.  To disassociate, do not include the property at all.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PutExternalcontactsConversationAsyncWithHttpInfo (string conversationId, ConversationAssociation body);

        /// <summary>
        /// Update an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        
        System.Threading.Tasks.Task<ExternalOrganization> PutExternalcontactsOrganizationAsync (string externalOrganizationId, ExternalOrganization body);

        /// <summary>
        /// Update an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PutExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId, ExternalOrganization body);

        /// <summary>
        /// Update a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of Note</returns>
        
        System.Threading.Tasks.Task<Note> PutExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId, Note body);

        /// <summary>
        /// Update a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId, Note body);

        /// <summary>
        /// Links a Trustor with an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>Task of ExternalOrganizationTrustorLink</returns>
        
        System.Threading.Tasks.Task<ExternalOrganizationTrustorLink> PutExternalcontactsOrganizationTrustorTrustorIdAsync (string externalOrganizationId, string trustorId);

        /// <summary>
        /// Links a Trustor with an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>Task of ApiResponse (ExternalOrganizationTrustorLink)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganizationTrustorLink>> PutExternalcontactsOrganizationTrustorTrustorIdAsyncWithHttpInfo (string externalOrganizationId, string trustorId);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        System.Threading.Tasks.Task<DataSchema> PutExternalcontactsOrganizationsSchemaAsync (string schemaId, DataSchema body);

        /// <summary>
        /// Update a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<DataSchema>> PutExternalcontactsOrganizationsSchemaAsyncWithHttpInfo (string schemaId, DataSchema body);

        /// <summary>
        /// Update a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        
        System.Threading.Tasks.Task<Relationship> PutExternalcontactsRelationshipAsync (string relationshipId, Relationship body);

        /// <summary>
        /// Update a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Relationship>> PutExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId, Relationship body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExternalContactsApi : IExternalContactsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExternalContactsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExternalContactsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PureCloudPlatform.Client.V2.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
             return this.Configuration.ApiClient.ClientOptions.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PureCloudPlatform.Client.V2.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use this.Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use this.Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }


        /// <summary>
        /// Delete an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Object</returns>
        
        public Object DeleteExternalcontactsContact (string contactId)
        {
             ApiResponse<Object> localVarResponse = DeleteExternalcontactsContactWithHttpInfo(contactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of Object</returns>
        
        public ApiResponse< Object > DeleteExternalcontactsContactWithHttpInfo (string contactId)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->DeleteExternalcontactsContact");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of Object</returns>
        
        public async System.Threading.Tasks.Task<Object> DeleteExternalcontactsContactAsync (string contactId)
        {
             ApiResponse<Object> localVarResponse = await DeleteExternalcontactsContactAsyncWithHttpInfo(contactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactAsyncWithHttpInfo (string contactId)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->DeleteExternalcontactsContact");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Object</returns>
        
        public Object DeleteExternalcontactsContactNote (string contactId, string noteId)
        {
             ApiResponse<Object> localVarResponse = DeleteExternalcontactsContactNoteWithHttpInfo(contactId, noteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object</returns>
        
        public ApiResponse< Object > DeleteExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->DeleteExternalcontactsContactNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->DeleteExternalcontactsContactNote");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of Object</returns>
        
        public async System.Threading.Tasks.Task<Object> DeleteExternalcontactsContactNoteAsync (string contactId, string noteId)
        {
             ApiResponse<Object> localVarResponse = await DeleteExternalcontactsContactNoteAsyncWithHttpInfo(contactId, noteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->DeleteExternalcontactsContactNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->DeleteExternalcontactsContactNote");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns></returns>
        
        public void DeleteExternalcontactsContactsSchema (string schemaId)
        {
             DeleteExternalcontactsContactsSchemaWithHttpInfo(schemaId);
        }

        /// <summary>
        /// Delete a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteExternalcontactsContactsSchemaWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->DeleteExternalcontactsContactsSchema");

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteExternalcontactsContactsSchemaAsync (string schemaId)
        {
             await DeleteExternalcontactsContactsSchemaAsyncWithHttpInfo(schemaId);

        }

        /// <summary>
        /// Delete a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactsSchemaAsyncWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->DeleteExternalcontactsContactsSchema");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Object</returns>
        
        public Object DeleteExternalcontactsOrganization (string externalOrganizationId)
        {
             ApiResponse<Object> localVarResponse = DeleteExternalcontactsOrganizationWithHttpInfo(externalOrganizationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ApiResponse of Object</returns>
        
        public ApiResponse< Object > DeleteExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->DeleteExternalcontactsOrganization");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of Object</returns>
        
        public async System.Threading.Tasks.Task<Object> DeleteExternalcontactsOrganizationAsync (string externalOrganizationId)
        {
             ApiResponse<Object> localVarResponse = await DeleteExternalcontactsOrganizationAsyncWithHttpInfo(externalOrganizationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->DeleteExternalcontactsOrganization");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Object</returns>
        
        public Object DeleteExternalcontactsOrganizationNote (string externalOrganizationId, string noteId)
        {
             ApiResponse<Object> localVarResponse = DeleteExternalcontactsOrganizationNoteWithHttpInfo(externalOrganizationId, noteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object</returns>
        
        public ApiResponse< Object > DeleteExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->DeleteExternalcontactsOrganizationNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->DeleteExternalcontactsOrganizationNote");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of Object</returns>
        
        public async System.Threading.Tasks.Task<Object> DeleteExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId)
        {
             ApiResponse<Object> localVarResponse = await DeleteExternalcontactsOrganizationNoteAsyncWithHttpInfo(externalOrganizationId, noteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->DeleteExternalcontactsOrganizationNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->DeleteExternalcontactsOrganizationNote");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Unlink the Trustor for this External Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns></returns>
        
        public void DeleteExternalcontactsOrganizationTrustor (string externalOrganizationId)
        {
             DeleteExternalcontactsOrganizationTrustorWithHttpInfo(externalOrganizationId);
        }

        /// <summary>
        /// Unlink the Trustor for this External Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteExternalcontactsOrganizationTrustorWithHttpInfo (string externalOrganizationId)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->DeleteExternalcontactsOrganizationTrustor");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationTrustor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationTrustor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Unlink the Trustor for this External Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteExternalcontactsOrganizationTrustorAsync (string externalOrganizationId)
        {
             await DeleteExternalcontactsOrganizationTrustorAsyncWithHttpInfo(externalOrganizationId);

        }

        /// <summary>
        /// Unlink the Trustor for this External Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsOrganizationTrustorAsyncWithHttpInfo (string externalOrganizationId)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->DeleteExternalcontactsOrganizationTrustor");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationTrustor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationTrustor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Object</returns>
        
        public Object DeleteExternalcontactsRelationship (string relationshipId)
        {
             ApiResponse<Object> localVarResponse = DeleteExternalcontactsRelationshipWithHttpInfo(relationshipId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>ApiResponse of Object</returns>
        
        public ApiResponse< Object > DeleteExternalcontactsRelationshipWithHttpInfo (string relationshipId)
        { 
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->DeleteExternalcontactsRelationship");

            var localVarPath = "/api/v2/externalcontacts/relationships/{relationshipId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", this.Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of Object</returns>
        
        public async System.Threading.Tasks.Task<Object> DeleteExternalcontactsRelationshipAsync (string relationshipId)
        {
             ApiResponse<Object> localVarResponse = await DeleteExternalcontactsRelationshipAsyncWithHttpInfo(relationshipId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId)
        { 
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->DeleteExternalcontactsRelationship");
            

            var localVarPath = "/api/v2/externalcontacts/relationships/{relationshipId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", this.Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>ExternalContact</returns>
        
        public ExternalContact GetExternalcontactsContact (string contactId, List<string> expand = null)
        {
             ApiResponse<ExternalContact> localVarResponse = GetExternalcontactsContactWithHttpInfo(contactId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        public ApiResponse< ExternalContact > GetExternalcontactsContactWithHttpInfo (string contactId, List<string> expand = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContact");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>Task of ExternalContact</returns>
        
        public async System.Threading.Tasks.Task<ExternalContact> GetExternalcontactsContactAsync (string contactId, List<string> expand = null)
        {
             ApiResponse<ExternalContact> localVarResponse = await GetExternalcontactsContactAsyncWithHttpInfo(contactId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> GetExternalcontactsContactAsyncWithHttpInfo (string contactId, List<string> expand = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContact");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List the identifiers for a contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>EntityListing</returns>
        
        public EntityListing GetExternalcontactsContactIdentifiers (string contactId)
        {
             ApiResponse<EntityListing> localVarResponse = GetExternalcontactsContactIdentifiersWithHttpInfo(contactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the identifiers for a contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of EntityListing</returns>
        
        public ApiResponse< EntityListing > GetExternalcontactsContactIdentifiersWithHttpInfo (string contactId)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactIdentifiers");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/identifiers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactIdentifiers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactIdentifiers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EntityListing>(localVarStatusCode,
                localVarHeaders,
                (EntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List the identifiers for a contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of EntityListing</returns>
        
        public async System.Threading.Tasks.Task<EntityListing> GetExternalcontactsContactIdentifiersAsync (string contactId)
        {
             ApiResponse<EntityListing> localVarResponse = await GetExternalcontactsContactIdentifiersAsyncWithHttpInfo(contactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the identifiers for a contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse (EntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EntityListing>> GetExternalcontactsContactIdentifiersAsyncWithHttpInfo (string contactId)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactIdentifiers");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/identifiers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactIdentifiers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactIdentifiers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EntityListing>(localVarStatusCode,
                localVarHeaders,
                (EntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve all sessions for a given external contact. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>SessionListing</returns>
        
        public SessionListing GetExternalcontactsContactJourneySessions (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)
        {
             ApiResponse<SessionListing> localVarResponse = GetExternalcontactsContactJourneySessionsWithHttpInfo(contactId, pageSize, after, includeMerged);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve all sessions for a given external contact. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>ApiResponse of SessionListing</returns>
        
        public ApiResponse< SessionListing > GetExternalcontactsContactJourneySessionsWithHttpInfo (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactJourneySessions");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/journey/sessions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (includeMerged != null) localVarQueryParams.Add(new Tuple<string, string>("includeMerged", this.Configuration.ApiClient.ParameterToString(includeMerged)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactJourneySessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactJourneySessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SessionListing>(localVarStatusCode,
                localVarHeaders,
                (SessionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SessionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve all sessions for a given external contact. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>Task of SessionListing</returns>
        
        public async System.Threading.Tasks.Task<SessionListing> GetExternalcontactsContactJourneySessionsAsync (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)
        {
             ApiResponse<SessionListing> localVarResponse = await GetExternalcontactsContactJourneySessionsAsyncWithHttpInfo(contactId, pageSize, after, includeMerged);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve all sessions for a given external contact. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="includeMerged">Indicates whether to return sessions from all external contacts in the merge-set of the given one. (optional)</param>
        /// <returns>Task of ApiResponse (SessionListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SessionListing>> GetExternalcontactsContactJourneySessionsAsyncWithHttpInfo (string contactId, string pageSize = null, string after = null, bool? includeMerged = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactJourneySessions");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/journey/sessions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (includeMerged != null) localVarQueryParams.Add(new Tuple<string, string>("includeMerged", this.Configuration.ApiClient.ParameterToString(includeMerged)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactJourneySessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactJourneySessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SessionListing>(localVarStatusCode,
                localVarHeaders,
                (SessionListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SessionListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Note</returns>
        
        public Note GetExternalcontactsContactNote (string contactId, string noteId, List<string> expand = null)
        {
             ApiResponse<Note> localVarResponse = GetExternalcontactsContactNoteWithHttpInfo(contactId, noteId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        
        public ApiResponse< Note > GetExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId, List<string> expand = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->GetExternalcontactsContactNote");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of Note</returns>
        
        public async System.Threading.Tasks.Task<Note> GetExternalcontactsContactNoteAsync (string contactId, string noteId, List<string> expand = null)
        {
             ApiResponse<Note> localVarResponse = await GetExternalcontactsContactNoteAsyncWithHttpInfo(contactId, noteId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Note>> GetExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId, List<string> expand = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->GetExternalcontactsContactNote");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List notes for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>NoteListing</returns>
        
        public NoteListing GetExternalcontactsContactNotes (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<NoteListing> localVarResponse = GetExternalcontactsContactNotesWithHttpInfo(contactId, pageSize, pageNumber, sortOrder, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List notes for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of NoteListing</returns>
        
        public ApiResponse< NoteListing > GetExternalcontactsContactNotesWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactNotes");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NoteListing>(localVarStatusCode,
                localVarHeaders,
                (NoteListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NoteListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List notes for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of NoteListing</returns>
        
        public async System.Threading.Tasks.Task<NoteListing> GetExternalcontactsContactNotesAsync (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<NoteListing> localVarResponse = await GetExternalcontactsContactNotesAsyncWithHttpInfo(contactId, pageSize, pageNumber, sortOrder, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List notes for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (NoteListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactNotes");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NoteListing>(localVarStatusCode,
                localVarHeaders,
                (NoteListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NoteListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch an unresolved external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>ExternalContact</returns>
        
        public ExternalContact GetExternalcontactsContactUnresolved (string contactId, List<string> expand = null)
        {
             ApiResponse<ExternalContact> localVarResponse = GetExternalcontactsContactUnresolvedWithHttpInfo(contactId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch an unresolved external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        public ApiResponse< ExternalContact > GetExternalcontactsContactUnresolvedWithHttpInfo (string contactId, List<string> expand = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactUnresolved");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/unresolved";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactUnresolved: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactUnresolved: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch an unresolved external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>Task of ExternalContact</returns>
        
        public async System.Threading.Tasks.Task<ExternalContact> GetExternalcontactsContactUnresolvedAsync (string contactId, List<string> expand = null)
        {
             ApiResponse<ExternalContact> localVarResponse = await GetExternalcontactsContactUnresolvedAsyncWithHttpInfo(contactId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch an unresolved external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="expand">which fields, if any, to expand (externalOrganization,externalDataSources) (optional)</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> GetExternalcontactsContactUnresolvedAsyncWithHttpInfo (string contactId, List<string> expand = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactUnresolved");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/unresolved";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactUnresolved: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactUnresolved: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Search for external contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ContactListing</returns>
        
        public ContactListing GetExternalcontactsContacts (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<ContactListing> localVarResponse = GetExternalcontactsContactsWithHttpInfo(pageSize, pageNumber, q, sortOrder, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search for external contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of ContactListing</returns>
        
        public ApiResponse< ContactListing > GetExternalcontactsContactsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", this.Configuration.ApiClient.ParameterToString(q)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListing>(localVarStatusCode,
                localVarHeaders,
                (ContactListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Search for external contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ContactListing</returns>
        
        public async System.Threading.Tasks.Task<ContactListing> GetExternalcontactsContactsAsync (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<ContactListing> localVarResponse = await GetExternalcontactsContactsAsyncWithHttpInfo(pageSize, pageNumber, q, sortOrder, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search for external contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (ContactListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetExternalcontactsContactsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", this.Configuration.ApiClient.ParameterToString(q)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListing>(localVarStatusCode,
                localVarHeaders,
                (ContactListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema GetExternalcontactsContactsSchema (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = GetExternalcontactsContactsSchemaWithHttpInfo(schemaId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > GetExternalcontactsContactsSchemaWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsContactsSchema");

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> GetExternalcontactsContactsSchemaAsync (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = await GetExternalcontactsContactsSchemaAsyncWithHttpInfo(schemaId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsContactsSchemaAsyncWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsContactsSchema");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema GetExternalcontactsContactsSchemaVersion (string schemaId, string versionId)
        {
             ApiResponse<DataSchema> localVarResponse = GetExternalcontactsContactsSchemaVersionWithHttpInfo(schemaId, versionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > GetExternalcontactsContactsSchemaVersionWithHttpInfo (string schemaId, string versionId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsContactsSchemaVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ExternalContactsApi->GetExternalcontactsContactsSchemaVersion");

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas/{schemaId}/versions/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemaVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemaVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> GetExternalcontactsContactsSchemaVersionAsync (string schemaId, string versionId)
        {
             ApiResponse<DataSchema> localVarResponse = await GetExternalcontactsContactsSchemaVersionAsyncWithHttpInfo(schemaId, versionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsContactsSchemaVersionAsyncWithHttpInfo (string schemaId, string versionId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsContactsSchemaVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ExternalContactsApi->GetExternalcontactsContactsSchemaVersion");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas/{schemaId}/versions/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemaVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemaVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all versions of an external contact's schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema GetExternalcontactsContactsSchemaVersions (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = GetExternalcontactsContactsSchemaVersionsWithHttpInfo(schemaId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all versions of an external contact's schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > GetExternalcontactsContactsSchemaVersionsWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsContactsSchemaVersions");

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas/{schemaId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemaVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemaVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all versions of an external contact's schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> GetExternalcontactsContactsSchemaVersionsAsync (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = await GetExternalcontactsContactsSchemaVersionsAsyncWithHttpInfo(schemaId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all versions of an external contact's schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsContactsSchemaVersionsAsyncWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsContactsSchemaVersions");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas/{schemaId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemaVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemaVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DataSchemaListing</returns>
        
        public DataSchemaListing GetExternalcontactsContactsSchemas ()
        {
             ApiResponse<DataSchemaListing> localVarResponse = GetExternalcontactsContactsSchemasWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DataSchemaListing</returns>
        
        public ApiResponse< DataSchemaListing > GetExternalcontactsContactsSchemasWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchemaListing>(localVarStatusCode,
                localVarHeaders,
                (DataSchemaListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchemaListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DataSchemaListing</returns>
        
        public async System.Threading.Tasks.Task<DataSchemaListing> GetExternalcontactsContactsSchemasAsync ()
        {
             ApiResponse<DataSchemaListing> localVarResponse = await GetExternalcontactsContactsSchemasAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DataSchemaListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchemaListing>> GetExternalcontactsContactsSchemasAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchemaListing>(localVarStatusCode,
                localVarHeaders,
                (DataSchemaListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchemaListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="expand">which fields, if any, to expand (externalDataSources) (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>ExternalOrganization</returns>
        
        public ExternalOrganization GetExternalcontactsOrganization (string externalOrganizationId, string expand = null, bool? includeTrustors = null)
        {
             ApiResponse<ExternalOrganization> localVarResponse = GetExternalcontactsOrganizationWithHttpInfo(externalOrganizationId, expand, includeTrustors);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="expand">which fields, if any, to expand (externalDataSources) (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        
        public ApiResponse< ExternalOrganization > GetExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId, string expand = null, bool? includeTrustors = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganization");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (includeTrustors != null) localVarQueryParams.Add(new Tuple<string, string>("includeTrustors", this.Configuration.ApiClient.ParameterToString(includeTrustors)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="expand">which fields, if any, to expand (externalDataSources) (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>Task of ExternalOrganization</returns>
        
        public async System.Threading.Tasks.Task<ExternalOrganization> GetExternalcontactsOrganizationAsync (string externalOrganizationId, string expand = null, bool? includeTrustors = null)
        {
             ApiResponse<ExternalOrganization> localVarResponse = await GetExternalcontactsOrganizationAsyncWithHttpInfo(externalOrganizationId, expand, includeTrustors);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="expand">which fields, if any, to expand (externalDataSources) (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> GetExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId, string expand = null, bool? includeTrustors = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganization");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (includeTrustors != null) localVarQueryParams.Add(new Tuple<string, string>("includeTrustors", this.Configuration.ApiClient.ParameterToString(includeTrustors)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Search for external contacts in an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ContactListing</returns>
        
        public ContactListing GetExternalcontactsOrganizationContacts (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<ContactListing> localVarResponse = GetExternalcontactsOrganizationContactsWithHttpInfo(externalOrganizationId, pageSize, pageNumber, q, sortOrder, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search for external contacts in an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of ContactListing</returns>
        
        public ApiResponse< ContactListing > GetExternalcontactsOrganizationContactsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationContacts");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", this.Configuration.ApiClient.ParameterToString(q)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListing>(localVarStatusCode,
                localVarHeaders,
                (ContactListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Search for external contacts in an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ContactListing</returns>
        
        public async System.Threading.Tasks.Task<ContactListing> GetExternalcontactsOrganizationContactsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<ContactListing> localVarResponse = await GetExternalcontactsOrganizationContactsAsyncWithHttpInfo(externalOrganizationId, pageSize, pageNumber, q, sortOrder, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search for external contacts in an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (ContactListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetExternalcontactsOrganizationContactsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationContacts");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", this.Configuration.ApiClient.ParameterToString(q)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListing>(localVarStatusCode,
                localVarHeaders,
                (ContactListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Note</returns>
        
        public Note GetExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, List<string> expand = null)
        {
             ApiResponse<Note> localVarResponse = GetExternalcontactsOrganizationNoteWithHttpInfo(externalOrganizationId, noteId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        
        public ApiResponse< Note > GetExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId, List<string> expand = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->GetExternalcontactsOrganizationNote");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of Note</returns>
        
        public async System.Threading.Tasks.Task<Note> GetExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId, List<string> expand = null)
        {
             ApiResponse<Note> localVarResponse = await GetExternalcontactsOrganizationNoteAsyncWithHttpInfo(externalOrganizationId, noteId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Note>> GetExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId, List<string> expand = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->GetExternalcontactsOrganizationNote");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List notes for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>NoteListing</returns>
        
        public NoteListing GetExternalcontactsOrganizationNotes (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<NoteListing> localVarResponse = GetExternalcontactsOrganizationNotesWithHttpInfo(externalOrganizationId, pageSize, pageNumber, sortOrder, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List notes for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of NoteListing</returns>
        
        public ApiResponse< NoteListing > GetExternalcontactsOrganizationNotesWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationNotes");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NoteListing>(localVarStatusCode,
                localVarHeaders,
                (NoteListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NoteListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List notes for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of NoteListing</returns>
        
        public async System.Threading.Tasks.Task<NoteListing> GetExternalcontactsOrganizationNotesAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<NoteListing> localVarResponse = await GetExternalcontactsOrganizationNotesAsyncWithHttpInfo(externalOrganizationId, pageSize, pageNumber, sortOrder, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List notes for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (NoteListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetExternalcontactsOrganizationNotesAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationNotes");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NoteListing>(localVarStatusCode,
                localVarHeaders,
                (NoteListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NoteListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch a relationship for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>RelationshipListing</returns>
        
        public RelationshipListing GetExternalcontactsOrganizationRelationships (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string expand = null, string sortOrder = null)
        {
             ApiResponse<RelationshipListing> localVarResponse = GetExternalcontactsOrganizationRelationshipsWithHttpInfo(externalOrganizationId, pageSize, pageNumber, expand, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a relationship for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>ApiResponse of RelationshipListing</returns>
        
        public ApiResponse< RelationshipListing > GetExternalcontactsOrganizationRelationshipsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string expand = null, string sortOrder = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationRelationships");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/relationships";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RelationshipListing>(localVarStatusCode,
                localVarHeaders,
                (RelationshipListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RelationshipListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch a relationship for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of RelationshipListing</returns>
        
        public async System.Threading.Tasks.Task<RelationshipListing> GetExternalcontactsOrganizationRelationshipsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string expand = null, string sortOrder = null)
        {
             ApiResponse<RelationshipListing> localVarResponse = await GetExternalcontactsOrganizationRelationshipsAsyncWithHttpInfo(externalOrganizationId, pageSize, pageNumber, expand, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a relationship for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of ApiResponse (RelationshipListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<RelationshipListing>> GetExternalcontactsOrganizationRelationshipsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string expand = null, string sortOrder = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationRelationships");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/relationships";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RelationshipListing>(localVarStatusCode,
                localVarHeaders,
                (RelationshipListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RelationshipListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Search for external organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">Search query (optional)</param>
        /// <param name="trustorId">Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>ExternalOrganizationListing</returns>
        
        public ExternalOrganizationListing GetExternalcontactsOrganizations (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null)
        {
             ApiResponse<ExternalOrganizationListing> localVarResponse = GetExternalcontactsOrganizationsWithHttpInfo(pageSize, pageNumber, q, trustorId, sortOrder, expand, includeTrustors);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search for external organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">Search query (optional)</param>
        /// <param name="trustorId">Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>ApiResponse of ExternalOrganizationListing</returns>
        
        public ApiResponse< ExternalOrganizationListing > GetExternalcontactsOrganizationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/organizations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", this.Configuration.ApiClient.ParameterToString(q)));
            if (trustorId != null) trustorId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("trustorId", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (includeTrustors != null) localVarQueryParams.Add(new Tuple<string, string>("includeTrustors", this.Configuration.ApiClient.ParameterToString(includeTrustors)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganizationListing>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganizationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganizationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Search for external organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">Search query (optional)</param>
        /// <param name="trustorId">Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>Task of ExternalOrganizationListing</returns>
        
        public async System.Threading.Tasks.Task<ExternalOrganizationListing> GetExternalcontactsOrganizationsAsync (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null)
        {
             ApiResponse<ExternalOrganizationListing> localVarResponse = await GetExternalcontactsOrganizationsAsyncWithHttpInfo(pageSize, pageNumber, q, trustorId, sortOrder, expand, includeTrustors);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search for external organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (limited to fetching first 1,000 records; pageNumber * pageSize must be &lt;&#x3D; 1,000) (optional, default to 1)</param>
        /// <param name="q">Search query (optional)</param>
        /// <param name="trustorId">Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>Task of ApiResponse (ExternalOrganizationListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganizationListing>> GetExternalcontactsOrganizationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/organizations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", this.Configuration.ApiClient.ParameterToString(q)));
            if (trustorId != null) trustorId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("trustorId", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (includeTrustors != null) localVarQueryParams.Add(new Tuple<string, string>("includeTrustors", this.Configuration.ApiClient.ParameterToString(includeTrustors)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganizationListing>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganizationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganizationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema GetExternalcontactsOrganizationsSchema (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = GetExternalcontactsOrganizationsSchemaWithHttpInfo(schemaId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > GetExternalcontactsOrganizationsSchemaWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsOrganizationsSchema");

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> GetExternalcontactsOrganizationsSchemaAsync (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = await GetExternalcontactsOrganizationsSchemaAsyncWithHttpInfo(schemaId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsOrganizationsSchemaAsyncWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsOrganizationsSchema");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema GetExternalcontactsOrganizationsSchemaVersion (string schemaId, string versionId)
        {
             ApiResponse<DataSchema> localVarResponse = GetExternalcontactsOrganizationsSchemaVersionWithHttpInfo(schemaId, versionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > GetExternalcontactsOrganizationsSchemaVersionWithHttpInfo (string schemaId, string versionId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsOrganizationsSchemaVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ExternalContactsApi->GetExternalcontactsOrganizationsSchemaVersion");

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas/{schemaId}/versions/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemaVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemaVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> GetExternalcontactsOrganizationsSchemaVersionAsync (string schemaId, string versionId)
        {
             ApiResponse<DataSchema> localVarResponse = await GetExternalcontactsOrganizationsSchemaVersionAsyncWithHttpInfo(schemaId, versionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a specific version of a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="versionId">Schema version</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsOrganizationsSchemaVersionAsyncWithHttpInfo (string schemaId, string versionId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsOrganizationsSchemaVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ExternalContactsApi->GetExternalcontactsOrganizationsSchemaVersion");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas/{schemaId}/versions/{versionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemaVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemaVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all versions of an external organization's schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema GetExternalcontactsOrganizationsSchemaVersions (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = GetExternalcontactsOrganizationsSchemaVersionsWithHttpInfo(schemaId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all versions of an external organization's schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > GetExternalcontactsOrganizationsSchemaVersionsWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsOrganizationsSchemaVersions");

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas/{schemaId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemaVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemaVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all versions of an external organization's schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> GetExternalcontactsOrganizationsSchemaVersionsAsync (string schemaId)
        {
             ApiResponse<DataSchema> localVarResponse = await GetExternalcontactsOrganizationsSchemaVersionsAsyncWithHttpInfo(schemaId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all versions of an external organization's schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> GetExternalcontactsOrganizationsSchemaVersionsAsyncWithHttpInfo (string schemaId)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->GetExternalcontactsOrganizationsSchemaVersions");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas/{schemaId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemaVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemaVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DataSchemaListing</returns>
        
        public DataSchemaListing GetExternalcontactsOrganizationsSchemas ()
        {
             ApiResponse<DataSchemaListing> localVarResponse = GetExternalcontactsOrganizationsSchemasWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DataSchemaListing</returns>
        
        public ApiResponse< DataSchemaListing > GetExternalcontactsOrganizationsSchemasWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchemaListing>(localVarStatusCode,
                localVarHeaders,
                (DataSchemaListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchemaListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DataSchemaListing</returns>
        
        public async System.Threading.Tasks.Task<DataSchemaListing> GetExternalcontactsOrganizationsSchemasAsync ()
        {
             ApiResponse<DataSchemaListing> localVarResponse = await GetExternalcontactsOrganizationsSchemasAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of schemas. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DataSchemaListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchemaListing>> GetExternalcontactsOrganizationsSchemasAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchemaListing>(localVarStatusCode,
                localVarHeaders,
                (DataSchemaListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchemaListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Relationship</returns>
        
        public Relationship GetExternalcontactsRelationship (string relationshipId, string expand = null)
        {
             ApiResponse<Relationship> localVarResponse = GetExternalcontactsRelationshipWithHttpInfo(relationshipId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of Relationship</returns>
        
        public ApiResponse< Relationship > GetExternalcontactsRelationshipWithHttpInfo (string relationshipId, string expand = null)
        { 
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->GetExternalcontactsRelationship");

            var localVarPath = "/api/v2/externalcontacts/relationships/{relationshipId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", this.Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of Relationship</returns>
        
        public async System.Threading.Tasks.Task<Relationship> GetExternalcontactsRelationshipAsync (string relationshipId, string expand = null)
        {
             ApiResponse<Relationship> localVarResponse = await GetExternalcontactsRelationshipAsyncWithHttpInfo(relationshipId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> GetExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId, string expand = null)
        { 
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->GetExternalcontactsRelationship");
            

            var localVarPath = "/api/v2/externalcontacts/relationships/{relationshipId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", this.Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lookupVal">User supplied value to lookup contacts/externalOrganizations (supports email addresses, e164 phone numbers, Twitter screen names)</param>
        /// <param name="expand">which field, if any, to expand (optional)</param>
        /// <returns>ReverseWhitepagesLookupResult</returns>
        
        public ReverseWhitepagesLookupResult GetExternalcontactsReversewhitepageslookup (string lookupVal, List<string> expand = null)
        {
             ApiResponse<ReverseWhitepagesLookupResult> localVarResponse = GetExternalcontactsReversewhitepageslookupWithHttpInfo(lookupVal, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lookupVal">User supplied value to lookup contacts/externalOrganizations (supports email addresses, e164 phone numbers, Twitter screen names)</param>
        /// <param name="expand">which field, if any, to expand (optional)</param>
        /// <returns>ApiResponse of ReverseWhitepagesLookupResult</returns>
        
        public ApiResponse< ReverseWhitepagesLookupResult > GetExternalcontactsReversewhitepageslookupWithHttpInfo (string lookupVal, List<string> expand = null)
        { 
            // verify the required parameter 'lookupVal' is set
            if (lookupVal == null)
                throw new ApiException(400, "Missing required parameter 'lookupVal' when calling ExternalContactsApi->GetExternalcontactsReversewhitepageslookup");

            var localVarPath = "/api/v2/externalcontacts/reversewhitepageslookup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (lookupVal != null) localVarQueryParams.Add(new Tuple<string, string>("lookupVal", this.Configuration.ApiClient.ParameterToString(lookupVal)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsReversewhitepageslookup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsReversewhitepageslookup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReverseWhitepagesLookupResult>(localVarStatusCode,
                localVarHeaders,
                (ReverseWhitepagesLookupResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReverseWhitepagesLookupResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lookupVal">User supplied value to lookup contacts/externalOrganizations (supports email addresses, e164 phone numbers, Twitter screen names)</param>
        /// <param name="expand">which field, if any, to expand (optional)</param>
        /// <returns>Task of ReverseWhitepagesLookupResult</returns>
        
        public async System.Threading.Tasks.Task<ReverseWhitepagesLookupResult> GetExternalcontactsReversewhitepageslookupAsync (string lookupVal, List<string> expand = null)
        {
             ApiResponse<ReverseWhitepagesLookupResult> localVarResponse = await GetExternalcontactsReversewhitepageslookupAsyncWithHttpInfo(lookupVal, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Look up contacts and externalOrganizations based on an attribute. Maximum of 25 values returned. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lookupVal">User supplied value to lookup contacts/externalOrganizations (supports email addresses, e164 phone numbers, Twitter screen names)</param>
        /// <param name="expand">which field, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (ReverseWhitepagesLookupResult)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ReverseWhitepagesLookupResult>> GetExternalcontactsReversewhitepageslookupAsyncWithHttpInfo (string lookupVal, List<string> expand = null)
        { 
            // verify the required parameter 'lookupVal' is set
            if (lookupVal == null)
                throw new ApiException(400, "Missing required parameter 'lookupVal' when calling ExternalContactsApi->GetExternalcontactsReversewhitepageslookup");
            

            var localVarPath = "/api/v2/externalcontacts/reversewhitepageslookup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (lookupVal != null) localVarQueryParams.Add(new Tuple<string, string>("lookupVal", this.Configuration.ApiClient.ParameterToString(lookupVal)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsReversewhitepageslookup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsReversewhitepageslookup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReverseWhitepagesLookupResult>(localVarStatusCode,
                localVarHeaders,
                (ReverseWhitepagesLookupResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReverseWhitepagesLookupResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Scan for external contacts using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of contacts per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>CursorContactListing</returns>
        
        public CursorContactListing GetExternalcontactsScanContacts (int? limit = null, string cursor = null)
        {
             ApiResponse<CursorContactListing> localVarResponse = GetExternalcontactsScanContactsWithHttpInfo(limit, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Scan for external contacts using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of contacts per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>ApiResponse of CursorContactListing</returns>
        
        public ApiResponse< CursorContactListing > GetExternalcontactsScanContactsWithHttpInfo (int? limit = null, string cursor = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/scan/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CursorContactListing>(localVarStatusCode,
                localVarHeaders,
                (CursorContactListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CursorContactListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Scan for external contacts using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of contacts per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of CursorContactListing</returns>
        
        public async System.Threading.Tasks.Task<CursorContactListing> GetExternalcontactsScanContactsAsync (int? limit = null, string cursor = null)
        {
             ApiResponse<CursorContactListing> localVarResponse = await GetExternalcontactsScanContactsAsyncWithHttpInfo(limit, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Scan for external contacts using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of contacts per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of ApiResponse (CursorContactListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CursorContactListing>> GetExternalcontactsScanContactsAsyncWithHttpInfo (int? limit = null, string cursor = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/scan/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CursorContactListing>(localVarStatusCode,
                localVarHeaders,
                (CursorContactListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CursorContactListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Scan for notes using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of notes per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>CursorNoteListing</returns>
        
        public CursorNoteListing GetExternalcontactsScanNotes (int? limit = null, string cursor = null)
        {
             ApiResponse<CursorNoteListing> localVarResponse = GetExternalcontactsScanNotesWithHttpInfo(limit, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Scan for notes using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of notes per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>ApiResponse of CursorNoteListing</returns>
        
        public ApiResponse< CursorNoteListing > GetExternalcontactsScanNotesWithHttpInfo (int? limit = null, string cursor = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/scan/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CursorNoteListing>(localVarStatusCode,
                localVarHeaders,
                (CursorNoteListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CursorNoteListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Scan for notes using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of notes per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of CursorNoteListing</returns>
        
        public async System.Threading.Tasks.Task<CursorNoteListing> GetExternalcontactsScanNotesAsync (int? limit = null, string cursor = null)
        {
             ApiResponse<CursorNoteListing> localVarResponse = await GetExternalcontactsScanNotesAsyncWithHttpInfo(limit, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Scan for notes using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of notes per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of ApiResponse (CursorNoteListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CursorNoteListing>> GetExternalcontactsScanNotesAsyncWithHttpInfo (int? limit = null, string cursor = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/scan/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CursorNoteListing>(localVarStatusCode,
                localVarHeaders,
                (CursorNoteListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CursorNoteListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Scan for external organizations using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of organizations per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>CursorOrganizationListing</returns>
        
        public CursorOrganizationListing GetExternalcontactsScanOrganizations (int? limit = null, string cursor = null)
        {
             ApiResponse<CursorOrganizationListing> localVarResponse = GetExternalcontactsScanOrganizationsWithHttpInfo(limit, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Scan for external organizations using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of organizations per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>ApiResponse of CursorOrganizationListing</returns>
        
        public ApiResponse< CursorOrganizationListing > GetExternalcontactsScanOrganizationsWithHttpInfo (int? limit = null, string cursor = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/scan/organizations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CursorOrganizationListing>(localVarStatusCode,
                localVarHeaders,
                (CursorOrganizationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CursorOrganizationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Scan for external organizations using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of organizations per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of CursorOrganizationListing</returns>
        
        public async System.Threading.Tasks.Task<CursorOrganizationListing> GetExternalcontactsScanOrganizationsAsync (int? limit = null, string cursor = null)
        {
             ApiResponse<CursorOrganizationListing> localVarResponse = await GetExternalcontactsScanOrganizationsAsyncWithHttpInfo(limit, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Scan for external organizations using paging 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of organizations per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of ApiResponse (CursorOrganizationListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CursorOrganizationListing>> GetExternalcontactsScanOrganizationsAsyncWithHttpInfo (int? limit = null, string cursor = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/scan/organizations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CursorOrganizationListing>(localVarStatusCode,
                localVarHeaders,
                (CursorOrganizationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CursorOrganizationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Scan for relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of relationships per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>CursorRelationshipListing</returns>
        
        public CursorRelationshipListing GetExternalcontactsScanRelationships (int? limit = null, string cursor = null)
        {
             ApiResponse<CursorRelationshipListing> localVarResponse = GetExternalcontactsScanRelationshipsWithHttpInfo(limit, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Scan for relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of relationships per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>ApiResponse of CursorRelationshipListing</returns>
        
        public ApiResponse< CursorRelationshipListing > GetExternalcontactsScanRelationshipsWithHttpInfo (int? limit = null, string cursor = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/scan/relationships";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CursorRelationshipListing>(localVarStatusCode,
                localVarHeaders,
                (CursorRelationshipListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CursorRelationshipListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Scan for relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of relationships per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of CursorRelationshipListing</returns>
        
        public async System.Threading.Tasks.Task<CursorRelationshipListing> GetExternalcontactsScanRelationshipsAsync (int? limit = null, string cursor = null)
        {
             ApiResponse<CursorRelationshipListing> localVarResponse = await GetExternalcontactsScanRelationshipsAsyncWithHttpInfo(limit, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Scan for relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The number of relationships per page; must be between 10 and 200, default is 100) (optional)</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page), each page returns a new cursor with a 24h TTL (optional)</param>
        /// <returns>Task of ApiResponse (CursorRelationshipListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CursorRelationshipListing>> GetExternalcontactsScanRelationshipsAsyncWithHttpInfo (int? limit = null, string cursor = null)
        { 

            var localVarPath = "/api/v2/externalcontacts/scan/relationships";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsScanRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CursorRelationshipListing>(localVarStatusCode,
                localVarHeaders,
                (CursorRelationshipListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CursorRelationshipListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Claim or release identifiers for a contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ClaimRequest</param>
        /// <returns>ContactIdentifier</returns>
        
        public ContactIdentifier PatchExternalcontactsContactIdentifiers (string contactId, IdentifierClaimRequest body)
        {
             ApiResponse<ContactIdentifier> localVarResponse = PatchExternalcontactsContactIdentifiersWithHttpInfo(contactId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Claim or release identifiers for a contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ClaimRequest</param>
        /// <returns>ApiResponse of ContactIdentifier</returns>
        
        public ApiResponse< ContactIdentifier > PatchExternalcontactsContactIdentifiersWithHttpInfo (string contactId, IdentifierClaimRequest body)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PatchExternalcontactsContactIdentifiers");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PatchExternalcontactsContactIdentifiers");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/identifiers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchExternalcontactsContactIdentifiers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchExternalcontactsContactIdentifiers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactIdentifier>(localVarStatusCode,
                localVarHeaders,
                (ContactIdentifier) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactIdentifier)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Claim or release identifiers for a contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ClaimRequest</param>
        /// <returns>Task of ContactIdentifier</returns>
        
        public async System.Threading.Tasks.Task<ContactIdentifier> PatchExternalcontactsContactIdentifiersAsync (string contactId, IdentifierClaimRequest body)
        {
             ApiResponse<ContactIdentifier> localVarResponse = await PatchExternalcontactsContactIdentifiersAsyncWithHttpInfo(contactId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Claim or release identifiers for a contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ClaimRequest</param>
        /// <returns>Task of ApiResponse (ContactIdentifier)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ContactIdentifier>> PatchExternalcontactsContactIdentifiersAsyncWithHttpInfo (string contactId, IdentifierClaimRequest body)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PatchExternalcontactsContactIdentifiers");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PatchExternalcontactsContactIdentifiers");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/identifiers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchExternalcontactsContactIdentifiers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchExternalcontactsContactIdentifiers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactIdentifier>(localVarStatusCode,
                localVarHeaders,
                (ContactIdentifier) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactIdentifier)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk fetch contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>BulkFetchContactsResponse</returns>
        
        public BulkFetchContactsResponse PostExternalcontactsBulkContacts (BulkIdsRequest body)
        {
             ApiResponse<BulkFetchContactsResponse> localVarResponse = PostExternalcontactsBulkContactsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk fetch contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>ApiResponse of BulkFetchContactsResponse</returns>
        
        public ApiResponse< BulkFetchContactsResponse > PostExternalcontactsBulkContactsWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkContacts");

            var localVarPath = "/api/v2/externalcontacts/bulk/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkFetchContactsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkFetchContactsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkFetchContactsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk fetch contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of BulkFetchContactsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkFetchContactsResponse> PostExternalcontactsBulkContactsAsync (BulkIdsRequest body)
        {
             ApiResponse<BulkFetchContactsResponse> localVarResponse = await PostExternalcontactsBulkContactsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk fetch contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of ApiResponse (BulkFetchContactsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkFetchContactsResponse>> PostExternalcontactsBulkContactsAsyncWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkContacts");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkFetchContactsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkFetchContactsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkFetchContactsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk add contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>BulkContactsResponse</returns>
        
        public BulkContactsResponse PostExternalcontactsBulkContactsAdd (BulkContactsRequest body)
        {
             ApiResponse<BulkContactsResponse> localVarResponse = PostExternalcontactsBulkContactsAddWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk add contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>ApiResponse of BulkContactsResponse</returns>
        
        public ApiResponse< BulkContactsResponse > PostExternalcontactsBulkContactsAddWithHttpInfo (BulkContactsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkContactsAdd");

            var localVarPath = "/api/v2/externalcontacts/bulk/contacts/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkContactsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkContactsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkContactsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk add contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>Task of BulkContactsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkContactsResponse> PostExternalcontactsBulkContactsAddAsync (BulkContactsRequest body)
        {
             ApiResponse<BulkContactsResponse> localVarResponse = await PostExternalcontactsBulkContactsAddAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk add contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>Task of ApiResponse (BulkContactsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkContactsResponse>> PostExternalcontactsBulkContactsAddAsyncWithHttpInfo (BulkContactsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkContactsAdd");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/contacts/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkContactsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkContactsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkContactsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk remove contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>BulkDeleteResponse</returns>
        
        public BulkDeleteResponse PostExternalcontactsBulkContactsRemove (BulkIdsRequest body)
        {
             ApiResponse<BulkDeleteResponse> localVarResponse = PostExternalcontactsBulkContactsRemoveWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk remove contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>ApiResponse of BulkDeleteResponse</returns>
        
        public ApiResponse< BulkDeleteResponse > PostExternalcontactsBulkContactsRemoveWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkContactsRemove");

            var localVarPath = "/api/v2/externalcontacts/bulk/contacts/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkDeleteResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkDeleteResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkDeleteResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk remove contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of BulkDeleteResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkDeleteResponse> PostExternalcontactsBulkContactsRemoveAsync (BulkIdsRequest body)
        {
             ApiResponse<BulkDeleteResponse> localVarResponse = await PostExternalcontactsBulkContactsRemoveAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk remove contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of ApiResponse (BulkDeleteResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkDeleteResponse>> PostExternalcontactsBulkContactsRemoveAsyncWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkContactsRemove");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/contacts/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkDeleteResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkDeleteResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkDeleteResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk fetch unresolved ancestor contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>BulkFetchContactsResponse</returns>
        
        public BulkFetchContactsResponse PostExternalcontactsBulkContactsUnresolved (BulkIdsRequest body)
        {
             ApiResponse<BulkFetchContactsResponse> localVarResponse = PostExternalcontactsBulkContactsUnresolvedWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk fetch unresolved ancestor contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>ApiResponse of BulkFetchContactsResponse</returns>
        
        public ApiResponse< BulkFetchContactsResponse > PostExternalcontactsBulkContactsUnresolvedWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkContactsUnresolved");

            var localVarPath = "/api/v2/externalcontacts/bulk/contacts/unresolved";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsUnresolved: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsUnresolved: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkFetchContactsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkFetchContactsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkFetchContactsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk fetch unresolved ancestor contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of BulkFetchContactsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkFetchContactsResponse> PostExternalcontactsBulkContactsUnresolvedAsync (BulkIdsRequest body)
        {
             ApiResponse<BulkFetchContactsResponse> localVarResponse = await PostExternalcontactsBulkContactsUnresolvedAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk fetch unresolved ancestor contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contact ids</param>
        /// <returns>Task of ApiResponse (BulkFetchContactsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkFetchContactsResponse>> PostExternalcontactsBulkContactsUnresolvedAsyncWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkContactsUnresolved");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/contacts/unresolved";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsUnresolved: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsUnresolved: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkFetchContactsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkFetchContactsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkFetchContactsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk update contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>BulkContactsResponse</returns>
        
        public BulkContactsResponse PostExternalcontactsBulkContactsUpdate (BulkContactsRequest body)
        {
             ApiResponse<BulkContactsResponse> localVarResponse = PostExternalcontactsBulkContactsUpdateWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk update contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>ApiResponse of BulkContactsResponse</returns>
        
        public ApiResponse< BulkContactsResponse > PostExternalcontactsBulkContactsUpdateWithHttpInfo (BulkContactsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkContactsUpdate");

            var localVarPath = "/api/v2/externalcontacts/bulk/contacts/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsUpdate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkContactsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkContactsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkContactsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk update contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>Task of BulkContactsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkContactsResponse> PostExternalcontactsBulkContactsUpdateAsync (BulkContactsRequest body)
        {
             ApiResponse<BulkContactsResponse> localVarResponse = await PostExternalcontactsBulkContactsUpdateAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk update contacts 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contacts</param>
        /// <returns>Task of ApiResponse (BulkContactsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkContactsResponse>> PostExternalcontactsBulkContactsUpdateAsyncWithHttpInfo (BulkContactsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkContactsUpdate");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/contacts/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsUpdate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkContactsUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkContactsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkContactsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkContactsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk fetch notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>BulkFetchNotesResponse</returns>
        
        public BulkFetchNotesResponse PostExternalcontactsBulkNotes (BulkIdsRequest body)
        {
             ApiResponse<BulkFetchNotesResponse> localVarResponse = PostExternalcontactsBulkNotesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk fetch notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>ApiResponse of BulkFetchNotesResponse</returns>
        
        public ApiResponse< BulkFetchNotesResponse > PostExternalcontactsBulkNotesWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkNotes");

            var localVarPath = "/api/v2/externalcontacts/bulk/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkFetchNotesResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkFetchNotesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkFetchNotesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk fetch notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>Task of BulkFetchNotesResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkFetchNotesResponse> PostExternalcontactsBulkNotesAsync (BulkIdsRequest body)
        {
             ApiResponse<BulkFetchNotesResponse> localVarResponse = await PostExternalcontactsBulkNotesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk fetch notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>Task of ApiResponse (BulkFetchNotesResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkFetchNotesResponse>> PostExternalcontactsBulkNotesAsyncWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkNotes");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkFetchNotesResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkFetchNotesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkFetchNotesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk add notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>BulkNotesResponse</returns>
        
        public BulkNotesResponse PostExternalcontactsBulkNotesAdd (BulkNotesRequest body)
        {
             ApiResponse<BulkNotesResponse> localVarResponse = PostExternalcontactsBulkNotesAddWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk add notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>ApiResponse of BulkNotesResponse</returns>
        
        public ApiResponse< BulkNotesResponse > PostExternalcontactsBulkNotesAddWithHttpInfo (BulkNotesRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkNotesAdd");

            var localVarPath = "/api/v2/externalcontacts/bulk/notes/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkNotesResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkNotesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkNotesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk add notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>Task of BulkNotesResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkNotesResponse> PostExternalcontactsBulkNotesAddAsync (BulkNotesRequest body)
        {
             ApiResponse<BulkNotesResponse> localVarResponse = await PostExternalcontactsBulkNotesAddAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk add notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>Task of ApiResponse (BulkNotesResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkNotesResponse>> PostExternalcontactsBulkNotesAddAsyncWithHttpInfo (BulkNotesRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkNotesAdd");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/notes/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkNotesResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkNotesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkNotesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk remove notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>BulkDeleteResponse</returns>
        
        public BulkDeleteResponse PostExternalcontactsBulkNotesRemove (BulkIdsRequest body)
        {
             ApiResponse<BulkDeleteResponse> localVarResponse = PostExternalcontactsBulkNotesRemoveWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk remove notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>ApiResponse of BulkDeleteResponse</returns>
        
        public ApiResponse< BulkDeleteResponse > PostExternalcontactsBulkNotesRemoveWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkNotesRemove");

            var localVarPath = "/api/v2/externalcontacts/bulk/notes/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkDeleteResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkDeleteResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkDeleteResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk remove notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>Task of BulkDeleteResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkDeleteResponse> PostExternalcontactsBulkNotesRemoveAsync (BulkIdsRequest body)
        {
             ApiResponse<BulkDeleteResponse> localVarResponse = await PostExternalcontactsBulkNotesRemoveAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk remove notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Note ids</param>
        /// <returns>Task of ApiResponse (BulkDeleteResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkDeleteResponse>> PostExternalcontactsBulkNotesRemoveAsyncWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkNotesRemove");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/notes/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkDeleteResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkDeleteResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkDeleteResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk update notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>BulkNotesResponse</returns>
        
        public BulkNotesResponse PostExternalcontactsBulkNotesUpdate (BulkNotesRequest body)
        {
             ApiResponse<BulkNotesResponse> localVarResponse = PostExternalcontactsBulkNotesUpdateWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk update notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>ApiResponse of BulkNotesResponse</returns>
        
        public ApiResponse< BulkNotesResponse > PostExternalcontactsBulkNotesUpdateWithHttpInfo (BulkNotesRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkNotesUpdate");

            var localVarPath = "/api/v2/externalcontacts/bulk/notes/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesUpdate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkNotesResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkNotesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkNotesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk update notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>Task of BulkNotesResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkNotesResponse> PostExternalcontactsBulkNotesUpdateAsync (BulkNotesRequest body)
        {
             ApiResponse<BulkNotesResponse> localVarResponse = await PostExternalcontactsBulkNotesUpdateAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk update notes 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Notes</param>
        /// <returns>Task of ApiResponse (BulkNotesResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkNotesResponse>> PostExternalcontactsBulkNotesUpdateAsyncWithHttpInfo (BulkNotesRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkNotesUpdate");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/notes/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesUpdate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkNotesUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkNotesResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkNotesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkNotesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk fetch organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations ids</param>
        /// <returns>BulkFetchOrganizationsResponse</returns>
        
        public BulkFetchOrganizationsResponse PostExternalcontactsBulkOrganizations (BulkIdsRequest body)
        {
             ApiResponse<BulkFetchOrganizationsResponse> localVarResponse = PostExternalcontactsBulkOrganizationsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk fetch organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations ids</param>
        /// <returns>ApiResponse of BulkFetchOrganizationsResponse</returns>
        
        public ApiResponse< BulkFetchOrganizationsResponse > PostExternalcontactsBulkOrganizationsWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkOrganizations");

            var localVarPath = "/api/v2/externalcontacts/bulk/organizations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkFetchOrganizationsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkFetchOrganizationsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkFetchOrganizationsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk fetch organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations ids</param>
        /// <returns>Task of BulkFetchOrganizationsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkFetchOrganizationsResponse> PostExternalcontactsBulkOrganizationsAsync (BulkIdsRequest body)
        {
             ApiResponse<BulkFetchOrganizationsResponse> localVarResponse = await PostExternalcontactsBulkOrganizationsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk fetch organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations ids</param>
        /// <returns>Task of ApiResponse (BulkFetchOrganizationsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkFetchOrganizationsResponse>> PostExternalcontactsBulkOrganizationsAsyncWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkOrganizations");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/organizations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkFetchOrganizationsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkFetchOrganizationsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkFetchOrganizationsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk add organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>BulkOrganizationsResponse</returns>
        
        public BulkOrganizationsResponse PostExternalcontactsBulkOrganizationsAdd (BulkOrganizationsRequest body)
        {
             ApiResponse<BulkOrganizationsResponse> localVarResponse = PostExternalcontactsBulkOrganizationsAddWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk add organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>ApiResponse of BulkOrganizationsResponse</returns>
        
        public ApiResponse< BulkOrganizationsResponse > PostExternalcontactsBulkOrganizationsAddWithHttpInfo (BulkOrganizationsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkOrganizationsAdd");

            var localVarPath = "/api/v2/externalcontacts/bulk/organizations/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkOrganizationsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkOrganizationsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkOrganizationsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk add organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>Task of BulkOrganizationsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkOrganizationsResponse> PostExternalcontactsBulkOrganizationsAddAsync (BulkOrganizationsRequest body)
        {
             ApiResponse<BulkOrganizationsResponse> localVarResponse = await PostExternalcontactsBulkOrganizationsAddAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk add organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>Task of ApiResponse (BulkOrganizationsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkOrganizationsResponse>> PostExternalcontactsBulkOrganizationsAddAsyncWithHttpInfo (BulkOrganizationsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkOrganizationsAdd");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/organizations/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkOrganizationsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkOrganizationsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkOrganizationsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk remove organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization ids</param>
        /// <returns>BulkDeleteResponse</returns>
        
        public BulkDeleteResponse PostExternalcontactsBulkOrganizationsRemove (BulkIdsRequest body)
        {
             ApiResponse<BulkDeleteResponse> localVarResponse = PostExternalcontactsBulkOrganizationsRemoveWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk remove organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization ids</param>
        /// <returns>ApiResponse of BulkDeleteResponse</returns>
        
        public ApiResponse< BulkDeleteResponse > PostExternalcontactsBulkOrganizationsRemoveWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkOrganizationsRemove");

            var localVarPath = "/api/v2/externalcontacts/bulk/organizations/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkDeleteResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkDeleteResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkDeleteResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk remove organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization ids</param>
        /// <returns>Task of BulkDeleteResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkDeleteResponse> PostExternalcontactsBulkOrganizationsRemoveAsync (BulkIdsRequest body)
        {
             ApiResponse<BulkDeleteResponse> localVarResponse = await PostExternalcontactsBulkOrganizationsRemoveAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk remove organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization ids</param>
        /// <returns>Task of ApiResponse (BulkDeleteResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkDeleteResponse>> PostExternalcontactsBulkOrganizationsRemoveAsyncWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkOrganizationsRemove");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/organizations/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkDeleteResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkDeleteResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkDeleteResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk update organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>BulkOrganizationsResponse</returns>
        
        public BulkOrganizationsResponse PostExternalcontactsBulkOrganizationsUpdate (BulkOrganizationsRequest body)
        {
             ApiResponse<BulkOrganizationsResponse> localVarResponse = PostExternalcontactsBulkOrganizationsUpdateWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk update organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>ApiResponse of BulkOrganizationsResponse</returns>
        
        public ApiResponse< BulkOrganizationsResponse > PostExternalcontactsBulkOrganizationsUpdateWithHttpInfo (BulkOrganizationsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkOrganizationsUpdate");

            var localVarPath = "/api/v2/externalcontacts/bulk/organizations/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsUpdate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkOrganizationsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkOrganizationsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkOrganizationsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk update organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>Task of BulkOrganizationsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkOrganizationsResponse> PostExternalcontactsBulkOrganizationsUpdateAsync (BulkOrganizationsRequest body)
        {
             ApiResponse<BulkOrganizationsResponse> localVarResponse = await PostExternalcontactsBulkOrganizationsUpdateAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk update organizations 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organizations</param>
        /// <returns>Task of ApiResponse (BulkOrganizationsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkOrganizationsResponse>> PostExternalcontactsBulkOrganizationsUpdateAsyncWithHttpInfo (BulkOrganizationsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkOrganizationsUpdate");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/organizations/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsUpdate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkOrganizationsUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkOrganizationsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkOrganizationsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkOrganizationsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk fetch relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>BulkFetchRelationshipsResponse</returns>
        
        public BulkFetchRelationshipsResponse PostExternalcontactsBulkRelationships (BulkIdsRequest body)
        {
             ApiResponse<BulkFetchRelationshipsResponse> localVarResponse = PostExternalcontactsBulkRelationshipsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk fetch relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>ApiResponse of BulkFetchRelationshipsResponse</returns>
        
        public ApiResponse< BulkFetchRelationshipsResponse > PostExternalcontactsBulkRelationshipsWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkRelationships");

            var localVarPath = "/api/v2/externalcontacts/bulk/relationships";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkFetchRelationshipsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkFetchRelationshipsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkFetchRelationshipsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk fetch relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>Task of BulkFetchRelationshipsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkFetchRelationshipsResponse> PostExternalcontactsBulkRelationshipsAsync (BulkIdsRequest body)
        {
             ApiResponse<BulkFetchRelationshipsResponse> localVarResponse = await PostExternalcontactsBulkRelationshipsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk fetch relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>Task of ApiResponse (BulkFetchRelationshipsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkFetchRelationshipsResponse>> PostExternalcontactsBulkRelationshipsAsyncWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkRelationships");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/relationships";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkFetchRelationshipsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkFetchRelationshipsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkFetchRelationshipsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk add relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>BulkRelationshipsResponse</returns>
        
        public BulkRelationshipsResponse PostExternalcontactsBulkRelationshipsAdd (BulkRelationshipsRequest body)
        {
             ApiResponse<BulkRelationshipsResponse> localVarResponse = PostExternalcontactsBulkRelationshipsAddWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk add relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>ApiResponse of BulkRelationshipsResponse</returns>
        
        public ApiResponse< BulkRelationshipsResponse > PostExternalcontactsBulkRelationshipsAddWithHttpInfo (BulkRelationshipsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkRelationshipsAdd");

            var localVarPath = "/api/v2/externalcontacts/bulk/relationships/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkRelationshipsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkRelationshipsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkRelationshipsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk add relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>Task of BulkRelationshipsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkRelationshipsResponse> PostExternalcontactsBulkRelationshipsAddAsync (BulkRelationshipsRequest body)
        {
             ApiResponse<BulkRelationshipsResponse> localVarResponse = await PostExternalcontactsBulkRelationshipsAddAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk add relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>Task of ApiResponse (BulkRelationshipsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkRelationshipsResponse>> PostExternalcontactsBulkRelationshipsAddAsyncWithHttpInfo (BulkRelationshipsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkRelationshipsAdd");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/relationships/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkRelationshipsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkRelationshipsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkRelationshipsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk remove relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>BulkDeleteResponse</returns>
        
        public BulkDeleteResponse PostExternalcontactsBulkRelationshipsRemove (BulkIdsRequest body)
        {
             ApiResponse<BulkDeleteResponse> localVarResponse = PostExternalcontactsBulkRelationshipsRemoveWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk remove relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>ApiResponse of BulkDeleteResponse</returns>
        
        public ApiResponse< BulkDeleteResponse > PostExternalcontactsBulkRelationshipsRemoveWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkRelationshipsRemove");

            var localVarPath = "/api/v2/externalcontacts/bulk/relationships/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkDeleteResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkDeleteResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkDeleteResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk remove relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>Task of BulkDeleteResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkDeleteResponse> PostExternalcontactsBulkRelationshipsRemoveAsync (BulkIdsRequest body)
        {
             ApiResponse<BulkDeleteResponse> localVarResponse = await PostExternalcontactsBulkRelationshipsRemoveAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk remove relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships ids</param>
        /// <returns>Task of ApiResponse (BulkDeleteResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkDeleteResponse>> PostExternalcontactsBulkRelationshipsRemoveAsyncWithHttpInfo (BulkIdsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkRelationshipsRemove");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/relationships/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkDeleteResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkDeleteResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkDeleteResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk update relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>BulkRelationshipsResponse</returns>
        
        public BulkRelationshipsResponse PostExternalcontactsBulkRelationshipsUpdate (BulkRelationshipsRequest body)
        {
             ApiResponse<BulkRelationshipsResponse> localVarResponse = PostExternalcontactsBulkRelationshipsUpdateWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk update relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>ApiResponse of BulkRelationshipsResponse</returns>
        
        public ApiResponse< BulkRelationshipsResponse > PostExternalcontactsBulkRelationshipsUpdateWithHttpInfo (BulkRelationshipsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkRelationshipsUpdate");

            var localVarPath = "/api/v2/externalcontacts/bulk/relationships/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsUpdate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkRelationshipsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkRelationshipsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkRelationshipsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk update relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>Task of BulkRelationshipsResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkRelationshipsResponse> PostExternalcontactsBulkRelationshipsUpdateAsync (BulkRelationshipsRequest body)
        {
             ApiResponse<BulkRelationshipsResponse> localVarResponse = await PostExternalcontactsBulkRelationshipsUpdateAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk update relationships 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationships</param>
        /// <returns>Task of ApiResponse (BulkRelationshipsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkRelationshipsResponse>> PostExternalcontactsBulkRelationshipsUpdateAsyncWithHttpInfo (BulkRelationshipsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsBulkRelationshipsUpdate");
            

            var localVarPath = "/api/v2/externalcontacts/bulk/relationships/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsUpdate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsBulkRelationshipsUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkRelationshipsResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkRelationshipsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkRelationshipsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Note</returns>
        
        public Note PostExternalcontactsContactNotes (string contactId, Note body)
        {
             ApiResponse<Note> localVarResponse = PostExternalcontactsContactNotesWithHttpInfo(contactId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of Note</returns>
        
        public ApiResponse< Note > PostExternalcontactsContactNotesWithHttpInfo (string contactId, Note body)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PostExternalcontactsContactNotes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsContactNotes");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of Note</returns>
        
        public async System.Threading.Tasks.Task<Note> PostExternalcontactsContactNotesAsync (string contactId, Note body)
        {
             ApiResponse<Note> localVarResponse = await PostExternalcontactsContactNotesAsyncWithHttpInfo(contactId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, Note body)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PostExternalcontactsContactNotes");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsContactNotes");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Promote an observed contact (ephemeral or identified) to a curated contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ExternalContact</returns>
        
        public ExternalContact PostExternalcontactsContactPromotion (string contactId)
        {
             ApiResponse<ExternalContact> localVarResponse = PostExternalcontactsContactPromotionWithHttpInfo(contactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Promote an observed contact (ephemeral or identified) to a curated contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        public ApiResponse< ExternalContact > PostExternalcontactsContactPromotionWithHttpInfo (string contactId)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PostExternalcontactsContactPromotion");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/promotion";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactPromotion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactPromotion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Promote an observed contact (ephemeral or identified) to a curated contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ExternalContact</returns>
        
        public async System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsContactPromotionAsync (string contactId)
        {
             ApiResponse<ExternalContact> localVarResponse = await PostExternalcontactsContactPromotionAsyncWithHttpInfo(contactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Promote an observed contact (ephemeral or identified) to a curated contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsContactPromotionAsyncWithHttpInfo (string contactId)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PostExternalcontactsContactPromotion");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/promotion";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactPromotion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactPromotion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact</param>
        /// <returns>ExternalContact</returns>
        
        public ExternalContact PostExternalcontactsContacts (ExternalContact body)
        {
             ApiResponse<ExternalContact> localVarResponse = PostExternalcontactsContactsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        public ApiResponse< ExternalContact > PostExternalcontactsContactsWithHttpInfo (ExternalContact body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsContacts");

            var localVarPath = "/api/v2/externalcontacts/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        
        public async System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsContactsAsync (ExternalContact body)
        {
             ApiResponse<ExternalContact> localVarResponse = await PostExternalcontactsContactsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsContactsAsyncWithHttpInfo (ExternalContact body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsContacts");
            

            var localVarPath = "/api/v2/externalcontacts/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema PostExternalcontactsContactsSchemas (DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = PostExternalcontactsContactsSchemasWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > PostExternalcontactsContactsSchemasWithHttpInfo (DataSchema body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsContactsSchemas");

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> PostExternalcontactsContactsSchemasAsync (DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = await PostExternalcontactsContactsSchemasAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> PostExternalcontactsContactsSchemasAsyncWithHttpInfo (DataSchema body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsContactsSchemas");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch a contact using an identifier type and value. 
        /// Phone number identifier values must be provided with the country code and a leading '+' symbol. Example: \"+1 704 298 4733\"
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier"></param>
        /// <returns>ExternalContact</returns>
        
        public ExternalContact PostExternalcontactsIdentifierlookup (ContactIdentifier identifier)
        {
             ApiResponse<ExternalContact> localVarResponse = PostExternalcontactsIdentifierlookupWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a contact using an identifier type and value. 
        /// Phone number identifier values must be provided with the country code and a leading '+' symbol. Example: \"+1 704 298 4733\"
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier"></param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        public ApiResponse< ExternalContact > PostExternalcontactsIdentifierlookupWithHttpInfo (ContactIdentifier identifier)
        { 
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ExternalContactsApi->PostExternalcontactsIdentifierlookup");

            var localVarPath = "/api/v2/externalcontacts/identifierlookup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (identifier != null && identifier.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(identifier); // http body (model) parameter
            else
                localVarPostBody = identifier; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsIdentifierlookup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsIdentifierlookup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch a contact using an identifier type and value. 
        /// Phone number identifier values must be provided with the country code and a leading '+' symbol. Example: \"+1 704 298 4733\"
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier"></param>
        /// <returns>Task of ExternalContact</returns>
        
        public async System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsIdentifierlookupAsync (ContactIdentifier identifier)
        {
             ApiResponse<ExternalContact> localVarResponse = await PostExternalcontactsIdentifierlookupAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a contact using an identifier type and value. 
        /// Phone number identifier values must be provided with the country code and a leading '+' symbol. Example: \"+1 704 298 4733\"
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier"></param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsIdentifierlookupAsyncWithHttpInfo (ContactIdentifier identifier)
        { 
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ExternalContactsApi->PostExternalcontactsIdentifierlookup");
            

            var localVarPath = "/api/v2/externalcontacts/identifierlookup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (identifier != null && identifier.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(identifier); // http body (model) parameter
            else
                localVarPostBody = identifier; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsIdentifierlookup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsIdentifierlookup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Merge two contacts into a new contact record 
        /// Two curated contacts cannot be merged. Refer to the Contact Merging article on the Developer Center for details
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MergeRequest</param>
        /// <returns>ExternalContact</returns>
        
        public ExternalContact PostExternalcontactsMergeContacts (MergeRequest body)
        {
             ApiResponse<ExternalContact> localVarResponse = PostExternalcontactsMergeContactsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Merge two contacts into a new contact record 
        /// Two curated contacts cannot be merged. Refer to the Contact Merging article on the Developer Center for details
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MergeRequest</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        public ApiResponse< ExternalContact > PostExternalcontactsMergeContactsWithHttpInfo (MergeRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsMergeContacts");

            var localVarPath = "/api/v2/externalcontacts/merge/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsMergeContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsMergeContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Merge two contacts into a new contact record 
        /// Two curated contacts cannot be merged. Refer to the Contact Merging article on the Developer Center for details
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MergeRequest</param>
        /// <returns>Task of ExternalContact</returns>
        
        public async System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsMergeContactsAsync (MergeRequest body)
        {
             ApiResponse<ExternalContact> localVarResponse = await PostExternalcontactsMergeContactsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Merge two contacts into a new contact record 
        /// Two curated contacts cannot be merged. Refer to the Contact Merging article on the Developer Center for details
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MergeRequest</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsMergeContactsAsyncWithHttpInfo (MergeRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsMergeContacts");
            

            var localVarPath = "/api/v2/externalcontacts/merge/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsMergeContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsMergeContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Note</returns>
        
        public Note PostExternalcontactsOrganizationNotes (string externalOrganizationId, Note body)
        {
             ApiResponse<Note> localVarResponse = PostExternalcontactsOrganizationNotesWithHttpInfo(externalOrganizationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of Note</returns>
        
        public ApiResponse< Note > PostExternalcontactsOrganizationNotesWithHttpInfo (string externalOrganizationId, Note body)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PostExternalcontactsOrganizationNotes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsOrganizationNotes");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of Note</returns>
        
        public async System.Threading.Tasks.Task<Note> PostExternalcontactsOrganizationNotesAsync (string externalOrganizationId, Note body)
        {
             ApiResponse<Note> localVarResponse = await PostExternalcontactsOrganizationNotesAsyncWithHttpInfo(externalOrganizationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsOrganizationNotesAsyncWithHttpInfo (string externalOrganizationId, Note body)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PostExternalcontactsOrganizationNotes");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsOrganizationNotes");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/notes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ExternalOrganization</returns>
        
        public ExternalOrganization PostExternalcontactsOrganizations (ExternalOrganization body)
        {
             ApiResponse<ExternalOrganization> localVarResponse = PostExternalcontactsOrganizationsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        
        public ApiResponse< ExternalOrganization > PostExternalcontactsOrganizationsWithHttpInfo (ExternalOrganization body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsOrganizations");

            var localVarPath = "/api/v2/externalcontacts/organizations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        
        public async System.Threading.Tasks.Task<ExternalOrganization> PostExternalcontactsOrganizationsAsync (ExternalOrganization body)
        {
             ApiResponse<ExternalOrganization> localVarResponse = await PostExternalcontactsOrganizationsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PostExternalcontactsOrganizationsAsyncWithHttpInfo (ExternalOrganization body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsOrganizations");
            

            var localVarPath = "/api/v2/externalcontacts/organizations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema PostExternalcontactsOrganizationsSchemas (DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = PostExternalcontactsOrganizationsSchemasWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > PostExternalcontactsOrganizationsSchemasWithHttpInfo (DataSchema body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsOrganizationsSchemas");

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> PostExternalcontactsOrganizationsSchemasAsync (DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = await PostExternalcontactsOrganizationsSchemasAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> PostExternalcontactsOrganizationsSchemasAsyncWithHttpInfo (DataSchema body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsOrganizationsSchemas");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationsSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationsSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship</param>
        /// <returns>Relationship</returns>
        
        public Relationship PostExternalcontactsRelationships (Relationship body)
        {
             ApiResponse<Relationship> localVarResponse = PostExternalcontactsRelationshipsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship</param>
        /// <returns>ApiResponse of Relationship</returns>
        
        public ApiResponse< Relationship > PostExternalcontactsRelationshipsWithHttpInfo (Relationship body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsRelationships");

            var localVarPath = "/api/v2/externalcontacts/relationships";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        
        public async System.Threading.Tasks.Task<Relationship> PostExternalcontactsRelationshipsAsync (Relationship body)
        {
             ApiResponse<Relationship> localVarResponse = await PostExternalcontactsRelationshipsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> PostExternalcontactsRelationshipsAsyncWithHttpInfo (Relationship body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PostExternalcontactsRelationships");
            

            var localVarPath = "/api/v2/externalcontacts/relationships";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ExternalContact</returns>
        
        public ExternalContact PutExternalcontactsContact (string contactId, ExternalContact body)
        {
             ApiResponse<ExternalContact> localVarResponse = PutExternalcontactsContactWithHttpInfo(contactId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        
        public ApiResponse< ExternalContact > PutExternalcontactsContactWithHttpInfo (string contactId, ExternalContact body)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutExternalcontactsContact");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsContact");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        
        public async System.Threading.Tasks.Task<ExternalContact> PutExternalcontactsContactAsync (string contactId, ExternalContact body)
        {
             ApiResponse<ExternalContact> localVarResponse = await PutExternalcontactsContactAsyncWithHttpInfo(contactId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PutExternalcontactsContactAsyncWithHttpInfo (string contactId, ExternalContact body)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutExternalcontactsContact");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsContact");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Note</returns>
        
        public Note PutExternalcontactsContactNote (string contactId, string noteId, Note body)
        {
             ApiResponse<Note> localVarResponse = PutExternalcontactsContactNoteWithHttpInfo(contactId, noteId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>ApiResponse of Note</returns>
        
        public ApiResponse< Note > PutExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId, Note body)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutExternalcontactsContactNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutExternalcontactsContactNote");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsContactNote");

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of Note</returns>
        
        public async System.Threading.Tasks.Task<Note> PutExternalcontactsContactNoteAsync (string contactId, string noteId, Note body)
        {
             ApiResponse<Note> localVarResponse = await PutExternalcontactsContactNoteAsyncWithHttpInfo(contactId, noteId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a note for an external contact 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId, Note body)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutExternalcontactsContactNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutExternalcontactsContactNote");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsContactNote");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/{contactId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", this.Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema PutExternalcontactsContactsSchema (string schemaId, DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = PutExternalcontactsContactsSchemaWithHttpInfo(schemaId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > PutExternalcontactsContactsSchemaWithHttpInfo (string schemaId, DataSchema body)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->PutExternalcontactsContactsSchema");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsContactsSchema");

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> PutExternalcontactsContactsSchemaAsync (string schemaId, DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = await PutExternalcontactsContactsSchemaAsyncWithHttpInfo(schemaId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> PutExternalcontactsContactsSchemaAsyncWithHttpInfo (string schemaId, DataSchema body)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->PutExternalcontactsContactsSchema");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsContactsSchema");
            

            var localVarPath = "/api/v2/externalcontacts/contacts/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Associate/disassociate an external contact with a conversation 
        /// To associate, supply a value for the externalContactId.  To disassociate, do not include the property at all.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation</param>
        /// <returns></returns>
        
        public void PutExternalcontactsConversation (string conversationId, ConversationAssociation body)
        {
             PutExternalcontactsConversationWithHttpInfo(conversationId, body);
        }

        /// <summary>
        /// Associate/disassociate an external contact with a conversation 
        /// To associate, supply a value for the externalContactId.  To disassociate, do not include the property at all.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PutExternalcontactsConversationWithHttpInfo (string conversationId, ConversationAssociation body)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ExternalContactsApi->PutExternalcontactsConversation");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsConversation");

            var localVarPath = "/api/v2/externalcontacts/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Associate/disassociate an external contact with a conversation 
        /// To associate, supply a value for the externalContactId.  To disassociate, do not include the property at all.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PutExternalcontactsConversationAsync (string conversationId, ConversationAssociation body)
        {
             await PutExternalcontactsConversationAsyncWithHttpInfo(conversationId, body);

        }

        /// <summary>
        /// Associate/disassociate an external contact with a conversation 
        /// To associate, supply a value for the externalContactId.  To disassociate, do not include the property at all.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutExternalcontactsConversationAsyncWithHttpInfo (string conversationId, ConversationAssociation body)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ExternalContactsApi->PutExternalcontactsConversation");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsConversation");
            

            var localVarPath = "/api/v2/externalcontacts/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ExternalOrganization</returns>
        
        public ExternalOrganization PutExternalcontactsOrganization (string externalOrganizationId, ExternalOrganization body)
        {
             ApiResponse<ExternalOrganization> localVarResponse = PutExternalcontactsOrganizationWithHttpInfo(externalOrganizationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        
        public ApiResponse< ExternalOrganization > PutExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId, ExternalOrganization body)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganization");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsOrganization");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        
        public async System.Threading.Tasks.Task<ExternalOrganization> PutExternalcontactsOrganizationAsync (string externalOrganizationId, ExternalOrganization body)
        {
             ApiResponse<ExternalOrganization> localVarResponse = await PutExternalcontactsOrganizationAsyncWithHttpInfo(externalOrganizationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PutExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId, ExternalOrganization body)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganization");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsOrganization");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Note</returns>
        
        public Note PutExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, Note body)
        {
             ApiResponse<Note> localVarResponse = PutExternalcontactsOrganizationNoteWithHttpInfo(externalOrganizationId, noteId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>ApiResponse of Note</returns>
        
        public ApiResponse< Note > PutExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId, Note body)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of Note</returns>
        
        public async System.Threading.Tasks.Task<Note> PutExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId, Note body)
        {
             ApiResponse<Note> localVarResponse = await PutExternalcontactsOrganizationNoteAsyncWithHttpInfo(externalOrganizationId, noteId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a note for an external organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId, Note body)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", this.Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Links a Trustor with an External Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>ExternalOrganizationTrustorLink</returns>
        
        public ExternalOrganizationTrustorLink PutExternalcontactsOrganizationTrustorTrustorId (string externalOrganizationId, string trustorId)
        {
             ApiResponse<ExternalOrganizationTrustorLink> localVarResponse = PutExternalcontactsOrganizationTrustorTrustorIdWithHttpInfo(externalOrganizationId, trustorId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Links a Trustor with an External Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>ApiResponse of ExternalOrganizationTrustorLink</returns>
        
        public ApiResponse< ExternalOrganizationTrustorLink > PutExternalcontactsOrganizationTrustorTrustorIdWithHttpInfo (string externalOrganizationId, string trustorId)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganizationTrustorTrustorId");
            // verify the required parameter 'trustorId' is set
            if (trustorId == null)
                throw new ApiException(400, "Missing required parameter 'trustorId' when calling ExternalContactsApi->PutExternalcontactsOrganizationTrustorTrustorId");

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor/{trustorId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (trustorId != null) localVarPathParams.Add("trustorId", this.Configuration.ApiClient.ParameterToString(trustorId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationTrustorTrustorId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationTrustorTrustorId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganizationTrustorLink>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganizationTrustorLink) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganizationTrustorLink)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Links a Trustor with an External Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>Task of ExternalOrganizationTrustorLink</returns>
        
        public async System.Threading.Tasks.Task<ExternalOrganizationTrustorLink> PutExternalcontactsOrganizationTrustorTrustorIdAsync (string externalOrganizationId, string trustorId)
        {
             ApiResponse<ExternalOrganizationTrustorLink> localVarResponse = await PutExternalcontactsOrganizationTrustorTrustorIdAsyncWithHttpInfo(externalOrganizationId, trustorId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Links a Trustor with an External Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>Task of ApiResponse (ExternalOrganizationTrustorLink)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganizationTrustorLink>> PutExternalcontactsOrganizationTrustorTrustorIdAsyncWithHttpInfo (string externalOrganizationId, string trustorId)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganizationTrustorTrustorId");
            
            // verify the required parameter 'trustorId' is set
            if (trustorId == null)
                throw new ApiException(400, "Missing required parameter 'trustorId' when calling ExternalContactsApi->PutExternalcontactsOrganizationTrustorTrustorId");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/{externalOrganizationId}/trustor/{trustorId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", this.Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (trustorId != null) localVarPathParams.Add("trustorId", this.Configuration.ApiClient.ParameterToString(trustorId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationTrustorTrustorId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationTrustorTrustorId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganizationTrustorLink>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganizationTrustorLink) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganizationTrustorLink)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>DataSchema</returns>
        
        public DataSchema PutExternalcontactsOrganizationsSchema (string schemaId, DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = PutExternalcontactsOrganizationsSchemaWithHttpInfo(schemaId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>ApiResponse of DataSchema</returns>
        
        public ApiResponse< DataSchema > PutExternalcontactsOrganizationsSchemaWithHttpInfo (string schemaId, DataSchema body)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->PutExternalcontactsOrganizationsSchema");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsOrganizationsSchema");

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of DataSchema</returns>
        
        public async System.Threading.Tasks.Task<DataSchema> PutExternalcontactsOrganizationsSchemaAsync (string schemaId, DataSchema body)
        {
             ApiResponse<DataSchema> localVarResponse = await PutExternalcontactsOrganizationsSchemaAsyncWithHttpInfo(schemaId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a schema 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="body">Data Schema</param>
        /// <returns>Task of ApiResponse (DataSchema)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<DataSchema>> PutExternalcontactsOrganizationsSchemaAsyncWithHttpInfo (string schemaId, DataSchema body)
        { 
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ExternalContactsApi->PutExternalcontactsOrganizationsSchema");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsOrganizationsSchema");
            

            var localVarPath = "/api/v2/externalcontacts/organizations/schemas/{schemaId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationsSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationsSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DataSchema>(localVarStatusCode,
                localVarHeaders,
                (DataSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSchema)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Relationship</returns>
        
        public Relationship PutExternalcontactsRelationship (string relationshipId, Relationship body)
        {
             ApiResponse<Relationship> localVarResponse = PutExternalcontactsRelationshipWithHttpInfo(relationshipId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>ApiResponse of Relationship</returns>
        
        public ApiResponse< Relationship > PutExternalcontactsRelationshipWithHttpInfo (string relationshipId, Relationship body)
        { 
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->PutExternalcontactsRelationship");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsRelationship");

            var localVarPath = "/api/v2/externalcontacts/relationships/{relationshipId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", this.Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        
        public async System.Threading.Tasks.Task<Relationship> PutExternalcontactsRelationshipAsync (string relationshipId, Relationship body)
        {
             ApiResponse<Relationship> localVarResponse = await PutExternalcontactsRelationshipAsyncWithHttpInfo(relationshipId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a relationship 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> PutExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId, Relationship body)
        { 
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->PutExternalcontactsRelationship");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalContactsApi->PutExternalcontactsRelationship");
            

            var localVarPath = "/api/v2/externalcontacts/relationships/{relationshipId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", this.Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
