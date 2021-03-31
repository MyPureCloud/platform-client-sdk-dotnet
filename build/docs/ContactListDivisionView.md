---
title: ContactListDivisionView
---
## ININ.PureCloudApi.Model.ContactListDivisionView

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Division** | [**Division**](Division.html) | The division to which this entity belongs. | [optional] |
| **ColumnNames** | **List&lt;string&gt;** | The names of the contact data columns. | |
| **PhoneColumns** | [**List&lt;ContactPhoneNumberColumn&gt;**](ContactPhoneNumberColumn.html) | Indicates which columns are phone numbers. | [optional] |
| **ImportStatus** | [**ImportStatus**](ImportStatus.html) | The status of the import process. | [optional] |
| **Size** | **long?** | The number of contacts in the ContactList. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


