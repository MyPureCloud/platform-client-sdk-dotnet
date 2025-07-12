# DncListDivisionView

## ININ.PureCloudApi.Model.DncListDivisionView

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Division** | [**Division**](Division) | The division to which this entity belongs. | [optional] |
| **ImportStatus** | [**ImportStatus**](ImportStatus) | The status of the import process. | [optional] |
| **Size** | **long?** | The number of contacts in the DncList. | [optional] |
| **DncSourceType** | **string** | The type of the DncList. | [optional] |
| **ContactMethod** | **string** | The contact method. Required if dncSourceType is rds. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
