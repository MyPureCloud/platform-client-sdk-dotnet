# CaseplanFilter

## ININ.PureCloudApi.Model.CaseplanFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Attribute name. Valid values: id, name, divisionId, published. The published filter requires the EQ operator and exactly one value: &#39;true&#39; (Caseplans that have a published version) or &#39;false&#39; (Caseplans that have never been published). | |
| **Operator** | **string** | Filter operator. | |
| **Values** | **List&lt;string&gt;** | List of values to be used in the filter. | |



_PureCloudPlatform.Client.V2 276.0.0_
