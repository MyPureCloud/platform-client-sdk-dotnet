---
title: TestModeResults
---
## ININ.PureCloudApi.Model.TestModeResults

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SchemaValidation** | [**TestSchemaOperation**](TestSchemaOperation.html) | Information about the validation of the schema of the event body passed in to test mode | [optional] |
| **TargetValidation** | [**TestTargetOperation**](TestTargetOperation.html) | Information about the validation of the trigger target | [optional] |
| **JsonPathValidation** | [**TestMatchesOperation**](TestMatchesOperation.html) | Information about the json path matching criteria | [optional] |
| **TriggerMatches** | **bool?** | Whether the trigger would have matched on the provided event body | [optional] |
{: class="table table-striped"}


