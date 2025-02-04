# Action

## ININ.PureCloudApi.Model.Action

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **IntegrationId** | **string** | The ID of the integration for which this action is associated | [optional] |
| **Category** | **string** | Category of Action | [optional] |
| **Contract** | [**ActionContract**](ActionContract) | Action contract | [optional] |
| **Version** | **int?** | Version of this action | [optional] |
| **Secure** | **bool?** | Indication of whether or not the action is designed to accept sensitive data | [optional] |
| **Config** | [**ActionConfig**](ActionConfig) | Configuration to support request and response processing | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
