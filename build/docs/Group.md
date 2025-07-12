# Group

## ININ.PureCloudApi.Model.Group

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The group name. | |
| **Description** | **string** |  | [optional] |
| **DateModified** | **DateTime?** | Last modified date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **MemberCount** | **long?** | Number of members. | [optional] |
| **State** | **string** | Active, inactive, or deleted state. | [optional] |
| **Version** | **int?** | Current version for this resource. | [optional] |
| **Type** | **string** | Type of group. | |
| **Images** | [**List&lt;Image&gt;**](Image) |  | [optional] |
| **Addresses** | [**List&lt;GroupContact&gt;**](GroupContact) |  | [optional] |
| **RulesVisible** | **bool?** | Are membership rules visible to the person requesting to view the group | |
| **Visibility** | **string** | Who can view this group | |
| **RolesEnabled** | **bool?** | Allow roles to be assigned to this group | [optional] |
| **IncludeOwners** | **bool?** | Allow owners to be included as members of the group | [optional] |
| **CallsEnabled** | **bool?** | Allow calls to be placed to this group. | [optional] |
| **Owners** | [**List&lt;User&gt;**](User) | Owners of the group | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 238.0.0_
