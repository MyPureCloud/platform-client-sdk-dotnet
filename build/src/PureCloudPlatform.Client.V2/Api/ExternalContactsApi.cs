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
        /// <returns></returns>
        void DeleteExternalcontactsContact (string contactId);

        /// <summary>
        /// Delete an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
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
        /// <returns></returns>
        void DeleteExternalcontactsContactNote (string contactId, string noteId);

        /// <summary>
        /// Delete a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId);
        
        /// <summary>
        /// Delete an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns></returns>
        void DeleteExternalcontactsOrganization (string externalOrganizationId);

        /// <summary>
        /// Delete an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
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
        /// <returns></returns>
        void DeleteExternalcontactsOrganizationNote (string externalOrganizationId, string noteId);

        /// <summary>
        /// Delete a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
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
        /// <returns></returns>
        void DeleteExternalcontactsRelationship (string relationshipId);

        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of NoteListing</returns>
        ApiResponse<NoteListing> GetExternalcontactsContactNotesWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);
        
        /// <summary>
        /// Search for external contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of ContactListing</returns>
        ApiResponse<ContactListing> GetExternalcontactsContactsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null);
        
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="q">Search query (optional)</param>
        /// <param name="trustorId">Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>ApiResponse of ExternalOrganizationListing</returns>
        ApiResponse<ExternalOrganizationListing> GetExternalcontactsOrganizationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null);
        
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
        /// Lookup contacts and externalOrganizations based on an attribute
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
        /// Lookup contacts and externalOrganizations based on an attribute
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
        /// Create a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Note</returns>
        Note PostExternalcontactsContactNotes (string contactId, Note body = null);

        /// <summary>
        /// Create a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> PostExternalcontactsContactNotesWithHttpInfo (string contactId, Note body = null);
        
        /// <summary>
        /// Create an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ExternalContact</returns>
        ExternalContact PostExternalcontactsContacts (ExternalContact body = null);

        /// <summary>
        /// Create an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        ApiResponse<ExternalContact> PostExternalcontactsContactsWithHttpInfo (ExternalContact body = null);
        
        /// <summary>
        /// Create a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Note</returns>
        Note PostExternalcontactsOrganizationNotes (string externalOrganizationId, Note body = null);

        /// <summary>
        /// Create a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> PostExternalcontactsOrganizationNotesWithHttpInfo (string externalOrganizationId, Note body = null);
        
        /// <summary>
        /// Create an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>ExternalOrganization</returns>
        ExternalOrganization PostExternalcontactsOrganizations (ExternalOrganization body = null);

        /// <summary>
        /// Create an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        ApiResponse<ExternalOrganization> PostExternalcontactsOrganizationsWithHttpInfo (ExternalOrganization body = null);
        
        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Relationship</returns>
        Relationship PostExternalcontactsRelationships (Relationship body = null);

        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>ApiResponse of Relationship</returns>
        ApiResponse<Relationship> PostExternalcontactsRelationshipsWithHttpInfo (Relationship body = null);
        
        /// <summary>
        /// Update an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ExternalContact</returns>
        ExternalContact PutExternalcontactsContact (string contactId, ExternalContact body = null);

        /// <summary>
        /// Update an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        ApiResponse<ExternalContact> PutExternalcontactsContactWithHttpInfo (string contactId, ExternalContact body = null);
        
        /// <summary>
        /// Update a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Note</returns>
        Note PutExternalcontactsContactNote (string contactId, string noteId, Note body = null);

        /// <summary>
        /// Update a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> PutExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId, Note body = null);
        
        /// <summary>
        /// Associate an external contact with a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation (optional)</param>
        /// <returns></returns>
        void PutExternalcontactsConversation (string conversationId, ConversationAssociation body = null);

        /// <summary>
        /// Associate an external contact with a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutExternalcontactsConversationWithHttpInfo (string conversationId, ConversationAssociation body = null);
        
        /// <summary>
        /// Update an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>ExternalOrganization</returns>
        ExternalOrganization PutExternalcontactsOrganization (string externalOrganizationId, ExternalOrganization body = null);

        /// <summary>
        /// Update an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        ApiResponse<ExternalOrganization> PutExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null);
        
        /// <summary>
        /// Update a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Note</returns>
        Note PutExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, Note body = null);

        /// <summary>
        /// Update a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> PutExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId, Note body = null);
        
        /// <summary>
        /// Links a Trustor with an Extenral Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>ExternalOrganization</returns>
        ExternalOrganization PutExternalcontactsOrganizationTrustorTrustorId (string externalOrganizationId, string trustorId);

        /// <summary>
        /// Links a Trustor with an Extenral Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        ApiResponse<ExternalOrganization> PutExternalcontactsOrganizationTrustorTrustorIdWithHttpInfo (string externalOrganizationId, string trustorId);
        
        /// <summary>
        /// Update a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Relationship</returns>
        Relationship PutExternalcontactsRelationship (string relationshipId, Relationship body = null);

        /// <summary>
        /// Update a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>ApiResponse of Relationship</returns>
        ApiResponse<Relationship> PutExternalcontactsRelationshipWithHttpInfo (string relationshipId, Relationship body = null);
        
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
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalcontactsContactAsync (string contactId);

        /// <summary>
        /// Delete an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse</returns>
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
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalcontactsContactNoteAsync (string contactId, string noteId);

        /// <summary>
        /// Delete a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId);
        
        /// <summary>
        /// Delete an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalcontactsOrganizationAsync (string externalOrganizationId);

        /// <summary>
        /// Delete an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse</returns>
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
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId);

        /// <summary>
        /// Delete a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
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
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalcontactsRelationshipAsync (string relationshipId);

        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse</returns>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (NoteListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null);
        
        /// <summary>
        /// Search for external contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported) (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (ContactListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetExternalcontactsContactsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null);
        
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="q">Search query (optional)</param>
        /// <param name="trustorId">Search for external organizations by trustorIds (limit 25). If supplied, the &#39;q&#39; parameters is ignored. Items are returned in the order requested (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <param name="expand">which fields, if any, to expand (optional)</param>
        /// <param name="includeTrustors">(true or false) whether or not to include trustor information embedded in the externalOrganization (optional)</param>
        /// <returns>Task of ApiResponse (ExternalOrganizationListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganizationListing>> GetExternalcontactsOrganizationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, List<string> trustorId = null, string sortOrder = null, List<string> expand = null, bool? includeTrustors = null);
        
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
        /// Lookup contacts and externalOrganizations based on an attribute
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
        /// Lookup contacts and externalOrganizations based on an attribute
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
        /// Create a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> PostExternalcontactsContactNotesAsync (string contactId, Note body = null);

        /// <summary>
        /// Create a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, Note body = null);
        
        /// <summary>
        /// Create an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ExternalContact</returns>
        System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsContactsAsync (ExternalContact body = null);

        /// <summary>
        /// Create an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsContactsAsyncWithHttpInfo (ExternalContact body = null);
        
        /// <summary>
        /// Create a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> PostExternalcontactsOrganizationNotesAsync (string externalOrganizationId, Note body = null);

        /// <summary>
        /// Create a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsOrganizationNotesAsyncWithHttpInfo (string externalOrganizationId, Note body = null);
        
        /// <summary>
        /// Create an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>Task of ExternalOrganization</returns>
        System.Threading.Tasks.Task<ExternalOrganization> PostExternalcontactsOrganizationsAsync (ExternalOrganization body = null);

        /// <summary>
        /// Create an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PostExternalcontactsOrganizationsAsyncWithHttpInfo (ExternalOrganization body = null);
        
        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Task of Relationship</returns>
        System.Threading.Tasks.Task<Relationship> PostExternalcontactsRelationshipsAsync (Relationship body = null);

        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<Relationship>> PostExternalcontactsRelationshipsAsyncWithHttpInfo (Relationship body = null);
        
        /// <summary>
        /// Update an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ExternalContact</returns>
        System.Threading.Tasks.Task<ExternalContact> PutExternalcontactsContactAsync (string contactId, ExternalContact body = null);

        /// <summary>
        /// Update an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PutExternalcontactsContactAsyncWithHttpInfo (string contactId, ExternalContact body = null);
        
        /// <summary>
        /// Update a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> PutExternalcontactsContactNoteAsync (string contactId, string noteId, Note body = null);

        /// <summary>
        /// Update a note for an external contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId, Note body = null);
        
        /// <summary>
        /// Associate an external contact with a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutExternalcontactsConversationAsync (string conversationId, ConversationAssociation body = null);

        /// <summary>
        /// Associate an external contact with a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutExternalcontactsConversationAsyncWithHttpInfo (string conversationId, ConversationAssociation body = null);
        
        /// <summary>
        /// Update an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>Task of ExternalOrganization</returns>
        System.Threading.Tasks.Task<ExternalOrganization> PutExternalcontactsOrganizationAsync (string externalOrganizationId, ExternalOrganization body = null);

        /// <summary>
        /// Update an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PutExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null);
        
        /// <summary>
        /// Update a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> PutExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId, Note body = null);

        /// <summary>
        /// Update a note for an external organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId, Note body = null);
        
        /// <summary>
        /// Links a Trustor with an Extenral Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>Task of ExternalOrganization</returns>
        System.Threading.Tasks.Task<ExternalOrganization> PutExternalcontactsOrganizationTrustorTrustorIdAsync (string externalOrganizationId, string trustorId);

        /// <summary>
        /// Links a Trustor with an Extenral Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PutExternalcontactsOrganizationTrustorTrustorIdAsyncWithHttpInfo (string externalOrganizationId, string trustorId);
        
        /// <summary>
        /// Update a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Task of Relationship</returns>
        System.Threading.Tasks.Task<Relationship> PutExternalcontactsRelationshipAsync (string relationshipId, Relationship body = null);

        /// <summary>
        /// Update a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<Relationship>> PutExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId, Relationship body = null);
        
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
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
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
        public ExternalContactsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
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
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
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
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        
        /// <summary>
        /// Delete an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns></returns>
        public void DeleteExternalcontactsContact (string contactId)
        {
             DeleteExternalcontactsContactWithHttpInfo(contactId);
        }

        /// <summary>
        /// Delete an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalcontactsContactWithHttpInfo (string contactId)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalcontactsContactAsync (string contactId)
        {
             await DeleteExternalcontactsContactAsyncWithHttpInfo(contactId);

        }

        /// <summary>
        /// Delete an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse</returns>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Delete a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns></returns>
        public void DeleteExternalcontactsContactNote (string contactId, string noteId)
        {
             DeleteExternalcontactsContactNoteWithHttpInfo(contactId, noteId);
        }

        /// <summary>
        /// Delete a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalcontactsContactNoteAsync (string contactId, string noteId)
        {
             await DeleteExternalcontactsContactNoteAsyncWithHttpInfo(contactId, noteId);

        }

        /// <summary>
        /// Delete a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Delete an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns></returns>
        public void DeleteExternalcontactsOrganization (string externalOrganizationId)
        {
             DeleteExternalcontactsOrganizationWithHttpInfo(externalOrganizationId);
        }

        /// <summary>
        /// Delete an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalcontactsOrganizationAsync (string externalOrganizationId)
        {
             await DeleteExternalcontactsOrganizationAsyncWithHttpInfo(externalOrganizationId);

        }

        /// <summary>
        /// Delete an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse</returns>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Delete a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns></returns>
        public void DeleteExternalcontactsOrganizationNote (string externalOrganizationId, string noteId)
        {
             DeleteExternalcontactsOrganizationNoteWithHttpInfo(externalOrganizationId, noteId);
        }

        /// <summary>
        /// Delete a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId)
        {
             await DeleteExternalcontactsOrganizationNoteAsyncWithHttpInfo(externalOrganizationId, noteId);

        }

        /// <summary>
        /// Delete a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Unlink the Trustor for this External Organization 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationTrustor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationTrustor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Unlink the Trustor for this External Organization 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationTrustor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsOrganizationTrustor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns></returns>
        public void DeleteExternalcontactsRelationship (string relationshipId)
        {
             DeleteExternalcontactsRelationshipWithHttpInfo(relationshipId);
        }

        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalcontactsRelationshipWithHttpInfo (string relationshipId)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalcontactsRelationshipAsync (string relationshipId)
        {
             await DeleteExternalcontactsRelationshipAsyncWithHttpInfo(relationshipId);

        }

        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse</returns>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Fetch an external contact 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)));
            
        }

        
        /// <summary>
        /// Fetch an external contact 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)));
            
        }

        
        
        /// <summary>
        /// Fetch a note for an external contact 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        /// <summary>
        /// Fetch a note for an external contact 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        
        /// <summary>
        /// List notes for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NoteListing>(localVarStatusCode,
                localVarHeaders,
                (NoteListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NoteListing)));
            
        }

        
        /// <summary>
        /// List notes for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContactNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NoteListing>(localVarStatusCode,
                localVarHeaders,
                (NoteListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NoteListing)));
            
        }

        
        
        /// <summary>
        /// Search for external contacts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", Configuration.ApiClient.ParameterToString(q)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListing>(localVarStatusCode,
                localVarHeaders,
                (ContactListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListing)));
            
        }

        
        /// <summary>
        /// Search for external contacts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", Configuration.ApiClient.ParameterToString(q)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListing>(localVarStatusCode,
                localVarHeaders,
                (ContactListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListing)));
            
        }

        
        
        /// <summary>
        /// Fetch an external organization 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
            if (includeTrustors != null) localVarQueryParams.Add(new Tuple<string, string>("includeTrustors", Configuration.ApiClient.ParameterToString(includeTrustors)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)));
            
        }

        
        /// <summary>
        /// Fetch an external organization 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
            if (includeTrustors != null) localVarQueryParams.Add(new Tuple<string, string>("includeTrustors", Configuration.ApiClient.ParameterToString(includeTrustors)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)));
            
        }

        
        
        /// <summary>
        /// Search for external contacts in an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", Configuration.ApiClient.ParameterToString(q)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListing>(localVarStatusCode,
                localVarHeaders,
                (ContactListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListing)));
            
        }

        
        /// <summary>
        /// Search for external contacts in an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", Configuration.ApiClient.ParameterToString(q)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListing>(localVarStatusCode,
                localVarHeaders,
                (ContactListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListing)));
            
        }

        
        
        /// <summary>
        /// Fetch a note for an external organization 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        /// <summary>
        /// Fetch a note for an external organization 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        
        /// <summary>
        /// List notes for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NoteListing>(localVarStatusCode,
                localVarHeaders,
                (NoteListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NoteListing)));
            
        }

        
        /// <summary>
        /// List notes for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NoteListing>(localVarStatusCode,
                localVarHeaders,
                (NoteListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NoteListing)));
            
        }

        
        
        /// <summary>
        /// Fetch a relationship for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RelationshipListing>(localVarStatusCode,
                localVarHeaders,
                (RelationshipListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RelationshipListing)));
            
        }

        
        /// <summary>
        /// Fetch a relationship for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RelationshipListing>(localVarStatusCode,
                localVarHeaders,
                (RelationshipListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RelationshipListing)));
            
        }

        
        
        /// <summary>
        /// Search for external organizations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", Configuration.ApiClient.ParameterToString(q)));
            if (trustorId != null) trustorId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("trustorId", Configuration.ApiClient.ParameterToString(obj))); });
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (includeTrustors != null) localVarQueryParams.Add(new Tuple<string, string>("includeTrustors", Configuration.ApiClient.ParameterToString(includeTrustors)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganizationListing>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganizationListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganizationListing)));
            
        }

        
        /// <summary>
        /// Search for external organizations 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 20)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (q != null) localVarQueryParams.Add(new Tuple<string, string>("q", Configuration.ApiClient.ParameterToString(q)));
            if (trustorId != null) trustorId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("trustorId", Configuration.ApiClient.ParameterToString(obj))); });
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (includeTrustors != null) localVarQueryParams.Add(new Tuple<string, string>("includeTrustors", Configuration.ApiClient.ParameterToString(includeTrustors)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganizationListing>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganizationListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganizationListing)));
            
        }

        
        
        /// <summary>
        /// Fetch a relationship 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)));
            
        }

        
        /// <summary>
        /// Fetch a relationship 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)));
            
        }

        
        
        /// <summary>
        /// Lookup contacts and externalOrganizations based on an attribute 
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
        /// Lookup contacts and externalOrganizations based on an attribute 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (lookupVal != null) localVarQueryParams.Add(new Tuple<string, string>("lookupVal", Configuration.ApiClient.ParameterToString(lookupVal)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsReversewhitepageslookup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsReversewhitepageslookup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReverseWhitepagesLookupResult>(localVarStatusCode,
                localVarHeaders,
                (ReverseWhitepagesLookupResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReverseWhitepagesLookupResult)));
            
        }

        
        /// <summary>
        /// Lookup contacts and externalOrganizations based on an attribute 
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
        /// Lookup contacts and externalOrganizations based on an attribute 
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (lookupVal != null) localVarQueryParams.Add(new Tuple<string, string>("lookupVal", Configuration.ApiClient.ParameterToString(lookupVal)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsReversewhitepageslookup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalcontactsReversewhitepageslookup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReverseWhitepagesLookupResult>(localVarStatusCode,
                localVarHeaders,
                (ReverseWhitepagesLookupResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReverseWhitepagesLookupResult)));
            
        }

        
        
        /// <summary>
        /// Create a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Note</returns>
        public Note PostExternalcontactsContactNotes (string contactId, Note body = null)
        {
             ApiResponse<Note> localVarResponse = PostExternalcontactsContactNotesWithHttpInfo(contactId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PostExternalcontactsContactNotesWithHttpInfo (string contactId, Note body = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PostExternalcontactsContactNotes");

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        /// <summary>
        /// Create a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of Note</returns>
        public async System.Threading.Tasks.Task<Note> PostExternalcontactsContactNotesAsync (string contactId, Note body = null)
        {
             ApiResponse<Note> localVarResponse = await PostExternalcontactsContactNotesAsyncWithHttpInfo(contactId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, Note body = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PostExternalcontactsContactNotes");
            

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContactNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        
        /// <summary>
        /// Create an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ExternalContact</returns>
        public ExternalContact PostExternalcontactsContacts (ExternalContact body = null)
        {
             ApiResponse<ExternalContact> localVarResponse = PostExternalcontactsContactsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        public ApiResponse< ExternalContact > PostExternalcontactsContactsWithHttpInfo (ExternalContact body = null)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)));
            
        }

        
        /// <summary>
        /// Create an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ExternalContact</returns>
        public async System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsContactsAsync (ExternalContact body = null)
        {
             ApiResponse<ExternalContact> localVarResponse = await PostExternalcontactsContactsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsContactsAsyncWithHttpInfo (ExternalContact body = null)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)));
            
        }

        
        
        /// <summary>
        /// Create a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Note</returns>
        public Note PostExternalcontactsOrganizationNotes (string externalOrganizationId, Note body = null)
        {
             ApiResponse<Note> localVarResponse = PostExternalcontactsOrganizationNotesWithHttpInfo(externalOrganizationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PostExternalcontactsOrganizationNotesWithHttpInfo (string externalOrganizationId, Note body = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PostExternalcontactsOrganizationNotes");

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        /// <summary>
        /// Create a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of Note</returns>
        public async System.Threading.Tasks.Task<Note> PostExternalcontactsOrganizationNotesAsync (string externalOrganizationId, Note body = null)
        {
             ApiResponse<Note> localVarResponse = await PostExternalcontactsOrganizationNotesAsyncWithHttpInfo(externalOrganizationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsOrganizationNotesAsyncWithHttpInfo (string externalOrganizationId, Note body = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PostExternalcontactsOrganizationNotes");
            

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationNotes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizationNotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        
        /// <summary>
        /// Create an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>ExternalOrganization</returns>
        public ExternalOrganization PostExternalcontactsOrganizations (ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> localVarResponse = PostExternalcontactsOrganizationsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        public ApiResponse< ExternalOrganization > PostExternalcontactsOrganizationsWithHttpInfo (ExternalOrganization body = null)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)));
            
        }

        
        /// <summary>
        /// Create an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>Task of ExternalOrganization</returns>
        public async System.Threading.Tasks.Task<ExternalOrganization> PostExternalcontactsOrganizationsAsync (ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> localVarResponse = await PostExternalcontactsOrganizationsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PostExternalcontactsOrganizationsAsyncWithHttpInfo (ExternalOrganization body = null)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)));
            
        }

        
        
        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Relationship</returns>
        public Relationship PostExternalcontactsRelationships (Relationship body = null)
        {
             ApiResponse<Relationship> localVarResponse = PostExternalcontactsRelationshipsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>ApiResponse of Relationship</returns>
        public ApiResponse< Relationship > PostExternalcontactsRelationshipsWithHttpInfo (Relationship body = null)
        { 

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)));
            
        }

        
        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Task of Relationship</returns>
        public async System.Threading.Tasks.Task<Relationship> PostExternalcontactsRelationshipsAsync (Relationship body = null)
        {
             ApiResponse<Relationship> localVarResponse = await PostExternalcontactsRelationshipsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> PostExternalcontactsRelationshipsAsyncWithHttpInfo (Relationship body = null)
        { 

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsRelationships: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExternalcontactsRelationships: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)));
            
        }

        
        
        /// <summary>
        /// Update an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ExternalContact</returns>
        public ExternalContact PutExternalcontactsContact (string contactId, ExternalContact body = null)
        {
             ApiResponse<ExternalContact> localVarResponse = PutExternalcontactsContactWithHttpInfo(contactId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        public ApiResponse< ExternalContact > PutExternalcontactsContactWithHttpInfo (string contactId, ExternalContact body = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutExternalcontactsContact");

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)));
            
        }

        
        /// <summary>
        /// Update an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ExternalContact</returns>
        public async System.Threading.Tasks.Task<ExternalContact> PutExternalcontactsContactAsync (string contactId, ExternalContact body = null)
        {
             ApiResponse<ExternalContact> localVarResponse = await PutExternalcontactsContactAsyncWithHttpInfo(contactId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact (optional)</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PutExternalcontactsContactAsyncWithHttpInfo (string contactId, ExternalContact body = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutExternalcontactsContact");
            

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalContact>(localVarStatusCode,
                localVarHeaders,
                (ExternalContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalContact)));
            
        }

        
        
        /// <summary>
        /// Update a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Note</returns>
        public Note PutExternalcontactsContactNote (string contactId, string noteId, Note body = null)
        {
             ApiResponse<Note> localVarResponse = PutExternalcontactsContactNoteWithHttpInfo(contactId, noteId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PutExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId, Note body = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutExternalcontactsContactNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutExternalcontactsContactNote");

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        /// <summary>
        /// Update a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Task of Note</returns>
        public async System.Threading.Tasks.Task<Note> PutExternalcontactsContactNoteAsync (string contactId, string noteId, Note body = null)
        {
             ApiResponse<Note> localVarResponse = await PutExternalcontactsContactNoteAsyncWithHttpInfo(contactId, noteId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a note for an external contact 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId, Note body = null)
        { 
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutExternalcontactsContactNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutExternalcontactsContactNote");
            

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsContactNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        
        /// <summary>
        /// Associate an external contact with a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation (optional)</param>
        /// <returns></returns>
        public void PutExternalcontactsConversation (string conversationId, ConversationAssociation body = null)
        {
             PutExternalcontactsConversationWithHttpInfo(conversationId, body);
        }

        /// <summary>
        /// Associate an external contact with a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PutExternalcontactsConversationWithHttpInfo (string conversationId, ConversationAssociation body = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ExternalContactsApi->PutExternalcontactsConversation");

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Associate an external contact with a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PutExternalcontactsConversationAsync (string conversationId, ConversationAssociation body = null)
        {
             await PutExternalcontactsConversationAsyncWithHttpInfo(conversationId, body);

        }

        /// <summary>
        /// Associate an external contact with a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="body">ConversationAssociation (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutExternalcontactsConversationAsyncWithHttpInfo (string conversationId, ConversationAssociation body = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ExternalContactsApi->PutExternalcontactsConversation");
            

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Update an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>ExternalOrganization</returns>
        public ExternalOrganization PutExternalcontactsOrganization (string externalOrganizationId, ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> localVarResponse = PutExternalcontactsOrganizationWithHttpInfo(externalOrganizationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        public ApiResponse< ExternalOrganization > PutExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganization");

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)));
            
        }

        
        /// <summary>
        /// Update an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>Task of ExternalOrganization</returns>
        public async System.Threading.Tasks.Task<ExternalOrganization> PutExternalcontactsOrganizationAsync (string externalOrganizationId, ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> localVarResponse = await PutExternalcontactsOrganizationAsyncWithHttpInfo(externalOrganizationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization (optional)</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PutExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganization");
            

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)));
            
        }

        
        
        /// <summary>
        /// Update a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Note</returns>
        public Note PutExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, Note body = null)
        {
             ApiResponse<Note> localVarResponse = PutExternalcontactsOrganizationNoteWithHttpInfo(externalOrganizationId, noteId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PutExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId, Note body = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        /// <summary>
        /// Update a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Task of Note</returns>
        public async System.Threading.Tasks.Task<Note> PutExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId, Note body = null)
        {
             ApiResponse<Note> localVarResponse = await PutExternalcontactsOrganizationNoteAsyncWithHttpInfo(externalOrganizationId, noteId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a note for an external organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note (optional)</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId, Note body = null)
        { 
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");
            

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (noteId != null) localVarPathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationNote: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationNote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Note>(localVarStatusCode,
                localVarHeaders,
                (Note) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Note)));
            
        }

        
        
        /// <summary>
        /// Links a Trustor with an Extenral Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>ExternalOrganization</returns>
        public ExternalOrganization PutExternalcontactsOrganizationTrustorTrustorId (string externalOrganizationId, string trustorId)
        {
             ApiResponse<ExternalOrganization> localVarResponse = PutExternalcontactsOrganizationTrustorTrustorIdWithHttpInfo(externalOrganizationId, trustorId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Links a Trustor with an Extenral Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        public ApiResponse< ExternalOrganization > PutExternalcontactsOrganizationTrustorTrustorIdWithHttpInfo (string externalOrganizationId, string trustorId)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (trustorId != null) localVarPathParams.Add("trustorId", Configuration.ApiClient.ParameterToString(trustorId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationTrustorTrustorId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationTrustorTrustorId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)));
            
        }

        
        /// <summary>
        /// Links a Trustor with an Extenral Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>Task of ExternalOrganization</returns>
        public async System.Threading.Tasks.Task<ExternalOrganization> PutExternalcontactsOrganizationTrustorTrustorIdAsync (string externalOrganizationId, string trustorId)
        {
             ApiResponse<ExternalOrganization> localVarResponse = await PutExternalcontactsOrganizationTrustorTrustorIdAsyncWithHttpInfo(externalOrganizationId, trustorId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Links a Trustor with an Extenral Organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="trustorId">Trustor ID</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PutExternalcontactsOrganizationTrustorTrustorIdAsyncWithHttpInfo (string externalOrganizationId, string trustorId)
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (externalOrganizationId != null) localVarPathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId));
            if (trustorId != null) localVarPathParams.Add("trustorId", Configuration.ApiClient.ParameterToString(trustorId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationTrustorTrustorId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsOrganizationTrustorTrustorId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(localVarStatusCode,
                localVarHeaders,
                (ExternalOrganization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalOrganization)));
            
        }

        
        
        /// <summary>
        /// Update a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Relationship</returns>
        public Relationship PutExternalcontactsRelationship (string relationshipId, Relationship body = null)
        {
             ApiResponse<Relationship> localVarResponse = PutExternalcontactsRelationshipWithHttpInfo(relationshipId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>ApiResponse of Relationship</returns>
        public ApiResponse< Relationship > PutExternalcontactsRelationshipWithHttpInfo (string relationshipId, Relationship body = null)
        { 
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->PutExternalcontactsRelationship");

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)));
            
        }

        
        /// <summary>
        /// Update a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Task of Relationship</returns>
        public async System.Threading.Tasks.Task<Relationship> PutExternalcontactsRelationshipAsync (string relationshipId, Relationship body = null)
        {
             ApiResponse<Relationship> localVarResponse = await PutExternalcontactsRelationshipAsyncWithHttpInfo(relationshipId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a relationship 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship (optional)</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> PutExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId, Relationship body = null)
        { 
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->PutExternalcontactsRelationship");
            

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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (relationshipId != null) localVarPathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsRelationship: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExternalcontactsRelationship: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Relationship>(localVarStatusCode,
                localVarHeaders,
                (Relationship) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Relationship)));
            
        }

        
        
    }
    
}
