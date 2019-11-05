---
title: LocationCreateUpdateDefinition
---
## ININ.PureCloudApi.Model.LocationCreateUpdateDefinition

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the Location. | |
| **Version** | **int?** | Current version of the location | [optional] |
| **State** | **string** | Current activity status of the location. | [optional] |
| **Path** | **List&lt;string&gt;** | A list of ancestor ids | [optional] |
| **AddressVerified** | **bool?** |  | [optional] |
| **Notes** | **string** | Notes for the location | [optional] |
| **ContactUser** | **string** | The user id of the location contact | [optional] |
| **EmergencyNumber** | [**LocationEmergencyNumber**](LocationEmergencyNumber.html) | Emergency number for the location | [optional] |
| **Address** | [**LocationAddress**](LocationAddress.html) | Address of the location | [optional] |
{: class="table table-striped"}


