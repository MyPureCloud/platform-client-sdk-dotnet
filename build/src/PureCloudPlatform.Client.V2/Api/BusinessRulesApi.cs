using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{

	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IBusinessRulesApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		/// Delete a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="forceDelete">Force delete decision table (under certain conditions) (optional, default to false)</param>
		/// <returns></returns>

		void DeleteBusinessrulesDecisiontable(string tableId, bool? forceDelete = null);

		/// <summary>
		/// Delete a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="forceDelete">Force delete decision table (under certain conditions) (optional, default to false)</param>
		/// <returns>ApiResponse of Object(void)</returns>

		ApiResponse<Object> DeleteBusinessrulesDecisiontableWithHttpInfo(string tableId, bool? forceDelete = null);

		/// <summary>
		/// Delete a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns></returns>

		void DeleteBusinessrulesDecisiontableVersion(string tableId, int? tableVersion);

		/// <summary>
		/// Delete a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>ApiResponse of Object(void)</returns>

		ApiResponse<Object> DeleteBusinessrulesDecisiontableVersionWithHttpInfo(string tableId, int? tableVersion);

		/// <summary>
		/// Delete a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns></returns>

		void DeleteBusinessrulesDecisiontableVersionRow(string tableId, int? tableVersion, string rowId);

		/// <summary>
		/// Delete a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>ApiResponse of Object(void)</returns>

		ApiResponse<Object> DeleteBusinessrulesDecisiontableVersionRowWithHttpInfo(string tableId, int? tableVersion, string rowId);

		/// <summary>
		/// Delete a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns></returns>

		void DeleteBusinessrulesSchema(string schemaId);

		/// <summary>
		/// Delete a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>ApiResponse of Object(void)</returns>

		ApiResponse<Object> DeleteBusinessrulesSchemaWithHttpInfo(string schemaId);

		/// <summary>
		/// Get a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>DecisionTable</returns>

		DecisionTable GetBusinessrulesDecisiontable(string tableId);

		/// <summary>
		/// Get a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>ApiResponse of DecisionTable</returns>

		ApiResponse<DecisionTable> GetBusinessrulesDecisiontableWithHttpInfo(string tableId);

		/// <summary>
		/// Get a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>DecisionTableVersion</returns>

		DecisionTableVersion GetBusinessrulesDecisiontableVersion(string tableId, int? tableVersion);

		/// <summary>
		/// Get a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		ApiResponse<DecisionTableVersion> GetBusinessrulesDecisiontableVersionWithHttpInfo(string tableId, int? tableVersion);

		/// <summary>
		/// Get a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>DecisionTableRow</returns>

		DecisionTableRow GetBusinessrulesDecisiontableVersionRow(string tableId, int? tableVersion, string rowId);

		/// <summary>
		/// Get a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>ApiResponse of DecisionTableRow</returns>

		ApiResponse<DecisionTableRow> GetBusinessrulesDecisiontableVersionRowWithHttpInfo(string tableId, int? tableVersion, string rowId);

		/// <summary>
		/// Get a list of decision table rows.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>DecisionTableRowListing</returns>

		DecisionTableRowListing GetBusinessrulesDecisiontableVersionRows(string tableId, int? tableVersion, string pageNumber = null, string pageSize = null);

		/// <summary>
		/// Get a list of decision table rows.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>ApiResponse of DecisionTableRowListing</returns>

		ApiResponse<DecisionTableRowListing> GetBusinessrulesDecisiontableVersionRowsWithHttpInfo(string tableId, int? tableVersion, string pageNumber = null, string pageSize = null);

		/// <summary>
		/// Get a list of decision table versions
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <returns>DecisionTableVersionListing</returns>

		DecisionTableVersionListing GetBusinessrulesDecisiontableVersions(string tableId, string after = null, string pageSize = null);

		/// <summary>
		/// Get a list of decision table versions
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <returns>ApiResponse of DecisionTableVersionListing</returns>

		ApiResponse<DecisionTableVersionListing> GetBusinessrulesDecisiontableVersionsWithHttpInfo(string tableId, string after = null, string pageSize = null);

		/// <summary>
		/// Get a list of decision tables.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="divisionIds">One or more comma separated divisions to filters decision tables by. If nothing is provided, the decision tables associated with the list of divisions that the user has access to will be returned. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. (optional)</param>
		/// <returns>DecisionTableListing</returns>

		DecisionTableListing GetBusinessrulesDecisiontables(string after = null, string pageSize = null, List<string> divisionIds = null, string name = null);

		/// <summary>
		/// Get a list of decision tables.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="divisionIds">One or more comma separated divisions to filters decision tables by. If nothing is provided, the decision tables associated with the list of divisions that the user has access to will be returned. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. (optional)</param>
		/// <returns>ApiResponse of DecisionTableListing</returns>

		ApiResponse<DecisionTableListing> GetBusinessrulesDecisiontablesWithHttpInfo(string after = null, string pageSize = null, List<string> divisionIds = null, string name = null);

		/// <summary>
		/// Search for decision tables.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="schemaId">Search for decision tables that use the schema with this ID. Cannot be combined with name search. Search results will not be paginated if used. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. Cannot be combined with schema search. Search results will not be paginated if used. (optional)</param>
		/// <param name="withPublishedVersion">Filters results to only decision tables that have at least one version in Published status (optional)</param>
		/// <param name="expand">Fields to expand in response (optional)</param>
		/// <param name="ids">Decision table IDs to search for (optional)</param>
		/// <returns>DecisionTableListing</returns>

		DecisionTableListing GetBusinessrulesDecisiontablesSearch(string after = null, string pageSize = null, string schemaId = null, string name = null, bool? withPublishedVersion = null, List<string> expand = null, List<string> ids = null);

		/// <summary>
		/// Search for decision tables.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="schemaId">Search for decision tables that use the schema with this ID. Cannot be combined with name search. Search results will not be paginated if used. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. Cannot be combined with schema search. Search results will not be paginated if used. (optional)</param>
		/// <param name="withPublishedVersion">Filters results to only decision tables that have at least one version in Published status (optional)</param>
		/// <param name="expand">Fields to expand in response (optional)</param>
		/// <param name="ids">Decision table IDs to search for (optional)</param>
		/// <returns>ApiResponse of DecisionTableListing</returns>

		ApiResponse<DecisionTableListing> GetBusinessrulesDecisiontablesSearchWithHttpInfo(string after = null, string pageSize = null, string schemaId = null, string name = null, bool? withPublishedVersion = null, List<string> expand = null, List<string> ids = null);

		/// <summary>
		/// Get a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>BusinessRulesDataSchema</returns>

		BusinessRulesDataSchema GetBusinessrulesSchema(string schemaId);

		/// <summary>
		/// Get a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>ApiResponse of BusinessRulesDataSchema</returns>

		ApiResponse<BusinessRulesDataSchema> GetBusinessrulesSchemaWithHttpInfo(string schemaId);

		/// <summary>
		/// Get a list of schemas.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>BusinessRulesDataSchemaListing</returns>

		BusinessRulesDataSchemaListing GetBusinessrulesSchemas();

		/// <summary>
		/// Get a list of schemas.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of BusinessRulesDataSchemaListing</returns>

		ApiResponse<BusinessRulesDataSchemaListing> GetBusinessrulesSchemasWithHttpInfo();

		/// <summary>
		/// Get a specific named core type.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="coreTypeName">The core type&#39;s name</param>
		/// <returns>Coretype</returns>

		Coretype GetBusinessrulesSchemasCoretype(string coreTypeName);

		/// <summary>
		/// Get a specific named core type.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="coreTypeName">The core type&#39;s name</param>
		/// <returns>ApiResponse of Coretype</returns>

		ApiResponse<Coretype> GetBusinessrulesSchemasCoretypeWithHttpInfo(string coreTypeName);

		/// <summary>
		/// Get the core types from which all schemas are built.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>CoretypeListing</returns>

		CoretypeListing GetBusinessrulesSchemasCoretypes();

		/// <summary>
		/// Get the core types from which all schemas are built.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of CoretypeListing</returns>

		ApiResponse<CoretypeListing> GetBusinessrulesSchemasCoretypesWithHttpInfo();

		/// <summary>
		/// Update a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTable</returns>

		DecisionTable PatchBusinessrulesDecisiontable(string tableId, UpdateDecisionTableRequest body);

		/// <summary>
		/// Update a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTable</returns>

		ApiResponse<DecisionTable> PatchBusinessrulesDecisiontableWithHttpInfo(string tableId, UpdateDecisionTableRequest body);

		/// <summary>
		/// Update a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTableVersion</returns>

		DecisionTableVersion PatchBusinessrulesDecisiontableVersion(string tableId, int? tableVersion, UpdateDecisionTableVersionRequest body);

		/// <summary>
		/// Update a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		ApiResponse<DecisionTableVersion> PatchBusinessrulesDecisiontableVersionWithHttpInfo(string tableId, int? tableVersion, UpdateDecisionTableVersionRequest body);

		/// <summary>
		/// Execute a published decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTableExecutionResponse</returns>

		DecisionTableExecutionResponse PostBusinessrulesDecisiontableExecute(string tableId, DecisionTableExecutionRequest body);

		/// <summary>
		/// Execute a published decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTableExecutionResponse</returns>

		ApiResponse<DecisionTableExecutionResponse> PostBusinessrulesDecisiontableExecuteWithHttpInfo(string tableId, DecisionTableExecutionRequest body);

		/// <summary>
		/// Copy a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTableVersion</returns>

		DecisionTableVersion PostBusinessrulesDecisiontableVersionCopy(string tableId, int? tableVersion, CopyDecisionTableRequest body);

		/// <summary>
		/// Copy a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		ApiResponse<DecisionTableVersion> PostBusinessrulesDecisiontableVersionCopyWithHttpInfo(string tableId, int? tableVersion, CopyDecisionTableRequest body);

		/// <summary>
		/// Execute a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTableExecutionResponse</returns>

		DecisionTableExecutionResponse PostBusinessrulesDecisiontableVersionExecute(string tableId, int? tableVersion, DecisionTableExecutionRequest body);

		/// <summary>
		/// Execute a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTableExecutionResponse</returns>

		ApiResponse<DecisionTableExecutionResponse> PostBusinessrulesDecisiontableVersionExecuteWithHttpInfo(string tableId, int? tableVersion, DecisionTableExecutionRequest body);

		/// <summary>
		/// Create a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Create decision table row request</param>
		/// <returns>DecisionTableRow</returns>

		DecisionTableRow PostBusinessrulesDecisiontableVersionRows(string tableId, int? tableVersion, CreateDecisionTableRowRequest body);

		/// <summary>
		/// Create a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Create decision table row request</param>
		/// <returns>ApiResponse of DecisionTableRow</returns>

		ApiResponse<DecisionTableRow> PostBusinessrulesDecisiontableVersionRowsWithHttpInfo(string tableId, int? tableVersion, CreateDecisionTableRowRequest body);

		/// <summary>
		/// Search for decision table rows
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Search decision table rows request</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>DecisionTableRowListing</returns>

		DecisionTableRowListing PostBusinessrulesDecisiontableVersionRowsSearch(string tableId, int? tableVersion, SearchDecisionTableRowsRequest body, string pageNumber = null, string pageSize = null);

		/// <summary>
		/// Search for decision table rows
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Search decision table rows request</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>ApiResponse of DecisionTableRowListing</returns>

		ApiResponse<DecisionTableRowListing> PostBusinessrulesDecisiontableVersionRowsSearchWithHttpInfo(string tableId, int? tableVersion, SearchDecisionTableRowsRequest body, string pageNumber = null, string pageSize = null);

		/// <summary>
		/// Update the Business Rules Schema to the latest version for a given decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>DecisionTableVersion</returns>

		DecisionTableVersion PostBusinessrulesDecisiontableVersionSync(string tableId, int? tableVersion);

		/// <summary>
		/// Update the Business Rules Schema to the latest version for a given decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		ApiResponse<DecisionTableVersion> PostBusinessrulesDecisiontableVersionSyncWithHttpInfo(string tableId, int? tableVersion);

		/// <summary>
		/// Create a new decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>DecisionTableVersion</returns>

		DecisionTableVersion PostBusinessrulesDecisiontableVersions(string tableId);

		/// <summary>
		/// Create a new decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		ApiResponse<DecisionTableVersion> PostBusinessrulesDecisiontableVersionsWithHttpInfo(string tableId);

		/// <summary>
		/// Create a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTableVersion</returns>

		DecisionTableVersion PostBusinessrulesDecisiontables(CreateDecisionTableRequest body);

		/// <summary>
		/// Create a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		ApiResponse<DecisionTableVersion> PostBusinessrulesDecisiontablesWithHttpInfo(CreateDecisionTableRequest body);

		/// <summary>
		/// Create a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Business Rules Schema Create Request</param>
		/// <returns>BusinessRulesDataSchema</returns>

		BusinessRulesDataSchema PostBusinessrulesSchemas(BusinessRulesSchemaCreateRequest body);

		/// <summary>
		/// Create a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Business Rules Schema Create Request</param>
		/// <returns>ApiResponse of BusinessRulesDataSchema</returns>

		ApiResponse<BusinessRulesDataSchema> PostBusinessrulesSchemasWithHttpInfo(BusinessRulesSchemaCreateRequest body);

		/// <summary>
		/// Publish a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>DecisionTableVersion</returns>

		DecisionTableVersion PutBusinessrulesDecisiontableVersionPublish(string tableId, int? tableVersion);

		/// <summary>
		/// Publish a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		ApiResponse<DecisionTableVersion> PutBusinessrulesDecisiontableVersionPublishWithHttpInfo(string tableId, int? tableVersion);

		/// <summary>
		/// Full update a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <param name="body">Full update decision table row request</param>
		/// <returns>DecisionTableRow</returns>

		DecisionTableRow PutBusinessrulesDecisiontableVersionRow(string tableId, int? tableVersion, string rowId, PutDecisionTableRowRequest body);

		/// <summary>
		/// Full update a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <param name="body">Full update decision table row request</param>
		/// <returns>ApiResponse of DecisionTableRow</returns>

		ApiResponse<DecisionTableRow> PutBusinessrulesDecisiontableVersionRowWithHttpInfo(string tableId, int? tableVersion, string rowId, PutDecisionTableRowRequest body);

		/// <summary>
		/// Update a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <param name="body">Business Rules Schema Update Request</param>
		/// <returns>BusinessRulesDataSchema</returns>

		BusinessRulesDataSchema PutBusinessrulesSchema(string schemaId, BusinessRulesSchemaUpdateRequest body);

		/// <summary>
		/// Update a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <param name="body">Business Rules Schema Update Request</param>
		/// <returns>ApiResponse of BusinessRulesDataSchema</returns>

		ApiResponse<BusinessRulesDataSchema> PutBusinessrulesSchemaWithHttpInfo(string schemaId, BusinessRulesSchemaUpdateRequest body);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		/// Delete a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="forceDelete">Force delete decision table (under certain conditions) (optional, default to false)</param>
		/// <returns>Task of void</returns>

		System.Threading.Tasks.Task DeleteBusinessrulesDecisiontableAsync(string tableId, bool? forceDelete = null);

		/// <summary>
		/// Delete a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="forceDelete">Force delete decision table (under certain conditions) (optional, default to false)</param>
		/// <returns>Task of ApiResponse</returns>

		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBusinessrulesDecisiontableAsyncWithHttpInfo(string tableId, bool? forceDelete = null);

		/// <summary>
		/// Delete a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of void</returns>

		System.Threading.Tasks.Task DeleteBusinessrulesDecisiontableVersionAsync(string tableId, int? tableVersion);

		/// <summary>
		/// Delete a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of ApiResponse</returns>

		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBusinessrulesDecisiontableVersionAsyncWithHttpInfo(string tableId, int? tableVersion);

		/// <summary>
		/// Delete a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>Task of void</returns>

		System.Threading.Tasks.Task DeleteBusinessrulesDecisiontableVersionRowAsync(string tableId, int? tableVersion, string rowId);

		/// <summary>
		/// Delete a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>Task of ApiResponse</returns>

		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBusinessrulesDecisiontableVersionRowAsyncWithHttpInfo(string tableId, int? tableVersion, string rowId);

		/// <summary>
		/// Delete a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>Task of void</returns>

		System.Threading.Tasks.Task DeleteBusinessrulesSchemaAsync(string schemaId);

		/// <summary>
		/// Delete a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>Task of ApiResponse</returns>

		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBusinessrulesSchemaAsyncWithHttpInfo(string schemaId);

		/// <summary>
		/// Get a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>Task of DecisionTable</returns>

		System.Threading.Tasks.Task<DecisionTable> GetBusinessrulesDecisiontableAsync(string tableId);

		/// <summary>
		/// Get a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>Task of ApiResponse (DecisionTable)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTable>> GetBusinessrulesDecisiontableAsyncWithHttpInfo(string tableId);

		/// <summary>
		/// Get a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of DecisionTableVersion</returns>

		System.Threading.Tasks.Task<DecisionTableVersion> GetBusinessrulesDecisiontableVersionAsync(string tableId, int? tableVersion);

		/// <summary>
		/// Get a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> GetBusinessrulesDecisiontableVersionAsyncWithHttpInfo(string tableId, int? tableVersion);

		/// <summary>
		/// Get a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>Task of DecisionTableRow</returns>

		System.Threading.Tasks.Task<DecisionTableRow> GetBusinessrulesDecisiontableVersionRowAsync(string tableId, int? tableVersion, string rowId);

		/// <summary>
		/// Get a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>Task of ApiResponse (DecisionTableRow)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableRow>> GetBusinessrulesDecisiontableVersionRowAsyncWithHttpInfo(string tableId, int? tableVersion, string rowId);

		/// <summary>
		/// Get a list of decision table rows.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>Task of DecisionTableRowListing</returns>

		System.Threading.Tasks.Task<DecisionTableRowListing> GetBusinessrulesDecisiontableVersionRowsAsync(string tableId, int? tableVersion, string pageNumber = null, string pageSize = null);

		/// <summary>
		/// Get a list of decision table rows.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>Task of ApiResponse (DecisionTableRowListing)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableRowListing>> GetBusinessrulesDecisiontableVersionRowsAsyncWithHttpInfo(string tableId, int? tableVersion, string pageNumber = null, string pageSize = null);

		/// <summary>
		/// Get a list of decision table versions
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <returns>Task of DecisionTableVersionListing</returns>

		System.Threading.Tasks.Task<DecisionTableVersionListing> GetBusinessrulesDecisiontableVersionsAsync(string tableId, string after = null, string pageSize = null);

		/// <summary>
		/// Get a list of decision table versions
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <returns>Task of ApiResponse (DecisionTableVersionListing)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableVersionListing>> GetBusinessrulesDecisiontableVersionsAsyncWithHttpInfo(string tableId, string after = null, string pageSize = null);

		/// <summary>
		/// Get a list of decision tables.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="divisionIds">One or more comma separated divisions to filters decision tables by. If nothing is provided, the decision tables associated with the list of divisions that the user has access to will be returned. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. (optional)</param>
		/// <returns>Task of DecisionTableListing</returns>

		System.Threading.Tasks.Task<DecisionTableListing> GetBusinessrulesDecisiontablesAsync(string after = null, string pageSize = null, List<string> divisionIds = null, string name = null);

		/// <summary>
		/// Get a list of decision tables.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="divisionIds">One or more comma separated divisions to filters decision tables by. If nothing is provided, the decision tables associated with the list of divisions that the user has access to will be returned. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. (optional)</param>
		/// <returns>Task of ApiResponse (DecisionTableListing)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableListing>> GetBusinessrulesDecisiontablesAsyncWithHttpInfo(string after = null, string pageSize = null, List<string> divisionIds = null, string name = null);

		/// <summary>
		/// Search for decision tables.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="schemaId">Search for decision tables that use the schema with this ID. Cannot be combined with name search. Search results will not be paginated if used. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. Cannot be combined with schema search. Search results will not be paginated if used. (optional)</param>
		/// <param name="withPublishedVersion">Filters results to only decision tables that have at least one version in Published status (optional)</param>
		/// <param name="expand">Fields to expand in response (optional)</param>
		/// <param name="ids">Decision table IDs to search for (optional)</param>
		/// <returns>Task of DecisionTableListing</returns>

		System.Threading.Tasks.Task<DecisionTableListing> GetBusinessrulesDecisiontablesSearchAsync(string after = null, string pageSize = null, string schemaId = null, string name = null, bool? withPublishedVersion = null, List<string> expand = null, List<string> ids = null);

		/// <summary>
		/// Search for decision tables.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="schemaId">Search for decision tables that use the schema with this ID. Cannot be combined with name search. Search results will not be paginated if used. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. Cannot be combined with schema search. Search results will not be paginated if used. (optional)</param>
		/// <param name="withPublishedVersion">Filters results to only decision tables that have at least one version in Published status (optional)</param>
		/// <param name="expand">Fields to expand in response (optional)</param>
		/// <param name="ids">Decision table IDs to search for (optional)</param>
		/// <returns>Task of ApiResponse (DecisionTableListing)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableListing>> GetBusinessrulesDecisiontablesSearchAsyncWithHttpInfo(string after = null, string pageSize = null, string schemaId = null, string name = null, bool? withPublishedVersion = null, List<string> expand = null, List<string> ids = null);

		/// <summary>
		/// Get a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>Task of BusinessRulesDataSchema</returns>

		System.Threading.Tasks.Task<BusinessRulesDataSchema> GetBusinessrulesSchemaAsync(string schemaId);

		/// <summary>
		/// Get a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>Task of ApiResponse (BusinessRulesDataSchema)</returns>

		System.Threading.Tasks.Task<ApiResponse<BusinessRulesDataSchema>> GetBusinessrulesSchemaAsyncWithHttpInfo(string schemaId);

		/// <summary>
		/// Get a list of schemas.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of BusinessRulesDataSchemaListing</returns>

		System.Threading.Tasks.Task<BusinessRulesDataSchemaListing> GetBusinessrulesSchemasAsync();

		/// <summary>
		/// Get a list of schemas.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (BusinessRulesDataSchemaListing)</returns>

		System.Threading.Tasks.Task<ApiResponse<BusinessRulesDataSchemaListing>> GetBusinessrulesSchemasAsyncWithHttpInfo();

		/// <summary>
		/// Get a specific named core type.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="coreTypeName">The core type&#39;s name</param>
		/// <returns>Task of Coretype</returns>

		System.Threading.Tasks.Task<Coretype> GetBusinessrulesSchemasCoretypeAsync(string coreTypeName);

		/// <summary>
		/// Get a specific named core type.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="coreTypeName">The core type&#39;s name</param>
		/// <returns>Task of ApiResponse (Coretype)</returns>

		System.Threading.Tasks.Task<ApiResponse<Coretype>> GetBusinessrulesSchemasCoretypeAsyncWithHttpInfo(string coreTypeName);

		/// <summary>
		/// Get the core types from which all schemas are built.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of CoretypeListing</returns>

		System.Threading.Tasks.Task<CoretypeListing> GetBusinessrulesSchemasCoretypesAsync();

		/// <summary>
		/// Get the core types from which all schemas are built.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (CoretypeListing)</returns>

		System.Threading.Tasks.Task<ApiResponse<CoretypeListing>> GetBusinessrulesSchemasCoretypesAsyncWithHttpInfo();

		/// <summary>
		/// Update a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTable</returns>

		System.Threading.Tasks.Task<DecisionTable> PatchBusinessrulesDecisiontableAsync(string tableId, UpdateDecisionTableRequest body);

		/// <summary>
		/// Update a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTable)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTable>> PatchBusinessrulesDecisiontableAsyncWithHttpInfo(string tableId, UpdateDecisionTableRequest body);

		/// <summary>
		/// Update a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTableVersion</returns>

		System.Threading.Tasks.Task<DecisionTableVersion> PatchBusinessrulesDecisiontableVersionAsync(string tableId, int? tableVersion, UpdateDecisionTableVersionRequest body);

		/// <summary>
		/// Update a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PatchBusinessrulesDecisiontableVersionAsyncWithHttpInfo(string tableId, int? tableVersion, UpdateDecisionTableVersionRequest body);

		/// <summary>
		/// Execute a published decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTableExecutionResponse</returns>

		System.Threading.Tasks.Task<DecisionTableExecutionResponse> PostBusinessrulesDecisiontableExecuteAsync(string tableId, DecisionTableExecutionRequest body);

		/// <summary>
		/// Execute a published decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTableExecutionResponse)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableExecutionResponse>> PostBusinessrulesDecisiontableExecuteAsyncWithHttpInfo(string tableId, DecisionTableExecutionRequest body);

		/// <summary>
		/// Copy a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTableVersion</returns>

		System.Threading.Tasks.Task<DecisionTableVersion> PostBusinessrulesDecisiontableVersionCopyAsync(string tableId, int? tableVersion, CopyDecisionTableRequest body);

		/// <summary>
		/// Copy a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PostBusinessrulesDecisiontableVersionCopyAsyncWithHttpInfo(string tableId, int? tableVersion, CopyDecisionTableRequest body);

		/// <summary>
		/// Execute a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTableExecutionResponse</returns>

		System.Threading.Tasks.Task<DecisionTableExecutionResponse> PostBusinessrulesDecisiontableVersionExecuteAsync(string tableId, int? tableVersion, DecisionTableExecutionRequest body);

		/// <summary>
		/// Execute a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTableExecutionResponse)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableExecutionResponse>> PostBusinessrulesDecisiontableVersionExecuteAsyncWithHttpInfo(string tableId, int? tableVersion, DecisionTableExecutionRequest body);

		/// <summary>
		/// Create a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Create decision table row request</param>
		/// <returns>Task of DecisionTableRow</returns>

		System.Threading.Tasks.Task<DecisionTableRow> PostBusinessrulesDecisiontableVersionRowsAsync(string tableId, int? tableVersion, CreateDecisionTableRowRequest body);

		/// <summary>
		/// Create a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Create decision table row request</param>
		/// <returns>Task of ApiResponse (DecisionTableRow)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableRow>> PostBusinessrulesDecisiontableVersionRowsAsyncWithHttpInfo(string tableId, int? tableVersion, CreateDecisionTableRowRequest body);

		/// <summary>
		/// Search for decision table rows
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Search decision table rows request</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>Task of DecisionTableRowListing</returns>

		System.Threading.Tasks.Task<DecisionTableRowListing> PostBusinessrulesDecisiontableVersionRowsSearchAsync(string tableId, int? tableVersion, SearchDecisionTableRowsRequest body, string pageNumber = null, string pageSize = null);

		/// <summary>
		/// Search for decision table rows
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Search decision table rows request</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>Task of ApiResponse (DecisionTableRowListing)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableRowListing>> PostBusinessrulesDecisiontableVersionRowsSearchAsyncWithHttpInfo(string tableId, int? tableVersion, SearchDecisionTableRowsRequest body, string pageNumber = null, string pageSize = null);

		/// <summary>
		/// Update the Business Rules Schema to the latest version for a given decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of DecisionTableVersion</returns>

		System.Threading.Tasks.Task<DecisionTableVersion> PostBusinessrulesDecisiontableVersionSyncAsync(string tableId, int? tableVersion);

		/// <summary>
		/// Update the Business Rules Schema to the latest version for a given decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PostBusinessrulesDecisiontableVersionSyncAsyncWithHttpInfo(string tableId, int? tableVersion);

		/// <summary>
		/// Create a new decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>Task of DecisionTableVersion</returns>

		System.Threading.Tasks.Task<DecisionTableVersion> PostBusinessrulesDecisiontableVersionsAsync(string tableId);

		/// <summary>
		/// Create a new decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PostBusinessrulesDecisiontableVersionsAsyncWithHttpInfo(string tableId);

		/// <summary>
		/// Create a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTableVersion</returns>

		System.Threading.Tasks.Task<DecisionTableVersion> PostBusinessrulesDecisiontablesAsync(CreateDecisionTableRequest body);

		/// <summary>
		/// Create a decision table
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PostBusinessrulesDecisiontablesAsyncWithHttpInfo(CreateDecisionTableRequest body);

		/// <summary>
		/// Create a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Business Rules Schema Create Request</param>
		/// <returns>Task of BusinessRulesDataSchema</returns>

		System.Threading.Tasks.Task<BusinessRulesDataSchema> PostBusinessrulesSchemasAsync(BusinessRulesSchemaCreateRequest body);

		/// <summary>
		/// Create a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Business Rules Schema Create Request</param>
		/// <returns>Task of ApiResponse (BusinessRulesDataSchema)</returns>

		System.Threading.Tasks.Task<ApiResponse<BusinessRulesDataSchema>> PostBusinessrulesSchemasAsyncWithHttpInfo(BusinessRulesSchemaCreateRequest body);

		/// <summary>
		/// Publish a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of DecisionTableVersion</returns>

		System.Threading.Tasks.Task<DecisionTableVersion> PutBusinessrulesDecisiontableVersionPublishAsync(string tableId, int? tableVersion);

		/// <summary>
		/// Publish a decision table version
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PutBusinessrulesDecisiontableVersionPublishAsyncWithHttpInfo(string tableId, int? tableVersion);

		/// <summary>
		/// Full update a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <param name="body">Full update decision table row request</param>
		/// <returns>Task of DecisionTableRow</returns>

		System.Threading.Tasks.Task<DecisionTableRow> PutBusinessrulesDecisiontableVersionRowAsync(string tableId, int? tableVersion, string rowId, PutDecisionTableRowRequest body);

		/// <summary>
		/// Full update a decision table row
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <param name="body">Full update decision table row request</param>
		/// <returns>Task of ApiResponse (DecisionTableRow)</returns>

		System.Threading.Tasks.Task<ApiResponse<DecisionTableRow>> PutBusinessrulesDecisiontableVersionRowAsyncWithHttpInfo(string tableId, int? tableVersion, string rowId, PutDecisionTableRowRequest body);

		/// <summary>
		/// Update a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <param name="body">Business Rules Schema Update Request</param>
		/// <returns>Task of BusinessRulesDataSchema</returns>

		System.Threading.Tasks.Task<BusinessRulesDataSchema> PutBusinessrulesSchemaAsync(string schemaId, BusinessRulesSchemaUpdateRequest body);

		/// <summary>
		/// Update a schema
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <param name="body">Business Rules Schema Update Request</param>
		/// <returns>Task of ApiResponse (BusinessRulesDataSchema)</returns>

		System.Threading.Tasks.Task<ApiResponse<BusinessRulesDataSchema>> PutBusinessrulesSchemaAsyncWithHttpInfo(string schemaId, BusinessRulesSchemaUpdateRequest body);

		#endregion Asynchronous Operations

	}

	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public partial class BusinessRulesApi : IBusinessRulesApi
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessRulesApi"/> class.
		/// </summary>
		/// <returns></returns>
		public BusinessRulesApi(String basePath)
		{
			this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

			// ensure API client has configuration ready
			if (this.Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessRulesApi"/> class
		/// using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public BusinessRulesApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
		public PureCloudPlatform.Client.V2.Client.Configuration Configuration { get; set; }

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
		/// Delete a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="forceDelete">Force delete decision table (under certain conditions) (optional, default to false)</param>
		/// <returns></returns>

		public void DeleteBusinessrulesDecisiontable(string tableId, bool? forceDelete = null)
		{
			DeleteBusinessrulesDecisiontableWithHttpInfo(tableId, forceDelete);
		}

		/// <summary>
		/// Delete a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="forceDelete">Force delete decision table (under certain conditions) (optional, default to false)</param>
		/// <returns>ApiResponse of Object(void)</returns>

		public ApiResponse<Object> DeleteBusinessrulesDecisiontableWithHttpInfo(string tableId, bool? forceDelete = null)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontable");

			var localVarPath = "/businessrules/decisiontables/{tableId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

			// Query params
			if (forceDelete != null) localVarQueryParams.Add(new Tuple<string, string>("forceDelete", this.Configuration.ApiClient.ParameterToString(forceDelete)));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontable: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Object>(localVarStatusCode,
				localVarHeaders,
				null,
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Delete a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="forceDelete">Force delete decision table (under certain conditions) (optional, default to false)</param>
		/// <returns>Task of void</returns>

		public async System.Threading.Tasks.Task DeleteBusinessrulesDecisiontableAsync(string tableId, bool? forceDelete = null)
		{
			await DeleteBusinessrulesDecisiontableAsyncWithHttpInfo(tableId, forceDelete);

		}

		/// <summary>
		/// Delete a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="forceDelete">Force delete decision table (under certain conditions) (optional, default to false)</param>
		/// <returns>Task of ApiResponse</returns>

		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBusinessrulesDecisiontableAsyncWithHttpInfo(string tableId, bool? forceDelete = null)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontable");


			var localVarPath = "/businessrules/decisiontables/{tableId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

			// Query params
			if (forceDelete != null) localVarQueryParams.Add(new Tuple<string, string>("forceDelete", this.Configuration.ApiClient.ParameterToString(forceDelete)));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontable: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Object>(localVarStatusCode,
				localVarHeaders,
				null,
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Delete a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns></returns>

		public void DeleteBusinessrulesDecisiontableVersion(string tableId, int? tableVersion)
		{
			DeleteBusinessrulesDecisiontableVersionWithHttpInfo(tableId, tableVersion);
		}

		/// <summary>
		/// Delete a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>ApiResponse of Object(void)</returns>

		public ApiResponse<Object> DeleteBusinessrulesDecisiontableVersionWithHttpInfo(string tableId, int? tableVersion)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontableVersion");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontableVersion");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontableVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontableVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Object>(localVarStatusCode,
				localVarHeaders,
				null,
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Delete a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of void</returns>

		public async System.Threading.Tasks.Task DeleteBusinessrulesDecisiontableVersionAsync(string tableId, int? tableVersion)
		{
			await DeleteBusinessrulesDecisiontableVersionAsyncWithHttpInfo(tableId, tableVersion);

		}

		/// <summary>
		/// Delete a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of ApiResponse</returns>

		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBusinessrulesDecisiontableVersionAsyncWithHttpInfo(string tableId, int? tableVersion)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontableVersion");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontableVersion");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontableVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontableVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Object>(localVarStatusCode,
				localVarHeaders,
				null,
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Delete a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns></returns>

		public void DeleteBusinessrulesDecisiontableVersionRow(string tableId, int? tableVersion, string rowId)
		{
			DeleteBusinessrulesDecisiontableVersionRowWithHttpInfo(tableId, tableVersion, rowId);
		}

		/// <summary>
		/// Delete a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>ApiResponse of Object(void)</returns>

		public ApiResponse<Object> DeleteBusinessrulesDecisiontableVersionRowWithHttpInfo(string tableId, int? tableVersion, string rowId)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontableVersionRow");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontableVersionRow");
			// verify the required parameter 'rowId' is set
			if (rowId == null)
				throw new ApiException(400, "Missing required parameter 'rowId' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontableVersionRow");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/{rowId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));
			if (rowId != null) localVarPathParams.Add("rowId", this.Configuration.ApiClient.ParameterToString(rowId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontableVersionRow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontableVersionRow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Object>(localVarStatusCode,
				localVarHeaders,
				null,
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Delete a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>Task of void</returns>

		public async System.Threading.Tasks.Task DeleteBusinessrulesDecisiontableVersionRowAsync(string tableId, int? tableVersion, string rowId)
		{
			await DeleteBusinessrulesDecisiontableVersionRowAsyncWithHttpInfo(tableId, tableVersion, rowId);

		}

		/// <summary>
		/// Delete a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>Task of ApiResponse</returns>

		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBusinessrulesDecisiontableVersionRowAsyncWithHttpInfo(string tableId, int? tableVersion, string rowId)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontableVersionRow");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontableVersionRow");

			// verify the required parameter 'rowId' is set
			if (rowId == null)
				throw new ApiException(400, "Missing required parameter 'rowId' when calling BusinessRulesApi->DeleteBusinessrulesDecisiontableVersionRow");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/{rowId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));
			if (rowId != null) localVarPathParams.Add("rowId", this.Configuration.ApiClient.ParameterToString(rowId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontableVersionRow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesDecisiontableVersionRow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Object>(localVarStatusCode,
				localVarHeaders,
				null,
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Delete a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns></returns>

		public void DeleteBusinessrulesSchema(string schemaId)
		{
			DeleteBusinessrulesSchemaWithHttpInfo(schemaId);
		}

		/// <summary>
		/// Delete a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>ApiResponse of Object(void)</returns>

		public ApiResponse<Object> DeleteBusinessrulesSchemaWithHttpInfo(string schemaId)
		{
			// verify the required parameter 'schemaId' is set
			if (schemaId == null)
				throw new ApiException(400, "Missing required parameter 'schemaId' when calling BusinessRulesApi->DeleteBusinessrulesSchema");

			var localVarPath = "/businessrules/schemas/{schemaId}";
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
			if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Object>(localVarStatusCode,
				localVarHeaders,
				null,
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Delete a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>Task of void</returns>

		public async System.Threading.Tasks.Task DeleteBusinessrulesSchemaAsync(string schemaId)
		{
			await DeleteBusinessrulesSchemaAsyncWithHttpInfo(schemaId);

		}

		/// <summary>
		/// Delete a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>Task of ApiResponse</returns>

		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBusinessrulesSchemaAsyncWithHttpInfo(string schemaId)
		{
			// verify the required parameter 'schemaId' is set
			if (schemaId == null)
				throw new ApiException(400, "Missing required parameter 'schemaId' when calling BusinessRulesApi->DeleteBusinessrulesSchema");


			var localVarPath = "/businessrules/schemas/{schemaId}";
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
			if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling DeleteBusinessrulesSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Object>(localVarStatusCode,
				localVarHeaders,
				null,
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>DecisionTable</returns>

		public DecisionTable GetBusinessrulesDecisiontable(string tableId)
		{
			ApiResponse<DecisionTable> localVarResponse = GetBusinessrulesDecisiontableWithHttpInfo(tableId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>ApiResponse of DecisionTable</returns>

		public ApiResponse<DecisionTable> GetBusinessrulesDecisiontableWithHttpInfo(string tableId)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->GetBusinessrulesDecisiontable");

			var localVarPath = "/businessrules/decisiontables/{tableId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontable: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTable>(localVarStatusCode,
				localVarHeaders,
				(DecisionTable)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTable)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>Task of DecisionTable</returns>

		public async System.Threading.Tasks.Task<DecisionTable> GetBusinessrulesDecisiontableAsync(string tableId)
		{
			ApiResponse<DecisionTable> localVarResponse = await GetBusinessrulesDecisiontableAsyncWithHttpInfo(tableId);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>Task of ApiResponse (DecisionTable)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTable>> GetBusinessrulesDecisiontableAsyncWithHttpInfo(string tableId)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->GetBusinessrulesDecisiontable");


			var localVarPath = "/businessrules/decisiontables/{tableId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontable: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTable>(localVarStatusCode,
				localVarHeaders,
				(DecisionTable)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTable)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>DecisionTableVersion</returns>

		public DecisionTableVersion GetBusinessrulesDecisiontableVersion(string tableId, int? tableVersion)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = GetBusinessrulesDecisiontableVersionWithHttpInfo(tableId, tableVersion);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		public ApiResponse<DecisionTableVersion> GetBusinessrulesDecisiontableVersionWithHttpInfo(string tableId, int? tableVersion)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersion");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersion");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of DecisionTableVersion</returns>

		public async System.Threading.Tasks.Task<DecisionTableVersion> GetBusinessrulesDecisiontableVersionAsync(string tableId, int? tableVersion)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = await GetBusinessrulesDecisiontableVersionAsyncWithHttpInfo(tableId, tableVersion);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> GetBusinessrulesDecisiontableVersionAsyncWithHttpInfo(string tableId, int? tableVersion)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersion");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersion");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>DecisionTableRow</returns>

		public DecisionTableRow GetBusinessrulesDecisiontableVersionRow(string tableId, int? tableVersion, string rowId)
		{
			ApiResponse<DecisionTableRow> localVarResponse = GetBusinessrulesDecisiontableVersionRowWithHttpInfo(tableId, tableVersion, rowId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>ApiResponse of DecisionTableRow</returns>

		public ApiResponse<DecisionTableRow> GetBusinessrulesDecisiontableVersionRowWithHttpInfo(string tableId, int? tableVersion, string rowId)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersionRow");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersionRow");
			// verify the required parameter 'rowId' is set
			if (rowId == null)
				throw new ApiException(400, "Missing required parameter 'rowId' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersionRow");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/{rowId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));
			if (rowId != null) localVarPathParams.Add("rowId", this.Configuration.ApiClient.ParameterToString(rowId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersionRow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersionRow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableRow>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableRow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableRow)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>Task of DecisionTableRow</returns>

		public async System.Threading.Tasks.Task<DecisionTableRow> GetBusinessrulesDecisiontableVersionRowAsync(string tableId, int? tableVersion, string rowId)
		{
			ApiResponse<DecisionTableRow> localVarResponse = await GetBusinessrulesDecisiontableVersionRowAsyncWithHttpInfo(tableId, tableVersion, rowId);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <returns>Task of ApiResponse (DecisionTableRow)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableRow>> GetBusinessrulesDecisiontableVersionRowAsyncWithHttpInfo(string tableId, int? tableVersion, string rowId)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersionRow");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersionRow");

			// verify the required parameter 'rowId' is set
			if (rowId == null)
				throw new ApiException(400, "Missing required parameter 'rowId' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersionRow");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/{rowId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));
			if (rowId != null) localVarPathParams.Add("rowId", this.Configuration.ApiClient.ParameterToString(rowId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersionRow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersionRow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableRow>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableRow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableRow)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get a list of decision table rows. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>DecisionTableRowListing</returns>

		public DecisionTableRowListing GetBusinessrulesDecisiontableVersionRows(string tableId, int? tableVersion, string pageNumber = null, string pageSize = null)
		{
			ApiResponse<DecisionTableRowListing> localVarResponse = GetBusinessrulesDecisiontableVersionRowsWithHttpInfo(tableId, tableVersion, pageNumber, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a list of decision table rows. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>ApiResponse of DecisionTableRowListing</returns>

		public ApiResponse<DecisionTableRowListing> GetBusinessrulesDecisiontableVersionRowsWithHttpInfo(string tableId, int? tableVersion, string pageNumber = null, string pageSize = null)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersionRows");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersionRows");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

			// Query params
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersionRows: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersionRows: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableRowListing>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableRowListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableRowListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a list of decision table rows. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>Task of DecisionTableRowListing</returns>

		public async System.Threading.Tasks.Task<DecisionTableRowListing> GetBusinessrulesDecisiontableVersionRowsAsync(string tableId, int? tableVersion, string pageNumber = null, string pageSize = null)
		{
			ApiResponse<DecisionTableRowListing> localVarResponse = await GetBusinessrulesDecisiontableVersionRowsAsyncWithHttpInfo(tableId, tableVersion, pageNumber, pageSize);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a list of decision table rows. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>Task of ApiResponse (DecisionTableRowListing)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableRowListing>> GetBusinessrulesDecisiontableVersionRowsAsyncWithHttpInfo(string tableId, int? tableVersion, string pageNumber = null, string pageSize = null)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersionRows");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersionRows");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

			// Query params
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersionRows: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersionRows: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableRowListing>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableRowListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableRowListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get a list of decision table versions 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <returns>DecisionTableVersionListing</returns>

		public DecisionTableVersionListing GetBusinessrulesDecisiontableVersions(string tableId, string after = null, string pageSize = null)
		{
			ApiResponse<DecisionTableVersionListing> localVarResponse = GetBusinessrulesDecisiontableVersionsWithHttpInfo(tableId, after, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a list of decision table versions 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <returns>ApiResponse of DecisionTableVersionListing</returns>

		public ApiResponse<DecisionTableVersionListing> GetBusinessrulesDecisiontableVersionsWithHttpInfo(string tableId, string after = null, string pageSize = null)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersions");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

			// Query params
			if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersionListing>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersionListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersionListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a list of decision table versions 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <returns>Task of DecisionTableVersionListing</returns>

		public async System.Threading.Tasks.Task<DecisionTableVersionListing> GetBusinessrulesDecisiontableVersionsAsync(string tableId, string after = null, string pageSize = null)
		{
			ApiResponse<DecisionTableVersionListing> localVarResponse = await GetBusinessrulesDecisiontableVersionsAsyncWithHttpInfo(tableId, after, pageSize);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a list of decision table versions 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <returns>Task of ApiResponse (DecisionTableVersionListing)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableVersionListing>> GetBusinessrulesDecisiontableVersionsAsyncWithHttpInfo(string tableId, string after = null, string pageSize = null)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->GetBusinessrulesDecisiontableVersions");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

			// Query params
			if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontableVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersionListing>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersionListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersionListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get a list of decision tables. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="divisionIds">One or more comma separated divisions to filters decision tables by. If nothing is provided, the decision tables associated with the list of divisions that the user has access to will be returned. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. (optional)</param>
		/// <returns>DecisionTableListing</returns>

		public DecisionTableListing GetBusinessrulesDecisiontables(string after = null, string pageSize = null, List<string> divisionIds = null, string name = null)
		{
			ApiResponse<DecisionTableListing> localVarResponse = GetBusinessrulesDecisiontablesWithHttpInfo(after, pageSize, divisionIds, name);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a list of decision tables. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="divisionIds">One or more comma separated divisions to filters decision tables by. If nothing is provided, the decision tables associated with the list of divisions that the user has access to will be returned. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. (optional)</param>
		/// <returns>ApiResponse of DecisionTableListing</returns>

		public ApiResponse<DecisionTableListing> GetBusinessrulesDecisiontablesWithHttpInfo(string after = null, string pageSize = null, List<string> divisionIds = null, string name = null)
		{

			var localVarPath = "/businessrules/decisiontables";
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
			if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
			if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
			if (divisionIds != null) divisionIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("divisionIds", this.Configuration.ApiClient.ParameterToString(obj))); });
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
			IHttpResponse localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
				localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType) as IHttpResponse;

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontables: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontables: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableListing>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a list of decision tables. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="divisionIds">One or more comma separated divisions to filters decision tables by. If nothing is provided, the decision tables associated with the list of divisions that the user has access to will be returned. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. (optional)</param>
		/// <returns>Task of DecisionTableListing</returns>

		public async System.Threading.Tasks.Task<DecisionTableListing> GetBusinessrulesDecisiontablesAsync(string after = null, string pageSize = null, List<string> divisionIds = null, string name = null)
		{
			ApiResponse<DecisionTableListing> localVarResponse = await GetBusinessrulesDecisiontablesAsyncWithHttpInfo(after, pageSize, divisionIds, name);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a list of decision tables. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="divisionIds">One or more comma separated divisions to filters decision tables by. If nothing is provided, the decision tables associated with the list of divisions that the user has access to will be returned. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. (optional)</param>
		/// <returns>Task of ApiResponse (DecisionTableListing)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableListing>> GetBusinessrulesDecisiontablesAsyncWithHttpInfo(string after = null, string pageSize = null, List<string> divisionIds = null, string name = null)
		{

			var localVarPath = "/businessrules/decisiontables";
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
			if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
			if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
			if (divisionIds != null) divisionIds.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("divisionIds", this.Configuration.ApiClient.ParameterToString(obj))); });
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
			IHttpResponse localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
				localVarHttpMethod, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType) as IHttpResponse;

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontables: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontables: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableListing>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Search for decision tables. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="schemaId">Search for decision tables that use the schema with this ID. Cannot be combined with name search. Search results will not be paginated if used. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. Cannot be combined with schema search. Search results will not be paginated if used. (optional)</param>
		/// <param name="withPublishedVersion">Filters results to only decision tables that have at least one version in Published status (optional)</param>
		/// <param name="expand">Fields to expand in response (optional)</param>
		/// <param name="ids">Decision table IDs to search for (optional)</param>
		/// <returns>DecisionTableListing</returns>

		public DecisionTableListing GetBusinessrulesDecisiontablesSearch(string after = null, string pageSize = null, string schemaId = null, string name = null, bool? withPublishedVersion = null, List<string> expand = null, List<string> ids = null)
		{
			ApiResponse<DecisionTableListing> localVarResponse = GetBusinessrulesDecisiontablesSearchWithHttpInfo(after, pageSize, schemaId, name, withPublishedVersion, expand, ids);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Search for decision tables. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="schemaId">Search for decision tables that use the schema with this ID. Cannot be combined with name search. Search results will not be paginated if used. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. Cannot be combined with schema search. Search results will not be paginated if used. (optional)</param>
		/// <param name="withPublishedVersion">Filters results to only decision tables that have at least one version in Published status (optional)</param>
		/// <param name="expand">Fields to expand in response (optional)</param>
		/// <param name="ids">Decision table IDs to search for (optional)</param>
		/// <returns>ApiResponse of DecisionTableListing</returns>

		public ApiResponse<DecisionTableListing> GetBusinessrulesDecisiontablesSearchWithHttpInfo(string after = null, string pageSize = null, string schemaId = null, string name = null, bool? withPublishedVersion = null, List<string> expand = null, List<string> ids = null)
		{

			var localVarPath = "/businessrules/decisiontables/search";
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
			if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
			if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
			if (schemaId != null) localVarQueryParams.Add(new Tuple<string, string>("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId)));
			if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
			if (withPublishedVersion != null) localVarQueryParams.Add(new Tuple<string, string>("withPublishedVersion", this.Configuration.ApiClient.ParameterToString(withPublishedVersion)));
			if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
			if (ids != null) ids.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(obj))); });

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontablesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontablesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableListing>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Search for decision tables. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="schemaId">Search for decision tables that use the schema with this ID. Cannot be combined with name search. Search results will not be paginated if used. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. Cannot be combined with schema search. Search results will not be paginated if used. (optional)</param>
		/// <param name="withPublishedVersion">Filters results to only decision tables that have at least one version in Published status (optional)</param>
		/// <param name="expand">Fields to expand in response (optional)</param>
		/// <param name="ids">Decision table IDs to search for (optional)</param>
		/// <returns>Task of DecisionTableListing</returns>

		public async System.Threading.Tasks.Task<DecisionTableListing> GetBusinessrulesDecisiontablesSearchAsync(string after = null, string pageSize = null, string schemaId = null, string name = null, bool? withPublishedVersion = null, List<string> expand = null, List<string> ids = null)
		{
			ApiResponse<DecisionTableListing> localVarResponse = await GetBusinessrulesDecisiontablesSearchAsyncWithHttpInfo(after, pageSize, schemaId, name, withPublishedVersion, expand, ids);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Search for decision tables. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. (optional)</param>
		/// <param name="schemaId">Search for decision tables that use the schema with this ID. Cannot be combined with name search. Search results will not be paginated if used. (optional)</param>
		/// <param name="name">Search for decision tables with a name that contains the given search string. Search is case insensitive and will match any table that contains this string in any part of the name. Cannot be combined with schema search. Search results will not be paginated if used. (optional)</param>
		/// <param name="withPublishedVersion">Filters results to only decision tables that have at least one version in Published status (optional)</param>
		/// <param name="expand">Fields to expand in response (optional)</param>
		/// <param name="ids">Decision table IDs to search for (optional)</param>
		/// <returns>Task of ApiResponse (DecisionTableListing)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableListing>> GetBusinessrulesDecisiontablesSearchAsyncWithHttpInfo(string after = null, string pageSize = null, string schemaId = null, string name = null, bool? withPublishedVersion = null, List<string> expand = null, List<string> ids = null)
		{

			var localVarPath = "/businessrules/decisiontables/search";
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
			if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
			if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
			if (schemaId != null) localVarQueryParams.Add(new Tuple<string, string>("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId)));
			if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", this.Configuration.ApiClient.ParameterToString(name)));
			if (withPublishedVersion != null) localVarQueryParams.Add(new Tuple<string, string>("withPublishedVersion", this.Configuration.ApiClient.ParameterToString(withPublishedVersion)));
			if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
			if (ids != null) ids.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("ids", this.Configuration.ApiClient.ParameterToString(obj))); });

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontablesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesDecisiontablesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableListing>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>BusinessRulesDataSchema</returns>

		public BusinessRulesDataSchema GetBusinessrulesSchema(string schemaId)
		{
			ApiResponse<BusinessRulesDataSchema> localVarResponse = GetBusinessrulesSchemaWithHttpInfo(schemaId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>ApiResponse of BusinessRulesDataSchema</returns>

		public ApiResponse<BusinessRulesDataSchema> GetBusinessrulesSchemaWithHttpInfo(string schemaId)
		{
			// verify the required parameter 'schemaId' is set
			if (schemaId == null)
				throw new ApiException(400, "Missing required parameter 'schemaId' when calling BusinessRulesApi->GetBusinessrulesSchema");

			var localVarPath = "/businessrules/schemas/{schemaId}";
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
			if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BusinessRulesDataSchema>(localVarStatusCode,
				localVarHeaders,
				(BusinessRulesDataSchema)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessRulesDataSchema)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>Task of BusinessRulesDataSchema</returns>

		public async System.Threading.Tasks.Task<BusinessRulesDataSchema> GetBusinessrulesSchemaAsync(string schemaId)
		{
			ApiResponse<BusinessRulesDataSchema> localVarResponse = await GetBusinessrulesSchemaAsyncWithHttpInfo(schemaId);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <returns>Task of ApiResponse (BusinessRulesDataSchema)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<BusinessRulesDataSchema>> GetBusinessrulesSchemaAsyncWithHttpInfo(string schemaId)
		{
			// verify the required parameter 'schemaId' is set
			if (schemaId == null)
				throw new ApiException(400, "Missing required parameter 'schemaId' when calling BusinessRulesApi->GetBusinessrulesSchema");


			var localVarPath = "/businessrules/schemas/{schemaId}";
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
			if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BusinessRulesDataSchema>(localVarStatusCode,
				localVarHeaders,
				(BusinessRulesDataSchema)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessRulesDataSchema)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get a list of schemas. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>BusinessRulesDataSchemaListing</returns>

		public BusinessRulesDataSchemaListing GetBusinessrulesSchemas()
		{
			ApiResponse<BusinessRulesDataSchemaListing> localVarResponse = GetBusinessrulesSchemasWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a list of schemas. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of BusinessRulesDataSchemaListing</returns>

		public ApiResponse<BusinessRulesDataSchemaListing> GetBusinessrulesSchemasWithHttpInfo()
		{

			var localVarPath = "/businessrules/schemas";
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BusinessRulesDataSchemaListing>(localVarStatusCode,
				localVarHeaders,
				(BusinessRulesDataSchemaListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessRulesDataSchemaListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a list of schemas. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of BusinessRulesDataSchemaListing</returns>

		public async System.Threading.Tasks.Task<BusinessRulesDataSchemaListing> GetBusinessrulesSchemasAsync()
		{
			ApiResponse<BusinessRulesDataSchemaListing> localVarResponse = await GetBusinessrulesSchemasAsyncWithHttpInfo();
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a list of schemas. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (BusinessRulesDataSchemaListing)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<BusinessRulesDataSchemaListing>> GetBusinessrulesSchemasAsyncWithHttpInfo()
		{

			var localVarPath = "/businessrules/schemas";
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BusinessRulesDataSchemaListing>(localVarStatusCode,
				localVarHeaders,
				(BusinessRulesDataSchemaListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessRulesDataSchemaListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get a specific named core type. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="coreTypeName">The core type&#39;s name</param>
		/// <returns>Coretype</returns>

		public Coretype GetBusinessrulesSchemasCoretype(string coreTypeName)
		{
			ApiResponse<Coretype> localVarResponse = GetBusinessrulesSchemasCoretypeWithHttpInfo(coreTypeName);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a specific named core type. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="coreTypeName">The core type&#39;s name</param>
		/// <returns>ApiResponse of Coretype</returns>

		public ApiResponse<Coretype> GetBusinessrulesSchemasCoretypeWithHttpInfo(string coreTypeName)
		{
			// verify the required parameter 'coreTypeName' is set
			if (coreTypeName == null)
				throw new ApiException(400, "Missing required parameter 'coreTypeName' when calling BusinessRulesApi->GetBusinessrulesSchemasCoretype");

			var localVarPath = "/businessrules/schemas/coretypes/{coreTypeName}";
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
			if (coreTypeName != null) localVarPathParams.Add("coreTypeName", this.Configuration.ApiClient.ParameterToString(coreTypeName));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemasCoretype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemasCoretype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Coretype>(localVarStatusCode,
				localVarHeaders,
				(Coretype)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Coretype)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get a specific named core type. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="coreTypeName">The core type&#39;s name</param>
		/// <returns>Task of Coretype</returns>

		public async System.Threading.Tasks.Task<Coretype> GetBusinessrulesSchemasCoretypeAsync(string coreTypeName)
		{
			ApiResponse<Coretype> localVarResponse = await GetBusinessrulesSchemasCoretypeAsyncWithHttpInfo(coreTypeName);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get a specific named core type. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="coreTypeName">The core type&#39;s name</param>
		/// <returns>Task of ApiResponse (Coretype)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<Coretype>> GetBusinessrulesSchemasCoretypeAsyncWithHttpInfo(string coreTypeName)
		{
			// verify the required parameter 'coreTypeName' is set
			if (coreTypeName == null)
				throw new ApiException(400, "Missing required parameter 'coreTypeName' when calling BusinessRulesApi->GetBusinessrulesSchemasCoretype");


			var localVarPath = "/businessrules/schemas/coretypes/{coreTypeName}";
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
			if (coreTypeName != null) localVarPathParams.Add("coreTypeName", this.Configuration.ApiClient.ParameterToString(coreTypeName));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemasCoretype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemasCoretype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<Coretype>(localVarStatusCode,
				localVarHeaders,
				(Coretype)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Coretype)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Get the core types from which all schemas are built. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>CoretypeListing</returns>

		public CoretypeListing GetBusinessrulesSchemasCoretypes()
		{
			ApiResponse<CoretypeListing> localVarResponse = GetBusinessrulesSchemasCoretypesWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the core types from which all schemas are built. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of CoretypeListing</returns>

		public ApiResponse<CoretypeListing> GetBusinessrulesSchemasCoretypesWithHttpInfo()
		{

			var localVarPath = "/businessrules/schemas/coretypes";
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemasCoretypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemasCoretypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<CoretypeListing>(localVarStatusCode,
				localVarHeaders,
				(CoretypeListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoretypeListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Get the core types from which all schemas are built. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of CoretypeListing</returns>

		public async System.Threading.Tasks.Task<CoretypeListing> GetBusinessrulesSchemasCoretypesAsync()
		{
			ApiResponse<CoretypeListing> localVarResponse = await GetBusinessrulesSchemasCoretypesAsyncWithHttpInfo();
			return localVarResponse.Data;

		}

		/// <summary>
		/// Get the core types from which all schemas are built. 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (CoretypeListing)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<CoretypeListing>> GetBusinessrulesSchemasCoretypesAsyncWithHttpInfo()
		{

			var localVarPath = "/businessrules/schemas/coretypes";
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemasCoretypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling GetBusinessrulesSchemasCoretypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<CoretypeListing>(localVarStatusCode,
				localVarHeaders,
				(CoretypeListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CoretypeListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Update a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTable</returns>

		public DecisionTable PatchBusinessrulesDecisiontable(string tableId, UpdateDecisionTableRequest body)
		{
			ApiResponse<DecisionTable> localVarResponse = PatchBusinessrulesDecisiontableWithHttpInfo(tableId, body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTable</returns>

		public ApiResponse<DecisionTable> PatchBusinessrulesDecisiontableWithHttpInfo(string tableId, UpdateDecisionTableRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PatchBusinessrulesDecisiontable");
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PatchBusinessrulesDecisiontable");

			var localVarPath = "/businessrules/decisiontables/{tableId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PatchBusinessrulesDecisiontable: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PatchBusinessrulesDecisiontable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTable>(localVarStatusCode,
				localVarHeaders,
				(DecisionTable)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTable)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Update a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTable</returns>

		public async System.Threading.Tasks.Task<DecisionTable> PatchBusinessrulesDecisiontableAsync(string tableId, UpdateDecisionTableRequest body)
		{
			ApiResponse<DecisionTable> localVarResponse = await PatchBusinessrulesDecisiontableAsyncWithHttpInfo(tableId, body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Update a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTable)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTable>> PatchBusinessrulesDecisiontableAsyncWithHttpInfo(string tableId, UpdateDecisionTableRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PatchBusinessrulesDecisiontable");

			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PatchBusinessrulesDecisiontable");


			var localVarPath = "/businessrules/decisiontables/{tableId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PatchBusinessrulesDecisiontable: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PatchBusinessrulesDecisiontable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTable>(localVarStatusCode,
				localVarHeaders,
				(DecisionTable)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTable)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Update a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTableVersion</returns>

		public DecisionTableVersion PatchBusinessrulesDecisiontableVersion(string tableId, int? tableVersion, UpdateDecisionTableVersionRequest body)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = PatchBusinessrulesDecisiontableVersionWithHttpInfo(tableId, tableVersion, body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		public ApiResponse<DecisionTableVersion> PatchBusinessrulesDecisiontableVersionWithHttpInfo(string tableId, int? tableVersion, UpdateDecisionTableVersionRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PatchBusinessrulesDecisiontableVersion");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PatchBusinessrulesDecisiontableVersion");
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PatchBusinessrulesDecisiontableVersion");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PatchBusinessrulesDecisiontableVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PatchBusinessrulesDecisiontableVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Update a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTableVersion</returns>

		public async System.Threading.Tasks.Task<DecisionTableVersion> PatchBusinessrulesDecisiontableVersionAsync(string tableId, int? tableVersion, UpdateDecisionTableVersionRequest body)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = await PatchBusinessrulesDecisiontableVersionAsyncWithHttpInfo(tableId, tableVersion, body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Update a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PatchBusinessrulesDecisiontableVersionAsyncWithHttpInfo(string tableId, int? tableVersion, UpdateDecisionTableVersionRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PatchBusinessrulesDecisiontableVersion");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PatchBusinessrulesDecisiontableVersion");

			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PatchBusinessrulesDecisiontableVersion");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PatchBusinessrulesDecisiontableVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PatchBusinessrulesDecisiontableVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Execute a published decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTableExecutionResponse</returns>

		public DecisionTableExecutionResponse PostBusinessrulesDecisiontableExecute(string tableId, DecisionTableExecutionRequest body)
		{
			ApiResponse<DecisionTableExecutionResponse> localVarResponse = PostBusinessrulesDecisiontableExecuteWithHttpInfo(tableId, body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Execute a published decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTableExecutionResponse</returns>

		public ApiResponse<DecisionTableExecutionResponse> PostBusinessrulesDecisiontableExecuteWithHttpInfo(string tableId, DecisionTableExecutionRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableExecute");
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontableExecute");

			var localVarPath = "/businessrules/decisiontables/{tableId}/execute";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableExecutionResponse>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableExecutionResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableExecutionResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Execute a published decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTableExecutionResponse</returns>

		public async System.Threading.Tasks.Task<DecisionTableExecutionResponse> PostBusinessrulesDecisiontableExecuteAsync(string tableId, DecisionTableExecutionRequest body)
		{
			ApiResponse<DecisionTableExecutionResponse> localVarResponse = await PostBusinessrulesDecisiontableExecuteAsyncWithHttpInfo(tableId, body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Execute a published decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTableExecutionResponse)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableExecutionResponse>> PostBusinessrulesDecisiontableExecuteAsyncWithHttpInfo(string tableId, DecisionTableExecutionRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableExecute");

			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontableExecute");


			var localVarPath = "/businessrules/decisiontables/{tableId}/execute";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableExecutionResponse>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableExecutionResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableExecutionResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Copy a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTableVersion</returns>

		public DecisionTableVersion PostBusinessrulesDecisiontableVersionCopy(string tableId, int? tableVersion, CopyDecisionTableRequest body)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = PostBusinessrulesDecisiontableVersionCopyWithHttpInfo(tableId, tableVersion, body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Copy a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		public ApiResponse<DecisionTableVersion> PostBusinessrulesDecisiontableVersionCopyWithHttpInfo(string tableId, int? tableVersion, CopyDecisionTableRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionCopy");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionCopy");
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionCopy");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/copy";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionCopy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionCopy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Copy a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTableVersion</returns>

		public async System.Threading.Tasks.Task<DecisionTableVersion> PostBusinessrulesDecisiontableVersionCopyAsync(string tableId, int? tableVersion, CopyDecisionTableRequest body)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = await PostBusinessrulesDecisiontableVersionCopyAsyncWithHttpInfo(tableId, tableVersion, body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Copy a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PostBusinessrulesDecisiontableVersionCopyAsyncWithHttpInfo(string tableId, int? tableVersion, CopyDecisionTableRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionCopy");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionCopy");

			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionCopy");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/copy";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionCopy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionCopy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Execute a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTableExecutionResponse</returns>

		public DecisionTableExecutionResponse PostBusinessrulesDecisiontableVersionExecute(string tableId, int? tableVersion, DecisionTableExecutionRequest body)
		{
			ApiResponse<DecisionTableExecutionResponse> localVarResponse = PostBusinessrulesDecisiontableVersionExecuteWithHttpInfo(tableId, tableVersion, body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Execute a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTableExecutionResponse</returns>

		public ApiResponse<DecisionTableExecutionResponse> PostBusinessrulesDecisiontableVersionExecuteWithHttpInfo(string tableId, int? tableVersion, DecisionTableExecutionRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionExecute");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionExecute");
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionExecute");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/execute";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableExecutionResponse>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableExecutionResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableExecutionResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Execute a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTableExecutionResponse</returns>

		public async System.Threading.Tasks.Task<DecisionTableExecutionResponse> PostBusinessrulesDecisiontableVersionExecuteAsync(string tableId, int? tableVersion, DecisionTableExecutionRequest body)
		{
			ApiResponse<DecisionTableExecutionResponse> localVarResponse = await PostBusinessrulesDecisiontableVersionExecuteAsyncWithHttpInfo(tableId, tableVersion, body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Execute a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTableExecutionResponse)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableExecutionResponse>> PostBusinessrulesDecisiontableVersionExecuteAsyncWithHttpInfo(string tableId, int? tableVersion, DecisionTableExecutionRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionExecute");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionExecute");

			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionExecute");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/execute";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableExecutionResponse>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableExecutionResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableExecutionResponse)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Create a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Create decision table row request</param>
		/// <returns>DecisionTableRow</returns>

		public DecisionTableRow PostBusinessrulesDecisiontableVersionRows(string tableId, int? tableVersion, CreateDecisionTableRowRequest body)
		{
			ApiResponse<DecisionTableRow> localVarResponse = PostBusinessrulesDecisiontableVersionRowsWithHttpInfo(tableId, tableVersion, body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Create decision table row request</param>
		/// <returns>ApiResponse of DecisionTableRow</returns>

		public ApiResponse<DecisionTableRow> PostBusinessrulesDecisiontableVersionRowsWithHttpInfo(string tableId, int? tableVersion, CreateDecisionTableRowRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRows");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRows");
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRows");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionRows: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionRows: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableRow>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableRow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableRow)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Create a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Create decision table row request</param>
		/// <returns>Task of DecisionTableRow</returns>

		public async System.Threading.Tasks.Task<DecisionTableRow> PostBusinessrulesDecisiontableVersionRowsAsync(string tableId, int? tableVersion, CreateDecisionTableRowRequest body)
		{
			ApiResponse<DecisionTableRow> localVarResponse = await PostBusinessrulesDecisiontableVersionRowsAsyncWithHttpInfo(tableId, tableVersion, body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Create a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Create decision table row request</param>
		/// <returns>Task of ApiResponse (DecisionTableRow)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableRow>> PostBusinessrulesDecisiontableVersionRowsAsyncWithHttpInfo(string tableId, int? tableVersion, CreateDecisionTableRowRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRows");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRows");

			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRows");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionRows: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionRows: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableRow>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableRow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableRow)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Search for decision table rows 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Search decision table rows request</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>DecisionTableRowListing</returns>

		public DecisionTableRowListing PostBusinessrulesDecisiontableVersionRowsSearch(string tableId, int? tableVersion, SearchDecisionTableRowsRequest body, string pageNumber = null, string pageSize = null)
		{
			ApiResponse<DecisionTableRowListing> localVarResponse = PostBusinessrulesDecisiontableVersionRowsSearchWithHttpInfo(tableId, tableVersion, body, pageNumber, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Search for decision table rows 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Search decision table rows request</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>ApiResponse of DecisionTableRowListing</returns>

		public ApiResponse<DecisionTableRowListing> PostBusinessrulesDecisiontableVersionRowsSearchWithHttpInfo(string tableId, int? tableVersion, SearchDecisionTableRowsRequest body, string pageNumber = null, string pageSize = null)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRowsSearch");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRowsSearch");
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRowsSearch");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/search";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

			// Query params
			if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
			if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionRowsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionRowsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableRowListing>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableRowListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableRowListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Search for decision table rows 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Search decision table rows request</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>Task of DecisionTableRowListing</returns>

		public async System.Threading.Tasks.Task<DecisionTableRowListing> PostBusinessrulesDecisiontableVersionRowsSearchAsync(string tableId, int? tableVersion, SearchDecisionTableRowsRequest body, string pageNumber = null, string pageSize = null)
		{
			ApiResponse<DecisionTableRowListing> localVarResponse = await PostBusinessrulesDecisiontableVersionRowsSearchAsyncWithHttpInfo(tableId, tableVersion, body, pageNumber, pageSize);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Search for decision table rows 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="body">Search decision table rows request</param>
		/// <param name="pageNumber">Page number of the entities to return. Defaults to 1. (optional)</param>
		/// <param name="pageSize">Number of entities to return. Maximum of 100. Defaults to 25. (optional)</param>
		/// <returns>Task of ApiResponse (DecisionTableRowListing)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableRowListing>> PostBusinessrulesDecisiontableVersionRowsSearchAsyncWithHttpInfo(string tableId, int? tableVersion, SearchDecisionTableRowsRequest body, string pageNumber = null, string pageSize = null)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRowsSearch");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRowsSearch");

			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionRowsSearch");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/search";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

			// Query params
			if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
			if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionRowsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionRowsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableRowListing>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableRowListing)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableRowListing)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Update the Business Rules Schema to the latest version for a given decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>DecisionTableVersion</returns>

		public DecisionTableVersion PostBusinessrulesDecisiontableVersionSync(string tableId, int? tableVersion)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = PostBusinessrulesDecisiontableVersionSyncWithHttpInfo(tableId, tableVersion);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update the Business Rules Schema to the latest version for a given decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		public ApiResponse<DecisionTableVersion> PostBusinessrulesDecisiontableVersionSyncWithHttpInfo(string tableId, int? tableVersion)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionSync");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionSync");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/sync";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionSync: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionSync: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Update the Business Rules Schema to the latest version for a given decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of DecisionTableVersion</returns>

		public async System.Threading.Tasks.Task<DecisionTableVersion> PostBusinessrulesDecisiontableVersionSyncAsync(string tableId, int? tableVersion)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = await PostBusinessrulesDecisiontableVersionSyncAsyncWithHttpInfo(tableId, tableVersion);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Update the Business Rules Schema to the latest version for a given decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PostBusinessrulesDecisiontableVersionSyncAsyncWithHttpInfo(string tableId, int? tableVersion)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionSync");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersionSync");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/sync";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionSync: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersionSync: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Create a new decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>DecisionTableVersion</returns>

		public DecisionTableVersion PostBusinessrulesDecisiontableVersions(string tableId)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = PostBusinessrulesDecisiontableVersionsWithHttpInfo(tableId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a new decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		public ApiResponse<DecisionTableVersion> PostBusinessrulesDecisiontableVersionsWithHttpInfo(string tableId)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersions");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Create a new decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>Task of DecisionTableVersion</returns>

		public async System.Threading.Tasks.Task<DecisionTableVersion> PostBusinessrulesDecisiontableVersionsAsync(string tableId)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = await PostBusinessrulesDecisiontableVersionsAsyncWithHttpInfo(tableId);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Create a new decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PostBusinessrulesDecisiontableVersionsAsyncWithHttpInfo(string tableId)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PostBusinessrulesDecisiontableVersions");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontableVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Create a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Decision Table</param>
		/// <returns>DecisionTableVersion</returns>

		public DecisionTableVersion PostBusinessrulesDecisiontables(CreateDecisionTableRequest body)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = PostBusinessrulesDecisiontablesWithHttpInfo(body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Decision Table</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		public ApiResponse<DecisionTableVersion> PostBusinessrulesDecisiontablesWithHttpInfo(CreateDecisionTableRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontables");

			var localVarPath = "/businessrules/decisiontables";
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontables: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontables: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Create a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of DecisionTableVersion</returns>

		public async System.Threading.Tasks.Task<DecisionTableVersion> PostBusinessrulesDecisiontablesAsync(CreateDecisionTableRequest body)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = await PostBusinessrulesDecisiontablesAsyncWithHttpInfo(body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Create a decision table 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Decision Table</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PostBusinessrulesDecisiontablesAsyncWithHttpInfo(CreateDecisionTableRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesDecisiontables");


			var localVarPath = "/businessrules/decisiontables";
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontables: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesDecisiontables: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Create a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Business Rules Schema Create Request</param>
		/// <returns>BusinessRulesDataSchema</returns>

		public BusinessRulesDataSchema PostBusinessrulesSchemas(BusinessRulesSchemaCreateRequest body)
		{
			ApiResponse<BusinessRulesDataSchema> localVarResponse = PostBusinessrulesSchemasWithHttpInfo(body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Business Rules Schema Create Request</param>
		/// <returns>ApiResponse of BusinessRulesDataSchema</returns>

		public ApiResponse<BusinessRulesDataSchema> PostBusinessrulesSchemasWithHttpInfo(BusinessRulesSchemaCreateRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesSchemas");

			var localVarPath = "/businessrules/schemas";
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BusinessRulesDataSchema>(localVarStatusCode,
				localVarHeaders,
				(BusinessRulesDataSchema)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessRulesDataSchema)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Create a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Business Rules Schema Create Request</param>
		/// <returns>Task of BusinessRulesDataSchema</returns>

		public async System.Threading.Tasks.Task<BusinessRulesDataSchema> PostBusinessrulesSchemasAsync(BusinessRulesSchemaCreateRequest body)
		{
			ApiResponse<BusinessRulesDataSchema> localVarResponse = await PostBusinessrulesSchemasAsyncWithHttpInfo(body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Create a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="body">Business Rules Schema Create Request</param>
		/// <returns>Task of ApiResponse (BusinessRulesDataSchema)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<BusinessRulesDataSchema>> PostBusinessrulesSchemasAsyncWithHttpInfo(BusinessRulesSchemaCreateRequest body)
		{
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PostBusinessrulesSchemas");


			var localVarPath = "/businessrules/schemas";
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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesSchemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PostBusinessrulesSchemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BusinessRulesDataSchema>(localVarStatusCode,
				localVarHeaders,
				(BusinessRulesDataSchema)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessRulesDataSchema)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Publish a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>DecisionTableVersion</returns>

		public DecisionTableVersion PutBusinessrulesDecisiontableVersionPublish(string tableId, int? tableVersion)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = PutBusinessrulesDecisiontableVersionPublishWithHttpInfo(tableId, tableVersion);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Publish a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>ApiResponse of DecisionTableVersion</returns>

		public ApiResponse<DecisionTableVersion> PutBusinessrulesDecisiontableVersionPublishWithHttpInfo(string tableId, int? tableVersion)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionPublish");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionPublish");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/publish";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesDecisiontableVersionPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesDecisiontableVersionPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Publish a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of DecisionTableVersion</returns>

		public async System.Threading.Tasks.Task<DecisionTableVersion> PutBusinessrulesDecisiontableVersionPublishAsync(string tableId, int? tableVersion)
		{
			ApiResponse<DecisionTableVersion> localVarResponse = await PutBusinessrulesDecisiontableVersionPublishAsyncWithHttpInfo(tableId, tableVersion);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Publish a decision table version 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <returns>Task of ApiResponse (DecisionTableVersion)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableVersion>> PutBusinessrulesDecisiontableVersionPublishAsyncWithHttpInfo(string tableId, int? tableVersion)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionPublish");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionPublish");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/publish";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesDecisiontableVersionPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesDecisiontableVersionPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableVersion>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableVersion)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableVersion)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Full update a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <param name="body">Full update decision table row request</param>
		/// <returns>DecisionTableRow</returns>

		public DecisionTableRow PutBusinessrulesDecisiontableVersionRow(string tableId, int? tableVersion, string rowId, PutDecisionTableRowRequest body)
		{
			ApiResponse<DecisionTableRow> localVarResponse = PutBusinessrulesDecisiontableVersionRowWithHttpInfo(tableId, tableVersion, rowId, body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Full update a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <param name="body">Full update decision table row request</param>
		/// <returns>ApiResponse of DecisionTableRow</returns>

		public ApiResponse<DecisionTableRow> PutBusinessrulesDecisiontableVersionRowWithHttpInfo(string tableId, int? tableVersion, string rowId, PutDecisionTableRowRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionRow");
			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionRow");
			// verify the required parameter 'rowId' is set
			if (rowId == null)
				throw new ApiException(400, "Missing required parameter 'rowId' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionRow");
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionRow");

			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/{rowId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));
			if (rowId != null) localVarPathParams.Add("rowId", this.Configuration.ApiClient.ParameterToString(rowId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesDecisiontableVersionRow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesDecisiontableVersionRow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableRow>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableRow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableRow)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Full update a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <param name="body">Full update decision table row request</param>
		/// <returns>Task of DecisionTableRow</returns>

		public async System.Threading.Tasks.Task<DecisionTableRow> PutBusinessrulesDecisiontableVersionRowAsync(string tableId, int? tableVersion, string rowId, PutDecisionTableRowRequest body)
		{
			ApiResponse<DecisionTableRow> localVarResponse = await PutBusinessrulesDecisiontableVersionRowAsyncWithHttpInfo(tableId, tableVersion, rowId, body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Full update a decision table row 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tableId">Table ID</param>
		/// <param name="tableVersion">Table Version</param>
		/// <param name="rowId">Row ID</param>
		/// <param name="body">Full update decision table row request</param>
		/// <returns>Task of ApiResponse (DecisionTableRow)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<DecisionTableRow>> PutBusinessrulesDecisiontableVersionRowAsyncWithHttpInfo(string tableId, int? tableVersion, string rowId, PutDecisionTableRowRequest body)
		{
			// verify the required parameter 'tableId' is set
			if (tableId == null)
				throw new ApiException(400, "Missing required parameter 'tableId' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionRow");

			// verify the required parameter 'tableVersion' is set
			if (tableVersion == null)
				throw new ApiException(400, "Missing required parameter 'tableVersion' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionRow");

			// verify the required parameter 'rowId' is set
			if (rowId == null)
				throw new ApiException(400, "Missing required parameter 'rowId' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionRow");

			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PutBusinessrulesDecisiontableVersionRow");


			var localVarPath = "/businessrules/decisiontables/{tableId}/versions/{tableVersion}/rows/{rowId}";
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
			if (tableId != null) localVarPathParams.Add("tableId", this.Configuration.ApiClient.ParameterToString(tableId));
			if (tableVersion != null) localVarPathParams.Add("tableVersion", this.Configuration.ApiClient.ParameterToString(tableVersion));
			if (rowId != null) localVarPathParams.Add("rowId", this.Configuration.ApiClient.ParameterToString(rowId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesDecisiontableVersionRow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesDecisiontableVersionRow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<DecisionTableRow>(localVarStatusCode,
				localVarHeaders,
				(DecisionTableRow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DecisionTableRow)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



		/// <summary>
		/// Update a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <param name="body">Business Rules Schema Update Request</param>
		/// <returns>BusinessRulesDataSchema</returns>

		public BusinessRulesDataSchema PutBusinessrulesSchema(string schemaId, BusinessRulesSchemaUpdateRequest body)
		{
			ApiResponse<BusinessRulesDataSchema> localVarResponse = PutBusinessrulesSchemaWithHttpInfo(schemaId, body);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <param name="body">Business Rules Schema Update Request</param>
		/// <returns>ApiResponse of BusinessRulesDataSchema</returns>

		public ApiResponse<BusinessRulesDataSchema> PutBusinessrulesSchemaWithHttpInfo(string schemaId, BusinessRulesSchemaUpdateRequest body)
		{
			// verify the required parameter 'schemaId' is set
			if (schemaId == null)
				throw new ApiException(400, "Missing required parameter 'schemaId' when calling BusinessRulesApi->PutBusinessrulesSchema");
			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PutBusinessrulesSchema");

			var localVarPath = "/businessrules/schemas/{schemaId}";
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
			if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BusinessRulesDataSchema>(localVarStatusCode,
				localVarHeaders,
				(BusinessRulesDataSchema)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessRulesDataSchema)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}


		/// <summary>
		/// Update a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <param name="body">Business Rules Schema Update Request</param>
		/// <returns>Task of BusinessRulesDataSchema</returns>

		public async System.Threading.Tasks.Task<BusinessRulesDataSchema> PutBusinessrulesSchemaAsync(string schemaId, BusinessRulesSchemaUpdateRequest body)
		{
			ApiResponse<BusinessRulesDataSchema> localVarResponse = await PutBusinessrulesSchemaAsyncWithHttpInfo(schemaId, body);
			return localVarResponse.Data;

		}

		/// <summary>
		/// Update a schema 
		/// 
		/// </summary>
		/// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="schemaId">Schema ID</param>
		/// <param name="body">Business Rules Schema Update Request</param>
		/// <returns>Task of ApiResponse (BusinessRulesDataSchema)</returns>

		public async System.Threading.Tasks.Task<ApiResponse<BusinessRulesDataSchema>> PutBusinessrulesSchemaAsyncWithHttpInfo(string schemaId, BusinessRulesSchemaUpdateRequest body)
		{
			// verify the required parameter 'schemaId' is set
			if (schemaId == null)
				throw new ApiException(400, "Missing required parameter 'schemaId' when calling BusinessRulesApi->PutBusinessrulesSchema");

			// verify the required parameter 'body' is set
			if (body == null)
				throw new ApiException(400, "Missing required parameter 'body' when calling BusinessRulesApi->PutBusinessrulesSchema");


			var localVarPath = "/businessrules/schemas/{schemaId}";
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
			if (schemaId != null) localVarPathParams.Add("schemaId", this.Configuration.ApiClient.ParameterToString(schemaId));

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

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

			if (localVarStatusCode >= 400)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesSchema: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
			else if (localVarStatusCode == 0)
				throw new ApiException(localVarStatusCode, "Error calling PutBusinessrulesSchema: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

			return new ApiResponse<BusinessRulesDataSchema>(localVarStatusCode,
				localVarHeaders,
				(BusinessRulesDataSchema)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessRulesDataSchema)),
				localVarResponse.Content,
				localVarResponse.StatusDescription);
		}



	}

}
