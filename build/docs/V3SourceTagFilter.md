# V3SourceTagFilter

## ININ.PureCloudApi.Model.V3SourceTagFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AllOf** | **List&lt;string&gt;** | Tags that must all be present (AND). | [optional] |
| **AnyOfGroups** | **List&lt;List&lt;string&gt;&gt;** | OR groups ANDed together; within each group at least one tag must match. | [optional] |
| **NoneOf** | **List&lt;string&gt;** | Tags that must not be present on matching chunks. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
