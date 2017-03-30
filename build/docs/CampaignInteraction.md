---
title: CampaignInteraction
---
## ININ.PureCloudApi.Model.CampaignInteraction

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Campaign** | [**UriReference**](UriReference.html) |  | [optional] |
| **Agent** | [**UriReference**](UriReference.html) |  | [optional] |
| **Contact** | [**UriReference**](UriReference.html) |  | [optional] |
| **DestinationAddress** | **string** |  | [optional] |
| **ActivePreviewCall** | **bool?** | Boolean value if there is an active preview call on the interaction | [optional] |
| **LastActivePreviewWrapupTime** | **DateTime?** | The time when the last preview of the interaction was wrapped up. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreationTime** | **DateTime?** | The time when dialer created the interaction. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CallPlacedTime** | **DateTime?** | The time when the agent or system places the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CallRoutedTime** | **DateTime?** | The time when the agent was connected to the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **PreviewConnectedTime** | **DateTime?** | The time when the customer and routing participant are connected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Queue** | [**UriReference**](UriReference.html) |  | [optional] |
| **Script** | [**UriReference**](UriReference.html) |  | [optional] |
| **Disposition** | **string** | Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer | [optional] |
| **CallerName** | **string** |  | [optional] |
| **CallerAddress** | **string** |  | [optional] |
| **PreviewPopDeliveredTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Conversation** | [**ConversationBasic**](ConversationBasic.html) |  | [optional] |
| **DialerSystemParticipantId** | **string** | conversation participant id that is the dialer system participant to monitor the call from dialer perspective | [optional] |
| **DialingMode** | **string** |  | [optional] |
| **Skills** | [**List&lt;UriReference&gt;**](UriReference.html) | Any skills that are attached to the call for routing | [optional] |
{: class="table table-striped"}


