# WfmVersionedEntityMetadata

## ININ.PureCloudApi.Model.WfmVersionedEntityMetadata

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Version** | **int?** | The version of the associated entity.  Used to prevent conflicts on concurrent edits | |
| **ModifiedBy** | [**UserReference**](UserReference) | The user who last modified the associated entity | [optional] |
| **DateModified** | **DateTime?** | The date the associated entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**UserReference**](UserReference) | The user who created the associated entity, if available | [optional] |
| **DateCreated** | **DateTime?** | The date the associated entity was created, if available. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
