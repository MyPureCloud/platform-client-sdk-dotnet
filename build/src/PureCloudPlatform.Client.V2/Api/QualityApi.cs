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
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation DeleteQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> DeleteQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        
        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns></returns>
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
        ApiResponse<Object> DeleteQualityFormWithHttpInfo (string formId);
        
        /// <summary>
        /// Delete a keywordSet by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns></returns>
        void DeleteQualityKeywordset (string keywordSetId);

        /// <summary>
        /// Delete a keywordSet by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteQualityKeywordsetWithHttpInfo (string keywordSetId);
        
        /// <summary>
        /// Delete keyword sets
        /// </summary>
        /// <remarks>
        /// Bulk delete of keyword sets; this will only delete the keyword sets that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A comma-delimited list of valid KeywordSet ids</param>
        /// <returns></returns>
        void DeleteQualityKeywordsets (string ids);

        /// <summary>
        /// Delete keyword sets
        /// </summary>
        /// <remarks>
        /// Bulk delete of keyword sets; this will only delete the keyword sets that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A comma-delimited list of valid KeywordSet ids</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteQualityKeywordsetsWithHttpInfo (string ids);
        
        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>AgentActivityEntityListing</returns>
        AgentActivityEntityListing GetQualityAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<Object> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);

        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        ApiResponse<AgentActivityEntityListing> GetQualityAgentsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<Object> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);
        
        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        Calibration GetQualityCalibration (string calibrationId, string calibratorId);

        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> GetQualityCalibrationWithHttpInfo (string calibrationId, string calibratorId);
        
        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
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
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>CalibrationEntityListing</returns>
        CalibrationEntityListing GetQualityCalibrations (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);

        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
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
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>ApiResponse of CalibrationEntityListing</returns>
        ApiResponse<CalibrationEntityListing> GetQualityCalibrationsWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);
        
        /// <summary>
        /// Get audits for conversation or recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation, Screen_Recording (optional, default to RECORDING)</param>
        /// <returns>QualityAuditPage</returns>
        QualityAuditPage GetQualityConversationAudits (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null);

        /// <summary>
        /// Get audits for conversation or recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation, Screen_Recording (optional, default to RECORDING)</param>
        /// <returns>ApiResponse of QualityAuditPage</returns>
        ApiResponse<QualityAuditPage> GetQualityConversationAuditsWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null);
        
        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation GetQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> GetQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        
        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        EvaluationEntityListing GetQualityEvaluationsQuery (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<Object> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        ApiResponse<EvaluationEntityListing> GetQualityEvaluationsQueryWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<Object> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);
        
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
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>EvaluatorActivityEntityListing</returns>
        EvaluatorActivityEntityListing GetQualityEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<Object> permission = null, string group = null);

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
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of EvaluatorActivityEntityListing</returns>
        ApiResponse<EvaluatorActivityEntityListing> GetQualityEvaluatorsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<Object> permission = null, string group = null);
        
        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm GetQualityForm (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> GetQualityFormWithHttpInfo (string formId);
        
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
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing GetQualityFormVersions (string formId, int? pageSize = null, int? pageNumber = null);

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
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> GetQualityFormVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get the list of evaluation forms
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
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing GetQualityForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null);

        /// <summary>
        /// Get the list of evaluation forms
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
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> GetQualityFormsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null);
        
        /// <summary>
        /// Get a keywordSet by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>KeywordSet</returns>
        KeywordSet GetQualityKeywordset (string keywordSetId);

        /// <summary>
        /// Get a keywordSet by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>ApiResponse of KeywordSet</returns>
        ApiResponse<KeywordSet> GetQualityKeywordsetWithHttpInfo (string keywordSetId);
        
        /// <summary>
        /// Get the list of keyword sets
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
        /// <param name="name">the keyword set name - used for filtering results in searches. (optional)</param>
        /// <param name="queueId">the queue id - used for filtering results in searches. (optional)</param>
        /// <param name="agentId">the agent id - used for filtering results in searches. (optional)</param>
        /// <param name="_operator">If agentID and queueId are both present, this determines whether the query is an AND or OR between those parameters. (optional)</param>
        /// <returns>KeywordSetEntityListing</returns>
        KeywordSetEntityListing GetQualityKeywordsets (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, string queueId = null, string agentId = null, string _operator = null);

        /// <summary>
        /// Get the list of keyword sets
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
        /// <param name="name">the keyword set name - used for filtering results in searches. (optional)</param>
        /// <param name="queueId">the queue id - used for filtering results in searches. (optional)</param>
        /// <param name="agentId">the agent id - used for filtering results in searches. (optional)</param>
        /// <param name="_operator">If agentID and queueId are both present, this determines whether the query is an AND or OR between those parameters. (optional)</param>
        /// <returns>ApiResponse of KeywordSetEntityListing</returns>
        ApiResponse<KeywordSetEntityListing> GetQualityKeywordsetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, string queueId = null, string agentId = null, string _operator = null);
        
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm GetQualityPublishedform (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> GetQualityPublishedformWithHttpInfo (string formId);
        
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
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing GetQualityPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null);

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
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> GetQualityPublishedformsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null);
        
        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AggregateQueryResponse</returns>
        AggregateQueryResponse PostAnalyticsEvaluationsAggregatesQuery (AggregationQuery body);

        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        ApiResponse<AggregateQueryResponse> PostAnalyticsEvaluationsAggregatesQueryWithHttpInfo (AggregationQuery body);
        
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
        Evaluation PostQualityConversationEvaluations (string conversationId, Evaluation body, string expand = null);

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
        ApiResponse<Evaluation> PostQualityConversationEvaluationsWithHttpInfo (string conversationId, Evaluation body, string expand = null);
        
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
        /// <returns>EvaluationForm</returns>
        EvaluationForm PostQualityForms (EvaluationForm body);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> PostQualityFormsWithHttpInfo (EvaluationForm body);
        
        /// <summary>
        /// Create a Keyword Set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">keywordSet</param>
        /// <param name="expand">queueId (optional)</param>
        /// <returns>KeywordSet</returns>
        KeywordSet PostQualityKeywordsets (KeywordSet body, string expand = null);

        /// <summary>
        /// Create a Keyword Set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">keywordSet</param>
        /// <param name="expand">queueId (optional)</param>
        /// <returns>ApiResponse of KeywordSet</returns>
        ApiResponse<KeywordSet> PostQualityKeywordsetsWithHttpInfo (KeywordSet body, string expand = null);
        
        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm PostQualityPublishedforms (EvaluationForm body);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> PostQualityPublishedformsWithHttpInfo (EvaluationForm body);
        
        /// <summary>
        /// Retrieve the spotability statistic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Keyword Set (optional)</param>
        /// <returns>KeywordSet</returns>
        KeywordSet PostQualitySpotability (KeywordSet body = null);

        /// <summary>
        /// Retrieve the spotability statistic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Keyword Set (optional)</param>
        /// <returns>ApiResponse of KeywordSet</returns>
        ApiResponse<KeywordSet> PostQualitySpotabilityWithHttpInfo (KeywordSet body = null);
        
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
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation PutQualityConversationEvaluation (string conversationId, string evaluationId, Evaluation body, string expand = null);

        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> PutQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, Evaluation body, string expand = null);
        
        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm PutQualityForm (string formId, EvaluationForm body);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> PutQualityFormWithHttpInfo (string formId, EvaluationForm body);
        
        /// <summary>
        /// Update a keywordSet to the specified keywordSet via PUT.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <param name="body">keywordSet</param>
        /// <returns>KeywordSet</returns>
        KeywordSet PutQualityKeywordset (string keywordSetId, KeywordSet body);

        /// <summary>
        /// Update a keywordSet to the specified keywordSet via PUT.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <param name="body">keywordSet</param>
        /// <returns>ApiResponse of KeywordSet</returns>
        ApiResponse<KeywordSet> PutQualityKeywordsetWithHttpInfo (string keywordSetId, KeywordSet body);
        
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
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> DeleteQualityConversationEvaluationAsync (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> DeleteQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        
        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of void</returns>
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
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityFormAsyncWithHttpInfo (string formId);
        
        /// <summary>
        /// Delete a keywordSet by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteQualityKeywordsetAsync (string keywordSetId);

        /// <summary>
        /// Delete a keywordSet by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityKeywordsetAsyncWithHttpInfo (string keywordSetId);
        
        /// <summary>
        /// Delete keyword sets
        /// </summary>
        /// <remarks>
        /// Bulk delete of keyword sets; this will only delete the keyword sets that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A comma-delimited list of valid KeywordSet ids</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteQualityKeywordsetsAsync (string ids);

        /// <summary>
        /// Delete keyword sets
        /// </summary>
        /// <remarks>
        /// Bulk delete of keyword sets; this will only delete the keyword sets that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A comma-delimited list of valid KeywordSet ids</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityKeywordsetsAsyncWithHttpInfo (string ids);
        
        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of AgentActivityEntityListing</returns>
        System.Threading.Tasks.Task<AgentActivityEntityListing> GetQualityAgentsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<Object> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);

        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (AgentActivityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> GetQualityAgentsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<Object> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);
        
        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> GetQualityCalibrationAsync (string calibrationId, string calibratorId);

        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> GetQualityCalibrationAsyncWithHttpInfo (string calibrationId, string calibratorId);
        
        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
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
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>Task of CalibrationEntityListing</returns>
        System.Threading.Tasks.Task<CalibrationEntityListing> GetQualityCalibrationsAsync (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);

        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
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
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>Task of ApiResponse (CalibrationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> GetQualityCalibrationsAsyncWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);
        
        /// <summary>
        /// Get audits for conversation or recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation, Screen_Recording (optional, default to RECORDING)</param>
        /// <returns>Task of QualityAuditPage</returns>
        System.Threading.Tasks.Task<QualityAuditPage> GetQualityConversationAuditsAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null);

        /// <summary>
        /// Get audits for conversation or recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation, Screen_Recording (optional, default to RECORDING)</param>
        /// <returns>Task of ApiResponse (QualityAuditPage)</returns>
        System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> GetQualityConversationAuditsAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null);
        
        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> GetQualityConversationEvaluationAsync (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> GetQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        
        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationEntityListing> GetQualityEvaluationsQueryAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<Object> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> GetQualityEvaluationsQueryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<Object> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);
        
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
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        System.Threading.Tasks.Task<EvaluatorActivityEntityListing> GetQualityEvaluatorsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<Object> permission = null, string group = null);

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
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> GetQualityEvaluatorsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<Object> permission = null, string group = null);
        
        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> GetQualityFormAsync (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetQualityFormAsyncWithHttpInfo (string formId);
        
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
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> GetQualityFormVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null);

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
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetQualityFormVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get the list of evaluation forms
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
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> GetQualityFormsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null);

        /// <summary>
        /// Get the list of evaluation forms
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
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetQualityFormsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null);
        
        /// <summary>
        /// Get a keywordSet by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>Task of KeywordSet</returns>
        System.Threading.Tasks.Task<KeywordSet> GetQualityKeywordsetAsync (string keywordSetId);

        /// <summary>
        /// Get a keywordSet by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>Task of ApiResponse (KeywordSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeywordSet>> GetQualityKeywordsetAsyncWithHttpInfo (string keywordSetId);
        
        /// <summary>
        /// Get the list of keyword sets
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
        /// <param name="name">the keyword set name - used for filtering results in searches. (optional)</param>
        /// <param name="queueId">the queue id - used for filtering results in searches. (optional)</param>
        /// <param name="agentId">the agent id - used for filtering results in searches. (optional)</param>
        /// <param name="_operator">If agentID and queueId are both present, this determines whether the query is an AND or OR between those parameters. (optional)</param>
        /// <returns>Task of KeywordSetEntityListing</returns>
        System.Threading.Tasks.Task<KeywordSetEntityListing> GetQualityKeywordsetsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, string queueId = null, string agentId = null, string _operator = null);

        /// <summary>
        /// Get the list of keyword sets
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
        /// <param name="name">the keyword set name - used for filtering results in searches. (optional)</param>
        /// <param name="queueId">the queue id - used for filtering results in searches. (optional)</param>
        /// <param name="agentId">the agent id - used for filtering results in searches. (optional)</param>
        /// <param name="_operator">If agentID and queueId are both present, this determines whether the query is an AND or OR between those parameters. (optional)</param>
        /// <returns>Task of ApiResponse (KeywordSetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeywordSetEntityListing>> GetQualityKeywordsetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, string queueId = null, string agentId = null, string _operator = null);
        
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> GetQualityPublishedformAsync (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetQualityPublishedformAsyncWithHttpInfo (string formId);
        
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
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> GetQualityPublishedformsAsync (int? pageSize = null, int? pageNumber = null, string name = null);

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
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetQualityPublishedformsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null);
        
        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        System.Threading.Tasks.Task<AggregateQueryResponse> PostAnalyticsEvaluationsAggregatesQueryAsync (AggregationQuery body);

        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostAnalyticsEvaluationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body);
        
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
        System.Threading.Tasks.Task<Evaluation> PostQualityConversationEvaluationsAsync (string conversationId, Evaluation body, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> PostQualityConversationEvaluationsAsyncWithHttpInfo (string conversationId, Evaluation body, string expand = null);
        
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
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> PostQualityFormsAsync (EvaluationForm body);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PostQualityFormsAsyncWithHttpInfo (EvaluationForm body);
        
        /// <summary>
        /// Create a Keyword Set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">keywordSet</param>
        /// <param name="expand">queueId (optional)</param>
        /// <returns>Task of KeywordSet</returns>
        System.Threading.Tasks.Task<KeywordSet> PostQualityKeywordsetsAsync (KeywordSet body, string expand = null);

        /// <summary>
        /// Create a Keyword Set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">keywordSet</param>
        /// <param name="expand">queueId (optional)</param>
        /// <returns>Task of ApiResponse (KeywordSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeywordSet>> PostQualityKeywordsetsAsyncWithHttpInfo (KeywordSet body, string expand = null);
        
        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> PostQualityPublishedformsAsync (EvaluationForm body);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PostQualityPublishedformsAsyncWithHttpInfo (EvaluationForm body);
        
        /// <summary>
        /// Retrieve the spotability statistic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Keyword Set (optional)</param>
        /// <returns>Task of KeywordSet</returns>
        System.Threading.Tasks.Task<KeywordSet> PostQualitySpotabilityAsync (KeywordSet body = null);

        /// <summary>
        /// Retrieve the spotability statistic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Keyword Set (optional)</param>
        /// <returns>Task of ApiResponse (KeywordSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeywordSet>> PostQualitySpotabilityAsyncWithHttpInfo (KeywordSet body = null);
        
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
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> PutQualityConversationEvaluationAsync (string conversationId, string evaluationId, Evaluation body, string expand = null);

        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> PutQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body, string expand = null);
        
        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> PutQualityFormAsync (string formId, EvaluationForm body);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PutQualityFormAsyncWithHttpInfo (string formId, EvaluationForm body);
        
        /// <summary>
        /// Update a keywordSet to the specified keywordSet via PUT.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <param name="body">keywordSet</param>
        /// <returns>Task of KeywordSet</returns>
        System.Threading.Tasks.Task<KeywordSet> PutQualityKeywordsetAsync (string keywordSetId, KeywordSet body);

        /// <summary>
        /// Update a keywordSet to the specified keywordSet via PUT.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <param name="body">keywordSet</param>
        /// <returns>Task of ApiResponse (KeywordSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeywordSet>> PutQualityKeywordsetAsyncWithHttpInfo (string keywordSetId, KeywordSet body);
        
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
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
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
        public QualityApi(Configuration configuration = null)
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
        /// Delete a calibration by id. 
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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId));

            // Query params
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        
        /// <summary>
        /// Delete a calibration by id. 
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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId));

            // Query params
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        
        
        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation DeleteQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = DeleteQualityConversationEvaluationWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > DeleteQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, string expand = null)
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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarHeaders,
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        
        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> DeleteQualityConversationEvaluationAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await DeleteQualityConversationEvaluationAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> DeleteQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId));

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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarHeaders,
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        
        
        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns></returns>
        public void DeleteQualityForm (string formId)
        {
             DeleteQualityFormWithHttpInfo(formId);
        }

        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteQualityFormAsync (string formId)
        {
             await DeleteQualityFormAsyncWithHttpInfo(formId);

        }

        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse</returns>
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Delete a keywordSet by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns></returns>
        public void DeleteQualityKeywordset (string keywordSetId)
        {
             DeleteQualityKeywordsetWithHttpInfo(keywordSetId);
        }

        /// <summary>
        /// Delete a keywordSet by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteQualityKeywordsetWithHttpInfo (string keywordSetId)
        { 
            // verify the required parameter 'keywordSetId' is set
            if (keywordSetId == null)
                throw new ApiException(400, "Missing required parameter 'keywordSetId' when calling QualityApi->DeleteQualityKeywordset");

            var localVarPath = "/api/v2/quality/keywordsets/{keywordSetId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (keywordSetId != null) localVarPathParams.Add("keywordSetId", Configuration.ApiClient.ParameterToString(keywordSetId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityKeywordset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityKeywordset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete a keywordSet by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteQualityKeywordsetAsync (string keywordSetId)
        {
             await DeleteQualityKeywordsetAsyncWithHttpInfo(keywordSetId);

        }

        /// <summary>
        /// Delete a keywordSet by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityKeywordsetAsyncWithHttpInfo (string keywordSetId)
        { 
            // verify the required parameter 'keywordSetId' is set
            if (keywordSetId == null)
                throw new ApiException(400, "Missing required parameter 'keywordSetId' when calling QualityApi->DeleteQualityKeywordset");
            

            var localVarPath = "/api/v2/quality/keywordsets/{keywordSetId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (keywordSetId != null) localVarPathParams.Add("keywordSetId", Configuration.ApiClient.ParameterToString(keywordSetId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityKeywordset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityKeywordset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Delete keyword sets Bulk delete of keyword sets; this will only delete the keyword sets that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A comma-delimited list of valid KeywordSet ids</param>
        /// <returns></returns>
        public void DeleteQualityKeywordsets (string ids)
        {
             DeleteQualityKeywordsetsWithHttpInfo(ids);
        }

        /// <summary>
        /// Delete keyword sets Bulk delete of keyword sets; this will only delete the keyword sets that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A comma-delimited list of valid KeywordSet ids</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteQualityKeywordsetsWithHttpInfo (string ids)
        { 
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling QualityApi->DeleteQualityKeywordsets");

            var localVarPath = "/api/v2/quality/keywordsets";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (ids != null) localVarQueryParams.Add(new Tuple<string, string>("ids", Configuration.ApiClient.ParameterToString(ids)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityKeywordsets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityKeywordsets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete keyword sets Bulk delete of keyword sets; this will only delete the keyword sets that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A comma-delimited list of valid KeywordSet ids</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteQualityKeywordsetsAsync (string ids)
        {
             await DeleteQualityKeywordsetsAsyncWithHttpInfo(ids);

        }

        /// <summary>
        /// Delete keyword sets Bulk delete of keyword sets; this will only delete the keyword sets that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A comma-delimited list of valid KeywordSet ids</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQualityKeywordsetsAsyncWithHttpInfo (string ids)
        { 
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling QualityApi->DeleteQualityKeywordsets");
            

            var localVarPath = "/api/v2/quality/keywordsets";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (ids != null) localVarQueryParams.Add(new Tuple<string, string>("ids", Configuration.ApiClient.ParameterToString(ids)));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityKeywordsets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQualityKeywordsets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>AgentActivityEntityListing</returns>
        public AgentActivityEntityListing GetQualityAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<Object> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
             ApiResponse<AgentActivityEntityListing> localVarResponse = GetQualityAgentsActivityWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, agentUserId, evaluatorUserId, name, group);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        public ApiResponse< AgentActivityEntityListing > GetQualityAgentsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<Object> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", Configuration.ApiClient.ParameterToString(endTime)));
            if (agentUserId != null) agentUserId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("agentUserId", Configuration.ApiClient.ParameterToString(obj))); });
            if (evaluatorUserId != null) localVarQueryParams.Add(new Tuple<string, string>("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (group != null) localVarQueryParams.Add(new Tuple<string, string>("group", Configuration.ApiClient.ParameterToString(group)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityAgentsActivity: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityAgentsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AgentActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentActivityEntityListing)));
            
        }

        
        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of AgentActivityEntityListing</returns>
        public async System.Threading.Tasks.Task<AgentActivityEntityListing> GetQualityAgentsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<Object> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
             ApiResponse<AgentActivityEntityListing> localVarResponse = await GetQualityAgentsActivityAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, agentUserId, evaluatorUserId, name, group);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (AgentActivityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> GetQualityAgentsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<Object> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", Configuration.ApiClient.ParameterToString(endTime)));
            if (agentUserId != null) agentUserId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("agentUserId", Configuration.ApiClient.ParameterToString(obj))); });
            if (evaluatorUserId != null) localVarQueryParams.Add(new Tuple<string, string>("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (group != null) localVarQueryParams.Add(new Tuple<string, string>("group", Configuration.ApiClient.ParameterToString(group)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityAgentsActivity: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityAgentsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AgentActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentActivityEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        public Calibration GetQualityCalibration (string calibrationId, string calibratorId)
        {
             ApiResponse<Calibration> localVarResponse = GetQualityCalibrationWithHttpInfo(calibrationId, calibratorId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > GetQualityCalibrationWithHttpInfo (string calibrationId, string calibratorId)
        { 
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->GetQualityCalibration");
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->GetQualityCalibration");

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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId));

            // Query params
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        
        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> GetQualityCalibrationAsync (string calibrationId, string calibratorId)
        {
             ApiResponse<Calibration> localVarResponse = await GetQualityCalibrationAsyncWithHttpInfo(calibrationId, calibratorId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> GetQualityCalibrationAsyncWithHttpInfo (string calibrationId, string calibratorId)
        { 
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->GetQualityCalibration");
            
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->GetQualityCalibration");
            

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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId));

            // Query params
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        
        
        /// <summary>
        /// Get the list of calibrations 
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
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>CalibrationEntityListing</returns>
        public CalibrationEntityListing GetQualityCalibrations (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
        {
             ApiResponse<CalibrationEntityListing> localVarResponse = GetQualityCalibrationsWithHttpInfo(calibratorId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, startTime, endTime);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of calibrations 
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
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>ApiResponse of CalibrationEntityListing</returns>
        public ApiResponse< CalibrationEntityListing > GetQualityCalibrationsWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", Configuration.ApiClient.ParameterToString(conversationId)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", Configuration.ApiClient.ParameterToString(endTime)));
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CalibrationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalibrationEntityListing)));
            
        }

        
        /// <summary>
        /// Get the list of calibrations 
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
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>Task of CalibrationEntityListing</returns>
        public async System.Threading.Tasks.Task<CalibrationEntityListing> GetQualityCalibrationsAsync (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
        {
             ApiResponse<CalibrationEntityListing> localVarResponse = await GetQualityCalibrationsAsyncWithHttpInfo(calibratorId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, startTime, endTime);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of calibrations 
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
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>Task of ApiResponse (CalibrationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> GetQualityCalibrationsAsyncWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", Configuration.ApiClient.ParameterToString(conversationId)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", Configuration.ApiClient.ParameterToString(endTime)));
            if (calibratorId != null) localVarQueryParams.Add(new Tuple<string, string>("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CalibrationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalibrationEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get audits for conversation or recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation, Screen_Recording (optional, default to RECORDING)</param>
        /// <returns>QualityAuditPage</returns>
        public QualityAuditPage GetQualityConversationAudits (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> localVarResponse = GetQualityConversationAuditsWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, recordingId, entityType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get audits for conversation or recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation, Screen_Recording (optional, default to RECORDING)</param>
        /// <returns>ApiResponse of QualityAuditPage</returns>
        public ApiResponse< QualityAuditPage > GetQualityConversationAuditsWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetQualityConversationAudits");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/audits";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (recordingId != null) localVarQueryParams.Add(new Tuple<string, string>("recordingId", Configuration.ApiClient.ParameterToString(recordingId)));
            if (entityType != null) localVarQueryParams.Add(new Tuple<string, string>("entityType", Configuration.ApiClient.ParameterToString(entityType)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationAudits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditPage>(localVarStatusCode,
                localVarHeaders,
                (QualityAuditPage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditPage)));
            
        }

        
        /// <summary>
        /// Get audits for conversation or recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation, Screen_Recording (optional, default to RECORDING)</param>
        /// <returns>Task of QualityAuditPage</returns>
        public async System.Threading.Tasks.Task<QualityAuditPage> GetQualityConversationAuditsAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> localVarResponse = await GetQualityConversationAuditsAsyncWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, recordingId, entityType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get audits for conversation or recording 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation, Screen_Recording (optional, default to RECORDING)</param>
        /// <returns>Task of ApiResponse (QualityAuditPage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> GetQualityConversationAuditsAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetQualityConversationAudits");
            

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/audits";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (recordingId != null) localVarQueryParams.Add(new Tuple<string, string>("recordingId", Configuration.ApiClient.ParameterToString(recordingId)));
            if (entityType != null) localVarQueryParams.Add(new Tuple<string, string>("entityType", Configuration.ApiClient.ParameterToString(entityType)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationAudits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditPage>(localVarStatusCode,
                localVarHeaders,
                (QualityAuditPage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditPage)));
            
        }

        
        
        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation GetQualityConversationEvaluation (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = GetQualityConversationEvaluationWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > GetQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, string expand = null)
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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarHeaders,
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        
        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> GetQualityConversationEvaluationAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await GetQualityConversationEvaluationAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> GetQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarHeaders,
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        
        
        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        public EvaluationEntityListing GetQualityEvaluationsQuery (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<Object> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = GetQualityEvaluationsQueryWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        public ApiResponse< EvaluationEntityListing > GetQualityEvaluationsQueryWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<Object> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", Configuration.ApiClient.ParameterToString(conversationId)));
            if (agentUserId != null) localVarQueryParams.Add(new Tuple<string, string>("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)));
            if (evaluatorUserId != null) localVarQueryParams.Add(new Tuple<string, string>("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)));
            if (queueId != null) localVarQueryParams.Add(new Tuple<string, string>("queueId", Configuration.ApiClient.ParameterToString(queueId)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", Configuration.ApiClient.ParameterToString(endTime)));
            if (evaluationState != null) evaluationState.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("evaluationState", Configuration.ApiClient.ParameterToString(obj))); });
            if (isReleased != null) localVarQueryParams.Add(new Tuple<string, string>("isReleased", Configuration.ApiClient.ParameterToString(isReleased)));
            if (agentHasRead != null) localVarQueryParams.Add(new Tuple<string, string>("agentHasRead", Configuration.ApiClient.ParameterToString(agentHasRead)));
            if (expandAnswerTotalScores != null) localVarQueryParams.Add(new Tuple<string, string>("expandAnswerTotalScores", Configuration.ApiClient.ParameterToString(expandAnswerTotalScores)));
            if (maximum != null) localVarQueryParams.Add(new Tuple<string, string>("maximum", Configuration.ApiClient.ParameterToString(maximum)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
            
        }

        
        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationEntityListing> GetQualityEvaluationsQueryAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<Object> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = await GetQualityEvaluationsQueryAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> GetQualityEvaluationsQueryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<Object> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (conversationId != null) localVarQueryParams.Add(new Tuple<string, string>("conversationId", Configuration.ApiClient.ParameterToString(conversationId)));
            if (agentUserId != null) localVarQueryParams.Add(new Tuple<string, string>("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)));
            if (evaluatorUserId != null) localVarQueryParams.Add(new Tuple<string, string>("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)));
            if (queueId != null) localVarQueryParams.Add(new Tuple<string, string>("queueId", Configuration.ApiClient.ParameterToString(queueId)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", Configuration.ApiClient.ParameterToString(endTime)));
            if (evaluationState != null) evaluationState.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("evaluationState", Configuration.ApiClient.ParameterToString(obj))); });
            if (isReleased != null) localVarQueryParams.Add(new Tuple<string, string>("isReleased", Configuration.ApiClient.ParameterToString(isReleased)));
            if (agentHasRead != null) localVarQueryParams.Add(new Tuple<string, string>("agentHasRead", Configuration.ApiClient.ParameterToString(agentHasRead)));
            if (expandAnswerTotalScores != null) localVarQueryParams.Add(new Tuple<string, string>("expandAnswerTotalScores", Configuration.ApiClient.ParameterToString(expandAnswerTotalScores)));
            if (maximum != null) localVarQueryParams.Add(new Tuple<string, string>("maximum", Configuration.ApiClient.ParameterToString(maximum)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>EvaluatorActivityEntityListing</returns>
        public EvaluatorActivityEntityListing GetQualityEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<Object> permission = null, string group = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> localVarResponse = GetQualityEvaluatorsActivityWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, name, permission, group);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of EvaluatorActivityEntityListing</returns>
        public ApiResponse< EvaluatorActivityEntityListing > GetQualityEvaluatorsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<Object> permission = null, string group = null)
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", Configuration.ApiClient.ParameterToString(endTime)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (permission != null) permission.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("permission", Configuration.ApiClient.ParameterToString(obj))); });
            if (group != null) localVarQueryParams.Add(new Tuple<string, string>("group", Configuration.ApiClient.ParameterToString(group)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluatorsActivity: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluatorsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluatorActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluatorActivityEntityListing)));
            
        }

        
        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluatorActivityEntityListing> GetQualityEvaluatorsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<Object> permission = null, string group = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> localVarResponse = await GetQualityEvaluatorsActivityAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, name, permission, group);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> GetQualityEvaluatorsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<Object> permission = null, string group = null)
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (startTime != null) localVarQueryParams.Add(new Tuple<string, string>("startTime", Configuration.ApiClient.ParameterToString(startTime)));
            if (endTime != null) localVarQueryParams.Add(new Tuple<string, string>("endTime", Configuration.ApiClient.ParameterToString(endTime)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (permission != null) permission.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("permission", Configuration.ApiClient.ParameterToString(obj))); });
            if (group != null) localVarQueryParams.Add(new Tuple<string, string>("group", Configuration.ApiClient.ParameterToString(group)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluatorsActivity: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityEvaluatorsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluatorActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluatorActivityEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm GetQualityForm (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = GetQualityFormWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > GetQualityFormWithHttpInfo (string formId)
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId));

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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarHeaders,
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        
        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> GetQualityFormAsync (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = await GetQualityFormAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetQualityFormAsyncWithHttpInfo (string formId)
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId));

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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarHeaders,
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        
        
        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing GetQualityFormVersions (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = GetQualityFormVersionsWithHttpInfo(formId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > GetQualityFormVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        
        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> GetQualityFormVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = await GetQualityFormVersionsAsyncWithHttpInfo(formId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetQualityFormVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityFormVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing GetQualityForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = GetQualityFormsWithHttpInfo(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > GetQualityFormsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null)
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        
        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> GetQualityFormsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = await GetQualityFormsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetQualityFormsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null)
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get a keywordSet by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>KeywordSet</returns>
        public KeywordSet GetQualityKeywordset (string keywordSetId)
        {
             ApiResponse<KeywordSet> localVarResponse = GetQualityKeywordsetWithHttpInfo(keywordSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a keywordSet by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>ApiResponse of KeywordSet</returns>
        public ApiResponse< KeywordSet > GetQualityKeywordsetWithHttpInfo (string keywordSetId)
        { 
            // verify the required parameter 'keywordSetId' is set
            if (keywordSetId == null)
                throw new ApiException(400, "Missing required parameter 'keywordSetId' when calling QualityApi->GetQualityKeywordset");

            var localVarPath = "/api/v2/quality/keywordsets/{keywordSetId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (keywordSetId != null) localVarPathParams.Add("keywordSetId", Configuration.ApiClient.ParameterToString(keywordSetId));

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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityKeywordset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityKeywordset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeywordSet>(localVarStatusCode,
                localVarHeaders,
                (KeywordSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeywordSet)));
            
        }

        
        /// <summary>
        /// Get a keywordSet by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>Task of KeywordSet</returns>
        public async System.Threading.Tasks.Task<KeywordSet> GetQualityKeywordsetAsync (string keywordSetId)
        {
             ApiResponse<KeywordSet> localVarResponse = await GetQualityKeywordsetAsyncWithHttpInfo(keywordSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a keywordSet by id. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <returns>Task of ApiResponse (KeywordSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeywordSet>> GetQualityKeywordsetAsyncWithHttpInfo (string keywordSetId)
        { 
            // verify the required parameter 'keywordSetId' is set
            if (keywordSetId == null)
                throw new ApiException(400, "Missing required parameter 'keywordSetId' when calling QualityApi->GetQualityKeywordset");
            

            var localVarPath = "/api/v2/quality/keywordsets/{keywordSetId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (keywordSetId != null) localVarPathParams.Add("keywordSetId", Configuration.ApiClient.ParameterToString(keywordSetId));

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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityKeywordset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityKeywordset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeywordSet>(localVarStatusCode,
                localVarHeaders,
                (KeywordSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeywordSet)));
            
        }

        
        
        /// <summary>
        /// Get the list of keyword sets 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the keyword set name - used for filtering results in searches. (optional)</param>
        /// <param name="queueId">the queue id - used for filtering results in searches. (optional)</param>
        /// <param name="agentId">the agent id - used for filtering results in searches. (optional)</param>
        /// <param name="_operator">If agentID and queueId are both present, this determines whether the query is an AND or OR between those parameters. (optional)</param>
        /// <returns>KeywordSetEntityListing</returns>
        public KeywordSetEntityListing GetQualityKeywordsets (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, string queueId = null, string agentId = null, string _operator = null)
        {
             ApiResponse<KeywordSetEntityListing> localVarResponse = GetQualityKeywordsetsWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, queueId, agentId, _operator);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of keyword sets 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the keyword set name - used for filtering results in searches. (optional)</param>
        /// <param name="queueId">the queue id - used for filtering results in searches. (optional)</param>
        /// <param name="agentId">the agent id - used for filtering results in searches. (optional)</param>
        /// <param name="_operator">If agentID and queueId are both present, this determines whether the query is an AND or OR between those parameters. (optional)</param>
        /// <returns>ApiResponse of KeywordSetEntityListing</returns>
        public ApiResponse< KeywordSetEntityListing > GetQualityKeywordsetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, string queueId = null, string agentId = null, string _operator = null)
        { 

            var localVarPath = "/api/v2/quality/keywordsets";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (queueId != null) localVarQueryParams.Add(new Tuple<string, string>("queueId", Configuration.ApiClient.ParameterToString(queueId)));
            if (agentId != null) localVarQueryParams.Add(new Tuple<string, string>("agentId", Configuration.ApiClient.ParameterToString(agentId)));
            if (_operator != null) localVarQueryParams.Add(new Tuple<string, string>("operator", Configuration.ApiClient.ParameterToString(_operator)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityKeywordsets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityKeywordsets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeywordSetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (KeywordSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeywordSetEntityListing)));
            
        }

        
        /// <summary>
        /// Get the list of keyword sets 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the keyword set name - used for filtering results in searches. (optional)</param>
        /// <param name="queueId">the queue id - used for filtering results in searches. (optional)</param>
        /// <param name="agentId">the agent id - used for filtering results in searches. (optional)</param>
        /// <param name="_operator">If agentID and queueId are both present, this determines whether the query is an AND or OR between those parameters. (optional)</param>
        /// <returns>Task of KeywordSetEntityListing</returns>
        public async System.Threading.Tasks.Task<KeywordSetEntityListing> GetQualityKeywordsetsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, string queueId = null, string agentId = null, string _operator = null)
        {
             ApiResponse<KeywordSetEntityListing> localVarResponse = await GetQualityKeywordsetsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, queueId, agentId, _operator);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of keyword sets 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the keyword set name - used for filtering results in searches. (optional)</param>
        /// <param name="queueId">the queue id - used for filtering results in searches. (optional)</param>
        /// <param name="agentId">the agent id - used for filtering results in searches. (optional)</param>
        /// <param name="_operator">If agentID and queueId are both present, this determines whether the query is an AND or OR between those parameters. (optional)</param>
        /// <returns>Task of ApiResponse (KeywordSetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeywordSetEntityListing>> GetQualityKeywordsetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, string queueId = null, string agentId = null, string _operator = null)
        { 

            var localVarPath = "/api/v2/quality/keywordsets";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(obj))); });
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", Configuration.ApiClient.ParameterToString(nextPage)));
            if (previousPage != null) localVarQueryParams.Add(new Tuple<string, string>("previousPage", Configuration.ApiClient.ParameterToString(previousPage)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (queueId != null) localVarQueryParams.Add(new Tuple<string, string>("queueId", Configuration.ApiClient.ParameterToString(queueId)));
            if (agentId != null) localVarQueryParams.Add(new Tuple<string, string>("agentId", Configuration.ApiClient.ParameterToString(agentId)));
            if (_operator != null) localVarQueryParams.Add(new Tuple<string, string>("operator", Configuration.ApiClient.ParameterToString(_operator)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityKeywordsets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityKeywordsets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeywordSetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (KeywordSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeywordSetEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm GetQualityPublishedform (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = GetQualityPublishedformWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > GetQualityPublishedformWithHttpInfo (string formId)
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId));

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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedform: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedform: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarHeaders,
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        
        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> GetQualityPublishedformAsync (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = await GetQualityPublishedformAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetQualityPublishedformAsyncWithHttpInfo (string formId)
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId));

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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedform: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedform: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarHeaders,
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        
        
        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing GetQualityPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = GetQualityPublishedformsWithHttpInfo(pageSize, pageNumber, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > GetQualityPublishedformsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null)
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedforms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        
        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> GetQualityPublishedformsAsync (int? pageSize = null, int? pageNumber = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = await GetQualityPublishedformsAsyncWithHttpInfo(pageSize, pageNumber, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetQualityPublishedformsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null)
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedforms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQualityPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        
        
        /// <summary>
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AggregateQueryResponse</returns>
        public AggregateQueryResponse PostAnalyticsEvaluationsAggregatesQuery (AggregationQuery body)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = PostAnalyticsEvaluationsAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        public ApiResponse< AggregateQueryResponse > PostAnalyticsEvaluationsAggregatesQueryWithHttpInfo (AggregationQuery body)
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
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
            
        }

        
        /// <summary>
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        public async System.Threading.Tasks.Task<AggregateQueryResponse> PostAnalyticsEvaluationsAggregatesQueryAsync (AggregationQuery body)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = await PostAnalyticsEvaluationsAggregatesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostAnalyticsEvaluationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body)
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
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsEvaluationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
            
        }

        
        
        /// <summary>
        /// Create a calibration 
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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityCalibrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        
        /// <summary>
        /// Create a calibration 
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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityCalibrations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        
        
        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation PostQualityConversationEvaluations (string conversationId, Evaluation body, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = PostQualityConversationEvaluationsWithHttpInfo(conversationId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > PostQualityConversationEvaluationsWithHttpInfo (string conversationId, Evaluation body, string expand = null)
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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarHeaders,
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        
        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> PostQualityConversationEvaluationsAsync (string conversationId, Evaluation body, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await PostQualityConversationEvaluationsAsyncWithHttpInfo(conversationId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> PostQualityConversationEvaluationsAsyncWithHttpInfo (string conversationId, Evaluation body, string expand = null)
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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationEvaluations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityConversationEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarHeaders,
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        
        
        /// <summary>
        /// Score evaluation 
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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsScoring: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsScoring: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(localVarStatusCode,
                localVarHeaders,
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationScoringSet)));
            
        }

        
        /// <summary>
        /// Score evaluation 
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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsScoring: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityEvaluationsScoring: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(localVarStatusCode,
                localVarHeaders,
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationScoringSet)));
            
        }

        
        
        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm PostQualityForms (EvaluationForm body)
        {
             ApiResponse<EvaluationForm> localVarResponse = PostQualityFormsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > PostQualityFormsWithHttpInfo (EvaluationForm body)
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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityForms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarHeaders,
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        
        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> PostQualityFormsAsync (EvaluationForm body)
        {
             ApiResponse<EvaluationForm> localVarResponse = await PostQualityFormsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PostQualityFormsAsyncWithHttpInfo (EvaluationForm body)
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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityForms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarHeaders,
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        
        
        /// <summary>
        /// Create a Keyword Set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">keywordSet</param>
        /// <param name="expand">queueId (optional)</param>
        /// <returns>KeywordSet</returns>
        public KeywordSet PostQualityKeywordsets (KeywordSet body, string expand = null)
        {
             ApiResponse<KeywordSet> localVarResponse = PostQualityKeywordsetsWithHttpInfo(body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Keyword Set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">keywordSet</param>
        /// <param name="expand">queueId (optional)</param>
        /// <returns>ApiResponse of KeywordSet</returns>
        public ApiResponse< KeywordSet > PostQualityKeywordsetsWithHttpInfo (KeywordSet body, string expand = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityKeywordsets");

            var localVarPath = "/api/v2/quality/keywordsets";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityKeywordsets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityKeywordsets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeywordSet>(localVarStatusCode,
                localVarHeaders,
                (KeywordSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeywordSet)));
            
        }

        
        /// <summary>
        /// Create a Keyword Set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">keywordSet</param>
        /// <param name="expand">queueId (optional)</param>
        /// <returns>Task of KeywordSet</returns>
        public async System.Threading.Tasks.Task<KeywordSet> PostQualityKeywordsetsAsync (KeywordSet body, string expand = null)
        {
             ApiResponse<KeywordSet> localVarResponse = await PostQualityKeywordsetsAsyncWithHttpInfo(body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Keyword Set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">keywordSet</param>
        /// <param name="expand">queueId (optional)</param>
        /// <returns>Task of ApiResponse (KeywordSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeywordSet>> PostQualityKeywordsetsAsyncWithHttpInfo (KeywordSet body, string expand = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PostQualityKeywordsets");
            

            var localVarPath = "/api/v2/quality/keywordsets";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityKeywordsets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityKeywordsets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeywordSet>(localVarStatusCode,
                localVarHeaders,
                (KeywordSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeywordSet)));
            
        }

        
        
        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm PostQualityPublishedforms (EvaluationForm body)
        {
             ApiResponse<EvaluationForm> localVarResponse = PostQualityPublishedformsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > PostQualityPublishedformsWithHttpInfo (EvaluationForm body)
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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedforms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarHeaders,
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        
        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> PostQualityPublishedformsAsync (EvaluationForm body)
        {
             ApiResponse<EvaluationForm> localVarResponse = await PostQualityPublishedformsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PostQualityPublishedformsAsyncWithHttpInfo (EvaluationForm body)
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
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedforms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualityPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarHeaders,
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        
        
        /// <summary>
        /// Retrieve the spotability statistic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Keyword Set (optional)</param>
        /// <returns>KeywordSet</returns>
        public KeywordSet PostQualitySpotability (KeywordSet body = null)
        {
             ApiResponse<KeywordSet> localVarResponse = PostQualitySpotabilityWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the spotability statistic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Keyword Set (optional)</param>
        /// <returns>ApiResponse of KeywordSet</returns>
        public ApiResponse< KeywordSet > PostQualitySpotabilityWithHttpInfo (KeywordSet body = null)
        { 

            var localVarPath = "/api/v2/quality/spotability";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostQualitySpotability: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualitySpotability: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeywordSet>(localVarStatusCode,
                localVarHeaders,
                (KeywordSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeywordSet)));
            
        }

        
        /// <summary>
        /// Retrieve the spotability statistic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Keyword Set (optional)</param>
        /// <returns>Task of KeywordSet</returns>
        public async System.Threading.Tasks.Task<KeywordSet> PostQualitySpotabilityAsync (KeywordSet body = null)
        {
             ApiResponse<KeywordSet> localVarResponse = await PostQualitySpotabilityAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the spotability statistic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Keyword Set (optional)</param>
        /// <returns>Task of ApiResponse (KeywordSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeywordSet>> PostQualitySpotabilityAsyncWithHttpInfo (KeywordSet body = null)
        { 

            var localVarPath = "/api/v2/quality/spotability";
            var localVarPathParams = new Dictionary<String, String>();
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
                throw new ApiException (localVarStatusCode, "Error calling PostQualitySpotability: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQualitySpotability: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeywordSet>(localVarStatusCode,
                localVarHeaders,
                (KeywordSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeywordSet)));
            
        }

        
        
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutQualityCalibration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityCalibration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarHeaders,
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        
        
        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation PutQualityConversationEvaluation (string conversationId, string evaluationId, Evaluation body, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = PutQualityConversationEvaluationWithHttpInfo(conversationId, evaluationId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > PutQualityConversationEvaluationWithHttpInfo (string conversationId, string evaluationId, Evaluation body, string expand = null)
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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling PutQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarHeaders,
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        
        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> PutQualityConversationEvaluationAsync (string conversationId, string evaluationId, Evaluation body, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await PutQualityConversationEvaluationAsyncWithHttpInfo(conversationId, evaluationId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="evaluationId">evaluationId</param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> PutQualityConversationEvaluationAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body, string expand = null)
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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", Configuration.ApiClient.ParameterToString(expand)));

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
                throw new ApiException (localVarStatusCode, "Error calling PutQualityConversationEvaluation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityConversationEvaluation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarHeaders,
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        
        
        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm PutQualityForm (string formId, EvaluationForm body)
        {
             ApiResponse<EvaluationForm> localVarResponse = PutQualityFormWithHttpInfo(formId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > PutQualityFormWithHttpInfo (string formId, EvaluationForm body)
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarHeaders,
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        
        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> PutQualityFormAsync (string formId, EvaluationForm body)
        {
             ApiResponse<EvaluationForm> localVarResponse = await PutQualityFormAsyncWithHttpInfo(formId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body">Evaluation form</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PutQualityFormAsyncWithHttpInfo (string formId, EvaluationForm body)
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutQualityForm: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarHeaders,
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        
        
        /// <summary>
        /// Update a keywordSet to the specified keywordSet via PUT. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <param name="body">keywordSet</param>
        /// <returns>KeywordSet</returns>
        public KeywordSet PutQualityKeywordset (string keywordSetId, KeywordSet body)
        {
             ApiResponse<KeywordSet> localVarResponse = PutQualityKeywordsetWithHttpInfo(keywordSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a keywordSet to the specified keywordSet via PUT. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <param name="body">keywordSet</param>
        /// <returns>ApiResponse of KeywordSet</returns>
        public ApiResponse< KeywordSet > PutQualityKeywordsetWithHttpInfo (string keywordSetId, KeywordSet body)
        { 
            // verify the required parameter 'keywordSetId' is set
            if (keywordSetId == null)
                throw new ApiException(400, "Missing required parameter 'keywordSetId' when calling QualityApi->PutQualityKeywordset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityKeywordset");

            var localVarPath = "/api/v2/quality/keywordsets/{keywordSetId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (keywordSetId != null) localVarPathParams.Add("keywordSetId", Configuration.ApiClient.ParameterToString(keywordSetId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutQualityKeywordset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityKeywordset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeywordSet>(localVarStatusCode,
                localVarHeaders,
                (KeywordSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeywordSet)));
            
        }

        
        /// <summary>
        /// Update a keywordSet to the specified keywordSet via PUT. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <param name="body">keywordSet</param>
        /// <returns>Task of KeywordSet</returns>
        public async System.Threading.Tasks.Task<KeywordSet> PutQualityKeywordsetAsync (string keywordSetId, KeywordSet body)
        {
             ApiResponse<KeywordSet> localVarResponse = await PutQualityKeywordsetAsyncWithHttpInfo(keywordSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a keywordSet to the specified keywordSet via PUT. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keywordSetId">KeywordSet ID</param>
        /// <param name="body">keywordSet</param>
        /// <returns>Task of ApiResponse (KeywordSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeywordSet>> PutQualityKeywordsetAsyncWithHttpInfo (string keywordSetId, KeywordSet body)
        { 
            // verify the required parameter 'keywordSetId' is set
            if (keywordSetId == null)
                throw new ApiException(400, "Missing required parameter 'keywordSetId' when calling QualityApi->PutQualityKeywordset");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutQualityKeywordset");
            

            var localVarPath = "/api/v2/quality/keywordsets/{keywordSetId}";
            var localVarPathParams = new Dictionary<String, String>();
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
            if (keywordSetId != null) localVarPathParams.Add("keywordSetId", Configuration.ApiClient.ParameterToString(keywordSetId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutQualityKeywordset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQualityKeywordset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeywordSet>(localVarStatusCode,
                localVarHeaders,
                (KeywordSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeywordSet)));
            
        }

        
        
    }
    
}
