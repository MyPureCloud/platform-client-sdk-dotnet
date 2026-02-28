# CriteriaGroup

## ININ.PureCloudApi.Model.CriteriaGroup

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **And** | [**List&lt;CriteriaItem&gt;**](CriteriaItem) | These criteriaItems will be AND&#39;d together to find a match. | [optional] |
| **Or** | [**List&lt;CriteriaItem&gt;**](CriteriaItem) | These criteriaItems will be OR&#39;d together to find a match. | [optional] |
| **Not** | [**List&lt;CriteriaItem&gt;**](CriteriaItem) | These criteriaItems must all be false to find a match. | [optional] |
| **Criteria** | [**CriteriaItem**](CriteriaItem) | A singular critieriaItem to match. | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
