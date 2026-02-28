# DialerContact

## ININ.PureCloudApi.Model.DialerContact

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ContactListId** | **string** | The identifier of the contact list containing this contact. | |
| **Data** | **Dictionary&lt;string, string&gt;** | An ordered map of the contact&#39;s columns and corresponding values. | |
| **CallRecords** | [**Dictionary&lt;string, CallRecord&gt;**](CallRecord) | A map of call records for the contact phone columns. | [optional] |
| **LatestSmsEvaluations** | [**Dictionary&lt;string, MessageEvaluation&gt;**](MessageEvaluation) | A map of SMS records for the contact phone columns. | [optional] |
| **LatestEmailEvaluations** | [**Dictionary&lt;string, MessageEvaluation&gt;**](MessageEvaluation) | A map of email records for the contact email columns. | [optional] |
| **LatestWhatsAppEvaluations** | [**Dictionary&lt;string, MessageEvaluation&gt;**](MessageEvaluation) | A map of whatsapp records for the contact whatsapp columns. | [optional] |
| **Callable** | **bool?** | Indicates whether or not the contact can be called. | [optional] |
| **PhoneNumberStatus** | [**Dictionary&lt;string, PhoneNumberStatus&gt;**](PhoneNumberStatus) | A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not. | [optional] |
| **ContactableStatus** | [**Dictionary&lt;string, ContactableStatus&gt;**](ContactableStatus) | A map of media types (Voice, SMS and Email) to ContactableStatus, which indicates if the contact can be contacted using the specified media type. | [optional] |
| **ContactColumnTimeZones** | [**Dictionary&lt;string, ContactColumnTimeZone&gt;**](ContactColumnTimeZone) | Map containing data about the timezone the contact is mapped to. This will only be populated if the contact list has automatic timezone mapping turned on. The key is the column name. The value is the timezone it mapped to and the type of column: Phone or Zip | [optional] |
| **ConfigurationOverrides** | [**ConfigurationOverrides**](ConfigurationOverrides) | the priority property within ConfigurationOverides indicates whether or not the contact to be placed in front of the queue or at the end of the queue | [optional] |
| **DateCreated** | **DateTime?** | Timestamp for when the contact was added. Contacts added prior to 2023 September 1 may be missing this value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
