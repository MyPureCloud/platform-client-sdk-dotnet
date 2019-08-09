---
title: LocationDefinition
---
## ININ.PureCloudApi.Model.LocationDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Location. | |
| **EmergencyNumber** | [**LocationEmergencyNumber**](LocationEmergencyNumber.html) |  | [optional] |
| **Address** | [**LocationAddress**](LocationAddress.html) |  | [optional] |
| **AddressVerified** | **bool?** |  | [optional] |
| **State** | **string** | Current activity status of the location. | [optional] |
| **Notes** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **Path** | **List&lt;string&gt;** | A list of ancestor IDs in order | [optional] |
| **ProfileImage** | [**List&lt;LocationImage&gt;**](LocationImage.html) | Profile image set for the location | [optional] |
| **FloorplanImage** | [**List&lt;LocationImage&gt;**](LocationImage.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


