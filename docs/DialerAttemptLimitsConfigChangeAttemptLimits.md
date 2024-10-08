# DialerAttemptLimitsConfigChangeAttemptLimits

## ININ.PureCloudApi.Model.DialerAttemptLimitsConfigChangeAttemptLimits

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MaxAttemptsPerContact** | **int?** |  | [optional] |
| **MaxAttemptsPerNumber** | **int?** |  | [optional] |
| **TimeZoneId** | **string** | The timezone is necessary to define when \&quot;today\&quot; starts and ends | [optional] |
| **ResetPeriod** | **string** | After how long the number of attempts will be set back to 0 | [optional] |
| **RecallEntries** | [**Dictionary&lt;string, DialerAttemptLimitsConfigChangeRecallEntry&gt;**](DialerAttemptLimitsConfigChangeRecallEntry) | Configuration for recall attempts | [optional] |
| **BreadthFirstRecalls** | **bool?** | Whether recalls are performed before considering other numbers (true) or after (false) | [optional] |
| **AdditionalProperties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |



_PureCloudPlatform.Client.V2 217.0.0_
