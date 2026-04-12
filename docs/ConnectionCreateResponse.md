# ConnectionCreateResponse

## ININ.PureCloudApi.Model.ConnectionCreateResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the connection. | [optional] |
| **Type** | **string** | Type of the connection. | [optional] |
| **Integration** | [**KnowledgeIntegrationReference**](KnowledgeIntegrationReference) | The reference to the integration associated with the connection. | [optional] |
| **AuthenticationProperties** | [**AuthenticationProperties**](AuthenticationProperties) | Authentication properties which can be used to initiate authentication of a user. | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | Reference of the creator. | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference) | Reference of the user whom modified the connection. | [optional] |
| **DateCreated** | **DateTime?** | Date of the creation of connection. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date of the last modification made to the connection. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Status** | **string** | Current status of the connection. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 262.0.0_
