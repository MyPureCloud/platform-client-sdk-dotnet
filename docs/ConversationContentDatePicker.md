# ConversationContentDatePicker

## ININ.PureCloudApi.Model.ConversationContentDatePicker

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Optional unique identifier to help map component replies to form messages where multiple DatePickers can be present. | [optional] |
| **Title** | **string** | Text to show in the title. | [optional] |
| **Subtitle** | **string** | Text to show in the description. | [optional] |
| **ImageUrl** | **string** | URL of an image | [optional] |
| **DateMinimum** | **DateTime?** | The minimum Date Enabled in the datepicker calendar, format: ISO 8601. | [optional] |
| **DateMaximum** | **DateTime?** | The maximum Date Enabled in the datepicker calendar, format: ISO 8601. | [optional] |
| **Location** | [**ConversationContentLocation**](ConversationContentLocation) | Location of the event. | [optional] |
| **AvailableTimes** | [**List&lt;ConversationContentDatePickerAvailableTime&gt;**](ConversationContentDatePickerAvailableTime) | An array of available times objects. | [optional] |
| **DateDisplayFormat** | **string** | The format the date should be presented to the end user. | [optional] |



_PureCloudPlatform.Client.V2 248.0.0_
