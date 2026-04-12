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
    public interface ICaseManagementApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>Object</returns>
        
        Object DeleteCasemanagementCase (string caseId);

        /// <summary>
        /// Delete a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>ApiResponse of Object</returns>
        
        ApiResponse<Object> DeleteCasemanagementCaseWithHttpInfo (string caseId);

        /// <summary>
        /// Delete a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Object</returns>
        
        Object DeleteCasemanagementCaseplan (string caseplanId);

        /// <summary>
        /// Delete a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>ApiResponse of Object</returns>
        
        ApiResponse<Object> DeleteCasemanagementCaseplanWithHttpInfo (string caseplanId);

        /// <summary>
        /// Get a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Case</returns>
        
        Case GetCasemanagementCase (string caseId, string expands = null);

        /// <summary>
        /// Get a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of Case</returns>
        
        ApiResponse<Case> GetCasemanagementCaseWithHttpInfo (string caseId, string expands = null);

        /// <summary>
        /// Get a Case Association.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseAssociation is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="associationId">Case Association ID</param>
        /// <returns>CaseAssociation</returns>
        
        CaseAssociation GetCasemanagementCaseAssociation (string caseId, string associationId);

        /// <summary>
        /// Get a Case Association.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseAssociation is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="associationId">Case Association ID</param>
        /// <returns>ApiResponse of CaseAssociation</returns>
        
        ApiResponse<CaseAssociation> GetCasemanagementCaseAssociationWithHttpInfo (string caseId, string associationId);

        /// <summary>
        /// Get a list of case associations for a provided case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>CaseAssociationListing</returns>
        
        CaseAssociationListing GetCasemanagementCaseAssociations (string caseId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a list of case associations for a provided case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>ApiResponse of CaseAssociationListing</returns>
        
        ApiResponse<CaseAssociationListing> GetCasemanagementCaseAssociationsWithHttpInfo (string caseId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a Stage.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <returns>Stage</returns>
        
        Stage GetCasemanagementCaseStage (string caseId, string stageId);

        /// <summary>
        /// Get a Stage.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <returns>ApiResponse of Stage</returns>
        
        ApiResponse<Stage> GetCasemanagementCaseStageWithHttpInfo (string caseId, string stageId);

        /// <summary>
        /// Get a Step.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStageStep is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="stepId">Step ID</param>
        /// <returns>Step</returns>
        
        Step GetCasemanagementCaseStageStep (string caseId, string stageId, string stepId);

        /// <summary>
        /// Get a Step.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStageStep is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="stepId">Step ID</param>
        /// <returns>ApiResponse of Step</returns>
        
        ApiResponse<Step> GetCasemanagementCaseStageStepWithHttpInfo (string caseId, string stageId, string stepId);

        /// <summary>
        /// Get a list of Steps.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStageSteps is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>StepListing</returns>
        
        StepListing GetCasemanagementCaseStageSteps (string caseId, string stageId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a list of Steps.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStageSteps is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>ApiResponse of StepListing</returns>
        
        ApiResponse<StepListing> GetCasemanagementCaseStageStepsWithHttpInfo (string caseId, string stageId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a list of Stages.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>StageListing</returns>
        
        StageListing GetCasemanagementCaseStages (string caseId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a list of Stages.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>ApiResponse of StageListing</returns>
        
        ApiResponse<StageListing> GetCasemanagementCaseStagesWithHttpInfo (string caseId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a Terminate Job for a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseTerminateJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>TerminateJob</returns>
        
        TerminateJob GetCasemanagementCaseTerminateJob (string caseId, string jobId);

        /// <summary>
        /// Get a Terminate Job for a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseTerminateJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of TerminateJob</returns>
        
        ApiResponse<TerminateJob> GetCasemanagementCaseTerminateJobWithHttpInfo (string caseId, string jobId);

        /// <summary>
        /// Get a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Caseplan</returns>
        
        Caseplan GetCasemanagementCaseplan (string caseplanId);

        /// <summary>
        /// Get a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>ApiResponse of Caseplan</returns>
        
        ApiResponse<Caseplan> GetCasemanagementCaseplanWithHttpInfo (string caseplanId);

        /// <summary>
        /// Get a Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Caseplan</returns>
        
        Caseplan GetCasemanagementCaseplanVersion (string caseplanId, string versionId);

        /// <summary>
        /// Get a Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>ApiResponse of Caseplan</returns>
        
        ApiResponse<Caseplan> GetCasemanagementCaseplanVersionWithHttpInfo (string caseplanId, string versionId);

        /// <summary>
        /// Get the dataSchemas for a caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionDataschemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>CaseplanDataSchemaListing</returns>
        
        CaseplanDataSchemaListing GetCasemanagementCaseplanVersionDataschemas (string caseplanId, string versionId);

        /// <summary>
        /// Get the dataSchemas for a caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionDataschemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>ApiResponse of CaseplanDataSchemaListing</returns>
        
        ApiResponse<CaseplanDataSchemaListing> GetCasemanagementCaseplanVersionDataschemasWithHttpInfo (string caseplanId, string versionId);

        /// <summary>
        /// Get the intake settings for a Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>IntakeSettingsListing</returns>
        
        IntakeSettingsListing GetCasemanagementCaseplanVersionIntakesettings (string caseplanId, string versionId);

        /// <summary>
        /// Get the intake settings for a Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>ApiResponse of IntakeSettingsListing</returns>
        
        ApiResponse<IntakeSettingsListing> GetCasemanagementCaseplanVersionIntakesettingsWithHttpInfo (string caseplanId, string versionId);

        /// <summary>
        /// Get a Stageplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Stageplan</returns>
        
        Stageplan GetCasemanagementCaseplanVersionStageplan (string caseplanId, string versionId, string stageplanId, List<string> expands = null);

        /// <summary>
        /// Get a Stageplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of Stageplan</returns>
        
        ApiResponse<Stageplan> GetCasemanagementCaseplanVersionStageplanWithHttpInfo (string caseplanId, string versionId, string stageplanId, List<string> expands = null);

        /// <summary>
        /// Get a Stepplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Stepplan</returns>
        
        Stepplan GetCasemanagementCaseplanVersionStageplanStepplan (string caseplanId, string versionId, string stageplanId, string stepplanId, List<string> expands = null);

        /// <summary>
        /// Get a Stepplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of Stepplan</returns>
        
        ApiResponse<Stepplan> GetCasemanagementCaseplanVersionStageplanStepplanWithHttpInfo (string caseplanId, string versionId, string stageplanId, string stepplanId, List<string> expands = null);

        /// <summary>
        /// Get a list of Stepplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>StepplanListing</returns>
        
        StepplanListing GetCasemanagementCaseplanVersionStageplanStepplans (string caseplanId, string versionId, string stageplanId, string before = null, string after = null, string pageSize = null, List<string> expands = null);

        /// <summary>
        /// Get a list of Stepplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of StepplanListing</returns>
        
        ApiResponse<StepplanListing> GetCasemanagementCaseplanVersionStageplanStepplansWithHttpInfo (string caseplanId, string versionId, string stageplanId, string before = null, string after = null, string pageSize = null, List<string> expands = null);

        /// <summary>
        /// Get a list of Stageplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>StageplanListing</returns>
        
        StageplanListing GetCasemanagementCaseplanVersionStageplans (string caseplanId, string versionId, string before = null, string after = null, string pageSize = null, List<string> expands = null);

        /// <summary>
        /// Get a list of Stageplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of StageplanListing</returns>
        
        ApiResponse<StageplanListing> GetCasemanagementCaseplanVersionStageplansWithHttpInfo (string caseplanId, string versionId, string before = null, string after = null, string pageSize = null, List<string> expands = null);

        /// <summary>
        /// Get a list of Caseplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of caseplans that has been returned. (optional)</param>
        /// <param name="pageSize">Number of caseplans to return. Maximum of 200. (optional)</param>
        /// <param name="customerIntentId">Filter by Customer Intent. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions. (optional)</param>
        /// <returns>CaseplanListing</returns>
        
        CaseplanListing GetCasemanagementCaseplans (string after = null, int? pageSize = null, string customerIntentId = null, string divisionIds = null);

        /// <summary>
        /// Get a list of Caseplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of caseplans that has been returned. (optional)</param>
        /// <param name="pageSize">Number of caseplans to return. Maximum of 200. (optional)</param>
        /// <param name="customerIntentId">Filter by Customer Intent. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions. (optional)</param>
        /// <returns>ApiResponse of CaseplanListing</returns>
        
        ApiResponse<CaseplanListing> GetCasemanagementCaseplansWithHttpInfo (string after = null, int? pageSize = null, string customerIntentId = null, string divisionIds = null);

        /// <summary>
        /// Get a list of cases for provided external contact id.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCasesExternalcontact is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact ID</param>
        /// <param name="after">The cursor that points to the end of the set of cases that has been returned. (optional)</param>
        /// <param name="pageSize">Number of cases to return. Maximum of 200. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>CaseListing</returns>
        
        CaseListing GetCasemanagementCasesExternalcontact (string externalContactId, string after = null, int? pageSize = null, string divisionIds = null, List<string> expands = null);

        /// <summary>
        /// Get a list of cases for provided external contact id.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCasesExternalcontact is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact ID</param>
        /// <param name="after">The cursor that points to the end of the set of cases that has been returned. (optional)</param>
        /// <param name="pageSize">Number of cases to return. Maximum of 200. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of CaseListing</returns>
        
        ApiResponse<CaseListing> GetCasemanagementCasesExternalcontactWithHttpInfo (string externalContactId, string after = null, int? pageSize = null, string divisionIds = null, List<string> expands = null);

        /// <summary>
        /// Get a Case by reference.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCasesReference is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceId">Reference</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Case</returns>
        
        Case GetCasemanagementCasesReference (string referenceId, string expands = null);

        /// <summary>
        /// Get a Case by reference.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCasesReference is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceId">Reference</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of Case</returns>
        
        ApiResponse<Case> GetCasemanagementCasesReferenceWithHttpInfo (string referenceId, string expands = null);

        /// <summary>
        /// Update date due of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseDatedue is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Date due</param>
        /// <returns>Case</returns>
        
        Case PatchCasemanagementCaseDatedue (string caseId, CaseDateDueUpdate body);

        /// <summary>
        /// Update date due of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseDatedue is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Date due</param>
        /// <returns>ApiResponse of Case</returns>
        
        ApiResponse<Case> PatchCasemanagementCaseDatedueWithHttpInfo (string caseId, CaseDateDueUpdate body);

        /// <summary>
        /// Update priority of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCasePriority is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Priority</param>
        /// <returns>Case</returns>
        
        Case PatchCasemanagementCasePriority (string caseId, CasePriorityUpdate body);

        /// <summary>
        /// Update priority of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCasePriority is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Priority</param>
        /// <returns>ApiResponse of Case</returns>
        
        ApiResponse<Case> PatchCasemanagementCasePriorityWithHttpInfo (string caseId, CasePriorityUpdate body);

        /// <summary>
        /// Update summary of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseSummary is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Summary</param>
        /// <returns>Case</returns>
        
        Case PatchCasemanagementCaseSummary (string caseId, CaseSummaryUpdate body);

        /// <summary>
        /// Update summary of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseSummary is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Summary</param>
        /// <returns>ApiResponse of Case</returns>
        
        ApiResponse<Case> PatchCasemanagementCaseSummaryWithHttpInfo (string caseId, CaseSummaryUpdate body);

        /// <summary>
        /// Update the attributes of a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Caseplan</param>
        /// <returns>Caseplan</returns>
        
        Caseplan PatchCasemanagementCaseplan (string caseplanId, CaseplanUpdate body);

        /// <summary>
        /// Update the attributes of a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Caseplan</param>
        /// <returns>ApiResponse of Caseplan</returns>
        
        ApiResponse<Caseplan> PatchCasemanagementCaseplanWithHttpInfo (string caseplanId, CaseplanUpdate body);

        /// <summary>
        /// Update the attributes of a Stageplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplanStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="body">Stageplan</param>
        /// <returns>Stageplan</returns>
        
        Stageplan PatchCasemanagementCaseplanStageplan (string caseplanId, string stageplanId, StageplanUpdate body);

        /// <summary>
        /// Update the attributes of a Stageplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplanStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="body">Stageplan</param>
        /// <returns>ApiResponse of Stageplan</returns>
        
        ApiResponse<Stageplan> PatchCasemanagementCaseplanStageplanWithHttpInfo (string caseplanId, string stageplanId, StageplanUpdate body);

        /// <summary>
        /// Update the attributes of a Stepplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplanStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="body">Stepplan</param>
        /// <returns>Stepplan</returns>
        
        Stepplan PatchCasemanagementCaseplanStageplanStepplan (string caseplanId, string stageplanId, string stepplanId, StepplanUpdate body);

        /// <summary>
        /// Update the attributes of a Stepplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplanStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="body">Stepplan</param>
        /// <returns>ApiResponse of Stepplan</returns>
        
        ApiResponse<Stepplan> PatchCasemanagementCaseplanStageplanStepplanWithHttpInfo (string caseplanId, string stageplanId, string stepplanId, StepplanUpdate body);

        /// <summary>
        /// Create a case association.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>CaseAssociation</returns>
        
        CaseAssociation PostCasemanagementCaseAssociations (string caseId, CaseAssociationCreate body = null);

        /// <summary>
        /// Create a case association.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>ApiResponse of CaseAssociation</returns>
        
        ApiResponse<CaseAssociation> PostCasemanagementCaseAssociationsWithHttpInfo (string caseId, CaseAssociationCreate body = null);

        /// <summary>
        /// Create a Terminate Job for a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseTerminateJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>TerminateJob</returns>
        
        TerminateJob PostCasemanagementCaseTerminateJobs (string caseId);

        /// <summary>
        /// Create a Terminate Job for a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseTerminateJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>ApiResponse of TerminateJob</returns>
        
        ApiResponse<TerminateJob> PostCasemanagementCaseTerminateJobsWithHttpInfo (string caseId);

        /// <summary>
        /// Publish Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplanPublish is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Caseplan</returns>
        
        Caseplan PostCasemanagementCaseplanPublish (string caseplanId);

        /// <summary>
        /// Publish Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplanPublish is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>ApiResponse of Caseplan</returns>
        
        ApiResponse<Caseplan> PostCasemanagementCaseplanPublishWithHttpInfo (string caseplanId);

        /// <summary>
        /// Create Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplanVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Caseplan</returns>
        
        Caseplan PostCasemanagementCaseplanVersions (string caseplanId);

        /// <summary>
        /// Create Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplanVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>ApiResponse of Caseplan</returns>
        
        ApiResponse<Caseplan> PostCasemanagementCaseplanVersionsWithHttpInfo (string caseplanId);

        /// <summary>
        /// Create a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Caseplan</param>
        /// <returns>CaseplanCreateResponse</returns>
        
        CaseplanCreateResponse PostCasemanagementCaseplans (CaseplanCreate body);

        /// <summary>
        /// Create a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Caseplan</param>
        /// <returns>ApiResponse of CaseplanCreateResponse</returns>
        
        ApiResponse<CaseplanCreateResponse> PostCasemanagementCaseplansWithHttpInfo (CaseplanCreate body);

        /// <summary>
        /// Create a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCases is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case</param>
        /// <returns>Case</returns>
        
        Case PostCasemanagementCases (CaseCreate body);

        /// <summary>
        /// Create a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCases is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case</param>
        /// <returns>ApiResponse of Case</returns>
        
        ApiResponse<Case> PostCasemanagementCasesWithHttpInfo (CaseCreate body);

        /// <summary>
        /// Query for case associations
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCasesAssociationsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>CaseAssociationQueryEntityListing</returns>
        
        CaseAssociationQueryEntityListing PostCasemanagementCasesAssociationsQuery (CaseAssociationQuery body = null);

        /// <summary>
        /// Query for case associations
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCasesAssociationsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>ApiResponse of CaseAssociationQueryEntityListing</returns>
        
        ApiResponse<CaseAssociationQueryEntityListing> PostCasemanagementCasesAssociationsQueryWithHttpInfo (CaseAssociationQuery body = null);

        /// <summary>
        /// Update the intake settings for a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PutCasemanagementCaseplanIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Intake Settings</param>
        /// <returns>IntakeSettingsListing</returns>
        
        IntakeSettingsListing PutCasemanagementCaseplanIntakesettings (string caseplanId, IntakeSettingsUpdate body);

        /// <summary>
        /// Update the intake settings for a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PutCasemanagementCaseplanIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Intake Settings</param>
        /// <returns>ApiResponse of IntakeSettingsListing</returns>
        
        ApiResponse<IntakeSettingsListing> PutCasemanagementCaseplanIntakesettingsWithHttpInfo (string caseplanId, IntakeSettingsUpdate body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>Task of Object</returns>
        
        System.Threading.Tasks.Task<Object> DeleteCasemanagementCaseAsync (string caseId);

        /// <summary>
        /// Delete a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCasemanagementCaseAsyncWithHttpInfo (string caseId);

        /// <summary>
        /// Delete a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of Object</returns>
        
        System.Threading.Tasks.Task<Object> DeleteCasemanagementCaseplanAsync (string caseplanId);

        /// <summary>
        /// Delete a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// DeleteCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCasemanagementCaseplanAsyncWithHttpInfo (string caseplanId);

        /// <summary>
        /// Get a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of Case</returns>
        
        System.Threading.Tasks.Task<Case> GetCasemanagementCaseAsync (string caseId, string expands = null);

        /// <summary>
        /// Get a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Case>> GetCasemanagementCaseAsyncWithHttpInfo (string caseId, string expands = null);

        /// <summary>
        /// Get a Case Association.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseAssociation is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="associationId">Case Association ID</param>
        /// <returns>Task of CaseAssociation</returns>
        
        System.Threading.Tasks.Task<CaseAssociation> GetCasemanagementCaseAssociationAsync (string caseId, string associationId);

        /// <summary>
        /// Get a Case Association.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseAssociation is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="associationId">Case Association ID</param>
        /// <returns>Task of ApiResponse (CaseAssociation)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CaseAssociation>> GetCasemanagementCaseAssociationAsyncWithHttpInfo (string caseId, string associationId);

        /// <summary>
        /// Get a list of case associations for a provided case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of CaseAssociationListing</returns>
        
        System.Threading.Tasks.Task<CaseAssociationListing> GetCasemanagementCaseAssociationsAsync (string caseId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a list of case associations for a provided case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of ApiResponse (CaseAssociationListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CaseAssociationListing>> GetCasemanagementCaseAssociationsAsyncWithHttpInfo (string caseId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a Stage.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <returns>Task of Stage</returns>
        
        System.Threading.Tasks.Task<Stage> GetCasemanagementCaseStageAsync (string caseId, string stageId);

        /// <summary>
        /// Get a Stage.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <returns>Task of ApiResponse (Stage)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Stage>> GetCasemanagementCaseStageAsyncWithHttpInfo (string caseId, string stageId);

        /// <summary>
        /// Get a Step.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStageStep is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="stepId">Step ID</param>
        /// <returns>Task of Step</returns>
        
        System.Threading.Tasks.Task<Step> GetCasemanagementCaseStageStepAsync (string caseId, string stageId, string stepId);

        /// <summary>
        /// Get a Step.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStageStep is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="stepId">Step ID</param>
        /// <returns>Task of ApiResponse (Step)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Step>> GetCasemanagementCaseStageStepAsyncWithHttpInfo (string caseId, string stageId, string stepId);

        /// <summary>
        /// Get a list of Steps.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStageSteps is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of StepListing</returns>
        
        System.Threading.Tasks.Task<StepListing> GetCasemanagementCaseStageStepsAsync (string caseId, string stageId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a list of Steps.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStageSteps is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of ApiResponse (StepListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<StepListing>> GetCasemanagementCaseStageStepsAsyncWithHttpInfo (string caseId, string stageId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a list of Stages.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of StageListing</returns>
        
        System.Threading.Tasks.Task<StageListing> GetCasemanagementCaseStagesAsync (string caseId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a list of Stages.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseStages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of ApiResponse (StageListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<StageListing>> GetCasemanagementCaseStagesAsyncWithHttpInfo (string caseId, string before = null, string after = null, string pageSize = null);

        /// <summary>
        /// Get a Terminate Job for a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseTerminateJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of TerminateJob</returns>
        
        System.Threading.Tasks.Task<TerminateJob> GetCasemanagementCaseTerminateJobAsync (string caseId, string jobId);

        /// <summary>
        /// Get a Terminate Job for a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseTerminateJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (TerminateJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TerminateJob>> GetCasemanagementCaseTerminateJobAsyncWithHttpInfo (string caseId, string jobId);

        /// <summary>
        /// Get a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of Caseplan</returns>
        
        System.Threading.Tasks.Task<Caseplan> GetCasemanagementCaseplanAsync (string caseplanId);

        /// <summary>
        /// Get a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of ApiResponse (Caseplan)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Caseplan>> GetCasemanagementCaseplanAsyncWithHttpInfo (string caseplanId);

        /// <summary>
        /// Get a Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of Caseplan</returns>
        
        System.Threading.Tasks.Task<Caseplan> GetCasemanagementCaseplanVersionAsync (string caseplanId, string versionId);

        /// <summary>
        /// Get a Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of ApiResponse (Caseplan)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Caseplan>> GetCasemanagementCaseplanVersionAsyncWithHttpInfo (string caseplanId, string versionId);

        /// <summary>
        /// Get the dataSchemas for a caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionDataschemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of CaseplanDataSchemaListing</returns>
        
        System.Threading.Tasks.Task<CaseplanDataSchemaListing> GetCasemanagementCaseplanVersionDataschemasAsync (string caseplanId, string versionId);

        /// <summary>
        /// Get the dataSchemas for a caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionDataschemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of ApiResponse (CaseplanDataSchemaListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CaseplanDataSchemaListing>> GetCasemanagementCaseplanVersionDataschemasAsyncWithHttpInfo (string caseplanId, string versionId);

        /// <summary>
        /// Get the intake settings for a Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of IntakeSettingsListing</returns>
        
        System.Threading.Tasks.Task<IntakeSettingsListing> GetCasemanagementCaseplanVersionIntakesettingsAsync (string caseplanId, string versionId);

        /// <summary>
        /// Get the intake settings for a Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of ApiResponse (IntakeSettingsListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IntakeSettingsListing>> GetCasemanagementCaseplanVersionIntakesettingsAsyncWithHttpInfo (string caseplanId, string versionId);

        /// <summary>
        /// Get a Stageplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of Stageplan</returns>
        
        System.Threading.Tasks.Task<Stageplan> GetCasemanagementCaseplanVersionStageplanAsync (string caseplanId, string versionId, string stageplanId, List<string> expands = null);

        /// <summary>
        /// Get a Stageplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Stageplan)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Stageplan>> GetCasemanagementCaseplanVersionStageplanAsyncWithHttpInfo (string caseplanId, string versionId, string stageplanId, List<string> expands = null);

        /// <summary>
        /// Get a Stepplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of Stepplan</returns>
        
        System.Threading.Tasks.Task<Stepplan> GetCasemanagementCaseplanVersionStageplanStepplanAsync (string caseplanId, string versionId, string stageplanId, string stepplanId, List<string> expands = null);

        /// <summary>
        /// Get a Stepplan.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Stepplan)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Stepplan>> GetCasemanagementCaseplanVersionStageplanStepplanAsyncWithHttpInfo (string caseplanId, string versionId, string stageplanId, string stepplanId, List<string> expands = null);

        /// <summary>
        /// Get a list of Stepplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of StepplanListing</returns>
        
        System.Threading.Tasks.Task<StepplanListing> GetCasemanagementCaseplanVersionStageplanStepplansAsync (string caseplanId, string versionId, string stageplanId, string before = null, string after = null, string pageSize = null, List<string> expands = null);

        /// <summary>
        /// Get a list of Stepplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (StepplanListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<StepplanListing>> GetCasemanagementCaseplanVersionStageplanStepplansAsyncWithHttpInfo (string caseplanId, string versionId, string stageplanId, string before = null, string after = null, string pageSize = null, List<string> expands = null);

        /// <summary>
        /// Get a list of Stageplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of StageplanListing</returns>
        
        System.Threading.Tasks.Task<StageplanListing> GetCasemanagementCaseplanVersionStageplansAsync (string caseplanId, string versionId, string before = null, string after = null, string pageSize = null, List<string> expands = null);

        /// <summary>
        /// Get a list of Stageplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplanVersionStageplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (StageplanListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<StageplanListing>> GetCasemanagementCaseplanVersionStageplansAsyncWithHttpInfo (string caseplanId, string versionId, string before = null, string after = null, string pageSize = null, List<string> expands = null);

        /// <summary>
        /// Get a list of Caseplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of caseplans that has been returned. (optional)</param>
        /// <param name="pageSize">Number of caseplans to return. Maximum of 200. (optional)</param>
        /// <param name="customerIntentId">Filter by Customer Intent. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions. (optional)</param>
        /// <returns>Task of CaseplanListing</returns>
        
        System.Threading.Tasks.Task<CaseplanListing> GetCasemanagementCaseplansAsync (string after = null, int? pageSize = null, string customerIntentId = null, string divisionIds = null);

        /// <summary>
        /// Get a list of Caseplans.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of caseplans that has been returned. (optional)</param>
        /// <param name="pageSize">Number of caseplans to return. Maximum of 200. (optional)</param>
        /// <param name="customerIntentId">Filter by Customer Intent. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions. (optional)</param>
        /// <returns>Task of ApiResponse (CaseplanListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CaseplanListing>> GetCasemanagementCaseplansAsyncWithHttpInfo (string after = null, int? pageSize = null, string customerIntentId = null, string divisionIds = null);

        /// <summary>
        /// Get a list of cases for provided external contact id.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCasesExternalcontact is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact ID</param>
        /// <param name="after">The cursor that points to the end of the set of cases that has been returned. (optional)</param>
        /// <param name="pageSize">Number of cases to return. Maximum of 200. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of CaseListing</returns>
        
        System.Threading.Tasks.Task<CaseListing> GetCasemanagementCasesExternalcontactAsync (string externalContactId, string after = null, int? pageSize = null, string divisionIds = null, List<string> expands = null);

        /// <summary>
        /// Get a list of cases for provided external contact id.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCasesExternalcontact is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact ID</param>
        /// <param name="after">The cursor that points to the end of the set of cases that has been returned. (optional)</param>
        /// <param name="pageSize">Number of cases to return. Maximum of 200. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (CaseListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CaseListing>> GetCasemanagementCasesExternalcontactAsyncWithHttpInfo (string externalContactId, string after = null, int? pageSize = null, string divisionIds = null, List<string> expands = null);

        /// <summary>
        /// Get a Case by reference.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCasesReference is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceId">Reference</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of Case</returns>
        
        System.Threading.Tasks.Task<Case> GetCasemanagementCasesReferenceAsync (string referenceId, string expands = null);

        /// <summary>
        /// Get a Case by reference.
        /// </summary>
        /// <remarks>
        /// 
        /// GetCasemanagementCasesReference is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceId">Reference</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Case>> GetCasemanagementCasesReferenceAsyncWithHttpInfo (string referenceId, string expands = null);

        /// <summary>
        /// Update date due of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseDatedue is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Date due</param>
        /// <returns>Task of Case</returns>
        
        System.Threading.Tasks.Task<Case> PatchCasemanagementCaseDatedueAsync (string caseId, CaseDateDueUpdate body);

        /// <summary>
        /// Update date due of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseDatedue is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Date due</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Case>> PatchCasemanagementCaseDatedueAsyncWithHttpInfo (string caseId, CaseDateDueUpdate body);

        /// <summary>
        /// Update priority of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCasePriority is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Priority</param>
        /// <returns>Task of Case</returns>
        
        System.Threading.Tasks.Task<Case> PatchCasemanagementCasePriorityAsync (string caseId, CasePriorityUpdate body);

        /// <summary>
        /// Update priority of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCasePriority is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Priority</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Case>> PatchCasemanagementCasePriorityAsyncWithHttpInfo (string caseId, CasePriorityUpdate body);

        /// <summary>
        /// Update summary of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseSummary is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Summary</param>
        /// <returns>Task of Case</returns>
        
        System.Threading.Tasks.Task<Case> PatchCasemanagementCaseSummaryAsync (string caseId, CaseSummaryUpdate body);

        /// <summary>
        /// Update summary of a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseSummary is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Summary</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Case>> PatchCasemanagementCaseSummaryAsyncWithHttpInfo (string caseId, CaseSummaryUpdate body);

        /// <summary>
        /// Update the attributes of a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Caseplan</param>
        /// <returns>Task of Caseplan</returns>
        
        System.Threading.Tasks.Task<Caseplan> PatchCasemanagementCaseplanAsync (string caseplanId, CaseplanUpdate body);

        /// <summary>
        /// Update the attributes of a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Caseplan</param>
        /// <returns>Task of ApiResponse (Caseplan)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Caseplan>> PatchCasemanagementCaseplanAsyncWithHttpInfo (string caseplanId, CaseplanUpdate body);

        /// <summary>
        /// Update the attributes of a Stageplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplanStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="body">Stageplan</param>
        /// <returns>Task of Stageplan</returns>
        
        System.Threading.Tasks.Task<Stageplan> PatchCasemanagementCaseplanStageplanAsync (string caseplanId, string stageplanId, StageplanUpdate body);

        /// <summary>
        /// Update the attributes of a Stageplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplanStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="body">Stageplan</param>
        /// <returns>Task of ApiResponse (Stageplan)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Stageplan>> PatchCasemanagementCaseplanStageplanAsyncWithHttpInfo (string caseplanId, string stageplanId, StageplanUpdate body);

        /// <summary>
        /// Update the attributes of a Stepplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplanStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="body">Stepplan</param>
        /// <returns>Task of Stepplan</returns>
        
        System.Threading.Tasks.Task<Stepplan> PatchCasemanagementCaseplanStageplanStepplanAsync (string caseplanId, string stageplanId, string stepplanId, StepplanUpdate body);

        /// <summary>
        /// Update the attributes of a Stepplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PatchCasemanagementCaseplanStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="body">Stepplan</param>
        /// <returns>Task of ApiResponse (Stepplan)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Stepplan>> PatchCasemanagementCaseplanStageplanStepplanAsyncWithHttpInfo (string caseplanId, string stageplanId, string stepplanId, StepplanUpdate body);

        /// <summary>
        /// Create a case association.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>Task of CaseAssociation</returns>
        
        System.Threading.Tasks.Task<CaseAssociation> PostCasemanagementCaseAssociationsAsync (string caseId, CaseAssociationCreate body = null);

        /// <summary>
        /// Create a case association.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>Task of ApiResponse (CaseAssociation)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CaseAssociation>> PostCasemanagementCaseAssociationsAsyncWithHttpInfo (string caseId, CaseAssociationCreate body = null);

        /// <summary>
        /// Create a Terminate Job for a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseTerminateJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>Task of TerminateJob</returns>
        
        System.Threading.Tasks.Task<TerminateJob> PostCasemanagementCaseTerminateJobsAsync (string caseId);

        /// <summary>
        /// Create a Terminate Job for a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseTerminateJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>Task of ApiResponse (TerminateJob)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<TerminateJob>> PostCasemanagementCaseTerminateJobsAsyncWithHttpInfo (string caseId);

        /// <summary>
        /// Publish Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplanPublish is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of Caseplan</returns>
        
        System.Threading.Tasks.Task<Caseplan> PostCasemanagementCaseplanPublishAsync (string caseplanId);

        /// <summary>
        /// Publish Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplanPublish is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of ApiResponse (Caseplan)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Caseplan>> PostCasemanagementCaseplanPublishAsyncWithHttpInfo (string caseplanId);

        /// <summary>
        /// Create Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplanVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of Caseplan</returns>
        
        System.Threading.Tasks.Task<Caseplan> PostCasemanagementCaseplanVersionsAsync (string caseplanId);

        /// <summary>
        /// Create Caseplan version.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplanVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of ApiResponse (Caseplan)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Caseplan>> PostCasemanagementCaseplanVersionsAsyncWithHttpInfo (string caseplanId);

        /// <summary>
        /// Create a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Caseplan</param>
        /// <returns>Task of CaseplanCreateResponse</returns>
        
        System.Threading.Tasks.Task<CaseplanCreateResponse> PostCasemanagementCaseplansAsync (CaseplanCreate body);

        /// <summary>
        /// Create a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Caseplan</param>
        /// <returns>Task of ApiResponse (CaseplanCreateResponse)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CaseplanCreateResponse>> PostCasemanagementCaseplansAsyncWithHttpInfo (CaseplanCreate body);

        /// <summary>
        /// Create a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCases is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case</param>
        /// <returns>Task of Case</returns>
        
        System.Threading.Tasks.Task<Case> PostCasemanagementCasesAsync (CaseCreate body);

        /// <summary>
        /// Create a Case.
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCases is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<Case>> PostCasemanagementCasesAsyncWithHttpInfo (CaseCreate body);

        /// <summary>
        /// Query for case associations
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCasesAssociationsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>Task of CaseAssociationQueryEntityListing</returns>
        
        System.Threading.Tasks.Task<CaseAssociationQueryEntityListing> PostCasemanagementCasesAssociationsQueryAsync (CaseAssociationQuery body = null);

        /// <summary>
        /// Query for case associations
        /// </summary>
        /// <remarks>
        /// 
        /// PostCasemanagementCasesAssociationsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>Task of ApiResponse (CaseAssociationQueryEntityListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<CaseAssociationQueryEntityListing>> PostCasemanagementCasesAssociationsQueryAsyncWithHttpInfo (CaseAssociationQuery body = null);

        /// <summary>
        /// Update the intake settings for a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PutCasemanagementCaseplanIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Intake Settings</param>
        /// <returns>Task of IntakeSettingsListing</returns>
        
        System.Threading.Tasks.Task<IntakeSettingsListing> PutCasemanagementCaseplanIntakesettingsAsync (string caseplanId, IntakeSettingsUpdate body);

        /// <summary>
        /// Update the intake settings for a Caseplan.
        /// </summary>
        /// <remarks>
        /// 
        /// PutCasemanagementCaseplanIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Intake Settings</param>
        /// <returns>Task of ApiResponse (IntakeSettingsListing)</returns>
        
        System.Threading.Tasks.Task<ApiResponse<IntakeSettingsListing>> PutCasemanagementCaseplanIntakesettingsAsyncWithHttpInfo (string caseplanId, IntakeSettingsUpdate body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CaseManagementApi : ICaseManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CaseManagementApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CaseManagementApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a Case. 
        /// 
        /// DeleteCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>Object</returns>
        
        public Object DeleteCasemanagementCase (string caseId)
        {
             ApiResponse<Object> localVarResponse = DeleteCasemanagementCaseWithHttpInfo(caseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Case. 
        /// 
        /// DeleteCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>ApiResponse of Object</returns>
        
        public ApiResponse< Object > DeleteCasemanagementCaseWithHttpInfo (string caseId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->DeleteCasemanagementCase");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCasemanagementCase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteCasemanagementCase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCasemanagementCase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Case. 
        /// 
        /// DeleteCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>Task of Object</returns>
        
        public async System.Threading.Tasks.Task<Object> DeleteCasemanagementCaseAsync (string caseId)
        {
             ApiResponse<Object> localVarResponse = await DeleteCasemanagementCaseAsyncWithHttpInfo(caseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Case. 
        /// 
        /// DeleteCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCasemanagementCaseAsyncWithHttpInfo (string caseId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->DeleteCasemanagementCase");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCasemanagementCase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteCasemanagementCase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCasemanagementCase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Delete a Caseplan. 
        /// 
        /// DeleteCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Object</returns>
        
        public Object DeleteCasemanagementCaseplan (string caseplanId)
        {
             ApiResponse<Object> localVarResponse = DeleteCasemanagementCaseplanWithHttpInfo(caseplanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Caseplan. 
        /// 
        /// DeleteCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>ApiResponse of Object</returns>
        
        public ApiResponse< Object > DeleteCasemanagementCaseplanWithHttpInfo (string caseplanId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->DeleteCasemanagementCaseplan");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCasemanagementCaseplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Delete a Caseplan. 
        /// 
        /// DeleteCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of Object</returns>
        
        public async System.Threading.Tasks.Task<Object> DeleteCasemanagementCaseplanAsync (string caseplanId)
        {
             ApiResponse<Object> localVarResponse = await DeleteCasemanagementCaseplanAsyncWithHttpInfo(caseplanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Caseplan. 
        /// 
        /// DeleteCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCasemanagementCaseplanAsyncWithHttpInfo (string caseplanId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->DeleteCasemanagementCaseplan");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling DeleteCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCasemanagementCaseplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Case. 
        /// 
        /// GetCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Case</returns>
        
        public Case GetCasemanagementCase (string caseId, string expands = null)
        {
             ApiResponse<Case> localVarResponse = GetCasemanagementCaseWithHttpInfo(caseId, expands);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Case. 
        /// 
        /// GetCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of Case</returns>
        
        public ApiResponse< Case > GetCasemanagementCaseWithHttpInfo (string caseId, string expands = null)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCase");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

            // Query params
            if (expands != null) localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(expands)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Case. 
        /// 
        /// GetCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of Case</returns>
        
        public async System.Threading.Tasks.Task<Case> GetCasemanagementCaseAsync (string caseId, string expands = null)
        {
             ApiResponse<Case> localVarResponse = await GetCasemanagementCaseAsyncWithHttpInfo(caseId, expands);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Case. 
        /// 
        /// GetCasemanagementCase is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Case>> GetCasemanagementCaseAsyncWithHttpInfo (string caseId, string expands = null)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCase");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

            // Query params
            if (expands != null) localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(expands)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCase: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCase: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Case Association. 
        /// 
        /// GetCasemanagementCaseAssociation is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="associationId">Case Association ID</param>
        /// <returns>CaseAssociation</returns>
        
        public CaseAssociation GetCasemanagementCaseAssociation (string caseId, string associationId)
        {
             ApiResponse<CaseAssociation> localVarResponse = GetCasemanagementCaseAssociationWithHttpInfo(caseId, associationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Case Association. 
        /// 
        /// GetCasemanagementCaseAssociation is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="associationId">Case Association ID</param>
        /// <returns>ApiResponse of CaseAssociation</returns>
        
        public ApiResponse< CaseAssociation > GetCasemanagementCaseAssociationWithHttpInfo (string caseId, string associationId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseAssociation");
            // verify the required parameter 'associationId' is set
            if (associationId == null)
                throw new ApiException(400, "Missing required parameter 'associationId' when calling CaseManagementApi->GetCasemanagementCaseAssociation");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/associations/{associationId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));
            if (associationId != null) localVarPathParams.Add("associationId", this.Configuration.ApiClient.ParameterToString(associationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseAssociation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseAssociation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseAssociation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseAssociation>(localVarStatusCode,
                localVarHeaders,
                (CaseAssociation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseAssociation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Case Association. 
        /// 
        /// GetCasemanagementCaseAssociation is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="associationId">Case Association ID</param>
        /// <returns>Task of CaseAssociation</returns>
        
        public async System.Threading.Tasks.Task<CaseAssociation> GetCasemanagementCaseAssociationAsync (string caseId, string associationId)
        {
             ApiResponse<CaseAssociation> localVarResponse = await GetCasemanagementCaseAssociationAsyncWithHttpInfo(caseId, associationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Case Association. 
        /// 
        /// GetCasemanagementCaseAssociation is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="associationId">Case Association ID</param>
        /// <returns>Task of ApiResponse (CaseAssociation)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CaseAssociation>> GetCasemanagementCaseAssociationAsyncWithHttpInfo (string caseId, string associationId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseAssociation");
            
            // verify the required parameter 'associationId' is set
            if (associationId == null)
                throw new ApiException(400, "Missing required parameter 'associationId' when calling CaseManagementApi->GetCasemanagementCaseAssociation");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/associations/{associationId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));
            if (associationId != null) localVarPathParams.Add("associationId", this.Configuration.ApiClient.ParameterToString(associationId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseAssociation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseAssociation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseAssociation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseAssociation>(localVarStatusCode,
                localVarHeaders,
                (CaseAssociation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseAssociation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of case associations for a provided case. 
        /// 
        /// GetCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>CaseAssociationListing</returns>
        
        public CaseAssociationListing GetCasemanagementCaseAssociations (string caseId, string before = null, string after = null, string pageSize = null)
        {
             ApiResponse<CaseAssociationListing> localVarResponse = GetCasemanagementCaseAssociationsWithHttpInfo(caseId, before, after, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of case associations for a provided case. 
        /// 
        /// GetCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>ApiResponse of CaseAssociationListing</returns>
        
        public ApiResponse< CaseAssociationListing > GetCasemanagementCaseAssociationsWithHttpInfo (string caseId, string before = null, string after = null, string pageSize = null)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseAssociations");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/associations";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
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

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseAssociations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseAssociations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseAssociations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseAssociationListing>(localVarStatusCode,
                localVarHeaders,
                (CaseAssociationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseAssociationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of case associations for a provided case. 
        /// 
        /// GetCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of CaseAssociationListing</returns>
        
        public async System.Threading.Tasks.Task<CaseAssociationListing> GetCasemanagementCaseAssociationsAsync (string caseId, string before = null, string after = null, string pageSize = null)
        {
             ApiResponse<CaseAssociationListing> localVarResponse = await GetCasemanagementCaseAssociationsAsyncWithHttpInfo(caseId, before, after, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of case associations for a provided case. 
        /// 
        /// GetCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of ApiResponse (CaseAssociationListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CaseAssociationListing>> GetCasemanagementCaseAssociationsAsyncWithHttpInfo (string caseId, string before = null, string after = null, string pageSize = null)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseAssociations");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/associations";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
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

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseAssociations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseAssociations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseAssociations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseAssociationListing>(localVarStatusCode,
                localVarHeaders,
                (CaseAssociationListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseAssociationListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Stage. 
        /// 
        /// GetCasemanagementCaseStage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <returns>Stage</returns>
        
        public Stage GetCasemanagementCaseStage (string caseId, string stageId)
        {
             ApiResponse<Stage> localVarResponse = GetCasemanagementCaseStageWithHttpInfo(caseId, stageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Stage. 
        /// 
        /// GetCasemanagementCaseStage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <returns>ApiResponse of Stage</returns>
        
        public ApiResponse< Stage > GetCasemanagementCaseStageWithHttpInfo (string caseId, string stageId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseStage");
            // verify the required parameter 'stageId' is set
            if (stageId == null)
                throw new ApiException(400, "Missing required parameter 'stageId' when calling CaseManagementApi->GetCasemanagementCaseStage");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/stages/{stageId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));
            if (stageId != null) localVarPathParams.Add("stageId", this.Configuration.ApiClient.ParameterToString(stageId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseStage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stage>(localVarStatusCode,
                localVarHeaders,
                (Stage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Stage. 
        /// 
        /// GetCasemanagementCaseStage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <returns>Task of Stage</returns>
        
        public async System.Threading.Tasks.Task<Stage> GetCasemanagementCaseStageAsync (string caseId, string stageId)
        {
             ApiResponse<Stage> localVarResponse = await GetCasemanagementCaseStageAsyncWithHttpInfo(caseId, stageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Stage. 
        /// 
        /// GetCasemanagementCaseStage is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <returns>Task of ApiResponse (Stage)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Stage>> GetCasemanagementCaseStageAsyncWithHttpInfo (string caseId, string stageId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseStage");
            
            // verify the required parameter 'stageId' is set
            if (stageId == null)
                throw new ApiException(400, "Missing required parameter 'stageId' when calling CaseManagementApi->GetCasemanagementCaseStage");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/stages/{stageId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));
            if (stageId != null) localVarPathParams.Add("stageId", this.Configuration.ApiClient.ParameterToString(stageId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseStage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stage>(localVarStatusCode,
                localVarHeaders,
                (Stage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Step. 
        /// 
        /// GetCasemanagementCaseStageStep is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="stepId">Step ID</param>
        /// <returns>Step</returns>
        
        public Step GetCasemanagementCaseStageStep (string caseId, string stageId, string stepId)
        {
             ApiResponse<Step> localVarResponse = GetCasemanagementCaseStageStepWithHttpInfo(caseId, stageId, stepId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Step. 
        /// 
        /// GetCasemanagementCaseStageStep is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="stepId">Step ID</param>
        /// <returns>ApiResponse of Step</returns>
        
        public ApiResponse< Step > GetCasemanagementCaseStageStepWithHttpInfo (string caseId, string stageId, string stepId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseStageStep");
            // verify the required parameter 'stageId' is set
            if (stageId == null)
                throw new ApiException(400, "Missing required parameter 'stageId' when calling CaseManagementApi->GetCasemanagementCaseStageStep");
            // verify the required parameter 'stepId' is set
            if (stepId == null)
                throw new ApiException(400, "Missing required parameter 'stepId' when calling CaseManagementApi->GetCasemanagementCaseStageStep");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/stages/{stageId}/steps/{stepId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));
            if (stageId != null) localVarPathParams.Add("stageId", this.Configuration.ApiClient.ParameterToString(stageId));
            if (stepId != null) localVarPathParams.Add("stepId", this.Configuration.ApiClient.ParameterToString(stepId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStageStep: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseStageStep: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStageStep: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Step>(localVarStatusCode,
                localVarHeaders,
                (Step) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Step)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Step. 
        /// 
        /// GetCasemanagementCaseStageStep is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="stepId">Step ID</param>
        /// <returns>Task of Step</returns>
        
        public async System.Threading.Tasks.Task<Step> GetCasemanagementCaseStageStepAsync (string caseId, string stageId, string stepId)
        {
             ApiResponse<Step> localVarResponse = await GetCasemanagementCaseStageStepAsyncWithHttpInfo(caseId, stageId, stepId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Step. 
        /// 
        /// GetCasemanagementCaseStageStep is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="stepId">Step ID</param>
        /// <returns>Task of ApiResponse (Step)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Step>> GetCasemanagementCaseStageStepAsyncWithHttpInfo (string caseId, string stageId, string stepId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseStageStep");
            
            // verify the required parameter 'stageId' is set
            if (stageId == null)
                throw new ApiException(400, "Missing required parameter 'stageId' when calling CaseManagementApi->GetCasemanagementCaseStageStep");
            
            // verify the required parameter 'stepId' is set
            if (stepId == null)
                throw new ApiException(400, "Missing required parameter 'stepId' when calling CaseManagementApi->GetCasemanagementCaseStageStep");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/stages/{stageId}/steps/{stepId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));
            if (stageId != null) localVarPathParams.Add("stageId", this.Configuration.ApiClient.ParameterToString(stageId));
            if (stepId != null) localVarPathParams.Add("stepId", this.Configuration.ApiClient.ParameterToString(stepId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStageStep: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseStageStep: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStageStep: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Step>(localVarStatusCode,
                localVarHeaders,
                (Step) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Step)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Steps. 
        /// 
        /// GetCasemanagementCaseStageSteps is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>StepListing</returns>
        
        public StepListing GetCasemanagementCaseStageSteps (string caseId, string stageId, string before = null, string after = null, string pageSize = null)
        {
             ApiResponse<StepListing> localVarResponse = GetCasemanagementCaseStageStepsWithHttpInfo(caseId, stageId, before, after, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Steps. 
        /// 
        /// GetCasemanagementCaseStageSteps is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>ApiResponse of StepListing</returns>
        
        public ApiResponse< StepListing > GetCasemanagementCaseStageStepsWithHttpInfo (string caseId, string stageId, string before = null, string after = null, string pageSize = null)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseStageSteps");
            // verify the required parameter 'stageId' is set
            if (stageId == null)
                throw new ApiException(400, "Missing required parameter 'stageId' when calling CaseManagementApi->GetCasemanagementCaseStageSteps");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/stages/{stageId}/steps";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));
            if (stageId != null) localVarPathParams.Add("stageId", this.Configuration.ApiClient.ParameterToString(stageId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
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

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStageSteps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseStageSteps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStageSteps: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StepListing>(localVarStatusCode,
                localVarHeaders,
                (StepListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StepListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Steps. 
        /// 
        /// GetCasemanagementCaseStageSteps is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of StepListing</returns>
        
        public async System.Threading.Tasks.Task<StepListing> GetCasemanagementCaseStageStepsAsync (string caseId, string stageId, string before = null, string after = null, string pageSize = null)
        {
             ApiResponse<StepListing> localVarResponse = await GetCasemanagementCaseStageStepsAsyncWithHttpInfo(caseId, stageId, before, after, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Steps. 
        /// 
        /// GetCasemanagementCaseStageSteps is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="stageId">Stage ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of ApiResponse (StepListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<StepListing>> GetCasemanagementCaseStageStepsAsyncWithHttpInfo (string caseId, string stageId, string before = null, string after = null, string pageSize = null)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseStageSteps");
            
            // verify the required parameter 'stageId' is set
            if (stageId == null)
                throw new ApiException(400, "Missing required parameter 'stageId' when calling CaseManagementApi->GetCasemanagementCaseStageSteps");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/stages/{stageId}/steps";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));
            if (stageId != null) localVarPathParams.Add("stageId", this.Configuration.ApiClient.ParameterToString(stageId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
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

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStageSteps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseStageSteps: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStageSteps: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StepListing>(localVarStatusCode,
                localVarHeaders,
                (StepListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StepListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Stages. 
        /// 
        /// GetCasemanagementCaseStages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>StageListing</returns>
        
        public StageListing GetCasemanagementCaseStages (string caseId, string before = null, string after = null, string pageSize = null)
        {
             ApiResponse<StageListing> localVarResponse = GetCasemanagementCaseStagesWithHttpInfo(caseId, before, after, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Stages. 
        /// 
        /// GetCasemanagementCaseStages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>ApiResponse of StageListing</returns>
        
        public ApiResponse< StageListing > GetCasemanagementCaseStagesWithHttpInfo (string caseId, string before = null, string after = null, string pageSize = null)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseStages");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/stages";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
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

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseStages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StageListing>(localVarStatusCode,
                localVarHeaders,
                (StageListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StageListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Stages. 
        /// 
        /// GetCasemanagementCaseStages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of StageListing</returns>
        
        public async System.Threading.Tasks.Task<StageListing> GetCasemanagementCaseStagesAsync (string caseId, string before = null, string after = null, string pageSize = null)
        {
             ApiResponse<StageListing> localVarResponse = await GetCasemanagementCaseStagesAsyncWithHttpInfo(caseId, before, after, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Stages. 
        /// 
        /// GetCasemanagementCaseStages is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <returns>Task of ApiResponse (StageListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<StageListing>> GetCasemanagementCaseStagesAsyncWithHttpInfo (string caseId, string before = null, string after = null, string pageSize = null)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseStages");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/stages";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
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

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers ?? new Dictionary<string, string>();

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseStages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseStages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StageListing>(localVarStatusCode,
                localVarHeaders,
                (StageListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StageListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Terminate Job for a Case. 
        /// 
        /// GetCasemanagementCaseTerminateJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>TerminateJob</returns>
        
        public TerminateJob GetCasemanagementCaseTerminateJob (string caseId, string jobId)
        {
             ApiResponse<TerminateJob> localVarResponse = GetCasemanagementCaseTerminateJobWithHttpInfo(caseId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Terminate Job for a Case. 
        /// 
        /// GetCasemanagementCaseTerminateJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of TerminateJob</returns>
        
        public ApiResponse< TerminateJob > GetCasemanagementCaseTerminateJobWithHttpInfo (string caseId, string jobId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseTerminateJob");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling CaseManagementApi->GetCasemanagementCaseTerminateJob");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/terminate/jobs/{jobId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseTerminateJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseTerminateJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseTerminateJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminateJob>(localVarStatusCode,
                localVarHeaders,
                (TerminateJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminateJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Terminate Job for a Case. 
        /// 
        /// GetCasemanagementCaseTerminateJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of TerminateJob</returns>
        
        public async System.Threading.Tasks.Task<TerminateJob> GetCasemanagementCaseTerminateJobAsync (string caseId, string jobId)
        {
             ApiResponse<TerminateJob> localVarResponse = await GetCasemanagementCaseTerminateJobAsyncWithHttpInfo(caseId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Terminate Job for a Case. 
        /// 
        /// GetCasemanagementCaseTerminateJob is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (TerminateJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TerminateJob>> GetCasemanagementCaseTerminateJobAsyncWithHttpInfo (string caseId, string jobId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->GetCasemanagementCaseTerminateJob");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling CaseManagementApi->GetCasemanagementCaseTerminateJob");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/terminate/jobs/{jobId}";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseTerminateJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseTerminateJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseTerminateJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminateJob>(localVarStatusCode,
                localVarHeaders,
                (TerminateJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminateJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Caseplan. 
        /// 
        /// GetCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Caseplan</returns>
        
        public Caseplan GetCasemanagementCaseplan (string caseplanId)
        {
             ApiResponse<Caseplan> localVarResponse = GetCasemanagementCaseplanWithHttpInfo(caseplanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Caseplan. 
        /// 
        /// GetCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>ApiResponse of Caseplan</returns>
        
        public ApiResponse< Caseplan > GetCasemanagementCaseplanWithHttpInfo (string caseplanId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplan");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Caseplan>(localVarStatusCode,
                localVarHeaders,
                (Caseplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Caseplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Caseplan. 
        /// 
        /// GetCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of Caseplan</returns>
        
        public async System.Threading.Tasks.Task<Caseplan> GetCasemanagementCaseplanAsync (string caseplanId)
        {
             ApiResponse<Caseplan> localVarResponse = await GetCasemanagementCaseplanAsyncWithHttpInfo(caseplanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Caseplan. 
        /// 
        /// GetCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of ApiResponse (Caseplan)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Caseplan>> GetCasemanagementCaseplanAsyncWithHttpInfo (string caseplanId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplan");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Caseplan>(localVarStatusCode,
                localVarHeaders,
                (Caseplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Caseplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Caseplan</returns>
        
        public Caseplan GetCasemanagementCaseplanVersion (string caseplanId, string versionId)
        {
             ApiResponse<Caseplan> localVarResponse = GetCasemanagementCaseplanVersionWithHttpInfo(caseplanId, versionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>ApiResponse of Caseplan</returns>
        
        public ApiResponse< Caseplan > GetCasemanagementCaseplanVersionWithHttpInfo (string caseplanId, string versionId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersion");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Caseplan>(localVarStatusCode,
                localVarHeaders,
                (Caseplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Caseplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of Caseplan</returns>
        
        public async System.Threading.Tasks.Task<Caseplan> GetCasemanagementCaseplanVersionAsync (string caseplanId, string versionId)
        {
             ApiResponse<Caseplan> localVarResponse = await GetCasemanagementCaseplanVersionAsyncWithHttpInfo(caseplanId, versionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersion is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of ApiResponse (Caseplan)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Caseplan>> GetCasemanagementCaseplanVersionAsyncWithHttpInfo (string caseplanId, string versionId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersion");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Caseplan>(localVarStatusCode,
                localVarHeaders,
                (Caseplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Caseplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the dataSchemas for a caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersionDataschemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>CaseplanDataSchemaListing</returns>
        
        public CaseplanDataSchemaListing GetCasemanagementCaseplanVersionDataschemas (string caseplanId, string versionId)
        {
             ApiResponse<CaseplanDataSchemaListing> localVarResponse = GetCasemanagementCaseplanVersionDataschemasWithHttpInfo(caseplanId, versionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the dataSchemas for a caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersionDataschemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>ApiResponse of CaseplanDataSchemaListing</returns>
        
        public ApiResponse< CaseplanDataSchemaListing > GetCasemanagementCaseplanVersionDataschemasWithHttpInfo (string caseplanId, string versionId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionDataschemas");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionDataschemas");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/dataschemas";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionDataschemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionDataschemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionDataschemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseplanDataSchemaListing>(localVarStatusCode,
                localVarHeaders,
                (CaseplanDataSchemaListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseplanDataSchemaListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the dataSchemas for a caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersionDataschemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of CaseplanDataSchemaListing</returns>
        
        public async System.Threading.Tasks.Task<CaseplanDataSchemaListing> GetCasemanagementCaseplanVersionDataschemasAsync (string caseplanId, string versionId)
        {
             ApiResponse<CaseplanDataSchemaListing> localVarResponse = await GetCasemanagementCaseplanVersionDataschemasAsyncWithHttpInfo(caseplanId, versionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the dataSchemas for a caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersionDataschemas is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of ApiResponse (CaseplanDataSchemaListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CaseplanDataSchemaListing>> GetCasemanagementCaseplanVersionDataschemasAsyncWithHttpInfo (string caseplanId, string versionId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionDataschemas");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionDataschemas");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/dataschemas";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionDataschemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionDataschemas: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionDataschemas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseplanDataSchemaListing>(localVarStatusCode,
                localVarHeaders,
                (CaseplanDataSchemaListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseplanDataSchemaListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get the intake settings for a Caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersionIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>IntakeSettingsListing</returns>
        
        public IntakeSettingsListing GetCasemanagementCaseplanVersionIntakesettings (string caseplanId, string versionId)
        {
             ApiResponse<IntakeSettingsListing> localVarResponse = GetCasemanagementCaseplanVersionIntakesettingsWithHttpInfo(caseplanId, versionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the intake settings for a Caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersionIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>ApiResponse of IntakeSettingsListing</returns>
        
        public ApiResponse< IntakeSettingsListing > GetCasemanagementCaseplanVersionIntakesettingsWithHttpInfo (string caseplanId, string versionId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionIntakesettings");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionIntakesettings");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/intakesettings";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionIntakesettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionIntakesettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionIntakesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntakeSettingsListing>(localVarStatusCode,
                localVarHeaders,
                (IntakeSettingsListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntakeSettingsListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get the intake settings for a Caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersionIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of IntakeSettingsListing</returns>
        
        public async System.Threading.Tasks.Task<IntakeSettingsListing> GetCasemanagementCaseplanVersionIntakesettingsAsync (string caseplanId, string versionId)
        {
             ApiResponse<IntakeSettingsListing> localVarResponse = await GetCasemanagementCaseplanVersionIntakesettingsAsyncWithHttpInfo(caseplanId, versionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the intake settings for a Caseplan version. 
        /// 
        /// GetCasemanagementCaseplanVersionIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version of the caseplan</param>
        /// <returns>Task of ApiResponse (IntakeSettingsListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IntakeSettingsListing>> GetCasemanagementCaseplanVersionIntakesettingsAsyncWithHttpInfo (string caseplanId, string versionId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionIntakesettings");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionIntakesettings");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/intakesettings";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionIntakesettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionIntakesettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionIntakesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntakeSettingsListing>(localVarStatusCode,
                localVarHeaders,
                (IntakeSettingsListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntakeSettingsListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Stageplan. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Stageplan</returns>
        
        public Stageplan GetCasemanagementCaseplanVersionStageplan (string caseplanId, string versionId, string stageplanId, List<string> expands = null)
        {
             ApiResponse<Stageplan> localVarResponse = GetCasemanagementCaseplanVersionStageplanWithHttpInfo(caseplanId, versionId, stageplanId, expands);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Stageplan. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of Stageplan</returns>
        
        public ApiResponse< Stageplan > GetCasemanagementCaseplanVersionStageplanWithHttpInfo (string caseplanId, string versionId, string stageplanId, List<string> expands = null)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplan");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplan");
            // verify the required parameter 'stageplanId' is set
            if (stageplanId == null)
                throw new ApiException(400, "Missing required parameter 'stageplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplan");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans/{stageplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));
            if (stageplanId != null) localVarPathParams.Add("stageplanId", this.Configuration.ApiClient.ParameterToString(stageplanId));

            // Query params
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionStageplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stageplan>(localVarStatusCode,
                localVarHeaders,
                (Stageplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stageplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Stageplan. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of Stageplan</returns>
        
        public async System.Threading.Tasks.Task<Stageplan> GetCasemanagementCaseplanVersionStageplanAsync (string caseplanId, string versionId, string stageplanId, List<string> expands = null)
        {
             ApiResponse<Stageplan> localVarResponse = await GetCasemanagementCaseplanVersionStageplanAsyncWithHttpInfo(caseplanId, versionId, stageplanId, expands);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Stageplan. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Stageplan)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Stageplan>> GetCasemanagementCaseplanVersionStageplanAsyncWithHttpInfo (string caseplanId, string versionId, string stageplanId, List<string> expands = null)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplan");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplan");
            
            // verify the required parameter 'stageplanId' is set
            if (stageplanId == null)
                throw new ApiException(400, "Missing required parameter 'stageplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplan");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans/{stageplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));
            if (stageplanId != null) localVarPathParams.Add("stageplanId", this.Configuration.ApiClient.ParameterToString(stageplanId));

            // Query params
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionStageplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stageplan>(localVarStatusCode,
                localVarHeaders,
                (Stageplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stageplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Stepplan. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Stepplan</returns>
        
        public Stepplan GetCasemanagementCaseplanVersionStageplanStepplan (string caseplanId, string versionId, string stageplanId, string stepplanId, List<string> expands = null)
        {
             ApiResponse<Stepplan> localVarResponse = GetCasemanagementCaseplanVersionStageplanStepplanWithHttpInfo(caseplanId, versionId, stageplanId, stepplanId, expands);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Stepplan. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of Stepplan</returns>
        
        public ApiResponse< Stepplan > GetCasemanagementCaseplanVersionStageplanStepplanWithHttpInfo (string caseplanId, string versionId, string stageplanId, string stepplanId, List<string> expands = null)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplan");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplan");
            // verify the required parameter 'stageplanId' is set
            if (stageplanId == null)
                throw new ApiException(400, "Missing required parameter 'stageplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplan");
            // verify the required parameter 'stepplanId' is set
            if (stepplanId == null)
                throw new ApiException(400, "Missing required parameter 'stepplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplan");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans/{stageplanId}/stepplans/{stepplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));
            if (stageplanId != null) localVarPathParams.Add("stageplanId", this.Configuration.ApiClient.ParameterToString(stageplanId));
            if (stepplanId != null) localVarPathParams.Add("stepplanId", this.Configuration.ApiClient.ParameterToString(stepplanId));

            // Query params
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplanStepplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionStageplanStepplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplanStepplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stepplan>(localVarStatusCode,
                localVarHeaders,
                (Stepplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stepplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Stepplan. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of Stepplan</returns>
        
        public async System.Threading.Tasks.Task<Stepplan> GetCasemanagementCaseplanVersionStageplanStepplanAsync (string caseplanId, string versionId, string stageplanId, string stepplanId, List<string> expands = null)
        {
             ApiResponse<Stepplan> localVarResponse = await GetCasemanagementCaseplanVersionStageplanStepplanAsyncWithHttpInfo(caseplanId, versionId, stageplanId, stepplanId, expands);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Stepplan. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Stepplan)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Stepplan>> GetCasemanagementCaseplanVersionStageplanStepplanAsyncWithHttpInfo (string caseplanId, string versionId, string stageplanId, string stepplanId, List<string> expands = null)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplan");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplan");
            
            // verify the required parameter 'stageplanId' is set
            if (stageplanId == null)
                throw new ApiException(400, "Missing required parameter 'stageplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplan");
            
            // verify the required parameter 'stepplanId' is set
            if (stepplanId == null)
                throw new ApiException(400, "Missing required parameter 'stepplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplan");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans/{stageplanId}/stepplans/{stepplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));
            if (stageplanId != null) localVarPathParams.Add("stageplanId", this.Configuration.ApiClient.ParameterToString(stageplanId));
            if (stepplanId != null) localVarPathParams.Add("stepplanId", this.Configuration.ApiClient.ParameterToString(stepplanId));

            // Query params
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplanStepplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionStageplanStepplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplanStepplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stepplan>(localVarStatusCode,
                localVarHeaders,
                (Stepplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stepplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Stepplans. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>StepplanListing</returns>
        
        public StepplanListing GetCasemanagementCaseplanVersionStageplanStepplans (string caseplanId, string versionId, string stageplanId, string before = null, string after = null, string pageSize = null, List<string> expands = null)
        {
             ApiResponse<StepplanListing> localVarResponse = GetCasemanagementCaseplanVersionStageplanStepplansWithHttpInfo(caseplanId, versionId, stageplanId, before, after, pageSize, expands);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Stepplans. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of StepplanListing</returns>
        
        public ApiResponse< StepplanListing > GetCasemanagementCaseplanVersionStageplanStepplansWithHttpInfo (string caseplanId, string versionId, string stageplanId, string before = null, string after = null, string pageSize = null, List<string> expands = null)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplans");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplans");
            // verify the required parameter 'stageplanId' is set
            if (stageplanId == null)
                throw new ApiException(400, "Missing required parameter 'stageplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplans");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans/{stageplanId}/stepplans";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));
            if (stageplanId != null) localVarPathParams.Add("stageplanId", this.Configuration.ApiClient.ParameterToString(stageplanId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplanStepplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionStageplanStepplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplanStepplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StepplanListing>(localVarStatusCode,
                localVarHeaders,
                (StepplanListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StepplanListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Stepplans. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of StepplanListing</returns>
        
        public async System.Threading.Tasks.Task<StepplanListing> GetCasemanagementCaseplanVersionStageplanStepplansAsync (string caseplanId, string versionId, string stageplanId, string before = null, string after = null, string pageSize = null, List<string> expands = null)
        {
             ApiResponse<StepplanListing> localVarResponse = await GetCasemanagementCaseplanVersionStageplanStepplansAsyncWithHttpInfo(caseplanId, versionId, stageplanId, before, after, pageSize, expands);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Stepplans. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplanStepplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (StepplanListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<StepplanListing>> GetCasemanagementCaseplanVersionStageplanStepplansAsyncWithHttpInfo (string caseplanId, string versionId, string stageplanId, string before = null, string after = null, string pageSize = null, List<string> expands = null)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplans");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplans");
            
            // verify the required parameter 'stageplanId' is set
            if (stageplanId == null)
                throw new ApiException(400, "Missing required parameter 'stageplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplanStepplans");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans/{stageplanId}/stepplans";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));
            if (stageplanId != null) localVarPathParams.Add("stageplanId", this.Configuration.ApiClient.ParameterToString(stageplanId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplanStepplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionStageplanStepplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplanStepplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StepplanListing>(localVarStatusCode,
                localVarHeaders,
                (StepplanListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StepplanListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Stageplans. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>StageplanListing</returns>
        
        public StageplanListing GetCasemanagementCaseplanVersionStageplans (string caseplanId, string versionId, string before = null, string after = null, string pageSize = null, List<string> expands = null)
        {
             ApiResponse<StageplanListing> localVarResponse = GetCasemanagementCaseplanVersionStageplansWithHttpInfo(caseplanId, versionId, before, after, pageSize, expands);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Stageplans. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of StageplanListing</returns>
        
        public ApiResponse< StageplanListing > GetCasemanagementCaseplanVersionStageplansWithHttpInfo (string caseplanId, string versionId, string before = null, string after = null, string pageSize = null, List<string> expands = null)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplans");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplans");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionStageplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StageplanListing>(localVarStatusCode,
                localVarHeaders,
                (StageplanListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StageplanListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Stageplans. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of StageplanListing</returns>
        
        public async System.Threading.Tasks.Task<StageplanListing> GetCasemanagementCaseplanVersionStageplansAsync (string caseplanId, string versionId, string before = null, string after = null, string pageSize = null, List<string> expands = null)
        {
             ApiResponse<StageplanListing> localVarResponse = await GetCasemanagementCaseplanVersionStageplansAsyncWithHttpInfo(caseplanId, versionId, before, after, pageSize, expands);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Stageplans. 
        /// 
        /// GetCasemanagementCaseplanVersionStageplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="before">The cursor that points to the start of the set of entities that has been returned. (optional)</param>
        /// <param name="after">The cursor that points to the end of the set of entities that has been returned. (optional)</param>
        /// <param name="pageSize">Number of entities to return. Maximum of 200. (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (StageplanListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<StageplanListing>> GetCasemanagementCaseplanVersionStageplansAsyncWithHttpInfo (string caseplanId, string versionId, string before = null, string after = null, string pageSize = null, List<string> expands = null)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplans");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling CaseManagementApi->GetCasemanagementCaseplanVersionStageplans");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions/{versionId}/stageplans";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

            // Query params
            if (before != null) localVarQueryParams.Add(new Tuple<string, string>("before", this.Configuration.ApiClient.ParameterToString(before)));
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplanVersionStageplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplanVersionStageplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StageplanListing>(localVarStatusCode,
                localVarHeaders,
                (StageplanListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StageplanListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of Caseplans. 
        /// 
        /// GetCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of caseplans that has been returned. (optional)</param>
        /// <param name="pageSize">Number of caseplans to return. Maximum of 200. (optional)</param>
        /// <param name="customerIntentId">Filter by Customer Intent. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions. (optional)</param>
        /// <returns>CaseplanListing</returns>
        
        public CaseplanListing GetCasemanagementCaseplans (string after = null, int? pageSize = null, string customerIntentId = null, string divisionIds = null)
        {
             ApiResponse<CaseplanListing> localVarResponse = GetCasemanagementCaseplansWithHttpInfo(after, pageSize, customerIntentId, divisionIds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Caseplans. 
        /// 
        /// GetCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of caseplans that has been returned. (optional)</param>
        /// <param name="pageSize">Number of caseplans to return. Maximum of 200. (optional)</param>
        /// <param name="customerIntentId">Filter by Customer Intent. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions. (optional)</param>
        /// <returns>ApiResponse of CaseplanListing</returns>
        
        public ApiResponse< CaseplanListing > GetCasemanagementCaseplansWithHttpInfo (string after = null, int? pageSize = null, string customerIntentId = null, string divisionIds = null)
        { 

            var localVarPath = "/api/v2/casemanagement/caseplans";
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
            if (customerIntentId != null) localVarQueryParams.Add(new Tuple<string, string>("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId)));
            if (divisionIds != null) localVarQueryParams.Add(new Tuple<string, string>("divisionIds", this.Configuration.ApiClient.ParameterToString(divisionIds)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseplanListing>(localVarStatusCode,
                localVarHeaders,
                (CaseplanListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseplanListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of Caseplans. 
        /// 
        /// GetCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of caseplans that has been returned. (optional)</param>
        /// <param name="pageSize">Number of caseplans to return. Maximum of 200. (optional)</param>
        /// <param name="customerIntentId">Filter by Customer Intent. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions. (optional)</param>
        /// <returns>Task of CaseplanListing</returns>
        
        public async System.Threading.Tasks.Task<CaseplanListing> GetCasemanagementCaseplansAsync (string after = null, int? pageSize = null, string customerIntentId = null, string divisionIds = null)
        {
             ApiResponse<CaseplanListing> localVarResponse = await GetCasemanagementCaseplansAsyncWithHttpInfo(after, pageSize, customerIntentId, divisionIds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Caseplans. 
        /// 
        /// GetCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">The cursor that points to the end of the set of caseplans that has been returned. (optional)</param>
        /// <param name="pageSize">Number of caseplans to return. Maximum of 200. (optional)</param>
        /// <param name="customerIntentId">Filter by Customer Intent. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions. (optional)</param>
        /// <returns>Task of ApiResponse (CaseplanListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CaseplanListing>> GetCasemanagementCaseplansAsyncWithHttpInfo (string after = null, int? pageSize = null, string customerIntentId = null, string divisionIds = null)
        { 

            var localVarPath = "/api/v2/casemanagement/caseplans";
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
            if (customerIntentId != null) localVarQueryParams.Add(new Tuple<string, string>("customerIntentId", this.Configuration.ApiClient.ParameterToString(customerIntentId)));
            if (divisionIds != null) localVarQueryParams.Add(new Tuple<string, string>("divisionIds", this.Configuration.ApiClient.ParameterToString(divisionIds)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCaseplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCaseplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseplanListing>(localVarStatusCode,
                localVarHeaders,
                (CaseplanListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseplanListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a list of cases for provided external contact id. 
        /// 
        /// GetCasemanagementCasesExternalcontact is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact ID</param>
        /// <param name="after">The cursor that points to the end of the set of cases that has been returned. (optional)</param>
        /// <param name="pageSize">Number of cases to return. Maximum of 200. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>CaseListing</returns>
        
        public CaseListing GetCasemanagementCasesExternalcontact (string externalContactId, string after = null, int? pageSize = null, string divisionIds = null, List<string> expands = null)
        {
             ApiResponse<CaseListing> localVarResponse = GetCasemanagementCasesExternalcontactWithHttpInfo(externalContactId, after, pageSize, divisionIds, expands);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of cases for provided external contact id. 
        /// 
        /// GetCasemanagementCasesExternalcontact is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact ID</param>
        /// <param name="after">The cursor that points to the end of the set of cases that has been returned. (optional)</param>
        /// <param name="pageSize">Number of cases to return. Maximum of 200. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of CaseListing</returns>
        
        public ApiResponse< CaseListing > GetCasemanagementCasesExternalcontactWithHttpInfo (string externalContactId, string after = null, int? pageSize = null, string divisionIds = null, List<string> expands = null)
        { 
            // verify the required parameter 'externalContactId' is set
            if (externalContactId == null)
                throw new ApiException(400, "Missing required parameter 'externalContactId' when calling CaseManagementApi->GetCasemanagementCasesExternalcontact");

            var localVarPath = "/api/v2/casemanagement/cases/externalcontacts/{externalContactId}";
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
            if (externalContactId != null) localVarPathParams.Add("externalContactId", this.Configuration.ApiClient.ParameterToString(externalContactId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (divisionIds != null) localVarQueryParams.Add(new Tuple<string, string>("divisionIds", this.Configuration.ApiClient.ParameterToString(divisionIds)));
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCasesExternalcontact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCasesExternalcontact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCasesExternalcontact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseListing>(localVarStatusCode,
                localVarHeaders,
                (CaseListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a list of cases for provided external contact id. 
        /// 
        /// GetCasemanagementCasesExternalcontact is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact ID</param>
        /// <param name="after">The cursor that points to the end of the set of cases that has been returned. (optional)</param>
        /// <param name="pageSize">Number of cases to return. Maximum of 200. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of CaseListing</returns>
        
        public async System.Threading.Tasks.Task<CaseListing> GetCasemanagementCasesExternalcontactAsync (string externalContactId, string after = null, int? pageSize = null, string divisionIds = null, List<string> expands = null)
        {
             ApiResponse<CaseListing> localVarResponse = await GetCasemanagementCasesExternalcontactAsyncWithHttpInfo(externalContactId, after, pageSize, divisionIds, expands);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of cases for provided external contact id. 
        /// 
        /// GetCasemanagementCasesExternalcontact is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalContactId">External Contact ID</param>
        /// <param name="after">The cursor that points to the end of the set of cases that has been returned. (optional)</param>
        /// <param name="pageSize">Number of cases to return. Maximum of 200. (optional)</param>
        /// <param name="divisionIds">Filter by Divisions (optional)</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (CaseListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CaseListing>> GetCasemanagementCasesExternalcontactAsyncWithHttpInfo (string externalContactId, string after = null, int? pageSize = null, string divisionIds = null, List<string> expands = null)
        { 
            // verify the required parameter 'externalContactId' is set
            if (externalContactId == null)
                throw new ApiException(400, "Missing required parameter 'externalContactId' when calling CaseManagementApi->GetCasemanagementCasesExternalcontact");
            

            var localVarPath = "/api/v2/casemanagement/cases/externalcontacts/{externalContactId}";
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
            if (externalContactId != null) localVarPathParams.Add("externalContactId", this.Configuration.ApiClient.ParameterToString(externalContactId));

            // Query params
            if (after != null) localVarQueryParams.Add(new Tuple<string, string>("after", this.Configuration.ApiClient.ParameterToString(after)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (divisionIds != null) localVarQueryParams.Add(new Tuple<string, string>("divisionIds", this.Configuration.ApiClient.ParameterToString(divisionIds)));
            if (expands != null) expands.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCasesExternalcontact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCasesExternalcontact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCasesExternalcontact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseListing>(localVarStatusCode,
                localVarHeaders,
                (CaseListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Get a Case by reference. 
        /// 
        /// GetCasemanagementCasesReference is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceId">Reference</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Case</returns>
        
        public Case GetCasemanagementCasesReference (string referenceId, string expands = null)
        {
             ApiResponse<Case> localVarResponse = GetCasemanagementCasesReferenceWithHttpInfo(referenceId, expands);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Case by reference. 
        /// 
        /// GetCasemanagementCasesReference is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceId">Reference</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>ApiResponse of Case</returns>
        
        public ApiResponse< Case > GetCasemanagementCasesReferenceWithHttpInfo (string referenceId, string expands = null)
        { 
            // verify the required parameter 'referenceId' is set
            if (referenceId == null)
                throw new ApiException(400, "Missing required parameter 'referenceId' when calling CaseManagementApi->GetCasemanagementCasesReference");

            var localVarPath = "/api/v2/casemanagement/cases/references/{referenceId}";
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
            if (referenceId != null) localVarPathParams.Add("referenceId", this.Configuration.ApiClient.ParameterToString(referenceId));

            // Query params
            if (expands != null) localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(expands)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCasesReference: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCasesReference: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCasesReference: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Get a Case by reference. 
        /// 
        /// GetCasemanagementCasesReference is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceId">Reference</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of Case</returns>
        
        public async System.Threading.Tasks.Task<Case> GetCasemanagementCasesReferenceAsync (string referenceId, string expands = null)
        {
             ApiResponse<Case> localVarResponse = await GetCasemanagementCasesReferenceAsyncWithHttpInfo(referenceId, expands);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Case by reference. 
        /// 
        /// GetCasemanagementCasesReference is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceId">Reference</param>
        /// <param name="expands">Which fields to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Case>> GetCasemanagementCasesReferenceAsyncWithHttpInfo (string referenceId, string expands = null)
        { 
            // verify the required parameter 'referenceId' is set
            if (referenceId == null)
                throw new ApiException(400, "Missing required parameter 'referenceId' when calling CaseManagementApi->GetCasemanagementCasesReference");
            

            var localVarPath = "/api/v2/casemanagement/cases/references/{referenceId}";
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
            if (referenceId != null) localVarPathParams.Add("referenceId", this.Configuration.ApiClient.ParameterToString(referenceId));

            // Query params
            if (expands != null) localVarQueryParams.Add(new Tuple<string, string>("expands", this.Configuration.ApiClient.ParameterToString(expands)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCasesReference: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling GetCasemanagementCasesReference: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCasemanagementCasesReference: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update date due of a Case. 
        /// 
        /// PatchCasemanagementCaseDatedue is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Date due</param>
        /// <returns>Case</returns>
        
        public Case PatchCasemanagementCaseDatedue (string caseId, CaseDateDueUpdate body)
        {
             ApiResponse<Case> localVarResponse = PatchCasemanagementCaseDatedueWithHttpInfo(caseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update date due of a Case. 
        /// 
        /// PatchCasemanagementCaseDatedue is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Date due</param>
        /// <returns>ApiResponse of Case</returns>
        
        public ApiResponse< Case > PatchCasemanagementCaseDatedueWithHttpInfo (string caseId, CaseDateDueUpdate body)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->PatchCasemanagementCaseDatedue");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCaseDatedue");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/datedue";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseDatedue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCaseDatedue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseDatedue: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update date due of a Case. 
        /// 
        /// PatchCasemanagementCaseDatedue is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Date due</param>
        /// <returns>Task of Case</returns>
        
        public async System.Threading.Tasks.Task<Case> PatchCasemanagementCaseDatedueAsync (string caseId, CaseDateDueUpdate body)
        {
             ApiResponse<Case> localVarResponse = await PatchCasemanagementCaseDatedueAsyncWithHttpInfo(caseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update date due of a Case. 
        /// 
        /// PatchCasemanagementCaseDatedue is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Date due</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Case>> PatchCasemanagementCaseDatedueAsyncWithHttpInfo (string caseId, CaseDateDueUpdate body)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->PatchCasemanagementCaseDatedue");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCaseDatedue");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/datedue";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseDatedue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCaseDatedue: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseDatedue: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update priority of a Case. 
        /// 
        /// PatchCasemanagementCasePriority is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Priority</param>
        /// <returns>Case</returns>
        
        public Case PatchCasemanagementCasePriority (string caseId, CasePriorityUpdate body)
        {
             ApiResponse<Case> localVarResponse = PatchCasemanagementCasePriorityWithHttpInfo(caseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update priority of a Case. 
        /// 
        /// PatchCasemanagementCasePriority is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Priority</param>
        /// <returns>ApiResponse of Case</returns>
        
        public ApiResponse< Case > PatchCasemanagementCasePriorityWithHttpInfo (string caseId, CasePriorityUpdate body)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->PatchCasemanagementCasePriority");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCasePriority");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/priority";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCasePriority: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCasePriority: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCasePriority: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update priority of a Case. 
        /// 
        /// PatchCasemanagementCasePriority is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Priority</param>
        /// <returns>Task of Case</returns>
        
        public async System.Threading.Tasks.Task<Case> PatchCasemanagementCasePriorityAsync (string caseId, CasePriorityUpdate body)
        {
             ApiResponse<Case> localVarResponse = await PatchCasemanagementCasePriorityAsyncWithHttpInfo(caseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update priority of a Case. 
        /// 
        /// PatchCasemanagementCasePriority is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Priority</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Case>> PatchCasemanagementCasePriorityAsyncWithHttpInfo (string caseId, CasePriorityUpdate body)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->PatchCasemanagementCasePriority");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCasePriority");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/priority";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCasePriority: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCasePriority: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCasePriority: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update summary of a Case. 
        /// 
        /// PatchCasemanagementCaseSummary is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Summary</param>
        /// <returns>Case</returns>
        
        public Case PatchCasemanagementCaseSummary (string caseId, CaseSummaryUpdate body)
        {
             ApiResponse<Case> localVarResponse = PatchCasemanagementCaseSummaryWithHttpInfo(caseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update summary of a Case. 
        /// 
        /// PatchCasemanagementCaseSummary is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Summary</param>
        /// <returns>ApiResponse of Case</returns>
        
        public ApiResponse< Case > PatchCasemanagementCaseSummaryWithHttpInfo (string caseId, CaseSummaryUpdate body)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->PatchCasemanagementCaseSummary");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCaseSummary");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/summary";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseSummary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCaseSummary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update summary of a Case. 
        /// 
        /// PatchCasemanagementCaseSummary is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Summary</param>
        /// <returns>Task of Case</returns>
        
        public async System.Threading.Tasks.Task<Case> PatchCasemanagementCaseSummaryAsync (string caseId, CaseSummaryUpdate body)
        {
             ApiResponse<Case> localVarResponse = await PatchCasemanagementCaseSummaryAsyncWithHttpInfo(caseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update summary of a Case. 
        /// 
        /// PatchCasemanagementCaseSummary is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <param name="body">Summary</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Case>> PatchCasemanagementCaseSummaryAsyncWithHttpInfo (string caseId, CaseSummaryUpdate body)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->PatchCasemanagementCaseSummary");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCaseSummary");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/summary";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseSummary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCaseSummary: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseSummary: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the attributes of a Caseplan. 
        /// 
        /// PatchCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Caseplan</param>
        /// <returns>Caseplan</returns>
        
        public Caseplan PatchCasemanagementCaseplan (string caseplanId, CaseplanUpdate body)
        {
             ApiResponse<Caseplan> localVarResponse = PatchCasemanagementCaseplanWithHttpInfo(caseplanId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the attributes of a Caseplan. 
        /// 
        /// PatchCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Caseplan</param>
        /// <returns>ApiResponse of Caseplan</returns>
        
        public ApiResponse< Caseplan > PatchCasemanagementCaseplanWithHttpInfo (string caseplanId, CaseplanUpdate body)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PatchCasemanagementCaseplan");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCaseplan");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Caseplan>(localVarStatusCode,
                localVarHeaders,
                (Caseplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Caseplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the attributes of a Caseplan. 
        /// 
        /// PatchCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Caseplan</param>
        /// <returns>Task of Caseplan</returns>
        
        public async System.Threading.Tasks.Task<Caseplan> PatchCasemanagementCaseplanAsync (string caseplanId, CaseplanUpdate body)
        {
             ApiResponse<Caseplan> localVarResponse = await PatchCasemanagementCaseplanAsyncWithHttpInfo(caseplanId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the attributes of a Caseplan. 
        /// 
        /// PatchCasemanagementCaseplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Caseplan</param>
        /// <returns>Task of ApiResponse (Caseplan)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Caseplan>> PatchCasemanagementCaseplanAsyncWithHttpInfo (string caseplanId, CaseplanUpdate body)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PatchCasemanagementCaseplan");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCaseplan");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCaseplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Caseplan>(localVarStatusCode,
                localVarHeaders,
                (Caseplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Caseplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the attributes of a Stageplan. 
        /// 
        /// PatchCasemanagementCaseplanStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="body">Stageplan</param>
        /// <returns>Stageplan</returns>
        
        public Stageplan PatchCasemanagementCaseplanStageplan (string caseplanId, string stageplanId, StageplanUpdate body)
        {
             ApiResponse<Stageplan> localVarResponse = PatchCasemanagementCaseplanStageplanWithHttpInfo(caseplanId, stageplanId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the attributes of a Stageplan. 
        /// 
        /// PatchCasemanagementCaseplanStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="body">Stageplan</param>
        /// <returns>ApiResponse of Stageplan</returns>
        
        public ApiResponse< Stageplan > PatchCasemanagementCaseplanStageplanWithHttpInfo (string caseplanId, string stageplanId, StageplanUpdate body)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplan");
            // verify the required parameter 'stageplanId' is set
            if (stageplanId == null)
                throw new ApiException(400, "Missing required parameter 'stageplanId' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplan");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplan");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/stageplans/{stageplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (stageplanId != null) localVarPathParams.Add("stageplanId", this.Configuration.ApiClient.ParameterToString(stageplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplanStageplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCaseplanStageplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplanStageplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stageplan>(localVarStatusCode,
                localVarHeaders,
                (Stageplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stageplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the attributes of a Stageplan. 
        /// 
        /// PatchCasemanagementCaseplanStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="body">Stageplan</param>
        /// <returns>Task of Stageplan</returns>
        
        public async System.Threading.Tasks.Task<Stageplan> PatchCasemanagementCaseplanStageplanAsync (string caseplanId, string stageplanId, StageplanUpdate body)
        {
             ApiResponse<Stageplan> localVarResponse = await PatchCasemanagementCaseplanStageplanAsyncWithHttpInfo(caseplanId, stageplanId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the attributes of a Stageplan. 
        /// 
        /// PatchCasemanagementCaseplanStageplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="body">Stageplan</param>
        /// <returns>Task of ApiResponse (Stageplan)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Stageplan>> PatchCasemanagementCaseplanStageplanAsyncWithHttpInfo (string caseplanId, string stageplanId, StageplanUpdate body)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplan");
            
            // verify the required parameter 'stageplanId' is set
            if (stageplanId == null)
                throw new ApiException(400, "Missing required parameter 'stageplanId' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplan");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplan");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/stageplans/{stageplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (stageplanId != null) localVarPathParams.Add("stageplanId", this.Configuration.ApiClient.ParameterToString(stageplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplanStageplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCaseplanStageplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplanStageplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stageplan>(localVarStatusCode,
                localVarHeaders,
                (Stageplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stageplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the attributes of a Stepplan. 
        /// 
        /// PatchCasemanagementCaseplanStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="body">Stepplan</param>
        /// <returns>Stepplan</returns>
        
        public Stepplan PatchCasemanagementCaseplanStageplanStepplan (string caseplanId, string stageplanId, string stepplanId, StepplanUpdate body)
        {
             ApiResponse<Stepplan> localVarResponse = PatchCasemanagementCaseplanStageplanStepplanWithHttpInfo(caseplanId, stageplanId, stepplanId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the attributes of a Stepplan. 
        /// 
        /// PatchCasemanagementCaseplanStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="body">Stepplan</param>
        /// <returns>ApiResponse of Stepplan</returns>
        
        public ApiResponse< Stepplan > PatchCasemanagementCaseplanStageplanStepplanWithHttpInfo (string caseplanId, string stageplanId, string stepplanId, StepplanUpdate body)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplanStepplan");
            // verify the required parameter 'stageplanId' is set
            if (stageplanId == null)
                throw new ApiException(400, "Missing required parameter 'stageplanId' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplanStepplan");
            // verify the required parameter 'stepplanId' is set
            if (stepplanId == null)
                throw new ApiException(400, "Missing required parameter 'stepplanId' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplanStepplan");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplanStepplan");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/stageplans/{stageplanId}/stepplans/{stepplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (stageplanId != null) localVarPathParams.Add("stageplanId", this.Configuration.ApiClient.ParameterToString(stageplanId));
            if (stepplanId != null) localVarPathParams.Add("stepplanId", this.Configuration.ApiClient.ParameterToString(stepplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplanStageplanStepplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCaseplanStageplanStepplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplanStageplanStepplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stepplan>(localVarStatusCode,
                localVarHeaders,
                (Stepplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stepplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the attributes of a Stepplan. 
        /// 
        /// PatchCasemanagementCaseplanStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="body">Stepplan</param>
        /// <returns>Task of Stepplan</returns>
        
        public async System.Threading.Tasks.Task<Stepplan> PatchCasemanagementCaseplanStageplanStepplanAsync (string caseplanId, string stageplanId, string stepplanId, StepplanUpdate body)
        {
             ApiResponse<Stepplan> localVarResponse = await PatchCasemanagementCaseplanStageplanStepplanAsyncWithHttpInfo(caseplanId, stageplanId, stepplanId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the attributes of a Stepplan. 
        /// 
        /// PatchCasemanagementCaseplanStageplanStepplan is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="stageplanId">Stageplan ID</param>
        /// <param name="stepplanId">Stepplan ID</param>
        /// <param name="body">Stepplan</param>
        /// <returns>Task of ApiResponse (Stepplan)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Stepplan>> PatchCasemanagementCaseplanStageplanStepplanAsyncWithHttpInfo (string caseplanId, string stageplanId, string stepplanId, StepplanUpdate body)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplanStepplan");
            
            // verify the required parameter 'stageplanId' is set
            if (stageplanId == null)
                throw new ApiException(400, "Missing required parameter 'stageplanId' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplanStepplan");
            
            // verify the required parameter 'stepplanId' is set
            if (stepplanId == null)
                throw new ApiException(400, "Missing required parameter 'stepplanId' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplanStepplan");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PatchCasemanagementCaseplanStageplanStepplan");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/stageplans/{stageplanId}/stepplans/{stepplanId}";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));
            if (stageplanId != null) localVarPathParams.Add("stageplanId", this.Configuration.ApiClient.ParameterToString(stageplanId));
            if (stepplanId != null) localVarPathParams.Add("stepplanId", this.Configuration.ApiClient.ParameterToString(stepplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplanStageplanStepplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PatchCasemanagementCaseplanStageplanStepplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCasemanagementCaseplanStageplanStepplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Stepplan>(localVarStatusCode,
                localVarHeaders,
                (Stepplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Stepplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a case association. 
        /// 
        /// PostCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>CaseAssociation</returns>
        
        public CaseAssociation PostCasemanagementCaseAssociations (string caseId, CaseAssociationCreate body = null)
        {
             ApiResponse<CaseAssociation> localVarResponse = PostCasemanagementCaseAssociationsWithHttpInfo(caseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a case association. 
        /// 
        /// PostCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>ApiResponse of CaseAssociation</returns>
        
        public ApiResponse< CaseAssociation > PostCasemanagementCaseAssociationsWithHttpInfo (string caseId, CaseAssociationCreate body = null)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->PostCasemanagementCaseAssociations");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/associations";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseAssociations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCaseAssociations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseAssociations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseAssociation>(localVarStatusCode,
                localVarHeaders,
                (CaseAssociation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseAssociation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a case association. 
        /// 
        /// PostCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>Task of CaseAssociation</returns>
        
        public async System.Threading.Tasks.Task<CaseAssociation> PostCasemanagementCaseAssociationsAsync (string caseId, CaseAssociationCreate body = null)
        {
             ApiResponse<CaseAssociation> localVarResponse = await PostCasemanagementCaseAssociationsAsyncWithHttpInfo(caseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a case association. 
        /// 
        /// PostCasemanagementCaseAssociations is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID.</param>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>Task of ApiResponse (CaseAssociation)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CaseAssociation>> PostCasemanagementCaseAssociationsAsyncWithHttpInfo (string caseId, CaseAssociationCreate body = null)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->PostCasemanagementCaseAssociations");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/associations";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseAssociations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCaseAssociations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseAssociations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseAssociation>(localVarStatusCode,
                localVarHeaders,
                (CaseAssociation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseAssociation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a Terminate Job for a Case. 
        /// 
        /// PostCasemanagementCaseTerminateJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>TerminateJob</returns>
        
        public TerminateJob PostCasemanagementCaseTerminateJobs (string caseId)
        {
             ApiResponse<TerminateJob> localVarResponse = PostCasemanagementCaseTerminateJobsWithHttpInfo(caseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Terminate Job for a Case. 
        /// 
        /// PostCasemanagementCaseTerminateJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>ApiResponse of TerminateJob</returns>
        
        public ApiResponse< TerminateJob > PostCasemanagementCaseTerminateJobsWithHttpInfo (string caseId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->PostCasemanagementCaseTerminateJobs");

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/terminate/jobs";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseTerminateJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCaseTerminateJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseTerminateJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminateJob>(localVarStatusCode,
                localVarHeaders,
                (TerminateJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminateJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a Terminate Job for a Case. 
        /// 
        /// PostCasemanagementCaseTerminateJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>Task of TerminateJob</returns>
        
        public async System.Threading.Tasks.Task<TerminateJob> PostCasemanagementCaseTerminateJobsAsync (string caseId)
        {
             ApiResponse<TerminateJob> localVarResponse = await PostCasemanagementCaseTerminateJobsAsyncWithHttpInfo(caseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Terminate Job for a Case. 
        /// 
        /// PostCasemanagementCaseTerminateJobs is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId">Case ID</param>
        /// <returns>Task of ApiResponse (TerminateJob)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<TerminateJob>> PostCasemanagementCaseTerminateJobsAsyncWithHttpInfo (string caseId)
        { 
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling CaseManagementApi->PostCasemanagementCaseTerminateJobs");
            

            var localVarPath = "/api/v2/casemanagement/cases/{caseId}/terminate/jobs";
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
            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseTerminateJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCaseTerminateJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseTerminateJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminateJob>(localVarStatusCode,
                localVarHeaders,
                (TerminateJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminateJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Publish Caseplan. 
        /// 
        /// PostCasemanagementCaseplanPublish is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Caseplan</returns>
        
        public Caseplan PostCasemanagementCaseplanPublish (string caseplanId)
        {
             ApiResponse<Caseplan> localVarResponse = PostCasemanagementCaseplanPublishWithHttpInfo(caseplanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish Caseplan. 
        /// 
        /// PostCasemanagementCaseplanPublish is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>ApiResponse of Caseplan</returns>
        
        public ApiResponse< Caseplan > PostCasemanagementCaseplanPublishWithHttpInfo (string caseplanId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PostCasemanagementCaseplanPublish");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/publish";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplanPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCaseplanPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplanPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Caseplan>(localVarStatusCode,
                localVarHeaders,
                (Caseplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Caseplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Publish Caseplan. 
        /// 
        /// PostCasemanagementCaseplanPublish is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of Caseplan</returns>
        
        public async System.Threading.Tasks.Task<Caseplan> PostCasemanagementCaseplanPublishAsync (string caseplanId)
        {
             ApiResponse<Caseplan> localVarResponse = await PostCasemanagementCaseplanPublishAsyncWithHttpInfo(caseplanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish Caseplan. 
        /// 
        /// PostCasemanagementCaseplanPublish is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of ApiResponse (Caseplan)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Caseplan>> PostCasemanagementCaseplanPublishAsyncWithHttpInfo (string caseplanId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PostCasemanagementCaseplanPublish");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/publish";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplanPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCaseplanPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplanPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Caseplan>(localVarStatusCode,
                localVarHeaders,
                (Caseplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Caseplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create Caseplan version. 
        /// 
        /// PostCasemanagementCaseplanVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Caseplan</returns>
        
        public Caseplan PostCasemanagementCaseplanVersions (string caseplanId)
        {
             ApiResponse<Caseplan> localVarResponse = PostCasemanagementCaseplanVersionsWithHttpInfo(caseplanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Caseplan version. 
        /// 
        /// PostCasemanagementCaseplanVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>ApiResponse of Caseplan</returns>
        
        public ApiResponse< Caseplan > PostCasemanagementCaseplanVersionsWithHttpInfo (string caseplanId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PostCasemanagementCaseplanVersions");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplanVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCaseplanVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplanVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Caseplan>(localVarStatusCode,
                localVarHeaders,
                (Caseplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Caseplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create Caseplan version. 
        /// 
        /// PostCasemanagementCaseplanVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of Caseplan</returns>
        
        public async System.Threading.Tasks.Task<Caseplan> PostCasemanagementCaseplanVersionsAsync (string caseplanId)
        {
             ApiResponse<Caseplan> localVarResponse = await PostCasemanagementCaseplanVersionsAsyncWithHttpInfo(caseplanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Caseplan version. 
        /// 
        /// PostCasemanagementCaseplanVersions is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <returns>Task of ApiResponse (Caseplan)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Caseplan>> PostCasemanagementCaseplanVersionsAsyncWithHttpInfo (string caseplanId)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PostCasemanagementCaseplanVersions");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/versions";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplanVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCaseplanVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplanVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Caseplan>(localVarStatusCode,
                localVarHeaders,
                (Caseplan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Caseplan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a Caseplan. 
        /// 
        /// PostCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Caseplan</param>
        /// <returns>CaseplanCreateResponse</returns>
        
        public CaseplanCreateResponse PostCasemanagementCaseplans (CaseplanCreate body)
        {
             ApiResponse<CaseplanCreateResponse> localVarResponse = PostCasemanagementCaseplansWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Caseplan. 
        /// 
        /// PostCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Caseplan</param>
        /// <returns>ApiResponse of CaseplanCreateResponse</returns>
        
        public ApiResponse< CaseplanCreateResponse > PostCasemanagementCaseplansWithHttpInfo (CaseplanCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PostCasemanagementCaseplans");

            var localVarPath = "/api/v2/casemanagement/caseplans";
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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCaseplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseplanCreateResponse>(localVarStatusCode,
                localVarHeaders,
                (CaseplanCreateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseplanCreateResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a Caseplan. 
        /// 
        /// PostCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Caseplan</param>
        /// <returns>Task of CaseplanCreateResponse</returns>
        
        public async System.Threading.Tasks.Task<CaseplanCreateResponse> PostCasemanagementCaseplansAsync (CaseplanCreate body)
        {
             ApiResponse<CaseplanCreateResponse> localVarResponse = await PostCasemanagementCaseplansAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Caseplan. 
        /// 
        /// PostCasemanagementCaseplans is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Caseplan</param>
        /// <returns>Task of ApiResponse (CaseplanCreateResponse)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CaseplanCreateResponse>> PostCasemanagementCaseplansAsyncWithHttpInfo (CaseplanCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PostCasemanagementCaseplans");
            

            var localVarPath = "/api/v2/casemanagement/caseplans";
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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCaseplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCaseplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseplanCreateResponse>(localVarStatusCode,
                localVarHeaders,
                (CaseplanCreateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseplanCreateResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a Case. 
        /// 
        /// PostCasemanagementCases is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case</param>
        /// <returns>Case</returns>
        
        public Case PostCasemanagementCases (CaseCreate body)
        {
             ApiResponse<Case> localVarResponse = PostCasemanagementCasesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Case. 
        /// 
        /// PostCasemanagementCases is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case</param>
        /// <returns>ApiResponse of Case</returns>
        
        public ApiResponse< Case > PostCasemanagementCasesWithHttpInfo (CaseCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PostCasemanagementCases");

            var localVarPath = "/api/v2/casemanagement/cases";
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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCases: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCases: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a Case. 
        /// 
        /// PostCasemanagementCases is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case</param>
        /// <returns>Task of Case</returns>
        
        public async System.Threading.Tasks.Task<Case> PostCasemanagementCasesAsync (CaseCreate body)
        {
             ApiResponse<Case> localVarResponse = await PostCasemanagementCasesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Case. 
        /// 
        /// PostCasemanagementCases is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case</param>
        /// <returns>Task of ApiResponse (Case)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<Case>> PostCasemanagementCasesAsyncWithHttpInfo (CaseCreate body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PostCasemanagementCases");
            

            var localVarPath = "/api/v2/casemanagement/cases";
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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCases: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCases: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Case>(localVarStatusCode,
                localVarHeaders,
                (Case) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Case)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Query for case associations 
        /// 
        /// PostCasemanagementCasesAssociationsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>CaseAssociationQueryEntityListing</returns>
        
        public CaseAssociationQueryEntityListing PostCasemanagementCasesAssociationsQuery (CaseAssociationQuery body = null)
        {
             ApiResponse<CaseAssociationQueryEntityListing> localVarResponse = PostCasemanagementCasesAssociationsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for case associations 
        /// 
        /// PostCasemanagementCasesAssociationsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>ApiResponse of CaseAssociationQueryEntityListing</returns>
        
        public ApiResponse< CaseAssociationQueryEntityListing > PostCasemanagementCasesAssociationsQueryWithHttpInfo (CaseAssociationQuery body = null)
        { 

            var localVarPath = "/api/v2/casemanagement/cases/associations/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCasesAssociationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCasesAssociationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCasesAssociationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseAssociationQueryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CaseAssociationQueryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseAssociationQueryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Query for case associations 
        /// 
        /// PostCasemanagementCasesAssociationsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>Task of CaseAssociationQueryEntityListing</returns>
        
        public async System.Threading.Tasks.Task<CaseAssociationQueryEntityListing> PostCasemanagementCasesAssociationsQueryAsync (CaseAssociationQuery body = null)
        {
             ApiResponse<CaseAssociationQueryEntityListing> localVarResponse = await PostCasemanagementCasesAssociationsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for case associations 
        /// 
        /// PostCasemanagementCasesAssociationsQuery is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Case Association (optional)</param>
        /// <returns>Task of ApiResponse (CaseAssociationQueryEntityListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<CaseAssociationQueryEntityListing>> PostCasemanagementCasesAssociationsQueryAsyncWithHttpInfo (CaseAssociationQuery body = null)
        { 

            var localVarPath = "/api/v2/casemanagement/cases/associations/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCasesAssociationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PostCasemanagementCasesAssociationsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCasemanagementCasesAssociationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaseAssociationQueryEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CaseAssociationQueryEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseAssociationQueryEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update the intake settings for a Caseplan. 
        /// 
        /// PutCasemanagementCaseplanIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Intake Settings</param>
        /// <returns>IntakeSettingsListing</returns>
        
        public IntakeSettingsListing PutCasemanagementCaseplanIntakesettings (string caseplanId, IntakeSettingsUpdate body)
        {
             ApiResponse<IntakeSettingsListing> localVarResponse = PutCasemanagementCaseplanIntakesettingsWithHttpInfo(caseplanId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the intake settings for a Caseplan. 
        /// 
        /// PutCasemanagementCaseplanIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Intake Settings</param>
        /// <returns>ApiResponse of IntakeSettingsListing</returns>
        
        public ApiResponse< IntakeSettingsListing > PutCasemanagementCaseplanIntakesettingsWithHttpInfo (string caseplanId, IntakeSettingsUpdate body)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PutCasemanagementCaseplanIntakesettings");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PutCasemanagementCaseplanIntakesettings");

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/intakesettings";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutCasemanagementCaseplanIntakesettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PutCasemanagementCaseplanIntakesettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCasemanagementCaseplanIntakesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntakeSettingsListing>(localVarStatusCode,
                localVarHeaders,
                (IntakeSettingsListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntakeSettingsListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update the intake settings for a Caseplan. 
        /// 
        /// PutCasemanagementCaseplanIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Intake Settings</param>
        /// <returns>Task of IntakeSettingsListing</returns>
        
        public async System.Threading.Tasks.Task<IntakeSettingsListing> PutCasemanagementCaseplanIntakesettingsAsync (string caseplanId, IntakeSettingsUpdate body)
        {
             ApiResponse<IntakeSettingsListing> localVarResponse = await PutCasemanagementCaseplanIntakesettingsAsyncWithHttpInfo(caseplanId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the intake settings for a Caseplan. 
        /// 
        /// PutCasemanagementCaseplanIntakesettings is a preview method and is subject to both breaking and non-breaking changes at any time without notice
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseplanId">Caseplan ID</param>
        /// <param name="body">Intake Settings</param>
        /// <returns>Task of ApiResponse (IntakeSettingsListing)</returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<IntakeSettingsListing>> PutCasemanagementCaseplanIntakesettingsAsyncWithHttpInfo (string caseplanId, IntakeSettingsUpdate body)
        { 
            // verify the required parameter 'caseplanId' is set
            if (caseplanId == null)
                throw new ApiException(400, "Missing required parameter 'caseplanId' when calling CaseManagementApi->PutCasemanagementCaseplanIntakesettings");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CaseManagementApi->PutCasemanagementCaseplanIntakesettings");
            

            var localVarPath = "/api/v2/casemanagement/caseplans/{caseplanId}/intakesettings";
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
            if (caseplanId != null) localVarPathParams.Add("caseplanId", this.Configuration.ApiClient.ParameterToString(caseplanId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutCasemanagementCaseplanIntakesettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode >= 300 && localVarStatusCode < 400)
                throw new ApiException.RedirectException (localVarStatusCode, "HTTP Redirect received calling PutCasemanagementCaseplanIntakesettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCasemanagementCaseplanIntakesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntakeSettingsListing>(localVarStatusCode,
                localVarHeaders,
                (IntakeSettingsListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntakeSettingsListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
