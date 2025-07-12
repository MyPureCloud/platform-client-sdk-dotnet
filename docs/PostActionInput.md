# PostActionInput

## ININ.PureCloudApi.Model.PostActionInput

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Category** | **string** | Category of action, Can be up to 256 characters long | |
| **Name** | **string** | Name of action, Can be up to 256 characters long | |
| **IntegrationId** | **string** | The ID of the integration this action is associated to | |
| **Config** | [**ActionConfig**](ActionConfig) | Configuration to support request and response processing | |
| **Contract** | [**ActionContractInput**](ActionContractInput) | Action contract | |
| **Secure** | **bool?** | Indication of whether or not the action is designed to accept sensitive data | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
