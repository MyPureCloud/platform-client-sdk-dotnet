---
title: AsgInfoResponse
---
## ININ.PureCloudApi.Model.AsgInfoResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Site** | [**Site**](Site.html) | The site that the asg belongs to. | [optional] |
| **Ami** | **string** | The ami ami of the asg. | [optional] |
| **EdgeVersion** | **string** | The software ami of the edges in the asg. | [optional] |
| **InstanceInfo** | [**List&lt;InstanceInfo&gt;**](InstanceInfo.html) | List of instances and their information that live in the ASG. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


