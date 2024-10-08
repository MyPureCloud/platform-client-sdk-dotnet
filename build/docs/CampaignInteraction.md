# CampaignInteraction

## ININ.PureCloudApi.Model.CampaignInteraction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Campaign** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Agent** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Contact** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **DestinationAddress** | **string** |  | [optional] |
| **ActivePreviewCall** | **bool?** | Boolean value if there is an active preview call on the interaction | [optional] |
| **LastActivePreviewWrapupTime** | **DateTime?** | The time when the last preview of the interaction was wrapped up. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreationTime** | **DateTime?** | The time when dialer created the interaction. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CallPlacedTime** | **DateTime?** | The time when the agent or system places the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CallRoutedTime** | **DateTime?** | The time when the agent was connected to the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **PreviewConnectedTime** | **DateTime?** | The time when the customer and routing participant are connected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Queue** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Script** | [**DomainEntityRef**](DomainEntityRef) |  | [optional] |
| **Disposition** | **string** | Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer | [optional] |
| **CallerName** | **string** |  | [optional] |
| **CallerAddress** | **string** |  | [optional] |
| **PreviewPopDeliveredTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Conversation** | [**ConversationBasic**](ConversationBasic) |  | [optional] |
| **DialerSystemParticipantId** | **string** | conversation participant id that is the dialer system participant to monitor the call from dialer perspective | [optional] |
| **DialingMode** | **string** |  | [optional] |
| **Skills** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) | Any skills that are attached to the call for routing | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
