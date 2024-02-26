---
title: JourneyViewElement
---
## ININ.PureCloudApi.Model.JourneyViewElement

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The unique identifier of the element within the elements list | |
| **Name** | **string** | The unique name of the element within the view | |
| **Attributes** | [**JourneyViewElementAttributes**](JourneyViewElementAttributes.html) | Required attributes of the element | |
| **Filter** | [**JourneyViewElementFilter**](JourneyViewElementFilter.html) | Any filters applied to this element | [optional] |
| **FollowedBy** | [**List&lt;JourneyViewLink&gt;**](JourneyViewLink.html) | A list of JourneyViewLink objects, listing the elements downstream of this element | [optional] |
{: class="table table-striped"}


