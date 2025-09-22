# FileSpecificationTemplate

## ININ.PureCloudApi.Model.FileSpecificationTemplate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the File Specification template. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **Description** | **string** | Description of the file specification template | [optional] |
| **Format** | **string** | File format | |
| **NumberOfHeadingLinesSkipped** | **int?** | Number of heading lines to be skipped | [optional] |
| **NumberOfTrailingLinesSkipped** | **int?** | Number of trailing lines to be skipped | [optional] |
| **Header** | **bool?** | If true indicates that delimited file has a header row, which can provide column names | [optional] |
| **Delimiter** | **string** | Kind of delimiter | [optional] |
| **DelimiterValue** | **string** | Delimiter character, used only when delimiter&#x3D;\&quot;Custom\&quot; | [optional] |
| **ColumnInformation** | [**List&lt;Column&gt;**](Column) | Columns specification | [optional] |
| **PreprocessingRules** | [**List&lt;PreprocessingRule&gt;**](PreprocessingRule) | Preprocessing rules | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 242.0.0_
