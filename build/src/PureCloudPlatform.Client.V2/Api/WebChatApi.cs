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
    public interface IWebChatApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns></returns>
        [Obsolete]
        
        void DeleteWebchatDeployment (string deploymentId);

        /// <summary>
        /// Delete a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        [Obsolete]
        
        ApiResponse<Object> DeleteWebchatDeploymentWithHttpInfo (string deploymentId);

        /// <summary>
        /// Remove a member from a chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns></returns>
        
        
        void DeleteWebchatGuestConversationMember (string conversationId, string memberId);

        /// <summary>
        /// Remove a member from a chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        ApiResponse<Object> DeleteWebchatGuestConversationMemberWithHttpInfo (string conversationId, string memberId);

        /// <summary>
        /// Remove WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        
        
        void DeleteWebchatSettings ();

        /// <summary>
        /// Remove WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        ApiResponse<Object> DeleteWebchatSettingsWithHttpInfo ();

        /// <summary>
        /// Get a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>WebChatDeployment</returns>
        [Obsolete]
        
        WebChatDeployment GetWebchatDeployment (string deploymentId);

        /// <summary>
        /// Get a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>ApiResponse of WebChatDeployment</returns>
        [Obsolete]
        
        ApiResponse<WebChatDeployment> GetWebchatDeploymentWithHttpInfo (string deploymentId);

        /// <summary>
        /// List WebChat deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WebChatDeploymentEntityListing</returns>
        [Obsolete]
        
        WebChatDeploymentEntityListing GetWebchatDeployments ();

        /// <summary>
        /// List WebChat deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WebChatDeploymentEntityListing</returns>
        [Obsolete]
        
        ApiResponse<WebChatDeploymentEntityListing> GetWebchatDeploymentsWithHttpInfo ();

        /// <summary>
        /// Get a media request in the conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <returns>WebChatGuestMediaRequest</returns>
        
        
        WebChatGuestMediaRequest GetWebchatGuestConversationMediarequest (string conversationId, string mediaRequestId);

        /// <summary>
        /// Get a media request in the conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <returns>ApiResponse of WebChatGuestMediaRequest</returns>
        
        
        ApiResponse<WebChatGuestMediaRequest> GetWebchatGuestConversationMediarequestWithHttpInfo (string conversationId, string mediaRequestId);

        /// <summary>
        /// Get all media requests to the guest in the conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>WebChatGuestMediaRequestEntityList</returns>
        
        
        WebChatGuestMediaRequestEntityList GetWebchatGuestConversationMediarequests (string conversationId);

        /// <summary>
        /// Get all media requests to the guest in the conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of WebChatGuestMediaRequestEntityList</returns>
        
        
        ApiResponse<WebChatGuestMediaRequestEntityList> GetWebchatGuestConversationMediarequestsWithHttpInfo (string conversationId);

        /// <summary>
        /// Get a web chat conversation member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>WebChatMemberInfo</returns>
        
        
        WebChatMemberInfo GetWebchatGuestConversationMember (string conversationId, string memberId);

        /// <summary>
        /// Get a web chat conversation member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>ApiResponse of WebChatMemberInfo</returns>
        
        
        ApiResponse<WebChatMemberInfo> GetWebchatGuestConversationMemberWithHttpInfo (string conversationId, string memberId);

        /// <summary>
        /// Get the members of a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page. (optional, default to 1)</param>
        /// <param name="excludeDisconnectedMembers">If true, the results will not contain members who have a DISCONNECTED state. (optional, default to false)</param>
        /// <returns>WebChatMemberInfoEntityList</returns>
        
        
        WebChatMemberInfoEntityList GetWebchatGuestConversationMembers (string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null);

        /// <summary>
        /// Get the members of a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page. (optional, default to 1)</param>
        /// <param name="excludeDisconnectedMembers">If true, the results will not contain members who have a DISCONNECTED state. (optional, default to false)</param>
        /// <returns>ApiResponse of WebChatMemberInfoEntityList</returns>
        
        
        ApiResponse<WebChatMemberInfoEntityList> GetWebchatGuestConversationMembersWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null);

        /// <summary>
        /// Get a web chat conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>WebChatMessage</returns>
        
        
        WebChatMessage GetWebchatGuestConversationMessage (string conversationId, string messageId);

        /// <summary>
        /// Get a web chat conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of WebChatMessage</returns>
        
        
        ApiResponse<WebChatMessage> GetWebchatGuestConversationMessageWithHttpInfo (string conversationId, string messageId);

        /// <summary>
        /// Get the messages of a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="after">If available, get the messages chronologically after the id of this message (optional)</param>
        /// <param name="before">If available, get the messages chronologically before the id of this message (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="maxResults">Limit the returned number of messages, up to a maximum of 100 (optional, default to 100)</param>
        /// <returns>WebChatMessageEntityList</returns>
        
        
        WebChatMessageEntityList GetWebchatGuestConversationMessages (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null);

        /// <summary>
        /// Get the messages of a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="after">If available, get the messages chronologically after the id of this message (optional)</param>
        /// <param name="before">If available, get the messages chronologically before the id of this message (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="maxResults">Limit the returned number of messages, up to a maximum of 100 (optional, default to 100)</param>
        /// <returns>ApiResponse of WebChatMessageEntityList</returns>
        
        
        ApiResponse<WebChatMessageEntityList> GetWebchatGuestConversationMessagesWithHttpInfo (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null);

        /// <summary>
        /// Get WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WebChatSettings</returns>
        
        
        WebChatSettings GetWebchatSettings ();

        /// <summary>
        /// Get WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WebChatSettings</returns>
        
        
        ApiResponse<WebChatSettings> GetWebchatSettingsWithHttpInfo ();

        /// <summary>
        /// Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <param name="body">Request</param>
        /// <returns>WebChatGuestMediaRequest</returns>
        
        
        WebChatGuestMediaRequest PatchWebchatGuestConversationMediarequest (string conversationId, string mediaRequestId, WebChatGuestMediaRequest body);

        /// <summary>
        /// Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <param name="body">Request</param>
        /// <returns>ApiResponse of WebChatGuestMediaRequest</returns>
        
        
        ApiResponse<WebChatGuestMediaRequest> PatchWebchatGuestConversationMediarequestWithHttpInfo (string conversationId, string mediaRequestId, WebChatGuestMediaRequest body);

        /// <summary>
        /// Create WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>WebChatDeployment</returns>
        [Obsolete]
        
        WebChatDeployment PostWebchatDeployments (WebChatDeployment body);

        /// <summary>
        /// Create WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>ApiResponse of WebChatDeployment</returns>
        [Obsolete]
        
        ApiResponse<WebChatDeployment> PostWebchatDeploymentsWithHttpInfo (WebChatDeployment body);

        /// <summary>
        /// Send a message in a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <param name="body">Message</param>
        /// <returns>WebChatMessage</returns>
        
        
        WebChatMessage PostWebchatGuestConversationMemberMessages (string conversationId, string memberId, CreateWebChatMessageRequest body);

        /// <summary>
        /// Send a message in a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <param name="body">Message</param>
        /// <returns>ApiResponse of WebChatMessage</returns>
        
        
        ApiResponse<WebChatMessage> PostWebchatGuestConversationMemberMessagesWithHttpInfo (string conversationId, string memberId, CreateWebChatMessageRequest body);

        /// <summary>
        /// Send a typing-indicator in a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>WebChatTyping</returns>
        
        
        WebChatTyping PostWebchatGuestConversationMemberTyping (string conversationId, string memberId);

        /// <summary>
        /// Send a typing-indicator in a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>ApiResponse of WebChatTyping</returns>
        
        
        ApiResponse<WebChatTyping> PostWebchatGuestConversationMemberTypingWithHttpInfo (string conversationId, string memberId);

        /// <summary>
        /// Create an ACD chat conversation from an external customer.
        /// </summary>
        /// <remarks>
        /// This endpoint will create a new ACD Chat conversation under the specified Chat Deployment.  The conversation will begin with a guest member in it (with a role=CUSTOMER) according to the customer information that is supplied. If the guest member is authenticated, the 'memberAuthToken' field should include his JWT as generated by the 'POST /api/v2/signeddata' resource; if the guest member is anonymous (and the Deployment permits it) this field can be omitted.  The returned data includes the IDs of the conversation created, along with a newly-create JWT token that you can supply to all future endpoints as authentication to perform operations against that conversation. After successfully creating a conversation, you should connect a websocket to the event stream named in the 'eventStreamUri' field of the response; the conversation is not routed until the event stream is attached.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateConversationRequest</param>
        /// <returns>CreateWebChatConversationResponse</returns>
        
        
        CreateWebChatConversationResponse PostWebchatGuestConversations (CreateWebChatConversationRequest body);

        /// <summary>
        /// Create an ACD chat conversation from an external customer.
        /// </summary>
        /// <remarks>
        /// This endpoint will create a new ACD Chat conversation under the specified Chat Deployment.  The conversation will begin with a guest member in it (with a role=CUSTOMER) according to the customer information that is supplied. If the guest member is authenticated, the 'memberAuthToken' field should include his JWT as generated by the 'POST /api/v2/signeddata' resource; if the guest member is anonymous (and the Deployment permits it) this field can be omitted.  The returned data includes the IDs of the conversation created, along with a newly-create JWT token that you can supply to all future endpoints as authentication to perform operations against that conversation. After successfully creating a conversation, you should connect a websocket to the event stream named in the 'eventStreamUri' field of the response; the conversation is not routed until the event stream is attached.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateConversationRequest</param>
        /// <returns>ApiResponse of CreateWebChatConversationResponse</returns>
        
        
        ApiResponse<CreateWebChatConversationResponse> PostWebchatGuestConversationsWithHttpInfo (CreateWebChatConversationRequest body);

        /// <summary>
        /// Update a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>WebChatDeployment</returns>
        [Obsolete]
        
        WebChatDeployment PutWebchatDeployment (string deploymentId, WebChatDeployment body);

        /// <summary>
        /// Update a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>ApiResponse of WebChatDeployment</returns>
        [Obsolete]
        
        ApiResponse<WebChatDeployment> PutWebchatDeploymentWithHttpInfo (string deploymentId, WebChatDeployment body);

        /// <summary>
        /// Update WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webChatSettings</param>
        /// <returns>WebChatSettings</returns>
        
        
        WebChatSettings PutWebchatSettings (WebChatSettings body);

        /// <summary>
        /// Update WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webChatSettings</param>
        /// <returns>ApiResponse of WebChatSettings</returns>
        
        
        ApiResponse<WebChatSettings> PutWebchatSettingsWithHttpInfo (WebChatSettings body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>Task of void</returns>
        [Obsolete]
        
        System.Threading.Tasks.Task DeleteWebchatDeploymentAsync (string deploymentId);

        /// <summary>
        /// Delete a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>Task of ApiResponse</returns>
        [Obsolete]
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebchatDeploymentAsyncWithHttpInfo (string deploymentId);

        /// <summary>
        /// Remove a member from a chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of void</returns>
        
        
        System.Threading.Tasks.Task DeleteWebchatGuestConversationMemberAsync (string conversationId, string memberId);

        /// <summary>
        /// Remove a member from a chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of ApiResponse</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebchatGuestConversationMemberAsyncWithHttpInfo (string conversationId, string memberId);

        /// <summary>
        /// Remove WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        
        
        System.Threading.Tasks.Task DeleteWebchatSettingsAsync ();

        /// <summary>
        /// Remove WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebchatSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Get a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>Task of WebChatDeployment</returns>
        [Obsolete]
        
        System.Threading.Tasks.Task<WebChatDeployment> GetWebchatDeploymentAsync (string deploymentId);

        /// <summary>
        /// Get a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>Task of ApiResponse (WebChatDeployment)</returns>
        [Obsolete]
        
        System.Threading.Tasks.Task<ApiResponse<WebChatDeployment>> GetWebchatDeploymentAsyncWithHttpInfo (string deploymentId);

        /// <summary>
        /// List WebChat deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WebChatDeploymentEntityListing</returns>
        [Obsolete]
        
        System.Threading.Tasks.Task<WebChatDeploymentEntityListing> GetWebchatDeploymentsAsync ();

        /// <summary>
        /// List WebChat deployments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WebChatDeploymentEntityListing)</returns>
        [Obsolete]
        
        System.Threading.Tasks.Task<ApiResponse<WebChatDeploymentEntityListing>> GetWebchatDeploymentsAsyncWithHttpInfo ();

        /// <summary>
        /// Get a media request in the conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <returns>Task of WebChatGuestMediaRequest</returns>
        
        
        System.Threading.Tasks.Task<WebChatGuestMediaRequest> GetWebchatGuestConversationMediarequestAsync (string conversationId, string mediaRequestId);

        /// <summary>
        /// Get a media request in the conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <returns>Task of ApiResponse (WebChatGuestMediaRequest)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatGuestMediaRequest>> GetWebchatGuestConversationMediarequestAsyncWithHttpInfo (string conversationId, string mediaRequestId);

        /// <summary>
        /// Get all media requests to the guest in the conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of WebChatGuestMediaRequestEntityList</returns>
        
        
        System.Threading.Tasks.Task<WebChatGuestMediaRequestEntityList> GetWebchatGuestConversationMediarequestsAsync (string conversationId);

        /// <summary>
        /// Get all media requests to the guest in the conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (WebChatGuestMediaRequestEntityList)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatGuestMediaRequestEntityList>> GetWebchatGuestConversationMediarequestsAsyncWithHttpInfo (string conversationId);

        /// <summary>
        /// Get a web chat conversation member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of WebChatMemberInfo</returns>
        
        
        System.Threading.Tasks.Task<WebChatMemberInfo> GetWebchatGuestConversationMemberAsync (string conversationId, string memberId);

        /// <summary>
        /// Get a web chat conversation member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of ApiResponse (WebChatMemberInfo)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatMemberInfo>> GetWebchatGuestConversationMemberAsyncWithHttpInfo (string conversationId, string memberId);

        /// <summary>
        /// Get the members of a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page. (optional, default to 1)</param>
        /// <param name="excludeDisconnectedMembers">If true, the results will not contain members who have a DISCONNECTED state. (optional, default to false)</param>
        /// <returns>Task of WebChatMemberInfoEntityList</returns>
        
        
        System.Threading.Tasks.Task<WebChatMemberInfoEntityList> GetWebchatGuestConversationMembersAsync (string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null);

        /// <summary>
        /// Get the members of a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page. (optional, default to 1)</param>
        /// <param name="excludeDisconnectedMembers">If true, the results will not contain members who have a DISCONNECTED state. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (WebChatMemberInfoEntityList)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatMemberInfoEntityList>> GetWebchatGuestConversationMembersAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null);

        /// <summary>
        /// Get a web chat conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of WebChatMessage</returns>
        
        
        System.Threading.Tasks.Task<WebChatMessage> GetWebchatGuestConversationMessageAsync (string conversationId, string messageId);

        /// <summary>
        /// Get a web chat conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse (WebChatMessage)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatMessage>> GetWebchatGuestConversationMessageAsyncWithHttpInfo (string conversationId, string messageId);

        /// <summary>
        /// Get the messages of a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="after">If available, get the messages chronologically after the id of this message (optional)</param>
        /// <param name="before">If available, get the messages chronologically before the id of this message (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="maxResults">Limit the returned number of messages, up to a maximum of 100 (optional, default to 100)</param>
        /// <returns>Task of WebChatMessageEntityList</returns>
        
        
        System.Threading.Tasks.Task<WebChatMessageEntityList> GetWebchatGuestConversationMessagesAsync (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null);

        /// <summary>
        /// Get the messages of a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="after">If available, get the messages chronologically after the id of this message (optional)</param>
        /// <param name="before">If available, get the messages chronologically before the id of this message (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="maxResults">Limit the returned number of messages, up to a maximum of 100 (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (WebChatMessageEntityList)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatMessageEntityList>> GetWebchatGuestConversationMessagesAsyncWithHttpInfo (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null);

        /// <summary>
        /// Get WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WebChatSettings</returns>
        
        
        System.Threading.Tasks.Task<WebChatSettings> GetWebchatSettingsAsync ();

        /// <summary>
        /// Get WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WebChatSettings)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatSettings>> GetWebchatSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <param name="body">Request</param>
        /// <returns>Task of WebChatGuestMediaRequest</returns>
        
        
        System.Threading.Tasks.Task<WebChatGuestMediaRequest> PatchWebchatGuestConversationMediarequestAsync (string conversationId, string mediaRequestId, WebChatGuestMediaRequest body);

        /// <summary>
        /// Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <param name="body">Request</param>
        /// <returns>Task of ApiResponse (WebChatGuestMediaRequest)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatGuestMediaRequest>> PatchWebchatGuestConversationMediarequestAsyncWithHttpInfo (string conversationId, string mediaRequestId, WebChatGuestMediaRequest body);

        /// <summary>
        /// Create WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>Task of WebChatDeployment</returns>
        [Obsolete]
        
        System.Threading.Tasks.Task<WebChatDeployment> PostWebchatDeploymentsAsync (WebChatDeployment body);

        /// <summary>
        /// Create WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>Task of ApiResponse (WebChatDeployment)</returns>
        [Obsolete]
        
        System.Threading.Tasks.Task<ApiResponse<WebChatDeployment>> PostWebchatDeploymentsAsyncWithHttpInfo (WebChatDeployment body);

        /// <summary>
        /// Send a message in a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <param name="body">Message</param>
        /// <returns>Task of WebChatMessage</returns>
        
        
        System.Threading.Tasks.Task<WebChatMessage> PostWebchatGuestConversationMemberMessagesAsync (string conversationId, string memberId, CreateWebChatMessageRequest body);

        /// <summary>
        /// Send a message in a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <param name="body">Message</param>
        /// <returns>Task of ApiResponse (WebChatMessage)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatMessage>> PostWebchatGuestConversationMemberMessagesAsyncWithHttpInfo (string conversationId, string memberId, CreateWebChatMessageRequest body);

        /// <summary>
        /// Send a typing-indicator in a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of WebChatTyping</returns>
        
        
        System.Threading.Tasks.Task<WebChatTyping> PostWebchatGuestConversationMemberTypingAsync (string conversationId, string memberId);

        /// <summary>
        /// Send a typing-indicator in a chat conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of ApiResponse (WebChatTyping)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatTyping>> PostWebchatGuestConversationMemberTypingAsyncWithHttpInfo (string conversationId, string memberId);

        /// <summary>
        /// Create an ACD chat conversation from an external customer.
        /// </summary>
        /// <remarks>
        /// This endpoint will create a new ACD Chat conversation under the specified Chat Deployment.  The conversation will begin with a guest member in it (with a role=CUSTOMER) according to the customer information that is supplied. If the guest member is authenticated, the 'memberAuthToken' field should include his JWT as generated by the 'POST /api/v2/signeddata' resource; if the guest member is anonymous (and the Deployment permits it) this field can be omitted.  The returned data includes the IDs of the conversation created, along with a newly-create JWT token that you can supply to all future endpoints as authentication to perform operations against that conversation. After successfully creating a conversation, you should connect a websocket to the event stream named in the 'eventStreamUri' field of the response; the conversation is not routed until the event stream is attached.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateConversationRequest</param>
        /// <returns>Task of CreateWebChatConversationResponse</returns>
        
        
        System.Threading.Tasks.Task<CreateWebChatConversationResponse> PostWebchatGuestConversationsAsync (CreateWebChatConversationRequest body);

        /// <summary>
        /// Create an ACD chat conversation from an external customer.
        /// </summary>
        /// <remarks>
        /// This endpoint will create a new ACD Chat conversation under the specified Chat Deployment.  The conversation will begin with a guest member in it (with a role=CUSTOMER) according to the customer information that is supplied. If the guest member is authenticated, the 'memberAuthToken' field should include his JWT as generated by the 'POST /api/v2/signeddata' resource; if the guest member is anonymous (and the Deployment permits it) this field can be omitted.  The returned data includes the IDs of the conversation created, along with a newly-create JWT token that you can supply to all future endpoints as authentication to perform operations against that conversation. After successfully creating a conversation, you should connect a websocket to the event stream named in the 'eventStreamUri' field of the response; the conversation is not routed until the event stream is attached.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateConversationRequest</param>
        /// <returns>Task of ApiResponse (CreateWebChatConversationResponse)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<CreateWebChatConversationResponse>> PostWebchatGuestConversationsAsyncWithHttpInfo (CreateWebChatConversationRequest body);

        /// <summary>
        /// Update a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>Task of WebChatDeployment</returns>
        [Obsolete]
        
        System.Threading.Tasks.Task<WebChatDeployment> PutWebchatDeploymentAsync (string deploymentId, WebChatDeployment body);

        /// <summary>
        /// Update a WebChat deployment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>Task of ApiResponse (WebChatDeployment)</returns>
        [Obsolete]
        
        System.Threading.Tasks.Task<ApiResponse<WebChatDeployment>> PutWebchatDeploymentAsyncWithHttpInfo (string deploymentId, WebChatDeployment body);

        /// <summary>
        /// Update WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webChatSettings</param>
        /// <returns>Task of WebChatSettings</returns>
        
        
        System.Threading.Tasks.Task<WebChatSettings> PutWebchatSettingsAsync (WebChatSettings body);

        /// <summary>
        /// Update WebChat deployment settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webChatSettings</param>
        /// <returns>Task of ApiResponse (WebChatSettings)</returns>
        
        
        System.Threading.Tasks.Task<ApiResponse<WebChatSettings>> PutWebchatSettingsAsyncWithHttpInfo (WebChatSettings body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WebChatApi : IWebChatApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebChatApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebChatApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns></returns>
        [Obsolete]
        
        public void DeleteWebchatDeployment (string deploymentId)
        {
             DeleteWebchatDeploymentWithHttpInfo(deploymentId);
        }

        /// <summary>
        /// Delete a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        [Obsolete]
        
        public ApiResponse<Object> DeleteWebchatDeploymentWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebChatApi->DeleteWebchatDeployment");

            var localVarPath = "/api/v2/webchat/deployments/{deploymentId}";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>Task of void</returns>
        [Obsolete]
        
        public async System.Threading.Tasks.Task DeleteWebchatDeploymentAsync (string deploymentId)
        {
             await DeleteWebchatDeploymentAsyncWithHttpInfo(deploymentId);

        }

        /// <summary>
        /// Delete a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>Task of ApiResponse</returns>
        [Obsolete]
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebchatDeploymentAsyncWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebChatApi->DeleteWebchatDeployment");
            

            var localVarPath = "/api/v2/webchat/deployments/{deploymentId}";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Remove a member from a chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns></returns>
        
        
        public void DeleteWebchatGuestConversationMember (string conversationId, string memberId)
        {
             DeleteWebchatGuestConversationMemberWithHttpInfo(conversationId, memberId);
        }

        /// <summary>
        /// Remove a member from a chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        public ApiResponse<Object> DeleteWebchatGuestConversationMemberWithHttpInfo (string conversationId, string memberId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->DeleteWebchatGuestConversationMember");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling WebChatApi->DeleteWebchatGuestConversationMember");

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}";
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
            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatGuestConversationMember: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatGuestConversationMember: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Remove a member from a chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of void</returns>
        
        
        public async System.Threading.Tasks.Task DeleteWebchatGuestConversationMemberAsync (string conversationId, string memberId)
        {
             await DeleteWebchatGuestConversationMemberAsyncWithHttpInfo(conversationId, memberId);

        }

        /// <summary>
        /// Remove a member from a chat conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of ApiResponse</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebchatGuestConversationMemberAsyncWithHttpInfo (string conversationId, string memberId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->DeleteWebchatGuestConversationMember");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling WebChatApi->DeleteWebchatGuestConversationMember");
            

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}";
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
            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatGuestConversationMember: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatGuestConversationMember: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Remove WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        
        
        public void DeleteWebchatSettings ()
        {
             DeleteWebchatSettingsWithHttpInfo();
        }

        /// <summary>
        /// Remove WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        
        
        public ApiResponse<Object> DeleteWebchatSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/webchat/settings";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Remove WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        
        
        public async System.Threading.Tasks.Task DeleteWebchatSettingsAsync ()
        {
             await DeleteWebchatSettingsAsyncWithHttpInfo();

        }

        /// <summary>
        /// Remove WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWebchatSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/webchat/settings";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWebchatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>WebChatDeployment</returns>
        [Obsolete]
        
        public WebChatDeployment GetWebchatDeployment (string deploymentId)
        {
             ApiResponse<WebChatDeployment> localVarResponse = GetWebchatDeploymentWithHttpInfo(deploymentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>ApiResponse of WebChatDeployment</returns>
        [Obsolete]
        
        public ApiResponse< WebChatDeployment > GetWebchatDeploymentWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebChatApi->GetWebchatDeployment");

            var localVarPath = "/api/v2/webchat/deployments/{deploymentId}";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebChatDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>Task of WebChatDeployment</returns>
        [Obsolete]
        
        public async System.Threading.Tasks.Task<WebChatDeployment> GetWebchatDeploymentAsync (string deploymentId)
        {
             ApiResponse<WebChatDeployment> localVarResponse = await GetWebchatDeploymentAsyncWithHttpInfo(deploymentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <returns>Task of ApiResponse (WebChatDeployment)</returns>
        [Obsolete]
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatDeployment>> GetWebchatDeploymentAsyncWithHttpInfo (string deploymentId)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebChatApi->GetWebchatDeployment");
            

            var localVarPath = "/api/v2/webchat/deployments/{deploymentId}";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebChatDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// List WebChat deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WebChatDeploymentEntityListing</returns>
        [Obsolete]
        
        public WebChatDeploymentEntityListing GetWebchatDeployments ()
        {
             ApiResponse<WebChatDeploymentEntityListing> localVarResponse = GetWebchatDeploymentsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List WebChat deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WebChatDeploymentEntityListing</returns>
        [Obsolete]
        
        public ApiResponse< WebChatDeploymentEntityListing > GetWebchatDeploymentsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/webchat/deployments";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatDeploymentEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WebChatDeploymentEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatDeploymentEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// List WebChat deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WebChatDeploymentEntityListing</returns>
        [Obsolete]
        
        public async System.Threading.Tasks.Task<WebChatDeploymentEntityListing> GetWebchatDeploymentsAsync ()
        {
             ApiResponse<WebChatDeploymentEntityListing> localVarResponse = await GetWebchatDeploymentsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List WebChat deployments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WebChatDeploymentEntityListing)</returns>
        [Obsolete]
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatDeploymentEntityListing>> GetWebchatDeploymentsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/webchat/deployments";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatDeploymentEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WebChatDeploymentEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatDeploymentEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a media request in the conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <returns>WebChatGuestMediaRequest</returns>
        
        
        public WebChatGuestMediaRequest GetWebchatGuestConversationMediarequest (string conversationId, string mediaRequestId)
        {
             ApiResponse<WebChatGuestMediaRequest> localVarResponse = GetWebchatGuestConversationMediarequestWithHttpInfo(conversationId, mediaRequestId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a media request in the conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <returns>ApiResponse of WebChatGuestMediaRequest</returns>
        
        
        public ApiResponse< WebChatGuestMediaRequest > GetWebchatGuestConversationMediarequestWithHttpInfo (string conversationId, string mediaRequestId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMediarequest");
            // verify the required parameter 'mediaRequestId' is set
            if (mediaRequestId == null)
                throw new ApiException(400, "Missing required parameter 'mediaRequestId' when calling WebChatApi->GetWebchatGuestConversationMediarequest");

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/mediarequests/{mediaRequestId}";
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
            if (mediaRequestId != null) localVarPathParams.Add("mediaRequestId", this.Configuration.ApiClient.ParameterToString(mediaRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMediarequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMediarequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatGuestMediaRequest>(localVarStatusCode,
                localVarHeaders,
                (WebChatGuestMediaRequest) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatGuestMediaRequest)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a media request in the conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <returns>Task of WebChatGuestMediaRequest</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatGuestMediaRequest> GetWebchatGuestConversationMediarequestAsync (string conversationId, string mediaRequestId)
        {
             ApiResponse<WebChatGuestMediaRequest> localVarResponse = await GetWebchatGuestConversationMediarequestAsyncWithHttpInfo(conversationId, mediaRequestId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a media request in the conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <returns>Task of ApiResponse (WebChatGuestMediaRequest)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatGuestMediaRequest>> GetWebchatGuestConversationMediarequestAsyncWithHttpInfo (string conversationId, string mediaRequestId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMediarequest");
            
            // verify the required parameter 'mediaRequestId' is set
            if (mediaRequestId == null)
                throw new ApiException(400, "Missing required parameter 'mediaRequestId' when calling WebChatApi->GetWebchatGuestConversationMediarequest");
            

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/mediarequests/{mediaRequestId}";
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
            if (mediaRequestId != null) localVarPathParams.Add("mediaRequestId", this.Configuration.ApiClient.ParameterToString(mediaRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMediarequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMediarequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatGuestMediaRequest>(localVarStatusCode,
                localVarHeaders,
                (WebChatGuestMediaRequest) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatGuestMediaRequest)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all media requests to the guest in the conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>WebChatGuestMediaRequestEntityList</returns>
        
        
        public WebChatGuestMediaRequestEntityList GetWebchatGuestConversationMediarequests (string conversationId)
        {
             ApiResponse<WebChatGuestMediaRequestEntityList> localVarResponse = GetWebchatGuestConversationMediarequestsWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all media requests to the guest in the conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of WebChatGuestMediaRequestEntityList</returns>
        
        
        public ApiResponse< WebChatGuestMediaRequestEntityList > GetWebchatGuestConversationMediarequestsWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMediarequests");

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/mediarequests";
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


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMediarequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMediarequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatGuestMediaRequestEntityList>(localVarStatusCode,
                localVarHeaders,
                (WebChatGuestMediaRequestEntityList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatGuestMediaRequestEntityList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all media requests to the guest in the conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of WebChatGuestMediaRequestEntityList</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatGuestMediaRequestEntityList> GetWebchatGuestConversationMediarequestsAsync (string conversationId)
        {
             ApiResponse<WebChatGuestMediaRequestEntityList> localVarResponse = await GetWebchatGuestConversationMediarequestsAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all media requests to the guest in the conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (WebChatGuestMediaRequestEntityList)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatGuestMediaRequestEntityList>> GetWebchatGuestConversationMediarequestsAsyncWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMediarequests");
            

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/mediarequests";
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


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMediarequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMediarequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatGuestMediaRequestEntityList>(localVarStatusCode,
                localVarHeaders,
                (WebChatGuestMediaRequestEntityList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatGuestMediaRequestEntityList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a web chat conversation member 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>WebChatMemberInfo</returns>
        
        
        public WebChatMemberInfo GetWebchatGuestConversationMember (string conversationId, string memberId)
        {
             ApiResponse<WebChatMemberInfo> localVarResponse = GetWebchatGuestConversationMemberWithHttpInfo(conversationId, memberId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a web chat conversation member 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>ApiResponse of WebChatMemberInfo</returns>
        
        
        public ApiResponse< WebChatMemberInfo > GetWebchatGuestConversationMemberWithHttpInfo (string conversationId, string memberId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMember");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling WebChatApi->GetWebchatGuestConversationMember");

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}";
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
            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMember: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMember: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatMemberInfo>(localVarStatusCode,
                localVarHeaders,
                (WebChatMemberInfo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatMemberInfo)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a web chat conversation member 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of WebChatMemberInfo</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatMemberInfo> GetWebchatGuestConversationMemberAsync (string conversationId, string memberId)
        {
             ApiResponse<WebChatMemberInfo> localVarResponse = await GetWebchatGuestConversationMemberAsyncWithHttpInfo(conversationId, memberId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a web chat conversation member 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of ApiResponse (WebChatMemberInfo)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatMemberInfo>> GetWebchatGuestConversationMemberAsyncWithHttpInfo (string conversationId, string memberId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMember");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling WebChatApi->GetWebchatGuestConversationMember");
            

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}";
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
            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMember: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMember: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatMemberInfo>(localVarStatusCode,
                localVarHeaders,
                (WebChatMemberInfo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatMemberInfo)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the members of a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page. (optional, default to 1)</param>
        /// <param name="excludeDisconnectedMembers">If true, the results will not contain members who have a DISCONNECTED state. (optional, default to false)</param>
        /// <returns>WebChatMemberInfoEntityList</returns>
        
        
        public WebChatMemberInfoEntityList GetWebchatGuestConversationMembers (string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null)
        {
             ApiResponse<WebChatMemberInfoEntityList> localVarResponse = GetWebchatGuestConversationMembersWithHttpInfo(conversationId, pageSize, pageNumber, excludeDisconnectedMembers);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the members of a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page. (optional, default to 1)</param>
        /// <param name="excludeDisconnectedMembers">If true, the results will not contain members who have a DISCONNECTED state. (optional, default to false)</param>
        /// <returns>ApiResponse of WebChatMemberInfoEntityList</returns>
        
        
        public ApiResponse< WebChatMemberInfoEntityList > GetWebchatGuestConversationMembersWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMembers");

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/members";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (excludeDisconnectedMembers != null) localVarQueryParams.Add(new Tuple<string, string>("excludeDisconnectedMembers", this.Configuration.ApiClient.ParameterToString(excludeDisconnectedMembers)));

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatMemberInfoEntityList>(localVarStatusCode,
                localVarHeaders,
                (WebChatMemberInfoEntityList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatMemberInfoEntityList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the members of a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page. (optional, default to 1)</param>
        /// <param name="excludeDisconnectedMembers">If true, the results will not contain members who have a DISCONNECTED state. (optional, default to false)</param>
        /// <returns>Task of WebChatMemberInfoEntityList</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatMemberInfoEntityList> GetWebchatGuestConversationMembersAsync (string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null)
        {
             ApiResponse<WebChatMemberInfoEntityList> localVarResponse = await GetWebchatGuestConversationMembersAsyncWithHttpInfo(conversationId, pageSize, pageNumber, excludeDisconnectedMembers);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the members of a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default. (optional, default to 25)</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page. (optional, default to 1)</param>
        /// <param name="excludeDisconnectedMembers">If true, the results will not contain members who have a DISCONNECTED state. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (WebChatMemberInfoEntityList)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatMemberInfoEntityList>> GetWebchatGuestConversationMembersAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, bool? excludeDisconnectedMembers = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMembers");
            

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/members";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (excludeDisconnectedMembers != null) localVarQueryParams.Add(new Tuple<string, string>("excludeDisconnectedMembers", this.Configuration.ApiClient.ParameterToString(excludeDisconnectedMembers)));

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatMemberInfoEntityList>(localVarStatusCode,
                localVarHeaders,
                (WebChatMemberInfoEntityList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatMemberInfoEntityList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a web chat conversation message 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>WebChatMessage</returns>
        
        
        public WebChatMessage GetWebchatGuestConversationMessage (string conversationId, string messageId)
        {
             ApiResponse<WebChatMessage> localVarResponse = GetWebchatGuestConversationMessageWithHttpInfo(conversationId, messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a web chat conversation message 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of WebChatMessage</returns>
        
        
        public ApiResponse< WebChatMessage > GetWebchatGuestConversationMessageWithHttpInfo (string conversationId, string messageId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling WebChatApi->GetWebchatGuestConversationMessage");

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/messages/{messageId}";
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
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatMessage>(localVarStatusCode,
                localVarHeaders,
                (WebChatMessage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatMessage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a web chat conversation message 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of WebChatMessage</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatMessage> GetWebchatGuestConversationMessageAsync (string conversationId, string messageId)
        {
             ApiResponse<WebChatMessage> localVarResponse = await GetWebchatGuestConversationMessageAsyncWithHttpInfo(conversationId, messageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a web chat conversation message 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse (WebChatMessage)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatMessage>> GetWebchatGuestConversationMessageAsyncWithHttpInfo (string conversationId, string messageId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMessage");
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling WebChatApi->GetWebchatGuestConversationMessage");
            

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/messages/{messageId}";
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
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatMessage>(localVarStatusCode,
                localVarHeaders,
                (WebChatMessage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatMessage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the messages of a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="after">If available, get the messages chronologically after the id of this message (optional)</param>
        /// <param name="before">If available, get the messages chronologically before the id of this message (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="maxResults">Limit the returned number of messages, up to a maximum of 100 (optional, default to 100)</param>
        /// <returns>WebChatMessageEntityList</returns>
        
        
        public WebChatMessageEntityList GetWebchatGuestConversationMessages (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null)
        {
             ApiResponse<WebChatMessageEntityList> localVarResponse = GetWebchatGuestConversationMessagesWithHttpInfo(conversationId, after, before, sortOrder, maxResults);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the messages of a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="after">If available, get the messages chronologically after the id of this message (optional)</param>
        /// <param name="before">If available, get the messages chronologically before the id of this message (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="maxResults">Limit the returned number of messages, up to a maximum of 100 (optional, default to 100)</param>
        /// <returns>ApiResponse of WebChatMessageEntityList</returns>
        
        
        public ApiResponse< WebChatMessageEntityList > GetWebchatGuestConversationMessagesWithHttpInfo (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMessages");

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/messages";
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
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (maxResults != null) localVarQueryParams.Add(new Tuple<string, string>("maxResults", this.Configuration.ApiClient.ParameterToString(maxResults)));

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatMessageEntityList>(localVarStatusCode,
                localVarHeaders,
                (WebChatMessageEntityList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatMessageEntityList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the messages of a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="after">If available, get the messages chronologically after the id of this message (optional)</param>
        /// <param name="before">If available, get the messages chronologically before the id of this message (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="maxResults">Limit the returned number of messages, up to a maximum of 100 (optional, default to 100)</param>
        /// <returns>Task of WebChatMessageEntityList</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatMessageEntityList> GetWebchatGuestConversationMessagesAsync (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null)
        {
             ApiResponse<WebChatMessageEntityList> localVarResponse = await GetWebchatGuestConversationMessagesAsyncWithHttpInfo(conversationId, after, before, sortOrder, maxResults);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the messages of a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="after">If available, get the messages chronologically after the id of this message (optional)</param>
        /// <param name="before">If available, get the messages chronologically before the id of this message (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="maxResults">Limit the returned number of messages, up to a maximum of 100 (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (WebChatMessageEntityList)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatMessageEntityList>> GetWebchatGuestConversationMessagesAsyncWithHttpInfo (string conversationId, string after = null, string before = null, string sortOrder = null, int? maxResults = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->GetWebchatGuestConversationMessages");
            

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/messages";
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
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (maxResults != null) localVarQueryParams.Add(new Tuple<string, string>("maxResults", this.Configuration.ApiClient.ParameterToString(maxResults)));

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatGuestConversationMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatMessageEntityList>(localVarStatusCode,
                localVarHeaders,
                (WebChatMessageEntityList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatMessageEntityList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WebChatSettings</returns>
        
        
        public WebChatSettings GetWebchatSettings ()
        {
             ApiResponse<WebChatSettings> localVarResponse = GetWebchatSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WebChatSettings</returns>
        
        
        public ApiResponse< WebChatSettings > GetWebchatSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/webchat/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatSettings>(localVarStatusCode,
                localVarHeaders,
                (WebChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WebChatSettings</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatSettings> GetWebchatSettingsAsync ()
        {
             ApiResponse<WebChatSettings> localVarResponse = await GetWebchatSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WebChatSettings)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatSettings>> GetWebchatSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/webchat/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWebchatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatSettings>(localVarStatusCode,
                localVarHeaders,
                (WebChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <param name="body">Request</param>
        /// <returns>WebChatGuestMediaRequest</returns>
        
        
        public WebChatGuestMediaRequest PatchWebchatGuestConversationMediarequest (string conversationId, string mediaRequestId, WebChatGuestMediaRequest body)
        {
             ApiResponse<WebChatGuestMediaRequest> localVarResponse = PatchWebchatGuestConversationMediarequestWithHttpInfo(conversationId, mediaRequestId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <param name="body">Request</param>
        /// <returns>ApiResponse of WebChatGuestMediaRequest</returns>
        
        
        public ApiResponse< WebChatGuestMediaRequest > PatchWebchatGuestConversationMediarequestWithHttpInfo (string conversationId, string mediaRequestId, WebChatGuestMediaRequest body)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->PatchWebchatGuestConversationMediarequest");
            // verify the required parameter 'mediaRequestId' is set
            if (mediaRequestId == null)
                throw new ApiException(400, "Missing required parameter 'mediaRequestId' when calling WebChatApi->PatchWebchatGuestConversationMediarequest");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PatchWebchatGuestConversationMediarequest");

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/mediarequests/{mediaRequestId}";
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
            if (mediaRequestId != null) localVarPathParams.Add("mediaRequestId", this.Configuration.ApiClient.ParameterToString(mediaRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWebchatGuestConversationMediarequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWebchatGuestConversationMediarequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatGuestMediaRequest>(localVarStatusCode,
                localVarHeaders,
                (WebChatGuestMediaRequest) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatGuestMediaRequest)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <param name="body">Request</param>
        /// <returns>Task of WebChatGuestMediaRequest</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatGuestMediaRequest> PatchWebchatGuestConversationMediarequestAsync (string conversationId, string mediaRequestId, WebChatGuestMediaRequest body)
        {
             ApiResponse<WebChatGuestMediaRequest> localVarResponse = await PatchWebchatGuestConversationMediarequestAsyncWithHttpInfo(conversationId, mediaRequestId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a media request in the conversation, setting the state to ACCEPTED/DECLINED/ERRORED 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="mediaRequestId">mediaRequestId</param>
        /// <param name="body">Request</param>
        /// <returns>Task of ApiResponse (WebChatGuestMediaRequest)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatGuestMediaRequest>> PatchWebchatGuestConversationMediarequestAsyncWithHttpInfo (string conversationId, string mediaRequestId, WebChatGuestMediaRequest body)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->PatchWebchatGuestConversationMediarequest");
            
            // verify the required parameter 'mediaRequestId' is set
            if (mediaRequestId == null)
                throw new ApiException(400, "Missing required parameter 'mediaRequestId' when calling WebChatApi->PatchWebchatGuestConversationMediarequest");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PatchWebchatGuestConversationMediarequest");
            

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/mediarequests/{mediaRequestId}";
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
            if (mediaRequestId != null) localVarPathParams.Add("mediaRequestId", this.Configuration.ApiClient.ParameterToString(mediaRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWebchatGuestConversationMediarequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWebchatGuestConversationMediarequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatGuestMediaRequest>(localVarStatusCode,
                localVarHeaders,
                (WebChatGuestMediaRequest) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatGuestMediaRequest)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>WebChatDeployment</returns>
        [Obsolete]
        
        public WebChatDeployment PostWebchatDeployments (WebChatDeployment body)
        {
             ApiResponse<WebChatDeployment> localVarResponse = PostWebchatDeploymentsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>ApiResponse of WebChatDeployment</returns>
        [Obsolete]
        
        public ApiResponse< WebChatDeployment > PostWebchatDeploymentsWithHttpInfo (WebChatDeployment body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PostWebchatDeployments");

            var localVarPath = "/api/v2/webchat/deployments";
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
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebChatDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>Task of WebChatDeployment</returns>
        [Obsolete]
        
        public async System.Threading.Tasks.Task<WebChatDeployment> PostWebchatDeploymentsAsync (WebChatDeployment body)
        {
             ApiResponse<WebChatDeployment> localVarResponse = await PostWebchatDeploymentsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Deployment</param>
        /// <returns>Task of ApiResponse (WebChatDeployment)</returns>
        [Obsolete]
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatDeployment>> PostWebchatDeploymentsAsyncWithHttpInfo (WebChatDeployment body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PostWebchatDeployments");
            

            var localVarPath = "/api/v2/webchat/deployments";
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
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatDeployments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatDeployments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebChatDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Send a message in a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <param name="body">Message</param>
        /// <returns>WebChatMessage</returns>
        
        
        public WebChatMessage PostWebchatGuestConversationMemberMessages (string conversationId, string memberId, CreateWebChatMessageRequest body)
        {
             ApiResponse<WebChatMessage> localVarResponse = PostWebchatGuestConversationMemberMessagesWithHttpInfo(conversationId, memberId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send a message in a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <param name="body">Message</param>
        /// <returns>ApiResponse of WebChatMessage</returns>
        
        
        public ApiResponse< WebChatMessage > PostWebchatGuestConversationMemberMessagesWithHttpInfo (string conversationId, string memberId, CreateWebChatMessageRequest body)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->PostWebchatGuestConversationMemberMessages");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling WebChatApi->PostWebchatGuestConversationMemberMessages");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PostWebchatGuestConversationMemberMessages");

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}/messages";
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
            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversationMemberMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversationMemberMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatMessage>(localVarStatusCode,
                localVarHeaders,
                (WebChatMessage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatMessage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Send a message in a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <param name="body">Message</param>
        /// <returns>Task of WebChatMessage</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatMessage> PostWebchatGuestConversationMemberMessagesAsync (string conversationId, string memberId, CreateWebChatMessageRequest body)
        {
             ApiResponse<WebChatMessage> localVarResponse = await PostWebchatGuestConversationMemberMessagesAsyncWithHttpInfo(conversationId, memberId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send a message in a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <param name="body">Message</param>
        /// <returns>Task of ApiResponse (WebChatMessage)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatMessage>> PostWebchatGuestConversationMemberMessagesAsyncWithHttpInfo (string conversationId, string memberId, CreateWebChatMessageRequest body)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->PostWebchatGuestConversationMemberMessages");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling WebChatApi->PostWebchatGuestConversationMemberMessages");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PostWebchatGuestConversationMemberMessages");
            

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}/messages";
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
            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversationMemberMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversationMemberMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatMessage>(localVarStatusCode,
                localVarHeaders,
                (WebChatMessage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatMessage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Send a typing-indicator in a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>WebChatTyping</returns>
        
        
        public WebChatTyping PostWebchatGuestConversationMemberTyping (string conversationId, string memberId)
        {
             ApiResponse<WebChatTyping> localVarResponse = PostWebchatGuestConversationMemberTypingWithHttpInfo(conversationId, memberId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send a typing-indicator in a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>ApiResponse of WebChatTyping</returns>
        
        
        public ApiResponse< WebChatTyping > PostWebchatGuestConversationMemberTypingWithHttpInfo (string conversationId, string memberId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->PostWebchatGuestConversationMemberTyping");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling WebChatApi->PostWebchatGuestConversationMemberTyping");

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}/typing";
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
            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversationMemberTyping: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversationMemberTyping: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatTyping>(localVarStatusCode,
                localVarHeaders,
                (WebChatTyping) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatTyping)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Send a typing-indicator in a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of WebChatTyping</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatTyping> PostWebchatGuestConversationMemberTypingAsync (string conversationId, string memberId)
        {
             ApiResponse<WebChatTyping> localVarResponse = await PostWebchatGuestConversationMemberTypingAsyncWithHttpInfo(conversationId, memberId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send a typing-indicator in a chat conversation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="memberId">memberId</param>
        /// <returns>Task of ApiResponse (WebChatTyping)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatTyping>> PostWebchatGuestConversationMemberTypingAsyncWithHttpInfo (string conversationId, string memberId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling WebChatApi->PostWebchatGuestConversationMemberTyping");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling WebChatApi->PostWebchatGuestConversationMemberTyping");
            

            var localVarPath = "/api/v2/webchat/guest/conversations/{conversationId}/members/{memberId}/typing";
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
            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (Guest Chat JWT) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversationMemberTyping: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversationMemberTyping: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatTyping>(localVarStatusCode,
                localVarHeaders,
                (WebChatTyping) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatTyping)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an ACD chat conversation from an external customer. This endpoint will create a new ACD Chat conversation under the specified Chat Deployment.  The conversation will begin with a guest member in it (with a role=CUSTOMER) according to the customer information that is supplied. If the guest member is authenticated, the 'memberAuthToken' field should include his JWT as generated by the 'POST /api/v2/signeddata' resource; if the guest member is anonymous (and the Deployment permits it) this field can be omitted.  The returned data includes the IDs of the conversation created, along with a newly-create JWT token that you can supply to all future endpoints as authentication to perform operations against that conversation. After successfully creating a conversation, you should connect a websocket to the event stream named in the 'eventStreamUri' field of the response; the conversation is not routed until the event stream is attached.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateConversationRequest</param>
        /// <returns>CreateWebChatConversationResponse</returns>
        
        
        public CreateWebChatConversationResponse PostWebchatGuestConversations (CreateWebChatConversationRequest body)
        {
             ApiResponse<CreateWebChatConversationResponse> localVarResponse = PostWebchatGuestConversationsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an ACD chat conversation from an external customer. This endpoint will create a new ACD Chat conversation under the specified Chat Deployment.  The conversation will begin with a guest member in it (with a role=CUSTOMER) according to the customer information that is supplied. If the guest member is authenticated, the 'memberAuthToken' field should include his JWT as generated by the 'POST /api/v2/signeddata' resource; if the guest member is anonymous (and the Deployment permits it) this field can be omitted.  The returned data includes the IDs of the conversation created, along with a newly-create JWT token that you can supply to all future endpoints as authentication to perform operations against that conversation. After successfully creating a conversation, you should connect a websocket to the event stream named in the 'eventStreamUri' field of the response; the conversation is not routed until the event stream is attached.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateConversationRequest</param>
        /// <returns>ApiResponse of CreateWebChatConversationResponse</returns>
        
        
        public ApiResponse< CreateWebChatConversationResponse > PostWebchatGuestConversationsWithHttpInfo (CreateWebChatConversationRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PostWebchatGuestConversations");

            var localVarPath = "/api/v2/webchat/guest/conversations";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateWebChatConversationResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateWebChatConversationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateWebChatConversationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an ACD chat conversation from an external customer. This endpoint will create a new ACD Chat conversation under the specified Chat Deployment.  The conversation will begin with a guest member in it (with a role=CUSTOMER) according to the customer information that is supplied. If the guest member is authenticated, the 'memberAuthToken' field should include his JWT as generated by the 'POST /api/v2/signeddata' resource; if the guest member is anonymous (and the Deployment permits it) this field can be omitted.  The returned data includes the IDs of the conversation created, along with a newly-create JWT token that you can supply to all future endpoints as authentication to perform operations against that conversation. After successfully creating a conversation, you should connect a websocket to the event stream named in the 'eventStreamUri' field of the response; the conversation is not routed until the event stream is attached.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateConversationRequest</param>
        /// <returns>Task of CreateWebChatConversationResponse</returns>
        
        
        public async System.Threading.Tasks.Task<CreateWebChatConversationResponse> PostWebchatGuestConversationsAsync (CreateWebChatConversationRequest body)
        {
             ApiResponse<CreateWebChatConversationResponse> localVarResponse = await PostWebchatGuestConversationsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an ACD chat conversation from an external customer. This endpoint will create a new ACD Chat conversation under the specified Chat Deployment.  The conversation will begin with a guest member in it (with a role=CUSTOMER) according to the customer information that is supplied. If the guest member is authenticated, the 'memberAuthToken' field should include his JWT as generated by the 'POST /api/v2/signeddata' resource; if the guest member is anonymous (and the Deployment permits it) this field can be omitted.  The returned data includes the IDs of the conversation created, along with a newly-create JWT token that you can supply to all future endpoints as authentication to perform operations against that conversation. After successfully creating a conversation, you should connect a websocket to the event stream named in the 'eventStreamUri' field of the response; the conversation is not routed until the event stream is attached.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateConversationRequest</param>
        /// <returns>Task of ApiResponse (CreateWebChatConversationResponse)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<CreateWebChatConversationResponse>> PostWebchatGuestConversationsAsyncWithHttpInfo (CreateWebChatConversationRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PostWebchatGuestConversations");
            

            var localVarPath = "/api/v2/webchat/guest/conversations";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWebchatGuestConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateWebChatConversationResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateWebChatConversationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateWebChatConversationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>WebChatDeployment</returns>
        [Obsolete]
        
        public WebChatDeployment PutWebchatDeployment (string deploymentId, WebChatDeployment body)
        {
             ApiResponse<WebChatDeployment> localVarResponse = PutWebchatDeploymentWithHttpInfo(deploymentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>ApiResponse of WebChatDeployment</returns>
        [Obsolete]
        
        public ApiResponse< WebChatDeployment > PutWebchatDeploymentWithHttpInfo (string deploymentId, WebChatDeployment body)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebChatApi->PutWebchatDeployment");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PutWebchatDeployment");

            var localVarPath = "/api/v2/webchat/deployments/{deploymentId}";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutWebchatDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWebchatDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebChatDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>Task of WebChatDeployment</returns>
        [Obsolete]
        
        public async System.Threading.Tasks.Task<WebChatDeployment> PutWebchatDeploymentAsync (string deploymentId, WebChatDeployment body)
        {
             ApiResponse<WebChatDeployment> localVarResponse = await PutWebchatDeploymentAsyncWithHttpInfo(deploymentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a WebChat deployment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deploymentId">Deployment Id</param>
        /// <param name="body">Deployment</param>
        /// <returns>Task of ApiResponse (WebChatDeployment)</returns>
        [Obsolete]
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatDeployment>> PutWebchatDeploymentAsyncWithHttpInfo (string deploymentId, WebChatDeployment body)
        { 
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null)
                throw new ApiException(400, "Missing required parameter 'deploymentId' when calling WebChatApi->PutWebchatDeployment");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PutWebchatDeployment");
            

            var localVarPath = "/api/v2/webchat/deployments/{deploymentId}";
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
            if (deploymentId != null) localVarPathParams.Add("deploymentId", this.Configuration.ApiClient.ParameterToString(deploymentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutWebchatDeployment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWebchatDeployment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatDeployment>(localVarStatusCode,
                localVarHeaders,
                (WebChatDeployment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatDeployment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webChatSettings</param>
        /// <returns>WebChatSettings</returns>
        
        
        public WebChatSettings PutWebchatSettings (WebChatSettings body)
        {
             ApiResponse<WebChatSettings> localVarResponse = PutWebchatSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webChatSettings</param>
        /// <returns>ApiResponse of WebChatSettings</returns>
        
        
        public ApiResponse< WebChatSettings > PutWebchatSettingsWithHttpInfo (WebChatSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PutWebchatSettings");

            var localVarPath = "/api/v2/webchat/settings";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutWebchatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWebchatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatSettings>(localVarStatusCode,
                localVarHeaders,
                (WebChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webChatSettings</param>
        /// <returns>Task of WebChatSettings</returns>
        
        
        public async System.Threading.Tasks.Task<WebChatSettings> PutWebchatSettingsAsync (WebChatSettings body)
        {
             ApiResponse<WebChatSettings> localVarResponse = await PutWebchatSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update WebChat deployment settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">webChatSettings</param>
        /// <returns>Task of ApiResponse (WebChatSettings)</returns>
        
        
        public async System.Threading.Tasks.Task<ApiResponse<WebChatSettings>> PutWebchatSettingsAsyncWithHttpInfo (WebChatSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebChatApi->PutWebchatSettings");
            

            var localVarPath = "/api/v2/webchat/settings";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutWebchatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWebchatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WebChatSettings>(localVarStatusCode,
                localVarHeaders,
                (WebChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
