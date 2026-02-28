# ConversationDataSchema

## ININ.PureCloudApi.Model.ConversationDataSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the schema. | [optional] |
| **Version** | **int?** | The schema&#39;s version, a positive integer. | [optional] |
| **Enabled** | **bool?** | The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists. | [optional] |
| **DateCreated** | **DateTime?** | The date and time this schema version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef) | The URI of the user that created this schema. | [optional] |
| **JsonSchema** | [**ConversationJsonSchemaDocument**](ConversationJsonSchemaDocument) | A JSON schema defining the extension to the built-in entity type. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 258.0.0_
