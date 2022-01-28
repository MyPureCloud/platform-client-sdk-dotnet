---
title: AssignmentValidation
---
## ININ.PureCloudApi.Model.AssignmentValidation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MembersNotAssigned** | [**List&lt;UserReference&gt;**](UserReference.html) | The list of users that are not assigned to any custom performance profile | [optional] |
| **MembersAlreadyAssigned** | [**List&lt;UserReference&gt;**](UserReference.html) | The list of users that are already assigned to the requesting custom performance profile | [optional] |
| **MembersAlreadyAssignedToOther** | [**List&lt;OtherProfileAssignment&gt;**](OtherProfileAssignment.html) | The list of users that are already assigned to other custom performance profiles | [optional] |
| **InvalidMemberAssignments** | [**List&lt;InvalidAssignment&gt;**](InvalidAssignment.html) | The list of user id that are invalid for the gamfication service to handle | [optional] |
{: class="table table-striped"}


