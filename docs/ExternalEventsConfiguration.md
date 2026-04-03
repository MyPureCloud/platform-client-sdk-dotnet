# ExternalEventsConfiguration

## ININ.PureCloudApi.Model.ExternalEventsConfiguration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The unique identifier for the external event configuration. | |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | A description of the external event configuration. | |
| **DivisionId** | **string** | The division ID (UUID) associated with this configuration. | |
| **DivisionIdActive** | **bool?** | Indicates whether the divisionId field is valid. | |
| **SchemaId** | **string** | The dynamic schema ID (UUID) that defines the structure of external events. | |
| **SchemaActive** | **bool?** | Indicates whether the schema is active or inactive. | |
| **Source** | **string** | The source of the external events e.g. Adobe, Salesforce. | |
| **DateLastModified** | **DateTime?** | The timestamp when the configuration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 261.0.0_
