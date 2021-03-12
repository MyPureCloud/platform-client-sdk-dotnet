---
title: Objective
---
## ININ.PureCloudApi.Model.Objective

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **TemplateId** | **string** | The id of this objective&#39;s base template | [optional] |
| **Zones** | [**List&lt;ObjectiveZone&gt;**](ObjectiveZone.html) | Objective zone specifies min,max points and values for the associated metric | [optional] |
| **Enabled** | **bool?** | A flag for whether this objective is enabled for the related metric | [optional] |
| **DateStart** | **String** | start date of the objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
{: class="table table-striped"}


