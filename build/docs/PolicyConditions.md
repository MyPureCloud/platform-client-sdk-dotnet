# PolicyConditions

## ININ.PureCloudApi.Model.PolicyConditions

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ForUsers** | [**List&lt;User&gt;**](User) |  | [optional] |
| **Directions** | **List&lt;string&gt;** |  | [optional] |
| **DateRanges** | **List&lt;string&gt;** |  | [optional] |
| **MediaTypes** | **List&lt;string&gt;** |  | [optional] |
| **ForQueues** | [**List&lt;Queue&gt;**](Queue) |  | [optional] |
| **Duration** | [**DurationCondition**](DurationCondition) |  | [optional] |
| **WrapupCodes** | [**List&lt;WrapupCode&gt;**](WrapupCode) |  | [optional] |
| **TimeAllowed** | [**TimeAllowed**](TimeAllowed) |  | [optional] |
| **Teams** | [**List&lt;Team&gt;**](Team) | Teams to match conversations against | [optional] |
| **CustomerParticipation** | **string** | This condition is to filter out conversation with and without customer participation. | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
