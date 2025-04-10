# ContactList

## ININ.PureCloudApi.Model.ContactList

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Division** | [**DomainEntityRef**](DomainEntityRef) | The division this entity belongs to. | [optional] |
| **ColumnNames** | **List&lt;string&gt;** | The names of the contact data columns. | |
| **PhoneColumns** | [**List&lt;ContactPhoneNumberColumn&gt;**](ContactPhoneNumberColumn) | Indicates which columns are phone numbers. | [optional] |
| **EmailColumns** | [**List&lt;EmailColumn&gt;**](EmailColumn) | Indicates which columns are email addresses | [optional] |
| **WhatsAppColumns** | [**List&lt;WhatsAppColumn&gt;**](WhatsAppColumn) | Indicates which columns are whatsApp contacts | [optional] |
| **ImportStatus** | [**ImportStatus**](ImportStatus) | The status of the import process. | [optional] |
| **PreviewModeColumnName** | **string** | A column to check if a contact should always be dialed in preview mode. | [optional] |
| **PreviewModeAcceptedValues** | **List&lt;string&gt;** | The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode. | [optional] |
| **Size** | **long?** | The number of contacts in the ContactList. | [optional] |
| **AttemptLimits** | [**DomainEntityRef**](DomainEntityRef) | AttemptLimits for this ContactList. | [optional] |
| **AutomaticTimeZoneMapping** | **bool?** | Indicates if automatic time zone mapping is to be used for this ContactList. | [optional] |
| **ZipCodeColumnName** | **string** | The name of contact list column containing the zip code for use with automatic time zone mapping. Only allowed if &#39;automaticTimeZoneMapping&#39; is set to true. | [optional] |
| **ColumnDataTypeSpecifications** | [**List&lt;ColumnDataTypeSpecification&gt;**](ColumnDataTypeSpecification) | The settings of the columns selected for dynamic queueing | [optional] |
| **TrimWhitespace** | **bool?** | Whether to trim white space when importing a contactlist csv file, default value &#x3D; true | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.1.0_
