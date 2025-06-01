# Site

## ININ.PureCloudApi.Model.Site

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
| **PrimarySites** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) |  | [optional] |
| **SecondarySites** | [**List&lt;DomainEntityRef&gt;**](DomainEntityRef) |  | [optional] |
| **PrimaryEdges** | [**List&lt;Edge&gt;**](Edge) |  | [optional] |
| **SecondaryEdges** | [**List&lt;Edge&gt;**](Edge) |  | [optional] |
| **Addresses** | [**List&lt;Contact&gt;**](Contact) |  | [optional] |
| **Edges** | [**List&lt;Edge&gt;**](Edge) |  | [optional] |
| **EdgeAutoUpdateConfig** | [**EdgeAutoUpdateConfig**](EdgeAutoUpdateConfig) | Recurrance rule, time zone, and start/end settings for automatic edge updates for this site | [optional] |
| **MediaRegionsUseLatencyBased** | **bool?** |  | [optional] |
| **Location** | [**LocationDefinition**](LocationDefinition) | Location | |
| **Managed** | **bool?** |  | [optional] |
| **NtpSettings** | [**NTPSettings**](NTPSettings) | Network Time Protocol settings for the site | [optional] |
| **MediaModel** | **string** | Media model for the site | [optional] |
| **CoreSite** | **bool?** | Is this site a core site | [optional] |
| **SiteConnections** | [**List&lt;SiteConnection&gt;**](SiteConnection) | The site connections | [optional] |
| **MediaRegions** | **List&lt;string&gt;** | The ordered list of AWS regions through which media can stream. | [optional] |
| **CallerId** | **string** | The caller ID value for the site. | [optional] |
| **CallerName** | **string** | The caller name for the site. | [optional] |
| **CloudProxyForceTurn** | **bool?** | Enables premises Edge Force Turn  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
