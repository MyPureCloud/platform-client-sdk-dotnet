# WebDeploymentConfigurationVersionResponse

## ININ.PureCloudApi.Model.WebDeploymentConfigurationVersionResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The configuration version ID | [optional] |
| **Name** | **string** | The configuration version name | |
| **Version** | **string** | The version of the configuration | [optional] |
| **HeadlessMode** | [**WebDeploymentHeadlessMode**](WebDeploymentHeadlessMode) | Headless Mode Support which Controls UI components. When enabled, native UI components will be disabled and allows for custom-built UI. | [optional] |
| **Description** | **string** | The description of the configuration | [optional] |
| **Languages** | **List&lt;string&gt;** | A list of languages supported on the configuration required if the messenger is enabled | [optional] |
| **DefaultLanguage** | **string** | The default language to use for the configuration required if the messenger is enabled | [optional] |
| **CustomI18nLabels** | [**List&lt;CustomI18nLabels&gt;**](CustomI18nLabels) | The localization settings for homescreen app | [optional] |
| **Messenger** | [**MessengerSettings**](MessengerSettings) | The settings for messenger | [optional] |
| **Position** | [**PositionSettings**](PositionSettings) | The settings for position | [optional] |
| **SupportCenter** | [**SupportCenterSettings**](SupportCenterSettings) | The settings for knowledge portal (previously support center) | [optional] |
| **Cobrowse** | [**CobrowseSettings**](CobrowseSettings) | The settings for cobrowse | [optional] |
| **JourneyEvents** | [**JourneyEventsSettings**](JourneyEventsSettings) | The settings for journey events | [optional] |
| **AuthenticationSettings** | [**AuthenticationSettings**](AuthenticationSettings) | The settings for authenticated deployments | [optional] |
| **DateCreated** | **DateTime?** | The date the configuration version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date the configuration version was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DatePublished** | **DateTime?** | The date the configuration version was most recently published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LastModifiedUser** | [**AddressableEntityRef**](AddressableEntityRef) | A reference to the user who most recently modified the configuration version | [optional] |
| **CreatedUser** | [**AddressableEntityRef**](AddressableEntityRef) | A reference to the user who created the configuration version | [optional] |
| **PublishedUser** | [**AddressableEntityRef**](AddressableEntityRef) | A reference to the user who published the configuration version | [optional] |
| **Status** | **string** | The current status of the configuration version | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |



_PureCloudPlatform.Client.V2 215.1.0_
