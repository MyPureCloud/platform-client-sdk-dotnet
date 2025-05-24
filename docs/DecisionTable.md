# DecisionTable

## ININ.PureCloudApi.Model.DecisionTable

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Division** | [**Division**](Division) | The division to which this entity belongs. | [optional] |
| **Description** | **string** | The decision table description. | [optional] |
| **DateCreated** | **DateTime?** | UTC date time indicating when this decision table was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | UTC date time indicating when this decision table was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DatePublished** | **DateTime?** | UTC date time indicating when this decision table was published. Null if never published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Published** | [**DecisionTableVersionEntity**](DecisionTableVersionEntity) | The entity reference to the most recently published decision table version. Null if never published. | [optional] |
| **Latest** | [**DecisionTableVersionEntity**](DecisionTableVersionEntity) | The entity reference to the most recently created decision table version. | [optional] |
| **Columns** | [**DecisionTableColumns**](DecisionTableColumns) | The column definitions of this decision table. | [optional] |
| **PublishedContract** | [**DecisionTableContract**](DecisionTableContract) | The published contract information for this decision table. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 234.0.0_
