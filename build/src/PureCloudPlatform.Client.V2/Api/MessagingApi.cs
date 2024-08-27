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
    public interface IMessagingApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns></returns>
        [Obsolete]
        void DeleteMessagingSetting (string messageSettingId);

        /// <summary>
        /// Delete a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        [Obsolete]
        ApiResponse<Object> DeleteMessagingSettingWithHttpInfo (string messageSettingId);

        /// <summary>
        /// Delete the organization's default setting, a global default will be applied to integrations without settings
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        [Obsolete]
        void DeleteMessagingSettingsDefault ();

        /// <summary>
        /// Delete the organization's default setting, a global default will be applied to integrations without settings
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        [Obsolete]
        ApiResponse<Object> DeleteMessagingSettingsDefaultWithHttpInfo ();

        /// <summary>
        /// Delete a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns></returns>
        [Obsolete]
        void DeleteMessagingSupportedcontentSupportedContentId (string supportedContentId);

        /// <summary>
        /// Delete a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        [Obsolete]
        ApiResponse<Object> DeleteMessagingSupportedcontentSupportedContentIdWithHttpInfo (string supportedContentId);

        /// <summary>
        /// Get a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>MessagingSetting</returns>
        [Obsolete]
        MessagingSetting GetMessagingSetting (string messageSettingId);

        /// <summary>
        /// Get a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>ApiResponse of MessagingSetting</returns>
        [Obsolete]
        ApiResponse<MessagingSetting> GetMessagingSettingWithHttpInfo (string messageSettingId);

        /// <summary>
        /// Get a list of messaging settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>MessagingConfigListing</returns>
        [Obsolete]
        MessagingConfigListing GetMessagingSettings (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of messaging settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of MessagingConfigListing</returns>
        [Obsolete]
        ApiResponse<MessagingConfigListing> GetMessagingSettingsWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the organization's default settings that will be used as the default when creating an integration.
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MessagingSetting</returns>
        [Obsolete]
        MessagingSetting GetMessagingSettingsDefault ();

        /// <summary>
        /// Get the organization's default settings that will be used as the default when creating an integration.
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MessagingSetting</returns>
        [Obsolete]
        ApiResponse<MessagingSetting> GetMessagingSettingsDefaultWithHttpInfo ();

        /// <summary>
        /// Get a list of Supported Content profiles
        /// </summary>
        /// <remarks>
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SupportedContentListing</returns>
        [Obsolete]
        SupportedContentListing GetMessagingSupportedcontent (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of Supported Content profiles
        /// </summary>
        /// <remarks>
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SupportedContentListing</returns>
        [Obsolete]
        ApiResponse<SupportedContentListing> GetMessagingSupportedcontentWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>SupportedContent</returns>
        [Obsolete]
        SupportedContent GetMessagingSupportedcontentSupportedContentId (string supportedContentId);

        /// <summary>
        /// Get a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>ApiResponse of SupportedContent</returns>
        [Obsolete]
        ApiResponse<SupportedContent> GetMessagingSupportedcontentSupportedContentIdWithHttpInfo (string supportedContentId);

        /// <summary>
        /// Update a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <param name="body">MessagingSetting</param>
        /// <returns>MessagingSetting</returns>
        [Obsolete]
        MessagingSetting PatchMessagingSetting (string messageSettingId, MessagingSettingRequest body);

        /// <summary>
        /// Update a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <param name="body">MessagingSetting</param>
        /// <returns>ApiResponse of MessagingSetting</returns>
        [Obsolete]
        ApiResponse<MessagingSetting> PatchMessagingSettingWithHttpInfo (string messageSettingId, MessagingSettingRequest body);

        /// <summary>
        /// Update a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <param name="body">SupportedContent</param>
        /// <returns>SupportedContent</returns>
        [Obsolete]
        SupportedContent PatchMessagingSupportedcontentSupportedContentId (string supportedContentId, SupportedContent body);

        /// <summary>
        /// Update a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <param name="body">SupportedContent</param>
        /// <returns>ApiResponse of SupportedContent</returns>
        [Obsolete]
        ApiResponse<SupportedContent> PatchMessagingSupportedcontentSupportedContentIdWithHttpInfo (string supportedContentId, SupportedContent body);

        /// <summary>
        /// Create a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MessagingSetting</param>
        /// <returns>MessagingSetting</returns>
        [Obsolete]
        MessagingSetting PostMessagingSettings (MessagingSettingRequest body);

        /// <summary>
        /// Create a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MessagingSetting</param>
        /// <returns>ApiResponse of MessagingSetting</returns>
        [Obsolete]
        ApiResponse<MessagingSetting> PostMessagingSettingsWithHttpInfo (MessagingSettingRequest body);

        /// <summary>
        /// Create a Supported Content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SupportedContent</param>
        /// <returns>SupportedContent</returns>
        [Obsolete]
        SupportedContent PostMessagingSupportedcontent (SupportedContent body);

        /// <summary>
        /// Create a Supported Content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SupportedContent</param>
        /// <returns>ApiResponse of SupportedContent</returns>
        [Obsolete]
        ApiResponse<SupportedContent> PostMessagingSupportedcontentWithHttpInfo (SupportedContent body);

        /// <summary>
        /// Set the organization's default settings that may be applied to an integration when it is created.
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Messaging Setting ID</param>
        /// <returns>MessagingSetting</returns>
        [Obsolete]
        MessagingSetting PutMessagingSettingsDefault (MessagingSettingDefaultRequest body);

        /// <summary>
        /// Set the organization's default settings that may be applied to an integration when it is created.
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Messaging Setting ID</param>
        /// <returns>ApiResponse of MessagingSetting</returns>
        [Obsolete]
        ApiResponse<MessagingSetting> PutMessagingSettingsDefaultWithHttpInfo (MessagingSettingDefaultRequest body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>Task of void</returns>
        [Obsolete]
        System.Threading.Tasks.Task DeleteMessagingSettingAsync (string messageSettingId);

        /// <summary>
        /// Delete a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>Task of ApiResponse</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteMessagingSettingAsyncWithHttpInfo (string messageSettingId);

        /// <summary>
        /// Delete the organization's default setting, a global default will be applied to integrations without settings
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        [Obsolete]
        System.Threading.Tasks.Task DeleteMessagingSettingsDefaultAsync ();

        /// <summary>
        /// Delete the organization's default setting, a global default will be applied to integrations without settings
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteMessagingSettingsDefaultAsyncWithHttpInfo ();

        /// <summary>
        /// Delete a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>Task of void</returns>
        [Obsolete]
        System.Threading.Tasks.Task DeleteMessagingSupportedcontentSupportedContentIdAsync (string supportedContentId);

        /// <summary>
        /// Delete a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>Task of ApiResponse</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo (string supportedContentId);

        /// <summary>
        /// Get a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>Task of MessagingSetting</returns>
        [Obsolete]
        System.Threading.Tasks.Task<MessagingSetting> GetMessagingSettingAsync (string messageSettingId);

        /// <summary>
        /// Get a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>Task of ApiResponse (MessagingSetting)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<MessagingSetting>> GetMessagingSettingAsyncWithHttpInfo (string messageSettingId);

        /// <summary>
        /// Get a list of messaging settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of MessagingConfigListing</returns>
        [Obsolete]
        System.Threading.Tasks.Task<MessagingConfigListing> GetMessagingSettingsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of messaging settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (MessagingConfigListing)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<MessagingConfigListing>> GetMessagingSettingsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the organization's default settings that will be used as the default when creating an integration.
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MessagingSetting</returns>
        [Obsolete]
        System.Threading.Tasks.Task<MessagingSetting> GetMessagingSettingsDefaultAsync ();

        /// <summary>
        /// Get the organization's default settings that will be used as the default when creating an integration.
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MessagingSetting)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<MessagingSetting>> GetMessagingSettingsDefaultAsyncWithHttpInfo ();

        /// <summary>
        /// Get a list of Supported Content profiles
        /// </summary>
        /// <remarks>
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SupportedContentListing</returns>
        [Obsolete]
        System.Threading.Tasks.Task<SupportedContentListing> GetMessagingSupportedcontentAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of Supported Content profiles
        /// </summary>
        /// <remarks>
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SupportedContentListing)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<SupportedContentListing>> GetMessagingSupportedcontentAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>Task of SupportedContent</returns>
        [Obsolete]
        System.Threading.Tasks.Task<SupportedContent> GetMessagingSupportedcontentSupportedContentIdAsync (string supportedContentId);

        /// <summary>
        /// Get a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>Task of ApiResponse (SupportedContent)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<SupportedContent>> GetMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo (string supportedContentId);

        /// <summary>
        /// Update a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <param name="body">MessagingSetting</param>
        /// <returns>Task of MessagingSetting</returns>
        [Obsolete]
        System.Threading.Tasks.Task<MessagingSetting> PatchMessagingSettingAsync (string messageSettingId, MessagingSettingRequest body);

        /// <summary>
        /// Update a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <param name="body">MessagingSetting</param>
        /// <returns>Task of ApiResponse (MessagingSetting)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<MessagingSetting>> PatchMessagingSettingAsyncWithHttpInfo (string messageSettingId, MessagingSettingRequest body);

        /// <summary>
        /// Update a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <param name="body">SupportedContent</param>
        /// <returns>Task of SupportedContent</returns>
        [Obsolete]
        System.Threading.Tasks.Task<SupportedContent> PatchMessagingSupportedcontentSupportedContentIdAsync (string supportedContentId, SupportedContent body);

        /// <summary>
        /// Update a supported content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <param name="body">SupportedContent</param>
        /// <returns>Task of ApiResponse (SupportedContent)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<SupportedContent>> PatchMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo (string supportedContentId, SupportedContent body);

        /// <summary>
        /// Create a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MessagingSetting</param>
        /// <returns>Task of MessagingSetting</returns>
        [Obsolete]
        System.Threading.Tasks.Task<MessagingSetting> PostMessagingSettingsAsync (MessagingSettingRequest body);

        /// <summary>
        /// Create a messaging setting
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MessagingSetting</param>
        /// <returns>Task of ApiResponse (MessagingSetting)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<MessagingSetting>> PostMessagingSettingsAsyncWithHttpInfo (MessagingSettingRequest body);

        /// <summary>
        /// Create a Supported Content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SupportedContent</param>
        /// <returns>Task of SupportedContent</returns>
        [Obsolete]
        System.Threading.Tasks.Task<SupportedContent> PostMessagingSupportedcontentAsync (SupportedContent body);

        /// <summary>
        /// Create a Supported Content profile
        /// </summary>
        /// <remarks>
        /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SupportedContent</param>
        /// <returns>Task of ApiResponse (SupportedContent)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<SupportedContent>> PostMessagingSupportedcontentAsyncWithHttpInfo (SupportedContent body);

        /// <summary>
        /// Set the organization's default settings that may be applied to an integration when it is created.
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Messaging Setting ID</param>
        /// <returns>Task of MessagingSetting</returns>
        [Obsolete]
        System.Threading.Tasks.Task<MessagingSetting> PutMessagingSettingsDefaultAsync (MessagingSettingDefaultRequest body);

        /// <summary>
        /// Set the organization's default settings that may be applied to an integration when it is created.
        /// </summary>
        /// <remarks>
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Messaging Setting ID</param>
        /// <returns>Task of ApiResponse (MessagingSetting)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<MessagingSetting>> PutMessagingSettingsDefaultAsyncWithHttpInfo (MessagingSettingDefaultRequest body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MessagingApi : IMessagingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagingApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MessagingApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns></returns>
        [Obsolete]
        public void DeleteMessagingSetting (string messageSettingId)
        {
             DeleteMessagingSettingWithHttpInfo(messageSettingId);
        }

        /// <summary>
        /// Delete a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        [Obsolete]
        public ApiResponse<Object> DeleteMessagingSettingWithHttpInfo (string messageSettingId)
        { 
            // verify the required parameter 'messageSettingId' is set
            if (messageSettingId == null)
                throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->DeleteMessagingSetting");

            var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (messageSettingId != null) localVarPathParams.Add("messageSettingId", this.Configuration.ApiClient.ParameterToString(messageSettingId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>Task of void</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task DeleteMessagingSettingAsync (string messageSettingId)
        {
             await DeleteMessagingSettingAsyncWithHttpInfo(messageSettingId);

        }

        /// <summary>
        /// Delete a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>Task of ApiResponse</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteMessagingSettingAsyncWithHttpInfo (string messageSettingId)
        { 
            // verify the required parameter 'messageSettingId' is set
            if (messageSettingId == null)
                throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->DeleteMessagingSetting");
            

            var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (messageSettingId != null) localVarPathParams.Add("messageSettingId", this.Configuration.ApiClient.ParameterToString(messageSettingId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete the organization's default setting, a global default will be applied to integrations without settings 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        [Obsolete]
        public void DeleteMessagingSettingsDefault ()
        {
             DeleteMessagingSettingsDefaultWithHttpInfo();
        }

        /// <summary>
        /// Delete the organization's default setting, a global default will be applied to integrations without settings 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        [Obsolete]
        public ApiResponse<Object> DeleteMessagingSettingsDefaultWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/messaging/settings/default";
            var localVarPathParams = new Dictionary<String, String>();
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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete the organization's default setting, a global default will be applied to integrations without settings 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task DeleteMessagingSettingsDefaultAsync ()
        {
             await DeleteMessagingSettingsDefaultAsyncWithHttpInfo();

        }

        /// <summary>
        /// Delete the organization's default setting, a global default will be applied to integrations without settings 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteMessagingSettingsDefaultAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/messaging/settings/default";
            var localVarPathParams = new Dictionary<String, String>();
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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a supported content profile 
        /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns></returns>
        [Obsolete]
        public void DeleteMessagingSupportedcontentSupportedContentId (string supportedContentId)
        {
             DeleteMessagingSupportedcontentSupportedContentIdWithHttpInfo(supportedContentId);
        }

        /// <summary>
        /// Delete a supported content profile 
        /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        [Obsolete]
        public ApiResponse<Object> DeleteMessagingSupportedcontentSupportedContentIdWithHttpInfo (string supportedContentId)
        { 
            // verify the required parameter 'supportedContentId' is set
            if (supportedContentId == null)
                throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->DeleteMessagingSupportedcontentSupportedContentId");

            var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (supportedContentId != null) localVarPathParams.Add("supportedContentId", this.Configuration.ApiClient.ParameterToString(supportedContentId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a supported content profile 
        /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>Task of void</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task DeleteMessagingSupportedcontentSupportedContentIdAsync (string supportedContentId)
        {
             await DeleteMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(supportedContentId);

        }

        /// <summary>
        /// Delete a supported content profile 
        /// Deprecated - use DELETE /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>Task of ApiResponse</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo (string supportedContentId)
        { 
            // verify the required parameter 'supportedContentId' is set
            if (supportedContentId == null)
                throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->DeleteMessagingSupportedcontentSupportedContentId");
            

            var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (supportedContentId != null) localVarPathParams.Add("supportedContentId", this.Configuration.ApiClient.ParameterToString(supportedContentId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>MessagingSetting</returns>
        [Obsolete]
        public MessagingSetting GetMessagingSetting (string messageSettingId)
        {
             ApiResponse<MessagingSetting> localVarResponse = GetMessagingSettingWithHttpInfo(messageSettingId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>ApiResponse of MessagingSetting</returns>
        [Obsolete]
        public ApiResponse< MessagingSetting > GetMessagingSettingWithHttpInfo (string messageSettingId)
        { 
            // verify the required parameter 'messageSettingId' is set
            if (messageSettingId == null)
                throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->GetMessagingSetting");

            var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (messageSettingId != null) localVarPathParams.Add("messageSettingId", this.Configuration.ApiClient.ParameterToString(messageSettingId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingSetting>(localVarStatusCode,
                localVarHeaders,
                (MessagingSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>Task of MessagingSetting</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<MessagingSetting> GetMessagingSettingAsync (string messageSettingId)
        {
             ApiResponse<MessagingSetting> localVarResponse = await GetMessagingSettingAsyncWithHttpInfo(messageSettingId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <returns>Task of ApiResponse (MessagingSetting)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<MessagingSetting>> GetMessagingSettingAsyncWithHttpInfo (string messageSettingId)
        { 
            // verify the required parameter 'messageSettingId' is set
            if (messageSettingId == null)
                throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->GetMessagingSetting");
            

            var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (messageSettingId != null) localVarPathParams.Add("messageSettingId", this.Configuration.ApiClient.ParameterToString(messageSettingId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingSetting>(localVarStatusCode,
                localVarHeaders,
                (MessagingSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of messaging settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>MessagingConfigListing</returns>
        [Obsolete]
        public MessagingConfigListing GetMessagingSettings (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<MessagingConfigListing> localVarResponse = GetMessagingSettingsWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of messaging settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of MessagingConfigListing</returns>
        [Obsolete]
        public ApiResponse< MessagingConfigListing > GetMessagingSettingsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/messaging/settings";
            var localVarPathParams = new Dictionary<String, String>();
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingConfigListing>(localVarStatusCode,
                localVarHeaders,
                (MessagingConfigListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingConfigListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of messaging settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of MessagingConfigListing</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<MessagingConfigListing> GetMessagingSettingsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<MessagingConfigListing> localVarResponse = await GetMessagingSettingsAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of messaging settings 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (MessagingConfigListing)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<MessagingConfigListing>> GetMessagingSettingsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/messaging/settings";
            var localVarPathParams = new Dictionary<String, String>();
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingConfigListing>(localVarStatusCode,
                localVarHeaders,
                (MessagingConfigListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingConfigListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the organization's default settings that will be used as the default when creating an integration. 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MessagingSetting</returns>
        [Obsolete]
        public MessagingSetting GetMessagingSettingsDefault ()
        {
             ApiResponse<MessagingSetting> localVarResponse = GetMessagingSettingsDefaultWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the organization's default settings that will be used as the default when creating an integration. 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MessagingSetting</returns>
        [Obsolete]
        public ApiResponse< MessagingSetting > GetMessagingSettingsDefaultWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/messaging/settings/default";
            var localVarPathParams = new Dictionary<String, String>();
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingSetting>(localVarStatusCode,
                localVarHeaders,
                (MessagingSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the organization's default settings that will be used as the default when creating an integration. 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MessagingSetting</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<MessagingSetting> GetMessagingSettingsDefaultAsync ()
        {
             ApiResponse<MessagingSetting> localVarResponse = await GetMessagingSettingsDefaultAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the organization's default settings that will be used as the default when creating an integration. 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MessagingSetting)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<MessagingSetting>> GetMessagingSettingsDefaultAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/messaging/settings/default";
            var localVarPathParams = new Dictionary<String, String>();
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingSetting>(localVarStatusCode,
                localVarHeaders,
                (MessagingSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Supported Content profiles 
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SupportedContentListing</returns>
        [Obsolete]
        public SupportedContentListing GetMessagingSupportedcontent (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SupportedContentListing> localVarResponse = GetMessagingSupportedcontentWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Supported Content profiles 
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SupportedContentListing</returns>
        [Obsolete]
        public ApiResponse< SupportedContentListing > GetMessagingSupportedcontentWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/messaging/supportedcontent";
            var localVarPathParams = new Dictionary<String, String>();
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSupportedcontent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSupportedcontent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SupportedContentListing>(localVarStatusCode,
                localVarHeaders,
                (SupportedContentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Supported Content profiles 
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SupportedContentListing</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<SupportedContentListing> GetMessagingSupportedcontentAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SupportedContentListing> localVarResponse = await GetMessagingSupportedcontentAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Supported Content profiles 
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SupportedContentListing)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<SupportedContentListing>> GetMessagingSupportedcontentAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        { 

            var localVarPath = "/api/v2/messaging/supportedcontent";
            var localVarPathParams = new Dictionary<String, String>();
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSupportedcontent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSupportedcontent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SupportedContentListing>(localVarStatusCode,
                localVarHeaders,
                (SupportedContentListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContentListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a supported content profile 
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>SupportedContent</returns>
        [Obsolete]
        public SupportedContent GetMessagingSupportedcontentSupportedContentId (string supportedContentId)
        {
             ApiResponse<SupportedContent> localVarResponse = GetMessagingSupportedcontentSupportedContentIdWithHttpInfo(supportedContentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a supported content profile 
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>ApiResponse of SupportedContent</returns>
        [Obsolete]
        public ApiResponse< SupportedContent > GetMessagingSupportedcontentSupportedContentIdWithHttpInfo (string supportedContentId)
        { 
            // verify the required parameter 'supportedContentId' is set
            if (supportedContentId == null)
                throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->GetMessagingSupportedcontentSupportedContentId");

            var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (supportedContentId != null) localVarPathParams.Add("supportedContentId", this.Configuration.ApiClient.ParameterToString(supportedContentId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SupportedContent>(localVarStatusCode,
                localVarHeaders,
                (SupportedContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a supported content profile 
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>Task of SupportedContent</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<SupportedContent> GetMessagingSupportedcontentSupportedContentIdAsync (string supportedContentId)
        {
             ApiResponse<SupportedContent> localVarResponse = await GetMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(supportedContentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a supported content profile 
        /// Deprecated - use GET /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <returns>Task of ApiResponse (SupportedContent)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<SupportedContent>> GetMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo (string supportedContentId)
        { 
            // verify the required parameter 'supportedContentId' is set
            if (supportedContentId == null)
                throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->GetMessagingSupportedcontentSupportedContentId");
            

            var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (supportedContentId != null) localVarPathParams.Add("supportedContentId", this.Configuration.ApiClient.ParameterToString(supportedContentId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SupportedContent>(localVarStatusCode,
                localVarHeaders,
                (SupportedContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <param name="body">MessagingSetting</param>
        /// <returns>MessagingSetting</returns>
        [Obsolete]
        public MessagingSetting PatchMessagingSetting (string messageSettingId, MessagingSettingRequest body)
        {
             ApiResponse<MessagingSetting> localVarResponse = PatchMessagingSettingWithHttpInfo(messageSettingId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <param name="body">MessagingSetting</param>
        /// <returns>ApiResponse of MessagingSetting</returns>
        [Obsolete]
        public ApiResponse< MessagingSetting > PatchMessagingSettingWithHttpInfo (string messageSettingId, MessagingSettingRequest body)
        { 
            // verify the required parameter 'messageSettingId' is set
            if (messageSettingId == null)
                throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->PatchMessagingSetting");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PatchMessagingSetting");

            var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (messageSettingId != null) localVarPathParams.Add("messageSettingId", this.Configuration.ApiClient.ParameterToString(messageSettingId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingSetting>(localVarStatusCode,
                localVarHeaders,
                (MessagingSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <param name="body">MessagingSetting</param>
        /// <returns>Task of MessagingSetting</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<MessagingSetting> PatchMessagingSettingAsync (string messageSettingId, MessagingSettingRequest body)
        {
             ApiResponse<MessagingSetting> localVarResponse = await PatchMessagingSettingAsyncWithHttpInfo(messageSettingId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageSettingId">Message Settings ID</param>
        /// <param name="body">MessagingSetting</param>
        /// <returns>Task of ApiResponse (MessagingSetting)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<MessagingSetting>> PatchMessagingSettingAsyncWithHttpInfo (string messageSettingId, MessagingSettingRequest body)
        { 
            // verify the required parameter 'messageSettingId' is set
            if (messageSettingId == null)
                throw new ApiException(400, "Missing required parameter 'messageSettingId' when calling MessagingApi->PatchMessagingSetting");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PatchMessagingSetting");
            

            var localVarPath = "/api/v2/messaging/settings/{messageSettingId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (messageSettingId != null) localVarPathParams.Add("messageSettingId", this.Configuration.ApiClient.ParameterToString(messageSettingId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchMessagingSetting: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchMessagingSetting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingSetting>(localVarStatusCode,
                localVarHeaders,
                (MessagingSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a supported content profile 
        /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <param name="body">SupportedContent</param>
        /// <returns>SupportedContent</returns>
        [Obsolete]
        public SupportedContent PatchMessagingSupportedcontentSupportedContentId (string supportedContentId, SupportedContent body)
        {
             ApiResponse<SupportedContent> localVarResponse = PatchMessagingSupportedcontentSupportedContentIdWithHttpInfo(supportedContentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a supported content profile 
        /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <param name="body">SupportedContent</param>
        /// <returns>ApiResponse of SupportedContent</returns>
        [Obsolete]
        public ApiResponse< SupportedContent > PatchMessagingSupportedcontentSupportedContentIdWithHttpInfo (string supportedContentId, SupportedContent body)
        { 
            // verify the required parameter 'supportedContentId' is set
            if (supportedContentId == null)
                throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->PatchMessagingSupportedcontentSupportedContentId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PatchMessagingSupportedcontentSupportedContentId");

            var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (supportedContentId != null) localVarPathParams.Add("supportedContentId", this.Configuration.ApiClient.ParameterToString(supportedContentId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SupportedContent>(localVarStatusCode,
                localVarHeaders,
                (SupportedContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a supported content profile 
        /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <param name="body">SupportedContent</param>
        /// <returns>Task of SupportedContent</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<SupportedContent> PatchMessagingSupportedcontentSupportedContentIdAsync (string supportedContentId, SupportedContent body)
        {
             ApiResponse<SupportedContent> localVarResponse = await PatchMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo(supportedContentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a supported content profile 
        /// Deprecated - use PATCH /api/v2/conversations/messaging/supportedcontent/{supportedContentId} as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="supportedContentId">Supported Content ID</param>
        /// <param name="body">SupportedContent</param>
        /// <returns>Task of ApiResponse (SupportedContent)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<SupportedContent>> PatchMessagingSupportedcontentSupportedContentIdAsyncWithHttpInfo (string supportedContentId, SupportedContent body)
        { 
            // verify the required parameter 'supportedContentId' is set
            if (supportedContentId == null)
                throw new ApiException(400, "Missing required parameter 'supportedContentId' when calling MessagingApi->PatchMessagingSupportedcontentSupportedContentId");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PatchMessagingSupportedcontentSupportedContentId");
            

            var localVarPath = "/api/v2/messaging/supportedcontent/{supportedContentId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (supportedContentId != null) localVarPathParams.Add("supportedContentId", this.Configuration.ApiClient.ParameterToString(supportedContentId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchMessagingSupportedcontentSupportedContentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchMessagingSupportedcontentSupportedContentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SupportedContent>(localVarStatusCode,
                localVarHeaders,
                (SupportedContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MessagingSetting</param>
        /// <returns>MessagingSetting</returns>
        [Obsolete]
        public MessagingSetting PostMessagingSettings (MessagingSettingRequest body)
        {
             ApiResponse<MessagingSetting> localVarResponse = PostMessagingSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MessagingSetting</param>
        /// <returns>ApiResponse of MessagingSetting</returns>
        [Obsolete]
        public ApiResponse< MessagingSetting > PostMessagingSettingsWithHttpInfo (MessagingSettingRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PostMessagingSettings");

            var localVarPath = "/api/v2/messaging/settings";
            var localVarPathParams = new Dictionary<String, String>();
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostMessagingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostMessagingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingSetting>(localVarStatusCode,
                localVarHeaders,
                (MessagingSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MessagingSetting</param>
        /// <returns>Task of MessagingSetting</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<MessagingSetting> PostMessagingSettingsAsync (MessagingSettingRequest body)
        {
             ApiResponse<MessagingSetting> localVarResponse = await PostMessagingSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a messaging setting 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MessagingSetting</param>
        /// <returns>Task of ApiResponse (MessagingSetting)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<MessagingSetting>> PostMessagingSettingsAsyncWithHttpInfo (MessagingSettingRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PostMessagingSettings");
            

            var localVarPath = "/api/v2/messaging/settings";
            var localVarPathParams = new Dictionary<String, String>();
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostMessagingSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostMessagingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingSetting>(localVarStatusCode,
                localVarHeaders,
                (MessagingSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a Supported Content profile 
        /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SupportedContent</param>
        /// <returns>SupportedContent</returns>
        [Obsolete]
        public SupportedContent PostMessagingSupportedcontent (SupportedContent body)
        {
             ApiResponse<SupportedContent> localVarResponse = PostMessagingSupportedcontentWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Supported Content profile 
        /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SupportedContent</param>
        /// <returns>ApiResponse of SupportedContent</returns>
        [Obsolete]
        public ApiResponse< SupportedContent > PostMessagingSupportedcontentWithHttpInfo (SupportedContent body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PostMessagingSupportedcontent");

            var localVarPath = "/api/v2/messaging/supportedcontent";
            var localVarPathParams = new Dictionary<String, String>();
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostMessagingSupportedcontent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostMessagingSupportedcontent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SupportedContent>(localVarStatusCode,
                localVarHeaders,
                (SupportedContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a Supported Content profile 
        /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SupportedContent</param>
        /// <returns>Task of SupportedContent</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<SupportedContent> PostMessagingSupportedcontentAsync (SupportedContent body)
        {
             ApiResponse<SupportedContent> localVarResponse = await PostMessagingSupportedcontentAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Supported Content profile 
        /// Deprecated - use POST /api/v2/conversations/messaging/supportedcontent as replacement
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SupportedContent</param>
        /// <returns>Task of ApiResponse (SupportedContent)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<SupportedContent>> PostMessagingSupportedcontentAsyncWithHttpInfo (SupportedContent body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PostMessagingSupportedcontent");
            

            var localVarPath = "/api/v2/messaging/supportedcontent";
            var localVarPathParams = new Dictionary<String, String>();
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostMessagingSupportedcontent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostMessagingSupportedcontent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SupportedContent>(localVarStatusCode,
                localVarHeaders,
                (SupportedContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupportedContent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Set the organization's default settings that may be applied to an integration when it is created. 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Messaging Setting ID</param>
        /// <returns>MessagingSetting</returns>
        [Obsolete]
        public MessagingSetting PutMessagingSettingsDefault (MessagingSettingDefaultRequest body)
        {
             ApiResponse<MessagingSetting> localVarResponse = PutMessagingSettingsDefaultWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set the organization's default settings that may be applied to an integration when it is created. 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Messaging Setting ID</param>
        /// <returns>ApiResponse of MessagingSetting</returns>
        [Obsolete]
        public ApiResponse< MessagingSetting > PutMessagingSettingsDefaultWithHttpInfo (MessagingSettingDefaultRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PutMessagingSettingsDefault");

            var localVarPath = "/api/v2/messaging/settings/default";
            var localVarPathParams = new Dictionary<String, String>();
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
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingSetting>(localVarStatusCode,
                localVarHeaders,
                (MessagingSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Set the organization's default settings that may be applied to an integration when it is created. 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Messaging Setting ID</param>
        /// <returns>Task of MessagingSetting</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<MessagingSetting> PutMessagingSettingsDefaultAsync (MessagingSettingDefaultRequest body)
        {
             ApiResponse<MessagingSetting> localVarResponse = await PutMessagingSettingsDefaultAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set the organization's default settings that may be applied to an integration when it is created. 
        /// When an integration is created a settings ID may be assigned to it. If the settings ID is not supplied, the default settings will be applied to it.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Messaging Setting ID</param>
        /// <returns>Task of ApiResponse (MessagingSetting)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<MessagingSetting>> PutMessagingSettingsDefaultAsyncWithHttpInfo (MessagingSettingDefaultRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagingApi->PutMessagingSettingsDefault");
            

            var localVarPath = "/api/v2/messaging/settings/default";
            var localVarPathParams = new Dictionary<String, String>();
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
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutMessagingSettingsDefault: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutMessagingSettingsDefault: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessagingSetting>(localVarStatusCode,
                localVarHeaders,
                (MessagingSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessagingSetting)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
