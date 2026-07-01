using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScreenMonitoringApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Stop a conversation-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns></returns>
        
        void DeleteConversationParticipantScreenmonitorsSession (string conversationId, string participantId, string screenMonitoringId);

        /// <summary>
        /// Stop a conversation-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteConversationParticipantScreenmonitorsSessionWithHttpInfo (string conversationId, string participantId, string screenMonitoringId);

        /// <summary>
        /// Stop an agent-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns></returns>
        
        void DeleteUserScreenmonitorsSession (string userId, string screenMonitoringId);

        /// <summary>
        /// Stop an agent-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteUserScreenmonitorsSessionWithHttpInfo (string userId, string screenMonitoringId);

        /// <summary>
        /// Get a conversation-level screen monitoring session object using the supplied screenMonitoringId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ScreenMonitoringSession</returns>
        
        ScreenMonitoringSession GetConversationParticipantScreenmonitorsSession (string conversationId, string participantId, string screenMonitoringId);

        /// <summary>
        /// Get a conversation-level screen monitoring session object using the supplied screenMonitoringId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ApiResponse of ScreenMonitoringSession</returns>
        
        ApiResponse<ScreenMonitoringSession> GetConversationParticipantScreenmonitorsSessionWithHttpInfo (string conversationId, string participantId, string screenMonitoringId);

        /// <summary>
        /// Get the details of all screen monitoring sessions for the current organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ScreenMonitoringDetails</returns>
        
        ScreenMonitoringDetails GetScreenmonitorsSessionsDetails ();

        /// <summary>
        /// Get the details of all screen monitoring sessions for the current organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ScreenMonitoringDetails</returns>
        
        ApiResponse<ScreenMonitoringDetails> GetScreenmonitorsSessionsDetailsWithHttpInfo ();

        /// <summary>
        /// Get the Screen Monitor Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ScreenMonitorSettings</returns>
        
        ScreenMonitorSettings GetScreenmonitorsSettings ();

        /// <summary>
        /// Get the Screen Monitor Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ScreenMonitorSettings</returns>
        
        ApiResponse<ScreenMonitorSettings> GetScreenmonitorsSettingsWithHttpInfo ();

        /// <summary>
        /// Get all screen monitoring sessions for the supplied userId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ScreenMonitoringSessionEntityListing</returns>
        
        ScreenMonitoringSessionEntityListing GetScreenmonitorsUserSessions (string userId);

        /// <summary>
        /// Get all screen monitoring sessions for the supplied userId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of ScreenMonitoringSessionEntityListing</returns>
        
        ApiResponse<ScreenMonitoringSessionEntityListing> GetScreenmonitorsUserSessionsWithHttpInfo (string userId);

        /// <summary>
        /// Get an agent-level screen monitoring session object using the supplied screenMonitoringId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ScreenMonitoringSession</returns>
        
        ScreenMonitoringSession GetUserScreenmonitorsSession (string userId, string screenMonitoringId);

        /// <summary>
        /// Get an agent-level screen monitoring session object using the supplied screenMonitoringId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ApiResponse of ScreenMonitoringSession</returns>
        
        ApiResponse<ScreenMonitoringSession> GetUserScreenmonitorsSessionWithHttpInfo (string userId, string screenMonitoringId);

        /// <summary>
        /// Start a conversation-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <returns>StartScreenMonitorResponseBody</returns>
        
        StartScreenMonitorResponseBody PostConversationParticipantScreenmonitorsSessions (string conversationId, string participantId);

        /// <summary>
        /// Start a conversation-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <returns>ApiResponse of StartScreenMonitorResponseBody</returns>
        
        ApiResponse<StartScreenMonitorResponseBody> PostConversationParticipantScreenmonitorsSessionsWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Get screen monitor session details for one or more users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of target user IDs</param>
        /// <returns>ScreenMonitoringUserDetailsEntityListing</returns>
        
        ScreenMonitoringUserDetailsEntityListing PostScreenmonitorsSessionsUsersDetails (List<string> body);

        /// <summary>
        /// Get screen monitor session details for one or more users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of target user IDs</param>
        /// <returns>ApiResponse of ScreenMonitoringUserDetailsEntityListing</returns>
        
        ApiResponse<ScreenMonitoringUserDetailsEntityListing> PostScreenmonitorsSessionsUsersDetailsWithHttpInfo (List<string> body);

        /// <summary>
        /// Start an agent-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>StartScreenMonitorResponseBody</returns>
        
        StartScreenMonitorResponseBody PostUserScreenmonitorsSessions (string userId);

        /// <summary>
        /// Start an agent-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of StartScreenMonitorResponseBody</returns>
        
        ApiResponse<StartScreenMonitorResponseBody> PostUserScreenmonitorsSessionsWithHttpInfo (string userId);

        /// <summary>
        /// Update the Screen Monitor Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Screen Monitor settings</param>
        /// <returns></returns>
        
        void PutScreenmonitorsSettings (ScreenMonitorSettings body);

        /// <summary>
        /// Update the Screen Monitor Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Screen Monitor settings</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PutScreenmonitorsSettingsWithHttpInfo (ScreenMonitorSettings body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Stop a conversation-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteConversationParticipantScreenmonitorsSessionAsync (string conversationId, string participantId, string screenMonitoringId);

        /// <summary>
        /// Stop a conversation-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationParticipantScreenmonitorsSessionAsyncWithHttpInfo (string conversationId, string participantId, string screenMonitoringId);

        /// <summary>
        /// Stop an agent-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteUserScreenmonitorsSessionAsync (string userId, string screenMonitoringId);

        /// <summary>
        /// Stop an agent-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserScreenmonitorsSessionAsyncWithHttpInfo (string userId, string screenMonitoringId);

        /// <summary>
        /// Get a conversation-level screen monitoring session object using the supplied screenMonitoringId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ScreenMonitoringSession</returns>
        
        System.Threading.Tasks.Task<ScreenMonitoringSession> GetConversationParticipantScreenmonitorsSessionAsync (string conversationId, string participantId, string screenMonitoringId);

        /// <summary>
        /// Get a conversation-level screen monitoring session object using the supplied screenMonitoringId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ApiResponse (ScreenMonitoringSession)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ScreenMonitoringSession>> GetConversationParticipantScreenmonitorsSessionAsyncWithHttpInfo (string conversationId, string participantId, string screenMonitoringId);

        /// <summary>
        /// Get the details of all screen monitoring sessions for the current organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ScreenMonitoringDetails</returns>
        
        System.Threading.Tasks.Task<ScreenMonitoringDetails> GetScreenmonitorsSessionsDetailsAsync ();

        /// <summary>
        /// Get the details of all screen monitoring sessions for the current organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ScreenMonitoringDetails)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ScreenMonitoringDetails>> GetScreenmonitorsSessionsDetailsAsyncWithHttpInfo ();

        /// <summary>
        /// Get the Screen Monitor Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ScreenMonitorSettings</returns>
        
        System.Threading.Tasks.Task<ScreenMonitorSettings> GetScreenmonitorsSettingsAsync ();

        /// <summary>
        /// Get the Screen Monitor Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ScreenMonitorSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ScreenMonitorSettings>> GetScreenmonitorsSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Get all screen monitoring sessions for the supplied userId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ScreenMonitoringSessionEntityListing</returns>
        
        System.Threading.Tasks.Task<ScreenMonitoringSessionEntityListing> GetScreenmonitorsUserSessionsAsync (string userId);

        /// <summary>
        /// Get all screen monitoring sessions for the supplied userId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (ScreenMonitoringSessionEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ScreenMonitoringSessionEntityListing>> GetScreenmonitorsUserSessionsAsyncWithHttpInfo (string userId);

        /// <summary>
        /// Get an agent-level screen monitoring session object using the supplied screenMonitoringId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ScreenMonitoringSession</returns>
        
        System.Threading.Tasks.Task<ScreenMonitoringSession> GetUserScreenmonitorsSessionAsync (string userId, string screenMonitoringId);

        /// <summary>
        /// Get an agent-level screen monitoring session object using the supplied screenMonitoringId.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ApiResponse (ScreenMonitoringSession)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ScreenMonitoringSession>> GetUserScreenmonitorsSessionAsyncWithHttpInfo (string userId, string screenMonitoringId);

        /// <summary>
        /// Start a conversation-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <returns>Task of StartScreenMonitorResponseBody</returns>
        
        System.Threading.Tasks.Task<StartScreenMonitorResponseBody> PostConversationParticipantScreenmonitorsSessionsAsync (string conversationId, string participantId);

        /// <summary>
        /// Start a conversation-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <returns>Task of ApiResponse (StartScreenMonitorResponseBody)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<StartScreenMonitorResponseBody>> PostConversationParticipantScreenmonitorsSessionsAsyncWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Get screen monitor session details for one or more users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of target user IDs</param>
        /// <returns>Task of ScreenMonitoringUserDetailsEntityListing</returns>
        
        System.Threading.Tasks.Task<ScreenMonitoringUserDetailsEntityListing> PostScreenmonitorsSessionsUsersDetailsAsync (List<string> body);

        /// <summary>
        /// Get screen monitor session details for one or more users.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of target user IDs</param>
        /// <returns>Task of ApiResponse (ScreenMonitoringUserDetailsEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ScreenMonitoringUserDetailsEntityListing>> PostScreenmonitorsSessionsUsersDetailsAsyncWithHttpInfo (List<string> body);

        /// <summary>
        /// Start an agent-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of StartScreenMonitorResponseBody</returns>
        
        System.Threading.Tasks.Task<StartScreenMonitorResponseBody> PostUserScreenmonitorsSessionsAsync (string userId);

        /// <summary>
        /// Start an agent-level screen monitoring session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (StartScreenMonitorResponseBody)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<StartScreenMonitorResponseBody>> PostUserScreenmonitorsSessionsAsyncWithHttpInfo (string userId);

        /// <summary>
        /// Update the Screen Monitor Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Screen Monitor settings</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PutScreenmonitorsSettingsAsync (ScreenMonitorSettings body);

        /// <summary>
        /// Update the Screen Monitor Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Screen Monitor settings</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PutScreenmonitorsSettingsAsyncWithHttpInfo (ScreenMonitorSettings body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ScreenMonitoringApi : IScreenMonitoringApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenMonitoringApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScreenMonitoringApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenMonitoringApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ScreenMonitoringApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Stop a conversation-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns></returns>
        
        public void DeleteConversationParticipantScreenmonitorsSession (string conversationId, string participantId, string screenMonitoringId)
        {
             DeleteConversationParticipantScreenmonitorsSessionWithHttpInfo(conversationId, participantId, screenMonitoringId);
        }

        /// <summary>
        /// Stop a conversation-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteConversationParticipantScreenmonitorsSessionWithHttpInfo (string conversationId, string participantId, string screenMonitoringId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ScreenMonitoringApi->DeleteConversationParticipantScreenmonitorsSession");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ScreenMonitoringApi->DeleteConversationParticipantScreenmonitorsSession");
            // verify the required parameter 'screenMonitoringId' is set
            if (screenMonitoringId == null)
                throw new ApiException(400, "Missing required parameter 'screenMonitoringId' when calling ScreenMonitoringApi->DeleteConversationParticipantScreenmonitorsSession");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/screenmonitors/sessions/{screenMonitoringId}";
            var localVarHttpMethod = "Delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (participantId != null) localVarPathParams.Add("participantId", this.Configuration.ApiClient.ParameterToString(participantId));
            if (screenMonitoringId != null) localVarPathParams.Add("screenMonitoringId", this.Configuration.ApiClient.ParameterToString(screenMonitoringId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteConversationParticipantScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantScreenmonitorsSession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Stop a conversation-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteConversationParticipantScreenmonitorsSessionAsync (string conversationId, string participantId, string screenMonitoringId)
        {
             await DeleteConversationParticipantScreenmonitorsSessionAsyncWithHttpInfo(conversationId, participantId, screenMonitoringId);

        }

        /// <summary>
        /// Stop a conversation-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationParticipantScreenmonitorsSessionAsyncWithHttpInfo (string conversationId, string participantId, string screenMonitoringId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ScreenMonitoringApi->DeleteConversationParticipantScreenmonitorsSession");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ScreenMonitoringApi->DeleteConversationParticipantScreenmonitorsSession");
            
            // verify the required parameter 'screenMonitoringId' is set
            if (screenMonitoringId == null)
                throw new ApiException(400, "Missing required parameter 'screenMonitoringId' when calling ScreenMonitoringApi->DeleteConversationParticipantScreenmonitorsSession");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/screenmonitors/sessions/{screenMonitoringId}";
            var localVarHttpMethod = "Delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (participantId != null) localVarPathParams.Add("participantId", this.Configuration.ApiClient.ParameterToString(participantId));
            if (screenMonitoringId != null) localVarPathParams.Add("screenMonitoringId", this.Configuration.ApiClient.ParameterToString(screenMonitoringId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteConversationParticipantScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantScreenmonitorsSession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Stop an agent-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns></returns>
        
        public void DeleteUserScreenmonitorsSession (string userId, string screenMonitoringId)
        {
             DeleteUserScreenmonitorsSessionWithHttpInfo(userId, screenMonitoringId);
        }

        /// <summary>
        /// Stop an agent-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteUserScreenmonitorsSessionWithHttpInfo (string userId, string screenMonitoringId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ScreenMonitoringApi->DeleteUserScreenmonitorsSession");
            // verify the required parameter 'screenMonitoringId' is set
            if (screenMonitoringId == null)
                throw new ApiException(400, "Missing required parameter 'screenMonitoringId' when calling ScreenMonitoringApi->DeleteUserScreenmonitorsSession");

            var localVarPath = "/api/v2/users/{userId}/screenmonitors/sessions/{screenMonitoringId}";
            var localVarHttpMethod = "Delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (screenMonitoringId != null) localVarPathParams.Add("screenMonitoringId", this.Configuration.ApiClient.ParameterToString(screenMonitoringId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteUserScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserScreenmonitorsSession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Stop an agent-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteUserScreenmonitorsSessionAsync (string userId, string screenMonitoringId)
        {
             await DeleteUserScreenmonitorsSessionAsyncWithHttpInfo(userId, screenMonitoringId);

        }

        /// <summary>
        /// Stop an agent-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserScreenmonitorsSessionAsyncWithHttpInfo (string userId, string screenMonitoringId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ScreenMonitoringApi->DeleteUserScreenmonitorsSession");
            
            // verify the required parameter 'screenMonitoringId' is set
            if (screenMonitoringId == null)
                throw new ApiException(400, "Missing required parameter 'screenMonitoringId' when calling ScreenMonitoringApi->DeleteUserScreenmonitorsSession");
            

            var localVarPath = "/api/v2/users/{userId}/screenmonitors/sessions/{screenMonitoringId}";
            var localVarHttpMethod = "Delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (screenMonitoringId != null) localVarPathParams.Add("screenMonitoringId", this.Configuration.ApiClient.ParameterToString(screenMonitoringId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteUserScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserScreenmonitorsSession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a conversation-level screen monitoring session object using the supplied screenMonitoringId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ScreenMonitoringSession</returns>
        
        public ScreenMonitoringSession GetConversationParticipantScreenmonitorsSession (string conversationId, string participantId, string screenMonitoringId)
        {
             ApiResponse<ScreenMonitoringSession> localVarResponse = GetConversationParticipantScreenmonitorsSessionWithHttpInfo(conversationId, participantId, screenMonitoringId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a conversation-level screen monitoring session object using the supplied screenMonitoringId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ApiResponse of ScreenMonitoringSession</returns>
        
        public ApiResponse< ScreenMonitoringSession > GetConversationParticipantScreenmonitorsSessionWithHttpInfo (string conversationId, string participantId, string screenMonitoringId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ScreenMonitoringApi->GetConversationParticipantScreenmonitorsSession");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ScreenMonitoringApi->GetConversationParticipantScreenmonitorsSession");
            // verify the required parameter 'screenMonitoringId' is set
            if (screenMonitoringId == null)
                throw new ApiException(400, "Missing required parameter 'screenMonitoringId' when calling ScreenMonitoringApi->GetConversationParticipantScreenmonitorsSession");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/screenmonitors/sessions/{screenMonitoringId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (participantId != null) localVarPathParams.Add("participantId", this.Configuration.ApiClient.ParameterToString(participantId));
            if (screenMonitoringId != null) localVarPathParams.Add("screenMonitoringId", this.Configuration.ApiClient.ParameterToString(screenMonitoringId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetConversationParticipantScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantScreenmonitorsSession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitoringSession>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitoringSession) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitoringSession)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a conversation-level screen monitoring session object using the supplied screenMonitoringId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ScreenMonitoringSession</returns>
        
        public async System.Threading.Tasks.Task<ScreenMonitoringSession> GetConversationParticipantScreenmonitorsSessionAsync (string conversationId, string participantId, string screenMonitoringId)
        {
             ApiResponse<ScreenMonitoringSession> localVarResponse = await GetConversationParticipantScreenmonitorsSessionAsyncWithHttpInfo(conversationId, participantId, screenMonitoringId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a conversation-level screen monitoring session object using the supplied screenMonitoringId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ApiResponse (ScreenMonitoringSession)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ScreenMonitoringSession>> GetConversationParticipantScreenmonitorsSessionAsyncWithHttpInfo (string conversationId, string participantId, string screenMonitoringId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ScreenMonitoringApi->GetConversationParticipantScreenmonitorsSession");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ScreenMonitoringApi->GetConversationParticipantScreenmonitorsSession");
            
            // verify the required parameter 'screenMonitoringId' is set
            if (screenMonitoringId == null)
                throw new ApiException(400, "Missing required parameter 'screenMonitoringId' when calling ScreenMonitoringApi->GetConversationParticipantScreenmonitorsSession");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/screenmonitors/sessions/{screenMonitoringId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (participantId != null) localVarPathParams.Add("participantId", this.Configuration.ApiClient.ParameterToString(participantId));
            if (screenMonitoringId != null) localVarPathParams.Add("screenMonitoringId", this.Configuration.ApiClient.ParameterToString(screenMonitoringId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetConversationParticipantScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantScreenmonitorsSession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitoringSession>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitoringSession) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitoringSession)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the details of all screen monitoring sessions for the current organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ScreenMonitoringDetails</returns>
        
        public ScreenMonitoringDetails GetScreenmonitorsSessionsDetails ()
        {
             ApiResponse<ScreenMonitoringDetails> localVarResponse = GetScreenmonitorsSessionsDetailsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the details of all screen monitoring sessions for the current organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ScreenMonitoringDetails</returns>
        
        public ApiResponse< ScreenMonitoringDetails > GetScreenmonitorsSessionsDetailsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/screenmonitors/sessions/details";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsSessionsDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetScreenmonitorsSessionsDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsSessionsDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitoringDetails>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitoringDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitoringDetails)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the details of all screen monitoring sessions for the current organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ScreenMonitoringDetails</returns>
        
        public async System.Threading.Tasks.Task<ScreenMonitoringDetails> GetScreenmonitorsSessionsDetailsAsync ()
        {
             ApiResponse<ScreenMonitoringDetails> localVarResponse = await GetScreenmonitorsSessionsDetailsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the details of all screen monitoring sessions for the current organization. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ScreenMonitoringDetails)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ScreenMonitoringDetails>> GetScreenmonitorsSessionsDetailsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/screenmonitors/sessions/details";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsSessionsDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetScreenmonitorsSessionsDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsSessionsDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitoringDetails>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitoringDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitoringDetails)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the Screen Monitor Settings for the Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ScreenMonitorSettings</returns>
        
        public ScreenMonitorSettings GetScreenmonitorsSettings ()
        {
             ApiResponse<ScreenMonitorSettings> localVarResponse = GetScreenmonitorsSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Screen Monitor Settings for the Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ScreenMonitorSettings</returns>
        
        public ApiResponse< ScreenMonitorSettings > GetScreenmonitorsSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/screenmonitors/settings";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetScreenmonitorsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitorSettings>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitorSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitorSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the Screen Monitor Settings for the Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ScreenMonitorSettings</returns>
        
        public async System.Threading.Tasks.Task<ScreenMonitorSettings> GetScreenmonitorsSettingsAsync ()
        {
             ApiResponse<ScreenMonitorSettings> localVarResponse = await GetScreenmonitorsSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Screen Monitor Settings for the Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ScreenMonitorSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ScreenMonitorSettings>> GetScreenmonitorsSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/screenmonitors/settings";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetScreenmonitorsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitorSettings>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitorSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitorSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all screen monitoring sessions for the supplied userId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ScreenMonitoringSessionEntityListing</returns>
        
        public ScreenMonitoringSessionEntityListing GetScreenmonitorsUserSessions (string userId)
        {
             ApiResponse<ScreenMonitoringSessionEntityListing> localVarResponse = GetScreenmonitorsUserSessionsWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all screen monitoring sessions for the supplied userId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of ScreenMonitoringSessionEntityListing</returns>
        
        public ApiResponse< ScreenMonitoringSessionEntityListing > GetScreenmonitorsUserSessionsWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ScreenMonitoringApi->GetScreenmonitorsUserSessions");

            var localVarPath = "/api/v2/screenmonitors/users/{userId}/sessions";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsUserSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetScreenmonitorsUserSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsUserSessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitoringSessionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitoringSessionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitoringSessionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all screen monitoring sessions for the supplied userId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ScreenMonitoringSessionEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ScreenMonitoringSessionEntityListing> GetScreenmonitorsUserSessionsAsync (string userId)
        {
             ApiResponse<ScreenMonitoringSessionEntityListing> localVarResponse = await GetScreenmonitorsUserSessionsAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all screen monitoring sessions for the supplied userId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (ScreenMonitoringSessionEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ScreenMonitoringSessionEntityListing>> GetScreenmonitorsUserSessionsAsyncWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ScreenMonitoringApi->GetScreenmonitorsUserSessions");
            

            var localVarPath = "/api/v2/screenmonitors/users/{userId}/sessions";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsUserSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetScreenmonitorsUserSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScreenmonitorsUserSessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitoringSessionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitoringSessionEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitoringSessionEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an agent-level screen monitoring session object using the supplied screenMonitoringId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ScreenMonitoringSession</returns>
        
        public ScreenMonitoringSession GetUserScreenmonitorsSession (string userId, string screenMonitoringId)
        {
             ApiResponse<ScreenMonitoringSession> localVarResponse = GetUserScreenmonitorsSessionWithHttpInfo(userId, screenMonitoringId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an agent-level screen monitoring session object using the supplied screenMonitoringId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>ApiResponse of ScreenMonitoringSession</returns>
        
        public ApiResponse< ScreenMonitoringSession > GetUserScreenmonitorsSessionWithHttpInfo (string userId, string screenMonitoringId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ScreenMonitoringApi->GetUserScreenmonitorsSession");
            // verify the required parameter 'screenMonitoringId' is set
            if (screenMonitoringId == null)
                throw new ApiException(400, "Missing required parameter 'screenMonitoringId' when calling ScreenMonitoringApi->GetUserScreenmonitorsSession");

            var localVarPath = "/api/v2/users/{userId}/screenmonitors/sessions/{screenMonitoringId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (screenMonitoringId != null) localVarPathParams.Add("screenMonitoringId", this.Configuration.ApiClient.ParameterToString(screenMonitoringId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUserScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetUserScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserScreenmonitorsSession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitoringSession>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitoringSession) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitoringSession)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an agent-level screen monitoring session object using the supplied screenMonitoringId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ScreenMonitoringSession</returns>
        
        public async System.Threading.Tasks.Task<ScreenMonitoringSession> GetUserScreenmonitorsSessionAsync (string userId, string screenMonitoringId)
        {
             ApiResponse<ScreenMonitoringSession> localVarResponse = await GetUserScreenmonitorsSessionAsyncWithHttpInfo(userId, screenMonitoringId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an agent-level screen monitoring session object using the supplied screenMonitoringId. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="screenMonitoringId">Screen Monitoring ID</param>
        /// <returns>Task of ApiResponse (ScreenMonitoringSession)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ScreenMonitoringSession>> GetUserScreenmonitorsSessionAsyncWithHttpInfo (string userId, string screenMonitoringId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ScreenMonitoringApi->GetUserScreenmonitorsSession");
            
            // verify the required parameter 'screenMonitoringId' is set
            if (screenMonitoringId == null)
                throw new ApiException(400, "Missing required parameter 'screenMonitoringId' when calling ScreenMonitoringApi->GetUserScreenmonitorsSession");
            

            var localVarPath = "/api/v2/users/{userId}/screenmonitors/sessions/{screenMonitoringId}";
            var localVarHttpMethod = "Get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (screenMonitoringId != null) localVarPathParams.Add("screenMonitoringId", this.Configuration.ApiClient.ParameterToString(screenMonitoringId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUserScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetUserScreenmonitorsSession: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserScreenmonitorsSession: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitoringSession>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitoringSession) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitoringSession)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Start a conversation-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <returns>StartScreenMonitorResponseBody</returns>
        
        public StartScreenMonitorResponseBody PostConversationParticipantScreenmonitorsSessions (string conversationId, string participantId)
        {
             ApiResponse<StartScreenMonitorResponseBody> localVarResponse = PostConversationParticipantScreenmonitorsSessionsWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start a conversation-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <returns>ApiResponse of StartScreenMonitorResponseBody</returns>
        
        public ApiResponse< StartScreenMonitorResponseBody > PostConversationParticipantScreenmonitorsSessionsWithHttpInfo (string conversationId, string participantId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ScreenMonitoringApi->PostConversationParticipantScreenmonitorsSessions");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ScreenMonitoringApi->PostConversationParticipantScreenmonitorsSessions");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/screenmonitors/sessions";
            var localVarHttpMethod = "Post";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (participantId != null) localVarPathParams.Add("participantId", this.Configuration.ApiClient.ParameterToString(participantId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantScreenmonitorsSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostConversationParticipantScreenmonitorsSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantScreenmonitorsSessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StartScreenMonitorResponseBody>(localVarStatusCode,
                localVarHeaders,
                (StartScreenMonitorResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StartScreenMonitorResponseBody)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Start a conversation-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <returns>Task of StartScreenMonitorResponseBody</returns>
        
        public async System.Threading.Tasks.Task<StartScreenMonitorResponseBody> PostConversationParticipantScreenmonitorsSessionsAsync (string conversationId, string participantId)
        {
             ApiResponse<StartScreenMonitorResponseBody> localVarResponse = await PostConversationParticipantScreenmonitorsSessionsAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start a conversation-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="participantId">Participant ID</param>
        /// <returns>Task of ApiResponse (StartScreenMonitorResponseBody)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<StartScreenMonitorResponseBody>> PostConversationParticipantScreenmonitorsSessionsAsyncWithHttpInfo (string conversationId, string participantId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ScreenMonitoringApi->PostConversationParticipantScreenmonitorsSessions");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ScreenMonitoringApi->PostConversationParticipantScreenmonitorsSessions");
            

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/screenmonitors/sessions";
            var localVarHttpMethod = "Post";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (participantId != null) localVarPathParams.Add("participantId", this.Configuration.ApiClient.ParameterToString(participantId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantScreenmonitorsSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostConversationParticipantScreenmonitorsSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantScreenmonitorsSessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StartScreenMonitorResponseBody>(localVarStatusCode,
                localVarHeaders,
                (StartScreenMonitorResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StartScreenMonitorResponseBody)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get screen monitor session details for one or more users. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of target user IDs</param>
        /// <returns>ScreenMonitoringUserDetailsEntityListing</returns>
        
        public ScreenMonitoringUserDetailsEntityListing PostScreenmonitorsSessionsUsersDetails (List<string> body)
        {
             ApiResponse<ScreenMonitoringUserDetailsEntityListing> localVarResponse = PostScreenmonitorsSessionsUsersDetailsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get screen monitor session details for one or more users. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of target user IDs</param>
        /// <returns>ApiResponse of ScreenMonitoringUserDetailsEntityListing</returns>
        
        public ApiResponse< ScreenMonitoringUserDetailsEntityListing > PostScreenmonitorsSessionsUsersDetailsWithHttpInfo (List<string> body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ScreenMonitoringApi->PostScreenmonitorsSessionsUsersDetails");

            var localVarPath = "/api/v2/screenmonitors/sessions/users/details";
            var localVarHttpMethod = "Post";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostScreenmonitorsSessionsUsersDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostScreenmonitorsSessionsUsersDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostScreenmonitorsSessionsUsersDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitoringUserDetailsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitoringUserDetailsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitoringUserDetailsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get screen monitor session details for one or more users. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of target user IDs</param>
        /// <returns>Task of ScreenMonitoringUserDetailsEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ScreenMonitoringUserDetailsEntityListing> PostScreenmonitorsSessionsUsersDetailsAsync (List<string> body)
        {
             ApiResponse<ScreenMonitoringUserDetailsEntityListing> localVarResponse = await PostScreenmonitorsSessionsUsersDetailsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get screen monitor session details for one or more users. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">List of target user IDs</param>
        /// <returns>Task of ApiResponse (ScreenMonitoringUserDetailsEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ScreenMonitoringUserDetailsEntityListing>> PostScreenmonitorsSessionsUsersDetailsAsyncWithHttpInfo (List<string> body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ScreenMonitoringApi->PostScreenmonitorsSessionsUsersDetails");
            

            var localVarPath = "/api/v2/screenmonitors/sessions/users/details";
            var localVarHttpMethod = "Post";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostScreenmonitorsSessionsUsersDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostScreenmonitorsSessionsUsersDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostScreenmonitorsSessionsUsersDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenMonitoringUserDetailsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScreenMonitoringUserDetailsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenMonitoringUserDetailsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Start an agent-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>StartScreenMonitorResponseBody</returns>
        
        public StartScreenMonitorResponseBody PostUserScreenmonitorsSessions (string userId)
        {
             ApiResponse<StartScreenMonitorResponseBody> localVarResponse = PostUserScreenmonitorsSessionsWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start an agent-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of StartScreenMonitorResponseBody</returns>
        
        public ApiResponse< StartScreenMonitorResponseBody > PostUserScreenmonitorsSessionsWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ScreenMonitoringApi->PostUserScreenmonitorsSessions");

            var localVarPath = "/api/v2/users/{userId}/screenmonitors/sessions";
            var localVarHttpMethod = "Post";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostUserScreenmonitorsSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostUserScreenmonitorsSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUserScreenmonitorsSessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StartScreenMonitorResponseBody>(localVarStatusCode,
                localVarHeaders,
                (StartScreenMonitorResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StartScreenMonitorResponseBody)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Start an agent-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of StartScreenMonitorResponseBody</returns>
        
        public async System.Threading.Tasks.Task<StartScreenMonitorResponseBody> PostUserScreenmonitorsSessionsAsync (string userId)
        {
             ApiResponse<StartScreenMonitorResponseBody> localVarResponse = await PostUserScreenmonitorsSessionsAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start an agent-level screen monitoring session. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (StartScreenMonitorResponseBody)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<StartScreenMonitorResponseBody>> PostUserScreenmonitorsSessionsAsyncWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ScreenMonitoringApi->PostUserScreenmonitorsSessions");
            

            var localVarPath = "/api/v2/users/{userId}/screenmonitors/sessions";
            var localVarHttpMethod = "Post";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostUserScreenmonitorsSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostUserScreenmonitorsSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUserScreenmonitorsSessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StartScreenMonitorResponseBody>(localVarStatusCode,
                localVarHeaders,
                (StartScreenMonitorResponseBody) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StartScreenMonitorResponseBody)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the Screen Monitor Settings for the Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Screen Monitor settings</param>
        /// <returns></returns>
        
        public void PutScreenmonitorsSettings (ScreenMonitorSettings body)
        {
             PutScreenmonitorsSettingsWithHttpInfo(body);
        }

        /// <summary>
        /// Update the Screen Monitor Settings for the Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Screen Monitor settings</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PutScreenmonitorsSettingsWithHttpInfo (ScreenMonitorSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ScreenMonitoringApi->PutScreenmonitorsSettings");

            var localVarPath = "/api/v2/screenmonitors/settings";
            var localVarHttpMethod = "Put";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutScreenmonitorsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PutScreenmonitorsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScreenmonitorsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the Screen Monitor Settings for the Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Screen Monitor settings</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PutScreenmonitorsSettingsAsync (ScreenMonitorSettings body)
        {
             await PutScreenmonitorsSettingsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update the Screen Monitor Settings for the Organization 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Screen Monitor settings</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutScreenmonitorsSettingsAsyncWithHttpInfo (ScreenMonitorSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ScreenMonitoringApi->PutScreenmonitorsSettings");
            

            var localVarPath = "/api/v2/screenmonitors/settings";
            var localVarHttpMethod = "Put";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, IFileParameter>();
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutScreenmonitorsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PutScreenmonitorsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScreenmonitorsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
