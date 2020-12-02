---
title: ActionTarget
---
## ININ.PureCloudApi.Model.ActionTarget

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **UserData** | [**List&lt;KeyValue&gt;**](KeyValue.html) | Additional user data associated with the target in key/value format. | [optional] |
| **SupportedMediaTypes** | **List&lt;string&gt;** | Supported media types of the target. | [optional] |
| **State** | **string** | Indicates the state of the target. | [optional] |
| **Description** | **string** | Description of the target. | [optional] |
| **ServiceLevel** | [**ServiceLevel**](ServiceLevel.html) | Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level. | [optional] |
| **ShortAbandonThreshold** | **int?** | Indicates the non-default short abandon threshold | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | The date the target was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedDate** | **DateTime?** | The date the target was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
{: class="table table-striped"}


