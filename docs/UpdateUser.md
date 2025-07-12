# UpdateUser

## ININ.PureCloudApi.Model.UpdateUser

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Chat** | [**Chat**](Chat) |  | [optional] |
| **Department** | **string** |  | [optional] |
| **Email** | **string** |  | [optional] |
| **PrimaryContactInfo** | [**List&lt;Contact&gt;**](Contact) | The address(s) used for primary contact. Updates to the corresponding address in the addresses list will be reflected here. | [optional] |
| **Addresses** | [**List&lt;Contact&gt;**](Contact) | Email address, phone number, and/or extension for this user. One entry is allowed per media type | [optional] |
| **Title** | **string** |  | [optional] |
| **Username** | **string** |  | [optional] |
| **PreferredName** | **string** | Preferred full name of agent | [optional] |
| **Manager** | **string** |  | [optional] |
| **Images** | [**List&lt;Image&gt;**](Image) |  | [optional] |
| **Version** | **int?** | This value should be the current version of the user. The current version can be obtained with a GET on the user before doing a PATCH. | |
| **ProfileSkills** | **List&lt;string&gt;** | Profile skills possessed by the user | [optional] |
| **Locations** | [**List&lt;Location&gt;**](Location) | The user placement at each site location. | [optional] |
| **Groups** | [**List&lt;Group&gt;**](Group) | The groups the user is a member of | [optional] |
| **State** | **string** | The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field. | [optional] |
| **AcdAutoAnswer** | **bool?** | The value that denotes if acdAutoAnswer is set on the user | [optional] |
| **Certifications** | **List&lt;string&gt;** |  | [optional] |
| **Biography** | [**Biography**](Biography) |  | [optional] |
| **EmployerInfo** | [**EmployerInfo**](EmployerInfo) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
