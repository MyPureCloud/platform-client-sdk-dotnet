---
title: ConversationMessageEventTopicMessageMediaParticipant
---
## ININ.PureCloudApi.Model.ConversationMessageEventTopicMessageMediaParticipant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Name** | **string** |  | [optional] |
| **Address** | **string** |  | [optional] |
| **StartTime** | **DateTime?** |  | [optional] |
| **ConnectedTime** | **DateTime?** |  | [optional] |
| **EndTime** | **DateTime?** |  | [optional] |
| **StartHoldTime** | **DateTime?** |  | [optional] |
| **Purpose** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **Direction** | **string** |  | [optional] |
| **DisconnectType** | **string** |  | [optional] |
| **Held** | **bool?** |  | [optional] |
| **WrapupRequired** | **bool?** |  | [optional] |
| **WrapupPrompt** | **string** |  | [optional] |
| **User** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference.html) |  | [optional] |
| **Queue** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference.html) |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ErrorInfo** | [**ConversationMessageEventTopicErrorBody**](ConversationMessageEventTopicErrorBody.html) |  | [optional] |
| **Script** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference.html) |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] |
| **AlertingTimeoutMs** | **int?** |  | [optional] |
| **Provider** | **string** |  | [optional] |
| **ExternalContact** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference.html) |  | [optional] |
| **ExternalOrganization** | [**ConversationMessageEventTopicUriReference**](ConversationMessageEventTopicUriReference.html) |  | [optional] |
| **Wrapup** | [**ConversationMessageEventTopicWrapup**](ConversationMessageEventTopicWrapup.html) |  | [optional] |
| **ConversationRoutingData** | [**ConversationMessageEventTopicConversationRoutingData**](ConversationMessageEventTopicConversationRoutingData.html) |  | [optional] |
| **Peer** | **string** |  | [optional] |
| **ScreenRecordingState** | **string** |  | [optional] |
| **FlaggedReason** | **string** |  | [optional] |
| **JourneyContext** | [**ConversationMessageEventTopicJourneyContext**](ConversationMessageEventTopicJourneyContext.html) |  | [optional] |
| **Messages** | [**List&lt;ConversationMessageEventTopicMessageDetails&gt;**](ConversationMessageEventTopicMessageDetails.html) |  | [optional] |
| **Type** | **string** |  | [optional] |
| **RecipientCountry** | **string** |  | [optional] |
| **RecipientType** | **string** |  | [optional] |
{: class="table table-striped"}


