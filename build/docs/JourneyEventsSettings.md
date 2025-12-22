# JourneyEventsSettings

## ININ.PureCloudApi.Model.JourneyEventsSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** | Whether or not journey event collection is enabled. | [optional] |
| **ExcludedQueryParameters** | **List&lt;string&gt;** | (deprecated) List of parameters to be excluded from the query string. | [optional] |
| **ShouldKeepUrlFragment** | **bool?** | (deprecated) Whether or not to keep the URL fragment. | [optional] |
| **SearchQueryParameters** | **List&lt;string&gt;** | (deprecated) List of query parameters used for search (e.g. &#39;q&#39;). | [optional] |
| **PageviewConfig** | **string** | Controls how the pageview events are tracked. | [optional] |
| **ClickEvents** | [**List&lt;SelectorEventTrigger&gt;**](SelectorEventTrigger) | Tracks when and where a visitor clicks on a webpage. | [optional] |
| **FormsTrackEvents** | [**List&lt;FormsTrackTrigger&gt;**](FormsTrackTrigger) | Controls how the form submitted and form abandoned events are tracked after a visitor interacts with a form element. | [optional] |
| **IdleEvents** | [**List&lt;IdleEventTrigger&gt;**](IdleEventTrigger) | Tracks when and where a visitor becomes inactive on a webpage. | [optional] |
| **InViewportEvents** | [**List&lt;SelectorEventTrigger&gt;**](SelectorEventTrigger) | Tracks when elements become visible or hidden on screen. | [optional] |
| **ScrollDepthEvents** | [**List&lt;ScrollPercentageEventTrigger&gt;**](ScrollPercentageEventTrigger) | Tracks when a visitor scrolls to a specific percentage of a webpage. | [optional] |
| **TrackingSettings** | [**TrackingSettings**](TrackingSettings) | Configuration settings for tracking behavior and filtering | [optional] |



_PureCloudPlatform.Client.V2 252.0.0_
