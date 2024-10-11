# MessagingSetting

## ININ.PureCloudApi.Model.MessagingSetting

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The messaging Setting unique identifier associated with this integration | |
| **Name** | **string** | The messaging Setting profile name | [optional] |
| **DateCreated** | **DateTime?** | Date this messaging setting was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this messaging setting was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **string** | Version number | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that created this Setting | [optional] |
| **UpdatedBy** | [**DomainEntityRef**](DomainEntityRef) | User reference that modified this Setting | [optional] |
| **Content** | [**ContentSetting**](ContentSetting) | Configuration relating to message contents | [optional] |
| **Event** | [**EventSetting**](EventSetting) | Configuration relating to events which may occur | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 218.0.0_
