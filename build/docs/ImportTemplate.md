---
title: ImportTemplate
---
## ININ.PureCloudApi.Model.ImportTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the import template. | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ContactListTemplate** | [**DomainEntityRef**](DomainEntityRef.html) | ContactListTemplate for this ImportTemplate. | |
| **ContactListFilter** | [**DomainEntityRef**](DomainEntityRef.html) | ContactListFilter for this ImportTemplate. | [optional] |
| **UseSplittingCriteria** | **bool?** | Whether or not to use splitting criteria. Default is false. | [optional] |
| **SplittingInformation** | [**SplittingInformation**](SplittingInformation.html) | How to split contact records, required if useSplittingCriteria is true. | [optional] |
| **ListNameFormat** | **string** | The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required. | [optional] |
| **CustomListNameFormatValue** | **string** | Custom value for the list name format, at least %N is required. Any character other than the specified tokens will be used as is. Available tokens: %N: ListNamePrefix; %P: Part number; %F: Filter name; %C: Column value; YYYY: year; MM: month; DD: day; hh: hour; mm: minute; ss: second. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


