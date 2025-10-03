# CampaignProgress

## ININ.PureCloudApi.Model.CampaignProgress

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Campaign** | [**DomainEntityRef**](DomainEntityRef) | Identifier of the campaign | |
| **ContactList** | [**DomainEntityRef**](DomainEntityRef) | Identifier of the contact list | |
| **NumberOfContactsCalled** | **long?** | Number of contacts called during the campaign | [optional] |
| **NumberOfContactsMessaged** | **long?** | Number of contacts messaged during the campaign | [optional] |
| **TotalNumberOfContacts** | **long?** | Total number of contacts in the campaign | [optional] |
| **Percentage** | **long?** | Percentage of contacts processed during the campaign | [optional] |
| **NumberOfContactsSkipped** | **Dictionary&lt;string, int?&gt;** | Number of contacts skipped during the campaign | [optional] |



_PureCloudPlatform.Client.V2 245.0.0_
