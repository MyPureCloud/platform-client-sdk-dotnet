# CreateWebChatConversationRequest

## ININ.PureCloudApi.Model.CreateWebChatConversationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **OrganizationId** | **string** | The organization identifier. | |
| **DeploymentId** | **string** | The web chat Deployment ID which contains the appropriate settings for this chat conversation. | |
| **RoutingTarget** | [**WebChatRoutingTarget**](WebChatRoutingTarget) | The routing information to use for the new chat conversation. | |
| **MemberInfo** | [**GuestMemberInfo**](GuestMemberInfo) | The guest member info to use for the new chat conversation. | |
| **MemberAuthToken** | **string** | If the guest member is an authenticated member (ie, not anonymous) his JWT is provided here. The token will have been previously generated with the \&quot;POST /api/v2/signeddata\&quot; resource. | [optional] |
| **JourneyContext** | [**JourneyContext**](JourneyContext) | A subset of the Journey System&#39;s data relevant to this conversation/session request (for external linkage and internal usage/context). | [optional] |



_PureCloudPlatform.Client.V2 216.0.0_
