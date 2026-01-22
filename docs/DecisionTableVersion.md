# DecisionTableVersion

## ININ.PureCloudApi.Model.DecisionTableVersion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Division** | [**Division**](Division) | The division to which this entity belongs. | [optional] |
| **Version** | **int?** | The decision table version. | [optional] |
| **Status** | **string** | Current status of this decision table version | [optional] |
| **Description** | **string** | The decision table description. | [optional] |
| **RowCount** | **int?** | The number of rows in this decision table version. | [optional] |
| **RowsUri** | **string** | The rows URI for this decision table version. | [optional] |
| **DateCreated** | **DateTime?** | UTC date time indicating when this decision table version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | UTC date time indicating when this decision table version was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DatePublished** | **DateTime?** | UTC date time indicating when this decision table version was published. Null if never published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Columns** | [**DecisionTableColumns**](DecisionTableColumns) | The column definitions of this decision table version. | [optional] |
| **Contract** | [**DecisionTableContract**](DecisionTableContract) | The contract information for this decision table version. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 255.0.0_
