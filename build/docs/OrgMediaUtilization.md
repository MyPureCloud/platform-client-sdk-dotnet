---
title: OrgMediaUtilization
---
## ININ.PureCloudApi.Model.OrgMediaUtilization

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MaximumCapacity** | **int?** | Defines the maximum number of conversations of this type that an agent can handle at one time. | [optional] |
| **InterruptableMediaTypes** | **List&lt;string&gt;** | Defines the list of other media types that can interrupt a conversation of this media type.  Values can be: call, chat, email, or socialExpression | [optional] |
| **IncludeNonAcd** | **bool?** | If true, then track non-ACD conversations against utilization | [optional] |
{: class="table table-striped"}


