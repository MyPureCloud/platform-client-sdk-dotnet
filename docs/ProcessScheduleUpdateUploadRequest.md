# ProcessScheduleUpdateUploadRequest

## ININ.PureCloudApi.Model.ProcessScheduleUpdateUploadRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **UploadKey** | **string** | The uploadKey provided by the request to get an upload URL | |
| **TeamIds** | **List&lt;string&gt;** | The list of teams to which the users being modified belong. Only required if the requesting user has conditional permission to wfm:schedule:edit | [optional] |
| **ManagementUnitIdsForAddedTeamUsers** | **List&lt;string&gt;** | The set of muIds to which agents belong if agents are being newly added to the schedule, if the requesting user has conditional permission to wfm:schedule:edit | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
