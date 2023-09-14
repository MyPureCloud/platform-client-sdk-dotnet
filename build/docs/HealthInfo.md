---
title: HealthInfo
---
## ININ.PureCloudApi.Model.HealthInfo

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | Status of health computation for this intent. | [optional] |
| **ErrorInfo** | [**FlowHealthErrorInfo**](FlowHealthErrorInfo.html) | Error details for the intent, if any. | [optional] |
| **OverallScore** | **float?** | Overall health score for the intent ranged between 0 and 100 as 100 is the perfect health score. | [optional] |
| **IssueCount** | **long?** | Number of issues found in the intent. | [optional] |
| **StaticValidationResults** | **List&lt;string&gt;** | Validation results for the intent. | [optional] |
| **Utterances** | [**List&lt;FlowHealthIntentUtterance&gt;**](FlowHealthIntentUtterance.html) | Utterances for this intent. | [optional] |
{: class="table table-striped"}


