# ContactImportSettings

## ININ.PureCloudApi.Model.ContactImportSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Display name for the settings | |
| **MatchingCriteria** | **List&lt;string&gt;** | Which fields you want to identity resolution based on. (e.g.: Email, Phone). It can be empty, populated only one of them or it can be both for now. The order of the items is important for identity resolution | [optional] |
| **MergeContacts** | **bool?** | Decides what happens when a record already found in the system. Action will be Upsert or Merge | |
| **ExternalSourceId** | **string** | Define the corresponding source system by the customer, the customer can have different externalId source, they can collect this id from contact service | |
| **ImportFields** | [**List&lt;ContactImportField&gt;**](ContactImportField) | Decides which field we need to send towards contact service | |
| **DateCreated** | **DateTime?** | Creation date for the settings. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 224.0.0_
