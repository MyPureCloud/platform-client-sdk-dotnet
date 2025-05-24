# TrusteeAuditQueryRequest

## ININ.PureCloudApi.Model.TrusteeAuditQueryRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **TrusteeOrganizationIds** | **List&lt;string&gt;** | Limit returned audits to these trustee organizationIds. | |
| **TrusteeUserIds** | **List&lt;string&gt;** | Limit returned audits to these trustee userIds. | |
| **StartDate** | **DateTime?** | Starting date/time for the audit search. ISO-8601 formatted date-time, UTC. | [optional] |
| **EndDate** | **DateTime?** | Ending date/time for the audit search. ISO-8601 formatted date-time, UTC. | [optional] |
| **QueryPhrase** | **string** | Word or phrase to look for in audit bodies. | [optional] |
| **Facets** | [**List&lt;Facet&gt;**](Facet) | Facet information to be returned with the query results. | [optional] |
| **Filters** | [**List&lt;Filter&gt;**](Filter) | Additional custom filters to be applied to the query. | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
