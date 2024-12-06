# FlowHealthUtterance

## ININ.PureCloudApi.Model.FlowHealthUtterance

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Text** | **string** | Utterance Text. | [optional] |
| **IssueCount** | **long?** | Number of issues found for this utterance. | [optional] |
| **Language** | **string** | Language provided for this utterance&#39;s health. | [optional] |
| **StaticValidationResults** | **List&lt;string&gt;** | Validation results for the utterance. | [optional] |
| **OutlierInfo** | [**OutlierInfo**](OutlierInfo) | Details about this utterance being an outlier or not. | [optional] |
| **ConfusionInfo** | [**ConfusionDetails**](ConfusionDetails) | Confusion details with other utterances. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 222.0.0_
