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
    public interface ITeamsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns></returns>
        
        void DeleteTeam (string teamId);

        /// <summary>
        /// Delete team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteTeamWithHttpInfo (string teamId);

        /// <summary>
        /// Delete team members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="id">Comma separated list of member ids to remove</param>
        /// <returns></returns>
        
        void DeleteTeamMembers (string teamId, string id);

        /// <summary>
        /// Delete team members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="id">Comma separated list of member ids to remove</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        ApiResponse<Object> DeleteTeamMembersWithHttpInfo (string teamId, string id);

        /// <summary>
        /// Get team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>Team</returns>
        
        Team GetTeam (string teamId);

        /// <summary>
        /// Get team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>ApiResponse of Team</returns>
        
        ApiResponse<Team> GetTeamWithHttpInfo (string teamId);

        /// <summary>
        /// Get team membership
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>TeamMemberEntityListing</returns>
        
        TeamMemberEntityListing GetTeamMembers (string teamId, int? pageSize = null, string before = null, string after = null, string expand = null);

        /// <summary>
        /// Get team membership
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>ApiResponse of TeamMemberEntityListing</returns>
        
        ApiResponse<TeamMemberEntityListing> GetTeamMembersWithHttpInfo (string teamId, int? pageSize = null, string before = null, string after = null, string expand = null);

        /// <summary>
        /// Get Team listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Return only teams whose names start with this value (case-insensitive matching) (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>TeamEntityListing</returns>
        
        TeamEntityListing GetTeams (int? pageSize = null, string name = null, string after = null, string before = null, string expand = null);

        /// <summary>
        /// Get Team listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Return only teams whose names start with this value (case-insensitive matching) (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>ApiResponse of TeamEntityListing</returns>
        
        ApiResponse<TeamEntityListing> GetTeamsWithHttpInfo (int? pageSize = null, string name = null, string after = null, string before = null, string expand = null);

        /// <summary>
        /// Update team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">Team</param>
        /// <returns>Team</returns>
        
        Team PatchTeam (string teamId, Team body);

        /// <summary>
        /// Update team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">Team</param>
        /// <returns>ApiResponse of Team</returns>
        
        ApiResponse<Team> PatchTeamWithHttpInfo (string teamId, Team body);

        /// <summary>
        /// Query for team activity observations
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsTeamsActivityQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="pageSize">The desired page size (optional)</param>
        /// <param name="pageNumber">The desired page number (optional)</param>
        /// <returns>TeamActivityResponse</returns>
        
        TeamActivityResponse PostAnalyticsTeamsActivityQuery (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Query for team activity observations
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsTeamsActivityQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="pageSize">The desired page size (optional)</param>
        /// <param name="pageNumber">The desired page number (optional)</param>
        /// <returns>ApiResponse of TeamActivityResponse</returns>
        
        ApiResponse<TeamActivityResponse> PostAnalyticsTeamsActivityQueryWithHttpInfo (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Add team members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">TeamMembers</param>
        /// <returns>TeamMemberAddListingResponse</returns>
        
        TeamMemberAddListingResponse PostTeamMembers (string teamId, TeamMembers body);

        /// <summary>
        /// Add team members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">TeamMembers</param>
        /// <returns>ApiResponse of TeamMemberAddListingResponse</returns>
        
        ApiResponse<TeamMemberAddListingResponse> PostTeamMembersWithHttpInfo (string teamId, TeamMembers body);

        /// <summary>
        /// Create a team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Team</param>
        /// <returns>Team</returns>
        
        Team PostTeams (Team body);

        /// <summary>
        /// Create a team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Team</param>
        /// <returns>ApiResponse of Team</returns>
        
        ApiResponse<Team> PostTeamsWithHttpInfo (Team body);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>TeamsSearchResponse</returns>
        
        TeamsSearchResponse PostTeamsSearch (TeamSearchRequest body);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of TeamsSearchResponse</returns>
        
        ApiResponse<TeamsSearchResponse> PostTeamsSearchWithHttpInfo (TeamSearchRequest body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteTeamAsync (string teamId);

        /// <summary>
        /// Delete team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTeamAsyncWithHttpInfo (string teamId);

        /// <summary>
        /// Delete team members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="id">Comma separated list of member ids to remove</param>
        /// <returns>Task of void</returns>
        
        System.Threading.Tasks.Task DeleteTeamMembersAsync (string teamId, string id);

        /// <summary>
        /// Delete team members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="id">Comma separated list of member ids to remove</param>
        /// <returns>Task of ApiResponse</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTeamMembersAsyncWithHttpInfo (string teamId, string id);

        /// <summary>
        /// Get team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>Task of Team</returns>
        
        System.Threading.Tasks.Task<Team> GetTeamAsync (string teamId);

        /// <summary>
        /// Get team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>Task of ApiResponse (Team)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Team>> GetTeamAsyncWithHttpInfo (string teamId);

        /// <summary>
        /// Get team membership
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>Task of TeamMemberEntityListing</returns>
        
        System.Threading.Tasks.Task<TeamMemberEntityListing> GetTeamMembersAsync (string teamId, int? pageSize = null, string before = null, string after = null, string expand = null);

        /// <summary>
        /// Get team membership
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>Task of ApiResponse (TeamMemberEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TeamMemberEntityListing>> GetTeamMembersAsyncWithHttpInfo (string teamId, int? pageSize = null, string before = null, string after = null, string expand = null);

        /// <summary>
        /// Get Team listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Return only teams whose names start with this value (case-insensitive matching) (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>Task of TeamEntityListing</returns>
        
        System.Threading.Tasks.Task<TeamEntityListing> GetTeamsAsync (int? pageSize = null, string name = null, string after = null, string before = null, string expand = null);

        /// <summary>
        /// Get Team listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Return only teams whose names start with this value (case-insensitive matching) (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>Task of ApiResponse (TeamEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TeamEntityListing>> GetTeamsAsyncWithHttpInfo (int? pageSize = null, string name = null, string after = null, string before = null, string expand = null);

        /// <summary>
        /// Update team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">Team</param>
        /// <returns>Task of Team</returns>
        
        System.Threading.Tasks.Task<Team> PatchTeamAsync (string teamId, Team body);

        /// <summary>
        /// Update team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">Team</param>
        /// <returns>Task of ApiResponse (Team)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Team>> PatchTeamAsyncWithHttpInfo (string teamId, Team body);

        /// <summary>
        /// Query for team activity observations
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsTeamsActivityQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="pageSize">The desired page size (optional)</param>
        /// <param name="pageNumber">The desired page number (optional)</param>
        /// <returns>Task of TeamActivityResponse</returns>
        
        System.Threading.Tasks.Task<TeamActivityResponse> PostAnalyticsTeamsActivityQueryAsync (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Query for team activity observations
        /// </summary>
        /// <remarks>
        /// 
        /// PostAnalyticsTeamsActivityQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="pageSize">The desired page size (optional)</param>
        /// <param name="pageNumber">The desired page number (optional)</param>
        /// <returns>Task of ApiResponse (TeamActivityResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TeamActivityResponse>> PostAnalyticsTeamsActivityQueryAsyncWithHttpInfo (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Add team members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">TeamMembers</param>
        /// <returns>Task of TeamMemberAddListingResponse</returns>
        
        System.Threading.Tasks.Task<TeamMemberAddListingResponse> PostTeamMembersAsync (string teamId, TeamMembers body);

        /// <summary>
        /// Add team members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">TeamMembers</param>
        /// <returns>Task of ApiResponse (TeamMemberAddListingResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TeamMemberAddListingResponse>> PostTeamMembersAsyncWithHttpInfo (string teamId, TeamMembers body);

        /// <summary>
        /// Create a team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Team</param>
        /// <returns>Task of Team</returns>
        
        System.Threading.Tasks.Task<Team> PostTeamsAsync (Team body);

        /// <summary>
        /// Create a team
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Team</param>
        /// <returns>Task of ApiResponse (Team)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Team>> PostTeamsAsyncWithHttpInfo (Team body);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of TeamsSearchResponse</returns>
        
        System.Threading.Tasks.Task<TeamsSearchResponse> PostTeamsSearchAsync (TeamSearchRequest body);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (TeamsSearchResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TeamsSearchResponse>> PostTeamsSearchAsyncWithHttpInfo (TeamSearchRequest body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TeamsApi : ITeamsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TeamsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TeamsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
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
        /// Delete team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns></returns>
        
        public void DeleteTeam (string teamId)
        {
             DeleteTeamWithHttpInfo(teamId);
        }

        /// <summary>
        /// Delete team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteTeamWithHttpInfo (string teamId)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->DeleteTeam");

            var localVarPath = "/api/v2/teams/{teamId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTeam: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTeam: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteTeamAsync (string teamId)
        {
             await DeleteTeamAsyncWithHttpInfo(teamId);

        }

        /// <summary>
        /// Delete team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTeamAsyncWithHttpInfo (string teamId)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->DeleteTeam");
            

            var localVarPath = "/api/v2/teams/{teamId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTeam: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTeam: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete team members 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="id">Comma separated list of member ids to remove</param>
        /// <returns></returns>
        
        public void DeleteTeamMembers (string teamId, string id)
        {
             DeleteTeamMembersWithHttpInfo(teamId, id);
        }

        /// <summary>
        /// Delete team members 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="id">Comma separated list of member ids to remove</param>
        /// <returns>ApiResponse of Object(void)</returns>
        
        public ApiResponse<Object> DeleteTeamMembersWithHttpInfo (string teamId, string id)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->DeleteTeamMembers");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TeamsApi->DeleteTeamMembers");

            var localVarPath = "/api/v2/teams/{teamId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

            // Query params
            if (id != null) localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(id)));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTeamMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTeamMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete team members 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="id">Comma separated list of member ids to remove</param>
        /// <returns>Task of void</returns>
        
        public async System.Threading.Tasks.Task DeleteTeamMembersAsync (string teamId, string id)
        {
             await DeleteTeamMembersAsyncWithHttpInfo(teamId, id);

        }

        /// <summary>
        /// Delete team members 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="id">Comma separated list of member ids to remove</param>
        /// <returns>Task of ApiResponse</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTeamMembersAsyncWithHttpInfo (string teamId, string id)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->DeleteTeamMembers");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TeamsApi->DeleteTeamMembers");
            

            var localVarPath = "/api/v2/teams/{teamId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

            // Query params
            if (id != null) localVarQueryParams.Add(new Tuple<string, string>("id", this.Configuration.ApiClient.ParameterToString(id)));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTeamMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteTeamMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>Team</returns>
        
        public Team GetTeam (string teamId)
        {
             ApiResponse<Team> localVarResponse = GetTeamWithHttpInfo(teamId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>ApiResponse of Team</returns>
        
        public ApiResponse< Team > GetTeamWithHttpInfo (string teamId)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->GetTeam");

            var localVarPath = "/api/v2/teams/{teamId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTeam: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTeam: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Team>(localVarStatusCode,
                localVarHeaders,
                (Team) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Team)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>Task of Team</returns>
        
        public async System.Threading.Tasks.Task<Team> GetTeamAsync (string teamId)
        {
             ApiResponse<Team> localVarResponse = await GetTeamAsyncWithHttpInfo(teamId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <returns>Task of ApiResponse (Team)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Team>> GetTeamAsyncWithHttpInfo (string teamId)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->GetTeam");
            

            var localVarPath = "/api/v2/teams/{teamId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTeam: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTeam: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Team>(localVarStatusCode,
                localVarHeaders,
                (Team) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Team)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get team membership 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>TeamMemberEntityListing</returns>
        
        public TeamMemberEntityListing GetTeamMembers (string teamId, int? pageSize = null, string before = null, string after = null, string expand = null)
        {
             ApiResponse<TeamMemberEntityListing> localVarResponse = GetTeamMembersWithHttpInfo(teamId, pageSize, before, after, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get team membership 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>ApiResponse of TeamMemberEntityListing</returns>
        
        public ApiResponse< TeamMemberEntityListing > GetTeamMembersWithHttpInfo (string teamId, int? pageSize = null, string before = null, string after = null, string expand = null)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->GetTeamMembers");

            var localVarPath = "/api/v2/teams/{teamId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTeamMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTeamMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TeamMemberEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TeamMemberEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamMemberEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get team membership 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>Task of TeamMemberEntityListing</returns>
        
        public async System.Threading.Tasks.Task<TeamMemberEntityListing> GetTeamMembersAsync (string teamId, int? pageSize = null, string before = null, string after = null, string expand = null)
        {
             ApiResponse<TeamMemberEntityListing> localVarResponse = await GetTeamMembersAsyncWithHttpInfo(teamId, pageSize, before, after, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get team membership 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>Task of ApiResponse (TeamMemberEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TeamMemberEntityListing>> GetTeamMembersAsyncWithHttpInfo (string teamId, int? pageSize = null, string before = null, string after = null, string expand = null)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->GetTeamMembers");
            

            var localVarPath = "/api/v2/teams/{teamId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTeamMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTeamMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TeamMemberEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TeamMemberEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamMemberEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get Team listing 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Return only teams whose names start with this value (case-insensitive matching) (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>TeamEntityListing</returns>
        
        public TeamEntityListing GetTeams (int? pageSize = null, string name = null, string after = null, string before = null, string expand = null)
        {
             ApiResponse<TeamEntityListing> localVarResponse = GetTeamsWithHttpInfo(pageSize, name, after, before, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Team listing 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Return only teams whose names start with this value (case-insensitive matching) (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>ApiResponse of TeamEntityListing</returns>
        
        public ApiResponse< TeamEntityListing > GetTeamsWithHttpInfo (int? pageSize = null, string name = null, string after = null, string before = null, string expand = null)
        { 

            var localVarPath = "/api/v2/teams";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTeams: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTeams: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TeamEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TeamEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get Team listing 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Return only teams whose names start with this value (case-insensitive matching) (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>Task of TeamEntityListing</returns>
        
        public async System.Threading.Tasks.Task<TeamEntityListing> GetTeamsAsync (int? pageSize = null, string name = null, string after = null, string before = null, string expand = null)
        {
             ApiResponse<TeamEntityListing> localVarResponse = await GetTeamsAsyncWithHttpInfo(pageSize, name, after, before, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Team listing 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Return only teams whose names start with this value (case-insensitive matching) (optional)</param>
        /// <param name="after">The cursor that points to the next item in the complete list of teams (optional)</param>
        /// <param name="before">The cursor that points to the previous item in the complete list of teams (optional)</param>
        /// <param name="expand">Expand the name on each user (optional)</param>
        /// <returns>Task of ApiResponse (TeamEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TeamEntityListing>> GetTeamsAsyncWithHttpInfo (int? pageSize = null, string name = null, string after = null, string before = null, string expand = null)
        { 

            var localVarPath = "/api/v2/teams";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetTeams: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTeams: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TeamEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TeamEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">Team</param>
        /// <returns>Team</returns>
        
        public Team PatchTeam (string teamId, Team body)
        {
             ApiResponse<Team> localVarResponse = PatchTeamWithHttpInfo(teamId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">Team</param>
        /// <returns>ApiResponse of Team</returns>
        
        public ApiResponse< Team > PatchTeamWithHttpInfo (string teamId, Team body)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->PatchTeam");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TeamsApi->PatchTeam");

            var localVarPath = "/api/v2/teams/{teamId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTeam: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTeam: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Team>(localVarStatusCode,
                localVarHeaders,
                (Team) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Team)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">Team</param>
        /// <returns>Task of Team</returns>
        
        public async System.Threading.Tasks.Task<Team> PatchTeamAsync (string teamId, Team body)
        {
             ApiResponse<Team> localVarResponse = await PatchTeamAsyncWithHttpInfo(teamId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">Team</param>
        /// <returns>Task of ApiResponse (Team)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Team>> PatchTeamAsyncWithHttpInfo (string teamId, Team body)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->PatchTeam");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TeamsApi->PatchTeam");
            

            var localVarPath = "/api/v2/teams/{teamId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchTeam: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchTeam: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Team>(localVarStatusCode,
                localVarHeaders,
                (Team) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Team)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for team activity observations 
        /// 
        /// PostAnalyticsTeamsActivityQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="pageSize">The desired page size (optional)</param>
        /// <param name="pageNumber">The desired page number (optional)</param>
        /// <returns>TeamActivityResponse</returns>
        
        public TeamActivityResponse PostAnalyticsTeamsActivityQuery (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TeamActivityResponse> localVarResponse = PostAnalyticsTeamsActivityQueryWithHttpInfo(body, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for team activity observations 
        /// 
        /// PostAnalyticsTeamsActivityQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="pageSize">The desired page size (optional)</param>
        /// <param name="pageNumber">The desired page number (optional)</param>
        /// <returns>ApiResponse of TeamActivityResponse</returns>
        
        public ApiResponse< TeamActivityResponse > PostAnalyticsTeamsActivityQueryWithHttpInfo (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TeamsApi->PostAnalyticsTeamsActivityQuery");

            var localVarPath = "/api/v2/analytics/teams/activity/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsTeamsActivityQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsTeamsActivityQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TeamActivityResponse>(localVarStatusCode,
                localVarHeaders,
                (TeamActivityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamActivityResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for team activity observations 
        /// 
        /// PostAnalyticsTeamsActivityQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="pageSize">The desired page size (optional)</param>
        /// <param name="pageNumber">The desired page number (optional)</param>
        /// <returns>Task of TeamActivityResponse</returns>
        
        public async System.Threading.Tasks.Task<TeamActivityResponse> PostAnalyticsTeamsActivityQueryAsync (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TeamActivityResponse> localVarResponse = await PostAnalyticsTeamsActivityQueryAsyncWithHttpInfo(body, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for team activity observations 
        /// 
        /// PostAnalyticsTeamsActivityQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <param name="pageSize">The desired page size (optional)</param>
        /// <param name="pageNumber">The desired page number (optional)</param>
        /// <returns>Task of ApiResponse (TeamActivityResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TeamActivityResponse>> PostAnalyticsTeamsActivityQueryAsyncWithHttpInfo (TeamActivityQuery body, int? pageSize = null, int? pageNumber = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TeamsApi->PostAnalyticsTeamsActivityQuery");
            

            var localVarPath = "/api/v2/analytics/teams/activity/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsTeamsActivityQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAnalyticsTeamsActivityQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TeamActivityResponse>(localVarStatusCode,
                localVarHeaders,
                (TeamActivityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamActivityResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Add team members 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">TeamMembers</param>
        /// <returns>TeamMemberAddListingResponse</returns>
        
        public TeamMemberAddListingResponse PostTeamMembers (string teamId, TeamMembers body)
        {
             ApiResponse<TeamMemberAddListingResponse> localVarResponse = PostTeamMembersWithHttpInfo(teamId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add team members 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">TeamMembers</param>
        /// <returns>ApiResponse of TeamMemberAddListingResponse</returns>
        
        public ApiResponse< TeamMemberAddListingResponse > PostTeamMembersWithHttpInfo (string teamId, TeamMembers body)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->PostTeamMembers");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TeamsApi->PostTeamMembers");

            var localVarPath = "/api/v2/teams/{teamId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTeamMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTeamMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TeamMemberAddListingResponse>(localVarStatusCode,
                localVarHeaders,
                (TeamMemberAddListingResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamMemberAddListingResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Add team members 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">TeamMembers</param>
        /// <returns>Task of TeamMemberAddListingResponse</returns>
        
        public async System.Threading.Tasks.Task<TeamMemberAddListingResponse> PostTeamMembersAsync (string teamId, TeamMembers body)
        {
             ApiResponse<TeamMemberAddListingResponse> localVarResponse = await PostTeamMembersAsyncWithHttpInfo(teamId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add team members 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team ID</param>
        /// <param name="body">TeamMembers</param>
        /// <returns>Task of ApiResponse (TeamMemberAddListingResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TeamMemberAddListingResponse>> PostTeamMembersAsyncWithHttpInfo (string teamId, TeamMembers body)
        { 
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsApi->PostTeamMembers");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TeamsApi->PostTeamMembers");
            

            var localVarPath = "/api/v2/teams/{teamId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (teamId != null) localVarPathParams.Add("teamId", this.Configuration.ApiClient.ParameterToString(teamId));

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTeamMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTeamMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TeamMemberAddListingResponse>(localVarStatusCode,
                localVarHeaders,
                (TeamMemberAddListingResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamMemberAddListingResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Team</param>
        /// <returns>Team</returns>
        
        public Team PostTeams (Team body)
        {
             ApiResponse<Team> localVarResponse = PostTeamsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Team</param>
        /// <returns>ApiResponse of Team</returns>
        
        public ApiResponse< Team > PostTeamsWithHttpInfo (Team body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TeamsApi->PostTeams");

            var localVarPath = "/api/v2/teams";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTeams: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTeams: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Team>(localVarStatusCode,
                localVarHeaders,
                (Team) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Team)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Team</param>
        /// <returns>Task of Team</returns>
        
        public async System.Threading.Tasks.Task<Team> PostTeamsAsync (Team body)
        {
             ApiResponse<Team> localVarResponse = await PostTeamsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a team 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Team</param>
        /// <returns>Task of ApiResponse (Team)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Team>> PostTeamsAsyncWithHttpInfo (Team body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TeamsApi->PostTeams");
            

            var localVarPath = "/api/v2/teams";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTeams: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTeams: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Team>(localVarStatusCode,
                localVarHeaders,
                (Team) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Team)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Search resources. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>TeamsSearchResponse</returns>
        
        public TeamsSearchResponse PostTeamsSearch (TeamSearchRequest body)
        {
             ApiResponse<TeamsSearchResponse> localVarResponse = PostTeamsSearchWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search resources. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of TeamsSearchResponse</returns>
        
        public ApiResponse< TeamsSearchResponse > PostTeamsSearchWithHttpInfo (TeamSearchRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TeamsApi->PostTeamsSearch");

            var localVarPath = "/api/v2/teams/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                                        .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                                        .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTeamsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTeamsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TeamsSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (TeamsSearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsSearchResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Search resources. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of TeamsSearchResponse</returns>
        
        public async System.Threading.Tasks.Task<TeamsSearchResponse> PostTeamsSearchAsync (TeamSearchRequest body)
        {
             ApiResponse<TeamsSearchResponse> localVarResponse = await PostTeamsSearchAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search resources. 
        /// 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (TeamsSearchResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TeamsSearchResponse>> PostTeamsSearchAsyncWithHttpInfo (TeamSearchRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TeamsApi->PostTeamsSearch");
            

            var localVarPath = "/api/v2/teams/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers
                                    .Select(header => new { Name = header.GetType().GetProperty("Name").GetValue(header), Value = header.GetType().GetProperty("Value").GetValue(header) })
                                    .ToDictionary(header => header.Name.ToString(), header => header.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostTeamsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTeamsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TeamsSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (TeamsSearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsSearchResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
