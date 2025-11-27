# DialerContactlistConfigChangeContactList

## ININ.PureCloudApi.Model.DialerContactlistConfigChangeContactList

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ColumnNames** | **List&lt;string&gt;** | the contact column names | [optional] |
| **PhoneColumns** | [**List&lt;DialerContactlistConfigChangeContactPhoneNumberColumn&gt;**](DialerContactlistConfigChangeContactPhoneNumberColumn) | the columns containing phone numbers | [optional] |
| **EmailColumns** | [**List&lt;DialerContactlistConfigChangeEmailColumn&gt;**](DialerContactlistConfigChangeEmailColumn) | the columns containing email addresses | [optional] |
| **ImportStatus** | [**DialerContactlistConfigChangeImportStatus**](DialerContactlistConfigChangeImportStatus) |  | [optional] |
| **PreviewModeColumnName** | **string** | the name of the column that holds the indicators for contacts that are to be dialed in preview mode only | [optional] |
| **PreviewModeAcceptedValues** | **List&lt;string&gt;** | list of user-defined values indicating the contact is to be dialed in preview mode only | [optional] |
| **Size** | **long?** | the number of contacts in the contact list | [optional] |
| **AttemptLimits** | [**DialerContactlistConfigChangeUriReference**](DialerContactlistConfigChangeUriReference) |  | [optional] |
| **AutomaticTimeZoneMapping** | **bool?** | whether or not automatic time zone mapping is enabled on the list | [optional] |
| **ZipCodeColumnName** | **string** | zip code column from the contact list to be used optionally with automatic time zone mapping | [optional] |
| **Division** | [**DialerContactlistConfigChangeUriReference**](DialerContactlistConfigChangeUriReference) | A UriReference for a resource | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **long?** | Required for updates, must match the version number of the most recent update | [optional] |
| **GetAdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
