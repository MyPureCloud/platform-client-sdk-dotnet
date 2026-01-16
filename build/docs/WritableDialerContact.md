# WritableDialerContact

## ININ.PureCloudApi.Model.WritableDialerContact

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **ContactListId** | **string** | The identifier of the contact list containing this contact. | |
| **Data** | **Dictionary&lt;string, string&gt;** | An ordered map of the contact&#39;s columns and corresponding values. | |
| **LatestSmsEvaluations** | [**Dictionary&lt;string, MessageEvaluation&gt;**](MessageEvaluation) | A map of SMS records for the contact phone columns. | [optional] |
| **LatestEmailEvaluations** | [**Dictionary&lt;string, MessageEvaluation&gt;**](MessageEvaluation) | A map of email records for the contact email columns. | [optional] |
| **LatestWhatsAppEvaluations** | [**Dictionary&lt;string, MessageEvaluation&gt;**](MessageEvaluation) | A map of whatsapp records for the contact whatsapp columns. | [optional] |
| **Callable** | **bool?** | Indicates whether or not the contact can be called. | [optional] |
| **PhoneNumberStatus** | [**Dictionary&lt;string, PhoneNumberStatus&gt;**](PhoneNumberStatus) | A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not. | [optional] |
| **ContactableStatus** | [**Dictionary&lt;string, ContactableStatus&gt;**](ContactableStatus) | A map of media types (Voice, SMS and Email) to ContactableStatus, which indicates if the contact can be contacted using the specified media type. | [optional] |
| **DateCreated** | **DateTime?** | Timestamp for when the contact was added. Contacts added prior to 2023 September 1 may be missing this value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 254.0.0_
