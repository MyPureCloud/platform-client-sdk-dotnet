---
title: CriteriaGroup
---
## ININ.PureCloudApi.Model.CriteriaGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **And** | [**List&lt;CriteriaItem&gt;**](CriteriaItem.html) | These criteriaItems will be AND&#39;d together to find a match. | [optional] |
| **Or** | [**List&lt;CriteriaItem&gt;**](CriteriaItem.html) | These criteriaItems will be OR&#39;d together to find a match. | [optional] |
| **Not** | [**List&lt;CriteriaItem&gt;**](CriteriaItem.html) | These criteriaItems must all be false to find a match. | [optional] |
| **Criteria** | [**CriteriaItem**](CriteriaItem.html) | A singular critieriaItem to match. | [optional] |
{: class="table table-striped"}


