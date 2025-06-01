# Schema

## ININ.PureCloudApi.Model.Schema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Title** | **string** | A core type&#39;s title | [optional] |
| **Description** | **string** | A core type&#39;s description | [optional] |
| **Type** | **List&lt;string&gt;** | An array of fundamental JSON Schema primitive types on which the core type is based | [optional] |
| **Items** | [**Items**](Items) | Denotes the type and pattern of the items in an enum core type | [optional] |
| **Pattern** | **string** | For the \&quot;date\&quot; and \&quot;datetime\&quot; core types, denotes the regex prescribing the allowable date/datetime format | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
