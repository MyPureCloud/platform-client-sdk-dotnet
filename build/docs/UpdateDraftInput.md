---
title: UpdateDraftInput
---
## ININ.PureCloudApi.Model.UpdateDraftInput

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Category** | **string** | Category of action, Can be up to 256 characters long | [optional] |
| **Name** | **string** | Name of action, Can be up to 256 characters long | [optional] |
| **Config** | [**ActionConfig**](ActionConfig.html) | Configuration to support request and response processing | [optional] |
| **Contract** | [**ActionContractInput**](ActionContractInput.html) | Action contract | [optional] |
| **Secure** | **bool?** | Indication of whether or not the action is designed to accept sensitive data | [optional] |
| **Version** | **int?** | Version of current Draft | |
{: class="table table-striped"}


