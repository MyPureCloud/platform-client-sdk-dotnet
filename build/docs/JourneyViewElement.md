# JourneyViewElement

## ININ.PureCloudApi.Model.JourneyViewElement

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The unique identifier of the element within the elements list | |
| **Name** | **string** | The unique name of the element within the view | |
| **Attributes** | [**JourneyViewElementAttributes**](JourneyViewElementAttributes) | Required attributes of the element | |
| **DisplayAttributes** | [**JourneyViewElementDisplayAttributes**](JourneyViewElementDisplayAttributes) | Attributes that defines the visualization of the element in the journey view | [optional] |
| **Filter** | [**JourneyViewElementFilter**](JourneyViewElementFilter) | Any filters applied to this element | [optional] |
| **FollowedBy** | [**List&lt;JourneyViewLink&gt;**](JourneyViewLink) | A list of JourneyViewLink objects, listing the elements downstream of this element | [optional] |



_PureCloudPlatform.Client.V2 225.0.0_
