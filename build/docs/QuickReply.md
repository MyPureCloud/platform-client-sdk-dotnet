# QuickReply

## ININ.PureCloudApi.Model.QuickReply

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Text** | **string** | Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply. | [optional] |
| **Payload** | **string** | Content of the textback payload after clicking a quick reply | [optional] |
| **Url** | **string** | The location of the image file associated with quick reply | [optional] |
| **Action** | **string** | Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \&quot;Message\&quot; which sends a message using the quick reply text. | [optional] |
| **IsSelected** | **bool?** | Indicates if the quick reply option is selected by end customer | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
