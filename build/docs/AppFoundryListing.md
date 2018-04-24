---
title: AppFoundryListing
---
## ININ.PureCloudApi.Model.AppFoundryListing

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | [**LocalizedField**](LocalizedField.html) | Localized name | [optional] |
| **RegistryInfo** | [**AppFoundryListingRegistryInfo**](AppFoundryListingRegistryInfo.html) | Provides information about the integration implementation | [optional] |
| **MarketingInfo** | [**MarketingInfo**](MarketingInfo.html) | Marketing data | [optional] |
| **Tagline** | [**LocalizedField**](LocalizedField.html) | Localized tagline | [optional] |
| **BriefDescription** | [**LocalizedField**](LocalizedField.html) | Localized short description | [optional] |
| **FullDescription** | [**LocalizedField**](LocalizedField.html) | Localized full description | [optional] |
| **Platform** | [**Platform**](Platform.html) | The supported platform | [optional] |
| **CompanyLogo** | **string** | URL to the company logo to be displayed | [optional] |
| **AppLogo** | **string** | URL to the app logo to be displayed | [optional] |
| **CompanyName** | [**LocalizedField**](LocalizedField.html) | Localized company name for the listing publisher | [optional] |
| **Website** | [**LocalizedField**](LocalizedField.html) | Localized URL to the website associated with the listing | [optional] |
| **Screenshots** | **List&lt;string&gt;** | Screenshot URLS | [optional] |
| **VideoLinks** | **List&lt;string&gt;** | Usage video URLS | [optional] |
| **Languages** | **List&lt;string&gt;** | Indicates the languages that the application supports. Supported application languages may differ from the listing localization languages | [optional] |
| **VendorEmail** | **string** | Contact email for the listing publisher | [optional] |
| **TermsOfService** | **string** | URL to the terms of service | [optional] |
| **HelpDocumentationURL** | [**LocalizedField**](LocalizedField.html) | URL to help documentation | [optional] |
| **MarketingURL** | [**LocalizedField**](LocalizedField.html) | URL to external marketing page | [optional] |
| **Industries** | **List&lt;string&gt;** | Industries targeted | [optional] |
| **Categories** | **List&lt;string&gt;** | Indicated the categories the listing belongs to | [optional] |
| **SmartCases** | [**List&lt;SmartCase&gt;**](SmartCase.html) | Use cases the listing is meant to address | [optional] |
| **Pricing** | [**List&lt;PricingOption&gt;**](PricingOption.html) | Pricing options for the listing | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


