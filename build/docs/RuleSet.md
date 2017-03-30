---
title: RuleSet
---
## ININ.PureCloudApi.Model.RuleSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ContactList** | [**UriReference**](UriReference.html) | The identifier of an example contact list that provides user-interface suggestions for contact-based conditions and actions | [optional] |
| **Queue** | [**UriReference**](UriReference.html) | The identifier of an example queue that provides user-interface suggestions for wrap-up associated conditions | [optional] |
| **Rules** | [**List&lt;DialerRule&gt;**](DialerRule.html) | The list of rules | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


