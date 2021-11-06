---
title: HistoryListing
---
## ININ.PureCloudApi.Model.HistoryListing

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Complete** | **bool?** |  | [optional] |
| **User** | [**User**](User.html) |  | [optional] |
| **Client** | [**DomainEntityRef**](DomainEntityRef.html) |  | [optional] |
| **ErrorMessage** | **string** |  | [optional] |
| **ErrorCode** | **string** |  | [optional] |
| **ErrorDetails** | [**List&lt;Detail&gt;**](Detail.html) |  | [optional] |
| **ErrorMessageParams** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **ActionName** | **string** | Action name | [optional] |
| **ActionStatus** | **string** | Action status | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **System** | **bool?** |  | [optional] |
| **Started** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Completed** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Entities** | [**List&lt;HistoryEntry&gt;**](HistoryEntry.html) |  | [optional] |
| **PageSize** | **int?** |  | [optional] |
| **PageNumber** | **int?** |  | [optional] |
| **Total** | **long?** |  | [optional] |
| **PageCount** | **int?** |  | [optional] |
{: class="table table-striped"}


