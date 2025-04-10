# ResponseFilter

## ININ.PureCloudApi.Model.ResponseFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | Field to filter on. Allowed values are &#39;name&#39;, &#39;libraryId&#39;, &#39;text.contentType&#39;, &#39;messagingTemplate&#39; and &#39;responseType&#39; | |
| **Operator** | **string** | Filter operation: IN, EQUALS, NOTEQUALS. | |
| **Values** | **List&lt;string&gt;** | Values to filter on. If name is &#39;responseType&#39; then allowed values are &#39;CampaignSmsTemplate&#39;, &#39;CampaignEmailTemplate&#39;, &#39;Footer&#39; and &#39;Signature&#39; | |



_PureCloudPlatform.Client.V2 231.1.0_
