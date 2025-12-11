# MessageMediaPolicyConditions

## ININ.PureCloudApi.Model.MessageMediaPolicyConditions

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ForUsers** | [**List&lt;PolicyUser&gt;**](PolicyUser) | List of users to apply this policy to. Each user object can include the &#39;id&#39; field containing the user&#39;s unique identifier. Example: [{\&quot;id\&quot;:\&quot;&lt;userId&gt;\&quot;}]. | [optional] |
| **DateRanges** | **List&lt;string&gt;** |  | [optional] |
| **ForQueues** | [**List&lt;Queue&gt;**](Queue) |  | [optional] |
| **WrapupCodes** | [**List&lt;WrapupCode&gt;**](WrapupCode) |  | [optional] |
| **Languages** | [**List&lt;Language&gt;**](Language) |  | [optional] |
| **TimeAllowed** | [**TimeAllowed**](TimeAllowed) |  | [optional] |
| **Teams** | [**List&lt;Team&gt;**](Team) | Teams to match conversations against | [optional] |
| **CustomerParticipation** | **string** |  | [optional] |



_PureCloudPlatform.Client.V2 251.0.0_
