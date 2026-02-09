# RuleSet

## ININ.PureCloudApi.Model.RuleSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the RuleSet. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ContactList** | [**DomainEntityRef**](DomainEntityRef) | A ContactList to provide user-interface suggestions for contact columns on relevant conditions and actions. | [optional] |
| **Queue** | [**DomainEntityRef**](DomainEntityRef) | A Queue to provide user-interface suggestions for wrap-up codes on relevant conditions and actions. | [optional] |
| **Rules** | [**List&lt;DialerRule&gt;**](DialerRule) | The list of rules. | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
