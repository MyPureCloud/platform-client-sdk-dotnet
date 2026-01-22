# ContactListDivisionView

## ININ.PureCloudApi.Model.ContactListDivisionView

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Division** | [**Division**](Division) | The division to which this entity belongs. | [optional] |
| **ColumnNames** | **List&lt;string&gt;** | The names of the contact data columns. | |
| **PhoneColumns** | [**List&lt;ContactPhoneNumberColumn&gt;**](ContactPhoneNumberColumn) | Indicates which columns are phone numbers. | [optional] |
| **EmailColumns** | [**List&lt;EmailColumn&gt;**](EmailColumn) | Indicates which columns are email addresses. | [optional] |
| **WhatsAppColumns** | [**List&lt;WhatsAppColumn&gt;**](WhatsAppColumn) | Indicates which columns are whatsApp contacts. | [optional] |
| **ImportStatus** | [**ImportStatus**](ImportStatus) | The status of the import process. | [optional] |
| **Size** | **long?** | The number of contacts in the ContactList. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
