# AssignmentValidation

## ININ.PureCloudApi.Model.AssignmentValidation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MembersNotAssigned** | [**List&lt;UserReference&gt;**](UserReference) | The list of users that are not assigned to any custom performance profile | [optional] |
| **MembersAlreadyAssigned** | [**List&lt;UserReference&gt;**](UserReference) | The list of users that are already assigned to the requesting custom performance profile | [optional] |
| **MembersAlreadyAssignedToOther** | [**List&lt;OtherProfileAssignment&gt;**](OtherProfileAssignment) | The list of users that are already assigned to other custom performance profiles | [optional] |
| **InvalidMemberAssignments** | [**List&lt;InvalidAssignment&gt;**](InvalidAssignment) | The list of user id that are invalid for the gamfication service to handle | [optional] |



_PureCloudPlatform.Client.V2 249.0.0_
