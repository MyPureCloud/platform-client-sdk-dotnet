# Edge

## ININ.PureCloudApi.Model.Edge

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Division** | [**Division**](Division) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The resource&#39;s description. | [optional] |
| **Version** | **int?** | The current version of the resource. | [optional] |
| **DateCreated** | **DateTime?** | The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedBy** | **string** | The ID of the user that last modified the resource. | [optional] |
| **CreatedBy** | **string** | The ID of the user that created the resource. | [optional] |
| **State** | **string** | Indicates if the resource is active, inactive, or deleted. | [optional] |
| **ModifiedByApp** | **string** | The application that last modified the resource. | [optional] |
| **CreatedByApp** | **string** | The application that created the resource. | [optional] |
| **Interfaces** | [**List&lt;EdgeInterface&gt;**](EdgeInterface) | The list of interfaces for the edge. (Deprecated) Replaced by configuring trunks/ip info on the logical interface instead | [optional] |
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
| **StatusCode** | **string** | The current status of the Edge. | [optional] |
| **EdgeGroup** | [**EdgeGroup**](EdgeGroup) |  | [optional] |
| **Site** | [**Site**](Site) | The Site to which the Edge is assigned. | [optional] |
| **SoftwareStatus** | [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto) | Details about an in-progress or recently in-progress Edge software upgrade. This node appears only if a software upgrade was recently initiated for this Edge. | [optional] |
| **OnlineStatus** | **string** |  | [optional] |
| **SerialNumber** | **string** |  | [optional] |
| **PhysicalEdge** | **bool?** |  | [optional] |
| **Managed** | **bool?** |  | [optional] |
| **EdgeDeploymentType** | **string** |  | [optional] |
| **CertType** | **string** | The type of certificate used to communicate with edge-proxy. | [optional] |
| **CallDrainingState** | **string** | The current state of the Edge&#39;s call draining process before it can be safely rebooted or updated. | [optional] |
| **ConversationCount** | **int?** | The remaining number of conversations the Edge has to drain before it can be safely rebooted or updated. When an Edge is not draining conversations, this will be NULL or 0. | [optional] |
| **Proxy** | **string** | Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed. | [optional] |
| **OfflineConfigCalled** | **bool?** | True if the offline edge configuration endpoint has been called for this edge. | [optional] |
| **OsName** | **string** | The name provided by the operating system of the Edge. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
