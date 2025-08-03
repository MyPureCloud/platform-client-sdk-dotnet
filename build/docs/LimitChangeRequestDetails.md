# LimitChangeRequestDetails

## ININ.PureCloudApi.Model.LimitChangeRequestDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Key** | **string** | Limit key to be overridden (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits) | |
| **Namespace** | **string** | Namespace the key belongs to (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits) | |
| **RequestedValue** | **double?** | Requested limit value for a given key | |
| **Description** | **string** | Description of the need for the limit change request | |
| **SupportCaseUrl** | **string** | The support case url created by Care | |
| **Status** | **string** | Current status of the limit change request | [optional] |
| **CurrentValue** | **double?** | Current limit value for a given key | [optional] |
| **DateCreated** | **DateTime?** | The date of the limit change request creation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **StatusHistory** | [**List&lt;StatusChange&gt;**](StatusChange) | List of statuses that a limit change request has gone through | [optional] |
| **DateCompleted** | **DateTime?** | The date of the limit change request completion (ChangeImplemented, Rejected, or RollbackImplemented. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **RejectReason** | **string** | The reason for rejecting the limit override request | [optional] |
| **ApprovalNamespaces** | [**List&lt;ApprovalNamespace&gt;**](ApprovalNamespace) | The approval breakdown for this override request. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 239.0.0_
