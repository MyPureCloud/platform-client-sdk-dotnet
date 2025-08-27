# ScimV2SchemaAttribute

## ININ.PureCloudApi.Model.ScimV2SchemaAttribute

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the attribute. | [optional] |
| **Type** | **string** | The data type of the attribute. | [optional] |
| **SubAttributes** | [**List&lt;ScimV2SchemaAttribute&gt;**](ScimV2SchemaAttribute) | The list of subattributes for an attribute of the type \&quot;complex\&quot;. Uses the same schema as \&quot;attributes\&quot;. | [optional] |
| **MultiValued** | **bool?** | Indicates whether an attribute contains multiple values. | [optional] |
| **Description** | **string** | The description of the attribute. | [optional] |
| **Required** | **bool?** | Indicates whether an attribute is required. | [optional] |
| **CanonicalValues** | **List&lt;string&gt;** | The list of standard values that service providers may use. Service providers may ignore unsupported values. | [optional] |
| **CaseExact** | **bool?** | Indicates whether a string attribute is case-sensitive. If set to \&quot;true\&quot;, the server preserves case sensitivity. If set to \&quot;false\&quot;, the server may change the case. The server also uses case sensitivity when evaluating filters. See section 3.4.2.2 \&quot;Filtering\&quot; in RFC 7644 for details. | [optional] |
| **Mutability** | **string** | The circumstances under which an attribute can be defined or redefined. The default is \&quot;readWrite\&quot;. | [optional] |
| **Returned** | **string** | The circumstances under which an attribute and its values are returned in response to a GET, PUT, POST, or PATCH request. | [optional] |
| **Uniqueness** | **string** | The method by which the service provider enforces the uniqueness of an attribute value. A server can reject a value by returning the HTTP response code 400 (Bad Request). A client can enforce uniqueness to a greater degree than the server provider enforces. For example, a client could make a value unique even though the server has \&quot;uniqueness\&quot; set to \&quot;none\&quot;. | [optional] |
| **ReferenceTypes** | **List&lt;string&gt;** | The list of SCIM resource types that may be referenced. Only applies when \&quot;type\&quot; is set to \&quot;reference\&quot;. | [optional] |



_PureCloudPlatform.Client.V2 241.0.0_
