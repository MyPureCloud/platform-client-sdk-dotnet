# AnalyticsParticipant

## ININ.PureCloudApi.Model.AnalyticsParticipant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ExternalContactId** | **string** | External contact identifier | [optional] |
| **ExternalOrganizationId** | **string** | External organization identifier | [optional] |
| **FlaggedReason** | **string** | Reason for which participant flagged conversation | [optional] |
| **ParticipantId** | **string** | Unique identifier for the participant | [optional] |
| **ParticipantName** | **string** | A human readable name identifying the participant | [optional] |
| **Purpose** | **string** | The participant&#39;s purpose | [optional] |
| **ScreenRecording** | **bool?** | Flag determining if a screen recording was started or not | [optional] |
| **TeamId** | **string** | The team ID the user is a member of | [optional] |
| **UserId** | **string** | Unique identifier for the user | [optional] |
| **Sessions** | [**List&lt;AnalyticsSession&gt;**](AnalyticsSession) | List of sessions associated to this participant | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | List of attributes associated to this participant | [optional] |



_PureCloudPlatform.Client.V2 230.0.0_
