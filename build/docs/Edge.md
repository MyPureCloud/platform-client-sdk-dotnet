---
title: Edge
---
## ININ.PureCloudApi.Model.Edge

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
| **Interfaces** | [**List&lt;EdgeInterface&gt;**](EdgeInterface.html) | The list of interfaces for the edge. (Deprecated) Replaced by configuring trunks/ip info on the logical interface instead | [optional] |
| **Make** | **string** |  | [optional] |
| **Model** | **string** |  | [optional] |
| **ApiVersion** | **string** |  | [optional] |
| **SoftwareVersion** | **string** |  | [optional] |
| **SoftwareVersionTimestamp** | **string** |  | [optional] |
| **SoftwareVersionPlatform** | **string** |  | [optional] |
| **SoftwareVersionConfiguration** | **string** |  | [optional] |
| **FullSoftwareVersion** | **string** |  | [optional] |
| **PairingId** | **string** | The pairing Id for a hardware Edge in the format: 00000-00000-00000-00000-00000. This field is only required when creating an Edge with a deployment type of HARDWARE. | [optional] |
| **Fingerprint** | **string** |  | [optional] |
| **FingerprintHint** | **string** |  | [optional] |
| **CurrentVersion** | **string** |  | [optional] |
| **StagedVersion** | **string** |  | [optional] |
| **Patch** | **string** |  | [optional] |
| **StatusCode** | **string** |  | [optional] |
| **EdgeGroup** | [**EdgeGroup**](EdgeGroup.html) |  | [optional] |
| **Site** | [**Site**](Site.html) | The Site to which the Edge is assigned. | [optional] |
| **SoftwareStatus** | [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html) |  | [optional] |
| **OnlineStatus** | **string** |  | [optional] |
| **SerialNumber** | **string** |  | [optional] |
| **PhysicalEdge** | **bool?** |  | [optional] |
| **Managed** | **bool?** |  | [optional] |
| **EdgeDeploymentType** | **string** |  | [optional] |
| **CallDrainingState** | **string** |  | [optional] |
| **ConversationCount** | **int?** |  | [optional] |
| **Proxy** | **string** | Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


