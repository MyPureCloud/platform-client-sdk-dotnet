# UCIntegration

## ININ.PureCloudApi.Model.UCIntegration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **UcIntegrationKey** | **string** | ucIntegrationKey | |
| **IntegrationPresenceSource** | **string** | integrationPresenceType | |
| **PbxPermission** | **string** | pbxPermission | |
| **Icon** | [**UCIcon**](UCIcon) | icon | |
| **BadgeIcons** | [**Dictionary&lt;string, UCIcon&gt;**](UCIcon) | badgeIcon | |
| **I10n** | [**Dictionary&lt;string, UCI10n&gt;**](UCI10n) | i10n | |
| **PolledPresence** | **bool?** | polledPresence | |
| **UserPermissions** | **List&lt;string&gt;** | userPermissions | |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 252.1.0_
