# IntegrationType

## ININ.PureCloudApi.Model.IntegrationType

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The ID of the integration type. | |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | Description of the integration type. | [optional] |
| **Provider** | **string** | PureCloud provider of the integration type. | [optional] |
| **Category** | **string** | Category describing the integration type. | [optional] |
| **Images** | [**List&lt;Image&gt;**](Image) | Collection of logos. | [optional] |
| **ConfigPropertiesSchemaUri** | **string** | URI of the schema describing the key-value properties needed to configure an integration of this type. | [optional] |
| **ConfigAdvancedSchemaUri** | **string** | URI of the schema describing the advanced JSON document needed to configure an integration of this type. | [optional] |
| **HelpUri** | **string** | URI of a page with more information about the integration type | [optional] |
| **TermsOfServiceUri** | **string** | URI of a page with terms and conditions for the integration type | [optional] |
| **VendorName** | **string** | Name of the vendor of this integration type | [optional] |
| **VendorWebsiteUri** | **string** | URI of the vendor&#39;s website | [optional] |
| **MarketplaceUri** | **string** | URI of the marketplace listing for this integration type | [optional] |
| **FaqUri** | **string** | URI of frequently asked questions about the integration type | [optional] |
| **PrivacyPolicyUri** | **string** | URI of a privacy policy for users of the integration type | [optional] |
| **SupportContactUri** | **string** | URI for vendor support | [optional] |
| **SalesContactUri** | **string** | URI for vendor sales information | [optional] |
| **HelpLinks** | [**List&lt;HelpLink&gt;**](HelpLink) | List of links to additional help resources | [optional] |
| **Credentials** | [**Dictionary&lt;string, CredentialSpecification&gt;**](CredentialSpecification) | Map of credentials for integrations of this type. The key is the name of a credential that can be provided in the credentials property of the integration configuration. | [optional] |
| **NonInstallable** | **bool?** | Indicates if the integration type is installable or not. | [optional] |
| **MaxInstances** | **int?** | The maximum number of integration instances allowable for this integration type | [optional] |
| **UserPermissions** | **List&lt;string&gt;** | List of permissions required to permit user access to the integration type. | [optional] |
| **VendorOAuthClientIds** | **List&lt;string&gt;** | List of OAuth Client IDs that must be authorized when the integration is created. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 253.0.0_
