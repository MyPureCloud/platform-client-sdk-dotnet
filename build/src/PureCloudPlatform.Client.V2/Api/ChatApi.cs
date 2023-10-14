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
    public interface IChatApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a message in a room
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <returns></returns>
        
        void DeleteChatsRoomMessage (string roomJid, string messageId);

        /// <summary>
        /// Delete a message in a room
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteChatsRoomMessageWithHttpInfo (string roomJid, string messageId);

        /// <summary>
        /// Remove a user from a room.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns></returns>
        
        void DeleteChatsRoomParticipant (string roomJid, string userId);

        /// <summary>
        /// Remove a user from a room.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteChatsRoomParticipantWithHttpInfo (string roomJid, string userId);

        /// <summary>
        /// Remove a pinned message from a room
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomPinnedmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pinnedMessageId">pinnedMessageId</param>
        /// <returns></returns>
        
        void DeleteChatsRoomPinnedmessage (string roomJid, string pinnedMessageId);

        /// <summary>
        /// Remove a pinned message from a room
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomPinnedmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pinnedMessageId">pinnedMessageId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteChatsRoomPinnedmessageWithHttpInfo (string roomJid, string pinnedMessageId);

        /// <summary>
        /// Delete a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <returns></returns>
        
        void DeleteChatsUserMessage (string userId, string messageId);

        /// <summary>
        /// Delete a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteChatsUserMessageWithHttpInfo (string userId, string messageId);

        /// <summary>
        /// Get Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChatSettings</returns>
        [Obsolete]
        ChatSettings GetChatSettings ();

        /// <summary>
        /// Get Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChatSettings</returns>
        [Obsolete]
        ApiResponse<ChatSettings> GetChatSettingsWithHttpInfo ();

        /// <summary>
        /// Get a message
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>ChatMessageResponse</returns>
        
        ChatMessageResponse GetChatsMessage (string messageId);

        /// <summary>
        /// Get a message
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of ChatMessageResponse</returns>
        
        ApiResponse<ChatMessageResponse> GetChatsMessageWithHttpInfo (string messageId);

        /// <summary>
        /// Get a room
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <returns>Room</returns>
        
        Room GetChatsRoom (string roomJid);

        /// <summary>
        /// Get a room
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <returns>ApiResponse of Room</returns>
        
        ApiResponse<Room> GetChatsRoomWithHttpInfo (string roomJid);

        /// <summary>
        /// Get messages by id(s) from a room
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>ChatMessageEntityListing</returns>
        
        ChatMessageEntityListing GetChatsRoomMessage (string roomJid, string messageIds);

        /// <summary>
        /// Get messages by id(s) from a room
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>ApiResponse of ChatMessageEntityListing</returns>
        
        ApiResponse<ChatMessageEntityListing> GetChatsRoomMessageWithHttpInfo (string roomJid, string messageIds);

        /// <summary>
        /// Get a room's message history
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ChatMessageEntityListing</returns>
        
        ChatMessageEntityListing GetChatsRoomMessages (string roomJid, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Get a room's message history
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ApiResponse of ChatMessageEntityListing</returns>
        
        ApiResponse<ChatMessageEntityListing> GetChatsRoomMessagesWithHttpInfo (string roomJid, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Get Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChatSettings</returns>
        
        ChatSettings GetChatsSettings ();

        /// <summary>
        /// Get Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChatSettings</returns>
        
        ApiResponse<ChatSettings> GetChatsSettingsWithHttpInfo ();

        /// <summary>
        /// Get history by thread
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsThreadMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">threadId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ChatMessageEntityListing</returns>
        
        ChatMessageEntityListing GetChatsThreadMessages (string threadId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Get history by thread
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsThreadMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">threadId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ApiResponse of ChatMessageEntityListing</returns>
        
        ApiResponse<ChatMessageEntityListing> GetChatsThreadMessagesWithHttpInfo (string threadId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Get messages by id(s) from a 1on1
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>ChatMessageEntityListing</returns>
        
        ChatMessageEntityListing GetChatsUserMessage (string userId, string messageIds);

        /// <summary>
        /// Get messages by id(s) from a 1on1
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>ApiResponse of ChatMessageEntityListing</returns>
        
        ApiResponse<ChatMessageEntityListing> GetChatsUserMessageWithHttpInfo (string userId, string messageIds);

        /// <summary>
        /// Get 1on1 History between a user
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ChatMessageResponse</returns>
        
        ChatMessageResponse GetChatsUserMessages (string userId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Get 1on1 History between a user
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ApiResponse of ChatMessageResponse</returns>
        
        ApiResponse<ChatMessageResponse> GetChatsUserMessagesWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Patch Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ChatSettings</returns>
        [Obsolete]
        ChatSettings PatchChatSettings (ChatSettings body);

        /// <summary>
        /// Patch Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ApiResponse of ChatSettings</returns>
        [Obsolete]
        ApiResponse<ChatSettings> PatchChatSettingsWithHttpInfo (ChatSettings body);

        /// <summary>
        /// Set properties for a room
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Room properties</param>
        /// <returns></returns>
        
        void PatchChatsRoom (string roomJid, RoomUpdateRequest body);

        /// <summary>
        /// Set properties for a room
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Room properties</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PatchChatsRoomWithHttpInfo (string roomJid, RoomUpdateRequest body);

        /// <summary>
        /// Edit a message in a room
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">messageBody</param>
        /// <returns>ChatSendMessageResponse</returns>
        
        ChatSendMessageResponse PatchChatsRoomMessage (string roomJid, string messageId, SendMessageBody body);

        /// <summary>
        /// Edit a message in a room
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">messageBody</param>
        /// <returns>ApiResponse of ChatSendMessageResponse</returns>
        
        ApiResponse<ChatSendMessageResponse> PatchChatsRoomMessageWithHttpInfo (string roomJid, string messageId, SendMessageBody body);

        /// <summary>
        /// Patch Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ChatSettings</returns>
        
        ChatSettings PatchChatsSettings (ChatSettings body);

        /// <summary>
        /// Patch Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ApiResponse of ChatSettings</returns>
        
        ApiResponse<ChatSettings> PatchChatsSettingsWithHttpInfo (ChatSettings body);

        /// <summary>
        /// Edit a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">message body</param>
        /// <returns>ChatSendMessageResponse</returns>
        
        ChatSendMessageResponse PatchChatsUserMessage (string userId, string messageId, SendMessageBody body);

        /// <summary>
        /// Edit a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">message body</param>
        /// <returns>ApiResponse of ChatSendMessageResponse</returns>
        
        ApiResponse<ChatSendMessageResponse> PatchChatsUserMessageWithHttpInfo (string userId, string messageId, SendMessageBody body);

        /// <summary>
        /// Send a message to a room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="body">messageBody</param>
        /// <returns>ChatSendMessageResponse</returns>
        
        ChatSendMessageResponse PostChatsRoomMessages (string roomJid, SendMessageBody body);

        /// <summary>
        /// Send a message to a room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="body">messageBody</param>
        /// <returns>ApiResponse of ChatSendMessageResponse</returns>
        
        ApiResponse<ChatSendMessageResponse> PostChatsRoomMessagesWithHttpInfo (string roomJid, SendMessageBody body);

        /// <summary>
        /// Join a room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns></returns>
        
        void PostChatsRoomParticipant (string roomJid, string userId);

        /// <summary>
        /// Join a room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostChatsRoomParticipantWithHttpInfo (string roomJid, string userId);

        /// <summary>
        /// Add pinned messages for a room, up to a maximum of 5 pinned messages
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomPinnedmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Pinned Message Ids</param>
        /// <returns></returns>
        
        void PostChatsRoomPinnedmessages (string roomJid, PinnedMessageRequest body);

        /// <summary>
        /// Add pinned messages for a room, up to a maximum of 5 pinned messages
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomPinnedmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Pinned Message Ids</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> PostChatsRoomPinnedmessagesWithHttpInfo (string roomJid, PinnedMessageRequest body);

        /// <summary>
        /// Create an adhoc room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRooms is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Room properties</param>
        /// <returns>CreateRoomResponse</returns>
        
        CreateRoomResponse PostChatsRooms (CreateRoomRequest body);

        /// <summary>
        /// Create an adhoc room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRooms is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Room properties</param>
        /// <returns>ApiResponse of CreateRoomResponse</returns>
        
        ApiResponse<CreateRoomResponse> PostChatsRoomsWithHttpInfo (CreateRoomRequest body);

        /// <summary>
        /// Send a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="body">message body</param>
        /// <returns>ChatSendMessageResponse</returns>
        
        ChatSendMessageResponse PostChatsUserMessages (string userId, SendMessageBody body);

        /// <summary>
        /// Send a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="body">message body</param>
        /// <returns>ApiResponse of ChatSendMessageResponse</returns>
        
        ApiResponse<ChatSendMessageResponse> PostChatsUserMessagesWithHttpInfo (string userId, SendMessageBody body);

        /// <summary>
        /// Update Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ChatSettings</returns>
        [Obsolete]
        ChatSettings PutChatSettings (ChatSettings body);

        /// <summary>
        /// Update Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ApiResponse of ChatSettings</returns>
        [Obsolete]
        ApiResponse<ChatSettings> PutChatSettingsWithHttpInfo (ChatSettings body);

        /// <summary>
        /// Update Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ChatSettings</returns>
        
        ChatSettings PutChatsSettings (ChatSettings body);

        /// <summary>
        /// Update Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ApiResponse of ChatSettings</returns>
        
        ApiResponse<ChatSettings> PutChatsSettingsWithHttpInfo (ChatSettings body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a message in a room
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteChatsRoomMessageAsync (string roomJid, string messageId);

        /// <summary>
        /// Delete a message in a room
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteChatsRoomMessageAsyncWithHttpInfo (string roomJid, string messageId);

        /// <summary>
        /// Remove a user from a room.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteChatsRoomParticipantAsync (string roomJid, string userId);

        /// <summary>
        /// Remove a user from a room.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteChatsRoomParticipantAsyncWithHttpInfo (string roomJid, string userId);

        /// <summary>
        /// Remove a pinned message from a room
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomPinnedmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pinnedMessageId">pinnedMessageId</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteChatsRoomPinnedmessageAsync (string roomJid, string pinnedMessageId);

        /// <summary>
        /// Remove a pinned message from a room
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsRoomPinnedmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pinnedMessageId">pinnedMessageId</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteChatsRoomPinnedmessageAsyncWithHttpInfo (string roomJid, string pinnedMessageId);

        /// <summary>
        /// Delete a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteChatsUserMessageAsync (string userId, string messageId);

        /// <summary>
        /// Delete a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteChatsUserMessageAsyncWithHttpInfo (string userId, string messageId);

        /// <summary>
        /// Get Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChatSettings</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ChatSettings> GetChatSettingsAsync ();

        /// <summary>
        /// Get Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<ChatSettings>> GetChatSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Get a message
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ChatMessageResponse</returns>
        
        System.Threading.Tasks.Task<ChatMessageResponse> GetChatsMessageAsync (string messageId);

        /// <summary>
        /// Get a message
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse (ChatMessageResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatMessageResponse>> GetChatsMessageAsyncWithHttpInfo (string messageId);

        /// <summary>
        /// Get a room
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <returns>Task of Room</returns>
        
        System.Threading.Tasks.Task<Room> GetChatsRoomAsync (string roomJid);

        /// <summary>
        /// Get a room
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <returns>Task of ApiResponse (Room)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Room>> GetChatsRoomAsyncWithHttpInfo (string roomJid);

        /// <summary>
        /// Get messages by id(s) from a room
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>Task of ChatMessageEntityListing</returns>
        
        System.Threading.Tasks.Task<ChatMessageEntityListing> GetChatsRoomMessageAsync (string roomJid, string messageIds);

        /// <summary>
        /// Get messages by id(s) from a room
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatMessageEntityListing>> GetChatsRoomMessageAsyncWithHttpInfo (string roomJid, string messageIds);

        /// <summary>
        /// Get a room's message history
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ChatMessageEntityListing</returns>
        
        System.Threading.Tasks.Task<ChatMessageEntityListing> GetChatsRoomMessagesAsync (string roomJid, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Get a room's message history
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatMessageEntityListing>> GetChatsRoomMessagesAsyncWithHttpInfo (string roomJid, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Get Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChatSettings</returns>
        
        System.Threading.Tasks.Task<ChatSettings> GetChatsSettingsAsync ();

        /// <summary>
        /// Get Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatSettings>> GetChatsSettingsAsyncWithHttpInfo ();

        /// <summary>
        /// Get history by thread
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsThreadMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">threadId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ChatMessageEntityListing</returns>
        
        System.Threading.Tasks.Task<ChatMessageEntityListing> GetChatsThreadMessagesAsync (string threadId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Get history by thread
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsThreadMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">threadId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatMessageEntityListing>> GetChatsThreadMessagesAsyncWithHttpInfo (string threadId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Get messages by id(s) from a 1on1
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>Task of ChatMessageEntityListing</returns>
        
        System.Threading.Tasks.Task<ChatMessageEntityListing> GetChatsUserMessageAsync (string userId, string messageIds);

        /// <summary>
        /// Get messages by id(s) from a 1on1
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatMessageEntityListing>> GetChatsUserMessageAsyncWithHttpInfo (string userId, string messageIds);

        /// <summary>
        /// Get 1on1 History between a user
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ChatMessageResponse</returns>
        
        System.Threading.Tasks.Task<ChatMessageResponse> GetChatsUserMessagesAsync (string userId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Get 1on1 History between a user
        /// </summary>
        /// <remarks>
        /// 
        /// GetChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ApiResponse (ChatMessageResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatMessageResponse>> GetChatsUserMessagesAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null);

        /// <summary>
        /// Patch Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ChatSettings</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ChatSettings> PatchChatSettingsAsync (ChatSettings body);

        /// <summary>
        /// Patch Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<ChatSettings>> PatchChatSettingsAsyncWithHttpInfo (ChatSettings body);

        /// <summary>
        /// Set properties for a room
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Room properties</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PatchChatsRoomAsync (string roomJid, RoomUpdateRequest body);

        /// <summary>
        /// Set properties for a room
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Room properties</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatsRoomAsyncWithHttpInfo (string roomJid, RoomUpdateRequest body);

        /// <summary>
        /// Edit a message in a room
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">messageBody</param>
        /// <returns>Task of ChatSendMessageResponse</returns>
        
        System.Threading.Tasks.Task<ChatSendMessageResponse> PatchChatsRoomMessageAsync (string roomJid, string messageId, SendMessageBody body);

        /// <summary>
        /// Edit a message in a room
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">messageBody</param>
        /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatSendMessageResponse>> PatchChatsRoomMessageAsyncWithHttpInfo (string roomJid, string messageId, SendMessageBody body);

        /// <summary>
        /// Patch Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ChatSettings</returns>
        
        System.Threading.Tasks.Task<ChatSettings> PatchChatsSettingsAsync (ChatSettings body);

        /// <summary>
        /// Patch Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatSettings>> PatchChatsSettingsAsyncWithHttpInfo (ChatSettings body);

        /// <summary>
        /// Edit a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">message body</param>
        /// <returns>Task of ChatSendMessageResponse</returns>
        
        System.Threading.Tasks.Task<ChatSendMessageResponse> PatchChatsUserMessageAsync (string userId, string messageId, SendMessageBody body);

        /// <summary>
        /// Edit a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// PatchChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">message body</param>
        /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatSendMessageResponse>> PatchChatsUserMessageAsyncWithHttpInfo (string userId, string messageId, SendMessageBody body);

        /// <summary>
        /// Send a message to a room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="body">messageBody</param>
        /// <returns>Task of ChatSendMessageResponse</returns>
        
        System.Threading.Tasks.Task<ChatSendMessageResponse> PostChatsRoomMessagesAsync (string roomJid, SendMessageBody body);

        /// <summary>
        /// Send a message to a room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="body">messageBody</param>
        /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatSendMessageResponse>> PostChatsRoomMessagesAsyncWithHttpInfo (string roomJid, SendMessageBody body);

        /// <summary>
        /// Join a room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostChatsRoomParticipantAsync (string roomJid, string userId);

        /// <summary>
        /// Join a room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostChatsRoomParticipantAsyncWithHttpInfo (string roomJid, string userId);

        /// <summary>
        /// Add pinned messages for a room, up to a maximum of 5 pinned messages
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomPinnedmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Pinned Message Ids</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task PostChatsRoomPinnedmessagesAsync (string roomJid, PinnedMessageRequest body);

        /// <summary>
        /// Add pinned messages for a room, up to a maximum of 5 pinned messages
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRoomPinnedmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Pinned Message Ids</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> PostChatsRoomPinnedmessagesAsyncWithHttpInfo (string roomJid, PinnedMessageRequest body);

        /// <summary>
        /// Create an adhoc room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRooms is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Room properties</param>
        /// <returns>Task of CreateRoomResponse</returns>
        
        System.Threading.Tasks.Task<CreateRoomResponse> PostChatsRoomsAsync (CreateRoomRequest body);

        /// <summary>
        /// Create an adhoc room
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsRooms is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Room properties</param>
        /// <returns>Task of ApiResponse (CreateRoomResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CreateRoomResponse>> PostChatsRoomsAsyncWithHttpInfo (CreateRoomRequest body);

        /// <summary>
        /// Send a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="body">message body</param>
        /// <returns>Task of ChatSendMessageResponse</returns>
        
        System.Threading.Tasks.Task<ChatSendMessageResponse> PostChatsUserMessagesAsync (string userId, SendMessageBody body);

        /// <summary>
        /// Send a message to a user
        /// </summary>
        /// <remarks>
        /// 
        /// PostChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="body">message body</param>
        /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatSendMessageResponse>> PostChatsUserMessagesAsyncWithHttpInfo (string userId, SendMessageBody body);

        /// <summary>
        /// Update Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ChatSettings</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ChatSettings> PutChatSettingsAsync (ChatSettings body);

        /// <summary>
        /// Update Chat Settings.
        /// </summary>
        /// <remarks>
        /// This route is deprecated, please use /chats/settings instead
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<ChatSettings>> PutChatSettingsAsyncWithHttpInfo (ChatSettings body);

        /// <summary>
        /// Update Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ChatSettings</returns>
        
        System.Threading.Tasks.Task<ChatSettings> PutChatsSettingsAsync (ChatSettings body);

        /// <summary>
        /// Update Chat Settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ChatSettings>> PutChatsSettingsAsyncWithHttpInfo (ChatSettings body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ChatApi : IChatApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChatApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ChatApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a message in a room 
        /// 
        /// DeleteChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <returns></returns>
        
        public void DeleteChatsRoomMessage (string roomJid, string messageId)
        {
             DeleteChatsRoomMessageWithHttpInfo(roomJid, messageId);
        }

        /// <summary>
        /// Delete a message in a room 
        /// 
        /// DeleteChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteChatsRoomMessageWithHttpInfo (string roomJid, string messageId)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->DeleteChatsRoomMessage");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a message in a room 
        /// 
        /// DeleteChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteChatsRoomMessageAsync (string roomJid, string messageId)
        {
             await DeleteChatsRoomMessageAsyncWithHttpInfo(roomJid, messageId);

        }

        /// <summary>
        /// Delete a message in a room 
        /// 
        /// DeleteChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteChatsRoomMessageAsyncWithHttpInfo (string roomJid, string messageId)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomMessage");
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->DeleteChatsRoomMessage");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Remove a user from a room. 
        /// 
        /// DeleteChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns></returns>
        
        public void DeleteChatsRoomParticipant (string roomJid, string userId)
        {
             DeleteChatsRoomParticipantWithHttpInfo(roomJid, userId);
        }

        /// <summary>
        /// Remove a user from a room. 
        /// 
        /// DeleteChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteChatsRoomParticipantWithHttpInfo (string roomJid, string userId)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomParticipant");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->DeleteChatsRoomParticipant");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Remove a user from a room. 
        /// 
        /// DeleteChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteChatsRoomParticipantAsync (string roomJid, string userId)
        {
             await DeleteChatsRoomParticipantAsyncWithHttpInfo(roomJid, userId);

        }

        /// <summary>
        /// Remove a user from a room. 
        /// 
        /// DeleteChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteChatsRoomParticipantAsyncWithHttpInfo (string roomJid, string userId)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomParticipant");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->DeleteChatsRoomParticipant");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Remove a pinned message from a room 
        /// 
        /// DeleteChatsRoomPinnedmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pinnedMessageId">pinnedMessageId</param>
        /// <returns></returns>
        
        public void DeleteChatsRoomPinnedmessage (string roomJid, string pinnedMessageId)
        {
             DeleteChatsRoomPinnedmessageWithHttpInfo(roomJid, pinnedMessageId);
        }

        /// <summary>
        /// Remove a pinned message from a room 
        /// 
        /// DeleteChatsRoomPinnedmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pinnedMessageId">pinnedMessageId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteChatsRoomPinnedmessageWithHttpInfo (string roomJid, string pinnedMessageId)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomPinnedmessage");
            // verify the required parameter 'pinnedMessageId' is set
            if (pinnedMessageId == null)
                throw new ApiException(400, "Missing required parameter 'pinnedMessageId' when calling ChatApi->DeleteChatsRoomPinnedmessage");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/pinnedmessages/{pinnedMessageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
            if (pinnedMessageId != null) localVarPathParams.Add("pinnedMessageId", this.Configuration.ApiClient.ParameterToString(pinnedMessageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomPinnedmessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomPinnedmessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Remove a pinned message from a room 
        /// 
        /// DeleteChatsRoomPinnedmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pinnedMessageId">pinnedMessageId</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteChatsRoomPinnedmessageAsync (string roomJid, string pinnedMessageId)
        {
             await DeleteChatsRoomPinnedmessageAsyncWithHttpInfo(roomJid, pinnedMessageId);

        }

        /// <summary>
        /// Remove a pinned message from a room 
        /// 
        /// DeleteChatsRoomPinnedmessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pinnedMessageId">pinnedMessageId</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteChatsRoomPinnedmessageAsyncWithHttpInfo (string roomJid, string pinnedMessageId)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->DeleteChatsRoomPinnedmessage");
            
            // verify the required parameter 'pinnedMessageId' is set
            if (pinnedMessageId == null)
                throw new ApiException(400, "Missing required parameter 'pinnedMessageId' when calling ChatApi->DeleteChatsRoomPinnedmessage");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/pinnedmessages/{pinnedMessageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
            if (pinnedMessageId != null) localVarPathParams.Add("pinnedMessageId", this.Configuration.ApiClient.ParameterToString(pinnedMessageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomPinnedmessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsRoomPinnedmessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a message to a user 
        /// 
        /// DeleteChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <returns></returns>
        
        public void DeleteChatsUserMessage (string userId, string messageId)
        {
             DeleteChatsUserMessageWithHttpInfo(userId, messageId);
        }

        /// <summary>
        /// Delete a message to a user 
        /// 
        /// DeleteChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteChatsUserMessageWithHttpInfo (string userId, string messageId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->DeleteChatsUserMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->DeleteChatsUserMessage");

            var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a message to a user 
        /// 
        /// DeleteChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteChatsUserMessageAsync (string userId, string messageId)
        {
             await DeleteChatsUserMessageAsyncWithHttpInfo(userId, messageId);

        }

        /// <summary>
        /// Delete a message to a user 
        /// 
        /// DeleteChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteChatsUserMessageAsyncWithHttpInfo (string userId, string messageId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->DeleteChatsUserMessage");
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->DeleteChatsUserMessage");
            

            var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChatSettings</returns>
        [Obsolete]
        public ChatSettings GetChatSettings ()
        {
             ApiResponse<ChatSettings> localVarResponse = GetChatSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChatSettings</returns>
        [Obsolete]
        public ApiResponse< ChatSettings > GetChatSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/chat/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChatSettings</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ChatSettings> GetChatSettingsAsync ()
        {
             ApiResponse<ChatSettings> localVarResponse = await GetChatSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<ChatSettings>> GetChatSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/chat/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a message 
        /// 
        /// GetChatsMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>ChatMessageResponse</returns>
        
        public ChatMessageResponse GetChatsMessage (string messageId)
        {
             ApiResponse<ChatMessageResponse> localVarResponse = GetChatsMessageWithHttpInfo(messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a message 
        /// 
        /// GetChatsMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of ChatMessageResponse</returns>
        
        public ApiResponse< ChatMessageResponse > GetChatsMessageWithHttpInfo (string messageId)
        { 
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->GetChatsMessage");

            var localVarPath = "/api/v2/chats/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a message 
        /// 
        /// GetChatsMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ChatMessageResponse</returns>
        
        public async System.Threading.Tasks.Task<ChatMessageResponse> GetChatsMessageAsync (string messageId)
        {
             ApiResponse<ChatMessageResponse> localVarResponse = await GetChatsMessageAsyncWithHttpInfo(messageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a message 
        /// 
        /// GetChatsMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse (ChatMessageResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatMessageResponse>> GetChatsMessageAsyncWithHttpInfo (string messageId)
        { 
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->GetChatsMessage");
            

            var localVarPath = "/api/v2/chats/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a room 
        /// 
        /// GetChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <returns>Room</returns>
        
        public Room GetChatsRoom (string roomJid)
        {
             ApiResponse<Room> localVarResponse = GetChatsRoomWithHttpInfo(roomJid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a room 
        /// 
        /// GetChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <returns>ApiResponse of Room</returns>
        
        public ApiResponse< Room > GetChatsRoomWithHttpInfo (string roomJid)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoom");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoom: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoom: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Room>(localVarStatusCode,
                localVarHeaders,
                (Room) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Room)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a room 
        /// 
        /// GetChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <returns>Task of Room</returns>
        
        public async System.Threading.Tasks.Task<Room> GetChatsRoomAsync (string roomJid)
        {
             ApiResponse<Room> localVarResponse = await GetChatsRoomAsyncWithHttpInfo(roomJid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a room 
        /// 
        /// GetChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <returns>Task of ApiResponse (Room)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Room>> GetChatsRoomAsyncWithHttpInfo (string roomJid)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoom");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoom: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoom: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Room>(localVarStatusCode,
                localVarHeaders,
                (Room) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Room)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get messages by id(s) from a room 
        /// 
        /// GetChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>ChatMessageEntityListing</returns>
        
        public ChatMessageEntityListing GetChatsRoomMessage (string roomJid, string messageIds)
        {
             ApiResponse<ChatMessageEntityListing> localVarResponse = GetChatsRoomMessageWithHttpInfo(roomJid, messageIds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get messages by id(s) from a room 
        /// 
        /// GetChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>ApiResponse of ChatMessageEntityListing</returns>
        
        public ApiResponse< ChatMessageEntityListing > GetChatsRoomMessageWithHttpInfo (string roomJid, string messageIds)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomMessage");
            // verify the required parameter 'messageIds' is set
            if (messageIds == null)
                throw new ApiException(400, "Missing required parameter 'messageIds' when calling ChatApi->GetChatsRoomMessage");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageIds}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
            if (messageIds != null) localVarPathParams.Add("messageIds", this.Configuration.ApiClient.ParameterToString(messageIds));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get messages by id(s) from a room 
        /// 
        /// GetChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>Task of ChatMessageEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ChatMessageEntityListing> GetChatsRoomMessageAsync (string roomJid, string messageIds)
        {
             ApiResponse<ChatMessageEntityListing> localVarResponse = await GetChatsRoomMessageAsyncWithHttpInfo(roomJid, messageIds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get messages by id(s) from a room 
        /// 
        /// GetChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatMessageEntityListing>> GetChatsRoomMessageAsyncWithHttpInfo (string roomJid, string messageIds)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomMessage");
            
            // verify the required parameter 'messageIds' is set
            if (messageIds == null)
                throw new ApiException(400, "Missing required parameter 'messageIds' when calling ChatApi->GetChatsRoomMessage");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageIds}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
            if (messageIds != null) localVarPathParams.Add("messageIds", this.Configuration.ApiClient.ParameterToString(messageIds));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a room's message history 
        /// 
        /// GetChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ChatMessageEntityListing</returns>
        
        public ChatMessageEntityListing GetChatsRoomMessages (string roomJid, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        {
             ApiResponse<ChatMessageEntityListing> localVarResponse = GetChatsRoomMessagesWithHttpInfo(roomJid, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, limit, before, after);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a room's message history 
        /// 
        /// GetChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ApiResponse of ChatMessageEntityListing</returns>
        
        public ApiResponse< ChatMessageEntityListing > GetChatsRoomMessagesWithHttpInfo (string roomJid, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomMessages");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoomMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoomMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a room's message history 
        /// 
        /// GetChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ChatMessageEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ChatMessageEntityListing> GetChatsRoomMessagesAsync (string roomJid, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        {
             ApiResponse<ChatMessageEntityListing> localVarResponse = await GetChatsRoomMessagesAsyncWithHttpInfo(roomJid, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, limit, before, after);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a room's message history 
        /// 
        /// GetChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatMessageEntityListing>> GetChatsRoomMessagesAsyncWithHttpInfo (string roomJid, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->GetChatsRoomMessages");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoomMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsRoomMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChatSettings</returns>
        
        public ChatSettings GetChatsSettings ()
        {
             ApiResponse<ChatSettings> localVarResponse = GetChatsSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChatSettings</returns>
        
        public ApiResponse< ChatSettings > GetChatsSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/chats/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChatSettings</returns>
        
        public async System.Threading.Tasks.Task<ChatSettings> GetChatsSettingsAsync ()
        {
             ApiResponse<ChatSettings> localVarResponse = await GetChatsSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatSettings>> GetChatsSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/chats/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get history by thread 
        /// 
        /// GetChatsThreadMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">threadId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ChatMessageEntityListing</returns>
        
        public ChatMessageEntityListing GetChatsThreadMessages (string threadId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        {
             ApiResponse<ChatMessageEntityListing> localVarResponse = GetChatsThreadMessagesWithHttpInfo(threadId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, limit, before, after);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get history by thread 
        /// 
        /// GetChatsThreadMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">threadId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ApiResponse of ChatMessageEntityListing</returns>
        
        public ApiResponse< ChatMessageEntityListing > GetChatsThreadMessagesWithHttpInfo (string threadId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        { 
            // verify the required parameter 'threadId' is set
            if (threadId == null)
                throw new ApiException(400, "Missing required parameter 'threadId' when calling ChatApi->GetChatsThreadMessages");

            var localVarPath = "/api/v2/chats/threads/{threadId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (threadId != null) localVarPathParams.Add("threadId", this.Configuration.ApiClient.ParameterToString(threadId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsThreadMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsThreadMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get history by thread 
        /// 
        /// GetChatsThreadMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">threadId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ChatMessageEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ChatMessageEntityListing> GetChatsThreadMessagesAsync (string threadId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        {
             ApiResponse<ChatMessageEntityListing> localVarResponse = await GetChatsThreadMessagesAsyncWithHttpInfo(threadId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, limit, before, after);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get history by thread 
        /// 
        /// GetChatsThreadMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">threadId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatMessageEntityListing>> GetChatsThreadMessagesAsyncWithHttpInfo (string threadId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        { 
            // verify the required parameter 'threadId' is set
            if (threadId == null)
                throw new ApiException(400, "Missing required parameter 'threadId' when calling ChatApi->GetChatsThreadMessages");
            

            var localVarPath = "/api/v2/chats/threads/{threadId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (threadId != null) localVarPathParams.Add("threadId", this.Configuration.ApiClient.ParameterToString(threadId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsThreadMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsThreadMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get messages by id(s) from a 1on1 
        /// 
        /// GetChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>ChatMessageEntityListing</returns>
        
        public ChatMessageEntityListing GetChatsUserMessage (string userId, string messageIds)
        {
             ApiResponse<ChatMessageEntityListing> localVarResponse = GetChatsUserMessageWithHttpInfo(userId, messageIds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get messages by id(s) from a 1on1 
        /// 
        /// GetChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>ApiResponse of ChatMessageEntityListing</returns>
        
        public ApiResponse< ChatMessageEntityListing > GetChatsUserMessageWithHttpInfo (string userId, string messageIds)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUserMessage");
            // verify the required parameter 'messageIds' is set
            if (messageIds == null)
                throw new ApiException(400, "Missing required parameter 'messageIds' when calling ChatApi->GetChatsUserMessage");

            var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageIds}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (messageIds != null) localVarPathParams.Add("messageIds", this.Configuration.ApiClient.ParameterToString(messageIds));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get messages by id(s) from a 1on1 
        /// 
        /// GetChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>Task of ChatMessageEntityListing</returns>
        
        public async System.Threading.Tasks.Task<ChatMessageEntityListing> GetChatsUserMessageAsync (string userId, string messageIds)
        {
             ApiResponse<ChatMessageEntityListing> localVarResponse = await GetChatsUserMessageAsyncWithHttpInfo(userId, messageIds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get messages by id(s) from a 1on1 
        /// 
        /// GetChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageIds">messageIds, comma separated</param>
        /// <returns>Task of ApiResponse (ChatMessageEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatMessageEntityListing>> GetChatsUserMessageAsyncWithHttpInfo (string userId, string messageIds)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUserMessage");
            
            // verify the required parameter 'messageIds' is set
            if (messageIds == null)
                throw new ApiException(400, "Missing required parameter 'messageIds' when calling ChatApi->GetChatsUserMessage");
            

            var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageIds}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (messageIds != null) localVarPathParams.Add("messageIds", this.Configuration.ApiClient.ParameterToString(messageIds));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get 1on1 History between a user 
        /// 
        /// GetChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ChatMessageResponse</returns>
        
        public ChatMessageResponse GetChatsUserMessages (string userId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        {
             ApiResponse<ChatMessageResponse> localVarResponse = GetChatsUserMessagesWithHttpInfo(userId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, limit, before, after);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get 1on1 History between a user 
        /// 
        /// GetChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>ApiResponse of ChatMessageResponse</returns>
        
        public ApiResponse< ChatMessageResponse > GetChatsUserMessagesWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUserMessages");

            var localVarPath = "/api/v2/chats/users/{userId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsUserMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsUserMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get 1on1 History between a user 
        /// 
        /// GetChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ChatMessageResponse</returns>
        
        public async System.Threading.Tasks.Task<ChatMessageResponse> GetChatsUserMessagesAsync (string userId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        {
             ApiResponse<ChatMessageResponse> localVarResponse = await GetChatsUserMessagesAsyncWithHttpInfo(userId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, limit, before, after);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get 1on1 History between a user 
        /// 
        /// GetChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="limit">The maximum number of messages to retrieve (optional)</param>
        /// <param name="before">The cutoff date for messages to retrieve (optional)</param>
        /// <param name="after">The beginning date for messages to retrieve (optional)</param>
        /// <returns>Task of ApiResponse (ChatMessageResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatMessageResponse>> GetChatsUserMessagesAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string limit = null, string before = null, string after = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->GetChatsUserMessages");
            

            var localVarPath = "/api/v2/chats/users/{userId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsUserMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsUserMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ChatSettings</returns>
        [Obsolete]
        public ChatSettings PatchChatSettings (ChatSettings body)
        {
             ApiResponse<ChatSettings> localVarResponse = PatchChatSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ApiResponse of ChatSettings</returns>
        [Obsolete]
        public ApiResponse< ChatSettings > PatchChatSettingsWithHttpInfo (ChatSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatSettings");

            var localVarPath = "/api/v2/chat/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ChatSettings</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ChatSettings> PatchChatSettingsAsync (ChatSettings body)
        {
             ApiResponse<ChatSettings> localVarResponse = await PatchChatSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<ChatSettings>> PatchChatSettingsAsyncWithHttpInfo (ChatSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatSettings");
            

            var localVarPath = "/api/v2/chat/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Set properties for a room 
        /// 
        /// PatchChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Room properties</param>
        /// <returns></returns>
        
        public void PatchChatsRoom (string roomJid, RoomUpdateRequest body)
        {
             PatchChatsRoomWithHttpInfo(roomJid, body);
        }

        /// <summary>
        /// Set properties for a room 
        /// 
        /// PatchChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Room properties</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PatchChatsRoomWithHttpInfo (string roomJid, RoomUpdateRequest body)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PatchChatsRoom");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsRoom");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsRoom: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsRoom: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Set properties for a room 
        /// 
        /// PatchChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Room properties</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PatchChatsRoomAsync (string roomJid, RoomUpdateRequest body)
        {
             await PatchChatsRoomAsyncWithHttpInfo(roomJid, body);

        }

        /// <summary>
        /// Set properties for a room 
        /// 
        /// PatchChatsRoom is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Room properties</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatsRoomAsyncWithHttpInfo (string roomJid, RoomUpdateRequest body)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PatchChatsRoom");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsRoom");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsRoom: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsRoom: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Edit a message in a room 
        /// 
        /// PatchChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">messageBody</param>
        /// <returns>ChatSendMessageResponse</returns>
        
        public ChatSendMessageResponse PatchChatsRoomMessage (string roomJid, string messageId, SendMessageBody body)
        {
             ApiResponse<ChatSendMessageResponse> localVarResponse = PatchChatsRoomMessageWithHttpInfo(roomJid, messageId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Edit a message in a room 
        /// 
        /// PatchChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">messageBody</param>
        /// <returns>ApiResponse of ChatSendMessageResponse</returns>
        
        public ApiResponse< ChatSendMessageResponse > PatchChatsRoomMessageWithHttpInfo (string roomJid, string messageId, SendMessageBody body)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PatchChatsRoomMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->PatchChatsRoomMessage");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsRoomMessage");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatSendMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Edit a message in a room 
        /// 
        /// PatchChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">messageBody</param>
        /// <returns>Task of ChatSendMessageResponse</returns>
        
        public async System.Threading.Tasks.Task<ChatSendMessageResponse> PatchChatsRoomMessageAsync (string roomJid, string messageId, SendMessageBody body)
        {
             ApiResponse<ChatSendMessageResponse> localVarResponse = await PatchChatsRoomMessageAsyncWithHttpInfo(roomJid, messageId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Edit a message in a room 
        /// 
        /// PatchChatsRoomMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">messageBody</param>
        /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatSendMessageResponse>> PatchChatsRoomMessageAsyncWithHttpInfo (string roomJid, string messageId, SendMessageBody body)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PatchChatsRoomMessage");
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->PatchChatsRoomMessage");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsRoomMessage");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsRoomMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsRoomMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatSendMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Patch Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ChatSettings</returns>
        
        public ChatSettings PatchChatsSettings (ChatSettings body)
        {
             ApiResponse<ChatSettings> localVarResponse = PatchChatsSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ApiResponse of ChatSettings</returns>
        
        public ApiResponse< ChatSettings > PatchChatsSettingsWithHttpInfo (ChatSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsSettings");

            var localVarPath = "/api/v2/chats/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Patch Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ChatSettings</returns>
        
        public async System.Threading.Tasks.Task<ChatSettings> PatchChatsSettingsAsync (ChatSettings body)
        {
             ApiResponse<ChatSettings> localVarResponse = await PatchChatsSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatSettings>> PatchChatsSettingsAsyncWithHttpInfo (ChatSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsSettings");
            

            var localVarPath = "/api/v2/chats/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Edit a message to a user 
        /// 
        /// PatchChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">message body</param>
        /// <returns>ChatSendMessageResponse</returns>
        
        public ChatSendMessageResponse PatchChatsUserMessage (string userId, string messageId, SendMessageBody body)
        {
             ApiResponse<ChatSendMessageResponse> localVarResponse = PatchChatsUserMessageWithHttpInfo(userId, messageId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Edit a message to a user 
        /// 
        /// PatchChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">message body</param>
        /// <returns>ApiResponse of ChatSendMessageResponse</returns>
        
        public ApiResponse< ChatSendMessageResponse > PatchChatsUserMessageWithHttpInfo (string userId, string messageId, SendMessageBody body)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PatchChatsUserMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->PatchChatsUserMessage");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsUserMessage");

            var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatSendMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Edit a message to a user 
        /// 
        /// PatchChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">message body</param>
        /// <returns>Task of ChatSendMessageResponse</returns>
        
        public async System.Threading.Tasks.Task<ChatSendMessageResponse> PatchChatsUserMessageAsync (string userId, string messageId, SendMessageBody body)
        {
             ApiResponse<ChatSendMessageResponse> localVarResponse = await PatchChatsUserMessageAsyncWithHttpInfo(userId, messageId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Edit a message to a user 
        /// 
        /// PatchChatsUserMessage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="messageId">messageId</param>
        /// <param name="body">message body</param>
        /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatSendMessageResponse>> PatchChatsUserMessageAsyncWithHttpInfo (string userId, string messageId, SendMessageBody body)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PatchChatsUserMessage");
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ChatApi->PatchChatsUserMessage");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PatchChatsUserMessage");
            

            var localVarPath = "/api/v2/chats/users/{userId}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (messageId != null) localVarPathParams.Add("messageId", this.Configuration.ApiClient.ParameterToString(messageId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsUserMessage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsUserMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatSendMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Send a message to a room 
        /// 
        /// PostChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="body">messageBody</param>
        /// <returns>ChatSendMessageResponse</returns>
        
        public ChatSendMessageResponse PostChatsRoomMessages (string roomJid, SendMessageBody body)
        {
             ApiResponse<ChatSendMessageResponse> localVarResponse = PostChatsRoomMessagesWithHttpInfo(roomJid, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send a message to a room 
        /// 
        /// PostChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="body">messageBody</param>
        /// <returns>ApiResponse of ChatSendMessageResponse</returns>
        
        public ApiResponse< ChatSendMessageResponse > PostChatsRoomMessagesWithHttpInfo (string roomJid, SendMessageBody body)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomMessages");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRoomMessages");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatSendMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Send a message to a room 
        /// 
        /// PostChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="body">messageBody</param>
        /// <returns>Task of ChatSendMessageResponse</returns>
        
        public async System.Threading.Tasks.Task<ChatSendMessageResponse> PostChatsRoomMessagesAsync (string roomJid, SendMessageBody body)
        {
             ApiResponse<ChatSendMessageResponse> localVarResponse = await PostChatsRoomMessagesAsyncWithHttpInfo(roomJid, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send a message to a room 
        /// 
        /// PostChatsRoomMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomId</param>
        /// <param name="body">messageBody</param>
        /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatSendMessageResponse>> PostChatsRoomMessagesAsyncWithHttpInfo (string roomJid, SendMessageBody body)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomMessages");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRoomMessages");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/messages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatSendMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Join a room 
        /// 
        /// PostChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns></returns>
        
        public void PostChatsRoomParticipant (string roomJid, string userId)
        {
             PostChatsRoomParticipantWithHttpInfo(roomJid, userId);
        }

        /// <summary>
        /// Join a room 
        /// 
        /// PostChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostChatsRoomParticipantWithHttpInfo (string roomJid, string userId)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomParticipant");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PostChatsRoomParticipant");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Join a room 
        /// 
        /// PostChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostChatsRoomParticipantAsync (string roomJid, string userId)
        {
             await PostChatsRoomParticipantAsyncWithHttpInfo(roomJid, userId);

        }

        /// <summary>
        /// Join a room 
        /// 
        /// PostChatsRoomParticipant is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="userId">userId</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostChatsRoomParticipantAsyncWithHttpInfo (string roomJid, string userId)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomParticipant");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PostChatsRoomParticipant");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/participants/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomParticipant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Add pinned messages for a room, up to a maximum of 5 pinned messages 
        /// 
        /// PostChatsRoomPinnedmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Pinned Message Ids</param>
        /// <returns></returns>
        
        public void PostChatsRoomPinnedmessages (string roomJid, PinnedMessageRequest body)
        {
             PostChatsRoomPinnedmessagesWithHttpInfo(roomJid, body);
        }

        /// <summary>
        /// Add pinned messages for a room, up to a maximum of 5 pinned messages 
        /// 
        /// PostChatsRoomPinnedmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Pinned Message Ids</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> PostChatsRoomPinnedmessagesWithHttpInfo (string roomJid, PinnedMessageRequest body)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomPinnedmessages");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRoomPinnedmessages");

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/pinnedmessages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomPinnedmessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomPinnedmessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Add pinned messages for a room, up to a maximum of 5 pinned messages 
        /// 
        /// PostChatsRoomPinnedmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Pinned Message Ids</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task PostChatsRoomPinnedmessagesAsync (string roomJid, PinnedMessageRequest body)
        {
             await PostChatsRoomPinnedmessagesAsyncWithHttpInfo(roomJid, body);

        }

        /// <summary>
        /// Add pinned messages for a room, up to a maximum of 5 pinned messages 
        /// 
        /// PostChatsRoomPinnedmessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomJid">roomJid</param>
        /// <param name="body">Pinned Message Ids</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostChatsRoomPinnedmessagesAsyncWithHttpInfo (string roomJid, PinnedMessageRequest body)
        { 
            // verify the required parameter 'roomJid' is set
            if (roomJid == null)
                throw new ApiException(400, "Missing required parameter 'roomJid' when calling ChatApi->PostChatsRoomPinnedmessages");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRoomPinnedmessages");
            

            var localVarPath = "/api/v2/chats/rooms/{roomJid}/pinnedmessages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (roomJid != null) localVarPathParams.Add("roomJid", this.Configuration.ApiClient.ParameterToString(roomJid));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomPinnedmessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRoomPinnedmessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an adhoc room 
        /// 
        /// PostChatsRooms is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Room properties</param>
        /// <returns>CreateRoomResponse</returns>
        
        public CreateRoomResponse PostChatsRooms (CreateRoomRequest body)
        {
             ApiResponse<CreateRoomResponse> localVarResponse = PostChatsRoomsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an adhoc room 
        /// 
        /// PostChatsRooms is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Room properties</param>
        /// <returns>ApiResponse of CreateRoomResponse</returns>
        
        public ApiResponse< CreateRoomResponse > PostChatsRoomsWithHttpInfo (CreateRoomRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRooms");

            var localVarPath = "/api/v2/chats/rooms";
            var localVarPathParams = new Dictionary<String, String>();
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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRooms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRooms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateRoomResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateRoomResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateRoomResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an adhoc room 
        /// 
        /// PostChatsRooms is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Room properties</param>
        /// <returns>Task of CreateRoomResponse</returns>
        
        public async System.Threading.Tasks.Task<CreateRoomResponse> PostChatsRoomsAsync (CreateRoomRequest body)
        {
             ApiResponse<CreateRoomResponse> localVarResponse = await PostChatsRoomsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an adhoc room 
        /// 
        /// PostChatsRooms is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Room properties</param>
        /// <returns>Task of ApiResponse (CreateRoomResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CreateRoomResponse>> PostChatsRoomsAsyncWithHttpInfo (CreateRoomRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsRooms");
            

            var localVarPath = "/api/v2/chats/rooms";
            var localVarPathParams = new Dictionary<String, String>();
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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRooms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsRooms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateRoomResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateRoomResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateRoomResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Send a message to a user 
        /// 
        /// PostChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="body">message body</param>
        /// <returns>ChatSendMessageResponse</returns>
        
        public ChatSendMessageResponse PostChatsUserMessages (string userId, SendMessageBody body)
        {
             ApiResponse<ChatSendMessageResponse> localVarResponse = PostChatsUserMessagesWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send a message to a user 
        /// 
        /// PostChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="body">message body</param>
        /// <returns>ApiResponse of ChatSendMessageResponse</returns>
        
        public ApiResponse< ChatSendMessageResponse > PostChatsUserMessagesWithHttpInfo (string userId, SendMessageBody body)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PostChatsUserMessages");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsUserMessages");

            var localVarPath = "/api/v2/chats/users/{userId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsUserMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsUserMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatSendMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Send a message to a user 
        /// 
        /// PostChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="body">message body</param>
        /// <returns>Task of ChatSendMessageResponse</returns>
        
        public async System.Threading.Tasks.Task<ChatSendMessageResponse> PostChatsUserMessagesAsync (string userId, SendMessageBody body)
        {
             ApiResponse<ChatSendMessageResponse> localVarResponse = await PostChatsUserMessagesAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send a message to a user 
        /// 
        /// PostChatsUserMessages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">userId</param>
        /// <param name="body">message body</param>
        /// <returns>Task of ApiResponse (ChatSendMessageResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatSendMessageResponse>> PostChatsUserMessagesAsyncWithHttpInfo (string userId, SendMessageBody body)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ChatApi->PostChatsUserMessages");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PostChatsUserMessages");
            

            var localVarPath = "/api/v2/chats/users/{userId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsUserMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsUserMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSendMessageResponse>(localVarStatusCode,
                localVarHeaders,
                (ChatSendMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSendMessageResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ChatSettings</returns>
        [Obsolete]
        public ChatSettings PutChatSettings (ChatSettings body)
        {
             ApiResponse<ChatSettings> localVarResponse = PutChatSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ApiResponse of ChatSettings</returns>
        [Obsolete]
        public ApiResponse< ChatSettings > PutChatSettingsWithHttpInfo (ChatSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PutChatSettings");

            var localVarPath = "/api/v2/chat/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutChatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutChatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ChatSettings</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ChatSettings> PutChatSettingsAsync (ChatSettings body)
        {
             ApiResponse<ChatSettings> localVarResponse = await PutChatSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Chat Settings. 
        /// This route is deprecated, please use /chats/settings instead
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<ChatSettings>> PutChatSettingsAsyncWithHttpInfo (ChatSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PutChatSettings");
            

            var localVarPath = "/api/v2/chat/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutChatSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutChatSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ChatSettings</returns>
        
        public ChatSettings PutChatsSettings (ChatSettings body)
        {
             ApiResponse<ChatSettings> localVarResponse = PutChatsSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>ApiResponse of ChatSettings</returns>
        
        public ApiResponse< ChatSettings > PutChatsSettingsWithHttpInfo (ChatSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PutChatsSettings");

            var localVarPath = "/api/v2/chats/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ChatSettings</returns>
        
        public async System.Threading.Tasks.Task<ChatSettings> PutChatsSettingsAsync (ChatSettings body)
        {
             ApiResponse<ChatSettings> localVarResponse = await PutChatsSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Chat Settings. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Chat</param>
        /// <returns>Task of ApiResponse (ChatSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ChatSettings>> PutChatsSettingsAsyncWithHttpInfo (ChatSettings body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->PutChatsSettings");
            

            var localVarPath = "/api/v2/chats/settings";
            var localVarPathParams = new Dictionary<String, String>();
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
                                                             .Select(header => new
                                                         {
                                                            Name = header.GetType().GetProperty("Name")?.GetValue(header),
                                                            Value = header.GetType().GetProperty("Value")?.GetValue(header)
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutChatsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutChatsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatSettings>(localVarStatusCode,
                localVarHeaders,
                (ChatSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
