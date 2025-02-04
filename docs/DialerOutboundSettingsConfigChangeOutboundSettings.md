# DialerOutboundSettingsConfigChangeOutboundSettings

## ININ.PureCloudApi.Model.DialerOutboundSettingsConfigChangeOutboundSettings

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **MaxCallsPerAgent** | **int?** | The maximum number of calls that can be placed per agent on any campaign | [optional] |
| **MaxLineUtilization** | **double?** | The maximum percentage of lines that should be used for Outbound, expressed as a decimal in the range [0.0, 1.0] | [optional] |
| **AbandonSeconds** | **double?** | The number of seconds used to determine if a call is abandoned | [optional] |
| **ComplianceAbandonRateDenominator** | **string** | The denominator to be used in determining the compliance abandon rate | [optional] |
| **AutomaticTimeZoneMapping** | [**DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings**](DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings) |  | [optional] |
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The UI-visible name of the object | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |



_PureCloudPlatform.Client.V2 226.0.0_
