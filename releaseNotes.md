Platform API version: 7719




# Major Changes (80 changes)

**/api/v2/contentmanagement/auditquery** (1 change)

* Path /api/v2/contentmanagement/auditquery was removed

**/api/v2/contentmanagement/documents/{documentId}/audits** (1 change)

* Path /api/v2/contentmanagement/documents/{documentId}/audits was removed

**/api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId}** (1 change)

* Path /api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId} was removed

**/api/v2/journey/sessions/{sessionId}/segments** (1 change)

* Path /api/v2/journey/sessions/{sessionId}/segments was removed

**GET /api/v2/authorization/divisions** (1 change)

* Parameter id was removed

**POST /api/v2/conversations/messaging/integrations/line** (1 change)

* Has been deprecated

**PUT /api/v2/identityproviders/adfs** (1 change)

* Response 200 type was changed from OAuthProvider to IdentityProvider

**PUT /api/v2/identityproviders/cic** (1 change)

* Response 200 type was changed from OAuthProvider to IdentityProvider

**PUT /api/v2/identityproviders/gsuite** (1 change)

* Response 200 type was changed from OAuthProvider to IdentityProvider

**PUT /api/v2/identityproviders/generic** (1 change)

* Response 200 type was changed from OAuthProvider to IdentityProvider

**GET /api/v2/identityproviders** (1 change)

* Response 200 type was changed from OAuthProviderEntityListing to IdentityProviderEntityListing

**PUT /api/v2/identityproviders/okta** (1 change)

* Response 200 type was changed from OAuthProvider to IdentityProvider

**PUT /api/v2/identityproviders/onelogin** (1 change)

* Response 200 type was changed from OAuthProvider to IdentityProvider

**PUT /api/v2/identityproviders/ping** (1 change)

* Response 200 type was changed from OAuthProvider to IdentityProvider

**PUT /api/v2/identityproviders/purecloud** (1 change)

* Response 200 type was changed from OAuthProvider to IdentityProvider

**PUT /api/v2/identityproviders/pureengage** (1 change)

* Response 200 type was changed from OAuthProvider to IdentityProvider

**PUT /api/v2/identityproviders/salesforce** (1 change)

* Response 200 type was changed from OAuthProvider to IdentityProvider

**GET /api/v2/presencedefinitions/{presenceId}** (1 change)

* Has been deprecated

**PUT /api/v2/presencedefinitions/{presenceId}** (1 change)

* Has been deprecated

**DELETE /api/v2/presencedefinitions/{presenceId}** (1 change)

* Has been deprecated

**GET /api/v2/presencedefinitions** (1 change)

* Has been deprecated

**POST /api/v2/presencedefinitions** (1 change)

* Has been deprecated

**GET /api/v2/telephony/providers/edges/sites** (1 change)

* Parameter expand was added

**GET /api/v2/architect/prompts/{promptId}** (3 changes)

* Parameter includeMediaUris was added
* Parameter includeResources was added
* Parameter language was added

**GET /api/v2/architect/prompts** (3 changes)

* Parameter includeMediaUris was added
* Parameter includeResources was added
* Parameter language was added

**GET /api/v2/architect/systemprompts/{promptId}** (3 changes)

* Parameter includeMediaUris was added
* Parameter includeResources was added
* Parameter language was added

**GET /api/v2/architect/systemprompts** (3 changes)

* Parameter includeMediaUris was added
* Parameter includeResources was added
* Parameter language was added

**GET /api/v2/chats/rooms/{roomJid}/messages** (6 changes)

* Parameter pageSize was removed
* Parameter pageNumber was removed
* Parameter sortBy was removed
* Parameter expand was removed
* Parameter nextPage was removed
* Parameter previousPage was removed

**GET /api/v2/chats/users/{userId}/messages** (6 changes)

* Parameter pageSize was removed
* Parameter pageNumber was removed
* Parameter sortBy was removed
* Parameter expand was removed
* Parameter nextPage was removed
* Parameter previousPage was removed

**GET /api/v2/chats/threads/{threadId}/messages** (6 changes)

* Parameter pageSize was removed
* Parameter pageNumber was removed
* Parameter sortBy was removed
* Parameter expand was removed
* Parameter nextPage was removed
* Parameter previousPage was removed

**ContentAttributeFilterItem** (1 change)

* Model ContentAttributeFilterItem was removed

**ContentFacetFilterItem** (1 change)

* Model ContentFacetFilterItem was removed

**ContentQueryRequest** (1 change)

* Model ContentQueryRequest was removed

**ContentSortItem** (1 change)

* Model ContentSortItem was removed

**AuditChange** (1 change)

* Model AuditChange was removed

**AuditEntityReference** (1 change)

* Model AuditEntityReference was removed

**DocumentAudit** (1 change)

* Model DocumentAudit was removed

**DocumentAuditEntityListing** (1 change)

* Model DocumentAuditEntityListing was removed

**OAuthProvider** (1 change)

* Model OAuthProvider was removed

**OAuthProviderEntityListing** (1 change)

* Model OAuthProviderEntityListing was removed

**SegmentAssignment** (1 change)

* Model SegmentAssignment was removed

**SegmentAssignmentListing** (1 change)

* Model SegmentAssignmentListing was removed

**SegmentAssignmentSegment** (1 change)

* Model SegmentAssignmentSegment was removed

**SegmentAssignmentSession** (1 change)

* Model SegmentAssignmentSession was removed

**LocalTime** (1 change)

* Model LocalTime was removed

**ConversationAggregationQuery** (2 changes)

* Enum value tCallback was removed from property metrics
* Enum value tCallbackComplete was removed from property metrics

**ConversationAggregationView** (2 changes)

* Enum value tCallback was removed from property target
* Enum value tCallbackComplete was removed from property target

**ConversationDetailQueryPredicate** (2 changes)

* Enum value tCallback was removed from property metric
* Enum value tCallbackComplete was removed from property metric

**GetAlertQuery** (1 change)

* Property activeStatus was removed

**ConversationAsyncAggregationQuery** (2 changes)

* Enum value tCallback was removed from property metrics
* Enum value tCallbackComplete was removed from property metrics

**WorkitemStatus** (1 change)

* Property statusTransitionTime was changed from LocalTime to string

**WorkitemStatusCreate** (1 change)

* Property statusTransitionTime was changed from LocalTime to string

**WorkitemStatusUpdate** (1 change)

* Property statusTransitionTime was changed from LocalTime to string


# Minor Changes (210 changes)

**/api/v2/screenrecording/token** (2 changes)

* Path was added
* Operation POST was added

**/api/v2/conversations/{conversationId}/summaries/{summaryId}/feedback** (2 changes)

* Path was added
* Operation POST was added

**/api/v2/outbound/contactlisttemplates/bulk/retrieve** (2 changes)

* Path was added
* Operation POST was added

**/api/v2/outbound/filespecificationtemplates/bulk** (2 changes)

* Path was added
* Operation DELETE was added

**/api/v2/outbound/filespecificationtemplates** (3 changes)

* Path was added
* Operation GET was added
* Operation POST was added

**/api/v2/outbound/filespecificationtemplates/{fileSpecificationTemplateId}** (4 changes)

* Path was added
* Operation GET was added
* Operation PUT was added
* Operation DELETE was added

**/api/v2/integrations/actions/certificates** (2 changes)

* Path was added
* Operation GET was added

**/api/v2/diagnostics/logcapture/browser/entries/query** (2 changes)

* Path was added
* Operation POST was added

**/api/v2/diagnostics/logcapture/browser/users** (2 changes)

* Path was added
* Operation GET was added

**/api/v2/diagnostics/logcapture/browser/users/{userId}** (4 changes)

* Path was added
* Operation GET was added
* Operation POST was added
* Operation DELETE was added

**/api/v2/identityproviders** (1 change)

* Operation post was added. Summary: Create Identity Provider

**/api/v2/identityproviders/{providerId}** (4 changes)

* Path was added
* Operation GET was added
* Operation PUT was added
* Operation DELETE was added

**/api/v2/routing/settings/transcription** (1 change)

* Operation patch was added. Summary: Patch Transcription Settings

**/api/v2/routing/wrapupcodes/divisionviews/{codeId}** (2 changes)

* Path was added
* Operation GET was added

**/api/v2/routing/wrapupcodes/divisionviews** (2 changes)

* Path was added
* Operation GET was added

**GET /api/v2/architect/prompts/{promptId}** (1 change)

* Response 206 was added

**GET /api/v2/architect/prompts** (1 change)

* Response 206 was added

**GET /api/v2/architect/systemprompts/{promptId}** (1 change)

* Response 206 was added

**GET /api/v2/architect/systemprompts** (1 change)

* Response 206 was added

**/api/v2/integrations/actions/{actionId}/draft/function** (3 changes)

* Path was added
* Operation GET was added
* Operation PUT was added

**/api/v2/integrations/actions/{actionId}/draft/function/upload** (2 changes)

* Path was added
* Operation POST was added

**/api/v2/integrations/actions/{actionId}/function** (2 changes)

* Path was added
* Operation GET was added

**/api/v2/integrations/actions/functions/runtimes** (2 changes)

* Path was added
* Operation GET was added

**/api/v2/chats/users/{userId}/settings** (3 changes)

* Path was added
* Operation GET was added
* Operation PATCH was added

**/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/operations** (2 changes)

* Path was added
* Operation GET was added

**/api/v2/knowledge/knowledgebases/{knowledgeBaseId}/operations/users/query** (2 changes)

* Path was added
* Operation GET was added

**EmailBeginTransmittingEvent** (1 change)

* Model was added

**EmailCommunicationAnsweredEvent** (1 change)

* Model was added

**EmailCommunicationDispositionAppliedEvent** (1 change)

* Model was added

**EmailCommunicationEndedEvent** (1 change)

* Model was added

**EmailCommunicationRepliedEvent** (1 change)

* Model was added

**EmailEndTransferEvent** (1 change)

* Model was added

**EmailExternalEstablishedEvent** (1 change)

* Model was added

**EmailFlowEstablishedEvent** (1 change)

* Model was added

**EmailHoldUpdatedEvent** (1 change)

* Model was added

**EmailInitialConfiguration** (1 change)

* Model was added

**EmailProgressTransferEvent** (1 change)

* Model was added

**EmailRoutingEstablishedEvent** (1 change)

* Model was added

**EmailRoutingTransferEvent** (1 change)

* Model was added

**EmailUserEstablishedEvent** (1 change)

* Model was added

**EmailUserTransferEvent** (1 change)

* Model was added

**Group** (1 change)

* Optional property rolesEnabled was added

**User** (1 change)

* Optional property preferredName was added

**UserPresence** (1 change)

* Optional property sourceId was added

**WorkPlanBidRanks** (1 change)

* Model was added

**ReportingTurnAction** (4 changes)

* Enum value ClearUtilizationLabelAction was added to property actionType
* Enum value FindGrammarByIdAction was added to property actionType
* Enum value FindUtilizationLabelAction was added to property actionType
* Enum value SetUtilizationLabelAction was added to property actionType

**ScreenRecordingUserAuthenticatedInfo** (1 change)

* Model was added

**OrgUser** (1 change)

* Optional property preferredName was added

**FeedbackAddRequest** (1 change)

* Model was added

**ContactListTemplateBulkRetrieveBody** (1 change)

* Model was added

**Column** (1 change)

* Model was added

**FileSpecificationTemplate** (1 change)

* Model was added

**PreprocessingRule** (1 change)

* Model was added

**FileSpecificationTemplateEntityListing** (1 change)

* Model was added

**GroupUpdate** (1 change)

* Optional property rolesEnabled was added

**GroupCreate** (1 change)

* Optional property rolesEnabled was added

**ActionCertificate** (1 change)

* Model was added

**ActionCertificateListing** (1 change)

* Model was added

**AddressableEntity** (1 change)

* Model was added

**LogEntry** (1 change)

* Model was added

**LogCaptureQueryResponse** (1 change)

* Model was added

**PagelessEntityListing** (1 change)

* Model was added

**IdentityProvider** (1 change)

* Model was added

**IdentityProviderEntityListing** (1 change)

* Model was added

**CustomProvider** (1 change)

* Model was added

**TrustGroup** (1 change)

* Optional property rolesEnabled was added

**TrustUser** (1 change)

* Optional property preferredName was added

**UcUserPresence** (1 change)

* Optional property sourceId was added

**MutableUserPresence** (1 change)

* Optional property sourceId was added

**GetAlertQuery** (1 change)

* Optional property alertStatus was added

**TranscriptionSettings** (2 changes)

* Optional property pciDssRedactionEnabled was added
* Optional property piiRedactionEnabled was added

**PhoneBaseEntityListing** (1 change)

* Optional property totalNumberOfEntities was added

**PhoneMetaBaseEntityListing** (1 change)

* Optional property totalNumberOfEntities was added

**PhoneStatus** (1 change)

* selfUri is no longer readonly

**TrunkMetabaseEntityListing** (1 change)

* Optional property totalNumberOfEntities was added

**MetadataProperty** (1 change)

* Optional property displayname was added

**UserMe** (1 change)

* Optional property preferredName was added

**UpdateUser** (1 change)

* Optional property preferredName was added

**PatchUser** (1 change)

* Optional property preferredName was added

**AuthenticationSettings** (1 change)

* Optional property allowSessionUpgrade was added

**AssessmentQuestionGroupScore** (1 change)

* Optional property systemMarkedNA was added

**AssessmentQuestionScore** (1 change)

* Optional property systemMarkedNA was added

**BuForecastModificationResponse** (2 changes)

* Optional property secondaryValues was added
* Optional property secondaryGranularity was added

**KnowledgeAggregateQueryPredicate** (1 change)

* Enum value surfacingMethod was added to property dimension

**KnowledgeAggregationQuery** (1 change)

* Enum value surfacingMethod was added to property groupBy

**KnowledgeAsyncAggregationQuery** (1 change)

* Enum value surfacingMethod was added to property groupBy

**TaskManagementAggregationQuery** (24 changes)

* Enum value nWorkitemsAcdCancelled was added to property metrics
* Enum value nWorkitemsAcdExpired was added to property metrics
* Enum value nWorkitemsAcdStarted was added to property metrics
* Enum value nWorkitemsAgentTransferred was added to property metrics
* Enum value nWorkitemsDeclined was added to property metrics
* Enum value nWorkitemsDisconnected was added to property metrics
* Enum value nWorkitemsOverSla was added to property metrics
* Enum value nWorkitemsQueueTransferred was added to property metrics
* Enum value nWorkitemsTerminated was added to property metrics
* Enum value nWorkitemsTimedout was added to property metrics
* Enum value nWorkitemsTransferred was added to property metrics
* Enum value nWorkitemsWrapupAdded was added to property metrics
* Enum value nWorkitemsWrapupRemoved was added to property metrics
* Enum value tWorkitemsAlert was added to property metrics
* Enum value tWorkitemsAnswered was added to property metrics
* Enum value tWorkitemsDirectAnswered was added to property metrics
* Enum value tWorkitemsFocus was added to property metrics
* Enum value tWorkitemsFocusComplete was added to property metrics
* Enum value tWorkitemsHandled was added to property metrics
* Enum value tWorkitemsHeld was added to property metrics
* Enum value tWorkitemsHeldComplete was added to property metrics
* Enum value tWorkitemsNotResponding was added to property metrics
* Enum value tWorkitemsParked was added to property metrics
* Enum value tWorkitemsQueueAnswered was added to property metrics

**TaskManagementAggregationView** (24 changes)

* Enum value nWorkitemsAcdCancelled was added to property target
* Enum value nWorkitemsAcdExpired was added to property target
* Enum value nWorkitemsAcdStarted was added to property target
* Enum value nWorkitemsAgentTransferred was added to property target
* Enum value nWorkitemsDeclined was added to property target
* Enum value nWorkitemsDisconnected was added to property target
* Enum value nWorkitemsOverSla was added to property target
* Enum value nWorkitemsQueueTransferred was added to property target
* Enum value nWorkitemsTerminated was added to property target
* Enum value nWorkitemsTimedout was added to property target
* Enum value nWorkitemsTransferred was added to property target
* Enum value nWorkitemsWrapupAdded was added to property target
* Enum value nWorkitemsWrapupRemoved was added to property target
* Enum value tWorkitemsAlert was added to property target
* Enum value tWorkitemsAnswered was added to property target
* Enum value tWorkitemsDirectAnswered was added to property target
* Enum value tWorkitemsFocus was added to property target
* Enum value tWorkitemsFocusComplete was added to property target
* Enum value tWorkitemsHandled was added to property target
* Enum value tWorkitemsHeld was added to property target
* Enum value tWorkitemsHeldComplete was added to property target
* Enum value tWorkitemsNotResponding was added to property target
* Enum value tWorkitemsParked was added to property target
* Enum value tWorkitemsQueueAnswered was added to property target

**TaskManagementAsyncAggregationQuery** (24 changes)

* Enum value nWorkitemsAcdCancelled was added to property metrics
* Enum value nWorkitemsAcdExpired was added to property metrics
* Enum value nWorkitemsAcdStarted was added to property metrics
* Enum value nWorkitemsAgentTransferred was added to property metrics
* Enum value nWorkitemsDeclined was added to property metrics
* Enum value nWorkitemsDisconnected was added to property metrics
* Enum value nWorkitemsOverSla was added to property metrics
* Enum value nWorkitemsQueueTransferred was added to property metrics
* Enum value nWorkitemsTerminated was added to property metrics
* Enum value nWorkitemsTimedout was added to property metrics
* Enum value nWorkitemsTransferred was added to property metrics
* Enum value nWorkitemsWrapupAdded was added to property metrics
* Enum value nWorkitemsWrapupRemoved was added to property metrics
* Enum value tWorkitemsAlert was added to property metrics
* Enum value tWorkitemsAnswered was added to property metrics
* Enum value tWorkitemsDirectAnswered was added to property metrics
* Enum value tWorkitemsFocus was added to property metrics
* Enum value tWorkitemsFocusComplete was added to property metrics
* Enum value tWorkitemsHandled was added to property metrics
* Enum value tWorkitemsHeld was added to property metrics
* Enum value tWorkitemsHeldComplete was added to property metrics
* Enum value tWorkitemsNotResponding was added to property metrics
* Enum value tWorkitemsParked was added to property metrics
* Enum value tWorkitemsQueueAnswered was added to property metrics

**Function** (1 change)

* Model was added

**FunctionConfig** (1 change)

* Model was added

**FunctionZipConfig** (1 change)

* Model was added

**FunctionUploadResponse** (1 change)

* Model was added

**FunctionUploadRequest** (1 change)

* Model was added

**FunctionRuntime** (1 change)

* Model was added

**ChatUserSettings** (1 change)

* Model was added

**MobileNotificationSettings** (1 change)

* Model was added

**MobileSettings** (1 change)

* Model was added

**OperationListing** (1 change)

* Model was added

**OperationResponse** (1 change)

* Model was added

**OperationCreatorUserResponse** (1 change)

* Model was added

**Workitem** (1 change)

* Optional property utilizationLabel was added

**WorkitemUtilizationLabelReference** (1 change)

* Model was added

**WorkitemCreate** (1 change)

* Optional property utilizationLabelId was added

**WorkitemUpdate** (1 change)

* Optional property utilizationLabelId was added

**WorkitemVersion** (1 change)

* Optional property utilizationLabel was added

**WorkitemDelta** (1 change)

* Optional property utilizationLabelId was added


# Point Changes (14 changes)

**GET /api/v2/externalcontacts/contacts/{contactId}/notes** (1 change)

* Description was changed for parameter sortOrder

**GET /api/v2/externalcontacts/contacts** (1 change)

* Description was changed for parameter sortOrder

**GET /api/v2/externalcontacts/organizations/{externalOrganizationId}/contacts** (1 change)

* Description was changed for parameter sortOrder

**GET /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes** (1 change)

* Description was changed for parameter sortOrder

**GET /api/v2/externalcontacts/organizations/{externalOrganizationId}/relationships** (1 change)

* Description was changed for parameter sortOrder

**GET /api/v2/externalcontacts/organizations** (1 change)

* Description was changed for parameter sortOrder

**POST /api/v2/conversations/messaging/integrations/line** (2 changes)

* Description was changed
* Summary was changed

**GET /api/v2/presencedefinitions/{presenceId}** (1 change)

* Summary was changed

**PUT /api/v2/presencedefinitions/{presenceId}** (1 change)

* Summary was changed

**DELETE /api/v2/presencedefinitions/{presenceId}** (1 change)

* Summary was changed

**GET /api/v2/presencedefinitions** (1 change)

* Summary was changed

**POST /api/v2/presencedefinitions** (1 change)

* Summary was changed

**PUT /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}** (1 change)

* Description was changed
