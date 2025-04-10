# DigitalRuleSet

## ININ.PureCloudApi.Model.DigitalRuleSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ContactList** | [**DomainEntityRef**](DomainEntityRef) | A ContactList to provide suggestions for contact columns on relevant conditions and actions. | [optional] |
| **Rules** | [**List&lt;DigitalRule&gt;**](DigitalRule) | The list of rules. | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 231.0.0_
