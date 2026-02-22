# InactivityTimeoutGroupBundle

## ININ.PureCloudApi.Model.InactivityTimeoutGroupBundle

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Priority** | **int?** | The priority of the group bundle (1-5). | |
| **TimeoutSeconds** | **int?** | The timeout value in seconds (300 to 28800, representing 5 to 480 minutes). | |
| **InactivityTimeoutUnit** | **string** | The unit for the timeout (MINUTES or HOURS). | [optional] |
| **Groups** | **List&lt;string&gt;** | The list of group IDs to select. | |



_PureCloudPlatform.Client.V2 257.0.0_
