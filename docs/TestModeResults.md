# TestModeResults

## ININ.PureCloudApi.Model.TestModeResults

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SchemaValidation** | [**TestSchemaOperation**](TestSchemaOperation) | Information about the validation of the schema of the event body passed in to test mode | [optional] |
| **TargetValidation** | [**TestTargetOperation**](TestTargetOperation) | Information about the validation of the trigger target | [optional] |
| **JsonPathValidation** | [**TestMatchesOperation**](TestMatchesOperation) | Information about the json path matching criteria | [optional] |
| **TriggerMatches** | **bool?** | Whether the trigger would have matched on the provided event body | [optional] |



_PureCloudPlatform.Client.V2 219.0.0_
