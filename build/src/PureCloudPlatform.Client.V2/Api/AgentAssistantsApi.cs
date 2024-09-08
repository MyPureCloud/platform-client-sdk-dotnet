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
    public interface IAgentAssistantsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns></returns>
        
        void DeleteAssistant (string assistantId);

        /// <summary>
        /// Delete an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteAssistantWithHttpInfo (string assistantId);

        /// <summary>
        /// Disassociate a queue from an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <returns></returns>
        
        void DeleteAssistantQueue (string assistantId, string queueId);

        /// <summary>
        /// Disassociate a queue from an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteAssistantQueueWithHttpInfo (string assistantId, string queueId);

        /// <summary>
        /// Disassociate the queues from an assistant for the given assistant ID and queue IDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be deleted. (optional)</param>
        /// <returns></returns>
        
        void DeleteAssistantQueues (string assistantId, string queueIds = null);

        /// <summary>
        /// Disassociate the queues from an assistant for the given assistant ID and queue IDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be deleted. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteAssistantQueuesWithHttpInfo (string assistantId, string queueIds = null);

        /// <summary>
        /// Get an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Assistant</returns>
        
        Assistant GetAssistant (string assistantId, string expand = null);

        /// <summary>
        /// Get an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of Assistant</returns>
        
        ApiResponse<Assistant> GetAssistantWithHttpInfo (string assistantId, string expand = null);

        /// <summary>
        /// Get queue Information for an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>AssistantQueue</returns>
        
        AssistantQueue GetAssistantQueue (string assistantId, string queueId, string expand = null);

        /// <summary>
        /// Get queue Information for an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of AssistantQueue</returns>
        
        ApiResponse<AssistantQueue> GetAssistantQueueWithHttpInfo (string assistantId, string queueId, string expand = null);

        /// <summary>
        /// Get all the queues associated with an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>AssistantQueueListing</returns>
        
        AssistantQueueListing GetAssistantQueues (string assistantId, string before = null, string after = null, string pageSize = null, string expand = null);

        /// <summary>
        /// Get all the queues associated with an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of AssistantQueueListing</returns>
        
        ApiResponse<AssistantQueueListing> GetAssistantQueuesWithHttpInfo (string assistantId, string before = null, string after = null, string pageSize = null, string expand = null);

        /// <summary>
        /// Get all assistants.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Return the assistant by the given name. (optional)</param>
        /// <returns>AssistantListing</returns>
        
        AssistantListing GetAssistants (string before = null, string after = null, string limit = null, string pageSize = null, string name = null);

        /// <summary>
        /// Get all assistants.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Return the assistant by the given name. (optional)</param>
        /// <returns>ApiResponse of AssistantListing</returns>
        
        ApiResponse<AssistantListing> GetAssistantsWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null);

        /// <summary>
        /// Get all queues assigned to any assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be retrieved. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>AssistantQueueListing</returns>
        
        AssistantQueueListing GetAssistantsQueues (string before = null, string after = null, string pageSize = null, string queueIds = null, string expand = null);

        /// <summary>
        /// Get all queues assigned to any assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be retrieved. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of AssistantQueueListing</returns>
        
        ApiResponse<AssistantQueueListing> GetAssistantsQueuesWithHttpInfo (string before = null, string after = null, string pageSize = null, string queueIds = null, string expand = null);

        /// <summary>
        /// Update an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Assistant</returns>
        
        Assistant PatchAssistant (string assistantId, Assistant body);

        /// <summary>
        /// Update an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Assistant</returns>
        
        ApiResponse<Assistant> PatchAssistantWithHttpInfo (string assistantId, Assistant body);

        /// <summary>
        /// Update Queues for an Assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>AssistantQueueListing</returns>
        
        AssistantQueueListing PatchAssistantQueues (string assistantId, List<AssistantQueue> body);

        /// <summary>
        /// Update Queues for an Assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AssistantQueueListing</returns>
        
        ApiResponse<AssistantQueueListing> PatchAssistantQueuesWithHttpInfo (string assistantId, List<AssistantQueue> body);

        /// <summary>
        /// Create an Assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Assistant</returns>
        
        Assistant PostAssistants (Assistant body);

        /// <summary>
        /// Create an Assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Assistant</returns>
        
        ApiResponse<Assistant> PostAssistantsWithHttpInfo (Assistant body);

        /// <summary>
        /// Create a queue assistant association.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>AssistantQueue</returns>
        
        AssistantQueue PutAssistantQueue (string assistantId, string queueId, AssistantQueue body);

        /// <summary>
        /// Create a queue assistant association.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AssistantQueue</returns>
        
        ApiResponse<AssistantQueue> PutAssistantQueueWithHttpInfo (string assistantId, string queueId, AssistantQueue body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteAssistantAsync (string assistantId);

        /// <summary>
        /// Delete an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssistantAsyncWithHttpInfo (string assistantId);

        /// <summary>
        /// Disassociate a queue from an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteAssistantQueueAsync (string assistantId, string queueId);

        /// <summary>
        /// Disassociate a queue from an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssistantQueueAsyncWithHttpInfo (string assistantId, string queueId);

        /// <summary>
        /// Disassociate the queues from an assistant for the given assistant ID and queue IDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be deleted. (optional)</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteAssistantQueuesAsync (string assistantId, string queueIds = null);

        /// <summary>
        /// Disassociate the queues from an assistant for the given assistant ID and queue IDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be deleted. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssistantQueuesAsyncWithHttpInfo (string assistantId, string queueIds = null);

        /// <summary>
        /// Get an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of Assistant</returns>
        
        System.Threading.Tasks.Task<Assistant> GetAssistantAsync (string assistantId, string expand = null);

        /// <summary>
        /// Get an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Assistant)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Assistant>> GetAssistantAsyncWithHttpInfo (string assistantId, string expand = null);

        /// <summary>
        /// Get queue Information for an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of AssistantQueue</returns>
        
        System.Threading.Tasks.Task<AssistantQueue> GetAssistantQueueAsync (string assistantId, string queueId, string expand = null);

        /// <summary>
        /// Get queue Information for an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (AssistantQueue)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantQueue>> GetAssistantQueueAsyncWithHttpInfo (string assistantId, string queueId, string expand = null);

        /// <summary>
        /// Get all the queues associated with an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of AssistantQueueListing</returns>
        
        System.Threading.Tasks.Task<AssistantQueueListing> GetAssistantQueuesAsync (string assistantId, string before = null, string after = null, string pageSize = null, string expand = null);

        /// <summary>
        /// Get all the queues associated with an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (AssistantQueueListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantQueueListing>> GetAssistantQueuesAsyncWithHttpInfo (string assistantId, string before = null, string after = null, string pageSize = null, string expand = null);

        /// <summary>
        /// Get all assistants.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Return the assistant by the given name. (optional)</param>
        /// <returns>Task of AssistantListing</returns>
        
        System.Threading.Tasks.Task<AssistantListing> GetAssistantsAsync (string before = null, string after = null, string limit = null, string pageSize = null, string name = null);

        /// <summary>
        /// Get all assistants.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Return the assistant by the given name. (optional)</param>
        /// <returns>Task of ApiResponse (AssistantListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantListing>> GetAssistantsAsyncWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null);

        /// <summary>
        /// Get all queues assigned to any assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be retrieved. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of AssistantQueueListing</returns>
        
        System.Threading.Tasks.Task<AssistantQueueListing> GetAssistantsQueuesAsync (string before = null, string after = null, string pageSize = null, string queueIds = null, string expand = null);

        /// <summary>
        /// Get all queues assigned to any assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be retrieved. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (AssistantQueueListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantQueueListing>> GetAssistantsQueuesAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, string queueIds = null, string expand = null);

        /// <summary>
        /// Update an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Assistant</returns>
        
        System.Threading.Tasks.Task<Assistant> PatchAssistantAsync (string assistantId, Assistant body);

        /// <summary>
        /// Update an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Assistant)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Assistant>> PatchAssistantAsyncWithHttpInfo (string assistantId, Assistant body);

        /// <summary>
        /// Update Queues for an Assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AssistantQueueListing</returns>
        
        System.Threading.Tasks.Task<AssistantQueueListing> PatchAssistantQueuesAsync (string assistantId, List<AssistantQueue> body);

        /// <summary>
        /// Update Queues for an Assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AssistantQueueListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantQueueListing>> PatchAssistantQueuesAsyncWithHttpInfo (string assistantId, List<AssistantQueue> body);

        /// <summary>
        /// Create an Assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Assistant</returns>
        
        System.Threading.Tasks.Task<Assistant> PostAssistantsAsync (Assistant body);

        /// <summary>
        /// Create an Assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Assistant)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Assistant>> PostAssistantsAsyncWithHttpInfo (Assistant body);

        /// <summary>
        /// Create a queue assistant association.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AssistantQueue</returns>
        
        System.Threading.Tasks.Task<AssistantQueue> PutAssistantQueueAsync (string assistantId, string queueId, AssistantQueue body);

        /// <summary>
        /// Create a queue assistant association.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AssistantQueue)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantQueue>> PutAssistantQueueAsyncWithHttpInfo (string assistantId, string queueId, AssistantQueue body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AgentAssistantsApi : IAgentAssistantsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAssistantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AgentAssistantsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAssistantsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AgentAssistantsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns></returns>
        
        public void DeleteAssistant (string assistantId)
        {
             DeleteAssistantWithHttpInfo(assistantId);
        }

        /// <summary>
        /// Delete an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteAssistantWithHttpInfo (string assistantId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->DeleteAssistant");

            var localVarPath = "/api/v2/assistants/{assistantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteAssistantAsync (string assistantId)
        {
             await DeleteAssistantAsyncWithHttpInfo(assistantId);

        }

        /// <summary>
        /// Delete an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssistantAsyncWithHttpInfo (string assistantId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->DeleteAssistant");
            

            var localVarPath = "/api/v2/assistants/{assistantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Disassociate a queue from an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <returns></returns>
        
        public void DeleteAssistantQueue (string assistantId, string queueId)
        {
             DeleteAssistantQueueWithHttpInfo(assistantId, queueId);
        }

        /// <summary>
        /// Disassociate a queue from an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteAssistantQueueWithHttpInfo (string assistantId, string queueId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->DeleteAssistantQueue");
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->DeleteAssistantQueue");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (queueId != null) localVarPathParams.Add("queueId", this.Configuration.ApiClient.ParameterToString(queueId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantQueue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantQueue: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Disassociate a queue from an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteAssistantQueueAsync (string assistantId, string queueId)
        {
             await DeleteAssistantQueueAsyncWithHttpInfo(assistantId, queueId);

        }

        /// <summary>
        /// Disassociate a queue from an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssistantQueueAsyncWithHttpInfo (string assistantId, string queueId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->DeleteAssistantQueue");
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->DeleteAssistantQueue");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (queueId != null) localVarPathParams.Add("queueId", this.Configuration.ApiClient.ParameterToString(queueId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantQueue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantQueue: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Disassociate the queues from an assistant for the given assistant ID and queue IDs. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be deleted. (optional)</param>
        /// <returns></returns>
        
        public void DeleteAssistantQueues (string assistantId, string queueIds = null)
        {
             DeleteAssistantQueuesWithHttpInfo(assistantId, queueIds);
        }

        /// <summary>
        /// Disassociate the queues from an assistant for the given assistant ID and queue IDs. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be deleted. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteAssistantQueuesWithHttpInfo (string assistantId, string queueIds = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->DeleteAssistantQueues");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

            // Query params
            if (queueIds != null) localVarQueryParams.Add(new Tuple<string, string>("queueIds", this.Configuration.ApiClient.ParameterToString(queueIds)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Disassociate the queues from an assistant for the given assistant ID and queue IDs. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be deleted. (optional)</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteAssistantQueuesAsync (string assistantId, string queueIds = null)
        {
             await DeleteAssistantQueuesAsyncWithHttpInfo(assistantId, queueIds);

        }

        /// <summary>
        /// Disassociate the queues from an assistant for the given assistant ID and queue IDs. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be deleted. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssistantQueuesAsyncWithHttpInfo (string assistantId, string queueIds = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->DeleteAssistantQueues");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

            // Query params
            if (queueIds != null) localVarQueryParams.Add(new Tuple<string, string>("queueIds", this.Configuration.ApiClient.ParameterToString(queueIds)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Assistant</returns>
        
        public Assistant GetAssistant (string assistantId, string expand = null)
        {
             ApiResponse<Assistant> localVarResponse = GetAssistantWithHttpInfo(assistantId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of Assistant</returns>
        
        public ApiResponse< Assistant > GetAssistantWithHttpInfo (string assistantId, string expand = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->GetAssistant");

            var localVarPath = "/api/v2/assistants/{assistantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Assistant>(localVarStatusCode,
                localVarHeaders,
                (Assistant) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Assistant)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of Assistant</returns>
        
        public async System.Threading.Tasks.Task<Assistant> GetAssistantAsync (string assistantId, string expand = null)
        {
             ApiResponse<Assistant> localVarResponse = await GetAssistantAsyncWithHttpInfo(assistantId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Assistant)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Assistant>> GetAssistantAsyncWithHttpInfo (string assistantId, string expand = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->GetAssistant");
            

            var localVarPath = "/api/v2/assistants/{assistantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Assistant>(localVarStatusCode,
                localVarHeaders,
                (Assistant) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Assistant)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get queue Information for an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>AssistantQueue</returns>
        
        public AssistantQueue GetAssistantQueue (string assistantId, string queueId, string expand = null)
        {
             ApiResponse<AssistantQueue> localVarResponse = GetAssistantQueueWithHttpInfo(assistantId, queueId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get queue Information for an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of AssistantQueue</returns>
        
        public ApiResponse< AssistantQueue > GetAssistantQueueWithHttpInfo (string assistantId, string queueId, string expand = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->GetAssistantQueue");
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->GetAssistantQueue");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (queueId != null) localVarPathParams.Add("queueId", this.Configuration.ApiClient.ParameterToString(queueId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueue: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueue>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueue) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueue)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get queue Information for an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of AssistantQueue</returns>
        
        public async System.Threading.Tasks.Task<AssistantQueue> GetAssistantQueueAsync (string assistantId, string queueId, string expand = null)
        {
             ApiResponse<AssistantQueue> localVarResponse = await GetAssistantQueueAsyncWithHttpInfo(assistantId, queueId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get queue Information for an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (AssistantQueue)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantQueue>> GetAssistantQueueAsyncWithHttpInfo (string assistantId, string queueId, string expand = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->GetAssistantQueue");
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->GetAssistantQueue");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (queueId != null) localVarPathParams.Add("queueId", this.Configuration.ApiClient.ParameterToString(queueId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueue: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueue>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueue) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueue)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all the queues associated with an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>AssistantQueueListing</returns>
        
        public AssistantQueueListing GetAssistantQueues (string assistantId, string before = null, string after = null, string pageSize = null, string expand = null)
        {
             ApiResponse<AssistantQueueListing> localVarResponse = GetAssistantQueuesWithHttpInfo(assistantId, before, after, pageSize, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all the queues associated with an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of AssistantQueueListing</returns>
        
        public ApiResponse< AssistantQueueListing > GetAssistantQueuesWithHttpInfo (string assistantId, string before = null, string after = null, string pageSize = null, string expand = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->GetAssistantQueues");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueListing>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all the queues associated with an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of AssistantQueueListing</returns>
        
        public async System.Threading.Tasks.Task<AssistantQueueListing> GetAssistantQueuesAsync (string assistantId, string before = null, string after = null, string pageSize = null, string expand = null)
        {
             ApiResponse<AssistantQueueListing> localVarResponse = await GetAssistantQueuesAsyncWithHttpInfo(assistantId, before, after, pageSize, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all the queues associated with an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (AssistantQueueListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantQueueListing>> GetAssistantQueuesAsyncWithHttpInfo (string assistantId, string before = null, string after = null, string pageSize = null, string expand = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->GetAssistantQueues");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueListing>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all assistants. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Return the assistant by the given name. (optional)</param>
        /// <returns>AssistantListing</returns>
        
        public AssistantListing GetAssistants (string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        {
             ApiResponse<AssistantListing> localVarResponse = GetAssistantsWithHttpInfo(before, after, limit, pageSize, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all assistants. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Return the assistant by the given name. (optional)</param>
        /// <returns>ApiResponse of AssistantListing</returns>
        
        public ApiResponse< AssistantListing > GetAssistantsWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        { 

            var localVarPath = "/api/v2/assistants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantListing>(localVarStatusCode,
                localVarHeaders,
                (AssistantListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all assistants. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Return the assistant by the given name. (optional)</param>
        /// <returns>Task of AssistantListing</returns>
        
        public async System.Threading.Tasks.Task<AssistantListing> GetAssistantsAsync (string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        {
             ApiResponse<AssistantListing> localVarResponse = await GetAssistantsAsyncWithHttpInfo(before, after, limit, pageSize, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all assistants. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="limit">Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="name">Return the assistant by the given name. (optional)</param>
        /// <returns>Task of ApiResponse (AssistantListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantListing>> GetAssistantsAsyncWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null)
        { 

            var localVarPath = "/api/v2/assistants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantListing>(localVarStatusCode,
                localVarHeaders,
                (AssistantListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all queues assigned to any assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be retrieved. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>AssistantQueueListing</returns>
        
        public AssistantQueueListing GetAssistantsQueues (string before = null, string after = null, string pageSize = null, string queueIds = null, string expand = null)
        {
             ApiResponse<AssistantQueueListing> localVarResponse = GetAssistantsQueuesWithHttpInfo(before, after, pageSize, queueIds, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all queues assigned to any assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be retrieved. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of AssistantQueueListing</returns>
        
        public ApiResponse< AssistantQueueListing > GetAssistantsQueuesWithHttpInfo (string before = null, string after = null, string pageSize = null, string queueIds = null, string expand = null)
        { 

            var localVarPath = "/api/v2/assistants/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (queueIds != null) localVarQueryParams.Add(new Tuple<string, string>("queueIds", this.Configuration.ApiClient.ParameterToString(queueIds)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueListing>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all queues assigned to any assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be retrieved. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of AssistantQueueListing</returns>
        
        public async System.Threading.Tasks.Task<AssistantQueueListing> GetAssistantsQueuesAsync (string before = null, string after = null, string pageSize = null, string queueIds = null, string expand = null)
        {
             ApiResponse<AssistantQueueListing> localVarResponse = await GetAssistantsQueuesAsyncWithHttpInfo(before, after, pageSize, queueIds, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all queues assigned to any assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="queueIds">Comma-separated identifiers of the queues that need to be retrieved. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (AssistantQueueListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantQueueListing>> GetAssistantsQueuesAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, string queueIds = null, string expand = null)
        { 

            var localVarPath = "/api/v2/assistants/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (queueIds != null) localVarQueryParams.Add(new Tuple<string, string>("queueIds", this.Configuration.ApiClient.ParameterToString(queueIds)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .GroupBy(header => header.GetType().GetProperty("Name")?.GetValue(header))
                                                             .Select(header => new
                                                         {
                                                            Name = header.First().GetType().GetProperty("Name")?.GetValue(header.First()),
                                                            Value = header.Select(x => x.GetType().GetProperty("Value")?.GetValue(x)).ToList()
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => String.Join(", ", header?.Value?.ToArray())) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueListing>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Assistant</returns>
        
        public Assistant PatchAssistant (string assistantId, Assistant body)
        {
             ApiResponse<Assistant> localVarResponse = PatchAssistantWithHttpInfo(assistantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Assistant</returns>
        
        public ApiResponse< Assistant > PatchAssistantWithHttpInfo (string assistantId, Assistant body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PatchAssistant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PatchAssistant");

            var localVarPath = "/api/v2/assistants/{assistantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchAssistant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAssistant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Assistant>(localVarStatusCode,
                localVarHeaders,
                (Assistant) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Assistant)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Assistant</returns>
        
        public async System.Threading.Tasks.Task<Assistant> PatchAssistantAsync (string assistantId, Assistant body)
        {
             ApiResponse<Assistant> localVarResponse = await PatchAssistantAsyncWithHttpInfo(assistantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Assistant)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Assistant>> PatchAssistantAsyncWithHttpInfo (string assistantId, Assistant body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PatchAssistant");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PatchAssistant");
            

            var localVarPath = "/api/v2/assistants/{assistantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchAssistant: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAssistant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Assistant>(localVarStatusCode,
                localVarHeaders,
                (Assistant) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Assistant)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update Queues for an Assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>AssistantQueueListing</returns>
        
        public AssistantQueueListing PatchAssistantQueues (string assistantId, List<AssistantQueue> body)
        {
             ApiResponse<AssistantQueueListing> localVarResponse = PatchAssistantQueuesWithHttpInfo(assistantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Queues for an Assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AssistantQueueListing</returns>
        
        public ApiResponse< AssistantQueueListing > PatchAssistantQueuesWithHttpInfo (string assistantId, List<AssistantQueue> body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PatchAssistantQueues");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PatchAssistantQueues");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchAssistantQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAssistantQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueListing>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update Queues for an Assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AssistantQueueListing</returns>
        
        public async System.Threading.Tasks.Task<AssistantQueueListing> PatchAssistantQueuesAsync (string assistantId, List<AssistantQueue> body)
        {
             ApiResponse<AssistantQueueListing> localVarResponse = await PatchAssistantQueuesAsyncWithHttpInfo(assistantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Queues for an Assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AssistantQueueListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantQueueListing>> PatchAssistantQueuesAsyncWithHttpInfo (string assistantId, List<AssistantQueue> body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PatchAssistantQueues");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PatchAssistantQueues");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchAssistantQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchAssistantQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueListing>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an Assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Assistant</returns>
        
        public Assistant PostAssistants (Assistant body)
        {
             ApiResponse<Assistant> localVarResponse = PostAssistantsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an Assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Assistant</returns>
        
        public ApiResponse< Assistant > PostAssistantsWithHttpInfo (Assistant body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistants");

            var localVarPath = "/api/v2/assistants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PostAssistants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Assistant>(localVarStatusCode,
                localVarHeaders,
                (Assistant) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Assistant)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an Assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Assistant</returns>
        
        public async System.Threading.Tasks.Task<Assistant> PostAssistantsAsync (Assistant body)
        {
             ApiResponse<Assistant> localVarResponse = await PostAssistantsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an Assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Assistant)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Assistant>> PostAssistantsAsyncWithHttpInfo (Assistant body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistants");
            

            var localVarPath = "/api/v2/assistants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                throw new ApiException (localVarStatusCode, "Error calling PostAssistants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Assistant>(localVarStatusCode,
                localVarHeaders,
                (Assistant) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Assistant)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a queue assistant association. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>AssistantQueue</returns>
        
        public AssistantQueue PutAssistantQueue (string assistantId, string queueId, AssistantQueue body)
        {
             ApiResponse<AssistantQueue> localVarResponse = PutAssistantQueueWithHttpInfo(assistantId, queueId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a queue assistant association. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AssistantQueue</returns>
        
        public ApiResponse< AssistantQueue > PutAssistantQueueWithHttpInfo (string assistantId, string queueId, AssistantQueue body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PutAssistantQueue");
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->PutAssistantQueue");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PutAssistantQueue");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (queueId != null) localVarPathParams.Add("queueId", this.Configuration.ApiClient.ParameterToString(queueId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantQueue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantQueue: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueue>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueue) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueue)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a queue assistant association. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AssistantQueue</returns>
        
        public async System.Threading.Tasks.Task<AssistantQueue> PutAssistantQueueAsync (string assistantId, string queueId, AssistantQueue body)
        {
             ApiResponse<AssistantQueue> localVarResponse = await PutAssistantQueueAsyncWithHttpInfo(assistantId, queueId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a queue assistant association. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AssistantQueue)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantQueue>> PutAssistantQueueAsyncWithHttpInfo (string assistantId, string queueId, AssistantQueue body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PutAssistantQueue");
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->PutAssistantQueue");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PutAssistantQueue");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (queueId != null) localVarPathParams.Add("queueId", this.Configuration.ApiClient.ParameterToString(queueId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantQueue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantQueue: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueue>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueue) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueue)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
