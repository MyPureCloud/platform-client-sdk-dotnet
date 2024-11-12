# Relationship

## ININ.PureCloudApi.Model.Relationship

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **User** | [**User**](User) | The user associated with the external organization. When creating or updating a relationship, only User.id is required. User object is fully populated when expanding a note. | |
| **ExternalOrganization** | [**ExternalOrganization**](ExternalOrganization) | The external organization this relationship is attached to | |
| **_Relationship** | **string** | The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant | |
| **ExternalDataSources** | [**List&lt;ExternalDataSource&gt;**](ExternalDataSource) | Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 221.0.0_
