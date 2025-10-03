# MaskingRule

## ININ.PureCloudApi.Model.MaskingRule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Masking rule name. | |
| **Description** | **string** | Description about masking rule. | [optional] |
| **SubstituteCharacter** | **string** | Replacement character for masked text character. | |
| **Definition** | **string** | Definition of masking rule (a valid regex or builtin AI based mask name). | |
| **Enabled** | **bool?** | True/False | |
| **Type** | **string** | Masking rule type | |
| **Direction** | **string** | inbound/outbound | [optional] |
| **Integrations** | **List&lt;string&gt;** | Associated integration channels | [optional] |
| **DateCreated** | **DateTime?** | Date when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date when the rule was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
