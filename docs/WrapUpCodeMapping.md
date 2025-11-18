# WrapUpCodeMapping

## ININ.PureCloudApi.Model.WrapUpCodeMapping

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **DefaultSet** | **List&lt;string&gt;** | The default set of wrap-up flags. These will be used if there is no entry for a given wrap-up code in the mapping. | [optional] |
| **Mapping** | [**Dictionary&lt;string, List&lt;string&gt;&gt;**](Set) | A map from wrap-up code identifiers to a set of wrap-up flags. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
