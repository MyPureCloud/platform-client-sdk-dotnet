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
    public interface IAIStudioApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Start the deletion of a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteGuideJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>GuideJob</returns>
        
        GuideJob DeleteGuideJobs (string guideId);

        /// <summary>
        /// Start the deletion of a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteGuideJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>ApiResponse of GuideJob</returns>
        
        ApiResponse<GuideJob> DeleteGuideJobsWithHttpInfo (string guideId);

        /// <summary>
        /// Get guide.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>Guide</returns>
        
        Guide GetGuide (string guideId);

        /// <summary>
        /// Get guide.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>ApiResponse of Guide</returns>
        
        ApiResponse<Guide> GetGuideWithHttpInfo (string guideId);

        /// <summary>
        /// Get the specified guide deletion job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>GuideJob</returns>
        
        GuideJob GetGuideJob (string guideId, string jobId);

        /// <summary>
        /// Get the specified guide deletion job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of GuideJob</returns>
        
        ApiResponse<GuideJob> GetGuideJobWithHttpInfo (string guideId, string jobId);

        /// <summary>
        /// Get a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <returns>GuideVersion</returns>
        
        GuideVersion GetGuideVersion (string guideId, string versionId);

        /// <summary>
        /// Get a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <returns>ApiResponse of GuideVersion</returns>
        
        ApiResponse<GuideVersion> GetGuideVersionWithHttpInfo (string guideId, string versionId);

        /// <summary>
        /// Get the status of the publishing job for this guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>GuideVersionPublishJob</returns>
        
        GuideVersionPublishJob GetGuideVersionJob (string guideId, string versionId, string jobId);

        /// <summary>
        /// Get the status of the publishing job for this guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of GuideVersionPublishJob</returns>
        
        ApiResponse<GuideVersionPublishJob> GetGuideVersionJobWithHttpInfo (string guideId, string versionId, string jobId);

        /// <summary>
        /// Get all guides.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>GuideEntityListing</returns>
        
        GuideEntityListing GetGuides (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all guides.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>ApiResponse of GuideEntityListing</returns>
        
        ApiResponse<GuideEntityListing> GetGuidesWithHttpInfo (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get the status of the guide content generation job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuidesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>GuideContentGenerationJob</returns>
        
        GuideContentGenerationJob GetGuidesJob (string jobId);

        /// <summary>
        /// Get the status of the guide content generation job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuidesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of GuideContentGenerationJob</returns>
        
        ApiResponse<GuideContentGenerationJob> GetGuidesJobWithHttpInfo (string jobId);

        /// <summary>
        /// Update a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"></param>
        /// <returns>Guide</returns>
        
        Guide PatchGuide (string guideId, UpdateGuide body);

        /// <summary>
        /// Update a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Guide</returns>
        
        ApiResponse<Guide> PatchGuideWithHttpInfo (string guideId, UpdateGuide body);

        /// <summary>
        /// Update a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>GuideVersion</returns>
        
        GuideVersion PatchGuideVersion (string guideId, string versionId, UpdateGuideVersion body);

        /// <summary>
        /// Update a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of GuideVersion</returns>
        
        ApiResponse<GuideVersion> PatchGuideVersionWithHttpInfo (string guideId, string versionId, UpdateGuideVersion body);

        /// <summary>
        /// Start the publishing of a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuideVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>GuideVersionPublishJob</returns>
        
        GuideVersionPublishJob PostGuideVersionJobs (string guideId, string versionId, GuideVersionPublishJobRequest body);

        /// <summary>
        /// Start the publishing of a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuideVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of GuideVersionPublishJob</returns>
        
        ApiResponse<GuideVersionPublishJob> PostGuideVersionJobsWithHttpInfo (string guideId, string versionId, GuideVersionPublishJobRequest body);

        /// <summary>
        /// Create a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuideVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>GuideVersion</returns>
        
        GuideVersion PostGuideVersions (string guideId, CreateGuideVersion body = null);

        /// <summary>
        /// Create a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuideVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of GuideVersion</returns>
        
        ApiResponse<GuideVersion> PostGuideVersionsWithHttpInfo (string guideId, CreateGuideVersion body = null);

        /// <summary>
        /// Create a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Guide</returns>
        
        Guide PostGuides (CreateGuide body);

        /// <summary>
        /// Create a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Guide</returns>
        
        ApiResponse<Guide> PostGuidesWithHttpInfo (CreateGuide body);

        /// <summary>
        /// Start a guide content generation job.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuidesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>GuideContentGenerationJob</returns>
        
        GuideContentGenerationJob PostGuidesJobs (GenerateGuideContentRequest body);

        /// <summary>
        /// Start a guide content generation job.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuidesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of GuideContentGenerationJob</returns>
        
        ApiResponse<GuideContentGenerationJob> PostGuidesJobsWithHttpInfo (GenerateGuideContentRequest body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Start the deletion of a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteGuideJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>Task of GuideJob</returns>
        
        System.Threading.Tasks.Task<GuideJob> DeleteGuideJobsAsync (string guideId);

        /// <summary>
        /// Start the deletion of a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteGuideJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>Task of ApiResponse (GuideJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GuideJob>> DeleteGuideJobsAsyncWithHttpInfo (string guideId);

        /// <summary>
        /// Get guide.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>Task of Guide</returns>
        
        System.Threading.Tasks.Task<Guide> GetGuideAsync (string guideId);

        /// <summary>
        /// Get guide.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>Task of ApiResponse (Guide)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Guide>> GetGuideAsyncWithHttpInfo (string guideId);

        /// <summary>
        /// Get the specified guide deletion job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of GuideJob</returns>
        
        System.Threading.Tasks.Task<GuideJob> GetGuideJobAsync (string guideId, string jobId);

        /// <summary>
        /// Get the specified guide deletion job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (GuideJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GuideJob>> GetGuideJobAsyncWithHttpInfo (string guideId, string jobId);

        /// <summary>
        /// Get a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <returns>Task of GuideVersion</returns>
        
        System.Threading.Tasks.Task<GuideVersion> GetGuideVersionAsync (string guideId, string versionId);

        /// <summary>
        /// Get a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <returns>Task of ApiResponse (GuideVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GuideVersion>> GetGuideVersionAsyncWithHttpInfo (string guideId, string versionId);

        /// <summary>
        /// Get the status of the publishing job for this guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of GuideVersionPublishJob</returns>
        
        System.Threading.Tasks.Task<GuideVersionPublishJob> GetGuideVersionJobAsync (string guideId, string versionId, string jobId);

        /// <summary>
        /// Get the status of the publishing job for this guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuideVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (GuideVersionPublishJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GuideVersionPublishJob>> GetGuideVersionJobAsyncWithHttpInfo (string guideId, string versionId, string jobId);

        /// <summary>
        /// Get all guides.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>Task of GuideEntityListing</returns>
        
        System.Threading.Tasks.Task<GuideEntityListing> GetGuidesAsync (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get all guides.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (GuideEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GuideEntityListing>> GetGuidesAsyncWithHttpInfo (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get the status of the guide content generation job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuidesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of GuideContentGenerationJob</returns>
        
        System.Threading.Tasks.Task<GuideContentGenerationJob> GetGuidesJobAsync (string jobId);

        /// <summary>
        /// Get the status of the guide content generation job.
        /// </summary>
        /// <remarks>
        /// 
        /// GetGuidesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (GuideContentGenerationJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GuideContentGenerationJob>> GetGuidesJobAsyncWithHttpInfo (string jobId);

        /// <summary>
        /// Update a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Guide</returns>
        
        System.Threading.Tasks.Task<Guide> PatchGuideAsync (string guideId, UpdateGuide body);

        /// <summary>
        /// Update a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Guide)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Guide>> PatchGuideAsyncWithHttpInfo (string guideId, UpdateGuide body);

        /// <summary>
        /// Update a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of GuideVersion</returns>
        
        System.Threading.Tasks.Task<GuideVersion> PatchGuideVersionAsync (string guideId, string versionId, UpdateGuideVersion body);

        /// <summary>
        /// Update a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (GuideVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GuideVersion>> PatchGuideVersionAsyncWithHttpInfo (string guideId, string versionId, UpdateGuideVersion body);

        /// <summary>
        /// Start the publishing of a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuideVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of GuideVersionPublishJob</returns>
        
        System.Threading.Tasks.Task<GuideVersionPublishJob> PostGuideVersionJobsAsync (string guideId, string versionId, GuideVersionPublishJobRequest body);

        /// <summary>
        /// Start the publishing of a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuideVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (GuideVersionPublishJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GuideVersionPublishJob>> PostGuideVersionJobsAsyncWithHttpInfo (string guideId, string versionId, GuideVersionPublishJobRequest body);

        /// <summary>
        /// Create a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuideVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of GuideVersion</returns>
        
        System.Threading.Tasks.Task<GuideVersion> PostGuideVersionsAsync (string guideId, CreateGuideVersion body = null);

        /// <summary>
        /// Create a guide version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuideVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (GuideVersion)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GuideVersion>> PostGuideVersionsAsyncWithHttpInfo (string guideId, CreateGuideVersion body = null);

        /// <summary>
        /// Create a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Guide</returns>
        
        System.Threading.Tasks.Task<Guide> PostGuidesAsync (CreateGuide body);

        /// <summary>
        /// Create a guide.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Guide)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Guide>> PostGuidesAsyncWithHttpInfo (CreateGuide body);

        /// <summary>
        /// Start a guide content generation job.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuidesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of GuideContentGenerationJob</returns>
        
        System.Threading.Tasks.Task<GuideContentGenerationJob> PostGuidesJobsAsync (GenerateGuideContentRequest body);

        /// <summary>
        /// Start a guide content generation job.
        /// </summary>
        /// <remarks>
        /// 
        /// PostGuidesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (GuideContentGenerationJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<GuideContentGenerationJob>> PostGuidesJobsAsyncWithHttpInfo (GenerateGuideContentRequest body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AIStudioApi : IAIStudioApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AIStudioApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AIStudioApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIStudioApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AIStudioApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Start the deletion of a guide. 
        /// 
        /// DeleteGuideJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>GuideJob</returns>
        
        public GuideJob DeleteGuideJobs (string guideId)
        {
             ApiResponse<GuideJob> localVarResponse = DeleteGuideJobsWithHttpInfo(guideId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start the deletion of a guide. 
        /// 
        /// DeleteGuideJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>ApiResponse of GuideJob</returns>
        
        public ApiResponse< GuideJob > DeleteGuideJobsWithHttpInfo (string guideId)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->DeleteGuideJobs");

            var localVarPath = "/api/v2/guides/{guideId}/jobs";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteGuideJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteGuideJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideJob>(localVarStatusCode,
                localVarHeaders,
                (GuideJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Start the deletion of a guide. 
        /// 
        /// DeleteGuideJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>Task of GuideJob</returns>
        
        public async System.Threading.Tasks.Task<GuideJob> DeleteGuideJobsAsync (string guideId)
        {
             ApiResponse<GuideJob> localVarResponse = await DeleteGuideJobsAsyncWithHttpInfo(guideId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start the deletion of a guide. 
        /// 
        /// DeleteGuideJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>Task of ApiResponse (GuideJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GuideJob>> DeleteGuideJobsAsyncWithHttpInfo (string guideId)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->DeleteGuideJobs");
            

            var localVarPath = "/api/v2/guides/{guideId}/jobs";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteGuideJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteGuideJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideJob>(localVarStatusCode,
                localVarHeaders,
                (GuideJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get guide. 
        /// 
        /// GetGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>Guide</returns>
        
        public Guide GetGuide (string guideId)
        {
             ApiResponse<Guide> localVarResponse = GetGuideWithHttpInfo(guideId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get guide. 
        /// 
        /// GetGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>ApiResponse of Guide</returns>
        
        public ApiResponse< Guide > GetGuideWithHttpInfo (string guideId)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->GetGuide");

            var localVarPath = "/api/v2/guides/{guideId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetGuide: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuide: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Guide>(localVarStatusCode,
                localVarHeaders,
                (Guide) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Guide)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get guide. 
        /// 
        /// GetGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>Task of Guide</returns>
        
        public async System.Threading.Tasks.Task<Guide> GetGuideAsync (string guideId)
        {
             ApiResponse<Guide> localVarResponse = await GetGuideAsyncWithHttpInfo(guideId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get guide. 
        /// 
        /// GetGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <returns>Task of ApiResponse (Guide)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Guide>> GetGuideAsyncWithHttpInfo (string guideId)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->GetGuide");
            

            var localVarPath = "/api/v2/guides/{guideId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetGuide: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuide: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Guide>(localVarStatusCode,
                localVarHeaders,
                (Guide) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Guide)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the specified guide deletion job. 
        /// 
        /// GetGuideJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>GuideJob</returns>
        
        public GuideJob GetGuideJob (string guideId, string jobId)
        {
             ApiResponse<GuideJob> localVarResponse = GetGuideJobWithHttpInfo(guideId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the specified guide deletion job. 
        /// 
        /// GetGuideJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of GuideJob</returns>
        
        public ApiResponse< GuideJob > GetGuideJobWithHttpInfo (string guideId, string jobId)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->GetGuideJob");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling AIStudioApi->GetGuideJob");

            var localVarPath = "/api/v2/guides/{guideId}/jobs/{jobId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetGuideJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuideJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideJob>(localVarStatusCode,
                localVarHeaders,
                (GuideJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the specified guide deletion job. 
        /// 
        /// GetGuideJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of GuideJob</returns>
        
        public async System.Threading.Tasks.Task<GuideJob> GetGuideJobAsync (string guideId, string jobId)
        {
             ApiResponse<GuideJob> localVarResponse = await GetGuideJobAsyncWithHttpInfo(guideId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the specified guide deletion job. 
        /// 
        /// GetGuideJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (GuideJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GuideJob>> GetGuideJobAsyncWithHttpInfo (string guideId, string jobId)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->GetGuideJob");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling AIStudioApi->GetGuideJob");
            

            var localVarPath = "/api/v2/guides/{guideId}/jobs/{jobId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetGuideJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuideJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideJob>(localVarStatusCode,
                localVarHeaders,
                (GuideJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a guide version. 
        /// 
        /// GetGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <returns>GuideVersion</returns>
        
        public GuideVersion GetGuideVersion (string guideId, string versionId)
        {
             ApiResponse<GuideVersion> localVarResponse = GetGuideVersionWithHttpInfo(guideId, versionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a guide version. 
        /// 
        /// GetGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <returns>ApiResponse of GuideVersion</returns>
        
        public ApiResponse< GuideVersion > GetGuideVersionWithHttpInfo (string guideId, string versionId)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->GetGuideVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling AIStudioApi->GetGuideVersion");

            var localVarPath = "/api/v2/guides/{guideId}/versions/{versionId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetGuideVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuideVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideVersion>(localVarStatusCode,
                localVarHeaders,
                (GuideVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a guide version. 
        /// 
        /// GetGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <returns>Task of GuideVersion</returns>
        
        public async System.Threading.Tasks.Task<GuideVersion> GetGuideVersionAsync (string guideId, string versionId)
        {
             ApiResponse<GuideVersion> localVarResponse = await GetGuideVersionAsyncWithHttpInfo(guideId, versionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a guide version. 
        /// 
        /// GetGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <returns>Task of ApiResponse (GuideVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GuideVersion>> GetGuideVersionAsyncWithHttpInfo (string guideId, string versionId)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->GetGuideVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling AIStudioApi->GetGuideVersion");
            

            var localVarPath = "/api/v2/guides/{guideId}/versions/{versionId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetGuideVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuideVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideVersion>(localVarStatusCode,
                localVarHeaders,
                (GuideVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the status of the publishing job for this guide version. 
        /// 
        /// GetGuideVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>GuideVersionPublishJob</returns>
        
        public GuideVersionPublishJob GetGuideVersionJob (string guideId, string versionId, string jobId)
        {
             ApiResponse<GuideVersionPublishJob> localVarResponse = GetGuideVersionJobWithHttpInfo(guideId, versionId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of the publishing job for this guide version. 
        /// 
        /// GetGuideVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of GuideVersionPublishJob</returns>
        
        public ApiResponse< GuideVersionPublishJob > GetGuideVersionJobWithHttpInfo (string guideId, string versionId, string jobId)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->GetGuideVersionJob");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling AIStudioApi->GetGuideVersionJob");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling AIStudioApi->GetGuideVersionJob");

            var localVarPath = "/api/v2/guides/{guideId}/versions/{versionId}/jobs/{jobId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetGuideVersionJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuideVersionJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideVersionPublishJob>(localVarStatusCode,
                localVarHeaders,
                (GuideVersionPublishJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideVersionPublishJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the status of the publishing job for this guide version. 
        /// 
        /// GetGuideVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of GuideVersionPublishJob</returns>
        
        public async System.Threading.Tasks.Task<GuideVersionPublishJob> GetGuideVersionJobAsync (string guideId, string versionId, string jobId)
        {
             ApiResponse<GuideVersionPublishJob> localVarResponse = await GetGuideVersionJobAsyncWithHttpInfo(guideId, versionId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the status of the publishing job for this guide version. 
        /// 
        /// GetGuideVersionJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (GuideVersionPublishJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GuideVersionPublishJob>> GetGuideVersionJobAsyncWithHttpInfo (string guideId, string versionId, string jobId)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->GetGuideVersionJob");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling AIStudioApi->GetGuideVersionJob");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling AIStudioApi->GetGuideVersionJob");
            

            var localVarPath = "/api/v2/guides/{guideId}/versions/{versionId}/jobs/{jobId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetGuideVersionJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuideVersionJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideVersionPublishJob>(localVarStatusCode,
                localVarHeaders,
                (GuideVersionPublishJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideVersionPublishJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get all guides. 
        /// 
        /// GetGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>GuideEntityListing</returns>
        
        public GuideEntityListing GetGuides (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<GuideEntityListing> localVarResponse = GetGuidesWithHttpInfo(name, nameContains, status, sortBy, sortOrder, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all guides. 
        /// 
        /// GetGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>ApiResponse of GuideEntityListing</returns>
        
        public ApiResponse< GuideEntityListing > GetGuidesWithHttpInfo (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/guides";
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (nameContains != null) localVarQueryParams.Add(new Tuple<string, string>("nameContains", this.Configuration.ApiClient.ParameterToString(nameContains)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetGuides: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuides: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideEntityListing>(localVarStatusCode,
                localVarHeaders,
                (GuideEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get all guides. 
        /// 
        /// GetGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>Task of GuideEntityListing</returns>
        
        public async System.Threading.Tasks.Task<GuideEntityListing> GetGuidesAsync (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<GuideEntityListing> localVarResponse = await GetGuidesAsyncWithHttpInfo(name, nameContains, status, sortBy, sortOrder, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all guides. 
        /// 
        /// GetGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Filter by matching name - case insensitive. (optional)</param>
        /// <param name="nameContains">Filter by name contains - case insensitive. (optional)</param>
        /// <param name="status">Filter by status. (optional)</param>
        /// <param name="sortBy">Sort by. Default value dateModified. (optional, default to dateModified)</param>
        /// <param name="sortOrder">Sort Order. Default value desc. (optional, default to desc)</param>
        /// <param name="pageNumber">Page number. (optional, default to 1)</param>
        /// <param name="pageSize">Page size. The maximum page size is 100. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (GuideEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GuideEntityListing>> GetGuidesAsyncWithHttpInfo (string name = null, string nameContains = null, string status = null, string sortBy = null, string sortOrder = null, int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/guides";
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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (nameContains != null) localVarQueryParams.Add(new Tuple<string, string>("nameContains", this.Configuration.ApiClient.ParameterToString(nameContains)));
            if (status != null) localVarQueryParams.Add(new Tuple<string, string>("status", this.Configuration.ApiClient.ParameterToString(status)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetGuides: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuides: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideEntityListing>(localVarStatusCode,
                localVarHeaders,
                (GuideEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the status of the guide content generation job. 
        /// 
        /// GetGuidesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>GuideContentGenerationJob</returns>
        
        public GuideContentGenerationJob GetGuidesJob (string jobId)
        {
             ApiResponse<GuideContentGenerationJob> localVarResponse = GetGuidesJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of the guide content generation job. 
        /// 
        /// GetGuidesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>ApiResponse of GuideContentGenerationJob</returns>
        
        public ApiResponse< GuideContentGenerationJob > GetGuidesJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling AIStudioApi->GetGuidesJob");

            var localVarPath = "/api/v2/guides/jobs/{jobId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetGuidesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuidesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideContentGenerationJob>(localVarStatusCode,
                localVarHeaders,
                (GuideContentGenerationJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideContentGenerationJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the status of the guide content generation job. 
        /// 
        /// GetGuidesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of GuideContentGenerationJob</returns>
        
        public async System.Threading.Tasks.Task<GuideContentGenerationJob> GetGuidesJobAsync (string jobId)
        {
             ApiResponse<GuideContentGenerationJob> localVarResponse = await GetGuidesJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the status of the guide content generation job. 
        /// 
        /// GetGuidesJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">jobId</param>
        /// <returns>Task of ApiResponse (GuideContentGenerationJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GuideContentGenerationJob>> GetGuidesJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling AIStudioApi->GetGuidesJob");
            

            var localVarPath = "/api/v2/guides/jobs/{jobId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetGuidesJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGuidesJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideContentGenerationJob>(localVarStatusCode,
                localVarHeaders,
                (GuideContentGenerationJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideContentGenerationJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a guide. 
        /// 
        /// PatchGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"></param>
        /// <returns>Guide</returns>
        
        public Guide PatchGuide (string guideId, UpdateGuide body)
        {
             ApiResponse<Guide> localVarResponse = PatchGuideWithHttpInfo(guideId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a guide. 
        /// 
        /// PatchGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Guide</returns>
        
        public ApiResponse< Guide > PatchGuideWithHttpInfo (string guideId, UpdateGuide body)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->PatchGuide");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AIStudioApi->PatchGuide");

            var localVarPath = "/api/v2/guides/{guideId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchGuide: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchGuide: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Guide>(localVarStatusCode,
                localVarHeaders,
                (Guide) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Guide)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a guide. 
        /// 
        /// PatchGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Guide</returns>
        
        public async System.Threading.Tasks.Task<Guide> PatchGuideAsync (string guideId, UpdateGuide body)
        {
             ApiResponse<Guide> localVarResponse = await PatchGuideAsyncWithHttpInfo(guideId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a guide. 
        /// 
        /// PatchGuide is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Guide)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Guide>> PatchGuideAsyncWithHttpInfo (string guideId, UpdateGuide body)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->PatchGuide");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AIStudioApi->PatchGuide");
            

            var localVarPath = "/api/v2/guides/{guideId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchGuide: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchGuide: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Guide>(localVarStatusCode,
                localVarHeaders,
                (Guide) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Guide)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update a guide version. 
        /// 
        /// PatchGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>GuideVersion</returns>
        
        public GuideVersion PatchGuideVersion (string guideId, string versionId, UpdateGuideVersion body)
        {
             ApiResponse<GuideVersion> localVarResponse = PatchGuideVersionWithHttpInfo(guideId, versionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a guide version. 
        /// 
        /// PatchGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of GuideVersion</returns>
        
        public ApiResponse< GuideVersion > PatchGuideVersionWithHttpInfo (string guideId, string versionId, UpdateGuideVersion body)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->PatchGuideVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling AIStudioApi->PatchGuideVersion");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AIStudioApi->PatchGuideVersion");

            var localVarPath = "/api/v2/guides/{guideId}/versions/{versionId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchGuideVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchGuideVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideVersion>(localVarStatusCode,
                localVarHeaders,
                (GuideVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update a guide version. 
        /// 
        /// PatchGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of GuideVersion</returns>
        
        public async System.Threading.Tasks.Task<GuideVersion> PatchGuideVersionAsync (string guideId, string versionId, UpdateGuideVersion body)
        {
             ApiResponse<GuideVersion> localVarResponse = await PatchGuideVersionAsyncWithHttpInfo(guideId, versionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a guide version. 
        /// 
        /// PatchGuideVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (GuideVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GuideVersion>> PatchGuideVersionAsyncWithHttpInfo (string guideId, string versionId, UpdateGuideVersion body)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->PatchGuideVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling AIStudioApi->PatchGuideVersion");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AIStudioApi->PatchGuideVersion");
            

            var localVarPath = "/api/v2/guides/{guideId}/versions/{versionId}";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchGuideVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchGuideVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideVersion>(localVarStatusCode,
                localVarHeaders,
                (GuideVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Start the publishing of a guide version. 
        /// 
        /// PostGuideVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>GuideVersionPublishJob</returns>
        
        public GuideVersionPublishJob PostGuideVersionJobs (string guideId, string versionId, GuideVersionPublishJobRequest body)
        {
             ApiResponse<GuideVersionPublishJob> localVarResponse = PostGuideVersionJobsWithHttpInfo(guideId, versionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start the publishing of a guide version. 
        /// 
        /// PostGuideVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of GuideVersionPublishJob</returns>
        
        public ApiResponse< GuideVersionPublishJob > PostGuideVersionJobsWithHttpInfo (string guideId, string versionId, GuideVersionPublishJobRequest body)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->PostGuideVersionJobs");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling AIStudioApi->PostGuideVersionJobs");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AIStudioApi->PostGuideVersionJobs");

            var localVarPath = "/api/v2/guides/{guideId}/versions/{versionId}/jobs";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostGuideVersionJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGuideVersionJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideVersionPublishJob>(localVarStatusCode,
                localVarHeaders,
                (GuideVersionPublishJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideVersionPublishJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Start the publishing of a guide version. 
        /// 
        /// PostGuideVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of GuideVersionPublishJob</returns>
        
        public async System.Threading.Tasks.Task<GuideVersionPublishJob> PostGuideVersionJobsAsync (string guideId, string versionId, GuideVersionPublishJobRequest body)
        {
             ApiResponse<GuideVersionPublishJob> localVarResponse = await PostGuideVersionJobsAsyncWithHttpInfo(guideId, versionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start the publishing of a guide version. 
        /// 
        /// PostGuideVersionJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (GuideVersionPublishJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GuideVersionPublishJob>> PostGuideVersionJobsAsyncWithHttpInfo (string guideId, string versionId, GuideVersionPublishJobRequest body)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->PostGuideVersionJobs");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling AIStudioApi->PostGuideVersionJobs");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AIStudioApi->PostGuideVersionJobs");
            

            var localVarPath = "/api/v2/guides/{guideId}/versions/{versionId}/jobs";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostGuideVersionJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGuideVersionJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideVersionPublishJob>(localVarStatusCode,
                localVarHeaders,
                (GuideVersionPublishJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideVersionPublishJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a guide version. 
        /// 
        /// PostGuideVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>GuideVersion</returns>
        
        public GuideVersion PostGuideVersions (string guideId, CreateGuideVersion body = null)
        {
             ApiResponse<GuideVersion> localVarResponse = PostGuideVersionsWithHttpInfo(guideId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a guide version. 
        /// 
        /// PostGuideVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of GuideVersion</returns>
        
        public ApiResponse< GuideVersion > PostGuideVersionsWithHttpInfo (string guideId, CreateGuideVersion body = null)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->PostGuideVersions");

            var localVarPath = "/api/v2/guides/{guideId}/versions";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostGuideVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGuideVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideVersion>(localVarStatusCode,
                localVarHeaders,
                (GuideVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a guide version. 
        /// 
        /// PostGuideVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of GuideVersion</returns>
        
        public async System.Threading.Tasks.Task<GuideVersion> PostGuideVersionsAsync (string guideId, CreateGuideVersion body = null)
        {
             ApiResponse<GuideVersion> localVarResponse = await PostGuideVersionsAsyncWithHttpInfo(guideId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a guide version. 
        /// 
        /// PostGuideVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guideId">Guide ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (GuideVersion)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GuideVersion>> PostGuideVersionsAsyncWithHttpInfo (string guideId, CreateGuideVersion body = null)
        { 
            // verify the required parameter 'guideId' is set
            if (guideId == null)
                throw new ApiException(400, "Missing required parameter 'guideId' when calling AIStudioApi->PostGuideVersions");
            

            var localVarPath = "/api/v2/guides/{guideId}/versions";
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
            if (guideId != null) localVarPathParams.Add("guideId", this.Configuration.ApiClient.ParameterToString(guideId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostGuideVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGuideVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideVersion>(localVarStatusCode,
                localVarHeaders,
                (GuideVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideVersion)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a guide. 
        /// 
        /// PostGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Guide</returns>
        
        public Guide PostGuides (CreateGuide body)
        {
             ApiResponse<Guide> localVarResponse = PostGuidesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a guide. 
        /// 
        /// PostGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Guide</returns>
        
        public ApiResponse< Guide > PostGuidesWithHttpInfo (CreateGuide body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AIStudioApi->PostGuides");

            var localVarPath = "/api/v2/guides";
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
                throw new ApiException (localVarStatusCode, "Error calling PostGuides: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGuides: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Guide>(localVarStatusCode,
                localVarHeaders,
                (Guide) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Guide)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a guide. 
        /// 
        /// PostGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Guide</returns>
        
        public async System.Threading.Tasks.Task<Guide> PostGuidesAsync (CreateGuide body)
        {
             ApiResponse<Guide> localVarResponse = await PostGuidesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a guide. 
        /// 
        /// PostGuides is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Guide)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Guide>> PostGuidesAsyncWithHttpInfo (CreateGuide body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AIStudioApi->PostGuides");
            

            var localVarPath = "/api/v2/guides";
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
                throw new ApiException (localVarStatusCode, "Error calling PostGuides: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGuides: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Guide>(localVarStatusCode,
                localVarHeaders,
                (Guide) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Guide)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Start a guide content generation job. 
        /// 
        /// PostGuidesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>GuideContentGenerationJob</returns>
        
        public GuideContentGenerationJob PostGuidesJobs (GenerateGuideContentRequest body)
        {
             ApiResponse<GuideContentGenerationJob> localVarResponse = PostGuidesJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start a guide content generation job. 
        /// 
        /// PostGuidesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of GuideContentGenerationJob</returns>
        
        public ApiResponse< GuideContentGenerationJob > PostGuidesJobsWithHttpInfo (GenerateGuideContentRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AIStudioApi->PostGuidesJobs");

            var localVarPath = "/api/v2/guides/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostGuidesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGuidesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideContentGenerationJob>(localVarStatusCode,
                localVarHeaders,
                (GuideContentGenerationJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideContentGenerationJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Start a guide content generation job. 
        /// 
        /// PostGuidesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of GuideContentGenerationJob</returns>
        
        public async System.Threading.Tasks.Task<GuideContentGenerationJob> PostGuidesJobsAsync (GenerateGuideContentRequest body)
        {
             ApiResponse<GuideContentGenerationJob> localVarResponse = await PostGuidesJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start a guide content generation job. 
        /// 
        /// PostGuidesJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (GuideContentGenerationJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<GuideContentGenerationJob>> PostGuidesJobsAsyncWithHttpInfo (GenerateGuideContentRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AIStudioApi->PostGuidesJobs");
            

            var localVarPath = "/api/v2/guides/jobs";
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
                throw new ApiException (localVarStatusCode, "Error calling PostGuidesJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGuidesJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GuideContentGenerationJob>(localVarStatusCode,
                localVarHeaders,
                (GuideContentGenerationJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GuideContentGenerationJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
