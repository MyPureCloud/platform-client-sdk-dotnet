# NuanceBot

## ININ.PureCloudApi.Model.NuanceBot

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Nuance bot Id | |
| **Name** | **string** | Nuance bot name | |
| **IntegrationId** | **string** | The Integration Id for this bot | |
| **NuanceOrganization** | [**NuanceOrganization**](NuanceOrganization) | The Nuance Organization for this bot | |
| **Application** | [**NuanceApplication**](NuanceApplication) | The Application for this bot | |
| **NuanceEnvironment** | [**NuanceEnvironment**](NuanceEnvironment) | The environment of the Nuance bot | |
| **Geography** | [**NuanceGeography**](NuanceGeography) | The Geography of the Nuance bot | |
| **Credentials** | [**List&lt;NuanceBotCredentials&gt;**](NuanceBotCredentials) | client ID/Secret objects for the credentials that execute this Nuance bot | [optional] |
| **Variables** | [**List&lt;NuanceBotVariable&gt;**](NuanceBotVariable) | List of available variables in this Nuance bot.  When querying, use the &#39;expand&#x3D;variables&#39; query param to populate this value | [optional] |
| **TransferNodes** | [**List&lt;NuanceBotTransferNode&gt;**](NuanceBotTransferNode) | List of transferNodes in this Nuance bot.  When querying, use the &#39;expand&#x3D;transferNodes&#39; query param to populate this value | [optional] |
| **Locales** | **List&lt;string&gt;** | List of locales associated with this Nuance bot.  Generally in the ISO format such as &#39;en-US&#39; | [optional] |
| **Channels** | [**List&lt;NuanceChannel&gt;**](NuanceChannel) | List of channels associated with this Nuance bot. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
