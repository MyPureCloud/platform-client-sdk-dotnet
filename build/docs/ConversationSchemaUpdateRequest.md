# ConversationSchemaUpdateRequest

## ININ.PureCloudApi.Model.ConversationSchemaUpdateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Version** | **int?** | The schema&#39;s version, a positive integer. | |
| **Enabled** | **bool?** | The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists. | |
| **JsonSchema** | [**ConversationJsonSchemaRequest**](ConversationJsonSchemaRequest) | A JSON schema defining the extension to the built-in entity type. | |



_PureCloudPlatform.Client.V2 258.0.0_
