---
title: PhoneStatus
---
## ININ.PureCloudApi.Model.PhoneStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **OperationalStatus** | **string** | The Operational Status of this phone | [optional] |
| **EdgesStatus** | **string** | The status of the primary or secondary Edges assigned to the phone lines. | [optional] |
| **EventCreationTime** | **string** | Event Creation Time represents an ISO-8601 string. For example: UTC, UTC+01:00, or Europe/London | [optional] |
| **Provision** | [**ProvisionInfo**](ProvisionInfo.html) | Provision information for this phone | [optional] |
| **LineStatuses** | [**List&lt;LineStatus&gt;**](LineStatus.html) | A list of LineStatus information for each of the lines of this phone | [optional] |
| **PhoneAssignmentToEdgeType** | **string** | The phone status&#39;s edge assignment type. | [optional] |
| **Edge** | [**DomainEntityRef**](DomainEntityRef.html) | The URI of the edge that provided this status information. | [optional] |
| **SelfUri** | **string** | The URI for this object. Deprecated. Do not use. | [optional] |
{: class="table table-striped"}


