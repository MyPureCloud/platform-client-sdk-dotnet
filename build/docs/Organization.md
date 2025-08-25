# Organization

## ININ.PureCloudApi.Model.Organization

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DefaultLanguage** | **string** | The default language for this organization. Example: &#39;en&#39; | [optional] |
| **DefaultCountryCode** | **string** | The default country code for this organization. Example: &#39;US&#39; | [optional] |
| **ThirdPartyOrgName** | **string** | The short name for the organization. This field is globally unique and cannot be changed. | [optional] |
| **ThirdPartyURI** | **string** |  | [optional] |
| **Domain** | **string** |  | [optional] |
| **Version** | **int?** | The current version of the organization. | |
| **State** | **string** | The current state. Examples are active, inactive, deleted. | [optional] |
| **DefaultSiteId** | **string** |  | [optional] |
| **SupportURI** | **string** | Email address where support tickets are sent to. | [optional] |
| **VoicemailEnabled** | **bool?** |  | [optional] |
| **ProductPlatform** | **string** | Organizations Originating Platform. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Features** | **Dictionary&lt;string, bool?&gt;** | The state of features available for the organization. | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
