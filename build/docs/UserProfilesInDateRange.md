---
title: UserProfilesInDateRange
---
## ININ.PureCloudApi.Model.UserProfilesInDateRange

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **User** | [**UserReference**](UserReference.html) | The query agent | [optional] |
| **DateStartWorkday** | **String** | Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **DateEndWorkday** | **String** | End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **Profiles** | [**List&lt;ProfileWithDateRange&gt;**](ProfileWithDateRange.html) | The list of profiles of the agent | [optional] |
{: class="table table-striped"}


