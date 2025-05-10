# ArchitectApi

## PureCloudPlatform.Client.V2.Api.ArchitectApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteArchitectEmergencygroup**](#DeleteArchitectEmergencygroup) | **Delete** /api/v2/architect/emergencygroups/{emergencyGroupId} | Deletes a emergency group by ID |
| [**DeleteArchitectGrammar**](#DeleteArchitectGrammar) | **Delete** /api/v2/architect/grammars/{grammarId} | Delete a grammar. |
| [**DeleteArchitectGrammarLanguage**](#DeleteArchitectGrammarLanguage) | **Delete** /api/v2/architect/grammars/{grammarId}/languages/{languageCode} | Delete specified grammar language |
| [**DeleteArchitectGrammarLanguageFilesDtmf**](#DeleteArchitectGrammarLanguageFilesDtmf) | **Delete** /api/v2/architect/grammars/{grammarId}/languages/{languageCode}/files/dtmf | Clear the DTMF mode file for the grammar language if there is one |
| [**DeleteArchitectGrammarLanguageFilesVoice**](#DeleteArchitectGrammarLanguageFilesVoice) | **Delete** /api/v2/architect/grammars/{grammarId}/languages/{languageCode}/files/voice | Clear the voice mode file for the grammar language if there is one |
| [**DeleteArchitectIvr**](#DeleteArchitectIvr) | **Delete** /api/v2/architect/ivrs/{ivrId} | Delete an IVR Config. |
| [**DeleteArchitectPrompt**](#DeleteArchitectPrompt) | **Delete** /api/v2/architect/prompts/{promptId} | Delete specified user prompt |
| [**DeleteArchitectPromptResource**](#DeleteArchitectPromptResource) | **Delete** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Delete specified user prompt resource |
| [**DeleteArchitectPromptResourceAudio**](#DeleteArchitectPromptResourceAudio) | **Delete** /api/v2/architect/prompts/{promptId}/resources/{languageCode}/audio | Delete specified user prompt resource audio |
| [**DeleteArchitectPrompts**](#DeleteArchitectPrompts) | **Delete** /api/v2/architect/prompts | Batch-delete a list of prompts |
| [**DeleteArchitectSchedule**](#DeleteArchitectSchedule) | **Delete** /api/v2/architect/schedules/{scheduleId} | Delete a schedule by id |
| [**DeleteArchitectSchedulegroup**](#DeleteArchitectSchedulegroup) | **Delete** /api/v2/architect/schedulegroups/{scheduleGroupId} | Deletes a schedule group by ID |
| [**DeleteArchitectSystempromptResource**](#DeleteArchitectSystempromptResource) | **Delete** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Delete a system prompt resource override. |
| [**DeleteFlow**](#DeleteFlow) | **Delete** /api/v2/flows/{flowId} | Delete flow |
| [**DeleteFlowInstancesSettingsLoglevels**](#DeleteFlowInstancesSettingsLoglevels) | **Delete** /api/v2/flows/{flowId}/instances/settings/loglevels | Deletes a log level for a flow by flow id. |
| [**DeleteFlows**](#DeleteFlows) | **Delete** /api/v2/flows | Batch-delete a list of flows |
| [**DeleteFlowsDatatable**](#DeleteFlowsDatatable) | **Delete** /api/v2/flows/datatables/{datatableId} | deletes a specific datatable by id |
| [**DeleteFlowsDatatableRow**](#DeleteFlowsDatatableRow) | **Delete** /api/v2/flows/datatables/{datatableId}/rows/{rowId} | Delete a row entry |
| [**DeleteFlowsInstancesSettingsLoglevelsDefault**](#DeleteFlowsInstancesSettingsLoglevelsDefault) | **Delete** /api/v2/flows/instances/settings/loglevels/default | Resets the org log level to default, base |
| [**DeleteFlowsMilestone**](#DeleteFlowsMilestone) | **Delete** /api/v2/flows/milestones/{milestoneId} | Delete a flow milestone. |
| [**GetArchitectDependencytracking**](#GetArchitectDependencytracking) | **Get** /api/v2/architect/dependencytracking | Get Dependency Tracking objects that have a given display name |
| [**GetArchitectDependencytrackingBuild**](#GetArchitectDependencytrackingBuild) | **Get** /api/v2/architect/dependencytracking/build | Get Dependency Tracking build status for an organization |
| [**GetArchitectDependencytrackingConsumedresources**](#GetArchitectDependencytrackingConsumedresources) | **Get** /api/v2/architect/dependencytracking/consumedresources | Get resources that are consumed by a given Dependency Tracking object |
| [**GetArchitectDependencytrackingConsumingresources**](#GetArchitectDependencytrackingConsumingresources) | **Get** /api/v2/architect/dependencytracking/consumingresources | Get resources that consume a given Dependency Tracking object |
| [**GetArchitectDependencytrackingDeletedresourceconsumers**](#GetArchitectDependencytrackingDeletedresourceconsumers) | **Get** /api/v2/architect/dependencytracking/deletedresourceconsumers | Get Dependency Tracking objects that consume deleted resources |
| [**GetArchitectDependencytrackingObject**](#GetArchitectDependencytrackingObject) | **Get** /api/v2/architect/dependencytracking/object | Get a Dependency Tracking object |
| [**GetArchitectDependencytrackingType**](#GetArchitectDependencytrackingType) | **Get** /api/v2/architect/dependencytracking/types/{typeId} | Get a Dependency Tracking type. |
| [**GetArchitectDependencytrackingTypes**](#GetArchitectDependencytrackingTypes) | **Get** /api/v2/architect/dependencytracking/types | Get Dependency Tracking types. |
| [**GetArchitectDependencytrackingUpdatedresourceconsumers**](#GetArchitectDependencytrackingUpdatedresourceconsumers) | **Get** /api/v2/architect/dependencytracking/updatedresourceconsumers | Get Dependency Tracking objects that depend on updated resources |
| [**GetArchitectEmergencygroup**](#GetArchitectEmergencygroup) | **Get** /api/v2/architect/emergencygroups/{emergencyGroupId} | Gets a emergency group by ID |
| [**GetArchitectEmergencygroups**](#GetArchitectEmergencygroups) | **Get** /api/v2/architect/emergencygroups | Get a list of emergency groups. |
| [**GetArchitectEmergencygroupsDivisionviews**](#GetArchitectEmergencygroupsDivisionviews) | **Get** /api/v2/architect/emergencygroups/divisionviews | Get a pageable list of basic emergency group objects filterable by query parameters. |
| [**GetArchitectGrammar**](#GetArchitectGrammar) | **Get** /api/v2/architect/grammars/{grammarId} | Get a grammar |
| [**GetArchitectGrammarLanguage**](#GetArchitectGrammarLanguage) | **Get** /api/v2/architect/grammars/{grammarId}/languages/{languageCode} | Get a grammar language. |
| [**GetArchitectGrammars**](#GetArchitectGrammars) | **Get** /api/v2/architect/grammars | Get a pageable list of grammars, filtered by query parameters |
| [**GetArchitectIvr**](#GetArchitectIvr) | **Get** /api/v2/architect/ivrs/{ivrId} | Get an IVR config. |
| [**GetArchitectIvrIdentityresolution**](#GetArchitectIvrIdentityresolution) | **Get** /api/v2/architect/ivrs/{ivrId}/identityresolution | Get an IVR IdentityResolutionConfig. |
| [**GetArchitectIvrs**](#GetArchitectIvrs) | **Get** /api/v2/architect/ivrs | Get IVR configs. |
| [**GetArchitectIvrsDivisionviews**](#GetArchitectIvrsDivisionviews) | **Get** /api/v2/architect/ivrs/divisionviews | Get a pageable list of basic ivr configuration information objects filterable by query parameters. |
| [**GetArchitectPrompt**](#GetArchitectPrompt) | **Get** /api/v2/architect/prompts/{promptId} | Get specified user prompt |
| [**GetArchitectPromptHistoryHistoryId**](#GetArchitectPromptHistoryHistoryId) | **Get** /api/v2/architect/prompts/{promptId}/history/{historyId} | Get generated prompt history |
| [**GetArchitectPromptResource**](#GetArchitectPromptResource) | **Get** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Get specified user prompt resource |
| [**GetArchitectPromptResources**](#GetArchitectPromptResources) | **Get** /api/v2/architect/prompts/{promptId}/resources | Get a pageable list of user prompt resources |
| [**GetArchitectPrompts**](#GetArchitectPrompts) | **Get** /api/v2/architect/prompts | Get a pageable list of user prompts |
| [**GetArchitectSchedule**](#GetArchitectSchedule) | **Get** /api/v2/architect/schedules/{scheduleId} | Get a schedule by ID |
| [**GetArchitectSchedulegroup**](#GetArchitectSchedulegroup) | **Get** /api/v2/architect/schedulegroups/{scheduleGroupId} | Gets a schedule group by ID |
| [**GetArchitectSchedulegroups**](#GetArchitectSchedulegroups) | **Get** /api/v2/architect/schedulegroups | Get a list of schedule groups. |
| [**GetArchitectSchedulegroupsDivisionviews**](#GetArchitectSchedulegroupsDivisionviews) | **Get** /api/v2/architect/schedulegroups/divisionviews | Get a pageable list of basic schedule group configuration information objects filterable by query parameters. |
| [**GetArchitectSchedules**](#GetArchitectSchedules) | **Get** /api/v2/architect/schedules | Get a list of schedules. |
| [**GetArchitectSchedulesDivisionviews**](#GetArchitectSchedulesDivisionviews) | **Get** /api/v2/architect/schedules/divisionviews | Get a pageable list of basic schedule configuration information objects filterable by query parameters. |
| [**GetArchitectSystemprompt**](#GetArchitectSystemprompt) | **Get** /api/v2/architect/systemprompts/{promptId} | Get a system prompt |
| [**GetArchitectSystempromptHistoryHistoryId**](#GetArchitectSystempromptHistoryHistoryId) | **Get** /api/v2/architect/systemprompts/{promptId}/history/{historyId} | Get generated prompt history |
| [**GetArchitectSystempromptResource**](#GetArchitectSystempromptResource) | **Get** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Get a system prompt resource. |
| [**GetArchitectSystempromptResources**](#GetArchitectSystempromptResources) | **Get** /api/v2/architect/systemprompts/{promptId}/resources | Get system prompt resources. |
| [**GetArchitectSystemprompts**](#GetArchitectSystemprompts) | **Get** /api/v2/architect/systemprompts | Get System Prompts |
| [**GetFlow**](#GetFlow) | **Get** /api/v2/flows/{flowId} | Get flow |
| [**GetFlowHistoryHistoryId**](#GetFlowHistoryHistoryId) | **Get** /api/v2/flows/{flowId}/history/{historyId} | Get generated flow history |
| [**GetFlowInstancesSettingsLoglevels**](#GetFlowInstancesSettingsLoglevels) | **Get** /api/v2/flows/{flowId}/instances/settings/loglevels | Retrieves the log level for a flow by flow id. |
| [**GetFlowLatestconfiguration**](#GetFlowLatestconfiguration) | **Get** /api/v2/flows/{flowId}/latestconfiguration | Get the latest configuration for flow |
| [**GetFlowVersion**](#GetFlowVersion) | **Get** /api/v2/flows/{flowId}/versions/{versionId} | Get flow version |
| [**GetFlowVersionConfiguration**](#GetFlowVersionConfiguration) | **Get** /api/v2/flows/{flowId}/versions/{versionId}/configuration | Get flow version configuration |
| [**GetFlowVersionHealth**](#GetFlowVersionHealth) | **Get** /api/v2/flows/{flowId}/versions/{versionId}/health | Get overall health scores for all intents present in the NLU domain version associated with the bot flow version. |
| [**GetFlowVersionIntentHealth**](#GetFlowVersionIntentHealth) | **Get** /api/v2/flows/{flowId}/versions/{versionId}/intents/{intentId}/health | Get health scores and other health metrics for a specific intent. This includes the health metrics for each utterance in an intent. |
| [**GetFlowVersionIntentUtteranceHealth**](#GetFlowVersionIntentUtteranceHealth) | **Get** /api/v2/flows/{flowId}/versions/{versionId}/intents/{intentId}/utterances/{utteranceId}/health | Get health metrics associated with a specific utterance of an intent. |
| [**GetFlowVersions**](#GetFlowVersions) | **Get** /api/v2/flows/{flowId}/versions | Get flow version list |
| [**GetFlows**](#GetFlows) | **Get** /api/v2/flows | Get a pageable list of flows, filtered by query parameters |
| [**GetFlowsDatatable**](#GetFlowsDatatable) | **Get** /api/v2/flows/datatables/{datatableId} | Returns a specific datatable by id |
| [**GetFlowsDatatableExportJob**](#GetFlowsDatatableExportJob) | **Get** /api/v2/flows/datatables/{datatableId}/export/jobs/{exportJobId} | Returns the state information about an export job |
| [**GetFlowsDatatableImportJob**](#GetFlowsDatatableImportJob) | **Get** /api/v2/flows/datatables/{datatableId}/import/jobs/{importJobId} | Returns the state information about an import job |
| [**GetFlowsDatatableImportJobs**](#GetFlowsDatatableImportJobs) | **Get** /api/v2/flows/datatables/{datatableId}/import/jobs | Get all recent import jobs |
| [**GetFlowsDatatableRow**](#GetFlowsDatatableRow) | **Get** /api/v2/flows/datatables/{datatableId}/rows/{rowId} | Returns a specific row for the datatable |
| [**GetFlowsDatatableRows**](#GetFlowsDatatableRows) | **Get** /api/v2/flows/datatables/{datatableId}/rows | Returns the rows for the datatable with the given id |
| [**GetFlowsDatatables**](#GetFlowsDatatables) | **Get** /api/v2/flows/datatables | Retrieve a list of datatables for the org |
| [**GetFlowsDatatablesDivisionview**](#GetFlowsDatatablesDivisionview) | **Get** /api/v2/flows/datatables/divisionviews/{datatableId} | Returns a specific datatable by id |
| [**GetFlowsDatatablesDivisionviews**](#GetFlowsDatatablesDivisionviews) | **Get** /api/v2/flows/datatables/divisionviews | Retrieve a list of datatables for the org |
| [**GetFlowsDivisionviews**](#GetFlowsDivisionviews) | **Get** /api/v2/flows/divisionviews | Get a pageable list of basic flow information objects filterable by query parameters. |
| [**GetFlowsExecution**](#GetFlowsExecution) | **Get** /api/v2/flows/executions/{flowExecutionId} | Get a flow execution&#39;s details. Flow execution details are available for several days after the flow is started. |
| [**GetFlowsExportJob**](#GetFlowsExportJob) | **Get** /api/v2/flows/export/jobs/{jobId} | Fetch Architect Export Job Status |
| [**GetFlowsInstance**](#GetFlowsInstance) | **Get** /api/v2/flows/instances/{instanceId} | Start a process (job) to prepare a download of a singular flow execution data instance by Id |
| [**GetFlowsInstancesJob**](#GetFlowsInstancesJob) | **Get** /api/v2/flows/instances/jobs/{jobId} | Get the status and/or results of an asynchronous flow execution data retrieval job |
| [**GetFlowsInstancesQuerycapabilities**](#GetFlowsInstancesQuerycapabilities) | **Get** /api/v2/flows/instances/querycapabilities | Retrieve a list of capabilities that the org can use to query for execution data |
| [**GetFlowsInstancesSettingsExecutiondata**](#GetFlowsInstancesSettingsExecutiondata) | **Get** /api/v2/flows/instances/settings/executiondata | Get the execution history enabled setting. |
| [**GetFlowsInstancesSettingsLoglevels**](#GetFlowsInstancesSettingsLoglevels) | **Get** /api/v2/flows/instances/settings/loglevels | Retrieve a list of LogLevels for the organization. |
| [**GetFlowsInstancesSettingsLoglevelsCharacteristics**](#GetFlowsInstancesSettingsLoglevelsCharacteristics) | **Get** /api/v2/flows/instances/settings/loglevels/characteristics | Gets the available flow log level characteristics for this organization. |
| [**GetFlowsInstancesSettingsLoglevelsDefault**](#GetFlowsInstancesSettingsLoglevelsDefault) | **Get** /api/v2/flows/instances/settings/loglevels/default | Returns the flow default log level. |
| [**GetFlowsJob**](#GetFlowsJob) | **Get** /api/v2/flows/jobs/{jobId} | Fetch Architect Job Status |
| [**GetFlowsMilestone**](#GetFlowsMilestone) | **Get** /api/v2/flows/milestones/{milestoneId} | Get a flow milestone |
| [**GetFlowsMilestones**](#GetFlowsMilestones) | **Get** /api/v2/flows/milestones | Get a pageable list of flow milestones, filtered by query parameters |
| [**GetFlowsMilestonesDivisionviews**](#GetFlowsMilestonesDivisionviews) | **Get** /api/v2/flows/milestones/divisionviews | Get a pageable list of basic flow milestone information objects filterable by query parameters. |
| [**GetFlowsOutcome**](#GetFlowsOutcome) | **Get** /api/v2/flows/outcomes/{flowOutcomeId} | Get a flow outcome |
| [**GetFlowsOutcomes**](#GetFlowsOutcomes) | **Get** /api/v2/flows/outcomes | Get a pageable list of flow outcomes, filtered by query parameters |
| [**GetFlowsOutcomesDivisionviews**](#GetFlowsOutcomesDivisionviews) | **Get** /api/v2/flows/outcomes/divisionviews | Get a pageable list of basic flow outcome information objects filterable by query parameters. |
| [**PatchArchitectGrammar**](#PatchArchitectGrammar) | **Patch** /api/v2/architect/grammars/{grammarId} | Updates a grammar |
| [**PatchArchitectGrammarLanguage**](#PatchArchitectGrammarLanguage) | **Patch** /api/v2/architect/grammars/{grammarId}/languages/{languageCode} | Updates a grammar language |
| [**PatchFlowsInstancesSettingsExecutiondata**](#PatchFlowsInstancesSettingsExecutiondata) | **Patch** /api/v2/flows/instances/settings/executiondata | Edit the execution history enabled setting. |
| [**PostArchitectDependencytrackingBuild**](#PostArchitectDependencytrackingBuild) | **Post** /api/v2/architect/dependencytracking/build | Rebuild Dependency Tracking data for an organization |
| [**PostArchitectEmergencygroups**](#PostArchitectEmergencygroups) | **Post** /api/v2/architect/emergencygroups | Creates a new emergency group |
| [**PostArchitectGrammarLanguageFilesDtmf**](#PostArchitectGrammarLanguageFilesDtmf) | **Post** /api/v2/architect/grammars/{grammarId}/languages/{languageCode}/files/dtmf | Creates a presigned URL for uploading a grammar DTMF mode file |
| [**PostArchitectGrammarLanguageFilesVoice**](#PostArchitectGrammarLanguageFilesVoice) | **Post** /api/v2/architect/grammars/{grammarId}/languages/{languageCode}/files/voice | Creates a presigned URL for uploading a grammar voice mode file |
| [**PostArchitectGrammarLanguages**](#PostArchitectGrammarLanguages) | **Post** /api/v2/architect/grammars/{grammarId}/languages | Create a new language for a given grammar |
| [**PostArchitectGrammars**](#PostArchitectGrammars) | **Post** /api/v2/architect/grammars | Create a new grammar |
| [**PostArchitectIvrs**](#PostArchitectIvrs) | **Post** /api/v2/architect/ivrs | Create IVR config. |
| [**PostArchitectPromptHistory**](#PostArchitectPromptHistory) | **Post** /api/v2/architect/prompts/{promptId}/history | Generate prompt history |
| [**PostArchitectPromptResourceUploads**](#PostArchitectPromptResourceUploads) | **Post** /api/v2/architect/prompts/{promptId}/resources/{languageCode}/uploads | Creates a presigned URL for uploading a user prompt file |
| [**PostArchitectPromptResources**](#PostArchitectPromptResources) | **Post** /api/v2/architect/prompts/{promptId}/resources | Create a new user prompt resource |
| [**PostArchitectPrompts**](#PostArchitectPrompts) | **Post** /api/v2/architect/prompts | Create a new user prompt |
| [**PostArchitectSchedulegroups**](#PostArchitectSchedulegroups) | **Post** /api/v2/architect/schedulegroups | Creates a new schedule group |
| [**PostArchitectSchedules**](#PostArchitectSchedules) | **Post** /api/v2/architect/schedules | Create a new schedule. |
| [**PostArchitectSystempromptHistory**](#PostArchitectSystempromptHistory) | **Post** /api/v2/architect/systemprompts/{promptId}/history | Generate system prompt history |
| [**PostArchitectSystempromptResourceUploads**](#PostArchitectSystempromptResourceUploads) | **Post** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode}/uploads | Creates a presigned URL for uploading a system prompt file |
| [**PostArchitectSystempromptResources**](#PostArchitectSystempromptResources) | **Post** /api/v2/architect/systemprompts/{promptId}/resources | Create system prompt resource override. |
| [**PostFlowHistory**](#PostFlowHistory) | **Post** /api/v2/flows/{flowId}/history | Generate flow history |
| [**PostFlowInstancesSettingsLoglevels**](#PostFlowInstancesSettingsLoglevels) | **Post** /api/v2/flows/{flowId}/instances/settings/loglevels | Set the logLevel for a particular flow id |
| [**PostFlowVersions**](#PostFlowVersions) | **Post** /api/v2/flows/{flowId}/versions | Create flow version |
| [**PostFlows**](#PostFlows) | **Post** /api/v2/flows | Create flow |
| [**PostFlowsActionsCheckin**](#PostFlowsActionsCheckin) | **Post** /api/v2/flows/actions/checkin | Check-in flow |
| [**PostFlowsActionsCheckout**](#PostFlowsActionsCheckout) | **Post** /api/v2/flows/actions/checkout | Check-out flow |
| [**PostFlowsActionsDeactivate**](#PostFlowsActionsDeactivate) | **Post** /api/v2/flows/actions/deactivate | Deactivate flow |
| [**PostFlowsActionsPublish**](#PostFlowsActionsPublish) | **Post** /api/v2/flows/actions/publish | Publish flow |
| [**PostFlowsActionsRevert**](#PostFlowsActionsRevert) | **Post** /api/v2/flows/actions/revert | Revert flow |
| [**PostFlowsActionsUnlock**](#PostFlowsActionsUnlock) | **Post** /api/v2/flows/actions/unlock | Unlock flow |
| [**PostFlowsDatatableExportJobs**](#PostFlowsDatatableExportJobs) | **Post** /api/v2/flows/datatables/{datatableId}/export/jobs | Begin an export process for exporting all rows from a datatable |
| [**PostFlowsDatatableImportJobs**](#PostFlowsDatatableImportJobs) | **Post** /api/v2/flows/datatables/{datatableId}/import/jobs | Begin an import process for importing rows into a datatable |
| [**PostFlowsDatatableRows**](#PostFlowsDatatableRows) | **Post** /api/v2/flows/datatables/{datatableId}/rows | Create a new row entry for the datatable. |
| [**PostFlowsDatatables**](#PostFlowsDatatables) | **Post** /api/v2/flows/datatables | Create a new datatable with the specified json-schema definition |
| [**PostFlowsExecutions**](#PostFlowsExecutions) | **Post** /api/v2/flows/executions | Launch an instance of a flow definition, for flow types that support it such as the &#39;workflow&#39; type. |
| [**PostFlowsExportJobs**](#PostFlowsExportJobs) | **Post** /api/v2/flows/export/jobs | Register Architect Export Job |
| [**PostFlowsInstancesJobs**](#PostFlowsInstancesJobs) | **Post** /api/v2/flows/instances/jobs | Start a process (job) that will prepare a list of execution data IDs for download. |
| [**PostFlowsInstancesQuery**](#PostFlowsInstancesQuery) | **Post** /api/v2/flows/instances/query | Query the database of existing flow histories to look for particular flow criteria |
| [**PostFlowsJobs**](#PostFlowsJobs) | **Post** /api/v2/flows/jobs | Register Architect Job. Returns a URL where a file, such as an Architect flow YAML file, can be PUT which will then initiate the job. |
| [**PostFlowsMilestones**](#PostFlowsMilestones) | **Post** /api/v2/flows/milestones | Create a flow milestone |
| [**PostFlowsOutcomes**](#PostFlowsOutcomes) | **Post** /api/v2/flows/outcomes | Create a flow outcome |
| [**PutArchitectEmergencygroup**](#PutArchitectEmergencygroup) | **Put** /api/v2/architect/emergencygroups/{emergencyGroupId} | Updates a emergency group by ID |
| [**PutArchitectIvr**](#PutArchitectIvr) | **Put** /api/v2/architect/ivrs/{ivrId} | Update an IVR Config. |
| [**PutArchitectIvrIdentityresolution**](#PutArchitectIvrIdentityresolution) | **Put** /api/v2/architect/ivrs/{ivrId}/identityresolution | Update an IVR IdentityResolutionConfig. |
| [**PutArchitectPrompt**](#PutArchitectPrompt) | **Put** /api/v2/architect/prompts/{promptId} | Update specified user prompt |
| [**PutArchitectPromptResource**](#PutArchitectPromptResource) | **Put** /api/v2/architect/prompts/{promptId}/resources/{languageCode} | Update specified user prompt resource |
| [**PutArchitectSchedule**](#PutArchitectSchedule) | **Put** /api/v2/architect/schedules/{scheduleId} | Update schedule by ID |
| [**PutArchitectSchedulegroup**](#PutArchitectSchedulegroup) | **Put** /api/v2/architect/schedulegroups/{scheduleGroupId} | Updates a schedule group by ID |
| [**PutArchitectSystempromptResource**](#PutArchitectSystempromptResource) | **Put** /api/v2/architect/systemprompts/{promptId}/resources/{languageCode} | Updates a system prompt resource override. |
| [**PutFlow**](#PutFlow) | **Put** /api/v2/flows/{flowId} | Update flow |
| [**PutFlowInstancesSettingsLoglevels**](#PutFlowInstancesSettingsLoglevels) | **Put** /api/v2/flows/{flowId}/instances/settings/loglevels | Edit the logLevel for a particular flow id |
| [**PutFlowsDatatable**](#PutFlowsDatatable) | **Put** /api/v2/flows/datatables/{datatableId} | Updates a specific datatable by id |
| [**PutFlowsDatatableRow**](#PutFlowsDatatableRow) | **Put** /api/v2/flows/datatables/{datatableId}/rows/{rowId} | Update a row entry |
| [**PutFlowsInstancesSettingsLoglevelsDefault**](#PutFlowsInstancesSettingsLoglevelsDefault) | **Put** /api/v2/flows/instances/settings/loglevels/default | Edit the flow default log level. |
| [**PutFlowsMilestone**](#PutFlowsMilestone) | **Put** /api/v2/flows/milestones/{milestoneId} | Updates a flow milestone |
| [**PutFlowsOutcome**](#PutFlowsOutcome) | **Put** /api/v2/flows/outcomes/{flowOutcomeId} | Updates a flow outcome |



## DeleteArchitectEmergencygroup

> void DeleteArchitectEmergencygroup (string emergencyGroupId)


Deletes a emergency group by ID

Requires ALL permissions: 

* routing:emergencyGroup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectEmergencygroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var emergencyGroupId = emergencyGroupId_example;  // string | Emergency group ID

            try
            { 
                // Deletes a emergency group by ID
                apiInstance.DeleteArchitectEmergencygroup(emergencyGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectEmergencygroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emergencyGroupId** | **string**| Emergency group ID |  |

### Return type

void (empty response body)


## DeleteArchitectGrammar

> **Object** DeleteArchitectGrammar (string grammarId)


Delete a grammar.

Requires ALL permissions: 

* architect:grammar:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectGrammarExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | grammar ID

            try
            { 
                // Delete a grammar.
                Object result = apiInstance.DeleteArchitectGrammar(grammarId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectGrammar: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| grammar ID |  |

### Return type

**Object**


## DeleteArchitectGrammarLanguage

> void DeleteArchitectGrammarLanguage (string grammarId, string languageCode)


Delete specified grammar language

Requires ALL permissions: 

* architect:grammar:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectGrammarLanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | Grammar ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Delete specified grammar language
                apiInstance.DeleteArchitectGrammarLanguage(grammarId, languageCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectGrammarLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| Grammar ID |  |
| **languageCode** | **string**| Language |  |

### Return type

void (empty response body)


## DeleteArchitectGrammarLanguageFilesDtmf

> void DeleteArchitectGrammarLanguageFilesDtmf (string grammarId, string languageCode)


Clear the DTMF mode file for the grammar language if there is one

Requires ALL permissions: 

* architect:grammar:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectGrammarLanguageFilesDtmfExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | Grammar ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Clear the DTMF mode file for the grammar language if there is one
                apiInstance.DeleteArchitectGrammarLanguageFilesDtmf(grammarId, languageCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectGrammarLanguageFilesDtmf: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| Grammar ID |  |
| **languageCode** | **string**| Language |  |

### Return type

void (empty response body)


## DeleteArchitectGrammarLanguageFilesVoice

> void DeleteArchitectGrammarLanguageFilesVoice (string grammarId, string languageCode)


Clear the voice mode file for the grammar language if there is one

Requires ALL permissions: 

* architect:grammar:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectGrammarLanguageFilesVoiceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | Grammar ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Clear the voice mode file for the grammar language if there is one
                apiInstance.DeleteArchitectGrammarLanguageFilesVoice(grammarId, languageCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectGrammarLanguageFilesVoice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| Grammar ID |  |
| **languageCode** | **string**| Language |  |

### Return type

void (empty response body)


## DeleteArchitectIvr

> void DeleteArchitectIvr (string ivrId)


Delete an IVR Config.

Requires ALL permissions: 

* routing:callRoute:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectIvrExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var ivrId = ivrId_example;  // string | IVR id

            try
            { 
                // Delete an IVR Config.
                apiInstance.DeleteArchitectIvr(ivrId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectIvr: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ivrId** | **string**| IVR id |  |

### Return type

void (empty response body)


## DeleteArchitectPrompt

> void DeleteArchitectPrompt (string promptId, bool? allResources = null)


Delete specified user prompt

Requires ALL permissions: 

* architect:userPrompt:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectPromptExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var allResources = true;  // bool? | Whether or not to delete all the prompt resources (optional) 

            try
            { 
                // Delete specified user prompt
                apiInstance.DeleteArchitectPrompt(promptId, allResources);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectPrompt: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **allResources** | **bool?**| Whether or not to delete all the prompt resources | [optional]  |

### Return type

void (empty response body)


## DeleteArchitectPromptResource

> void DeleteArchitectPromptResource (string promptId, string languageCode)


Delete specified user prompt resource

Requires ALL permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectPromptResourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Delete specified user prompt resource
                apiInstance.DeleteArchitectPromptResource(promptId, languageCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectPromptResource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |

### Return type

void (empty response body)


## DeleteArchitectPromptResourceAudio

> void DeleteArchitectPromptResourceAudio (string promptId, string languageCode)


Delete specified user prompt resource audio

Requires ALL permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectPromptResourceAudioExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Delete specified user prompt resource audio
                apiInstance.DeleteArchitectPromptResourceAudio(promptId, languageCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectPromptResourceAudio: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |

### Return type

void (empty response body)


## DeleteArchitectPrompts

> [**Operation**](Operation) DeleteArchitectPrompts (List<string> id)


Batch-delete a list of prompts

Multiple IDs can be specified, in which case all specified prompts will be deleted.  Asynchronous.  Notification topic: v2.architect.prompts.{promptId}

Requires ALL permissions: 

* architect:userPrompt:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectPromptsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var id = new List<string>(); // List<string> | List of Prompt IDs

            try
            { 
                // Batch-delete a list of prompts
                Operation result = apiInstance.DeleteArchitectPrompts(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectPrompts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string)| List of Prompt IDs |  |

### Return type

[**Operation**](Operation)


## DeleteArchitectSchedule

> void DeleteArchitectSchedule (string scheduleId)


Delete a schedule by id

Requires ALL permissions: 

* routing:schedule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID

            try
            { 
                // Delete a schedule by id
                apiInstance.DeleteArchitectSchedule(scheduleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |

### Return type

void (empty response body)


## DeleteArchitectSchedulegroup

> void DeleteArchitectSchedulegroup (string scheduleGroupId)


Deletes a schedule group by ID

Requires ALL permissions: 

* routing:scheduleGroup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectSchedulegroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var scheduleGroupId = scheduleGroupId_example;  // string | Schedule group ID

            try
            { 
                // Deletes a schedule group by ID
                apiInstance.DeleteArchitectSchedulegroup(scheduleGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectSchedulegroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleGroupId** | **string**| Schedule group ID |  |

### Return type

void (empty response body)


## DeleteArchitectSystempromptResource

> void DeleteArchitectSystempromptResource (string promptId, string languageCode)


Delete a system prompt resource override.

Requires ALL permissions: 

* architect:systemPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteArchitectSystempromptResourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Delete a system prompt resource override.
                apiInstance.DeleteArchitectSystempromptResource(promptId, languageCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteArchitectSystempromptResource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |

### Return type

void (empty response body)


## DeleteFlow

> void DeleteFlow (string flowId)


Delete flow

Requires ANY permissions: 

* architect:flow:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID

            try
            { 
                // Delete flow
                apiInstance.DeleteFlow(flowId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |

### Return type

void (empty response body)


## DeleteFlowInstancesSettingsLoglevels

> void DeleteFlowInstancesSettingsLoglevels (string flowId)


Deletes a log level for a flow by flow id.

Deletes the associated log level for a flow by flow id

Requires ALL permissions: 

* architect:flowLogLevel:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowInstancesSettingsLoglevelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | The flow id to delete the loglevel for

            try
            { 
                // Deletes a log level for a flow by flow id.
                apiInstance.DeleteFlowInstancesSettingsLoglevels(flowId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlowInstancesSettingsLoglevels: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| The flow id to delete the loglevel for |  |

### Return type

void (empty response body)


## DeleteFlows

> [**Operation**](Operation) DeleteFlows (List<string> id)


Batch-delete a list of flows

Multiple IDs can be specified, in which case all specified flows will be deleted.  Asynchronous.  Notification topic: v2.flows.{flowId}

Requires ANY permissions: 

* architect:flow:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var id = new List<string>(); // List<string> | List of Flow IDs

            try
            { 
                // Batch-delete a list of flows
                Operation result = apiInstance.DeleteFlows(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlows: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string)| List of Flow IDs |  |

### Return type

[**Operation**](Operation)


## DeleteFlowsDatatable

> void DeleteFlowsDatatable (string datatableId, bool? force = null)


deletes a specific datatable by id

Deletes an entire datatable (including the schema and data) with a given datatableId

Requires ANY permissions: 

* architect:datatable:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowsDatatableExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var force = true;  // bool? | force delete, even if in use (optional)  (default to false)

            try
            { 
                // deletes a specific datatable by id
                apiInstance.DeleteFlowsDatatable(datatableId, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlowsDatatable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **force** | **bool?**| force delete, even if in use | [optional] [default to false] |

### Return type

void (empty response body)


## DeleteFlowsDatatableRow

> void DeleteFlowsDatatableRow (string datatableId, string rowId)


Delete a row entry

Deletes a row with a given rowId (the value of the key field).

Requires ANY permissions: 

* architect:datatable:delete
* architect:datatableRow:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowsDatatableRowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var rowId = rowId_example;  // string | the key for the row

            try
            { 
                // Delete a row entry
                apiInstance.DeleteFlowsDatatableRow(datatableId, rowId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlowsDatatableRow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **rowId** | **string**| the key for the row |  |

### Return type

void (empty response body)


## DeleteFlowsInstancesSettingsLoglevelsDefault

> void DeleteFlowsInstancesSettingsLoglevelsDefault ()


Resets the org log level to default, base

Resets the org log level to default, base

Requires ANY permissions: 

* architect:flowLogLevelDefault:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowsInstancesSettingsLoglevelsDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();

            try
            { 
                // Resets the org log level to default, base
                apiInstance.DeleteFlowsInstancesSettingsLoglevelsDefault();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlowsInstancesSettingsLoglevelsDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## DeleteFlowsMilestone

> **Object** DeleteFlowsMilestone (string milestoneId)


Delete a flow milestone.

Requires ALL permissions: 

* architect:flowMilestone:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteFlowsMilestoneExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var milestoneId = milestoneId_example;  // string | flow milestone ID

            try
            { 
                // Delete a flow milestone.
                Object result = apiInstance.DeleteFlowsMilestone(milestoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.DeleteFlowsMilestone: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **milestoneId** | **string**| flow milestone ID |  |

### Return type

**Object**


## GetArchitectDependencytracking

> [**DependencyObjectEntityListing**](DependencyObjectEntityListing) GetArchitectDependencytracking (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)


Get Dependency Tracking objects that have a given display name

Requires ALL permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var name = name_example;  // string | Object name to search for
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var objectType = new List<string>(); // List<string> | Object type(s) to search for (optional) 
            var consumedResources = true;  // bool? | Include resources each result item consumes (optional) 
            var consumingResources = true;  // bool? | Include resources that consume each result item (optional) 
            var consumedResourceType = new List<string>(); // List<string> | Types of consumed resources to return, if consumed resources are requested (optional) 
            var consumingResourceType = new List<string>(); // List<string> | Types of consuming resources to return, if consuming resources are requested (optional) 

            try
            { 
                // Get Dependency Tracking objects that have a given display name
                DependencyObjectEntityListing result = apiInstance.GetArchitectDependencytracking(name, pageNumber, pageSize, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytracking: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Object name to search for |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **objectType** | [**List<string>**](string)| Object type(s) to search for | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **consumedResources** | **bool?**| Include resources each result item consumes | [optional]  |
| **consumingResources** | **bool?**| Include resources that consume each result item | [optional]  |
| **consumedResourceType** | [**List<string>**](string)| Types of consumed resources to return, if consumed resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **consumingResourceType** | [**List<string>**](string)| Types of consuming resources to return, if consuming resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |

### Return type

[**DependencyObjectEntityListing**](DependencyObjectEntityListing)


## GetArchitectDependencytrackingBuild

> [**DependencyStatus**](DependencyStatus) GetArchitectDependencytrackingBuild ()


Get Dependency Tracking build status for an organization

Requires ALL permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingBuildExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();

            try
            { 
                // Get Dependency Tracking build status for an organization
                DependencyStatus result = apiInstance.GetArchitectDependencytrackingBuild();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**DependencyStatus**](DependencyStatus)


## GetArchitectDependencytrackingConsumedresources

> [**ConsumedResourcesEntityListing**](ConsumedResourcesEntityListing) GetArchitectDependencytrackingConsumedresources (string id, string version, string objectType, List<string> resourceType = null, int? pageNumber = null, int? pageSize = null)


Get resources that are consumed by a given Dependency Tracking object

Requires ALL permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingConsumedresourcesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var id = id_example;  // string | Consuming object ID
            var version = version_example;  // string | Consuming object version
            var objectType = objectType_example;  // string | Consuming object type.  Only versioned types are allowed here.
            var resourceType = new List<string>(); // List<string> | Types of consumed resources to show (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get resources that are consumed by a given Dependency Tracking object
                ConsumedResourcesEntityListing result = apiInstance.GetArchitectDependencytrackingConsumedresources(id, version, objectType, resourceType, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingConsumedresources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Consuming object ID |  |
| **version** | **string**| Consuming object version |  |
| **objectType** | **string**| Consuming object type.  Only versioned types are allowed here. | <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **resourceType** | [**List<string>**](string)| Types of consumed resources to show | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**ConsumedResourcesEntityListing**](ConsumedResourcesEntityListing)


## GetArchitectDependencytrackingConsumingresources

> [**ConsumingResourcesEntityListing**](ConsumingResourcesEntityListing) GetArchitectDependencytrackingConsumingresources (string id, string objectType, List<string> resourceType = null, string version = null, int? pageNumber = null, int? pageSize = null, string flowFilter = null)


Get resources that consume a given Dependency Tracking object

Requires ALL permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingConsumingresourcesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var id = id_example;  // string | Consumed object ID
            var objectType = objectType_example;  // string | Consumed object type
            var resourceType = new List<string>(); // List<string> | Types of consuming resources to show.  Only versioned types are allowed here. (optional) 
            var version = version_example;  // string | Object version (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var flowFilter = flowFilter_example;  // string | Show only checkedIn or published flows (optional) 

            try
            { 
                // Get resources that consume a given Dependency Tracking object
                ConsumingResourcesEntityListing result = apiInstance.GetArchitectDependencytrackingConsumingresources(id, objectType, resourceType, version, pageNumber, pageSize, flowFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingConsumingresources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Consumed object ID |  |
| **objectType** | **string**| Consumed object type | <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **resourceType** | [**List<string>**](string)| Types of consuming resources to show.  Only versioned types are allowed here. | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **version** | **string**| Object version | [optional]  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **flowFilter** | **string**| Show only checkedIn or published flows | [optional] <br />**Values**: checkedIn, published |

### Return type

[**ConsumingResourcesEntityListing**](ConsumingResourcesEntityListing)


## GetArchitectDependencytrackingDeletedresourceconsumers

> [**DependencyObjectEntityListing**](DependencyObjectEntityListing) GetArchitectDependencytrackingDeletedresourceconsumers (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)


Get Dependency Tracking objects that consume deleted resources

Requires ALL permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingDeletedresourceconsumersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var name = name_example;  // string | Name to search for (optional) 
            var objectType = new List<string>(); // List<string> | Object type(s) to search for (optional) 
            var flowFilter = flowFilter_example;  // string | Show only checkedIn or published flows (optional) 
            var consumedResources = true;  // bool? | Return consumed resources? (optional)  (default to false)
            var consumedResourceType = new List<string>(); // List<string> | Resource type(s) to return (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get Dependency Tracking objects that consume deleted resources
                DependencyObjectEntityListing result = apiInstance.GetArchitectDependencytrackingDeletedresourceconsumers(name, objectType, flowFilter, consumedResources, consumedResourceType, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingDeletedresourceconsumers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Name to search for | [optional]  |
| **objectType** | [**List<string>**](string)| Object type(s) to search for | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **flowFilter** | **string**| Show only checkedIn or published flows | [optional] <br />**Values**: checkedIn, published |
| **consumedResources** | **bool?**| Return consumed resources? | [optional] [default to false] |
| **consumedResourceType** | [**List<string>**](string)| Resource type(s) to return | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**DependencyObjectEntityListing**](DependencyObjectEntityListing)


## GetArchitectDependencytrackingObject

> [**DependencyObject**](DependencyObject) GetArchitectDependencytrackingObject (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null, bool? consumedResourceRequest = null)


Get a Dependency Tracking object

Requires ALL permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingObjectExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var id = id_example;  // string | Object ID
            var version = version_example;  // string | Object version (optional) 
            var objectType = objectType_example;  // string | Object type (optional) 
            var consumedResources = true;  // bool? | Include resources this item consumes (optional) 
            var consumingResources = true;  // bool? | Include resources that consume this item (optional) 
            var consumedResourceType = new List<string>(); // List<string> | Types of consumed resources to return, if consumed resources are requested (optional) 
            var consumingResourceType = new List<string>(); // List<string> | Types of consuming resources to return, if consuming resources are requested (optional) 
            var consumedResourceRequest = true;  // bool? | Indicate that this is going to look up a consumed resource object (optional) 

            try
            { 
                // Get a Dependency Tracking object
                DependencyObject result = apiInstance.GetArchitectDependencytrackingObject(id, version, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType, consumedResourceRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingObject: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Object ID |  |
| **version** | **string**| Object version | [optional]  |
| **objectType** | **string**| Object type | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **consumedResources** | **bool?**| Include resources this item consumes | [optional]  |
| **consumingResources** | **bool?**| Include resources that consume this item | [optional]  |
| **consumedResourceType** | [**List<string>**](string)| Types of consumed resources to return, if consumed resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **consumingResourceType** | [**List<string>**](string)| Types of consuming resources to return, if consuming resources are requested | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **consumedResourceRequest** | **bool?**| Indicate that this is going to look up a consumed resource object | [optional]  |

### Return type

[**DependencyObject**](DependencyObject)


## GetArchitectDependencytrackingType

> [**DependencyType**](DependencyType) GetArchitectDependencytrackingType (string typeId)


Get a Dependency Tracking type.

Requires ALL permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingTypeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var typeId = typeId_example;  // string | Type ID

            try
            { 
                // Get a Dependency Tracking type.
                DependencyType result = apiInstance.GetArchitectDependencytrackingType(typeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingType: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **typeId** | **string**| Type ID |  |

### Return type

[**DependencyType**](DependencyType)


## GetArchitectDependencytrackingTypes

> [**DependencyTypeEntityListing**](DependencyTypeEntityListing) GetArchitectDependencytrackingTypes (int? pageNumber = null, int? pageSize = null)


Get Dependency Tracking types.

Requires ALL permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingTypesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get Dependency Tracking types.
                DependencyTypeEntityListing result = apiInstance.GetArchitectDependencytrackingTypes(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**DependencyTypeEntityListing**](DependencyTypeEntityListing)


## GetArchitectDependencytrackingUpdatedresourceconsumers

> [**DependencyObjectEntityListing**](DependencyObjectEntityListing) GetArchitectDependencytrackingUpdatedresourceconsumers (string name = null, List<string> objectType = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)


Get Dependency Tracking objects that depend on updated resources

Requires ALL permissions: 

* architect:dependencyTracking:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectDependencytrackingUpdatedresourceconsumersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var name = name_example;  // string | Name to search for (optional) 
            var objectType = new List<string>(); // List<string> | Object type(s) to search for (optional) 
            var consumedResources = true;  // bool? | Return consumed resources? (optional)  (default to false)
            var consumedResourceType = new List<string>(); // List<string> | Resource type(s) to return (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get Dependency Tracking objects that depend on updated resources
                DependencyObjectEntityListing result = apiInstance.GetArchitectDependencytrackingUpdatedresourceconsumers(name, objectType, consumedResources, consumedResourceType, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectDependencytrackingUpdatedresourceconsumers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **name** | **string**| Name to search for | [optional]  |
| **objectType** | [**List<string>**](string)| Object type(s) to search for | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **consumedResources** | **bool?**| Return consumed resources? | [optional] [default to false] |
| **consumedResourceType** | [**List<string>**](string)| Resource type(s) to return | [optional] <br />**Values**: ACDLANGUAGE, ACDSKILL, ACDWRAPUPCODE, AUDIOCONNECTORBOT, BOTCONNECTORBOT, BOTCONNECTORINTEGRATION, BOTFLOW, BRIDGEACTION, COMMONMODULEFLOW, COMPOSERSCRIPT, CONTACTLIST, DATAACTION, DATATABLE, DECISIONTABLE, DIALOGENGINEBOT, DIALOGENGINEBOTVERSION, DIALOGFLOWAGENT, DIALOGFLOWCXAGENT, DIGITALBOTCONNECTOR, DIGITALBOTFLOW, DIVISION, EMAILROUTE, EMERGENCYGROUP, FLOWACTION, FLOWDATATYPE, FLOWMILESTONE, FLOWOUTCOME, GRAMMAR, GROUP, IMAGE, INBOUNDCALLFLOW, INBOUNDCHATFLOW, INBOUNDEMAILFLOW, INBOUNDSHORTMESSAGEFLOW, INQUEUECALLFLOW, INQUEUEEMAILFLOW, INQUEUESHORTMESSAGEFLOW, IVRCONFIGURATION, KNOWLEDGEBASE, KNOWLEDGEBASEDOCUMENT, LANGUAGE, LEXBOT, LEXBOTALIAS, LEXV2BOT, LEXV2BOTALIAS, NLUDOMAIN, NUANCEMIXBOT, NUANCEMIXINTEGRATION, OAUTHCLIENT, OUTBOUNDCALLFLOW, QUEUE, RECORDINGPOLICY, RESPONSE, SCHEDULE, SCHEDULEGROUP, SECUREACTION, SECURECALLFLOW, SMSPHONENUMBER, STTENGINE, SURVEYFORM, SURVEYINVITEFLOW, SYSTEMPROMPT, TTSENGINE, TTSVOICE, USER, USERPROMPT, UTILIZATIONLABEL, VOICEFLOW, VOICEMAILFLOW, VOICESURVEYFLOW, WIDGET, WORKFLOW, WORKITEMFLOW, WORKTYPE |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**DependencyObjectEntityListing**](DependencyObjectEntityListing)


## GetArchitectEmergencygroup

> [**EmergencyGroup**](EmergencyGroup) GetArchitectEmergencygroup (string emergencyGroupId)


Gets a emergency group by ID

Requires ALL permissions: 

* routing:emergencyGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectEmergencygroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var emergencyGroupId = emergencyGroupId_example;  // string | Emergency group ID

            try
            { 
                // Gets a emergency group by ID
                EmergencyGroup result = apiInstance.GetArchitectEmergencygroup(emergencyGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectEmergencygroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emergencyGroupId** | **string**| Emergency group ID |  |

### Return type

[**EmergencyGroup**](EmergencyGroup)


## GetArchitectEmergencygroups

> [**EmergencyGroupListing**](EmergencyGroupListing) GetArchitectEmergencygroups (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)


Get a list of emergency groups.

Requires ALL permissions: 

* routing:emergencyGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectEmergencygroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var name = name_example;  // string | Name of the Emergency Group to filter by. (optional) 

            try
            { 
                // Get a list of emergency groups.
                EmergencyGroupListing result = apiInstance.GetArchitectEmergencygroups(pageNumber, pageSize, sortBy, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectEmergencygroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **name** | **string**| Name of the Emergency Group to filter by. | [optional]  |

### Return type

[**EmergencyGroupListing**](EmergencyGroupListing)


## GetArchitectEmergencygroupsDivisionviews

> [**EmergencyGroupDivisionViewEntityListing**](EmergencyGroupDivisionViewEntityListing) GetArchitectEmergencygroupsDivisionviews (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, List<string> divisionId = null)


Get a pageable list of basic emergency group objects filterable by query parameters.

This returns emergency groups consisting of name and division. If one or more IDs are specified, the search will fetch flow outcomes that match the given ID(s) and not use any additional supplied query parameters in the search.

Requires ALL permissions: 

* routing:emergencyGroup:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectEmergencygroupsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var id = new List<string>(); // List<string> | ID of the Emergency Groups to filter by. (optional) 
            var name = name_example;  // string | Name of the Emergency Group to filter by. (optional) 
            var divisionId = new List<string>(); // List<string> | List of divisionIds on which to filter. (optional) 

            try
            { 
                // Get a pageable list of basic emergency group objects filterable by query parameters.
                EmergencyGroupDivisionViewEntityListing result = apiInstance.GetArchitectEmergencygroupsDivisionviews(pageNumber, pageSize, sortBy, sortOrder, id, name, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectEmergencygroupsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **id** | [**List<string>**](string)| ID of the Emergency Groups to filter by. | [optional]  |
| **name** | **string**| Name of the Emergency Group to filter by. | [optional]  |
| **divisionId** | [**List<string>**](string)| List of divisionIds on which to filter. | [optional]  |

### Return type

[**EmergencyGroupDivisionViewEntityListing**](EmergencyGroupDivisionViewEntityListing)


## GetArchitectGrammar

> [**Grammar**](Grammar) GetArchitectGrammar (string grammarId, bool? includeFileUrls = null)


Get a grammar

Returns a specified grammar

Requires ALL permissions: 

* architect:grammar:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectGrammarExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | grammar ID
            var includeFileUrls = true;  // bool? | Include grammar language file URLs (optional) 

            try
            { 
                // Get a grammar
                Grammar result = apiInstance.GetArchitectGrammar(grammarId, includeFileUrls);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectGrammar: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| grammar ID |  |
| **includeFileUrls** | **bool?**| Include grammar language file URLs | [optional]  |

### Return type

[**Grammar**](Grammar)


## GetArchitectGrammarLanguage

> [**GrammarLanguage**](GrammarLanguage) GetArchitectGrammarLanguage (string grammarId, string languageCode)


Get a grammar language.

Requires ALL permissions: 

* architect:grammar:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectGrammarLanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | Grammar ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Get a grammar language.
                GrammarLanguage result = apiInstance.GetArchitectGrammarLanguage(grammarId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectGrammarLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| Grammar ID |  |
| **languageCode** | **string**| Language |  |

### Return type

[**GrammarLanguage**](GrammarLanguage)


## GetArchitectGrammars

> [**GrammarListing**](GrammarListing) GetArchitectGrammars (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, bool? includeFileUrls = null)


Get a pageable list of grammars, filtered by query parameters

Multiple IDs can be specified, in which case all matching grammars will be returned, and no other parameters will be evaluated.

Requires ALL permissions: 

* architect:grammar:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectGrammarsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 
            var includeFileUrls = true;  // bool? | Include grammar language file URLs (optional) 

            try
            { 
                // Get a pageable list of grammars, filtered by query parameters
                GrammarListing result = apiInstance.GetArchitectGrammars(pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, includeFileUrls);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectGrammars: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to id]<br />**Values**: description, id, name |
| **sortOrder** | **string**| Sort order | [optional] [default to asc]<br />**Values**: asc, desc |
| **id** | [**List<string>**](string)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
| **includeFileUrls** | **bool?**| Include grammar language file URLs | [optional]  |

### Return type

[**GrammarListing**](GrammarListing)


## GetArchitectIvr

> [**IVR**](IVR) GetArchitectIvr (string ivrId)


Get an IVR config.

Requires ALL permissions: 

* routing:callRoute:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectIvrExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var ivrId = ivrId_example;  // string | IVR id

            try
            { 
                // Get an IVR config.
                IVR result = apiInstance.GetArchitectIvr(ivrId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectIvr: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ivrId** | **string**| IVR id |  |

### Return type

[**IVR**](IVR)


## GetArchitectIvrIdentityresolution

> [**IdentityResolutionConfig**](IdentityResolutionConfig) GetArchitectIvrIdentityresolution (string ivrId)


Get an IVR IdentityResolutionConfig.

Requires ALL permissions: 

* routing:callRoute:view
* routing:identityResolution:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectIvrIdentityresolutionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var ivrId = ivrId_example;  // string | IVR id

            try
            { 
                // Get an IVR IdentityResolutionConfig.
                IdentityResolutionConfig result = apiInstance.GetArchitectIvrIdentityresolution(ivrId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectIvrIdentityresolution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ivrId** | **string**| IVR id |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## GetArchitectIvrs

> [**IVREntityListing**](IVREntityListing) GetArchitectIvrs (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string dnis = null, string scheduleGroup = null, List<string> expand = null)


Get IVR configs.

Requires ALL permissions: 

* routing:callRoute:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectIvrsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var name = name_example;  // string | Name of the IVR to filter by. (optional) 
            var dnis = dnis_example;  // string | The phone number of the IVR to filter by. (optional) 
            var scheduleGroup = scheduleGroup_example;  // string | The Schedule Group of the IVR to filter by. (optional) 
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            { 
                // Get IVR configs.
                IVREntityListing result = apiInstance.GetArchitectIvrs(pageNumber, pageSize, sortBy, sortOrder, name, dnis, scheduleGroup, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectIvrs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **name** | **string**| Name of the IVR to filter by. | [optional]  |
| **dnis** | **string**| The phone number of the IVR to filter by. | [optional]  |
| **scheduleGroup** | **string**| The Schedule Group of the IVR to filter by. | [optional]  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand | [optional] <br />**Values**: identityresolution |

### Return type

[**IVREntityListing**](IVREntityListing)


## GetArchitectIvrsDivisionviews

> [**IVRDivisionViewEntityListing**](IVRDivisionViewEntityListing) GetArchitectIvrsDivisionviews (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, List<string> divisionId = null)


Get a pageable list of basic ivr configuration information objects filterable by query parameters.

Requires ALL permissions: 

* routing:callRoute:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectIvrsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var id = new List<string>(); // List<string> | ID of the IVR to filter by. (optional) 
            var name = name_example;  // string | Name of the IVR to filter by. (optional) 
            var divisionId = new List<string>(); // List<string> | List of divisionIds on which to filter. (optional) 

            try
            { 
                // Get a pageable list of basic ivr configuration information objects filterable by query parameters.
                IVRDivisionViewEntityListing result = apiInstance.GetArchitectIvrsDivisionviews(pageNumber, pageSize, sortBy, sortOrder, id, name, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectIvrsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **id** | [**List<string>**](string)| ID of the IVR to filter by. | [optional]  |
| **name** | **string**| Name of the IVR to filter by. | [optional]  |
| **divisionId** | [**List<string>**](string)| List of divisionIds on which to filter. | [optional]  |

### Return type

[**IVRDivisionViewEntityListing**](IVRDivisionViewEntityListing)


## GetArchitectPrompt

> [**Prompt**](Prompt) GetArchitectPrompt (string promptId, bool? includeMediaUris = null, bool? includeResources = null, List<string> language = null)


Get specified user prompt

Requires ALL permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectPromptExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var includeMediaUris = true;  // bool? | Include the media URIs for each resource (optional)  (default to true)
            var includeResources = true;  // bool? | Include the resources for each system prompt (optional)  (default to true)
            var language = new List<string>(); // List<string> | Filter the resources down to the provided languages (optional) 

            try
            { 
                // Get specified user prompt
                Prompt result = apiInstance.GetArchitectPrompt(promptId, includeMediaUris, includeResources, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPrompt: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **includeMediaUris** | **bool?**| Include the media URIs for each resource | [optional] [default to true] |
| **includeResources** | **bool?**| Include the resources for each system prompt | [optional] [default to true] |
| **language** | [**List<string>**](string)| Filter the resources down to the provided languages | [optional]  |

### Return type

[**Prompt**](Prompt)


## GetArchitectPromptHistoryHistoryId

> [**HistoryListing**](HistoryListing) GetArchitectPromptHistoryHistoryId (string promptId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null)


Get generated prompt history

Requires ALL permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectPromptHistoryHistoryIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var historyId = historyId_example;  // string | History request ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "desc")
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to timestamp)
            var action = new List<string>(); // List<string> | Flow actions to include (omit to include all) (optional) 

            try
            { 
                // Get generated prompt history
                HistoryListing result = apiInstance.GetArchitectPromptHistoryHistoryId(promptId, historyId, pageNumber, pageSize, sortOrder, sortBy, action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPromptHistoryHistoryId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **historyId** | **string**| History request ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortOrder** | **string**| Sort order | [optional] [default to "desc"] |
| **sortBy** | **string**| Sort by | [optional] [default to timestamp]<br />**Values**: action, timestamp, user |
| **action** | [**List<string>**](string)| Flow actions to include (omit to include all) | [optional] <br />**Values**: checkin, checkout, create, deactivate, debug, delete, publish, revert, save |

### Return type

[**HistoryListing**](HistoryListing)


## GetArchitectPromptResource

> [**PromptAsset**](PromptAsset) GetArchitectPromptResource (string promptId, string languageCode)


Get specified user prompt resource

Requires ALL permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectPromptResourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Get specified user prompt resource
                PromptAsset result = apiInstance.GetArchitectPromptResource(promptId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPromptResource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |

### Return type

[**PromptAsset**](PromptAsset)


## GetArchitectPromptResources

> [**PromptAssetEntityListing**](PromptAssetEntityListing) GetArchitectPromptResources (string promptId, int? pageNumber = null, int? pageSize = null)


Get a pageable list of user prompt resources

The returned list is pageable, and query parameters can be used for filtering.

Requires ALL permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectPromptResourcesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get a pageable list of user prompt resources
                PromptAssetEntityListing result = apiInstance.GetArchitectPromptResources(promptId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPromptResources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**PromptAssetEntityListing**](PromptAssetEntityListing)


## GetArchitectPrompts

> [**PromptEntityListing**](PromptEntityListing) GetArchitectPrompts (int? pageNumber = null, int? pageSize = null, List<string> name = null, string description = null, string nameOrDescription = null, string sortBy = null, string sortOrder = null, bool? includeMediaUris = null, bool? includeResources = null, List<string> language = null)


Get a pageable list of user prompts

The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.

Requires ALL permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectPromptsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var name = new List<string>(); // List<string> | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "id")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")
            var includeMediaUris = true;  // bool? | Include the media URIs for each resource (optional)  (default to true)
            var includeResources = true;  // bool? | Include the resources for each system prompt (optional)  (default to true)
            var language = new List<string>(); // List<string> | Filter the resources down to the provided languages (optional) 

            try
            { 
                // Get a pageable list of user prompts
                PromptEntityListing result = apiInstance.GetArchitectPrompts(pageNumber, pageSize, name, description, nameOrDescription, sortBy, sortOrder, includeMediaUris, includeResources, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectPrompts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **name** | [**List<string>**](string)| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to "id"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |
| **includeMediaUris** | **bool?**| Include the media URIs for each resource | [optional] [default to true] |
| **includeResources** | **bool?**| Include the resources for each system prompt | [optional] [default to true] |
| **language** | [**List<string>**](string)| Filter the resources down to the provided languages | [optional]  |

### Return type

[**PromptEntityListing**](PromptEntityListing)


## GetArchitectSchedule

> [**Schedule**](Schedule) GetArchitectSchedule (string scheduleId)


Get a schedule by ID

Requires ALL permissions: 

* routing:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID

            try
            { 
                // Get a schedule by ID
                Schedule result = apiInstance.GetArchitectSchedule(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |

### Return type

[**Schedule**](Schedule)


## GetArchitectSchedulegroup

> [**ScheduleGroup**](ScheduleGroup) GetArchitectSchedulegroup (string scheduleGroupId)


Gets a schedule group by ID

Requires ALL permissions: 

* routing:scheduleGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSchedulegroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var scheduleGroupId = scheduleGroupId_example;  // string | Schedule group ID

            try
            { 
                // Gets a schedule group by ID
                ScheduleGroup result = apiInstance.GetArchitectSchedulegroup(scheduleGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSchedulegroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleGroupId** | **string**| Schedule group ID |  |

### Return type

[**ScheduleGroup**](ScheduleGroup)


## GetArchitectSchedulegroups

> [**ScheduleGroupEntityListing**](ScheduleGroupEntityListing) GetArchitectSchedulegroups (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string scheduleIds = null, List<string> divisionId = null)


Get a list of schedule groups.

Requires ALL permissions: 

* routing:scheduleGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSchedulegroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var name = name_example;  // string | Name of the Schedule Group to filter by. (optional) 
            var scheduleIds = scheduleIds_example;  // string | A comma-delimited list of Schedule IDs to filter by. (optional) 
            var divisionId = new List<string>(); // List<string> | List of divisionIds on which to filter. (optional) 

            try
            { 
                // Get a list of schedule groups.
                ScheduleGroupEntityListing result = apiInstance.GetArchitectSchedulegroups(pageNumber, pageSize, sortBy, sortOrder, name, scheduleIds, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSchedulegroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **name** | **string**| Name of the Schedule Group to filter by. | [optional]  |
| **scheduleIds** | **string**| A comma-delimited list of Schedule IDs to filter by. | [optional]  |
| **divisionId** | [**List<string>**](string)| List of divisionIds on which to filter. | [optional]  |

### Return type

[**ScheduleGroupEntityListing**](ScheduleGroupEntityListing)


## GetArchitectSchedulegroupsDivisionviews

> [**ScheduleGroupDivisionViewEntityListing**](ScheduleGroupDivisionViewEntityListing) GetArchitectSchedulegroupsDivisionviews (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, List<string> divisionId = null)


Get a pageable list of basic schedule group configuration information objects filterable by query parameters.

Requires ALL permissions: 

* routing:scheduleGroup:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSchedulegroupsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var id = new List<string>(); // List<string> | ID of the schedule group to filter by. (optional) 
            var name = name_example;  // string | Name of the schedule group to filter by. (optional) 
            var divisionId = new List<string>(); // List<string> | List of divisionIds on which to filter. (optional) 

            try
            { 
                // Get a pageable list of basic schedule group configuration information objects filterable by query parameters.
                ScheduleGroupDivisionViewEntityListing result = apiInstance.GetArchitectSchedulegroupsDivisionviews(pageNumber, pageSize, sortBy, sortOrder, id, name, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSchedulegroupsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **id** | [**List<string>**](string)| ID of the schedule group to filter by. | [optional]  |
| **name** | **string**| Name of the schedule group to filter by. | [optional]  |
| **divisionId** | [**List<string>**](string)| List of divisionIds on which to filter. | [optional]  |

### Return type

[**ScheduleGroupDivisionViewEntityListing**](ScheduleGroupDivisionViewEntityListing)


## GetArchitectSchedules

> [**ScheduleEntityListing**](ScheduleEntityListing) GetArchitectSchedules (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, List<string> divisionId = null)


Get a list of schedules.

Requires ALL permissions: 

* routing:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSchedulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")
            var name = name_example;  // string | Name of the Schedule to filter by. (optional) 
            var divisionId = new List<string>(); // List<string> | List of divisionIds on which to filter. (optional) 

            try
            { 
                // Get a list of schedules.
                ScheduleEntityListing result = apiInstance.GetArchitectSchedules(pageNumber, pageSize, sortBy, sortOrder, name, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |
| **name** | **string**| Name of the Schedule to filter by. | [optional]  |
| **divisionId** | [**List<string>**](string)| List of divisionIds on which to filter. | [optional]  |

### Return type

[**ScheduleEntityListing**](ScheduleEntityListing)


## GetArchitectSchedulesDivisionviews

> [**ScheduleDivisionViewEntityListing**](ScheduleDivisionViewEntityListing) GetArchitectSchedulesDivisionviews (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, List<string> divisionId = null)


Get a pageable list of basic schedule configuration information objects filterable by query parameters.

Requires ALL permissions: 

* routing:schedule:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSchedulesDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "name")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ASC")
            var id = new List<string>(); // List<string> | ID of the schedule group to filter by. (optional) 
            var name = name_example;  // string | Name of the schedule group to filter by. (optional) 
            var divisionId = new List<string>(); // List<string> | List of divisionIds on which to filter. (optional) 

            try
            { 
                // Get a pageable list of basic schedule configuration information objects filterable by query parameters.
                ScheduleDivisionViewEntityListing result = apiInstance.GetArchitectSchedulesDivisionviews(pageNumber, pageSize, sortBy, sortOrder, id, name, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSchedulesDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "name"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "ASC"] |
| **id** | [**List<string>**](string)| ID of the schedule group to filter by. | [optional]  |
| **name** | **string**| Name of the schedule group to filter by. | [optional]  |
| **divisionId** | [**List<string>**](string)| List of divisionIds on which to filter. | [optional]  |

### Return type

[**ScheduleDivisionViewEntityListing**](ScheduleDivisionViewEntityListing)


## GetArchitectSystemprompt

> [**SystemPrompt**](SystemPrompt) GetArchitectSystemprompt (string promptId, bool? includeMediaUris = null, bool? includeResources = null, List<string> language = null)


Get a system prompt

Requires ALL permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSystempromptExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | promptId
            var includeMediaUris = true;  // bool? | Include the media URIs for each resource (optional)  (default to true)
            var includeResources = true;  // bool? | Include the resources for each system prompt (optional)  (default to true)
            var language = new List<string>(); // List<string> | Filter the resources down to the provided languages (optional) 

            try
            { 
                // Get a system prompt
                SystemPrompt result = apiInstance.GetArchitectSystemprompt(promptId, includeMediaUris, includeResources, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSystemprompt: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| promptId |  |
| **includeMediaUris** | **bool?**| Include the media URIs for each resource | [optional] [default to true] |
| **includeResources** | **bool?**| Include the resources for each system prompt | [optional] [default to true] |
| **language** | [**List<string>**](string)| Filter the resources down to the provided languages | [optional]  |

### Return type

[**SystemPrompt**](SystemPrompt)


## GetArchitectSystempromptHistoryHistoryId

> [**HistoryListing**](HistoryListing) GetArchitectSystempromptHistoryHistoryId (string promptId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null)


Get generated prompt history

Requires ALL permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSystempromptHistoryHistoryIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | promptId
            var historyId = historyId_example;  // string | History request ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "desc")
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to timestamp)
            var action = new List<string>(); // List<string> | Flow actions to include (omit to include all) (optional) 

            try
            { 
                // Get generated prompt history
                HistoryListing result = apiInstance.GetArchitectSystempromptHistoryHistoryId(promptId, historyId, pageNumber, pageSize, sortOrder, sortBy, action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSystempromptHistoryHistoryId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| promptId |  |
| **historyId** | **string**| History request ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortOrder** | **string**| Sort order | [optional] [default to "desc"] |
| **sortBy** | **string**| Sort by | [optional] [default to timestamp]<br />**Values**: action, timestamp, user |
| **action** | [**List<string>**](string)| Flow actions to include (omit to include all) | [optional] <br />**Values**: checkin, checkout, create, deactivate, debug, delete, publish, revert, save |

### Return type

[**HistoryListing**](HistoryListing)


## GetArchitectSystempromptResource

> [**SystemPromptAsset**](SystemPromptAsset) GetArchitectSystempromptResource (string promptId, string languageCode)


Get a system prompt resource.

Requires ALL permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSystempromptResourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Get a system prompt resource.
                SystemPromptAsset result = apiInstance.GetArchitectSystempromptResource(promptId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSystempromptResource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |

### Return type

[**SystemPromptAsset**](SystemPromptAsset)


## GetArchitectSystempromptResources

> [**SystemPromptAssetEntityListing**](SystemPromptAssetEntityListing) GetArchitectSystempromptResources (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)


Get system prompt resources.

Requires ALL permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSystempromptResourcesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "id")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")

            try
            { 
                // Get system prompt resources.
                SystemPromptAssetEntityListing result = apiInstance.GetArchitectSystempromptResources(promptId, pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSystempromptResources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "id"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |

### Return type

[**SystemPromptAssetEntityListing**](SystemPromptAssetEntityListing)


## GetArchitectSystemprompts

> [**SystemPromptEntityListing**](SystemPromptEntityListing) GetArchitectSystemprompts (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null, bool? includeMediaUris = null, bool? includeResources = null, List<string> language = null)


Get System Prompts

Requires ALL permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetArchitectSystempromptsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "id")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")
            var name = name_example;  // string | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 
            var includeMediaUris = true;  // bool? | Include the media URIs for each resource (optional)  (default to true)
            var includeResources = true;  // bool? | Include the resources for each system prompt (optional)  (default to true)
            var language = new List<string>(); // List<string> | Filter the resources down to the provided languages (optional) 

            try
            { 
                // Get System Prompts
                SystemPromptEntityListing result = apiInstance.GetArchitectSystemprompts(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription, includeMediaUris, includeResources, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetArchitectSystemprompts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "id"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |
| **name** | **string**| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
| **includeMediaUris** | **bool?**| Include the media URIs for each resource | [optional] [default to true] |
| **includeResources** | **bool?**| Include the resources for each system prompt | [optional] [default to true] |
| **language** | [**List<string>**](string)| Filter the resources down to the provided languages | [optional]  |

### Return type

[**SystemPromptEntityListing**](SystemPromptEntityListing)


## GetFlow

> [**Flow**](Flow) GetFlow (string flowId, bool? deleted = null)


Get flow

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var deleted = true;  // bool? | Deleted flows (optional)  (default to false)

            try
            { 
                // Get flow
                Flow result = apiInstance.GetFlow(flowId, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **deleted** | **bool?**| Deleted flows | [optional] [default to false] |

### Return type

[**Flow**](Flow)


## GetFlowHistoryHistoryId

> [**HistoryListing**](HistoryListing) GetFlowHistoryHistoryId (string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null)


Get generated flow history

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowHistoryHistoryIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var historyId = historyId_example;  // string | History request ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "desc")
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to timestamp)
            var action = new List<string>(); // List<string> | Flow actions to include (omit to include all) (optional) 

            try
            { 
                // Get generated flow history
                HistoryListing result = apiInstance.GetFlowHistoryHistoryId(flowId, historyId, pageNumber, pageSize, sortOrder, sortBy, action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowHistoryHistoryId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **historyId** | **string**| History request ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortOrder** | **string**| Sort order | [optional] [default to "desc"] |
| **sortBy** | **string**| Sort by | [optional] [default to timestamp]<br />**Values**: action, timestamp, user |
| **action** | [**List<string>**](string)| Flow actions to include (omit to include all) | [optional] <br />**Values**: checkin, checkout, create, deactivate, debug, delete, publish, revert, save |

### Return type

[**HistoryListing**](HistoryListing)


## GetFlowInstancesSettingsLoglevels

> [**FlowSettingsResponse**](FlowSettingsResponse) GetFlowInstancesSettingsLoglevels (string flowId, List<string> expand = null)


Retrieves the log level for a flow by flow id.

Retrieves the log level for a flow by flow id.

Requires ALL permissions: 

* architect:flowLogLevel:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowInstancesSettingsLoglevelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | The flow id to get the loglevel for
            var expand = new List<string>(); // List<string> | Expand instructions for the result (optional) 

            try
            { 
                // Retrieves the log level for a flow by flow id.
                FlowSettingsResponse result = apiInstance.GetFlowInstancesSettingsLoglevels(flowId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowInstancesSettingsLoglevels: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| The flow id to get the loglevel for |  |
| **expand** | [**List<string>**](string)| Expand instructions for the result | [optional] <br />**Values**: name, type, logLevelCharacteristics.characteristics |

### Return type

[**FlowSettingsResponse**](FlowSettingsResponse)


## GetFlowLatestconfiguration

> **Object** GetFlowLatestconfiguration (string flowId, bool? deleted = null)


Get the latest configuration for flow

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowLatestconfigurationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var deleted = true;  // bool? | Deleted flows (optional)  (default to false)

            try
            { 
                // Get the latest configuration for flow
                Object result = apiInstance.GetFlowLatestconfiguration(flowId, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowLatestconfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **deleted** | **bool?**| Deleted flows | [optional] [default to false] |

### Return type

**Object**


## GetFlowVersion

> [**FlowVersion**](FlowVersion) GetFlowVersion (string flowId, string versionId, string deleted = null)


Get flow version

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowVersionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var versionId = versionId_example;  // string | Version ID
            var deleted = deleted_example;  // string | Deleted flows (optional) 

            try
            { 
                // Get flow version
                FlowVersion result = apiInstance.GetFlowVersion(flowId, versionId, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **versionId** | **string**| Version ID |  |
| **deleted** | **string**| Deleted flows | [optional]  |

### Return type

[**FlowVersion**](FlowVersion)


## GetFlowVersionConfiguration

> **Object** GetFlowVersionConfiguration (string flowId, string versionId, string deleted = null)


Get flow version configuration

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowVersionConfigurationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var versionId = versionId_example;  // string | Version ID
            var deleted = deleted_example;  // string | Deleted flows (optional) 

            try
            { 
                // Get flow version configuration
                Object result = apiInstance.GetFlowVersionConfiguration(flowId, versionId, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowVersionConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **versionId** | **string**| Version ID |  |
| **deleted** | **string**| Deleted flows | [optional]  |

### Return type

**Object**


## GetFlowVersionHealth

> [**FlowHealth**](FlowHealth) GetFlowVersionHealth (string flowId, string versionId, string language = null)


Get overall health scores for all intents present in the NLU domain version associated with the bot flow version.

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowVersionHealthExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID.
            var versionId = versionId_example;  // string | Version ID.
            var language = language_example;  // string | Language to filter for (optional) 

            try
            { 
                // Get overall health scores for all intents present in the NLU domain version associated with the bot flow version.
                FlowHealth result = apiInstance.GetFlowVersionHealth(flowId, versionId, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowVersionHealth: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID. |  |
| **versionId** | **string**| Version ID. |  |
| **language** | **string**| Language to filter for | [optional] <br />**Values**: en-us, en-gb, en-au, en-za, en-nz, en-ie, fr-ca, fr-fr, es-us, es-es, es-mx, de-de, it-it, pt-br, pt-pt, nl-nl |

### Return type

[**FlowHealth**](FlowHealth)


## GetFlowVersionIntentHealth

> [**FlowHealthIntent**](FlowHealthIntent) GetFlowVersionIntentHealth (string flowId, string versionId, string intentId, string language)


Get health scores and other health metrics for a specific intent. This includes the health metrics for each utterance in an intent.

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowVersionIntentHealthExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID.
            var versionId = versionId_example;  // string | Version ID.
            var intentId = intentId_example;  // string | Intent ID.
            var language = language_example;  // string | Language to filter for

            try
            { 
                // Get health scores and other health metrics for a specific intent. This includes the health metrics for each utterance in an intent.
                FlowHealthIntent result = apiInstance.GetFlowVersionIntentHealth(flowId, versionId, intentId, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowVersionIntentHealth: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID. |  |
| **versionId** | **string**| Version ID. |  |
| **intentId** | **string**| Intent ID. |  |
| **language** | **string**| Language to filter for | <br />**Values**: en-us, en-gb, en-au, en-za, en-nz, en-ie, fr-ca, fr-fr, es-us, es-es, es-mx, de-de, it-it, pt-br, pt-pt, nl-nl |

### Return type

[**FlowHealthIntent**](FlowHealthIntent)


## GetFlowVersionIntentUtteranceHealth

> [**FlowHealthUtterance**](FlowHealthUtterance) GetFlowVersionIntentUtteranceHealth (string flowId, string versionId, string intentId, string utteranceId, string language)


Get health metrics associated with a specific utterance of an intent.

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowVersionIntentUtteranceHealthExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID.
            var versionId = versionId_example;  // string | Version ID.
            var intentId = intentId_example;  // string | Intent ID.
            var utteranceId = utteranceId_example;  // string | Utterance ID.
            var language = language_example;  // string | Language to filter for

            try
            { 
                // Get health metrics associated with a specific utterance of an intent.
                FlowHealthUtterance result = apiInstance.GetFlowVersionIntentUtteranceHealth(flowId, versionId, intentId, utteranceId, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowVersionIntentUtteranceHealth: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID. |  |
| **versionId** | **string**| Version ID. |  |
| **intentId** | **string**| Intent ID. |  |
| **utteranceId** | **string**| Utterance ID. |  |
| **language** | **string**| Language to filter for | <br />**Values**: en-us, en-gb, en-au, en-za, en-nz, en-ie, fr-ca, fr-fr, es-us, es-es, es-mx, de-de, it-it, pt-br, pt-pt, nl-nl |

### Return type

[**FlowHealthUtterance**](FlowHealthUtterance)


## GetFlowVersions

> [**FlowVersionEntityListing**](FlowVersionEntityListing) GetFlowVersions (string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null)


Get flow version list

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var deleted = true;  // bool? | Include Deleted flows (optional) 

            try
            { 
                // Get flow version list
                FlowVersionEntityListing result = apiInstance.GetFlowVersions(flowId, pageNumber, pageSize, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **deleted** | **bool?**| Include Deleted flows | [optional]  |

### Return type

[**FlowVersionEntityListing**](FlowVersionEntityListing)


## GetFlows

> [**FlowEntityListing**](FlowEntityListing) GetFlows (List<string> type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string lockedByClientId = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null, List<string> divisionId = null)


Get a pageable list of flows, filtered by query parameters

If one or more IDs are specified, the search will fetch flows that match the given ID(s) and not use any additional supplied query parameters in the search.

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var type = new List<string>(); // List<string> | Type (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "id")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 
            var publishVersionId = publishVersionId_example;  // string | Publish version ID (optional) 
            var editableBy = editableBy_example;  // string | Editable by (optional) 
            var lockedBy = lockedBy_example;  // string | Locked by (optional) 
            var lockedByClientId = lockedByClientId_example;  // string | Locked by client ID (optional) 
            var secure = secure_example;  // string | Secure (optional) 
            var deleted = true;  // bool? | Include deleted (optional)  (default to false)
            var includeSchemas = true;  // bool? | Include variable schemas (optional)  (default to false)
            var publishedAfter = 2015-01-01T12:00:00-0600, 2015-01-01T18:00:00Z, 2015-01-01T12:00:00.000-0600, 2015-01-01T18:00:00.000Z, 2015-01-01;  // string | Published after (optional) 
            var publishedBefore = 2015-01-01T12:00:00-0600, 2015-01-01T18:00:00Z, 2015-01-01T12:00:00.000-0600, 2015-01-01T18:00:00.000Z, 2015-01-01;  // string | Published before (optional) 
            var divisionId = new List<string>(); // List<string> | division ID(s) (optional) 

            try
            { 
                // Get a pageable list of flows, filtered by query parameters
                FlowEntityListing result = apiInstance.GetFlows(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, lockedByClientId, secure, deleted, includeSchemas, publishedAfter, publishedBefore, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlows: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | [**List<string>**](string)| Type | [optional] <br />**Values**: bot, commonmodule, digitalbot, inboundcall, inboundchat, inboundemail, inboundshortmessage, outboundcall, inqueuecall, inqueueemail, inqueueshortmessage, speech, securecall, surveyinvite, voice, voicemail, voicesurvey, workflow, workitem |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "id"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |
| **id** | [**List<string>**](string)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
| **publishVersionId** | **string**| Publish version ID | [optional]  |
| **editableBy** | **string**| Editable by | [optional]  |
| **lockedBy** | **string**| Locked by | [optional]  |
| **lockedByClientId** | **string**| Locked by client ID | [optional]  |
| **secure** | **string**| Secure | [optional] <br />**Values**: any, checkedin, published |
| **deleted** | **bool?**| Include deleted | [optional] [default to false] |
| **includeSchemas** | **bool?**| Include variable schemas | [optional] [default to false] |
| **publishedAfter** | **string**| Published after | [optional]  |
| **publishedBefore** | **string**| Published before | [optional]  |
| **divisionId** | [**List<string>**](string)| division ID(s) | [optional]  |

### Return type

[**FlowEntityListing**](FlowEntityListing)


## GetFlowsDatatable

> [**DataTable**](DataTable) GetFlowsDatatable (string datatableId, string expand = null)


Returns a specific datatable by id

Given a datatableId returns the datatable object and schema associated with it.

Requires ANY permissions: 

* architect:datatable:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatableExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var expand = expand_example;  // string | Expand instructions for the result (optional) 

            try
            { 
                // Returns a specific datatable by id
                DataTable result = apiInstance.GetFlowsDatatable(datatableId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **expand** | **string**| Expand instructions for the result | [optional] <br />**Values**: schema |

### Return type

[**DataTable**](DataTable)


## GetFlowsDatatableExportJob

> [**DataTableExportJob**](DataTableExportJob) GetFlowsDatatableExportJob (string datatableId, string exportJobId)


Returns the state information about an export job

Returns the state information about an export job.

Requires ANY permissions: 

* architect:datatable:view
* architect:datatableRow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatableExportJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var exportJobId = exportJobId_example;  // string | id of export job

            try
            { 
                // Returns the state information about an export job
                DataTableExportJob result = apiInstance.GetFlowsDatatableExportJob(datatableId, exportJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatableExportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **exportJobId** | **string**| id of export job |  |

### Return type

[**DataTableExportJob**](DataTableExportJob)


## GetFlowsDatatableImportJob

> [**DataTableImportJob**](DataTableImportJob) GetFlowsDatatableImportJob (string datatableId, string importJobId)


Returns the state information about an import job

Returns the state information about an import job.

Requires ANY permissions: 

* architect:datatable:view
* architect:datatableRow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatableImportJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var importJobId = importJobId_example;  // string | id of import job

            try
            { 
                // Returns the state information about an import job
                DataTableImportJob result = apiInstance.GetFlowsDatatableImportJob(datatableId, importJobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatableImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **importJobId** | **string**| id of import job |  |

### Return type

[**DataTableImportJob**](DataTableImportJob)


## GetFlowsDatatableImportJobs

> [**DataTableImportEntityListing**](DataTableImportEntityListing) GetFlowsDatatableImportJobs (string datatableId, int? pageNumber = null, int? pageSize = null)


Get all recent import jobs

Get all recent import jobs

Requires ANY permissions: 

* architect:datatable:edit
* architect:datatableRow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatableImportJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get all recent import jobs
                DataTableImportEntityListing result = apiInstance.GetFlowsDatatableImportJobs(datatableId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatableImportJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**DataTableImportEntityListing**](DataTableImportEntityListing)


## GetFlowsDatatableRow

> **Dictionary&lt;string, Object&gt;** GetFlowsDatatableRow (string datatableId, string rowId, bool? showbrief = null)


Returns a specific row for the datatable

Given a datatableId and a rowId (the value of the key field) this will return the full row contents for that rowId.

Requires ANY permissions: 

* architect:datatable:view
* architect:datatableRow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatableRowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var rowId = rowId_example;  // string | The key for the row
            var showbrief = true;  // bool? | if true returns just the key field for the row (optional)  (default to true)

            try
            { 
                // Returns a specific row for the datatable
                Dictionary<string, Object> result = apiInstance.GetFlowsDatatableRow(datatableId, rowId, showbrief);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatableRow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **rowId** | **string**| The key for the row |  |
| **showbrief** | **bool?**| if true returns just the key field for the row | [optional] [default to true] |

### Return type

**Dictionary<string, Object>**


## GetFlowsDatatableRows

> [**DataTableRowEntityListing**](DataTableRowEntityListing) GetFlowsDatatableRows (string datatableId, int? pageNumber = null, int? pageSize = null, bool? showbrief = null, string sortOrder = null)


Returns the rows for the datatable with the given id

Returns all of the rows for the datatable with the given datatableId.  By default this will just be a truncated list returning the key for each row. Set showBrief to false to return all of the row contents.

Requires ANY permissions: 

* architect:datatable:view
* architect:datatableRow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatableRowsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var showbrief = true;  // bool? | If true returns just the key value of the row (optional)  (default to true)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)

            try
            { 
                // Returns the rows for the datatable with the given id
                DataTableRowEntityListing result = apiInstance.GetFlowsDatatableRows(datatableId, pageNumber, pageSize, showbrief, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatableRows: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **showbrief** | **bool?**| If true returns just the key value of the row | [optional] [default to true] |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |

### Return type

[**DataTableRowEntityListing**](DataTableRowEntityListing)


## GetFlowsDatatables

> [**DataTablesDomainEntityListing**](DataTablesDomainEntityListing) GetFlowsDatatables (string expand = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> divisionId = null, string name = null)


Retrieve a list of datatables for the org

Returns a metadata list of the datatables associated with this org, including datatableId, name and description.

Requires ANY permissions: 

* architect:datatable:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatablesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var expand = expand_example;  // string | Expand instructions for the result (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ascending")
            var divisionId = new List<string>(); // List<string> | division ID(s) (optional) 
            var name = exactMatch, beginsWith*, *endsWith, *contains*;  // string | Filter by Name. The wildcard character * is supported within the filter. Matches are case-insensitive. (optional) 

            try
            { 
                // Retrieve a list of datatables for the org
                DataTablesDomainEntityListing result = apiInstance.GetFlowsDatatables(expand, pageNumber, pageSize, sortBy, sortOrder, divisionId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatables: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | **string**| Expand instructions for the result | [optional] <br />**Values**: schema |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to id]<br />**Values**: id, name |
| **sortOrder** | **string**| Sort order | [optional] [default to "ascending"] |
| **divisionId** | [**List<string>**](string)| division ID(s) | [optional]  |
| **name** | **string**| Filter by Name. The wildcard character * is supported within the filter. Matches are case-insensitive. | [optional]  |

### Return type

[**DataTablesDomainEntityListing**](DataTablesDomainEntityListing)


## GetFlowsDatatablesDivisionview

> [**DataTable**](DataTable) GetFlowsDatatablesDivisionview (string datatableId, string expand = null)


Returns a specific datatable by id

Given a datatableId returns the datatable object and schema associated with it.

Requires ALL permissions: 

* architect:datatable:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatablesDivisionviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var expand = expand_example;  // string | Expand instructions for the result (optional) 

            try
            { 
                // Returns a specific datatable by id
                DataTable result = apiInstance.GetFlowsDatatablesDivisionview(datatableId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatablesDivisionview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **expand** | **string**| Expand instructions for the result | [optional] <br />**Values**: schema |

### Return type

[**DataTable**](DataTable)


## GetFlowsDatatablesDivisionviews

> [**DataTablesDomainEntityListing**](DataTablesDomainEntityListing) GetFlowsDatatablesDivisionviews (string expand = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> divisionId = null, string name = null)


Retrieve a list of datatables for the org

Returns a metadata list of the datatables associated with this org, including datatableId, name and description.

Requires ALL permissions: 

* architect:datatable:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDatatablesDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var expand = expand_example;  // string | Expand instructions for the result (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "ascending")
            var divisionId = new List<string>(); // List<string> | division ID(s) (optional) 
            var name = exactMatch, beginsWith*, *endsWith, *contains*;  // string | Filter by Name. The wildcard character * is supported within the filter. Matches are case-insensitive. (optional) 

            try
            { 
                // Retrieve a list of datatables for the org
                DataTablesDomainEntityListing result = apiInstance.GetFlowsDatatablesDivisionviews(expand, pageNumber, pageSize, sortBy, sortOrder, divisionId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDatatablesDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | **string**| Expand instructions for the result | [optional] <br />**Values**: schema |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to id]<br />**Values**: id, name |
| **sortOrder** | **string**| Sort order | [optional] [default to "ascending"] |
| **divisionId** | [**List<string>**](string)| division ID(s) | [optional]  |
| **name** | **string**| Filter by Name. The wildcard character * is supported within the filter. Matches are case-insensitive. | [optional]  |

### Return type

[**DataTablesDomainEntityListing**](DataTablesDomainEntityListing)


## GetFlowsDivisionviews

> [**FlowDivisionViewEntityListing**](FlowDivisionViewEntityListing) GetFlowsDivisionviews (List<string> type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string publishVersionId = null, string publishedAfter = null, string publishedBefore = null, List<string> divisionId = null, bool? includeSchemas = null)


Get a pageable list of basic flow information objects filterable by query parameters.

This returns a simplified version of /flow consisting of name and type. If one or more IDs are specified, the search will fetch flows that match the given ID(s) and not use any additional supplied query parameters in the search.

Requires ALL permissions: 

* architect:flow:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var type = new List<string>(); // List<string> | Type (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "id")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var publishVersionId = publishVersionId_example;  // string | Publish version ID (optional) 
            var publishedAfter = 2015-01-01T12:00:00-0600, 2015-01-01T18:00:00Z, 2015-01-01T12:00:00.000-0600, 2015-01-01T18:00:00.000Z, 2015-01-01;  // string | Published after (optional) 
            var publishedBefore = 2015-01-01T12:00:00-0600, 2015-01-01T18:00:00Z, 2015-01-01T12:00:00.000-0600, 2015-01-01T18:00:00.000Z, 2015-01-01;  // string | Published before (optional) 
            var divisionId = new List<string>(); // List<string> | division ID(s) (optional) 
            var includeSchemas = true;  // bool? | Include variable schemas (optional)  (default to false)

            try
            { 
                // Get a pageable list of basic flow information objects filterable by query parameters.
                FlowDivisionViewEntityListing result = apiInstance.GetFlowsDivisionviews(type, pageNumber, pageSize, sortBy, sortOrder, id, name, publishVersionId, publishedAfter, publishedBefore, divisionId, includeSchemas);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | [**List<string>**](string)| Type | [optional] <br />**Values**: bot, commonmodule, digitalbot, inboundcall, inboundchat, inboundemail, inboundshortmessage, outboundcall, inqueuecall, inqueueemail, inqueueshortmessage, speech, securecall, surveyinvite, voice, voicemail, voicesurvey, workflow, workitem |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "id"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |
| **id** | [**List<string>**](string)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **publishVersionId** | **string**| Publish version ID | [optional]  |
| **publishedAfter** | **string**| Published after | [optional]  |
| **publishedBefore** | **string**| Published before | [optional]  |
| **divisionId** | [**List<string>**](string)| division ID(s) | [optional]  |
| **includeSchemas** | **bool?**| Include variable schemas | [optional] [default to false] |

### Return type

[**FlowDivisionViewEntityListing**](FlowDivisionViewEntityListing)


## GetFlowsExecution

> [**FlowRuntimeExecution**](FlowRuntimeExecution) GetFlowsExecution (string flowExecutionId)


Get a flow execution's details. Flow execution details are available for several days after the flow is started.

Requires ANY permissions: 

* architect:flowExecution:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsExecutionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowExecutionId = flowExecutionId_example;  // string | flow execution ID

            try
            { 
                // Get a flow execution's details. Flow execution details are available for several days after the flow is started.
                FlowRuntimeExecution result = apiInstance.GetFlowsExecution(flowExecutionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsExecution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowExecutionId** | **string**| flow execution ID |  |

### Return type

[**FlowRuntimeExecution**](FlowRuntimeExecution)


## GetFlowsExportJob

> [**ArchitectExportJobStateResponse**](ArchitectExportJobStateResponse) GetFlowsExportJob (string jobId, List<string> expand = null)


Fetch Architect Export Job Status

Requires ALL permissions: 

* architect:jobExport:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsExportJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var jobId = jobId_example;  // string | Job ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Fetch Architect Export Job Status
                ArchitectExportJobStateResponse result = apiInstance.GetFlowsExportJob(jobId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsExportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| Job ID |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: messages |

### Return type

[**ArchitectExportJobStateResponse**](ArchitectExportJobStateResponse)


## GetFlowsInstance

> [**GetFlowExecutionDataJobResult**](GetFlowExecutionDataJobResult) GetFlowsInstance (string instanceId, string expand = null)


Start a process (job) to prepare a download of a singular flow execution data instance by Id

Returns a JobResult object that contains an ID that can be used to check status and/or download links when the process (job) is complete.

Requires ANY permissions: 

* architect:flowInstance:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsInstanceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var instanceId = instanceId_example;  // string | Instance ID
            var expand = expand_example;  // string | Expand various details. (optional) 

            try
            { 
                // Start a process (job) to prepare a download of a singular flow execution data instance by Id
                GetFlowExecutionDataJobResult result = apiInstance.GetFlowsInstance(instanceId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **instanceId** | **string**| Instance ID |  |
| **expand** | **string**| Expand various details. | [optional] <br />**Values**: bots, dataActions |

### Return type

[**GetFlowExecutionDataJobResult**](GetFlowExecutionDataJobResult)


## GetFlowsInstancesJob

> [**GetFlowExecutionDataJobResult**](GetFlowExecutionDataJobResult) GetFlowsInstancesJob (string jobId)


Get the status and/or results of an asynchronous flow execution data retrieval job

Requires ANY permissions: 

* architect:flowInstance:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsInstancesJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var jobId = jobId_example;  // string | The asynchronous job ID

            try
            { 
                // Get the status and/or results of an asynchronous flow execution data retrieval job
                GetFlowExecutionDataJobResult result = apiInstance.GetFlowsInstancesJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsInstancesJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| The asynchronous job ID |  |

### Return type

[**GetFlowExecutionDataJobResult**](GetFlowExecutionDataJobResult)


## GetFlowsInstancesQuerycapabilities

> [**FlowsQueryCriteriaResponse**](FlowsQueryCriteriaResponse) GetFlowsInstancesQuerycapabilities (string expand = null)


Retrieve a list of capabilities that the org can use to query for execution data

Returns the queryable parameters that can be used to build a query for execution data.

Requires ANY permissions: 

* architect:flowInstance:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsInstancesQuerycapabilitiesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var expand = expand_example;  // string | Expand various query types. (optional) 

            try
            { 
                // Retrieve a list of capabilities that the org can use to query for execution data
                FlowsQueryCriteriaResponse result = apiInstance.GetFlowsInstancesQuerycapabilities(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsInstancesQuerycapabilities: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | **string**| Expand various query types. | [optional] <br />**Values**: flow, action |

### Return type

[**FlowsQueryCriteriaResponse**](FlowsQueryCriteriaResponse)


## GetFlowsInstancesSettingsExecutiondata

> [**ExecutionDataFlowSettingsResponse**](ExecutionDataFlowSettingsResponse) GetFlowsInstancesSettingsExecutiondata ()


Get the execution history enabled setting.

Get the execution history enabled setting.

Requires ANY permissions: 

* architect:flowinstanceexecutiondata:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsInstancesSettingsExecutiondataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();

            try
            { 
                // Get the execution history enabled setting.
                ExecutionDataFlowSettingsResponse result = apiInstance.GetFlowsInstancesSettingsExecutiondata();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsInstancesSettingsExecutiondata: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ExecutionDataFlowSettingsResponse**](ExecutionDataFlowSettingsResponse)


## GetFlowsInstancesSettingsLoglevels

> [**FlowSettingsResponseEntityListing**](FlowSettingsResponseEntityListing) GetFlowsInstancesSettingsLoglevels (List<string> expand = null, int? pageNumber = null, int? pageSize = null)


Retrieve a list of LogLevels for the organization.

Returns a paged set of LogLevels per flow id

Requires ALL permissions: 

* architect:flowLogLevel:view
* architect:flow:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsInstancesSettingsLoglevelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var expand = new List<string>(); // List<string> | Expand instructions for the result (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Number of entities to return. Maximum of 200. (optional)  (default to 25)

            try
            { 
                // Retrieve a list of LogLevels for the organization.
                FlowSettingsResponseEntityListing result = apiInstance.GetFlowsInstancesSettingsLoglevels(expand, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsInstancesSettingsLoglevels: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string)| Expand instructions for the result | [optional] <br />**Values**: name, type, logLevelCharacteristics.characteristics |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Number of entities to return. Maximum of 200. | [optional] [default to 25] |

### Return type

[**FlowSettingsResponseEntityListing**](FlowSettingsResponseEntityListing)


## GetFlowsInstancesSettingsLoglevelsCharacteristics

> [**FlowLogLevelCharacteristicsDefinitions**](FlowLogLevelCharacteristicsDefinitions) GetFlowsInstancesSettingsLoglevelsCharacteristics ()


Gets the available flow log level characteristics for this organization.

Log levels can be customized and this returns the set of available characteristics that can be enabled/disabled.

Requires ANY permissions: 

* architect:flowLogLevel:view
* architect:flowLogLevelDefault:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsInstancesSettingsLoglevelsCharacteristicsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();

            try
            { 
                // Gets the available flow log level characteristics for this organization.
                FlowLogLevelCharacteristicsDefinitions result = apiInstance.GetFlowsInstancesSettingsLoglevelsCharacteristics();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsInstancesSettingsLoglevelsCharacteristics: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**FlowLogLevelCharacteristicsDefinitions**](FlowLogLevelCharacteristicsDefinitions)


## GetFlowsInstancesSettingsLoglevelsDefault

> [**FlowSettingsResponse**](FlowSettingsResponse) GetFlowsInstancesSettingsLoglevelsDefault (List<string> expand = null)


Returns the flow default log level.

Returns the flow default log level which will be used if no specific flow id log level is found.

Requires ANY permissions: 

* architect:flowLogLevelDefault:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsInstancesSettingsLoglevelsDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var expand = new List<string>(); // List<string> | Expand instructions for the result (optional) 

            try
            { 
                // Returns the flow default log level.
                FlowSettingsResponse result = apiInstance.GetFlowsInstancesSettingsLoglevelsDefault(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsInstancesSettingsLoglevelsDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string)| Expand instructions for the result | [optional] <br />**Values**: logLevelCharacteristics.characteristics |

### Return type

[**FlowSettingsResponse**](FlowSettingsResponse)


## GetFlowsJob

> [**ArchitectJobStateResponse**](ArchitectJobStateResponse) GetFlowsJob (string jobId, List<string> expand = null)


Fetch Architect Job Status

Requires ALL permissions: 

* architect:job:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var jobId = jobId_example;  // string | Job ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            { 
                // Fetch Architect Job Status
                ArchitectJobStateResponse result = apiInstance.GetFlowsJob(jobId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| Job ID |  |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: messages |

### Return type

[**ArchitectJobStateResponse**](ArchitectJobStateResponse)


## GetFlowsMilestone

> [**FlowMilestone**](FlowMilestone) GetFlowsMilestone (string milestoneId)


Get a flow milestone

Returns a specified flow milestone

Requires ALL permissions: 

* architect:flowMilestone:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsMilestoneExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var milestoneId = milestoneId_example;  // string | flow milestone ID

            try
            { 
                // Get a flow milestone
                FlowMilestone result = apiInstance.GetFlowsMilestone(milestoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsMilestone: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **milestoneId** | **string**| flow milestone ID |  |

### Return type

[**FlowMilestone**](FlowMilestone)


## GetFlowsMilestones

> [**FlowMilestoneListing**](FlowMilestoneListing) GetFlowsMilestones (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, List<string> divisionId = null)


Get a pageable list of flow milestones, filtered by query parameters

Multiple IDs can be specified, in which case all matching flow milestones will be returned, and no other parameters will be evaluated.

Requires ALL permissions: 

* architect:flowMilestone:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsMilestonesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "id")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 
            var divisionId = new List<string>(); // List<string> | division ID(s) (optional) 

            try
            { 
                // Get a pageable list of flow milestones, filtered by query parameters
                FlowMilestoneListing result = apiInstance.GetFlowsMilestones(pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsMilestones: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "id"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |
| **id** | [**List<string>**](string)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
| **divisionId** | [**List<string>**](string)| division ID(s) | [optional]  |

### Return type

[**FlowMilestoneListing**](FlowMilestoneListing)


## GetFlowsMilestonesDivisionviews

> [**FlowMilestoneDivisionViewEntityListing**](FlowMilestoneDivisionViewEntityListing) GetFlowsMilestonesDivisionviews (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, List<string> divisionId = null)


Get a pageable list of basic flow milestone information objects filterable by query parameters.

This returns flow milestones consisting of name and division. If one or more IDs are specified, the search will fetch flow milestones that match the given ID(s) and not use any additional supplied query parameters in the search.

Requires ALL permissions: 

* architect:flowMilestone:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsMilestonesDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "id")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var divisionId = new List<string>(); // List<string> | division ID(s) (optional) 

            try
            { 
                // Get a pageable list of basic flow milestone information objects filterable by query parameters.
                FlowMilestoneDivisionViewEntityListing result = apiInstance.GetFlowsMilestonesDivisionviews(pageNumber, pageSize, sortBy, sortOrder, id, name, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsMilestonesDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "id"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |
| **id** | [**List<string>**](string)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **divisionId** | [**List<string>**](string)| division ID(s) | [optional]  |

### Return type

[**FlowMilestoneDivisionViewEntityListing**](FlowMilestoneDivisionViewEntityListing)


## GetFlowsOutcome

> [**FlowOutcome**](FlowOutcome) GetFlowsOutcome (string flowOutcomeId)


Get a flow outcome

Returns a specified flow outcome

Requires ALL permissions: 

* architect:flowOutcome:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsOutcomeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowOutcomeId = flowOutcomeId_example;  // string | flow outcome ID

            try
            { 
                // Get a flow outcome
                FlowOutcome result = apiInstance.GetFlowsOutcome(flowOutcomeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsOutcome: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowOutcomeId** | **string**| flow outcome ID |  |

### Return type

[**FlowOutcome**](FlowOutcome)


## GetFlowsOutcomes

> [**FlowOutcomeListing**](FlowOutcomeListing) GetFlowsOutcomes (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, List<string> divisionId = null)


Get a pageable list of flow outcomes, filtered by query parameters

Multiple IDs can be specified, in which case all matching flow outcomes will be returned, and no other parameters will be evaluated.

Requires ALL permissions: 

* architect:flowOutcome:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsOutcomesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "id")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 
            var divisionId = new List<string>(); // List<string> | division ID(s) (optional) 

            try
            { 
                // Get a pageable list of flow outcomes, filtered by query parameters
                FlowOutcomeListing result = apiInstance.GetFlowsOutcomes(pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsOutcomes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "id"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |
| **id** | [**List<string>**](string)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
| **divisionId** | [**List<string>**](string)| division ID(s) | [optional]  |

### Return type

[**FlowOutcomeListing**](FlowOutcomeListing)


## GetFlowsOutcomesDivisionviews

> [**FlowOutcomeDivisionViewEntityListing**](FlowOutcomeDivisionViewEntityListing) GetFlowsOutcomesDivisionviews (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, List<string> divisionId = null)


Get a pageable list of basic flow outcome information objects filterable by query parameters.

This returns flow outcomes consisting of name and division. If one or more IDs are specified, the search will fetch flow outcomes that match the given ID(s) and not use any additional supplied query parameters in the search.

Requires ALL permissions: 

* architect:flowOutcome:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetFlowsOutcomesDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to "id")
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to "asc")
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var divisionId = new List<string>(); // List<string> | division ID(s) (optional) 

            try
            { 
                // Get a pageable list of basic flow outcome information objects filterable by query parameters.
                FlowOutcomeDivisionViewEntityListing result = apiInstance.GetFlowsOutcomesDivisionviews(pageNumber, pageSize, sortBy, sortOrder, id, name, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.GetFlowsOutcomesDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to "id"] |
| **sortOrder** | **string**| Sort order | [optional] [default to "asc"] |
| **id** | [**List<string>**](string)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **divisionId** | [**List<string>**](string)| division ID(s) | [optional]  |

### Return type

[**FlowOutcomeDivisionViewEntityListing**](FlowOutcomeDivisionViewEntityListing)


## PatchArchitectGrammar

> [**Grammar**](Grammar) PatchArchitectGrammar (string grammarId, Grammar body = null)


Updates a grammar

Requires ALL permissions: 

* architect:grammar:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchArchitectGrammarExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | grammar ID
            var body = new Grammar(); // Grammar |  (optional) 

            try
            { 
                // Updates a grammar
                Grammar result = apiInstance.PatchArchitectGrammar(grammarId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PatchArchitectGrammar: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| grammar ID |  |
| **body** | [**Grammar**](Grammar)|  | [optional]  |

### Return type

[**Grammar**](Grammar)


## PatchArchitectGrammarLanguage

> [**GrammarLanguage**](GrammarLanguage) PatchArchitectGrammarLanguage (string grammarId, string languageCode, GrammarLanguageUpdate body = null)


Updates a grammar language

Requires ALL permissions: 

* architect:grammar:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchArchitectGrammarLanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | Grammar ID
            var languageCode = languageCode_example;  // string | Language
            var body = new GrammarLanguageUpdate(); // GrammarLanguageUpdate |  (optional) 

            try
            { 
                // Updates a grammar language
                GrammarLanguage result = apiInstance.PatchArchitectGrammarLanguage(grammarId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PatchArchitectGrammarLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| Grammar ID |  |
| **languageCode** | **string**| Language |  |
| **body** | [**GrammarLanguageUpdate**](GrammarLanguageUpdate)|  | [optional]  |

### Return type

[**GrammarLanguage**](GrammarLanguage)


## PatchFlowsInstancesSettingsExecutiondata

> [**ExecutionDataFlowSettingsResponse**](ExecutionDataFlowSettingsResponse) PatchFlowsInstancesSettingsExecutiondata (ExecutionDataSettingsRequest body)


Edit the execution history enabled setting.

Edit the execution history enabled setting.

Requires ANY permissions: 

* architect:flowinstanceexecutiondata:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchFlowsInstancesSettingsExecutiondataExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new ExecutionDataSettingsRequest(); // ExecutionDataSettingsRequest | New Execution Data Setting

            try
            { 
                // Edit the execution history enabled setting.
                ExecutionDataFlowSettingsResponse result = apiInstance.PatchFlowsInstancesSettingsExecutiondata(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PatchFlowsInstancesSettingsExecutiondata: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExecutionDataSettingsRequest**](ExecutionDataSettingsRequest)| New Execution Data Setting |  |

### Return type

[**ExecutionDataFlowSettingsResponse**](ExecutionDataFlowSettingsResponse)


## PostArchitectDependencytrackingBuild

> void PostArchitectDependencytrackingBuild ()


Rebuild Dependency Tracking data for an organization

Asynchronous.  Notification topic: v2.architect.dependencytracking.build

Requires ALL permissions: 

* architect:dependencyTracking:rebuild

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectDependencytrackingBuildExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();

            try
            { 
                // Rebuild Dependency Tracking data for an organization
                apiInstance.PostArchitectDependencytrackingBuild();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectDependencytrackingBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## PostArchitectEmergencygroups

> [**EmergencyGroup**](EmergencyGroup) PostArchitectEmergencygroups (EmergencyGroup body)


Creates a new emergency group

Requires ALL permissions: 

* routing:emergencyGroup:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectEmergencygroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new EmergencyGroup(); // EmergencyGroup | 

            try
            { 
                // Creates a new emergency group
                EmergencyGroup result = apiInstance.PostArchitectEmergencygroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectEmergencygroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EmergencyGroup**](EmergencyGroup)|  |  |

### Return type

[**EmergencyGroup**](EmergencyGroup)


## PostArchitectGrammarLanguageFilesDtmf

> [**UploadUrlResponse**](UploadUrlResponse) PostArchitectGrammarLanguageFilesDtmf (string grammarId, string languageCode, GrammarFileUploadRequest body)


Creates a presigned URL for uploading a grammar DTMF mode file

Requires ALL permissions: 

* architect:grammar:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectGrammarLanguageFilesDtmfExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | Grammar ID
            var languageCode = languageCode_example;  // string | Language
            var body = new GrammarFileUploadRequest(); // GrammarFileUploadRequest | query

            try
            { 
                // Creates a presigned URL for uploading a grammar DTMF mode file
                UploadUrlResponse result = apiInstance.PostArchitectGrammarLanguageFilesDtmf(grammarId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectGrammarLanguageFilesDtmf: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| Grammar ID |  |
| **languageCode** | **string**| Language |  |
| **body** | [**GrammarFileUploadRequest**](GrammarFileUploadRequest)| query |  |

### Return type

[**UploadUrlResponse**](UploadUrlResponse)


## PostArchitectGrammarLanguageFilesVoice

> [**UploadUrlResponse**](UploadUrlResponse) PostArchitectGrammarLanguageFilesVoice (string grammarId, string languageCode, GrammarFileUploadRequest body)


Creates a presigned URL for uploading a grammar voice mode file

Requires ALL permissions: 

* architect:grammar:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectGrammarLanguageFilesVoiceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | Grammar ID
            var languageCode = languageCode_example;  // string | Language
            var body = new GrammarFileUploadRequest(); // GrammarFileUploadRequest | query

            try
            { 
                // Creates a presigned URL for uploading a grammar voice mode file
                UploadUrlResponse result = apiInstance.PostArchitectGrammarLanguageFilesVoice(grammarId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectGrammarLanguageFilesVoice: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| Grammar ID |  |
| **languageCode** | **string**| Language |  |
| **body** | [**GrammarFileUploadRequest**](GrammarFileUploadRequest)| query |  |

### Return type

[**UploadUrlResponse**](UploadUrlResponse)


## PostArchitectGrammarLanguages

> [**GrammarLanguage**](GrammarLanguage) PostArchitectGrammarLanguages (string grammarId, GrammarLanguage body)


Create a new language for a given grammar

Requires ALL permissions: 

* architect:grammar:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectGrammarLanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var grammarId = grammarId_example;  // string | Grammar ID
            var body = new GrammarLanguage(); // GrammarLanguage | 

            try
            { 
                // Create a new language for a given grammar
                GrammarLanguage result = apiInstance.PostArchitectGrammarLanguages(grammarId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectGrammarLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **grammarId** | **string**| Grammar ID |  |
| **body** | [**GrammarLanguage**](GrammarLanguage)|  |  |

### Return type

[**GrammarLanguage**](GrammarLanguage)


## PostArchitectGrammars

> [**Grammar**](Grammar) PostArchitectGrammars (Grammar body)


Create a new grammar

Requires ALL permissions: 

* architect:grammar:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectGrammarsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new Grammar(); // Grammar | 

            try
            { 
                // Create a new grammar
                Grammar result = apiInstance.PostArchitectGrammars(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectGrammars: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Grammar**](Grammar)|  |  |

### Return type

[**Grammar**](Grammar)


## PostArchitectIvrs

> [**IVR**](IVR) PostArchitectIvrs (IVR body)


Create IVR config.

Requires ALL permissions: 

* routing:callRoute:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectIvrsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new IVR(); // IVR | 

            try
            { 
                // Create IVR config.
                IVR result = apiInstance.PostArchitectIvrs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectIvrs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**IVR**](IVR)|  |  |

### Return type

[**IVR**](IVR)


## PostArchitectPromptHistory

> [**Operation**](Operation) PostArchitectPromptHistory (string promptId)


Generate prompt history

Asynchronous.  Notification topic: v2.architect.prompts.{promptId}

Requires ALL permissions: 

* architect:userPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectPromptHistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID

            try
            { 
                // Generate prompt history
                Operation result = apiInstance.PostArchitectPromptHistory(promptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectPromptHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |

### Return type

[**Operation**](Operation)


## PostArchitectPromptResourceUploads

> [**PromptAssetUpload**](PromptAssetUpload) PostArchitectPromptResourceUploads (string promptId, string languageCode)


Creates a presigned URL for uploading a user prompt file

Requires ALL permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectPromptResourceUploadsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Creates a presigned URL for uploading a user prompt file
                PromptAssetUpload result = apiInstance.PostArchitectPromptResourceUploads(promptId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectPromptResourceUploads: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |

### Return type

[**PromptAssetUpload**](PromptAssetUpload)


## PostArchitectPromptResources

> [**PromptAsset**](PromptAsset) PostArchitectPromptResources (string promptId, PromptAssetCreate body)


Create a new user prompt resource

Requires ALL permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectPromptResourcesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var body = new PromptAssetCreate(); // PromptAssetCreate | 

            try
            { 
                // Create a new user prompt resource
                PromptAsset result = apiInstance.PostArchitectPromptResources(promptId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectPromptResources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **body** | [**PromptAssetCreate**](PromptAssetCreate)|  |  |

### Return type

[**PromptAsset**](PromptAsset)


## PostArchitectPrompts

> [**Prompt**](Prompt) PostArchitectPrompts (Prompt body)


Create a new user prompt

Requires ALL permissions: 

* architect:userPrompt:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectPromptsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new Prompt(); // Prompt | 

            try
            { 
                // Create a new user prompt
                Prompt result = apiInstance.PostArchitectPrompts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectPrompts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Prompt**](Prompt)|  |  |

### Return type

[**Prompt**](Prompt)


## PostArchitectSchedulegroups

> [**ScheduleGroup**](ScheduleGroup) PostArchitectSchedulegroups (ScheduleGroup body)


Creates a new schedule group

Requires ALL permissions: 

* routing:scheduleGroup:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectSchedulegroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new ScheduleGroup(); // ScheduleGroup | 

            try
            { 
                // Creates a new schedule group
                ScheduleGroup result = apiInstance.PostArchitectSchedulegroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectSchedulegroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ScheduleGroup**](ScheduleGroup)|  |  |

### Return type

[**ScheduleGroup**](ScheduleGroup)


## PostArchitectSchedules

> [**Schedule**](Schedule) PostArchitectSchedules (Schedule body)


Create a new schedule.

Requires ALL permissions: 

* routing:schedule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectSchedulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new Schedule(); // Schedule | 

            try
            { 
                // Create a new schedule.
                Schedule result = apiInstance.PostArchitectSchedules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Schedule**](Schedule)|  |  |

### Return type

[**Schedule**](Schedule)


## PostArchitectSystempromptHistory

> [**Operation**](Operation) PostArchitectSystempromptHistory (string promptId)


Generate system prompt history

Asynchronous.  Notification topic: v2.architect.systemprompts.{systemPromptId}

Requires ALL permissions: 

* architect:systemPrompt:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectSystempromptHistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | promptId

            try
            { 
                // Generate system prompt history
                Operation result = apiInstance.PostArchitectSystempromptHistory(promptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectSystempromptHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| promptId |  |

### Return type

[**Operation**](Operation)


## PostArchitectSystempromptResourceUploads

> [**PromptAssetUpload**](PromptAssetUpload) PostArchitectSystempromptResourceUploads (string promptId, string languageCode)


Creates a presigned URL for uploading a system prompt file

Requires ALL permissions: 

* architect:systemPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectSystempromptResourceUploadsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language

            try
            { 
                // Creates a presigned URL for uploading a system prompt file
                PromptAssetUpload result = apiInstance.PostArchitectSystempromptResourceUploads(promptId, languageCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectSystempromptResourceUploads: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |

### Return type

[**PromptAssetUpload**](PromptAssetUpload)


## PostArchitectSystempromptResources

> [**SystemPromptAsset**](SystemPromptAsset) PostArchitectSystempromptResources (string promptId, SystemPromptAsset body)


Create system prompt resource override.

Requires ALL permissions: 

* architect:systemPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostArchitectSystempromptResourcesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var body = new SystemPromptAsset(); // SystemPromptAsset | 

            try
            { 
                // Create system prompt resource override.
                SystemPromptAsset result = apiInstance.PostArchitectSystempromptResources(promptId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostArchitectSystempromptResources: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **body** | [**SystemPromptAsset**](SystemPromptAsset)|  |  |

### Return type

[**SystemPromptAsset**](SystemPromptAsset)


## PostFlowHistory

> [**Operation**](Operation) PostFlowHistory (string flowId)


Generate flow history

Asynchronous.  Notification topic: v2.flows.{flowId}

Requires ANY permissions: 

* architect:flow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowHistoryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID

            try
            { 
                // Generate flow history
                Operation result = apiInstance.PostFlowHistory(flowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |

### Return type

[**Operation**](Operation)


## PostFlowInstancesSettingsLoglevels

> [**FlowSettingsResponse**](FlowSettingsResponse) PostFlowInstancesSettingsLoglevels (string flowId, FlowLogLevelRequest body, List<string> expand = null)


Set the logLevel for a particular flow id

Assigns a new loglevel to a flow id

Requires ALL permissions: 

* architect:flowLogLevel:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowInstancesSettingsLoglevelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | The flow id to set the loglevel for
            var body = new FlowLogLevelRequest(); // FlowLogLevelRequest | New LogLevel settings
            var expand = new List<string>(); // List<string> | Expand instructions for the result (optional) 

            try
            { 
                // Set the logLevel for a particular flow id
                FlowSettingsResponse result = apiInstance.PostFlowInstancesSettingsLoglevels(flowId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowInstancesSettingsLoglevels: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| The flow id to set the loglevel for |  |
| **body** | [**FlowLogLevelRequest**](FlowLogLevelRequest)| New LogLevel settings |  |
| **expand** | [**List<string>**](string)| Expand instructions for the result | [optional] <br />**Values**: name, type, logLevelCharacteristics.characteristics |

### Return type

[**FlowSettingsResponse**](FlowSettingsResponse)


## PostFlowVersions

> [**FlowVersion**](FlowVersion) PostFlowVersions (string flowId, Object body)


Create flow version

Requires ANY permissions: 

* architect:flow:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowVersionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var body = new Object(); // Object | 

            try
            { 
                // Create flow version
                FlowVersion result = apiInstance.PostFlowVersions(flowId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **body** | [**Object**](Object)|  |  |

### Return type

[**FlowVersion**](FlowVersion)


## PostFlows

> [**Flow**](Flow) PostFlows (Flow body, string language = null)


Create flow

Requires ANY permissions: 

* architect:flow:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new Flow(); // Flow | 
            var language = language_example;  // string | Language (optional) 

            try
            { 
                // Create flow
                Flow result = apiInstance.PostFlows(body, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlows: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Flow**](Flow)|  |  |
| **language** | **string**| Language | [optional]  |

### Return type

[**Flow**](Flow)


## PostFlowsActionsCheckin

> [**Operation**](Operation) PostFlowsActionsCheckin (string flow)


Check-in flow

Asynchronous.  Notification topic: v2.flows.{flowId}

Requires ANY permissions: 

* architect:flow:edit
* architect:flow:unlock

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsCheckinExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flow = flow_example;  // string | Flow ID

            try
            { 
                // Check-in flow
                Operation result = apiInstance.PostFlowsActionsCheckin(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsCheckin: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |

### Return type

[**Operation**](Operation)


## PostFlowsActionsCheckout

> [**Flow**](Flow) PostFlowsActionsCheckout (string flow)


Check-out flow

Requires ANY permissions: 

* architect:flow:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsCheckoutExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flow = flow_example;  // string | Flow ID

            try
            { 
                // Check-out flow
                Flow result = apiInstance.PostFlowsActionsCheckout(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsCheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |

### Return type

[**Flow**](Flow)


## PostFlowsActionsDeactivate

> [**Flow**](Flow) PostFlowsActionsDeactivate (string flow)


Deactivate flow

Requires ANY permissions: 

* architect:flow:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsDeactivateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flow = flow_example;  // string | Flow ID

            try
            { 
                // Deactivate flow
                Flow result = apiInstance.PostFlowsActionsDeactivate(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsDeactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |

### Return type

[**Flow**](Flow)


## PostFlowsActionsPublish

> [**Operation**](Operation) PostFlowsActionsPublish (string flow, string version = null)


Publish flow

Asynchronous.  Notification topic: v2.flows.{flowId}

Requires ANY permissions: 

* architect:flow:unlock
* architect:flow:publish

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsPublishExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flow = flow_example;  // string | Flow ID
            var version = version_example;  // string | version (optional) 

            try
            { 
                // Publish flow
                Operation result = apiInstance.PostFlowsActionsPublish(flow, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsPublish: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |
| **version** | **string**| version | [optional]  |

### Return type

[**Operation**](Operation)


## PostFlowsActionsRevert

> [**Flow**](Flow) PostFlowsActionsRevert (string flow)


Revert flow

Requires ANY permissions: 

* architect:flow:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsRevertExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flow = flow_example;  // string | Flow ID

            try
            { 
                // Revert flow
                Flow result = apiInstance.PostFlowsActionsRevert(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsRevert: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |

### Return type

[**Flow**](Flow)


## PostFlowsActionsUnlock

> [**Flow**](Flow) PostFlowsActionsUnlock (string flow)


Unlock flow

Allows for unlocking a flow in the case where there is no flow configuration available, and thus a check-in will not unlock the flow. The user must have Architect Admin permissions to perform this action.

Requires ANY permissions: 

* architect:flow:unlock

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsActionsUnlockExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flow = flow_example;  // string | Flow ID

            try
            { 
                // Unlock flow
                Flow result = apiInstance.PostFlowsActionsUnlock(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsActionsUnlock: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flow** | **string**| Flow ID |  |

### Return type

[**Flow**](Flow)


## PostFlowsDatatableExportJobs

> [**DataTableExportJob**](DataTableExportJob) PostFlowsDatatableExportJobs (string datatableId)


Begin an export process for exporting all rows from a datatable

Create an export job for exporting rows. The caller can then poll for status of the export using the token returned in the response

Requires ANY permissions: 

* architect:datatable:view
* architect:datatableRow:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsDatatableExportJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable

            try
            { 
                // Begin an export process for exporting all rows from a datatable
                DataTableExportJob result = apiInstance.PostFlowsDatatableExportJobs(datatableId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsDatatableExportJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |

### Return type

[**DataTableExportJob**](DataTableExportJob)


## PostFlowsDatatableImportJobs

> [**DataTableImportJob**](DataTableImportJob) PostFlowsDatatableImportJobs (string datatableId, DataTableImportJob body)


Begin an import process for importing rows into a datatable

Create an import job for importing rows. The caller can then poll for status of the import using the token returned in the response

Requires ANY permissions: 

* architect:datatable:edit
* architect:datatableRow:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsDatatableImportJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var body = new DataTableImportJob(); // DataTableImportJob | import job information

            try
            { 
                // Begin an import process for importing rows into a datatable
                DataTableImportJob result = apiInstance.PostFlowsDatatableImportJobs(datatableId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsDatatableImportJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **body** | [**DataTableImportJob**](DataTableImportJob)| import job information |  |

### Return type

[**DataTableImportJob**](DataTableImportJob)


## PostFlowsDatatableRows

> **Dictionary&lt;string, Object&gt;** PostFlowsDatatableRows (string datatableId, Object dataTableRow)


Create a new row entry for the datatable.

Will add the passed in row entry to the datatable with the given datatableId after verifying it against the schema.  When building the request body within API Explorer, Pro mode should be used. The DataTableRow should be a json-ized' stream of key -> value pairs {      \"Field1\": \"XYZZY\",      \"Field2\": false,      \"KEY\": \"27272\"  }

Requires ANY permissions: 

* architect:datatable:add
* architect:datatableRow:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsDatatableRowsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var dataTableRow = new Object(); // Object | 

            try
            { 
                // Create a new row entry for the datatable.
                Dictionary<string, Object> result = apiInstance.PostFlowsDatatableRows(datatableId, dataTableRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsDatatableRows: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **dataTableRow** | [**Object**](Object)|  |  |

### Return type

**Dictionary<string, Object>**


## PostFlowsDatatables

> [**DataTable**](DataTable) PostFlowsDatatables (DataTable body)


Create a new datatable with the specified json-schema definition

This will create a new datatable with fields that match the property definitions in the JSON schema.  The schema's title field will be overridden by the name field in the DataTable object.  See also http://json-schema.org/

Requires ANY permissions: 

* architect:datatable:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsDatatablesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new DataTable(); // DataTable | datatable json-schema

            try
            { 
                // Create a new datatable with the specified json-schema definition
                DataTable result = apiInstance.PostFlowsDatatables(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsDatatables: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DataTable**](DataTable)| datatable json-schema |  |

### Return type

[**DataTable**](DataTable)


## PostFlowsExecutions

> [**FlowExecutionLaunchResponse**](FlowExecutionLaunchResponse) PostFlowsExecutions (FlowExecutionLaunchRequest flowLaunchRequest)


Launch an instance of a flow definition, for flow types that support it such as the 'workflow' type.

The launch is asynchronous, it returns as soon as the flow starts. You can use the returned ID to query its status if you need.

Requires ANY permissions: 

* architect:flow:launch

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsExecutionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowLaunchRequest = new FlowExecutionLaunchRequest(); // FlowExecutionLaunchRequest | 

            try
            { 
                // Launch an instance of a flow definition, for flow types that support it such as the 'workflow' type.
                FlowExecutionLaunchResponse result = apiInstance.PostFlowsExecutions(flowLaunchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowLaunchRequest** | [**FlowExecutionLaunchRequest**](FlowExecutionLaunchRequest)|  |  |

### Return type

[**FlowExecutionLaunchResponse**](FlowExecutionLaunchResponse)


## PostFlowsExportJobs

> [**RegisterArchitectExportJobResponse**](RegisterArchitectExportJobResponse) PostFlowsExportJobs (RegisterArchitectExportJob body)


Register Architect Export Job

Requires ALL permissions: 

* architect:jobExport:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsExportJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new RegisterArchitectExportJob(); // RegisterArchitectExportJob | 

            try
            { 
                // Register Architect Export Job
                RegisterArchitectExportJobResponse result = apiInstance.PostFlowsExportJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsExportJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RegisterArchitectExportJob**](RegisterArchitectExportJob)|  |  |

### Return type

[**RegisterArchitectExportJobResponse**](RegisterArchitectExportJobResponse)


## PostFlowsInstancesJobs

> [**GetFlowExecutionDataJobResult**](GetFlowExecutionDataJobResult) PostFlowsInstancesJobs (ExecutionDataRequest body, string expand = null)


Start a process (job) that will prepare a list of execution data IDs for download.

Returns a JobResult object that contains an ID that can be used to check status and/or download links when the process (job) is complete.

Requires ANY permissions: 

* architect:flowInstance:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsInstancesJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new ExecutionDataRequest(); // ExecutionDataRequest | Requested Flow Ids
            var expand = expand_example;  // string | Expand various query types. (optional) 

            try
            { 
                // Start a process (job) that will prepare a list of execution data IDs for download.
                GetFlowExecutionDataJobResult result = apiInstance.PostFlowsInstancesJobs(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsInstancesJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExecutionDataRequest**](ExecutionDataRequest)| Requested Flow Ids |  |
| **expand** | **string**| Expand various query types. | [optional] <br />**Values**: bots, dataActions |

### Return type

[**GetFlowExecutionDataJobResult**](GetFlowExecutionDataJobResult)


## PostFlowsInstancesQuery

> [**FlowResultEntityListing**](FlowResultEntityListing) PostFlowsInstancesQuery (CriteriaQuery body, bool? indexOnly = null, int? pageSize = null)


Query the database of existing flow histories to look for particular flow criteria

Returns a list of matching flow histories up to 200 max.

Requires ANY permissions: 

* architect:flowInstance:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsInstancesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new CriteriaQuery(); // CriteriaQuery | query
            var indexOnly = true;  // bool? | indexes only (optional) 
            var pageSize = 56;  // int? | number of results to return (optional)  (default to 50)

            try
            { 
                // Query the database of existing flow histories to look for particular flow criteria
                FlowResultEntityListing result = apiInstance.PostFlowsInstancesQuery(body, indexOnly, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsInstancesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CriteriaQuery**](CriteriaQuery)| query |  |
| **indexOnly** | **bool?**| indexes only | [optional]  |
| **pageSize** | **int?**| number of results to return | [optional] [default to 50] |

### Return type

[**FlowResultEntityListing**](FlowResultEntityListing)


## PostFlowsJobs

> [**RegisterArchitectJobResponse**](RegisterArchitectJobResponse) PostFlowsJobs ()


Register Architect Job. Returns a URL where a file, such as an Architect flow YAML file, can be PUT which will then initiate the job.

Requires ALL permissions: 

* architect:job:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();

            try
            { 
                // Register Architect Job. Returns a URL where a file, such as an Architect flow YAML file, can be PUT which will then initiate the job.
                RegisterArchitectJobResponse result = apiInstance.PostFlowsJobs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**RegisterArchitectJobResponse**](RegisterArchitectJobResponse)


## PostFlowsMilestones

> [**FlowMilestone**](FlowMilestone) PostFlowsMilestones (FlowMilestone body = null)


Create a flow milestone

Requires ALL permissions: 

* architect:flowMilestone:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsMilestonesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new FlowMilestone(); // FlowMilestone |  (optional) 

            try
            { 
                // Create a flow milestone
                FlowMilestone result = apiInstance.PostFlowsMilestones(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsMilestones: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowMilestone**](FlowMilestone)|  | [optional]  |

### Return type

[**FlowMilestone**](FlowMilestone)


## PostFlowsOutcomes

> [**FlowOutcome**](FlowOutcome) PostFlowsOutcomes (FlowOutcome body = null)


Create a flow outcome

Asynchronous.  Notification topic: v2.flows.outcomes.{flowOutcomeId}

Requires ALL permissions: 

* architect:flowOutcome:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostFlowsOutcomesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new FlowOutcome(); // FlowOutcome |  (optional) 

            try
            { 
                // Create a flow outcome
                FlowOutcome result = apiInstance.PostFlowsOutcomes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PostFlowsOutcomes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowOutcome**](FlowOutcome)|  | [optional]  |

### Return type

[**FlowOutcome**](FlowOutcome)


## PutArchitectEmergencygroup

> [**EmergencyGroup**](EmergencyGroup) PutArchitectEmergencygroup (string emergencyGroupId, EmergencyGroup body)


Updates a emergency group by ID

Requires ALL permissions: 

* routing:emergencyGroup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectEmergencygroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var emergencyGroupId = emergencyGroupId_example;  // string | Emergency group ID
            var body = new EmergencyGroup(); // EmergencyGroup | 

            try
            { 
                // Updates a emergency group by ID
                EmergencyGroup result = apiInstance.PutArchitectEmergencygroup(emergencyGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectEmergencygroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emergencyGroupId** | **string**| Emergency group ID |  |
| **body** | [**EmergencyGroup**](EmergencyGroup)|  |  |

### Return type

[**EmergencyGroup**](EmergencyGroup)


## PutArchitectIvr

> [**IVR**](IVR) PutArchitectIvr (string ivrId, IVR body)


Update an IVR Config.

Requires ALL permissions: 

* routing:callRoute:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectIvrExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var ivrId = ivrId_example;  // string | IVR id
            var body = new IVR(); // IVR | 

            try
            { 
                // Update an IVR Config.
                IVR result = apiInstance.PutArchitectIvr(ivrId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectIvr: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ivrId** | **string**| IVR id |  |
| **body** | [**IVR**](IVR)|  |  |

### Return type

[**IVR**](IVR)


## PutArchitectIvrIdentityresolution

> [**IdentityResolutionConfig**](IdentityResolutionConfig) PutArchitectIvrIdentityresolution (string ivrId, IdentityResolutionConfig body)


Update an IVR IdentityResolutionConfig.

Requires ALL permissions: 

* routing:callRoute:edit
* routing:identityResolution:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectIvrIdentityresolutionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var ivrId = ivrId_example;  // string | IVR id
            var body = new IdentityResolutionConfig(); // IdentityResolutionConfig | 

            try
            { 
                // Update an IVR IdentityResolutionConfig.
                IdentityResolutionConfig result = apiInstance.PutArchitectIvrIdentityresolution(ivrId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectIvrIdentityresolution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ivrId** | **string**| IVR id |  |
| **body** | [**IdentityResolutionConfig**](IdentityResolutionConfig)|  |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## PutArchitectPrompt

> [**Prompt**](Prompt) PutArchitectPrompt (string promptId, Prompt body)


Update specified user prompt

Requires ALL permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectPromptExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var body = new Prompt(); // Prompt | 

            try
            { 
                // Update specified user prompt
                Prompt result = apiInstance.PutArchitectPrompt(promptId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectPrompt: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **body** | [**Prompt**](Prompt)|  |  |

### Return type

[**Prompt**](Prompt)


## PutArchitectPromptResource

> [**PromptAsset**](PromptAsset) PutArchitectPromptResource (string promptId, string languageCode, PromptAsset body)


Update specified user prompt resource

Requires ALL permissions: 

* architect:userPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectPromptResourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language
            var body = new PromptAsset(); // PromptAsset | 

            try
            { 
                // Update specified user prompt resource
                PromptAsset result = apiInstance.PutArchitectPromptResource(promptId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectPromptResource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
| **body** | [**PromptAsset**](PromptAsset)|  |  |

### Return type

[**PromptAsset**](PromptAsset)


## PutArchitectSchedule

> [**Schedule**](Schedule) PutArchitectSchedule (string scheduleId, Schedule body)


Update schedule by ID

Requires ALL permissions: 

* routing:schedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID
            var body = new Schedule(); // Schedule | 

            try
            { 
                // Update schedule by ID
                Schedule result = apiInstance.PutArchitectSchedule(scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
| **body** | [**Schedule**](Schedule)|  |  |

### Return type

[**Schedule**](Schedule)


## PutArchitectSchedulegroup

> [**ScheduleGroup**](ScheduleGroup) PutArchitectSchedulegroup (string scheduleGroupId, ScheduleGroup body)


Updates a schedule group by ID

Requires ALL permissions: 

* routing:scheduleGroup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectSchedulegroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var scheduleGroupId = scheduleGroupId_example;  // string | Schedule group ID
            var body = new ScheduleGroup(); // ScheduleGroup | 

            try
            { 
                // Updates a schedule group by ID
                ScheduleGroup result = apiInstance.PutArchitectSchedulegroup(scheduleGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectSchedulegroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleGroupId** | **string**| Schedule group ID |  |
| **body** | [**ScheduleGroup**](ScheduleGroup)|  |  |

### Return type

[**ScheduleGroup**](ScheduleGroup)


## PutArchitectSystempromptResource

> [**SystemPromptAsset**](SystemPromptAsset) PutArchitectSystempromptResource (string promptId, string languageCode, SystemPromptAsset body)


Updates a system prompt resource override.

Requires ALL permissions: 

* architect:systemPrompt:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutArchitectSystempromptResourceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var promptId = promptId_example;  // string | Prompt ID
            var languageCode = languageCode_example;  // string | Language
            var body = new SystemPromptAsset(); // SystemPromptAsset | 

            try
            { 
                // Updates a system prompt resource override.
                SystemPromptAsset result = apiInstance.PutArchitectSystempromptResource(promptId, languageCode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutArchitectSystempromptResource: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **promptId** | **string**| Prompt ID |  |
| **languageCode** | **string**| Language |  |
| **body** | [**SystemPromptAsset**](SystemPromptAsset)|  |  |

### Return type

[**SystemPromptAsset**](SystemPromptAsset)


## PutFlow

> [**Flow**](Flow) PutFlow (string flowId, Flow body)


Update flow

Requires ANY permissions: 

* architect:flow:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | Flow ID
            var body = new Flow(); // Flow | 

            try
            { 
                // Update flow
                Flow result = apiInstance.PutFlow(flowId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| Flow ID |  |
| **body** | [**Flow**](Flow)|  |  |

### Return type

[**Flow**](Flow)


## PutFlowInstancesSettingsLoglevels

> [**FlowSettingsResponse**](FlowSettingsResponse) PutFlowInstancesSettingsLoglevels (string flowId, FlowLogLevelRequest body, List<string> expand = null)


Edit the logLevel for a particular flow id

Updates the loglevel for a flow id

Requires ALL permissions: 

* architect:flowLogLevel:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowInstancesSettingsLoglevelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowId = flowId_example;  // string | The flow id to edit the loglevel for
            var body = new FlowLogLevelRequest(); // FlowLogLevelRequest | New LogLevel settings
            var expand = new List<string>(); // List<string> | Expand instructions for the result (optional) 

            try
            { 
                // Edit the logLevel for a particular flow id
                FlowSettingsResponse result = apiInstance.PutFlowInstancesSettingsLoglevels(flowId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlowInstancesSettingsLoglevels: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowId** | **string**| The flow id to edit the loglevel for |  |
| **body** | [**FlowLogLevelRequest**](FlowLogLevelRequest)| New LogLevel settings |  |
| **expand** | [**List<string>**](string)| Expand instructions for the result | [optional] <br />**Values**: name, type, logLevelCharacteristics.characteristics |

### Return type

[**FlowSettingsResponse**](FlowSettingsResponse)


## PutFlowsDatatable

> [**DataTable**](DataTable) PutFlowsDatatable (string datatableId, DataTable body, string expand = null)


Updates a specific datatable by id

Updates a schema for a datatable with the given datatableId -updates allow only new fields to be added in the schema, no changes or removals of existing fields.

Requires ANY permissions: 

* architect:datatable:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowsDatatableExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var body = new DataTable(); // DataTable | datatable json-schema
            var expand = expand_example;  // string | Expand instructions for the result (optional) 

            try
            { 
                // Updates a specific datatable by id
                DataTable result = apiInstance.PutFlowsDatatable(datatableId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlowsDatatable: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **body** | [**DataTable**](DataTable)| datatable json-schema |  |
| **expand** | **string**| Expand instructions for the result | [optional] <br />**Values**: schema |

### Return type

[**DataTable**](DataTable)


## PutFlowsDatatableRow

> **Dictionary&lt;string, Object&gt;** PutFlowsDatatableRow (string datatableId, string rowId, Object body = null)


Update a row entry

Updates a row with the given rowId (the value of the key field) to the new values.  When building the request body within API Explorer, Pro mode should be used. The DataTableRow should be a json-ized' stream of key -> value pairs {     \"Field1\": \"XYZZY\",     \"Field2\": false,     \"KEY\": \"27272\" }

Requires ANY permissions: 

* architect:datatable:edit
* architect:datatableRow:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowsDatatableRowExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var datatableId = datatableId_example;  // string | id of datatable
            var rowId = rowId_example;  // string | the key for the row
            var body = new Object(); // Object | datatable row (optional) 

            try
            { 
                // Update a row entry
                Dictionary<string, Object> result = apiInstance.PutFlowsDatatableRow(datatableId, rowId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlowsDatatableRow: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **datatableId** | **string**| id of datatable |  |
| **rowId** | **string**| the key for the row |  |
| **body** | [**Object**](Object)| datatable row | [optional]  |

### Return type

**Dictionary<string, Object>**


## PutFlowsInstancesSettingsLoglevelsDefault

> [**FlowSettingsResponse**](FlowSettingsResponse) PutFlowsInstancesSettingsLoglevelsDefault (FlowLogLevelRequest body, List<string> expand = null)


Edit the flow default log level.

Edit the flow default log level.

Requires ANY permissions: 

* architect:flowLogLevelDefault:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowsInstancesSettingsLoglevelsDefaultExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var body = new FlowLogLevelRequest(); // FlowLogLevelRequest | New LogLevel settings
            var expand = new List<string>(); // List<string> | Expand instructions for the result (optional) 

            try
            { 
                // Edit the flow default log level.
                FlowSettingsResponse result = apiInstance.PutFlowsInstancesSettingsLoglevelsDefault(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlowsInstancesSettingsLoglevelsDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowLogLevelRequest**](FlowLogLevelRequest)| New LogLevel settings |  |
| **expand** | [**List<string>**](string)| Expand instructions for the result | [optional] <br />**Values**: logLevelCharacteristics.characteristics |

### Return type

[**FlowSettingsResponse**](FlowSettingsResponse)


## PutFlowsMilestone

> [**FlowMilestone**](FlowMilestone) PutFlowsMilestone (string milestoneId, FlowMilestone body = null)


Updates a flow milestone

Requires ALL permissions: 

* architect:flowMilestone:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowsMilestoneExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var milestoneId = milestoneId_example;  // string | flow milestone ID
            var body = new FlowMilestone(); // FlowMilestone |  (optional) 

            try
            { 
                // Updates a flow milestone
                FlowMilestone result = apiInstance.PutFlowsMilestone(milestoneId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlowsMilestone: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **milestoneId** | **string**| flow milestone ID |  |
| **body** | [**FlowMilestone**](FlowMilestone)|  | [optional]  |

### Return type

[**FlowMilestone**](FlowMilestone)


## PutFlowsOutcome

> [**Operation**](Operation) PutFlowsOutcome (string flowOutcomeId, FlowOutcome body = null)


Updates a flow outcome

Updates a flow outcome.  Asynchronous.  Notification topic: v2.flowoutcomes.{flowoutcomeId}

Requires ALL permissions: 

* architect:flowOutcome:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutFlowsOutcomeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new ArchitectApi();
            var flowOutcomeId = flowOutcomeId_example;  // string | flow outcome ID
            var body = new FlowOutcome(); // FlowOutcome |  (optional) 

            try
            { 
                // Updates a flow outcome
                Operation result = apiInstance.PutFlowsOutcome(flowOutcomeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.PutFlowsOutcome: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **flowOutcomeId** | **string**| flow outcome ID |  |
| **body** | [**FlowOutcome**](FlowOutcome)|  | [optional]  |

### Return type

[**Operation**](Operation)


_PureCloudPlatform.Client.V2 233.0.0_
