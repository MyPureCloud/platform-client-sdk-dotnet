---
title: DialerRulesetConfigChangeRuleSet
---
## ININ.PureCloudApi.Model.DialerRulesetConfigChangeRuleSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ContactList** | [**DialerRulesetConfigChangeUriReference**](DialerRulesetConfigChangeUriReference.html) |  | [optional] |
| **Queue** | [**DialerRulesetConfigChangeUriReference**](DialerRulesetConfigChangeUriReference.html) | A UriReference for a resource | [optional] |
| **Rules** | [**List&lt;DialerRulesetConfigChangeRule&gt;**](DialerRulesetConfigChangeRule.html) |  | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
{: class="table table-striped"}


