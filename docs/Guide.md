# Guide

## ININ.PureCloudApi.Model.Guide

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the guide. | [optional] |
| **Status** | **string** | The status of the guide. | [optional] |
| **Source** | **string** | Indicates how the guide content was generated. | [optional] |
| **DateCreated** | **DateTime?** | The date and time the guide was created.. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date and time the guide was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **LatestSavedVersion** | [**GuideVersionRef**](GuideVersionRef) | The latest saved version of the guide. | [optional] |
| **LatestProductionReadyVersion** | [**GuideVersionRef**](GuideVersionRef) | The latest production ready version of the guide. | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
