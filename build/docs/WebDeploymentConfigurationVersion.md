---
title: WebDeploymentConfigurationVersion
---
## ININ.PureCloudApi.Model.WebDeploymentConfigurationVersion

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The configuration version ID | [optional] |
| **Name** | **string** | The configuration version name | |
| **Version** | **string** | The version of the configuration | [optional] |
| **Description** | **string** | The description of the configuration | [optional] |
| **Languages** | **List&lt;string&gt;** | A list of languages supported on the configuration | [optional] |
| **DefaultLanguage** | **string** | The default language to use for the configuration | [optional] |
| **Messenger** | [**MessengerSettings**](MessengerSettings.html) | The settings for messenger | [optional] |
| **SupportCenter** | [**SupportCenterSettings**](SupportCenterSettings.html) | The settings for support center | [optional] |
| **Cobrowse** | [**CobrowseSettings**](CobrowseSettings.html) | The settings for cobrowse | [optional] |
| **JourneyEvents** | [**JourneyEventsSettings**](JourneyEventsSettings.html) | The settings for journey events | [optional] |
| **AuthenticationSettings** | [**AuthenticationSettings**](AuthenticationSettings.html) | The settings for authenticated deployments | [optional] |
| **DateCreated** | **DateTime?** | The date the configuration version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date the configuration version was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DatePublished** | **DateTime?** | The date the configuration version was most recently published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LastModifiedUser** | [**AddressableEntityRef**](AddressableEntityRef.html) | A reference to the user who most recently modified the configuration version | [optional] |
| **CreatedUser** | [**AddressableEntityRef**](AddressableEntityRef.html) | A reference to the user who created the configuration version | [optional] |
| **PublishedUser** | [**AddressableEntityRef**](AddressableEntityRef.html) | A reference to the user who published the configuration version | [optional] |
| **Status** | **string** | The current status of the configuration version | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


