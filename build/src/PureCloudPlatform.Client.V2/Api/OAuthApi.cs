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
    public interface IOAuthApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns></returns>
        void DeleteOauthClient (string clientId);

        /// <summary>
        /// Delete OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOauthClientWithHttpInfo (string clientId);
        
        /// <summary>
        /// Get a client that is authorized by the resource owner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The ID of client</param>
        /// <returns>OAuthAuthorization</returns>
        OAuthAuthorization GetOauthAuthorization (string clientId);

        /// <summary>
        /// Get a client that is authorized by the resource owner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The ID of client</param>
        /// <returns>ApiResponse of OAuthAuthorization</returns>
        ApiResponse<OAuthAuthorization> GetOauthAuthorizationWithHttpInfo (string clientId);
        
        /// <summary>
        /// List clients that are authorized by the resource owner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OAuthAuthorizationListing</returns>
        OAuthAuthorizationListing GetOauthAuthorizations ();

        /// <summary>
        /// List clients that are authorized by the resource owner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OAuthAuthorizationListing</returns>
        ApiResponse<OAuthAuthorizationListing> GetOauthAuthorizationsWithHttpInfo ();
        
        /// <summary>
        /// Get OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>OAuthClient</returns>
        OAuthClient GetOauthClient (string clientId);

        /// <summary>
        /// Get OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        ApiResponse<OAuthClient> GetOauthClientWithHttpInfo (string clientId);
        
        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiUsageQueryResult</returns>
        ApiUsageQueryResult GetOauthClientUsageQueryResult (string executionId, string clientId);

        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of ApiUsageQueryResult</returns>
        ApiResponse<ApiUsageQueryResult> GetOauthClientUsageQueryResultWithHttpInfo (string executionId, string clientId);
        
        /// <summary>
        /// Get a summary of OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to 7)</param>
        /// <returns>UsageExecutionResult</returns>
        UsageExecutionResult GetOauthClientUsageSummary (string clientId, string days = null);

        /// <summary>
        /// Get a summary of OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to 7)</param>
        /// <returns>ApiResponse of UsageExecutionResult</returns>
        ApiResponse<UsageExecutionResult> GetOauthClientUsageSummaryWithHttpInfo (string clientId, string days = null);
        
        /// <summary>
        /// The list of OAuth clients
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OAuthClientEntityListing</returns>
        OAuthClientEntityListing GetOauthClients ();

        /// <summary>
        /// The list of OAuth clients
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OAuthClientEntityListing</returns>
        ApiResponse<OAuthClientEntityListing> GetOauthClientsWithHttpInfo ();
        
        /// <summary>
        /// An OAuth scope
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scopeId">Scope ID</param>
        /// <param name="acceptLanguage">The language with which to display the scope description. (optional, default to en-us)</param>
        /// <returns>OAuthScope</returns>
        OAuthScope GetOauthScope (string scopeId, string acceptLanguage = null);

        /// <summary>
        /// An OAuth scope
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scopeId">Scope ID</param>
        /// <param name="acceptLanguage">The language with which to display the scope description. (optional, default to en-us)</param>
        /// <returns>ApiResponse of OAuthScope</returns>
        ApiResponse<OAuthScope> GetOauthScopeWithHttpInfo (string scopeId, string acceptLanguage = null);
        
        /// <summary>
        /// The list of OAuth scopes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The language with which to display the scope descriptions. (optional, default to en-us)</param>
        /// <returns>OAuthScopeListing</returns>
        OAuthScopeListing GetOauthScopes (string acceptLanguage = null);

        /// <summary>
        /// The list of OAuth scopes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The language with which to display the scope descriptions. (optional, default to en-us)</param>
        /// <returns>ApiResponse of OAuthScopeListing</returns>
        ApiResponse<OAuthScopeListing> GetOauthScopesWithHttpInfo (string acceptLanguage = null);
        
        /// <summary>
        /// Regenerate Client Secret
        /// </summary>
        /// <remarks>
        /// This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>OAuthClient</returns>
        OAuthClient PostOauthClientSecret (string clientId);

        /// <summary>
        /// Regenerate Client Secret
        /// </summary>
        /// <remarks>
        /// This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        ApiResponse<OAuthClient> PostOauthClientSecretWithHttpInfo (string clientId);
        
        /// <summary>
        /// Query for OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>UsageExecutionResult</returns>
        UsageExecutionResult PostOauthClientUsageQuery (string clientId, ApiUsageQuery body);

        /// <summary>
        /// Query for OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>ApiResponse of UsageExecutionResult</returns>
        ApiResponse<UsageExecutionResult> PostOauthClientUsageQueryWithHttpInfo (string clientId, ApiUsageQuery body);
        
        /// <summary>
        /// Create OAuth client
        /// </summary>
        /// <remarks>
        /// The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud.  The preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server.  If the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps.  If a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles  via the &#39;roleIds&#39; field.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Client</param>
        /// <returns>OAuthClient</returns>
        OAuthClient PostOauthClients (OAuthClientRequest body);

        /// <summary>
        /// Create OAuth client
        /// </summary>
        /// <remarks>
        /// The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud.  The preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server.  If the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps.  If a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles  via the &#39;roleIds&#39; field.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Client</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        ApiResponse<OAuthClient> PostOauthClientsWithHttpInfo (OAuthClientRequest body);
        
        /// <summary>
        /// Update OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>OAuthClient</returns>
        OAuthClient PutOauthClient (string clientId, OAuthClientRequest body);

        /// <summary>
        /// Update OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        ApiResponse<OAuthClient> PutOauthClientWithHttpInfo (string clientId, OAuthClientRequest body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOauthClientAsync (string clientId);

        /// <summary>
        /// Delete OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOauthClientAsyncWithHttpInfo (string clientId);
        
        /// <summary>
        /// Get a client that is authorized by the resource owner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The ID of client</param>
        /// <returns>Task of OAuthAuthorization</returns>
        System.Threading.Tasks.Task<OAuthAuthorization> GetOauthAuthorizationAsync (string clientId);

        /// <summary>
        /// Get a client that is authorized by the resource owner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The ID of client</param>
        /// <returns>Task of ApiResponse (OAuthAuthorization)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthAuthorization>> GetOauthAuthorizationAsyncWithHttpInfo (string clientId);
        
        /// <summary>
        /// List clients that are authorized by the resource owner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OAuthAuthorizationListing</returns>
        System.Threading.Tasks.Task<OAuthAuthorizationListing> GetOauthAuthorizationsAsync ();

        /// <summary>
        /// List clients that are authorized by the resource owner
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OAuthAuthorizationListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthAuthorizationListing>> GetOauthAuthorizationsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of OAuthClient</returns>
        System.Threading.Tasks.Task<OAuthClient> GetOauthClientAsync (string clientId);

        /// <summary>
        /// Get OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthClient>> GetOauthClientAsyncWithHttpInfo (string clientId);
        
        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiUsageQueryResult</returns>
        System.Threading.Tasks.Task<ApiUsageQueryResult> GetOauthClientUsageQueryResultAsync (string executionId, string clientId);

        /// <summary>
        /// Get the results of a usage query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (ApiUsageQueryResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiUsageQueryResult>> GetOauthClientUsageQueryResultAsyncWithHttpInfo (string executionId, string clientId);
        
        /// <summary>
        /// Get a summary of OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to 7)</param>
        /// <returns>Task of UsageExecutionResult</returns>
        System.Threading.Tasks.Task<UsageExecutionResult> GetOauthClientUsageSummaryAsync (string clientId, string days = null);

        /// <summary>
        /// Get a summary of OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to 7)</param>
        /// <returns>Task of ApiResponse (UsageExecutionResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsageExecutionResult>> GetOauthClientUsageSummaryAsyncWithHttpInfo (string clientId, string days = null);
        
        /// <summary>
        /// The list of OAuth clients
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OAuthClientEntityListing</returns>
        System.Threading.Tasks.Task<OAuthClientEntityListing> GetOauthClientsAsync ();

        /// <summary>
        /// The list of OAuth clients
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OAuthClientEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthClientEntityListing>> GetOauthClientsAsyncWithHttpInfo ();
        
        /// <summary>
        /// An OAuth scope
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scopeId">Scope ID</param>
        /// <param name="acceptLanguage">The language with which to display the scope description. (optional, default to en-us)</param>
        /// <returns>Task of OAuthScope</returns>
        System.Threading.Tasks.Task<OAuthScope> GetOauthScopeAsync (string scopeId, string acceptLanguage = null);

        /// <summary>
        /// An OAuth scope
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scopeId">Scope ID</param>
        /// <param name="acceptLanguage">The language with which to display the scope description. (optional, default to en-us)</param>
        /// <returns>Task of ApiResponse (OAuthScope)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthScope>> GetOauthScopeAsyncWithHttpInfo (string scopeId, string acceptLanguage = null);
        
        /// <summary>
        /// The list of OAuth scopes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The language with which to display the scope descriptions. (optional, default to en-us)</param>
        /// <returns>Task of OAuthScopeListing</returns>
        System.Threading.Tasks.Task<OAuthScopeListing> GetOauthScopesAsync (string acceptLanguage = null);

        /// <summary>
        /// The list of OAuth scopes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The language with which to display the scope descriptions. (optional, default to en-us)</param>
        /// <returns>Task of ApiResponse (OAuthScopeListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthScopeListing>> GetOauthScopesAsyncWithHttpInfo (string acceptLanguage = null);
        
        /// <summary>
        /// Regenerate Client Secret
        /// </summary>
        /// <remarks>
        /// This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of OAuthClient</returns>
        System.Threading.Tasks.Task<OAuthClient> PostOauthClientSecretAsync (string clientId);

        /// <summary>
        /// Regenerate Client Secret
        /// </summary>
        /// <remarks>
        /// This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthClient>> PostOauthClientSecretAsyncWithHttpInfo (string clientId);
        
        /// <summary>
        /// Query for OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>Task of UsageExecutionResult</returns>
        System.Threading.Tasks.Task<UsageExecutionResult> PostOauthClientUsageQueryAsync (string clientId, ApiUsageQuery body);

        /// <summary>
        /// Query for OAuth client API usage
        /// </summary>
        /// <remarks>
        /// After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>Task of ApiResponse (UsageExecutionResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsageExecutionResult>> PostOauthClientUsageQueryAsyncWithHttpInfo (string clientId, ApiUsageQuery body);
        
        /// <summary>
        /// Create OAuth client
        /// </summary>
        /// <remarks>
        /// The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud.  The preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server.  If the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps.  If a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles  via the &#39;roleIds&#39; field.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Client</param>
        /// <returns>Task of OAuthClient</returns>
        System.Threading.Tasks.Task<OAuthClient> PostOauthClientsAsync (OAuthClientRequest body);

        /// <summary>
        /// Create OAuth client
        /// </summary>
        /// <remarks>
        /// The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud.  The preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server.  If the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps.  If a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles  via the &#39;roleIds&#39; field.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Client</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthClient>> PostOauthClientsAsyncWithHttpInfo (OAuthClientRequest body);
        
        /// <summary>
        /// Update OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>Task of OAuthClient</returns>
        System.Threading.Tasks.Task<OAuthClient> PutOauthClientAsync (string clientId, OAuthClientRequest body);

        /// <summary>
        /// Update OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthClient>> PutOauthClientAsyncWithHttpInfo (string clientId, OAuthClientRequest body);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OAuthApi : IOAuthApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OAuthApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OAuthApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
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
        /// Delete OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns></returns>
        public void DeleteOauthClient (string clientId)
        {
             DeleteOauthClientWithHttpInfo(clientId);
        }

        /// <summary>
        /// Delete OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOauthClientWithHttpInfo (string clientId)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->DeleteOauthClient");

            var localVarPath = "/api/v2/oauth/clients/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOauthClient: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOauthClient: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOauthClientAsync (string clientId)
        {
             await DeleteOauthClientAsyncWithHttpInfo(clientId);

        }

        /// <summary>
        /// Delete OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOauthClientAsyncWithHttpInfo (string clientId)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->DeleteOauthClient");
            

            var localVarPath = "/api/v2/oauth/clients/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOauthClient: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOauthClient: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a client that is authorized by the resource owner 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The ID of client</param>
        /// <returns>OAuthAuthorization</returns>
        public OAuthAuthorization GetOauthAuthorization (string clientId)
        {
             ApiResponse<OAuthAuthorization> localVarResponse = GetOauthAuthorizationWithHttpInfo(clientId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a client that is authorized by the resource owner 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The ID of client</param>
        /// <returns>ApiResponse of OAuthAuthorization</returns>
        public ApiResponse< OAuthAuthorization > GetOauthAuthorizationWithHttpInfo (string clientId)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->GetOauthAuthorization");

            var localVarPath = "/api/v2/oauth/authorizations/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthAuthorization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthAuthorization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthAuthorization>(localVarStatusCode,
                localVarHeaders,
                (OAuthAuthorization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthAuthorization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a client that is authorized by the resource owner 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The ID of client</param>
        /// <returns>Task of OAuthAuthorization</returns>
        public async System.Threading.Tasks.Task<OAuthAuthorization> GetOauthAuthorizationAsync (string clientId)
        {
             ApiResponse<OAuthAuthorization> localVarResponse = await GetOauthAuthorizationAsyncWithHttpInfo(clientId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a client that is authorized by the resource owner 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The ID of client</param>
        /// <returns>Task of ApiResponse (OAuthAuthorization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthAuthorization>> GetOauthAuthorizationAsyncWithHttpInfo (string clientId)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->GetOauthAuthorization");
            

            var localVarPath = "/api/v2/oauth/authorizations/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthAuthorization: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthAuthorization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthAuthorization>(localVarStatusCode,
                localVarHeaders,
                (OAuthAuthorization) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthAuthorization)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// List clients that are authorized by the resource owner 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OAuthAuthorizationListing</returns>
        public OAuthAuthorizationListing GetOauthAuthorizations ()
        {
             ApiResponse<OAuthAuthorizationListing> localVarResponse = GetOauthAuthorizationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List clients that are authorized by the resource owner 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OAuthAuthorizationListing</returns>
        public ApiResponse< OAuthAuthorizationListing > GetOauthAuthorizationsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/oauth/authorizations";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthAuthorizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthAuthorizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthAuthorizationListing>(localVarStatusCode,
                localVarHeaders,
                (OAuthAuthorizationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthAuthorizationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// List clients that are authorized by the resource owner 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OAuthAuthorizationListing</returns>
        public async System.Threading.Tasks.Task<OAuthAuthorizationListing> GetOauthAuthorizationsAsync ()
        {
             ApiResponse<OAuthAuthorizationListing> localVarResponse = await GetOauthAuthorizationsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List clients that are authorized by the resource owner 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OAuthAuthorizationListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthAuthorizationListing>> GetOauthAuthorizationsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/oauth/authorizations";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthAuthorizations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthAuthorizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthAuthorizationListing>(localVarStatusCode,
                localVarHeaders,
                (OAuthAuthorizationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthAuthorizationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>OAuthClient</returns>
        public OAuthClient GetOauthClient (string clientId)
        {
             ApiResponse<OAuthClient> localVarResponse = GetOauthClientWithHttpInfo(clientId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        public ApiResponse< OAuthClient > GetOauthClientWithHttpInfo (string clientId)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->GetOauthClient");

            var localVarPath = "/api/v2/oauth/clients/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClient: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClient: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthClient>(localVarStatusCode,
                localVarHeaders,
                (OAuthClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthClient)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of OAuthClient</returns>
        public async System.Threading.Tasks.Task<OAuthClient> GetOauthClientAsync (string clientId)
        {
             ApiResponse<OAuthClient> localVarResponse = await GetOauthClientAsyncWithHttpInfo(clientId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthClient>> GetOauthClientAsyncWithHttpInfo (string clientId)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->GetOauthClient");
            

            var localVarPath = "/api/v2/oauth/clients/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClient: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClient: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthClient>(localVarStatusCode,
                localVarHeaders,
                (OAuthClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthClient)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiUsageQueryResult</returns>
        public ApiUsageQueryResult GetOauthClientUsageQueryResult (string executionId, string clientId)
        {
             ApiResponse<ApiUsageQueryResult> localVarResponse = GetOauthClientUsageQueryResultWithHttpInfo(executionId, clientId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of ApiUsageQueryResult</returns>
        public ApiResponse< ApiUsageQueryResult > GetOauthClientUsageQueryResultWithHttpInfo (string executionId, string clientId)
        { 
            // verify the required parameter 'executionId' is set
            if (executionId == null)
                throw new ApiException(400, "Missing required parameter 'executionId' when calling OAuthApi->GetOauthClientUsageQueryResult");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->GetOauthClientUsageQueryResult");

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/query/results/{executionId}";
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
            if (executionId != null) localVarPathParams.Add("executionId", this.Configuration.ApiClient.ParameterToString(executionId));
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageQueryResult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageQueryResult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiUsageQueryResult>(localVarStatusCode,
                localVarHeaders,
                (ApiUsageQueryResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiUsageQueryResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiUsageQueryResult</returns>
        public async System.Threading.Tasks.Task<ApiUsageQueryResult> GetOauthClientUsageQueryResultAsync (string executionId, string clientId)
        {
             ApiResponse<ApiUsageQueryResult> localVarResponse = await GetOauthClientUsageQueryResultAsyncWithHttpInfo(executionId, clientId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the results of a usage query 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="executionId">ID of the query execution</param>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (ApiUsageQueryResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiUsageQueryResult>> GetOauthClientUsageQueryResultAsyncWithHttpInfo (string executionId, string clientId)
        { 
            // verify the required parameter 'executionId' is set
            if (executionId == null)
                throw new ApiException(400, "Missing required parameter 'executionId' when calling OAuthApi->GetOauthClientUsageQueryResult");
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->GetOauthClientUsageQueryResult");
            

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/query/results/{executionId}";
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
            if (executionId != null) localVarPathParams.Add("executionId", this.Configuration.ApiClient.ParameterToString(executionId));
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageQueryResult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageQueryResult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiUsageQueryResult>(localVarStatusCode,
                localVarHeaders,
                (ApiUsageQueryResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiUsageQueryResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a summary of OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to 7)</param>
        /// <returns>UsageExecutionResult</returns>
        public UsageExecutionResult GetOauthClientUsageSummary (string clientId, string days = null)
        {
             ApiResponse<UsageExecutionResult> localVarResponse = GetOauthClientUsageSummaryWithHttpInfo(clientId, days);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a summary of OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to 7)</param>
        /// <returns>ApiResponse of UsageExecutionResult</returns>
        public ApiResponse< UsageExecutionResult > GetOauthClientUsageSummaryWithHttpInfo (string clientId, string days = null)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->GetOauthClientUsageSummary");

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/summary";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

            // Query params
            if (days != null) localVarQueryParams.Add(new Tuple<string, string>("days", this.Configuration.ApiClient.ParameterToString(days)));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageSummary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsageExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (UsageExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsageExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a summary of OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to 7)</param>
        /// <returns>Task of UsageExecutionResult</returns>
        public async System.Threading.Tasks.Task<UsageExecutionResult> GetOauthClientUsageSummaryAsync (string clientId, string days = null)
        {
             ApiResponse<UsageExecutionResult> localVarResponse = await GetOauthClientUsageSummaryAsyncWithHttpInfo(clientId, days);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a summary of OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="days">Previous number of days to query (optional, default to 7)</param>
        /// <returns>Task of ApiResponse (UsageExecutionResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsageExecutionResult>> GetOauthClientUsageSummaryAsyncWithHttpInfo (string clientId, string days = null)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->GetOauthClientUsageSummary");
            

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/summary";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

            // Query params
            if (days != null) localVarQueryParams.Add(new Tuple<string, string>("days", this.Configuration.ApiClient.ParameterToString(days)));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageSummary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClientUsageSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsageExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (UsageExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsageExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// The list of OAuth clients 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OAuthClientEntityListing</returns>
        public OAuthClientEntityListing GetOauthClients ()
        {
             ApiResponse<OAuthClientEntityListing> localVarResponse = GetOauthClientsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// The list of OAuth clients 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OAuthClientEntityListing</returns>
        public ApiResponse< OAuthClientEntityListing > GetOauthClientsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/oauth/clients";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClients: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClients: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthClientEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OAuthClientEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthClientEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// The list of OAuth clients 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OAuthClientEntityListing</returns>
        public async System.Threading.Tasks.Task<OAuthClientEntityListing> GetOauthClientsAsync ()
        {
             ApiResponse<OAuthClientEntityListing> localVarResponse = await GetOauthClientsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// The list of OAuth clients 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OAuthClientEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthClientEntityListing>> GetOauthClientsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/oauth/clients";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClients: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthClients: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthClientEntityListing>(localVarStatusCode,
                localVarHeaders,
                (OAuthClientEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthClientEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// An OAuth scope 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scopeId">Scope ID</param>
        /// <param name="acceptLanguage">The language with which to display the scope description. (optional, default to en-us)</param>
        /// <returns>OAuthScope</returns>
        public OAuthScope GetOauthScope (string scopeId, string acceptLanguage = null)
        {
             ApiResponse<OAuthScope> localVarResponse = GetOauthScopeWithHttpInfo(scopeId, acceptLanguage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// An OAuth scope 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scopeId">Scope ID</param>
        /// <param name="acceptLanguage">The language with which to display the scope description. (optional, default to en-us)</param>
        /// <returns>ApiResponse of OAuthScope</returns>
        public ApiResponse< OAuthScope > GetOauthScopeWithHttpInfo (string scopeId, string acceptLanguage = null)
        { 
            // verify the required parameter 'scopeId' is set
            if (scopeId == null)
                throw new ApiException(400, "Missing required parameter 'scopeId' when calling OAuthApi->GetOauthScope");

            var localVarPath = "/api/v2/oauth/scopes/{scopeId}";
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
            if (scopeId != null) localVarPathParams.Add("scopeId", this.Configuration.ApiClient.ParameterToString(scopeId));

            // Query params

            // Header params
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", this.Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthScope: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthScope: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthScope>(localVarStatusCode,
                localVarHeaders,
                (OAuthScope) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthScope)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// An OAuth scope 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scopeId">Scope ID</param>
        /// <param name="acceptLanguage">The language with which to display the scope description. (optional, default to en-us)</param>
        /// <returns>Task of OAuthScope</returns>
        public async System.Threading.Tasks.Task<OAuthScope> GetOauthScopeAsync (string scopeId, string acceptLanguage = null)
        {
             ApiResponse<OAuthScope> localVarResponse = await GetOauthScopeAsyncWithHttpInfo(scopeId, acceptLanguage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// An OAuth scope 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scopeId">Scope ID</param>
        /// <param name="acceptLanguage">The language with which to display the scope description. (optional, default to en-us)</param>
        /// <returns>Task of ApiResponse (OAuthScope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthScope>> GetOauthScopeAsyncWithHttpInfo (string scopeId, string acceptLanguage = null)
        { 
            // verify the required parameter 'scopeId' is set
            if (scopeId == null)
                throw new ApiException(400, "Missing required parameter 'scopeId' when calling OAuthApi->GetOauthScope");
            

            var localVarPath = "/api/v2/oauth/scopes/{scopeId}";
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
            if (scopeId != null) localVarPathParams.Add("scopeId", this.Configuration.ApiClient.ParameterToString(scopeId));

            // Query params

            // Header params
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", this.Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthScope: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthScope: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthScope>(localVarStatusCode,
                localVarHeaders,
                (OAuthScope) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthScope)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// The list of OAuth scopes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The language with which to display the scope descriptions. (optional, default to en-us)</param>
        /// <returns>OAuthScopeListing</returns>
        public OAuthScopeListing GetOauthScopes (string acceptLanguage = null)
        {
             ApiResponse<OAuthScopeListing> localVarResponse = GetOauthScopesWithHttpInfo(acceptLanguage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// The list of OAuth scopes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The language with which to display the scope descriptions. (optional, default to en-us)</param>
        /// <returns>ApiResponse of OAuthScopeListing</returns>
        public ApiResponse< OAuthScopeListing > GetOauthScopesWithHttpInfo (string acceptLanguage = null)
        { 

            var localVarPath = "/api/v2/oauth/scopes";
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
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", this.Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthScopes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthScopes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthScopeListing>(localVarStatusCode,
                localVarHeaders,
                (OAuthScopeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthScopeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// The list of OAuth scopes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The language with which to display the scope descriptions. (optional, default to en-us)</param>
        /// <returns>Task of OAuthScopeListing</returns>
        public async System.Threading.Tasks.Task<OAuthScopeListing> GetOauthScopesAsync (string acceptLanguage = null)
        {
             ApiResponse<OAuthScopeListing> localVarResponse = await GetOauthScopesAsyncWithHttpInfo(acceptLanguage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// The list of OAuth scopes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The language with which to display the scope descriptions. (optional, default to en-us)</param>
        /// <returns>Task of ApiResponse (OAuthScopeListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthScopeListing>> GetOauthScopesAsyncWithHttpInfo (string acceptLanguage = null)
        { 

            var localVarPath = "/api/v2/oauth/scopes";
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
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", this.Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthScopes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOauthScopes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthScopeListing>(localVarStatusCode,
                localVarHeaders,
                (OAuthScopeListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthScopeListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Regenerate Client Secret This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>OAuthClient</returns>
        public OAuthClient PostOauthClientSecret (string clientId)
        {
             ApiResponse<OAuthClient> localVarResponse = PostOauthClientSecretWithHttpInfo(clientId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate Client Secret This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        public ApiResponse< OAuthClient > PostOauthClientSecretWithHttpInfo (string clientId)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->PostOauthClientSecret");

            var localVarPath = "/api/v2/oauth/clients/{clientId}/secret";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientSecret: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientSecret: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthClient>(localVarStatusCode,
                localVarHeaders,
                (OAuthClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthClient)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Regenerate Client Secret This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of OAuthClient</returns>
        public async System.Threading.Tasks.Task<OAuthClient> PostOauthClientSecretAsync (string clientId)
        {
             ApiResponse<OAuthClient> localVarResponse = await PostOauthClientSecretAsyncWithHttpInfo(clientId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Regenerate Client Secret This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthClient>> PostOauthClientSecretAsyncWithHttpInfo (string clientId)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->PostOauthClientSecret");
            

            var localVarPath = "/api/v2/oauth/clients/{clientId}/secret";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientSecret: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientSecret: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthClient>(localVarStatusCode,
                localVarHeaders,
                (OAuthClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthClient)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Query for OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>UsageExecutionResult</returns>
        public UsageExecutionResult PostOauthClientUsageQuery (string clientId, ApiUsageQuery body)
        {
             ApiResponse<UsageExecutionResult> localVarResponse = PostOauthClientUsageQueryWithHttpInfo(clientId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>ApiResponse of UsageExecutionResult</returns>
        public ApiResponse< UsageExecutionResult > PostOauthClientUsageQueryWithHttpInfo (string clientId, ApiUsageQuery body)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->PostOauthClientUsageQuery");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OAuthApi->PostOauthClientUsageQuery");

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/query";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientUsageQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientUsageQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsageExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (UsageExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsageExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Query for OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>Task of UsageExecutionResult</returns>
        public async System.Threading.Tasks.Task<UsageExecutionResult> PostOauthClientUsageQueryAsync (string clientId, ApiUsageQuery body)
        {
             ApiResponse<UsageExecutionResult> localVarResponse = await PostOauthClientUsageQueryAsyncWithHttpInfo(clientId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for OAuth client API usage After calling this method, you will then need to poll for the query results based on the returned execution Id
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Query</param>
        /// <returns>Task of ApiResponse (UsageExecutionResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsageExecutionResult>> PostOauthClientUsageQueryAsyncWithHttpInfo (string clientId, ApiUsageQuery body)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->PostOauthClientUsageQuery");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OAuthApi->PostOauthClientUsageQuery");
            

            var localVarPath = "/api/v2/oauth/clients/{clientId}/usage/query";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientUsageQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClientUsageQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsageExecutionResult>(localVarStatusCode,
                localVarHeaders,
                (UsageExecutionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsageExecutionResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create OAuth client The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud.  The preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server.  If the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps.  If a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles  via the &#39;roleIds&#39; field.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Client</param>
        /// <returns>OAuthClient</returns>
        public OAuthClient PostOauthClients (OAuthClientRequest body)
        {
             ApiResponse<OAuthClient> localVarResponse = PostOauthClientsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create OAuth client The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud.  The preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server.  If the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps.  If a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles  via the &#39;roleIds&#39; field.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Client</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        public ApiResponse< OAuthClient > PostOauthClientsWithHttpInfo (OAuthClientRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OAuthApi->PostOauthClients");

            var localVarPath = "/api/v2/oauth/clients";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClients: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClients: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthClient>(localVarStatusCode,
                localVarHeaders,
                (OAuthClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthClient)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create OAuth client The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud.  The preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server.  If the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps.  If a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles  via the &#39;roleIds&#39; field.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Client</param>
        /// <returns>Task of OAuthClient</returns>
        public async System.Threading.Tasks.Task<OAuthClient> PostOauthClientsAsync (OAuthClientRequest body)
        {
             ApiResponse<OAuthClient> localVarResponse = await PostOauthClientsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create OAuth client The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud.  The preferred authorizedGrantTypes is &#39;CODE&#39; which requires applications to send a client ID and client secret. This is typically a web server.  If the client is unable to secure the client secret then the &#39;TOKEN&#39; grant type aka IMPLICIT should be used. This is would be for browser or mobile apps.  If a client is to be used outside of the context of a user then the &#39;CLIENT-CREDENTIALS&#39; grant may be used. In this case the client must be granted roles  via the &#39;roleIds&#39; field.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Client</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthClient>> PostOauthClientsAsyncWithHttpInfo (OAuthClientRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OAuthApi->PostOauthClients");
            

            var localVarPath = "/api/v2/oauth/clients";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClients: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOauthClients: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthClient>(localVarStatusCode,
                localVarHeaders,
                (OAuthClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthClient)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>OAuthClient</returns>
        public OAuthClient PutOauthClient (string clientId, OAuthClientRequest body)
        {
             ApiResponse<OAuthClient> localVarResponse = PutOauthClientWithHttpInfo(clientId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        public ApiResponse< OAuthClient > PutOauthClientWithHttpInfo (string clientId, OAuthClientRequest body)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->PutOauthClient");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OAuthApi->PutOauthClient");

            var localVarPath = "/api/v2/oauth/clients/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOauthClient: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOauthClient: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthClient>(localVarStatusCode,
                localVarHeaders,
                (OAuthClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthClient)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>Task of OAuthClient</returns>
        public async System.Threading.Tasks.Task<OAuthClient> PutOauthClientAsync (string clientId, OAuthClientRequest body)
        {
             ApiResponse<OAuthClient> localVarResponse = await PutOauthClientAsyncWithHttpInfo(clientId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update OAuth Client 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <param name="body">Client</param>
        /// <returns>Task of ApiResponse (OAuthClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OAuthClient>> PutOauthClientAsyncWithHttpInfo (string clientId, OAuthClientRequest body)
        { 
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuthApi->PutOauthClient");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OAuthApi->PutOauthClient");
            

            var localVarPath = "/api/v2/oauth/clients/{clientId}";
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
            if (clientId != null) localVarPathParams.Add("clientId", this.Configuration.ApiClient.ParameterToString(clientId));

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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOauthClient: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOauthClient: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OAuthClient>(localVarStatusCode,
                localVarHeaders,
                (OAuthClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OAuthClient)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
