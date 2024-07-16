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
    public interface IQualityApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        
        Calibration DeleteQualityCalibration (string calibrationId, string calibratorId);

        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        
        ApiResponse<Calibration> DeleteQualityCalibrationWithHttpInfo (string calibrationId, string calibratorId);

        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId, evaluationForm (optional)</param>
        /// <returns>EvaluationResponse</returns>
        
        EvaluationResponse DeleteQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId, evaluationForm (optional)</param>
        /// <returns>ApiResponse of EvaluationResponse</returns>
        
        ApiResponse<EvaluationResponse> DeleteQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns></returns>
        [Obsolete]
        void DeleteQualityForm (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        [Obsolete]
        ApiResponse<Object> DeleteQualityFormWithHttpInfo (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns></returns>
        
        void DeleteQualityFormsEvaluation (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteQualityFormsEvaluationWithHttpInfo (string formId);

        /// <summary>
        /// Delete a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns></returns>
        
        void DeleteQualityFormsSurvey (string formId);

        /// <summary>
        /// Delete a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteQualityFormsSurveyWithHttpInfo (string formId);

        /// <summary>
        /// Get status for async query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsEvaluationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>AsyncQueryStatus</returns>
        
        AsyncQueryStatus GetAnalyticsEvaluationsAggregatesJob (string jobId);

        /// <summary>
        /// Get status for async query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsEvaluationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AsyncQueryStatus</returns>
        
        ApiResponse<AsyncQueryStatus> GetAnalyticsEvaluationsAggregatesJobWithHttpInfo (string jobId);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsEvaluationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>EvaluationAsyncAggregateQueryResponse</returns>
        
        EvaluationAsyncAggregateQueryResponse GetAnalyticsEvaluationsAggregatesJobResults (string jobId, string cursor = null);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsEvaluationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>ApiResponse of EvaluationAsyncAggregateQueryResponse</returns>
        
        ApiResponse<EvaluationAsyncAggregateQueryResponse> GetAnalyticsEvaluationsAggregatesJobResultsWithHttpInfo (string jobId, string cursor = null);

        /// <summary>
        /// Get status for async query for survey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsSurveysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>AsyncQueryStatus</returns>
        
        AsyncQueryStatus GetAnalyticsSurveysAggregatesJob (string jobId);

        /// <summary>
        /// Get status for async query for survey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsSurveysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AsyncQueryStatus</returns>
        
        ApiResponse<AsyncQueryStatus> GetAnalyticsSurveysAggregatesJobWithHttpInfo (string jobId);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsSurveysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>SurveyAsyncAggregateQueryResponse</returns>
        
        SurveyAsyncAggregateQueryResponse GetAnalyticsSurveysAggregatesJobResults (string jobId, string cursor = null);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsSurveysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>ApiResponse of SurveyAsyncAggregateQueryResponse</returns>
        
        ApiResponse<SurveyAsyncAggregateQueryResponse> GetAnalyticsSurveysAggregatesJobResultsWithHttpInfo (string jobId, string cursor = null);

        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Each item on the list shows one agent's evaluation activity comprised of the number of evaluations and the highest, average, and lowest standard and critical scores, as well as a sub list showing the number and average score of evaluations for each evaluator for that agent.  evaluatorUserId, startTime, and endTime are all filtering criteria. If specified, the only evaluations used to compile the agent activity response will be ones that match the filtering criteria. agentUserId, name, group, and agentTeamId are all agent selection criteria. criteria.  If one or more agent selection criteria are specified, then the returned activity will include users that match the criteria even if those users did not have any agent activity or evaluations that do not match any filtering criteria.  If no agent selection criteria are specified but an evaluatorUserId is, then the returned activity will be only for those agents that had evaluations where the evaluator is the evaluatorUserId.  If no agent selection criteria are specified and no evaluatorUserId is specified, then the returned activity will be for all users
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents requested (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <returns>AgentActivityEntityListing</returns>
        
        AgentActivityEntityListing GetQualityAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null);

        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Each item on the list shows one agent's evaluation activity comprised of the number of evaluations and the highest, average, and lowest standard and critical scores, as well as a sub list showing the number and average score of evaluations for each evaluator for that agent.  evaluatorUserId, startTime, and endTime are all filtering criteria. If specified, the only evaluations used to compile the agent activity response will be ones that match the filtering criteria. agentUserId, name, group, and agentTeamId are all agent selection criteria. criteria.  If one or more agent selection criteria are specified, then the returned activity will include users that match the criteria even if those users did not have any agent activity or evaluations that do not match any filtering criteria.  If no agent selection criteria are specified but an evaluatorUserId is, then the returned activity will be only for those agents that had evaluations where the evaluator is the evaluatorUserId.  If no agent selection criteria are specified and no evaluatorUserId is specified, then the returned activity will be for all users
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents requested (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        
        ApiResponse<AgentActivityEntityListing> GetQualityAgentsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null);

        /// <summary>
        /// Get a calibration by id.  Requires either calibrator id or conversation id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Calibration</returns>
        
        Calibration GetQualityCalibration (string calibrationId, string calibratorId = null, string conversationId = null);

        /// <summary>
        /// Get a calibration by id.  Requires either calibrator id or conversation id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        
        ApiResponse<Calibration> GetQualityCalibrationWithHttpInfo (string calibrationId, string calibratorId = null, string conversationId = null);

        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// NOTE: The count for total and pageCount might not be accurate when querying for a large number of calibrations. nextUri, if present, will indicate that there are more calibrations to fetch.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <returns>CalibrationEntityListing</returns>
        
        CalibrationEntityListing GetQualityCalibrations (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);

        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// NOTE: The count for total and pageCount might not be accurate when querying for a large number of calibrations. nextUri, if present, will indicate that there are more calibrations to fetch.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <returns>ApiResponse of CalibrationEntityListing</returns>
        
        ApiResponse<CalibrationEntityListing> GetQualityCalibrationsWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);

        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, assignee, evaluator, evaluationForm (optional)</param>
        /// <returns>EvaluationResponse</returns>
        
        EvaluationResponse GetQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, assignee, evaluator, evaluationForm (optional)</param>
        /// <returns>ApiResponse of EvaluationResponse</returns>
        
        ApiResponse<EvaluationResponse> GetQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get the surveys for a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>List&lt;Survey&gt;</returns>
        
        List<Survey> GetQualityConversationSurveys (string conversationId);

        /// <summary>
        /// Get the surveys for a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of List&lt;Survey&gt;</returns>
        
        ApiResponse<List<Survey>> GetQualityConversationSurveysWithHttpInfo (string conversationId);

        /// <summary>
        /// Get status of audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>QualityAuditQueryExecutionStatusResponse</returns>
        
        QualityAuditQueryExecutionStatusResponse GetQualityConversationsAuditsQueryTransactionId (string transactionId);

        /// <summary>
        /// Get status of audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>ApiResponse of QualityAuditQueryExecutionStatusResponse</returns>
        
        ApiResponse<QualityAuditQueryExecutionStatusResponse> GetQualityConversationsAuditsQueryTransactionIdWithHttpInfo (string transactionId);

        /// <summary>
        /// Get results of audit query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>QualityAuditQueryExecutionResultsResponse</returns>
        
        QualityAuditQueryExecutionResultsResponse GetQualityConversationsAuditsQueryTransactionIdResults (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Get results of audit query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of QualityAuditQueryExecutionResultsResponse</returns>
        
        ApiResponse<QualityAuditQueryExecutionResultsResponse> GetQualityConversationsAuditsQueryTransactionIdResultsWithHttpInfo (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, agentUserId or assigneeUserId. When querying by agentUserId (and not conversationId or evaluatorUserId), the results are sorted by release date. Evaluations set to 'Never Release' are omitted in this case. When querying by evaluatorUserId or conversationId (including when combined with agentUserId), the results are sorted by assigned date. NOTE: The count for total and pageCount might not be accurate when querying for a large number of evaluations. nextUri, if present, will indicate that there are more evaluations to fetch. The evaluation entities contained in the response might only contain a subset of all the properties listed below. It is often because a given property's value has not yet been populated or is not applicable in the current state of the evaluation. It might also be because the missing property in the response was not requested by the user.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="agentTeamId">team id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="assigneeUserId">assignee user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <param name="evaluationState"> (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations. NOTE: The answers will only be populated if this parameter is set to true in the request. (optional)</param>
        /// <param name="maximum">the maximum number of results to return (optional)</param>
        /// <param name="sortOrder">NOTE: Does not work when conversationId is supplied. (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        
        EvaluationEntityListing GetQualityEvaluationsQuery (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, agentUserId or assigneeUserId. When querying by agentUserId (and not conversationId or evaluatorUserId), the results are sorted by release date. Evaluations set to 'Never Release' are omitted in this case. When querying by evaluatorUserId or conversationId (including when combined with agentUserId), the results are sorted by assigned date. NOTE: The count for total and pageCount might not be accurate when querying for a large number of evaluations. nextUri, if present, will indicate that there are more evaluations to fetch. The evaluation entities contained in the response might only contain a subset of all the properties listed below. It is often because a given property's value has not yet been populated or is not applicable in the current state of the evaluation. It might also be because the missing property in the response was not requested by the user.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="agentTeamId">team id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="assigneeUserId">assignee user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <param name="evaluationState"> (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations. NOTE: The answers will only be populated if this parameter is set to true in the request. (optional)</param>
        /// <param name="maximum">the maximum number of results to return (optional)</param>
        /// <param name="sortOrder">NOTE: Does not work when conversationId is supplied. (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        
        ApiResponse<EvaluationEntityListing> GetQualityEvaluationsQueryWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null);

        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents to be considered (optional)</param>
        /// <returns>EvaluatorActivityEntityListing</returns>
        
        EvaluatorActivityEntityListing GetQualityEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null, string agentTeamId = null);

        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents to be considered (optional)</param>
        /// <returns>ApiResponse of EvaluatorActivityEntityListing</returns>
        
        ApiResponse<EvaluatorActivityEntityListing> GetQualityEvaluatorsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null, string agentTeamId = null);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationFormResponse</returns>
        [Obsolete]
        EvaluationFormResponse GetQualityForm (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        [Obsolete]
        ApiResponse<EvaluationFormResponse> GetQualityFormWithHttpInfo (string formId);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        EvaluationFormResponseEntityListing GetQualityFormVersions (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        ApiResponse<EvaluationFormResponseEntityListing> GetQualityFormVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        EvaluationFormResponseEntityListing GetQualityForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Get the list of evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        ApiResponse<EvaluationFormResponseEntityListing> GetQualityFormsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationFormResponse</returns>
        
        EvaluationFormResponse GetQualityFormsEvaluation (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        
        ApiResponse<EvaluationFormResponse> GetQualityFormsEvaluationWithHttpInfo (string formId);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to "asc")</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        
        EvaluationFormResponseEntityListing GetQualityFormsEvaluationVersions (string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to "asc")</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        
        ApiResponse<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// By default, \"published\" field is always returned as false for all evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. In addition, \"questionGroups\", the detailed information about evaluation form, is not returned. We will enhance this field in a future release.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        
        EvaluationFormResponseEntityListing GetQualityFormsEvaluations (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// By default, \"published\" field is always returned as false for all evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. In addition, \"questionGroups\", the detailed information about evaluation form, is not returned. We will enhance this field in a future release.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        
        ApiResponse<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Retrieve a list of the latest published evaluation form versions by context ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid evaluation form context ids</param>
        /// <returns>List&lt;EvaluationFormResponse&gt;</returns>
        
        List<EvaluationFormResponse> GetQualityFormsEvaluationsBulkContexts (List<string> contextId);

        /// <summary>
        /// Retrieve a list of the latest published evaluation form versions by context ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid evaluation form context ids</param>
        /// <returns>ApiResponse of List&lt;EvaluationFormResponse&gt;</returns>
        
        ApiResponse<List<EvaluationFormResponse>> GetQualityFormsEvaluationsBulkContextsWithHttpInfo (List<string> contextId);

        /// <summary>
        /// Get a survey form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>SurveyForm</returns>
        
        SurveyForm GetQualityFormsSurvey (string formId);

        /// <summary>
        /// Get a survey form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        ApiResponse<SurveyForm> GetQualityFormsSurveyWithHttpInfo (string formId);

        /// <summary>
        /// Gets all the revisions for a specific survey.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SurveyFormEntityListing</returns>
        
        SurveyFormEntityListing GetQualityFormsSurveyVersions (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets all the revisions for a specific survey.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SurveyFormEntityListing</returns>
        
        ApiResponse<SurveyFormEntityListing> GetQualityFormsSurveyVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of survey forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>SurveyFormEntityListing</returns>
        
        SurveyFormEntityListing GetQualityFormsSurveys (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Get the list of survey forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>ApiResponse of SurveyFormEntityListing</returns>
        
        ApiResponse<SurveyFormEntityListing> GetQualityFormsSurveysWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Retrieve a list of survey forms by their ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A comma-delimited list of valid survey form ids</param>
        /// <returns>SurveyFormEntityListing</returns>
        
        SurveyFormEntityListing GetQualityFormsSurveysBulk (List<string> id);

        /// <summary>
        /// Retrieve a list of survey forms by their ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A comma-delimited list of valid survey form ids</param>
        /// <returns>ApiResponse of SurveyFormEntityListing</returns>
        
        ApiResponse<SurveyFormEntityListing> GetQualityFormsSurveysBulkWithHttpInfo (List<string> id);

        /// <summary>
        /// Retrieve a list of the latest form versions by context ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid survey form context ids. The maximum number of ids allowed in this list is 100.</param>
        /// <param name="published">If true, the latest published version will be included. If false, only the unpublished version will be included. (optional, default to true)</param>
        /// <returns>List&lt;SurveyForm&gt;</returns>
        
        List<SurveyForm> GetQualityFormsSurveysBulkContexts (List<string> contextId, bool? published = null);

        /// <summary>
        /// Retrieve a list of the latest form versions by context ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid survey form context ids. The maximum number of ids allowed in this list is 100.</param>
        /// <param name="published">If true, the latest published version will be included. If false, only the unpublished version will be included. (optional, default to true)</param>
        /// <returns>ApiResponse of List&lt;SurveyForm&gt;</returns>
        
        ApiResponse<List<SurveyForm>> GetQualityFormsSurveysBulkContextsWithHttpInfo (List<string> contextId, bool? published = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationFormResponse</returns>
        [Obsolete]
        EvaluationFormResponse GetQualityPublishedform (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        [Obsolete]
        ApiResponse<EvaluationFormResponse> GetQualityPublishedformWithHttpInfo (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        EvaluationFormResponseEntityListing GetQualityPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        ApiResponse<EvaluationFormResponseEntityListing> GetQualityPublishedformsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null);

        /// <summary>
        /// Get the most recent published version of an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationFormResponse</returns>
        
        EvaluationFormResponse GetQualityPublishedformsEvaluation (string formId);

        /// <summary>
        /// Get the most recent published version of an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        
        ApiResponse<EvaluationFormResponse> GetQualityPublishedformsEvaluationWithHttpInfo (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        
        EvaluationFormResponseEntityListing GetQualityPublishedformsEvaluations (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        
        ApiResponse<EvaluationFormResponseEntityListing> GetQualityPublishedformsEvaluationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null);

        /// <summary>
        /// Get the most recent published version of a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>SurveyForm</returns>
        
        SurveyForm GetQualityPublishedformsSurvey (string formId);

        /// <summary>
        /// Get the most recent published version of a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        ApiResponse<SurveyForm> GetQualityPublishedformsSurveyWithHttpInfo (string formId);

        /// <summary>
        /// Get the published survey forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestEnabledPerContext">onlyLatestEnabledPerContext (optional, default to false)</param>
        /// <returns>SurveyFormEntityListing</returns>
        
        SurveyFormEntityListing GetQualityPublishedformsSurveys (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null);

        /// <summary>
        /// Get the published survey forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestEnabledPerContext">onlyLatestEnabledPerContext (optional, default to false)</param>
        /// <returns>ApiResponse of SurveyFormEntityListing</returns>
        
        ApiResponse<SurveyFormEntityListing> GetQualityPublishedformsSurveysWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null);

        /// <summary>
        /// Get a survey for a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="surveyId">surveyId</param>
        /// <returns>Survey</returns>
        
        Survey GetQualitySurvey (string surveyId);

        /// <summary>
        /// Get a survey for a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="surveyId">surveyId</param>
        /// <returns>ApiResponse of Survey</returns>
        
        ApiResponse<Survey> GetQualitySurveyWithHttpInfo (string surveyId);

        /// <summary>
        /// Get a survey as an end-customer, for the purposes of scoring it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <returns>ScorableSurvey</returns>
        
        ScorableSurvey GetQualitySurveysScorable (string customerSurveyUrl);

        /// <summary>
        /// Get a survey as an end-customer, for the purposes of scoring it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <returns>ApiResponse of ScorableSurvey</returns>
        
        ApiResponse<ScorableSurvey> GetQualitySurveysScorableWithHttpInfo (string customerSurveyUrl);

        /// <summary>
        /// Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>SurveyForm</returns>
        
        SurveyForm PatchQualityFormsSurvey (string formId, SurveyForm body);

        /// <summary>
        /// Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        ApiResponse<SurveyForm> PatchQualityFormsSurveyWithHttpInfo (string formId, SurveyForm body);

        /// <summary>
        /// Query for evaluation aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsEvaluationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AsyncQueryResponse</returns>
        
        AsyncQueryResponse PostAnalyticsEvaluationsAggregatesJobs (EvaluationAsyncAggregationQuery body);

        /// <summary>
        /// Query for evaluation aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsEvaluationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AsyncQueryResponse</returns>
        
        ApiResponse<AsyncQueryResponse> PostAnalyticsEvaluationsAggregatesJobsWithHttpInfo (EvaluationAsyncAggregationQuery body);

        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>EvaluationAggregateQueryResponse</returns>
        
        EvaluationAggregateQueryResponse PostAnalyticsEvaluationsAggregatesQuery (EvaluationAggregationQuery body);

        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of EvaluationAggregateQueryResponse</returns>
        
        ApiResponse<EvaluationAggregateQueryResponse> PostAnalyticsEvaluationsAggregatesQueryWithHttpInfo (EvaluationAggregationQuery body);

        /// <summary>
        /// Query for survey aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsSurveysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AsyncQueryResponse</returns>
        
        AsyncQueryResponse PostAnalyticsSurveysAggregatesJobs (SurveyAsyncAggregationQuery body);

        /// <summary>
        /// Query for survey aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsSurveysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AsyncQueryResponse</returns>
        
        ApiResponse<AsyncQueryResponse> PostAnalyticsSurveysAggregatesJobsWithHttpInfo (SurveyAsyncAggregationQuery body);

        /// <summary>
        /// Query for survey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>SurveyAggregateQueryResponse</returns>
        
        SurveyAggregateQueryResponse PostAnalyticsSurveysAggregatesQuery (SurveyAggregationQuery body);

        /// <summary>
        /// Query for survey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of SurveyAggregateQueryResponse</returns>
        
        ApiResponse<SurveyAggregateQueryResponse> PostAnalyticsSurveysAggregatesQueryWithHttpInfo (SurveyAggregationQuery body);

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        
        Calibration PostQualityCalibrations (CalibrationCreate body, string expand = null);

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        
        ApiResponse<Calibration> PostQualityCalibrationsWithHttpInfo (CalibrationCreate body, string expand = null);

        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        
        Evaluation PostQualityConversationEvaluations (string conversationId, EvaluationCreateBody body, string expand = null);

        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        
        ApiResponse<Evaluation> PostQualityConversationEvaluationsWithHttpInfo (string conversationId, EvaluationCreateBody body, string expand = null);

        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>QualityAuditQueryExecutionStatusResponse</returns>
        
        QualityAuditQueryExecutionStatusResponse PostQualityConversationsAuditsQuery (QMAuditQueryRequest body);

        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of QualityAuditQueryExecutionStatusResponse</returns>
        
        ApiResponse<QualityAuditQueryExecutionStatusResponse> PostQualityConversationsAuditsQueryWithHttpInfo (QMAuditQueryRequest body);

        /// <summary>
        /// Query for evaluation aggregates for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>EvaluationAggregateQueryResponse</returns>
        
        EvaluationAggregateQueryResponse PostQualityEvaluationsAggregatesQueryMe (EvaluationAggregationQueryMe body);

        /// <summary>
        /// Query for evaluation aggregates for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of EvaluationAggregateQueryResponse</returns>
        
        ApiResponse<EvaluationAggregateQueryResponse> PostQualityEvaluationsAggregatesQueryMeWithHttpInfo (EvaluationAggregationQueryMe body);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>EvaluationScoringSet</returns>
        
        EvaluationScoringSet PostQualityEvaluationsScoring (EvaluationFormAndScoringSet body);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        
        ApiResponse<EvaluationScoringSet> PostQualityEvaluationsScoringWithHttpInfo (EvaluationFormAndScoringSet body);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationFormResponse</returns>
        [Obsolete]
        EvaluationFormResponse PostQualityForms (EvaluationForm body);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        [Obsolete]
        ApiResponse<EvaluationFormResponse> PostQualityFormsWithHttpInfo (EvaluationForm body);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationFormResponse</returns>
        
        EvaluationFormResponse PostQualityFormsEvaluations (EvaluationForm body);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        
        ApiResponse<EvaluationFormResponse> PostQualityFormsEvaluationsWithHttpInfo (EvaluationForm body);

        /// <summary>
        /// Create a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>SurveyForm</returns>
        
        SurveyForm PostQualityFormsSurveys (SurveyForm body);

        /// <summary>
        /// Create a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        ApiResponse<SurveyForm> PostQualityFormsSurveysWithHttpInfo (SurveyForm body);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>EvaluationFormResponse</returns>
        [Obsolete]
        EvaluationFormResponse PostQualityPublishedforms (PublishForm body);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        [Obsolete]
        ApiResponse<EvaluationFormResponse> PostQualityPublishedformsWithHttpInfo (PublishForm body);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>EvaluationFormResponse</returns>
        
        EvaluationFormResponse PostQualityPublishedformsEvaluations (PublishForm body);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        
        ApiResponse<EvaluationFormResponse> PostQualityPublishedformsEvaluationsWithHttpInfo (PublishForm body);

        /// <summary>
        /// Publish a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>SurveyForm</returns>
        
        SurveyForm PostQualityPublishedformsSurveys (PublishForm body);

        /// <summary>
        /// Publish a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        ApiResponse<SurveyForm> PostQualityPublishedformsSurveysWithHttpInfo (PublishForm body);

        /// <summary>
        /// Score survey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">surveyAndScoringSet</param>
        /// <returns>SurveyScoringSet</returns>
        
        SurveyScoringSet PostQualitySurveysScoring (SurveyFormAndScoringSet body);

        /// <summary>
        /// Score survey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">surveyAndScoringSet</param>
        /// <returns>ApiResponse of SurveyScoringSet</returns>
        
        ApiResponse<SurveyScoringSet> PostQualitySurveysScoringWithHttpInfo (SurveyFormAndScoringSet body);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Calibration</returns>
        
        Calibration PutQualityCalibration (string calibrationId, Calibration body);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>ApiResponse of Calibration</returns>
        
        ApiResponse<Calibration> PutQualityCalibrationWithHttpInfo (string calibrationId, Calibration body);

        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// The quality:evaluation:edit permission allows modification of most fields, while the quality:evaluation:editScore permission allows an evaluator to change just the question scores, and the quality:evaluation:editAgentSignoff permission allows an agent to change the agent comments and sign off on the evaluation. authorizedActions is not returned for this PUT request, and is only returned for GET requests to this endpoint.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId, evaluationForm, assignee, evaluator (optional)</param>
        /// <returns>EvaluationResponse</returns>
        
        EvaluationResponse PutQualityConversationEvaluation (string conversationId, string evaluationId, Evaluation body, string expand = null);

        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// The quality:evaluation:edit permission allows modification of most fields, while the quality:evaluation:editScore permission allows an evaluator to change just the question scores, and the quality:evaluation:editAgentSignoff permission allows an agent to change the agent comments and sign off on the evaluation. authorizedActions is not returned for this PUT request, and is only returned for GET requests to this endpoint.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId, evaluationForm, assignee, evaluator (optional)</param>
        /// <returns>ApiResponse of EvaluationResponse</returns>
        
        ApiResponse<EvaluationResponse> PutQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, Evaluation body, string expand = null);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationFormResponse</returns>
        [Obsolete]
        EvaluationFormResponse PutQualityForm (string formId, EvaluationForm body);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        [Obsolete]
        ApiResponse<EvaluationFormResponse> PutQualityFormWithHttpInfo (string formId, EvaluationForm body);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationFormResponse</returns>
        
        EvaluationFormResponse PutQualityFormsEvaluation (string formId, EvaluationForm body);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        
        ApiResponse<EvaluationFormResponse> PutQualityFormsEvaluationWithHttpInfo (string formId, EvaluationForm body);

        /// <summary>
        /// Update the AI Scoring settings of an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// PutQualityFormsEvaluationAiscoringSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">AI Scoring Settings</param>
        /// <returns>AiScoringSettings</returns>
        
        AiScoringSettings PutQualityFormsEvaluationAiscoringSettings (string formId, AiScoringSettings body);

        /// <summary>
        /// Update the AI Scoring settings of an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// PutQualityFormsEvaluationAiscoringSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">AI Scoring Settings</param>
        /// <returns>ApiResponse of AiScoringSettings</returns>
        
        ApiResponse<AiScoringSettings> PutQualityFormsEvaluationAiscoringSettingsWithHttpInfo (string formId, AiScoringSettings body);

        /// <summary>
        /// Update a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>SurveyForm</returns>
        
        SurveyForm PutQualityFormsSurvey (string formId, SurveyForm body);

        /// <summary>
        /// Update a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        ApiResponse<SurveyForm> PutQualityFormsSurveyWithHttpInfo (string formId, SurveyForm body);

        /// <summary>
        /// Update a survey as an end-customer, for the purposes of scoring it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <param name="body">survey</param>
        /// <returns>ScorableSurvey</returns>
        
        ScorableSurvey PutQualitySurveysScorable (string customerSurveyUrl, ScorableSurvey body);

        /// <summary>
        /// Update a survey as an end-customer, for the purposes of scoring it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <param name="body">survey</param>
        /// <returns>ApiResponse of ScorableSurvey</returns>
        
        ApiResponse<ScorableSurvey> PutQualitySurveysScorableWithHttpInfo (string customerSurveyUrl, ScorableSurvey body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        
        System.Threading.Tasks.Task<Calibration> DeleteQualityCalibrationAsync (string calibrationId, string calibratorId);

        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Calibration>> DeleteQualityCalibrationAsyncWithHttpInfo (string calibrationId, string calibratorId);

        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId, evaluationForm (optional)</param>
        /// <returns>Task of EvaluationResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationResponse> DeleteQualityConversationEvaluationAsync (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId, evaluationForm (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationResponse>> DeleteQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of void</returns>
        [Obsolete]
        System.Threading.Tasks.Task DeleteQualityFormAsync (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityFormAsyncWithHttpInfo (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteQualityFormsEvaluationAsync (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityFormsEvaluationAsyncWithHttpInfo (string formId);

        /// <summary>
        /// Delete a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteQualityFormsSurveyAsync (string formId);

        /// <summary>
        /// Delete a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityFormsSurveyAsyncWithHttpInfo (string formId);

        /// <summary>
        /// Get status for async query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsEvaluationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AsyncQueryStatus</returns>
        
        System.Threading.Tasks.Task<AsyncQueryStatus> GetAnalyticsEvaluationsAggregatesJobAsync (string jobId);

        /// <summary>
        /// Get status for async query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsEvaluationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AsyncQueryStatus>> GetAnalyticsEvaluationsAggregatesJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsEvaluationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of EvaluationAsyncAggregateQueryResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationAsyncAggregateQueryResponse> GetAnalyticsEvaluationsAggregatesJobResultsAsync (string jobId, string cursor = null);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsEvaluationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationAsyncAggregateQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationAsyncAggregateQueryResponse>> GetAnalyticsEvaluationsAggregatesJobResultsAsyncWithHttpInfo (string jobId, string cursor = null);

        /// <summary>
        /// Get status for async query for survey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsSurveysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AsyncQueryStatus</returns>
        
        System.Threading.Tasks.Task<AsyncQueryStatus> GetAnalyticsSurveysAggregatesJobAsync (string jobId);

        /// <summary>
        /// Get status for async query for survey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsSurveysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AsyncQueryStatus>> GetAnalyticsSurveysAggregatesJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsSurveysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of SurveyAsyncAggregateQueryResponse</returns>
        
        System.Threading.Tasks.Task<SurveyAsyncAggregateQueryResponse> GetAnalyticsSurveysAggregatesJobResultsAsync (string jobId, string cursor = null);

        /// <summary>
        /// Fetch a page of results for an async aggregates query
        /// </summary>
        /// <remarks>
        /// 
        /// GetAnalyticsSurveysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of ApiResponse (SurveyAsyncAggregateQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyAsyncAggregateQueryResponse>> GetAnalyticsSurveysAggregatesJobResultsAsyncWithHttpInfo (string jobId, string cursor = null);

        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Each item on the list shows one agent's evaluation activity comprised of the number of evaluations and the highest, average, and lowest standard and critical scores, as well as a sub list showing the number and average score of evaluations for each evaluator for that agent.  evaluatorUserId, startTime, and endTime are all filtering criteria. If specified, the only evaluations used to compile the agent activity response will be ones that match the filtering criteria. agentUserId, name, group, and agentTeamId are all agent selection criteria. criteria.  If one or more agent selection criteria are specified, then the returned activity will include users that match the criteria even if those users did not have any agent activity or evaluations that do not match any filtering criteria.  If no agent selection criteria are specified but an evaluatorUserId is, then the returned activity will be only for those agents that had evaluations where the evaluator is the evaluatorUserId.  If no agent selection criteria are specified and no evaluatorUserId is specified, then the returned activity will be for all users
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents requested (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <returns>Task of AgentActivityEntityListing</returns>
        
        System.Threading.Tasks.Task<AgentActivityEntityListing> GetQualityAgentsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null);

        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Each item on the list shows one agent's evaluation activity comprised of the number of evaluations and the highest, average, and lowest standard and critical scores, as well as a sub list showing the number and average score of evaluations for each evaluator for that agent.  evaluatorUserId, startTime, and endTime are all filtering criteria. If specified, the only evaluations used to compile the agent activity response will be ones that match the filtering criteria. agentUserId, name, group, and agentTeamId are all agent selection criteria. criteria.  If one or more agent selection criteria are specified, then the returned activity will include users that match the criteria even if those users did not have any agent activity or evaluations that do not match any filtering criteria.  If no agent selection criteria are specified but an evaluatorUserId is, then the returned activity will be only for those agents that had evaluations where the evaluator is the evaluatorUserId.  If no agent selection criteria are specified and no evaluatorUserId is specified, then the returned activity will be for all users
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents requested (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <returns>Task of ApiResponse (AgentActivityEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> GetQualityAgentsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null);

        /// <summary>
        /// Get a calibration by id.  Requires either calibrator id or conversation id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of Calibration</returns>
        
        System.Threading.Tasks.Task<Calibration> GetQualityCalibrationAsync (string calibrationId, string calibratorId = null, string conversationId = null);

        /// <summary>
        /// Get a calibration by id.  Requires either calibrator id or conversation id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Calibration>> GetQualityCalibrationAsyncWithHttpInfo (string calibrationId, string calibratorId = null, string conversationId = null);

        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// NOTE: The count for total and pageCount might not be accurate when querying for a large number of calibrations. nextUri, if present, will indicate that there are more calibrations to fetch.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <returns>Task of CalibrationEntityListing</returns>
        
        System.Threading.Tasks.Task<CalibrationEntityListing> GetQualityCalibrationsAsync (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);

        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// NOTE: The count for total and pageCount might not be accurate when querying for a large number of calibrations. nextUri, if present, will indicate that there are more calibrations to fetch.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <returns>Task of ApiResponse (CalibrationEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> GetQualityCalibrationsAsyncWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);

        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, assignee, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of EvaluationResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationResponse> GetQualityConversationEvaluationAsync (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, assignee, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationResponse>> GetQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get the surveys for a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of List&lt;Survey&gt;</returns>
        
        System.Threading.Tasks.Task<List<Survey>> GetQualityConversationSurveysAsync (string conversationId);

        /// <summary>
        /// Get the surveys for a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (List&lt;Survey&gt;)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<List<Survey>>> GetQualityConversationSurveysAsyncWithHttpInfo (string conversationId);

        /// <summary>
        /// Get status of audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>Task of QualityAuditQueryExecutionStatusResponse</returns>
        
        System.Threading.Tasks.Task<QualityAuditQueryExecutionStatusResponse> GetQualityConversationsAuditsQueryTransactionIdAsync (string transactionId);

        /// <summary>
        /// Get status of audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>Task of ApiResponse (QualityAuditQueryExecutionStatusResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<QualityAuditQueryExecutionStatusResponse>> GetQualityConversationsAuditsQueryTransactionIdAsyncWithHttpInfo (string transactionId);

        /// <summary>
        /// Get results of audit query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of QualityAuditQueryExecutionResultsResponse</returns>
        
        System.Threading.Tasks.Task<QualityAuditQueryExecutionResultsResponse> GetQualityConversationsAuditsQueryTransactionIdResultsAsync (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Get results of audit query
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (QualityAuditQueryExecutionResultsResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<QualityAuditQueryExecutionResultsResponse>> GetQualityConversationsAuditsQueryTransactionIdResultsAsyncWithHttpInfo (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, agentUserId or assigneeUserId. When querying by agentUserId (and not conversationId or evaluatorUserId), the results are sorted by release date. Evaluations set to 'Never Release' are omitted in this case. When querying by evaluatorUserId or conversationId (including when combined with agentUserId), the results are sorted by assigned date. NOTE: The count for total and pageCount might not be accurate when querying for a large number of evaluations. nextUri, if present, will indicate that there are more evaluations to fetch. The evaluation entities contained in the response might only contain a subset of all the properties listed below. It is often because a given property's value has not yet been populated or is not applicable in the current state of the evaluation. It might also be because the missing property in the response was not requested by the user.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="agentTeamId">team id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="assigneeUserId">assignee user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <param name="evaluationState"> (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations. NOTE: The answers will only be populated if this parameter is set to true in the request. (optional)</param>
        /// <param name="maximum">the maximum number of results to return (optional)</param>
        /// <param name="sortOrder">NOTE: Does not work when conversationId is supplied. (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        
        System.Threading.Tasks.Task<EvaluationEntityListing> GetQualityEvaluationsQueryAsync (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, agentUserId or assigneeUserId. When querying by agentUserId (and not conversationId or evaluatorUserId), the results are sorted by release date. Evaluations set to 'Never Release' are omitted in this case. When querying by evaluatorUserId or conversationId (including when combined with agentUserId), the results are sorted by assigned date. NOTE: The count for total and pageCount might not be accurate when querying for a large number of evaluations. nextUri, if present, will indicate that there are more evaluations to fetch. The evaluation entities contained in the response might only contain a subset of all the properties listed below. It is often because a given property's value has not yet been populated or is not applicable in the current state of the evaluation. It might also be because the missing property in the response was not requested by the user.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="agentTeamId">team id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="assigneeUserId">assignee user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <param name="evaluationState"> (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations. NOTE: The answers will only be populated if this parameter is set to true in the request. (optional)</param>
        /// <param name="maximum">the maximum number of results to return (optional)</param>
        /// <param name="sortOrder">NOTE: Does not work when conversationId is supplied. (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> GetQualityEvaluationsQueryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null);

        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents to be considered (optional)</param>
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        
        System.Threading.Tasks.Task<EvaluatorActivityEntityListing> GetQualityEvaluatorsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null, string agentTeamId = null);

        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents to be considered (optional)</param>
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> GetQualityEvaluatorsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null, string agentTeamId = null);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        [Obsolete]
        System.Threading.Tasks.Task<EvaluationFormResponse> GetQualityFormAsync (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> GetQualityFormAsyncWithHttpInfo (string formId);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityFormVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityFormVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityFormsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Get the list of evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityFormsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationFormResponse> GetQualityFormsEvaluationAsync (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> GetQualityFormsEvaluationAsyncWithHttpInfo (string formId);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to "asc")</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        
        System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to "asc")</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityFormsEvaluationVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// By default, \"published\" field is always returned as false for all evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. In addition, \"questionGroups\", the detailed information about evaluation form, is not returned. We will enhance this field in a future release.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        
        System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// By default, \"published\" field is always returned as false for all evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. In addition, \"questionGroups\", the detailed information about evaluation form, is not returned. We will enhance this field in a future release.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityFormsEvaluationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Retrieve a list of the latest published evaluation form versions by context ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid evaluation form context ids</param>
        /// <returns>Task of List&lt;EvaluationFormResponse&gt;</returns>
        
        System.Threading.Tasks.Task<List<EvaluationFormResponse>> GetQualityFormsEvaluationsBulkContextsAsync (List<string> contextId);

        /// <summary>
        /// Retrieve a list of the latest published evaluation form versions by context ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid evaluation form context ids</param>
        /// <returns>Task of ApiResponse (List&lt;EvaluationFormResponse&gt;)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<List<EvaluationFormResponse>>> GetQualityFormsEvaluationsBulkContextsAsyncWithHttpInfo (List<string> contextId);

        /// <summary>
        /// Get a survey form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of SurveyForm</returns>
        
        System.Threading.Tasks.Task<SurveyForm> GetQualityFormsSurveyAsync (string formId);

        /// <summary>
        /// Get a survey form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyForm>> GetQualityFormsSurveyAsyncWithHttpInfo (string formId);

        /// <summary>
        /// Gets all the revisions for a specific survey.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SurveyFormEntityListing</returns>
        
        System.Threading.Tasks.Task<SurveyFormEntityListing> GetQualityFormsSurveyVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets all the revisions for a specific survey.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SurveyFormEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyFormEntityListing>> GetQualityFormsSurveyVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of survey forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of SurveyFormEntityListing</returns>
        
        System.Threading.Tasks.Task<SurveyFormEntityListing> GetQualityFormsSurveysAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Get the list of survey forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of ApiResponse (SurveyFormEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyFormEntityListing>> GetQualityFormsSurveysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null);

        /// <summary>
        /// Retrieve a list of survey forms by their ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A comma-delimited list of valid survey form ids</param>
        /// <returns>Task of SurveyFormEntityListing</returns>
        
        System.Threading.Tasks.Task<SurveyFormEntityListing> GetQualityFormsSurveysBulkAsync (List<string> id);

        /// <summary>
        /// Retrieve a list of survey forms by their ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A comma-delimited list of valid survey form ids</param>
        /// <returns>Task of ApiResponse (SurveyFormEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyFormEntityListing>> GetQualityFormsSurveysBulkAsyncWithHttpInfo (List<string> id);

        /// <summary>
        /// Retrieve a list of the latest form versions by context ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid survey form context ids. The maximum number of ids allowed in this list is 100.</param>
        /// <param name="published">If true, the latest published version will be included. If false, only the unpublished version will be included. (optional, default to true)</param>
        /// <returns>Task of List&lt;SurveyForm&gt;</returns>
        
        System.Threading.Tasks.Task<List<SurveyForm>> GetQualityFormsSurveysBulkContextsAsync (List<string> contextId, bool? published = null);

        /// <summary>
        /// Retrieve a list of the latest form versions by context ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid survey form context ids. The maximum number of ids allowed in this list is 100.</param>
        /// <param name="published">If true, the latest published version will be included. If false, only the unpublished version will be included. (optional, default to true)</param>
        /// <returns>Task of ApiResponse (List&lt;SurveyForm&gt;)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<List<SurveyForm>>> GetQualityFormsSurveysBulkContextsAsyncWithHttpInfo (List<string> contextId, bool? published = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        [Obsolete]
        System.Threading.Tasks.Task<EvaluationFormResponse> GetQualityPublishedformAsync (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> GetQualityPublishedformAsyncWithHttpInfo (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityPublishedformsAsync (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityPublishedformsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null);

        /// <summary>
        /// Get the most recent published version of an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationFormResponse> GetQualityPublishedformsEvaluationAsync (string formId);

        /// <summary>
        /// Get the most recent published version of an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> GetQualityPublishedformsEvaluationAsyncWithHttpInfo (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        
        System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityPublishedformsEvaluationsAsync (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityPublishedformsEvaluationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null);

        /// <summary>
        /// Get the most recent published version of a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of SurveyForm</returns>
        
        System.Threading.Tasks.Task<SurveyForm> GetQualityPublishedformsSurveyAsync (string formId);

        /// <summary>
        /// Get the most recent published version of a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyForm>> GetQualityPublishedformsSurveyAsyncWithHttpInfo (string formId);

        /// <summary>
        /// Get the published survey forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestEnabledPerContext">onlyLatestEnabledPerContext (optional, default to false)</param>
        /// <returns>Task of SurveyFormEntityListing</returns>
        
        System.Threading.Tasks.Task<SurveyFormEntityListing> GetQualityPublishedformsSurveysAsync (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null);

        /// <summary>
        /// Get the published survey forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestEnabledPerContext">onlyLatestEnabledPerContext (optional, default to false)</param>
        /// <returns>Task of ApiResponse (SurveyFormEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyFormEntityListing>> GetQualityPublishedformsSurveysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null);

        /// <summary>
        /// Get a survey for a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="surveyId">surveyId</param>
        /// <returns>Task of Survey</returns>
        
        System.Threading.Tasks.Task<Survey> GetQualitySurveyAsync (string surveyId);

        /// <summary>
        /// Get a survey for a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="surveyId">surveyId</param>
        /// <returns>Task of ApiResponse (Survey)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Survey>> GetQualitySurveyAsyncWithHttpInfo (string surveyId);

        /// <summary>
        /// Get a survey as an end-customer, for the purposes of scoring it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <returns>Task of ScorableSurvey</returns>
        
        System.Threading.Tasks.Task<ScorableSurvey> GetQualitySurveysScorableAsync (string customerSurveyUrl);

        /// <summary>
        /// Get a survey as an end-customer, for the purposes of scoring it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <returns>Task of ApiResponse (ScorableSurvey)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ScorableSurvey>> GetQualitySurveysScorableAsyncWithHttpInfo (string customerSurveyUrl);

        /// <summary>
        /// Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>Task of SurveyForm</returns>
        
        System.Threading.Tasks.Task<SurveyForm> PatchQualityFormsSurveyAsync (string formId, SurveyForm body);

        /// <summary>
        /// Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyForm>> PatchQualityFormsSurveyAsyncWithHttpInfo (string formId, SurveyForm body);

        /// <summary>
        /// Query for evaluation aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsEvaluationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AsyncQueryResponse</returns>
        
        System.Threading.Tasks.Task<AsyncQueryResponse> PostAnalyticsEvaluationsAggregatesJobsAsync (EvaluationAsyncAggregationQuery body);

        /// <summary>
        /// Query for evaluation aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsEvaluationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AsyncQueryResponse>> PostAnalyticsEvaluationsAggregatesJobsAsyncWithHttpInfo (EvaluationAsyncAggregationQuery body);

        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of EvaluationAggregateQueryResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationAggregateQueryResponse> PostAnalyticsEvaluationsAggregatesQueryAsync (EvaluationAggregationQuery body);

        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (EvaluationAggregateQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationAggregateQueryResponse>> PostAnalyticsEvaluationsAggregatesQueryAsyncWithHttpInfo (EvaluationAggregationQuery body);

        /// <summary>
        /// Query for survey aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsSurveysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AsyncQueryResponse</returns>
        
        System.Threading.Tasks.Task<AsyncQueryResponse> PostAnalyticsSurveysAggregatesJobsAsync (SurveyAsyncAggregationQuery body);

        /// <summary>
        /// Query for survey aggregates asynchronously
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsSurveysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AsyncQueryResponse>> PostAnalyticsSurveysAggregatesJobsAsyncWithHttpInfo (SurveyAsyncAggregationQuery body);

        /// <summary>
        /// Query for survey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of SurveyAggregateQueryResponse</returns>
        
        System.Threading.Tasks.Task<SurveyAggregateQueryResponse> PostAnalyticsSurveysAggregatesQueryAsync (SurveyAggregationQuery body);

        /// <summary>
        /// Query for survey aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (SurveyAggregateQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyAggregateQueryResponse>> PostAnalyticsSurveysAggregatesQueryAsyncWithHttpInfo (SurveyAggregationQuery body);

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        
        System.Threading.Tasks.Task<Calibration> PostQualityCalibrationsAsync (CalibrationCreate body, string expand = null);

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Calibration>> PostQualityCalibrationsAsyncWithHttpInfo (CalibrationCreate body, string expand = null);

        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        
        System.Threading.Tasks.Task<Evaluation> PostQualityConversationEvaluationsAsync (string conversationId, EvaluationCreateBody body, string expand = null);

        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> PostQualityConversationEvaluationsAsyncWithHttpInfo (string conversationId, EvaluationCreateBody body, string expand = null);

        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of QualityAuditQueryExecutionStatusResponse</returns>
        
        System.Threading.Tasks.Task<QualityAuditQueryExecutionStatusResponse> PostQualityConversationsAuditsQueryAsync (QMAuditQueryRequest body);

        /// <summary>
        /// Create audit query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (QualityAuditQueryExecutionStatusResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<QualityAuditQueryExecutionStatusResponse>> PostQualityConversationsAuditsQueryAsyncWithHttpInfo (QMAuditQueryRequest body);

        /// <summary>
        /// Query for evaluation aggregates for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of EvaluationAggregateQueryResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationAggregateQueryResponse> PostQualityEvaluationsAggregatesQueryMeAsync (EvaluationAggregationQueryMe body);

        /// <summary>
        /// Query for evaluation aggregates for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (EvaluationAggregateQueryResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationAggregateQueryResponse>> PostQualityEvaluationsAggregatesQueryMeAsyncWithHttpInfo (EvaluationAggregationQueryMe body);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        
        System.Threading.Tasks.Task<EvaluationScoringSet> PostQualityEvaluationsScoringAsync (EvaluationFormAndScoringSet body);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> PostQualityEvaluationsScoringAsyncWithHttpInfo (EvaluationFormAndScoringSet body);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        [Obsolete]
        System.Threading.Tasks.Task<EvaluationFormResponse> PostQualityFormsAsync (EvaluationForm body);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PostQualityFormsAsyncWithHttpInfo (EvaluationForm body);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationFormResponse> PostQualityFormsEvaluationsAsync (EvaluationForm body);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PostQualityFormsEvaluationsAsyncWithHttpInfo (EvaluationForm body);

        /// <summary>
        /// Create a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>Task of SurveyForm</returns>
        
        System.Threading.Tasks.Task<SurveyForm> PostQualityFormsSurveysAsync (SurveyForm body);

        /// <summary>
        /// Create a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyForm>> PostQualityFormsSurveysAsyncWithHttpInfo (SurveyForm body);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        [Obsolete]
        System.Threading.Tasks.Task<EvaluationFormResponse> PostQualityPublishedformsAsync (PublishForm body);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PostQualityPublishedformsAsyncWithHttpInfo (PublishForm body);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationFormResponse> PostQualityPublishedformsEvaluationsAsync (PublishForm body);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PostQualityPublishedformsEvaluationsAsyncWithHttpInfo (PublishForm body);

        /// <summary>
        /// Publish a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>Task of SurveyForm</returns>
        
        System.Threading.Tasks.Task<SurveyForm> PostQualityPublishedformsSurveysAsync (PublishForm body);

        /// <summary>
        /// Publish a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyForm>> PostQualityPublishedformsSurveysAsyncWithHttpInfo (PublishForm body);

        /// <summary>
        /// Score survey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">surveyAndScoringSet</param>
        /// <returns>Task of SurveyScoringSet</returns>
        
        System.Threading.Tasks.Task<SurveyScoringSet> PostQualitySurveysScoringAsync (SurveyFormAndScoringSet body);

        /// <summary>
        /// Score survey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">surveyAndScoringSet</param>
        /// <returns>Task of ApiResponse (SurveyScoringSet)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyScoringSet>> PostQualitySurveysScoringAsyncWithHttpInfo (SurveyFormAndScoringSet body);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of Calibration</returns>
        
        System.Threading.Tasks.Task<Calibration> PutQualityCalibrationAsync (string calibrationId, Calibration body);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Calibration>> PutQualityCalibrationAsyncWithHttpInfo (string calibrationId, Calibration body);

        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// The quality:evaluation:edit permission allows modification of most fields, while the quality:evaluation:editScore permission allows an evaluator to change just the question scores, and the quality:evaluation:editAgentSignoff permission allows an agent to change the agent comments and sign off on the evaluation. authorizedActions is not returned for this PUT request, and is only returned for GET requests to this endpoint.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId, evaluationForm, assignee, evaluator (optional)</param>
        /// <returns>Task of EvaluationResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationResponse> PutQualityConversationEvaluationAsync (string conversationId, string evaluationId, Evaluation body, string expand = null);

        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// The quality:evaluation:edit permission allows modification of most fields, while the quality:evaluation:editScore permission allows an evaluator to change just the question scores, and the quality:evaluation:editAgentSignoff permission allows an agent to change the agent comments and sign off on the evaluation. authorizedActions is not returned for this PUT request, and is only returned for GET requests to this endpoint.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId, evaluationForm, assignee, evaluator (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationResponse>> PutQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body, string expand = null);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        [Obsolete]
        System.Threading.Tasks.Task<EvaluationFormResponse> PutQualityFormAsync (string formId, EvaluationForm body);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PutQualityFormAsyncWithHttpInfo (string formId, EvaluationForm body);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        
        System.Threading.Tasks.Task<EvaluationFormResponse> PutQualityFormsEvaluationAsync (string formId, EvaluationForm body);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PutQualityFormsEvaluationAsyncWithHttpInfo (string formId, EvaluationForm body);

        /// <summary>
        /// Update the AI Scoring settings of an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// PutQualityFormsEvaluationAiscoringSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">AI Scoring Settings</param>
        /// <returns>Task of AiScoringSettings</returns>
        
        System.Threading.Tasks.Task<AiScoringSettings> PutQualityFormsEvaluationAiscoringSettingsAsync (string formId, AiScoringSettings body);

        /// <summary>
        /// Update the AI Scoring settings of an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// PutQualityFormsEvaluationAiscoringSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">AI Scoring Settings</param>
        /// <returns>Task of ApiResponse (AiScoringSettings)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<AiScoringSettings>> PutQualityFormsEvaluationAiscoringSettingsAsyncWithHttpInfo (string formId, AiScoringSettings body);

        /// <summary>
        /// Update a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>Task of SurveyForm</returns>
        
        System.Threading.Tasks.Task<SurveyForm> PutQualityFormsSurveyAsync (string formId, SurveyForm body);

        /// <summary>
        /// Update a survey form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<SurveyForm>> PutQualityFormsSurveyAsyncWithHttpInfo (string formId, SurveyForm body);

        /// <summary>
        /// Update a survey as an end-customer, for the purposes of scoring it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <param name="body">survey</param>
        /// <returns>Task of ScorableSurvey</returns>
        
        System.Threading.Tasks.Task<ScorableSurvey> PutQualitySurveysScorableAsync (string customerSurveyUrl, ScorableSurvey body);

        /// <summary>
        /// Update a survey as an end-customer, for the purposes of scoring it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <param name="body">survey</param>
        /// <returns>Task of ApiResponse (ScorableSurvey)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<ScorableSurvey>> PutQualitySurveysScorableAsyncWithHttpInfo (string customerSurveyUrl, ScorableSurvey body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class QualityApi : IQualityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QualityApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public QualityApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a calibration by id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        
        public Calibration DeleteQualityCalibration (string calibrationId, string calibratorId)
        {
             ApiResponse<Calibration> localVarResponse = DeleteQualityCalibrationWithHttpInfo(calibrationId, calibratorId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a calibration by id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        
        public ApiResponse< Calibration > DeleteQualityCalibrationWithHttpInfo (string calibrationId, string calibratorId)
        { 
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->DeleteQualityCalibration");
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->DeleteQualityCalibration");

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (calibrationId != null) localVarPathParams.Add("calibrationId", this.Configuration.ApiClient.ParameterToString(calibrationId));

            // Query params
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", this.Configuration.ApiClient.ParameterToString(calibratorId)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a calibration by id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        
        public async System.Threading.Tasks.Task<Calibration> DeleteQualityCalibrationAsync (string calibrationId, string calibratorId)
        {
             ApiResponse<Calibration> localVarResponse = await DeleteQualityCalibrationAsyncWithHttpInfo(calibrationId, calibratorId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a calibration by id. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> DeleteQualityCalibrationAsyncWithHttpInfo (string calibrationId, string calibratorId)
        { 
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->DeleteQualityCalibration");
            
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->DeleteQualityCalibration");
            

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (calibrationId != null) localVarPathParams.Add("calibrationId", this.Configuration.ApiClient.ParameterToString(calibrationId));

            // Query params
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", this.Configuration.ApiClient.ParameterToString(calibratorId)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId, evaluationForm (optional)</param>
        /// <returns>EvaluationResponse</returns>
        
        public EvaluationResponse DeleteQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<EvaluationResponse> localVarResponse = DeleteQualityConversationEvaluationWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId, evaluationForm (optional)</param>
        /// <returns>ApiResponse of EvaluationResponse</returns>
        
        public ApiResponse< EvaluationResponse > DeleteQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->DeleteQualityConversationEvaluation");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->DeleteQualityConversationEvaluation");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", this.Configuration.ApiClient.ParameterToString(evaluationId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId, evaluationForm (optional)</param>
        /// <returns>Task of EvaluationResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationResponse> DeleteQualityConversationEvaluationAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<EvaluationResponse> localVarResponse = await DeleteQualityConversationEvaluationAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId, evaluationForm (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationResponse>> DeleteQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->DeleteQualityConversationEvaluation");
            
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->DeleteQualityConversationEvaluation");
            

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", this.Configuration.ApiClient.ParameterToString(evaluationId));

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
                Method.Delete, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns></returns>
        [Obsolete]
        public void DeleteQualityForm (string formId)
        {
             DeleteQualityFormWithHttpInfo(formId);
        }

        /// <summary>
        /// Delete an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        [Obsolete]
        public ApiResponse<Object> DeleteQualityFormWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->DeleteQualityForm");

            var localVarPath = "/api/v2/quality/forms/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of void</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task DeleteQualityFormAsync (string formId)
        {
             await DeleteQualityFormAsyncWithHttpInfo(formId);

        }

        /// <summary>
        /// Delete an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityFormAsyncWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->DeleteQualityForm");
            

            var localVarPath = "/api/v2/quality/forms/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns></returns>
        
        public void DeleteQualityFormsEvaluation (string formId)
        {
             DeleteQualityFormsEvaluationWithHttpInfo(formId);
        }

        /// <summary>
        /// Delete an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteQualityFormsEvaluationWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->DeleteQualityFormsEvaluation");

            var localVarPath = "/api/v2/quality/forms/evaluations/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityFormsEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityFormsEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteQualityFormsEvaluationAsync (string formId)
        {
             await DeleteQualityFormsEvaluationAsyncWithHttpInfo(formId);

        }

        /// <summary>
        /// Delete an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityFormsEvaluationAsyncWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->DeleteQualityFormsEvaluation");
            

            var localVarPath = "/api/v2/quality/forms/evaluations/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityFormsEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityFormsEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns></returns>
        
        public void DeleteQualityFormsSurvey (string formId)
        {
             DeleteQualityFormsSurveyWithHttpInfo(formId);
        }

        /// <summary>
        /// Delete a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteQualityFormsSurveyWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->DeleteQualityFormsSurvey");

            var localVarPath = "/api/v2/quality/forms/surveys/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityFormsSurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityFormsSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteQualityFormsSurveyAsync (string formId)
        {
             await DeleteQualityFormsSurveyAsyncWithHttpInfo(formId);

        }

        /// <summary>
        /// Delete a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityFormsSurveyAsyncWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->DeleteQualityFormsSurvey");
            

            var localVarPath = "/api/v2/quality/forms/surveys/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityFormsSurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityFormsSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get status for async query for evaluation aggregates 
        /// 
        /// GetAnalyticsEvaluationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>AsyncQueryStatus</returns>
        
        public AsyncQueryStatus GetAnalyticsEvaluationsAggregatesJob (string jobId)
        {
             ApiResponse<AsyncQueryStatus> localVarResponse = GetAnalyticsEvaluationsAggregatesJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get status for async query for evaluation aggregates 
        /// 
        /// GetAnalyticsEvaluationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AsyncQueryStatus</returns>
        
        public ApiResponse< AsyncQueryStatus > GetAnalyticsEvaluationsAggregatesJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling QualityApi->GetAnalyticsEvaluationsAggregatesJob");

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsEvaluationsAggregatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsEvaluationsAggregatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get status for async query for evaluation aggregates 
        /// 
        /// GetAnalyticsEvaluationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AsyncQueryStatus</returns>
        
        public async System.Threading.Tasks.Task<AsyncQueryStatus> GetAnalyticsEvaluationsAggregatesJobAsync (string jobId)
        {
             ApiResponse<AsyncQueryStatus> localVarResponse = await GetAnalyticsEvaluationsAggregatesJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get status for async query for evaluation aggregates 
        /// 
        /// GetAnalyticsEvaluationsAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AsyncQueryStatus>> GetAnalyticsEvaluationsAggregatesJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling QualityApi->GetAnalyticsEvaluationsAggregatesJob");
            

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsEvaluationsAggregatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsEvaluationsAggregatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsEvaluationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>EvaluationAsyncAggregateQueryResponse</returns>
        
        public EvaluationAsyncAggregateQueryResponse GetAnalyticsEvaluationsAggregatesJobResults (string jobId, string cursor = null)
        {
             ApiResponse<EvaluationAsyncAggregateQueryResponse> localVarResponse = GetAnalyticsEvaluationsAggregatesJobResultsWithHttpInfo(jobId, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsEvaluationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>ApiResponse of EvaluationAsyncAggregateQueryResponse</returns>
        
        public ApiResponse< EvaluationAsyncAggregateQueryResponse > GetAnalyticsEvaluationsAggregatesJobResultsWithHttpInfo (string jobId, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling QualityApi->GetAnalyticsEvaluationsAggregatesJobResults");

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/jobs/{jobId}/results";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsEvaluationsAggregatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsEvaluationsAggregatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationAsyncAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationAsyncAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationAsyncAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsEvaluationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of EvaluationAsyncAggregateQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationAsyncAggregateQueryResponse> GetAnalyticsEvaluationsAggregatesJobResultsAsync (string jobId, string cursor = null)
        {
             ApiResponse<EvaluationAsyncAggregateQueryResponse> localVarResponse = await GetAnalyticsEvaluationsAggregatesJobResultsAsyncWithHttpInfo(jobId, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsEvaluationsAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationAsyncAggregateQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationAsyncAggregateQueryResponse>> GetAnalyticsEvaluationsAggregatesJobResultsAsyncWithHttpInfo (string jobId, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling QualityApi->GetAnalyticsEvaluationsAggregatesJobResults");
            

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/jobs/{jobId}/results";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsEvaluationsAggregatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsEvaluationsAggregatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationAsyncAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationAsyncAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationAsyncAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get status for async query for survey aggregates 
        /// 
        /// GetAnalyticsSurveysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>AsyncQueryStatus</returns>
        
        public AsyncQueryStatus GetAnalyticsSurveysAggregatesJob (string jobId)
        {
             ApiResponse<AsyncQueryStatus> localVarResponse = GetAnalyticsSurveysAggregatesJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get status for async query for survey aggregates 
        /// 
        /// GetAnalyticsSurveysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of AsyncQueryStatus</returns>
        
        public ApiResponse< AsyncQueryStatus > GetAnalyticsSurveysAggregatesJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling QualityApi->GetAnalyticsSurveysAggregatesJob");

            var localVarPath = "/api/v2/analytics/surveys/aggregates/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
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
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsSurveysAggregatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsSurveysAggregatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get status for async query for survey aggregates 
        /// 
        /// GetAnalyticsSurveysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of AsyncQueryStatus</returns>
        
        public async System.Threading.Tasks.Task<AsyncQueryStatus> GetAnalyticsSurveysAggregatesJobAsync (string jobId)
        {
             ApiResponse<AsyncQueryStatus> localVarResponse = await GetAnalyticsSurveysAggregatesJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get status for async query for survey aggregates 
        /// 
        /// GetAnalyticsSurveysAggregatesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (AsyncQueryStatus)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AsyncQueryStatus>> GetAnalyticsSurveysAggregatesJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling QualityApi->GetAnalyticsSurveysAggregatesJob");
            

            var localVarPath = "/api/v2/analytics/surveys/aggregates/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
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
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsSurveysAggregatesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsSurveysAggregatesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryStatus>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsSurveysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>SurveyAsyncAggregateQueryResponse</returns>
        
        public SurveyAsyncAggregateQueryResponse GetAnalyticsSurveysAggregatesJobResults (string jobId, string cursor = null)
        {
             ApiResponse<SurveyAsyncAggregateQueryResponse> localVarResponse = GetAnalyticsSurveysAggregatesJobResultsWithHttpInfo(jobId, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsSurveysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>ApiResponse of SurveyAsyncAggregateQueryResponse</returns>
        
        public ApiResponse< SurveyAsyncAggregateQueryResponse > GetAnalyticsSurveysAggregatesJobResultsWithHttpInfo (string jobId, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling QualityApi->GetAnalyticsSurveysAggregatesJobResults");

            var localVarPath = "/api/v2/analytics/surveys/aggregates/jobs/{jobId}/results";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsSurveysAggregatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsSurveysAggregatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyAsyncAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (SurveyAsyncAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyAsyncAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsSurveysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of SurveyAsyncAggregateQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<SurveyAsyncAggregateQueryResponse> GetAnalyticsSurveysAggregatesJobResultsAsync (string jobId, string cursor = null)
        {
             ApiResponse<SurveyAsyncAggregateQueryResponse> localVarResponse = await GetAnalyticsSurveysAggregatesJobResultsAsyncWithHttpInfo(jobId, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a page of results for an async aggregates query 
        /// 
        /// GetAnalyticsSurveysAggregatesJobResults is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <param name="cursor">Cursor token to retrieve next page (optional)</param>
        /// <returns>Task of ApiResponse (SurveyAsyncAggregateQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyAsyncAggregateQueryResponse>> GetAnalyticsSurveysAggregatesJobResultsAsyncWithHttpInfo (string jobId, string cursor = null)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling QualityApi->GetAnalyticsSurveysAggregatesJobResults");
            

            var localVarPath = "/api/v2/analytics/surveys/aggregates/jobs/{jobId}/results";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsSurveysAggregatesJobResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAnalyticsSurveysAggregatesJobResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyAsyncAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (SurveyAsyncAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyAsyncAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets a list of Agent Activities 
        /// Each item on the list shows one agent's evaluation activity comprised of the number of evaluations and the highest, average, and lowest standard and critical scores, as well as a sub list showing the number and average score of evaluations for each evaluator for that agent.  evaluatorUserId, startTime, and endTime are all filtering criteria. If specified, the only evaluations used to compile the agent activity response will be ones that match the filtering criteria. agentUserId, name, group, and agentTeamId are all agent selection criteria. criteria.  If one or more agent selection criteria are specified, then the returned activity will include users that match the criteria even if those users did not have any agent activity or evaluations that do not match any filtering criteria.  If no agent selection criteria are specified but an evaluatorUserId is, then the returned activity will be only for those agents that had evaluations where the evaluator is the evaluatorUserId.  If no agent selection criteria are specified and no evaluatorUserId is specified, then the returned activity will be for all users
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents requested (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <returns>AgentActivityEntityListing</returns>
        
        public AgentActivityEntityListing GetQualityAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null)
        {
             ApiResponse<AgentActivityEntityListing> localVarResponse = GetQualityAgentsActivityWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, agentUserId, evaluatorUserId, name, group, agentTeamId, formContextId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of Agent Activities 
        /// Each item on the list shows one agent's evaluation activity comprised of the number of evaluations and the highest, average, and lowest standard and critical scores, as well as a sub list showing the number and average score of evaluations for each evaluator for that agent.  evaluatorUserId, startTime, and endTime are all filtering criteria. If specified, the only evaluations used to compile the agent activity response will be ones that match the filtering criteria. agentUserId, name, group, and agentTeamId are all agent selection criteria. criteria.  If one or more agent selection criteria are specified, then the returned activity will include users that match the criteria even if those users did not have any agent activity or evaluations that do not match any filtering criteria.  If no agent selection criteria are specified but an evaluatorUserId is, then the returned activity will be only for those agents that had evaluations where the evaluator is the evaluatorUserId.  If no agent selection criteria are specified and no evaluatorUserId is specified, then the returned activity will be for all users
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents requested (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        
        public ApiResponse< AgentActivityEntityListing > GetQualityAgentsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null)
        { 

            var localVarPath = "/api/v2/quality/agents/activity";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", this.Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", this.Configuration.ApiClient.ParameterToString(endTime)));
            if (agentUserId != null) agentUserId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("agentUserId", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (evaluatorUserId != null) localVarQueryParams.Add(new Tuple<string, string>("evaluatorUserId", this.Configuration.ApiClient.ParameterToString(evaluatorUserId)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (group != null) localVarQueryParams.Add(new Tuple<string, string>("group", this.Configuration.ApiClient.ParameterToString(group)));
            if (agentTeamId != null) localVarQueryParams.Add(new Tuple<string, string>("agentTeamId", this.Configuration.ApiClient.ParameterToString(agentTeamId)));
            if (formContextId != null) localVarQueryParams.Add(new Tuple<string, string>("formContextId", this.Configuration.ApiClient.ParameterToString(formContextId)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityAgentsActivity: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityAgentsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AgentActivityEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentActivityEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets a list of Agent Activities 
        /// Each item on the list shows one agent's evaluation activity comprised of the number of evaluations and the highest, average, and lowest standard and critical scores, as well as a sub list showing the number and average score of evaluations for each evaluator for that agent.  evaluatorUserId, startTime, and endTime are all filtering criteria. If specified, the only evaluations used to compile the agent activity response will be ones that match the filtering criteria. agentUserId, name, group, and agentTeamId are all agent selection criteria. criteria.  If one or more agent selection criteria are specified, then the returned activity will include users that match the criteria even if those users did not have any agent activity or evaluations that do not match any filtering criteria.  If no agent selection criteria are specified but an evaluatorUserId is, then the returned activity will be only for those agents that had evaluations where the evaluator is the evaluatorUserId.  If no agent selection criteria are specified and no evaluatorUserId is specified, then the returned activity will be for all users
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents requested (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <returns>Task of AgentActivityEntityListing</returns>
        
        public async System.Threading.Tasks.Task<AgentActivityEntityListing> GetQualityAgentsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null)
        {
             ApiResponse<AgentActivityEntityListing> localVarResponse = await GetQualityAgentsActivityAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, agentUserId, evaluatorUserId, name, group, agentTeamId, formContextId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of Agent Activities 
        /// Each item on the list shows one agent's evaluation activity comprised of the number of evaluations and the highest, average, and lowest standard and critical scores, as well as a sub list showing the number and average score of evaluations for each evaluator for that agent.  evaluatorUserId, startTime, and endTime are all filtering criteria. If specified, the only evaluations used to compile the agent activity response will be ones that match the filtering criteria. agentUserId, name, group, and agentTeamId are all agent selection criteria. criteria.  If one or more agent selection criteria are specified, then the returned activity will include users that match the criteria even if those users did not have any agent activity or evaluations that do not match any filtering criteria.  If no agent selection criteria are specified but an evaluatorUserId is, then the returned activity will be only for those agents that had evaluations where the evaluator is the evaluatorUserId.  If no agent selection criteria are specified and no evaluatorUserId is specified, then the returned activity will be for all users
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">End time of agent activity based on assigned date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents requested (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <returns>Task of ApiResponse (AgentActivityEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> GetQualityAgentsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null, string agentTeamId = null, string formContextId = null)
        { 

            var localVarPath = "/api/v2/quality/agents/activity";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", this.Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", this.Configuration.ApiClient.ParameterToString(endTime)));
            if (agentUserId != null) agentUserId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("agentUserId", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (evaluatorUserId != null) localVarQueryParams.Add(new Tuple<string, string>("evaluatorUserId", this.Configuration.ApiClient.ParameterToString(evaluatorUserId)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (group != null) localVarQueryParams.Add(new Tuple<string, string>("group", this.Configuration.ApiClient.ParameterToString(group)));
            if (agentTeamId != null) localVarQueryParams.Add(new Tuple<string, string>("agentTeamId", this.Configuration.ApiClient.ParameterToString(agentTeamId)));
            if (formContextId != null) localVarQueryParams.Add(new Tuple<string, string>("formContextId", this.Configuration.ApiClient.ParameterToString(formContextId)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityAgentsActivity: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityAgentsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AgentActivityEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentActivityEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a calibration by id.  Requires either calibrator id or conversation id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Calibration</returns>
        
        public Calibration GetQualityCalibration (string calibrationId, string calibratorId = null, string conversationId = null)
        {
             ApiResponse<Calibration> localVarResponse = GetQualityCalibrationWithHttpInfo(calibrationId, calibratorId, conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a calibration by id.  Requires either calibrator id or conversation id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        
        public ApiResponse< Calibration > GetQualityCalibrationWithHttpInfo (string calibrationId, string calibratorId = null, string conversationId = null)
        { 
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->GetQualityCalibration");

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (calibrationId != null) localVarPathParams.Add("calibrationId", this.Configuration.ApiClient.ParameterToString(calibrationId));

            // Query params
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", this.Configuration.ApiClient.ParameterToString(calibratorId)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a calibration by id.  Requires either calibrator id or conversation id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of Calibration</returns>
        
        public async System.Threading.Tasks.Task<Calibration> GetQualityCalibrationAsync (string calibrationId, string calibratorId = null, string conversationId = null)
        {
             ApiResponse<Calibration> localVarResponse = await GetQualityCalibrationAsyncWithHttpInfo(calibrationId, calibratorId, conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a calibration by id.  Requires either calibrator id or conversation id 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> GetQualityCalibrationAsyncWithHttpInfo (string calibrationId, string calibratorId = null, string conversationId = null)
        { 
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->GetQualityCalibration");
            

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (calibrationId != null) localVarPathParams.Add("calibrationId", this.Configuration.ApiClient.ParameterToString(calibrationId));

            // Query params
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", this.Configuration.ApiClient.ParameterToString(calibratorId)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of calibrations 
        /// NOTE: The count for total and pageCount might not be accurate when querying for a large number of calibrations. nextUri, if present, will indicate that there are more calibrations to fetch.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <returns>CalibrationEntityListing</returns>
        
        public CalibrationEntityListing GetQualityCalibrations (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
        {
             ApiResponse<CalibrationEntityListing> localVarResponse = GetQualityCalibrationsWithHttpInfo(calibratorId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, startTime, endTime);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of calibrations 
        /// NOTE: The count for total and pageCount might not be accurate when querying for a large number of calibrations. nextUri, if present, will indicate that there are more calibrations to fetch.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <returns>ApiResponse of CalibrationEntityListing</returns>
        
        public ApiResponse< CalibrationEntityListing > GetQualityCalibrationsWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
        { 
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->GetQualityCalibrations");

            var localVarPath = "/api/v2/quality/calibrations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", this.Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", this.Configuration.ApiClient.ParameterToString(endTime)));
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", this.Configuration.ApiClient.ParameterToString(calibratorId)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CalibrationEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalibrationEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of calibrations 
        /// NOTE: The count for total and pageCount might not be accurate when querying for a large number of calibrations. nextUri, if present, will indicate that there are more calibrations to fetch.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <returns>Task of CalibrationEntityListing</returns>
        
        public async System.Threading.Tasks.Task<CalibrationEntityListing> GetQualityCalibrationsAsync (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
        {
             ApiResponse<CalibrationEntityListing> localVarResponse = await GetQualityCalibrationsAsyncWithHttpInfo(calibratorId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, startTime, endTime);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of calibrations 
        /// NOTE: The count for total and pageCount might not be accurate when querying for a large number of calibrations. nextUri, if present, will indicate that there are more calibrations to fetch.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <returns>Task of ApiResponse (CalibrationEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> GetQualityCalibrationsAsyncWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
        { 
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->GetQualityCalibrations");
            

            var localVarPath = "/api/v2/quality/calibrations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", this.Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", this.Configuration.ApiClient.ParameterToString(endTime)));
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", this.Configuration.ApiClient.ParameterToString(calibratorId)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CalibrationEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalibrationEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, assignee, evaluator, evaluationForm (optional)</param>
        /// <returns>EvaluationResponse</returns>
        
        public EvaluationResponse GetQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<EvaluationResponse> localVarResponse = GetQualityConversationEvaluationWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, assignee, evaluator, evaluationForm (optional)</param>
        /// <returns>ApiResponse of EvaluationResponse</returns>
        
        public ApiResponse< EvaluationResponse > GetQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetQualityConversationEvaluation");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->GetQualityConversationEvaluation");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", this.Configuration.ApiClient.ParameterToString(evaluationId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, assignee, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of EvaluationResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationResponse> GetQualityConversationEvaluationAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<EvaluationResponse> localVarResponse = await GetQualityConversationEvaluationAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, assignee, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationResponse>> GetQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetQualityConversationEvaluation");
            
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->GetQualityConversationEvaluation");
            

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", this.Configuration.ApiClient.ParameterToString(evaluationId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the surveys for a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>List&lt;Survey&gt;</returns>
        
        public List<Survey> GetQualityConversationSurveys (string conversationId)
        {
             ApiResponse<List<Survey>> localVarResponse = GetQualityConversationSurveysWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the surveys for a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of List&lt;Survey&gt;</returns>
        
        public ApiResponse< List<Survey> > GetQualityConversationSurveysWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetQualityConversationSurveys");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/surveys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationSurveys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationSurveys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Survey>>(localVarStatusCode,
                localVarHeaders,
                (List<Survey>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Survey>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the surveys for a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of List&lt;Survey&gt;</returns>
        
        public async System.Threading.Tasks.Task<List<Survey>> GetQualityConversationSurveysAsync (string conversationId)
        {
             ApiResponse<List<Survey>> localVarResponse = await GetQualityConversationSurveysAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the surveys for a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (List&lt;Survey&gt;)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<List<Survey>>> GetQualityConversationSurveysAsyncWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetQualityConversationSurveys");
            

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/surveys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationSurveys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationSurveys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Survey>>(localVarStatusCode,
                localVarHeaders,
                (List<Survey>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Survey>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get status of audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>QualityAuditQueryExecutionStatusResponse</returns>
        
        public QualityAuditQueryExecutionStatusResponse GetQualityConversationsAuditsQueryTransactionId (string transactionId)
        {
             ApiResponse<QualityAuditQueryExecutionStatusResponse> localVarResponse = GetQualityConversationsAuditsQueryTransactionIdWithHttpInfo(transactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get status of audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>ApiResponse of QualityAuditQueryExecutionStatusResponse</returns>
        
        public ApiResponse< QualityAuditQueryExecutionStatusResponse > GetQualityConversationsAuditsQueryTransactionIdWithHttpInfo (string transactionId)
        { 
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling QualityApi->GetQualityConversationsAuditsQueryTransactionId");

            var localVarPath = "/api/v2/quality/conversations/audits/query/{transactionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationsAuditsQueryTransactionId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationsAuditsQueryTransactionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditQueryExecutionStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (QualityAuditQueryExecutionStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditQueryExecutionStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get status of audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>Task of QualityAuditQueryExecutionStatusResponse</returns>
        
        public async System.Threading.Tasks.Task<QualityAuditQueryExecutionStatusResponse> GetQualityConversationsAuditsQueryTransactionIdAsync (string transactionId)
        {
             ApiResponse<QualityAuditQueryExecutionStatusResponse> localVarResponse = await GetQualityConversationsAuditsQueryTransactionIdAsyncWithHttpInfo(transactionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get status of audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <returns>Task of ApiResponse (QualityAuditQueryExecutionStatusResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<QualityAuditQueryExecutionStatusResponse>> GetQualityConversationsAuditsQueryTransactionIdAsyncWithHttpInfo (string transactionId)
        { 
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling QualityApi->GetQualityConversationsAuditsQueryTransactionId");
            

            var localVarPath = "/api/v2/quality/conversations/audits/query/{transactionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationsAuditsQueryTransactionId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationsAuditsQueryTransactionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditQueryExecutionStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (QualityAuditQueryExecutionStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditQueryExecutionStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get results of audit query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>QualityAuditQueryExecutionResultsResponse</returns>
        
        public QualityAuditQueryExecutionResultsResponse GetQualityConversationsAuditsQueryTransactionIdResults (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)
        {
             ApiResponse<QualityAuditQueryExecutionResultsResponse> localVarResponse = GetQualityConversationsAuditsQueryTransactionIdResultsWithHttpInfo(transactionId, cursor, pageSize, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get results of audit query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of QualityAuditQueryExecutionResultsResponse</returns>
        
        public ApiResponse< QualityAuditQueryExecutionResultsResponse > GetQualityConversationsAuditsQueryTransactionIdResultsWithHttpInfo (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)
        { 
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling QualityApi->GetQualityConversationsAuditsQueryTransactionIdResults");

            var localVarPath = "/api/v2/quality/conversations/audits/query/{transactionId}/results";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId));

            // Query params
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationsAuditsQueryTransactionIdResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationsAuditsQueryTransactionIdResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditQueryExecutionResultsResponse>(localVarStatusCode,
                localVarHeaders,
                (QualityAuditQueryExecutionResultsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditQueryExecutionResultsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get results of audit query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of QualityAuditQueryExecutionResultsResponse</returns>
        
        public async System.Threading.Tasks.Task<QualityAuditQueryExecutionResultsResponse> GetQualityConversationsAuditsQueryTransactionIdResultsAsync (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)
        {
             ApiResponse<QualityAuditQueryExecutionResultsResponse> localVarResponse = await GetQualityConversationsAuditsQueryTransactionIdResultsAsyncWithHttpInfo(transactionId, cursor, pageSize, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get results of audit query 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction ID</param>
        /// <param name="cursor">Indicates where to resume query results (not required for first page) (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (QualityAuditQueryExecutionResultsResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<QualityAuditQueryExecutionResultsResponse>> GetQualityConversationsAuditsQueryTransactionIdResultsAsyncWithHttpInfo (string transactionId, string cursor = null, int? pageSize = null, List<string> expand = null)
        { 
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling QualityApi->GetQualityConversationsAuditsQueryTransactionIdResults");
            

            var localVarPath = "/api/v2/quality/conversations/audits/query/{transactionId}/results";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId));

            // Query params
            if (cursor != null) localVarQueryParams.Add(new Tuple<string, string>("cursor", this.Configuration.ApiClient.ParameterToString(cursor)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationsAuditsQueryTransactionIdResults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationsAuditsQueryTransactionIdResults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditQueryExecutionResultsResponse>(localVarStatusCode,
                localVarHeaders,
                (QualityAuditQueryExecutionResultsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditQueryExecutionResultsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Queries Evaluations and returns a paged list 
        /// Query params must include one of conversationId, evaluatorUserId, agentUserId or assigneeUserId. When querying by agentUserId (and not conversationId or evaluatorUserId), the results are sorted by release date. Evaluations set to 'Never Release' are omitted in this case. When querying by evaluatorUserId or conversationId (including when combined with agentUserId), the results are sorted by assigned date. NOTE: The count for total and pageCount might not be accurate when querying for a large number of evaluations. nextUri, if present, will indicate that there are more evaluations to fetch. The evaluation entities contained in the response might only contain a subset of all the properties listed below. It is often because a given property's value has not yet been populated or is not applicable in the current state of the evaluation. It might also be because the missing property in the response was not requested by the user.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="agentTeamId">team id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="assigneeUserId">assignee user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <param name="evaluationState"> (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations. NOTE: The answers will only be populated if this parameter is set to true in the request. (optional)</param>
        /// <param name="maximum">the maximum number of results to return (optional)</param>
        /// <param name="sortOrder">NOTE: Does not work when conversationId is supplied. (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        
        public EvaluationEntityListing GetQualityEvaluationsQuery (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = GetQualityEvaluationsQueryWithHttpInfo(pageSize, pageNumber, expand, previousPage, conversationId, agentUserId, agentTeamId, evaluatorUserId, assigneeUserId, queueId, startTime, endTime, formContextId, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Queries Evaluations and returns a paged list 
        /// Query params must include one of conversationId, evaluatorUserId, agentUserId or assigneeUserId. When querying by agentUserId (and not conversationId or evaluatorUserId), the results are sorted by release date. Evaluations set to 'Never Release' are omitted in this case. When querying by evaluatorUserId or conversationId (including when combined with agentUserId), the results are sorted by assigned date. NOTE: The count for total and pageCount might not be accurate when querying for a large number of evaluations. nextUri, if present, will indicate that there are more evaluations to fetch. The evaluation entities contained in the response might only contain a subset of all the properties listed below. It is often because a given property's value has not yet been populated or is not applicable in the current state of the evaluation. It might also be because the missing property in the response was not requested by the user.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="agentTeamId">team id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="assigneeUserId">assignee user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <param name="evaluationState"> (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations. NOTE: The answers will only be populated if this parameter is set to true in the request. (optional)</param>
        /// <param name="maximum">the maximum number of results to return (optional)</param>
        /// <param name="sortOrder">NOTE: Does not work when conversationId is supplied. (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        
        public ApiResponse< EvaluationEntityListing > GetQualityEvaluationsQueryWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/quality/evaluations/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId)));
            if (agentUserId != null) localVarQueryParams.Add(new Tuple<string, string>("agentUserId", this.Configuration.ApiClient.ParameterToString(agentUserId)));
            if (agentTeamId != null) localVarQueryParams.Add(new Tuple<string, string>("agentTeamId", this.Configuration.ApiClient.ParameterToString(agentTeamId)));
            if (evaluatorUserId != null) localVarQueryParams.Add(new Tuple<string, string>("evaluatorUserId", this.Configuration.ApiClient.ParameterToString(evaluatorUserId)));
            if (assigneeUserId != null) localVarQueryParams.Add(new Tuple<string, string>("assigneeUserId", this.Configuration.ApiClient.ParameterToString(assigneeUserId)));
            if (queueId != null) localVarQueryParams.Add(new Tuple<string, string>("queueId", this.Configuration.ApiClient.ParameterToString(queueId)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", this.Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", this.Configuration.ApiClient.ParameterToString(endTime)));
            if (formContextId != null) localVarQueryParams.Add(new Tuple<string, string>("formContextId", this.Configuration.ApiClient.ParameterToString(formContextId)));
            if (evaluationState != null) evaluationState.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("evaluationState", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (isReleased != null) localVarQueryParams.Add(new Tuple<string, string>("isReleased", this.Configuration.ApiClient.ParameterToString(isReleased)));
            if (agentHasRead != null) localVarQueryParams.Add(new Tuple<string, string>("agentHasRead", this.Configuration.ApiClient.ParameterToString(agentHasRead)));
            if (expandAnswerTotalScores != null) localVarQueryParams.Add(new Tuple<string, string>("expandAnswerTotalScores", this.Configuration.ApiClient.ParameterToString(expandAnswerTotalScores)));
            if (maximum != null) localVarQueryParams.Add(new Tuple<string, string>("maximum", this.Configuration.ApiClient.ParameterToString(maximum)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Queries Evaluations and returns a paged list 
        /// Query params must include one of conversationId, evaluatorUserId, agentUserId or assigneeUserId. When querying by agentUserId (and not conversationId or evaluatorUserId), the results are sorted by release date. Evaluations set to 'Never Release' are omitted in this case. When querying by evaluatorUserId or conversationId (including when combined with agentUserId), the results are sorted by assigned date. NOTE: The count for total and pageCount might not be accurate when querying for a large number of evaluations. nextUri, if present, will indicate that there are more evaluations to fetch. The evaluation entities contained in the response might only contain a subset of all the properties listed below. It is often because a given property's value has not yet been populated or is not applicable in the current state of the evaluation. It might also be because the missing property in the response was not requested by the user.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="agentTeamId">team id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="assigneeUserId">assignee user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <param name="evaluationState"> (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations. NOTE: The answers will only be populated if this parameter is set to true in the request. (optional)</param>
        /// <param name="maximum">the maximum number of results to return (optional)</param>
        /// <param name="sortOrder">NOTE: Does not work when conversationId is supplied. (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        
        public async System.Threading.Tasks.Task<EvaluationEntityListing> GetQualityEvaluationsQueryAsync (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = await GetQualityEvaluationsQueryAsyncWithHttpInfo(pageSize, pageNumber, expand, previousPage, conversationId, agentUserId, agentTeamId, evaluatorUserId, assigneeUserId, queueId, startTime, endTime, formContextId, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Queries Evaluations and returns a paged list 
        /// Query params must include one of conversationId, evaluatorUserId, agentUserId or assigneeUserId. When querying by agentUserId (and not conversationId or evaluatorUserId), the results are sorted by release date. Evaluations set to 'Never Release' are omitted in this case. When querying by evaluatorUserId or conversationId (including when combined with agentUserId), the results are sorted by assigned date. NOTE: The count for total and pageCount might not be accurate when querying for a large number of evaluations. nextUri, if present, will indicate that there are more evaluations to fetch. The evaluation entities contained in the response might only contain a subset of all the properties listed below. It is often because a given property's value has not yet been populated or is not applicable in the current state of the evaluation. It might also be because the missing property in the response was not requested by the user.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="agentTeamId">team id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="assigneeUserId">assignee user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="formContextId">shared id between form versions (optional)</param>
        /// <param name="evaluationState"> (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations. NOTE: The answers will only be populated if this parameter is set to true in the request. (optional)</param>
        /// <param name="maximum">the maximum number of results to return (optional)</param>
        /// <param name="sortOrder">NOTE: Does not work when conversationId is supplied. (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> GetQualityEvaluationsQueryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> expand = null, string previousPage = null, string conversationId = null, string agentUserId = null, string agentTeamId = null, string evaluatorUserId = null, string assigneeUserId = null, string queueId = null, string startTime = null, string endTime = null, string formContextId = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/quality/evaluations/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId)));
            if (agentUserId != null) localVarQueryParams.Add(new Tuple<string, string>("agentUserId", this.Configuration.ApiClient.ParameterToString(agentUserId)));
            if (agentTeamId != null) localVarQueryParams.Add(new Tuple<string, string>("agentTeamId", this.Configuration.ApiClient.ParameterToString(agentTeamId)));
            if (evaluatorUserId != null) localVarQueryParams.Add(new Tuple<string, string>("evaluatorUserId", this.Configuration.ApiClient.ParameterToString(evaluatorUserId)));
            if (assigneeUserId != null) localVarQueryParams.Add(new Tuple<string, string>("assigneeUserId", this.Configuration.ApiClient.ParameterToString(assigneeUserId)));
            if (queueId != null) localVarQueryParams.Add(new Tuple<string, string>("queueId", this.Configuration.ApiClient.ParameterToString(queueId)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", this.Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", this.Configuration.ApiClient.ParameterToString(endTime)));
            if (formContextId != null) localVarQueryParams.Add(new Tuple<string, string>("formContextId", this.Configuration.ApiClient.ParameterToString(formContextId)));
            if (evaluationState != null) evaluationState.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("evaluationState", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (isReleased != null) localVarQueryParams.Add(new Tuple<string, string>("isReleased", this.Configuration.ApiClient.ParameterToString(isReleased)));
            if (agentHasRead != null) localVarQueryParams.Add(new Tuple<string, string>("agentHasRead", this.Configuration.ApiClient.ParameterToString(agentHasRead)));
            if (expandAnswerTotalScores != null) localVarQueryParams.Add(new Tuple<string, string>("expandAnswerTotalScores", this.Configuration.ApiClient.ParameterToString(expandAnswerTotalScores)));
            if (maximum != null) localVarQueryParams.Add(new Tuple<string, string>("maximum", this.Configuration.ApiClient.ParameterToString(maximum)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an evaluator activity 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents to be considered (optional)</param>
        /// <returns>EvaluatorActivityEntityListing</returns>
        
        public EvaluatorActivityEntityListing GetQualityEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null, string agentTeamId = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> localVarResponse = GetQualityEvaluatorsActivityWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, name, permission, group, agentTeamId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an evaluator activity 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents to be considered (optional)</param>
        /// <returns>ApiResponse of EvaluatorActivityEntityListing</returns>
        
        public ApiResponse< EvaluatorActivityEntityListing > GetQualityEvaluatorsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null, string agentTeamId = null)
        { 

            var localVarPath = "/api/v2/quality/evaluators/activity";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", this.Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", this.Configuration.ApiClient.ParameterToString(endTime)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (permission != null) permission.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("permission", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (group != null) localVarQueryParams.Add(new Tuple<string, string>("group", this.Configuration.ApiClient.ParameterToString(group)));
            if (agentTeamId != null) localVarQueryParams.Add(new Tuple<string, string>("agentTeamId", this.Configuration.ApiClient.ParameterToString(agentTeamId)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluatorsActivity: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluatorsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluatorActivityEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluatorActivityEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an evaluator activity 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents to be considered (optional)</param>
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        
        public async System.Threading.Tasks.Task<EvaluatorActivityEntityListing> GetQualityEvaluatorsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null, string agentTeamId = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> localVarResponse = await GetQualityEvaluatorsActivityAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, name, permission, group, agentTeamId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an evaluator activity 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <param name="agentTeamId">team id of agents to be considered (optional)</param>
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> GetQualityEvaluatorsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null, string agentTeamId = null)
        { 

            var localVarPath = "/api/v2/quality/evaluators/activity";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", this.Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", this.Configuration.ApiClient.ParameterToString(endTime)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (permission != null) permission.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("permission", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (group != null) localVarQueryParams.Add(new Tuple<string, string>("group", this.Configuration.ApiClient.ParameterToString(group)));
            if (agentTeamId != null) localVarQueryParams.Add(new Tuple<string, string>("agentTeamId", this.Configuration.ApiClient.ParameterToString(agentTeamId)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluatorsActivity: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluatorsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluatorActivityEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluatorActivityEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an evaluation form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationFormResponse</returns>
        [Obsolete]
        public EvaluationFormResponse GetQualityForm (string formId)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = GetQualityFormWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an evaluation form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        [Obsolete]
        public ApiResponse< EvaluationFormResponse > GetQualityFormWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityForm");

            var localVarPath = "/api/v2/quality/forms/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an evaluation form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<EvaluationFormResponse> GetQualityFormAsync (string formId)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = await GetQualityFormAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an evaluation form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> GetQualityFormAsyncWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityForm");
            

            var localVarPath = "/api/v2/quality/forms/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        public EvaluationFormResponseEntityListing GetQualityFormVersions (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = GetQualityFormVersionsWithHttpInfo(formId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        public ApiResponse< EvaluationFormResponseEntityListing > GetQualityFormVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityFormVersions");

            var localVarPath = "/api/v2/quality/forms/{formId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityFormVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = await GetQualityFormVersionsAsyncWithHttpInfo(formId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityFormVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityFormVersions");
            

            var localVarPath = "/api/v2/quality/forms/{formId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        public EvaluationFormResponseEntityListing GetQualityForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = GetQualityFormsWithHttpInfo(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        public ApiResponse< EvaluationFormResponseEntityListing > GetQualityFormsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/quality/forms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityFormsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = await GetQualityFormsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityFormsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/quality/forms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get an evaluation form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationFormResponse</returns>
        
        public EvaluationFormResponse GetQualityFormsEvaluation (string formId)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = GetQualityFormsEvaluationWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an evaluation form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        
        public ApiResponse< EvaluationFormResponse > GetQualityFormsEvaluationWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityFormsEvaluation");

            var localVarPath = "/api/v2/quality/forms/evaluations/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get an evaluation form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationFormResponse> GetQualityFormsEvaluationAsync (string formId)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = await GetQualityFormsEvaluationAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an evaluation form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> GetQualityFormsEvaluationAsyncWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityFormsEvaluation");
            

            var localVarPath = "/api/v2/quality/forms/evaluations/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to "asc")</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        
        public EvaluationFormResponseEntityListing GetQualityFormsEvaluationVersions (string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = GetQualityFormsEvaluationVersionsWithHttpInfo(formId, pageSize, pageNumber, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to "asc")</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        
        public ApiResponse< EvaluationFormResponseEntityListing > GetQualityFormsEvaluationVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityFormsEvaluationVersions");

            var localVarPath = "/api/v2/quality/forms/evaluations/{formId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluationVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluationVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to "asc")</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        
        public async System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = await GetQualityFormsEvaluationVersionsAsyncWithHttpInfo(formId, pageSize, pageNumber, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to "asc")</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityFormsEvaluationVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityFormsEvaluationVersions");
            

            var localVarPath = "/api/v2/quality/forms/evaluations/{formId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluationVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluationVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of evaluation forms 
        /// By default, \"published\" field is always returned as false for all evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. In addition, \"questionGroups\", the detailed information about evaluation form, is not returned. We will enhance this field in a future release.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        
        public EvaluationFormResponseEntityListing GetQualityFormsEvaluations (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = GetQualityFormsEvaluationsWithHttpInfo(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// By default, \"published\" field is always returned as false for all evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. In addition, \"questionGroups\", the detailed information about evaluation form, is not returned. We will enhance this field in a future release.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        
        public ApiResponse< EvaluationFormResponseEntityListing > GetQualityFormsEvaluationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/quality/forms/evaluations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of evaluation forms 
        /// By default, \"published\" field is always returned as false for all evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. In addition, \"questionGroups\", the detailed information about evaluation form, is not returned. We will enhance this field in a future release.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        
        public async System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityFormsEvaluationsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = await GetQualityFormsEvaluationsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// By default, \"published\" field is always returned as false for all evaluation forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding evaluation form. In addition, \"questionGroups\", the detailed information about evaluation form, is not returned. We will enhance this field in a future release.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityFormsEvaluationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/quality/forms/evaluations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a list of the latest published evaluation form versions by context ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid evaluation form context ids</param>
        /// <returns>List&lt;EvaluationFormResponse&gt;</returns>
        
        public List<EvaluationFormResponse> GetQualityFormsEvaluationsBulkContexts (List<string> contextId)
        {
             ApiResponse<List<EvaluationFormResponse>> localVarResponse = GetQualityFormsEvaluationsBulkContextsWithHttpInfo(contextId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of the latest published evaluation form versions by context ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid evaluation form context ids</param>
        /// <returns>ApiResponse of List&lt;EvaluationFormResponse&gt;</returns>
        
        public ApiResponse< List<EvaluationFormResponse> > GetQualityFormsEvaluationsBulkContextsWithHttpInfo (List<string> contextId)
        { 
            // verify the required parameter 'contextId' is set
            if (contextId == null)
                throw new ApiException(400, "Missing required parameter 'contextId' when calling QualityApi->GetQualityFormsEvaluationsBulkContexts");

            var localVarPath = "/api/v2/quality/forms/evaluations/bulk/contexts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (contextId != null) contextId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("contextId", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluationsBulkContexts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluationsBulkContexts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<EvaluationFormResponse>>(localVarStatusCode,
                localVarHeaders,
                (List<EvaluationFormResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EvaluationFormResponse>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a list of the latest published evaluation form versions by context ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid evaluation form context ids</param>
        /// <returns>Task of List&lt;EvaluationFormResponse&gt;</returns>
        
        public async System.Threading.Tasks.Task<List<EvaluationFormResponse>> GetQualityFormsEvaluationsBulkContextsAsync (List<string> contextId)
        {
             ApiResponse<List<EvaluationFormResponse>> localVarResponse = await GetQualityFormsEvaluationsBulkContextsAsyncWithHttpInfo(contextId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of the latest published evaluation form versions by context ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid evaluation form context ids</param>
        /// <returns>Task of ApiResponse (List&lt;EvaluationFormResponse&gt;)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<List<EvaluationFormResponse>>> GetQualityFormsEvaluationsBulkContextsAsyncWithHttpInfo (List<string> contextId)
        { 
            // verify the required parameter 'contextId' is set
            if (contextId == null)
                throw new ApiException(400, "Missing required parameter 'contextId' when calling QualityApi->GetQualityFormsEvaluationsBulkContexts");
            

            var localVarPath = "/api/v2/quality/forms/evaluations/bulk/contexts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (contextId != null) contextId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("contextId", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluationsBulkContexts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsEvaluationsBulkContexts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<EvaluationFormResponse>>(localVarStatusCode,
                localVarHeaders,
                (List<EvaluationFormResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EvaluationFormResponse>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a survey form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>SurveyForm</returns>
        
        public SurveyForm GetQualityFormsSurvey (string formId)
        {
             ApiResponse<SurveyForm> localVarResponse = GetQualityFormsSurveyWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a survey form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        public ApiResponse< SurveyForm > GetQualityFormsSurveyWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityFormsSurvey");

            var localVarPath = "/api/v2/quality/forms/surveys/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a survey form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of SurveyForm</returns>
        
        public async System.Threading.Tasks.Task<SurveyForm> GetQualityFormsSurveyAsync (string formId)
        {
             ApiResponse<SurveyForm> localVarResponse = await GetQualityFormsSurveyAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a survey form 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyForm>> GetQualityFormsSurveyAsyncWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityFormsSurvey");
            

            var localVarPath = "/api/v2/quality/forms/surveys/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gets all the revisions for a specific survey. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SurveyFormEntityListing</returns>
        
        public SurveyFormEntityListing GetQualityFormsSurveyVersions (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SurveyFormEntityListing> localVarResponse = GetQualityFormsSurveyVersionsWithHttpInfo(formId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all the revisions for a specific survey. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SurveyFormEntityListing</returns>
        
        public ApiResponse< SurveyFormEntityListing > GetQualityFormsSurveyVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityFormsSurveyVersions");

            var localVarPath = "/api/v2/quality/forms/surveys/{formId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveyVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveyVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SurveyFormEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyFormEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gets all the revisions for a specific survey. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SurveyFormEntityListing</returns>
        
        public async System.Threading.Tasks.Task<SurveyFormEntityListing> GetQualityFormsSurveyVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SurveyFormEntityListing> localVarResponse = await GetQualityFormsSurveyVersionsAsyncWithHttpInfo(formId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all the revisions for a specific survey. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SurveyFormEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyFormEntityListing>> GetQualityFormsSurveyVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityFormsSurveyVersions");
            

            var localVarPath = "/api/v2/quality/forms/surveys/{formId}/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveyVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveyVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SurveyFormEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyFormEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the list of survey forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>SurveyFormEntityListing</returns>
        
        public SurveyFormEntityListing GetQualityFormsSurveys (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        {
             ApiResponse<SurveyFormEntityListing> localVarResponse = GetQualityFormsSurveysWithHttpInfo(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of survey forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>ApiResponse of SurveyFormEntityListing</returns>
        
        public ApiResponse< SurveyFormEntityListing > GetQualityFormsSurveysWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/quality/forms/surveys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SurveyFormEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyFormEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the list of survey forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of SurveyFormEntityListing</returns>
        
        public async System.Threading.Tasks.Task<SurveyFormEntityListing> GetQualityFormsSurveysAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        {
             ApiResponse<SurveyFormEntityListing> localVarResponse = await GetQualityFormsSurveysAsyncWithHttpInfo(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of survey forms. If you set \"expand=publishHistory\", then you will be able to get published versions for each corresponding survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">If &#39;expand&#x3D;publishHistory&#39;, then each unpublished evaluation form includes a listing of its published versions (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortOrder">Order to sort results, either asc or desc (optional)</param>
        /// <returns>Task of ApiResponse (SurveyFormEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyFormEntityListing>> GetQualityFormsSurveysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null, string sortOrder = null)
        { 

            var localVarPath = "/api/v2/quality/forms/surveys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", this.Configuration.ApiClient.ParameterToString(previousPage)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SurveyFormEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyFormEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a list of survey forms by their ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A comma-delimited list of valid survey form ids</param>
        /// <returns>SurveyFormEntityListing</returns>
        
        public SurveyFormEntityListing GetQualityFormsSurveysBulk (List<string> id)
        {
             ApiResponse<SurveyFormEntityListing> localVarResponse = GetQualityFormsSurveysBulkWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of survey forms by their ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A comma-delimited list of valid survey form ids</param>
        /// <returns>ApiResponse of SurveyFormEntityListing</returns>
        
        public ApiResponse< SurveyFormEntityListing > GetQualityFormsSurveysBulkWithHttpInfo (List<string> id)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling QualityApi->GetQualityFormsSurveysBulk");

            var localVarPath = "/api/v2/quality/forms/surveys/bulk";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveysBulk: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveysBulk: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SurveyFormEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyFormEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a list of survey forms by their ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A comma-delimited list of valid survey form ids</param>
        /// <returns>Task of SurveyFormEntityListing</returns>
        
        public async System.Threading.Tasks.Task<SurveyFormEntityListing> GetQualityFormsSurveysBulkAsync (List<string> id)
        {
             ApiResponse<SurveyFormEntityListing> localVarResponse = await GetQualityFormsSurveysBulkAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of survey forms by their ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A comma-delimited list of valid survey form ids</param>
        /// <returns>Task of ApiResponse (SurveyFormEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyFormEntityListing>> GetQualityFormsSurveysBulkAsyncWithHttpInfo (List<string> id)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling QualityApi->GetQualityFormsSurveysBulk");
            

            var localVarPath = "/api/v2/quality/forms/surveys/bulk";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveysBulk: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveysBulk: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SurveyFormEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyFormEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Retrieve a list of the latest form versions by context ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid survey form context ids. The maximum number of ids allowed in this list is 100.</param>
        /// <param name="published">If true, the latest published version will be included. If false, only the unpublished version will be included. (optional, default to true)</param>
        /// <returns>List&lt;SurveyForm&gt;</returns>
        
        public List<SurveyForm> GetQualityFormsSurveysBulkContexts (List<string> contextId, bool? published = null)
        {
             ApiResponse<List<SurveyForm>> localVarResponse = GetQualityFormsSurveysBulkContextsWithHttpInfo(contextId, published);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of the latest form versions by context ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid survey form context ids. The maximum number of ids allowed in this list is 100.</param>
        /// <param name="published">If true, the latest published version will be included. If false, only the unpublished version will be included. (optional, default to true)</param>
        /// <returns>ApiResponse of List&lt;SurveyForm&gt;</returns>
        
        public ApiResponse< List<SurveyForm> > GetQualityFormsSurveysBulkContextsWithHttpInfo (List<string> contextId, bool? published = null)
        { 
            // verify the required parameter 'contextId' is set
            if (contextId == null)
                throw new ApiException(400, "Missing required parameter 'contextId' when calling QualityApi->GetQualityFormsSurveysBulkContexts");

            var localVarPath = "/api/v2/quality/forms/surveys/bulk/contexts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (contextId != null) contextId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("contextId", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (published != null) localVarQueryParams.Add(new Tuple<string, string>("published", this.Configuration.ApiClient.ParameterToString(published)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveysBulkContexts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveysBulkContexts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<SurveyForm>>(localVarStatusCode,
                localVarHeaders,
                (List<SurveyForm>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SurveyForm>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Retrieve a list of the latest form versions by context ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid survey form context ids. The maximum number of ids allowed in this list is 100.</param>
        /// <param name="published">If true, the latest published version will be included. If false, only the unpublished version will be included. (optional, default to true)</param>
        /// <returns>Task of List&lt;SurveyForm&gt;</returns>
        
        public async System.Threading.Tasks.Task<List<SurveyForm>> GetQualityFormsSurveysBulkContextsAsync (List<string> contextId, bool? published = null)
        {
             ApiResponse<List<SurveyForm>> localVarResponse = await GetQualityFormsSurveysBulkContextsAsyncWithHttpInfo(contextId, published);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of the latest form versions by context ids 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contextId">A comma-delimited list of valid survey form context ids. The maximum number of ids allowed in this list is 100.</param>
        /// <param name="published">If true, the latest published version will be included. If false, only the unpublished version will be included. (optional, default to true)</param>
        /// <returns>Task of ApiResponse (List&lt;SurveyForm&gt;)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<List<SurveyForm>>> GetQualityFormsSurveysBulkContextsAsyncWithHttpInfo (List<string> contextId, bool? published = null)
        { 
            // verify the required parameter 'contextId' is set
            if (contextId == null)
                throw new ApiException(400, "Missing required parameter 'contextId' when calling QualityApi->GetQualityFormsSurveysBulkContexts");
            

            var localVarPath = "/api/v2/quality/forms/surveys/bulk/contexts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (contextId != null) contextId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("contextId", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (published != null) localVarQueryParams.Add(new Tuple<string, string>("published", this.Configuration.ApiClient.ParameterToString(published)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveysBulkContexts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormsSurveysBulkContexts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<SurveyForm>>(localVarStatusCode,
                localVarHeaders,
                (List<SurveyForm>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SurveyForm>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationFormResponse</returns>
        [Obsolete]
        public EvaluationFormResponse GetQualityPublishedform (string formId)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = GetQualityPublishedformWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        [Obsolete]
        public ApiResponse< EvaluationFormResponse > GetQualityPublishedformWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityPublishedform");

            var localVarPath = "/api/v2/quality/publishedforms/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedform: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedform: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<EvaluationFormResponse> GetQualityPublishedformAsync (string formId)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = await GetQualityPublishedformAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> GetQualityPublishedformAsyncWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityPublishedform");
            

            var localVarPath = "/api/v2/quality/publishedforms/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedform: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedform: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        public EvaluationFormResponseEntityListing GetQualityPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = GetQualityPublishedformsWithHttpInfo(pageSize, pageNumber, name, onlyLatestPerContext);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        public ApiResponse< EvaluationFormResponseEntityListing > GetQualityPublishedformsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)
        { 

            var localVarPath = "/api/v2/quality/publishedforms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (onlyLatestPerContext != null) localVarQueryParams.Add(new Tuple<string, string>("onlyLatestPerContext", this.Configuration.ApiClient.ParameterToString(onlyLatestPerContext)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedforms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityPublishedformsAsync (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = await GetQualityPublishedformsAsyncWithHttpInfo(pageSize, pageNumber, name, onlyLatestPerContext);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityPublishedformsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)
        { 

            var localVarPath = "/api/v2/quality/publishedforms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (onlyLatestPerContext != null) localVarQueryParams.Add(new Tuple<string, string>("onlyLatestPerContext", this.Configuration.ApiClient.ParameterToString(onlyLatestPerContext)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedforms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the most recent published version of an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationFormResponse</returns>
        
        public EvaluationFormResponse GetQualityPublishedformsEvaluation (string formId)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = GetQualityPublishedformsEvaluationWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the most recent published version of an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        
        public ApiResponse< EvaluationFormResponse > GetQualityPublishedformsEvaluationWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityPublishedformsEvaluation");

            var localVarPath = "/api/v2/quality/publishedforms/evaluations/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the most recent published version of an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationFormResponse> GetQualityPublishedformsEvaluationAsync (string formId)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = await GetQualityPublishedformsEvaluationAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the most recent published version of an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> GetQualityPublishedformsEvaluationAsyncWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityPublishedformsEvaluation");
            

            var localVarPath = "/api/v2/quality/publishedforms/evaluations/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>EvaluationFormResponseEntityListing</returns>
        
        public EvaluationFormResponseEntityListing GetQualityPublishedformsEvaluations (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = GetQualityPublishedformsEvaluationsWithHttpInfo(pageSize, pageNumber, name, onlyLatestPerContext);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>ApiResponse of EvaluationFormResponseEntityListing</returns>
        
        public ApiResponse< EvaluationFormResponseEntityListing > GetQualityPublishedformsEvaluationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)
        { 

            var localVarPath = "/api/v2/quality/publishedforms/evaluations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (onlyLatestPerContext != null) localVarQueryParams.Add(new Tuple<string, string>("onlyLatestPerContext", this.Configuration.ApiClient.ParameterToString(onlyLatestPerContext)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>Task of EvaluationFormResponseEntityListing</returns>
        
        public async System.Threading.Tasks.Task<EvaluationFormResponseEntityListing> GetQualityPublishedformsEvaluationsAsync (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)
        {
             ApiResponse<EvaluationFormResponseEntityListing> localVarResponse = await GetQualityPublishedformsEvaluationsAsyncWithHttpInfo(pageSize, pageNumber, name, onlyLatestPerContext);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestPerContext">onlyLatestPerContext (optional, default to false)</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponseEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponseEntityListing>> GetQualityPublishedformsEvaluationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestPerContext = null)
        { 

            var localVarPath = "/api/v2/quality/publishedforms/evaluations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (onlyLatestPerContext != null) localVarQueryParams.Add(new Tuple<string, string>("onlyLatestPerContext", this.Configuration.ApiClient.ParameterToString(onlyLatestPerContext)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponseEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponseEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponseEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the most recent published version of a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>SurveyForm</returns>
        
        public SurveyForm GetQualityPublishedformsSurvey (string formId)
        {
             ApiResponse<SurveyForm> localVarResponse = GetQualityPublishedformsSurveyWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the most recent published version of a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        public ApiResponse< SurveyForm > GetQualityPublishedformsSurveyWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityPublishedformsSurvey");

            var localVarPath = "/api/v2/quality/publishedforms/surveys/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsSurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the most recent published version of a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of SurveyForm</returns>
        
        public async System.Threading.Tasks.Task<SurveyForm> GetQualityPublishedformsSurveyAsync (string formId)
        {
             ApiResponse<SurveyForm> localVarResponse = await GetQualityPublishedformsSurveyAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the most recent published version of a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyForm>> GetQualityPublishedformsSurveyAsyncWithHttpInfo (string formId)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetQualityPublishedformsSurvey");
            

            var localVarPath = "/api/v2/quality/publishedforms/surveys/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsSurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the published survey forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestEnabledPerContext">onlyLatestEnabledPerContext (optional, default to false)</param>
        /// <returns>SurveyFormEntityListing</returns>
        
        public SurveyFormEntityListing GetQualityPublishedformsSurveys (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null)
        {
             ApiResponse<SurveyFormEntityListing> localVarResponse = GetQualityPublishedformsSurveysWithHttpInfo(pageSize, pageNumber, name, onlyLatestEnabledPerContext);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published survey forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestEnabledPerContext">onlyLatestEnabledPerContext (optional, default to false)</param>
        /// <returns>ApiResponse of SurveyFormEntityListing</returns>
        
        public ApiResponse< SurveyFormEntityListing > GetQualityPublishedformsSurveysWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null)
        { 

            var localVarPath = "/api/v2/quality/publishedforms/surveys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (onlyLatestEnabledPerContext != null) localVarQueryParams.Add(new Tuple<string, string>("onlyLatestEnabledPerContext", this.Configuration.ApiClient.ParameterToString(onlyLatestEnabledPerContext)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsSurveys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsSurveys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SurveyFormEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyFormEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the published survey forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestEnabledPerContext">onlyLatestEnabledPerContext (optional, default to false)</param>
        /// <returns>Task of SurveyFormEntityListing</returns>
        
        public async System.Threading.Tasks.Task<SurveyFormEntityListing> GetQualityPublishedformsSurveysAsync (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null)
        {
             ApiResponse<SurveyFormEntityListing> localVarResponse = await GetQualityPublishedformsSurveysAsyncWithHttpInfo(pageSize, pageNumber, name, onlyLatestEnabledPerContext);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published survey forms. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="onlyLatestEnabledPerContext">onlyLatestEnabledPerContext (optional, default to false)</param>
        /// <returns>Task of ApiResponse (SurveyFormEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyFormEntityListing>> GetQualityPublishedformsSurveysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, bool? onlyLatestEnabledPerContext = null)
        { 

            var localVarPath = "/api/v2/quality/publishedforms/surveys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (onlyLatestEnabledPerContext != null) localVarQueryParams.Add(new Tuple<string, string>("onlyLatestEnabledPerContext", this.Configuration.ApiClient.ParameterToString(onlyLatestEnabledPerContext)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsSurveys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedformsSurveys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SurveyFormEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyFormEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a survey for a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="surveyId">surveyId</param>
        /// <returns>Survey</returns>
        
        public Survey GetQualitySurvey (string surveyId)
        {
             ApiResponse<Survey> localVarResponse = GetQualitySurveyWithHttpInfo(surveyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a survey for a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="surveyId">surveyId</param>
        /// <returns>ApiResponse of Survey</returns>
        
        public ApiResponse< Survey > GetQualitySurveyWithHttpInfo (string surveyId)
        { 
            // verify the required parameter 'surveyId' is set
            if (surveyId == null)
                throw new ApiException(400, "Missing required parameter 'surveyId' when calling QualityApi->GetQualitySurvey");

            var localVarPath = "/api/v2/quality/surveys/{surveyId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (surveyId != null) localVarPathParams.Add("surveyId", this.Configuration.ApiClient.ParameterToString(surveyId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualitySurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualitySurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Survey>(localVarStatusCode,
                localVarHeaders,
                (Survey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Survey)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a survey for a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="surveyId">surveyId</param>
        /// <returns>Task of Survey</returns>
        
        public async System.Threading.Tasks.Task<Survey> GetQualitySurveyAsync (string surveyId)
        {
             ApiResponse<Survey> localVarResponse = await GetQualitySurveyAsyncWithHttpInfo(surveyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a survey for a conversation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="surveyId">surveyId</param>
        /// <returns>Task of ApiResponse (Survey)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Survey>> GetQualitySurveyAsyncWithHttpInfo (string surveyId)
        { 
            // verify the required parameter 'surveyId' is set
            if (surveyId == null)
                throw new ApiException(400, "Missing required parameter 'surveyId' when calling QualityApi->GetQualitySurvey");
            

            var localVarPath = "/api/v2/quality/surveys/{surveyId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (surveyId != null) localVarPathParams.Add("surveyId", this.Configuration.ApiClient.ParameterToString(surveyId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualitySurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualitySurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Survey>(localVarStatusCode,
                localVarHeaders,
                (Survey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Survey)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a survey as an end-customer, for the purposes of scoring it. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <returns>ScorableSurvey</returns>
        
        public ScorableSurvey GetQualitySurveysScorable (string customerSurveyUrl)
        {
             ApiResponse<ScorableSurvey> localVarResponse = GetQualitySurveysScorableWithHttpInfo(customerSurveyUrl);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a survey as an end-customer, for the purposes of scoring it. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <returns>ApiResponse of ScorableSurvey</returns>
        
        public ApiResponse< ScorableSurvey > GetQualitySurveysScorableWithHttpInfo (string customerSurveyUrl)
        { 
            // verify the required parameter 'customerSurveyUrl' is set
            if (customerSurveyUrl == null)
                throw new ApiException(400, "Missing required parameter 'customerSurveyUrl' when calling QualityApi->GetQualitySurveysScorable");

            var localVarPath = "/api/v2/quality/surveys/scorable";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (customerSurveyUrl != null) localVarQueryParams.Add(new Tuple<string, string>("customerSurveyUrl", this.Configuration.ApiClient.ParameterToString(customerSurveyUrl)));

            // Header params

            // Form params
            
            // Body param


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualitySurveysScorable: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualitySurveysScorable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScorableSurvey>(localVarStatusCode,
                localVarHeaders,
                (ScorableSurvey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScorableSurvey)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a survey as an end-customer, for the purposes of scoring it. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <returns>Task of ScorableSurvey</returns>
        
        public async System.Threading.Tasks.Task<ScorableSurvey> GetQualitySurveysScorableAsync (string customerSurveyUrl)
        {
             ApiResponse<ScorableSurvey> localVarResponse = await GetQualitySurveysScorableAsyncWithHttpInfo(customerSurveyUrl);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a survey as an end-customer, for the purposes of scoring it. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <returns>Task of ApiResponse (ScorableSurvey)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ScorableSurvey>> GetQualitySurveysScorableAsyncWithHttpInfo (string customerSurveyUrl)
        { 
            // verify the required parameter 'customerSurveyUrl' is set
            if (customerSurveyUrl == null)
                throw new ApiException(400, "Missing required parameter 'customerSurveyUrl' when calling QualityApi->GetQualitySurveysScorable");
            

            var localVarPath = "/api/v2/quality/surveys/scorable";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (customerSurveyUrl != null) localVarQueryParams.Add(new Tuple<string, string>("customerSurveyUrl", this.Configuration.ApiClient.ParameterToString(customerSurveyUrl)));

            // Header params

            // Form params
            
            // Body param


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualitySurveysScorable: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualitySurveysScorable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScorableSurvey>(localVarStatusCode,
                localVarHeaders,
                (ScorableSurvey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScorableSurvey)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>SurveyForm</returns>
        
        public SurveyForm PatchQualityFormsSurvey (string formId, SurveyForm body)
        {
             ApiResponse<SurveyForm> localVarResponse = PatchQualityFormsSurveyWithHttpInfo(formId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        public ApiResponse< SurveyForm > PatchQualityFormsSurveyWithHttpInfo (string formId, SurveyForm body)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PatchQualityFormsSurvey");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PatchQualityFormsSurvey");

            var localVarPath = "/api/v2/quality/forms/surveys/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchQualityFormsSurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchQualityFormsSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>Task of SurveyForm</returns>
        
        public async System.Threading.Tasks.Task<SurveyForm> PatchQualityFormsSurveyAsync (string formId, SurveyForm body)
        {
             ApiResponse<SurveyForm> localVarResponse = await PatchQualityFormsSurveyAsyncWithHttpInfo(formId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Disable a particular version of a survey form and invalidates any invitations that have already been sent to customers using this version of the form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyForm>> PatchQualityFormsSurveyAsyncWithHttpInfo (string formId, SurveyForm body)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PatchQualityFormsSurvey");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PatchQualityFormsSurvey");
            

            var localVarPath = "/api/v2/quality/forms/surveys/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchQualityFormsSurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchQualityFormsSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for evaluation aggregates asynchronously 
        /// 
        /// PostAnalyticsEvaluationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AsyncQueryResponse</returns>
        
        public AsyncQueryResponse PostAnalyticsEvaluationsAggregatesJobs (EvaluationAsyncAggregationQuery body)
        {
             ApiResponse<AsyncQueryResponse> localVarResponse = PostAnalyticsEvaluationsAggregatesJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for evaluation aggregates asynchronously 
        /// 
        /// PostAnalyticsEvaluationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AsyncQueryResponse</returns>
        
        public ApiResponse< AsyncQueryResponse > PostAnalyticsEvaluationsAggregatesJobsWithHttpInfo (EvaluationAsyncAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostAnalyticsEvaluationsAggregatesJobs");

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/jobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for evaluation aggregates asynchronously 
        /// 
        /// PostAnalyticsEvaluationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AsyncQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<AsyncQueryResponse> PostAnalyticsEvaluationsAggregatesJobsAsync (EvaluationAsyncAggregationQuery body)
        {
             ApiResponse<AsyncQueryResponse> localVarResponse = await PostAnalyticsEvaluationsAggregatesJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for evaluation aggregates asynchronously 
        /// 
        /// PostAnalyticsEvaluationsAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AsyncQueryResponse>> PostAnalyticsEvaluationsAggregatesJobsAsyncWithHttpInfo (EvaluationAsyncAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostAnalyticsEvaluationsAggregatesJobs");
            

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/jobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for evaluation aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>EvaluationAggregateQueryResponse</returns>
        
        public EvaluationAggregateQueryResponse PostAnalyticsEvaluationsAggregatesQuery (EvaluationAggregationQuery body)
        {
             ApiResponse<EvaluationAggregateQueryResponse> localVarResponse = PostAnalyticsEvaluationsAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for evaluation aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of EvaluationAggregateQueryResponse</returns>
        
        public ApiResponse< EvaluationAggregateQueryResponse > PostAnalyticsEvaluationsAggregatesQueryWithHttpInfo (EvaluationAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostAnalyticsEvaluationsAggregatesQuery");

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for evaluation aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of EvaluationAggregateQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationAggregateQueryResponse> PostAnalyticsEvaluationsAggregatesQueryAsync (EvaluationAggregationQuery body)
        {
             ApiResponse<EvaluationAggregateQueryResponse> localVarResponse = await PostAnalyticsEvaluationsAggregatesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for evaluation aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (EvaluationAggregateQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationAggregateQueryResponse>> PostAnalyticsEvaluationsAggregatesQueryAsyncWithHttpInfo (EvaluationAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostAnalyticsEvaluationsAggregatesQuery");
            

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for survey aggregates asynchronously 
        /// 
        /// PostAnalyticsSurveysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AsyncQueryResponse</returns>
        
        public AsyncQueryResponse PostAnalyticsSurveysAggregatesJobs (SurveyAsyncAggregationQuery body)
        {
             ApiResponse<AsyncQueryResponse> localVarResponse = PostAnalyticsSurveysAggregatesJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for survey aggregates asynchronously 
        /// 
        /// PostAnalyticsSurveysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AsyncQueryResponse</returns>
        
        public ApiResponse< AsyncQueryResponse > PostAnalyticsSurveysAggregatesJobsWithHttpInfo (SurveyAsyncAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostAnalyticsSurveysAggregatesJobs");

            var localVarPath = "/api/v2/analytics/surveys/aggregates/jobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsSurveysAggregatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsSurveysAggregatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for survey aggregates asynchronously 
        /// 
        /// PostAnalyticsSurveysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AsyncQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<AsyncQueryResponse> PostAnalyticsSurveysAggregatesJobsAsync (SurveyAsyncAggregationQuery body)
        {
             ApiResponse<AsyncQueryResponse> localVarResponse = await PostAnalyticsSurveysAggregatesJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for survey aggregates asynchronously 
        /// 
        /// PostAnalyticsSurveysAggregatesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AsyncQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AsyncQueryResponse>> PostAnalyticsSurveysAggregatesJobsAsyncWithHttpInfo (SurveyAsyncAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostAnalyticsSurveysAggregatesJobs");
            

            var localVarPath = "/api/v2/analytics/surveys/aggregates/jobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsSurveysAggregatesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsSurveysAggregatesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for survey aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>SurveyAggregateQueryResponse</returns>
        
        public SurveyAggregateQueryResponse PostAnalyticsSurveysAggregatesQuery (SurveyAggregationQuery body)
        {
             ApiResponse<SurveyAggregateQueryResponse> localVarResponse = PostAnalyticsSurveysAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for survey aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of SurveyAggregateQueryResponse</returns>
        
        public ApiResponse< SurveyAggregateQueryResponse > PostAnalyticsSurveysAggregatesQueryWithHttpInfo (SurveyAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostAnalyticsSurveysAggregatesQuery");

            var localVarPath = "/api/v2/analytics/surveys/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsSurveysAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsSurveysAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (SurveyAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for survey aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of SurveyAggregateQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<SurveyAggregateQueryResponse> PostAnalyticsSurveysAggregatesQueryAsync (SurveyAggregationQuery body)
        {
             ApiResponse<SurveyAggregateQueryResponse> localVarResponse = await PostAnalyticsSurveysAggregatesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for survey aggregates 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (SurveyAggregateQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyAggregateQueryResponse>> PostAnalyticsSurveysAggregatesQueryAsyncWithHttpInfo (SurveyAggregationQuery body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostAnalyticsSurveysAggregatesQuery");
            

            var localVarPath = "/api/v2/analytics/surveys/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsSurveysAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsSurveysAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (SurveyAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a calibration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        
        public Calibration PostQualityCalibrations (CalibrationCreate body, string expand = null)
        {
             ApiResponse<Calibration> localVarResponse = PostQualityCalibrationsWithHttpInfo(body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a calibration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        
        public ApiResponse< Calibration > PostQualityCalibrationsWithHttpInfo (CalibrationCreate body, string expand = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityCalibrations");

            var localVarPath = "/api/v2/quality/calibrations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityCalibrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a calibration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        
        public async System.Threading.Tasks.Task<Calibration> PostQualityCalibrationsAsync (CalibrationCreate body, string expand = null)
        {
             ApiResponse<Calibration> localVarResponse = await PostQualityCalibrationsAsyncWithHttpInfo(body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a calibration 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> PostQualityCalibrationsAsyncWithHttpInfo (CalibrationCreate body, string expand = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityCalibrations");
            

            var localVarPath = "/api/v2/quality/calibrations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityCalibrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        
        public Evaluation PostQualityConversationEvaluations (string conversationId, EvaluationCreateBody body, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = PostQualityConversationEvaluationsWithHttpInfo(conversationId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        
        public ApiResponse< Evaluation > PostQualityConversationEvaluationsWithHttpInfo (string conversationId, EvaluationCreateBody body, string expand = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PostQualityConversationEvaluations");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityConversationEvaluations");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarHeaders,
                (Evaluation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        
        public async System.Threading.Tasks.Task<Evaluation> PostQualityConversationEvaluationsAsync (string conversationId, EvaluationCreateBody body, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await PostQualityConversationEvaluationsAsyncWithHttpInfo(conversationId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> PostQualityConversationEvaluationsAsyncWithHttpInfo (string conversationId, EvaluationCreateBody body, string expand = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PostQualityConversationEvaluations");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityConversationEvaluations");
            

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarHeaders,
                (Evaluation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>QualityAuditQueryExecutionStatusResponse</returns>
        
        public QualityAuditQueryExecutionStatusResponse PostQualityConversationsAuditsQuery (QMAuditQueryRequest body)
        {
             ApiResponse<QualityAuditQueryExecutionStatusResponse> localVarResponse = PostQualityConversationsAuditsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of QualityAuditQueryExecutionStatusResponse</returns>
        
        public ApiResponse< QualityAuditQueryExecutionStatusResponse > PostQualityConversationsAuditsQueryWithHttpInfo (QMAuditQueryRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityConversationsAuditsQuery");

            var localVarPath = "/api/v2/quality/conversations/audits/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationsAuditsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationsAuditsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditQueryExecutionStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (QualityAuditQueryExecutionStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditQueryExecutionStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of QualityAuditQueryExecutionStatusResponse</returns>
        
        public async System.Threading.Tasks.Task<QualityAuditQueryExecutionStatusResponse> PostQualityConversationsAuditsQueryAsync (QMAuditQueryRequest body)
        {
             ApiResponse<QualityAuditQueryExecutionStatusResponse> localVarResponse = await PostQualityConversationsAuditsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create audit query execution 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (QualityAuditQueryExecutionStatusResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<QualityAuditQueryExecutionStatusResponse>> PostQualityConversationsAuditsQueryAsyncWithHttpInfo (QMAuditQueryRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityConversationsAuditsQuery");
            

            var localVarPath = "/api/v2/quality/conversations/audits/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationsAuditsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationsAuditsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditQueryExecutionStatusResponse>(localVarStatusCode,
                localVarHeaders,
                (QualityAuditQueryExecutionStatusResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditQueryExecutionStatusResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for evaluation aggregates for the current user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>EvaluationAggregateQueryResponse</returns>
        
        public EvaluationAggregateQueryResponse PostQualityEvaluationsAggregatesQueryMe (EvaluationAggregationQueryMe body)
        {
             ApiResponse<EvaluationAggregateQueryResponse> localVarResponse = PostQualityEvaluationsAggregatesQueryMeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for evaluation aggregates for the current user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of EvaluationAggregateQueryResponse</returns>
        
        public ApiResponse< EvaluationAggregateQueryResponse > PostQualityEvaluationsAggregatesQueryMeWithHttpInfo (EvaluationAggregationQueryMe body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityEvaluationsAggregatesQueryMe");

            var localVarPath = "/api/v2/quality/evaluations/aggregates/query/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsAggregatesQueryMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsAggregatesQueryMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for evaluation aggregates for the current user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of EvaluationAggregateQueryResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationAggregateQueryResponse> PostQualityEvaluationsAggregatesQueryMeAsync (EvaluationAggregationQueryMe body)
        {
             ApiResponse<EvaluationAggregateQueryResponse> localVarResponse = await PostQualityEvaluationsAggregatesQueryMeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for evaluation aggregates for the current user 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (EvaluationAggregateQueryResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationAggregateQueryResponse>> PostQualityEvaluationsAggregatesQueryMeAsyncWithHttpInfo (EvaluationAggregationQueryMe body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityEvaluationsAggregatesQueryMe");
            

            var localVarPath = "/api/v2/quality/evaluations/aggregates/query/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsAggregatesQueryMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsAggregatesQueryMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationAggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationAggregateQueryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationAggregateQueryResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Score evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>EvaluationScoringSet</returns>
        
        public EvaluationScoringSet PostQualityEvaluationsScoring (EvaluationFormAndScoringSet body)
        {
             ApiResponse<EvaluationScoringSet> localVarResponse = PostQualityEvaluationsScoringWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Score evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        
        public ApiResponse< EvaluationScoringSet > PostQualityEvaluationsScoringWithHttpInfo (EvaluationFormAndScoringSet body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityEvaluationsScoring");

            var localVarPath = "/api/v2/quality/evaluations/scoring";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsScoring: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsScoring: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(localVarStatusCode,
                localVarHeaders,
                (EvaluationScoringSet) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationScoringSet)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Score evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        
        public async System.Threading.Tasks.Task<EvaluationScoringSet> PostQualityEvaluationsScoringAsync (EvaluationFormAndScoringSet body)
        {
             ApiResponse<EvaluationScoringSet> localVarResponse = await PostQualityEvaluationsScoringAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Score evaluation 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> PostQualityEvaluationsScoringAsyncWithHttpInfo (EvaluationFormAndScoringSet body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityEvaluationsScoring");
            

            var localVarPath = "/api/v2/quality/evaluations/scoring";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsScoring: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsScoring: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(localVarStatusCode,
                localVarHeaders,
                (EvaluationScoringSet) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationScoringSet)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationFormResponse</returns>
        [Obsolete]
        public EvaluationFormResponse PostQualityForms (EvaluationForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = PostQualityFormsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        [Obsolete]
        public ApiResponse< EvaluationFormResponse > PostQualityFormsWithHttpInfo (EvaluationForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityForms");

            var localVarPath = "/api/v2/quality/forms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityForms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<EvaluationFormResponse> PostQualityFormsAsync (EvaluationForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = await PostQualityFormsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PostQualityFormsAsyncWithHttpInfo (EvaluationForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityForms");
            

            var localVarPath = "/api/v2/quality/forms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityForms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationFormResponse</returns>
        
        public EvaluationFormResponse PostQualityFormsEvaluations (EvaluationForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = PostQualityFormsEvaluationsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        
        public ApiResponse< EvaluationFormResponse > PostQualityFormsEvaluationsWithHttpInfo (EvaluationForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityFormsEvaluations");

            var localVarPath = "/api/v2/quality/forms/evaluations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityFormsEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityFormsEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationFormResponse> PostQualityFormsEvaluationsAsync (EvaluationForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = await PostQualityFormsEvaluationsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PostQualityFormsEvaluationsAsyncWithHttpInfo (EvaluationForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityFormsEvaluations");
            

            var localVarPath = "/api/v2/quality/forms/evaluations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityFormsEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityFormsEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>SurveyForm</returns>
        
        public SurveyForm PostQualityFormsSurveys (SurveyForm body)
        {
             ApiResponse<SurveyForm> localVarResponse = PostQualityFormsSurveysWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        public ApiResponse< SurveyForm > PostQualityFormsSurveysWithHttpInfo (SurveyForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityFormsSurveys");

            var localVarPath = "/api/v2/quality/forms/surveys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityFormsSurveys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityFormsSurveys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>Task of SurveyForm</returns>
        
        public async System.Threading.Tasks.Task<SurveyForm> PostQualityFormsSurveysAsync (SurveyForm body)
        {
             ApiResponse<SurveyForm> localVarResponse = await PostQualityFormsSurveysAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyForm>> PostQualityFormsSurveysAsyncWithHttpInfo (SurveyForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityFormsSurveys");
            

            var localVarPath = "/api/v2/quality/forms/surveys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityFormsSurveys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityFormsSurveys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Publish an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>EvaluationFormResponse</returns>
        [Obsolete]
        public EvaluationFormResponse PostQualityPublishedforms (PublishForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = PostQualityPublishedformsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        [Obsolete]
        public ApiResponse< EvaluationFormResponse > PostQualityPublishedformsWithHttpInfo (PublishForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityPublishedforms");

            var localVarPath = "/api/v2/quality/publishedforms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedforms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Publish an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<EvaluationFormResponse> PostQualityPublishedformsAsync (PublishForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = await PostQualityPublishedformsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PostQualityPublishedformsAsyncWithHttpInfo (PublishForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityPublishedforms");
            

            var localVarPath = "/api/v2/quality/publishedforms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedforms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Publish an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>EvaluationFormResponse</returns>
        
        public EvaluationFormResponse PostQualityPublishedformsEvaluations (PublishForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = PostQualityPublishedformsEvaluationsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        
        public ApiResponse< EvaluationFormResponse > PostQualityPublishedformsEvaluationsWithHttpInfo (PublishForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityPublishedformsEvaluations");

            var localVarPath = "/api/v2/quality/publishedforms/evaluations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedformsEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedformsEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Publish an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationFormResponse> PostQualityPublishedformsEvaluationsAsync (PublishForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = await PostQualityPublishedformsEvaluationsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publish request containing id of form to publish</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PostQualityPublishedformsEvaluationsAsyncWithHttpInfo (PublishForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityPublishedformsEvaluations");
            

            var localVarPath = "/api/v2/quality/publishedforms/evaluations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedformsEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedformsEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Publish a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>SurveyForm</returns>
        
        public SurveyForm PostQualityPublishedformsSurveys (PublishForm body)
        {
             ApiResponse<SurveyForm> localVarResponse = PostQualityPublishedformsSurveysWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        public ApiResponse< SurveyForm > PostQualityPublishedformsSurveysWithHttpInfo (PublishForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityPublishedformsSurveys");

            var localVarPath = "/api/v2/quality/publishedforms/surveys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedformsSurveys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedformsSurveys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Publish a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>Task of SurveyForm</returns>
        
        public async System.Threading.Tasks.Task<SurveyForm> PostQualityPublishedformsSurveysAsync (PublishForm body)
        {
             ApiResponse<SurveyForm> localVarResponse = await PostQualityPublishedformsSurveysAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Survey form</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyForm>> PostQualityPublishedformsSurveysAsyncWithHttpInfo (PublishForm body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityPublishedformsSurveys");
            

            var localVarPath = "/api/v2/quality/publishedforms/surveys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedformsSurveys: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedformsSurveys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Score survey 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">surveyAndScoringSet</param>
        /// <returns>SurveyScoringSet</returns>
        
        public SurveyScoringSet PostQualitySurveysScoring (SurveyFormAndScoringSet body)
        {
             ApiResponse<SurveyScoringSet> localVarResponse = PostQualitySurveysScoringWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Score survey 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">surveyAndScoringSet</param>
        /// <returns>ApiResponse of SurveyScoringSet</returns>
        
        public ApiResponse< SurveyScoringSet > PostQualitySurveysScoringWithHttpInfo (SurveyFormAndScoringSet body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualitySurveysScoring");

            var localVarPath = "/api/v2/quality/surveys/scoring";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualitySurveysScoring: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualitySurveysScoring: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyScoringSet>(localVarStatusCode,
                localVarHeaders,
                (SurveyScoringSet) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyScoringSet)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Score survey 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">surveyAndScoringSet</param>
        /// <returns>Task of SurveyScoringSet</returns>
        
        public async System.Threading.Tasks.Task<SurveyScoringSet> PostQualitySurveysScoringAsync (SurveyFormAndScoringSet body)
        {
             ApiResponse<SurveyScoringSet> localVarResponse = await PostQualitySurveysScoringAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Score survey 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">surveyAndScoringSet</param>
        /// <returns>Task of ApiResponse (SurveyScoringSet)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyScoringSet>> PostQualitySurveysScoringAsyncWithHttpInfo (SurveyFormAndScoringSet body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualitySurveysScoring");
            

            var localVarPath = "/api/v2/quality/surveys/scoring";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostQualitySurveysScoring: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualitySurveysScoring: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyScoringSet>(localVarStatusCode,
                localVarHeaders,
                (SurveyScoringSet) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyScoringSet)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Calibration</returns>
        
        public Calibration PutQualityCalibration (string calibrationId, Calibration body)
        {
             ApiResponse<Calibration> localVarResponse = PutQualityCalibrationWithHttpInfo(calibrationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>ApiResponse of Calibration</returns>
        
        public ApiResponse< Calibration > PutQualityCalibrationWithHttpInfo (string calibrationId, Calibration body)
        { 
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->PutQualityCalibration");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityCalibration");

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (calibrationId != null) localVarPathParams.Add("calibrationId", this.Configuration.ApiClient.ParameterToString(calibrationId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of Calibration</returns>
        
        public async System.Threading.Tasks.Task<Calibration> PutQualityCalibrationAsync (string calibrationId, Calibration body)
        {
             ApiResponse<Calibration> localVarResponse = await PutQualityCalibrationAsyncWithHttpInfo(calibrationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> PutQualityCalibrationAsyncWithHttpInfo (string calibrationId, Calibration body)
        { 
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->PutQualityCalibration");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityCalibration");
            

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (calibrationId != null) localVarPathParams.Add("calibrationId", this.Configuration.ApiClient.ParameterToString(calibrationId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an evaluation 
        /// The quality:evaluation:edit permission allows modification of most fields, while the quality:evaluation:editScore permission allows an evaluator to change just the question scores, and the quality:evaluation:editAgentSignoff permission allows an agent to change the agent comments and sign off on the evaluation. authorizedActions is not returned for this PUT request, and is only returned for GET requests to this endpoint.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId, evaluationForm, assignee, evaluator (optional)</param>
        /// <returns>EvaluationResponse</returns>
        
        public EvaluationResponse PutQualityConversationEvaluation (string conversationId, string evaluationId, Evaluation body, string expand = null)
        {
             ApiResponse<EvaluationResponse> localVarResponse = PutQualityConversationEvaluationWithHttpInfo(conversationId, evaluationId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an evaluation 
        /// The quality:evaluation:edit permission allows modification of most fields, while the quality:evaluation:editScore permission allows an evaluator to change just the question scores, and the quality:evaluation:editAgentSignoff permission allows an agent to change the agent comments and sign off on the evaluation. authorizedActions is not returned for this PUT request, and is only returned for GET requests to this endpoint.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId, evaluationForm, assignee, evaluator (optional)</param>
        /// <returns>ApiResponse of EvaluationResponse</returns>
        
        public ApiResponse< EvaluationResponse > PutQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, Evaluation body, string expand = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PutQualityConversationEvaluation");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->PutQualityConversationEvaluation");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityConversationEvaluation");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", this.Configuration.ApiClient.ParameterToString(evaluationId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an evaluation 
        /// The quality:evaluation:edit permission allows modification of most fields, while the quality:evaluation:editScore permission allows an evaluator to change just the question scores, and the quality:evaluation:editAgentSignoff permission allows an agent to change the agent comments and sign off on the evaluation. authorizedActions is not returned for this PUT request, and is only returned for GET requests to this endpoint.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId, evaluationForm, assignee, evaluator (optional)</param>
        /// <returns>Task of EvaluationResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationResponse> PutQualityConversationEvaluationAsync (string conversationId, string evaluationId, Evaluation body, string expand = null)
        {
             ApiResponse<EvaluationResponse> localVarResponse = await PutQualityConversationEvaluationAsyncWithHttpInfo(conversationId, evaluationId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an evaluation 
        /// The quality:evaluation:edit permission allows modification of most fields, while the quality:evaluation:editScore permission allows an evaluator to change just the question scores, and the quality:evaluation:editAgentSignoff permission allows an agent to change the agent comments and sign off on the evaluation. authorizedActions is not returned for this PUT request, and is only returned for GET requests to this endpoint.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId, evaluationForm, assignee, evaluator (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationResponse>> PutQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body, string expand = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PutQualityConversationEvaluation");
            
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->PutQualityConversationEvaluation");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityConversationEvaluation");
            

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", this.Configuration.ApiClient.ParameterToString(evaluationId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationFormResponse</returns>
        [Obsolete]
        public EvaluationFormResponse PutQualityForm (string formId, EvaluationForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = PutQualityFormWithHttpInfo(formId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        [Obsolete]
        public ApiResponse< EvaluationFormResponse > PutQualityFormWithHttpInfo (string formId, EvaluationForm body)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PutQualityForm");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityForm");

            var localVarPath = "/api/v2/quality/forms/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<EvaluationFormResponse> PutQualityFormAsync (string formId, EvaluationForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = await PutQualityFormAsyncWithHttpInfo(formId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PutQualityFormAsyncWithHttpInfo (string formId, EvaluationForm body)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PutQualityForm");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityForm");
            

            var localVarPath = "/api/v2/quality/forms/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationFormResponse</returns>
        
        public EvaluationFormResponse PutQualityFormsEvaluation (string formId, EvaluationForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = PutQualityFormsEvaluationWithHttpInfo(formId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationFormResponse</returns>
        
        public ApiResponse< EvaluationFormResponse > PutQualityFormsEvaluationWithHttpInfo (string formId, EvaluationForm body)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PutQualityFormsEvaluation");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityFormsEvaluation");

            var localVarPath = "/api/v2/quality/forms/evaluations/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationFormResponse</returns>
        
        public async System.Threading.Tasks.Task<EvaluationFormResponse> PutQualityFormsEvaluationAsync (string formId, EvaluationForm body)
        {
             ApiResponse<EvaluationFormResponse> localVarResponse = await PutQualityFormsEvaluationAsyncWithHttpInfo(formId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an evaluation form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationFormResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormResponse>> PutQualityFormsEvaluationAsyncWithHttpInfo (string formId, EvaluationForm body)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PutQualityFormsEvaluation");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityFormsEvaluation");
            

            var localVarPath = "/api/v2/quality/forms/evaluations/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormResponse>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the AI Scoring settings of an evaluation form. 
        /// 
        /// PutQualityFormsEvaluationAiscoringSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">AI Scoring Settings</param>
        /// <returns>AiScoringSettings</returns>
        
        public AiScoringSettings PutQualityFormsEvaluationAiscoringSettings (string formId, AiScoringSettings body)
        {
             ApiResponse<AiScoringSettings> localVarResponse = PutQualityFormsEvaluationAiscoringSettingsWithHttpInfo(formId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the AI Scoring settings of an evaluation form. 
        /// 
        /// PutQualityFormsEvaluationAiscoringSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">AI Scoring Settings</param>
        /// <returns>ApiResponse of AiScoringSettings</returns>
        
        public ApiResponse< AiScoringSettings > PutQualityFormsEvaluationAiscoringSettingsWithHttpInfo (string formId, AiScoringSettings body)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PutQualityFormsEvaluationAiscoringSettings");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityFormsEvaluationAiscoringSettings");

            var localVarPath = "/api/v2/quality/forms/evaluations/{formId}/aiscoring/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsEvaluationAiscoringSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsEvaluationAiscoringSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AiScoringSettings>(localVarStatusCode,
                localVarHeaders,
                (AiScoringSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AiScoringSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the AI Scoring settings of an evaluation form. 
        /// 
        /// PutQualityFormsEvaluationAiscoringSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">AI Scoring Settings</param>
        /// <returns>Task of AiScoringSettings</returns>
        
        public async System.Threading.Tasks.Task<AiScoringSettings> PutQualityFormsEvaluationAiscoringSettingsAsync (string formId, AiScoringSettings body)
        {
             ApiResponse<AiScoringSettings> localVarResponse = await PutQualityFormsEvaluationAiscoringSettingsAsyncWithHttpInfo(formId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the AI Scoring settings of an evaluation form. 
        /// 
        /// PutQualityFormsEvaluationAiscoringSettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">AI Scoring Settings</param>
        /// <returns>Task of ApiResponse (AiScoringSettings)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<AiScoringSettings>> PutQualityFormsEvaluationAiscoringSettingsAsyncWithHttpInfo (string formId, AiScoringSettings body)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PutQualityFormsEvaluationAiscoringSettings");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityFormsEvaluationAiscoringSettings");
            

            var localVarPath = "/api/v2/quality/forms/evaluations/{formId}/aiscoring/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsEvaluationAiscoringSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsEvaluationAiscoringSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AiScoringSettings>(localVarStatusCode,
                localVarHeaders,
                (AiScoringSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AiScoringSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>SurveyForm</returns>
        
        public SurveyForm PutQualityFormsSurvey (string formId, SurveyForm body)
        {
             ApiResponse<SurveyForm> localVarResponse = PutQualityFormsSurveyWithHttpInfo(formId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>ApiResponse of SurveyForm</returns>
        
        public ApiResponse< SurveyForm > PutQualityFormsSurveyWithHttpInfo (string formId, SurveyForm body)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PutQualityFormsSurvey");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityFormsSurvey");

            var localVarPath = "/api/v2/quality/forms/surveys/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsSurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>Task of SurveyForm</returns>
        
        public async System.Threading.Tasks.Task<SurveyForm> PutQualityFormsSurveyAsync (string formId, SurveyForm body)
        {
             ApiResponse<SurveyForm> localVarResponse = await PutQualityFormsSurveyAsyncWithHttpInfo(formId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a survey form. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Survey form</param>
        /// <returns>Task of ApiResponse (SurveyForm)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<SurveyForm>> PutQualityFormsSurveyAsyncWithHttpInfo (string formId, SurveyForm body)
        { 
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PutQualityFormsSurvey");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityFormsSurvey");
            

            var localVarPath = "/api/v2/quality/forms/surveys/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (formId != null) localVarPathParams.Add("formId", this.Configuration.ApiClient.ParameterToString(formId));

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
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsSurvey: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityFormsSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SurveyForm>(localVarStatusCode,
                localVarHeaders,
                (SurveyForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SurveyForm)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a survey as an end-customer, for the purposes of scoring it. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <param name="body">survey</param>
        /// <returns>ScorableSurvey</returns>
        
        public ScorableSurvey PutQualitySurveysScorable (string customerSurveyUrl, ScorableSurvey body)
        {
             ApiResponse<ScorableSurvey> localVarResponse = PutQualitySurveysScorableWithHttpInfo(customerSurveyUrl, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a survey as an end-customer, for the purposes of scoring it. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <param name="body">survey</param>
        /// <returns>ApiResponse of ScorableSurvey</returns>
        
        public ApiResponse< ScorableSurvey > PutQualitySurveysScorableWithHttpInfo (string customerSurveyUrl, ScorableSurvey body)
        { 
            // verify the required parameter 'customerSurveyUrl' is set
            if (customerSurveyUrl == null)
                throw new ApiException(400, "Missing required parameter 'customerSurveyUrl' when calling QualityApi->PutQualitySurveysScorable");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualitySurveysScorable");

            var localVarPath = "/api/v2/quality/surveys/scorable";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (customerSurveyUrl != null) localVarQueryParams.Add(new Tuple<string, string>("customerSurveyUrl", this.Configuration.ApiClient.ParameterToString(customerSurveyUrl)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualitySurveysScorable: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualitySurveysScorable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScorableSurvey>(localVarStatusCode,
                localVarHeaders,
                (ScorableSurvey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScorableSurvey)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a survey as an end-customer, for the purposes of scoring it. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <param name="body">survey</param>
        /// <returns>Task of ScorableSurvey</returns>
        
        public async System.Threading.Tasks.Task<ScorableSurvey> PutQualitySurveysScorableAsync (string customerSurveyUrl, ScorableSurvey body)
        {
             ApiResponse<ScorableSurvey> localVarResponse = await PutQualitySurveysScorableAsyncWithHttpInfo(customerSurveyUrl, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a survey as an end-customer, for the purposes of scoring it. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerSurveyUrl">customerSurveyUrl</param>
        /// <param name="body">survey</param>
        /// <returns>Task of ApiResponse (ScorableSurvey)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<ScorableSurvey>> PutQualitySurveysScorableAsyncWithHttpInfo (string customerSurveyUrl, ScorableSurvey body)
        { 
            // verify the required parameter 'customerSurveyUrl' is set
            if (customerSurveyUrl == null)
                throw new ApiException(400, "Missing required parameter 'customerSurveyUrl' when calling QualityApi->PutQualitySurveysScorable");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualitySurveysScorable");
            

            var localVarPath = "/api/v2/quality/surveys/scorable";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (customerSurveyUrl != null) localVarQueryParams.Add(new Tuple<string, string>("customerSurveyUrl", this.Configuration.ApiClient.ParameterToString(customerSurveyUrl)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers?
                                                             .Select(header => new
                                                         {
                                                            Name = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Name"),
                                                            Value = Extensions.ReflectionUtils.GetSafePropertyValue(header, "Value")
                                                            }).ToDictionary(header => header?.Name?.ToString(), header => header?.Value?.ToString()) 
                                                        ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutQualitySurveysScorable: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualitySurveysScorable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScorableSurvey>(localVarStatusCode,
                localVarHeaders,
                (ScorableSurvey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScorableSurvey)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
