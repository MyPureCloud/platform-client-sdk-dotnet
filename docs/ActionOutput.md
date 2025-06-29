# ActionOutput

## ININ.PureCloudApi.Model.ActionOutput

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SuccessSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) | JSON schema that defines the transformed, successful result that will be sent back to the caller. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either successSchema or successSchemaFlattened will be returned, not both. | [optional] |
| **SuccessSchemaUri** | **string** | URI to retrieve success schema | [optional] |
| **ErrorSchema** | [**JsonSchemaDocument**](JsonSchemaDocument) | JSON schema that defines the body of response when request is not successful. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either errorSchema or errorSchemaFlattened will be returned, not both. | [optional] |
| **ErrorSchemaUri** | **string** | URI to retrieve error schema | [optional] |
| **SuccessSchemaFlattened** | [**FlattenedJsonSchemaDocument**](FlattenedJsonSchemaDocument) | JSON schema that defines the transformed, successful result that will be sent back to the caller. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either successSchema or successSchemaFlattened will be returned, not both. | [optional] |
| **ErrorSchemaFlattened** | [**FlattenedJsonSchemaDocument**](FlattenedJsonSchemaDocument) | JSON schema that defines the body of response when request is not successful. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either errorSchema or errorSchemaFlattened will be returned, not both. | [optional] |



_PureCloudPlatform.Client.V2 237.0.0_
