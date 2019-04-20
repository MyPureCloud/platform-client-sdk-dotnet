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
| **Enabled** | **bool?** | The schema&#39;s current enabled/disabled status. A disabled schema cannot be assigned to any other objects, but the data on those objects from the schemas still exists | [optional] |
| **Deleted** | **bool?** | The schema&#39;s deleted status. A deleted schema can not be used by any records or updated. All records using a deleted schema will eventually have their schema-based data removed. | [optional] |
| **CreatedBy** | [**UriReference**](UriReference.html) | The user that created this schema. | [optional] |
| **DateCreated** | **DateTime?** | The date and time this schema was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **JsonSchema** | [**JsonSchemaDocument**](JsonSchemaDocument.html) | The JSON schema defining the data extension. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


