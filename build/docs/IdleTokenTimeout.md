# IdleTokenTimeout

## ININ.PureCloudApi.Model.IdleTokenTimeout

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **IdleTokenTimeoutSeconds** | **int?** | Token timeout length in seconds. Must be at least 5 minutes and at most 8 hours. HIPAA-enabled organizations may be subject to a stricter 15-minute maximum during rollout. | [optional] |
| **EnableIdleTokenTimeout** | **bool?** | Indicates whether the Token Timeout should be enabled or disabled. | [optional] |
| **InactivityTimeoutUnit** | **string** | The unit for the inactivity timeout (MINUTES or HOURS). | [optional] |
| **InactivityTimeoutGroupsEnabled** | **bool?** | Indicates whether inactivity timeout groups are enabled. | [optional] |
| **InactivityTimeoutGroupBundles** | [**List&lt;InactivityTimeoutGroupBundle&gt;**](InactivityTimeoutGroupBundle) | Group bundle configuration for inactivity timeout. | [optional] |



_PureCloudPlatform.Client.V2 268.0.0_
