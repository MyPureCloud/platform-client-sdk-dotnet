---
title: ContactList
---
## ININ.PureCloudApi.Model.ContactList

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ColumnNames** | **List&lt;string&gt;** | the contact column names | |
| **PhoneColumns** | [**List&lt;ContactPhoneNumberColumn&gt;**](ContactPhoneNumberColumn.html) | the columns containing phone numbers | |
| **ImportStatus** | [**ImportStatus**](ImportStatus.html) | the status of the import process | [optional] |
| **PreviewModeColumnName** | **string** | the name of the column that holds the indicators for contacts that are to be dialed in preview mode only | [optional] |
| **PreviewModeAcceptedValues** | **List&lt;string&gt;** | list of user-defined values indicating the contact is to be dialed in preview mode only | [optional] |
| **Size** | **long?** | the number of contacts in the contact list | [optional] |
| **AttemptLimits** | [**UriReference**](UriReference.html) | the associated AttemptLimits | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


