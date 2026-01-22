# NamedEntityTypeMechanism

## ININ.PureCloudApi.Model.NamedEntityTypeMechanism

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Items** | [**List&lt;NamedEntityTypeItem&gt;**](NamedEntityTypeItem) | The items that define the named entity type. | |
| **Restricted** | **bool?** | Whether the named entity type is restricted to the items provided. Default: false | [optional] |
| **Type** | **string** | The type of the mechanism. | |
| **SubType** | **string** | Subtype of detection mechanism | [optional] |
| **MaxLength** | **int?** | The maximum length of the entity resolved value | [optional] |
| **MinLength** | **int?** | The minimum length of the entity resolved value | [optional] |
| **AllowSpecialChars** | **bool?** | Flag whether to allow for special characters during AI slot capture | [optional] |
| **Examples** | [**List&lt;NamedEntityTypeMechanismExample&gt;**](NamedEntityTypeMechanismExample) | Examples for entity detection | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
