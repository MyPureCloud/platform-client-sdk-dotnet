# KnowledgeGuestSession

## ININ.PureCloudApi.Model.KnowledgeGuestSession

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Session ID. | [optional] |
| **App** | [**KnowledgeGuestSessionApp**](KnowledgeGuestSessionApp) | The app where the session is started. | |
| **CustomerId** | **string** | An arbitrary ID for the customer starting the session. Used to track multiple sessions started by the same customer. | |
| **PageUrl** | **string** | URL of the page where the session is started. | [optional] |
| **Contexts** | [**List&lt;KnowledgeGuestSessionContext&gt;**](KnowledgeGuestSessionContext) | The session contexts. | [optional] |
| **JourneySessionId** | **string** | Journey session ID. Used to get the segments of the customer to filter search results. | [optional] |



_PureCloudPlatform.Client.V2 229.0.0_
