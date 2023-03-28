---
title: CallbackMediaSettings
---
## ININ.PureCloudApi.Model.CallbackMediaSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **EnableAutoAnswer** | **bool?** | Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings. | [optional] |
| **AlertingTimeoutSeconds** | **int?** |  | [optional] |
| **ServiceLevel** | [**ServiceLevel**](ServiceLevel.html) |  | [optional] |
| **SubTypeSettings** | [**Dictionary&lt;string, BaseMediaSettings&gt;**](BaseMediaSettings.html) | Map of media subtype to media subtype specific settings. | [optional] |
{: class="table table-striped"}


