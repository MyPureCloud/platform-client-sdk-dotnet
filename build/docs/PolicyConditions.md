---
title: PolicyConditions
---
## ININ.PureCloudApi.Model.PolicyConditions

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ForUsers** | [**List&lt;User&gt;**](User.html) |  | [optional] |
| **Directions** | **List&lt;string&gt;** |  | [optional] |
| **DateRanges** | **List&lt;string&gt;** |  | [optional] |
| **MediaTypes** | **List&lt;string&gt;** |  | [optional] |
| **ForQueues** | [**List&lt;Queue&gt;**](Queue.html) |  | [optional] |
| **Duration** | [**DurationCondition**](DurationCondition.html) |  | [optional] |
| **WrapupCodes** | [**List&lt;WrapupCode&gt;**](WrapupCode.html) |  | [optional] |
| **TimeAllowed** | [**TimeAllowed**](TimeAllowed.html) |  | [optional] |
| **Teams** | [**List&lt;Team&gt;**](Team.html) | Teams to match conversations against | [optional] |
| **CustomerParticipation** | **string** | This condition is to filter out conversation with and without customer participation. | [optional] |
{: class="table table-striped"}


