# CustomAttributes

## ININ.PureCloudApi.Model.CustomAttributes

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The id of the Custom Attributes record. | [optional] |
| **Name** | **string** |  | [optional] |
| **ConversationId** | **string** | The id of the conversation. | [optional] |
| **Divisions** | **List&lt;string&gt;** | The list of division ids that the record is visible in. If [], the record is visible to all divisions (Unassigned Division). | [optional] |
| **Schema** | [**ConversationDataSchema**](ConversationDataSchema) | The schema that dictates which attributes can be included. | [optional] |
| **_CustomAttributes** | **Dictionary&lt;string, Object&gt;** | The map of attribute values. | [optional] |
| **CustomAttributesTimestamps** | **Dictionary&lt;string, string&gt;** | The map of timestamps for when each attribute was last updated. | [optional] |
| **Version** | **int?** | The latest version of the Custom Attributes record. | [optional] |
| **DateCreated** | **DateTime?** | The date the record was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date the record was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
