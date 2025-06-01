# UnifiedCommunicationsIntegration

## ININ.PureCloudApi.Model.UnifiedCommunicationsIntegration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **UcIntegrationKey** | [**AddressableEntityRef**](AddressableEntityRef) | ucIntegrationKey | |
| **IntegrationPresenceSource** | **string** | integrationPresenceType | |
| **PbxPermission** | **string** | pbxPermission | |
| **Icon** | [**UCIcon**](UCIcon) | icon | |
| **BadgeIcons** | [**Dictionary&lt;string, UCIcon&gt;**](UCIcon) | badgeIcon | |
| **I10n** | [**Dictionary&lt;string, UCI10n&gt;**](UCI10n) | i10n | |
| **PolledPresence** | **bool?** | polledPresence | |
| **PollIntervalSec** | **int?** | pollIntervalSec | [optional] |
| **IncludeBadge** | **bool?** | includeBadge | [optional] |
| **UserPermissions** | **List&lt;string&gt;** | userPermissions | |
| **OauthScopes** | **List&lt;string&gt;** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 235.0.0_
