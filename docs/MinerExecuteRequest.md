# MinerExecuteRequest

## ININ.PureCloudApi.Model.MinerExecuteRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **DateStart** | **String** | Start date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEnd** | **String** | End date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **UploadKey** | **string** | Location of input conversations. | [optional] |
| **MediaType** | **string** | Media type for filtering conversations. | [optional] |
| **ParticipantType** | **string** | Type of the participant, either agent, customer or both. | [optional] |
| **QueueIds** | **List&lt;string&gt;** | List of queue IDs for filtering conversations. | [optional] |



_PureCloudPlatform.Client.V2 229.0.0_
