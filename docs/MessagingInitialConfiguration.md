# MessagingInitialConfiguration

## ININ.PureCloudApi.Model.MessagingInitialConfiguration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ToAddress** | **string** | Address for the participant on receiving side of the message conversation. If the address is a phone number, E.164 format is recommended. | |
| **FromAddress** | **string** | Address for the participant on the sending side of the message conversation. If the address is a phone number, E.164 format is recommended. | |
| **MessageType** | **string** | The type of message platform from which the message originated. | [optional] |
| **Held** | **bool?** | Indicates that this communication&#39;s initial state is held. | [optional] |
| **Alerting** | **bool?** | Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state. | [optional] |
| **Inbound** | **bool?** | Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND. | [optional] |
| **InvitedBy** | **string** | The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred. | [optional] |
| **AdditionalInfo** | **Dictionary&lt;string, string&gt;** | Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields. | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
