# OutboundApi

## PureCloudPlatform.Client.V2.Api.OutboundApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteOutboundAttemptlimit**](#DeleteOutboundAttemptlimit) | **Delete** /api/v2/outbound/attemptlimits/{attemptLimitsId} | Delete attempt limits |
| [**DeleteOutboundCallabletimeset**](#DeleteOutboundCallabletimeset) | **Delete** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Delete callable time set |
| [**DeleteOutboundCallanalysisresponseset**](#DeleteOutboundCallanalysisresponseset) | **Delete** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Delete a dialer call analysis response set. |
| [**DeleteOutboundCampaign**](#DeleteOutboundCampaign) | **Delete** /api/v2/outbound/campaigns/{campaignId} | Delete a campaign. |
| [**DeleteOutboundCampaignProgress**](#DeleteOutboundCampaignProgress) | **Delete** /api/v2/outbound/campaigns/{campaignId}/progress | Reset campaign progress and recycle the campaign |
| [**DeleteOutboundCampaignrule**](#DeleteOutboundCampaignrule) | **Delete** /api/v2/outbound/campaignrules/{campaignRuleId} | Delete Campaign Rule |
| [**DeleteOutboundContactlist**](#DeleteOutboundContactlist) | **Delete** /api/v2/outbound/contactlists/{contactListId} | Delete a contact list. |
| [**DeleteOutboundContactlistContact**](#DeleteOutboundContactlistContact) | **Delete** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Delete a contact. |
| [**DeleteOutboundContactlistContacts**](#DeleteOutboundContactlistContacts) | **Delete** /api/v2/outbound/contactlists/{contactListId}/contacts | Delete contacts from a contact list. |
| [**DeleteOutboundContactlistfilter**](#DeleteOutboundContactlistfilter) | **Delete** /api/v2/outbound/contactlistfilters/{contactListFilterId} | Delete Contact List Filter |
| [**DeleteOutboundContactlists**](#DeleteOutboundContactlists) | **Delete** /api/v2/outbound/contactlists | Delete multiple contact lists. |
| [**DeleteOutboundContactlisttemplate**](#DeleteOutboundContactlisttemplate) | **Delete** /api/v2/outbound/contactlisttemplates/{contactListTemplateId} | Delete Contact List Template |
| [**DeleteOutboundContactlisttemplates**](#DeleteOutboundContactlisttemplates) | **Delete** /api/v2/outbound/contactlisttemplates | Delete multiple contact list templates. |
| [**DeleteOutboundDigitalruleset**](#DeleteOutboundDigitalruleset) | **Delete** /api/v2/outbound/digitalrulesets/{digitalRuleSetId} | Delete an Outbound Digital Rule Set |
| [**DeleteOutboundDnclist**](#DeleteOutboundDnclist) | **Delete** /api/v2/outbound/dnclists/{dncListId} | Delete dialer DNC list |
| [**DeleteOutboundDnclistCustomexclusioncolumns**](#DeleteOutboundDnclistCustomexclusioncolumns) | **Delete** /api/v2/outbound/dnclists/{dncListId}/customexclusioncolumns | Deletes all or expired custom exclusion column entries from a DNC list. |
| [**DeleteOutboundDnclistEmailaddresses**](#DeleteOutboundDnclistEmailaddresses) | **Delete** /api/v2/outbound/dnclists/{dncListId}/emailaddresses | Deletes all or expired email addresses from a DNC list. |
| [**DeleteOutboundDnclistPhonenumbers**](#DeleteOutboundDnclistPhonenumbers) | **Delete** /api/v2/outbound/dnclists/{dncListId}/phonenumbers | Deletes all or expired phone numbers from a DNC list. |
| [**DeleteOutboundFilespecificationtemplate**](#DeleteOutboundFilespecificationtemplate) | **Delete** /api/v2/outbound/filespecificationtemplates/{fileSpecificationTemplateId} | Delete File Specification Template |
| [**DeleteOutboundFilespecificationtemplatesBulk**](#DeleteOutboundFilespecificationtemplatesBulk) | **Delete** /api/v2/outbound/filespecificationtemplates/bulk | Delete multiple file specification templates. |
| [**DeleteOutboundImporttemplate**](#DeleteOutboundImporttemplate) | **Delete** /api/v2/outbound/importtemplates/{importTemplateId} | Delete Import Template |
| [**DeleteOutboundImporttemplates**](#DeleteOutboundImporttemplates) | **Delete** /api/v2/outbound/importtemplates | Delete multiple import templates. |
| [**DeleteOutboundMessagingcampaign**](#DeleteOutboundMessagingcampaign) | **Delete** /api/v2/outbound/messagingcampaigns/{messagingCampaignId} | Delete an Outbound Messaging Campaign |
| [**DeleteOutboundMessagingcampaignProgress**](#DeleteOutboundMessagingcampaignProgress) | **Delete** /api/v2/outbound/messagingcampaigns/{messagingCampaignId}/progress | Reset messaging campaign progress and recycle the messaging campaign |
| [**DeleteOutboundRuleset**](#DeleteOutboundRuleset) | **Delete** /api/v2/outbound/rulesets/{ruleSetId} | Delete a Rule Set. |
| [**DeleteOutboundSchedulesCampaign**](#DeleteOutboundSchedulesCampaign) | **Delete** /api/v2/outbound/schedules/campaigns/{campaignId} | Delete a dialer campaign schedule. |
| [**DeleteOutboundSchedulesEmailcampaign**](#DeleteOutboundSchedulesEmailcampaign) | **Delete** /api/v2/outbound/schedules/emailcampaigns/{emailCampaignId} | Delete an email campaign schedule. |
| [**DeleteOutboundSchedulesMessagingcampaign**](#DeleteOutboundSchedulesMessagingcampaign) | **Delete** /api/v2/outbound/schedules/messagingcampaigns/{messagingCampaignId} | Delete a messaging campaign schedule. |
| [**DeleteOutboundSchedulesSequence**](#DeleteOutboundSchedulesSequence) | **Delete** /api/v2/outbound/schedules/sequences/{sequenceId} | Delete a dialer sequence schedule. |
| [**DeleteOutboundSequence**](#DeleteOutboundSequence) | **Delete** /api/v2/outbound/sequences/{sequenceId} | Delete a dialer campaign sequence. |
| [**GetOutboundAttemptlimit**](#GetOutboundAttemptlimit) | **Get** /api/v2/outbound/attemptlimits/{attemptLimitsId} | Get attempt limits |
| [**GetOutboundAttemptlimits**](#GetOutboundAttemptlimits) | **Get** /api/v2/outbound/attemptlimits | Query attempt limits list |
| [**GetOutboundCallabletimeset**](#GetOutboundCallabletimeset) | **Get** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Get callable time set |
| [**GetOutboundCallabletimesets**](#GetOutboundCallabletimesets) | **Get** /api/v2/outbound/callabletimesets | Query callable time set list |
| [**GetOutboundCallanalysisresponseset**](#GetOutboundCallanalysisresponseset) | **Get** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Get a dialer call analysis response set. |
| [**GetOutboundCallanalysisresponsesets**](#GetOutboundCallanalysisresponsesets) | **Get** /api/v2/outbound/callanalysisresponsesets | Query a list of dialer call analysis response sets. |
| [**GetOutboundCampaign**](#GetOutboundCampaign) | **Get** /api/v2/outbound/campaigns/{campaignId} | Get dialer campaign. |
| [**GetOutboundCampaignAgentownedmappingpreviewResults**](#GetOutboundCampaignAgentownedmappingpreviewResults) | **Get** /api/v2/outbound/campaigns/{campaignId}/agentownedmappingpreview/results | Get a preview of how agents will be mapped to this campaign&#39;s contact list. |
| [**GetOutboundCampaignDiagnostics**](#GetOutboundCampaignDiagnostics) | **Get** /api/v2/outbound/campaigns/{campaignId}/diagnostics | Get campaign diagnostics |
| [**GetOutboundCampaignInteractions**](#GetOutboundCampaignInteractions) | **Get** /api/v2/outbound/campaigns/{campaignId}/interactions | Get dialer campaign interactions. |
| [**GetOutboundCampaignLinedistribution**](#GetOutboundCampaignLinedistribution) | **Get** /api/v2/outbound/campaigns/{campaignId}/linedistribution | Get line distribution information for campaigns using same Edge Group or Site as given campaign |
| [**GetOutboundCampaignProgress**](#GetOutboundCampaignProgress) | **Get** /api/v2/outbound/campaigns/{campaignId}/progress | Get campaign progress |
| [**GetOutboundCampaignSkillcombinations**](#GetOutboundCampaignSkillcombinations) | **Get** /api/v2/outbound/campaigns/{campaignId}/skillcombinations | Get the remaining and total contact count for each skill combination in a skills campaign |
| [**GetOutboundCampaignStats**](#GetOutboundCampaignStats) | **Get** /api/v2/outbound/campaigns/{campaignId}/stats | Get statistics about a Dialer Campaign |
| [**GetOutboundCampaignrule**](#GetOutboundCampaignrule) | **Get** /api/v2/outbound/campaignrules/{campaignRuleId} | Get Campaign Rule |
| [**GetOutboundCampaignrules**](#GetOutboundCampaignrules) | **Get** /api/v2/outbound/campaignrules | Query Campaign Rule list |
| [**GetOutboundCampaigns**](#GetOutboundCampaigns) | **Get** /api/v2/outbound/campaigns | Query a list of dialer campaigns. |
| [**GetOutboundCampaignsAll**](#GetOutboundCampaignsAll) | **Get** /api/v2/outbound/campaigns/all | Query across all types of campaigns by division |
| [**GetOutboundCampaignsAllDivisionviews**](#GetOutboundCampaignsAllDivisionviews) | **Get** /api/v2/outbound/campaigns/all/divisionviews | Query across all types of campaigns |
| [**GetOutboundCampaignsDivisionview**](#GetOutboundCampaignsDivisionview) | **Get** /api/v2/outbound/campaigns/divisionviews/{campaignId} | Get a basic Campaign information object |
| [**GetOutboundCampaignsDivisionviews**](#GetOutboundCampaignsDivisionviews) | **Get** /api/v2/outbound/campaigns/divisionviews | Query a list of basic Campaign information objects |
| [**GetOutboundContactlist**](#GetOutboundContactlist) | **Get** /api/v2/outbound/contactlists/{contactListId} | Get a dialer contact list. |
| [**GetOutboundContactlistContact**](#GetOutboundContactlistContact) | **Get** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Get a contact. |
| [**GetOutboundContactlistContactsBulkJob**](#GetOutboundContactlistContactsBulkJob) | **Get** /api/v2/outbound/contactlists/{contactListId}/contacts/bulk/jobs/{jobId} | Get bulk operation job. |
| [**GetOutboundContactlistContactsBulkJobs**](#GetOutboundContactlistContactsBulkJobs) | **Get** /api/v2/outbound/contactlists/{contactListId}/contacts/bulk/jobs | Get 10 most recent bulk operation jobs associated with contact list. |
| [**GetOutboundContactlistExport**](#GetOutboundContactlistExport) | **Get** /api/v2/outbound/contactlists/{contactListId}/export | Get the URI of a contact list export. |
| [**GetOutboundContactlistImportstatus**](#GetOutboundContactlistImportstatus) | **Get** /api/v2/outbound/contactlists/{contactListId}/importstatus | Get dialer contactList import status. |
| [**GetOutboundContactlistTimezonemappingpreview**](#GetOutboundContactlistTimezonemappingpreview) | **Get** /api/v2/outbound/contactlists/{contactListId}/timezonemappingpreview | Preview the result of applying Automatic Time Zone Mapping to a contact list |
| [**GetOutboundContactlistfilter**](#GetOutboundContactlistfilter) | **Get** /api/v2/outbound/contactlistfilters/{contactListFilterId} | Get Contact list filter |
| [**GetOutboundContactlistfilters**](#GetOutboundContactlistfilters) | **Get** /api/v2/outbound/contactlistfilters | Query Contact list filters |
| [**GetOutboundContactlists**](#GetOutboundContactlists) | **Get** /api/v2/outbound/contactlists | Query a list of contact lists. |
| [**GetOutboundContactlistsDivisionview**](#GetOutboundContactlistsDivisionview) | **Get** /api/v2/outbound/contactlists/divisionviews/{contactListId} | Get a basic ContactList information object |
| [**GetOutboundContactlistsDivisionviews**](#GetOutboundContactlistsDivisionviews) | **Get** /api/v2/outbound/contactlists/divisionviews | Query a list of simplified contact list objects. |
| [**GetOutboundContactlisttemplate**](#GetOutboundContactlisttemplate) | **Get** /api/v2/outbound/contactlisttemplates/{contactListTemplateId} | Get Contact List Template |
| [**GetOutboundContactlisttemplates**](#GetOutboundContactlisttemplates) | **Get** /api/v2/outbound/contactlisttemplates | Query a list of contact list templates |
| [**GetOutboundDigitalruleset**](#GetOutboundDigitalruleset) | **Get** /api/v2/outbound/digitalrulesets/{digitalRuleSetId} | Get an Outbound Digital Rule Set |
| [**GetOutboundDigitalrulesets**](#GetOutboundDigitalrulesets) | **Get** /api/v2/outbound/digitalrulesets | Query a list of Outbound Digital Rule Sets |
| [**GetOutboundDnclist**](#GetOutboundDnclist) | **Get** /api/v2/outbound/dnclists/{dncListId} | Get dialer DNC list |
| [**GetOutboundDnclistExport**](#GetOutboundDnclistExport) | **Get** /api/v2/outbound/dnclists/{dncListId}/export | Get the URI of a DNC list export. |
| [**GetOutboundDnclistImportstatus**](#GetOutboundDnclistImportstatus) | **Get** /api/v2/outbound/dnclists/{dncListId}/importstatus | Get dialer dncList import status. |
| [**GetOutboundDnclists**](#GetOutboundDnclists) | **Get** /api/v2/outbound/dnclists | Query dialer DNC lists |
| [**GetOutboundDnclistsDivisionview**](#GetOutboundDnclistsDivisionview) | **Get** /api/v2/outbound/dnclists/divisionviews/{dncListId} | Get a basic DncList information object |
| [**GetOutboundDnclistsDivisionviews**](#GetOutboundDnclistsDivisionviews) | **Get** /api/v2/outbound/dnclists/divisionviews | Query a list of simplified dnc list objects. |
| [**GetOutboundEvent**](#GetOutboundEvent) | **Get** /api/v2/outbound/events/{eventId} | Get Dialer Event |
| [**GetOutboundEvents**](#GetOutboundEvents) | **Get** /api/v2/outbound/events | Query Event Logs |
| [**GetOutboundFilespecificationtemplate**](#GetOutboundFilespecificationtemplate) | **Get** /api/v2/outbound/filespecificationtemplates/{fileSpecificationTemplateId} | Get File Specification Template |
| [**GetOutboundFilespecificationtemplates**](#GetOutboundFilespecificationtemplates) | **Get** /api/v2/outbound/filespecificationtemplates | Query File Specification Templates |
| [**GetOutboundImporttemplate**](#GetOutboundImporttemplate) | **Get** /api/v2/outbound/importtemplates/{importTemplateId} | Get Import Template |
| [**GetOutboundImporttemplateImportstatus**](#GetOutboundImporttemplateImportstatus) | **Get** /api/v2/outbound/importtemplates/{importTemplateId}/importstatus | Get the import status for an import template. |
| [**GetOutboundImporttemplates**](#GetOutboundImporttemplates) | **Get** /api/v2/outbound/importtemplates | Query Import Templates |
| [**GetOutboundMessagingcampaign**](#GetOutboundMessagingcampaign) | **Get** /api/v2/outbound/messagingcampaigns/{messagingCampaignId} | Get an Outbound Messaging Campaign |
| [**GetOutboundMessagingcampaignDiagnostics**](#GetOutboundMessagingcampaignDiagnostics) | **Get** /api/v2/outbound/messagingcampaigns/{messagingCampaignId}/diagnostics | Get messaging campaign diagnostics |
| [**GetOutboundMessagingcampaignProgress**](#GetOutboundMessagingcampaignProgress) | **Get** /api/v2/outbound/messagingcampaigns/{messagingCampaignId}/progress | Get messaging campaign&#39;s progress |
| [**GetOutboundMessagingcampaigns**](#GetOutboundMessagingcampaigns) | **Get** /api/v2/outbound/messagingcampaigns | Query a list of Messaging Campaigns |
| [**GetOutboundMessagingcampaignsDivisionview**](#GetOutboundMessagingcampaignsDivisionview) | **Get** /api/v2/outbound/messagingcampaigns/divisionviews/{messagingCampaignId} | Get a basic Messaging Campaign information object |
| [**GetOutboundMessagingcampaignsDivisionviews**](#GetOutboundMessagingcampaignsDivisionviews) | **Get** /api/v2/outbound/messagingcampaigns/divisionviews | Query a list of basic Messaging Campaign information objects |
| [**GetOutboundRuleset**](#GetOutboundRuleset) | **Get** /api/v2/outbound/rulesets/{ruleSetId} | Get a Rule Set by ID. |
| [**GetOutboundRulesets**](#GetOutboundRulesets) | **Get** /api/v2/outbound/rulesets | Query a list of Rule Sets. |
| [**GetOutboundSchedulesCampaign**](#GetOutboundSchedulesCampaign) | **Get** /api/v2/outbound/schedules/campaigns/{campaignId} | Get a dialer campaign schedule. |
| [**GetOutboundSchedulesCampaigns**](#GetOutboundSchedulesCampaigns) | **Get** /api/v2/outbound/schedules/campaigns | Query for a list of dialer campaign schedules. |
| [**GetOutboundSchedulesEmailcampaign**](#GetOutboundSchedulesEmailcampaign) | **Get** /api/v2/outbound/schedules/emailcampaigns/{emailCampaignId} | Get an email campaign schedule. |
| [**GetOutboundSchedulesEmailcampaigns**](#GetOutboundSchedulesEmailcampaigns) | **Get** /api/v2/outbound/schedules/emailcampaigns | Query for a list of email campaign schedules. |
| [**GetOutboundSchedulesMessagingcampaign**](#GetOutboundSchedulesMessagingcampaign) | **Get** /api/v2/outbound/schedules/messagingcampaigns/{messagingCampaignId} | Get a messaging campaign schedule. |
| [**GetOutboundSchedulesMessagingcampaigns**](#GetOutboundSchedulesMessagingcampaigns) | **Get** /api/v2/outbound/schedules/messagingcampaigns | Query for a list of messaging campaign schedules. |
| [**GetOutboundSchedulesSequence**](#GetOutboundSchedulesSequence) | **Get** /api/v2/outbound/schedules/sequences/{sequenceId} | Get a dialer sequence schedule. |
| [**GetOutboundSchedulesSequences**](#GetOutboundSchedulesSequences) | **Get** /api/v2/outbound/schedules/sequences | Query for a list of dialer sequence schedules. |
| [**GetOutboundSequence**](#GetOutboundSequence) | **Get** /api/v2/outbound/sequences/{sequenceId} | Get a dialer campaign sequence. |
| [**GetOutboundSequences**](#GetOutboundSequences) | **Get** /api/v2/outbound/sequences | Query a list of dialer campaign sequences. |
| [**GetOutboundSettings**](#GetOutboundSettings) | **Get** /api/v2/outbound/settings | Get the outbound settings for this organization |
| [**GetOutboundWrapupcodemappings**](#GetOutboundWrapupcodemappings) | **Get** /api/v2/outbound/wrapupcodemappings | Get the Dialer wrap up code mapping. |
| [**PatchOutboundCampaign**](#PatchOutboundCampaign) | **Patch** /api/v2/outbound/campaigns/{campaignId} | Update a campaign. |
| [**PatchOutboundDnclistCustomexclusioncolumns**](#PatchOutboundDnclistCustomexclusioncolumns) | **Patch** /api/v2/outbound/dnclists/{dncListId}/customexclusioncolumns | Add entries to or delete entries from a DNC list. |
| [**PatchOutboundDnclistEmailaddresses**](#PatchOutboundDnclistEmailaddresses) | **Patch** /api/v2/outbound/dnclists/{dncListId}/emailaddresses | Add emails to or Delete emails from a DNC list. |
| [**PatchOutboundDnclistPhonenumbers**](#PatchOutboundDnclistPhonenumbers) | **Patch** /api/v2/outbound/dnclists/{dncListId}/phonenumbers | Add numbers to or delete numbers from a DNC list. |
| [**PatchOutboundSettings**](#PatchOutboundSettings) | **Patch** /api/v2/outbound/settings | Update the outbound settings for this organization |
| [**PostOutboundAttemptlimits**](#PostOutboundAttemptlimits) | **Post** /api/v2/outbound/attemptlimits | Create attempt limits |
| [**PostOutboundCallabletimesets**](#PostOutboundCallabletimesets) | **Post** /api/v2/outbound/callabletimesets | Create callable time set |
| [**PostOutboundCallanalysisresponsesets**](#PostOutboundCallanalysisresponsesets) | **Post** /api/v2/outbound/callanalysisresponsesets | Create a dialer call analysis response set. |
| [**PostOutboundCampaignAgentownedmappingpreview**](#PostOutboundCampaignAgentownedmappingpreview) | **Post** /api/v2/outbound/campaigns/{campaignId}/agentownedmappingpreview | Initiate request for a preview of how agents will be mapped to this campaign&#39;s contact list. |
| [**PostOutboundCampaignCallbackSchedule**](#PostOutboundCampaignCallbackSchedule) | **Post** /api/v2/outbound/campaigns/{campaignId}/callback/schedule | Schedule a Callback for a Dialer Campaign (Deprecated) |
| [**PostOutboundCampaignStart**](#PostOutboundCampaignStart) | **Post** /api/v2/outbound/campaigns/{campaignId}/start | Start the campaign |
| [**PostOutboundCampaignStop**](#PostOutboundCampaignStop) | **Post** /api/v2/outbound/campaigns/{campaignId}/stop | Stop the campaign |
| [**PostOutboundCampaignrules**](#PostOutboundCampaignrules) | **Post** /api/v2/outbound/campaignrules | Create Campaign Rule |
| [**PostOutboundCampaigns**](#PostOutboundCampaigns) | **Post** /api/v2/outbound/campaigns | Create a campaign. |
| [**PostOutboundCampaignsProgress**](#PostOutboundCampaignsProgress) | **Post** /api/v2/outbound/campaigns/progress | Get progress for a list of campaigns |
| [**PostOutboundContactlistClear**](#PostOutboundContactlistClear) | **Post** /api/v2/outbound/contactlists/{contactListId}/clear | Deletes all contacts out of a list. All outstanding recalls or rule-scheduled callbacks for non-preview campaigns configured with the contactlist will be cancelled. |
| [**PostOutboundContactlistContacts**](#PostOutboundContactlistContacts) | **Post** /api/v2/outbound/contactlists/{contactListId}/contacts | Add contacts to a contact list. |
| [**PostOutboundContactlistContactsBulk**](#PostOutboundContactlistContactsBulk) | **Post** /api/v2/outbound/contactlists/{contactListId}/contacts/bulk | Get contacts from a contact list. |
| [**PostOutboundContactlistContactsBulkRemove**](#PostOutboundContactlistContactsBulkRemove) | **Post** /api/v2/outbound/contactlists/{contactListId}/contacts/bulk/remove | Start an async job to delete contacts using a filter. |
| [**PostOutboundContactlistContactsBulkUpdate**](#PostOutboundContactlistContactsBulkUpdate) | **Post** /api/v2/outbound/contactlists/{contactListId}/contacts/bulk/update | Start an async job to bulk edit contacts. |
| [**PostOutboundContactlistContactsSearch**](#PostOutboundContactlistContactsSearch) | **Post** /api/v2/outbound/contactlists/{contactListId}/contacts/search | Query contacts from a contact list. |
| [**PostOutboundContactlistExport**](#PostOutboundContactlistExport) | **Post** /api/v2/outbound/contactlists/{contactListId}/export | Initiate the export of a contact list. |
| [**PostOutboundContactlistfilters**](#PostOutboundContactlistfilters) | **Post** /api/v2/outbound/contactlistfilters | Create Contact List Filter |
| [**PostOutboundContactlistfiltersBulkRetrieve**](#PostOutboundContactlistfiltersBulkRetrieve) | **Post** /api/v2/outbound/contactlistfilters/bulk/retrieve | Retrieve multiple contact list filters |
| [**PostOutboundContactlistfiltersPreview**](#PostOutboundContactlistfiltersPreview) | **Post** /api/v2/outbound/contactlistfilters/preview | Get a preview of the output of a contact list filter |
| [**PostOutboundContactlists**](#PostOutboundContactlists) | **Post** /api/v2/outbound/contactlists | Create a contact List. |
| [**PostOutboundContactlisttemplates**](#PostOutboundContactlisttemplates) | **Post** /api/v2/outbound/contactlisttemplates | Create Contact List Template |
| [**PostOutboundContactlisttemplatesBulkAdd**](#PostOutboundContactlisttemplatesBulkAdd) | **Post** /api/v2/outbound/contactlisttemplates/bulk/add | Add multiple contact list templates |
| [**PostOutboundContactlisttemplatesBulkRetrieve**](#PostOutboundContactlisttemplatesBulkRetrieve) | **Post** /api/v2/outbound/contactlisttemplates/bulk/retrieve | Get multiple contact list templates |
| [**PostOutboundConversationDnc**](#PostOutboundConversationDnc) | **Post** /api/v2/outbound/conversations/{conversationId}/dnc | Add phone numbers to a Dialer DNC list. |
| [**PostOutboundDigitalrulesets**](#PostOutboundDigitalrulesets) | **Post** /api/v2/outbound/digitalrulesets | Create an Outbound Digital Rule Set |
| [**PostOutboundDnclistEmailaddresses**](#PostOutboundDnclistEmailaddresses) | **Post** /api/v2/outbound/dnclists/{dncListId}/emailaddresses | Add email addresses to a DNC list. |
| [**PostOutboundDnclistExport**](#PostOutboundDnclistExport) | **Post** /api/v2/outbound/dnclists/{dncListId}/export | Initiate the export of a dnc list. |
| [**PostOutboundDnclistPhonenumbers**](#PostOutboundDnclistPhonenumbers) | **Post** /api/v2/outbound/dnclists/{dncListId}/phonenumbers | Add phone numbers to a DNC list. |
| [**PostOutboundDnclists**](#PostOutboundDnclists) | **Post** /api/v2/outbound/dnclists | Create dialer DNC list |
| [**PostOutboundFilespecificationtemplates**](#PostOutboundFilespecificationtemplates) | **Post** /api/v2/outbound/filespecificationtemplates | Create File Specification Template |
| [**PostOutboundImporttemplates**](#PostOutboundImporttemplates) | **Post** /api/v2/outbound/importtemplates | Create Import Template |
| [**PostOutboundImporttemplatesBulkAdd**](#PostOutboundImporttemplatesBulkAdd) | **Post** /api/v2/outbound/importtemplates/bulk/add | Add multiple import templates |
| [**PostOutboundMessagingcampaignStart**](#PostOutboundMessagingcampaignStart) | **Post** /api/v2/outbound/messagingcampaigns/{messagingCampaignId}/start | Start the campaign |
| [**PostOutboundMessagingcampaignStop**](#PostOutboundMessagingcampaignStop) | **Post** /api/v2/outbound/messagingcampaigns/{messagingCampaignId}/stop | Stop the campaign |
| [**PostOutboundMessagingcampaigns**](#PostOutboundMessagingcampaigns) | **Post** /api/v2/outbound/messagingcampaigns | Create a Messaging Campaign |
| [**PostOutboundMessagingcampaignsProgress**](#PostOutboundMessagingcampaignsProgress) | **Post** /api/v2/outbound/messagingcampaigns/progress | Get progress for a list of messaging campaigns |
| [**PostOutboundRulesets**](#PostOutboundRulesets) | **Post** /api/v2/outbound/rulesets | Create a Rule Set. |
| [**PostOutboundSequences**](#PostOutboundSequences) | **Post** /api/v2/outbound/sequences | Create a new campaign sequence. |
| [**PutOutboundAttemptlimit**](#PutOutboundAttemptlimit) | **Put** /api/v2/outbound/attemptlimits/{attemptLimitsId} | Update attempt limits |
| [**PutOutboundCallabletimeset**](#PutOutboundCallabletimeset) | **Put** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Update callable time set |
| [**PutOutboundCallanalysisresponseset**](#PutOutboundCallanalysisresponseset) | **Put** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Update a dialer call analysis response set. |
| [**PutOutboundCampaign**](#PutOutboundCampaign) | **Put** /api/v2/outbound/campaigns/{campaignId} | Update a campaign. |
| [**PutOutboundCampaignAgent**](#PutOutboundCampaignAgent) | **Put** /api/v2/outbound/campaigns/{campaignId}/agents/{userId} | Send notification that an agent&#39;s state changed  |
| [**PutOutboundCampaignrule**](#PutOutboundCampaignrule) | **Put** /api/v2/outbound/campaignrules/{campaignRuleId} | Update Campaign Rule |
| [**PutOutboundContactlist**](#PutOutboundContactlist) | **Put** /api/v2/outbound/contactlists/{contactListId} | Update a contact list. |
| [**PutOutboundContactlistContact**](#PutOutboundContactlistContact) | **Put** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Update a contact. |
| [**PutOutboundContactlistfilter**](#PutOutboundContactlistfilter) | **Put** /api/v2/outbound/contactlistfilters/{contactListFilterId} | Update Contact List Filter |
| [**PutOutboundContactlisttemplate**](#PutOutboundContactlisttemplate) | **Put** /api/v2/outbound/contactlisttemplates/{contactListTemplateId} | Update a contact list template. |
| [**PutOutboundDigitalruleset**](#PutOutboundDigitalruleset) | **Put** /api/v2/outbound/digitalrulesets/{digitalRuleSetId} | Update an Outbound Digital Rule Set |
| [**PutOutboundDnclist**](#PutOutboundDnclist) | **Put** /api/v2/outbound/dnclists/{dncListId} | Update dialer DNC list |
| [**PutOutboundFilespecificationtemplate**](#PutOutboundFilespecificationtemplate) | **Put** /api/v2/outbound/filespecificationtemplates/{fileSpecificationTemplateId} | Update File Specification Template |
| [**PutOutboundImporttemplate**](#PutOutboundImporttemplate) | **Put** /api/v2/outbound/importtemplates/{importTemplateId} | Update Import Template |
| [**PutOutboundMessagingcampaign**](#PutOutboundMessagingcampaign) | **Put** /api/v2/outbound/messagingcampaigns/{messagingCampaignId} | Update an Outbound Messaging Campaign |
| [**PutOutboundRuleset**](#PutOutboundRuleset) | **Put** /api/v2/outbound/rulesets/{ruleSetId} | Update a Rule Set. |
| [**PutOutboundSchedulesCampaign**](#PutOutboundSchedulesCampaign) | **Put** /api/v2/outbound/schedules/campaigns/{campaignId} | Update a new campaign schedule. |
| [**PutOutboundSchedulesEmailcampaign**](#PutOutboundSchedulesEmailcampaign) | **Put** /api/v2/outbound/schedules/emailcampaigns/{emailCampaignId} | Update an email campaign schedule. |
| [**PutOutboundSchedulesMessagingcampaign**](#PutOutboundSchedulesMessagingcampaign) | **Put** /api/v2/outbound/schedules/messagingcampaigns/{messagingCampaignId} | Update a new messaging campaign schedule. |
| [**PutOutboundSchedulesSequence**](#PutOutboundSchedulesSequence) | **Put** /api/v2/outbound/schedules/sequences/{sequenceId} | Update a new sequence schedule. |
| [**PutOutboundSequence**](#PutOutboundSequence) | **Put** /api/v2/outbound/sequences/{sequenceId} | Update a new campaign sequence. |
| [**PutOutboundWrapupcodemappings**](#PutOutboundWrapupcodemappings) | **Put** /api/v2/outbound/wrapupcodemappings | Update the Dialer wrap up code mapping. |



## DeleteOutboundAttemptlimit

> void DeleteOutboundAttemptlimit (string attemptLimitsId)


Delete attempt limits

Requires ANY permissions: 

* outbound:attemptLimits:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundAttemptlimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var attemptLimitsId = attemptLimitsId_example;  // string | Attempt limits ID

            try
            { 
                // Delete attempt limits
                apiInstance.DeleteOutboundAttemptlimit(attemptLimitsId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundAttemptlimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attemptLimitsId** | **string**| Attempt limits ID |  |

### Return type

void (empty response body)


## DeleteOutboundCallabletimeset

> void DeleteOutboundCallabletimeset (string callableTimeSetId)


Delete callable time set

Requires ANY permissions: 

* outbound:callableTimeSet:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCallabletimesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID

            try
            { 
                // Delete callable time set
                apiInstance.DeleteOutboundCallabletimeset(callableTimeSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCallabletimeset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |

### Return type

void (empty response body)


## DeleteOutboundCallanalysisresponseset

> void DeleteOutboundCallanalysisresponseset (string callAnalysisSetId)


Delete a dialer call analysis response set.

Requires ANY permissions: 

* outbound:responseSet:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCallanalysisresponsesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID

            try
            { 
                // Delete a dialer call analysis response set.
                apiInstance.DeleteOutboundCallanalysisresponseset(callAnalysisSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCallanalysisresponseset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |

### Return type

void (empty response body)


## DeleteOutboundCampaign

> [**Campaign**](Campaign) DeleteOutboundCampaign (string campaignId)


Delete a campaign.

Requires ANY permissions: 

* outbound:campaign:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Delete a campaign.
                Campaign result = apiInstance.DeleteOutboundCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

[**Campaign**](Campaign)


## DeleteOutboundCampaignProgress

> void DeleteOutboundCampaignProgress (string campaignId)


Reset campaign progress and recycle the campaign

Requires ANY permissions: 

* outbound:campaign:edit
* outbound:campaign:recycle

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCampaignProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Reset campaign progress and recycle the campaign
                apiInstance.DeleteOutboundCampaignProgress(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCampaignProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

void (empty response body)


## DeleteOutboundCampaignrule

> void DeleteOutboundCampaignrule (string campaignRuleId)


Delete Campaign Rule

Requires ANY permissions: 

* outbound:campaignRule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundCampaignruleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignRuleId = campaignRuleId_example;  // string | Campaign Rule ID

            try
            { 
                // Delete Campaign Rule
                apiInstance.DeleteOutboundCampaignrule(campaignRuleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundCampaignrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignRuleId** | **string**| Campaign Rule ID |  |

### Return type

void (empty response body)


## DeleteOutboundContactlist

> void DeleteOutboundContactlist (string contactListId)


Delete a contact list.

Requires ANY permissions: 

* outbound:contactList:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID

            try
            { 
                // Delete a contact list.
                apiInstance.DeleteOutboundContactlist(contactListId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |

### Return type

void (empty response body)


## DeleteOutboundContactlistContact

> void DeleteOutboundContactlistContact (string contactListId, string contactId)


Delete a contact.

Requires ANY permissions: 

* outbound:contact:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistContactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactId = contactId_example;  // string | Contact ID

            try
            { 
                // Delete a contact.
                apiInstance.DeleteOutboundContactlistContact(contactListId, contactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlistContact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |

### Return type

void (empty response body)


## DeleteOutboundContactlistContacts

> void DeleteOutboundContactlistContacts (string contactListId, List<string> contactIds)


Delete contacts from a contact list.

Requires ANY permissions: 

* outbound:contact:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistContactsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactIds = new List<string>(); // List<string> | ContactIds to delete.

            try
            { 
                // Delete contacts from a contact list.
                apiInstance.DeleteOutboundContactlistContacts(contactListId, contactIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlistContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactIds** | [**List<string>**](string)| ContactIds to delete. |  |

### Return type

void (empty response body)


## DeleteOutboundContactlistfilter

> void DeleteOutboundContactlistfilter (string contactListFilterId)


Delete Contact List Filter

Requires ANY permissions: 

* outbound:contactListFilter:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistfilterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListFilterId = contactListFilterId_example;  // string | Contact List Filter ID

            try
            { 
                // Delete Contact List Filter
                apiInstance.DeleteOutboundContactlistfilter(contactListFilterId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlistfilter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListFilterId** | **string**| Contact List Filter ID |  |

### Return type

void (empty response body)


## DeleteOutboundContactlists

> void DeleteOutboundContactlists (List<string> id)


Delete multiple contact lists.

Requires ANY permissions: 

* outbound:contactList:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlistsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var id = new List<string>(); // List<string> | contact list id(s) to delete

            try
            { 
                // Delete multiple contact lists.
                apiInstance.DeleteOutboundContactlists(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlists: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string)| contact list id(s) to delete |  |

### Return type

void (empty response body)


## DeleteOutboundContactlisttemplate

> void DeleteOutboundContactlisttemplate (string contactListTemplateId)


Delete Contact List Template

Requires ANY permissions: 

* outbound:contactListTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlisttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListTemplateId = contactListTemplateId_example;  // string | ContactListTemplate ID

            try
            { 
                // Delete Contact List Template
                apiInstance.DeleteOutboundContactlisttemplate(contactListTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlisttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListTemplateId** | **string**| ContactListTemplate ID |  |

### Return type

void (empty response body)


## DeleteOutboundContactlisttemplates

> void DeleteOutboundContactlisttemplates (List<string> id)


Delete multiple contact list templates.

Requires ANY permissions: 

* outbound:contactListTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundContactlisttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var id = new List<string>(); // List<string> | contact list template id(s) to delete

            try
            { 
                // Delete multiple contact list templates.
                apiInstance.DeleteOutboundContactlisttemplates(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundContactlisttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string)| contact list template id(s) to delete |  |

### Return type

void (empty response body)


## DeleteOutboundDigitalruleset

> void DeleteOutboundDigitalruleset (string digitalRuleSetId)


Delete an Outbound Digital Rule Set

Requires ANY permissions: 

* outbound:digitalRuleSet:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDigitalrulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var digitalRuleSetId = digitalRuleSetId_example;  // string | The Digital Rule Set ID

            try
            { 
                // Delete an Outbound Digital Rule Set
                apiInstance.DeleteOutboundDigitalruleset(digitalRuleSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDigitalruleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **digitalRuleSetId** | **string**| The Digital Rule Set ID |  |

### Return type

void (empty response body)


## DeleteOutboundDnclist

> void DeleteOutboundDnclist (string dncListId)


Delete dialer DNC list

Requires ANY permissions: 

* outbound:dncList:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDnclistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID

            try
            { 
                // Delete dialer DNC list
                apiInstance.DeleteOutboundDnclist(dncListId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDnclist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |

### Return type

void (empty response body)


## DeleteOutboundDnclistCustomexclusioncolumns

> void DeleteOutboundDnclistCustomexclusioncolumns (string dncListId, bool? expiredOnly = null)


Deletes all or expired custom exclusion column entries from a DNC list.

This operation is only for Internal DNC lists of custom exclusion column entries

Requires ANY permissions: 

* outbound:dnc:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDnclistCustomexclusioncolumnsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var expiredOnly = true;  // bool? | Set to true to only remove DNC entries that are expired (optional)  (default to false)

            try
            { 
                // Deletes all or expired custom exclusion column entries from a DNC list.
                apiInstance.DeleteOutboundDnclistCustomexclusioncolumns(dncListId, expiredOnly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDnclistCustomexclusioncolumns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **expiredOnly** | **bool?**| Set to true to only remove DNC entries that are expired | [optional] [default to false] |

### Return type

void (empty response body)


## DeleteOutboundDnclistEmailaddresses

> void DeleteOutboundDnclistEmailaddresses (string dncListId, bool? expiredOnly = null)


Deletes all or expired email addresses from a DNC list.

This operation is Only for Internal DNC lists of email addresses

Requires ANY permissions: 

* outbound:dnc:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDnclistEmailaddressesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var expiredOnly = true;  // bool? | Set to true to only remove DNC entries that are expired (optional)  (default to false)

            try
            { 
                // Deletes all or expired email addresses from a DNC list.
                apiInstance.DeleteOutboundDnclistEmailaddresses(dncListId, expiredOnly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDnclistEmailaddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **expiredOnly** | **bool?**| Set to true to only remove DNC entries that are expired | [optional] [default to false] |

### Return type

void (empty response body)


## DeleteOutboundDnclistPhonenumbers

> void DeleteOutboundDnclistPhonenumbers (string dncListId, bool? expiredOnly = null)


Deletes all or expired phone numbers from a DNC list.

This operation is Only for Internal DNC lists of phone numbers

Requires ANY permissions: 

* outbound:dnc:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundDnclistPhonenumbersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var expiredOnly = true;  // bool? | Set to true to only remove DNC entries that are expired (optional)  (default to false)

            try
            { 
                // Deletes all or expired phone numbers from a DNC list.
                apiInstance.DeleteOutboundDnclistPhonenumbers(dncListId, expiredOnly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundDnclistPhonenumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **expiredOnly** | **bool?**| Set to true to only remove DNC entries that are expired | [optional] [default to false] |

### Return type

void (empty response body)


## DeleteOutboundFilespecificationtemplate

> void DeleteOutboundFilespecificationtemplate (string fileSpecificationTemplateId)


Delete File Specification Template

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundFilespecificationtemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var fileSpecificationTemplateId = fileSpecificationTemplateId_example;  // string | File Specification Template ID

            try
            { 
                // Delete File Specification Template
                apiInstance.DeleteOutboundFilespecificationtemplate(fileSpecificationTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundFilespecificationtemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **fileSpecificationTemplateId** | **string**| File Specification Template ID |  |

### Return type

void (empty response body)


## DeleteOutboundFilespecificationtemplatesBulk

> void DeleteOutboundFilespecificationtemplatesBulk (List<string> id)


Delete multiple file specification templates.

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundFilespecificationtemplatesBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var id = new List<string>(); // List<string> | File Specification template id(s) to delete

            try
            { 
                // Delete multiple file specification templates.
                apiInstance.DeleteOutboundFilespecificationtemplatesBulk(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundFilespecificationtemplatesBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string)| File Specification template id(s) to delete |  |

### Return type

void (empty response body)


## DeleteOutboundImporttemplate

> void DeleteOutboundImporttemplate (string importTemplateId)


Delete Import Template

Requires ANY permissions: 

* outbound:importTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundImporttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var importTemplateId = importTemplateId_example;  // string | Import Template ID

            try
            { 
                // Delete Import Template
                apiInstance.DeleteOutboundImporttemplate(importTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundImporttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **importTemplateId** | **string**| Import Template ID |  |

### Return type

void (empty response body)


## DeleteOutboundImporttemplates

> void DeleteOutboundImporttemplates (List<string> id)


Delete multiple import templates.

Requires ANY permissions: 

* outbound:importTemplate:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundImporttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var id = new List<string>(); // List<string> | import template id(s) to delete

            try
            { 
                // Delete multiple import templates.
                apiInstance.DeleteOutboundImporttemplates(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundImporttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string)| import template id(s) to delete |  |

### Return type

void (empty response body)


## DeleteOutboundMessagingcampaign

> [**MessagingCampaign**](MessagingCampaign) DeleteOutboundMessagingcampaign (string messagingCampaignId)


Delete an Outbound Messaging Campaign

Requires ANY permissions: 

* outbound:messagingCampaign:delete
* outbound:emailCampaign:delete
* outbound:whatsAppCampaign:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Delete an Outbound Messaging Campaign
                MessagingCampaign result = apiInstance.DeleteOutboundMessagingcampaign(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |

### Return type

[**MessagingCampaign**](MessagingCampaign)


## DeleteOutboundMessagingcampaignProgress

> void DeleteOutboundMessagingcampaignProgress (string messagingCampaignId)


Reset messaging campaign progress and recycle the messaging campaign

Documented permissions are applicable based on campaign type.

Requires ANY permissions: 

* outbound:messagingCampaign:edit
* outbound:messagingCampaign:recycle
* outbound:emailCampaign:edit
* outbound:emailCampaign:recycle
* outbound:whatsAppCampaign:edit
* outbound:whatsAppCampaign:recycle

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundMessagingcampaignProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Reset messaging campaign progress and recycle the messaging campaign
                apiInstance.DeleteOutboundMessagingcampaignProgress(messagingCampaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundMessagingcampaignProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |

### Return type

void (empty response body)


## DeleteOutboundRuleset

> void DeleteOutboundRuleset (string ruleSetId)


Delete a Rule Set.

Requires ANY permissions: 

* outbound:ruleSet:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundRulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID

            try
            { 
                // Delete a Rule Set.
                apiInstance.DeleteOutboundRuleset(ruleSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundRuleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |

### Return type

void (empty response body)


## DeleteOutboundSchedulesCampaign

> void DeleteOutboundSchedulesCampaign (string campaignId)


Delete a dialer campaign schedule.

Requires ANY permissions: 

* outbound:schedule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSchedulesCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Delete a dialer campaign schedule.
                apiInstance.DeleteOutboundSchedulesCampaign(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSchedulesCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

void (empty response body)


## DeleteOutboundSchedulesEmailcampaign

> void DeleteOutboundSchedulesEmailcampaign (string emailCampaignId)


Delete an email campaign schedule.

Requires ANY permissions: 

* outbound:emailCampaignSchedule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSchedulesEmailcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var emailCampaignId = emailCampaignId_example;  // string | Email Campaign ID

            try
            { 
                // Delete an email campaign schedule.
                apiInstance.DeleteOutboundSchedulesEmailcampaign(emailCampaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSchedulesEmailcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailCampaignId** | **string**| Email Campaign ID |  |

### Return type

void (empty response body)


## DeleteOutboundSchedulesMessagingcampaign

> void DeleteOutboundSchedulesMessagingcampaign (string messagingCampaignId)


Delete a messaging campaign schedule.

Requires ANY permissions: 

* outbound:messagingCampaignSchedule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSchedulesMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | Messaging Campaign ID

            try
            { 
                // Delete a messaging campaign schedule.
                apiInstance.DeleteOutboundSchedulesMessagingcampaign(messagingCampaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSchedulesMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| Messaging Campaign ID |  |

### Return type

void (empty response body)


## DeleteOutboundSchedulesSequence

> void DeleteOutboundSchedulesSequence (string sequenceId)


Delete a dialer sequence schedule.

Requires ANY permissions: 

* outbound:schedule:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSchedulesSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Sequence ID

            try
            { 
                // Delete a dialer sequence schedule.
                apiInstance.DeleteOutboundSchedulesSequence(sequenceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSchedulesSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |

### Return type

void (empty response body)


## DeleteOutboundSequence

> void DeleteOutboundSequence (string sequenceId)


Delete a dialer campaign sequence.

Requires ANY permissions: 

* outbound:campaignSequence:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteOutboundSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID

            try
            { 
                // Delete a dialer campaign sequence.
                apiInstance.DeleteOutboundSequence(sequenceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteOutboundSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |

### Return type

void (empty response body)


## GetOutboundAttemptlimit

> [**AttemptLimits**](AttemptLimits) GetOutboundAttemptlimit (string attemptLimitsId)


Get attempt limits

Requires ANY permissions: 

* outbound:attemptLimits:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundAttemptlimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var attemptLimitsId = attemptLimitsId_example;  // string | Attempt limits ID

            try
            { 
                // Get attempt limits
                AttemptLimits result = apiInstance.GetOutboundAttemptlimit(attemptLimitsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundAttemptlimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attemptLimitsId** | **string**| Attempt limits ID |  |

### Return type

[**AttemptLimits**](AttemptLimits)


## GetOutboundAttemptlimits

> [**AttemptLimitsEntityListing**](AttemptLimitsEntityListing) GetOutboundAttemptlimits (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)


Query attempt limits list

Requires ANY permissions: 

* outbound:attemptLimits:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundAttemptlimitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query attempt limits list
                AttemptLimitsEntityListing result = apiInstance.GetOutboundAttemptlimits(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundAttemptlimits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**AttemptLimitsEntityListing**](AttemptLimitsEntityListing)


## GetOutboundCallabletimeset

> [**CallableTimeSet**](CallableTimeSet) GetOutboundCallabletimeset (string callableTimeSetId)


Get callable time set

Requires ANY permissions: 

* outbound:callableTimeSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallabletimesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID

            try
            { 
                // Get callable time set
                CallableTimeSet result = apiInstance.GetOutboundCallabletimeset(callableTimeSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallabletimeset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |

### Return type

[**CallableTimeSet**](CallableTimeSet)


## GetOutboundCallabletimesets

> [**CallableTimeSetEntityListing**](CallableTimeSetEntityListing) GetOutboundCallabletimesets (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)


Query callable time set list

Requires ANY permissions: 

* outbound:callableTimeSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallabletimesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query callable time set list
                CallableTimeSetEntityListing result = apiInstance.GetOutboundCallabletimesets(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallabletimesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**CallableTimeSetEntityListing**](CallableTimeSetEntityListing)


## GetOutboundCallanalysisresponseset

> [**ResponseSet**](ResponseSet) GetOutboundCallanalysisresponseset (string callAnalysisSetId)


Get a dialer call analysis response set.

Requires ANY permissions: 

* outbound:responseSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallanalysisresponsesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID

            try
            { 
                // Get a dialer call analysis response set.
                ResponseSet result = apiInstance.GetOutboundCallanalysisresponseset(callAnalysisSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallanalysisresponseset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |

### Return type

[**ResponseSet**](ResponseSet)


## GetOutboundCallanalysisresponsesets

> [**ResponseSetEntityListing**](ResponseSetEntityListing) GetOutboundCallanalysisresponsesets (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)


Query a list of dialer call analysis response sets.

Requires ANY permissions: 

* outbound:responseSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCallanalysisresponsesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of dialer call analysis response sets.
                ResponseSetEntityListing result = apiInstance.GetOutboundCallanalysisresponsesets(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCallanalysisresponsesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**ResponseSetEntityListing**](ResponseSetEntityListing)


## GetOutboundCampaign

> [**Campaign**](Campaign) GetOutboundCampaign (string campaignId)


Get dialer campaign.

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get dialer campaign.
                Campaign result = apiInstance.GetOutboundCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

[**Campaign**](Campaign)


## GetOutboundCampaignAgentownedmappingpreviewResults

> [**AgentOwnedMappingPreviewListing**](AgentOwnedMappingPreviewListing) GetOutboundCampaignAgentownedmappingpreviewResults (string campaignId)


Get a preview of how agents will be mapped to this campaign's contact list.

Requires ALL permissions: 

* outbound:campaign:view
* outbound:contact:view
* routing:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignAgentownedmappingpreviewResultsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get a preview of how agents will be mapped to this campaign's contact list.
                AgentOwnedMappingPreviewListing result = apiInstance.GetOutboundCampaignAgentownedmappingpreviewResults(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignAgentownedmappingpreviewResults: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

[**AgentOwnedMappingPreviewListing**](AgentOwnedMappingPreviewListing)


## GetOutboundCampaignDiagnostics

> [**CampaignDiagnostics**](CampaignDiagnostics) GetOutboundCampaignDiagnostics (string campaignId)


Get campaign diagnostics

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignDiagnosticsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get campaign diagnostics
                CampaignDiagnostics result = apiInstance.GetOutboundCampaignDiagnostics(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignDiagnostics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

[**CampaignDiagnostics**](CampaignDiagnostics)


## GetOutboundCampaignInteractions

> [**CampaignInteractions**](CampaignInteractions) GetOutboundCampaignInteractions (string campaignId)


Get dialer campaign interactions.

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignInteractionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get dialer campaign interactions.
                CampaignInteractions result = apiInstance.GetOutboundCampaignInteractions(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignInteractions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

[**CampaignInteractions**](CampaignInteractions)


## GetOutboundCampaignLinedistribution

> [**CampaignOutboundLinesDistribution**](CampaignOutboundLinesDistribution) GetOutboundCampaignLinedistribution (string campaignId, bool? includeOnlyActiveCampaigns = null, string edgeGroupId = null, string siteId = null, bool? useWeight = null, int? relativeWeight = null, int? outboundLineCount = null)


Get line distribution information for campaigns using same Edge Group or Site as given campaign

Requires ANY permissions: 

* outbound:lineDistribution:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignLinedistributionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var includeOnlyActiveCampaigns = true;  // bool? | If true will return only active Campaigns (optional)  (default to true)
            var edgeGroupId = edgeGroupId_example;  // string | Edge group to be used in line distribution calculations instead of current Campaign's Edge Group. Campaign's Site and Edge Group are mutually exclusive. (optional) 
            var siteId = siteId_example;  // string | Site to be used in line distribution calculations instead of current Campaign's Site.  Campaign's Site and Edge Group are mutually exclusive. (optional) 
            var useWeight = true;  // bool? | Enable usage of weight, this value overrides current Campaign's setting in line distribution calculations (optional) 
            var relativeWeight = 56;  // int? | Relative weight to be used in line distribution calculations instead of current Campaign's relative weight (optional) 
            var outboundLineCount = 56;  // int? | The number of outbound lines to be used in line distribution calculations, instead of current Campaign's Outbound Lines Count (optional) 

            try
            { 
                // Get line distribution information for campaigns using same Edge Group or Site as given campaign
                CampaignOutboundLinesDistribution result = apiInstance.GetOutboundCampaignLinedistribution(campaignId, includeOnlyActiveCampaigns, edgeGroupId, siteId, useWeight, relativeWeight, outboundLineCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignLinedistribution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **includeOnlyActiveCampaigns** | **bool?**| If true will return only active Campaigns | [optional] [default to true] |
| **edgeGroupId** | **string**| Edge group to be used in line distribution calculations instead of current Campaign&#39;s Edge Group. Campaign&#39;s Site and Edge Group are mutually exclusive. | [optional]  |
| **siteId** | **string**| Site to be used in line distribution calculations instead of current Campaign&#39;s Site.  Campaign&#39;s Site and Edge Group are mutually exclusive. | [optional]  |
| **useWeight** | **bool?**| Enable usage of weight, this value overrides current Campaign&#39;s setting in line distribution calculations | [optional]  |
| **relativeWeight** | **int?**| Relative weight to be used in line distribution calculations instead of current Campaign&#39;s relative weight | [optional]  |
| **outboundLineCount** | **int?**| The number of outbound lines to be used in line distribution calculations, instead of current Campaign&#39;s Outbound Lines Count | [optional]  |

### Return type

[**CampaignOutboundLinesDistribution**](CampaignOutboundLinesDistribution)


## GetOutboundCampaignProgress

> [**CampaignProgress**](CampaignProgress) GetOutboundCampaignProgress (string campaignId)


Get campaign progress

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get campaign progress
                CampaignProgress result = apiInstance.GetOutboundCampaignProgress(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

[**CampaignProgress**](CampaignProgress)


## GetOutboundCampaignSkillcombinations

> [**PagedSkillCombinationListing**](PagedSkillCombinationListing) GetOutboundCampaignSkillcombinations (string campaignId, int? pageNumber = null, int? pageSize = null)


Get the remaining and total contact count for each skill combination in a skills campaign

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignSkillcombinationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            { 
                // Get the remaining and total contact count for each skill combination in a skills campaign
                PagedSkillCombinationListing result = apiInstance.GetOutboundCampaignSkillcombinations(campaignId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignSkillcombinations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |

### Return type

[**PagedSkillCombinationListing**](PagedSkillCombinationListing)


## GetOutboundCampaignStats

> [**CampaignStats**](CampaignStats) GetOutboundCampaignStats (string campaignId)


Get statistics about a Dialer Campaign

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignStatsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get statistics about a Dialer Campaign
                CampaignStats result = apiInstance.GetOutboundCampaignStats(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignStats: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

[**CampaignStats**](CampaignStats)


## GetOutboundCampaignrule

> [**CampaignRule**](CampaignRule) GetOutboundCampaignrule (string campaignRuleId)


Get Campaign Rule

Requires ANY permissions: 

* outbound:campaignRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignruleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignRuleId = campaignRuleId_example;  // string | Campaign Rule ID

            try
            { 
                // Get Campaign Rule
                CampaignRule result = apiInstance.GetOutboundCampaignrule(campaignRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignRuleId** | **string**| Campaign Rule ID |  |

### Return type

[**CampaignRule**](CampaignRule)


## GetOutboundCampaignrules

> [**CampaignRuleEntityListing**](CampaignRuleEntityListing) GetOutboundCampaignrules (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)


Query Campaign Rule list

Requires ANY permissions: 

* outbound:campaignRule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignrulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query Campaign Rule list
                CampaignRuleEntityListing result = apiInstance.GetOutboundCampaignrules(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignrules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**CampaignRuleEntityListing**](CampaignRuleEntityListing)


## GetOutboundCampaigns

> [**CampaignEntityListing**](CampaignEntityListing) GetOutboundCampaigns (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, List<string> id = null, string contactListId = null, string dncListIds = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, List<string> divisionId = null, string sortBy = null, string sortOrder = null)


Query a list of dialer campaigns.

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var contactListId = contactListId_example;  // string | Contact List ID (optional) 
            var dncListIds = dncListIds_example;  // string | DNC list ID (optional) 
            var distributionQueueId = distributionQueueId_example;  // string | Distribution queue ID (optional) 
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID (optional) 
            var callAnalysisResponseSetId = callAnalysisResponseSetId_example;  // string | Call analysis response set ID (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of dialer campaigns.
                CampaignEntityListing result = apiInstance.GetOutboundCampaigns(pageSize, pageNumber, filterType, name, id, contactListId, dncListIds, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, divisionId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string)| id | [optional]  |
| **contactListId** | **string**| Contact List ID | [optional]  |
| **dncListIds** | **string**| DNC list ID | [optional]  |
| **distributionQueueId** | **string**| Distribution queue ID | [optional]  |
| **edgeGroupId** | **string**| Edge group ID | [optional]  |
| **callAnalysisResponseSetId** | **string**| Call analysis response set ID | [optional]  |
| **divisionId** | [**List<string>**](string)| Division ID(s) | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**CampaignEntityListing**](CampaignEntityListing)


## GetOutboundCampaignsAll

> [**CommonCampaignEntityListing**](CommonCampaignEntityListing) GetOutboundCampaignsAll (int? pageSize = null, int? pageNumber = null, List<string> id = null, string name = null, List<string> divisionId = null, List<string> mediaType = null, string sortOrder = null)


Query across all types of campaigns by division

Requires ANY permissions: 

* outbound:campaign:view
* outbound:messagingCampaign:view
* outbound:emailCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsAllExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | Campaign ID(s) (optional) 
            var name = name_example;  // string | Campaign name(s) (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var mediaType = new List<string>(); // List<string> | Media type(s) (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query across all types of campaigns by division
                CommonCampaignEntityListing result = apiInstance.GetOutboundCampaignsAll(pageSize, pageNumber, id, name, divisionId, mediaType, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignsAll: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **id** | [**List<string>**](string)| Campaign ID(s) | [optional]  |
| **name** | **string**| Campaign name(s) | [optional]  |
| **divisionId** | [**List<string>**](string)| Division ID(s) | [optional]  |
| **mediaType** | [**List<string>**](string)| Media type(s) | [optional] <br />**Values**: email, sms, voice |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**CommonCampaignEntityListing**](CommonCampaignEntityListing)


## GetOutboundCampaignsAllDivisionviews

> [**CommonCampaignDivisionViewEntityListing**](CommonCampaignDivisionViewEntityListing) GetOutboundCampaignsAllDivisionviews (int? pageSize = null, int? pageNumber = null, List<string> id = null, string name = null, List<string> divisionId = null, List<string> mediaType = null, string sortOrder = null)


Query across all types of campaigns

Requires ANY permissions: 

* outbound:campaign:search
* outbound:messagingCampaign:search
* outbound:emailCampaign:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsAllDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | Campaign ID(s) (optional) 
            var name = name_example;  // string | Campaign name(s) (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var mediaType = new List<string>(); // List<string> | Media type(s) (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query across all types of campaigns
                CommonCampaignDivisionViewEntityListing result = apiInstance.GetOutboundCampaignsAllDivisionviews(pageSize, pageNumber, id, name, divisionId, mediaType, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignsAllDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **id** | [**List<string>**](string)| Campaign ID(s) | [optional]  |
| **name** | **string**| Campaign name(s) | [optional]  |
| **divisionId** | [**List<string>**](string)| Division ID(s) | [optional]  |
| **mediaType** | [**List<string>**](string)| Media type(s) | [optional] <br />**Values**: email, sms, voice |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**CommonCampaignDivisionViewEntityListing**](CommonCampaignDivisionViewEntityListing)


## GetOutboundCampaignsDivisionview

> [**CampaignDivisionView**](CampaignDivisionView) GetOutboundCampaignsDivisionview (string campaignId)


Get a basic Campaign information object

This returns a simplified version of a Campaign, consisting of name and division.

Requires ALL permissions: 

* outbound:campaign:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsDivisionviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get a basic Campaign information object
                CampaignDivisionView result = apiInstance.GetOutboundCampaignsDivisionview(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignsDivisionview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

[**CampaignDivisionView**](CampaignDivisionView)


## GetOutboundCampaignsDivisionviews

> [**CampaignDivisionViewListing**](CampaignDivisionViewListing) GetOutboundCampaignsDivisionviews (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, List<string> id = null, string sortBy = null, string sortOrder = null)


Query a list of basic Campaign information objects

This returns a simplified version of a Campaign, consisting of name and division.

Requires ALL permissions: 

* outbound:campaign:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundCampaignsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of basic Campaign information objects
                CampaignDivisionViewListing result = apiInstance.GetOutboundCampaignsDivisionviews(pageSize, pageNumber, filterType, name, id, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundCampaignsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string)| id | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**CampaignDivisionViewListing**](CampaignDivisionViewListing)


## GetOutboundContactlist

> [**ContactList**](ContactList) GetOutboundContactlist (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)


Get a dialer contact list.

Requires ANY permissions: 

* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            { 
                // Get a dialer contact list.
                ContactList result = apiInstance.GetOutboundContactlist(contactListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |

### Return type

[**ContactList**](ContactList)


## GetOutboundContactlistContact

> [**DialerContact**](DialerContact) GetOutboundContactlistContact (string contactListId, string contactId)


Get a contact.

Requires ANY permissions: 

* outbound:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistContactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactId = contactId_example;  // string | Contact ID

            try
            { 
                // Get a contact.
                DialerContact result = apiInstance.GetOutboundContactlistContact(contactListId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistContact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |

### Return type

[**DialerContact**](DialerContact)


## GetOutboundContactlistContactsBulkJob

> [**ContactsBulkOperationJob**](ContactsBulkOperationJob) GetOutboundContactlistContactsBulkJob (string contactListId, string jobId)


Get bulk operation job.

Requires ANY permissions: 

* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistContactsBulkJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var jobId = jobId_example;  // string | Job ID

            try
            { 
                // Get bulk operation job.
                ContactsBulkOperationJob result = apiInstance.GetOutboundContactlistContactsBulkJob(contactListId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistContactsBulkJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **jobId** | **string**| Job ID |  |

### Return type

[**ContactsBulkOperationJob**](ContactsBulkOperationJob)


## GetOutboundContactlistContactsBulkJobs

> [**ContactsBulkOperationJobListing**](ContactsBulkOperationJobListing) GetOutboundContactlistContactsBulkJobs (string contactListId)


Get 10 most recent bulk operation jobs associated with contact list.

Requires ANY permissions: 

* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistContactsBulkJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID

            try
            { 
                // Get 10 most recent bulk operation jobs associated with contact list.
                ContactsBulkOperationJobListing result = apiInstance.GetOutboundContactlistContactsBulkJobs(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistContactsBulkJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |

### Return type

[**ContactsBulkOperationJobListing**](ContactsBulkOperationJobListing)


## GetOutboundContactlistExport

> [**ExportUri**](ExportUri) GetOutboundContactlistExport (string contactListId, string download = null)


Get the URI of a contact list export.

Requires ALL permissions: 

* outbound:contact:view
* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistExportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var download = download_example;  // string | Redirect to download uri (optional)  (default to "false")

            try
            { 
                // Get the URI of a contact list export.
                ExportUri result = apiInstance.GetOutboundContactlistExport(contactListId, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistExport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **download** | **string**| Redirect to download uri | [optional] [default to "false"] |

### Return type

[**ExportUri**](ExportUri)


## GetOutboundContactlistImportstatus

> [**ImportStatus**](ImportStatus) GetOutboundContactlistImportstatus (string contactListId)


Get dialer contactList import status.

Requires ANY permissions: 

* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistImportstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID

            try
            { 
                // Get dialer contactList import status.
                ImportStatus result = apiInstance.GetOutboundContactlistImportstatus(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistImportstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |

### Return type

[**ImportStatus**](ImportStatus)


## GetOutboundContactlistTimezonemappingpreview

> [**TimeZoneMappingPreview**](TimeZoneMappingPreview) GetOutboundContactlistTimezonemappingpreview (string contactListId)


Preview the result of applying Automatic Time Zone Mapping to a contact list

Requires ANY permissions: 

* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistTimezonemappingpreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID

            try
            { 
                // Preview the result of applying Automatic Time Zone Mapping to a contact list
                TimeZoneMappingPreview result = apiInstance.GetOutboundContactlistTimezonemappingpreview(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistTimezonemappingpreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |

### Return type

[**TimeZoneMappingPreview**](TimeZoneMappingPreview)


## GetOutboundContactlistfilter

> [**ContactListFilter**](ContactListFilter) GetOutboundContactlistfilter (string contactListFilterId)


Get Contact list filter

Requires ANY permissions: 

* outbound:contactListFilter:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistfilterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListFilterId = contactListFilterId_example;  // string | Contact List Filter ID

            try
            { 
                // Get Contact list filter
                ContactListFilter result = apiInstance.GetOutboundContactlistfilter(contactListFilterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistfilter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListFilterId** | **string**| Contact List Filter ID |  |

### Return type

[**ContactListFilter**](ContactListFilter)


## GetOutboundContactlistfilters

> [**ContactListFilterEntityListing**](ContactListFilterEntityListing) GetOutboundContactlistfilters (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, string contactListId = null)


Query Contact list filters

Requires ANY permissions: 

* outbound:contactListFilter:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistfiltersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            var contactListId = contactListId_example;  // string | Contact List ID (optional) 

            try
            { 
                // Query Contact list filters
                ContactListFilterEntityListing result = apiInstance.GetOutboundContactlistfilters(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder, contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistfilters: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
| **contactListId** | **string**| Contact List ID | [optional]  |

### Return type

[**ContactListFilterEntityListing**](ContactListFilterEntityListing)


## GetOutboundContactlists

> [**ContactListEntityListing**](ContactListEntityListing) GetOutboundContactlists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, List<string> id = null, List<string> divisionId = null, string sortBy = null, string sortOrder = null)


Query a list of contact lists.

Requires ANY permissions: 

* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of contact lists.
                ContactListEntityListing result = apiInstance.GetOutboundContactlists(includeImportStatus, includeSize, pageSize, pageNumber, allowEmptyResult, filterType, name, id, divisionId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlists: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string)| id | [optional]  |
| **divisionId** | [**List<string>**](string)| Division ID(s) | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**ContactListEntityListing**](ContactListEntityListing)


## GetOutboundContactlistsDivisionview

> [**ContactListDivisionView**](ContactListDivisionView) GetOutboundContactlistsDivisionview (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)


Get a basic ContactList information object

This returns a simplified version of a ContactList, consisting of the name, division, column names, phone columns, import status, and size.

Requires ALL permissions: 

* outbound:contactList:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistsDivisionviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contactlist ID
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            { 
                // Get a basic ContactList information object
                ContactListDivisionView result = apiInstance.GetOutboundContactlistsDivisionview(contactListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistsDivisionview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contactlist ID |  |
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |

### Return type

[**ContactListDivisionView**](ContactListDivisionView)


## GetOutboundContactlistsDivisionviews

> [**ContactListDivisionViewListing**](ContactListDivisionViewListing) GetOutboundContactlistsDivisionviews (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, List<string> id = null, string sortBy = null, string sortOrder = null)


Query a list of simplified contact list objects.

This return a simplified version of contact lists, consisting of the name, division, column names, phone columns, import status, and size.

Requires ALL permissions: 

* outbound:contactList:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlistsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of simplified contact list objects.
                ContactListDivisionViewListing result = apiInstance.GetOutboundContactlistsDivisionviews(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, id, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlistsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string)| id | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**ContactListDivisionViewListing**](ContactListDivisionViewListing)


## GetOutboundContactlisttemplate

> [**ContactListTemplate**](ContactListTemplate) GetOutboundContactlisttemplate (string contactListTemplateId)


Get Contact List Template

Requires ANY permissions: 

* outbound:contactListTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlisttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListTemplateId = contactListTemplateId_example;  // string | ContactListTemplate ID

            try
            { 
                // Get Contact List Template
                ContactListTemplate result = apiInstance.GetOutboundContactlisttemplate(contactListTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlisttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListTemplateId** | **string**| ContactListTemplate ID |  |

### Return type

[**ContactListTemplate**](ContactListTemplate)


## GetOutboundContactlisttemplates

> [**ContactListTemplateEntityListing**](ContactListTemplateEntityListing) GetOutboundContactlisttemplates (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)


Query a list of contact list templates

Requires ANY permissions: 

* outbound:contactListTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundContactlisttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of contact list templates
                ContactListTemplateEntityListing result = apiInstance.GetOutboundContactlisttemplates(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundContactlisttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**ContactListTemplateEntityListing**](ContactListTemplateEntityListing)


## GetOutboundDigitalruleset

> [**DigitalRuleSet**](DigitalRuleSet) GetOutboundDigitalruleset (string digitalRuleSetId)


Get an Outbound Digital Rule Set

Requires ANY permissions: 

* outbound:digitalRuleSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDigitalrulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var digitalRuleSetId = digitalRuleSetId_example;  // string | The Digital Rule Set ID

            try
            { 
                // Get an Outbound Digital Rule Set
                DigitalRuleSet result = apiInstance.GetOutboundDigitalruleset(digitalRuleSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDigitalruleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **digitalRuleSetId** | **string**| The Digital Rule Set ID |  |

### Return type

[**DigitalRuleSet**](DigitalRuleSet)


## GetOutboundDigitalrulesets

> [**DigitalRuleSetEntityListing**](DigitalRuleSetEntityListing) GetOutboundDigitalrulesets (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, List<string> id = null)


Query a list of Outbound Digital Rule Sets

Requires ANY permissions: 

* outbound:digitalRuleSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDigitalrulesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | The field to sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | The direction to sort (optional)  (default to ascending)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | A list of digital rule set ids to bulk fetch (optional) 

            try
            { 
                // Query a list of Outbound Digital Rule Sets
                DigitalRuleSetEntityListing result = apiInstance.GetOutboundDigitalrulesets(pageSize, pageNumber, sortBy, sortOrder, name, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDigitalrulesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| The field to sort by | [optional] [default to name]<br />**Values**: name |
| **sortOrder** | **string**| The direction to sort | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string)| A list of digital rule set ids to bulk fetch | [optional]  |

### Return type

[**DigitalRuleSetEntityListing**](DigitalRuleSetEntityListing)


## GetOutboundDnclist

> [**DncList**](DncList) GetOutboundDnclist (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)


Get dialer DNC list

Requires ANY permissions: 

* outbound:dncList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            { 
                // Get dialer DNC list
                DncList result = apiInstance.GetOutboundDnclist(dncListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |

### Return type

[**DncList**](DncList)


## GetOutboundDnclistExport

> [**ExportUri**](ExportUri) GetOutboundDnclistExport (string dncListId, string download = null)


Get the URI of a DNC list export.

Requires ALL permissions: 

* outbound:dnc:view
* outbound:dncList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistExportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var download = download_example;  // string | Redirect to download uri (optional)  (default to "false")

            try
            { 
                // Get the URI of a DNC list export.
                ExportUri result = apiInstance.GetOutboundDnclistExport(dncListId, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclistExport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **download** | **string**| Redirect to download uri | [optional] [default to "false"] |

### Return type

[**ExportUri**](ExportUri)


## GetOutboundDnclistImportstatus

> [**ImportStatus**](ImportStatus) GetOutboundDnclistImportstatus (string dncListId)


Get dialer dncList import status.

Requires ANY permissions: 

* outbound:dncList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistImportstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID

            try
            { 
                // Get dialer dncList import status.
                ImportStatus result = apiInstance.GetOutboundDnclistImportstatus(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclistImportstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |

### Return type

[**ImportStatus**](ImportStatus)


## GetOutboundDnclists

> [**DncListEntityListing**](DncListEntityListing) GetOutboundDnclists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string dncSourceType = null, List<string> divisionId = null, string sortBy = null, string sortOrder = null)


Query dialer DNC lists

Requires ANY permissions: 

* outbound:dncList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var dncSourceType = dncSourceType_example;  // string | DncSourceType (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 

            try
            { 
                // Query dialer DNC lists
                DncListEntityListing result = apiInstance.GetOutboundDnclists(includeImportStatus, includeSize, pageSize, pageNumber, allowEmptyResult, filterType, name, dncSourceType, divisionId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclists: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **dncSourceType** | **string**| DncSourceType | [optional] <br />**Values**: rds, rds_custom, dnc.com, gryphon |
| **divisionId** | [**List<string>**](string)| Division ID(s) | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] <br />**Values**: ascending, descending |

### Return type

[**DncListEntityListing**](DncListEntityListing)


## GetOutboundDnclistsDivisionview

> [**DncListDivisionView**](DncListDivisionView) GetOutboundDnclistsDivisionview (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)


Get a basic DncList information object

This returns a simplified version of a DncList, consisting of the name, division, import status, and size.

Requires ALL permissions: 

* outbound:dncList:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistsDivisionviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | Dnclist ID
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            { 
                // Get a basic DncList information object
                DncListDivisionView result = apiInstance.GetOutboundDnclistsDivisionview(dncListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclistsDivisionview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| Dnclist ID |  |
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |

### Return type

[**DncListDivisionView**](DncListDivisionView)


## GetOutboundDnclistsDivisionviews

> [**DncListDivisionViewListing**](DncListDivisionViewListing) GetOutboundDnclistsDivisionviews (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string dncSourceType = null, List<string> id = null, string sortBy = null, string sortOrder = null)


Query a list of simplified dnc list objects.

This return a simplified version of dnc lists, consisting of the name, division, import status, and size.

Requires ALL permissions: 

* outbound:dncList:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundDnclistsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var dncSourceType = dncSourceType_example;  // string | DncSourceType (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of simplified dnc list objects.
                DncListDivisionViewListing result = apiInstance.GetOutboundDnclistsDivisionviews(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, dncSourceType, id, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundDnclistsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **dncSourceType** | **string**| DncSourceType | [optional] <br />**Values**: rds, rds_custom, dnc.com, gryphon |
| **id** | [**List<string>**](string)| id | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**DncListDivisionViewListing**](DncListDivisionViewListing)


## GetOutboundEvent

> [**EventLog**](EventLog) GetOutboundEvent (string eventId)


Get Dialer Event

Requires ANY permissions: 

* outbound:eventLog:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundEventExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var eventId = eventId_example;  // string | Event Log ID

            try
            { 
                // Get Dialer Event
                EventLog result = apiInstance.GetOutboundEvent(eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **eventId** | **string**| Event Log ID |  |

### Return type

[**EventLog**](EventLog)


## GetOutboundEvents

> [**DialerEventEntityListing**](DialerEventEntityListing) GetOutboundEvents (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null)


Query Event Logs

Requires ANY permissions: 

* outbound:eventLog:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundEventsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var category = category_example;  // string | Category (optional) 
            var level = level_example;  // string | Level (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query Event Logs
                DialerEventEntityListing result = apiInstance.GetOutboundEvents(pageSize, pageNumber, filterType, category, level, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **category** | **string**| Category | [optional]  |
| **level** | **string**| Level | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**DialerEventEntityListing**](DialerEventEntityListing)


## GetOutboundFilespecificationtemplate

> [**FileSpecificationTemplate**](FileSpecificationTemplate) GetOutboundFilespecificationtemplate (string fileSpecificationTemplateId)


Get File Specification Template

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundFilespecificationtemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var fileSpecificationTemplateId = fileSpecificationTemplateId_example;  // string | File Specification Template ID

            try
            { 
                // Get File Specification Template
                FileSpecificationTemplate result = apiInstance.GetOutboundFilespecificationtemplate(fileSpecificationTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundFilespecificationtemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **fileSpecificationTemplateId** | **string**| File Specification Template ID |  |

### Return type

[**FileSpecificationTemplate**](FileSpecificationTemplate)


## GetOutboundFilespecificationtemplates

> [**FileSpecificationTemplateEntityListing**](FileSpecificationTemplateEntityListing) GetOutboundFilespecificationtemplates (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)


Query File Specification Templates

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundFilespecificationtemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query File Specification Templates
                FileSpecificationTemplateEntityListing result = apiInstance.GetOutboundFilespecificationtemplates(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundFilespecificationtemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**FileSpecificationTemplateEntityListing**](FileSpecificationTemplateEntityListing)


## GetOutboundImporttemplate

> [**ImportTemplate**](ImportTemplate) GetOutboundImporttemplate (string importTemplateId, bool? includeImportStatus = null)


Get Import Template

Requires ANY permissions: 

* outbound:importTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundImporttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var importTemplateId = importTemplateId_example;  // string | Import Template ID
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)

            try
            { 
                // Get Import Template
                ImportTemplate result = apiInstance.GetOutboundImporttemplate(importTemplateId, includeImportStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundImporttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **importTemplateId** | **string**| Import Template ID |  |
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |

### Return type

[**ImportTemplate**](ImportTemplate)


## GetOutboundImporttemplateImportstatus

> [**ImportStatus**](ImportStatus) GetOutboundImporttemplateImportstatus (string importTemplateId, string listNamePrefix = null)


Get the import status for an import template.

Requires ANY permissions: 

* outbound:importTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundImporttemplateImportstatusExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var importTemplateId = importTemplateId_example;  // string | importTemplateId
            var listNamePrefix = listNamePrefix_example;  // string | listNamePrefix (optional) 

            try
            { 
                // Get the import status for an import template.
                ImportStatus result = apiInstance.GetOutboundImporttemplateImportstatus(importTemplateId, listNamePrefix);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundImporttemplateImportstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **importTemplateId** | **string**| importTemplateId |  |
| **listNamePrefix** | **string**| listNamePrefix | [optional]  |

### Return type

[**ImportStatus**](ImportStatus)


## GetOutboundImporttemplates

> [**ImportTemplateEntityListing**](ImportTemplateEntityListing) GetOutboundImporttemplates (bool? includeImportStatus = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, string contactListTemplateId = null)


Query Import Templates

Requires ANY permissions: 

* outbound:importTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundImporttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)
            var contactListTemplateId = contactListTemplateId_example;  // string | Contact List Template ID (optional) 

            try
            { 
                // Query Import Templates
                ImportTemplateEntityListing result = apiInstance.GetOutboundImporttemplates(includeImportStatus, pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder, contactListTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundImporttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |
| **contactListTemplateId** | **string**| Contact List Template ID | [optional]  |

### Return type

[**ImportTemplateEntityListing**](ImportTemplateEntityListing)


## GetOutboundMessagingcampaign

> [**MessagingCampaign**](MessagingCampaign) GetOutboundMessagingcampaign (string messagingCampaignId)


Get an Outbound Messaging Campaign

Requires ANY permissions: 

* outbound:messagingCampaign:view
* outbound:emailCampaign:view
* outbound:whatsAppCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Get an Outbound Messaging Campaign
                MessagingCampaign result = apiInstance.GetOutboundMessagingcampaign(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |

### Return type

[**MessagingCampaign**](MessagingCampaign)


## GetOutboundMessagingcampaignDiagnostics

> [**MessagingCampaignDiagnostics**](MessagingCampaignDiagnostics) GetOutboundMessagingcampaignDiagnostics (string messagingCampaignId)


Get messaging campaign diagnostics

Requires ANY permissions: 

* outbound:messagingCampaign:view
* outbound:emailCampaign:view
* outbound:whatsAppCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignDiagnosticsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Get messaging campaign diagnostics
                MessagingCampaignDiagnostics result = apiInstance.GetOutboundMessagingcampaignDiagnostics(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaignDiagnostics: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |

### Return type

[**MessagingCampaignDiagnostics**](MessagingCampaignDiagnostics)


## GetOutboundMessagingcampaignProgress

> [**CampaignProgress**](CampaignProgress) GetOutboundMessagingcampaignProgress (string messagingCampaignId)


Get messaging campaign's progress

Requires ANY permissions: 

* outbound:messagingCampaign:view
* outbound:emailCampaign:view
* outbound:whatsAppCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Get messaging campaign's progress
                CampaignProgress result = apiInstance.GetOutboundMessagingcampaignProgress(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaignProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |

### Return type

[**CampaignProgress**](CampaignProgress)


## GetOutboundMessagingcampaigns

> [**MessagingCampaignEntityListing**](MessagingCampaignEntityListing) GetOutboundMessagingcampaigns (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string contactListId = null, List<string> divisionId = null, string type = null, string senderSmsPhoneNumber = null, List<string> id = null)


Query a list of Messaging Campaigns

Requires ANY permissions: 

* outbound:messagingCampaign:view
* outbound:emailCampaign:view
* outbound:whatsAppCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | The field to sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | The direction to sort (optional)  (default to ascending)
            var name = name_example;  // string | Name (optional) 
            var contactListId = contactListId_example;  // string | Contact List ID (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var type = type_example;  // string | Campaign Type (optional) 
            var senderSmsPhoneNumber = senderSmsPhoneNumber_example;  // string | Sender SMS Phone Number (optional) 
            var id = new List<string>(); // List<string> | A list of messaging campaign ids to bulk fetch (optional) 

            try
            { 
                // Query a list of Messaging Campaigns
                MessagingCampaignEntityListing result = apiInstance.GetOutboundMessagingcampaigns(pageSize, pageNumber, sortBy, sortOrder, name, contactListId, divisionId, type, senderSmsPhoneNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| The field to sort by | [optional] [default to name]<br />**Values**: campaignStatus, name, type |
| **sortOrder** | **string**| The direction to sort | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **name** | **string**| Name | [optional]  |
| **contactListId** | **string**| Contact List ID | [optional]  |
| **divisionId** | [**List<string>**](string)| Division ID(s) | [optional]  |
| **type** | **string**| Campaign Type | [optional] <br />**Values**: EMAIL, SMS, WHATSAPP |
| **senderSmsPhoneNumber** | **string**| Sender SMS Phone Number | [optional]  |
| **id** | [**List<string>**](string)| A list of messaging campaign ids to bulk fetch | [optional]  |

### Return type

[**MessagingCampaignEntityListing**](MessagingCampaignEntityListing)


## GetOutboundMessagingcampaignsDivisionview

> [**MessagingCampaignDivisionView**](MessagingCampaignDivisionView) GetOutboundMessagingcampaignsDivisionview (string messagingCampaignId)


Get a basic Messaging Campaign information object

This returns a simplified version of a Messaging Campaign, consisting of id, name, and division.

Requires ANY permissions: 

* outbound:messagingCampaign:search
* outbound:emailCampaign:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignsDivisionviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Get a basic Messaging Campaign information object
                MessagingCampaignDivisionView result = apiInstance.GetOutboundMessagingcampaignsDivisionview(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaignsDivisionview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |

### Return type

[**MessagingCampaignDivisionView**](MessagingCampaignDivisionView)


## GetOutboundMessagingcampaignsDivisionviews

> [**MessagingCampaignDivisionViewEntityListing**](MessagingCampaignDivisionViewEntityListing) GetOutboundMessagingcampaignsDivisionviews (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, string type = null, List<string> id = null, string senderSmsPhoneNumber = null)


Query a list of basic Messaging Campaign information objects

This returns a listing of simplified Messaging Campaigns, each consisting of id, name, and division.

Requires ANY permissions: 

* outbound:messagingCampaign:search
* outbound:emailCampaign:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundMessagingcampaignsDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | The direction to sort (optional)  (default to a)
            var name = name_example;  // string | Name (optional) 
            var type = type_example;  // string | Campaign Type (optional) 
            var id = new List<string>(); // List<string> | id (optional) 
            var senderSmsPhoneNumber = senderSmsPhoneNumber_example;  // string | Sender SMS Phone Number (optional) 

            try
            { 
                // Query a list of basic Messaging Campaign information objects
                MessagingCampaignDivisionViewEntityListing result = apiInstance.GetOutboundMessagingcampaignsDivisionviews(pageSize, pageNumber, sortOrder, name, type, id, senderSmsPhoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundMessagingcampaignsDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| The direction to sort | [optional] [default to a]<br />**Values**: ascending, descending |
| **name** | **string**| Name | [optional]  |
| **type** | **string**| Campaign Type | [optional] <br />**Values**: EMAIL, SMS, WHATSAPP |
| **id** | [**List<string>**](string)| id | [optional]  |
| **senderSmsPhoneNumber** | **string**| Sender SMS Phone Number | [optional]  |

### Return type

[**MessagingCampaignDivisionViewEntityListing**](MessagingCampaignDivisionViewEntityListing)


## GetOutboundRuleset

> [**RuleSet**](RuleSet) GetOutboundRuleset (string ruleSetId)


Get a Rule Set by ID.

Requires ANY permissions: 

* outbound:ruleSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundRulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID

            try
            { 
                // Get a Rule Set by ID.
                RuleSet result = apiInstance.GetOutboundRuleset(ruleSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundRuleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |

### Return type

[**RuleSet**](RuleSet)


## GetOutboundRulesets

> [**RuleSetEntityListing**](RuleSetEntityListing) GetOutboundRulesets (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)


Query a list of Rule Sets.

Requires ANY permissions: 

* outbound:ruleSet:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundRulesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of Rule Sets.
                RuleSetEntityListing result = apiInstance.GetOutboundRulesets(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundRulesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**RuleSetEntityListing**](RuleSetEntityListing)


## GetOutboundSchedulesCampaign

> [**CampaignSchedule**](CampaignSchedule) GetOutboundSchedulesCampaign (string campaignId)


Get a dialer campaign schedule.

Requires ANY permissions: 

* outbound:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Get a dialer campaign schedule.
                CampaignSchedule result = apiInstance.GetOutboundSchedulesCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

[**CampaignSchedule**](CampaignSchedule)


## GetOutboundSchedulesCampaigns

> [**List&lt;CampaignSchedule&gt;**](CampaignSchedule) GetOutboundSchedulesCampaigns ()


Query for a list of dialer campaign schedules.

Requires ANY permissions: 

* outbound:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesCampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Query for a list of dialer campaign schedules.
                List<CampaignSchedule> result = apiInstance.GetOutboundSchedulesCampaigns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**List<CampaignSchedule>**](CampaignSchedule)


## GetOutboundSchedulesEmailcampaign

> [**EmailCampaignSchedule**](EmailCampaignSchedule) GetOutboundSchedulesEmailcampaign (string emailCampaignId)


Get an email campaign schedule.

Requires ANY permissions: 

* outbound:emailCampaignSchedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesEmailcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var emailCampaignId = emailCampaignId_example;  // string | Email Campaign ID

            try
            { 
                // Get an email campaign schedule.
                EmailCampaignSchedule result = apiInstance.GetOutboundSchedulesEmailcampaign(emailCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesEmailcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailCampaignId** | **string**| Email Campaign ID |  |

### Return type

[**EmailCampaignSchedule**](EmailCampaignSchedule)


## GetOutboundSchedulesEmailcampaigns

> [**EmailCampaignScheduleEntityListing**](EmailCampaignScheduleEntityListing) GetOutboundSchedulesEmailcampaigns ()


Query for a list of email campaign schedules.

Requires ANY permissions: 

* outbound:emailCampaignSchedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesEmailcampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Query for a list of email campaign schedules.
                EmailCampaignScheduleEntityListing result = apiInstance.GetOutboundSchedulesEmailcampaigns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesEmailcampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EmailCampaignScheduleEntityListing**](EmailCampaignScheduleEntityListing)


## GetOutboundSchedulesMessagingcampaign

> [**MessagingCampaignSchedule**](MessagingCampaignSchedule) GetOutboundSchedulesMessagingcampaign (string messagingCampaignId)


Get a messaging campaign schedule.

Requires ANY permissions: 

* outbound:messagingCampaignSchedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | Messaging Campaign ID

            try
            { 
                // Get a messaging campaign schedule.
                MessagingCampaignSchedule result = apiInstance.GetOutboundSchedulesMessagingcampaign(messagingCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| Messaging Campaign ID |  |

### Return type

[**MessagingCampaignSchedule**](MessagingCampaignSchedule)


## GetOutboundSchedulesMessagingcampaigns

> [**MessagingCampaignScheduleEntityListing**](MessagingCampaignScheduleEntityListing) GetOutboundSchedulesMessagingcampaigns ()


Query for a list of messaging campaign schedules.

Requires ANY permissions: 

* outbound:messagingCampaignSchedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesMessagingcampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Query for a list of messaging campaign schedules.
                MessagingCampaignScheduleEntityListing result = apiInstance.GetOutboundSchedulesMessagingcampaigns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesMessagingcampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**MessagingCampaignScheduleEntityListing**](MessagingCampaignScheduleEntityListing)


## GetOutboundSchedulesSequence

> [**SequenceSchedule**](SequenceSchedule) GetOutboundSchedulesSequence (string sequenceId)


Get a dialer sequence schedule.

Requires ANY permissions: 

* outbound:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Sequence ID

            try
            { 
                // Get a dialer sequence schedule.
                SequenceSchedule result = apiInstance.GetOutboundSchedulesSequence(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |

### Return type

[**SequenceSchedule**](SequenceSchedule)


## GetOutboundSchedulesSequences

> [**List&lt;SequenceSchedule&gt;**](SequenceSchedule) GetOutboundSchedulesSequences ()


Query for a list of dialer sequence schedules.

Requires ANY permissions: 

* outbound:schedule:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSchedulesSequencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Query for a list of dialer sequence schedules.
                List<SequenceSchedule> result = apiInstance.GetOutboundSchedulesSequences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSchedulesSequences: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**List<SequenceSchedule>**](SequenceSchedule)


## GetOutboundSequence

> [**CampaignSequence**](CampaignSequence) GetOutboundSequence (string sequenceId)


Get a dialer campaign sequence.

Requires ANY permissions: 

* outbound:campaignSequence:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID

            try
            { 
                // Get a dialer campaign sequence.
                CampaignSequence result = apiInstance.GetOutboundSequence(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |

### Return type

[**CampaignSequence**](CampaignSequence)


## GetOutboundSequences

> [**CampaignSequenceEntityListing**](CampaignSequenceEntityListing) GetOutboundSequences (int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)


Query a list of dialer campaign sequences.

Requires ANY permissions: 

* outbound:campaignSequence:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSequencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size. The max that will be returned is 100. (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var allowEmptyResult = true;  // bool? | Whether to return an empty page when there are no results for that page (optional)  (default to false)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to Prefix)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            { 
                // Query a list of dialer campaign sequences.
                CampaignSequenceEntityListing result = apiInstance.GetOutboundSequences(pageSize, pageNumber, allowEmptyResult, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSequences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size. The max that will be returned is 100. | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **allowEmptyResult** | **bool?**| Whether to return an empty page when there are no results for that page | [optional] [default to false] |
| **filterType** | **string**| Filter type | [optional] [default to Prefix]<br />**Values**: Equals, RegEx, Contains, Prefix, LessThan, LessThanEqualTo, GreaterThan, GreaterThanEqualTo, BeginsWith, EndsWith |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a]<br />**Values**: ascending, descending |

### Return type

[**CampaignSequenceEntityListing**](CampaignSequenceEntityListing)


## GetOutboundSettings

> [**OutboundSettings**](OutboundSettings) GetOutboundSettings ()


Get the outbound settings for this organization

Requires ANY permissions: 

* outbound:settings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Get the outbound settings for this organization
                OutboundSettings result = apiInstance.GetOutboundSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**OutboundSettings**](OutboundSettings)


## GetOutboundWrapupcodemappings

> [**WrapUpCodeMapping**](WrapUpCodeMapping) GetOutboundWrapupcodemappings ()


Get the Dialer wrap up code mapping.

Requires ANY permissions: 

* outbound:wrapUpCodeMapping:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetOutboundWrapupcodemappingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();

            try
            { 
                // Get the Dialer wrap up code mapping.
                WrapUpCodeMapping result = apiInstance.GetOutboundWrapupcodemappings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetOutboundWrapupcodemappings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**WrapUpCodeMapping**](WrapUpCodeMapping)


## PatchOutboundCampaign

> void PatchOutboundCampaign (string campaignId, CampaignPatchRequest body)


Update a campaign.

Requires ALL permissions: 

* outbound:campaign:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOutboundCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new CampaignPatchRequest(); // CampaignPatchRequest | CampaignPatchRequest

            try
            { 
                // Update a campaign.
                apiInstance.PatchOutboundCampaign(campaignId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PatchOutboundCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**CampaignPatchRequest**](CampaignPatchRequest)| CampaignPatchRequest |  |

### Return type

void (empty response body)


## PatchOutboundDnclistCustomexclusioncolumns

> void PatchOutboundDnclistCustomexclusioncolumns (string dncListId, DncPatchCustomExclusionColumnsRequest body)


Add entries to or delete entries from a DNC list.

Only Internal DNC lists may be deleted from

Requires ANY permissions: 

* outbound:dnc:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOutboundDnclistCustomexclusioncolumnsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new DncPatchCustomExclusionColumnsRequest(); // DncPatchCustomExclusionColumnsRequest | DNC Custom exclusion column entries

            try
            { 
                // Add entries to or delete entries from a DNC list.
                apiInstance.PatchOutboundDnclistCustomexclusioncolumns(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PatchOutboundDnclistCustomexclusioncolumns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncPatchCustomExclusionColumnsRequest**](DncPatchCustomExclusionColumnsRequest)| DNC Custom exclusion column entries |  |

### Return type

void (empty response body)


## PatchOutboundDnclistEmailaddresses

> void PatchOutboundDnclistEmailaddresses (string dncListId, DncPatchEmailsRequest body)


Add emails to or Delete emails from a DNC list.

Only Internal DNC lists may be added to or deleted from

Requires ANY permissions: 

* outbound:dnc:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOutboundDnclistEmailaddressesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new DncPatchEmailsRequest(); // DncPatchEmailsRequest | DNC Emails

            try
            { 
                // Add emails to or Delete emails from a DNC list.
                apiInstance.PatchOutboundDnclistEmailaddresses(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PatchOutboundDnclistEmailaddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncPatchEmailsRequest**](DncPatchEmailsRequest)| DNC Emails |  |

### Return type

void (empty response body)


## PatchOutboundDnclistPhonenumbers

> void PatchOutboundDnclistPhonenumbers (string dncListId, DncPatchPhoneNumbersRequest body)


Add numbers to or delete numbers from a DNC list.

Only Internal DNC lists may be added to deleted from

Requires ANY permissions: 

* outbound:dnc:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOutboundDnclistPhonenumbersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new DncPatchPhoneNumbersRequest(); // DncPatchPhoneNumbersRequest | DNC Phone Numbers

            try
            { 
                // Add numbers to or delete numbers from a DNC list.
                apiInstance.PatchOutboundDnclistPhonenumbers(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PatchOutboundDnclistPhonenumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncPatchPhoneNumbersRequest**](DncPatchPhoneNumbersRequest)| DNC Phone Numbers |  |

### Return type

void (empty response body)


## PatchOutboundSettings

> void PatchOutboundSettings (OutboundSettings body)


Update the outbound settings for this organization

Requires ANY permissions: 

* outbound:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchOutboundSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new OutboundSettings(); // OutboundSettings | outboundSettings

            try
            { 
                // Update the outbound settings for this organization
                apiInstance.PatchOutboundSettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PatchOutboundSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutboundSettings**](OutboundSettings)| outboundSettings |  |

### Return type

void (empty response body)


## PostOutboundAttemptlimits

> [**AttemptLimits**](AttemptLimits) PostOutboundAttemptlimits (AttemptLimits body)


Create attempt limits

Requires ANY permissions: 

* outbound:attemptLimits:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundAttemptlimitsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new AttemptLimits(); // AttemptLimits | AttemptLimits

            try
            { 
                // Create attempt limits
                AttemptLimits result = apiInstance.PostOutboundAttemptlimits(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundAttemptlimits: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AttemptLimits**](AttemptLimits)| AttemptLimits |  |

### Return type

[**AttemptLimits**](AttemptLimits)


## PostOutboundCallabletimesets

> [**CallableTimeSet**](CallableTimeSet) PostOutboundCallabletimesets (CallableTimeSet body)


Create callable time set

Requires ANY permissions: 

* outbound:callableTimeSet:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCallabletimesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new CallableTimeSet(); // CallableTimeSet | DialerCallableTimeSet

            try
            { 
                // Create callable time set
                CallableTimeSet result = apiInstance.PostOutboundCallabletimesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCallabletimesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CallableTimeSet**](CallableTimeSet)| DialerCallableTimeSet |  |

### Return type

[**CallableTimeSet**](CallableTimeSet)


## PostOutboundCallanalysisresponsesets

> [**ResponseSet**](ResponseSet) PostOutboundCallanalysisresponsesets (ResponseSet body)


Create a dialer call analysis response set.

Requires ANY permissions: 

* outbound:responseSet:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCallanalysisresponsesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ResponseSet(); // ResponseSet | ResponseSet

            try
            { 
                // Create a dialer call analysis response set.
                ResponseSet result = apiInstance.PostOutboundCallanalysisresponsesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCallanalysisresponsesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ResponseSet**](ResponseSet)| ResponseSet |  |

### Return type

[**ResponseSet**](ResponseSet)


## PostOutboundCampaignAgentownedmappingpreview

> **Object** PostOutboundCampaignAgentownedmappingpreview (string campaignId)


Initiate request for a preview of how agents will be mapped to this campaign's contact list.

Requires ALL permissions: 

* outbound:campaign:view
* outbound:contact:view
* directory:user:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignAgentownedmappingpreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Initiate request for a preview of how agents will be mapped to this campaign's contact list.
                Object result = apiInstance.PostOutboundCampaignAgentownedmappingpreview(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignAgentownedmappingpreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

**Object**


## PostOutboundCampaignCallbackSchedule

> [**ContactCallbackRequest**](ContactCallbackRequest) PostOutboundCampaignCallbackSchedule (string campaignId, ContactCallbackRequest body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

Schedule a Callback for a Dialer Campaign (Deprecated)

This endpoint is deprecated and may have unexpected results. Please use \"/conversations/{conversationId}/participants/{participantId}/callbacks instead.\"

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignCallbackScheduleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new ContactCallbackRequest(); // ContactCallbackRequest | ContactCallbackRequest

            try
            { 
                // Schedule a Callback for a Dialer Campaign (Deprecated)
                ContactCallbackRequest result = apiInstance.PostOutboundCampaignCallbackSchedule(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignCallbackSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**ContactCallbackRequest**](ContactCallbackRequest)| ContactCallbackRequest |  |

### Return type

[**ContactCallbackRequest**](ContactCallbackRequest)


## PostOutboundCampaignStart

> void PostOutboundCampaignStart (string campaignId)


Start the campaign

Requires ANY permissions: 

* outbound:campaign:start

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignStartExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Start the campaign
                apiInstance.PostOutboundCampaignStart(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignStart: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

void (empty response body)


## PostOutboundCampaignStop

> void PostOutboundCampaignStop (string campaignId)


Stop the campaign

Requires ANY permissions: 

* outbound:campaign:stop

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignStopExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            { 
                // Stop the campaign
                apiInstance.PostOutboundCampaignStop(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignStop: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |

### Return type

void (empty response body)


## PostOutboundCampaignrules

> [**CampaignRule**](CampaignRule) PostOutboundCampaignrules (CampaignRule body)


Create Campaign Rule

Requires ANY permissions: 

* outbound:campaignRule:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignrulesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new CampaignRule(); // CampaignRule | CampaignRule

            try
            { 
                // Create Campaign Rule
                CampaignRule result = apiInstance.PostOutboundCampaignrules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignrules: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CampaignRule**](CampaignRule)| CampaignRule |  |

### Return type

[**CampaignRule**](CampaignRule)


## PostOutboundCampaigns

> [**Campaign**](Campaign) PostOutboundCampaigns (Campaign body)


Create a campaign.

Requires ANY permissions: 

* outbound:campaign:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new Campaign(); // Campaign | Campaign

            try
            { 
                // Create a campaign.
                Campaign result = apiInstance.PostOutboundCampaigns(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Campaign**](Campaign)| Campaign |  |

### Return type

[**Campaign**](Campaign)


## PostOutboundCampaignsProgress

> [**List&lt;CampaignProgress&gt;**](CampaignProgress) PostOutboundCampaignsProgress (List<string> body)


Get progress for a list of campaigns

Requires ANY permissions: 

* outbound:campaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundCampaignsProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new List<string>(); // List<string> | Campaign IDs

            try
            { 
                // Get progress for a list of campaigns
                List<CampaignProgress> result = apiInstance.PostOutboundCampaignsProgress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundCampaignsProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<string>**](string)| Campaign IDs |  |

### Return type

[**List<CampaignProgress>**](CampaignProgress)


## PostOutboundContactlistClear

> void PostOutboundContactlistClear (string contactListId)


Deletes all contacts out of a list. All outstanding recalls or rule-scheduled callbacks for non-preview campaigns configured with the contactlist will be cancelled.

Requires ANY permissions: 

* outbound:contact:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistClearExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID

            try
            { 
                // Deletes all contacts out of a list. All outstanding recalls or rule-scheduled callbacks for non-preview campaigns configured with the contactlist will be cancelled.
                apiInstance.PostOutboundContactlistClear(contactListId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistClear: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |

### Return type

void (empty response body)


## PostOutboundContactlistContacts

> [**List&lt;DialerContact&gt;**](DialerContact) PostOutboundContactlistContacts (string contactListId, List<WritableDialerContact> body, bool? priority = null, bool? clearSystemData = null, bool? doNotQueue = null)


Add contacts to a contact list.

Requires ANY permissions: 

* outbound:contact:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new List<WritableDialerContact>(); // List<WritableDialerContact> | Contact
            var priority = true;  // bool? | Contact priority. True means the contact(s) will be dialed next; false means the contact will go to the end of the contact queue. (optional) 
            var clearSystemData = true;  // bool? | Clear system data. True means the system columns (attempts, callable status, etc) stored on the contact will be cleared if the contact already exists; false means they won't. (optional) 
            var doNotQueue = true;  // bool? | Do not queue. True means that updated contacts will not have their positions in the queue altered, so contacts that have already been dialed will not be redialed. For new contacts, this parameter has no effect; False means that updated contacts will be re-queued, according to the 'priority' parameter. (optional) 

            try
            { 
                // Add contacts to a contact list.
                List<DialerContact> result = apiInstance.PostOutboundContactlistContacts(contactListId, body, priority, clearSystemData, doNotQueue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**List<WritableDialerContact>**](WritableDialerContact)| Contact |  |
| **priority** | **bool?**| Contact priority. True means the contact(s) will be dialed next; false means the contact will go to the end of the contact queue. | [optional]  |
| **clearSystemData** | **bool?**| Clear system data. True means the system columns (attempts, callable status, etc) stored on the contact will be cleared if the contact already exists; false means they won&#39;t. | [optional]  |
| **doNotQueue** | **bool?**| Do not queue. True means that updated contacts will not have their positions in the queue altered, so contacts that have already been dialed will not be redialed. For new contacts, this parameter has no effect; False means that updated contacts will be re-queued, according to the &#39;priority&#39; parameter. | [optional]  |

### Return type

[**List<DialerContact>**](DialerContact)


## PostOutboundContactlistContactsBulk

> [**List&lt;DialerContact&gt;**](DialerContact) PostOutboundContactlistContactsBulk (string contactListId, List<string> body)


Get contacts from a contact list.

Requires ANY permissions: 

* outbound:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new List<string>(); // List<string> | ContactIds to get.

            try
            { 
                // Get contacts from a contact list.
                List<DialerContact> result = apiInstance.PostOutboundContactlistContactsBulk(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContactsBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**List<string>**](string)| ContactIds to get. |  |

### Return type

[**List<DialerContact>**](DialerContact)


## PostOutboundContactlistContactsBulkRemove

> [**ContactsBulkOperationJob**](ContactsBulkOperationJob) PostOutboundContactlistContactsBulkRemove (string contactListId, ContactBulkSearchParameters body)


Start an async job to delete contacts using a filter.

Requires ANY permissions: 

* outbound:contact:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsBulkRemoveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new ContactBulkSearchParameters(); // ContactBulkSearchParameters | Contact filter information.

            try
            { 
                // Start an async job to delete contacts using a filter.
                ContactsBulkOperationJob result = apiInstance.PostOutboundContactlistContactsBulkRemove(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContactsBulkRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**ContactBulkSearchParameters**](ContactBulkSearchParameters)| Contact filter information. |  |

### Return type

[**ContactsBulkOperationJob**](ContactsBulkOperationJob)


## PostOutboundContactlistContactsBulkUpdate

> [**ContactsBulkOperationJob**](ContactsBulkOperationJob) PostOutboundContactlistContactsBulkUpdate (string contactListId, ContactBulkEditRequest body)


Start an async job to bulk edit contacts.

Requires ANY permissions: 

* outbound:contact:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsBulkUpdateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new ContactBulkEditRequest(); // ContactBulkEditRequest | Contact bulk edit request information.

            try
            { 
                // Start an async job to bulk edit contacts.
                ContactsBulkOperationJob result = apiInstance.PostOutboundContactlistContactsBulkUpdate(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContactsBulkUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**ContactBulkEditRequest**](ContactBulkEditRequest)| Contact bulk edit request information. |  |

### Return type

[**ContactsBulkOperationJob**](ContactsBulkOperationJob)


## PostOutboundContactlistContactsSearch

> [**ContactListingResponse**](ContactListingResponse) PostOutboundContactlistContactsSearch (string contactListId, ContactListingRequest body)


Query contacts from a contact list.

Requires ANY permissions: 

* outbound:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistContactsSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new ContactListingRequest(); // ContactListingRequest | Contact search parameters.

            try
            { 
                // Query contacts from a contact list.
                ContactListingResponse result = apiInstance.PostOutboundContactlistContactsSearch(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistContactsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**ContactListingRequest**](ContactListingRequest)| Contact search parameters. |  |

### Return type

[**ContactListingResponse**](ContactListingResponse)


## PostOutboundContactlistExport

> [**DomainEntityRef**](DomainEntityRef) PostOutboundContactlistExport (string contactListId, ContactsExportRequest body = null)


Initiate the export of a contact list.

Returns 200 if received OK.

Requires ALL permissions: 

* outbound:contact:view
* outbound:contactList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistExportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var body = new ContactsExportRequest(); // ContactsExportRequest | Export information to get (optional) 

            try
            { 
                // Initiate the export of a contact list.
                DomainEntityRef result = apiInstance.PostOutboundContactlistExport(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistExport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **body** | [**ContactsExportRequest**](ContactsExportRequest)| Export information to get | [optional]  |

### Return type

[**DomainEntityRef**](DomainEntityRef)


## PostOutboundContactlistfilters

> [**ContactListFilter**](ContactListFilter) PostOutboundContactlistfilters (ContactListFilter body)


Create Contact List Filter

Requires ANY permissions: 

* outbound:contactListFilter:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistfiltersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactListFilter(); // ContactListFilter | ContactListFilter

            try
            { 
                // Create Contact List Filter
                ContactListFilter result = apiInstance.PostOutboundContactlistfilters(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistfilters: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListFilter**](ContactListFilter)| ContactListFilter |  |

### Return type

[**ContactListFilter**](ContactListFilter)


## PostOutboundContactlistfiltersBulkRetrieve

> [**ContactListFilterEntityListing**](ContactListFilterEntityListing) PostOutboundContactlistfiltersBulkRetrieve (ContactListFilterBulkRetrieveBody body)


Retrieve multiple contact list filters

Requires ANY permissions: 

* outbound:contactListFilter:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistfiltersBulkRetrieveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactListFilterBulkRetrieveBody(); // ContactListFilterBulkRetrieveBody | The contact list filters to retrieve

            try
            { 
                // Retrieve multiple contact list filters
                ContactListFilterEntityListing result = apiInstance.PostOutboundContactlistfiltersBulkRetrieve(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistfiltersBulkRetrieve: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListFilterBulkRetrieveBody**](ContactListFilterBulkRetrieveBody)| The contact list filters to retrieve |  |

### Return type

[**ContactListFilterEntityListing**](ContactListFilterEntityListing)


## PostOutboundContactlistfiltersPreview

> [**FilterPreviewResponse**](FilterPreviewResponse) PostOutboundContactlistfiltersPreview (ContactListFilter body)


Get a preview of the output of a contact list filter

Requires ANY permissions: 

* outbound:contact:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistfiltersPreviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactListFilter(); // ContactListFilter | ContactListFilter

            try
            { 
                // Get a preview of the output of a contact list filter
                FilterPreviewResponse result = apiInstance.PostOutboundContactlistfiltersPreview(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlistfiltersPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListFilter**](ContactListFilter)| ContactListFilter |  |

### Return type

[**FilterPreviewResponse**](FilterPreviewResponse)


## PostOutboundContactlists

> [**ContactList**](ContactList) PostOutboundContactlists (ContactList body)


Create a contact List.

Requires ANY permissions: 

* outbound:contactList:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlistsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactList(); // ContactList | ContactList

            try
            { 
                // Create a contact List.
                ContactList result = apiInstance.PostOutboundContactlists(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlists: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactList**](ContactList)| ContactList |  |

### Return type

[**ContactList**](ContactList)


## PostOutboundContactlisttemplates

> [**ContactListTemplate**](ContactListTemplate) PostOutboundContactlisttemplates (ContactListTemplate body)


Create Contact List Template

Requires ANY permissions: 

* outbound:contactListTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlisttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactListTemplate(); // ContactListTemplate | ContactListTemplate

            try
            { 
                // Create Contact List Template
                ContactListTemplate result = apiInstance.PostOutboundContactlisttemplates(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlisttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListTemplate**](ContactListTemplate)| ContactListTemplate |  |

### Return type

[**ContactListTemplate**](ContactListTemplate)


## PostOutboundContactlisttemplatesBulkAdd

> [**ContactListTemplateEntityListing**](ContactListTemplateEntityListing) PostOutboundContactlisttemplatesBulkAdd (List<ContactListTemplate> body)


Add multiple contact list templates

Requires ANY permissions: 

* outbound:contactListTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlisttemplatesBulkAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new List<ContactListTemplate>(); // List<ContactListTemplate> | contact list template(s) to add

            try
            { 
                // Add multiple contact list templates
                ContactListTemplateEntityListing result = apiInstance.PostOutboundContactlisttemplatesBulkAdd(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlisttemplatesBulkAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<ContactListTemplate>**](ContactListTemplate)| contact list template(s) to add |  |

### Return type

[**ContactListTemplateEntityListing**](ContactListTemplateEntityListing)


## PostOutboundContactlisttemplatesBulkRetrieve

> [**ContactListTemplateEntityListing**](ContactListTemplateEntityListing) PostOutboundContactlisttemplatesBulkRetrieve (ContactListTemplateBulkRetrieveBody body)


Get multiple contact list templates

Requires ANY permissions: 

* outbound:contactListTemplate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundContactlisttemplatesBulkRetrieveExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ContactListTemplateBulkRetrieveBody(); // ContactListTemplateBulkRetrieveBody | contact list templates to get

            try
            { 
                // Get multiple contact list templates
                ContactListTemplateEntityListing result = apiInstance.PostOutboundContactlisttemplatesBulkRetrieve(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundContactlisttemplatesBulkRetrieve: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactListTemplateBulkRetrieveBody**](ContactListTemplateBulkRetrieveBody)| contact list templates to get |  |

### Return type

[**ContactListTemplateEntityListing**](ContactListTemplateEntityListing)


## PostOutboundConversationDnc

> void PostOutboundConversationDnc (string conversationId)


Add phone numbers to a Dialer DNC list.

Requires ANY permissions: 

* outbound:dnc:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundConversationDncExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var conversationId = conversationId_example;  // string | Conversation ID

            try
            { 
                // Add phone numbers to a Dialer DNC list.
                apiInstance.PostOutboundConversationDnc(conversationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundConversationDnc: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |

### Return type

void (empty response body)


## PostOutboundDigitalrulesets

> [**DigitalRuleSet**](DigitalRuleSet) PostOutboundDigitalrulesets (DigitalRuleSet body)


Create an Outbound Digital Rule Set

Requires ANY permissions: 

* outbound:digitalRuleSet:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDigitalrulesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new DigitalRuleSet(); // DigitalRuleSet | Digital Rule Set

            try
            { 
                // Create an Outbound Digital Rule Set
                DigitalRuleSet result = apiInstance.PostOutboundDigitalrulesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDigitalrulesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DigitalRuleSet**](DigitalRuleSet)| Digital Rule Set |  |

### Return type

[**DigitalRuleSet**](DigitalRuleSet)


## PostOutboundDnclistEmailaddresses

> void PostOutboundDnclistEmailaddresses (string dncListId, List<string> body)


Add email addresses to a DNC list.

Only Internal DNC lists may be appended to

Requires ANY permissions: 

* outbound:dnc:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistEmailaddressesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new List<string>(); // List<string> | DNC email addresses

            try
            { 
                // Add email addresses to a DNC list.
                apiInstance.PostOutboundDnclistEmailaddresses(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclistEmailaddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**List<string>**](string)| DNC email addresses |  |

### Return type

void (empty response body)


## PostOutboundDnclistExport

> [**DomainEntityRef**](DomainEntityRef) PostOutboundDnclistExport (string dncListId)


Initiate the export of a dnc list.

Returns 200 if received OK.

Requires ALL permissions: 

* outbound:dnc:view
* outbound:dncList:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistExportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID

            try
            { 
                // Initiate the export of a dnc list.
                DomainEntityRef result = apiInstance.PostOutboundDnclistExport(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclistExport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |

### Return type

[**DomainEntityRef**](DomainEntityRef)


## PostOutboundDnclistPhonenumbers

> void PostOutboundDnclistPhonenumbers (string dncListId, List<string> body, string expirationDateTime = null)


Add phone numbers to a DNC list.

Only Internal DNC lists may be appended to

Requires ANY permissions: 

* outbound:dnc:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistPhonenumbersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new List<string>(); // List<string> | DNC Phone Numbers
            var expirationDateTime = expirationDateTime_example;  // string | Expiration date for DNC phone numbers in yyyy-MM-ddTHH:mmZ format (optional) 

            try
            { 
                // Add phone numbers to a DNC list.
                apiInstance.PostOutboundDnclistPhonenumbers(dncListId, body, expirationDateTime);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclistPhonenumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**List<string>**](string)| DNC Phone Numbers |  |
| **expirationDateTime** | **string**| Expiration date for DNC phone numbers in yyyy-MM-ddTHH:mmZ format | [optional]  |

### Return type

void (empty response body)


## PostOutboundDnclists

> [**DncList**](DncList) PostOutboundDnclists (DncListCreate body)


Create dialer DNC list

Requires ANY permissions: 

* outbound:dncList:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundDnclistsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new DncListCreate(); // DncListCreate | DncList

            try
            { 
                // Create dialer DNC list
                DncList result = apiInstance.PostOutboundDnclists(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundDnclists: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DncListCreate**](DncListCreate)| DncList |  |

### Return type

[**DncList**](DncList)


## PostOutboundFilespecificationtemplates

> [**FileSpecificationTemplate**](FileSpecificationTemplate) PostOutboundFilespecificationtemplates (FileSpecificationTemplate body)


Create File Specification Template

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundFilespecificationtemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new FileSpecificationTemplate(); // FileSpecificationTemplate | FileSpecificationTemplate

            try
            { 
                // Create File Specification Template
                FileSpecificationTemplate result = apiInstance.PostOutboundFilespecificationtemplates(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundFilespecificationtemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FileSpecificationTemplate**](FileSpecificationTemplate)| FileSpecificationTemplate |  |

### Return type

[**FileSpecificationTemplate**](FileSpecificationTemplate)


## PostOutboundImporttemplates

> [**ImportTemplate**](ImportTemplate) PostOutboundImporttemplates (ImportTemplate body)


Create Import Template

Requires ANY permissions: 

* outbound:importTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundImporttemplatesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new ImportTemplate(); // ImportTemplate | ImportTemplate

            try
            { 
                // Create Import Template
                ImportTemplate result = apiInstance.PostOutboundImporttemplates(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundImporttemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ImportTemplate**](ImportTemplate)| ImportTemplate |  |

### Return type

[**ImportTemplate**](ImportTemplate)


## PostOutboundImporttemplatesBulkAdd

> [**ImportTemplateEntityListing**](ImportTemplateEntityListing) PostOutboundImporttemplatesBulkAdd (List<ImportTemplate> body)


Add multiple import templates

Requires ANY permissions: 

* outbound:importTemplate:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundImporttemplatesBulkAddExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new List<ImportTemplate>(); // List<ImportTemplate> | import template(s) to add

            try
            { 
                // Add multiple import templates
                ImportTemplateEntityListing result = apiInstance.PostOutboundImporttemplatesBulkAdd(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundImporttemplatesBulkAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<ImportTemplate>**](ImportTemplate)| import template(s) to add |  |

### Return type

[**ImportTemplateEntityListing**](ImportTemplateEntityListing)


## PostOutboundMessagingcampaignStart

> void PostOutboundMessagingcampaignStart (string messagingCampaignId)


Start the campaign

Documented permissions are applicable based on campaign type.

Requires ANY permissions: 

* outbound:messagingCampaign:start
* outbound:emailCampaign:start
* outbound:whatsAppCampaign:start

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundMessagingcampaignStartExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Start the campaign
                apiInstance.PostOutboundMessagingcampaignStart(messagingCampaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundMessagingcampaignStart: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |

### Return type

void (empty response body)


## PostOutboundMessagingcampaignStop

> void PostOutboundMessagingcampaignStop (string messagingCampaignId)


Stop the campaign

Documented permissions are applicable based on campaign type.

Requires ANY permissions: 

* outbound:messagingCampaign:stop
* outbound:emailCampaign:stop
* outbound:whatsAppCampaign:stop

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundMessagingcampaignStopExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID

            try
            { 
                // Stop the campaign
                apiInstance.PostOutboundMessagingcampaignStop(messagingCampaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundMessagingcampaignStop: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |

### Return type

void (empty response body)


## PostOutboundMessagingcampaigns

> [**MessagingCampaign**](MessagingCampaign) PostOutboundMessagingcampaigns (MessagingCampaign body)


Create a Messaging Campaign

Requires ANY permissions: 

* outbound:messagingCampaign:add
* outbound:emailCampaign:add
* outbound:whatsAppCampaign:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundMessagingcampaignsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new MessagingCampaign(); // MessagingCampaign | Messaging Campaign

            try
            { 
                // Create a Messaging Campaign
                MessagingCampaign result = apiInstance.PostOutboundMessagingcampaigns(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundMessagingcampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**MessagingCampaign**](MessagingCampaign)| Messaging Campaign |  |

### Return type

[**MessagingCampaign**](MessagingCampaign)


## PostOutboundMessagingcampaignsProgress

> [**List&lt;CampaignProgress&gt;**](CampaignProgress) PostOutboundMessagingcampaignsProgress (List<string> body)


Get progress for a list of messaging campaigns

Requires ANY permissions: 

* outbound:messagingCampaign:view
* outbound:emailCampaign:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundMessagingcampaignsProgressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new List<string>(); // List<string> | Messaging Campaign IDs

            try
            { 
                // Get progress for a list of messaging campaigns
                List<CampaignProgress> result = apiInstance.PostOutboundMessagingcampaignsProgress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundMessagingcampaignsProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<string>**](string)| Messaging Campaign IDs |  |

### Return type

[**List<CampaignProgress>**](CampaignProgress)


## PostOutboundRulesets

> [**RuleSet**](RuleSet) PostOutboundRulesets (RuleSet body)


Create a Rule Set.

Requires ANY permissions: 

* outbound:ruleSet:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundRulesetsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new RuleSet(); // RuleSet | RuleSet

            try
            { 
                // Create a Rule Set.
                RuleSet result = apiInstance.PostOutboundRulesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundRulesets: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RuleSet**](RuleSet)| RuleSet |  |

### Return type

[**RuleSet**](RuleSet)


## PostOutboundSequences

> [**CampaignSequence**](CampaignSequence) PostOutboundSequences (CampaignSequence body)


Create a new campaign sequence.

Requires ANY permissions: 

* outbound:campaignSequence:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostOutboundSequencesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new CampaignSequence(); // CampaignSequence | Organization

            try
            { 
                // Create a new campaign sequence.
                CampaignSequence result = apiInstance.PostOutboundSequences(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostOutboundSequences: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CampaignSequence**](CampaignSequence)| Organization |  |

### Return type

[**CampaignSequence**](CampaignSequence)


## PutOutboundAttemptlimit

> [**AttemptLimits**](AttemptLimits) PutOutboundAttemptlimit (string attemptLimitsId, AttemptLimits body)


Update attempt limits

Requires ANY permissions: 

* outbound:attemptLimits:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundAttemptlimitExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var attemptLimitsId = attemptLimitsId_example;  // string | Attempt limits ID
            var body = new AttemptLimits(); // AttemptLimits | AttemptLimits

            try
            { 
                // Update attempt limits
                AttemptLimits result = apiInstance.PutOutboundAttemptlimit(attemptLimitsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundAttemptlimit: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attemptLimitsId** | **string**| Attempt limits ID |  |
| **body** | [**AttemptLimits**](AttemptLimits)| AttemptLimits |  |

### Return type

[**AttemptLimits**](AttemptLimits)


## PutOutboundCallabletimeset

> [**CallableTimeSet**](CallableTimeSet) PutOutboundCallabletimeset (string callableTimeSetId, CallableTimeSet body)


Update callable time set

Requires ANY permissions: 

* outbound:callableTimeSet:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCallabletimesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID
            var body = new CallableTimeSet(); // CallableTimeSet | DialerCallableTimeSet

            try
            { 
                // Update callable time set
                CallableTimeSet result = apiInstance.PutOutboundCallabletimeset(callableTimeSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCallabletimeset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
| **body** | [**CallableTimeSet**](CallableTimeSet)| DialerCallableTimeSet |  |

### Return type

[**CallableTimeSet**](CallableTimeSet)


## PutOutboundCallanalysisresponseset

> [**ResponseSet**](ResponseSet) PutOutboundCallanalysisresponseset (string callAnalysisSetId, ResponseSet body)


Update a dialer call analysis response set.

Requires ANY permissions: 

* outbound:responseSet:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCallanalysisresponsesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID
            var body = new ResponseSet(); // ResponseSet | ResponseSet

            try
            { 
                // Update a dialer call analysis response set.
                ResponseSet result = apiInstance.PutOutboundCallanalysisresponseset(callAnalysisSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCallanalysisresponseset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
| **body** | [**ResponseSet**](ResponseSet)| ResponseSet |  |

### Return type

[**ResponseSet**](ResponseSet)


## PutOutboundCampaign

> [**Campaign**](Campaign) PutOutboundCampaign (string campaignId, Campaign body)


Update a campaign.

Requires ALL permissions: 

* outbound:campaign:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new Campaign(); // Campaign | Campaign

            try
            { 
                // Update a campaign.
                Campaign result = apiInstance.PutOutboundCampaign(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**Campaign**](Campaign)| Campaign |  |

### Return type

[**Campaign**](Campaign)


## PutOutboundCampaignAgent

> **string** PutOutboundCampaignAgent (string campaignId, string userId, Agent body)


Send notification that an agent's state changed 

New agent state.

Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCampaignAgentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var userId = userId_example;  // string | Agent's user ID
            var body = new Agent(); // Agent | agent

            try
            { 
                // Send notification that an agent's state changed 
                string result = apiInstance.PutOutboundCampaignAgent(campaignId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCampaignAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **userId** | **string**| Agent&#39;s user ID |  |
| **body** | [**Agent**](Agent)| agent |  |

### Return type

**string**


## PutOutboundCampaignrule

> [**CampaignRule**](CampaignRule) PutOutboundCampaignrule (string campaignRuleId, CampaignRule body)


Update Campaign Rule

Requires ANY permissions: 

* outbound:campaignRule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundCampaignruleExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignRuleId = campaignRuleId_example;  // string | Campaign Rule ID
            var body = new CampaignRule(); // CampaignRule | CampaignRule

            try
            { 
                // Update Campaign Rule
                CampaignRule result = apiInstance.PutOutboundCampaignrule(campaignRuleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundCampaignrule: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignRuleId** | **string**| Campaign Rule ID |  |
| **body** | [**CampaignRule**](CampaignRule)| CampaignRule |  |

### Return type

[**CampaignRule**](CampaignRule)


## PutOutboundContactlist

> [**ContactList**](ContactList) PutOutboundContactlist (string contactListId, ContactList body)


Update a contact list.

Requires ANY permissions: 

* outbound:contactList:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var body = new ContactList(); // ContactList | ContactList

            try
            { 
                // Update a contact list.
                ContactList result = apiInstance.PutOutboundContactlist(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **body** | [**ContactList**](ContactList)| ContactList |  |

### Return type

[**ContactList**](ContactList)


## PutOutboundContactlistContact

> [**DialerContact**](DialerContact) PutOutboundContactlistContact (string contactListId, string contactId, DialerContact body)


Update a contact.

Requires ANY permissions: 

* outbound:contact:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlistContactExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactId = contactId_example;  // string | Contact ID
            var body = new DialerContact(); // DialerContact | Contact

            try
            { 
                // Update a contact.
                DialerContact result = apiInstance.PutOutboundContactlistContact(contactListId, contactId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlistContact: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
| **body** | [**DialerContact**](DialerContact)| Contact |  |

### Return type

[**DialerContact**](DialerContact)


## PutOutboundContactlistfilter

> [**ContactListFilter**](ContactListFilter) PutOutboundContactlistfilter (string contactListFilterId, ContactListFilter body)


Update Contact List Filter

Requires ANY permissions: 

* outbound:contactListFilter:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlistfilterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListFilterId = contactListFilterId_example;  // string | Contact List Filter ID
            var body = new ContactListFilter(); // ContactListFilter | ContactListFilter

            try
            { 
                // Update Contact List Filter
                ContactListFilter result = apiInstance.PutOutboundContactlistfilter(contactListFilterId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlistfilter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListFilterId** | **string**| Contact List Filter ID |  |
| **body** | [**ContactListFilter**](ContactListFilter)| ContactListFilter |  |

### Return type

[**ContactListFilter**](ContactListFilter)


## PutOutboundContactlisttemplate

> [**ContactListTemplate**](ContactListTemplate) PutOutboundContactlisttemplate (string contactListTemplateId, ContactListTemplate body)


Update a contact list template.

Requires ANY permissions: 

* outbound:contactListTemplate:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundContactlisttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var contactListTemplateId = contactListTemplateId_example;  // string | ContactListTemplate ID
            var body = new ContactListTemplate(); // ContactListTemplate | ContactListTemplate

            try
            { 
                // Update a contact list template.
                ContactListTemplate result = apiInstance.PutOutboundContactlisttemplate(contactListTemplateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundContactlisttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListTemplateId** | **string**| ContactListTemplate ID |  |
| **body** | [**ContactListTemplate**](ContactListTemplate)| ContactListTemplate |  |

### Return type

[**ContactListTemplate**](ContactListTemplate)


## PutOutboundDigitalruleset

> [**DigitalRuleSet**](DigitalRuleSet) PutOutboundDigitalruleset (string digitalRuleSetId, DigitalRuleSet body)


Update an Outbound Digital Rule Set

Requires ANY permissions: 

* outbound:digitalRuleSet:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundDigitalrulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var digitalRuleSetId = digitalRuleSetId_example;  // string | The Digital Rule Set ID
            var body = new DigitalRuleSet(); // DigitalRuleSet | Digital Rule Set

            try
            { 
                // Update an Outbound Digital Rule Set
                DigitalRuleSet result = apiInstance.PutOutboundDigitalruleset(digitalRuleSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundDigitalruleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **digitalRuleSetId** | **string**| The Digital Rule Set ID |  |
| **body** | [**DigitalRuleSet**](DigitalRuleSet)| Digital Rule Set |  |

### Return type

[**DigitalRuleSet**](DigitalRuleSet)


## PutOutboundDnclist

> [**DncList**](DncList) PutOutboundDnclist (string dncListId, DncList body)


Update dialer DNC list

Requires ANY permissions: 

* outbound:dncList:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundDnclistExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new DncList(); // DncList | DncList

            try
            { 
                // Update dialer DNC list
                DncList result = apiInstance.PutOutboundDnclist(dncListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundDnclist: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncList**](DncList)| DncList |  |

### Return type

[**DncList**](DncList)


## PutOutboundFilespecificationtemplate

> [**FileSpecificationTemplate**](FileSpecificationTemplate) PutOutboundFilespecificationtemplate (string fileSpecificationTemplateId, FileSpecificationTemplate body)


Update File Specification Template

Requires ANY permissions: 

* outbound:fileSpecificationTemplate:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundFilespecificationtemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var fileSpecificationTemplateId = fileSpecificationTemplateId_example;  // string | File Specification Template ID
            var body = new FileSpecificationTemplate(); // FileSpecificationTemplate | fileSpecificationTemplate

            try
            { 
                // Update File Specification Template
                FileSpecificationTemplate result = apiInstance.PutOutboundFilespecificationtemplate(fileSpecificationTemplateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundFilespecificationtemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **fileSpecificationTemplateId** | **string**| File Specification Template ID |  |
| **body** | [**FileSpecificationTemplate**](FileSpecificationTemplate)| fileSpecificationTemplate |  |

### Return type

[**FileSpecificationTemplate**](FileSpecificationTemplate)


## PutOutboundImporttemplate

> [**ImportTemplate**](ImportTemplate) PutOutboundImporttemplate (string importTemplateId, ImportTemplate body)


Update Import Template

Requires ANY permissions: 

* outbound:importTemplate:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundImporttemplateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var importTemplateId = importTemplateId_example;  // string | Import Template ID
            var body = new ImportTemplate(); // ImportTemplate | importTemplate

            try
            { 
                // Update Import Template
                ImportTemplate result = apiInstance.PutOutboundImporttemplate(importTemplateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundImporttemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **importTemplateId** | **string**| Import Template ID |  |
| **body** | [**ImportTemplate**](ImportTemplate)| importTemplate |  |

### Return type

[**ImportTemplate**](ImportTemplate)


## PutOutboundMessagingcampaign

> [**MessagingCampaign**](MessagingCampaign) PutOutboundMessagingcampaign (string messagingCampaignId, MessagingCampaign body)


Update an Outbound Messaging Campaign

Requires ANY permissions: 

* outbound:messagingCampaign:edit
* outbound:emailCampaign:edit
* outbound:whatsAppCampaign:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | The Messaging Campaign ID
            var body = new MessagingCampaign(); // MessagingCampaign | MessagingCampaign

            try
            { 
                // Update an Outbound Messaging Campaign
                MessagingCampaign result = apiInstance.PutOutboundMessagingcampaign(messagingCampaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| The Messaging Campaign ID |  |
| **body** | [**MessagingCampaign**](MessagingCampaign)| MessagingCampaign |  |

### Return type

[**MessagingCampaign**](MessagingCampaign)


## PutOutboundRuleset

> [**RuleSet**](RuleSet) PutOutboundRuleset (string ruleSetId, RuleSet body)


Update a Rule Set.

Requires ANY permissions: 

* outbound:ruleSet:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundRulesetExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID
            var body = new RuleSet(); // RuleSet | RuleSet

            try
            { 
                // Update a Rule Set.
                RuleSet result = apiInstance.PutOutboundRuleset(ruleSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundRuleset: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
| **body** | [**RuleSet**](RuleSet)| RuleSet |  |

### Return type

[**RuleSet**](RuleSet)


## PutOutboundSchedulesCampaign

> [**CampaignSchedule**](CampaignSchedule) PutOutboundSchedulesCampaign (string campaignId, CampaignSchedule body)


Update a new campaign schedule.

Requires ANY permissions: 

* outbound:schedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSchedulesCampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new CampaignSchedule(); // CampaignSchedule | CampaignSchedule

            try
            { 
                // Update a new campaign schedule.
                CampaignSchedule result = apiInstance.PutOutboundSchedulesCampaign(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSchedulesCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**CampaignSchedule**](CampaignSchedule)| CampaignSchedule |  |

### Return type

[**CampaignSchedule**](CampaignSchedule)


## PutOutboundSchedulesEmailcampaign

> [**EmailCampaignSchedule**](EmailCampaignSchedule) PutOutboundSchedulesEmailcampaign (string emailCampaignId, EmailCampaignSchedule body)


Update an email campaign schedule.

Requires ANY permissions: 

* outbound:emailCampaignSchedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSchedulesEmailcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var emailCampaignId = emailCampaignId_example;  // string | Email Campaign ID
            var body = new EmailCampaignSchedule(); // EmailCampaignSchedule | EmailCampaignSchedule

            try
            { 
                // Update an email campaign schedule.
                EmailCampaignSchedule result = apiInstance.PutOutboundSchedulesEmailcampaign(emailCampaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSchedulesEmailcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailCampaignId** | **string**| Email Campaign ID |  |
| **body** | [**EmailCampaignSchedule**](EmailCampaignSchedule)| EmailCampaignSchedule |  |

### Return type

[**EmailCampaignSchedule**](EmailCampaignSchedule)


## PutOutboundSchedulesMessagingcampaign

> [**MessagingCampaignSchedule**](MessagingCampaignSchedule) PutOutboundSchedulesMessagingcampaign (string messagingCampaignId, MessagingCampaignSchedule body)


Update a new messaging campaign schedule.

Requires ANY permissions: 

* outbound:messagingCampaignSchedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSchedulesMessagingcampaignExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var messagingCampaignId = messagingCampaignId_example;  // string | Messaging Campaign ID
            var body = new MessagingCampaignSchedule(); // MessagingCampaignSchedule | MessagingCampaignSchedule

            try
            { 
                // Update a new messaging campaign schedule.
                MessagingCampaignSchedule result = apiInstance.PutOutboundSchedulesMessagingcampaign(messagingCampaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSchedulesMessagingcampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messagingCampaignId** | **string**| Messaging Campaign ID |  |
| **body** | [**MessagingCampaignSchedule**](MessagingCampaignSchedule)| MessagingCampaignSchedule |  |

### Return type

[**MessagingCampaignSchedule**](MessagingCampaignSchedule)


## PutOutboundSchedulesSequence

> [**SequenceSchedule**](SequenceSchedule) PutOutboundSchedulesSequence (string sequenceId, SequenceSchedule body)


Update a new sequence schedule.

Requires ANY permissions: 

* outbound:schedule:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSchedulesSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Sequence ID
            var body = new SequenceSchedule(); // SequenceSchedule | SequenceSchedule

            try
            { 
                // Update a new sequence schedule.
                SequenceSchedule result = apiInstance.PutOutboundSchedulesSequence(sequenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSchedulesSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
| **body** | [**SequenceSchedule**](SequenceSchedule)| SequenceSchedule |  |

### Return type

[**SequenceSchedule**](SequenceSchedule)


## PutOutboundSequence

> [**CampaignSequence**](CampaignSequence) PutOutboundSequence (string sequenceId, CampaignSequence body)


Update a new campaign sequence.

Requires ANY permissions: 

* outbound:campaignSequence:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundSequenceExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID
            var body = new CampaignSequence(); // CampaignSequence | Organization

            try
            { 
                // Update a new campaign sequence.
                CampaignSequence result = apiInstance.PutOutboundSequence(sequenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundSequence: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
| **body** | [**CampaignSequence**](CampaignSequence)| Organization |  |

### Return type

[**CampaignSequence**](CampaignSequence)


## PutOutboundWrapupcodemappings

> [**WrapUpCodeMapping**](WrapUpCodeMapping) PutOutboundWrapupcodemappings (WrapUpCodeMapping body)


Update the Dialer wrap up code mapping.

Requires ANY permissions: 

* outbound:wrapUpCodeMapping:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutOutboundWrapupcodemappingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new OutboundApi();
            var body = new WrapUpCodeMapping(); // WrapUpCodeMapping | wrapUpCodeMapping

            try
            { 
                // Update the Dialer wrap up code mapping.
                WrapUpCodeMapping result = apiInstance.PutOutboundWrapupcodemappings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutOutboundWrapupcodemappings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WrapUpCodeMapping**](WrapUpCodeMapping)| wrapUpCodeMapping |  |

### Return type

[**WrapUpCodeMapping**](WrapUpCodeMapping)


_PureCloudPlatform.Client.V2 224.0.0_
