# Geolocation

## ININ.PureCloudApi.Model.Geolocation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** | A string used to describe the type of client the geolocation is being updated from e.g. ios, android, web, etc. | [optional] |
| **Primary** | **bool?** | A boolean used to tell whether or not to set this geolocation client as the primary on a PATCH | [optional] |
| **Latitude** | **double?** |  | [optional] |
| **Longitude** | **double?** |  | [optional] |
| **Country** | **string** |  | [optional] |
| **Region** | **string** |  | [optional] |
| **City** | **string** |  | [optional] |
| **Locations** | [**List&lt;LocationDefinition&gt;**](LocationDefinition) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
