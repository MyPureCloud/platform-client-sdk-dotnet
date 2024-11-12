# EmailInitialConfiguration

## ININ.PureCloudApi.Model.EmailInitialConfiguration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **To** | **string** | An email address that this email is to. | |
| **From** | **string** | An email address that this email is from. | |
| **Cc** | **List&lt;string&gt;** | An email addresses that this email is carbon copied to. | [optional] |
| **Bcc** | **List&lt;string&gt;** | An email addresses that this email is blind carbon copied to. | [optional] |
| **Subject** | **string** | The subject for this email. | [optional] |
| **PreviousEmailId** | **string** | UUID identifying the most recent previous email communication ID from the same participant on this email conversation. Will be null if this is a new participant. | [optional] |
| **Held** | **bool?** | Indicates that this communication&#39;s initial state is held. | [optional] |
| **Alerting** | **bool?** | Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state. | [optional] |
| **Inbound** | **bool?** | Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND. | [optional] |
| **InvitedBy** | **string** | The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred. | [optional] |
| **AdditionalInfo** | **Dictionary&lt;string, string&gt;** | Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields. | [optional] |



_PureCloudPlatform.Client.V2 221.0.0_
