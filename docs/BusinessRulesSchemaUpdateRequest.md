# BusinessRulesSchemaUpdateRequest

## ININ.PureCloudApi.Model.BusinessRulesSchemaUpdateRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Version** | **int?** | The schema&#39;s version, a positive integer. Required for updates. | |
| **Enabled** | **bool?** | The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists. | [optional] |
| **JsonSchema** | [**JsonSchemaWithDefinitions**](JsonSchemaWithDefinitions) | A JSON schema defining the extension to the built-in entity type. | |



_PureCloudPlatform.Client.V2 254.0.0_
