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
        /// Delete an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns></returns>
        
        void DeleteAssistantsAgentchecklist (string agentChecklistId);

        /// <summary>
        /// Delete an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteAssistantsAgentchecklistWithHttpInfo (string agentChecklistId);

        /// <summary>
        /// Get an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="languageVariation">Language variation (optional)</param>
        /// <param name="fallbackToPrimaryAssistant">Fall back to primary assistant if specified variation is not found (optional)</param>
        /// <returns>Assistant</returns>
        
        Assistant GetAssistant (string assistantId, string expand = null, string languageVariation = null, bool? fallbackToPrimaryAssistant = null);

        /// <summary>
        /// Get an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="languageVariation">Language variation (optional)</param>
        /// <param name="fallbackToPrimaryAssistant">Fall back to primary assistant if specified variation is not found (optional)</param>
        /// <returns>ApiResponse of Assistant</returns>
        
        ApiResponse<Assistant> GetAssistantWithHttpInfo (string assistantId, string expand = null, string languageVariation = null, bool? fallbackToPrimaryAssistant = null);

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
        /// Get job details.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>AssistantQueueUsersJobsResponse</returns>
        
        AssistantQueueUsersJobsResponse GetAssistantQueueUsersJob (string assistantId, string queueId, string jobId);

        /// <summary>
        /// Get job details.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of AssistantQueueUsersJobsResponse</returns>
        
        ApiResponse<AssistantQueueUsersJobsResponse> GetAssistantQueueUsersJobWithHttpInfo (string assistantId, string queueId, string jobId);

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
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>AssistantListing</returns>
        
        AssistantListing GetAssistants (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string expand = null);

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
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of AssistantListing</returns>
        
        ApiResponse<AssistantListing> GetAssistantsWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string expand = null);

        /// <summary>
        /// Get an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>AgentChecklist</returns>
        
        AgentChecklist GetAssistantsAgentchecklist (string agentChecklistId);

        /// <summary>
        /// Get an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>ApiResponse of AgentChecklist</returns>
        
        ApiResponse<AgentChecklist> GetAssistantsAgentchecklistWithHttpInfo (string agentChecklistId);

        /// <summary>
        /// Get the list of agent checklists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to "25")</param>
        /// <param name="namePrefix">The agent checklist name prefix filter applied to the listing. (optional)</param>
        /// <param name="language">The agent checklist language filter applied to the listing. (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional)</param>
        /// <param name="sortBy">The field to sort by for the listing. (optional)</param>
        /// <returns>AgentChecklistListing</returns>
        
        AgentChecklistListing GetAssistantsAgentchecklists (string before = null, string after = null, string pageSize = null, string namePrefix = null, string language = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get the list of agent checklists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to "25")</param>
        /// <param name="namePrefix">The agent checklist name prefix filter applied to the listing. (optional)</param>
        /// <param name="language">The agent checklist language filter applied to the listing. (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional)</param>
        /// <param name="sortBy">The field to sort by for the listing. (optional)</param>
        /// <returns>ApiResponse of AgentChecklistListing</returns>
        
        ApiResponse<AgentChecklistListing> GetAssistantsAgentchecklistsWithHttpInfo (string before = null, string after = null, string pageSize = null, string namePrefix = null, string language = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get the list of supported languages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EntityListing</returns>
        
        EntityListing GetAssistantsAgentchecklistsLanguages ();

        /// <summary>
        /// Get the list of supported languages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EntityListing</returns>
        
        ApiResponse<EntityListing> GetAssistantsAgentchecklistsLanguagesWithHttpInfo ();

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
        /// Bulk add users to assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>BulkResponse</returns>
        
        BulkResponse PostAssistantQueueUsersBulkAdd (string assistantId, string queueId, AssistantQueueUsersBulkAddRequest body);

        /// <summary>
        /// Bulk add users to assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of BulkResponse</returns>
        
        ApiResponse<BulkResponse> PostAssistantQueueUsersBulkAddWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersBulkAddRequest body);

        /// <summary>
        /// Bulk remove users from assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>BulkResponse</returns>
        
        BulkResponse PostAssistantQueueUsersBulkRemove (string assistantId, string queueId, AssistantQueueUsersBulkRemoveRequest body);

        /// <summary>
        /// Bulk remove users from assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of BulkResponse</returns>
        
        ApiResponse<BulkResponse> PostAssistantQueueUsersBulkRemoveWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersBulkRemoveRequest body);

        /// <summary>
        /// Start a new job to assistant-queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>AssistantQueueUsersJobsResponse</returns>
        
        AssistantQueueUsersJobsResponse PostAssistantQueueUsersJobs (string assistantId, string queueId, AssistantQueueUsersJobsRequest body);

        /// <summary>
        /// Start a new job to assistant-queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AssistantQueueUsersJobsResponse</returns>
        
        ApiResponse<AssistantQueueUsersJobsResponse> PostAssistantQueueUsersJobsWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersJobsRequest body);

        /// <summary>
        /// Query for users in the assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <param name="expand">Which fields, if any, to expand with. (optional)</param>
        /// <returns>AssistantQueueUsersQueryResponse</returns>
        
        AssistantQueueUsersQueryResponse PostAssistantQueueUsersQuery (string assistantId, string queueId, AssistantQueueUsersQueryRequest body, List<string> expand = null);

        /// <summary>
        /// Query for users in the assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <param name="expand">Which fields, if any, to expand with. (optional)</param>
        /// <returns>ApiResponse of AssistantQueueUsersQueryResponse</returns>
        
        ApiResponse<AssistantQueueUsersQueryResponse> PostAssistantQueueUsersQueryWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersQueryRequest body, List<string> expand = null);

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
        /// Create an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing details of checklist to be added</param>
        /// <returns>AgentChecklist</returns>
        
        AgentChecklist PostAssistantsAgentchecklists (AgentChecklist body);

        /// <summary>
        /// Create an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing details of checklist to be added</param>
        /// <returns>ApiResponse of AgentChecklist</returns>
        
        ApiResponse<AgentChecklist> PostAssistantsAgentchecklistsWithHttpInfo (AgentChecklist body);

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

        /// <summary>
        /// Update an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <param name="body">Request body containing details of checklist to be updated</param>
        /// <returns>AgentChecklist</returns>
        
        AgentChecklist PutAssistantsAgentchecklist (string agentChecklistId, AgentChecklist body);

        /// <summary>
        /// Update an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <param name="body">Request body containing details of checklist to be updated</param>
        /// <returns>ApiResponse of AgentChecklist</returns>
        
        ApiResponse<AgentChecklist> PutAssistantsAgentchecklistWithHttpInfo (string agentChecklistId, AgentChecklist body);

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
        /// Delete an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteAssistantsAgentchecklistAsync (string agentChecklistId);

        /// <summary>
        /// Delete an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssistantsAgentchecklistAsyncWithHttpInfo (string agentChecklistId);

        /// <summary>
        /// Get an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="languageVariation">Language variation (optional)</param>
        /// <param name="fallbackToPrimaryAssistant">Fall back to primary assistant if specified variation is not found (optional)</param>
        /// <returns>Task of Assistant</returns>
        
        System.Threading.Tasks.Task<Assistant> GetAssistantAsync (string assistantId, string expand = null, string languageVariation = null, bool? fallbackToPrimaryAssistant = null);

        /// <summary>
        /// Get an assistant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="languageVariation">Language variation (optional)</param>
        /// <param name="fallbackToPrimaryAssistant">Fall back to primary assistant if specified variation is not found (optional)</param>
        /// <returns>Task of ApiResponse (Assistant)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Assistant>> GetAssistantAsyncWithHttpInfo (string assistantId, string expand = null, string languageVariation = null, bool? fallbackToPrimaryAssistant = null);

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
        /// Get job details.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of AssistantQueueUsersJobsResponse</returns>
        
        System.Threading.Tasks.Task<AssistantQueueUsersJobsResponse> GetAssistantQueueUsersJobAsync (string assistantId, string queueId, string jobId);

        /// <summary>
        /// Get job details.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (AssistantQueueUsersJobsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantQueueUsersJobsResponse>> GetAssistantQueueUsersJobAsyncWithHttpInfo (string assistantId, string queueId, string jobId);

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
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of AssistantListing</returns>
        
        System.Threading.Tasks.Task<AssistantListing> GetAssistantsAsync (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string expand = null);

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
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (AssistantListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantListing>> GetAssistantsAsyncWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string expand = null);

        /// <summary>
        /// Get an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>Task of AgentChecklist</returns>
        
        System.Threading.Tasks.Task<AgentChecklist> GetAssistantsAgentchecklistAsync (string agentChecklistId);

        /// <summary>
        /// Get an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>Task of ApiResponse (AgentChecklist)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgentChecklist>> GetAssistantsAgentchecklistAsyncWithHttpInfo (string agentChecklistId);

        /// <summary>
        /// Get the list of agent checklists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to "25")</param>
        /// <param name="namePrefix">The agent checklist name prefix filter applied to the listing. (optional)</param>
        /// <param name="language">The agent checklist language filter applied to the listing. (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional)</param>
        /// <param name="sortBy">The field to sort by for the listing. (optional)</param>
        /// <returns>Task of AgentChecklistListing</returns>
        
        System.Threading.Tasks.Task<AgentChecklistListing> GetAssistantsAgentchecklistsAsync (string before = null, string after = null, string pageSize = null, string namePrefix = null, string language = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get the list of agent checklists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to "25")</param>
        /// <param name="namePrefix">The agent checklist name prefix filter applied to the listing. (optional)</param>
        /// <param name="language">The agent checklist language filter applied to the listing. (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional)</param>
        /// <param name="sortBy">The field to sort by for the listing. (optional)</param>
        /// <returns>Task of ApiResponse (AgentChecklistListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgentChecklistListing>> GetAssistantsAgentchecklistsAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, string namePrefix = null, string language = null, string sortOrder = null, string sortBy = null);

        /// <summary>
        /// Get the list of supported languages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EntityListing</returns>
        
        System.Threading.Tasks.Task<EntityListing> GetAssistantsAgentchecklistsLanguagesAsync ();

        /// <summary>
        /// Get the list of supported languages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EntityListing>> GetAssistantsAgentchecklistsLanguagesAsyncWithHttpInfo ();

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
        /// Bulk add users to assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of BulkResponse</returns>
        
        System.Threading.Tasks.Task<BulkResponse> PostAssistantQueueUsersBulkAddAsync (string assistantId, string queueId, AssistantQueueUsersBulkAddRequest body);

        /// <summary>
        /// Bulk add users to assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (BulkResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkResponse>> PostAssistantQueueUsersBulkAddAsyncWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersBulkAddRequest body);

        /// <summary>
        /// Bulk remove users from assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of BulkResponse</returns>
        
        System.Threading.Tasks.Task<BulkResponse> PostAssistantQueueUsersBulkRemoveAsync (string assistantId, string queueId, AssistantQueueUsersBulkRemoveRequest body);

        /// <summary>
        /// Bulk remove users from assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (BulkResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<BulkResponse>> PostAssistantQueueUsersBulkRemoveAsyncWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersBulkRemoveRequest body);

        /// <summary>
        /// Start a new job to assistant-queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AssistantQueueUsersJobsResponse</returns>
        
        System.Threading.Tasks.Task<AssistantQueueUsersJobsResponse> PostAssistantQueueUsersJobsAsync (string assistantId, string queueId, AssistantQueueUsersJobsRequest body);

        /// <summary>
        /// Start a new job to assistant-queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AssistantQueueUsersJobsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantQueueUsersJobsResponse>> PostAssistantQueueUsersJobsAsyncWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersJobsRequest body);

        /// <summary>
        /// Query for users in the assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <param name="expand">Which fields, if any, to expand with. (optional)</param>
        /// <returns>Task of AssistantQueueUsersQueryResponse</returns>
        
        System.Threading.Tasks.Task<AssistantQueueUsersQueryResponse> PostAssistantQueueUsersQueryAsync (string assistantId, string queueId, AssistantQueueUsersQueryRequest body, List<string> expand = null);

        /// <summary>
        /// Query for users in the assistant-queue (requires manual assignment mode).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <param name="expand">Which fields, if any, to expand with. (optional)</param>
        /// <returns>Task of ApiResponse (AssistantQueueUsersQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AssistantQueueUsersQueryResponse>> PostAssistantQueueUsersQueryAsyncWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersQueryRequest body, List<string> expand = null);

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
        /// Create an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing details of checklist to be added</param>
        /// <returns>Task of AgentChecklist</returns>
        
        System.Threading.Tasks.Task<AgentChecklist> PostAssistantsAgentchecklistsAsync (AgentChecklist body);

        /// <summary>
        /// Create an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing details of checklist to be added</param>
        /// <returns>Task of ApiResponse (AgentChecklist)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgentChecklist>> PostAssistantsAgentchecklistsAsyncWithHttpInfo (AgentChecklist body);

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

        /// <summary>
        /// Update an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <param name="body">Request body containing details of checklist to be updated</param>
        /// <returns>Task of AgentChecklist</returns>
        
        System.Threading.Tasks.Task<AgentChecklist> PutAssistantsAgentchecklistAsync (string agentChecklistId, AgentChecklist body);

        /// <summary>
        /// Update an agent checklist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <param name="body">Request body containing details of checklist to be updated</param>
        /// <returns>Task of ApiResponse (AgentChecklist)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgentChecklist>> PutAssistantsAgentchecklistAsyncWithHttpInfo (string agentChecklistId, AgentChecklist body);

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Delete an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns></returns>
        
        public void DeleteAssistantsAgentchecklist (string agentChecklistId)
        {
             DeleteAssistantsAgentchecklistWithHttpInfo(agentChecklistId);
        }

        /// <summary>
        /// Delete an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteAssistantsAgentchecklistWithHttpInfo (string agentChecklistId)
        { 
            // verify the required parameter 'agentChecklistId' is set
            if (agentChecklistId == null)
                throw new ApiException(400, "Missing required parameter 'agentChecklistId' when calling AgentAssistantsApi->DeleteAssistantsAgentchecklist");

            var localVarPath = "/api/v2/assistants/agentchecklists/{agentChecklistId}";
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
            if (agentChecklistId != null) localVarPathParams.Add("agentChecklistId", this.Configuration.ApiClient.ParameterToString(agentChecklistId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantsAgentchecklist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantsAgentchecklist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteAssistantsAgentchecklistAsync (string agentChecklistId)
        {
             await DeleteAssistantsAgentchecklistAsyncWithHttpInfo(agentChecklistId);

        }

        /// <summary>
        /// Delete an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssistantsAgentchecklistAsyncWithHttpInfo (string agentChecklistId)
        { 
            // verify the required parameter 'agentChecklistId' is set
            if (agentChecklistId == null)
                throw new ApiException(400, "Missing required parameter 'agentChecklistId' when calling AgentAssistantsApi->DeleteAssistantsAgentchecklist");
            

            var localVarPath = "/api/v2/assistants/agentchecklists/{agentChecklistId}";
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
            if (agentChecklistId != null) localVarPathParams.Add("agentChecklistId", this.Configuration.ApiClient.ParameterToString(agentChecklistId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantsAgentchecklist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAssistantsAgentchecklist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="languageVariation">Language variation (optional)</param>
        /// <param name="fallbackToPrimaryAssistant">Fall back to primary assistant if specified variation is not found (optional)</param>
        /// <returns>Assistant</returns>
        
        public Assistant GetAssistant (string assistantId, string expand = null, string languageVariation = null, bool? fallbackToPrimaryAssistant = null)
        {
             ApiResponse<Assistant> localVarResponse = GetAssistantWithHttpInfo(assistantId, expand, languageVariation, fallbackToPrimaryAssistant);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="languageVariation">Language variation (optional)</param>
        /// <param name="fallbackToPrimaryAssistant">Fall back to primary assistant if specified variation is not found (optional)</param>
        /// <returns>ApiResponse of Assistant</returns>
        
        public ApiResponse< Assistant > GetAssistantWithHttpInfo (string assistantId, string expand = null, string languageVariation = null, bool? fallbackToPrimaryAssistant = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->GetAssistant");

            var localVarPath = "/api/v2/assistants/{assistantId}";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (languageVariation != null) localVarQueryParams.Add(new Tuple<string, string>("languageVariation", this.Configuration.ApiClient.ParameterToString(languageVariation)));
            if (fallbackToPrimaryAssistant != null) localVarQueryParams.Add(new Tuple<string, string>("fallbackToPrimaryAssistant", this.Configuration.ApiClient.ParameterToString(fallbackToPrimaryAssistant)));

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
        /// <param name="languageVariation">Language variation (optional)</param>
        /// <param name="fallbackToPrimaryAssistant">Fall back to primary assistant if specified variation is not found (optional)</param>
        /// <returns>Task of Assistant</returns>
        
        public async System.Threading.Tasks.Task<Assistant> GetAssistantAsync (string assistantId, string expand = null, string languageVariation = null, bool? fallbackToPrimaryAssistant = null)
        {
             ApiResponse<Assistant> localVarResponse = await GetAssistantAsyncWithHttpInfo(assistantId, expand, languageVariation, fallbackToPrimaryAssistant);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an assistant. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="languageVariation">Language variation (optional)</param>
        /// <param name="fallbackToPrimaryAssistant">Fall back to primary assistant if specified variation is not found (optional)</param>
        /// <returns>Task of ApiResponse (Assistant)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Assistant>> GetAssistantAsyncWithHttpInfo (string assistantId, string expand = null, string languageVariation = null, bool? fallbackToPrimaryAssistant = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->GetAssistant");
            

            var localVarPath = "/api/v2/assistants/{assistantId}";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (languageVariation != null) localVarQueryParams.Add(new Tuple<string, string>("languageVariation", this.Configuration.ApiClient.ParameterToString(languageVariation)));
            if (fallbackToPrimaryAssistant != null) localVarQueryParams.Add(new Tuple<string, string>("fallbackToPrimaryAssistant", this.Configuration.ApiClient.ParameterToString(fallbackToPrimaryAssistant)));

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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Get job details. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>AssistantQueueUsersJobsResponse</returns>
        
        public AssistantQueueUsersJobsResponse GetAssistantQueueUsersJob (string assistantId, string queueId, string jobId)
        {
             ApiResponse<AssistantQueueUsersJobsResponse> localVarResponse = GetAssistantQueueUsersJobWithHttpInfo(assistantId, queueId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get job details. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of AssistantQueueUsersJobsResponse</returns>
        
        public ApiResponse< AssistantQueueUsersJobsResponse > GetAssistantQueueUsersJobWithHttpInfo (string assistantId, string queueId, string jobId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->GetAssistantQueueUsersJob");
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->GetAssistantQueueUsersJob");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling AgentAssistantsApi->GetAssistantQueueUsersJob");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}/users/jobs/{jobId}";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (queueId != null) localVarPathParams.Add("queueId", this.Configuration.ApiClient.ParameterToString(queueId));
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueueUsersJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueueUsersJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueUsersJobsResponse>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueUsersJobsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueUsersJobsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get job details. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of AssistantQueueUsersJobsResponse</returns>
        
        public async System.Threading.Tasks.Task<AssistantQueueUsersJobsResponse> GetAssistantQueueUsersJobAsync (string assistantId, string queueId, string jobId)
        {
             ApiResponse<AssistantQueueUsersJobsResponse> localVarResponse = await GetAssistantQueueUsersJobAsyncWithHttpInfo(assistantId, queueId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get job details. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (AssistantQueueUsersJobsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantQueueUsersJobsResponse>> GetAssistantQueueUsersJobAsyncWithHttpInfo (string assistantId, string queueId, string jobId)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->GetAssistantQueueUsersJob");
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->GetAssistantQueueUsersJob");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling AgentAssistantsApi->GetAssistantQueueUsersJob");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}/users/jobs/{jobId}";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (queueId != null) localVarPathParams.Add("queueId", this.Configuration.ApiClient.ParameterToString(queueId));
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueueUsersJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantQueueUsersJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueUsersJobsResponse>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueUsersJobsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueUsersJobsResponse)),
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>AssistantListing</returns>
        
        public AssistantListing GetAssistants (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string expand = null)
        {
             ApiResponse<AssistantListing> localVarResponse = GetAssistantsWithHttpInfo(before, after, limit, pageSize, name, expand);
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
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of AssistantListing</returns>
        
        public ApiResponse< AssistantListing > GetAssistantsWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string expand = null)
        { 

            var localVarPath = "/api/v2/assistants";
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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of AssistantListing</returns>
        
        public async System.Threading.Tasks.Task<AssistantListing> GetAssistantsAsync (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string expand = null)
        {
             ApiResponse<AssistantListing> localVarResponse = await GetAssistantsAsyncWithHttpInfo(before, after, limit, pageSize, name, expand);
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
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (AssistantListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantListing>> GetAssistantsAsyncWithHttpInfo (string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string expand = null)
        { 

            var localVarPath = "/api/v2/assistants";
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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (limit != null) localVarQueryParams.Add(new Tuple<string, string>("limit", this.Configuration.ApiClient.ParameterToString(limit)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Get an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>AgentChecklist</returns>
        
        public AgentChecklist GetAssistantsAgentchecklist (string agentChecklistId)
        {
             ApiResponse<AgentChecklist> localVarResponse = GetAssistantsAgentchecklistWithHttpInfo(agentChecklistId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>ApiResponse of AgentChecklist</returns>
        
        public ApiResponse< AgentChecklist > GetAssistantsAgentchecklistWithHttpInfo (string agentChecklistId)
        { 
            // verify the required parameter 'agentChecklistId' is set
            if (agentChecklistId == null)
                throw new ApiException(400, "Missing required parameter 'agentChecklistId' when calling AgentAssistantsApi->GetAssistantsAgentchecklist");

            var localVarPath = "/api/v2/assistants/agentchecklists/{agentChecklistId}";
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
            if (agentChecklistId != null) localVarPathParams.Add("agentChecklistId", this.Configuration.ApiClient.ParameterToString(agentChecklistId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentChecklist>(localVarStatusCode,
                localVarHeaders,
                (AgentChecklist) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentChecklist)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>Task of AgentChecklist</returns>
        
        public async System.Threading.Tasks.Task<AgentChecklist> GetAssistantsAgentchecklistAsync (string agentChecklistId)
        {
             ApiResponse<AgentChecklist> localVarResponse = await GetAssistantsAgentchecklistAsyncWithHttpInfo(agentChecklistId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <returns>Task of ApiResponse (AgentChecklist)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgentChecklist>> GetAssistantsAgentchecklistAsyncWithHttpInfo (string agentChecklistId)
        { 
            // verify the required parameter 'agentChecklistId' is set
            if (agentChecklistId == null)
                throw new ApiException(400, "Missing required parameter 'agentChecklistId' when calling AgentAssistantsApi->GetAssistantsAgentchecklist");
            

            var localVarPath = "/api/v2/assistants/agentchecklists/{agentChecklistId}";
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
            if (agentChecklistId != null) localVarPathParams.Add("agentChecklistId", this.Configuration.ApiClient.ParameterToString(agentChecklistId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentChecklist>(localVarStatusCode,
                localVarHeaders,
                (AgentChecklist) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentChecklist)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of agent checklists 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to "25")</param>
        /// <param name="namePrefix">The agent checklist name prefix filter applied to the listing. (optional)</param>
        /// <param name="language">The agent checklist language filter applied to the listing. (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional)</param>
        /// <param name="sortBy">The field to sort by for the listing. (optional)</param>
        /// <returns>AgentChecklistListing</returns>
        
        public AgentChecklistListing GetAssistantsAgentchecklists (string before = null, string after = null, string pageSize = null, string namePrefix = null, string language = null, string sortOrder = null, string sortBy = null)
        {
             ApiResponse<AgentChecklistListing> localVarResponse = GetAssistantsAgentchecklistsWithHttpInfo(before, after, pageSize, namePrefix, language, sortOrder, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of agent checklists 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to "25")</param>
        /// <param name="namePrefix">The agent checklist name prefix filter applied to the listing. (optional)</param>
        /// <param name="language">The agent checklist language filter applied to the listing. (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional)</param>
        /// <param name="sortBy">The field to sort by for the listing. (optional)</param>
        /// <returns>ApiResponse of AgentChecklistListing</returns>
        
        public ApiResponse< AgentChecklistListing > GetAssistantsAgentchecklistsWithHttpInfo (string before = null, string after = null, string pageSize = null, string namePrefix = null, string language = null, string sortOrder = null, string sortBy = null)
        { 

            var localVarPath = "/api/v2/assistants/agentchecklists";
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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (namePrefix != null) localVarQueryParams.Add(new Tuple<string, string>("namePrefix", this.Configuration.ApiClient.ParameterToString(namePrefix)));
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentChecklistListing>(localVarStatusCode,
                localVarHeaders,
                (AgentChecklistListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentChecklistListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of agent checklists 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to "25")</param>
        /// <param name="namePrefix">The agent checklist name prefix filter applied to the listing. (optional)</param>
        /// <param name="language">The agent checklist language filter applied to the listing. (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional)</param>
        /// <param name="sortBy">The field to sort by for the listing. (optional)</param>
        /// <returns>Task of AgentChecklistListing</returns>
        
        public async System.Threading.Tasks.Task<AgentChecklistListing> GetAssistantsAgentchecklistsAsync (string before = null, string after = null, string pageSize = null, string namePrefix = null, string language = null, string sortOrder = null, string sortBy = null)
        {
             ApiResponse<AgentChecklistListing> localVarResponse = await GetAssistantsAgentchecklistsAsyncWithHttpInfo(before, after, pageSize, namePrefix, language, sortOrder, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of agent checklists 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">The page size for the listing. The max that will be returned is 100. (optional, default to "25")</param>
        /// <param name="namePrefix">The agent checklist name prefix filter applied to the listing. (optional)</param>
        /// <param name="language">The agent checklist language filter applied to the listing. (optional)</param>
        /// <param name="sortOrder">The sort order for the listing (optional)</param>
        /// <param name="sortBy">The field to sort by for the listing. (optional)</param>
        /// <returns>Task of ApiResponse (AgentChecklistListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgentChecklistListing>> GetAssistantsAgentchecklistsAsyncWithHttpInfo (string before = null, string after = null, string pageSize = null, string namePrefix = null, string language = null, string sortOrder = null, string sortBy = null)
        { 

            var localVarPath = "/api/v2/assistants/agentchecklists";
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
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (namePrefix != null) localVarQueryParams.Add(new Tuple<string, string>("namePrefix", this.Configuration.ApiClient.ParameterToString(namePrefix)));
            if (language != null) localVarQueryParams.Add(new Tuple<string, string>("language", this.Configuration.ApiClient.ParameterToString(language)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentChecklistListing>(localVarStatusCode,
                localVarHeaders,
                (AgentChecklistListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentChecklistListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of supported languages 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EntityListing</returns>
        
        public EntityListing GetAssistantsAgentchecklistsLanguages ()
        {
             ApiResponse<EntityListing> localVarResponse = GetAssistantsAgentchecklistsLanguagesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of supported languages 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EntityListing</returns>
        
        public ApiResponse< EntityListing > GetAssistantsAgentchecklistsLanguagesWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/assistants/agentchecklists/languages";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklistsLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklistsLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EntityListing>(localVarStatusCode,
                localVarHeaders,
                (EntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of supported languages 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EntityListing</returns>
        
        public async System.Threading.Tasks.Task<EntityListing> GetAssistantsAgentchecklistsLanguagesAsync ()
        {
             ApiResponse<EntityListing> localVarResponse = await GetAssistantsAgentchecklistsLanguagesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of supported languages 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EntityListing>> GetAssistantsAgentchecklistsLanguagesAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/assistants/agentchecklists/languages";
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
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklistsLanguages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAssistantsAgentchecklistsLanguages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EntityListing>(localVarStatusCode,
                localVarHeaders,
                (EntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EntityListing)),
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            var localVarHttpMethod = "Patch";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            var localVarHttpMethod = "Patch";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            var localVarHttpMethod = "Patch";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            var localVarHttpMethod = "Patch";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Bulk add users to assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>BulkResponse</returns>
        
        public BulkResponse PostAssistantQueueUsersBulkAdd (string assistantId, string queueId, AssistantQueueUsersBulkAddRequest body)
        {
             ApiResponse<BulkResponse> localVarResponse = PostAssistantQueueUsersBulkAddWithHttpInfo(assistantId, queueId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk add users to assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of BulkResponse</returns>
        
        public ApiResponse< BulkResponse > PostAssistantQueueUsersBulkAddWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersBulkAddRequest body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkAdd");
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkAdd");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkAdd");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}/users/bulk/add";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersBulkAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersBulkAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk add users to assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of BulkResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkResponse> PostAssistantQueueUsersBulkAddAsync (string assistantId, string queueId, AssistantQueueUsersBulkAddRequest body)
        {
             ApiResponse<BulkResponse> localVarResponse = await PostAssistantQueueUsersBulkAddAsyncWithHttpInfo(assistantId, queueId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk add users to assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (BulkResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkResponse>> PostAssistantQueueUsersBulkAddAsyncWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersBulkAddRequest body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkAdd");
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkAdd");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkAdd");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}/users/bulk/add";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersBulkAdd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersBulkAdd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Bulk remove users from assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>BulkResponse</returns>
        
        public BulkResponse PostAssistantQueueUsersBulkRemove (string assistantId, string queueId, AssistantQueueUsersBulkRemoveRequest body)
        {
             ApiResponse<BulkResponse> localVarResponse = PostAssistantQueueUsersBulkRemoveWithHttpInfo(assistantId, queueId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk remove users from assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of BulkResponse</returns>
        
        public ApiResponse< BulkResponse > PostAssistantQueueUsersBulkRemoveWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersBulkRemoveRequest body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkRemove");
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkRemove");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkRemove");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}/users/bulk/remove";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersBulkRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersBulkRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Bulk remove users from assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of BulkResponse</returns>
        
        public async System.Threading.Tasks.Task<BulkResponse> PostAssistantQueueUsersBulkRemoveAsync (string assistantId, string queueId, AssistantQueueUsersBulkRemoveRequest body)
        {
             ApiResponse<BulkResponse> localVarResponse = await PostAssistantQueueUsersBulkRemoveAsyncWithHttpInfo(assistantId, queueId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk remove users from assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (BulkResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<BulkResponse>> PostAssistantQueueUsersBulkRemoveAsyncWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersBulkRemoveRequest body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkRemove");
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkRemove");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistantQueueUsersBulkRemove");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}/users/bulk/remove";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersBulkRemove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersBulkRemove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BulkResponse>(localVarStatusCode,
                localVarHeaders,
                (BulkResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Start a new job to assistant-queue. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>AssistantQueueUsersJobsResponse</returns>
        
        public AssistantQueueUsersJobsResponse PostAssistantQueueUsersJobs (string assistantId, string queueId, AssistantQueueUsersJobsRequest body)
        {
             ApiResponse<AssistantQueueUsersJobsResponse> localVarResponse = PostAssistantQueueUsersJobsWithHttpInfo(assistantId, queueId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start a new job to assistant-queue. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AssistantQueueUsersJobsResponse</returns>
        
        public ApiResponse< AssistantQueueUsersJobsResponse > PostAssistantQueueUsersJobsWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersJobsRequest body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PostAssistantQueueUsersJobs");
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->PostAssistantQueueUsersJobs");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistantQueueUsersJobs");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}/users/jobs";
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueUsersJobsResponse>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueUsersJobsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueUsersJobsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Start a new job to assistant-queue. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of AssistantQueueUsersJobsResponse</returns>
        
        public async System.Threading.Tasks.Task<AssistantQueueUsersJobsResponse> PostAssistantQueueUsersJobsAsync (string assistantId, string queueId, AssistantQueueUsersJobsRequest body)
        {
             ApiResponse<AssistantQueueUsersJobsResponse> localVarResponse = await PostAssistantQueueUsersJobsAsyncWithHttpInfo(assistantId, queueId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start a new job to assistant-queue. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AssistantQueueUsersJobsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantQueueUsersJobsResponse>> PostAssistantQueueUsersJobsAsyncWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersJobsRequest body)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PostAssistantQueueUsersJobs");
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->PostAssistantQueueUsersJobs");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistantQueueUsersJobs");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}/users/jobs";
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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueUsersJobsResponse>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueUsersJobsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueUsersJobsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for users in the assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <param name="expand">Which fields, if any, to expand with. (optional)</param>
        /// <returns>AssistantQueueUsersQueryResponse</returns>
        
        public AssistantQueueUsersQueryResponse PostAssistantQueueUsersQuery (string assistantId, string queueId, AssistantQueueUsersQueryRequest body, List<string> expand = null)
        {
             ApiResponse<AssistantQueueUsersQueryResponse> localVarResponse = PostAssistantQueueUsersQueryWithHttpInfo(assistantId, queueId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for users in the assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <param name="expand">Which fields, if any, to expand with. (optional)</param>
        /// <returns>ApiResponse of AssistantQueueUsersQueryResponse</returns>
        
        public ApiResponse< AssistantQueueUsersQueryResponse > PostAssistantQueueUsersQueryWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersQueryRequest body, List<string> expand = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PostAssistantQueueUsersQuery");
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->PostAssistantQueueUsersQuery");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistantQueueUsersQuery");

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}/users/query";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (queueId != null) localVarPathParams.Add("queueId", this.Configuration.ApiClient.ParameterToString(queueId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueUsersQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueUsersQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueUsersQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for users in the assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <param name="expand">Which fields, if any, to expand with. (optional)</param>
        /// <returns>Task of AssistantQueueUsersQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<AssistantQueueUsersQueryResponse> PostAssistantQueueUsersQueryAsync (string assistantId, string queueId, AssistantQueueUsersQueryRequest body, List<string> expand = null)
        {
             ApiResponse<AssistantQueueUsersQueryResponse> localVarResponse = await PostAssistantQueueUsersQueryAsyncWithHttpInfo(assistantId, queueId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for users in the assistant-queue (requires manual assignment mode). 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assistantId">Assistant ID</param>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body"></param>
        /// <param name="expand">Which fields, if any, to expand with. (optional)</param>
        /// <returns>Task of ApiResponse (AssistantQueueUsersQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AssistantQueueUsersQueryResponse>> PostAssistantQueueUsersQueryAsyncWithHttpInfo (string assistantId, string queueId, AssistantQueueUsersQueryRequest body, List<string> expand = null)
        { 
            // verify the required parameter 'assistantId' is set
            if (assistantId == null)
                throw new ApiException(400, "Missing required parameter 'assistantId' when calling AgentAssistantsApi->PostAssistantQueueUsersQuery");
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling AgentAssistantsApi->PostAssistantQueueUsersQuery");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistantQueueUsersQuery");
            

            var localVarPath = "/api/v2/assistants/{assistantId}/queues/{queueId}/users/query";
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
            if (assistantId != null) localVarPathParams.Add("assistantId", this.Configuration.ApiClient.ParameterToString(assistantId));
            if (queueId != null) localVarPathParams.Add("queueId", this.Configuration.ApiClient.ParameterToString(queueId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantQueueUsersQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssistantQueueUsersQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AssistantQueueUsersQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssistantQueueUsersQueryResponse)),
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
        /// Create an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing details of checklist to be added</param>
        /// <returns>AgentChecklist</returns>
        
        public AgentChecklist PostAssistantsAgentchecklists (AgentChecklist body)
        {
             ApiResponse<AgentChecklist> localVarResponse = PostAssistantsAgentchecklistsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing details of checklist to be added</param>
        /// <returns>ApiResponse of AgentChecklist</returns>
        
        public ApiResponse< AgentChecklist > PostAssistantsAgentchecklistsWithHttpInfo (AgentChecklist body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistantsAgentchecklists");

            var localVarPath = "/api/v2/assistants/agentchecklists";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantsAgentchecklists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantsAgentchecklists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentChecklist>(localVarStatusCode,
                localVarHeaders,
                (AgentChecklist) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentChecklist)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing details of checklist to be added</param>
        /// <returns>Task of AgentChecklist</returns>
        
        public async System.Threading.Tasks.Task<AgentChecklist> PostAssistantsAgentchecklistsAsync (AgentChecklist body)
        {
             ApiResponse<AgentChecklist> localVarResponse = await PostAssistantsAgentchecklistsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Request body containing details of checklist to be added</param>
        /// <returns>Task of ApiResponse (AgentChecklist)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgentChecklist>> PostAssistantsAgentchecklistsAsyncWithHttpInfo (AgentChecklist body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PostAssistantsAgentchecklists");
            

            var localVarPath = "/api/v2/assistants/agentchecklists";
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
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantsAgentchecklists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAssistantsAgentchecklists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentChecklist>(localVarStatusCode,
                localVarHeaders,
                (AgentChecklist) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentChecklist)),
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
            IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
            IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType) as IHttpResponse;

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

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
        /// Update an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <param name="body">Request body containing details of checklist to be updated</param>
        /// <returns>AgentChecklist</returns>
        
        public AgentChecklist PutAssistantsAgentchecklist (string agentChecklistId, AgentChecklist body)
        {
             ApiResponse<AgentChecklist> localVarResponse = PutAssistantsAgentchecklistWithHttpInfo(agentChecklistId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <param name="body">Request body containing details of checklist to be updated</param>
        /// <returns>ApiResponse of AgentChecklist</returns>
        
        public ApiResponse< AgentChecklist > PutAssistantsAgentchecklistWithHttpInfo (string agentChecklistId, AgentChecklist body)
        { 
            // verify the required parameter 'agentChecklistId' is set
            if (agentChecklistId == null)
                throw new ApiException(400, "Missing required parameter 'agentChecklistId' when calling AgentAssistantsApi->PutAssistantsAgentchecklist");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PutAssistantsAgentchecklist");

            var localVarPath = "/api/v2/assistants/agentchecklists/{agentChecklistId}";
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
            if (agentChecklistId != null) localVarPathParams.Add("agentChecklistId", this.Configuration.ApiClient.ParameterToString(agentChecklistId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantsAgentchecklist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantsAgentchecklist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentChecklist>(localVarStatusCode,
                localVarHeaders,
                (AgentChecklist) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentChecklist)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <param name="body">Request body containing details of checklist to be updated</param>
        /// <returns>Task of AgentChecklist</returns>
        
        public async System.Threading.Tasks.Task<AgentChecklist> PutAssistantsAgentchecklistAsync (string agentChecklistId, AgentChecklist body)
        {
             ApiResponse<AgentChecklist> localVarResponse = await PutAssistantsAgentchecklistAsyncWithHttpInfo(agentChecklistId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an agent checklist 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agentChecklistId">Agent Checklist ID</param>
        /// <param name="body">Request body containing details of checklist to be updated</param>
        /// <returns>Task of ApiResponse (AgentChecklist)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgentChecklist>> PutAssistantsAgentchecklistAsyncWithHttpInfo (string agentChecklistId, AgentChecklist body)
        { 
            // verify the required parameter 'agentChecklistId' is set
            if (agentChecklistId == null)
                throw new ApiException(400, "Missing required parameter 'agentChecklistId' when calling AgentAssistantsApi->PutAssistantsAgentchecklist");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AgentAssistantsApi->PutAssistantsAgentchecklist");
            

            var localVarPath = "/api/v2/assistants/agentchecklists/{agentChecklistId}";
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
            if (agentChecklistId != null) localVarPathParams.Add("agentChecklistId", this.Configuration.ApiClient.ParameterToString(agentChecklistId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantsAgentchecklist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAssistantsAgentchecklist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentChecklist>(localVarStatusCode,
                localVarHeaders,
                (AgentChecklist) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentChecklist)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
