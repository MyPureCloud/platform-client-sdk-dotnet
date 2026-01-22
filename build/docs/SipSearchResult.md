# SipSearchResult

## ININ.PureCloudApi.Model.SipSearchResult

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Status** | **int?** | Status of the search request | [optional] |
| **Sid** | **string** | Session id associated to the search request | [optional] |
| **Auth** | **string** | Auth token used for this search request | [optional] |
| **Message** | **string** | Any messages returned from homer as part of the response | [optional] |
| **Data** | [**List&lt;HomerRecord&gt;**](HomerRecord) | Homer search data that is returned | [optional] |
| **Count** | **int?** | Number of records returned | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
