# ContactListFilter

## ININ.PureCloudApi.Model.ContactListFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the list. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ContactList** | [**DomainEntityRef**](DomainEntityRef) | The contact list the filter is based on. Required if sourceType is ContactList | [optional] |
| **ContactListTemplate** | [**DomainEntityRef**](DomainEntityRef) | The contact list template the filter is based on. Required if sourceType is ContactListTemplate | [optional] |
| **SourceType** | **string** | The source type the filter is based on. | [optional] |
| **Clauses** | [**List&lt;ContactListFilterClause&gt;**](ContactListFilterClause) | Groups of conditions to filter the contacts by. | [optional] |
| **FilterType** | **string** | How to join clauses together. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
