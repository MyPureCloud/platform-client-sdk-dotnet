# TimeZoneMappingPreview

## ININ.PureCloudApi.Model.TimeZoneMappingPreview

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContactList** | [**DomainEntityRef**](DomainEntityRef) | The associated ContactList | [optional] |
| **ContactsPerTimeZone** | **Dictionary&lt;string, long?&gt;** | The number of contacts per time zone that mapped to only that time zone | [optional] |
| **ContactsMappedUsingZipCode** | **Dictionary&lt;string, long?&gt;** | The number of contacts per time zone that mapped to only that time zone and were mapped using the zip code column | [optional] |
| **ContactsMappedToASingleZone** | **long?** | The total number of contacts that mapped to a single time zone | [optional] |
| **ContactsMappedToASingleZoneUsingZipCode** | **long?** | The total number of contacts that mapped to a single time zone and were mapped using the zip code column | [optional] |
| **ContactsMappedToMultipleZones** | **long?** | The total number of contacts that mapped to multiple time zones | [optional] |
| **ContactsMappedToMultipleZonesUsingZipCode** | **long?** | The total number of contacts that mapped to multiple time zones and were mapped using the zip code column | [optional] |
| **ContactsInDefaultWindow** | **long?** | The total number of contacts that will be dialed during the default window | [optional] |
| **ContactListSize** | **long?** | The total number of contacts in the contact list | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
