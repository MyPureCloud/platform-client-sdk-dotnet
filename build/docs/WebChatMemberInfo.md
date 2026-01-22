# WebChatMemberInfo

## ININ.PureCloudApi.Model.WebChatMemberInfo

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The communicationId of this member. | [optional] |
| **DisplayName** | **string** | The display name of the member. | [optional] |
| **FirstName** | **string** | The first name of the member. | [optional] |
| **LastName** | **string** | The last name of the member. | [optional] |
| **Email** | **string** | The email address of the member. | [optional] |
| **PhoneNumber** | **string** | The phone number of the member. | [optional] |
| **AvatarImageUrl** | **string** | The url to the avatar image of the member. | [optional] |
| **Role** | **string** | The role of the member, one of [agent, customer, acd, workflow] | |
| **JoinDate** | **DateTime?** | The time the member joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LeaveDate** | **DateTime?** | The time the member left the conversation, or null if the member is still active in the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AuthenticatedGuest** | **bool?** | If true, the guest member is an authenticated guest. | [optional] |
| **CustomFields** | **Dictionary&lt;string, string&gt;** | Any custom fields of information pertaining to this member. | [optional] |
| **State** | **string** | The connection state of this member. | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
