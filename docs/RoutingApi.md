# RoutingApi

## PureCloudPlatform.Client.V2.Api.RoutingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteRoutingAssessment**](#DeleteRoutingAssessment) | **Delete** /api/v2/routing/assessments/{assessmentId} | Delete single benefit assessment. |
| [**DeleteRoutingDirectroutingbackupSettingsMe**](#DeleteRoutingDirectroutingbackupSettingsMe) | **Delete** /api/v2/routing/directroutingbackup/settings/me | Delete the user&#39;s Direct Routing Backup settings and revert to the Direct Routing Queue default. |
| [**DeleteRoutingEmailDomain**](#DeleteRoutingEmailDomain) | **Delete** /api/v2/routing/email/domains/{domainId} | Delete a domain |
| [**DeleteRoutingEmailDomainRoute**](#DeleteRoutingEmailDomainRoute) | **Delete** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Delete a route |
| [**DeleteRoutingEmailOutboundDomain**](#DeleteRoutingEmailOutboundDomain) | **Delete** /api/v2/routing/email/outbound/domains/{domainId} | Delete an outbound domain |
| [**DeleteRoutingLanguage**](#DeleteRoutingLanguage) | **Delete** /api/v2/routing/languages/{languageId} | Delete a routing language |
| [**DeleteRoutingPredictor**](#DeleteRoutingPredictor) | **Delete** /api/v2/routing/predictors/{predictorId} | Delete single predictor. |
| [**DeleteRoutingQueue**](#DeleteRoutingQueue) | **Delete** /api/v2/routing/queues/{queueId} | Delete a queue |
| [**DeleteRoutingQueueMember**](#DeleteRoutingQueueMember) | **Delete** /api/v2/routing/queues/{queueId}/members/{memberId} | Delete a queue member. |
| [**DeleteRoutingQueueUser**](#DeleteRoutingQueueUser) | **Delete** /api/v2/routing/queues/{queueId}/users/{memberId} | DEPRECATED: use DELETE /routing/queues/{queueId}/members/{memberId}.  Delete queue member. |
| [**DeleteRoutingQueueWrapupcode**](#DeleteRoutingQueueWrapupcode) | **Delete** /api/v2/routing/queues/{queueId}/wrapupcodes/{codeId} | Delete a wrap-up code from a queue |
| [**DeleteRoutingSettings**](#DeleteRoutingSettings) | **Delete** /api/v2/routing/settings | Delete an organization&#39;s routing settings |
| [**DeleteRoutingSkill**](#DeleteRoutingSkill) | **Delete** /api/v2/routing/skills/{skillId} | Delete Routing Skill |
| [**DeleteRoutingSkillgroup**](#DeleteRoutingSkillgroup) | **Delete** /api/v2/routing/skillgroups/{skillGroupId} | Remove skill group definition |
| [**DeleteRoutingSmsAddress**](#DeleteRoutingSmsAddress) | **Delete** /api/v2/routing/sms/addresses/{addressId} | Delete an Address by Id for SMS |
| [**DeleteRoutingSmsPhonenumber**](#DeleteRoutingSmsPhonenumber) | **Delete** /api/v2/routing/sms/phonenumbers/{phoneNumberId} | Delete a phone number provisioned for SMS. |
| [**DeleteRoutingUserDirectroutingbackupSettings**](#DeleteRoutingUserDirectroutingbackupSettings) | **Delete** /api/v2/routing/users/{userId}/directroutingbackup/settings | Delete the user&#39;s Direct Routing Backup settings and revert to the Direct Routing Queue default. |
| [**DeleteRoutingUserUtilization**](#DeleteRoutingUserUtilization) | **Delete** /api/v2/routing/users/{userId}/utilization | Delete the user&#39;s max utilization settings and revert to the organization-wide default. |
| [**DeleteRoutingUtilization**](#DeleteRoutingUtilization) | **Delete** /api/v2/routing/utilization | Delete the organization-wide max utilization settings and revert to the system default. |
| [**DeleteRoutingUtilizationLabel**](#DeleteRoutingUtilizationLabel) | **Delete** /api/v2/routing/utilization/labels/{labelId} | Delete a utilization label |
| [**DeleteRoutingUtilizationTag**](#DeleteRoutingUtilizationTag) | **Delete** /api/v2/routing/utilization/tags/{tagId} | Delete an utilization tag |
| [**DeleteRoutingWrapupcode**](#DeleteRoutingWrapupcode) | **Delete** /api/v2/routing/wrapupcodes/{codeId} | Delete wrap-up code |
| [**DeleteUserRoutinglanguage**](#DeleteUserRoutinglanguage) | **Delete** /api/v2/users/{userId}/routinglanguages/{languageId} | Remove a routing language from a user |
| [**DeleteUserRoutingskill**](#DeleteUserRoutingskill) | **Delete** /api/v2/users/{userId}/routingskills/{skillId} | Remove a routing skill from a user |
| [**GetRoutingAssessment**](#GetRoutingAssessment) | **Get** /api/v2/routing/assessments/{assessmentId} | Retrieve a single benefit assessment. |
| [**GetRoutingAssessments**](#GetRoutingAssessments) | **Get** /api/v2/routing/assessments | Retrieve all benefit assessments. |
| [**GetRoutingAssessmentsJob**](#GetRoutingAssessmentsJob) | **Get** /api/v2/routing/assessments/jobs/{jobId} | Retrieve a single benefit assessments job. |
| [**GetRoutingAssessmentsJobs**](#GetRoutingAssessmentsJobs) | **Get** /api/v2/routing/assessments/jobs | Retrieve all benefit assessment jobs. |
| [**GetRoutingAvailablemediatypes**](#GetRoutingAvailablemediatypes) | **Get** /api/v2/routing/availablemediatypes | Get available media types |
| [**GetRoutingDirectroutingbackupSettingsMe**](#GetRoutingDirectroutingbackupSettingsMe) | **Get** /api/v2/routing/directroutingbackup/settings/me | Get the user&#39;s Direct Routing Backup settings. |
| [**GetRoutingEmailDomain**](#GetRoutingEmailDomain) | **Get** /api/v2/routing/email/domains/{domainId} | Get domain |
| [**GetRoutingEmailDomainRoute**](#GetRoutingEmailDomainRoute) | **Get** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Get a route |
| [**GetRoutingEmailDomainRouteIdentityresolution**](#GetRoutingEmailDomainRouteIdentityresolution) | **Get** /api/v2/routing/email/domains/{domainName}/routes/{routeId}/identityresolution | Get a route identity resolution setting. |
| [**GetRoutingEmailDomainRoutes**](#GetRoutingEmailDomainRoutes) | **Get** /api/v2/routing/email/domains/{domainName}/routes | Get routes |
| [**GetRoutingEmailDomains**](#GetRoutingEmailDomains) | **Get** /api/v2/routing/email/domains | Get domains |
| [**GetRoutingEmailOutboundDomain**](#GetRoutingEmailOutboundDomain) | **Get** /api/v2/routing/email/outbound/domains/{domainId} | Get domain |
| [**GetRoutingEmailOutboundDomainActivation**](#GetRoutingEmailOutboundDomainActivation) | **Get** /api/v2/routing/email/outbound/domains/{domainId}/activation | Get activation status (cname + dkim) of an outbound domain |
| [**GetRoutingEmailOutboundDomainSearch**](#GetRoutingEmailOutboundDomainSearch) | **Get** /api/v2/routing/email/outbound/domains/{domainId}/search | Search a domain across organizations |
| [**GetRoutingEmailOutboundDomains**](#GetRoutingEmailOutboundDomains) | **Get** /api/v2/routing/email/outbound/domains | Get outbound domains |
| [**GetRoutingEmailSetup**](#GetRoutingEmailSetup) | **Get** /api/v2/routing/email/setup | Get email setup |
| [**GetRoutingLanguage**](#GetRoutingLanguage) | **Get** /api/v2/routing/languages/{languageId} | Get a routing language |
| [**GetRoutingLanguages**](#GetRoutingLanguages) | **Get** /api/v2/routing/languages | Get the list of supported languages. |
| [**GetRoutingMessageRecipient**](#GetRoutingMessageRecipient) | **Get** /api/v2/routing/message/recipients/{recipientId} | Get a recipient |
| [**GetRoutingMessageRecipients**](#GetRoutingMessageRecipients) | **Get** /api/v2/routing/message/recipients | Get recipients |
| [**GetRoutingPredictor**](#GetRoutingPredictor) | **Get** /api/v2/routing/predictors/{predictorId} | Retrieve a single predictor. |
| [**GetRoutingPredictorModelFeatures**](#GetRoutingPredictorModelFeatures) | **Get** /api/v2/routing/predictors/{predictorId}/models/{modelId}/features | Retrieve Predictor Model Features. |
| [**GetRoutingPredictorModels**](#GetRoutingPredictorModels) | **Get** /api/v2/routing/predictors/{predictorId}/models | Retrieve Predictor Models and Top Features. |
| [**GetRoutingPredictors**](#GetRoutingPredictors) | **Get** /api/v2/routing/predictors | Retrieve all predictors. |
| [**GetRoutingPredictorsKeyperformanceindicators**](#GetRoutingPredictorsKeyperformanceindicators) | **Get** /api/v2/routing/predictors/keyperformanceindicators | Get a list of Key Performance Indicators |
| [**GetRoutingQueue**](#GetRoutingQueue) | **Get** /api/v2/routing/queues/{queueId} | Get details about this queue. |
| [**GetRoutingQueueAssistant**](#GetRoutingQueueAssistant) | **Get** /api/v2/routing/queues/{queueId}/assistant | Get an assistant associated with a queue. |
| [**GetRoutingQueueComparisonperiod**](#GetRoutingQueueComparisonperiod) | **Get** /api/v2/routing/queues/{queueId}/comparisonperiods/{comparisonPeriodId} | Get a Comparison Period. |
| [**GetRoutingQueueComparisonperiods**](#GetRoutingQueueComparisonperiods) | **Get** /api/v2/routing/queues/{queueId}/comparisonperiods | Get list of comparison periods |
| [**GetRoutingQueueEstimatedwaittime**](#GetRoutingQueueEstimatedwaittime) | **Get** /api/v2/routing/queues/{queueId}/estimatedwaittime | Get Estimated Wait Time |
| [**GetRoutingQueueIdentityresolution**](#GetRoutingQueueIdentityresolution) | **Get** /api/v2/routing/queues/{queueId}/identityresolution | Get Queue IdentityResolution Settings. |
| [**GetRoutingQueueMediatypeEstimatedwaittime**](#GetRoutingQueueMediatypeEstimatedwaittime) | **Get** /api/v2/routing/queues/{queueId}/mediatypes/{mediaType}/estimatedwaittime | Get Estimated Wait Time |
| [**GetRoutingQueueMembers**](#GetRoutingQueueMembers) | **Get** /api/v2/routing/queues/{queueId}/members | Get the members of this queue. |
| [**GetRoutingQueueUsers**](#GetRoutingQueueUsers) | **Get** /api/v2/routing/queues/{queueId}/users | DEPRECATED: use GET /routing/queues/{queueId}/members.  Get the members of this queue. |
| [**GetRoutingQueueWrapupcodes**](#GetRoutingQueueWrapupcodes) | **Get** /api/v2/routing/queues/{queueId}/wrapupcodes | Get the wrap-up codes for a queue |
| [**GetRoutingQueues**](#GetRoutingQueues) | **Get** /api/v2/routing/queues | Get list of queues. |
| [**GetRoutingQueuesDivisionviews**](#GetRoutingQueuesDivisionviews) | **Get** /api/v2/routing/queues/divisionviews | Get a paged listing of simplified queue objects, filterable by name, queue ID(s), or division ID(s). |
| [**GetRoutingQueuesDivisionviewsAll**](#GetRoutingQueuesDivisionviewsAll) | **Get** /api/v2/routing/queues/divisionviews/all | Get a paged listing of simplified queue objects, sorted by name.  Can be used to get a digest of all queues in an organization. |
| [**GetRoutingQueuesMe**](#GetRoutingQueuesMe) | **Get** /api/v2/routing/queues/me | Get a paged listing of queues the user is a member of. |
| [**GetRoutingSettings**](#GetRoutingSettings) | **Get** /api/v2/routing/settings | Get an organization&#39;s routing settings |
| [**GetRoutingSettingsContactcenter**](#GetRoutingSettingsContactcenter) | **Get** /api/v2/routing/settings/contactcenter | Get Contact Center Settings |
| [**GetRoutingSettingsTranscription**](#GetRoutingSettingsTranscription) | **Get** /api/v2/routing/settings/transcription | Get Transcription Settings |
| [**GetRoutingSkill**](#GetRoutingSkill) | **Get** /api/v2/routing/skills/{skillId} | Get Routing Skill |
| [**GetRoutingSkillgroup**](#GetRoutingSkillgroup) | **Get** /api/v2/routing/skillgroups/{skillGroupId} | Get skill group |
| [**GetRoutingSkillgroupMembers**](#GetRoutingSkillgroupMembers) | **Get** /api/v2/routing/skillgroups/{skillGroupId}/members | Get skill group members |
| [**GetRoutingSkillgroupMembersDivisions**](#GetRoutingSkillgroupMembersDivisions) | **Get** /api/v2/routing/skillgroups/{skillGroupId}/members/divisions | Get list of member divisions for this skill group. |
| [**GetRoutingSkillgroups**](#GetRoutingSkillgroups) | **Get** /api/v2/routing/skillgroups | Get skill group listing |
| [**GetRoutingSkills**](#GetRoutingSkills) | **Get** /api/v2/routing/skills | Get the list of routing skills. |
| [**GetRoutingSmsAddress**](#GetRoutingSmsAddress) | **Get** /api/v2/routing/sms/addresses/{addressId} | Get an Address by Id for SMS |
| [**GetRoutingSmsAddresses**](#GetRoutingSmsAddresses) | **Get** /api/v2/routing/sms/addresses | Get a list of Addresses for SMS |
| [**GetRoutingSmsAvailablephonenumbers**](#GetRoutingSmsAvailablephonenumbers) | **Get** /api/v2/routing/sms/availablephonenumbers | Get a list of available phone numbers for SMS provisioning. |
| [**GetRoutingSmsIdentityresolutionPhonenumber**](#GetRoutingSmsIdentityresolutionPhonenumber) | **Get** /api/v2/routing/sms/identityresolution/phonenumbers/{addressId} | Get a SMS identity resolution settings. |
| [**GetRoutingSmsPhonenumber**](#GetRoutingSmsPhonenumber) | **Get** /api/v2/routing/sms/phonenumbers/{phoneNumberId} | Get a phone number provisioned for SMS. |
| [**GetRoutingSmsPhonenumbers**](#GetRoutingSmsPhonenumbers) | **Get** /api/v2/routing/sms/phonenumbers | Get a list of provisioned phone numbers. |
| [**GetRoutingUserDirectroutingbackupSettings**](#GetRoutingUserDirectroutingbackupSettings) | **Get** /api/v2/routing/users/{userId}/directroutingbackup/settings | Get the user&#39;s Direct Routing Backup settings. |
| [**GetRoutingUserUtilization**](#GetRoutingUserUtilization) | **Get** /api/v2/routing/users/{userId}/utilization | Get the user&#39;s max utilization settings.  If not configured, the organization-wide default is returned. |
| [**GetRoutingUtilization**](#GetRoutingUtilization) | **Get** /api/v2/routing/utilization | Get the organization-wide max utilization settings. |
| [**GetRoutingUtilizationLabel**](#GetRoutingUtilizationLabel) | **Get** /api/v2/routing/utilization/labels/{labelId} | Get details about this utilization label |
| [**GetRoutingUtilizationLabelAgents**](#GetRoutingUtilizationLabelAgents) | **Get** /api/v2/routing/utilization/labels/{labelId}/agents | Get list of agent ids associated with a utilization label |
| [**GetRoutingUtilizationLabels**](#GetRoutingUtilizationLabels) | **Get** /api/v2/routing/utilization/labels | Get list of utilization labels |
| [**GetRoutingUtilizationTag**](#GetRoutingUtilizationTag) | **Get** /api/v2/routing/utilization/tags/{tagId} | Get details about this utilization tag |
| [**GetRoutingUtilizationTagAgents**](#GetRoutingUtilizationTagAgents) | **Get** /api/v2/routing/utilization/tags/{tagId}/agents | Get list of agent ids associated with a utilization tag |
| [**GetRoutingUtilizationTags**](#GetRoutingUtilizationTags) | **Get** /api/v2/routing/utilization/tags | Get list of utilization tags |
| [**GetRoutingWrapupcode**](#GetRoutingWrapupcode) | **Get** /api/v2/routing/wrapupcodes/{codeId} | Get details about this wrap-up code. |
| [**GetRoutingWrapupcodes**](#GetRoutingWrapupcodes) | **Get** /api/v2/routing/wrapupcodes | Get list of wrapup codes. |
| [**GetRoutingWrapupcodesDivisionview**](#GetRoutingWrapupcodesDivisionview) | **Get** /api/v2/routing/wrapupcodes/divisionviews/{codeId} | Get a simplified wrap-up code. |
| [**GetRoutingWrapupcodesDivisionviews**](#GetRoutingWrapupcodesDivisionviews) | **Get** /api/v2/routing/wrapupcodes/divisionviews | Get a paged listing of simplified wrapup code objects, filterable by name, wrapup code ID(s), or division ID(s). |
| [**GetUserQueues**](#GetUserQueues) | **Get** /api/v2/users/{userId}/queues | Get queues for user |
| [**GetUserRoutinglanguages**](#GetUserRoutinglanguages) | **Get** /api/v2/users/{userId}/routinglanguages | List routing languages assigned to a user |
| [**GetUserRoutingskills**](#GetUserRoutingskills) | **Get** /api/v2/users/{userId}/routingskills | List routing skills assigned to a user |
| [**GetUserSkillgroups**](#GetUserSkillgroups) | **Get** /api/v2/users/{userId}/skillgroups | Get skill groups for a user |
| [**PatchRoutingConversation**](#PatchRoutingConversation) | **Patch** /api/v2/routing/conversations/{conversationId} | Update attributes of an in-queue conversation |
| [**PatchRoutingEmailDomain**](#PatchRoutingEmailDomain) | **Patch** /api/v2/routing/email/domains/{domainId} | Update domain settings |
| [**PatchRoutingEmailDomainValidate**](#PatchRoutingEmailDomainValidate) | **Patch** /api/v2/routing/email/domains/{domainId}/validate | Validate domain settings |
| [**PatchRoutingPredictor**](#PatchRoutingPredictor) | **Patch** /api/v2/routing/predictors/{predictorId} | Update single predictor. |
| [**PatchRoutingQueueMember**](#PatchRoutingQueueMember) | **Patch** /api/v2/routing/queues/{queueId}/members/{memberId} | Update the ring number OR joined status for a queue member. |
| [**PatchRoutingQueueMembers**](#PatchRoutingQueueMembers) | **Patch** /api/v2/routing/queues/{queueId}/members | Join or unjoin a set of up to 100 users for a queue |
| [**PatchRoutingQueueUser**](#PatchRoutingQueueUser) | **Patch** /api/v2/routing/queues/{queueId}/users/{memberId} | DEPRECATED: use PATCH /routing/queues/{queueId}/members/{memberId}.  Update the ring number OR joined status for a User in a Queue. |
| [**PatchRoutingQueueUsers**](#PatchRoutingQueueUsers) | **Patch** /api/v2/routing/queues/{queueId}/users | DEPRECATED: use PATCH /routing/queues/{queueId}/members.  Join or unjoin a set of users for a queue. |
| [**PatchRoutingSettingsContactcenter**](#PatchRoutingSettingsContactcenter) | **Patch** /api/v2/routing/settings/contactcenter | Update Contact Center Settings |
| [**PatchRoutingSettingsTranscription**](#PatchRoutingSettingsTranscription) | **Patch** /api/v2/routing/settings/transcription | Patch Transcription Settings |
| [**PatchRoutingSkillgroup**](#PatchRoutingSkillgroup) | **Patch** /api/v2/routing/skillgroups/{skillGroupId} | Update skill group definition |
| [**PatchUserQueue**](#PatchUserQueue) | **Patch** /api/v2/users/{userId}/queues/{queueId} | Join or unjoin a queue for a user |
| [**PatchUserQueues**](#PatchUserQueues) | **Patch** /api/v2/users/{userId}/queues | Join or unjoin a set of queues for a user |
| [**PatchUserRoutinglanguage**](#PatchUserRoutinglanguage) | **Patch** /api/v2/users/{userId}/routinglanguages/{languageId} | Update an assigned routing language&#39;s proficiency |
| [**PatchUserRoutinglanguagesBulk**](#PatchUserRoutinglanguagesBulk) | **Patch** /api/v2/users/{userId}/routinglanguages/bulk | Assign multiple routing languages to a user. Max 50 routing languages in request body |
| [**PatchUserRoutingskillsBulk**](#PatchUserRoutingskillsBulk) | **Patch** /api/v2/users/{userId}/routingskills/bulk | Assign multiple routing skills to a user |
| [**PostAnalyticsQueuesObservationsQuery**](#PostAnalyticsQueuesObservationsQuery) | **Post** /api/v2/analytics/queues/observations/query | Query for queue observations |
| [**PostAnalyticsRoutingActivityQuery**](#PostAnalyticsRoutingActivityQuery) | **Post** /api/v2/analytics/routing/activity/query | Query for user activity observations |
| [**PostRoutingAssessments**](#PostRoutingAssessments) | **Post** /api/v2/routing/assessments | Create a benefit assessment. |
| [**PostRoutingAssessmentsJobs**](#PostRoutingAssessmentsJobs) | **Post** /api/v2/routing/assessments/jobs | Create a benefit assessment job. |
| [**PostRoutingEmailDomainRoutes**](#PostRoutingEmailDomainRoutes) | **Post** /api/v2/routing/email/domains/{domainName}/routes | Create a route |
| [**PostRoutingEmailDomainTestconnection**](#PostRoutingEmailDomainTestconnection) | **Post** /api/v2/routing/email/domains/{domainId}/testconnection | Tests the custom SMTP server integration connection set on this domain |
| [**PostRoutingEmailDomains**](#PostRoutingEmailDomains) | **Post** /api/v2/routing/email/domains | Create a domain |
| [**PostRoutingEmailOutboundDomains**](#PostRoutingEmailOutboundDomains) | **Post** /api/v2/routing/email/outbound/domains | Create a domain |
| [**PostRoutingEmailOutboundDomainsSimulated**](#PostRoutingEmailOutboundDomainsSimulated) | **Post** /api/v2/routing/email/outbound/domains/simulated | Create a simulated domain |
| [**PostRoutingLanguages**](#PostRoutingLanguages) | **Post** /api/v2/routing/languages | Create Language |
| [**PostRoutingPredictors**](#PostRoutingPredictors) | **Post** /api/v2/routing/predictors | Create a predictor. |
| [**PostRoutingQueueMembers**](#PostRoutingQueueMembers) | **Post** /api/v2/routing/queues/{queueId}/members | Bulk add or delete up to 100 queue members |
| [**PostRoutingQueueUsers**](#PostRoutingQueueUsers) | **Post** /api/v2/routing/queues/{queueId}/users | DEPRECATED: use POST /routing/queues/{queueId}/members.  Bulk add or delete up to 100 queue members. |
| [**PostRoutingQueueWrapupcodes**](#PostRoutingQueueWrapupcodes) | **Post** /api/v2/routing/queues/{queueId}/wrapupcodes | Add up to 100 wrap-up codes to a queue |
| [**PostRoutingQueues**](#PostRoutingQueues) | **Post** /api/v2/routing/queues | Create a queue |
| [**PostRoutingSkillgroupMembersDivisions**](#PostRoutingSkillgroupMembersDivisions) | **Post** /api/v2/routing/skillgroups/{skillGroupId}/members/divisions | Add or remove member divisions for this skill group. |
| [**PostRoutingSkillgroups**](#PostRoutingSkillgroups) | **Post** /api/v2/routing/skillgroups | Create a skill group |
| [**PostRoutingSkills**](#PostRoutingSkills) | **Post** /api/v2/routing/skills | Create Skill |
| [**PostRoutingSmsAddresses**](#PostRoutingSmsAddresses) | **Post** /api/v2/routing/sms/addresses | Provision an Address for SMS |
| [**PostRoutingSmsPhonenumbers**](#PostRoutingSmsPhonenumbers) | **Post** /api/v2/routing/sms/phonenumbers | Provision a phone number for SMS |
| [**PostRoutingSmsPhonenumbersAlphanumeric**](#PostRoutingSmsPhonenumbersAlphanumeric) | **Post** /api/v2/routing/sms/phonenumbers/alphanumeric | Provision an alphanumeric number for SMS |
| [**PostRoutingSmsPhonenumbersImport**](#PostRoutingSmsPhonenumbersImport) | **Post** /api/v2/routing/sms/phonenumbers/import | Imports a phone number for SMS |
| [**PostRoutingUtilizationLabels**](#PostRoutingUtilizationLabels) | **Post** /api/v2/routing/utilization/labels | Create a utilization label |
| [**PostRoutingUtilizationTags**](#PostRoutingUtilizationTags) | **Post** /api/v2/routing/utilization/tags | Create an utilization tag |
| [**PostRoutingWrapupcodes**](#PostRoutingWrapupcodes) | **Post** /api/v2/routing/wrapupcodes | Create a wrap-up code |
| [**PostUserRoutinglanguages**](#PostUserRoutinglanguages) | **Post** /api/v2/users/{userId}/routinglanguages | Assign a routing language to a user |
| [**PostUserRoutingskills**](#PostUserRoutingskills) | **Post** /api/v2/users/{userId}/routingskills | Assign a routing skill to a user |
| [**PutRoutingDirectroutingbackupSettingsMe**](#PutRoutingDirectroutingbackupSettingsMe) | **Put** /api/v2/routing/directroutingbackup/settings/me | Update the user&#39;s Direct Routing Backup settings. |
| [**PutRoutingEmailDomainRoute**](#PutRoutingEmailDomainRoute) | **Put** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Update a route |
| [**PutRoutingEmailDomainRouteIdentityresolution**](#PutRoutingEmailDomainRouteIdentityresolution) | **Put** /api/v2/routing/email/domains/{domainName}/routes/{routeId}/identityresolution | Update identity resolution settings for a route. |
| [**PutRoutingEmailOutboundDomainActivation**](#PutRoutingEmailOutboundDomainActivation) | **Put** /api/v2/routing/email/outbound/domains/{domainId}/activation | Request an activation status (cname + dkim) update of an outbound domain |
| [**PutRoutingMessageRecipient**](#PutRoutingMessageRecipient) | **Put** /api/v2/routing/message/recipients/{recipientId} | Update a recipient |
| [**PutRoutingQueue**](#PutRoutingQueue) | **Put** /api/v2/routing/queues/{queueId} | Update a queue |
| [**PutRoutingQueueIdentityresolution**](#PutRoutingQueueIdentityresolution) | **Put** /api/v2/routing/queues/{queueId}/identityresolution | Update Queue IdentityResolution Settings. |
| [**PutRoutingSettings**](#PutRoutingSettings) | **Put** /api/v2/routing/settings | Update an organization&#39;s routing settings |
| [**PutRoutingSettingsTranscription**](#PutRoutingSettingsTranscription) | **Put** /api/v2/routing/settings/transcription | Update Transcription Settings |
| [**PutRoutingSmsIdentityresolutionPhonenumber**](#PutRoutingSmsIdentityresolutionPhonenumber) | **Put** /api/v2/routing/sms/identityresolution/phonenumbers/{addressId} | Update an SMS identity resolution settings. |
| [**PutRoutingUserDirectroutingbackupSettings**](#PutRoutingUserDirectroutingbackupSettings) | **Put** /api/v2/routing/users/{userId}/directroutingbackup/settings | Update the user&#39;s Direct Routing Backup settings. |
| [**PutRoutingUserUtilization**](#PutRoutingUserUtilization) | **Put** /api/v2/routing/users/{userId}/utilization | Update the user&#39;s max utilization settings.  Include only those media types requiring custom configuration. |
| [**PutRoutingUtilization**](#PutRoutingUtilization) | **Put** /api/v2/routing/utilization | Update the organization-wide max utilization settings.  Include only those media types requiring custom configuration. |
| [**PutRoutingUtilizationLabel**](#PutRoutingUtilizationLabel) | **Put** /api/v2/routing/utilization/labels/{labelId} | Update a utilization label |
| [**PutRoutingWrapupcode**](#PutRoutingWrapupcode) | **Put** /api/v2/routing/wrapupcodes/{codeId} | Update wrap-up code |
| [**PutUserRoutingskill**](#PutUserRoutingskill) | **Put** /api/v2/users/{userId}/routingskills/{skillId} | Update an assigned routing skill&#39;s proficiency |
| [**PutUserRoutingskillsBulk**](#PutUserRoutingskillsBulk) | **Put** /api/v2/users/{userId}/routingskills/bulk | Assign multiple routing skills to a user, replacing any current assignments |



## DeleteRoutingAssessment

> void DeleteRoutingAssessment (string assessmentId)


Delete single benefit assessment.

Requires ANY permissions: 

* routing:assessment:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingAssessmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var assessmentId = assessmentId_example;  // string | Benefit Assessment ID

            try
            { 
                // Delete single benefit assessment.
                apiInstance.DeleteRoutingAssessment(assessmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingAssessment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assessmentId** | **string**| Benefit Assessment ID |  |

### Return type

void (empty response body)


## DeleteRoutingDirectroutingbackupSettingsMe

> void DeleteRoutingDirectroutingbackupSettingsMe ()


Delete the user's Direct Routing Backup settings and revert to the Direct Routing Queue default.

Requires ANY permissions: 

* routing:directRoutingBackup:selfDelete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingDirectroutingbackupSettingsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Delete the user's Direct Routing Backup settings and revert to the Direct Routing Queue default.
                apiInstance.DeleteRoutingDirectroutingbackupSettingsMe();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingDirectroutingbackupSettingsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## DeleteRoutingEmailDomain

> void DeleteRoutingEmailDomain (string domainId)


Delete a domain

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingEmailDomainExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID

            try
            { 
                // Delete a domain
                apiInstance.DeleteRoutingEmailDomain(domainId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingEmailDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |

### Return type

void (empty response body)


## DeleteRoutingEmailDomainRoute

> void DeleteRoutingEmailDomainRoute (string domainName, string routeId)


Delete a route

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingEmailDomainRouteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var routeId = routeId_example;  // string | route ID

            try
            { 
                // Delete a route
                apiInstance.DeleteRoutingEmailDomainRoute(domainName, routeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingEmailDomainRoute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |

### Return type

void (empty response body)


## DeleteRoutingEmailOutboundDomain

> void DeleteRoutingEmailOutboundDomain (string domainId)


Delete an outbound domain

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingEmailOutboundDomainExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID

            try
            { 
                // Delete an outbound domain
                apiInstance.DeleteRoutingEmailOutboundDomain(domainId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingEmailOutboundDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |

### Return type

void (empty response body)


## DeleteRoutingLanguage

> void DeleteRoutingLanguage (string languageId)


Delete a routing language

Requires ANY permissions: 

* routing:skill:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingLanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var languageId = languageId_example;  // string | Language ID

            try
            { 
                // Delete a routing language
                apiInstance.DeleteRoutingLanguage(languageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **languageId** | **string**| Language ID |  |

### Return type

void (empty response body)


## DeleteRoutingPredictor

> void DeleteRoutingPredictor (string predictorId)


Delete single predictor.

Requires ALL permissions: 

* routing:predictor:delete
* routing:queue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingPredictorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var predictorId = predictorId_example;  // string | Predictor ID

            try
            { 
                // Delete single predictor.
                apiInstance.DeleteRoutingPredictor(predictorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingPredictor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **predictorId** | **string**| Predictor ID |  |

### Return type

void (empty response body)


## DeleteRoutingQueue

> void DeleteRoutingQueue (string queueId, bool? forceDelete = null)


Delete a queue

Requires ALL permissions: 

* routing:queue:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingQueueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var forceDelete = true;  // bool? | forceDelete (optional) 

            try
            { 
                // Delete a queue
                apiInstance.DeleteRoutingQueue(queueId, forceDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **forceDelete** | **bool?**| forceDelete | [optional]  |

### Return type

void (empty response body)


## DeleteRoutingQueueMember

> void DeleteRoutingQueueMember (string queueId, string memberId)


Delete a queue member.

Requires ANY permissions: 

* routing:queue:edit
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingQueueMemberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member ID

            try
            { 
                // Delete a queue member.
                apiInstance.DeleteRoutingQueueMember(queueId, memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingQueueMember: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |

### Return type

void (empty response body)


## DeleteRoutingQueueUser

> void DeleteRoutingQueueUser (string queueId, string memberId)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

DEPRECATED: use DELETE /routing/queues/{queueId}/members/{memberId}.  Delete queue member.

Requires ANY permissions: 

* routing:queue:edit
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingQueueUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member ID

            try
            { 
                // DEPRECATED: use DELETE /routing/queues/{queueId}/members/{memberId}.  Delete queue member.
                apiInstance.DeleteRoutingQueueUser(queueId, memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingQueueUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |

### Return type

void (empty response body)


## DeleteRoutingQueueWrapupcode

> void DeleteRoutingQueueWrapupcode (string queueId, string codeId)


Delete a wrap-up code from a queue

Requires ALL permissions: 

* routing:queue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingQueueWrapupcodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var codeId = codeId_example;  // string | Code ID

            try
            { 
                // Delete a wrap-up code from a queue
                apiInstance.DeleteRoutingQueueWrapupcode(queueId, codeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingQueueWrapupcode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **codeId** | **string**| Code ID |  |

### Return type

void (empty response body)


## DeleteRoutingSettings

> void DeleteRoutingSettings ()


Delete an organization's routing settings

Requires ANY permissions: 

* routing:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Delete an organization's routing settings
                apiInstance.DeleteRoutingSettings();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## DeleteRoutingSkill

> void DeleteRoutingSkill (string skillId)


Delete Routing Skill

Requires ALL permissions: 

* routing:skill:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingSkillExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var skillId = skillId_example;  // string | Skill ID

            try
            { 
                // Delete Routing Skill
                apiInstance.DeleteRoutingSkill(skillId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingSkill: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillId** | **string**| Skill ID |  |

### Return type

void (empty response body)


## DeleteRoutingSkillgroup

> void DeleteRoutingSkillgroup (string skillGroupId)


Remove skill group definition

Requires ANY permissions: 

* routing:skillGroup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingSkillgroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var skillGroupId = skillGroupId_example;  // string | Skill Group ID

            try
            { 
                // Remove skill group definition
                apiInstance.DeleteRoutingSkillgroup(skillGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingSkillgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillGroupId** | **string**| Skill Group ID |  |

### Return type

void (empty response body)


## DeleteRoutingSmsAddress

> void DeleteRoutingSmsAddress (string addressId)


Delete an Address by Id for SMS

Requires ALL permissions: 

* sms:phoneNumber:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingSmsAddressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var addressId = addressId_example;  // string | Address ID

            try
            { 
                // Delete an Address by Id for SMS
                apiInstance.DeleteRoutingSmsAddress(addressId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingSmsAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |

### Return type

void (empty response body)


## DeleteRoutingSmsPhonenumber

> void DeleteRoutingSmsPhonenumber (string phoneNumberId)


Delete a phone number provisioned for SMS.

Requires ALL permissions: 

* sms:phoneNumber:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingSmsPhonenumberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var phoneNumberId = phoneNumberId_example;  // string | phone number

            try
            { 
                // Delete a phone number provisioned for SMS.
                apiInstance.DeleteRoutingSmsPhonenumber(phoneNumberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingSmsPhonenumber: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneNumberId** | **string**| phone number |  |

### Return type

void (empty response body)


## DeleteRoutingUserDirectroutingbackupSettings

> void DeleteRoutingUserDirectroutingbackupSettings (string userId)


Delete the user's Direct Routing Backup settings and revert to the Direct Routing Queue default.

Requires ANY permissions: 

* routing:directRoutingBackup:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingUserDirectroutingbackupSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Delete the user's Direct Routing Backup settings and revert to the Direct Routing Queue default.
                apiInstance.DeleteRoutingUserDirectroutingbackupSettings(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingUserDirectroutingbackupSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |

### Return type

void (empty response body)


## DeleteRoutingUserUtilization

> void DeleteRoutingUserUtilization (string userId)


Delete the user's max utilization settings and revert to the organization-wide default.

Requires ANY permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingUserUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Delete the user's max utilization settings and revert to the organization-wide default.
                apiInstance.DeleteRoutingUserUtilization(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingUserUtilization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |

### Return type

void (empty response body)


## DeleteRoutingUtilization

> void DeleteRoutingUtilization ()


Delete the organization-wide max utilization settings and revert to the system default.

Requires ALL permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Delete the organization-wide max utilization settings and revert to the system default.
                apiInstance.DeleteRoutingUtilization();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingUtilization: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

void (empty response body)


## DeleteRoutingUtilizationLabel

> void DeleteRoutingUtilizationLabel (string labelId, bool? forceDelete = null)


Delete a utilization label

Requires ALL permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingUtilizationLabelExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var labelId = labelId_example;  // string | Utilization Label ID
            var forceDelete = true;  // bool? | Remove all label usages (if found) without warning (optional)  (default to false)

            try
            { 
                // Delete a utilization label
                apiInstance.DeleteRoutingUtilizationLabel(labelId, forceDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingUtilizationLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **labelId** | **string**| Utilization Label ID |  |
| **forceDelete** | **bool?**| Remove all label usages (if found) without warning | [optional] [default to false] |

### Return type

void (empty response body)


## DeleteRoutingUtilizationTag

> void DeleteRoutingUtilizationTag (string tagId, bool? forceDelete = null)


Delete an utilization tag

DeleteRoutingUtilizationTag is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingUtilizationTagExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var tagId = tagId_example;  // string | Utilization Tag ID
            var forceDelete = true;  // bool? | Remove all tag usages (if found) without warning (optional)  (default to false)

            try
            { 
                // Delete an utilization tag
                apiInstance.DeleteRoutingUtilizationTag(tagId, forceDelete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingUtilizationTag: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tagId** | **string**| Utilization Tag ID |  |
| **forceDelete** | **bool?**| Remove all tag usages (if found) without warning | [optional] [default to false] |

### Return type

void (empty response body)


## DeleteRoutingWrapupcode

> void DeleteRoutingWrapupcode (string codeId)


Delete wrap-up code

Requires ALL permissions: 

* routing:wrapupCode:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteRoutingWrapupcodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var codeId = codeId_example;  // string | Wrapup Code ID

            try
            { 
                // Delete wrap-up code
                apiInstance.DeleteRoutingWrapupcode(codeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteRoutingWrapupcode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |

### Return type

void (empty response body)


## DeleteUserRoutinglanguage

> void DeleteUserRoutinglanguage (string userId, string languageId)


Remove a routing language from a user

Requires ANY permissions: 

* routing:skill:assign
* routing:language:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserRoutinglanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var languageId = languageId_example;  // string | languageId

            try
            { 
                // Remove a routing language from a user
                apiInstance.DeleteUserRoutinglanguage(userId, languageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteUserRoutinglanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **languageId** | **string**| languageId |  |

### Return type

void (empty response body)


## DeleteUserRoutingskill

> void DeleteUserRoutingskill (string userId, string skillId)


Remove a routing skill from a user

Requires ALL permissions: 

* routing:skill:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteUserRoutingskillExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var skillId = skillId_example;  // string | skillId

            try
            { 
                // Remove a routing skill from a user
                apiInstance.DeleteUserRoutingskill(userId, skillId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteUserRoutingskill: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **skillId** | **string**| skillId |  |

### Return type

void (empty response body)


## GetRoutingAssessment

> [**BenefitAssessment**](BenefitAssessment) GetRoutingAssessment (string assessmentId)


Retrieve a single benefit assessment.

Requires ANY permissions: 

* routing:assessment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingAssessmentExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var assessmentId = assessmentId_example;  // string | Benefit Assessment ID

            try
            { 
                // Retrieve a single benefit assessment.
                BenefitAssessment result = apiInstance.GetRoutingAssessment(assessmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingAssessment: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **assessmentId** | **string**| Benefit Assessment ID |  |

### Return type

[**BenefitAssessment**](BenefitAssessment)


## GetRoutingAssessments

> [**AssessmentListing**](AssessmentListing) GetRoutingAssessments (string before = null, string after = null, string limit = null, string pageSize = null, List<string> queueId = null)


Retrieve all benefit assessments.

Requires ANY permissions: 

* routing:queue:view
* routing:assessment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingAssessmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var queueId = new List<string>(); // List<string> | Queue ID(s) to filter assessments by. (optional) 

            try
            { 
                // Retrieve all benefit assessments.
                AssessmentListing result = apiInstance.GetRoutingAssessments(before, after, limit, pageSize, queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingAssessments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. Deprecated in favour of pageSize | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **queueId** | [**List<string>**](string)| Queue ID(s) to filter assessments by. | [optional]  |

### Return type

[**AssessmentListing**](AssessmentListing)


## GetRoutingAssessmentsJob

> [**BenefitAssessmentJob**](BenefitAssessmentJob) GetRoutingAssessmentsJob (string jobId)


Retrieve a single benefit assessments job.

Requires ANY permissions: 

* routing:assessment:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingAssessmentsJobExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var jobId = jobId_example;  // string | Benefit Assessment Job ID

            try
            { 
                // Retrieve a single benefit assessments job.
                BenefitAssessmentJob result = apiInstance.GetRoutingAssessmentsJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingAssessmentsJob: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **jobId** | **string**| Benefit Assessment Job ID |  |

### Return type

[**BenefitAssessmentJob**](BenefitAssessmentJob)


## GetRoutingAssessmentsJobs

> [**AssessmentJobListing**](AssessmentJobListing) GetRoutingAssessmentsJobs (List<string> divisionId = null)


Retrieve all benefit assessment jobs.

Requires ANY permissions: 

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
    public class GetRoutingAssessmentsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var divisionId = new List<string>(); // List<string> | Division ID(s) to filter assessment jobs by. (optional) 

            try
            { 
                // Retrieve all benefit assessment jobs.
                AssessmentJobListing result = apiInstance.GetRoutingAssessmentsJobs(divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingAssessmentsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **divisionId** | [**List<string>**](string)| Division ID(s) to filter assessment jobs by. | [optional]  |

### Return type

[**AssessmentJobListing**](AssessmentJobListing)


## GetRoutingAvailablemediatypes

> [**AvailableMediaTypeEntityListing**](AvailableMediaTypeEntityListing) GetRoutingAvailablemediatypes ()


Get available media types

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
    public class GetRoutingAvailablemediatypesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get available media types
                AvailableMediaTypeEntityListing result = apiInstance.GetRoutingAvailablemediatypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingAvailablemediatypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**AvailableMediaTypeEntityListing**](AvailableMediaTypeEntityListing)


## GetRoutingDirectroutingbackupSettingsMe

> [**AgentDirectRoutingBackupSettings**](AgentDirectRoutingBackupSettings) GetRoutingDirectroutingbackupSettingsMe ()


Get the user's Direct Routing Backup settings.

Requires ANY permissions: 

* routing:directRoutingBackup:selfView

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingDirectroutingbackupSettingsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get the user's Direct Routing Backup settings.
                AgentDirectRoutingBackupSettings result = apiInstance.GetRoutingDirectroutingbackupSettingsMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingDirectroutingbackupSettingsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**AgentDirectRoutingBackupSettings**](AgentDirectRoutingBackupSettings)


## GetRoutingEmailDomain

> [**InboundDomain**](InboundDomain) GetRoutingEmailDomain (string domainId)


Get domain

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailDomainExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID

            try
            { 
                // Get domain
                InboundDomain result = apiInstance.GetRoutingEmailDomain(domainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |

### Return type

[**InboundDomain**](InboundDomain)


## GetRoutingEmailDomainRoute

> [**InboundRoute**](InboundRoute) GetRoutingEmailDomainRoute (string domainName, string routeId)


Get a route

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailDomainRouteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var routeId = routeId_example;  // string | route ID

            try
            { 
                // Get a route
                InboundRoute result = apiInstance.GetRoutingEmailDomainRoute(domainName, routeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailDomainRoute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |

### Return type

[**InboundRoute**](InboundRoute)


## GetRoutingEmailDomainRouteIdentityresolution

> [**IdentityResolutionConfig**](IdentityResolutionConfig) GetRoutingEmailDomainRouteIdentityresolution (string domainName, string routeId)


Get a route identity resolution setting.

GetRoutingEmailDomainRouteIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* routing:email:manage
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
    public class GetRoutingEmailDomainRouteIdentityresolutionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var routeId = routeId_example;  // string | route ID

            try
            { 
                // Get a route identity resolution setting.
                IdentityResolutionConfig result = apiInstance.GetRoutingEmailDomainRouteIdentityresolution(domainName, routeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailDomainRouteIdentityresolution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## GetRoutingEmailDomainRoutes

> [**InboundRouteEntityListing**](InboundRouteEntityListing) GetRoutingEmailDomainRoutes (string domainName, int? pageSize = null, int? pageNumber = null, string pattern = null)


Get routes

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailDomainRoutesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pattern = pattern_example;  // string | Filter routes by the route's pattern property (optional) 

            try
            { 
                // Get routes
                InboundRouteEntityListing result = apiInstance.GetRoutingEmailDomainRoutes(domainName, pageSize, pageNumber, pattern);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailDomainRoutes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pattern** | **string**| Filter routes by the route&#39;s pattern property | [optional]  |

### Return type

[**InboundRouteEntityListing**](InboundRouteEntityListing)


## GetRoutingEmailDomains

> [**InboundDomainEntityListing**](InboundDomainEntityListing) GetRoutingEmailDomains (int? pageSize = null, int? pageNumber = null, bool? excludeStatus = null, string filter = null)


Get domains

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailDomainsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var excludeStatus = true;  // bool? | Exclude MX record data (optional)  (default to false)
            var filter = filter_example;  // string | Optional search filter that, if defined, use the **filter** syntax, eg: **mySearchedPattern**. Note that **** is considered no filter. (optional) 

            try
            { 
                // Get domains
                InboundDomainEntityListing result = apiInstance.GetRoutingEmailDomains(pageSize, pageNumber, excludeStatus, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailDomains: " + e.Message );
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
| **excludeStatus** | **bool?**| Exclude MX record data | [optional] [default to false] |
| **filter** | **string**| Optional search filter that, if defined, use the **filter** syntax, eg: **mySearchedPattern**. Note that **** is considered no filter. | [optional]  |

### Return type

[**InboundDomainEntityListing**](InboundDomainEntityListing)


## GetRoutingEmailOutboundDomain

> [**OutboundDomain**](OutboundDomain) GetRoutingEmailOutboundDomain (string domainId)


Get domain

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailOutboundDomainExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID

            try
            { 
                // Get domain
                OutboundDomain result = apiInstance.GetRoutingEmailOutboundDomain(domainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailOutboundDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |

### Return type

[**OutboundDomain**](OutboundDomain)


## GetRoutingEmailOutboundDomainActivation

> [**EmailOutboundDomainResult**](EmailOutboundDomainResult) GetRoutingEmailOutboundDomainActivation (string domainId)


Get activation status (cname + dkim) of an outbound domain

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailOutboundDomainActivationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID

            try
            { 
                // Get activation status (cname + dkim) of an outbound domain
                EmailOutboundDomainResult result = apiInstance.GetRoutingEmailOutboundDomainActivation(domainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailOutboundDomainActivation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |

### Return type

[**EmailOutboundDomainResult**](EmailOutboundDomainResult)


## GetRoutingEmailOutboundDomainSearch

> [**OutboundDomain**](OutboundDomain) GetRoutingEmailOutboundDomainSearch (string domainId)


Search a domain across organizations

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailOutboundDomainSearchExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID

            try
            { 
                // Search a domain across organizations
                OutboundDomain result = apiInstance.GetRoutingEmailOutboundDomainSearch(domainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailOutboundDomainSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |

### Return type

[**OutboundDomain**](OutboundDomain)


## GetRoutingEmailOutboundDomains

> [**OutboundDomainEntityListing**](OutboundDomainEntityListing) GetRoutingEmailOutboundDomains (int? pageSize = null, int? pageNumber = null, string filter = null)


Get outbound domains

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailOutboundDomainsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filter = filter_example;  // string | Optional search filter that, if defined, use the **filter** syntax, eg: **mySearchedPattern**. Note that **** is considered no filter. (optional) 

            try
            { 
                // Get outbound domains
                OutboundDomainEntityListing result = apiInstance.GetRoutingEmailOutboundDomains(pageSize, pageNumber, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailOutboundDomains: " + e.Message );
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
| **filter** | **string**| Optional search filter that, if defined, use the **filter** syntax, eg: **mySearchedPattern**. Note that **** is considered no filter. | [optional]  |

### Return type

[**OutboundDomainEntityListing**](OutboundDomainEntityListing)


## GetRoutingEmailSetup

> [**EmailSetup**](EmailSetup) GetRoutingEmailSetup ()


Get email setup

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingEmailSetupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get email setup
                EmailSetup result = apiInstance.GetRoutingEmailSetup();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingEmailSetup: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**EmailSetup**](EmailSetup)


## GetRoutingLanguage

> [**Language**](Language) GetRoutingLanguage (string languageId)


Get a routing language

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
    public class GetRoutingLanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var languageId = languageId_example;  // string | Language ID

            try
            { 
                // Get a routing language
                Language result = apiInstance.GetRoutingLanguage(languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **languageId** | **string**| Language ID |  |

### Return type

[**Language**](Language)


## GetRoutingLanguages

> [**LanguageEntityListing**](LanguageEntityListing) GetRoutingLanguages (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, List<string> id = null)


Get the list of supported languages.

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
    public class GetRoutingLanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | id (optional) 

            try
            { 
                // Get the list of supported languages.
                LanguageEntityListing result = apiInstance.GetRoutingLanguages(pageSize, pageNumber, sortOrder, name, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingLanguages: " + e.Message );
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
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string)| id | [optional]  |

### Return type

[**LanguageEntityListing**](LanguageEntityListing)


## GetRoutingMessageRecipient

> [**Recipient**](Recipient) GetRoutingMessageRecipient (string recipientId)


Get a recipient

Requires ALL permissions: 

* routing:message:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingMessageRecipientExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var recipientId = recipientId_example;  // string | Recipient ID

            try
            { 
                // Get a recipient
                Recipient result = apiInstance.GetRoutingMessageRecipient(recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingMessageRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recipientId** | **string**| Recipient ID |  |

### Return type

[**Recipient**](Recipient)


## GetRoutingMessageRecipients

> [**RecipientListing**](RecipientListing) GetRoutingMessageRecipients (string messengerType = null, string name = null, int? pageSize = null, int? pageNumber = null)


Get recipients

Requires ALL permissions: 

* routing:message:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingMessageRecipientsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var messengerType = messengerType_example;  // string | Messenger Type (optional) 
            var name = name_example;  // string | Recipient Name (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get recipients
                RecipientListing result = apiInstance.GetRoutingMessageRecipients(messengerType, name, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingMessageRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messengerType** | **string**| Messenger Type | [optional] <br />**Values**: sms, facebook, twitter, whatsapp, open, instagram, apple |
| **name** | **string**| Recipient Name | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**RecipientListing**](RecipientListing)


## GetRoutingPredictor

> [**Predictor**](Predictor) GetRoutingPredictor (string predictorId)


Retrieve a single predictor.

Requires ANY permissions: 

* routing:predictor:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingPredictorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var predictorId = predictorId_example;  // string | Predictor ID

            try
            { 
                // Retrieve a single predictor.
                Predictor result = apiInstance.GetRoutingPredictor(predictorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingPredictor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **predictorId** | **string**| Predictor ID |  |

### Return type

[**Predictor**](Predictor)


## GetRoutingPredictorModelFeatures

> [**PredictorModelFeatureListing**](PredictorModelFeatureListing) GetRoutingPredictorModelFeatures (string predictorId, string modelId)


Retrieve Predictor Model Features.

Requires ALL permissions: 

* routing:predictorModelFeature:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingPredictorModelFeaturesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var predictorId = predictorId_example;  // string | Predictor ID
            var modelId = modelId_example;  // string | Model ID

            try
            { 
                // Retrieve Predictor Model Features.
                PredictorModelFeatureListing result = apiInstance.GetRoutingPredictorModelFeatures(predictorId, modelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingPredictorModelFeatures: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **predictorId** | **string**| Predictor ID |  |
| **modelId** | **string**| Model ID |  |

### Return type

[**PredictorModelFeatureListing**](PredictorModelFeatureListing)


## GetRoutingPredictorModels

> [**PredictorModels**](PredictorModels) GetRoutingPredictorModels (string predictorId)


Retrieve Predictor Models and Top Features.

Requires ALL permissions: 

* routing:predictorModel:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingPredictorModelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var predictorId = predictorId_example;  // string | Predictor ID

            try
            { 
                // Retrieve Predictor Models and Top Features.
                PredictorModels result = apiInstance.GetRoutingPredictorModels(predictorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingPredictorModels: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **predictorId** | **string**| Predictor ID |  |

### Return type

[**PredictorModels**](PredictorModels)


## GetRoutingPredictors

> [**PredictorListing**](PredictorListing) GetRoutingPredictors (string before = null, string after = null, string limit = null, string pageSize = null, List<string> queueId = null)


Retrieve all predictors.

Requires ANY permissions: 

* routing:predictor:view
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
    public class GetRoutingPredictorsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var before = before_example;  // string | The cursor that points to the start of the set of entities that has been returned. (optional) 
            var after = after_example;  // string | The cursor that points to the end of the set of entities that has been returned. (optional) 
            var limit = limit_example;  // string | Number of entities to return. Maximum of 200. Deprecated in favour of pageSize (optional) 
            var pageSize = pageSize_example;  // string | Number of entities to return. Maximum of 200. (optional) 
            var queueId = new List<string>(); // List<string> | Comma-separated list of queue Ids to filter by. (optional) 

            try
            { 
                // Retrieve all predictors.
                PredictorListing result = apiInstance.GetRoutingPredictors(before, after, limit, pageSize, queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingPredictors: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **before** | **string**| The cursor that points to the start of the set of entities that has been returned. | [optional]  |
| **after** | **string**| The cursor that points to the end of the set of entities that has been returned. | [optional]  |
| **limit** | **string**| Number of entities to return. Maximum of 200. Deprecated in favour of pageSize | [optional]  |
| **pageSize** | **string**| Number of entities to return. Maximum of 200. | [optional]  |
| **queueId** | [**List<string>**](string)| Comma-separated list of queue Ids to filter by. | [optional]  |

### Return type

[**PredictorListing**](PredictorListing)


## GetRoutingPredictorsKeyperformanceindicators

> [**List&lt;KeyPerformanceIndicator&gt;**](KeyPerformanceIndicator) GetRoutingPredictorsKeyperformanceindicators (string kpiGroup = null, List<string> expand = null)


Get a list of Key Performance Indicators

Requires ANY permissions: 

* routing:keyPerformanceIndicator:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingPredictorsKeyperformanceindicatorsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var kpiGroup = kpiGroup_example;  // string | The Group of Key Performance Indicators to return (optional) 
            var expand = new List<string>(); // List<string> | Parameter to request additional data to return in KPI payload (optional) 

            try
            { 
                // Get a list of Key Performance Indicators
                List<KeyPerformanceIndicator> result = apiInstance.GetRoutingPredictorsKeyperformanceindicators(kpiGroup, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingPredictorsKeyperformanceindicators: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **kpiGroup** | **string**| The Group of Key Performance Indicators to return | [optional] <br />**Values**: Standard, Custom |
| **expand** | [**List<string>**](string)| Parameter to request additional data to return in KPI payload | [optional] <br />**Values**: queues |

### Return type

[**List<KeyPerformanceIndicator>**](KeyPerformanceIndicator)


## GetRoutingQueue

> [**Queue**](Queue) GetRoutingQueue (string queueId)


Get details about this queue.

Requires ALL permissions: 

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
    public class GetRoutingQueueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID

            try
            { 
                // Get details about this queue.
                Queue result = apiInstance.GetRoutingQueue(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |

### Return type

[**Queue**](Queue)


## GetRoutingQueueAssistant

> [**AssistantQueue**](AssistantQueue) GetRoutingQueueAssistant (string queueId, string expand = null)


Get an assistant associated with a queue.

Requires ALL permissions: 

* assistants:queue:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueueAssistantExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var expand = expand_example;  // string | Which fields, if any, to expand. (optional) 

            try
            { 
                // Get an assistant associated with a queue.
                AssistantQueue result = apiInstance.GetRoutingQueueAssistant(queueId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueAssistant: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **expand** | **string**| Which fields, if any, to expand. | [optional] <br />**Values**: assistant |

### Return type

[**AssistantQueue**](AssistantQueue)


## GetRoutingQueueComparisonperiod

> [**ComparisonPeriod**](ComparisonPeriod) GetRoutingQueueComparisonperiod (string queueId, string comparisonPeriodId)


Get a Comparison Period.

Requires ALL permissions: 

* routing:comparisonPeriod:view
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
    public class GetRoutingQueueComparisonperiodExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue id
            var comparisonPeriodId = comparisonPeriodId_example;  // string | ComparisonPeriod id

            try
            { 
                // Get a Comparison Period.
                ComparisonPeriod result = apiInstance.GetRoutingQueueComparisonperiod(queueId, comparisonPeriodId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueComparisonperiod: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue id |  |
| **comparisonPeriodId** | **string**| ComparisonPeriod id |  |

### Return type

[**ComparisonPeriod**](ComparisonPeriod)


## GetRoutingQueueComparisonperiods

> [**ComparisonPeriodListing**](ComparisonPeriodListing) GetRoutingQueueComparisonperiods (string queueId)


Get list of comparison periods

Requires ALL permissions: 

* routing:comparisonPeriod:view
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
    public class GetRoutingQueueComparisonperiodsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue id

            try
            { 
                // Get list of comparison periods
                ComparisonPeriodListing result = apiInstance.GetRoutingQueueComparisonperiods(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueComparisonperiods: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue id |  |

### Return type

[**ComparisonPeriodListing**](ComparisonPeriodListing)


## GetRoutingQueueEstimatedwaittime

> [**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions) GetRoutingQueueEstimatedwaittime (string queueId, string conversationId = null)


Get Estimated Wait Time

Requires ALL permissions: 

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
    public class GetRoutingQueueEstimatedwaittimeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | queueId
            var conversationId = conversationId_example;  // string | conversationId (optional) 

            try
            { 
                // Get Estimated Wait Time
                EstimatedWaitTimePredictions result = apiInstance.GetRoutingQueueEstimatedwaittime(queueId, conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueEstimatedwaittime: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| queueId |  |
| **conversationId** | **string**| conversationId | [optional]  |

### Return type

[**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions)


## GetRoutingQueueIdentityresolution

> [**IdentityResolutionQueueConfig**](IdentityResolutionQueueConfig) GetRoutingQueueIdentityresolution (string queueId)


Get Queue IdentityResolution Settings.

GetRoutingQueueIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* routing:queue:view
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
    public class GetRoutingQueueIdentityresolutionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID

            try
            { 
                // Get Queue IdentityResolution Settings.
                IdentityResolutionQueueConfig result = apiInstance.GetRoutingQueueIdentityresolution(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueIdentityresolution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |

### Return type

[**IdentityResolutionQueueConfig**](IdentityResolutionQueueConfig)


## GetRoutingQueueMediatypeEstimatedwaittime

> [**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions) GetRoutingQueueMediatypeEstimatedwaittime (string queueId, string mediaType, string labelId = null)


Get Estimated Wait Time

Requires ALL permissions: 

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
    public class GetRoutingQueueMediatypeEstimatedwaittimeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | queueId
            var mediaType = mediaType_example;  // string | mediaType
            var labelId = labelId_example;  // string | Unique id that represents the interaction label used with media type for EWT calculation (optional) 

            try
            { 
                // Get Estimated Wait Time
                EstimatedWaitTimePredictions result = apiInstance.GetRoutingQueueMediatypeEstimatedwaittime(queueId, mediaType, labelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueMediatypeEstimatedwaittime: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| queueId |  |
| **mediaType** | **string**| mediaType | <br />**Values**: all, call, chat, callback, email, videoComm, message |
| **labelId** | **string**| Unique id that represents the interaction label used with media type for EWT calculation | [optional]  |

### Return type

[**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions)


## GetRoutingQueueMembers

> [**QueueMemberEntityListing**](QueueMemberEntityListing) GetRoutingQueueMembers (string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, List<string> expand = null, string name = null, List<string> profileSkills = null, List<string> skills = null, List<string> languages = null, List<string> routingStatus = null, List<string> presence = null, string memberBy = null, bool? joined = null)


Get the members of this queue.

Requires ANY permissions: 

* routing:queue:view
* routing:queue:edit
* routing:queue:readonly
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueueMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? | Max value is 100 (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Note: results are sorted by name. (optional)  (default to asc)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 
            var name = name_example;  // string | Filter by queue member name (contains-style search) (optional) 
            var profileSkills = new List<string>(); // List<string> | Filter by profile skill (contains-style search) (optional) 
            var skills = new List<string>(); // List<string> | Filter by skill (contains-style search) (optional) 
            var languages = new List<string>(); // List<string> | Filter by language (contains-style search) (optional) 
            var routingStatus = new List<string>(); // List<string> | Filter by routing status (optional) 
            var presence = new List<string>(); // List<string> | Filter by presence (optional) 
            var memberBy = memberBy_example;  // string | Filter by member type (optional) 
            var joined = joined_example;  // bool? | Filter by joined status (optional) 

            try
            { 
                // Get the members of this queue.
                QueueMemberEntityListing result = apiInstance.GetRoutingQueueMembers(queueId, pageNumber, pageSize, sortOrder, expand, name, profileSkills, skills, languages, routingStatus, presence, memberBy, joined);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**| Max value is 100 | [optional] [default to 25] |
| **sortOrder** | **string**| Note: results are sorted by name. | [optional] [default to asc]<br />**Values**: asc, desc |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, externalContactsSettings, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin, dateWelcomeSent |
| **name** | **string**| Filter by queue member name (contains-style search) | [optional]  |
| **profileSkills** | [**List<string>**](string)| Filter by profile skill (contains-style search) | [optional]  |
| **skills** | [**List<string>**](string)| Filter by skill (contains-style search) | [optional]  |
| **languages** | [**List<string>**](string)| Filter by language (contains-style search) | [optional]  |
| **routingStatus** | [**List<string>**](string)| Filter by routing status | [optional]  |
| **presence** | [**List<string>**](string)| Filter by presence | [optional]  |
| **memberBy** | **string**| Filter by member type | [optional] <br />**Values**: user, group |
| **joined** | **bool?**| Filter by joined status | [optional] <br />**Values**: true, false |

### Return type

[**QueueMemberEntityListing**](QueueMemberEntityListing)


## GetRoutingQueueUsers

> [**QueueMemberEntityListingV1**](QueueMemberEntityListingV1) GetRoutingQueueUsers (string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, List<string> expand = null, bool? joined = null, string name = null, List<string> profileSkills = null, List<string> skills = null, List<string> languages = null, List<string> routingStatus = null, List<string> presence = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

DEPRECATED: use GET /routing/queues/{queueId}/members.  Get the members of this queue.

Requires ANY permissions: 

* routing:queue:view
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueueUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? | Max value is 100 (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Note: results are sorted by name. (optional)  (default to asc)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 
            var joined = true;  // bool? | Filter by joined status (optional) 
            var name = name_example;  // string | Filter by queue member name (optional) 
            var profileSkills = new List<string>(); // List<string> | Filter by profile skill (optional) 
            var skills = new List<string>(); // List<string> | Filter by skill (optional) 
            var languages = new List<string>(); // List<string> | Filter by language (optional) 
            var routingStatus = new List<string>(); // List<string> | Filter by routing status (optional) 
            var presence = new List<string>(); // List<string> | Filter by presence (optional) 

            try
            { 
                // DEPRECATED: use GET /routing/queues/{queueId}/members.  Get the members of this queue.
                QueueMemberEntityListingV1 result = apiInstance.GetRoutingQueueUsers(queueId, pageNumber, pageSize, sortOrder, expand, joined, name, profileSkills, skills, languages, routingStatus, presence);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**| Max value is 100 | [optional] [default to 25] |
| **sortOrder** | **string**| Note: results are sorted by name. | [optional] [default to asc]<br />**Values**: asc, desc |
| **expand** | [**List<string>**](string)| Which fields, if any, to expand. | [optional] <br />**Values**: routingStatus, presence, integrationPresence, conversationSummary, outOfOffice, geolocation, station, authorization, lasttokenissued, authorization.unusedRoles, team, workPlanBidRanks, externalContactsSettings, profileSkills, certifications, locations, groups, skills, languages, languagePreference, employerInfo, biography, dateLastLogin, dateWelcomeSent |
| **joined** | **bool?**| Filter by joined status | [optional]  |
| **name** | **string**| Filter by queue member name | [optional]  |
| **profileSkills** | [**List<string>**](string)| Filter by profile skill | [optional]  |
| **skills** | [**List<string>**](string)| Filter by skill | [optional]  |
| **languages** | [**List<string>**](string)| Filter by language | [optional]  |
| **routingStatus** | [**List<string>**](string)| Filter by routing status | [optional]  |
| **presence** | [**List<string>**](string)| Filter by presence | [optional]  |

### Return type

[**QueueMemberEntityListingV1**](QueueMemberEntityListingV1)


## GetRoutingQueueWrapupcodes

> [**WrapupCodeEntityListing**](WrapupCodeEntityListing) GetRoutingQueueWrapupcodes (string queueId, int? pageSize = null, int? pageNumber = null)


Get the wrap-up codes for a queue

Requires ALL permissions: 

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
    public class GetRoutingQueueWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get the wrap-up codes for a queue
                WrapupCodeEntityListing result = apiInstance.GetRoutingQueueWrapupcodes(queueId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueueWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |

### Return type

[**WrapupCodeEntityListing**](WrapupCodeEntityListing)


## GetRoutingQueues

> [**QueueEntityListing**](QueueEntityListing) GetRoutingQueues (int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, List<string> id = null, List<string> divisionId = null, List<string> peerId = null, string cannedResponseLibraryId = null, bool? hasPeer = null)


Get list of queues.

Requires ANY permissions: 

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
    public class GetRoutingQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortOrder = sortOrder_example;  // string | Note: results are sorted by name. (optional)  (default to asc)
            var name = name_example;  // string | Include only queues with the given name (leading and trailing asterisks allowed) (optional) 
            var id = new List<string>(); // List<string> | Include only queues with the specified ID(s) (optional) 
            var divisionId = new List<string>(); // List<string> | Include only queues in the specified division ID(s) (optional) 
            var peerId = new List<string>(); // List<string> | Include only queues with the specified peer ID(s) (optional) 
            var cannedResponseLibraryId = cannedResponseLibraryId_example;  // string | Include only queues explicitly associated with the specified canned response library ID (optional) 
            var hasPeer = true;  // bool? | Include only queues with a peer ID (optional) 

            try
            { 
                // Get list of queues.
                QueueEntityListing result = apiInstance.GetRoutingQueues(pageNumber, pageSize, sortOrder, name, id, divisionId, peerId, cannedResponseLibraryId, hasPeer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueues: " + e.Message );
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
| **sortOrder** | **string**| Note: results are sorted by name. | [optional] [default to asc]<br />**Values**: asc, desc |
| **name** | **string**| Include only queues with the given name (leading and trailing asterisks allowed) | [optional]  |
| **id** | [**List<string>**](string)| Include only queues with the specified ID(s) | [optional]  |
| **divisionId** | [**List<string>**](string)| Include only queues in the specified division ID(s) | [optional]  |
| **peerId** | [**List<string>**](string)| Include only queues with the specified peer ID(s) | [optional]  |
| **cannedResponseLibraryId** | **string**| Include only queues explicitly associated with the specified canned response library ID | [optional]  |
| **hasPeer** | **bool?**| Include only queues with a peer ID | [optional]  |

### Return type

[**QueueEntityListing**](QueueEntityListing)


## GetRoutingQueuesDivisionviews

> [**QueueEntityListing**](QueueEntityListing) GetRoutingQueuesDivisionviews (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, List<string> id = null, List<string> divisionId = null)


Get a paged listing of simplified queue objects, filterable by name, queue ID(s), or division ID(s).

Requires ALL permissions: 

* routing:queue:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueuesDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size [max value is 100] (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number [max value is 5] (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            var name = name_example;  // string | Name (optional) 
            var id = new List<string>(); // List<string> | Queue ID(s) (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 

            try
            { 
                // Get a paged listing of simplified queue objects, filterable by name, queue ID(s), or division ID(s).
                QueueEntityListing result = apiInstance.GetRoutingQueuesDivisionviews(pageSize, pageNumber, sortBy, sortOrder, name, id, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueuesDivisionviews: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size [max value is 100] | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number [max value is 5] | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to name]<br />**Values**: name, id, divisionId |
| **sortOrder** | **string**| Sort order | [optional] [default to asc]<br />**Values**: asc, desc |
| **name** | **string**| Name | [optional]  |
| **id** | [**List<string>**](string)| Queue ID(s) | [optional]  |
| **divisionId** | [**List<string>**](string)| Division ID(s) | [optional]  |

### Return type

[**QueueEntityListing**](QueueEntityListing)


## GetRoutingQueuesDivisionviewsAll

> [**QueueEntityListing**](QueueEntityListing) GetRoutingQueuesDivisionviewsAll (int? pageSize = null, int? pageNumber = null, string sortOrder = null)


Get a paged listing of simplified queue objects, sorted by name.  Can be used to get a digest of all queues in an organization.

Requires ALL permissions: 

* routing:queue:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingQueuesDivisionviewsAllExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size [max value is 500] (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)

            try
            { 
                // Get a paged listing of simplified queue objects, sorted by name.  Can be used to get a digest of all queues in an organization.
                QueueEntityListing result = apiInstance.GetRoutingQueuesDivisionviewsAll(pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueuesDivisionviewsAll: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size [max value is 500] | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc]<br />**Values**: asc, desc |

### Return type

[**QueueEntityListing**](QueueEntityListing)


## GetRoutingQueuesMe

> [**UserQueueEntityListing**](UserQueueEntityListing) GetRoutingQueuesMe (int? pageNumber = null, int? pageSize = null, bool? joined = null, string sortOrder = null)


Get a paged listing of queues the user is a member of.

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
    public class GetRoutingQueuesMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var joined = joined_example;  // bool? | Filter by joined status. (optional) 
            var sortOrder = sortOrder_example;  // string | Note: results are sorted by name. (optional)  (default to asc)

            try
            { 
                // Get a paged listing of queues the user is a member of.
                UserQueueEntityListing result = apiInstance.GetRoutingQueuesMe(pageNumber, pageSize, joined, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingQueuesMe: " + e.Message );
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
| **joined** | **bool?**| Filter by joined status. | [optional] <br />**Values**: true, false |
| **sortOrder** | **string**| Note: results are sorted by name. | [optional] [default to asc]<br />**Values**: asc, desc |

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing)


## GetRoutingSettings

> [**RoutingSettings**](RoutingSettings) GetRoutingSettings ()


Get an organization's routing settings

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
    public class GetRoutingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get an organization's routing settings
                RoutingSettings result = apiInstance.GetRoutingSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**RoutingSettings**](RoutingSettings)


## GetRoutingSettingsContactcenter

> [**ContactCenterSettings**](ContactCenterSettings) GetRoutingSettingsContactcenter ()


Get Contact Center Settings

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
    public class GetRoutingSettingsContactcenterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get Contact Center Settings
                ContactCenterSettings result = apiInstance.GetRoutingSettingsContactcenter();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSettingsContactcenter: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**ContactCenterSettings**](ContactCenterSettings)


## GetRoutingSettingsTranscription

> [**TranscriptionSettings**](TranscriptionSettings) GetRoutingSettingsTranscription ()


Get Transcription Settings

Requires ANY permissions: 

* routing:transcriptionSettings:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSettingsTranscriptionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get Transcription Settings
                TranscriptionSettings result = apiInstance.GetRoutingSettingsTranscription();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSettingsTranscription: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**TranscriptionSettings**](TranscriptionSettings)


## GetRoutingSkill

> [**RoutingSkill**](RoutingSkill) GetRoutingSkill (string skillId)


Get Routing Skill

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
    public class GetRoutingSkillExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var skillId = skillId_example;  // string | Skill ID

            try
            { 
                // Get Routing Skill
                RoutingSkill result = apiInstance.GetRoutingSkill(skillId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSkill: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillId** | **string**| Skill ID |  |

### Return type

[**RoutingSkill**](RoutingSkill)


## GetRoutingSkillgroup

> [**SkillGroup**](SkillGroup) GetRoutingSkillgroup (string skillGroupId)


Get skill group

Requires ANY permissions: 

* routing:skillGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSkillgroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var skillGroupId = skillGroupId_example;  // string | Skill Group ID

            try
            { 
                // Get skill group
                SkillGroup result = apiInstance.GetRoutingSkillgroup(skillGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSkillgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillGroupId** | **string**| Skill Group ID |  |

### Return type

[**SkillGroup**](SkillGroup)


## GetRoutingSkillgroupMembers

> [**SkillGroupMemberEntityListing**](SkillGroupMemberEntityListing) GetRoutingSkillgroupMembers (string skillGroupId, int? pageSize = null, string after = null, string before = null, string expand = null)


Get skill group members

Requires ANY permissions: 

* routing:skillGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSkillgroupMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var skillGroupId = skillGroupId_example;  // string | Skill Group ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var after = after_example;  // string | The cursor that points to the next item (optional) 
            var before = before_example;  // string | The cursor that points to the previous item (optional) 
            var expand = expand_example;  // string | Expand the name on each user (optional) 

            try
            { 
                // Get skill group members
                SkillGroupMemberEntityListing result = apiInstance.GetRoutingSkillgroupMembers(skillGroupId, pageSize, after, before, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSkillgroupMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillGroupId** | **string**| Skill Group ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **after** | **string**| The cursor that points to the next item | [optional]  |
| **before** | **string**| The cursor that points to the previous item | [optional]  |
| **expand** | **string**| Expand the name on each user | [optional] <br />**Values**: entities |

### Return type

[**SkillGroupMemberEntityListing**](SkillGroupMemberEntityListing)


## GetRoutingSkillgroupMembersDivisions

> [**SkillGroupMemberDivisionList**](SkillGroupMemberDivisionList) GetRoutingSkillgroupMembersDivisions (string skillGroupId, string expand = null)


Get list of member divisions for this skill group.

Requires ANY permissions: 

* routing:skillGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSkillgroupMembersDivisionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var skillGroupId = skillGroupId_example;  // string | Skill Group ID
            var expand = expand_example;  // string | Expand the name on each user (optional) 

            try
            { 
                // Get list of member divisions for this skill group.
                SkillGroupMemberDivisionList result = apiInstance.GetRoutingSkillgroupMembersDivisions(skillGroupId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSkillgroupMembersDivisions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillGroupId** | **string**| Skill Group ID |  |
| **expand** | **string**| Expand the name on each user | [optional] <br />**Values**: entities |

### Return type

[**SkillGroupMemberDivisionList**](SkillGroupMemberDivisionList)


## GetRoutingSkillgroups

> [**SkillGroupEntityListing**](SkillGroupEntityListing) GetRoutingSkillgroups (int? pageSize = null, string name = null, string after = null, string before = null)


Get skill group listing

Requires ANY permissions: 

* routing:skillGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSkillgroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var name = name_example;  // string | Return only skill group names whose names start with this value (case-insensitive matching) (optional) 
            var after = after_example;  // string | The cursor that points to the next item (optional) 
            var before = before_example;  // string | The cursor that points to the previous item (optional) 

            try
            { 
                // Get skill group listing
                SkillGroupEntityListing result = apiInstance.GetRoutingSkillgroups(pageSize, name, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSkillgroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **name** | **string**| Return only skill group names whose names start with this value (case-insensitive matching) | [optional]  |
| **after** | **string**| The cursor that points to the next item | [optional]  |
| **before** | **string**| The cursor that points to the previous item | [optional]  |

### Return type

[**SkillGroupEntityListing**](SkillGroupEntityListing)


## GetRoutingSkills

> [**SkillEntityListing**](SkillEntityListing) GetRoutingSkills (int? pageSize = null, int? pageNumber = null, string name = null, List<string> id = null)


Get the list of routing skills.

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
    public class GetRoutingSkillsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Filter for results that start with this value (optional) 
            var id = new List<string>(); // List<string> | id (optional) 

            try
            { 
                // Get the list of routing skills.
                SkillEntityListing result = apiInstance.GetRoutingSkills(pageSize, pageNumber, name, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSkills: " + e.Message );
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
| **name** | **string**| Filter for results that start with this value | [optional]  |
| **id** | [**List<string>**](string)| id | [optional]  |

### Return type

[**SkillEntityListing**](SkillEntityListing)


## GetRoutingSmsAddress

> [**SmsAddress**](SmsAddress) GetRoutingSmsAddress (string addressId)


Get an Address by Id for SMS

Requires ALL permissions: 

* sms:phoneNumber:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSmsAddressExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var addressId = addressId_example;  // string | Address ID

            try
            { 
                // Get an Address by Id for SMS
                SmsAddress result = apiInstance.GetRoutingSmsAddress(addressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |

### Return type

[**SmsAddress**](SmsAddress)


## GetRoutingSmsAddresses

> [**SmsAddressEntityListing**](SmsAddressEntityListing) GetRoutingSmsAddresses (int? pageSize = null, int? pageNumber = null)


Get a list of Addresses for SMS

Requires ALL permissions: 

* sms:phoneNumber:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSmsAddressesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Addresses for SMS
                SmsAddressEntityListing result = apiInstance.GetRoutingSmsAddresses(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsAddresses: " + e.Message );
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

### Return type

[**SmsAddressEntityListing**](SmsAddressEntityListing)


## GetRoutingSmsAvailablephonenumbers

> [**SMSAvailablePhoneNumberEntityListing**](SMSAvailablePhoneNumberEntityListing) GetRoutingSmsAvailablephonenumbers (string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, string addressRequirement = null)


Get a list of available phone numbers for SMS provisioning.

This request will return up to 30 random phone numbers matching the criteria specified.  To get additional phone numbers repeat the request.

Requires ALL permissions: 

* sms:phoneNumber:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSmsAvailablephonenumbersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var countryCode = countryCode_example;  // string | The ISO 3166-1 alpha-2 country code of the county for which available phone numbers should be returned
            var phoneNumberType = phoneNumberType_example;  // string | Type of available phone numbers searched
            var region = region_example;  // string | Region/province/state that can be used to restrict the numbers returned (optional) 
            var city = city_example;  // string | City that can be used to restrict the numbers returned (optional) 
            var areaCode = areaCode_example;  // string | Area code that can be used to restrict the numbers returned (optional) 
            var pattern = pattern_example;  // string | A pattern to match phone numbers. Valid characters are '*' and [0-9a-zA-Z]. The '*' character will match any single digit. (optional) 
            var addressRequirement = addressRequirement_example;  // string | This indicates whether the phone number requires to have an Address registered. (optional) 

            try
            { 
                // Get a list of available phone numbers for SMS provisioning.
                SMSAvailablePhoneNumberEntityListing result = apiInstance.GetRoutingSmsAvailablephonenumbers(countryCode, phoneNumberType, region, city, areaCode, pattern, addressRequirement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsAvailablephonenumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **countryCode** | **string**| The ISO 3166-1 alpha-2 country code of the county for which available phone numbers should be returned |  |
| **phoneNumberType** | **string**| Type of available phone numbers searched | <br />**Values**: local, mobile, tollfree |
| **region** | **string**| Region/province/state that can be used to restrict the numbers returned | [optional]  |
| **city** | **string**| City that can be used to restrict the numbers returned | [optional]  |
| **areaCode** | **string**| Area code that can be used to restrict the numbers returned | [optional]  |
| **pattern** | **string**| A pattern to match phone numbers. Valid characters are &#39;*&#39; and [0-9a-zA-Z]. The &#39;*&#39; character will match any single digit. | [optional]  |
| **addressRequirement** | **string**| This indicates whether the phone number requires to have an Address registered. | [optional] <br />**Values**: none, any, local, foreign |

### Return type

[**SMSAvailablePhoneNumberEntityListing**](SMSAvailablePhoneNumberEntityListing)


## GetRoutingSmsIdentityresolutionPhonenumber

> [**IdentityResolutionConfig**](IdentityResolutionConfig) GetRoutingSmsIdentityresolutionPhonenumber (string addressId)


Get a SMS identity resolution settings.

GetRoutingSmsIdentityresolutionPhonenumber is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* sms:phoneNumber:view
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
    public class GetRoutingSmsIdentityresolutionPhonenumberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var addressId = addressId_example;  // string | Address ID

            try
            { 
                // Get a SMS identity resolution settings.
                IdentityResolutionConfig result = apiInstance.GetRoutingSmsIdentityresolutionPhonenumber(addressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsIdentityresolutionPhonenumber: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## GetRoutingSmsPhonenumber

> [**SmsPhoneNumber**](SmsPhoneNumber) GetRoutingSmsPhonenumber (string phoneNumberId, string expand = null)


Get a phone number provisioned for SMS.

Requires ALL permissions: 

* sms:phoneNumber:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSmsPhonenumberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var phoneNumberId = phoneNumberId_example;  // string | phone number
            var expand = expand_example;  // string | Expand response with additional information (optional) 

            try
            { 
                // Get a phone number provisioned for SMS.
                SmsPhoneNumber result = apiInstance.GetRoutingSmsPhonenumber(phoneNumberId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsPhonenumber: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneNumberId** | **string**| phone number |  |
| **expand** | **string**| Expand response with additional information | [optional] <br />**Values**: compliance, supportedContent |

### Return type

[**SmsPhoneNumber**](SmsPhoneNumber)


## GetRoutingSmsPhonenumbers

> [**SmsPhoneNumberEntityListing**](SmsPhoneNumberEntityListing) GetRoutingSmsPhonenumbers (string phoneNumber = null, List<string> phoneNumberType = null, List<string> phoneNumberStatus = null, List<string> countryCode = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, string integrationId = null, string supportedContentId = null)


Get a list of provisioned phone numbers.

Requires ALL permissions: 

* sms:phoneNumber:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingSmsPhonenumbersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var phoneNumber = phoneNumber_example;  // string | Filter on phone number address. Allowable characters are the digits '0-9' and the wild card character '\\*'. If just digits are present, a contains search is done on the address pattern. For example, '317' could be matched anywhere in the address. An '\\*' will match multiple digits. For example, to match a specific area code within the US a pattern like '1317*' could be used. (optional) 
            var phoneNumberType = new List<string>(); // List<string> | Filter on phone number type (optional) 
            var phoneNumberStatus = new List<string>(); // List<string> | Filter on phone number status (optional) 
            var countryCode = new List<string>(); // List<string> | Filter on country code (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Optional field to sort results (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            var language = en-US;  // string | A language tag (which is sometimes referred to as a \"locale identifier\") to use to localize country field and sort operations (optional)  (default to "en-US")
            var integrationId = integrationId_example;  // string | Filter on the Genesys Cloud integration id to which the phone number belongs to (optional) 
            var supportedContentId = supportedContentId_example;  // string | Filter based on the supported content ID (optional) 

            try
            { 
                // Get a list of provisioned phone numbers.
                SmsPhoneNumberEntityListing result = apiInstance.GetRoutingSmsPhonenumbers(phoneNumber, phoneNumberType, phoneNumberStatus, countryCode, pageSize, pageNumber, sortBy, sortOrder, language, integrationId, supportedContentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingSmsPhonenumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneNumber** | **string**| Filter on phone number address. Allowable characters are the digits &#39;0-9&#39; and the wild card character &#39;\\*&#39;. If just digits are present, a contains search is done on the address pattern. For example, &#39;317&#39; could be matched anywhere in the address. An &#39;\\*&#39; will match multiple digits. For example, to match a specific area code within the US a pattern like &#39;1317*&#39; could be used. | [optional]  |
| **phoneNumberType** | [**List<string>**](string)| Filter on phone number type | [optional] <br />**Values**: local, mobile, tollfree, shortcode, alphanumeric |
| **phoneNumberStatus** | [**List<string>**](string)| Filter on phone number status | [optional] <br />**Values**: active, invalid, initiated, porting, pending, pending-cancellation |
| **countryCode** | [**List<string>**](string)| Filter on country code | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Optional field to sort results | [optional] <br />**Values**: phoneNumber, countryCode, country, dateCreated, dateModified, phoneNumberStatus, phoneNumberType, purchaseDate, supportsMms, supportsSms, supportsVoice |
| **sortOrder** | **string**| Sort order | [optional] <br />**Values**: ascending, descending |
| **language** | **string**| A language tag (which is sometimes referred to as a \&quot;locale identifier\&quot;) to use to localize country field and sort operations | [optional] [default to "en-US"] |
| **integrationId** | **string**| Filter on the Genesys Cloud integration id to which the phone number belongs to | [optional]  |
| **supportedContentId** | **string**| Filter based on the supported content ID | [optional]  |

### Return type

[**SmsPhoneNumberEntityListing**](SmsPhoneNumberEntityListing)


## GetRoutingUserDirectroutingbackupSettings

> [**AgentDirectRoutingBackupSettings**](AgentDirectRoutingBackupSettings) GetRoutingUserDirectroutingbackupSettings (string userId)


Get the user's Direct Routing Backup settings.

Requires ANY permissions: 

* routing:directRoutingBackup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUserDirectroutingbackupSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get the user's Direct Routing Backup settings.
                AgentDirectRoutingBackupSettings result = apiInstance.GetRoutingUserDirectroutingbackupSettings(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUserDirectroutingbackupSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |

### Return type

[**AgentDirectRoutingBackupSettings**](AgentDirectRoutingBackupSettings)


## GetRoutingUserUtilization

> [**AgentMaxUtilizationResponse**](AgentMaxUtilizationResponse) GetRoutingUserUtilization (string userId)


Get the user's max utilization settings.  If not configured, the organization-wide default is returned.

Requires ANY permissions: 

* routing:utilization:manage
* routing:utilization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUserUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Get the user's max utilization settings.  If not configured, the organization-wide default is returned.
                AgentMaxUtilizationResponse result = apiInstance.GetRoutingUserUtilization(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUserUtilization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |

### Return type

[**AgentMaxUtilizationResponse**](AgentMaxUtilizationResponse)


## GetRoutingUtilization

> [**UtilizationResponse**](UtilizationResponse) GetRoutingUtilization ()


Get the organization-wide max utilization settings.

Requires ANY permissions: 

* routing:utilization:manage
* routing:utilization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();

            try
            { 
                // Get the organization-wide max utilization settings.
                UtilizationResponse result = apiInstance.GetRoutingUtilization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUtilization: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.

### Return type

[**UtilizationResponse**](UtilizationResponse)


## GetRoutingUtilizationLabel

> [**UtilizationLabel**](UtilizationLabel) GetRoutingUtilizationLabel (string labelId)


Get details about this utilization label

Requires ALL permissions: 

* routing:utilization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUtilizationLabelExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var labelId = labelId_example;  // string | Utilization Label ID

            try
            { 
                // Get details about this utilization label
                UtilizationLabel result = apiInstance.GetRoutingUtilizationLabel(labelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUtilizationLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **labelId** | **string**| Utilization Label ID |  |

### Return type

[**UtilizationLabel**](UtilizationLabel)


## GetRoutingUtilizationLabelAgents

> **List&lt;Object&gt;** GetRoutingUtilizationLabelAgents (string labelId)


Get list of agent ids associated with a utilization label

Requires ALL permissions: 

* routing:utilization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUtilizationLabelAgentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var labelId = labelId_example;  // string | Utilization Label ID

            try
            { 
                // Get list of agent ids associated with a utilization label
                List<Object> result = apiInstance.GetRoutingUtilizationLabelAgents(labelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUtilizationLabelAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **labelId** | **string**| Utilization Label ID |  |

### Return type

**List<Object>**


## GetRoutingUtilizationLabels

> [**UtilizationLabelEntityListing**](UtilizationLabelEntityListing) GetRoutingUtilizationLabels (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)


Get list of utilization labels

Requires ALL permissions: 

* routing:utilization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUtilizationLabelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order by name (optional)  (default to ascending)
            var name = name_example;  // string | Utilization label's name (Wildcard is supported, e.g., 'label1*', '*label*' (optional) 

            try
            { 
                // Get list of utilization labels
                UtilizationLabelEntityListing result = apiInstance.GetRoutingUtilizationLabels(pageSize, pageNumber, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUtilizationLabels: " + e.Message );
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
| **sortOrder** | **string**| Sort order by name | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **name** | **string**| Utilization label&#39;s name (Wildcard is supported, e.g., &#39;label1*&#39;, &#39;*label*&#39; | [optional]  |

### Return type

[**UtilizationLabelEntityListing**](UtilizationLabelEntityListing)


## GetRoutingUtilizationTag

> [**UtilizationTag**](UtilizationTag) GetRoutingUtilizationTag (string tagId)


Get details about this utilization tag

GetRoutingUtilizationTag is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* routing:utilization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUtilizationTagExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var tagId = tagId_example;  // string | Utilization Tag ID

            try
            { 
                // Get details about this utilization tag
                UtilizationTag result = apiInstance.GetRoutingUtilizationTag(tagId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUtilizationTag: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tagId** | **string**| Utilization Tag ID |  |

### Return type

[**UtilizationTag**](UtilizationTag)


## GetRoutingUtilizationTagAgents

> **List&lt;Object&gt;** GetRoutingUtilizationTagAgents (string tagId)


Get list of agent ids associated with a utilization tag

GetRoutingUtilizationTagAgents is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* routing:utilization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUtilizationTagAgentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var tagId = tagId_example;  // string | Utilization Tag ID

            try
            { 
                // Get list of agent ids associated with a utilization tag
                List<Object> result = apiInstance.GetRoutingUtilizationTagAgents(tagId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUtilizationTagAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **tagId** | **string**| Utilization Tag ID |  |

### Return type

**List<Object>**


## GetRoutingUtilizationTags

> [**UtilizationTagEntityListing**](UtilizationTagEntityListing) GetRoutingUtilizationTags (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)


Get list of utilization tags

GetRoutingUtilizationTags is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* routing:utilization:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingUtilizationTagsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order by name (optional)  (default to ascending)
            var name = name_example;  // string | Utilization tag's name (Wildcard is supported, e.g., 'tag1*') (optional) 

            try
            { 
                // Get list of utilization tags
                UtilizationTagEntityListing result = apiInstance.GetRoutingUtilizationTags(pageSize, pageNumber, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingUtilizationTags: " + e.Message );
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
| **sortOrder** | **string**| Sort order by name | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **name** | **string**| Utilization tag&#39;s name (Wildcard is supported, e.g., &#39;tag1*&#39;) | [optional]  |

### Return type

[**UtilizationTagEntityListing**](UtilizationTagEntityListing)


## GetRoutingWrapupcode

> [**WrapupCode**](WrapupCode) GetRoutingWrapupcode (string codeId)


Get details about this wrap-up code.

Requires ALL permissions: 

* routing:wrapupCode:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingWrapupcodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var codeId = codeId_example;  // string | Wrapup Code ID

            try
            { 
                // Get details about this wrap-up code.
                WrapupCode result = apiInstance.GetRoutingWrapupcode(codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingWrapupcode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |

### Return type

[**WrapupCode**](WrapupCode)


## GetRoutingWrapupcodes

> [**WrapupCodeEntityListing**](WrapupCodeEntityListing) GetRoutingWrapupcodes (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, List<string> id = null, List<string> divisionId = null)


Get list of wrapup codes.

Requires ALL permissions: 

* routing:wrapupCode:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)
            var name = name_example;  // string | Wrapup code's name ('Sort by' param is ignored unless this field is provided) (optional) 
            var id = new List<string>(); // List<string> | Filter by wrapup code ID(s) (optional) 
            var divisionId = new List<string>(); // List<string> | Filter by division ID(s) (optional) 

            try
            { 
                // Get list of wrapup codes.
                WrapupCodeEntityListing result = apiInstance.GetRoutingWrapupcodes(pageSize, pageNumber, sortBy, sortOrder, name, id, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingWrapupcodes: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name]<br />**Values**: name, id |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending]<br />**Values**: ascending, descending |
| **name** | **string**| Wrapup code&#39;s name (&#39;Sort by&#39; param is ignored unless this field is provided) | [optional]  |
| **id** | [**List<string>**](string)| Filter by wrapup code ID(s) | [optional]  |
| **divisionId** | [**List<string>**](string)| Filter by division ID(s) | [optional]  |

### Return type

[**WrapupCodeEntityListing**](WrapupCodeEntityListing)


## GetRoutingWrapupcodesDivisionview

> [**WrapupCode**](WrapupCode) GetRoutingWrapupcodesDivisionview (string codeId)


Get a simplified wrap-up code.

Requires ALL permissions: 

* routing:wrapupCode:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingWrapupcodesDivisionviewExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var codeId = codeId_example;  // string | Wrapup Code ID

            try
            { 
                // Get a simplified wrap-up code.
                WrapupCode result = apiInstance.GetRoutingWrapupcodesDivisionview(codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingWrapupcodesDivisionview: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |

### Return type

[**WrapupCode**](WrapupCode)


## GetRoutingWrapupcodesDivisionviews

> [**WrapupCodeEntityListing**](WrapupCodeEntityListing) GetRoutingWrapupcodesDivisionviews (int? pageSize = null, int? pageNumber = null, string name = null, List<string> id = null, List<string> divisionId = null, string includeState = null)


Get a paged listing of simplified wrapup code objects, filterable by name, wrapup code ID(s), or division ID(s).

Specifying both name and ID parameters is not supported.

Requires ALL permissions: 

* routing:wrapupCode:search

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetRoutingWrapupcodesDivisionviewsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (trailing asterisks allowed) (optional) 
            var id = new List<string>(); // List<string> | Wrapup code ID(s) (optional) 
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 
            var includeState = includeState_example;  // string | Wrapup code state(s) to include (optional) 

            try
            { 
                // Get a paged listing of simplified wrapup code objects, filterable by name, wrapup code ID(s), or division ID(s).
                WrapupCodeEntityListing result = apiInstance.GetRoutingWrapupcodesDivisionviews(pageSize, pageNumber, name, id, divisionId, includeState);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingWrapupcodesDivisionviews: " + e.Message );
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
| **name** | **string**| Name (trailing asterisks allowed) | [optional]  |
| **id** | [**List<string>**](string)| Wrapup code ID(s) | [optional]  |
| **divisionId** | [**List<string>**](string)| Division ID(s) | [optional]  |
| **includeState** | **string**| Wrapup code state(s) to include | [optional] <br />**Values**: Active, Deleted, ActiveAndDeleted |

### Return type

[**WrapupCodeEntityListing**](WrapupCodeEntityListing)


## GetUserQueues

> [**UserQueueEntityListing**](UserQueueEntityListing) GetUserQueues (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null, List<string> divisionId = null)


Get queues for user

Requires ANY permissions: 

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
    public class GetUserQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var joined = true;  // bool? | Is joined to the queue (optional)  (default to true)
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 

            try
            { 
                // Get queues for user
                UserQueueEntityListing result = apiInstance.GetUserQueues(userId, pageSize, pageNumber, joined, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetUserQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **joined** | **bool?**| Is joined to the queue | [optional] [default to true] |
| **divisionId** | [**List<string>**](string)| Division ID(s) | [optional]  |

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing)


## GetUserRoutinglanguages

> [**UserLanguageEntityListing**](UserLanguageEntityListing) GetUserRoutinglanguages (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)


List routing languages assigned to a user

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
    public class GetUserRoutinglanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            { 
                // List routing languages assigned to a user
                UserLanguageEntityListing result = apiInstance.GetUserRoutinglanguages(userId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetUserRoutinglanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |

### Return type

[**UserLanguageEntityListing**](UserLanguageEntityListing)


## GetUserRoutingskills

> [**UserSkillEntityListing**](UserSkillEntityListing) GetUserRoutingskills (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)


List routing skills assigned to a user

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
    public class GetUserRoutingskillsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            { 
                // List routing skills assigned to a user
                UserSkillEntityListing result = apiInstance.GetUserRoutingskills(userId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetUserRoutingskills: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC]<br />**Values**: ascending, descending |

### Return type

[**UserSkillEntityListing**](UserSkillEntityListing)


## GetUserSkillgroups

> [**UserSkillGroupEntityListing**](UserSkillGroupEntityListing) GetUserSkillgroups (string userId, int? pageSize = null, string after = null, string before = null)


Get skill groups for a user

Requires ANY permissions: 

* routing:skillGroup:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetUserSkillgroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var after = after_example;  // string | The cursor that points to the next page (optional) 
            var before = before_example;  // string | The cursor that points to the previous page (optional) 

            try
            { 
                // Get skill groups for a user
                UserSkillGroupEntityListing result = apiInstance.GetUserSkillgroups(userId, pageSize, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetUserSkillgroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **after** | **string**| The cursor that points to the next page | [optional]  |
| **before** | **string**| The cursor that points to the previous page | [optional]  |

### Return type

[**UserSkillGroupEntityListing**](UserSkillGroupEntityListing)


## PatchRoutingConversation

> [**RoutingConversationAttributesResponse**](RoutingConversationAttributesResponse) PatchRoutingConversation (string conversationId, RoutingConversationAttributesRequest body)


Update attributes of an in-queue conversation

Returns an object indicating the updated values of all settable attributes. Supported attributes: skillIds, languageId, and priority.

Requires ANY permissions: 

* routing:conversation:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingConversationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var body = new RoutingConversationAttributesRequest(); // RoutingConversationAttributesRequest | Conversation Attributes

            try
            { 
                // Update attributes of an in-queue conversation
                RoutingConversationAttributesResponse result = apiInstance.PatchRoutingConversation(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **body** | [**RoutingConversationAttributesRequest**](RoutingConversationAttributesRequest)| Conversation Attributes |  |

### Return type

[**RoutingConversationAttributesResponse**](RoutingConversationAttributesResponse)


## PatchRoutingEmailDomain

> [**InboundDomain**](InboundDomain) PatchRoutingEmailDomain (string domainId, InboundDomainPatchRequest body)


Update domain settings

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingEmailDomainExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID
            var body = new InboundDomainPatchRequest(); // InboundDomainPatchRequest | Domain settings

            try
            { 
                // Update domain settings
                InboundDomain result = apiInstance.PatchRoutingEmailDomain(domainId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingEmailDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |
| **body** | [**InboundDomainPatchRequest**](InboundDomainPatchRequest)| Domain settings |  |

### Return type

[**InboundDomain**](InboundDomain)


## PatchRoutingEmailDomainValidate

> [**InboundDomain**](InboundDomain) PatchRoutingEmailDomainValidate (string domainId, InboundDomainPatchRequest body)


Validate domain settings

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingEmailDomainValidateExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID
            var body = new InboundDomainPatchRequest(); // InboundDomainPatchRequest | Domain settings

            try
            { 
                // Validate domain settings
                InboundDomain result = apiInstance.PatchRoutingEmailDomainValidate(domainId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingEmailDomainValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |
| **body** | [**InboundDomainPatchRequest**](InboundDomainPatchRequest)| Domain settings |  |

### Return type

[**InboundDomain**](InboundDomain)


## PatchRoutingPredictor

> [**Predictor**](Predictor) PatchRoutingPredictor (string predictorId, PatchPredictorRequest body = null)


Update single predictor.

Requires ALL permissions: 

* routing:predictor:edit
* routing:queue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingPredictorExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var predictorId = predictorId_example;  // string | Predictor ID
            var body = new PatchPredictorRequest(); // PatchPredictorRequest |  (optional) 

            try
            { 
                // Update single predictor.
                Predictor result = apiInstance.PatchRoutingPredictor(predictorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingPredictor: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **predictorId** | **string**| Predictor ID |  |
| **body** | [**PatchPredictorRequest**](PatchPredictorRequest)|  | [optional]  |

### Return type

[**Predictor**](Predictor)


## PatchRoutingQueueMember

> void PatchRoutingQueueMember (string queueId, string memberId, QueueMember body)


Update the ring number OR joined status for a queue member.

Requires ANY permissions: 

* routing:queue:edit
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingQueueMemberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member ID
            var body = new QueueMember(); // QueueMember | Queue Member

            try
            { 
                // Update the ring number OR joined status for a queue member.
                apiInstance.PatchRoutingQueueMember(queueId, memberId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingQueueMember: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
| **body** | [**QueueMember**](QueueMember)| Queue Member |  |

### Return type

void (empty response body)


## PatchRoutingQueueMembers

> [**QueueMemberEntityListing**](QueueMemberEntityListing) PatchRoutingQueueMembers (string queueId, List<QueueMember> body)


Join or unjoin a set of up to 100 users for a queue

Requires ANY permissions: 

* routing:queue:edit
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingQueueMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<QueueMember>(); // List<QueueMember> | Queue Members

            try
            { 
                // Join or unjoin a set of up to 100 users for a queue
                QueueMemberEntityListing result = apiInstance.PatchRoutingQueueMembers(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingQueueMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<QueueMember>**](QueueMember)| Queue Members |  |

### Return type

[**QueueMemberEntityListing**](QueueMemberEntityListing)


## PatchRoutingQueueUser

> void PatchRoutingQueueUser (string queueId, string memberId, QueueMember body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

DEPRECATED: use PATCH /routing/queues/{queueId}/members/{memberId}.  Update the ring number OR joined status for a User in a Queue.

Requires ANY permissions: 

* routing:queue:edit
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingQueueUserExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member ID
            var body = new QueueMember(); // QueueMember | Queue Member

            try
            { 
                // DEPRECATED: use PATCH /routing/queues/{queueId}/members/{memberId}.  Update the ring number OR joined status for a User in a Queue.
                apiInstance.PatchRoutingQueueUser(queueId, memberId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingQueueUser: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
| **body** | [**QueueMember**](QueueMember)| Queue Member |  |

### Return type

void (empty response body)


## PatchRoutingQueueUsers

> [**QueueMemberEntityListingV1**](QueueMemberEntityListingV1) PatchRoutingQueueUsers (string queueId, List<QueueMember> body)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

DEPRECATED: use PATCH /routing/queues/{queueId}/members.  Join or unjoin a set of users for a queue.

Requires ANY permissions: 

* routing:queue:edit
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingQueueUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<QueueMember>(); // List<QueueMember> | Queue Members

            try
            { 
                // DEPRECATED: use PATCH /routing/queues/{queueId}/members.  Join or unjoin a set of users for a queue.
                QueueMemberEntityListingV1 result = apiInstance.PatchRoutingQueueUsers(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingQueueUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<QueueMember>**](QueueMember)| Queue Members |  |

### Return type

[**QueueMemberEntityListingV1**](QueueMemberEntityListingV1)


## PatchRoutingSettingsContactcenter

> void PatchRoutingSettingsContactcenter (ContactCenterSettings body)


Update Contact Center Settings

Requires ANY permissions: 

* routing:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingSettingsContactcenterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new ContactCenterSettings(); // ContactCenterSettings | Contact Center Settings

            try
            { 
                // Update Contact Center Settings
                apiInstance.PatchRoutingSettingsContactcenter(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingSettingsContactcenter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactCenterSettings**](ContactCenterSettings)| Contact Center Settings |  |

### Return type

void (empty response body)


## PatchRoutingSettingsTranscription

> [**TranscriptionSettings**](TranscriptionSettings) PatchRoutingSettingsTranscription (TranscriptionSettings body)


Patch Transcription Settings

Requires ANY permissions: 

* routing:transcriptionSettings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingSettingsTranscriptionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new TranscriptionSettings(); // TranscriptionSettings | Organization Settings

            try
            { 
                // Patch Transcription Settings
                TranscriptionSettings result = apiInstance.PatchRoutingSettingsTranscription(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingSettingsTranscription: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TranscriptionSettings**](TranscriptionSettings)| Organization Settings |  |

### Return type

[**TranscriptionSettings**](TranscriptionSettings)


## PatchRoutingSkillgroup

> [**SkillGroup**](SkillGroup) PatchRoutingSkillgroup (string skillGroupId, SkillGroup body)


Update skill group definition

Requires ANY permissions: 

* routing:skillGroup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchRoutingSkillgroupExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var skillGroupId = skillGroupId_example;  // string | Skill Group ID
            var body = new SkillGroup(); // SkillGroup | Update skill groups

            try
            { 
                // Update skill group definition
                SkillGroup result = apiInstance.PatchRoutingSkillgroup(skillGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchRoutingSkillgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillGroupId** | **string**| Skill Group ID |  |
| **body** | [**SkillGroup**](SkillGroup)| Update skill groups |  |

### Return type

[**SkillGroup**](SkillGroup)


## PatchUserQueue

> [**UserQueue**](UserQueue) PatchUserQueue (string queueId, string userId, UserQueue body)


Join or unjoin a queue for a user

Requires ANY permissions: 

* routing:queue:join
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserQueueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var userId = userId_example;  // string | User ID
            var body = new UserQueue(); // UserQueue | Queue Member

            try
            { 
                // Join or unjoin a queue for a user
                UserQueue result = apiInstance.PatchUserQueue(queueId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchUserQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **userId** | **string**| User ID |  |
| **body** | [**UserQueue**](UserQueue)| Queue Member |  |

### Return type

[**UserQueue**](UserQueue)


## PatchUserQueues

> [**UserQueueEntityListing**](UserQueueEntityListing) PatchUserQueues (string userId, List<UserQueue> body, List<string> divisionId = null)


Join or unjoin a set of queues for a user

Requires ANY permissions: 

* routing:queue:join
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var body = new List<UserQueue>(); // List<UserQueue> | User Queues
            var divisionId = new List<string>(); // List<string> | Division ID(s) (optional) 

            try
            { 
                // Join or unjoin a set of queues for a user
                UserQueueEntityListing result = apiInstance.PatchUserQueues(userId, body, divisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchUserQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserQueue>**](UserQueue)| User Queues |  |
| **divisionId** | [**List<string>**](string)| Division ID(s) | [optional]  |

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing)


## PatchUserRoutinglanguage

> [**UserRoutingLanguage**](UserRoutingLanguage) PatchUserRoutinglanguage (string userId, string languageId, UserRoutingLanguage body)


Update an assigned routing language's proficiency

Requires ANY permissions: 

* routing:skill:assign
* routing:language:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserRoutinglanguageExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var languageId = languageId_example;  // string | languageId
            var body = new UserRoutingLanguage(); // UserRoutingLanguage | Language

            try
            { 
                // Update an assigned routing language's proficiency
                UserRoutingLanguage result = apiInstance.PatchUserRoutinglanguage(userId, languageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchUserRoutinglanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **languageId** | **string**| languageId |  |
| **body** | [**UserRoutingLanguage**](UserRoutingLanguage)| Language |  |

### Return type

[**UserRoutingLanguage**](UserRoutingLanguage)


## PatchUserRoutinglanguagesBulk

> [**UserLanguageEntityListing**](UserLanguageEntityListing) PatchUserRoutinglanguagesBulk (string userId, List<UserRoutingLanguagePost> body)


Assign multiple routing languages to a user. Max 50 routing languages in request body

Requires ANY permissions: 

* routing:skill:assign
* routing:language:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserRoutinglanguagesBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var body = new List<UserRoutingLanguagePost>(); // List<UserRoutingLanguagePost> | Language

            try
            { 
                // Assign multiple routing languages to a user. Max 50 routing languages in request body
                UserLanguageEntityListing result = apiInstance.PatchUserRoutinglanguagesBulk(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchUserRoutinglanguagesBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserRoutingLanguagePost>**](UserRoutingLanguagePost)| Language |  |

### Return type

[**UserLanguageEntityListing**](UserLanguageEntityListing)


## PatchUserRoutingskillsBulk

> [**UserSkillEntityListing**](UserSkillEntityListing) PatchUserRoutingskillsBulk (string userId, List<UserRoutingSkillPost> body)


Assign multiple routing skills to a user

Requires ANY permissions: 

* routing:skill:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PatchUserRoutingskillsBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var body = new List<UserRoutingSkillPost>(); // List<UserRoutingSkillPost> | Skill

            try
            { 
                // Assign multiple routing skills to a user
                UserSkillEntityListing result = apiInstance.PatchUserRoutingskillsBulk(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchUserRoutingskillsBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserRoutingSkillPost>**](UserRoutingSkillPost)| Skill |  |

### Return type

[**UserSkillEntityListing**](UserSkillEntityListing)


## PostAnalyticsQueuesObservationsQuery

> [**QueueObservationQueryResponse**](QueueObservationQueryResponse) PostAnalyticsQueuesObservationsQuery (QueueObservationQuery body)


Query for queue observations

Requires ANY permissions: 

* analytics:queueObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsQueuesObservationsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new QueueObservationQuery(); // QueueObservationQuery | query

            try
            { 
                // Query for queue observations
                QueueObservationQueryResponse result = apiInstance.PostAnalyticsQueuesObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostAnalyticsQueuesObservationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**QueueObservationQuery**](QueueObservationQuery)| query |  |

### Return type

[**QueueObservationQueryResponse**](QueueObservationQueryResponse)


## PostAnalyticsRoutingActivityQuery

> [**RoutingActivityResponse**](RoutingActivityResponse) PostAnalyticsRoutingActivityQuery (RoutingActivityQuery body, int? pageSize = null, int? pageNumber = null)


Query for user activity observations

Requires ANY permissions: 

* analytics:queueObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsRoutingActivityQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new RoutingActivityQuery(); // RoutingActivityQuery | query
            var pageSize = 56;  // int? | The desired page size (optional) 
            var pageNumber = 56;  // int? | The desired page number (optional) 

            try
            { 
                // Query for user activity observations
                RoutingActivityResponse result = apiInstance.PostAnalyticsRoutingActivityQuery(body, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostAnalyticsRoutingActivityQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RoutingActivityQuery**](RoutingActivityQuery)| query |  |
| **pageSize** | **int?**| The desired page size | [optional]  |
| **pageNumber** | **int?**| The desired page number | [optional]  |

### Return type

[**RoutingActivityResponse**](RoutingActivityResponse)


## PostRoutingAssessments

> [**BenefitAssessment**](BenefitAssessment) PostRoutingAssessments (CreateBenefitAssessmentRequest body = null)


Create a benefit assessment.

Requires ALL permissions: 

* routing:assessment:add
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
    public class PostRoutingAssessmentsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new CreateBenefitAssessmentRequest(); // CreateBenefitAssessmentRequest |  (optional) 

            try
            { 
                // Create a benefit assessment.
                BenefitAssessment result = apiInstance.PostRoutingAssessments(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingAssessments: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateBenefitAssessmentRequest**](CreateBenefitAssessmentRequest)|  | [optional]  |

### Return type

[**BenefitAssessment**](BenefitAssessment)


## PostRoutingAssessmentsJobs

> [**BenefitAssessmentJob**](BenefitAssessmentJob) PostRoutingAssessmentsJobs (CreateBenefitAssessmentJobRequest body = null)


Create a benefit assessment job.

Requires ANY permissions: 

* routing:assessment:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingAssessmentsJobsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new CreateBenefitAssessmentJobRequest(); // CreateBenefitAssessmentJobRequest |  (optional) 

            try
            { 
                // Create a benefit assessment job.
                BenefitAssessmentJob result = apiInstance.PostRoutingAssessmentsJobs(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingAssessmentsJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateBenefitAssessmentJobRequest**](CreateBenefitAssessmentJobRequest)|  | [optional]  |

### Return type

[**BenefitAssessmentJob**](BenefitAssessmentJob)


## PostRoutingEmailDomainRoutes

> [**InboundRoute**](InboundRoute) PostRoutingEmailDomainRoutes (string domainName, InboundRoute body)


Create a route

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingEmailDomainRoutesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var body = new InboundRoute(); // InboundRoute | Route

            try
            { 
                // Create a route
                InboundRoute result = apiInstance.PostRoutingEmailDomainRoutes(domainName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingEmailDomainRoutes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **body** | [**InboundRoute**](InboundRoute)| Route |  |

### Return type

[**InboundRoute**](InboundRoute)


## PostRoutingEmailDomainTestconnection

> [**TestMessage**](TestMessage) PostRoutingEmailDomainTestconnection (string domainId, TestMessage body = null)


Tests the custom SMTP server integration connection set on this domain

The request body is optional. If omitted, this endpoint will just test the connection of the Custom SMTP Server. If the body is specified, there will be an attempt to send an email message to the server.

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingEmailDomainTestconnectionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID
            var body = new TestMessage(); // TestMessage | TestMessage (optional) 

            try
            { 
                // Tests the custom SMTP server integration connection set on this domain
                TestMessage result = apiInstance.PostRoutingEmailDomainTestconnection(domainId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingEmailDomainTestconnection: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |
| **body** | [**TestMessage**](TestMessage)| TestMessage | [optional]  |

### Return type

[**TestMessage**](TestMessage)


## PostRoutingEmailDomains

> [**InboundDomain**](InboundDomain) PostRoutingEmailDomains (InboundDomain body)


Create a domain

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingEmailDomainsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new InboundDomain(); // InboundDomain | Domain

            try
            { 
                // Create a domain
                InboundDomain result = apiInstance.PostRoutingEmailDomains(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingEmailDomains: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**InboundDomain**](InboundDomain)| Domain |  |

### Return type

[**InboundDomain**](InboundDomain)


## PostRoutingEmailOutboundDomains

> [**EmailOutboundDomainResult**](EmailOutboundDomainResult) PostRoutingEmailOutboundDomains (OutboundDomain body)


Create a domain

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingEmailOutboundDomainsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new OutboundDomain(); // OutboundDomain | Domain

            try
            { 
                // Create a domain
                EmailOutboundDomainResult result = apiInstance.PostRoutingEmailOutboundDomains(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingEmailOutboundDomains: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutboundDomain**](OutboundDomain)| Domain |  |

### Return type

[**EmailOutboundDomainResult**](EmailOutboundDomainResult)


## PostRoutingEmailOutboundDomainsSimulated

> [**EmailOutboundDomainResult**](EmailOutboundDomainResult) PostRoutingEmailOutboundDomainsSimulated (OutboundDomain body)


Create a simulated domain

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingEmailOutboundDomainsSimulatedExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new OutboundDomain(); // OutboundDomain | Domain

            try
            { 
                // Create a simulated domain
                EmailOutboundDomainResult result = apiInstance.PostRoutingEmailOutboundDomainsSimulated(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingEmailOutboundDomainsSimulated: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutboundDomain**](OutboundDomain)| Domain |  |

### Return type

[**EmailOutboundDomainResult**](EmailOutboundDomainResult)


## PostRoutingLanguages

> [**Language**](Language) PostRoutingLanguages (Language body)


Create Language

Requires ANY permissions: 

* routing:skill:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingLanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new Language(); // Language | Language

            try
            { 
                // Create Language
                Language result = apiInstance.PostRoutingLanguages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Language**](Language)| Language |  |

### Return type

[**Language**](Language)


## PostRoutingPredictors

> [**Predictor**](Predictor) PostRoutingPredictors (CreatePredictorRequest body = null)


Create a predictor.

Requires ALL permissions: 

* routing:predictor:add
* routing:queue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingPredictorsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new CreatePredictorRequest(); // CreatePredictorRequest |  (optional) 

            try
            { 
                // Create a predictor.
                Predictor result = apiInstance.PostRoutingPredictors(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingPredictors: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreatePredictorRequest**](CreatePredictorRequest)|  | [optional]  |

### Return type

[**Predictor**](Predictor)


## PostRoutingQueueMembers

> void PostRoutingQueueMembers (string queueId, List<WritableEntity> body, bool? delete = null)


Bulk add or delete up to 100 queue members

Requires ANY permissions: 

* routing:queue:edit
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingQueueMembersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<WritableEntity>(); // List<WritableEntity> | Queue Members
            var delete = true;  // bool? | True to delete queue members (optional)  (default to false)

            try
            { 
                // Bulk add or delete up to 100 queue members
                apiInstance.PostRoutingQueueMembers(queueId, body, delete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingQueueMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<WritableEntity>**](WritableEntity)| Queue Members |  |
| **delete** | **bool?**| True to delete queue members | [optional] [default to false] |

### Return type

void (empty response body)


## PostRoutingQueueUsers

> void PostRoutingQueueUsers (string queueId, List<WritableEntity> body, bool? delete = null)

:::{"alert":"warning","title":"Deprecated","collapsible":false,"autoCollapse":false}
This resource has been deprecated
:::

DEPRECATED: use POST /routing/queues/{queueId}/members.  Bulk add or delete up to 100 queue members.

Requires ANY permissions: 

* routing:queue:edit
* routing:queueMember:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingQueueUsersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<WritableEntity>(); // List<WritableEntity> | Queue Members
            var delete = true;  // bool? | True to delete queue members (optional)  (default to false)

            try
            { 
                // DEPRECATED: use POST /routing/queues/{queueId}/members.  Bulk add or delete up to 100 queue members.
                apiInstance.PostRoutingQueueUsers(queueId, body, delete);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingQueueUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<WritableEntity>**](WritableEntity)| Queue Members |  |
| **delete** | **bool?**| True to delete queue members | [optional] [default to false] |

### Return type

void (empty response body)


## PostRoutingQueueWrapupcodes

> [**List&lt;WrapupCode&gt;**](WrapupCode) PostRoutingQueueWrapupcodes (string queueId, List<WrapUpCodeReference> body)


Add up to 100 wrap-up codes to a queue

Requires ALL permissions: 

* routing:queue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingQueueWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<WrapUpCodeReference>(); // List<WrapUpCodeReference> | List of wrapup codes

            try
            { 
                // Add up to 100 wrap-up codes to a queue
                List<WrapupCode> result = apiInstance.PostRoutingQueueWrapupcodes(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingQueueWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<WrapUpCodeReference>**](WrapUpCodeReference)| List of wrapup codes |  |

### Return type

[**List<WrapupCode>**](WrapupCode)


## PostRoutingQueues

> [**Queue**](Queue) PostRoutingQueues (CreateQueueRequest body)


Create a queue

Requires ANY permissions: 

* routing:queue:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingQueuesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new CreateQueueRequest(); // CreateQueueRequest | Queue

            try
            { 
                // Create a queue
                Queue result = apiInstance.PostRoutingQueues(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateQueueRequest**](CreateQueueRequest)| Queue |  |

### Return type

[**Queue**](Queue)


## PostRoutingSkillgroupMembersDivisions

> void PostRoutingSkillgroupMembersDivisions (string skillGroupId, SkillGroupMemberDivisions body = null)


Add or remove member divisions for this skill group.

Requires ALL permissions: 

* routing:skillGroup:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingSkillgroupMembersDivisionsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var skillGroupId = skillGroupId_example;  // string | Skill Group ID
            var body = new SkillGroupMemberDivisions(); // SkillGroupMemberDivisions |  (optional) 

            try
            { 
                // Add or remove member divisions for this skill group.
                apiInstance.PostRoutingSkillgroupMembersDivisions(skillGroupId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSkillgroupMembersDivisions: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillGroupId** | **string**| Skill Group ID |  |
| **body** | [**SkillGroupMemberDivisions**](SkillGroupMemberDivisions)|  | [optional]  |

### Return type

void (empty response body)


## PostRoutingSkillgroups

> [**SkillGroupWithMemberDivisions**](SkillGroupWithMemberDivisions) PostRoutingSkillgroups (SkillGroupWithMemberDivisions body)


Create a skill group

Requires ALL permissions: 

* routing:skillGroup:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingSkillgroupsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new SkillGroupWithMemberDivisions(); // SkillGroupWithMemberDivisions | Create skill group

            try
            { 
                // Create a skill group
                SkillGroupWithMemberDivisions result = apiInstance.PostRoutingSkillgroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSkillgroups: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SkillGroupWithMemberDivisions**](SkillGroupWithMemberDivisions)| Create skill group |  |

### Return type

[**SkillGroupWithMemberDivisions**](SkillGroupWithMemberDivisions)


## PostRoutingSkills

> [**RoutingSkill**](RoutingSkill) PostRoutingSkills (RoutingSkill body)


Create Skill

Requires ANY permissions: 

* routing:skill:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingSkillsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new RoutingSkill(); // RoutingSkill | Skill

            try
            { 
                // Create Skill
                RoutingSkill result = apiInstance.PostRoutingSkills(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSkills: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RoutingSkill**](RoutingSkill)| Skill |  |

### Return type

[**RoutingSkill**](RoutingSkill)


## PostRoutingSmsAddresses

> [**SmsAddress**](SmsAddress) PostRoutingSmsAddresses (SmsAddressProvision body)


Provision an Address for SMS

Requires ALL permissions: 

* sms:phoneNumber:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingSmsAddressesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new SmsAddressProvision(); // SmsAddressProvision | SmsAddress

            try
            { 
                // Provision an Address for SMS
                SmsAddress result = apiInstance.PostRoutingSmsAddresses(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSmsAddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SmsAddressProvision**](SmsAddressProvision)| SmsAddress |  |

### Return type

[**SmsAddress**](SmsAddress)


## PostRoutingSmsPhonenumbers

> [**SmsPhoneNumber**](SmsPhoneNumber) PostRoutingSmsPhonenumbers (SmsPhoneNumberProvision body)


Provision a phone number for SMS

Requires ALL permissions: 

* sms:phoneNumber:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingSmsPhonenumbersExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new SmsPhoneNumberProvision(); // SmsPhoneNumberProvision | SmsPhoneNumber

            try
            { 
                // Provision a phone number for SMS
                SmsPhoneNumber result = apiInstance.PostRoutingSmsPhonenumbers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSmsPhonenumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SmsPhoneNumberProvision**](SmsPhoneNumberProvision)| SmsPhoneNumber |  |

### Return type

[**SmsPhoneNumber**](SmsPhoneNumber)


## PostRoutingSmsPhonenumbersAlphanumeric

> [**SmsPhoneNumber**](SmsPhoneNumber) PostRoutingSmsPhonenumbersAlphanumeric (SmsAlphanumericProvision body)


Provision an alphanumeric number for SMS

PostRoutingSmsPhonenumbersAlphanumeric is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* sms:phoneNumber:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingSmsPhonenumbersAlphanumericExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new SmsAlphanumericProvision(); // SmsAlphanumericProvision | SmsPhoneNumber

            try
            { 
                // Provision an alphanumeric number for SMS
                SmsPhoneNumber result = apiInstance.PostRoutingSmsPhonenumbersAlphanumeric(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSmsPhonenumbersAlphanumeric: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SmsAlphanumericProvision**](SmsAlphanumericProvision)| SmsPhoneNumber |  |

### Return type

[**SmsPhoneNumber**](SmsPhoneNumber)


## PostRoutingSmsPhonenumbersImport

> [**SmsPhoneNumber**](SmsPhoneNumber) PostRoutingSmsPhonenumbersImport (SmsPhoneNumberImport body)


Imports a phone number for SMS

Requires ALL permissions: 

* sms:phoneNumber:byoImport

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingSmsPhonenumbersImportExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new SmsPhoneNumberImport(); // SmsPhoneNumberImport | SmsPhoneNumber

            try
            { 
                // Imports a phone number for SMS
                SmsPhoneNumber result = apiInstance.PostRoutingSmsPhonenumbersImport(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingSmsPhonenumbersImport: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SmsPhoneNumberImport**](SmsPhoneNumberImport)| SmsPhoneNumber |  |

### Return type

[**SmsPhoneNumber**](SmsPhoneNumber)


## PostRoutingUtilizationLabels

> [**UtilizationLabel**](UtilizationLabel) PostRoutingUtilizationLabels (CreateUtilizationLabelRequest body)


Create a utilization label

Requires ALL permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingUtilizationLabelsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new CreateUtilizationLabelRequest(); // CreateUtilizationLabelRequest | UtilizationLabel

            try
            { 
                // Create a utilization label
                UtilizationLabel result = apiInstance.PostRoutingUtilizationLabels(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingUtilizationLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateUtilizationLabelRequest**](CreateUtilizationLabelRequest)| UtilizationLabel |  |

### Return type

[**UtilizationLabel**](UtilizationLabel)


## PostRoutingUtilizationTags

> [**UtilizationTag**](UtilizationTag) PostRoutingUtilizationTags (CreateUtilizationTagRequest body)


Create an utilization tag

PostRoutingUtilizationTags is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingUtilizationTagsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new CreateUtilizationTagRequest(); // CreateUtilizationTagRequest | UtilizationTag

            try
            { 
                // Create an utilization tag
                UtilizationTag result = apiInstance.PostRoutingUtilizationTags(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingUtilizationTags: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateUtilizationTagRequest**](CreateUtilizationTagRequest)| UtilizationTag |  |

### Return type

[**UtilizationTag**](UtilizationTag)


## PostRoutingWrapupcodes

> [**WrapupCode**](WrapupCode) PostRoutingWrapupcodes (WrapupCodeRequest body)


Create a wrap-up code

Requires ALL permissions: 

* routing:wrapupCode:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostRoutingWrapupcodesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new WrapupCodeRequest(); // WrapupCodeRequest | WrapupCode

            try
            { 
                // Create a wrap-up code
                WrapupCode result = apiInstance.PostRoutingWrapupcodes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostRoutingWrapupcodes: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WrapupCodeRequest**](WrapupCodeRequest)| WrapupCode |  |

### Return type

[**WrapupCode**](WrapupCode)


## PostUserRoutinglanguages

> [**UserRoutingLanguage**](UserRoutingLanguage) PostUserRoutinglanguages (string userId, UserRoutingLanguagePost body)


Assign a routing language to a user

Requires ANY permissions: 

* routing:skill:assign
* routing:language:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUserRoutinglanguagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var body = new UserRoutingLanguagePost(); // UserRoutingLanguagePost | Language

            try
            { 
                // Assign a routing language to a user
                UserRoutingLanguage result = apiInstance.PostUserRoutinglanguages(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostUserRoutinglanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UserRoutingLanguagePost**](UserRoutingLanguagePost)| Language |  |

### Return type

[**UserRoutingLanguage**](UserRoutingLanguage)


## PostUserRoutingskills

> [**UserRoutingSkill**](UserRoutingSkill) PostUserRoutingskills (string userId, UserRoutingSkillPost body)


Assign a routing skill to a user

Requires ALL permissions: 

* routing:skill:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUserRoutingskillsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var body = new UserRoutingSkillPost(); // UserRoutingSkillPost | Skill

            try
            { 
                // Assign a routing skill to a user
                UserRoutingSkill result = apiInstance.PostUserRoutingskills(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostUserRoutingskills: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UserRoutingSkillPost**](UserRoutingSkillPost)| Skill |  |

### Return type

[**UserRoutingSkill**](UserRoutingSkill)


## PutRoutingDirectroutingbackupSettingsMe

> [**AgentDirectRoutingBackupSettings**](AgentDirectRoutingBackupSettings) PutRoutingDirectroutingbackupSettingsMe (AgentDirectRoutingBackupSettings body)


Update the user's Direct Routing Backup settings.

Requires ANY permissions: 

* routing:directRoutingBackup:selfEdit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingDirectroutingbackupSettingsMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new AgentDirectRoutingBackupSettings(); // AgentDirectRoutingBackupSettings | directRoutingBackup

            try
            { 
                // Update the user's Direct Routing Backup settings.
                AgentDirectRoutingBackupSettings result = apiInstance.PutRoutingDirectroutingbackupSettingsMe(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingDirectroutingbackupSettingsMe: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AgentDirectRoutingBackupSettings**](AgentDirectRoutingBackupSettings)| directRoutingBackup |  |

### Return type

[**AgentDirectRoutingBackupSettings**](AgentDirectRoutingBackupSettings)


## PutRoutingEmailDomainRoute

> [**InboundRoute**](InboundRoute) PutRoutingEmailDomainRoute (string domainName, string routeId, InboundRoute body)


Update a route

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingEmailDomainRouteExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var routeId = routeId_example;  // string | route ID
            var body = new InboundRoute(); // InboundRoute | Route

            try
            { 
                // Update a route
                InboundRoute result = apiInstance.PutRoutingEmailDomainRoute(domainName, routeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingEmailDomainRoute: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |
| **body** | [**InboundRoute**](InboundRoute)| Route |  |

### Return type

[**InboundRoute**](InboundRoute)


## PutRoutingEmailDomainRouteIdentityresolution

> [**IdentityResolutionConfig**](IdentityResolutionConfig) PutRoutingEmailDomainRouteIdentityresolution (string domainName, string routeId, IdentityResolutionConfig body)


Update identity resolution settings for a route.

PutRoutingEmailDomainRouteIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* routing:email:manage
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
    public class PutRoutingEmailDomainRouteIdentityresolutionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var routeId = routeId_example;  // string | route ID
            var body = new IdentityResolutionConfig(); // IdentityResolutionConfig | 

            try
            { 
                // Update identity resolution settings for a route.
                IdentityResolutionConfig result = apiInstance.PutRoutingEmailDomainRouteIdentityresolution(domainName, routeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingEmailDomainRouteIdentityresolution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |
| **body** | [**IdentityResolutionConfig**](IdentityResolutionConfig)|  |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## PutRoutingEmailOutboundDomainActivation

> [**EmailOutboundDomainResult**](EmailOutboundDomainResult) PutRoutingEmailOutboundDomainActivation (string domainId)


Request an activation status (cname + dkim) update of an outbound domain

Requires ALL permissions: 

* routing:email:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingEmailOutboundDomainActivationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID

            try
            { 
                // Request an activation status (cname + dkim) update of an outbound domain
                EmailOutboundDomainResult result = apiInstance.PutRoutingEmailOutboundDomainActivation(domainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingEmailOutboundDomainActivation: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |

### Return type

[**EmailOutboundDomainResult**](EmailOutboundDomainResult)


## PutRoutingMessageRecipient

> [**Recipient**](Recipient) PutRoutingMessageRecipient (string recipientId, RecipientRequest body)


Update a recipient

Requires ALL permissions: 

* routing:message:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingMessageRecipientExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var recipientId = recipientId_example;  // string | Recipient ID
            var body = new RecipientRequest(); // RecipientRequest | Recipient

            try
            { 
                // Update a recipient
                Recipient result = apiInstance.PutRoutingMessageRecipient(recipientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingMessageRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recipientId** | **string**| Recipient ID |  |
| **body** | [**RecipientRequest**](RecipientRequest)| Recipient |  |

### Return type

[**Recipient**](Recipient)


## PutRoutingQueue

> [**Queue**](Queue) PutRoutingQueue (string queueId, QueueRequest body)


Update a queue

Requires ANY permissions: 

* routing:queue:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingQueueExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new QueueRequest(); // QueueRequest | Queue

            try
            { 
                // Update a queue
                Queue result = apiInstance.PutRoutingQueue(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**QueueRequest**](QueueRequest)| Queue |  |

### Return type

[**Queue**](Queue)


## PutRoutingQueueIdentityresolution

> [**IdentityResolutionQueueConfig**](IdentityResolutionQueueConfig) PutRoutingQueueIdentityresolution (string queueId, IdentityResolutionQueueConfig body)


Update Queue IdentityResolution Settings.

PutRoutingQueueIdentityresolution is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* routing:queue:edit
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
    public class PutRoutingQueueIdentityresolutionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new IdentityResolutionQueueConfig(); // IdentityResolutionQueueConfig | 

            try
            { 
                // Update Queue IdentityResolution Settings.
                IdentityResolutionQueueConfig result = apiInstance.PutRoutingQueueIdentityresolution(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingQueueIdentityresolution: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**IdentityResolutionQueueConfig**](IdentityResolutionQueueConfig)|  |  |

### Return type

[**IdentityResolutionQueueConfig**](IdentityResolutionQueueConfig)


## PutRoutingSettings

> [**RoutingSettings**](RoutingSettings) PutRoutingSettings (RoutingSettings body)


Update an organization's routing settings

Requires ANY permissions: 

* routing:settings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new RoutingSettings(); // RoutingSettings | Organization Settings

            try
            { 
                // Update an organization's routing settings
                RoutingSettings result = apiInstance.PutRoutingSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RoutingSettings**](RoutingSettings)| Organization Settings |  |

### Return type

[**RoutingSettings**](RoutingSettings)


## PutRoutingSettingsTranscription

> [**TranscriptionSettings**](TranscriptionSettings) PutRoutingSettingsTranscription (TranscriptionSettings body)


Update Transcription Settings

Requires ANY permissions: 

* routing:transcriptionSettings:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingSettingsTranscriptionExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new TranscriptionSettings(); // TranscriptionSettings | Organization Settings

            try
            { 
                // Update Transcription Settings
                TranscriptionSettings result = apiInstance.PutRoutingSettingsTranscription(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingSettingsTranscription: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TranscriptionSettings**](TranscriptionSettings)| Organization Settings |  |

### Return type

[**TranscriptionSettings**](TranscriptionSettings)


## PutRoutingSmsIdentityresolutionPhonenumber

> [**IdentityResolutionConfig**](IdentityResolutionConfig) PutRoutingSmsIdentityresolutionPhonenumber (string addressId, IdentityResolutionConfig body)


Update an SMS identity resolution settings.

PutRoutingSmsIdentityresolutionPhonenumber is a preview method and is subject to both breaking and non-breaking changes at any time without notice

Requires ALL permissions: 

* sms:phoneNumber:edit
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
    public class PutRoutingSmsIdentityresolutionPhonenumberExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var addressId = addressId_example;  // string | Address ID
            var body = new IdentityResolutionConfig(); // IdentityResolutionConfig | 

            try
            { 
                // Update an SMS identity resolution settings.
                IdentityResolutionConfig result = apiInstance.PutRoutingSmsIdentityresolutionPhonenumber(addressId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingSmsIdentityresolutionPhonenumber: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **addressId** | **string**| Address ID |  |
| **body** | [**IdentityResolutionConfig**](IdentityResolutionConfig)|  |  |

### Return type

[**IdentityResolutionConfig**](IdentityResolutionConfig)


## PutRoutingUserDirectroutingbackupSettings

> [**AgentDirectRoutingBackupSettings**](AgentDirectRoutingBackupSettings) PutRoutingUserDirectroutingbackupSettings (string userId, AgentDirectRoutingBackupSettings body)


Update the user's Direct Routing Backup settings.

Requires ANY permissions: 

* routing:directRoutingBackup:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingUserDirectroutingbackupSettingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var body = new AgentDirectRoutingBackupSettings(); // AgentDirectRoutingBackupSettings | directRoutingBackup

            try
            { 
                // Update the user's Direct Routing Backup settings.
                AgentDirectRoutingBackupSettings result = apiInstance.PutRoutingUserDirectroutingbackupSettings(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingUserDirectroutingbackupSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**AgentDirectRoutingBackupSettings**](AgentDirectRoutingBackupSettings)| directRoutingBackup |  |

### Return type

[**AgentDirectRoutingBackupSettings**](AgentDirectRoutingBackupSettings)


## PutRoutingUserUtilization

> [**AgentMaxUtilizationResponse**](AgentMaxUtilizationResponse) PutRoutingUserUtilization (string userId, UtilizationRequest body)


Update the user's max utilization settings.  Include only those media types requiring custom configuration.

Requires ANY permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingUserUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var body = new UtilizationRequest(); // UtilizationRequest | utilization

            try
            { 
                // Update the user's max utilization settings.  Include only those media types requiring custom configuration.
                AgentMaxUtilizationResponse result = apiInstance.PutRoutingUserUtilization(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingUserUtilization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UtilizationRequest**](UtilizationRequest)| utilization |  |

### Return type

[**AgentMaxUtilizationResponse**](AgentMaxUtilizationResponse)


## PutRoutingUtilization

> [**UtilizationResponse**](UtilizationResponse) PutRoutingUtilization (UtilizationRequest body)


Update the organization-wide max utilization settings.  Include only those media types requiring custom configuration.

Requires ALL permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingUtilizationExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var body = new UtilizationRequest(); // UtilizationRequest | utilization

            try
            { 
                // Update the organization-wide max utilization settings.  Include only those media types requiring custom configuration.
                UtilizationResponse result = apiInstance.PutRoutingUtilization(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingUtilization: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UtilizationRequest**](UtilizationRequest)| utilization |  |

### Return type

[**UtilizationResponse**](UtilizationResponse)


## PutRoutingUtilizationLabel

> [**UtilizationLabel**](UtilizationLabel) PutRoutingUtilizationLabel (string labelId, UpdateUtilizationLabelRequest body)


Update a utilization label

Requires ALL permissions: 

* routing:utilization:manage

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingUtilizationLabelExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var labelId = labelId_example;  // string | Utilization Label ID
            var body = new UpdateUtilizationLabelRequest(); // UpdateUtilizationLabelRequest | UtilizationLabel

            try
            { 
                // Update a utilization label
                UtilizationLabel result = apiInstance.PutRoutingUtilizationLabel(labelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingUtilizationLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **labelId** | **string**| Utilization Label ID |  |
| **body** | [**UpdateUtilizationLabelRequest**](UpdateUtilizationLabelRequest)| UtilizationLabel |  |

### Return type

[**UtilizationLabel**](UtilizationLabel)


## PutRoutingWrapupcode

> [**WrapupCode**](WrapupCode) PutRoutingWrapupcode (string codeId, WrapupCodeRequest body)


Update wrap-up code

Requires ALL permissions: 

* routing:wrapupCode:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutRoutingWrapupcodeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var codeId = codeId_example;  // string | Wrapup Code ID
            var body = new WrapupCodeRequest(); // WrapupCodeRequest | WrapupCode

            try
            { 
                // Update wrap-up code
                WrapupCode result = apiInstance.PutRoutingWrapupcode(codeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutRoutingWrapupcode: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
| **body** | [**WrapupCodeRequest**](WrapupCodeRequest)| WrapupCode |  |

### Return type

[**WrapupCode**](WrapupCode)


## PutUserRoutingskill

> [**UserRoutingSkill**](UserRoutingSkill) PutUserRoutingskill (string userId, string skillId, UserRoutingSkill body)


Update an assigned routing skill's proficiency

Requires ALL permissions: 

* routing:skill:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserRoutingskillExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var skillId = skillId_example;  // string | skillId
            var body = new UserRoutingSkill(); // UserRoutingSkill | Skill

            try
            { 
                // Update an assigned routing skill's proficiency
                UserRoutingSkill result = apiInstance.PutUserRoutingskill(userId, skillId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutUserRoutingskill: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **skillId** | **string**| skillId |  |
| **body** | [**UserRoutingSkill**](UserRoutingSkill)| Skill |  |

### Return type

[**UserRoutingSkill**](UserRoutingSkill)


## PutUserRoutingskillsBulk

> [**UserSkillEntityListing**](UserSkillEntityListing) PutUserRoutingskillsBulk (string userId, List<UserRoutingSkillPost> body)


Assign multiple routing skills to a user, replacing any current assignments

Requires ANY permissions: 

* routing:skill:assign

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutUserRoutingskillsBulkExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var body = new List<UserRoutingSkillPost>(); // List<UserRoutingSkillPost> | Skill

            try
            { 
                // Assign multiple routing skills to a user, replacing any current assignments
                UserSkillEntityListing result = apiInstance.PutUserRoutingskillsBulk(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutUserRoutingskillsBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserRoutingSkillPost>**](UserRoutingSkillPost)| Skill |  |

### Return type

[**UserSkillEntityListing**](UserSkillEntityListing)


_PureCloudPlatform.Client.V2 231.0.0_
