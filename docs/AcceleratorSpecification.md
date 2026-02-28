# AcceleratorSpecification

## ININ.PureCloudApi.Model.AcceleratorSpecification

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | name of this accelerator | [optional] |
| **Description** | **string** | a description of the general purpose of this accelerator | [optional] |
| **Origin** | **string** | where the accelerator originated | [optional] |
| **Type** | **string** | type of the artifact | [optional] |
| **Classification** | **string** | architectural classification into which the accelerator belongs | [optional] |
| **Tags** | **List&lt;string&gt;** | tags | [optional] |
| **Permissions** | **List&lt;string&gt;** | Genesys Cloud permissions required to install the accelerator | [optional] |
| **Products** | **List&lt;string&gt;** | Genesys Cloud products required to install the accelerator | [optional] |
| **Documentation** | [**List&lt;MetadataDocumentation&gt;**](MetadataDocumentation) | additional documentation about the artifact | [optional] |
| **Presentation** | [**List&lt;MetadataPresentation&gt;**](MetadataPresentation) | presentation of data fields to be gathered for the accelerator | [optional] |
| **Results** | [**MetadataResults**](MetadataResults) | resources created or modified as a result of running the accelerator | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
