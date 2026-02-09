# IdleTokenTimeout

## ININ.PureCloudApi.Model.IdleTokenTimeout

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **IdleTokenTimeoutSeconds** | **int?** | Token timeout length in seconds. Must be at least 5 minutes and 8 hours or less (if HIPAA is disabled) or 15 minutes or less (if HIPAA is enabled). | [optional] |
| **EnableIdleTokenTimeout** | **bool?** | Indicates whether the Token Timeout should be enabled or disabled. | [optional] |
| **InactivityTimeoutUnit** | **string** | The unit for the inactivity timeout (MINUTES or HOURS). | [optional] |
| **InactivityTimeoutGroupsEnabled** | **bool?** | Indicates whether inactivity timeout groups are enabled. | [optional] |
| **InactivityTimeoutGroupBundles** | [**List&lt;InactivityTimeoutGroupBundle&gt;**](InactivityTimeoutGroupBundle) | Group bundle configuration for inactivity timeout. | [optional] |



_PureCloudPlatform.Client.V2 256.0.0_
