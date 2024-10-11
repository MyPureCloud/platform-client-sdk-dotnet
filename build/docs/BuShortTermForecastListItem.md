# BuShortTermForecastListItem

## ININ.PureCloudApi.Model.BuShortTermForecastListItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **WeekDate** | **String** | The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd | [optional] |
| **WeekCount** | **int?** | The number of weeks this forecast covers | [optional] |
| **CreationMethod** | **string** | The method by which this forecast was created | [optional] |
| **Description** | **string** | The description of this forecast | [optional] |
| **Legacy** | **bool?** | Whether this forecast contains modifications on legacy metrics | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata) | Metadata for this forecast | [optional] |
| **CanUseForScheduling** | **bool?** | Whether this forecast can be used for scheduling | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 218.0.0_
