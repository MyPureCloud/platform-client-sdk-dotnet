# CreateUser

## ININ.PureCloudApi.Model.CreateUser

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | User&#39;s full name | |
| **Department** | **string** |  | [optional] |
| **Email** | **string** | User&#39;s email and username | |
| **Addresses** | [**List&lt;Contact&gt;**](Contact) | Email addresses and phone numbers for this user | [optional] |
| **Title** | **string** |  | [optional] |
| **Password** | **string** | User&#39;s password | [optional] |
| **DivisionId** | **string** | The division to which this user will belong | |
| **State** | **string** | Optional initialized state of the user. If not specified, state will be Active if invites are sent, otherwise Inactive. | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
