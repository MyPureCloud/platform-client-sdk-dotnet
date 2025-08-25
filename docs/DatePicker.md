# DatePicker

## ININ.PureCloudApi.Model.DatePicker

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | Optional unique identifier to help map component replies to form messages where multiple DatePickers can be present. | [optional] |
| **Title** | **string** | Text to show in the title. | [optional] |
| **Subtitle** | **string** | Text to show in the description. | [optional] |
| **DatePickerAvailableDateTimes** | [**List&lt;DatePickerAvailableDateTime&gt;**](DatePickerAvailableDateTime) | An array of available times objects. | |
| **DateSelected** | **DateTime?** | Selected date response from end customer. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 240.0.0_
