---
title: DataSchema
---
## ININ.PureCloudApi.Model.DataSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Version** | **int?** | The schema&#39;s version. Required for updates. | |
| **AppliesTo** | **List&lt;string&gt;** | The PureCloud data this schema extends. | [optional] |
| **CreatedBy** | [**UriReference**](UriReference.html) | The user that created this schema. | [optional] |
| **DateCreated** | **DateTime?** | The date and time this schema was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **JsonSchema** | [**JsonSchemaDocument**](JsonSchemaDocument.html) | The JSON schema defining the data extension. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


