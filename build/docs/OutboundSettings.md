# OutboundSettings

## ININ.PureCloudApi.Model.OutboundSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **MaxCallsPerAgent** | **int?** | The maximum number of calls that can be placed per agent on any campaign | [optional] |
| **MaxCallsPerAgentDecimal** | **double?** | The maximum number of calls that can be placed per agent on any campaign with decimal precision | [optional] |
| **MaxConfigurableCallsPerAgent** | **int?** | The maximum number of calls that can be configured to be placed per agent on any campaign | [optional] |
| **MaxLineUtilization** | **double?** | The maximum percentage of lines that should be used for Outbound, expressed as a decimal in the range [0.0, 1.0] | [optional] |
| **AbandonSeconds** | **double?** | The number of seconds used to determine if a call is abandoned | [optional] |
| **ComplianceAbandonRateDenominator** | **string** | The denominator to be used in determining the compliance abandon rate | [optional] |
| **AutomaticTimeZoneMapping** | [**AutomaticTimeZoneMappingSettings**](AutomaticTimeZoneMappingSettings) | The settings for automatic time zone mapping. Note that changing these settings will change them for both voice and messaging campaigns. | [optional] |
| **RescheduleTimeZoneSkippedContacts** | **bool?** | Whether or not to reschedule time-zone blocked contacts | [optional] |
| **ContactListDefaultRetentionType** | **string** | The default type of retention for newly created contact lists and contact list templates. Valid values: Never, Today, RetentionDays. | [optional] |
| **ContactListDefaultRetentionDays** | **int?** | The default number of days to retain newly created contact lists and contact list templates. Only applicable when retentionType is RetentionDays. | [optional] |
| **TimeZone** | **string** | The time zone for newly created lists&#39; retention when option Today is used; for example, Africa/Abidjan. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 273.0.0_
