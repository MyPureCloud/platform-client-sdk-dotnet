# UpdateDraftInput

## ININ.PureCloudApi.Model.UpdateDraftInput

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Category** | **string** | Category of action, Can be up to 256 characters long | [optional] |
| **Name** | **string** | Name of action, Can be up to 256 characters long | [optional] |
| **Config** | [**ActionConfig**](ActionConfig) | Configuration to support request and response processing | [optional] |
| **Contract** | [**ActionContractInput**](ActionContractInput) | Action contract | [optional] |
| **Secure** | **bool?** | Indication of whether or not the action is designed to accept sensitive data | [optional] |
| **Version** | **int?** | Version of current Draft | |



_PureCloudPlatform.Client.V2 244.0.0_
